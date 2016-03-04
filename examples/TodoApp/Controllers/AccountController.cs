using Luno;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TodoApp.ViewModels;
using Luno.Exceptions;
using TodoApp.Models;
using Luno.Models.User;
using TodoApp.Extensions;
using TodoApp.Helper;
using Luno.Models.Session;

namespace TodoApp.Controllers
{
	public class AccountController : BaseController
	{
		public AccountController(LunoClient lunoClient)
			 : base(lunoClient)
		{ }

		// GET: /Account/
		public async Task<IActionResult> Index()
		{
			var session = await SessionHelper.GetSessionAsync(this, LunoClient);
			if (session == null)
				return RedirectToAction("Index", "Home");

			return View(session.User);
		}

		// GET: /Account/
		public async Task<IActionResult> Create()
		{
			if (await SessionHelper.GetSessionAsync(this, LunoClient) != null)
				return RedirectToAction("Index", "Home");

			return View();
		}

		// POST: /Account/
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(RegisterViewModel model)
		{
			if (await SessionHelper.GetSessionAsync(this, LunoClient) != null)
				return RedirectToAction("Index", "Home");

			if (!ModelState.IsValid)
				return View(model);
			
			try
			{
				var user = await LunoClient.User.CreateAsync(new CreateUser<Profile>
				{
					Username = model.Username,
					Name = model.Name,
					Password = model.Password
				});
				var session = await LunoClient.Session.CreateAsync<SessionStorage, Profile>(new CreateSession<SessionStorage> { UserId = user.Id }, expand: new[] { "user" });
				HttpContext.Session.SetObjectAsJson("session", session);
			}
			catch (LunoApiException ex)
			{
				ModelState.AddModelError(string.Empty, ex.Message);
				return View(model);
			}

			return RedirectToAction("Index", "Home");
		}
	}
}

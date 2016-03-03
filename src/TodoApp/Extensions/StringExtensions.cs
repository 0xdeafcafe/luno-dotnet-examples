using System.Text;

namespace TodoApp.Extensions
{
	public static class StringExtensions
	{
		public static byte[] ToByteArray(this string val)
		{
			return Encoding.UTF8.GetBytes(val);
		}
	}
}

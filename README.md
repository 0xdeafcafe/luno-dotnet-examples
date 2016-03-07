# luno-dotnet-examples
[![Github Issues](https://img.shields.io/github/issues/0xdeafcafe/luno-dotnet-examples.svg?style=flat-square)](https://github.com/0xdeafcafe/luno-dotnet-examples/issues) 
[![Github Stars](https://img.shields.io/github/stars/0xdeafcafe/luno-dotnet-examples.svg?style=flat-square)](https://github.com/0xdeafcafe/luno-dotnet-examples/stargazers) 
[![Github License](https://img.shields.io/github/license/0xdeafcafe/luno-dotnet-examples.svg?style=flat-square)](https://github.com/0xdeafcafe/luno-dotnet-examples/blob/master/LICENSE)

Example projects for using the Luno DotNet library.

### Setting up dotnet
To get started, you'll probably need to install dotnet. This is actually easy now, so just visit one of the following pages depending on which OS you're running: [Windows](https://docs.asp.net/en/latest/getting-started/installing-on-windows.html), [OSX](https://docs.asp.net/en/latest/getting-started/installing-on-mac.html), or [Linux](https://docs.asp.net/en/latest/getting-started/installing-on-linux.html). None of the example projects require mono, so you can use the `coreclr` runtime.

### Running an example project
```bash
$ git clone git@github.com:0xdeafcafe/luno-dotnet-examples.git
$ cd luno-dotnet-examples\examples
$ cd example_name # choose the example you want to use
$ dnu restore
$ dnu build
$ dnx web # before running this command, edit the config.json file to include your luno api keys
```

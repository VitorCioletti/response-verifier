<p align="center" >
    <a>
        <img href="http://www.freepik.com" alt="logo" src="Doc/Image/bird.png" width="150" height="150">
    </a>
</p>

# Response Verifier

[![][build-img]][build]
[![][nuget-img]][nuget]

Simple .NET and .NET Core package to verify HTTP status code response groups.

Nuget CLI: `install-package`

Dotnet: `dotnet add` 

[build]:     https://ci.appveyor.com/project/VitorCioletti/curse-io
[build-img]: https://ci.appveyor.com/api/projects/status/nv34gc8sm0ds2cxj?svg=true

[nuget]:     https://www.nuget.org/packages/Curse-IO/
[nuget-img]: https://badge.fury.io/nu/curse-io.svg


This package was made to simplify HTTP response verification. Instead of checking integer value ranges, just call one of the extension methods this library provides.

## Usage

Do this: 

```cs
var response = client.Execute(request);

if (response.StatusCode.IsFromSuccessfulResponse())
    // Happy ending :)
else
    // Sad ending :(
```

Instead of this:

```cs
var response = client.Execute(request);

var statusCode = (int)response.StatusCode;

if (statusCode >= 200 && statusCode < 300)
    // Happy ending :)
else
    // Sad ending :(
```

## Provided extenion methods

- `.IsFromInformationalResponse()`
- `.IsFromSucessfulResponse()`
- `.IsFromRedirectionResponse()`
- `.IsFromClientErrorResponse()`
- `.IsFromServerErrorResponse()`


<p align="center">
    <a href="http://creativecommons.org/licenses/by/4.0/">
        <img alt="logo" src="http://i.creativecommons.org/l/by/4.0/80x15.png">
    </a>
</p>
<p align="center">Creative Commons 4.0 International</p>



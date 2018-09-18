<p align="center" >
    <a href="https://www.flaticon.com/free-icon/bird_212800#"> 
        <img alt="logo" src="Doc/Image/bird.png" width="150" height="150">
    </a>
</p>

# Response Verifier
Simple .NET and .NET Core package to verify HTTP status code response groups.

[![][build-img]][build]
[![][nuget-img]][nuget]


 Package manager: `Install-Package ResponseVerifier`

.NET CLI: `dotnet add package ResponseVerifier` 

[build]:     https://ci.appveyor.com/project/VitorCioletti/response-verifier
[build-img]: https://ci.appveyor.com/api/projects/status/pj04auhuml85byls?svg=true

[nuget]:     https://www.nuget.org/packages/ResponseVerifier/
[nuget-img]: https://badge.fury.io/nu/ResponseVerifier.svg


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

## Provided extension methods

- `.IsFromInformationalResponse()`
- `.IsFromSuccessfulResponse()`
- `.IsFromRedirectionResponse()`
- `.IsFromClientErrorResponse()`
- `.IsFromServerErrorResponse()`


## Using it with [WhenResponse](https://github.com/nikolasmagno/WhenResponse)

Just a simple library to make response treatment clean and fluent.

```cs
var client = new RestClient("https://httpstat.us/");
var request = new RestRequest("202?sleep=2000", Method.GET);
          
// execute the request
IRestResponse response = client.Execute(request);
response.When((r)=> r.StatusCode.StatusCode.IsFromSuccessfulResponse(),(r)=> System.Console.WriteLine("Ok"))        
        .When((r)=> !r.StatusCode.StatusCode.IsFromSuccessfulResponse(),(r)=> Assert.Fail("Fail"));
```
<p align="center">
    <a href="http://creativecommons.org/licenses/by/4.0/">
        <img alt="logo" src="http://i.creativecommons.org/l/by/4.0/80x15.png">
    </a>
</p>
<p align="center">Creative Commons 4.0 International</p>



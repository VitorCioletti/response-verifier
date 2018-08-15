# Response Verifier
Simple .NET and .NET Core package to verify HTTP status code response groups.

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

# Provided extenion methods

- `.IsFromInformationalResponse()`
- `.IsFromSucessfulResponse()`
- `.IsFromRedirectionResponse()`
- `.IsFromClientErrorResponse()`
- `.IsFromServerErrorResponse()`


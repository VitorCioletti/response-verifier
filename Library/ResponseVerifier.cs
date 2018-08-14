namespace ResponseVerifier
{
    using System.Net;

    public static class ResponseVerifier
    {
        public static bool IsFromInformationalResponse(this HttpStatusCode statusCode) =>
            IsFrom(StatusCodeGroup.Informational,statusCode);

        public static bool IsFromSucessfulResponse(this HttpStatusCode statusCode) =>
            IsFrom(StatusCodeGroup.Successful, statusCode);

        public static bool IsFromRedirectionResponse(this HttpStatusCode statusCode) =>
            IsFrom(StatusCodeGroup.Redirection, statusCode);

        public static bool IsFromClientErrorResponse(this HttpStatusCode statusCode) =>
            IsFrom(StatusCodeGroup.ClientError,statusCode);

        public static bool IsFromServerErrorResponse(this HttpStatusCode statusCode) =>
            IsFrom(StatusCodeGroup.ServerError, statusCode);
            
        private static bool IsFrom(StatusCodeGroup family, HttpStatusCode statusCode)
        {
            switch (family)
            {
                case StatusCodeGroup.Informational:
                    return CheckValueRange((int)statusCode, 100, 200);

                case StatusCodeGroup.Successful:
                    return CheckValueRange((int)statusCode, 200, 300);

                case StatusCodeGroup.Redirection:
                    return CheckValueRange((int)statusCode, 300, 400);

                case StatusCodeGroup.ClientError:
                   return CheckValueRange((int)statusCode, 400, 500);

                case StatusCodeGroup.ServerError:
                    return CheckValueRange((int)statusCode, 500, 600);
            }

            return false;
        }

        private static bool CheckValueRange(int statusCode, int minimumAndEqual, int maximumAndMinor) =>
            statusCode >= minimumAndEqual && statusCode < maximumAndMinor;
    }
}
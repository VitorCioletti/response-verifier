namespace ResponseVerifier
{
    using System.Net;

    public static class ResponseVerifier
    {

        /// <summary>
        /// Verify if the current HTTP status is equal/over than 100 and lower than 200
        /// </summary>
        public static bool IsFromInformationalResponse(this HttpStatusCode statusCode) =>
            IsFrom(StatusCodeGroup.Informational,statusCode);

        /// <summary>
        /// Verify if the current HTTP status is equal/over than 200 and lower than 300
        /// </summary>
        public static bool IsFromSucessfulResponse(this HttpStatusCode statusCode) =>
            IsFrom(StatusCodeGroup.Successful, statusCode);

        /// <summary>
        /// Verify if the current HTTP status is equal/over than 300 and lower than 400
        /// </summary>
        public static bool IsFromRedirectionResponse(this HttpStatusCode statusCode) =>
            IsFrom(StatusCodeGroup.Redirection, statusCode);

        /// <summary>
        /// Verify if the current HTTP status is equal/over than 400 and lower than 500
        /// </summary>
        public static bool IsFromClientErrorResponse(this HttpStatusCode statusCode) =>
            IsFrom(StatusCodeGroup.ClientError,statusCode);

        /// <summary>
        /// Verify if the current HTTP status is equal/over than 500 and lower than 600
        /// </summary>
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
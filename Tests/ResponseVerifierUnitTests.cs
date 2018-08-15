namespace ResponseVerifier.UnitTests
{
    using System.Net;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ResponseVerifierUnitTests
    {
        [TestMethod]
        public void InformationalContinue() =>
            Assert.IsTrue(HttpStatusCode.Continue.IsFromInformationalResponse());

        [TestMethod]
        public void InformationalSwitchingProtocols() =>
            Assert.IsTrue(HttpStatusCode.SwitchingProtocols.IsFromInformationalResponse());

        [TestMethod]
        public void SuccessfulOK() =>
            Assert.IsTrue(HttpStatusCode.OK.IsFromSucessfulResponse());

        [TestMethod]
         public void SuccessfulCreated() =>
            Assert.IsTrue(HttpStatusCode.Created.IsFromSucessfulResponse());

        [TestMethod]
         public void SuccessfulAccepted() =>
            Assert.IsTrue(HttpStatusCode.Accepted.IsFromSucessfulResponse());

        [TestMethod]
         public void SuccessfulNonAuthoritativeInformation() =>
            Assert.IsTrue(HttpStatusCode.NonAuthoritativeInformation.IsFromSucessfulResponse());

        [TestMethod]
        public void RedirectionMultipleChoices() =>
            Assert.IsTrue(HttpStatusCode.MultipleChoices.IsFromRedirectionResponse());

        [TestMethod]
        public void RedirectionMovedPermanently() =>
            Assert.IsTrue(HttpStatusCode.MovedPermanently.IsFromRedirectionResponse());

        [TestMethod]
        public void RedirectionFound() =>
            Assert.IsTrue(HttpStatusCode.Found.IsFromRedirectionResponse());

        [TestMethod]
        public void RedirectionNotModified() =>
            Assert.IsTrue(HttpStatusCode.NotModified.IsFromRedirectionResponse());

        [TestMethod]
        public void ClientErrorBadRequest() =>
            Assert.IsTrue(HttpStatusCode.BadRequest.IsFromClientErrorResponse());

        [TestMethod]
        public void ClientErrorUnauthorized() =>
            Assert.IsTrue(HttpStatusCode.Unauthorized.IsFromClientErrorResponse());

        [TestMethod]
        public void ClientErrorPaymentRequired() =>
            Assert.IsTrue(HttpStatusCode.PaymentRequired.IsFromClientErrorResponse());

        [TestMethod]
        public void ClientErrorForbidden() =>
            Assert.IsTrue(HttpStatusCode.Forbidden.IsFromClientErrorResponse());
            
        [TestMethod]
        public void ServerErrorInternalServerError() =>
            Assert.IsTrue(HttpStatusCode.InternalServerError.IsFromServerErrorResponse());    

        [TestMethod]
        public void ServerErrorNotImplemented() =>
            Assert.IsTrue(HttpStatusCode.NotImplemented.IsFromServerErrorResponse());    

        [TestMethod]
        public void ServerErrorBadGateway() =>
            Assert.IsTrue(HttpStatusCode.BadGateway.IsFromServerErrorResponse());    

        [TestMethod]
        public void ServerErrorServiceUnavailable() =>
            Assert.IsTrue(HttpStatusCode.ServiceUnavailable.IsFromServerErrorResponse());        
    }
}

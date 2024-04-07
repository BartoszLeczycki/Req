using NUnit.Framework;
using Rekrutacja_AQA.PageObjects;

namespace Rekrutacja_AQA.Tests
{
    [TestFixture]
    public class Tests : TestSettings
    {
        private ForexHome _forexHome;
        private Trustpilot _trustpilot;

        [Test]
        public void CheckForexRating([Values(4.7)] int rating)
        {
            _forexHome.GoToTrustpilotPage()
                    .AcceptTrustModal();

            Assert.IsTrue(_trustpilot.IsRatingCorrect(rating));
        }
    }
}
using System.Globalization;

namespace Rekrutacja_AQA.Helpers
{
    public static class ParseHelper
    {
        public static bool AreDoublesEqual(double value1, double value2, double tolerance)
        {
            return Math.Abs(value1 - value2) <= tolerance;
        }

        public static double ParseStringToDouble(string value)
        {
            return double.Parse(value, CultureInfo.InvariantCulture);
        }
    }
}

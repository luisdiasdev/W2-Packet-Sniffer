using System.Text.RegularExpressions;

namespace W2.PacketSniffer
{
    /// <summary>
    /// Represents an IPV4 address validator
    /// </summary>
    public class AddressValidator
    {
        private static readonly Regex validIpV4AddressRegex =
                new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$",
                    RegexOptions.IgnoreCase);

        public static bool Validate(string value)
        {
            if (value == null)
                return false;

            if (string.IsNullOrWhiteSpace(value))
                return false;

            return validIpV4AddressRegex.IsMatch(value);
        }
    }
}

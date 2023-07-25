using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string website)
        {
            if (!ValidateUrl(website))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {website}!";
        }

        public string Call(string number)
        {
            if (!ValidatePhoneNumber(number))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {number}";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
       => phoneNumber.All(c => char.IsDigit(c));

        private bool ValidateUrl(string url)
        => url.All(c => !char.IsDigit(c));
    }
}

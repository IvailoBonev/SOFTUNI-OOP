using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (!ValidatePhoneNumber(number))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Dialing... {number}";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
       => phoneNumber.All(c => char.IsDigit(c));
    }
}

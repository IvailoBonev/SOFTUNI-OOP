using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BorderControl
{
    public interface IBuyer
    {
        public void BuyFood();
        public int Food { get; }
    }
}

using System;

namespace AbsoluteCalculator.Service
{
    public class AbsoluteNumberCalulator
    {
        public int FindAbsolute(int number)
        {
            //throw new Exception();
            if (number < 0)
                return -number;
            return number;
        }
    }
}

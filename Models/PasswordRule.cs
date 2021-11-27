using System;
using System.Collections.Generic;
using System.Text;

namespace AOC2020.Models
{
    public class PasswordRule
    {
        public PasswordRule(char character, int lowLimit, int highLimit)
        {
            Character = character;
            LowLimit = lowLimit;
            HighLimit = highLimit;
        }

        public char Character { get; set; }
        public int LowLimit {  get; set; }
        public int HighLimit { get; set; }
    }
}

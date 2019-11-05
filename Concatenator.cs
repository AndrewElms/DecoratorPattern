using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Concatenator : IConcatenator
    {   
        public string Concatenate(string s1, string s2)
        {
            return string.Concat(s1, s2);
        }
    }
}

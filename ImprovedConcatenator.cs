using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ImprovedConcatenator: DecoratedConcatenator
    {
        // This constructor needs to match the one in the DecoratedConstruct, except we will also add the base class to it.
        public ImprovedConcatenator(Concatenator concatenator): base(concatenator)
        {
        }

        public override string Concatenate(string s1, string s2)
        {
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();
            
            return base.Concatenate(s1, s2);
        }
    }
}

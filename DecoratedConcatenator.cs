using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{    
    // Inherits from the original Concatenator base class
    // Creates a virtual version of the Concatenate() method so it can be overriden but its implementation just uses the orginal base classes implementation
    // Note that the abstract class inherits from the base Concatenator class (because it has the implementation of Concatenate that we want to run)
    //      and also expects an instance of the base class to be passed into its constructor (because we need to still be able to call the base Concatenate method)
    public abstract class DecoratedConcatenator : Concatenator
    {
        private readonly Concatenator _concatenator;

        // Must pass the base Concatenator object instance into this constructor so we can still call the base Concatenators Concatenate method
        public DecoratedConcatenator(Concatenator concatenator)
        {
            _concatenator = concatenator;
        }

        // Note that this method is still calling the base Concatenators Concatenate method to do the concatenation of the two strings
        public virtual string Concatenate(string s1, string s2)
        {
           return _concatenator.Concatenate(s1, s2);
        }
    }
}

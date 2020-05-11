using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id) : base(id) { }
        public override Prototype Clone()
        {
            return this.MemberwiseClone() as ConcretePrototype2;
        }
    }
}

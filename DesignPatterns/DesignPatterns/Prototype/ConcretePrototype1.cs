using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id) : base(id) { }
        public override Prototype Clone()
        {
            return this.MemberwiseClone() as ConcretePrototype1;
        }
    }
}

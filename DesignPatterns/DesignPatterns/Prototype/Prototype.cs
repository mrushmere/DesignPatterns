using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public abstract class Prototype
    {
        public Prototype(int id)
        {
            Id = id;
        }
        public int Id { get; }

        public abstract Prototype Clone();
    }
}

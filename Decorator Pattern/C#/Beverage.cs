using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal abstract class Beverage()
    {
        public enum Size { TALL,GRANDE,VENTI}

        protected string Description = "Unknown Beverage";

        public Size Ssize { get; set; } = Size.TALL;

        public virtual string GetDescription()
        {
            return this.Description;
        }
        
        public abstract double Cost();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class FakerMethodAttribute : Attribute
    {
        public FakerMethodAttribute(string fakerName)
        {
            this.FakerMethodName = fakerName;
        }
        public string FakerMethodName { get; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class FakerPropertyAttribute : Attribute
    {
        //public FakerPropertyAttribute()
        //{
        //    this.FakerMethodName = fakerName;
        //}
        //public string FakerMethodName { get; }
    }
}

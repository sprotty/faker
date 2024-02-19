﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false)]
    public class FakerMethodAttribute : Attribute
    {
        public FakerMethodAttribute(string fakerName = null)
        {
            this.FakerMethodName = fakerName;
        }
        public string FakerMethodName { get; }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class FakerGeneratorAttribute : Attribute
    {
        public FakerGeneratorAttribute(string fakerGeneratorName )
        {
            this.FakerGeneratorName = fakerGeneratorName.ToLower();
        }
        public string FakerGeneratorName { get; }
    }

}

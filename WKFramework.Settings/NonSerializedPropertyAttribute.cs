﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKFramework.Settings
{
    [AttributeUsageAttribute(AttributeTargets.Property, Inherited = false)]
    public sealed class NonSerializedPropertyAttribute : Attribute
    {
    }
}

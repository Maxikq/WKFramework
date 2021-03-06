﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKFramework.Utils.Serializer
{
    public interface ISerializer
    {
        object Serialize(object obj);

        object Deserialize(object obj);
    }

    public interface ISerializer<TSerialized> : ISerializer
    {
        new TSerialized Serialize(object obj);

        TResult Deserialize<TResult>(TSerialized obj);
    }
}

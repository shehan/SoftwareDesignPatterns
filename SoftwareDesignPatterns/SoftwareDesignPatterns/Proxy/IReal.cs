﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Proxy
{
    public interface IReal
    {
        void ProcessRequest(string message);
    }
}

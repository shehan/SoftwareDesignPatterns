﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Adapter
{
    public interface IAdapter
    {
        void ConvertToDigital(Analog data);
    }
}

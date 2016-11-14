﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Factory
{
    public interface IFoodFactory
    {
        IFood OrderFood(string type);
    }
}

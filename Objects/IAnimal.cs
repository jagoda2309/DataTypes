﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public interface IAnimal
    {
        string Name { get; set; }
        int GetLegs();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopStorage.StorageClasses
{
    interface IProduct
    {
        string Name { get; set; }
        int SKU { get; set; }
        string Definition { get; set; }
        decimal Price { get; set; }
        string Type { get; set; }
        string Unit { get; set; }

    }
}
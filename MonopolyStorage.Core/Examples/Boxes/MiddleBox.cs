﻿using MonopolyStorage.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyStorage.Core.Examples.Boxes
{
    public class MiddleBox : Box
    {
        public MiddleBox(int id, double width, double height, double depth, double weight) : base(id, width, height, depth, weight)
        {

        }
    }
}
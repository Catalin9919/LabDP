﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AlignLeft : AlignStrategy
    {
        public void Print(string Text)
        {
            Console.WriteLine($"{Text}+++++");
        }
    }
}
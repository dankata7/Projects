﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
  
        class SumEvenNumbers
        {
            static void Main(string[] args)
            {
                int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            }
        }
    }


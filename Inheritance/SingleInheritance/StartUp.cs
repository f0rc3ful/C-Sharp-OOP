﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class StartUp
    {
        static void Main()
        {
            Puppy pup = new Puppy();
            pup.Bark();
            pup.Eat();
            pup.Weep();
        }
    }
}

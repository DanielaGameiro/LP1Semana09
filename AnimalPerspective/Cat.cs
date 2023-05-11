﻿using System;

namespace AnimalPerspective
{
    public class Cat : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }

        public int NumberOfNipples => 6;
    }
}

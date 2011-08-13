using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class FordFiestaBuilder : CarBuilder
    {
        public FordFiestaBuilder()
        {
            Make("Ford");
            Model("Fiesta");
        }
    }
}

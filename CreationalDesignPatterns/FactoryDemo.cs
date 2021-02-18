using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns
{
    
        public enum AreaDesign
        {
            Rectangle,
            Square
        }



        public class FactoryDemo
        {
            private int x;
            private int y;


            private FactoryDemo(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return $"{nameof(x)}:{x} , {nameof(y)}: {y}";
            }

         public static class AreaFactory                              // We make AreaFactory as Inner class of FactoryDemo to make FactoryDemo constructor as Private (before it is outside of FactortDemo clasd)
        {
            public static FactoryDemo AreaRectangle(int x, int y)     //Factory Method
            {
                return new FactoryDemo(x, y);
            }

            public static FactoryDemo AreaSquare(int PI, int r)     //Factory Method
            {
                return new FactoryDemo(PI, (r * r));
            }
        }

    }
    }


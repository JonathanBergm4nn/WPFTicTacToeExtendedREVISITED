using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace BIZ
{
    public class ClassCountDrawAndRegister : ClassNotify
    {

        public ClassCountDrawAndRegister()
        {
            intX = 0;
            intO = 0;
            intScoreCountX = 0;
            intScoreCountO = 0;
            InitialiseArray();
        }

        protected string[,] strSignPlacement = new string[3, 3];

        protected int intX { get; set; }

        protected int intO { get; set; }

        protected int intScoreCountX { get; set; }

        protected int intScoreCountO { get; set; }



        protected void InitialiseArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    strSignPlacement[i, x] = "";
                }
            }
        }



    }
}

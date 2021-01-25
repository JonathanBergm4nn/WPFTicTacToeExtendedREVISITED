using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace BIZ
{
    public class ClassCheckForWinner : ClassCountDrawAndRegister
    {

        public ClassCheckForWinner()
        {

        }

        /// <summary>
        /// Check if the current player has a winning position by checking it against the array of possible winning positions
        /// </summary>
        /// <param name="strSign">string</param>
        /// <returns>boolean</returns>
        protected bool CheckNewDraw(string strSign)
        {
            bool bolRes = false;
            string strWinner = strSign + strSign + strSign;
            string[] strFacit = new string[8];
            strFacit[0] = strSignPlacement[0, 0] + strSignPlacement[0, 1] + strSignPlacement[0, 2];
            strFacit[1] = strSignPlacement[1, 0] + strSignPlacement[1, 1] + strSignPlacement[1, 2];
            strFacit[2] = strSignPlacement[2, 0] + strSignPlacement[2, 1] + strSignPlacement[2, 2];
            strFacit[3] = strSignPlacement[0, 0] + strSignPlacement[1, 0] + strSignPlacement[2, 0];
            strFacit[4] = strSignPlacement[0, 1] + strSignPlacement[1, 1] + strSignPlacement[2, 1];
            strFacit[5] = strSignPlacement[0, 2] + strSignPlacement[1, 2] + strSignPlacement[2, 2];
            strFacit[6] = strSignPlacement[0, 0] + strSignPlacement[1, 1] + strSignPlacement[2, 2];
            strFacit[7] = strSignPlacement[0, 2] + strSignPlacement[1, 1] + strSignPlacement[2, 0];

            for (int i = 0; i <= 7; i++)
            {
                if (strFacit[i] == strWinner)
                {
                    bolRes = true;
                    UpdateScore(strSign);
                }
            }
            return bolRes;
        }


        /// <summary>
        /// Updates the score of the player that won for use in yet to e implemented for persistent saves
        /// </summary>
        /// <param name="inSign"></param>
        private void UpdateScore(string inSign)
        {
            if (inSign == "X")
            {
                intScoreCountX++;
            }
            else
            {
                intScoreCountO++;
            }
        }



    }
}

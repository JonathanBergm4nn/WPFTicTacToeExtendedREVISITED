using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace BIZ
{
    public class ClassTextBoxHandler : ClassCheckForWinner
    {

        private string _gridColor;
        private string _actualSign;



        public ClassTextBoxHandler()
        {
            classTextBoxCollection = new ClassTextBoxCollection();
            gridColor = "Blue";
            
        }

        public ClassTextBoxCollection classTextBoxCollection { get; set; }


        

        public string gridColor
        {
            get { return _gridColor; }
            set
            {
                if (_gridColor != value)
                {
                    //checks whose turn it is, if the colour isn't blue it's O's turn.
                    _gridColor = value;
                    if (_gridColor == "Blue")
                    {
                        actualSign = "X";
                    }
                    else
                    {
                        actualSign = "O";
                    }
                }
                Notify("gridColor");
            }
        }


        
        public string actualSign
        {
            get { return _actualSign; }
            private set { _actualSign = value; }
        }


        /// <summary>
        /// Receives coordinates of user clicks and depending on the current colour of the board, assigns an X or O to the textbox
        /// also makes sure that a player can not put anymore than 3 signs on the board, forcing them on their fourth move to remove one of their signs to continue.
        /// this loop continues untill there is a winner.
        /// </summary>
        /// <param name="boxID">string</param>
        /// <returns>bool</returns>
        public bool RegTextBoxClick(string boxID)
        {
            bool bolRes = false;
            string[] arrayKey = boxID.Split(',');               // Split; Splits the string boxID into a one dimensional array
            int xCord = Convert.ToInt32(arrayKey[0]);           // Int value for the X cordinate on the array
            int yCord = Convert.ToInt32(arrayKey[1]);           // Int value for the Y cordinate on the array

            
            if (strSignPlacement[xCord, yCord] == "" && CheckNumberOfSigns() < 3)       //Condition for that signs placed needs to be empty and the total number of signs be less than 3
            {
                strSignPlacement[xCord, yCord] = actualSign;                            
                UpdateNumberOfSignsAdd();       

                classTextBoxCollection.SetSign(boxID, actualSign);                      
                

                
                if (CheckNumberOfSigns() == 3)
                {
                    if (CheckNewDraw(actualSign) == true)                               // Checks if player has won
                    {
                        bolRes = true;
                    }
                }

                
                if (bolRes == false)
                {
                    SetColor();                                                     // Call to method, to change player turn
                }

            }

            else
            {
                //Since a player has not won yet, and there's 3 signs placed, a player must remove a sign, in order to continue the game, and then place another again.
                if (CheckNumberOfSigns() == 3)                                  
                {
                    if (strSignPlacement[xCord, yCord] == actualSign)               
                    {
                        strSignPlacement[xCord, yCord] = "";
                        UpdateNumberOfSignsRemove();
                        classTextBoxCollection.SetSign(boxID, "");
                    }
                }
            }

            return bolRes;
        }


        /// <summary>
        /// Method to show, whose turn it is. 
        /// </summary>
        private void SetColor()
        {
            if (gridColor == "Blue")
            {
                gridColor = "Red";
            }
            else
            {
                gridColor = "Blue";
            }
        }

        /// <summary>
        /// Method that checks how many signs there are for each player, then returns the value in an Interger.
        /// </summary>
        /// <returns>interger</returns>

        private int CheckNumberOfSigns() 
        {
            int intRes = 0;

            if (actualSign == "X") 
            {
                intRes = intX;
            }
            else
            {
                intRes = intO;
            }

            return intRes; 
        }


        /// <summary>
        /// Method to add a sign, depending on player turn.
        /// </summary>
        private void UpdateNumberOfSignsAdd()
        {
            if (actualSign == "X")
            {
                intX++;
            }
            else
            {
                intO++;
            }
        }


        /// <summary>
        /// Method to remove a sign depending on player turn
        /// </summary>
        private void UpdateNumberOfSignsRemove()
        {
            if (actualSign == "X")
            {
                intX--;
            }
            else
            {
                intO--;
            }
        }


        /// <summary>
        /// Method that resets the board, clearing all signs on the gamepad
        /// </summary>
        public void ResetAll()
        {
            InitialiseArray();
            classTextBoxCollection.InitialiseTextBox();
            gridColor = "Blue";
            intO = 0;
            intX = 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassTextBoxCollection : ClassNotify
    {

        private string _textBox00;
        private string _textBox01;
        private string _textBox02;
        private string _textBox10;
        private string _textBox11;
        private string _textBox12;
        private string _textBox20;
        private string _textBox21;
        private string _textBox22;

        public ClassTextBoxCollection()
        { 
            InitialiseTextBox(); //initialising the method
        }


        /// <summary>
        /// Places the current sign in the selected textbox via a switch statement
        /// a switch statement is  away of writing a lot of if statements in a more efficient way
        /// </summary>
        /// <param name="inKey"></param>
        /// <param name="inSign"></param>

        public void SetSign(string inKey, string inSign)
        {
            switch (inKey)
            {
                case "0,0":
                    textBox00 = inSign;
                    break;
                case "0,1":
                    textBox01 = inSign;
                    break;
                case "0,2":
                    textBox02 = inSign;
                    break;
                case "1,0":
                    textBox10 = inSign;
                    break;
                case "1,1":
                    textBox11 = inSign;
                    break;
                case "1,2":
                    textBox12 = inSign;
                    break;
                case "2,0":
                    textBox20 = inSign;
                    break;
                case "2,1":
                    textBox21 = inSign;
                    break;
                case "2,2":
                    textBox22 = inSign;
                    break;

                default:
                    break;
            }
        }

        //whole lot of properties
        #region textbox properties
        public string textBox00
        {
            get { return _textBox00; }
            set
            {
                if (_textBox00 != value)
                {
                    _textBox00 = value;
                }
                Notify("textBox00");
            }
        }

        public string textBox01
        {
            get { return _textBox01; }
            set
            {
                if (_textBox01 != value)
                {
                    _textBox01 = value;
                }
                Notify("textBox01");
            }
        }

        public string textBox02
        {
            get { return _textBox02; }
            set
            {
                if (_textBox02 != value)
                {
                    _textBox02 = value;
                }
                Notify("textBox02");
            }
        }

        public string textBox10
        {
            get { return _textBox10; }
            set
            {
                if (_textBox10 != value)
                {
                    _textBox10 = value;
                }
                Notify("textBox10");
            }
        }

        public string textBox11
        {
            get { return _textBox11; }
            set
            {
                if (_textBox11 != value)
                {
                    _textBox11 = value;
                }
                Notify("textBox11");
            }
        }

        public string textBox12
        {
            get { return _textBox12; }
            set
            {
                if (_textBox12 != value)
                {
                    _textBox12 = value;
                }
                Notify("textBox12");
            }
        }

        public string textBox20
        {
            get { return _textBox20; }
            set
            {
                if (_textBox20 != value)
                {
                    _textBox20 = value;
                }
                Notify("textBox20");
            }
        }

        public string textBox21
        {
            get { return _textBox21; }
            set
            {
                if (_textBox21 != value)
                {
                    _textBox21 = value;
                }
                Notify("textBox21");
            }
        }

        public string textBox22
        {
            get { return _textBox22; }
            set
            {
                if (_textBox22 != value)
                {
                    _textBox22 = value;
                }
                Notify("textBox22");
            }
        }
        #endregion


        /// <summary>
        /// Initialises the textboxes with an empty string avoiding their value to be null.
        /// </summary>

        public void InitialiseTextBox()
        {
            textBox00 = "";
            textBox01 = "";
            textBox02 = "";
            textBox10 = "";
            textBox11 = "";
            textBox12 = "";
            textBox20 = "";
            textBox21 = "";
            textBox22 = "";
        }

    }
}

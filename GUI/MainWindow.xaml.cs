using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BIZ;
using Repository;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassTextBoxHandler CTBH;
        public MainWindow()
        {
            InitializeComponent();
            CTBH = new ClassTextBoxHandler();
            MainGrid.DataContext = CTBH;
        }


        /// <summary>
        /// Laver en instanse af den textbox der er blevet double clicket på, fra den instance 
        /// sendes der tag værdien til metoden RegTextBoxClick.
        /// Svaret fra denne metode, som er en bolsk værdi, afgører om der er fundet en vinder efter tegnet er sat.
        /// Hvis der er en vinder åbnes Usercontrollen der viser vinderen.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">MouseButtonEventArgs</param>
        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (CTBH.RegTextBoxClick(textBox.Tag.ToString()))
            {
                UserControlWinner UCW = new UserControlWinner(CTBH.actualSign, this.WinnerGrid);
                WinnerGrid.Children.Add(UCW);
                CTBH.ResetAll();

            }
        }


    }
}

using LoreSoft.MathExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using System.Windows.Shapes;

namespace ScientificCalc
{
    /// <summary>
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Window
    {
        public DisplayControl play;
        public History(DisplayControl display)
        {
            play = display;
            InitializeComponent();
        }
        

        public void historyContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (!Global.historyClean)
            {
                Test.Text = historyContent.SelectedItem.ToString().Substring(historyContent.SelectedItem.ToString().IndexOf("=") + 1);
                // play.Text = Test.Text;
                TextBox textTest = new TextBox(); ;
                textTest.Text = historyContent.SelectedItem.ToString().Substring(0, historyContent.SelectedItem.ToString().IndexOf("="));
                Global.expressionReturn = textTest.Text;

            }
            else
            {
                Test.Text = "";
            }
        }

      
    }
}
    
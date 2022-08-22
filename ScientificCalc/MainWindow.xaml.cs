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
using System.ComponentModel;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using LoreSoft.MathExpressions;
namespace ScientificCalc
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private DisplayControl DisplayControl = new DisplayControl();
        private History history;

        public bool isShowingError = false;
        public int mode = 0;
        public MainWindow()
        {
            history = new History(DisplayControl);
            history.Show();
            InitializeComponent();
            hideScientific();
            hideProgramming();
            mod.IsEnabled = true;

        }


        public string _display;
        public string Display
        {
            get { return _display; }
            set
            {
                if (string.Equals(value, _display))
                    return;
                _display = value;
                OnPropertyChanged("Display");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ButtonPressed(string NewValue, bool IsNewTerm = false, string Operation = "")
        {
            if (this.isShowingError)
                toggleErrorDisplay();

            
          /*  if (this.DisplayControl.Text.Length < 15)
            {*/
                this.DisplayControl.Update(NewValue: NewValue, IsNewTerm: IsNewTerm, Operation: Operation);
                this.Display = this.DisplayControl.Text;
            //}
           
                
        }

        private void EvaluateExpression()
        {
            try
            {
                this.DisplayControl.Evaluate();
                this.Display = this.DisplayControl.Text;
            }
            catch (LoreSoft.MathExpressions.ParseException e)
            {
                Console.WriteLine("Invalid expression: {0}", e);
                this.toggleErrorDisplay();
            }
        }

        public void toggleErrorDisplay()
        {
            if (isShowingError)
            {
                errorDisplay.Opacity = 0.0;
                this.isShowingError = false;
            }
            else
            {
                errorDisplay.Opacity = 1.0;
                this.isShowingError = true;
            }

        }


        public void Squared_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "^(2)");
        }

        public void XToTheY_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "^");
        }

        public void Sin_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "sin(");
        }

        public void Cos_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "cos(");
        }


        public void Tan_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "tan(");
        }

        public void SquareRoot_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "sqrt(");
        }

        public void TenToX_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "10^");
        }

        public void Log_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "log10(");
        }

        public void Ln_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "log(");
        }

        public void Mod_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "/100");
            EvaluateExpression();
        }

        public void CE_Click(object sender, RoutedEventArgs e)
        {
            this.Display = "0";
            Global.historyClean = true;
            history.historyContent.Items.Clear();
            Global.historyClean = false;
            this.DisplayControl.Clear();
        }

        public void C_Click(object sender, RoutedEventArgs e)
        {
            this.Display = "0";
            this.DisplayControl.Clear();
        }

        public void Back_Click(object sender, RoutedEventArgs e)
        {
            if(DisplayControl.Text.Length!=0)
            {
                this.ButtonPressed(NewValue: "BACKSPACE");
            }
          
        }

        public void Div_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "/");
        }

        public void Pi_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "pi");
        }

        public void Seven_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "7");
        }

        public void Eight_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "8");
        }

        public void Nine_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "9");
        }

        public void Mult_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "*");
        }



        public void Four_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "4");
        }

        public void Five_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "5");
        }

        public void Six_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "6");
        }

        public void Minus_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "-", IsNewTerm: true);
        }

        public void One_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "1");
        }

        public void Two_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "2");
        }

        public void Three_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "3");
        }

        public void Plus_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "+", IsNewTerm: true);
        }

        public void Open_par_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "(");
        }

        public void Close_par_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: ")");
        }

        public void Zero_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "0");
        }

        public void Decimal_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: ".");
        }

        public  void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0)
            {

                TextBox text = new TextBox();
                text.Text = DisplayControl.Text;
                EvaluateExpression();
                if (!isShowingError)
                {
                    history.historyContent.Items.Add(text.Text + "=" + ResultBox.Text);
                }



            }

            else if (Global.mode ==1)
            {
                TextBox text = new TextBox();
                text.Text = DisplayControl.Text;
                EvaluateExpression();
                if (!isShowingError)
                {
                    history.historyContent.Items.Add(text.Text + "=" + ResultBox.Text);
                }



            }
            else if (mode == 2)
            {
                TextBox text = new TextBox();
                text.Text = DisplayControl.Text;
                EvaluateExpression();
                string bin = Convert.ToString(Convert.ToInt32(DisplayControl.Value), 8);
                this.Display = bin;
                this.DisplayControl.Text = bin;

                if (!isShowingError)
                {
                    history.historyContent.Items.Add(text.Text + "=" + ResultBox.Text);
                }


            }
            else
            {
                TextBox text = new TextBox();
                text.Text = DisplayControl.Text;
                string testing = DisplayControl.Text;
                testing = testing.Replace("a", "10");
                testing = testing.Replace("b", "11");
                testing = testing.Replace("c", "12");
                testing = testing.Replace("d", "13");
                testing = testing.Replace("e", "14");
                testing = testing.Replace("f", "15");
                DisplayControl.Text = testing;
                EvaluateExpression();
                string bin = Convert.ToString(Convert.ToInt32(DisplayControl.Value), 16);
                this.Display = bin;
                this.DisplayControl.Text = bin;

                if (!isShowingError)
                {
                    history.historyContent.Items.Add(text.Text + "=" + ResultBox.Text);
                }
            }
        }



        //Keybindings
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                // Basic Digits
                case Key.D1:
                    this.One_Click(sender, e);
                    break;
                case Key.D2:
                    this.Two_Click(sender, e);
                    break;
                case Key.D3:
                    this.Three_Click(sender, e);
                    break;
                case Key.D4:
                    this.Four_Click(sender, e);
                    break;
                case Key.D5:
                    this.Five_Click(sender, e);
                    break;
                case Key.D6:
                    this.Six_Click(sender, e);
                    break;
                case Key.D7:
                    this.Seven_Click(sender, e);
                    break;
                case Key.D8:
                    this.Eight_Click(sender, e);
                    break;
                case Key.D9:
                    this.Nine_Click(sender, e);
                    break;
                case Key.D0:
                    this.Zero_Click(sender, e);
                    break;
                case Key.Decimal:
                    this.Decimal_Click(sender, e);
                    break;

                // Numpad digits
                case Key.NumPad1:
                    this.One_Click(sender, e);
                    break;
                case Key.NumPad2:
                    this.Two_Click(sender, e);
                    break;
                case Key.NumPad3:
                    this.Three_Click(sender, e);
                    break;
                case Key.NumPad4:
                    this.Four_Click(sender, e);
                    break;
                case Key.NumPad5:
                    this.Five_Click(sender, e);
                    break;
                case Key.NumPad6:
                    this.Six_Click(sender, e);
                    break;
                case Key.NumPad7:
                    this.Seven_Click(sender, e);
                    break;
                case Key.NumPad8:
                    this.Eight_Click(sender, e);
                    break;
                case Key.NumPad9:
                    this.Nine_Click(sender, e);
                    break;
                case Key.NumPad0:
                    this.Zero_Click(sender, e);
                    break;

                // Operations
                case Key.OemPlus:
                    this.Plus_Click(sender, e);
                    break;
                case Key.OemMinus:
                    this.Minus_Click(sender, e);
                    break;
                case Key.Multiply:
                    this.Mult_Click(sender, e);
                    break;
                case Key.Divide:
                    this.Div_Click(sender, e);
                    break;
                case Key.OemBackslash:
                    this.Div_Click(sender, e);
                    break;
                case Key.OemOpenBrackets:
                    this.Open_par_Click(sender, e);
                    break;
                case Key.OemCloseBrackets:
                    this.Close_par_Click(sender, e);
                    break;

                // Evaluation
                case Key.Enter:
                    Equal_Click(sender, e);
                    break;
                case Key.System:
                    this.Equal_Click(sender, e);
                    break;

                // Backspace
                case Key.Back:
                    this.Back_Click(sender, e);
                    break;

            }
        }

        public void ProgrammingClick(object sender, RoutedEventArgs e)
        {
            CE_Click(sender,e);
            showProgramming();
            hideScientific();
            mod.IsEnabled = false;
            hideHex();


        }

        public void Standard_Click(object sender, RoutedEventArgs e)
        {
            CE_Click(sender, e);
            hideScientific();
            hideProgramming();
            mod.IsEnabled = true;
            hidebinary();
            Global.mode = 0;
            mode = 0;
        }

        public void ButtonScientific_Click(object sender, RoutedEventArgs e)
        {
            CE_Click(sender, e);
            showScientific();
            hideProgramming();
            mod.IsEnabled = true;
            hidebinary();
            mode = 0;
            Global.mode = 0;
        }


        public void B_CLICK(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue:"b");
        }

        public void A_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "a");
        }

        public void CHex_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "c");
        }

        public void D_CLICK(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "d");
        }

        public void E_CLICK(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "e");
        }

        public void F_Click(object sender, RoutedEventArgs e)
        { 
            this.ButtonPressed(NewValue: "f");
        }

        public void Binary_Click(object sender, RoutedEventArgs e)
        {
            Global.mode = 1;
            hideHex();
            showbinary();
            

        }

        public void Octal_Click(object sender, RoutedEventArgs e)
        {
            hideHex();
            nine.IsEnabled = false;
            eight.IsEnabled = false;
            seven.IsEnabled = true;
            six.IsEnabled = true;
            five.IsEnabled = true;
            four.IsEnabled = true;
            three.IsEnabled = true;
            two.IsEnabled = true;
            mode = 2;
            Global.mode = 0;
                

        }

        public void Hex_Click(object sender, RoutedEventArgs e)
        {
            showHex();
            hidebinary();
            mode = 3;
            Global.mode = 0;
        }
        public void hideProgramming()
        {
            A.IsEnabled = false;
            B.IsEnabled = false;
            c.IsEnabled = false;
            D.IsEnabled = false;
            E.IsEnabled = false;
            F.IsEnabled = false;
            Binary.IsEnabled = false;
            Octal.IsEnabled = false;
            Hex.IsEnabled = false;
            Decimal.IsEnabled = false;
            mult.IsEnabled = true;
            @decimal.IsEnabled = true;
        }
        public void showProgramming()
        {
            A.IsEnabled = true;
            B.IsEnabled = true;
            c.IsEnabled = true;
            D.IsEnabled = true;
            E.IsEnabled = true;
            F.IsEnabled = true;
            Binary.IsEnabled = true;
            Octal.IsEnabled = true;
            Hex.IsEnabled = true;
            Decimal.IsEnabled = true;
            mult.IsEnabled = false;
            @decimal.IsEnabled = false;
        }
        public void hideScientific()
        {
            sin.IsEnabled = false;
            squared.IsEnabled = false;
            xToTheY.IsEnabled = false;
            squareRoot.IsEnabled = false;
            TenToX.IsEnabled = false;

            cos.IsEnabled = false;
            tan.IsEnabled = false;
            log.IsEnabled = false;
            ln.IsEnabled = false;
            pi.IsEnabled = false;
            Exp.IsEnabled = false;
        }
        public void showScientific()
        {
            sin.IsEnabled = true;
            squared.IsEnabled = true;
            xToTheY.IsEnabled = true;
            squareRoot.IsEnabled = true;
            TenToX.IsEnabled = true;
            cos.IsEnabled = true;
            tan.IsEnabled = true;
            log.IsEnabled = true;
            ln.IsEnabled = true;
            pi.IsEnabled = true;
            Exp.IsEnabled = true;
        }
        public void hideHex()
        {
            A.IsEnabled = false;
            B.IsEnabled = false;
            c.IsEnabled = false;
            D.IsEnabled = false;
            E.IsEnabled = false;
            F.IsEnabled = false;
        }
        public void showHex()
        {
            A.IsEnabled = true;
            B.IsEnabled = true;
            c.IsEnabled = true;
            D.IsEnabled = true;
            E.IsEnabled = true;
            F.IsEnabled = true;
        }

        public void base10_Click(object sender, RoutedEventArgs e)
        {
            hideHex();
            nine.IsEnabled = true;
            eight.IsEnabled = true;
            seven.IsEnabled = true;
            six.IsEnabled = true;
            five.IsEnabled = true;
            four.IsEnabled = true;
            three.IsEnabled = true;
            two.IsEnabled = true;
            mode = 0;

        }
        public void showbinary()
        {
            nine.IsEnabled = false;
            eight.IsEnabled = false;
            seven.IsEnabled = false;
            six.IsEnabled = false;
            five.IsEnabled = false;
            four.IsEnabled = false;
            three.IsEnabled = false;
            two.IsEnabled = false;
        }
        public void hidebinary()
        {
            nine.IsEnabled = true;
            eight.IsEnabled = true;
            seven.IsEnabled = true;
            six.IsEnabled = true;
            five.IsEnabled = true;
            four.IsEnabled = true;
            three.IsEnabled = true;
            two.IsEnabled = true;
        }


        public void Exp_Click(object sender, RoutedEventArgs e)
        {
            this.ButtonPressed(NewValue: "e");
        }

        public void Abs_Click(object sender, RoutedEventArgs e)
        { 
            this.ButtonPressed(NewValue: "abs(");
            }
        

        public void Radian_Click(object sender, RoutedEventArgs e)
        {
            Degree.IsEnabled = true;
            Global.isDegree = false;
            Radian.IsEnabled = false;
        }

        public void Degree_Click(object sender, RoutedEventArgs e)
        {
            Global.isDegree = true;
            Degree.IsEnabled = false;
            Radian.IsEnabled = true;
        }

        public void returnExpression_Click(object sender, RoutedEventArgs e)
        {
            if (history.historyContent.SelectedItem != null)
            {
                this.DisplayControl.Text = Global.expressionReturn;
                this.Display = this.DisplayControl.Text;

            }
        }

    }
}

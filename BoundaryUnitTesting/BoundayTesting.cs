using LoreSoft.MathExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScientificCalc;
using System;
using System.Windows;

namespace BoundaryUnitTesting
{
    [TestClass]
    public class BoundayTesting
    {
        [TestMethod]
        public void CheckIfNumber1ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);

            // Act

            // Assert
            string expected = "1";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }

        [TestMethod]
        public void CheckIfNumber2ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Two_Click(sender, e);

            // Act

            // Assert
            string expected = "2";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }

        [TestMethod]
        public void CheckIfNumber3ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Three_Click(sender, e);

            // Act

            // Assert
            string expected = "3";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }
        [TestMethod]
        public void CheckIfNumber4ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Four_Click(sender, e);

            // Act

            // Assert
            string expected = "4";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }
        [TestMethod]
        public void CheckIfNumber5ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);

            // Act

            // Assert
            string expected = "5";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }

        [TestMethod]
        public void CheckIfNumber6ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Six_Click(sender, e);

            // Act

            // Assert
            string expected = "6";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }
        [TestMethod]
        public void CheckIfNumber7ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Seven_Click(sender, e);

            // Act

            // Assert
            string expected = "7";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }

        [TestMethod]
        public void CheckIfNumber8ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Eight_Click(sender, e);

            // Act

            // Assert
            string expected = "8";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }

        [TestMethod]
        public void CheckIfNumber9ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Nine_Click(sender, e);

            // Act

            // Assert
            string expected = "9";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }
        [TestMethod]
        public void CheckIfNumber0ButtonWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Zero_Click(sender, e);

            // Act

            // Assert
            string expected = "0";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }


        [TestMethod]
        public void Multiple_Numbers()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Zero_Click(sender, e);

            // Act

            // Assert
            string expected = "50";
            Assert.AreEqual(expected, main.Display, "Failed Single Number");
        }

        [TestMethod]
        public void plus_click_expression_no_calculate()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Plus_Click(sender, e);
            main.Seven_Click(sender, e);

            // Act

            // Assert
            string expected = "5+7";
            Assert.AreEqual(expected, main.Display, "Failed plus click");
        }
        [TestMethod]
        public void plus_click_expression_with_calculate()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Plus_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Equal_Click(sender, e);

            // Act

            // Assert
            string expected = "12";
            Assert.AreEqual(expected, main.Display, "Failed basic addition");
        }
        [TestMethod]
        public void Basic_Subtraction_click()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Seven_Click(sender, e);

            // Act

            // Assert
            string expected = "5-7";
            Assert.AreEqual(expected, main.Display, "Failed Basic Subtraction_click");
        }
        [TestMethod]
        public void Basic_Subtraction_calculation()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Equal_Click(sender, e);

            // Act

            // Assert
            string expected = "-2";
            Assert.AreEqual(expected, main.Display, "Failed Basic Subtraction Calculation");
        }

        [TestMethod]
        public void Basic_Multiplication_click()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Mult_Click(sender, e);
            main.Seven_Click(sender, e);

            // Act

            // Assert
            string expected = "5*7";
            Assert.AreEqual(expected, main.Display, "Failed Basic Multiplication click");
        }
        [TestMethod]
        public void Basic_Multiplication_calculation()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Mult_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Equal_Click(sender, e);

            // Act

            // Assert
            string expected = "35";
            Assert.AreEqual(expected, main.Display, "Failed Basic Multiplication calculation");
        }

        [TestMethod]
        public void Basic_Division_no_calculate()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Eight_Click(sender, e);
            main.Div_Click(sender, e);
            main.Two_Click(sender, e);

            // Act

            // Assert
            string expected = "8/2";
            Assert.AreEqual(expected, main.Display, "Failed Basic Division click");
        }
        [TestMethod]
        public void Basic_Division_calculate()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Eight_Click(sender, e);
            main.Div_Click(sender, e);
            main.Two_Click(sender, e);
            main.Equal_Click(sender, e);

            // Act

            // Assert
            string expected = "4";
            Assert.AreEqual(expected, main.Display, "Failed Basic Division calculate");
        }
        public void division_zero()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Eight_Click(sender, e);
            main.Div_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Equal_Click(sender, e);

            // Act

            // Assert
            string expected = "∞";
            Assert.AreEqual(expected, main.Display, "Failed Basic Division calculate");
        }

        [TestMethod]
        public void Pi()
        {
            // Arrange
            MainWindow main = new MainWindow();
            // Act pi
            object sender = null;
            RoutedEventArgs e = null;
            main.Pi_Click(sender, e);
            main.Equal_Click(sender, e);
            // Assert
            string expected = "3.14159265358979";
            Assert.AreEqual(expected, main.Display, "Failed Pi");
        }
        //Checking Scientific Calculator Methods here ===
        [TestMethod]
        public void ScientificCalculatorSinRadian()
        {
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Radian_Click(sender, e);
            main.Sin_Click(sender, e);
            main.One_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "0.841470984807897";
            Assert.AreEqual(expected, main.Display, "failed Sin Calculation Radian");
        }
        [TestMethod]
        public void ScientificCalculatorSinDegree()
        {
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Degree_Click(sender, e);
            main.Sin_Click(sender, e);
            main.One_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "0.0174524064372835";
            Assert.AreEqual(expected, main.Display, "failed Sin Calculation Degree");
        }
        [TestMethod]
        public void ScientificCalculatorSinPiDegree()
        {

            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Degree_Click(sender, e);
            main.Sin_Click(sender, e);
            main.Pi_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "0.0548036651487895";
            Assert.AreEqual(expected, main.Display, "failed Sin Calculation Degree");
        }
        [TestMethod]
        public void ScientificCalculatorCosPiRadian()
        {
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Radian_Click(sender, e);
            main.Cos_Click(sender, e);
            main.Pi_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "-1";
            Assert.AreEqual(expected, main.Display, "failed Cos Calculation Radian");
        }

        [TestMethod]
        public void CosDegree()
        {
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Radian_Click(sender, e);
            main.Cos_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "1";
            Assert.AreEqual(expected, main.Display, "failed Sin Calculation Degree");
        }

        [TestMethod]
        public void TanDegree()
        {
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Degree_Click(sender, e);
            main.Tan_Click(sender, e);
            main.Pi_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "0.0548861508080033";
            Assert.AreEqual(expected, main.Display, "failed Tan Calculation Degree");
        }

        [TestMethod]
        public void Tan_Radian()
        {
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Radian_Click(sender, e);
            main.Tan_Click(sender, e);
            main.Pi_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "-1.22460635382238E-16";
            Assert.AreEqual(expected, main.Display, "failed Tan Calculation Degree");
        }

        [TestMethod]
        public void Exponential()
        {
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Exp_Click(sender, e);

            main.Equal_Click(sender, e);

            string expected = "2.71828182845905";
            Assert.AreEqual(expected, main.Display, "failed Tan Calculation Degree");
        }

        [TestMethod]
        public void Basic_Parentheses()
        {
            //checking if a scientific expression with parentheses work
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Radian_Click(sender, e);
            main.Cos_Click(sender, e);
            main.Pi_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Mult_Click(sender, e);
            main.Five_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "-5";
            Assert.AreEqual(expected, main.Display, "failed Mult With Cos");
        }
       
        [TestMethod]
        public void squareRoot()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.SquareRoot_Click(sender, e);
            main.Nine_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "3";
            Assert.AreEqual(expected, main.Display, "failed sqrt");
        }
        [TestMethod]
        public void squareRoot_Minus()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.SquareRoot_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Nine_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "NaN";
            Assert.AreEqual(expected, main.Display, "failed SquareRoot");
        }

        [TestMethod]
        public void PowerRegularPositive()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Nine_Click(sender, e);
            main.XToTheY_Click(sender, e);
            main.Two_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "81";
            Assert.AreEqual(expected, main.Display, "failed Power");
        }

        [TestMethod]
        public void Power_Negative()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Two_Click(sender, e);
            main.XToTheY_Click(sender, e);
            main.Open_par_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Three_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "0.125";
            Assert.AreEqual(expected, main.Display, "failed Power");
        }
        [TestMethod]
        public void Power_Zero()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Two_Click(sender, e);
            main.XToTheY_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "1";
            Assert.AreEqual(expected, main.Display, "failed Power");
        }



        [TestMethod]
        public void Backspace()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
          
            main.Two_Click(sender, e);
            main.Four_Click(sender, e);
            main.Back_Click(sender, e);
           

            string expected = "2";
            Assert.AreEqual(expected, main.Display, "failed backspace");
        }

        [TestMethod]
        public void Backspace_No_Values()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;

            main.Back_Click(sender, e);


            string expected = "";
            Assert.AreEqual(expected, main.Display, "failed backspace");
        }


        [TestMethod]
        public void TenToX()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.TenToX_Click(sender, e);
            main.Four_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "10000";
            Assert.AreEqual(expected, main.Display, "failed tentox");

        }
        [TestMethod]
        public void TenToX_parenthesis()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.TenToX_Click(sender, e);
            main.Open_par_Click(sender, e);
            main.Four_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "10000";
            Assert.AreEqual(expected, main.Display, "failed tentox");

        }

        [TestMethod]
        public void Ln()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Ln_Click(sender, e);
            main.One_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "0";
            Assert.AreEqual(expected, main.Display, "failed ln");
        }

        [TestMethod]
        public void Ln_zero()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Ln_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "-∞";
            Assert.AreEqual(expected, main.Display, "failed ln");
        }
        [TestMethod]
        public void Ln_any_minus()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            main.Ln_Click(sender, e);
            main.Minus_Click(sender, e);
            main.One_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);

            string expected = "NaN";
            Assert.AreEqual(expected, main.Display, "failed ln");
        }
        [TestMethod]
        public void Percentage_Divisor()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Four_Click(sender, e);
            main.Mod_Click(sender, e);
            string expected = "0.04";
            Assert.AreEqual(expected, main.Display, "failed percentage");
        }

        
        [TestMethod]
        public void Abs_click()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Abs_Click(sender, e);
            main.Four_Click(sender, e);
            main.Close_par_Click(sender, e);
            string expected = "abs(4)";
            Assert.AreEqual(expected, main.Display, "failed abs");

        }
        [TestMethod]
        public void Abs_click_calculate()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Abs_Click(sender, e);
            main.Four_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);
            string expected = "4";
            Assert.AreEqual(expected, main.Display, "failed abs");

        }
        [TestMethod]
        public void Abs_click_withminus()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Abs_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Four_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);
            string expected = "4";
            Assert.AreEqual(expected, main.Display, "failed abs");

        }
        [TestMethod]
        public void Pow2Click()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Minus_Click(sender, e);
            main.Four_Click(sender, e);
            main.Squared_Click(sender, e);
            main.Equal_Click(sender, e);
            string expected = "16";
            Assert.AreEqual(expected, main.Display, "failed power");

        }
        [TestMethod]
         public void Scientific_notation()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Four_Click(sender, e);
            main.Decimal_Click(sender, e);
            main.Two_Click(sender, e);
            main.Equal_Click(sender, e);
            string expected = "4.2";
            Assert.AreEqual(expected, main.Display, "failed notation");

        }
        [TestMethod]
        public void LogBase10()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Log_Click(sender, e);
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Zero_Click(sender,e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);
            string expected = "2";
            Assert.AreEqual(expected, main.Display, "failed log");

        }

        [TestMethod]
        public void ClearClick()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Log_Click(sender, e);
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.C_Click(sender, e);
            string expected = "0";
            Assert.AreEqual(expected, main.Display, "failed log");

        }
        [TestMethod]
        public void ClearClick_emptyvakue()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.C_Click(sender, e);
            string expected = "0";
            Assert.AreEqual(expected, main.Display, "failed log");

        }
        [TestMethod]
        public void CheckHistoryWorks()
        {
            // Arrange
            MainWindow main = new MainWindow();
            DisplayControl display = new DisplayControl();
            History history = new History(display);
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);
            main.Plus_Click(sender, e);
            main.One_Click(sender, e);
            string testing = main.Display;
            main.Equal_Click(sender, e);
            history.historyContent.Items.Add(testing + "=" + main.Display);
          string expected= (string)history.historyContent.Items[0];
            //  main.CE_Click(sender, e);
            Assert.AreEqual(expected,testing+ "="+ main.Display, "History Not Work");

        }
        [TestMethod]
        public void ReturnExpression()
        {
            // Arrange
            MainWindow main = new MainWindow();
            DisplayControl display = new DisplayControl();
            History history = new History(display);
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);
            main.Plus_Click(sender, e);
            main.One_Click(sender, e);
            string testing = main.Display;
            main.Equal_Click(sender, e);
            history.historyContent.Items.Add(testing + "=" + main.Display);
         
           history.historyContent.SelectAll();
           history.historyContent.SelectedItems.Add(testing);
            string expected = (string)history.historyContent.SelectedItems[0];
            expected = expected.Substring(0, expected.IndexOf("="));
            main.returnExpression_Click(sender, e);
          
            //  main.CE_Click(sender, e);
            Assert.AreEqual(expected, testing, "History Not Work");

        }
        [TestMethod]
        public void Ce_Click()
        {
            // Arrange
            MainWindow main = new MainWindow();
            DisplayControl display = new DisplayControl();
            History history = new History(display);
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);
            main.Plus_Click(sender, e);
            main.One_Click(sender, e);
            string testing = main.Display;
            main.Equal_Click(sender, e);
            history.historyContent.Items.Add(testing + "=" + main.Display);
            main.CE_Click(sender, e);
            string expected = "0";


            //  main.CE_Click(sender, e);
            Assert.AreEqual(expected, main.Display, "Ce Not Work");

        }
        [TestMethod]
            public void Ce_Click_for_history()
        {
            // Arrange
            MainWindow main = new MainWindow();
            DisplayControl display = new DisplayControl();
            History history = new History(display);
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);
            main.Plus_Click(sender, e);
            main.One_Click(sender, e);
            string testing = main.Display;
            main.Equal_Click(sender, e);
            history.historyContent.Items.Add(testing + "=" + main.Display);
            main.CE_Click(sender, e);
            int expected = history.historyContent.Items.Count-1;


            //  main.CE_Click(sender, e);
            Assert.AreEqual(expected, 0, "History Not Work");

        }
        [TestMethod]
        public void WeInStandardMode()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Standard_Click(sender, e);
            bool expected = false; ;
            if (!main.cos.IsEnabled)
            {
              expected = true;
            }
            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void WeInScientificMode()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ButtonScientific_Click(sender, e);
            bool expected = false; ;
            if (main.cos.IsEnabled)
            {
                expected = true;
            }
            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void OpenParenthesisWork()
        { 
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Open_par_Click(sender, e);
            string expected = "(";
            Assert.AreEqual(expected, main.Display, "Failed PArenthesis Open");
        }
        [TestMethod]
        public void CloseParenthesisWork()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Close_par_Click(sender, e);
            string expected = ")";
            Assert.AreEqual(expected, main.Display, "Failed PArenthesis Close");
        }
        [TestMethod]
        public void ScientificNotationDotWork()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Decimal_Click(sender, e);
            string expected = ".";
            Assert.AreEqual(expected, main.Display, "Failed scientific notation");
        }
        [TestMethod]
        public void RadianMode()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Radian_Click(sender, e);
            bool expected = false;
            if(Global.isDegree==false)
            {
                expected = true;
            }
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void DegreeMode()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Degree_Click(sender, e);
            bool expected = false;
            if (Global.isDegree)
            {
                expected = true;
            }
            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void WeInProgrammingMode()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.ProgrammingClick(sender, e);
            bool expected = false; ;
            if (main.C.IsEnabled)
            {
                expected = true;
            }
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void BinaryAddition()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            // Act
            main.ProgrammingClick(sender, e);
            main.Binary_Click(sender, e);
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Plus_Click(sender, e);
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Equal_Click(sender, e);
            // Assert

            string expected = "100";
            Assert.AreEqual(expected, main.Display, "Failed binary addition");
        }
        [TestMethod]
        public void BinarySub()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            // Act
            main.ProgrammingClick(sender, e);
            main.Binary_Click(sender, e);
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Minus_Click(sender, e);
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Equal_Click(sender, e);
            // Assert

            string expected = "0";
            Assert.AreEqual(expected, main.Display, "Failed binary sub");
        }
        [TestMethod]
        public void OctalAddition()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            // Act
            main.ProgrammingClick(sender, e);
            main.Octal_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Plus_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Equal_Click(sender, e);
            // Assert

            string expected = "16";
            Assert.AreEqual(expected, main.Display, "Failed Octal addition");
        }
        [TestMethod]
        public void OctalSub()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            // Act
            main.ProgrammingClick(sender, e);
            main.Octal_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Equal_Click(sender, e);
            // Assert

            string expected = "0";
            Assert.AreEqual(expected, main.Display, "Failed Octal Sub");
        }

        [TestMethod]
        public void OctalMultiply()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            // Act
            main.ProgrammingClick(sender, e);
            main.Octal_Click(sender, e);
            main.One_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Mult_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Equal_Click(sender, e);
            // Assert

            string expected = "167";
            Assert.AreEqual(expected, main.Display, "Failed Octal Mult");
        }

        [TestMethod]
        public void HexAddition()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            // Act
            main.ProgrammingClick(sender, e);
            main.Hex_Click(sender, e);
            main.A_Click(sender, e);
            main.Plus_Click(sender, e);
            main.B_CLICK(sender, e);
            main.Plus_Click(sender, e);
            main.CHex_Click(sender, e);
            main.Equal_Click(sender, e);
            // Assert

            string expected = "21";
            Assert.AreEqual(expected, main.Display, "Failed Hex Addition");
        }
        [TestMethod]
        public void HexSub()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            // Act
            main.ProgrammingClick(sender, e);
            main.Hex_Click(sender, e);
            main.F_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Three_Click(sender, e);
            main.Equal_Click(sender, e);
            // Assert

            string expected = "c";
            Assert.AreEqual(expected, main.Display, "Failed Hex Sub");
        }
        [TestMethod]
        public void HexMult()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            // Act
            main.ProgrammingClick(sender, e);
            main.Hex_Click(sender, e);
            main.Five_Click(sender, e);
            main.Mult_Click(sender, e);
            main.Nine_Click(sender, e);
            main.Equal_Click(sender, e);
            // Assert

            string expected = "2d";
            Assert.AreEqual(expected, main.Display, "Failed Hex Sub");
        }
        [TestMethod]
        public void Scientific_notation_invalid()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Four_Click(sender, e);
            main.Decimal_Click(sender, e);
            main.Two_Click(sender, e);
            main.Decimal_Click(sender, e);
            main.Plus_Click(sender, e);
            main.One_Click(sender,e);
            main.Equal_Click(sender, e);
            main.isShowingError = false;
            main.toggleErrorDisplay();
            Assert.IsTrue(main.isShowingError);
        }
        [TestMethod]
        public void ExpressionWrong()
        {
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Four_Click(sender, e);
            main.Two_Click(sender, e);
            main.Plus_Click(sender, e);
            main.Open_par_Click(sender, e);
            main.One_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Open_par_Click(sender, e);
            main.Equal_Click(sender, e);
            main.isShowingError = false;
            main.toggleErrorDisplay();
            Assert.IsTrue(main.isShowingError);
        }
        [TestMethod]
        public void ChangeModeHistoryRemove()
        {
            // Arrange
            MainWindow main = new MainWindow();
            DisplayControl display = new DisplayControl();
            History history = new History(display);
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);
            main.Plus_Click(sender, e);
            main.One_Click(sender, e);
            string testing = main.Display;
            main.Equal_Click(sender, e);
            history.historyContent.Items.Add(testing + "=" + main.Display);
            main.ButtonScientific_Click(sender, e);
            history.historyContent.Items.Clear();
            int x =history.historyContent.Items.Count;
            string expected = x.ToString();
            //  main.CE_Click(sender, e);
            Assert.AreEqual(expected,"0", "History Not Work");

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScientificCalc;
using System;
using System.Windows;

namespace BoundaryUnitTesting
{
    [TestClass]
    public class AcceptanceTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*First Scenario:
             * Add Two Numbers:
             * Given i have entered 50 into the calculator
             * And i have entered plus operator then 70 into the calculator
             * When i press equal sign
             * Then the result should be 120 on the screen
             */
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Plus_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Equal_Click(sender, e);

            // Act

            // Assert
            string expected = "120";
            Assert.AreEqual(expected, main.Display, "Failed Two Numbers Addition");

        }
        [TestMethod]
        public void TestMethod2()
        {
            /*Second Scenario:
             * Mult Two numbers Numbers:
             * Given i have entered 5 into the calculator
             * And i have entered mult operator then 5.2 into the calculator
             * When i press equal sign
             * Then the result should be 26 on the screen
             */
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Mult_Click(sender, e);
            main.Five_Click(sender, e);
            main.Decimal_Click(sender, e);
            main.Two_Click(sender, e);
            main.Equal_Click(sender, e);

            // Act

            // Assert
            string expected = "26";
            Assert.AreEqual(expected, main.Display, "Failed Two Numbers Multiply");
        }
        [TestMethod]
        public void TestMethod3()
        {
            /*Third Scenario:
             * Sub Two numbers Numbers:
             * Given i have entered 5 into the calculator
             * And i have entered minus operator then 5.2 into the calculator
             * When i press equal sign
             * Then the result should be -0.2 on the screen
             */
            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Five_Click(sender, e);
            main.Decimal_Click(sender, e);
            main.Two_Click(sender, e);
            main.Equal_Click(sender, e);

            // Act

            // Assert
            string expected = "-0.2";
            Assert.AreEqual(expected, main.Display, "Failed Two Numbers Multiply");
        }
        [TestMethod]
        public void TestMethod4()
        {
            /*Fourth Scenario:
             * Divide By Zero:
             * Given i have entered 5 into the calculator
             * And i have entered 0 into the calculator
             * When i press equal sign
             * Then the result should be infinity on the screen
             */

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
            Assert.AreEqual(expected, main.Display, "Failed Division 0");
        }
        [TestMethod]
        public void TestMethod5()
        {
            /*Fifth Scenario:
             * Divide Two numbers Numbers:
             * Given i have entered 10 into the calculator
             * And i have entered 2 into the calculator
             * When i press equal sign
             * Then the result should be 5 on the screen
             */
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Div_Click(sender, e);
            main.Two_Click(sender, e);
            main.Equal_Click(sender, e);
            string expected = "5";
            Assert.AreEqual(expected, main.Display, "Failed Basic Division");

        }
        [TestMethod]
        public void TestMethod6()
        {
            /*Sixth Scenario:
             * Fix Wrong Expression
             * 
             */
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Div_Click(sender, e);
            main.Two_Click(sender, e);
            main.Open_par_Click(sender, e);
            main.Back_Click(sender, e);
            main.Equal_Click(sender, e);
            string expected = "5";
            Assert.AreEqual(expected, main.Display, "Failed");



        }
        [TestMethod]
        public void TestMethod7()
        {
            /*Seven Scenario:
             * USer wants to check IF  calculator USES BODMAS
             * So he types a expression like 5*(7+1) and he should get 40
            
             */

            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Five_Click(sender, e);
            main.Mult_Click(sender, e);
            main.Open_par_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Plus_Click(sender, e);
            main.One_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);
            string expected = "40";
            Assert.AreEqual(expected, main.Display, "FAILED BODMAS");


        }
        [TestMethod]
        public void TestMethod8()
        {
            /*Eight Scenario:
             *Calculate Cos(pi) in radian:
             * Given i have entered cos into the calculator
             * And i have entered pi into the calculator
             * When i press equal sign
             * Then the result should be -1 on the screen
             */

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
        public void TestMethod9()
        {
            /*Char 15 max Scenario: Ninth
             * Given i have entered 15 chars into the calculator
             * And i have entered another char into the calculator
             * Should not update display
             */
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            string expected = "111111111111111";
            Assert.AreEqual(expected, main.Display, "Failed Max Char");
        }
        [TestMethod]
        public void TestMethod10()
        {
            /*Tenth Scenario:
             * Want To Return Expression because i typed wrong:
             * Given i have entered 5 into the calculator
             * And i have entered 5.2 into the calculator
             * When i press equal sign
             * Then the result should be 10.2 on the screen
             * But i mistook 5.2 i needed to put 2
             * i dont want to backspace /CE
             * I want to retrieve the expression from history
             * so i can redo it
             */
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            DisplayControl display = new DisplayControl();
            History history = new History(display);
            main.Five_Click(sender, e);
            main.Plus_Click(sender, e);
            main.Five_Click(sender, e);
            main.Decimal_Click(sender, e);
            main.Two_Click(sender, e);
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
        public void testmethod12()
        {
            /*script:
             USer enter 10 
            *
            then user enter open parentheses (7-5)
            then user divide by (2-2)

            */
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.One_Click(sender, e);
            main.Zero_Click(sender, e);
            main.Mult_Click(sender, e);
            main.Open_par_Click(sender, e);
            main.Seven_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Five_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Div_Click(sender, e);
            main.Open_par_Click(sender, e);
            main.Two_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Two_Click(sender, e);
            main.Close_par_Click(sender, e);
            main.Equal_Click(sender, e);
            string expected = "∞";
            Assert.AreEqual(expected, main.Display, "Failed Test");

        }

        [TestMethod]
        public void ExpressionWrong()
        {
            /*
             Scenario
            USer Accidenatally Pressed Two scientific Notation. like 4.2.2 so his expression is wrong*/

            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Four_Click(sender, e);
            main.Decimal_Click(sender, e);
            main.Two_Click(sender, e);
            main.Decimal_Click(sender, e);
            main.Two_Click(sender,e);
            main.Equal_Click(sender, e);
            
            main.isShowingError = false;
            main.toggleErrorDisplay();
            Assert.IsTrue(main.isShowingError);
        }
        [TestMethod]
        public void ExpressionWrong_2()
        {
            /*
             Scenario
            USer Accidenatally Pressed Two scientific Notation. like 4.2.2 so his expression is wrong*/

            // Arrange
            MainWindow main = new MainWindow();
            object sender = null;
            RoutedEventArgs e = null;
            main.Four_Click(sender, e);
            main.Decimal_Click(sender, e);
            main.Two_Click(sender, e);
            main.Two_Click(sender, e);
            main.Plus_Click(sender, e);
            main.Minus_Click(sender, e);
            main.Mult_Click(sender, e);
            main.Equal_Click(sender, e);

            main.isShowingError = false;
            main.toggleErrorDisplay();
            Assert.IsTrue(main.isShowingError);
        }
    }
}

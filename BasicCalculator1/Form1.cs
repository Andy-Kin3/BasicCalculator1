using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ArithmeticOperator Operator = new ArithmeticOperator();
        private void UserInputText_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Event for buttons when they are clicked
        /// </summary>
        /// <param name="sender">The value clicked by the user</param>
        /// <param name="e">The event areguement</param>
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (this.operationComplete)
            {
                operationComplete = false;
                this.UserInputText.Text = "";
            }

            // Passing Button event as an object
            var button = sender as Button;

            // This variable contains all the number buttons as integers
            var numberbuttons = new[] { OneButton, TwoButton, ThreeButton, FourButton, FiveButton, SixButton, SevenButton, EightButton, NineButton, ZeroButton };

            if(numberbuttons.Contains(button))
            {
                // Take he value of the button as pass them as a string
                var buttonValue = int.Parse(button.Tag.ToString());
                // Updating the operand to the next value.
                Operator.UpdateOperand(buttonValue);
                this.UserInputText.Text += button.Text;
                return;
            }

            var operatorButtons = new[] { AddButton, MinusButton, MultiplyButton, DivideButton, ModulusButton };
            if(operatorButtons.Contains(button))
            {
                var operatorValue = (OperationType)int.Parse(button.Tag.ToString());
                Operator.UpdateOperator(operatorValue);
                this.UserInputText.Text += button.Text;
                return;
            }

            // Cancel button acction.
            if(button == CEButton || button == CancelButton)
            {
                this.Operator = new ArithmeticOperator();
                this.UserInputText.Text = "";
                return;
            }

            if(button == DelButton)
            {
                // Delete button removing the last character from the calculator
                this.Operator.UndoLastAction();
                if (this.UserInputText.Text?.Length > 0)
                {
                    this.UserInputText.Text = this.UserInputText.Text.Substring(0, this.UserInputText.Text.Length - 1);
                    return;
                }
            }

            if (button == PointButton)
            {
                // Check if the point button was already inputed before.
                if (Operator.UpdatePoint())
                {
                    //Appending point to the value on the left
                    this.UserInputText.Text += button.Text;
                }
                return;
            }

            // Performing the calculation.
            if(button == EqualsButton)
            {
                // Calculate the equation.
                var result = this.Operator.Calculate();
                // Converting the result to string.
                this.UserInputText.Text = result.ToString();
                // Calling the ArithmeticOperator operation.
                this.Operator = new ArithmeticOperator();
                // Checking if the operation is complete.
                this.operationComplete = true;
                return;
            }
        }
        private bool operationComplete = false;
    }
}

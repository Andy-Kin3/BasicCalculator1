using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator1
{
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Cancel Methods
        private void DelButton_Click(object sender, EventArgs e)
        {
            // Deleting text input in the text box
            DeleteTextValue();

            //Focus user input
            FocusUserInputText();
        }
        /// <summary>
        /// Clears the User input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            this.UserInputText.Text = string.Empty;

            //Focus usert input text
            FocusUserInputText();
        }
        #endregion

        #region Operator Functions

        /// <summary>
        /// Calculate the given equation in the input text.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            // Calculate the given equation.
            CalculateEquation();

            //Focus usert input text
            FocusUserInputText();
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("%");

            //Focus usert input text
            FocusUserInputText();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            //Focus usert input text
            FocusUserInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            //Focus usert input text
            FocusUserInputText();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            //Focus usert input text
            FocusUserInputText();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            //Focus usert input text
            FocusUserInputText();
        }

        #endregion

        #region Number Methods

        private void NineButton_Click(object sender, EventArgs e)
        {
            // Causes the button to send the digit to the screen
            InsertTextValue("9");

            //Focus usert input text
            FocusUserInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            //Focus usert input text
            FocusUserInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            //Focus usert input text
            FocusUserInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            //Focus usert input text
            FocusUserInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            //Focus usert input text
            FocusUserInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            //Focus usert input text
            FocusUserInputText();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            //Focus usert input text
            FocusUserInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            //Focus usert input text
            FocusUserInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            //Focus usert input text
            FocusUserInputText();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            //Focus usert input text
            FocusUserInputText();
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            //Focus usert input text
            FocusUserInputText();
        }
        #endregion

        #region Calculate Equations

        /// <summary>
        /// Calculate the equation
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void CalculateEquation()
        {
            // TODO make calculations for the calculator.

            var userInput = this.UserInputText.Text;

            // Enums
            // New class files
            // Recursive functions
            // Solution statments

            this.CalculationResultLabel.Text = ParseOperation();

            FocusUserInputText();
        }

        /// <summary>
        /// Parses the uses input and equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // Get the user's input from the textbox
                var userInput = this.UserInputText.Text;

                // Remove all spaces
                userInput = userInput.Replace(" ", "");

                //Create an operation..
                var operation = new Operation();
                var leftSide = true;

                //Loop through each character from left to right..
                for(int i = 0; i < userInput.Length; i++)
                {
                    var myNumbers = "0123456789.";
                    var myOperators = "*/+-%.";

                    // Check if the current character is a number.
                    if (myNumbers.Any(c => userInput[i] == c))
                    {
                        if (leftSide)
                        {
                            operation.leftSide = AddNumberPart(operation.leftSide, userInput[i]);
                        }
                        else
                        {
                            operation.rightSide = AddNumberPart(operation.rightSide, userInput[i]);
                        }
                    }

                    // If it is an operator then assign an operator type. 
                    else if(myOperators.Any(c => userInput[i] == c))
                        {
                            // If on the right side then calculate the current operation..
                            if (!leftSide)
                            {
                                var operatorType = GetOperatorType(userInput[i]);

                                if (operation.rightSide.Length == 0)
                                {
                                    //Check if the operation isn't equal to minus and indicate
                                    if (operatorType != OperationType.Minus)
                                        throw new InvalidOperationException($"Invalid operator at the begining avoid operator if not minus");

                                    // If there is no number on the left of the minus, concatenate the minus with the immediate digit
                                    operation.rightSide += userInput[i];
                                }
                                else
                                {
                                    // Store the current value
                                    operation.leftSide = CalculateOperation(operation);

                                    // Set the new operator.
                                    operation.OperationType = operatorType;

                                    // Clear the previous right value
                                    operation.rightSide = string.Empty;
                                }
                            
                        }
                            else
                            {
                                var operatorType = GetOperatorType(userInput[i]);

                                //Check if we have a right side number.
                                if(operation.leftSide.Length == 0)
                                {
                                    //Check if the operation isn't equal to minus and indicate
                                    if(operatorType != OperationType.Minus)
                                        throw new InvalidOperationException($"Invalid operator at the begining avoid operator if not minus");

                                    // If there is no number on the left of the minus, concatenate the minus with the immediate digit
                                    operation.leftSide += userInput[i];
                                }
                                else
                                {
                                    // Moving to the right side with an operator and a number on the left side.

                                    //Set the operation type
                                    operation.OperationType = operatorType;

                                    // Move to the right side
                                    leftSide = false;

                                }
                            }
                    }
                }
                return CalculateOperation(operation);

                return string.Empty;
            }
            catch(Exception ex)
            {
                return $"invalid equation. {ex.Message}";
            }

        }
        //Calculates the operation and returns the result.
        private string CalculateOperation(Operation operation)
        {
            // Store the number values of the string representation
            double left = 0;
            double right = 0;

            // Check if we have a valid left side value
            if (string.IsNullOrEmpty(operation.leftSide) || !double.TryParse(operation.leftSide, out left))
                throw new InvalidOperationException($"Left side of the opertion eas not a number. {operation.leftSide}");

            if (string.IsNullOrEmpty(operation.rightSide) || !double.TryParse(operation.rightSide, out right))
                throw new InvalidOperationException($"Left side of the opertion eas not a number. {operation.rightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Modulus:
                        return (left % right).ToString();
                    default:
                        throw new InvalidOperationException($"The given operator is not valid or Unknown. {operation.OperationType}");
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.leftSide} {operation.OperationType} {operation.rightSide}");
            }
        }
        
        /// Accept the <see cref="OperationType"/  >
        private OperationType GetOperatorType(char newCharacter)
        {
            switch (newCharacter)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Divide;
                case '%':
                    return OperationType.Modulus;
                default:
                    throw new InvalidOperationException($"Unknown Operator type {newCharacter}");
            }
        }

        /// <summary>
        /// Attepmts to add a new character to the current number and checks for valid characters..
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newCharacter">The new chracter to append to string</param>
        public string AddNumberPart(string currentNumber, char newCharater)
            {
                // Check if there is already a . in the number
                if(newCharater == '.' && currentNumber.Contains('.'))
                    throw new InvalidOperationException($"Nmber {currentNumber} already contains a dit(.)");
                return currentNumber + newCharater;
            }

        #endregion

        #region Private Helpers
        /// <summary>
        /// Focuses the user input text
        /// </summary>

        private void FocusUserInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Insert the given text to the user input..+
       /// </summary>
        /// <param name="value">argument to assign button value</param>
        private void InsertTextValue(string value)
        {
            //Remember selection start..
            var selectionStart = this.UserInputText.SelectionStart;

            // Start new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start.
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            //Set selection start to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Delecte the character of the user input text box
        /// </summary>
        private void DeleteTextValue()
        {
            // If there are no values to delete then do nothing(return)
            if (string.IsNullOrWhiteSpace(this.UserInputText.Text))
                return;


            //Remember selection start..
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection..
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.Text.Length-1, 1);

            // Restore the selection start.
            this.UserInputText.SelectionStart = selectionStart;

            //Set selection start to zero
            this.UserInputText.SelectionLength = 0;
        }

        #endregion

        #region Other operators
        private ArithmeticOperator Operator;
        private void UserInputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == CEButton) 
            {

            }

            var numberbuttons = new[] { OneButton, TwoButton, ThreeButton, FourButton, FiveButton, SixButton, SevenButton, EightButton, NineButton, ZeroButton };

            if (numberbuttons.Contains(button))
            {
                var buttonValue = (int)button.Tag;
                UpdateOperation(buttonValue);
            }

        }

        private void UpdateOperation(int buttonValue)
        {
            if (Operator == null)
            {
                Operator = new ArithmeticOperator();
            }
        }
        #endregion
    }
}

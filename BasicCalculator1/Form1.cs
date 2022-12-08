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
        private void EqualsButton_Click(object sender, EventArgs e)
        {
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
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            //Remember selection start..
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection..
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            // Restore the selection start.
            this.UserInputText.SelectionStart = selectionStart;

            //Set selection start to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Calculate the equation
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void CalculateEquation()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

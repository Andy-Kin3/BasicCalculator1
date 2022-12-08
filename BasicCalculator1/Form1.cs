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
            //this.UserInputText.Text = ;
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
            MessageBox.Show("Hi");
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Number Methods

        private void NineButton_Click(object sender, EventArgs e)
        {
            // Causes the button to send the digit to the screen
            InsertTextValue("9");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, "8");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, "7");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, "4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, "5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, "6");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, "1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, "2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, "3");
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, "0");
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, ".");
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
        /// Collecting button value and sending to textbox,,,
        /// </summary>
        /// <param name="value">argument to assign button value</param>
        private void InsertTextValue(string value)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);
        }

        #endregion
    }
}

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

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (this.operationComplete)
            {
                operationComplete = false;
                this.UserInputText.Text = "";
            }

            var button = sender as Button;

            var numberbuttons = new[] { OneButton, TwoButton, ThreeButton, FourButton, FiveButton, SixButton, SevenButton, EightButton, NineButton, ZeroButton };

            if(numberbuttons.Contains(button))
            {
                var buttonValue = int.Parse(button.Tag.ToString());
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

            if(button == CEButton || button == CancelButton)
            {
                this.Operator = new ArithmeticOperator();
                this.UserInputText.Text = "";
                return;
            }

            if(button == DelButton)
            {
                this.Operator.UndoLastAction();
                if (this.UserInputText.Text?.Length > 0)
                {
                    this.UserInputText.Text = this.UserInputText.Text.Substring(0, this.UserInputText.Text.Length - 1);
                    return;
                }
            }

            if (button == PointButton)
            {
                if (Operator.UpdatePoint())
                {
                    this.UserInputText.Text += button.Text;
                }
                return;
            }

            if(button == EqualsButton)
            {
                var result = this.Operator.Calculate();
                this.UserInputText.Text = result.ToString();
                this.Operator = new ArithmeticOperator();
                this.operationComplete = true;
                return;
            }
        }
        private bool operationComplete = false;
    }
}

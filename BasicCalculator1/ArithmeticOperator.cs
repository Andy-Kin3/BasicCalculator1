using System;

namespace BasicCalculator1
{
    public class ArithmeticOperator
    {
        public ArithmeticOperator()
        {   
        }

        public ArithmeticOperator AccumulatedOperator { get; set; }
        public double? Operand1 { get; set; }
        public double? Operand2 { get; set; }
        public OperationType OperationType = OperationType.None;

        public double Calculate()
        {
            var operand1 = GetOperaand1();// Operand1.Calculate();
            var operand2 = this.Operand2 ?? 0;
            var operationType = this.OperationType;
            var results = performOperation(operand1, operand2, operationType);
            return results;
        }

        private double GetOperaand1()
        {
            if(this.AccumulatedOperator != null)
            {
                return this.AccumulatedOperator.Calculate();
            }
            return Operand1 ?? 0;
        }

        private double performOperation(double operand1, double operand2, OperationType operationType)
        {
            switch(operationType)
            {
                case OperationType.Add:
                    return operand1 + operand2;
                case OperationType.Minus:
                    return operand1 - operand2;
                case OperationType.Multiply:
                    return operand1 * operand2;
                case OperationType.Divide:
                    return operand1 / operand2;
                case OperationType.Modulus:
                    return operand1 % operand2;
                default:
                    return 0;
            }
        }

        internal void UpdateOperand(int value)
        {
            if(this.OperationType == OperationType.None)
            {
                UpdateOperand1(value);
            }
            else
            {
                UpdateOperand2(value);
            }
        }

        private void UpdateOperand1(int value)
        {
            var stringValue = this.Operand1?.ToString();
            if (Operand1PointPending)
            {
                Operand1PointPending = false;
                stringValue += ".";
            }
            stringValue += value;
            this.Operand1 = double.Parse(stringValue);
        }
        private void UpdateOperand2(int value)
        {
            var stringValue = this.Operand2?.ToString();
            if (Operand2PointPending)
            {
                Operand2PointPending = false;
                stringValue += ".";
            }
            stringValue += value;
            this.Operand2 = double.Parse(stringValue);
        }

        internal void UpdateOperator(OperationType operatorValue)
        {
            if(this.Operand2.HasValue)
            {
                var newOperator = new ArithmeticOperator();
                Copy(this, newOperator);
                this.AccumulatedOperator = newOperator;
                this.Operand1 = this.Operand2 = null;
            }
            this.OperationType = operatorValue; 
        }

        internal void UndoLastAction()
        {
            if(this.Operand2.HasValue)
            {
                if(this.Operand2PointPending)
                {
                    Operand2PointPending = false;
                    return;
                }
                var stringValue = this.Operand2.ToString();
                stringValue = stringValue.Substring(0, stringValue.Length-1);
                this.Operand2 = double.Parse(stringValue);
                return;
            }
            if(this.OperationType != OperationType.None)
            {
                this.OperationType = OperationType.None;
                return;
            }
            if(this.AccumulatedOperator != null)
            {
                this.AccumulatedOperator.UndoLastAction();
                Copy(this.AccumulatedOperator, this);
                return;
            }
            if(this.Operand1.HasValue)
            {
                if (this.Operand1PointPending)
                {
                    Operand1PointPending = false;
                    return;
                }
                var stringValue = this.Operand1?.ToString();
                stringValue = stringValue.Substring(0, stringValue.Length - 1);
                this.Operand1 = double.Parse(stringValue);
                return;
            }

        }

        private void Copy(ArithmeticOperator from, ArithmeticOperator to)
        {
            to.Operand1 = from.Operand1;
            to.Operand2 = from.Operand2;
            to.OperationType = from.OperationType;
            to.AccumulatedOperator = from.AccumulatedOperator;
        }

        private bool Operand1PointPending = false;
        private bool Operand2PointPending = false;

        internal bool UpdatePoint()
        {
            if (Operand2.HasValue)
            {
                if (Operand2.HasDecimalPoint())
                {
                    return false;
                }
                else
                {
                    Operand2PointPending = true;
                    return true;
                }
            }
            if(this.OperationType != OperationType.None)
            {
                return false;
            }
            if (Operand1.HasValue)
            {
                if (Operand1.HasDecimalPoint())
                {
                    return false;
                }
                else
                {
                    Operand1PointPending = true;
                    return true;
                }
            }
            return false;
        }
    }
}

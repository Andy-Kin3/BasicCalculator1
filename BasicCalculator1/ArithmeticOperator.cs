namespace BasicCalculator1
{
    public class ArithmeticOperator
    {
        public ArithmeticOperator Operand1 { get; set; }
        public int Operand2 { get; set; }
        public OperationType OperationType { get; set; }

        public int Calculate()
        {
            var operand1 = Operand1.Calculate();
            var operand2 = this.Operand2;
            var operationType = this.OperationType;
            var results = performOperation(operand1, operand2, operationType);
            return results;
        }

        /// <summary>
        /// Perfom an operation and store its value
        /// </summary>
        /// <param name="operand1">the operand of the left side</param>
        /// <param name="operand2">the operand on the right side</param>
        /// <param name="operationType">The type of operation being performed</param>
        /// <returns></returns>
        private int performOperation(int operand1, int operand2, OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Add:
                    return operand1 + operand2;
                case OperationType.Minus:
                    return operand1 - operand2;
                case OperationType.Add:
                    return operand1 + operand2;
                case OperationType.Add:
                    return operand1 + operand2;
                case OperationType.Add:
                    return operand1 + operand2;
                case OperationType.Add:
                    return operand1 + operand2;
            }
        }

        internal void UpdateOperand(int buttonValue)
        {
            throw new System.NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator1
{

    /// <summary>
    /// The type of operation the calculator can perform
    /// </summary>
    public enum OperationType
    {
        None = 0,
        /// <summary>
        /// Add a series of numbers
        /// </summary>
        Add = 1,
        /// <summary>
        /// Substract numbers
        /// </summary>
        Minus = 2,
        /// <summary>
        /// Divide a sequence of numbers
        /// </summary>
        Divide = 3,
        /// <summary>
        /// Multiply two values...
        /// </summary>
        Multiply = 4,
        /// <summary>
        /// Give the remainder of the eqaution.
        /// </summary>
        Modulus = 5,
    }
}

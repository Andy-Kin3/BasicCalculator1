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
        /// <summary>
        /// Add a series of numbers
        /// </summary>
        Add,
        /// <summary>
        /// Substract numbers
        /// </summary>
        Minus,
        /// <summary>
        /// Divide a sequence of numbers
        /// </summary>
        Divide,
        /// <summary>
        /// Multiply two values...
        /// </summary>
        Multiply,
        /// <summary>
        /// Give the remainder of the eqaution.
        /// </summary>
        Modulus
    }
}

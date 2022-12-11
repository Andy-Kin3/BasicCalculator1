using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator1
{
    public class Operation
    {
        #region Public properties
        /// <summary>
        /// The left side of the operation
        /// </summary>
        public string leftSide { get; set; }
        /// <summary>
        /// The right side of the operation.
        /// </summary>
        public string rightSide { get; set; }
        /// <summary>
        /// The type of operation performed
        /// </summary>
        public OperationType OperationType { get; set; }
        /// <summary>
        /// The inner operation
        /// </summary>
        public Operation InnerOperation { get; set; }
        #endregion

        #region
        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {
            //Create empty strings instead of having nulls
            this.leftSide = string.Empty;
            this.rightSide = string.Empty;
        }
        #endregion
    }
}

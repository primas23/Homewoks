namespace SumNumbersASPMVC.Models
{
    public class SumViewModel
    {
        /// <summary>
        /// Gets or sets the first number.
        /// </summary>
        /// <value>
        /// The first number.
        /// </value>
        public int FirstNumber { get; set; }

        /// <summary>
        /// Gets or sets the second number.
        /// </summary>
        /// <value>
        /// The second number.
        /// </value>
        public int SecondNumber { get; set; }

        /// <summary>
        /// Gets or sets the result of the sum.
        /// </summary>
        /// <value>
        /// The result of the sum.
        /// </value>
        public int? Result
        {
            get
            {
                return this.FirstNumber + this.SecondNumber;
            }
        }
    }
}
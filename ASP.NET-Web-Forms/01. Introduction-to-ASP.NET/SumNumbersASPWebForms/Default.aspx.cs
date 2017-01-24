using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SumNumbersASPWebForms
{
    public partial class _Default : Page
    {
        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public int Result
        {
            get
            {
                return this.Sum(int.Parse(this.firNum.Text), int.Parse(this.secNum.Text));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalcSum(object sender, EventArgs e)
        {
            this.result.Text = this.Result.ToString();
        }

        /// <summary>
        /// Sums the specified first number.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns>The sum</returns>
        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
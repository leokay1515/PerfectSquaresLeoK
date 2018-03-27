using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquaresLeoK
{
    public partial class frmPerfectSquaresLeoK : Form
    {
        public frmPerfectSquaresLeoK()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //local variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInt;

            //Set initial values
            value = 1;

            //clear the list items
            this.lstPerfectSquares.Items.Clear();

            //Get the number from the up down box
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            //State any perfect squares until you've reached the end value
            while (value <= endingValue)
            {
                //square the value
                squareRootAsDouble = Math.Sqrt(value);

                //convert the double to an int
                squareRootAsInt = Convert.ToInt32(squareRootAsDouble);

                //If the int and the double are equal, then its a perfect square
                if (squareRootAsDouble == squareRootAsInt)
                {
                    //add it to the list
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }
                value++;
            }
        }
    }
}

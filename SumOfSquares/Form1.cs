using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfSquares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long sum1 = 0;
        long sum2 = 0;
        int size = 100;
        long sub = 0;
        bool odd = false;
        bool even = false;
        double cube = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            #region Reset
            sum1 = 0;sum2 = 0;sub = 0;cube = 0;
            #endregion
            #region Sum1
            for (int i=0; i<size; i++)
            {
                sum1 += (i + 1)*(i + 1);
            }
            lblSum1.Text = "1^2 + 2^2 + 3^2 + ... + 100^2 = " + sum1.ToString();
            #endregion
            #region Sum2
            for(int i=0; i<size; i++)
            {
                sum2 += (i + 1);
            }
            sum2 = sum2 * sum2;
            lblSum2.Text = "(1 + 2 + 3 + ... + 100)^2 = " + sum2.ToString();
            #endregion
            #region Sub
            sub = sum2 - sum1;
            if(sub % 2 == 0)
            {
                lblDiff.Text = "Difference: " + sub.ToString() + "; Even";
            }
            if (sub % 2 == 1)
            {
                lblDiff.Text = "Difference: " + sub.ToString() + "; Odd";
            }
            #endregion
            #region Cube Root
            cube = Math.Round(Math.Pow(sub, 1.0/3.0)); lblCube.Text = "Cube Root: " + cube.ToString();
            
            if(cube%2== 0)
            {
                lblCube.Text = "Cube Root: " + cube.ToString() + "; Even";
            }
            if (cube % 2 == 1)
            {
                lblCube.Text = "Cube Root: " + cube.ToString() + "; Odd";
            }
            
            #endregion
        }
    }
}

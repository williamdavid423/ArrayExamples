using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            /// 1. Add 1 to each value in given array and display
            /// to the screen
            /// 
            /// Sample Output:
            /// 2 3 4 5 6 

            for (int i = 0; i < numbers.Length; i++)
            {

            }


            /// 2. Sum all the values in the given array and 
            /// display result
            /// 
            /// Sample Output:
            /// The sum is 20



            /// 3. Perform the following on the given array, then 
            /// display the updated array values.
            ///
            /// - add 5 to the element at index 1
            /// - multiple the element at index 2 by element 
            /// at index 4, and place result back at index 2
            /// - subtract the element at index 1 from element 
            /// at index 0 and place result in at index 0
            /// - swap the elements at index 3 and index 4
            /// 
            /// Sample Output
            /// -6 8 24 6 5


        }
    }
}

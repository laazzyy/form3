using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static void combinationUtil(int[] arr,
                  int n, int r, int index,
                          int[] data, int i)
        {

            // Current combination is ready to 
            // be printed, print it 
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                    Console.Write(data[j] + " ");

                Console.WriteLine("");

                return;
            }

            // When no more elements are there 
            // to put in data[] 
            if (i >= n)
                return;

            // current is included, put next 
            // at next location 
            data[index] = arr[i];
            combinationUtil(arr, n, r, index + 1,
                                    data, i + 1);

            // current is excluded, replace 
            // it with next (Note that i+1  
            // is passed, but index is not 
            // changed) 
            combinationUtil(arr, n, r, index,
                                    data, i + 1);
        }
        static void printCombination(int[] arr,
                               int n, int r)
        {

            // A temporary array to store all 
            // combination one by one 
            int[] data = new int[r];

            // Print all combination using 
            // temprary array 'data[]' 
            combinationUtil(arr, n, r, 0, data, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int n = arr.Length;
            //   int r = n;
            for (int r = 0; r <= n; r++)
            {
                printCombination(arr, n, r);
            }
        }
    }
}

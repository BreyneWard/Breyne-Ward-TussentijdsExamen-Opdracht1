using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLoginWithDB
{
    public partial class MenuForm : Form
    {
        public static double[,] createdMDArray;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void txt_multidimarray_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_multidimarray_Resize(object sender, EventArgs e)
        {
            // Scale the font size of the textbox ??
            float fontSize = txt_multidimarray.ClientSize.Height / txt_multidimarray.Lines.Length;
            txt_multidimarray.Font = new Font(txt_multidimarray.Font.FontFamily, fontSize);
        }

        private void btn_opvul_afdruk_Click(object sender, EventArgs e)
        {
            if (createdMDArray == null)
            {
                createdMDArray = CreateMultiDMArray();
            }
            else
            {
                txt_multidimarray.Text = PrintMultiDMArray();

            }
        }

        public static double[,] CreateMultiDMArray()
        {
            int rows = 10;
            int columns = 7;
            double[,] multidimensionalArray = new double[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                double maxValue = 0;
                double sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    multidimensionalArray[i, j] = random.Next(0, 100);
                    maxValue = Math.Max(maxValue, multidimensionalArray[i, j]);
                    sum += multidimensionalArray[i, j];
                }
                multidimensionalArray[i, 4] = maxValue;
                multidimensionalArray[i, 5] = sum;
                multidimensionalArray[i, 6] = sum / 4.00;
            }

            return multidimensionalArray;


        }
        
        public static string PrintMultiDMArray()
        {
            int rows = 10;
            int columns = 7;
            StringBuilder sb = new StringBuilder(); 
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sb.Append(String.Format("{0,6:N2}\t", createdMDArray[i, j]));
                }
                
                sb.AppendLine();
            }

            return sb.ToString();
        }
        
        


    }
}

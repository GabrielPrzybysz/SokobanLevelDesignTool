using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokobanLD
{
    public partial class Main : Form
    {
        public static int GridWidth;
        public static int GridHeight;


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label_width_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_height_Click(object sender, EventArgs e)
        {

        }

        private void gotogrid_Click(object sender, EventArgs e)
        {
            int valueX;
            int valueY;

            bool successX = int.TryParse(textBoxWidth.Text, out valueX);
            bool successY = int.TryParse(textBoxHeight.Text, out valueY);

            if (successX)
            {
                if (valueX > 30) 
                {
                    valueX = 30;
                }

                GridWidth = valueX;
            }
            else 
            {
                GridWidth = 1;
            }

            if (successY) 
            {
                if (valueY > 30) 
                {
                    valueY = 30;
                }

                GridHeight = valueY;
            }
            else 
            {
                GridHeight = 1;
            }

            //Go to Grid:
            GridForm gridForm = new GridForm();

            gridForm.Show();
         
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = GridForm.Result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Calculate()
            {
            /*defines all variables needed*/
            decimal volume;
            decimal floor;
            decimal Height = Convert.ToDecimal(txtHeight.Text);
            decimal Length = Convert.ToDecimal(txtLength.Text);
            decimal Width = Convert.ToDecimal(txtWidth.Text);
            decimal Coverage = Convert.ToDecimal(txtCoverage.Text);
            decimal Coats = Convert.ToDecimal(txtCoats.Text);

            /* Calculates the surface area for all of the windows and doors in the room*/
            decimal LargeWindow = 4 * nudLrgWindow.Value;
            decimal MediumWindow = 2 * nudMedWindow.Value;
            decimal SmallWindow = nudSmlWindow.Value;
            decimal SingleDoor = nudSinDoor.Value;
            decimal DoubleDoor = 2 * nudDblDoor.Value;

            /*Works out volume*/
            volume = Height* Length * Width;
            txtVolume.Text = Convert.ToString(volume) + "m³";

            /*works out floor area*/
            floor = Length* Width;
            txtFloor.Text = Convert.ToString(floor) + "m²";

            /*multiply two walls and double as the opposite walls will be same size*/
            decimal Side1 = Width * Height;
            decimal Side2 = Length * Height;
            decimal area = 2 * (Side1 + Side2);

            /*Subtracts the surface area of windows and doors from the wall surface area*/
            if (nudLrgWindow.Value > 0)
                area = area-LargeWindow;
            if (nudMedWindow.Value > 0)
                area = area-MediumWindow;
            if (nudSmlWindow.Value > 0)
                area = area-SmallWindow;
            if (nudSinDoor.Value > 0)
                area = area-SingleDoor;
            if (nudDblDoor.Value > 0)
                area = area-DoubleDoor;

            txtSurface.Text = Convert.ToString(area + "m²");       

        /*works out amount of paint needed*/
            decimal Paint = (area / Coverage) * Coats;
            txtPaint.Text = Paint.ToString("0.##") + " Litres";
            }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*Checks that the textboxes has values before doing teh calculations*/
            if (string.IsNullOrEmpty(txtHeight.Text))
                MessageBox.Show("Please enter Height of walls", "Enter height", MessageBoxButtons.OK);
            else if (string.IsNullOrEmpty(txtLength.Text))
                MessageBox.Show("Please enter length of walls", "Enter length", MessageBoxButtons.OK);
            else if (string.IsNullOrEmpty(txtWidth.Text))
                MessageBox.Show("Please enter width of walls", "Enter width", MessageBoxButtons.OK);
            else if (string.IsNullOrEmpty(txtCoverage.Text))
                MessageBox.Show("Please enter the coverage of the paint", "Enter coverage", MessageBoxButtons.OK);
            else if (string.IsNullOrEmpty(txtCoats.Text))
                MessageBox.Show("Please enter the number of coats wanted", "Enter number of coats", MessageBoxButtons.OK);
            else
                Calculate();
        }        

        /*detects the keyboard characters that are being inputted and will stop any letters and symbols from being entered*/
        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {           
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);       
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
        }

        private void txtCoverage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
        }

        private void txtCoats_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
        }
    }
}

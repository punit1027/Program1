// Punit Naran
// CIS 199-01
// Program 1
// Description: This program will allow you to calculate the amount of paint and cost associated with 
// labor and paint. It will use the user input to generate the proper calculations.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calculate1_Click(object sender, EventArgs e)
        {
            //Input Data Variables
            float squareFootage = float.Parse(sqfeetInput.Text);
            int coats = int.Parse(coatsInput.Text);
            float perGallon = float.Parse(perGallonInput.Text);


            //Output Data variables 
            double totalFootage = 0.0f;
            double numberOfGallons;
            const double totalSqFtpergallon = 330;
            double hours = 0.0f;
            const double Hourly = 10.5;
            double costOfPaint;
            double costOfLabor;
            double totalCostPaint = 0.00f;
            double paintRequired;

            //Calculations used
           
            totalFootage = squareFootage * coats; // calculates total square feet
            numberOfGallons = totalFootage / totalSqFtpergallon; // calculates number of gallons
            paintRequired = Math.Ceiling(numberOfGallons); // calculates paint require and then rounds up
            hours = numberOfGallons * 6; //calculates number of hours
            costOfLabor = hours * Hourly; // calculate labor charge
            costOfPaint = paintRequired * perGallon; //calculates cost of paint
            totalCostPaint = costOfLabor + costOfPaint; // calculates total cost of paint

            //Output Info
            totalSqftBox.Text = totalFootage.ToString(); // shows result for total footage
            gallonBox.Text = paintRequired.ToString(); // result of total gallons 
            hourBox.Text = (Math.Round(hours, 1)).ToString(); // result total hours
            paintBox.Text = costOfPaint.ToString("C"); // results total cost of paint
            laborBox.Text = costOfLabor.ToString("c"); // results total cost of labor
            totalBox.Text = totalCostPaint.ToString("C"); // results total cost for everything

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

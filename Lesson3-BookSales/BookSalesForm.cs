/*
 * Name: Todd Raymond
 * Date: Sept 23 2014
 * Purpose: Inpute Sales information about books.  Calculate the extended price and the discount and discounted
 * price thereafter.
 * Maintain sale summary information for all sales.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3_BookSales
{
    public partial class BookSalesForm : Form
    {
        //module level variables
        private int salesCountInteger, quantitySumInteger;
        private decimal discountSumDecimal, discountedPriceSumDecimal;

        public BookSalesForm()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //print preview the form
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears input given by the user and the current transaction output.
            quantityTextBox.Clear();
            titleTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Focus();

            extendedPriceTextBox.Clear();
            discountTexBox.Clear();
            discountedPriceTextBox.Clear();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Calculate the sale price, discount and the discounted price
            //maintains the summary sale information

            int quantityInteger;
            decimal priceDecimal, extendedPriceDecimal, discountDecimal, discountedPriceDecimal, averageDiscountDecial;

            const decimal DISCOUNT_RATE_Decimal = 0.15m;

            //Calculate the sale figures
            try
            {
                //take the quantity input and parse it as an integer
                quantityInteger = int.Parse(quantityTextBox.Text);
                try
                {
                    //take the price input and parse it as a decimal
                    priceDecimal = decimal.Parse(priceTextBox.Text);

                    //perform calculations
                    extendedPriceDecimal = quantityInteger * priceDecimal;
                    discountDecimal = extendedPriceDecimal + DISCOUNT_RATE_Decimal;
                    averageDiscountDecial = extendedPriceDecimal - discountDecimal;

                    // Summary Calculations
                    salesCountInteger++;
                    quantitySumInteger += quantityInteger;
                    discountSumDecimal += discountDecimal;
                    discountedPriceSumDecimal += discountedPriceSumDecimal;
                    averageDiscountDecial = discountSumDecimal / salesCountInteger;

                    //format output and display
                    extendedPriceTextBox.Text = extendedPriceDecimal.ToString("c");
                    discountTexBox.Text = discountDecimal.ToString("c");
                    discountedPriceTextBox.Text = discountedPriceSumDecimal.ToString("c");

                    quantitySumTextBox.Text = quantitySumInteger.ToString();
                    discountSumTextBox.Text = discountSumDecimal.ToString();
                    discountedAmountSumTextBox.Text = discountedPriceSumDecimal.ToString("c");
                    averageDiscountTextBox.Text = averageDiscountDecial.ToString("c");

                }
                catch (FormatException priceException)
                {
                    MessageBox.Show("Price must be a positive number", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    priceTextBox.SelectAll();
                    priceTextBox.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error...Error...Errrrrrooooooorrrrrrr.....:" + ex.Message);
                }

            }
            catch (FormatException quantityException)
            {
                MessageBox.Show("Quantity must be a positive number", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                quantityTextBox.SelectAll();
                quantityTextBox.Focus();

            }
        }
    }
}

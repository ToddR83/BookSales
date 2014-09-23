namespace Lesson3_BookSales
{
    partial class BookSalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSalesForm));
            this.bookSalesLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.printButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.extendedPriceTextBox = new System.Windows.Forms.TextBox();
            this.discountTexBox = new System.Windows.Forms.TextBox();
            this.discountedPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quantitySumTextBox = new System.Windows.Forms.TextBox();
            this.discountSumTextBox = new System.Windows.Forms.TextBox();
            this.discountedAmountSumTextBox = new System.Windows.Forms.TextBox();
            this.averageDiscountTextBox = new System.Windows.Forms.TextBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookSalesLabel
            // 
            this.bookSalesLabel.AutoSize = true;
            this.bookSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSalesLabel.Location = new System.Drawing.Point(236, 18);
            this.bookSalesLabel.Name = "bookSalesLabel";
            this.bookSalesLabel.Size = new System.Drawing.Size(146, 29);
            this.bookSalesLabel.TabIndex = 5;
            this.bookSalesLabel.Text = "Book Sales";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.discountedPriceTextBox);
            this.groupBox2.Controls.Add(this.discountTexBox);
            this.groupBox2.Controls.Add(this.extendedPriceTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale value";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.averageDiscountTextBox);
            this.groupBox3.Controls.Add(this.discountedAmountSumTextBox);
            this.groupBox3.Controls.Add(this.discountSumTextBox);
            this.groupBox3.Controls.Add(this.quantitySumTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 147);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sale Summary";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(35, 604);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(110, 34);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print &Form";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(181, 604);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 34);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(327, 604);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 34);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear &Sale";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(473, 604);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 34);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Todd Raymond";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Price";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(275, 34);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(124, 22);
            this.quantityTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(275, 68);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(313, 22);
            this.titleTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(275, 102);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(124, 22);
            this.priceTextBox.TabIndex = 5;
            // 
            // extendedPriceTextBox
            // 
            this.extendedPriceTextBox.Location = new System.Drawing.Point(275, 26);
            this.extendedPriceTextBox.Name = "extendedPriceTextBox";
            this.extendedPriceTextBox.ReadOnly = true;
            this.extendedPriceTextBox.Size = new System.Drawing.Size(184, 22);
            this.extendedPriceTextBox.TabIndex = 0;
            this.extendedPriceTextBox.TabStop = false;
            // 
            // discountTexBox
            // 
            this.discountTexBox.Location = new System.Drawing.Point(275, 65);
            this.discountTexBox.Name = "discountTexBox";
            this.discountTexBox.ReadOnly = true;
            this.discountTexBox.Size = new System.Drawing.Size(184, 22);
            this.discountTexBox.TabIndex = 1;
            this.discountTexBox.TabStop = false;
            // 
            // discountedPriceTextBox
            // 
            this.discountedPriceTextBox.Location = new System.Drawing.Point(275, 107);
            this.discountedPriceTextBox.Name = "discountedPriceTextBox";
            this.discountedPriceTextBox.ReadOnly = true;
            this.discountedPriceTextBox.Size = new System.Drawing.Size(184, 22);
            this.discountedPriceTextBox.TabIndex = 2;
            this.discountedPriceTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Extended Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "15% Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Discounted Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Number of Books";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Discounts given";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total Discounted Amounts";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Average Discount";
            // 
            // quantitySumTextBox
            // 
            this.quantitySumTextBox.Location = new System.Drawing.Point(275, 16);
            this.quantitySumTextBox.Name = "quantitySumTextBox";
            this.quantitySumTextBox.ReadOnly = true;
            this.quantitySumTextBox.Size = new System.Drawing.Size(184, 22);
            this.quantitySumTextBox.TabIndex = 4;
            this.quantitySumTextBox.TabStop = false;
            // 
            // discountSumTextBox
            // 
            this.discountSumTextBox.Location = new System.Drawing.Point(275, 50);
            this.discountSumTextBox.Name = "discountSumTextBox";
            this.discountSumTextBox.ReadOnly = true;
            this.discountSumTextBox.Size = new System.Drawing.Size(184, 22);
            this.discountSumTextBox.TabIndex = 5;
            this.discountSumTextBox.TabStop = false;
            // 
            // discountedAmountSumTextBox
            // 
            this.discountedAmountSumTextBox.Location = new System.Drawing.Point(275, 84);
            this.discountedAmountSumTextBox.Name = "discountedAmountSumTextBox";
            this.discountedAmountSumTextBox.ReadOnly = true;
            this.discountedAmountSumTextBox.Size = new System.Drawing.Size(184, 22);
            this.discountedAmountSumTextBox.TabIndex = 6;
            this.discountedAmountSumTextBox.TabStop = false;
            // 
            // averageDiscountTextBox
            // 
            this.averageDiscountTextBox.Location = new System.Drawing.Point(275, 118);
            this.averageDiscountTextBox.Name = "averageDiscountTextBox";
            this.averageDiscountTextBox.ReadOnly = true;
            this.averageDiscountTextBox.Size = new System.Drawing.Size(184, 22);
            this.averageDiscountTextBox.TabIndex = 7;
            this.averageDiscountTextBox.TabStop = false;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // BookSalesForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(619, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bookSalesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "BookSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R\' n R for Reading and Refreshment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookSalesLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox discountedPriceTextBox;
        private System.Windows.Forms.TextBox discountTexBox;
        private System.Windows.Forms.TextBox extendedPriceTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox averageDiscountTextBox;
        private System.Windows.Forms.TextBox discountedAmountSumTextBox;
        private System.Windows.Forms.TextBox discountSumTextBox;
        private System.Windows.Forms.TextBox quantitySumTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}


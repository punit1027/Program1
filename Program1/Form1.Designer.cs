namespace Program1
{
    partial class Form1
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
            this.sqftlabel = new System.Windows.Forms.Label();
            this.coatsLabel = new System.Windows.Forms.Label();
            this.ppgLabel = new System.Windows.Forms.Label();
            this.sqfeetInput = new System.Windows.Forms.TextBox();
            this.coatsInput = new System.Windows.Forms.TextBox();
            this.perGallonInput = new System.Windows.Forms.TextBox();
            this.totalSqftLabel = new System.Windows.Forms.Label();
            this.galLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.paintLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalSqftBox = new System.Windows.Forms.TextBox();
            this.gallonBox = new System.Windows.Forms.TextBox();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.paintBox = new System.Windows.Forms.TextBox();
            this.laborBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqftlabel
            // 
            this.sqftlabel.AutoSize = true;
            this.sqftlabel.Location = new System.Drawing.Point(115, 27);
            this.sqftlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqftlabel.Name = "sqftlabel";
            this.sqftlabel.Size = new System.Drawing.Size(42, 16);
            this.sqftlabel.TabIndex = 0;
            this.sqftlabel.Text = "Sq. Ft";
            // 
            // coatsLabel
            // 
            this.coatsLabel.AutoSize = true;
            this.coatsLabel.Location = new System.Drawing.Point(115, 70);
            this.coatsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coatsLabel.Name = "coatsLabel";
            this.coatsLabel.Size = new System.Drawing.Size(43, 16);
            this.coatsLabel.TabIndex = 1;
            this.coatsLabel.Text = "Coats";
            // 
            // ppgLabel
            // 
            this.ppgLabel.AutoSize = true;
            this.ppgLabel.Location = new System.Drawing.Point(89, 116);
            this.ppgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ppgLabel.Name = "ppgLabel";
            this.ppgLabel.Size = new System.Drawing.Size(105, 16);
            this.ppgLabel.TabIndex = 2;
            this.ppgLabel.Text = "Price Per Gallon";
            // 
            // sqfeetInput
            // 
            this.sqfeetInput.Location = new System.Drawing.Point(219, 23);
            this.sqfeetInput.Margin = new System.Windows.Forms.Padding(4);
            this.sqfeetInput.Name = "sqfeetInput";
            this.sqfeetInput.Size = new System.Drawing.Size(132, 22);
            this.sqfeetInput.TabIndex = 3;
            // 
            // coatsInput
            // 
            this.coatsInput.Location = new System.Drawing.Point(219, 66);
            this.coatsInput.Margin = new System.Windows.Forms.Padding(4);
            this.coatsInput.Name = "coatsInput";
            this.coatsInput.Size = new System.Drawing.Size(132, 22);
            this.coatsInput.TabIndex = 4;
            // 
            // perGallonInput
            // 
            this.perGallonInput.Location = new System.Drawing.Point(219, 107);
            this.perGallonInput.Margin = new System.Windows.Forms.Padding(4);
            this.perGallonInput.Name = "perGallonInput";
            this.perGallonInput.Size = new System.Drawing.Size(132, 22);
            this.perGallonInput.TabIndex = 5;
            // 
            // totalSqftLabel
            // 
            this.totalSqftLabel.AutoSize = true;
            this.totalSqftLabel.Location = new System.Drawing.Point(445, 23);
            this.totalSqftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalSqftLabel.Name = "totalSqftLabel";
            this.totalSqftLabel.Size = new System.Drawing.Size(72, 16);
            this.totalSqftLabel.TabIndex = 6;
            this.totalSqftLabel.Text = "Total sq. ft.";
            // 
            // galLabel
            // 
            this.galLabel.AutoSize = true;
            this.galLabel.Location = new System.Drawing.Point(445, 65);
            this.galLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.galLabel.Name = "galLabel";
            this.galLabel.Size = new System.Drawing.Size(62, 16);
            this.galLabel.TabIndex = 7;
            this.galLabel.Text = "Gallon(s)";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(445, 107);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(52, 16);
            this.hoursLabel.TabIndex = 8;
            this.hoursLabel.Text = "Hour(s)";
            this.hoursLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // paintLabel
            // 
            this.paintLabel.AutoSize = true;
            this.paintLabel.Location = new System.Drawing.Point(445, 160);
            this.paintLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paintLabel.Name = "paintLabel";
            this.paintLabel.Size = new System.Drawing.Size(38, 16);
            this.paintLabel.TabIndex = 9;
            this.paintLabel.Text = "Paint";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(445, 204);
            this.laborLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(43, 16);
            this.laborLabel.TabIndex = 10;
            this.laborLabel.Text = "Labor";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(445, 271);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(39, 16);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // totalSqftBox
            // 
            this.totalSqftBox.Enabled = false;
            this.totalSqftBox.Location = new System.Drawing.Point(561, 18);
            this.totalSqftBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalSqftBox.Name = "totalSqftBox";
            this.totalSqftBox.Size = new System.Drawing.Size(132, 22);
            this.totalSqftBox.TabIndex = 12;
            // 
            // gallonBox
            // 
            this.gallonBox.Enabled = false;
            this.gallonBox.Location = new System.Drawing.Point(561, 62);
            this.gallonBox.Margin = new System.Windows.Forms.Padding(4);
            this.gallonBox.Name = "gallonBox";
            this.gallonBox.Size = new System.Drawing.Size(132, 22);
            this.gallonBox.TabIndex = 13;
            // 
            // hourBox
            // 
            this.hourBox.Enabled = false;
            this.hourBox.Location = new System.Drawing.Point(561, 103);
            this.hourBox.Margin = new System.Windows.Forms.Padding(4);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(132, 22);
            this.hourBox.TabIndex = 14;
            // 
            // paintBox
            // 
            this.paintBox.Enabled = false;
            this.paintBox.Location = new System.Drawing.Point(561, 151);
            this.paintBox.Margin = new System.Windows.Forms.Padding(4);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(132, 22);
            this.paintBox.TabIndex = 15;
            // 
            // laborBox
            // 
            this.laborBox.Enabled = false;
            this.laborBox.Location = new System.Drawing.Point(561, 196);
            this.laborBox.Margin = new System.Windows.Forms.Padding(4);
            this.laborBox.Name = "laborBox";
            this.laborBox.Size = new System.Drawing.Size(132, 22);
            this.laborBox.TabIndex = 16;
            // 
            // totalBox
            // 
            this.totalBox.Enabled = false;
            this.totalBox.Location = new System.Drawing.Point(561, 262);
            this.totalBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(132, 22);
            this.totalBox.TabIndex = 17;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(219, 265);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 28);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculate1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 482);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.laborBox);
            this.Controls.Add(this.paintBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.gallonBox);
            this.Controls.Add(this.totalSqftBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.paintLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.galLabel);
            this.Controls.Add(this.totalSqftLabel);
            this.Controls.Add(this.perGallonInput);
            this.Controls.Add(this.coatsInput);
            this.Controls.Add(this.sqfeetInput);
            this.Controls.Add(this.ppgLabel);
            this.Controls.Add(this.coatsLabel);
            this.Controls.Add(this.sqftlabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sqftlabel;
        private System.Windows.Forms.Label coatsLabel;
        private System.Windows.Forms.Label ppgLabel;
        private System.Windows.Forms.TextBox sqfeetInput;
        private System.Windows.Forms.TextBox coatsInput;
        private System.Windows.Forms.TextBox perGallonInput;
        private System.Windows.Forms.Label totalSqftLabel;
        private System.Windows.Forms.Label galLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label paintLabel;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalSqftBox;
        private System.Windows.Forms.TextBox gallonBox;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.TextBox paintBox;
        private System.Windows.Forms.TextBox laborBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Button calculateButton;
    }
}


﻿namespace EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectAllVendors = new Button();
            btnAllCAVendors = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            btnSelectAllVendors.Location = new Point(41, 84);
            btnSelectAllVendors.Name = "btnSelectAllVendors";
            btnSelectAllVendors.Size = new Size(143, 23);
            btnSelectAllVendors.TabIndex = 0;
            btnSelectAllVendors.Text = "Select * From Vendors";
            btnSelectAllVendors.UseVisualStyleBackColor = true;
            btnSelectAllVendors.Click += btnSelectAllVendors_Click;
            // 
            // btnAllCAVendors
            // 
            btnAllCAVendors.Location = new Point(41, 165);
            btnAllCAVendors.Name = "btnAllCAVendors";
            btnAllCAVendors.Size = new Size(414, 23);
            btnAllCAVendors.TabIndex = 1;
            btnAllCAVendors.Text = "Select * From Vendors Where VendorState = CA OrderBy VendorName";
            btnAllCAVendors.UseVisualStyleBackColor = true;
            btnAllCAVendors.Click += btnAllCAVendors_Click;
            // 
            // button3
            // 
            button3.Location = new Point(41, 245);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btnAllCAVendors);
            Controls.Add(btnSelectAllVendors);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCAVendors;
        private Button button3;
    }
}
﻿
namespace HospitalDatabase
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Staff Entries";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);

               
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Patient Entries";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
        
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 60);
            this.button3.TabIndex = 1;
            this.button3.Text = "Admin Entries";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
           // this.AutoScaleDimensions = new System.Drawing.SizeF(9F, F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);

            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}
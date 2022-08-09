
namespace Recursion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFibonacci = new System.Windows.Forms.TextBox();
            this.lblResultFibonacci = new System.Windows.Forms.Label();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.txtBoxFactorial = new System.Windows.Forms.TextBox();
            this.lblResultFactorial = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of term:";
            // 
            // txtBoxFibonacci
            // 
            this.txtBoxFibonacci.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFibonacci.Location = new System.Drawing.Point(227, 79);
            this.txtBoxFibonacci.Name = "txtBoxFibonacci";
            this.txtBoxFibonacci.Size = new System.Drawing.Size(108, 26);
            this.txtBoxFibonacci.TabIndex = 1;
            // 
            // lblResultFibonacci
            // 
            this.lblResultFibonacci.AutoSize = true;
            this.lblResultFibonacci.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultFibonacci.Location = new System.Drawing.Point(193, 184);
            this.lblResultFibonacci.Name = "lblResultFibonacci";
            this.lblResultFibonacci.Size = new System.Drawing.Size(0, 20);
            this.lblResultFibonacci.TabIndex = 2;
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFibonacci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFibonacci.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFibonacci.Location = new System.Drawing.Point(26, 181);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(105, 44);
            this.btnFibonacci.TabIndex = 3;
            this.btnFibonacci.Text = "Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = false;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFibonacci);
            this.panel1.Controls.Add(this.txtBoxFibonacci);
            this.panel1.Controls.Add(this.lblResultFibonacci);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 325);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "FIBONACCI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnFactorial);
            this.panel2.Controls.Add(this.txtBoxFactorial);
            this.panel2.Controls.Add(this.lblResultFactorial);
            this.panel2.Location = new System.Drawing.Point(398, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 325);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "FACTORIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter number :";
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFactorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFactorial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.Location = new System.Drawing.Point(33, 184);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(106, 41);
            this.btnFactorial.TabIndex = 3;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // txtBoxFactorial
            // 
            this.txtBoxFactorial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFactorial.Location = new System.Drawing.Point(219, 79);
            this.txtBoxFactorial.Name = "txtBoxFactorial";
            this.txtBoxFactorial.Size = new System.Drawing.Size(100, 26);
            this.txtBoxFactorial.TabIndex = 1;
            // 
            // lblResultFactorial
            // 
            this.lblResultFactorial.AutoSize = true;
            this.lblResultFactorial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultFactorial.Location = new System.Drawing.Point(175, 184);
            this.lblResultFactorial.Name = "lblResultFactorial";
            this.lblResultFactorial.Size = new System.Drawing.Size(0, 20);
            this.lblResultFactorial.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(770, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Recursion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFibonacci;
        private System.Windows.Forms.Label lblResultFibonacci;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.TextBox txtBoxFactorial;
        private System.Windows.Forms.Label lblResultFactorial;
    }
}


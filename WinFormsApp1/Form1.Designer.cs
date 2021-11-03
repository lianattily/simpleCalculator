
namespace WinFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Font = new System.Drawing.Font("Bebas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(34, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(234, 41);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(34, 89);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(74, 74);
            this.n1.TabIndex = 4;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.button2_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(34, 169);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(74, 74);
            this.n4.TabIndex = 5;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(194, 89);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(74, 74);
            this.n3.TabIndex = 6;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(114, 89);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(74, 74);
            this.n2.TabIndex = 7;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(114, 169);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(74, 74);
            this.n5.TabIndex = 8;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(194, 169);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(74, 74);
            this.n6.TabIndex = 9;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(194, 249);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(74, 74);
            this.n9.TabIndex = 10;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(114, 249);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(74, 74);
            this.n8.TabIndex = 11;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(34, 249);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(74, 74);
            this.n7.TabIndex = 12;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(114, 329);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(74, 74);
            this.n0.TabIndex = 13;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(288, 89);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(74, 36);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(288, 127);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(74, 36);
            this.sub.TabIndex = 15;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(288, 207);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(74, 36);
            this.mul.TabIndex = 17;
            this.mul.Text = "x";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(288, 169);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(74, 36);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.Location = new System.Drawing.Point(288, 329);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(74, 74);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(288, 249);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(74, 36);
            this.mod.TabIndex = 18;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DarkSalmon;
            this.clear.Location = new System.Drawing.Point(288, 28);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(74, 36);
            this.clear.TabIndex = 21;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 423);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear;
    }
}


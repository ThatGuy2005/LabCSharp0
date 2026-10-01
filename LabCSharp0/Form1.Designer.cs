using System;
using System.Threading;

namespace LabCSharp0
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
            this.left = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(190, 170);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(74, 39);
            this.left.TabIndex = 0;
            this.left.Text = "LEFT";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(304, 237);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 41);
            this.down.TabIndex = 1;
            this.down.Text = "DOWN";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(304, 96);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 44);
            this.up.TabIndex = 2;
            this.up.Text = "UP";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.button3_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(419, 169);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(69, 40);
            this.right.TabIndex = 3;
            this.right.Text = "RIGHT";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // option
            // 
            this.option.AutoSize = true;
            this.option.Location = new System.Drawing.Point(287, 44);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(117, 20);
            this.option.TabIndex = 4;
            this.option.Text = "What to press?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 5;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(675, 330);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(87, 37);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(675, 387);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(87, 33);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.option);
            this.Controls.Add(this.right);
            this.Controls.Add(this.up);
            this.Controls.Add(this.down);
            this.Controls.Add(this.left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Label option;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;

        private Random random = new Random();
    }
}


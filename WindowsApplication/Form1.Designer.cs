namespace WindowsApplication
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
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.picture = new ZedGraph.ZedGraphControl();
            this.znach_a = new System.Windows.Forms.TextBox();
            this.znach_b = new System.Windows.Forms.TextBox();
            this.znach_c = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.znach = new System.Windows.Forms.TextBox();
            this.znach_x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(34, 515);
            this.button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(153, 45);
            this.button.TabIndex = 0;
            this.button.Text = "Построить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(351, 18);
            this.picture.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.picture.Name = "picture";
            this.picture.ScrollGrace = 0D;
            this.picture.ScrollMaxX = 0D;
            this.picture.ScrollMaxY = 0D;
            this.picture.ScrollMaxY2 = 0D;
            this.picture.ScrollMinX = 0D;
            this.picture.ScrollMinY = 0D;
            this.picture.ScrollMinY2 = 0D;
            this.picture.Size = new System.Drawing.Size(606, 542);
            this.picture.TabIndex = 1;
            this.picture.Load += new System.EventHandler(this.picture_Load);
            // 
            // znach_a
            // 
            this.znach_a.Location = new System.Drawing.Point(154, 68);
            this.znach_a.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.znach_a.MaxLength = 2;
            this.znach_a.Name = "znach_a";
            this.znach_a.Size = new System.Drawing.Size(76, 26);
            this.znach_a.TabIndex = 2;
            // 
            // znach_b
            // 
            this.znach_b.Location = new System.Drawing.Point(154, 108);
            this.znach_b.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.znach_b.MaxLength = 2;
            this.znach_b.Name = "znach_b";
            this.znach_b.Size = new System.Drawing.Size(76, 26);
            this.znach_b.TabIndex = 3;
            // 
            // znach_c
            // 
            this.znach_c.Location = new System.Drawing.Point(154, 148);
            this.znach_c.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.znach_c.MaxLength = 2;
            this.znach_c.Name = "znach_c";
            this.znach_c.Size = new System.Drawing.Size(76, 26);
            this.znach_c.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "A =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "B =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "C =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Граница переменной х";
            // 
            // znach
            // 
            this.znach.Location = new System.Drawing.Point(66, 262);
            this.znach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.znach.MaxLength = 2;
            this.znach.Name = "znach";
            this.znach.ReadOnly = true;
            this.znach.Size = new System.Drawing.Size(76, 26);
            this.znach.TabIndex = 9;
            this.znach.Text = "0";
            // 
            // znach_x
            // 
            this.znach_x.Location = new System.Drawing.Point(213, 262);
            this.znach_x.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.znach_x.MaxLength = 2;
            this.znach_x.Name = "znach_x";
            this.znach_x.Size = new System.Drawing.Size(76, 26);
            this.znach_x.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "от";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "до";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 578);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.znach_x);
            this.Controls.Add(this.znach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.znach_c);
            this.Controls.Add(this.znach_b);
            this.Controls.Add(this.znach_a);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Построение параболы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private ZedGraph.ZedGraphControl picture;
        private System.Windows.Forms.TextBox znach_a;
        private System.Windows.Forms.TextBox znach_b;
        private System.Windows.Forms.TextBox znach_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox znach;
        private System.Windows.Forms.TextBox znach_x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


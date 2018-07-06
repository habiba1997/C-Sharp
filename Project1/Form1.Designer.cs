namespace Project1
{
    partial class Window
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
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.buttonAns = new System.Windows.Forms.Button();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelAns1 = new System.Windows.Forms.Label();
            this.labelAns2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Arduino = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Arduino.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(58, 114);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(73, 18);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A (X^2)";
            this.labelA.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(221, 114);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 26);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(221, 166);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 26);
            this.textBoxB.TabIndex = 3;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(58, 173);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(51, 18);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "B (X)";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(221, 221);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 26);
            this.textBoxC.TabIndex = 5;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(54, 228);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(114, 18);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "C (Constant)";
            // 
            // buttonAns
            // 
            this.buttonAns.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonAns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAns.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAns.ForeColor = System.Drawing.Color.Black;
            this.buttonAns.Location = new System.Drawing.Point(499, 134);
            this.buttonAns.Name = "buttonAns";
            this.buttonAns.Size = new System.Drawing.Size(149, 89);
            this.buttonAns.TabIndex = 6;
            this.buttonAns.Text = "Answer";
            this.buttonAns.UseVisualStyleBackColor = false;
            this.buttonAns.Click += new System.EventHandler(this.buttonAns_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(285, 315);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 18);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "X1 =";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(285, 375);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(45, 18);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "X2 =";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labelAns1
            // 
            this.labelAns1.AutoSize = true;
            this.labelAns1.BackColor = System.Drawing.Color.Goldenrod;
            this.labelAns1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAns1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelAns1.Location = new System.Drawing.Point(348, 310);
            this.labelAns1.Name = "labelAns1";
            this.labelAns1.Size = new System.Drawing.Size(112, 27);
            this.labelAns1.TabIndex = 9;
            this.labelAns1.Text = "Answer 1";
            this.labelAns1.Click += new System.EventHandler(this.labelAns1_Click);
            // 
            // labelAns2
            // 
            this.labelAns2.AutoSize = true;
            this.labelAns2.BackColor = System.Drawing.Color.Goldenrod;
            this.labelAns2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAns2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelAns2.Location = new System.Drawing.Point(348, 370);
            this.labelAns2.Name = "labelAns2";
            this.labelAns2.Size = new System.Drawing.Size(115, 27);
            this.labelAns2.TabIndex = 10;
            this.labelAns2.Text = "Answer 2";
            this.labelAns2.Click += new System.EventHandler(this.labelAns2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(163, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "A(X^2) + B(X) + C = 0";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Arduino
            // 
            this.Arduino.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Arduino.Controls.Add(this.tabPage1);
            this.Arduino.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arduino.Location = new System.Drawing.Point(12, 12);
            this.Arduino.Name = "Arduino";
            this.Arduino.SelectedIndex = 0;
            this.Arduino.Size = new System.Drawing.Size(771, 476);
            this.Arduino.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonAns);
            this.tabPage1.Controls.Add(this.textBoxC);
            this.tabPage1.Controls.Add(this.labelAns2);
            this.tabPage1.Controls.Add(this.labelC);
            this.tabPage1.Controls.Add(this.textBoxA);
            this.tabPage1.Controls.Add(this.textBoxB);
            this.tabPage1.Controls.Add(this.labelAns1);
            this.tabPage1.Controls.Add(this.labelX1);
            this.tabPage1.Controls.Add(this.labelA);
            this.tabPage1.Controls.Add(this.labelB);
            this.tabPage1.Controls.Add(this.labelX2);
            this.tabPage1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Math";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(626, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 63);
            this.button1.TabIndex = 12;
            this.button1.Text = "Arduino";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(795, 500);
            this.Controls.Add(this.Arduino);
            this.Name = "Window";
            this.Text = "Window";
            this.Arduino.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelAns2;
        private System.Windows.Forms.Label labelAns1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Button buttonAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Arduino;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
    }
}
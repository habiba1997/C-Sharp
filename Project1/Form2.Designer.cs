namespace Project1
{
    partial class Form2
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
            this.ON = new System.Windows.Forms.Button();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.led = new System.Windows.Forms.Label();
            this.OFF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ON
            // 
            this.ON.BackColor = System.Drawing.Color.SeaShell;
            this.ON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ON.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ON.ForeColor = System.Drawing.Color.Maroon;
            this.ON.Location = new System.Drawing.Point(110, 105);
            this.ON.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(218, 99);
            this.ON.TabIndex = 0;
            this.ON.Text = " ON";
            this.ON.UseVisualStyleBackColor = false;
            this.ON.Click += new System.EventHandler(this.button1_Click);
            // 
            // Arduino
            // 
            this.Arduino.PortName = "COM5";
            // 
            // led
            // 
            this.led.AutoSize = true;
            this.led.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.led.Location = new System.Drawing.Point(284, 23);
            this.led.Name = "led";
            this.led.Size = new System.Drawing.Size(132, 56);
            this.led.TabIndex = 1;
            this.led.Text = "LED";
            // 
            // OFF
            // 
            this.OFF.BackColor = System.Drawing.Color.SeaShell;
            this.OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OFF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OFF.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OFF.ForeColor = System.Drawing.Color.Maroon;
            this.OFF.Location = new System.Drawing.Point(393, 105);
            this.OFF.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(231, 99);
            this.OFF.TabIndex = 2;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = false;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(256, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "LDR Value";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(167, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 90);
            this.button1.TabIndex = 5;
            this.button1.Text = "LDR Value";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(747, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.led);
            this.Controls.Add(this.ON);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form2";
            this.Tag = "NO Value";
            this.Text = "Arduino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ON;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.Label led;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
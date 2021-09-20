
namespace PC_Heal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.tbCoreName = new System.Windows.Forms.TextBox();
            this.tbDCFree = new System.Windows.Forms.TextBox();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.tbRAM = new System.Windows.Forms.TextBox();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.tbNPhyCore = new System.Windows.Forms.TextBox();
            this.tbNLCore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMAC = new System.Windows.Forms.TextBox();
            this.tbDDfree = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Core";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Free Disk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPU Usage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "RAM Usage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Temperature";
            // 
            // tbCName
            // 
            this.tbCName.Enabled = false;
            this.tbCName.Location = new System.Drawing.Point(286, 27);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(199, 22);
            this.tbCName.TabIndex = 1;
            // 
            // tbCoreName
            // 
            this.tbCoreName.Enabled = false;
            this.tbCoreName.Location = new System.Drawing.Point(286, 85);
            this.tbCoreName.Name = "tbCoreName";
            this.tbCoreName.Size = new System.Drawing.Size(199, 22);
            this.tbCoreName.TabIndex = 1;
            // 
            // tbDCFree
            // 
            this.tbDCFree.Enabled = false;
            this.tbDCFree.Location = new System.Drawing.Point(286, 219);
            this.tbDCFree.Name = "tbDCFree";
            this.tbDCFree.Size = new System.Drawing.Size(72, 22);
            this.tbDCFree.TabIndex = 1;
            // 
            // tbCPU
            // 
            this.tbCPU.Enabled = false;
            this.tbCPU.Location = new System.Drawing.Point(286, 362);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.Size = new System.Drawing.Size(199, 22);
            this.tbCPU.TabIndex = 1;
            // 
            // tbRAM
            // 
            this.tbRAM.Enabled = false;
            this.tbRAM.Location = new System.Drawing.Point(286, 426);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.Size = new System.Drawing.Size(199, 22);
            this.tbRAM.TabIndex = 1;
            // 
            // tbTemp
            // 
            this.tbTemp.Enabled = false;
            this.tbTemp.Location = new System.Drawing.Point(286, 491);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(199, 22);
            this.tbTemp.TabIndex = 1;
            // 
            // tbNPhyCore
            // 
            this.tbNPhyCore.Enabled = false;
            this.tbNPhyCore.Location = new System.Drawing.Point(286, 127);
            this.tbNPhyCore.Name = "tbNPhyCore";
            this.tbNPhyCore.Size = new System.Drawing.Size(199, 22);
            this.tbNPhyCore.TabIndex = 1;
            // 
            // tbNLCore
            // 
            this.tbNLCore.Enabled = false;
            this.tbNLCore.Location = new System.Drawing.Point(286, 171);
            this.tbNLCore.Name = "tbNLCore";
            this.tbNLCore.Size = new System.Drawing.Size(199, 22);
            this.tbNLCore.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Physical Core";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Logical Core";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "IP Address";
            // 
            // tbIP
            // 
            this.tbIP.Enabled = false;
            this.tbIP.Location = new System.Drawing.Point(286, 260);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(199, 22);
            this.tbIP.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "MAC Address";
            // 
            // tbMAC
            // 
            this.tbMAC.Enabled = false;
            this.tbMAC.Location = new System.Drawing.Point(286, 306);
            this.tbMAC.Name = "tbMAC";
            this.tbMAC.Size = new System.Drawing.Size(199, 22);
            this.tbMAC.TabIndex = 1;
            // 
            // tbDDfree
            // 
            this.tbDDfree.Enabled = false;
            this.tbDDfree.Location = new System.Drawing.Point(413, 219);
            this.tbDDfree.Name = "tbDDfree";
            this.tbDDfree.Size = new System.Drawing.Size(72, 22);
            this.tbDDfree.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(240, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "D:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(367, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "C:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 558);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Shutdown After (s):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(286, 568);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(199, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Shutdown";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.tbRAM);
            this.Controls.Add(this.tbCPU);
            this.Controls.Add(this.tbMAC);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbDDfree);
            this.Controls.Add(this.tbDCFree);
            this.Controls.Add(this.tbNLCore);
            this.Controls.Add(this.tbNPhyCore);
            this.Controls.Add(this.tbCoreName);
            this.Controls.Add(this.tbCName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.TextBox tbCoreName;
        private System.Windows.Forms.TextBox tbDCFree;
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.TextBox tbRAM;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.TextBox tbNPhyCore;
        private System.Windows.Forms.TextBox tbNLCore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMAC;
        private System.Windows.Forms.TextBox tbDDfree;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}


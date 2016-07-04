namespace TemperatureSensor
{
    partial class TempSensorForm
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
            this.CPU_CriticalTemp = new System.Windows.Forms.TextBox();
            this.CPU_CurrentTemp = new System.Windows.Forms.Label();
            this.Signal_CheckBox = new System.Windows.Forms.CheckBox();
            this.GPU_CurrentTemp = new System.Windows.Forms.Label();
            this.HDD_CurrentTemp = new System.Windows.Forms.Label();
            this.SSD_CurrentTemp = new System.Windows.Forms.Label();
            this.MotherBoard_CurrentTemp = new System.Windows.Forms.Label();
            this.GPU_CriticalTemp = new System.Windows.Forms.TextBox();
            this.HDD_CriticalTemp = new System.Windows.Forms.TextBox();
            this.SSD_CriticalTemp = new System.Windows.Forms.TextBox();
            this.MotherBoard__CriticalTemp = new System.Windows.Forms.TextBox();
            this.RAM_CurrentTemp = new System.Windows.Forms.Label();
            this.RAM_CriticalTemp = new System.Windows.Forms.TextBox();
            this.PowerOFF_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CPU_CriticalTemp
            // 
            this.CPU_CriticalTemp.Location = new System.Drawing.Point(199, 31);
            this.CPU_CriticalTemp.Name = "CPU_CriticalTemp";
            this.CPU_CriticalTemp.Size = new System.Drawing.Size(100, 20);
            this.CPU_CriticalTemp.TabIndex = 0;
            // 
            // CPU_CurrentTemp
            // 
            this.CPU_CurrentTemp.AutoSize = true;
            this.CPU_CurrentTemp.Location = new System.Drawing.Point(23, 34);
            this.CPU_CurrentTemp.Name = "CPU_CurrentTemp";
            this.CPU_CurrentTemp.Size = new System.Drawing.Size(35, 13);
            this.CPU_CurrentTemp.TabIndex = 1;
            this.CPU_CurrentTemp.Text = "CPU: ";
            // 
            // Signal_CheckBox
            // 
            this.Signal_CheckBox.AutoSize = true;
            this.Signal_CheckBox.Location = new System.Drawing.Point(26, 265);
            this.Signal_CheckBox.Name = "Signal_CheckBox";
            this.Signal_CheckBox.Size = new System.Drawing.Size(100, 17);
            this.Signal_CheckBox.TabIndex = 2;
            this.Signal_CheckBox.Text = "Attention Signal";
            this.Signal_CheckBox.UseVisualStyleBackColor = true;
            // 
            // GPU_CurrentTemp
            // 
            this.GPU_CurrentTemp.AutoSize = true;
            this.GPU_CurrentTemp.Location = new System.Drawing.Point(23, 73);
            this.GPU_CurrentTemp.Name = "GPU_CurrentTemp";
            this.GPU_CurrentTemp.Size = new System.Drawing.Size(33, 13);
            this.GPU_CurrentTemp.TabIndex = 3;
            this.GPU_CurrentTemp.Text = "GPU:";
            // 
            // HDD_CurrentTemp
            // 
            this.HDD_CurrentTemp.AutoSize = true;
            this.HDD_CurrentTemp.Location = new System.Drawing.Point(23, 109);
            this.HDD_CurrentTemp.Name = "HDD_CurrentTemp";
            this.HDD_CurrentTemp.Size = new System.Drawing.Size(37, 13);
            this.HDD_CurrentTemp.TabIndex = 4;
            this.HDD_CurrentTemp.Text = "HDD: ";
            // 
            // SSD_CurrentTemp
            // 
            this.SSD_CurrentTemp.AutoSize = true;
            this.SSD_CurrentTemp.Location = new System.Drawing.Point(23, 157);
            this.SSD_CurrentTemp.Name = "SSD_CurrentTemp";
            this.SSD_CurrentTemp.Size = new System.Drawing.Size(35, 13);
            this.SSD_CurrentTemp.TabIndex = 5;
            this.SSD_CurrentTemp.Text = "SSD: ";
            // 
            // MotherBoard_CurrentTemp
            // 
            this.MotherBoard_CurrentTemp.AutoSize = true;
            this.MotherBoard_CurrentTemp.Location = new System.Drawing.Point(23, 238);
            this.MotherBoard_CurrentTemp.Name = "MotherBoard_CurrentTemp";
            this.MotherBoard_CurrentTemp.Size = new System.Drawing.Size(74, 13);
            this.MotherBoard_CurrentTemp.TabIndex = 6;
            this.MotherBoard_CurrentTemp.Text = "MotherBoard: ";
            // 
            // GPU_CriticalTemp
            // 
            this.GPU_CriticalTemp.Location = new System.Drawing.Point(199, 66);
            this.GPU_CriticalTemp.Name = "GPU_CriticalTemp";
            this.GPU_CriticalTemp.Size = new System.Drawing.Size(100, 20);
            this.GPU_CriticalTemp.TabIndex = 7;
            // 
            // HDD_CriticalTemp
            // 
            this.HDD_CriticalTemp.Location = new System.Drawing.Point(199, 109);
            this.HDD_CriticalTemp.Name = "HDD_CriticalTemp";
            this.HDD_CriticalTemp.Size = new System.Drawing.Size(100, 20);
            this.HDD_CriticalTemp.TabIndex = 8;
            // 
            // SSD_CriticalTemp
            // 
            this.SSD_CriticalTemp.Location = new System.Drawing.Point(199, 150);
            this.SSD_CriticalTemp.Name = "SSD_CriticalTemp";
            this.SSD_CriticalTemp.Size = new System.Drawing.Size(100, 20);
            this.SSD_CriticalTemp.TabIndex = 9;
            // 
            // MotherBoard__CriticalTemp
            // 
            this.MotherBoard__CriticalTemp.Location = new System.Drawing.Point(199, 231);
            this.MotherBoard__CriticalTemp.Name = "MotherBoard__CriticalTemp";
            this.MotherBoard__CriticalTemp.Size = new System.Drawing.Size(100, 20);
            this.MotherBoard__CriticalTemp.TabIndex = 10;
            // 
            // RAM_CurrentTemp
            // 
            this.RAM_CurrentTemp.AutoSize = true;
            this.RAM_CurrentTemp.Location = new System.Drawing.Point(21, 196);
            this.RAM_CurrentTemp.Name = "RAM_CurrentTemp";
            this.RAM_CurrentTemp.Size = new System.Drawing.Size(37, 13);
            this.RAM_CurrentTemp.TabIndex = 11;
            this.RAM_CurrentTemp.Text = "RAM: ";
            // 
            // RAM_CriticalTemp
            // 
            this.RAM_CriticalTemp.Location = new System.Drawing.Point(199, 193);
            this.RAM_CriticalTemp.Name = "RAM_CriticalTemp";
            this.RAM_CriticalTemp.Size = new System.Drawing.Size(100, 20);
            this.RAM_CriticalTemp.TabIndex = 12;
            // 
            // PowerOFF_CheckBox
            // 
            this.PowerOFF_CheckBox.AutoSize = true;
            this.PowerOFF_CheckBox.Location = new System.Drawing.Point(26, 298);
            this.PowerOFF_CheckBox.Name = "PowerOFF_CheckBox";
            this.PowerOFF_CheckBox.Size = new System.Drawing.Size(79, 17);
            this.PowerOFF_CheckBox.TabIndex = 13;
            this.PowerOFF_CheckBox.Text = "Power OFF";
            this.PowerOFF_CheckBox.UseVisualStyleBackColor = true;
            // 
            // TempSensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 357);
            this.Controls.Add(this.PowerOFF_CheckBox);
            this.Controls.Add(this.RAM_CriticalTemp);
            this.Controls.Add(this.RAM_CurrentTemp);
            this.Controls.Add(this.MotherBoard__CriticalTemp);
            this.Controls.Add(this.SSD_CriticalTemp);
            this.Controls.Add(this.HDD_CriticalTemp);
            this.Controls.Add(this.GPU_CriticalTemp);
            this.Controls.Add(this.MotherBoard_CurrentTemp);
            this.Controls.Add(this.SSD_CurrentTemp);
            this.Controls.Add(this.HDD_CurrentTemp);
            this.Controls.Add(this.GPU_CurrentTemp);
            this.Controls.Add(this.Signal_CheckBox);
            this.Controls.Add(this.CPU_CurrentTemp);
            this.Controls.Add(this.CPU_CriticalTemp);
            this.Name = "TempSensorForm";
            this.Text = "Temperature Sensor v 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CPU_CriticalTemp;
        private System.Windows.Forms.Label CPU_CurrentTemp;
        private System.Windows.Forms.CheckBox Signal_CheckBox;
        private System.Windows.Forms.Label GPU_CurrentTemp;
        private System.Windows.Forms.Label HDD_CurrentTemp;
        private System.Windows.Forms.Label SSD_CurrentTemp;
        private System.Windows.Forms.Label MotherBoard_CurrentTemp;
        private System.Windows.Forms.TextBox GPU_CriticalTemp;
        private System.Windows.Forms.TextBox HDD_CriticalTemp;
        private System.Windows.Forms.TextBox SSD_CriticalTemp;
        private System.Windows.Forms.TextBox MotherBoard__CriticalTemp;
        private System.Windows.Forms.Label RAM_CurrentTemp;
        private System.Windows.Forms.TextBox RAM_CriticalTemp;
        private System.Windows.Forms.CheckBox PowerOFF_CheckBox;
    }
}


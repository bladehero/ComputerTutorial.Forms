namespace PocketComputerTutorial.Forms.Controls.AssemblyComponents
{
    partial class AssemblyComponentList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AssemblyComponentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.dollarSign = new System.Windows.Forms.Label();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CPUButton = new System.Windows.Forms.Button();
            this.RAMButton = new System.Windows.Forms.Button();
            this.GPUButton = new System.Windows.Forms.Button();
            this.PowerUnitButton = new System.Windows.Forms.Button();
            this.MotherboardButton = new System.Windows.Forms.Button();
            this.HDDButton = new System.Windows.Forms.Button();
            this.SSDButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssemblyComponentPanel
            // 
            this.AssemblyComponentPanel.AutoScroll = true;
            this.AssemblyComponentPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.AssemblyComponentPanel.Location = new System.Drawing.Point(3, 3);
            this.AssemblyComponentPanel.Name = "AssemblyComponentPanel";
            this.AssemblyComponentPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AssemblyComponentPanel.Size = new System.Drawing.Size(784, 418);
            this.AssemblyComponentPanel.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Roboto Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(14, 486);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(170, 27);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Assembly Name";
            // 
            // dollarSign
            // 
            this.dollarSign.AutoSize = true;
            this.dollarSign.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dollarSign.Location = new System.Drawing.Point(697, 488);
            this.dollarSign.Name = "dollarSign";
            this.dollarSign.Size = new System.Drawing.Size(19, 20);
            this.dollarSign.TabIndex = 4;
            this.dollarSign.Text = "$";
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentLabel.Location = new System.Drawing.Point(714, 488);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(45, 20);
            this.CurrentLabel.TabIndex = 3;
            this.CurrentLabel.Text = "9999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(697, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "$";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLabel.Location = new System.Drawing.Point(714, 518);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(45, 20);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "9999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(608, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(632, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(70, 521);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(392, 23);
            this.ProgressBar.TabIndex = 9;
            this.ProgressBar.Value = 50;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.RefreshButton.Location = new System.Drawing.Point(538, 480);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(64, 64);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "↺";
            this.RefreshButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.BackButton.Location = new System.Drawing.Point(468, 480);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 64);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "🠔";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Roboto Thin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressLabel.Location = new System.Drawing.Point(16, 523);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(24, 17);
            this.ProgressLabel.TabIndex = 12;
            this.ProgressLabel.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Thin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(46, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "%";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CPUButton);
            this.flowLayoutPanel1.Controls.Add(this.RAMButton);
            this.flowLayoutPanel1.Controls.Add(this.GPUButton);
            this.flowLayoutPanel1.Controls.Add(this.PowerUnitButton);
            this.flowLayoutPanel1.Controls.Add(this.MotherboardButton);
            this.flowLayoutPanel1.Controls.Add(this.HDDButton);
            this.flowLayoutPanel1.Controls.Add(this.SSDButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 427);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 47);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // CPUButton
            // 
            this.CPUButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPUButton.Font = new System.Drawing.Font("Roboto Thin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUButton.Location = new System.Drawing.Point(558, 3);
            this.CPUButton.Name = "CPUButton";
            this.CPUButton.Size = new System.Drawing.Size(223, 41);
            this.CPUButton.TabIndex = 7;
            this.CPUButton.Text = "CPU";
            this.CPUButton.UseVisualStyleBackColor = true;
            this.CPUButton.Visible = false;
            // 
            // RAMButton
            // 
            this.RAMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RAMButton.Font = new System.Drawing.Font("Roboto Thin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAMButton.Location = new System.Drawing.Point(329, 3);
            this.RAMButton.Name = "RAMButton";
            this.RAMButton.Size = new System.Drawing.Size(223, 41);
            this.RAMButton.TabIndex = 8;
            this.RAMButton.Text = "RAM";
            this.RAMButton.UseVisualStyleBackColor = true;
            this.RAMButton.Visible = false;
            // 
            // GPUButton
            // 
            this.GPUButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPUButton.Font = new System.Drawing.Font("Roboto Thin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GPUButton.Location = new System.Drawing.Point(100, 3);
            this.GPUButton.Name = "GPUButton";
            this.GPUButton.Size = new System.Drawing.Size(223, 41);
            this.GPUButton.TabIndex = 9;
            this.GPUButton.Text = "GPU";
            this.GPUButton.UseVisualStyleBackColor = true;
            this.GPUButton.Visible = false;
            // 
            // PowerUnitButton
            // 
            this.PowerUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerUnitButton.Font = new System.Drawing.Font("Roboto Thin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerUnitButton.Location = new System.Drawing.Point(558, 50);
            this.PowerUnitButton.Name = "PowerUnitButton";
            this.PowerUnitButton.Size = new System.Drawing.Size(223, 41);
            this.PowerUnitButton.TabIndex = 10;
            this.PowerUnitButton.Text = "Power Unit";
            this.PowerUnitButton.UseVisualStyleBackColor = true;
            this.PowerUnitButton.Visible = false;
            // 
            // MotherboardButton
            // 
            this.MotherboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MotherboardButton.Font = new System.Drawing.Font("Roboto Thin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MotherboardButton.Location = new System.Drawing.Point(329, 50);
            this.MotherboardButton.Name = "MotherboardButton";
            this.MotherboardButton.Size = new System.Drawing.Size(223, 41);
            this.MotherboardButton.TabIndex = 11;
            this.MotherboardButton.Text = "Motherboard";
            this.MotherboardButton.UseVisualStyleBackColor = true;
            this.MotherboardButton.Visible = false;
            // 
            // HDDButton
            // 
            this.HDDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HDDButton.Font = new System.Drawing.Font("Roboto Thin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HDDButton.Location = new System.Drawing.Point(100, 50);
            this.HDDButton.Name = "HDDButton";
            this.HDDButton.Size = new System.Drawing.Size(223, 41);
            this.HDDButton.TabIndex = 12;
            this.HDDButton.Text = "HDD";
            this.HDDButton.UseVisualStyleBackColor = true;
            this.HDDButton.Visible = false;
            // 
            // SSDButton
            // 
            this.SSDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSDButton.Font = new System.Drawing.Font("Roboto Thin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SSDButton.Location = new System.Drawing.Point(558, 97);
            this.SSDButton.Name = "SSDButton";
            this.SSDButton.Size = new System.Drawing.Size(223, 41);
            this.SSDButton.TabIndex = 13;
            this.SSDButton.Text = "SSD";
            this.SSDButton.UseVisualStyleBackColor = true;
            this.SSDButton.Visible = false;
            // 
            // AssemblyComponentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.dollarSign);
            this.Controls.Add(this.CurrentLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AssemblyComponentPanel);
            this.Name = "AssemblyComponentList";
            this.Size = new System.Drawing.Size(790, 552);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AssemblyComponentPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label dollarSign;
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CPUButton;
        private System.Windows.Forms.Button RAMButton;
        private System.Windows.Forms.Button GPUButton;
        private System.Windows.Forms.Button PowerUnitButton;
        private System.Windows.Forms.Button MotherboardButton;
        private System.Windows.Forms.Button HDDButton;
        private System.Windows.Forms.Button SSDButton;
    }
}

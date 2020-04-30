namespace PocketComputerTutorial.Forms.Controls.Assemblies
{
    partial class AssemblyView
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
            this.AssemblyNameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.dollarSign = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssemblyNameLabel
            // 
            this.AssemblyNameLabel.AutoSize = true;
            this.AssemblyNameLabel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AssemblyNameLabel.Location = new System.Drawing.Point(8, 20);
            this.AssemblyNameLabel.Name = "AssemblyNameLabel";
            this.AssemblyNameLabel.Size = new System.Drawing.Size(187, 29);
            this.AssemblyNameLabel.TabIndex = 0;
            this.AssemblyNameLabel.Text = "Assembly Name";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(30, 53);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(49, 20);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "9999";
            // 
            // dollarSign
            // 
            this.dollarSign.AutoSize = true;
            this.dollarSign.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dollarSign.Location = new System.Drawing.Point(9, 53);
            this.dollarSign.Name = "dollarSign";
            this.dollarSign.Size = new System.Drawing.Size(19, 20);
            this.dollarSign.TabIndex = 2;
            this.dollarSign.Text = "$";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Firebrick;
            this.DeleteButton.Location = new System.Drawing.Point(655, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(64, 64);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "🗑️";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.Transparent;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeButton.Location = new System.Drawing.Point(585, 8);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(64, 64);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "⚙";
            this.ChangeButton.UseVisualStyleBackColor = false;
            // 
            // AssemblyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dollarSign);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AssemblyNameLabel);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "AssemblyView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(727, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AssemblyNameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label dollarSign;
        private System.Windows.Forms.Button DeleteButton;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button ChangeButton;
    }
}

namespace PocketComputerTutorial.Forms.Options
{
    partial class RangeOption
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MinNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxNumeric = new System.Windows.Forms.NumericUpDown();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 11);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(105, 24);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Unit Name";
            // 
            // MinNumeric
            // 
            this.MinNumeric.DecimalPlaces = 1;
            this.MinNumeric.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MinNumeric.Location = new System.Drawing.Point(10, 62);
            this.MinNumeric.Name = "MinNumeric";
            this.MinNumeric.Size = new System.Drawing.Size(156, 28);
            this.MinNumeric.TabIndex = 2;
            // 
            // MaxNumeric
            // 
            this.MaxNumeric.DecimalPlaces = 1;
            this.MaxNumeric.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MaxNumeric.Location = new System.Drawing.Point(181, 62);
            this.MaxNumeric.Name = "MaxNumeric";
            this.MaxNumeric.Size = new System.Drawing.Size(156, 28);
            this.MaxNumeric.TabIndex = 3;
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(7, 42);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(30, 17);
            this.MinLabel.TabIndex = 4;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(178, 42);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(33, 17);
            this.MaxLabel.TabIndex = 5;
            this.MaxLabel.Text = "Max";
            // 
            // RangeOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxNumeric);
            this.Controls.Add(this.MinNumeric);
            this.Controls.Add(this.TitleLabel);
            this.Name = "RangeOption";
            this.Size = new System.Drawing.Size(346, 96);
            ((System.ComponentModel.ISupportInitialize)(this.MinNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.NumericUpDown MinNumeric;
        private System.Windows.Forms.NumericUpDown MaxNumeric;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
    }
}

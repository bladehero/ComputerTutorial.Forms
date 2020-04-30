namespace PocketComputerTutorial.Forms.Controls.Assemblies
{
    partial class AssemblyList
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AssemblyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assemblies";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.Teal;
            this.AddButton.Location = new System.Drawing.Point(709, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(70, 64);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "＋";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // AssemblyPanel
            // 
            this.AssemblyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssemblyPanel.AutoScroll = true;
            this.AssemblyPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AssemblyPanel.Location = new System.Drawing.Point(3, 73);
            this.AssemblyPanel.Name = "AssemblyPanel";
            this.AssemblyPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.AssemblyPanel.Size = new System.Drawing.Size(784, 464);
            this.AssemblyPanel.TabIndex = 3;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.RefreshButton.Location = new System.Drawing.Point(633, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(70, 64);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "↺";
            this.RefreshButton.UseVisualStyleBackColor = false;
            // 
            // AssemblyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AssemblyPanel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AssemblyList";
            this.Size = new System.Drawing.Size(790, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.FlowLayoutPanel AssemblyPanel;
        private System.Windows.Forms.Button RefreshButton;
    }
}

namespace PocketComputerTutorial.Forms.Controls.SearchComponents
{
    partial class SearchComponentList
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
            this.OptionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Label = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OptionPanel
            // 
            this.OptionPanel.AutoScroll = true;
            this.OptionPanel.Location = new System.Drawing.Point(3, 39);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(772, 510);
            this.OptionPanel.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(3, 7);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(102, 29);
            this.Label.TabIndex = 1;
            this.Label.Text = "Options:";
            // 
            // Search
            // 
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Roboto Thin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(670, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(105, 30);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // SearchComponentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.OptionPanel);
            this.Name = "SearchComponentList";
            this.Size = new System.Drawing.Size(778, 552);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OptionPanel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Search;
    }
}

namespace ManagementSystem
{
    partial class ManagementSystemForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.Location = new System.Drawing.Point(0, 64);
            this.mainPanel.MinimumSize = new System.Drawing.Size(1360, 678);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1360, 678);
            this.mainPanel.TabIndex = 0;
            // 
            // ManagementSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1360, 742);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(1360, 678);
            this.Name = "ManagementSystemForm";
            this.Text = "Management System";
            this.Load += new System.EventHandler(this.ManagementSystemForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        public AuthorityUserControl AuthorityUserControl { get; set; }
        public UserControlMainMenu UserControlMainMenu { get; set; }
        public UserAddControl UserAddControl { get; set; }
    }
}
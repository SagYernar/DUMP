namespace ManagementSystem
{
    partial class AuthorityUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.languagePickButtonKZ = new MaterialSkin.Controls.MaterialRaisedButton();
            this.languagePickButtonRU = new MaterialSkin.Controls.MaterialRaisedButton();
            this.languagePickButtonEN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loginLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.submitAuthorization = new MaterialSkin.Controls.MaterialRaisedButton();
            this.incorrectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.authorityPanel = new System.Windows.Forms.Panel();
            this.authorityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // languagePickButtonKZ
            // 
            this.languagePickButtonKZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.languagePickButtonKZ.AutoSize = true;
            this.languagePickButtonKZ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.languagePickButtonKZ.Depth = 0;
            this.languagePickButtonKZ.Location = new System.Drawing.Point(525, 466);
            this.languagePickButtonKZ.MinimumSize = new System.Drawing.Size(50, 50);
            this.languagePickButtonKZ.MouseState = MaterialSkin.MouseState.HOVER;
            this.languagePickButtonKZ.Name = "languagePickButtonKZ";
            this.languagePickButtonKZ.Primary = true;
            this.languagePickButtonKZ.Size = new System.Drawing.Size(50, 50);
            this.languagePickButtonKZ.TabIndex = 0;
            this.languagePickButtonKZ.Text = "KZ";
            this.languagePickButtonKZ.UseVisualStyleBackColor = true;
            this.languagePickButtonKZ.Click += new System.EventHandler(this.LanguagePickButtonKZ_Click);
            // 
            // languagePickButtonRU
            // 
            this.languagePickButtonRU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.languagePickButtonRU.AutoSize = true;
            this.languagePickButtonRU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.languagePickButtonRU.Depth = 0;
            this.languagePickButtonRU.Location = new System.Drawing.Point(641, 466);
            this.languagePickButtonRU.MinimumSize = new System.Drawing.Size(50, 50);
            this.languagePickButtonRU.MouseState = MaterialSkin.MouseState.HOVER;
            this.languagePickButtonRU.Name = "languagePickButtonRU";
            this.languagePickButtonRU.Primary = true;
            this.languagePickButtonRU.Size = new System.Drawing.Size(50, 50);
            this.languagePickButtonRU.TabIndex = 1;
            this.languagePickButtonRU.Text = "RU";
            this.languagePickButtonRU.UseVisualStyleBackColor = true;
            this.languagePickButtonRU.Click += new System.EventHandler(this.LanguagePickButtonRU_Click);
            // 
            // languagePickButtonEN
            // 
            this.languagePickButtonEN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.languagePickButtonEN.AutoSize = true;
            this.languagePickButtonEN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.languagePickButtonEN.Depth = 0;
            this.languagePickButtonEN.Location = new System.Drawing.Point(757, 466);
            this.languagePickButtonEN.MinimumSize = new System.Drawing.Size(50, 50);
            this.languagePickButtonEN.MouseState = MaterialSkin.MouseState.HOVER;
            this.languagePickButtonEN.Name = "languagePickButtonEN";
            this.languagePickButtonEN.Primary = true;
            this.languagePickButtonEN.Size = new System.Drawing.Size(50, 50);
            this.languagePickButtonEN.TabIndex = 2;
            this.languagePickButtonEN.Text = "EN";
            this.languagePickButtonEN.UseVisualStyleBackColor = true;
            this.languagePickButtonEN.Click += new System.EventHandler(this.LanguagePickButtonEN_Click);
            // 
            // loginLineTextField
            // 
            this.loginLineTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLineTextField.Depth = 0;
            this.loginLineTextField.Hint = global::ManagementSystem.Properties.Resources.Login;
            this.loginLineTextField.Location = new System.Drawing.Point(592, 272);
            this.loginLineTextField.MinimumSize = new System.Drawing.Size(150, 25);
            this.loginLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginLineTextField.Name = "loginLineTextField";
            this.loginLineTextField.PasswordChar = '\0';
            this.loginLineTextField.SelectedText = "";
            this.loginLineTextField.SelectionLength = 0;
            this.loginLineTextField.SelectionStart = 0;
            this.loginLineTextField.Size = new System.Drawing.Size(150, 25);
            this.loginLineTextField.TabIndex = 3;
            this.loginLineTextField.TabStop = false;
            this.loginLineTextField.UseSystemPasswordChar = false;
            // 
            // passwordLineTextField
            // 
            this.passwordLineTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLineTextField.Depth = 0;
            this.passwordLineTextField.Hint = global::ManagementSystem.Properties.Resources.Password;
            this.passwordLineTextField.Location = new System.Drawing.Point(592, 320);
            this.passwordLineTextField.MinimumSize = new System.Drawing.Size(150, 25);
            this.passwordLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLineTextField.Name = "passwordLineTextField";
            this.passwordLineTextField.PasswordChar = '\0';
            this.passwordLineTextField.SelectedText = "";
            this.passwordLineTextField.SelectionLength = 0;
            this.passwordLineTextField.SelectionStart = 0;
            this.passwordLineTextField.Size = new System.Drawing.Size(150, 25);
            this.passwordLineTextField.TabIndex = 4;
            this.passwordLineTextField.TabStop = false;
            this.passwordLineTextField.UseSystemPasswordChar = true;
            // 
            // submitAuthorization
            // 
            this.submitAuthorization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitAuthorization.AutoSize = true;
            this.submitAuthorization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitAuthorization.Depth = 0;
            this.submitAuthorization.Location = new System.Drawing.Point(610, 387);
            this.submitAuthorization.MinimumSize = new System.Drawing.Size(100, 40);
            this.submitAuthorization.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitAuthorization.Name = "submitAuthorization";
            this.submitAuthorization.Primary = true;
            this.submitAuthorization.Size = new System.Drawing.Size(100, 40);
            this.submitAuthorization.TabIndex = 5;
            this.submitAuthorization.Text = global::ManagementSystem.Properties.Resources.SignIn;
            this.submitAuthorization.UseVisualStyleBackColor = true;
            this.submitAuthorization.Click += new System.EventHandler(this.SubmitAuthorization_Click);
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.Depth = 0;
            this.incorrectLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.incorrectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incorrectLabel.Location = new System.Drawing.Point(564, 217);
            this.incorrectLabel.MinimumSize = new System.Drawing.Size(200, 20);
            this.incorrectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(200, 20);
            this.incorrectLabel.TabIndex = 6;
            this.incorrectLabel.Text = "Incorrect login or password";
            this.incorrectLabel.Visible = false;
            // 
            // authorityPanel
            // 
            this.authorityPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorityPanel.Controls.Add(this.incorrectLabel);
            this.authorityPanel.Controls.Add(this.submitAuthorization);
            this.authorityPanel.Controls.Add(this.passwordLineTextField);
            this.authorityPanel.Controls.Add(this.loginLineTextField);
            this.authorityPanel.Controls.Add(this.languagePickButtonEN);
            this.authorityPanel.Controls.Add(this.languagePickButtonRU);
            this.authorityPanel.Controls.Add(this.languagePickButtonKZ);
            this.authorityPanel.Location = new System.Drawing.Point(0, 0);
            this.authorityPanel.MinimumSize = new System.Drawing.Size(1360, 678);
            this.authorityPanel.Name = "authorityPanel";
            this.authorityPanel.Size = new System.Drawing.Size(1360, 678);
            this.authorityPanel.TabIndex = 7;
            // 
            // AuthorityUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.authorityPanel);
            this.MinimumSize = new System.Drawing.Size(1360, 678);
            this.Name = "AuthorityUserControl";
            this.Size = new System.Drawing.Size(1360, 678);
            this.authorityPanel.ResumeLayout(false);
            this.authorityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton languagePickButtonKZ;
        private MaterialSkin.Controls.MaterialRaisedButton languagePickButtonRU;
        private MaterialSkin.Controls.MaterialRaisedButton languagePickButtonEN;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton submitAuthorization;
        private MaterialSkin.Controls.MaterialLabel incorrectLabel;
        private System.Windows.Forms.Panel authorityPanel;
    }
}

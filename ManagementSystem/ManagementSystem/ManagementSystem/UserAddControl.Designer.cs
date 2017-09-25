namespace ManagementSystem
{
    partial class UserAddControl
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
            this.fullNameLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.accessLevelLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addUserButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ratingLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.positionLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CancelFromAddUserButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fillErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.fillInputErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // fullNameLineTextField
            // 
            this.fullNameLineTextField.Depth = 0;
            this.fullNameLineTextField.Hint = "";
            this.fullNameLineTextField.Location = new System.Drawing.Point(48, 64);
            this.fullNameLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.fullNameLineTextField.Name = "fullNameLineTextField";
            this.fullNameLineTextField.PasswordChar = '\0';
            this.fullNameLineTextField.SelectedText = "";
            this.fullNameLineTextField.SelectionLength = 0;
            this.fullNameLineTextField.SelectionStart = 0;
            this.fullNameLineTextField.Size = new System.Drawing.Size(297, 23);
            this.fullNameLineTextField.TabIndex = 0;
            this.fullNameLineTextField.TabStop = false;
            this.fullNameLineTextField.UseSystemPasswordChar = false;
            // 
            // accessLevelLineTextField
            // 
            this.accessLevelLineTextField.Depth = 0;
            this.accessLevelLineTextField.Hint = "";
            this.accessLevelLineTextField.Location = new System.Drawing.Point(48, 93);
            this.accessLevelLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.accessLevelLineTextField.Name = "accessLevelLineTextField";
            this.accessLevelLineTextField.PasswordChar = '\0';
            this.accessLevelLineTextField.SelectedText = "";
            this.accessLevelLineTextField.SelectionLength = 0;
            this.accessLevelLineTextField.SelectionStart = 0;
            this.accessLevelLineTextField.Size = new System.Drawing.Size(297, 23);
            this.accessLevelLineTextField.TabIndex = 6;
            this.accessLevelLineTextField.TabStop = false;
            this.accessLevelLineTextField.UseSystemPasswordChar = false;
            // 
            // addUserButton
            // 
            this.addUserButton.AutoSize = true;
            this.addUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addUserButton.Depth = 0;
            this.addUserButton.Location = new System.Drawing.Point(50, 401);
            this.addUserButton.MinimumSize = new System.Drawing.Size(100, 36);
            this.addUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Primary = true;
            this.addUserButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addUserButton.Size = new System.Drawing.Size(100, 36);
            this.addUserButton.TabIndex = 9;
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // ratingLineTextField
            // 
            this.ratingLineTextField.Depth = 0;
            this.ratingLineTextField.Hint = "";
            this.ratingLineTextField.Location = new System.Drawing.Point(48, 217);
            this.ratingLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.ratingLineTextField.Name = "ratingLineTextField";
            this.ratingLineTextField.PasswordChar = '\0';
            this.ratingLineTextField.SelectedText = "";
            this.ratingLineTextField.SelectionLength = 0;
            this.ratingLineTextField.SelectionStart = 0;
            this.ratingLineTextField.Size = new System.Drawing.Size(297, 23);
            this.ratingLineTextField.TabIndex = 16;
            this.ratingLineTextField.TabStop = false;
            this.ratingLineTextField.UseSystemPasswordChar = false;
            // 
            // positionLineTextField
            // 
            this.positionLineTextField.Depth = 0;
            this.positionLineTextField.Hint = "";
            this.positionLineTextField.Location = new System.Drawing.Point(48, 186);
            this.positionLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.positionLineTextField.Name = "positionLineTextField";
            this.positionLineTextField.PasswordChar = '\0';
            this.positionLineTextField.SelectedText = "";
            this.positionLineTextField.SelectionLength = 0;
            this.positionLineTextField.SelectionStart = 0;
            this.positionLineTextField.Size = new System.Drawing.Size(297, 23);
            this.positionLineTextField.TabIndex = 14;
            this.positionLineTextField.TabStop = false;
            this.positionLineTextField.UseSystemPasswordChar = false;
            // 
            // passwordLineTextField
            // 
            this.passwordLineTextField.Depth = 0;
            this.passwordLineTextField.Hint = "";
            this.passwordLineTextField.Location = new System.Drawing.Point(48, 156);
            this.passwordLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLineTextField.Name = "passwordLineTextField";
            this.passwordLineTextField.PasswordChar = '\0';
            this.passwordLineTextField.SelectedText = "";
            this.passwordLineTextField.SelectionLength = 0;
            this.passwordLineTextField.SelectionStart = 0;
            this.passwordLineTextField.Size = new System.Drawing.Size(297, 23);
            this.passwordLineTextField.TabIndex = 12;
            this.passwordLineTextField.TabStop = false;
            this.passwordLineTextField.UseSystemPasswordChar = false;
            // 
            // loginLineTextField
            // 
            this.loginLineTextField.Depth = 0;
            this.loginLineTextField.Hint = "";
            this.loginLineTextField.Location = new System.Drawing.Point(48, 125);
            this.loginLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginLineTextField.Name = "loginLineTextField";
            this.loginLineTextField.PasswordChar = '\0';
            this.loginLineTextField.SelectedText = "";
            this.loginLineTextField.SelectionLength = 0;
            this.loginLineTextField.SelectionStart = 0;
            this.loginLineTextField.Size = new System.Drawing.Size(297, 23);
            this.loginLineTextField.TabIndex = 10;
            this.loginLineTextField.TabStop = false;
            this.loginLineTextField.UseSystemPasswordChar = false;
            // 
            // CancelFromAddUserButton
            // 
            this.CancelFromAddUserButton.AutoSize = true;
            this.CancelFromAddUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelFromAddUserButton.Depth = 0;
            this.CancelFromAddUserButton.Location = new System.Drawing.Point(243, 401);
            this.CancelFromAddUserButton.MinimumSize = new System.Drawing.Size(100, 36);
            this.CancelFromAddUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelFromAddUserButton.Name = "CancelFromAddUserButton";
            this.CancelFromAddUserButton.Primary = true;
            this.CancelFromAddUserButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelFromAddUserButton.Size = new System.Drawing.Size(100, 36);
            this.CancelFromAddUserButton.TabIndex = 18;
            this.CancelFromAddUserButton.UseVisualStyleBackColor = true;
            // 
            // fillErrorLabel
            // 
            this.fillErrorLabel.AutoSize = true;
            this.fillErrorLabel.Depth = 0;
            this.fillErrorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fillErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.fillErrorLabel.Location = new System.Drawing.Point(52, 293);
            this.fillErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fillErrorLabel.Name = "fillErrorLabel";
            this.fillErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.fillErrorLabel.TabIndex = 19;
            this.fillErrorLabel.Visible = false;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(192, 246);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(153, 20);
            this.dateOfBirthPicker.TabIndex = 20;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(44, 246);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(0, 20);
            this.dateOfBirthLabel.TabIndex = 21;
            // 
            // fillInputErrorLabel
            // 
            this.fillInputErrorLabel.AutoSize = true;
            this.fillInputErrorLabel.Depth = 0;
            this.fillInputErrorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fillInputErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fillInputErrorLabel.Location = new System.Drawing.Point(52, 333);
            this.fillInputErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fillInputErrorLabel.Name = "fillInputErrorLabel";
            this.fillInputErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.fillInputErrorLabel.TabIndex = 22;
            this.fillInputErrorLabel.Visible = false;
            // 
            // UserAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillInputErrorLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.fillErrorLabel);
            this.Controls.Add(this.CancelFromAddUserButton);
            this.Controls.Add(this.ratingLineTextField);
            this.Controls.Add(this.positionLineTextField);
            this.Controls.Add(this.passwordLineTextField);
            this.Controls.Add(this.loginLineTextField);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.accessLevelLineTextField);
            this.Controls.Add(this.fullNameLineTextField);
            this.Name = "UserAddControl";
            this.Size = new System.Drawing.Size(400, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField fullNameLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField accessLevelLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton addUserButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField ratingLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField positionLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton CancelFromAddUserButton;
        private MaterialSkin.Controls.MaterialLabel fillErrorLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private MaterialSkin.Controls.MaterialLabel fillInputErrorLabel;
    }
}

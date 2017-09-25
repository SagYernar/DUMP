namespace ManagementSystem
{
    partial class UserControlMainMenu
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
            this.MaterialLabelPosition = new MaterialSkin.Controls.MaterialLabel();
            this.MaterialLabelFullName = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPageNewTask = new System.Windows.Forms.TabPage();
            this.reCreationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deadlineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toWhatCategoryTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.createTaskButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.createRequestButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.priorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.descriptionTaskTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nameOfTaskTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.StandartTaskButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.SelectedTaskButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.AutomaticTaskButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.TabPageCurrentTasks = new System.Windows.Forms.TabPage();
            this.TabPageMonitoring = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userMenuPanel = new System.Windows.Forms.Panel();
            this.menuTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPageNewTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumeric)).BeginInit();
            this.userMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaterialLabelPosition
            // 
            this.MaterialLabelPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaterialLabelPosition.AutoSize = true;
            this.MaterialLabelPosition.BackColor = System.Drawing.SystemColors.Window;
            this.MaterialLabelPosition.Depth = 0;
            this.MaterialLabelPosition.Font = new System.Drawing.Font("Roboto", 11F);
            this.MaterialLabelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaterialLabelPosition.Location = new System.Drawing.Point(451, 129);
            this.MaterialLabelPosition.MinimumSize = new System.Drawing.Size(300, 20);
            this.MaterialLabelPosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialLabelPosition.Name = "MaterialLabelPosition";
            this.MaterialLabelPosition.Size = new System.Drawing.Size(300, 20);
            this.MaterialLabelPosition.TabIndex = 11;
            this.MaterialLabelPosition.Text = "Position";
            // 
            // MaterialLabelFullName
            // 
            this.MaterialLabelFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaterialLabelFullName.AutoSize = true;
            this.MaterialLabelFullName.BackColor = System.Drawing.SystemColors.Window;
            this.MaterialLabelFullName.Depth = 0;
            this.MaterialLabelFullName.Font = new System.Drawing.Font("Roboto", 11F);
            this.MaterialLabelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaterialLabelFullName.Location = new System.Drawing.Point(451, 87);
            this.MaterialLabelFullName.MinimumSize = new System.Drawing.Size(300, 20);
            this.MaterialLabelFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialLabelFullName.Name = "MaterialLabelFullName";
            this.MaterialLabelFullName.Size = new System.Drawing.Size(300, 20);
            this.MaterialLabelFullName.TabIndex = 10;
            this.MaterialLabelFullName.Text = "Full Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(303, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 82);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabControl.Controls.Add(this.TabPageNewTask);
            this.TabControl.Controls.Add(this.TabPageCurrentTasks);
            this.TabControl.Controls.Add(this.TabPageMonitoring);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(293, 249);
            this.TabControl.MinimumSize = new System.Drawing.Size(690, 330);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(690, 330);
            this.TabControl.TabIndex = 8;
            // 
            // TabPageNewTask
            // 
            this.TabPageNewTask.BackColor = System.Drawing.Color.White;
            this.TabPageNewTask.Controls.Add(this.reCreationTimePicker);
            this.TabPageNewTask.Controls.Add(this.deadlineTimePicker);
            this.TabPageNewTask.Controls.Add(this.toWhatCategoryTextField);
            this.TabPageNewTask.Controls.Add(this.createTaskButton);
            this.TabPageNewTask.Controls.Add(this.createRequestButton);
            this.TabPageNewTask.Controls.Add(this.priorityNumeric);
            this.TabPageNewTask.Controls.Add(this.descriptionTaskTextField);
            this.TabPageNewTask.Controls.Add(this.nameOfTaskTextField);
            this.TabPageNewTask.Controls.Add(this.StandartTaskButton);
            this.TabPageNewTask.Controls.Add(this.SelectedTaskButton);
            this.TabPageNewTask.Controls.Add(this.AutomaticTaskButton);
            this.TabPageNewTask.Location = new System.Drawing.Point(4, 22);
            this.TabPageNewTask.Name = "TabPageNewTask";
            this.TabPageNewTask.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNewTask.Size = new System.Drawing.Size(682, 304);
            this.TabPageNewTask.TabIndex = 0;
            this.TabPageNewTask.Text = "Create New Task";
            // 
            // reCreationTimePicker
            // 
            this.reCreationTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reCreationTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reCreationTimePicker.Location = new System.Drawing.Point(283, 160);
            this.reCreationTimePicker.MinimumSize = new System.Drawing.Size(250, 30);
            this.reCreationTimePicker.Name = "reCreationTimePicker";
            this.reCreationTimePicker.ShowUpDown = true;
            this.reCreationTimePicker.Size = new System.Drawing.Size(250, 30);
            this.reCreationTimePicker.TabIndex = 10;
            this.reCreationTimePicker.Visible = false;
            // 
            // deadlineTimePicker
            // 
            this.deadlineTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deadlineTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deadlineTimePicker.Location = new System.Drawing.Point(283, 110);
            this.deadlineTimePicker.MinimumSize = new System.Drawing.Size(250, 30);
            this.deadlineTimePicker.Name = "deadlineTimePicker";
            this.deadlineTimePicker.ShowUpDown = true;
            this.deadlineTimePicker.Size = new System.Drawing.Size(250, 30);
            this.deadlineTimePicker.TabIndex = 9;
            this.deadlineTimePicker.ValueChanged += new System.EventHandler(this.DeadlineTimePicker_ValueChanged);
            // 
            // toWhatCategoryTextField
            // 
            this.toWhatCategoryTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toWhatCategoryTextField.Depth = 0;
            this.toWhatCategoryTextField.Hint = global::ManagementSystem.Properties.Resources.Category;
            this.toWhatCategoryTextField.Location = new System.Drawing.Point(29, 169);
            this.toWhatCategoryTextField.MinimumSize = new System.Drawing.Size(200, 30);
            this.toWhatCategoryTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.toWhatCategoryTextField.Name = "toWhatCategoryTextField";
            this.toWhatCategoryTextField.PasswordChar = '\0';
            this.toWhatCategoryTextField.SelectedText = "";
            this.toWhatCategoryTextField.SelectionLength = 0;
            this.toWhatCategoryTextField.SelectionStart = 0;
            this.toWhatCategoryTextField.Size = new System.Drawing.Size(200, 30);
            this.toWhatCategoryTextField.TabIndex = 8;
            this.toWhatCategoryTextField.TabStop = false;
            this.toWhatCategoryTextField.UseSystemPasswordChar = false;
            // 
            // createTaskButton
            // 
            this.createTaskButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createTaskButton.Depth = 0;
            this.createTaskButton.Location = new System.Drawing.Point(408, 239);
            this.createTaskButton.MinimumSize = new System.Drawing.Size(200, 40);
            this.createTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Primary = true;
            this.createTaskButton.Size = new System.Drawing.Size(200, 40);
            this.createTaskButton.TabIndex = 7;
            this.createTaskButton.Text = global::ManagementSystem.Properties.Resources.CreateTask;
            this.createTaskButton.UseVisualStyleBackColor = true;
            // 
            // createRequestButton
            // 
            this.createRequestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createRequestButton.Depth = 0;
            this.createRequestButton.Location = new System.Drawing.Point(56, 239);
            this.createRequestButton.MinimumSize = new System.Drawing.Size(200, 40);
            this.createRequestButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createRequestButton.Name = "createRequestButton";
            this.createRequestButton.Primary = true;
            this.createRequestButton.Size = new System.Drawing.Size(200, 40);
            this.createRequestButton.TabIndex = 6;
            this.createRequestButton.Text = global::ManagementSystem.Properties.Resources.CreateRequest;
            this.createRequestButton.UseVisualStyleBackColor = true;
            // 
            // priorityNumeric
            // 
            this.priorityNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priorityNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priorityNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priorityNumeric.Location = new System.Drawing.Point(283, 69);
            this.priorityNumeric.MinimumSize = new System.Drawing.Size(250, 0);
            this.priorityNumeric.Name = "priorityNumeric";
            this.priorityNumeric.Size = new System.Drawing.Size(250, 19);
            this.priorityNumeric.TabIndex = 5;
            // 
            // descriptionTaskTextField
            // 
            this.descriptionTaskTextField.Depth = 0;
            this.descriptionTaskTextField.Hint = global::ManagementSystem.Properties.Resources.DescriptionOfTask;
            this.descriptionTaskTextField.Location = new System.Drawing.Point(29, 120);
            this.descriptionTaskTextField.MinimumSize = new System.Drawing.Size(200, 30);
            this.descriptionTaskTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.descriptionTaskTextField.Name = "descriptionTaskTextField";
            this.descriptionTaskTextField.PasswordChar = '\0';
            this.descriptionTaskTextField.SelectedText = "";
            this.descriptionTaskTextField.SelectionLength = 0;
            this.descriptionTaskTextField.SelectionStart = 0;
            this.descriptionTaskTextField.Size = new System.Drawing.Size(200, 30);
            this.descriptionTaskTextField.TabIndex = 4;
            this.descriptionTaskTextField.UseSystemPasswordChar = false;
            // 
            // nameOfTaskTextField
            // 
            this.nameOfTaskTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOfTaskTextField.Depth = 0;
            this.nameOfTaskTextField.Hint = global::ManagementSystem.Properties.Resources.NameOfTask;
            this.nameOfTaskTextField.Location = new System.Drawing.Point(29, 69);
            this.nameOfTaskTextField.MinimumSize = new System.Drawing.Size(200, 30);
            this.nameOfTaskTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameOfTaskTextField.Name = "nameOfTaskTextField";
            this.nameOfTaskTextField.PasswordChar = '\0';
            this.nameOfTaskTextField.SelectedText = "";
            this.nameOfTaskTextField.SelectionLength = 0;
            this.nameOfTaskTextField.SelectionStart = 0;
            this.nameOfTaskTextField.Size = new System.Drawing.Size(200, 30);
            this.nameOfTaskTextField.TabIndex = 3;
            this.nameOfTaskTextField.UseSystemPasswordChar = false;
            // 
            // StandartTaskButton
            // 
            this.StandartTaskButton.AutoSize = true;
            this.StandartTaskButton.Depth = 0;
            this.StandartTaskButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.StandartTaskButton.Location = new System.Drawing.Point(438, 18);
            this.StandartTaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.StandartTaskButton.MinimumSize = new System.Drawing.Size(170, 30);
            this.StandartTaskButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StandartTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StandartTaskButton.Name = "StandartTaskButton";
            this.StandartTaskButton.Ripple = true;
            this.StandartTaskButton.Size = new System.Drawing.Size(170, 30);
            this.StandartTaskButton.TabIndex = 2;
            this.StandartTaskButton.TabStop = true;
            this.StandartTaskButton.Text = "Create Task";
            this.StandartTaskButton.UseVisualStyleBackColor = true;
            this.StandartTaskButton.CheckedChanged += new System.EventHandler(this.StandartTaskButton_CheckedChanged);
            // 
            // SelectedTaskButton
            // 
            this.SelectedTaskButton.AutoSize = true;
            this.SelectedTaskButton.Depth = 0;
            this.SelectedTaskButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.SelectedTaskButton.Location = new System.Drawing.Point(237, 18);
            this.SelectedTaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedTaskButton.MinimumSize = new System.Drawing.Size(170, 30);
            this.SelectedTaskButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SelectedTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectedTaskButton.Name = "SelectedTaskButton";
            this.SelectedTaskButton.Ripple = true;
            this.SelectedTaskButton.Size = new System.Drawing.Size(170, 30);
            this.SelectedTaskButton.TabIndex = 1;
            this.SelectedTaskButton.TabStop = true;
            this.SelectedTaskButton.Text = "Create Selected Task";
            this.SelectedTaskButton.UseVisualStyleBackColor = true;
            this.SelectedTaskButton.CheckedChanged += new System.EventHandler(this.SelectedTaskButton_CheckedChanged);
            // 
            // AutomaticTaskButton
            // 
            this.AutomaticTaskButton.AutoSize = true;
            this.AutomaticTaskButton.Depth = 0;
            this.AutomaticTaskButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.AutomaticTaskButton.Location = new System.Drawing.Point(29, 18);
            this.AutomaticTaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.AutomaticTaskButton.MinimumSize = new System.Drawing.Size(170, 30);
            this.AutomaticTaskButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AutomaticTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutomaticTaskButton.Name = "AutomaticTaskButton";
            this.AutomaticTaskButton.Ripple = true;
            this.AutomaticTaskButton.Size = new System.Drawing.Size(170, 30);
            this.AutomaticTaskButton.TabIndex = 0;
            this.AutomaticTaskButton.TabStop = true;
            this.AutomaticTaskButton.Text = "Create Automatic Task";
            this.AutomaticTaskButton.UseVisualStyleBackColor = true;
            this.AutomaticTaskButton.CheckedChanged += new System.EventHandler(this.AutomaticTaskButton_CheckedChanged);
            // 
            // TabPageCurrentTasks
            // 
            this.TabPageCurrentTasks.Location = new System.Drawing.Point(4, 22);
            this.TabPageCurrentTasks.Name = "TabPageCurrentTasks";
            this.TabPageCurrentTasks.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageCurrentTasks.Size = new System.Drawing.Size(682, 304);
            this.TabPageCurrentTasks.TabIndex = 1;
            this.TabPageCurrentTasks.Text = "Current Tasks";
            this.TabPageCurrentTasks.UseVisualStyleBackColor = true;
            // 
            // TabPageMonitoring
            // 
            this.TabPageMonitoring.Location = new System.Drawing.Point(4, 22);
            this.TabPageMonitoring.Name = "TabPageMonitoring";
            this.TabPageMonitoring.Size = new System.Drawing.Size(682, 304);
            this.TabPageMonitoring.TabIndex = 2;
            this.TabPageMonitoring.Text = "Monitoring";
            this.TabPageMonitoring.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 304);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Statistic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userMenuPanel
            // 
            this.userMenuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userMenuPanel.Controls.Add(this.menuTabSelector);
            this.userMenuPanel.Controls.Add(this.MaterialLabelPosition);
            this.userMenuPanel.Controls.Add(this.MaterialLabelFullName);
            this.userMenuPanel.Controls.Add(this.pictureBox1);
            this.userMenuPanel.Controls.Add(this.TabControl);
            this.userMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.userMenuPanel.MinimumSize = new System.Drawing.Size(1360, 678);
            this.userMenuPanel.Name = "userMenuPanel";
            this.userMenuPanel.Size = new System.Drawing.Size(1360, 678);
            this.userMenuPanel.TabIndex = 15;
            // 
            // menuTabSelector
            // 
            this.menuTabSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuTabSelector.BaseTabControl = this.TabControl;
            this.menuTabSelector.Depth = 0;
            this.menuTabSelector.Location = new System.Drawing.Point(293, 191);
            this.menuTabSelector.MinimumSize = new System.Drawing.Size(400, 50);
            this.menuTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuTabSelector.Name = "menuTabSelector";
            this.menuTabSelector.Size = new System.Drawing.Size(686, 52);
            this.menuTabSelector.TabIndex = 3;
            // 
            // UserControlMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userMenuPanel);
            this.Location = new System.Drawing.Point(0, 64);
            this.MinimumSize = new System.Drawing.Size(1360, 678);
            this.Name = "UserControlMainMenu";
            this.Size = new System.Drawing.Size(1360, 678);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPageNewTask.ResumeLayout(false);
            this.TabPageNewTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumeric)).EndInit();
            this.userMenuPanel.ResumeLayout(false);
            this.userMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel MaterialLabelPosition;
        private MaterialSkin.Controls.MaterialLabel MaterialLabelFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage TabPageCurrentTasks;
        private System.Windows.Forms.TabPage TabPageMonitoring;
        private System.Windows.Forms.Panel userMenuPanel;
        private MaterialSkin.Controls.MaterialTabSelector menuTabSelector;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TabPageNewTask;
        private MaterialSkin.Controls.MaterialRadioButton StandartTaskButton;
        private MaterialSkin.Controls.MaterialRadioButton SelectedTaskButton;
        private MaterialSkin.Controls.MaterialRadioButton AutomaticTaskButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameOfTaskTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField descriptionTaskTextField;
        private System.Windows.Forms.NumericUpDown priorityNumeric;
        private MaterialSkin.Controls.MaterialRaisedButton createTaskButton;
        private MaterialSkin.Controls.MaterialRaisedButton createRequestButton;
        private System.Windows.Forms.DateTimePicker reCreationTimePicker;
        private System.Windows.Forms.DateTimePicker deadlineTimePicker;
        private MaterialSkin.Controls.MaterialSingleLineTextField toWhatCategoryTextField;
    }
}

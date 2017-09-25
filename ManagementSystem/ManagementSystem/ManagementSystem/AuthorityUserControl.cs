using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ManagementSystem
{
    public partial class AuthorityUserControl : UserControl
    {
        private readonly MaterialSkinManager materialSkinManager;
        private ServiceAuthorization serviceAuthorization;
        public AuthorityUserControl()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            this.incorrectLabel.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            serviceAuthorization = new ServiceAuthorization();
        }

        private void LanguagePickButtonKZ_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("kk-KZ");
            loginLineTextField.Hint = Properties.Resources.Login;
            passwordLineTextField.Hint = Properties.Resources.Password;
            submitAuthorization.Text = Properties.Resources.SignIn;
            incorrectLabel.Text = Properties.Resources.IncorrectLoginOrPassword;
        }

        private void LanguagePickButtonRU_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
            loginLineTextField.Hint = Properties.Resources.Login;
            passwordLineTextField.Hint = Properties.Resources.Password;
            submitAuthorization.Text = Properties.Resources.SignIn;
            incorrectLabel.Text = Properties.Resources.IncorrectLoginOrPassword;
        }

        private void LanguagePickButtonEN_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            loginLineTextField.Hint = Properties.Resources.Login;
            passwordLineTextField.Hint = Properties.Resources.Password;
            submitAuthorization.Text = Properties.Resources.SignIn;
            incorrectLabel.Text = Properties.Resources.IncorrectLoginOrPassword;
        }

        private void SubmitAuthorization_Click(object sender, EventArgs e)
        {
            if (!((loginLineTextField.Text == "") || (passwordLineTextField.Text == "")))
            {
                if (loginLineTextField.Text[0] >= '0' && loginLineTextField.Text[0] <= '9')
                {
                    loginLineTextField.Text = "";
                    passwordLineTextField.Text = "";
                    incorrectLabel.ForeColor = Color.Red;
                    incorrectLabel.Visible = true;
                }
                else if (serviceAuthorization.AuthorityVerify(loginLineTextField.Text, passwordLineTextField.Text))
                {
                    (Form.ActiveForm as ManagementSystemForm).AuthorityUserControl.Visible = false;
                    (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Add((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu);
                    (Form.ActiveForm as ManagementSystemForm).Size= new Size(860,570);
                    (Form.ActiveForm as ManagementSystemForm).MainPanel.Size= new Size(860, 560);
                    (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Remove((Form.ActiveForm as ManagementSystemForm).AuthorityUserControl);
                }
                else
                {
                    loginLineTextField.Text = "";
                    passwordLineTextField.Text = "";
                    incorrectLabel.Visible = true;
                }
            }
        }
    }
}

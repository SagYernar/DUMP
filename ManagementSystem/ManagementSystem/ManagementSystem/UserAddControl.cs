using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class UserAddControl : UserControl
    {
        public int numberForParsing;

        public UserAddControl()
        {
            InitializeComponent();
            fullNameLineTextField.Hint = Properties.Resources.FullName;
            //ageLineTextField.Hint = Properties.Resources.Age;
            dateOfBirthLabel.Text = Properties.Resources.DateOfBirth;
            accessLevelLineTextField.Hint = Properties.Resources.AccessLevel;
            loginLineTextField.Hint = Properties.Resources.Login;
            passwordLineTextField.Hint = Properties.Resources.Password;
            positionLineTextField.Hint = Properties.Resources.Position;
            ratingLineTextField.Hint = Properties.Resources.Rating;
            fillErrorLabel.Text = Properties.Resources.FillError;
            fillInputErrorLabel.Text = Properties.Resources.IncorrectValue;
            addUserButton.Text = Properties.Resources.Add;
            CancelFromAddUserButton.Text = Properties.Resources.Cancel;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (
                !(fullNameLineTextField.Text == "") && 
                //!(ageLineTextField.Text == "") &&
                !(accessLevelLineTextField.Text == "") &&
                !(loginLineTextField.Text == "") &&
                !(passwordLineTextField.Text == "") &&
                !(positionLineTextField.Text == "") &&
                !(ratingLineTextField.Text == "")
                )
            {
                if (//Int32.TryParse(ageLineTextField.Text, out numberForParsing) &&
                    Int32.TryParse(accessLevelLineTextField.Text, out numberForParsing) &&
                    Int32.TryParse(ratingLineTextField.Text, out numberForParsing)
                    )
                {
                    if(//Int32.Parse(ageLineTextField.Text)>14 && 
                       //Int32.Parse(ageLineTextField.Text) < 100 &&
                       Int32.Parse(accessLevelLineTextField.Text) > 0 &&
                       Int32.Parse(accessLevelLineTextField.Text) < 4)
                    {
                        User user = new User();
                        user.FullName = fullNameLineTextField.Text;
                        //user.Age = Int32.Parse(ageLineTextField.Text);
                        user.AccessModifier = Int32.Parse(accessLevelLineTextField.Text);
                        user.Login = loginLineTextField.Text;
                        user.Password = passwordLineTextField.Text;
                        user.Position = positionLineTextField.Text;
                        user.Rating = Int32.Parse(ratingLineTextField.Text);
                        
                        user.Birthday = dateOfBirthPicker.Value;
                    }

                    else
                    {
                        fillInputErrorLabel.Visible = true;
                    }
                }

                else
                {
                    fillInputErrorLabel.Visible = true;
                }

            }

            else
            {
                fillErrorLabel.Visible = true;
            }
        }
    }
}

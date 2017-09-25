using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace ManagementSystem
{
    public partial class UserControlMainMenu : UserControl
    {
        public UserControlMainMenu()
        {
            InitializeComponent();
        }

        private void MaterialRaisedButtonCurrentTasks_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(1);
        }

        private void MaterialRaisedButtonMonitoring_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(2);
        }

        private void MaterialRaisedButtonNewTask_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageNewTask");
        }

        private void AutomaticTaskButton_CheckedChanged(object sender, EventArgs e)
        {
            reCreationTimePicker.Visible = true;

        }

        private void SelectedTaskButton_CheckedChanged(object sender, EventArgs e)
        {
            reCreationTimePicker.Visible = false;
        }

        private void StandartTaskButton_CheckedChanged(object sender, EventArgs e)
        {
            reCreationTimePicker.Visible = false;
        }

        private void DeadlineTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int year= (sender as DateTimePicker).Value.Year;
            if (year < DateTime.Today.Year)
            {
                //(sender as DateTimePicker).Value.;
            }
        }
    }
}

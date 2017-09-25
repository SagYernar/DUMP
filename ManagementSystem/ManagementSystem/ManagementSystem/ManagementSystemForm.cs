using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class ManagementSystemForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Panel MainPanel { get => mainPanel; set => mainPanel = value; }
        public ManagementSystemForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            AuthorityUserControl = new AuthorityUserControl();
            UserControlMainMenu = new UserControlMainMenu();
            UserAddControl = new UserAddControl();
        }

        private void ManagementSystemForm_Load(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Add(UserAddControl);
            
        }

    }
}

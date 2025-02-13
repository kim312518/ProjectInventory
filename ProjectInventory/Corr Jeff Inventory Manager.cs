using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectInventory
{
    public partial class Corr_Jeff_Inventory_Manager : MaterialForm
    {
        public Corr_Jeff_Inventory_Manager()
        {
            InitializeComponent();
        }

        private void Corr_Jeff_Inventory_Manager_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange200, TextShade.WHITE);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

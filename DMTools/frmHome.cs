using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMTools
{
    public partial class frmHome : Form
    {
        frmTown TownGenerator = new frmTown();

        public frmHome()
        {
            InitializeComponent();
        }

        private void btnTowns_Click(object sender, EventArgs e)
        {
            TownGenerator.Show();
        }
    }
}

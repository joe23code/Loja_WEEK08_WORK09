using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_WEEK08_WORK09
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeform frmEmployeeform = new frmEmployeeform();
            frmEmployeeform.MdiParent  = this;
            frmEmployeeform.Show();
        }
    }
}

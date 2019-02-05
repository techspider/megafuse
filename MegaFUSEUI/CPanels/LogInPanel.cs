using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaFUSEUI.CPanels
{
    public partial class LogInPanel : UserControl
    {
        public LogInPanel()
        {
            InitializeComponent();
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

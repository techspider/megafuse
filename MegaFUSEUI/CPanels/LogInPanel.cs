using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaFUSE.UI.MGFuseMain;
using CG.Web.MegaApiClient;
using MegaFUSE.UI;
using MegaFUSE.UI.Controls;

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
            if (MegaClient != null)
                if (MegaClient.IsLoggedIn)
                    MegaClient.Logout();
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MegaClient = new MegaApiClient();
            try
            {
                MegaClient.Login(usernameInput.Text, passwordInput.Text);
                MGFuseUI.ShowPanel<MgmtPanel>();
            }
            catch(ApiException ex)
            {
                MessageBox.Show("API Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed logging in! Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}

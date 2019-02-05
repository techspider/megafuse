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
using DokanNet;

namespace MegaFUSEUI.CPanels
{
    public partial class MgmtPanel : UserControl
    {
        public MgmtPanel()
        {
            InitializeComponent();
        }

        public async void GetAccount()
        {
            var accinfo = await MegaClient.GetAccountInformationAsync();
            storageLabel.Text = (accinfo.TotalQuota/1024/1024/1024) + " GB total\n" + (accinfo.UsedQuota/1024/1024/1024) + " GB used\n" + ((accinfo.TotalQuota - accinfo.UsedQuota)/1024/1024/1024) + " GB free";
            //Mount FUSE
            
        }

        private void MgmtPanel_Load(object sender, EventArgs e)
        {
            GetAccount();
        }
    }
}

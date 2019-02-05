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
using MegaFUSE.UI;

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
            static_quota_max = accinfo.TotalQuota;
            MGFuseMain.dynamic_quota_used = accinfo.UsedQuota;
            MGFuseMain.dynamic_quota_free = static_quota_max - dynamic_quota_used;
            storageLabel.Text = (static_quota_max/1024/1024/1024) + " GB total\n" + (dynamic_quota_used/1024/1024/1024) + " GB used\n" + (dynamic_quota_free/1024/1024/1024) + " GB free";
            //Mount FUSE
            
        }

        private void MgmtPanel_Load(object sender, EventArgs e)
        {
            GetAccount();
        }
    }
}

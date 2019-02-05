using MegaFUSEUI.CPanels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaFUSE.UI;
using System.IO;
using System.Windows.Forms;
using DokanNet;
using static MegaFUSE.UI.MGFuseMain;
using CG.Web.MegaApiClient;

namespace MegaFUSE.UI
{
    public class MegaFSHook : MFuseFSHook
    {
        public List<INode> NodeList { get; set; } = new List<INode>();

        public override MQuotaInformation GetQuota()
        {
            return new MQuotaInformation { QuotaFree = MGFuseMain.dynamic_quota_free, QuotaUsed = MGFuseMain.dynamic_quota_used, QuotaTotal = MGFuseMain.static_quota_max };
        }

        public override void OnMounted()
        {
            MgmtPanel.Instance.PerformSafely(()=> MgmtPanel.Instance.SetFUSEStatus("Mounted", Color.Green));
        }

        public override void OnEject()
        {
            MgmtPanel.Instance.PerformSafely(() => MgmtPanel.Instance.SetFUSEStatus("Unmounted", Color.Red));
        }

        public override NtStatus CreateFile(string fileName, FileMode mode, FileAttributes attributes)
        {
            var dpath = Path.GetDirectoryName(fileName);
            if (NodeList.Count < 1)
                NodeList = MegaClient.GetNodes().ToList();
            MessageBox.Show((NodeList[0].Type == NodeType.Root).ToString());
            
            return NtStatus.Success;
        }
    }
}

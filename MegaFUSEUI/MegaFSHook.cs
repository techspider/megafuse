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

        public MegaFSHook()
        {
            if (NodeList.Count < 1)
                NodeList = MegaClient.GetNodes().ToList();
        }

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
            return DokanResult.Success;
        }

        public override IList<FileInformation> GetFiles(string fileName)
        {
            string pname = Path.GetFileName(fileName);
            INode dirParent = null;
            if (pname.Trim() == "")
                dirParent = NodeList[0];
            else
                dirParent = NodeList.Single(x => (x.Name == pname) && (x.Type == NodeType.Directory));

            var files = NodeList.Where(x => x.ParentId == dirParent.Id);
            var flist = new List<FileInformation>();
            foreach(INode f in files)
            {
                FileInformation fi = new FileInformation();
                fi.FileName = f.Name;
                if (f.Type == NodeType.Directory) fi.Attributes = FileAttributes.Directory;
                else fi.Attributes = FileAttributes.Normal;
                fi.CreationTime = f.CreationDate;
                fi.LastAccessTime = f.ModificationDate;
                fi.LastWriteTime = f.ModificationDate;
                flist.Add(fi);
            }
            return flist;
        }
    }
}

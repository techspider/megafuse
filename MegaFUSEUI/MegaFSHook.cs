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
        public bool Ready { get; set; } = false;
        public static MegaFSHook Instance { get; set; }
        public Dictionary<string, INode> FilesystemStruct { get; set; } = new Dictionary<string, INode>();

        public MegaFSHook()
        {
            Instance = this;
            if (NodeList.Count < 1)
                NodeList = MegaClient.GetNodes().ToList();
            FilesystemStruct = Flat23dst(NodeList[0]);
        }

        public override MQuotaInformation GetQuota()
        {
            return new MQuotaInformation { QuotaFree = MGFuseMain.dynamic_quota_free, QuotaUsed = MGFuseMain.dynamic_quota_used, QuotaTotal = MGFuseMain.static_quota_max };
        }

        public override void OnMounted()
        {
            MgmtPanel.Instance.PerformSafely(()=> MgmtPanel.Instance.SetFUSEStatus("Mounted", Color.Green));
            Ready = true;
        }

        public override void OnEject()
        {
            MgmtPanel.Instance.PerformSafely(() => MgmtPanel.Instance.SetFUSEStatus("Unmounted", Color.Red));
            Ready = false;
        }

        public override NtStatus CreateFile(string fileName, FileMode mode, FileAttributes attributes)
        {
            return DokanResult.Success;
        }

        public List<INode> GetContents(INode rootNode)
        {
            List<INode> nlist = new List<INode>();
            foreach (var node in NodeList)
            {
                if (node.Id == rootNode.Id) continue;
                if ((node.Type == NodeType.Inbox) || (node.Type == NodeType.Trash)) continue;
                if (node.ParentId != rootNode.Id) continue;
                nlist.Add(node);
                // debug => MessageBox.Show(node.Name);
            }
            return nlist;
        }

        public void RefreshFS()
        {
            NodeList = MegaClient.GetNodes().ToList();
            FilesystemStruct = Flat23dst(NodeList[0]);
        }

        public Dictionary<string, INode> Flat23dst(INode rootNode)
        {
            Dictionary<string, INode> _3dst = new Dictionary<string, INode>();
            _3dst["\\"] = rootNode;
            string depth = "";
            void recursiveRegister(INode dir)
            {
                string dname;
                if (dir.Name == null) dname = "";
                else dname = dir.Name;
                depth += "\\" + dname;
                var contents = GetContents(dir);
                foreach(var c in contents)
                {
                    _3dst[(depth + "\\" + c.Name).Replace("\\\\", "\\")] = c;
                    if (c.Type == NodeType.Directory) recursiveRegister(c);
                }
                depth = depth.Remove(depth.Length - (dname.Length + 1));
            }
            recursiveRegister(rootNode);
            return _3dst;
        }

        public override IList<FileInformation> GetFiles(string fileName)
        {
            var flist = new List<FileInformation>();
            if (!FilesystemStruct.ContainsKey(fileName)) return null;
            var item = FilesystemStruct[fileName];
            var contents = GetContents(item);
            foreach (INode f in contents)
            {
                FileInformation fi = new FileInformation();
                fi.FileName = f.Name;
                if (f.Type == NodeType.Directory)
                {
                    fi.Attributes = FileAttributes.Directory;
                    //fi.Length = f.GetFolderSize(MegaClient);
                }
                else fi.Attributes = FileAttributes.Normal;
                fi.CreationTime = f.CreationDate;
                fi.LastAccessTime = f.ModificationDate;
                fi.LastWriteTime = f.ModificationDate;
                fi.Length = f.Size;
                flist.Add(fi);
            }
            return flist;
        }

        public override NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, DokanFileInfo info)
        {
            if(!FilesystemStruct.ContainsKey(fileName))
            {
                MessageBox.Show("yes");
                bytesRead = 0;
                return DokanResult.FileNotFound;
            }
            if (info.Context == null)
            {
                using (var stream = MegaClient.Download(FilesystemStruct[fileName]))
                {
                    stream.Position = offset;
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                }
            }
            else
            {
                var stream = info.Context as Stream;
                lock (stream)
                {
                    stream.Position = offset;
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                }
            }
            return DokanResult.Success;
        }
    }
}

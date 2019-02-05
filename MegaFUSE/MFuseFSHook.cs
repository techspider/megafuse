using DokanNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFUSE
{
    public abstract class MFuseFSHook
    {
        public abstract MQuotaInformation GetQuota();
        public abstract void OnMounted();
        public abstract void OnEject();
        public abstract NtStatus CreateFile(string fileName, FileMode mode, FileAttributes attributes);
        public abstract IList<FileInformation> GetFiles(string fileName);
        public abstract NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, DokanFileInfo info);
        public abstract NtStatus DeleteDir(string fileName, DokanFileInfo info);
        public abstract NtStatus DeleteFile(string fileName, DokanFileInfo info);
        public abstract NtStatus SetFileTime(string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, DokanFileInfo info);
        public abstract NtStatus GetFileInfo(string fileName, out FileInformation fileInfo, DokanFileInfo info);
    }
}

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
    }
}

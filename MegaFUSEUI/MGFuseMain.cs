using CG.Web.MegaApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaFUSE.UI
{
    internal static class MGFuseMain
    {
        public static MegaApiClient MegaClient { get; set; }
        public static long static_quota_max { get; set; }
        public static long dynamic_quota_used { get; set; }
        public static long dynamic_quota_free { get; set; }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MGFuseUI());
        }
    }
}

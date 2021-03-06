﻿using MegaFUSEUI.CPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaFUSE.UI.MGFuseMain;

namespace MegaFUSE.UI
{
    public partial class MGFuseUI : Form //singleton
    {
        public static MGFuseUI Instance { get; set; }

        public MGFuseUI()
        {
            Instance = this;
            InitializeComponent();
        }

        public static void ShowPanel<T>() where T : Control
        {
            if(Instance != null)
            {
                Instance.Controls.Clear();
                var control = Activator.CreateInstance(typeof(T)) as Control;
                control.Dock = DockStyle.Fill;
                Instance.Controls.Add(control);
            }
        }

        private void MGFuseUI_Load(object sender, EventArgs e)
        {
            ShowPanel<LogInPanel>();
        }

        private void MGFuseUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MegaClient != null)
                if (MegaClient.IsLoggedIn)
                    MegaClient.Logout();
            Application.Exit();
        }
    }
}

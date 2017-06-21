using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DependenciesChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectxCheck();
            netframeworkCheck();
            vcreditsX86Check();
            vcreditsX64Check();
            msbuildtoolsCheck();
        }

        private void msbuildtoolsCheck()
        {
            if (Directory.Exists("C:/Program Files (x86)/MSBuild"))
            {
                MSBT_lbl.Text = "Found";
                MSBT_lbl.ForeColor = Color.ForestGreen;
            }
            else if (!Directory.Exists("C:/Program Files (x86)/MSBuild"))
            {
                MSBT_lbl.Text = "N/A";
                MSBT_lbl.ForeColor = Color.Red;
            }
        }

        private void vcreditsX64Check()
        {
            var vcredist64 = "HKLM/SOFTWARE/Classes/Installer/Dependencies/{ 050d4fc8 - 5d48 - 4b8f - 8972 - 47c82c46020f}";

            RegistryKey rkSubKey = Registry.CurrentUser.OpenSubKey(vcredist64, false);

            if (rkSubKey == null)
            {
                vcx64_lbl.Text = "Found";
                vcx64_lbl.ForeColor = Color.ForestGreen;
            }
            else
            {
                vcx64_lbl.Text = "N/A";
                vcx64_lbl.ForeColor = Color.Red;
            }
        }

        private void vcreditsX86Check()
        {
            var vcredist86 = "HKLM/SOFTWARE/Classes/Installer/Dependencies/{f65db027-aff3-4070-886a-0d87064aabb1}";

            RegistryKey rkSubKey = Registry.CurrentUser.OpenSubKey(vcredist86, false);

            if (rkSubKey == null)
            {
                vcx86_lbl.Text = "Found";
                vcx86_lbl.ForeColor = Color.ForestGreen;
            }
            else
            {
                vcx86_lbl.Text = "N/A";
                vcx86_lbl.ForeColor = Color.Red;
            }
        }

        private void netframeworkCheck()
        {
            string path = "C:/Windows/Microsoft.NET/Framework";

            if (Directory.Exists(path))
            {
                NET_lbl.Text = "Found";
                NET_lbl.ForeColor = Color.ForestGreen;
            }
            else if (!Directory.Exists(path))
            {
                NET_lbl.Text = "N/A";
                NET_lbl.ForeColor = Color.Red;
            }
        }

        private void DirectxCheck()
        {
            string path = "C:/Windows/System32/d3d9.dll";

            if (File.Exists(path))
            {
                DX_lbl.Text = "Found";
                DX_lbl.ForeColor = Color.ForestGreen;
            }
            else if (!File.Exists(path))
            {
                DX_lbl.Text = "N/A";
                DX_lbl.ForeColor = Color.Red;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhungFireFoxVaoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize(Application.StartupPath + "\\xulrunner");
            geckoWeb.Navigate("https://www.howkteam.vn/course/stream-ky-thuat-c-net/nhung-firefox-vao-winform-c-stream-ky-thuat-1270");
            geckoWeb.CreateWindow2 += GeckoWeb_CreateWindow2;
        }

        private void GeckoWeb_CreateWindow2(object sender, Gecko.GeckoCreateWindow2EventArgs e)
        {
            Process.Start(e.Uri);
            e.Cancel = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using AxJVueAXLib;
using JVueAXLib;

namespace Previewer
{
    public partial class FormMain : Form
    {
        private Timer timer1;
        private string FILE_PATH = "path.txt";
        private string path = "";
        private string prePath = "";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            AxJVueAXControl1.setValue("GUIFILE", "ActiveX.gui");
            AxJVueAXControl1.initActiveX();
            InitTimer();
        }

        protected void FormMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //this.Visible = false;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Visible = false;
                e.Cancel = true;
            }
        }


        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sysPath = Application.StartupPath;

            string configFile = sysPath + "\\" + FILE_PATH;
            if (!File.Exists(configFile))
            {
                MessageBox.Show("该配置文件不存在：" + path+ "，请添加“path.txt”文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(configFile);
            while ((line = file.ReadLine()) != null)
            {
                path = line;
                break;
            }
            file.Close();

            if (path == prePath)
            {
                return;
            }

            prePath = path;

            if (File.Exists(path))
            {
                string vuePath = "upload://" + path;
                AxJVueAXControl1.setFile(vuePath);
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("该文件路径不存在：" + path, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

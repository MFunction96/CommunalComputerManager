﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Vexease.Views
{
    public partial class AdmForm : Form
    {
        public AdmForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            TabSet();

        }

        

        private void AdmForm_Load(object sender, EventArgs e)
        {

            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            //ControlBox = false;//上面三个按钮隐藏,以后用...
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            // DialogResult result = MessageBox.Show("当前为用户状态，不能自主终止程序，是否隐藏窗口，最小化到系统托盘？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            var onclosingForm = new OnClosingForm();
            onclosingForm.ShowDialog();
            Application.DoEvents();
           if (onclosingForm.t==0&&onclosingForm.t!=2)
            {
                //t=0,最小化
                
                WindowState = FormWindowState.Minimized;
                NotifyIcon.Visible = true;//托盘图标可见
            }
            else if(onclosingForm.t==1&&onclosingForm.t!=2)
            {
                //t=1，关闭
                e.Cancel = false;
                Environment.Exit(0);//彻底关掉！
            }
            base.OnClosing(e);
        }


        private void TlStrBtnBList_Click(object sender, EventArgs e)
        {
            int n = 0;//给个名单内名字的个数吧..

            if (PnlBList.Height == 0) { PnlBList.Height = 180; } else { PnlBList.Height = 0; }
        }

        private void TlStrBtnWList_Click(object sender, EventArgs e)
        {
            int n = 0;//给个名单内名字的个数吧..

            if (PnlWList.Height == 0) { PnlWList.Height = 180; } else { PnlWList.Height = 0; }
        }

        private void TlStrBtnBListSet_Click(object sender, EventArgs e)
        {
            Hide();
            var bListSetForm = new BandWListSetForm();
            bListSetForm.Show();
        }

        private void TlStrBtnWListSet_Click(object sender, EventArgs e)
        {
            Hide();
            var wListSetForm = new BandWListSetForm();
            wListSetForm.Show();
        }

        private void MenuSetIP_Click(object sender, EventArgs e)
        {
            Hide();
            var setIPForm = new SetIPForm();
            setIPForm.Show();
            
        }

        private void PnlAbout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuStripAdm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (LvStatus.Height == 0)
            {
                LvStatus.Height = 180;
            }
            else
            {
                LvStatus.Height = 0;
            }
        }

        private void MenuFileImport_Click(object sender, EventArgs e)
        {
            var importForm = new ImportForm();
            importForm.Show();
        }

        private void MenuFileExport_Click(object sender, EventArgs e)
        {
            var exportForm = new ExportForm();
            exportForm.Show();
        }

        private void MenuStripAdm_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
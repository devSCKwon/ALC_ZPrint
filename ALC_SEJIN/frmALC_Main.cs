using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALC_SEJIN
{
    public partial class frmALC_Main : Form
    {
        private static string _progCD;
        private static string _zplPrintSize;

        private void DefultAppSetting()
        {
            _progCD = Properties.Settings.Default["zplPrintSize"].ToString();
            _zplPrintSize = Properties.Settings.Default["zplPrintSize"].ToString();
            foreach (ToolStripMenuItem item in tsmiZPLPrintSize.DropDownItems)
            {
                item.Checked = false;
                if (_zplPrintSize.Equals(item.Text))
                {
                    item.Checked = true;
                    this.tsmiZPLPrintSize.Text = "Print SIZE : " + item.Text;
                    this.tsmiZPLPrintSize.Checked = true;
                }
            }
        }

        public frmALC_Main()
        {
            InitializeComponent();
        }
        private void frmALC_Main_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtPNO;
            this.txtPNO.Text = "87360AA000A5G";
            this.txtPNO.SelectAll();
            this.DefultAppSetting();
        }

        private void tsmiPROGListOption_Click(object sender, EventArgs e)
        {
            //초기화
            this.tsmiPROGListOption1.Checked = false;
            this.tsmiPROGListOption2.Checked = false;

            ((ToolStripMenuItem)sender).Checked = true;

            if (((ToolStripMenuItem)sender).Checked)
            {
                this.tsmiPROGList.Text = string.Concat("선택공정 : ", ((ToolStripMenuItem)sender).Text);
            }
        }

        private void tsmiZPLPrintSizeOption_Click(object sender, EventArgs e)
        {
            //초기화
            this.tsmiZPLPrintSizeOption1.Checked = false;
            this.tsmiZPLPrintSizeOption2.Checked = false;

            ((ToolStripMenuItem)sender).Checked = true;

            if (((ToolStripMenuItem)sender).Checked)
            {
                this.tsmiZPLPrintSize.Text = string.Concat("Print SIZE : ", ((ToolStripMenuItem)sender).Text);
                _zplPrintSize = ((ToolStripMenuItem)sender).Text;
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiZPLSave_Click(object sender, EventArgs e)
        {
            this.tsmiZPLPrintSize.DropDown.Close();
            this.tsmiZPLPrintSize.DropDown.AutoClose = true;
            this.tsmiZPLMenu.Enabled = true;

            MessageBox.Show(_zplPrintSize);
            Properties.Settings.Default["zplPrintSize"] = _zplPrintSize;
            Properties.Settings.Default.Save();

            //stutus 설정변경
            string status = "Setting Saved";

            //this.toolStripStatusLabel1.Text = status;
            //log.Info(status);

            ////세팅값 변경
            //Properties.Settings.Default["zplDataType"] = _zplDataType;
            //Properties.Settings.Default["optionList"] = this.tstbOptionListData.TextBox.Text;
            //_optionList = Properties.Settings.Default["optionList"].ToString().Split(',');
            //Properties.Settings.Default.Save();

            ////stutus 설정변경
            //string status = "Setting Saved";
            //this.toolStripStatusLabel1.Text = status;
            //log.Info(status);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

    }
}

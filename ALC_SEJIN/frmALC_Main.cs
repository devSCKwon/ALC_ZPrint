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
        public frmALC_Main()
        {
            InitializeComponent();
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

        private void tsmiZPLDataOption_Click(object sender, EventArgs e)
        {
            //초기화
            this.tsmiZPLDataOption1.Checked = false;
            this.tsmiZPLDataOption2.Checked = false;

            ((ToolStripMenuItem)sender).Checked = true;

            if (((ToolStripMenuItem)sender).Checked)
            {
                this.tsmiZPLData.Text = string.Concat("설정사이즈 : ", ((ToolStripMenuItem)sender).Text);
            }
        }
    }
}

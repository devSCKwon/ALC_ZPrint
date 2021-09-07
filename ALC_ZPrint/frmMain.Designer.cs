
namespace ALC_ZPrint
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtALC = new System.Windows.Forms.TextBox();
            this.btnGetJson = new System.Windows.Forms.Button();
            this.btnShowJson = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtPNO = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiZPLMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptionList = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbOptionListData = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiURL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZPLData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZPLDataOption1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZPLDataOption2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZPLDataOption3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiZPLSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZPLExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtALC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGetJson, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnShowJson, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPNO, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTemp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 537);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtALC
            // 
            this.txtALC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtALC.Location = new System.Drawing.Point(270, 3);
            this.txtALC.Name = "txtALC";
            this.txtALC.ReadOnly = true;
            this.txtALC.Size = new System.Drawing.Size(261, 21);
            this.txtALC.TabIndex = 13;
            this.txtALC.TabStop = false;
            // 
            // btnGetJson
            // 
            this.btnGetJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetJson.Location = new System.Drawing.Point(270, 80);
            this.btnGetJson.Name = "btnGetJson";
            this.btnGetJson.Size = new System.Drawing.Size(261, 44);
            this.btnGetJson.TabIndex = 3;
            this.btnGetJson.Text = "Get Json";
            this.btnGetJson.UseVisualStyleBackColor = true;
            this.btnGetJson.Click += new System.EventHandler(this.btnGetJson_Click);
            // 
            // btnShowJson
            // 
            this.btnShowJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowJson.Location = new System.Drawing.Point(3, 80);
            this.btnShowJson.Name = "btnShowJson";
            this.btnShowJson.Size = new System.Drawing.Size(261, 44);
            this.btnShowJson.TabIndex = 4;
            this.btnShowJson.Text = "Show Json";
            this.btnShowJson.UseVisualStyleBackColor = true;
            this.btnShowJson.Click += new System.EventHandler(this.btnShowJson_Click);
            // 
            // btnPrint
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnPrint, 2);
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(3, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(528, 44);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtPNO
            // 
            this.txtPNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPNO.Location = new System.Drawing.Point(3, 3);
            this.txtPNO.Name = "txtPNO";
            this.txtPNO.Size = new System.Drawing.Size(261, 21);
            this.txtPNO.TabIndex = 1;
            this.txtPNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPNO_KeyDown);
            //this.txtPNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPNO_KeyPress);
            // 
            // txtTemp
            // 
            this.txtTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemp.Location = new System.Drawing.Point(3, 130);
            this.txtTemp.Multiline = true;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.txtTemp, 2);
            this.txtTemp.Size = new System.Drawing.Size(261, 384);
            this.txtTemp.TabIndex = 14;
            this.txtTemp.TabStop = false;
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 20);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 15);
            this.toolStripStatusLabel1.Text = "Scan your barcode now.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(270, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 354);
            this.panel1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZPLMenu,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiZPLMenu
            // 
            this.tsmiZPLMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptionList,
            this.tsmiURL,
            this.tsmiZPLData,
            this.toolStripSeparator1,
            this.tsmiZPLSave,
            this.tsmiZPLExit});
            this.tsmiZPLMenu.Name = "tsmiZPLMenu";
            this.tsmiZPLMenu.Size = new System.Drawing.Size(58, 20);
            this.tsmiZPLMenu.Text = "설정(&B)";
            // 
            // tsmiOptionList
            // 
            this.tsmiOptionList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbOptionListData});
            this.tsmiOptionList.Name = "tsmiOptionList";
            this.tsmiOptionList.Size = new System.Drawing.Size(144, 22);
            this.tsmiOptionList.Text = "Option List";
            this.tsmiOptionList.Click += new System.EventHandler(this.tsmiOptionList_Click);
            // 
            // tstbOptionListData
            // 
            this.tstbOptionListData.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.tstbOptionListData.Name = "tstbOptionListData";
            this.tstbOptionListData.Size = new System.Drawing.Size(200, 23);
            // 
            // tsmiURL
            // 
            this.tsmiURL.Name = "tsmiURL";
            this.tsmiURL.Size = new System.Drawing.Size(144, 22);
            this.tsmiURL.Text = "Data URL";
            this.tsmiURL.Click += new System.EventHandler(this.tsmiURL_Click);
            // 
            // tsmiZPLData
            // 
            this.tsmiZPLData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZPLDataOption1,
            this.tsmiZPLDataOption2,
            this.tsmiZPLDataOption3});
            this.tsmiZPLData.Name = "tsmiZPLData";
            this.tsmiZPLData.Size = new System.Drawing.Size(144, 22);
            this.tsmiZPLData.Text = "Barcode SIZE";
            this.tsmiZPLData.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsmiZPLData_DropDownItemClicked);
            // 
            // tsmiZPLDataOption1
            // 
            this.tsmiZPLDataOption1.CheckOnClick = true;
            this.tsmiZPLDataOption1.Name = "tsmiZPLDataOption1";
            this.tsmiZPLDataOption1.Size = new System.Drawing.Size(140, 22);
            this.tsmiZPLDataOption1.Text = "ALC(55×25)";
            this.tsmiZPLDataOption1.Click += new System.EventHandler(this.tsmiZPLDataOption_Click);
            // 
            // tsmiZPLDataOption2
            // 
            this.tsmiZPLDataOption2.CheckOnClick = true;
            this.tsmiZPLDataOption2.Name = "tsmiZPLDataOption2";
            this.tsmiZPLDataOption2.Size = new System.Drawing.Size(140, 22);
            this.tsmiZPLDataOption2.Text = "ALC(55×35)";
            this.tsmiZPLDataOption2.Click += new System.EventHandler(this.tsmiZPLDataOption_Click);
            // 
            // tsmiZPLDataOption3
            // 
            this.tsmiZPLDataOption3.CheckOnClick = true;
            this.tsmiZPLDataOption3.Name = "tsmiZPLDataOption3";
            this.tsmiZPLDataOption3.Size = new System.Drawing.Size(140, 22);
            this.tsmiZPLDataOption3.Text = "ALC(70×40)";
            this.tsmiZPLDataOption3.Click += new System.EventHandler(this.tsmiZPLDataOption_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmiZPLSave
            // 
            this.tsmiZPLSave.Name = "tsmiZPLSave";
            this.tsmiZPLSave.ShowShortcutKeys = false;
            this.tsmiZPLSave.Size = new System.Drawing.Size(144, 22);
            this.tsmiZPLSave.Text = "설정저장(&S)";
            this.tsmiZPLSave.Click += new System.EventHandler(this.tsmiZPLSave_Click);
            // 
            // tsmiZPLExit
            // 
            this.tsmiZPLExit.Name = "tsmiZPLExit";
            this.tsmiZPLExit.Size = new System.Drawing.Size(144, 22);
            this.tsmiZPLExit.Text = "설정종료(&X)";
            this.tsmiZPLExit.Click += new System.EventHandler(this.tsmiZPLExit_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(110, 20);
            this.tsmiExit.Text = "프로그램 종료(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = " ALC_ZPrint";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtPNO;
        private System.Windows.Forms.TextBox txtALC;
        private System.Windows.Forms.Button btnGetJson;
        private System.Windows.Forms.Button btnShowJson;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLDataOption1;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLDataOption2;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLDataOption3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiURL;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionList;
        private System.Windows.Forms.ToolStripTextBox tstbOptionListData;
        private System.Windows.Forms.Panel panel1;
    }
}
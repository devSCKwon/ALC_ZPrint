
namespace ALC_SEJIN
{
    partial class frmALC_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiZPLMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPROGList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPROGListOption1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPROGListOption2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZPLPrintSize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZPLPrintSizeOption1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZPLPrintSizeOption2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiURL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiZPLSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowJson = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtPNO = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZPLMenu,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiZPLMenu
            // 
            this.tsmiZPLMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPROGList,
            this.tsmiZPLPrintSize,
            this.tsmiURL,
            this.toolStripSeparator1,
            this.tsmiZPLSave});
            this.tsmiZPLMenu.Name = "tsmiZPLMenu";
            this.tsmiZPLMenu.Size = new System.Drawing.Size(58, 20);
            this.tsmiZPLMenu.Text = "설정(&B)";
            // 
            // tsmiPROGList
            // 
            this.tsmiPROGList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPROGListOption1,
            this.tsmiPROGListOption2});
            this.tsmiPROGList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsmiPROGList.Name = "tsmiPROGList";
            this.tsmiPROGList.Size = new System.Drawing.Size(162, 22);
            this.tsmiPROGList.Text = "공정선택";
            // 
            // tsmiPROGListOption1
            // 
            this.tsmiPROGListOption1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsmiPROGListOption1.Name = "tsmiPROGListOption1";
            this.tsmiPROGListOption1.Size = new System.Drawing.Size(187, 22);
            this.tsmiPROGListOption1.Text = "스포일러 조립(A000)";
            this.tsmiPROGListOption1.Click += new System.EventHandler(this.tsmiPROGListOption_Click);
            // 
            // tsmiPROGListOption2
            // 
            this.tsmiPROGListOption2.Name = "tsmiPROGListOption2";
            this.tsmiPROGListOption2.Size = new System.Drawing.Size(187, 22);
            this.tsmiPROGListOption2.Text = "글라스 후가공(A010)";
            this.tsmiPROGListOption2.Click += new System.EventHandler(this.tsmiPROGListOption_Click);
            // 
            // tsmiZPLPrintSize
            // 
            this.tsmiZPLPrintSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZPLPrintSizeOption1,
            this.tsmiZPLPrintSizeOption2});
            this.tsmiZPLPrintSize.Name = "tsmiZPLPrintSize";
            this.tsmiZPLPrintSize.Size = new System.Drawing.Size(162, 22);
            this.tsmiZPLPrintSize.Text = "출력사이즈 선택";
            // 
            // tsmiZPLPrintSizeOption1
            // 
            this.tsmiZPLPrintSizeOption1.Name = "tsmiZPLPrintSizeOption1";
            this.tsmiZPLPrintSizeOption1.Size = new System.Drawing.Size(140, 22);
            this.tsmiZPLPrintSizeOption1.Text = "ALC(55×25)";
            this.tsmiZPLPrintSizeOption1.Click += new System.EventHandler(this.tsmiZPLPrintSizeOption_Click);
            // 
            // tsmiZPLPrintSizeOption2
            // 
            this.tsmiZPLPrintSizeOption2.Name = "tsmiZPLPrintSizeOption2";
            this.tsmiZPLPrintSizeOption2.Size = new System.Drawing.Size(140, 22);
            this.tsmiZPLPrintSizeOption2.Text = "ALC(50×20)";
            this.tsmiZPLPrintSizeOption2.Click += new System.EventHandler(this.tsmiZPLPrintSizeOption_Click);
            // 
            // tsmiURL
            // 
            this.tsmiURL.Name = "tsmiURL";
            this.tsmiURL.Size = new System.Drawing.Size(162, 22);
            this.tsmiURL.Text = "Data URL";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmiZPLSave
            // 
            this.tsmiZPLSave.Name = "tsmiZPLSave";
            this.tsmiZPLSave.ShowShortcutKeys = false;
            this.tsmiZPLSave.Size = new System.Drawing.Size(162, 22);
            this.tsmiZPLSave.Text = "설정저장(&S)";
            this.tsmiZPLSave.Click += new System.EventHandler(this.tsmiZPLSave_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(110, 20);
            this.tsmiExit.Text = "프로그램 종료(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnShowJson, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTemp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPNO, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 404);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnShowJson
            // 
            this.btnShowJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowJson.Location = new System.Drawing.Point(403, 85);
            this.btnShowJson.Name = "btnShowJson";
            this.btnShowJson.Size = new System.Drawing.Size(394, 44);
            this.btnShowJson.TabIndex = 17;
            this.btnShowJson.Text = "Show Json";
            this.btnShowJson.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(403, 35);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(394, 44);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemp.Location = new System.Drawing.Point(3, 35);
            this.txtTemp.Multiline = true;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.txtTemp, 4);
            this.txtTemp.Size = new System.Drawing.Size(394, 366);
            this.txtTemp.TabIndex = 15;
            this.txtTemp.TabStop = false;
            // 
            // txtPNO
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPNO, 2);
            this.txtPNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPNO.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPNO.Location = new System.Drawing.Point(3, 3);
            this.txtPNO.Name = "txtPNO";
            this.txtPNO.Size = new System.Drawing.Size(794, 21);
            this.txtPNO.TabIndex = 0;
            // 
            // frmALC_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmALC_Main";
            this.Text = "ALC_SEJIN";
            this.Load += new System.EventHandler(this.frmALC_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiPROGList;
        private System.Windows.Forms.ToolStripMenuItem tsmiURL;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLPrintSize;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLPrintSizeOption1;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLPrintSizeOption2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiZPLSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPNO;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShowJson;
        private System.Windows.Forms.ToolStripMenuItem tsmiPROGListOption1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPROGListOption2;
    }
}


using log4net;
using log4net.Config;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Zebra.Sdk.Comm;

namespace ALC_ZPrint
{
    public partial class frmMain : Form
    {
        private static readonly string _jsonUrl = Properties.Settings.Default["jsonUrl"].ToString();
        private static string _zplDataType;
        private static readonly string printIpAddress = "10.206.63.197";
        private static readonly string jsonFilePath = @"D:\option.json";
        private static readonly string jsonFileTempPath = @"D:\option_sample.json";
        //시스템에서 사용할 필요한 사업장공장코드만 입력 받는다.(AppSetting)
        //private static string[] _companyList = { "Z02", "Z03" };
        private static string[] _optionList;

        private static ILog log;
        public frmMain()
        {
            InitializeComponent();
            //LOG기록위한 설정
            XmlConfigurator.Configure(new FileInfo("logManager.xml"));
            log = LogManager.GetLogger(typeof(frmMain));

            if (log.IsDebugEnabled)
            {
                log.Debug(this.ToString() + " 프로그램 실행 시작, 로그작성 최초 로드");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtPNO;
            this.txtPNO.Text = "87360AA000A5G";
            this.txtPNO.SelectAll();
            this.DefultAppSetting();

            //로그테스트
            //log.Info("알림말");
            //log.Debug("디버그");
            //log.Warn("경고");
            //log.Error("에러");
        }

        /// <summary>
        /// 로드시 기초 설정값
        /// </summary>
        private void DefultAppSetting()
        {
            _zplDataType = Properties.Settings.Default["zplDataType"].ToString();
            _optionList = Properties.Settings.Default["optionList"].ToString().Split(',');
            foreach (ToolStripMenuItem item in tsmiZPLData.DropDownItems)
            {
                item.Checked = false;
                if (_zplDataType.Equals(item.Text))
                {
                    item.Checked = true;
                    this.tsmiZPLData.Text = "SIZE : " + item.Text;
                    this.tsmiZPLData.Checked = true;
                }
            }

            var str = string.Join(",", _optionList);
            this.tstbOptionListData.TextBox.Text = str;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ZPL_Print();
        }

        private void ZPL_Print()
        {
            this.SendZplOverTcp(printIpAddress, ReturnZplData(this.txtPNO.Text, this.txtALC.Text, _zplDataType));
            this.txtTemp.Text = ReturnZplData(this.txtPNO.Text, this.txtALC.Text, _zplDataType);
            //stutus 설정변경
            string status = $"PRINT - PNo : {this.txtPNO.Text}, ALCNo : {this.txtALC.Text}";
            this.toolStripStatusLabel1.Text = status;
            log.Info(status);
        }

        private void SendZplOverTcp(string theIpAddress, string pZplData)
        {
            // Instantiate connection for ZPL TCP port at given address
            Connection thePrinterConn = new TcpConnection(theIpAddress, TcpConnection.DEFAULT_ZPL_TCP_PORT);

            try
            {
                // Open the connection - physical connection is established here.
                thePrinterConn.Open();

                // This example prints "This is a ZPL test." near the top of the label.
                //string zplData = "^XA^FO20,20^A0N,25,25^FDThis is a ZPL test.^FS^XZ";

                // Send the data to printer as a byte array.
                thePrinterConn.Write(Encoding.UTF8.GetBytes(pZplData));
            }
            catch (ConnectionException e)
            {
                // Handle communications error here.
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // Close the connection to release resources.
                thePrinterConn.Close();
            }
        }

        private string ReturnZplData(string pPNO, string pALC, string pZplDataType)
        {
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string zplData = string.Empty;

            if (pZplDataType.Equals("ALC(55×25)"))
            {
                zplData = $@"^XA
^MMT
^PW440
^LL0200
^LS0
^FT26,193^BQN,2,7
^FH
^FDLA,{pALC}^FS
^FT189,55^ACN,36,10
^FH
^FD{pPNO}^FS
^FO187,66^GB198,0,1^FS
^FT191,137^A0N,68,98^FB162,1,0,C
^FH
^FD{pALC}^FS
^FT189,169^AAN,18,5^FH
^FD{now}^FS
^PQ1,0,1,Y^XZ
^XZ";
            }
            else if (pZplDataType.Equals("ALC(50×20)"))
            {
                zplData = $@"^XA
^MMT
^PW400
^LL0160
^LS0
^FT16,162^BQN,2,6
^FH
^FDLA,{pALC}^FS
^FT161,34^ACN,18,10^FH
^FD{pPNO}^FS
^FO160,43^GB198,0,1^FS
^FT160,109^A0N,65,96^FH
^FD{pALC}^FS
^FT161,141^AAN,18,5^FH
^FD{now}^FS
^PQ1,0,1,Y^XZ
";
            }
            return zplData;
        }

        private void btnGetJson_Click(object sender, EventArgs e)
        {
            //1.WebClient 클래스 활용
            string webClientResult = callWebClient();
            var r = JObject.Parse(webClientResult);

            //var list = r["list"];
            //string webClientResult = callWebRequest();
            //var r = JObject.Parse(webClientResult);

            File.WriteAllText(jsonFilePath, r.ToString());
        }

        public static string callWebClient()
        {
            string result = string.Empty;
            try
            {
                WebClient client = new WebClient();

                //특정 요청 헤더값을 추가해준다. 
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                using (Stream data = client.OpenRead(_jsonUrl))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        string s = reader.ReadToEnd();
                        result = s;

                        reader.Close();
                        data.Close();
                    }
                }

            }
            catch (Exception e)
            {
                //통신 실패시 처리로직
                Console.WriteLine(e.ToString());
            }
            return result;
        }

        private void btnShowJson_Click(object sender, EventArgs e)
        {
            ShowJson();
        }

        private void ShowJson()
        {
            using (StreamReader file = File.OpenText(jsonFileTempPath))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    var json = JToken.ReadFrom(reader);
                    this.btnPrint.Enabled = false;
                    this.txtALC.Text = string.Empty;
                    this.txtTemp.Text = string.Empty;
                    this.panel1.BackColor = Color.White;

                    foreach (var temp in json["list"]["options"])
                    {
                        //차종:회사코드 조합이 있는 데이터만 검출
                        var checkCD = $"{temp["kindcd"]}:{temp["companycd"]}";
                        if (_optionList.Contains(checkCD))
                        {
                            if (this.txtPNO.Text.Equals(temp["apno"].ToString()))
                            {
                                this.txtALC.Text = temp["alccd"].ToString();
                                this.txtTemp.Text = temp.ToString();
                                this.btnPrint.Enabled = true;

                                var optionCD = temp["optioncd"].ToString();
                                if (optionCD.Equals("A5G"))
                                {
                                    this.panel1.BackColor = Color.FromArgb(0, 51, 102);
                                }
                                else if (optionCD.Equals("C5G"))
                                {
                                    this.panel1.BackColor = Color.FromArgb(153, 0, 0);
                                }
                                else if (optionCD.Equals("M6T"))
                                {
                                    this.panel1.BackColor = Color.FromArgb(64, 64, 64);
                                }
                                else
                                {
                                    this.panel1.BackColor = Color.DimGray;
                                };
                            }
                        }
                    }
                }
            }
        }

        private void tsmiZPLDataOption_Click(object sender, EventArgs e)
        {
            //초기화
            this.tsmiZPLDataOption1.Checked = false;
            this.tsmiZPLDataOption2.Checked = false;

            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void tsmiZPLData_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = true;
            ((ToolStripMenuItem)sender).Text = "SIZE : " + e.ClickedItem.Text;

            _zplDataType = e.ClickedItem.Text;
            this.tsmiZPLData.DropDown.AutoClose = false;
            this.tsmiZPLMenu.Enabled = false;
        }

        private void tsmiZPLSave_Click(object sender, EventArgs e)
        {
            this.tsmiZPLData.DropDown.Close();
            this.tsmiZPLData.DropDown.AutoClose = true;
            this.tsmiZPLMenu.Enabled = true;

            //세팅값 변경
            Properties.Settings.Default["zplDataType"] = _zplDataType;
            Properties.Settings.Default["optionList"] = this.tstbOptionListData.TextBox.Text;            
            _optionList = Properties.Settings.Default["optionList"].ToString().Split(',');
            Properties.Settings.Default.Save();

            //stutus 설정변경
            string status = "Setting Saved";
            this.toolStripStatusLabel1.Text = status;
            log.Info(status);
        }
        private void tsmiZPLExit_Click(object sender, EventArgs e)
        {
            this.tsmiZPLData.DropDown.Close();
            this.tsmiZPLData.DropDown.AutoClose = true;
            this.tsmiZPLMenu.Enabled = true;
            DefultAppSetting();
        }

        private void tsmiURL_Click(object sender, EventArgs e)
        {
            this.txtTemp.Text = $"Json URL\r\n\r\n{_jsonUrl}";
            //MessageBox.Show($"Json URL : {_jsonUrl}", "System Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void tsmiOptionList_Click(object sender, EventArgs e)
        {
            var str = string.Join(",", _optionList);
            this.tstbOptionListData.TextBox.Text = str;
            this.txtTemp.Text = "OPTION LIST\r\n차종코드(kindCD):사업장코드(companyCD)\r\n\r\n" + str;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void txtPNO_KeyUp(object sender, KeyEventArgs e)
        //{
        //}

        //private void txtPNO_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    MessageBox.Show(e.KeyChar.ToString());
        //    //if (e.KeyChar.Equals(Keys.Return))
        //    //{
        //    //    this.txtPNO.SelectAll();
        //    //    ShowJson();
        //    //    ZPL_Print();
        //    //}
        //}

        private void txtPNO_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (e.KeyCode.Equals(Keys.Tab))
            {
                this.txtPNO.SelectAll();
                ShowJson();
                ZPL_Print();
            }
        }
    }
}
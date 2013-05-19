namespace VBWebBrowserNew
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    //using System.ComponentModel.ComponentResourceManager;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using System.Xml;
    using VBWebBrowserNew.My;
    using VBWebBrowserNew.My.Resources;

    [DesignerGenerated]
    public class Form1 : Form
    {
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Button2")]
        private Button _Button2;
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;
        [AccessedThroughProperty("CheckBox2")]
        private CheckBox _CheckBox2;
        [AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;
        [AccessedThroughProperty("ComboBox2")]
        private ComboBox _ComboBox2;
        [AccessedThroughProperty("ComboBox3")]
        private ComboBox _ComboBox3;
        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("Label13")]
        private Label _Label13;
        [AccessedThroughProperty("Label14")]
        private Label _Label14;
        [AccessedThroughProperty("Label15")]
        private Label _Label15;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("Label18")]
        private Label _Label18;
        [AccessedThroughProperty("Label19")]
        private Label _Label19;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label20")]
        private Label _Label20;
        [AccessedThroughProperty("Label21")]
        private Label _Label21;
        [AccessedThroughProperty("Label22")]
        private Label _Label22;
        [AccessedThroughProperty("Label23")]
        private Label _Label23;
        [AccessedThroughProperty("Label24")]
        private Label _Label24;
        [AccessedThroughProperty("Label25")]
        private Label _Label25;
        [AccessedThroughProperty("Label26")]
        private Label _Label26;
        [AccessedThroughProperty("Label27")]
        private Label _Label27;
        [AccessedThroughProperty("Label28")]
        private Label _Label28;
        [AccessedThroughProperty("Label29")]
        private Label _Label29;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label30")]
        private Label _Label30;
        [AccessedThroughProperty("Label31")]
        private Label _Label31;
        [AccessedThroughProperty("Label32")]
        private Label _Label32;
        [AccessedThroughProperty("Label33")]
        private Label _Label33;
        [AccessedThroughProperty("Label34")]
        private Label _Label34;
        [AccessedThroughProperty("Label35")]
        private Label _Label35;
        [AccessedThroughProperty("Label36")]
        private Label _Label36;
        [AccessedThroughProperty("Label37")]
        private Label _Label37;
        [AccessedThroughProperty("Label38")]
        private Label _Label38;
        [AccessedThroughProperty("Label39")]
        private Label _Label39;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label40")]
        private Label _Label40;
        [AccessedThroughProperty("Label41")]
        private Label _Label41;
        [AccessedThroughProperty("Label42")]
        private Label _Label42;
        [AccessedThroughProperty("Label43")]
        private Label _Label43;
        [AccessedThroughProperty("Label44")]
        private Label _Label44;
        [AccessedThroughProperty("Label45")]
        private Label _Label45;
        [AccessedThroughProperty("Label46")]
        private Label _Label46;
        [AccessedThroughProperty("Label47")]
        private Label _Label47;
        [AccessedThroughProperty("Label48")]
        private Label _Label48;
        [AccessedThroughProperty("Label49")]
        private Label _Label49;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label50")]
        private Label _Label50;
        [AccessedThroughProperty("Label51")]
        private Label _Label51;
        [AccessedThroughProperty("Label52")]
        private Label _Label52;
        [AccessedThroughProperty("Label53")]
        private Label _Label53;
        [AccessedThroughProperty("Label54")]
        private Label _Label54;
        [AccessedThroughProperty("Label55")]
        private Label _Label55;
        [AccessedThroughProperty("Label56")]
        private Label _Label56;
        [AccessedThroughProperty("Label57")]
        private Label _Label57;
        [AccessedThroughProperty("Label58")]
        private Label _Label58;
        [AccessedThroughProperty("Label59")]
        private Label _Label59;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("LinkLabel1")]
        private LinkLabel _LinkLabel1;
        [AccessedThroughProperty("NotifyIcon1")]
        private NotifyIcon _NotifyIcon1;
        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;
        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;
        [AccessedThroughProperty("TabPage3")]
        private TabPage _TabPage3;
        [AccessedThroughProperty("TabPage4")]
        private TabPage _TabPage4;
        [AccessedThroughProperty("TabPage5")]
        private TabPage _TabPage5;
        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;
        [AccessedThroughProperty("TextBox3")]
        private TextBox _TextBox3;
        [AccessedThroughProperty("TextBox4")]
        private TextBox _TextBox4;
        [AccessedThroughProperty("TextBox5")]
        private TextBox _TextBox5;
        [AccessedThroughProperty("TextBox6")]
        private TextBox _TextBox6;
        [AccessedThroughProperty("TextBox7")]
        private TextBox _TextBox7;
        [AccessedThroughProperty("Timer1")]
        private System.Windows.Forms.Timer _Timer1;
        [AccessedThroughProperty("WebBrowser1")]
        private WebBrowser _WebBrowser1;
        [AccessedThroughProperty("WebBrowser2")]
        private WebBrowser _WebBrowser2;
        [AccessedThroughProperty("WebBrowser3")]
        private WebBrowser _WebBrowser3;
        [AccessedThroughProperty("WebBrowser4")]
        private WebBrowser _WebBrowser4;
        [AccessedThroughProperty("WebBrowser5")]
        private WebBrowser _WebBrowser5;
        private DFSSBrowser[] browsers;
        private const int CALC = 4;
        private const int CANCEL = 1;
        private int[,] car;
        private Label[,] cell;
        private IContainer components;
        private string[] currentPhases;
        private string[] currentTimes;
        private string[] day_map;
        private int delay;
        private object domainURL;
        private const int ERROR_ACCESS_DENIED = 8;
        private const int ERROR_BADDB = 1;
        private const int ERROR_BADKEY = 2;
        private const int ERROR_CANTOPEN = 3;
        private const int ERROR_CANTREAD = 4;
        private const int ERROR_CANTWRITE = 5;
        private const int ERROR_INVALID_PARAMETER = 7;
        private const int ERROR_INVALID_PARAMETERS = 0x57;
        private const int ERROR_NO_MORE_ITEMS = 0x103;
        private const int ERROR_NONE = 0;
        private const int ERROR_OUTOFMEMORY = 6;
        private const int HKEY_CURRENT_USER = -2147483647;
        private object homeURL;
        private string[] hour_map;
        private const int INDEED = 2;
        private object loginPath;
        private object loginURL;
        private const int MAX_PATH = 260;
        private const int NEED = 3;
        private const int NO_NEED = 0;
        private const int REG_DWORD = 4;
        private const int REG_EXPAND_SZ = 2;
        private const int REG_SZ = 1;
        private bool running;
        private const int SET_FEATURE_IN_REGISTRY = 4;
        private const int SET_FEATURE_ON_PROCESS = 2;
        private const int SET_FEATURE_ON_THREAD = 1;
        private const int SET_FEATURE_ON_THREAD_INTERNET = 0x40;
        private const int SET_FEATURE_ON_THREAD_INTRANET = 0x10;
        private const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 8;
        private const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x80;
        private const int SET_FEATURE_ON_THREAD_TRUSTED = 0x20;
        private object targetPath;
        private object targetURL;
        private int thread;
        private short[] time_map;
        private int timeout;
        private string[] totalTimes;
        private string user;
        private int wbCount;
        private int wbIndex;
        private bool wbLock;
        private int wbMax;
        private DisposeBrowser[] wbStack;

        public Form1()
        {
            base.Resize += new EventHandler(this.Form1_Resize);
            base.Load += new EventHandler(this.Form1_Load);
            this.day_map = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            this.hour_map = new string[] { "07:00-09:00", "09:00-13:00", "13:00-17:00", "17:00-19:00", "19:00-21:00" };
            this.time_map = new short[] { 2, 4, 4, 2, 2 };
            this.user = VBWebBrowserNew.My.Resources.Resources.id;
            this.running = false;
            this.thread = 1;
            this.delay = 60;
            this.timeout = 5;
            this.homeURL = "http://www.dfss.com.cn";
            this.domainURL = "http://218.205.165.196:8080";
            this.targetPath = "/aspx/car/XYYC22.aspx";
            this.targetURL = Operators.AddObject(this.domainURL, this.targetPath);
            this.loginPath = "/XYYC21DR1.aspx";
            this.loginURL = Operators.AddObject(this.domainURL, this.loginPath);
            this.totalTimes = new string[] { "6", "24", "18", "8", "6" };
            this.currentTimes = new string[] { "0", "0", "0", "0", "0" };
            this.currentPhases = new string[] { "模拟机", "散段", "桩训", "综合训练", "路训" };
            this.car = new int[8, 6];
            this.cell = new Label[8, 6];
            this.browsers = new DFSSBrowser[5];
            this.wbMax = 10;
            this.wbStack = new DisposeBrowser[11];
            this.wbCount = 0;
            this.wbIndex = 0;
            this.wbLock = false;
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WebBrowser_Run(this.running);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("MSScriptControl.ScriptControl", ""));
                NewLateBinding.LateSet(objectValue, null, "AllowUI", new object[] { true }, null, null);
                NewLateBinding.LateSet(objectValue, null, "Language", new object[] { "JavaScript" }, null, null);
                NewLateBinding.LateCall(objectValue, null, "AddCode", new object[] { VBWebBrowserNew.My.Resources.Resources.fetion }, null, null, null, true);
                NewLateBinding.LateCall(objectValue, null, "AddCode", new object[] { VBWebBrowserNew.My.Resources.Resources.sms }, null, null, null, true);
                string str = "testSMS(" + this.TextBox6.Text + ",'" + this.TextBox7.Text + "')";
                object[] arguments = new object[] { str };
                bool[] copyBack = new bool[] { true };
                if (copyBack[0])
                {
                    str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments[0]), typeof(string));
                }
                Interaction.MsgBox(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Eval", arguments, null, null, copyBack)), MsgBoxStyle.ApplicationModal, null);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("运行错误: " + exception.Message, MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        [DllImport("urlmon.dll", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int CoInternetSetFeatureEnabled(INTERNETFEATURELIST FeatureEntry, int dwFlags, bool fEnable);
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.thread = Conversions.ToInteger(this.ComboBox1.SelectedItem);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.delay = Conversions.ToInteger(this.ComboBox2.SelectedItem);
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.timeout = Conversions.ToInteger(this.ComboBox3.SelectedItem);
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object obj2 = null;
            string str5;
            object obj5 = null;
            try
            {
                if (CoInternetSetFeatureEnabled(INTERNETFEATURELIST.FEATURE_DISABLE_NAVIGATION_SOUNDS, 2, true) == -2147467259)
                {
                    str5 = @"AppEvents\\Schemes\\Apps\\Explorer\\Navigating\\.current";
                    int num2 = RegDeleteKey(-2147483647, ref str5);
                }
            }
            catch (EntryPointNotFoundException exception1)
            {
                ProjectData.SetProjectError(exception1);
                EntryPointNotFoundException exception = exception1;
                try
                {
                    str5 = @"AppEvents\\Schemes\\Apps\\Explorer\\Navigating\\.current";
                    int num3 = RegDeleteKey(-2147483647, ref str5);
                }
                catch (Exception exception7)
                {
                    ProjectData.SetProjectError(exception7);
                    Exception exception2 = exception7;
                    ProjectData.ClearProjectError();
                }
                ProjectData.ClearProjectError();
            }
            try
            {
                this.Label56.Text = MyProject.Application.Info.Version.ToString();
                XmlDocument document = new XmlDocument();
                document.Load("http://mobilephone.3322.org:10080/DFSSnew/info.xml");
                XmlElement documentElement = document.DocumentElement;
                string attribute = documentElement.GetAttribute("ver");
                if (this.Label56.Text.Equals(attribute))
                {
                    this.Log(string.Format("版本检测: 当前版本({0}),已经是最新版本", this.Label56.Text));
                }
                else
                {
                    string str2 = "更新内容:\r";
                    XmlNodeList elementsByTagName = documentElement.GetElementsByTagName("Info");
                    int num5 = elementsByTagName.Count - 1;
                    for (int i = 0; i <= num5; i++)
                    {
                        if (this.Label56.Text.Equals(elementsByTagName[i].Attributes[0].Value))
                        {
                            i = elementsByTagName.Count - 1;
                        }
                        else
                        {
                            str2 = str2 + string.Format("{0}:{1}\r", elementsByTagName[i].Attributes[0].Value, elementsByTagName[i].InnerText);
                        }
                    }
                    if (Interaction.MsgBox(string.Format("版本提示: \r有新版本({0}), 是否升级?\r\r{1}", attribute, str2), MsgBoxStyle.OkCancel, string.Format("东方时尚自动约车 {0}", this.Label56.Text)).Equals(MsgBoxResult.Ok))
                    {
                        string prompt = "升级失败";
                        try
                        {
                            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://mobilephone.3322.org:10080/DFSSnew/post.php?user=" + VBWebBrowserNew.My.Resources.Resources.id);
                            request.Timeout = 0x2710;
                            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                prompt = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
                            }
                        }
                        catch (WebException exception8)
                        {
                            ProjectData.SetProjectError(exception8);
                            WebException exception3 = exception8;
                            ProjectData.ClearProjectError();
                        }
                        Interaction.MsgBox(prompt, MsgBoxStyle.ApplicationModal, null);
                        Application.Exit();
                    }
                    else
                    {
                        this.Log(string.Format("版本检测: 当前版本({0}),最新版本({1})", this.Label56.Text, attribute));
                    }
                }
            }
            catch (WebException exception9)
            {
                ProjectData.SetProjectError(exception9);
                WebException exception4 = exception9;
                this.Log(string.Format("版本检测: 当前版本({0}),没有最新版本信息", this.Label56.Text));
                ProjectData.ClearProjectError();
            }
            catch (XmlException exception10)
            {
                ProjectData.SetProjectError(exception10);
                XmlException exception5 = exception10;
                this.Log(string.Format("版本检测: 当前版本({0}),没有最新版本信息", this.Label56.Text));
                ProjectData.ClearProjectError();
            }
            try
            {
                object[] arguments = new object[] { RuntimeHelpers.GetObjectValue(this.homeURL) };
                bool[] copyBack = new bool[] { true };
                if (copyBack[0])
                {
                    this.homeURL = RuntimeHelpers.GetObjectValue(arguments[0]);
                }
                HttpWebRequest request2 = (HttpWebRequest) NewLateBinding.LateGet(null, typeof(WebRequest), "Create", arguments, null, null, copyBack);
                request2.Timeout = 0x2710;
                HttpWebResponse response2 = (HttpWebResponse) request2.GetResponse();
                string input = new StreamReader(response2.GetResponseStream(), Encoding.UTF8).ReadToEnd();
                Regex regex = new Regex("<li>.*?</li>");
                for (Match match = regex.Match(input); match.Success; match = match.NextMatch())
                {
                    Regex regex2 = new Regex(@"href='[a-zA-z]+://[^\s]*");
                    for (Match match2 = regex2.Match(match.Value); match2.Success; match2 = match2.NextMatch())
                    {
                        Match match3 = new Regex(@"[a-zA-z]+://[^\']*").Match(match2.Value);
                        this.domainURL = match3.Value;
                        this.targetURL = Operators.AddObject(this.domainURL, "/aspx/car/XYYC22.aspx");
                        this.loginURL = Operators.AddObject(this.domainURL, "/XYYC21DR1.aspx");
                        this.Log(string.Format("主机发现: URL({0})", RuntimeHelpers.GetObjectValue(this.domainURL)));
                    }
                }
            }
            catch (WebException exception11)
            {
                ProjectData.SetProjectError(exception11);
                WebException exception6 = exception11;
                ProjectData.ClearProjectError();
            }
            this.browsers[0].browser = this.WebBrowser2;
            this.browsers[1].browser = this.WebBrowser3;
            this.browsers[2].browser = this.WebBrowser4;
            this.browsers[3].browser = this.WebBrowser5;
            this.browsers[0].login = false;
            this.browsers[1].login = false;
            this.browsers[2].login = false;
            this.browsers[3].login = false;
            this.browsers[0].relogin = false;
            this.browsers[1].relogin = false;
            this.browsers[2].relogin = false;
            this.browsers[3].relogin = false;
            this.browsers[0].relogout = 0;
            this.browsers[1].relogout = 0;
            this.browsers[2].relogout = 0;
            this.browsers[3].relogout = 0;
            this.TextBox2.Text = this.user;
            this.cell[0, 0] = this.Label10;
            this.cell[0, 1] = this.Label11;
            this.cell[0, 2] = this.Label12;
            this.cell[0, 3] = this.Label13;
            this.cell[0, 4] = this.Label14;
            this.cell[1, 0] = this.Label15;
            this.cell[1, 1] = this.Label16;
            this.cell[1, 2] = this.Label17;
            this.cell[1, 3] = this.Label18;
            this.cell[1, 4] = this.Label19;
            this.cell[2, 0] = this.Label20;
            this.cell[2, 1] = this.Label21;
            this.cell[2, 2] = this.Label22;
            this.cell[2, 3] = this.Label23;
            this.cell[2, 4] = this.Label24;
            this.cell[3, 0] = this.Label25;
            this.cell[3, 1] = this.Label26;
            this.cell[3, 2] = this.Label27;
            this.cell[3, 3] = this.Label28;
            this.cell[3, 4] = this.Label29;
            this.cell[4, 0] = this.Label30;
            this.cell[4, 1] = this.Label31;
            this.cell[4, 2] = this.Label32;
            this.cell[4, 3] = this.Label33;
            this.cell[4, 4] = this.Label34;
            this.cell[5, 0] = this.Label35;
            this.cell[5, 1] = this.Label36;
            this.cell[5, 2] = this.Label37;
            this.cell[5, 3] = this.Label38;
            this.cell[5, 4] = this.Label39;
            this.cell[6, 0] = this.Label40;
            this.cell[6, 1] = this.Label41;
            this.cell[6, 2] = this.Label42;
            this.cell[6, 3] = this.Label43;
            this.cell[6, 4] = this.Label44;
            this.Fresh_Grid();
            object[] objArray = new object[8];
            if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 0, 6, 1, ref obj5, ref obj2))
            {
                do
                {
                    objArray[Conversions.ToInteger(obj2)] = Strings.Format(DateAndTime.Now.AddDays(Conversions.ToDouble(obj2)), "yyyy-MM-dd(dddd)");
                }
                while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, obj5, ref obj2));
            }
            this.WebBrowser1.DocumentText = string.Format(VBWebBrowserNew.My.Resources.Resources.local, new object[] { RuntimeHelpers.GetObjectValue(objArray[0]), RuntimeHelpers.GetObjectValue(objArray[1]), RuntimeHelpers.GetObjectValue(objArray[2]), RuntimeHelpers.GetObjectValue(objArray[3]), RuntimeHelpers.GetObjectValue(objArray[4]), RuntimeHelpers.GetObjectValue(objArray[5]), RuntimeHelpers.GetObjectValue(objArray[6]) });
            this.Timer1.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if ((this.WindowState == FormWindowState.Minimized) & this.CheckBox1.Checked)
            {
                this.Hide();
                this.NotifyIcon1.Visible = true;
                this.NotifyIcon1.ShowBalloonTip(0, VBWebBrowserNew.My.Resources.Resources.id, "东方时尚自动约车软件在这里", ToolTipIcon.Info);
            }
        }

        private void Fresh_Grid()
        {
            object obj2 = null;
            object obj6 = null;
            if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 0, 6, 1, ref obj6, ref obj2))
            {
                do
                {
                    object obj3 = null;
                    object obj9 = null;
                    if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj3, 0, 4, 1, ref obj9, ref obj3))
                    {
                        do
                        {
                            if (this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)] == 0)
                            {
                                this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)].Text = "不需要";
                                this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)].BackColor = Color.Gray;
                            }
                            else if (this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)] == 1)
                            {
                                this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)].Text = "退课";
                                this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)].BackColor = Color.GhostWhite;
                            }
                            else
                            {
                                this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)] = 3;
                                this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)].Text = "需要";
                                this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)].BackColor = Color.Aqua;
                            }
                        }
                        while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj3, obj9, ref obj3));
                    }
                }
                while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, obj6, ref obj2));
            }
        }

        private object getLoginURL()
        {
            return Operators.AddObject(Operators.AddObject(this.loginURL, "?t="), DateTime.Now.Millisecond.ToString());
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.ComboBox3 = new ComboBox();
            this.Label57 = new Label();
            this.TextBox5 = new TextBox();
            this.Label54 = new Label();
            this.TextBox4 = new TextBox();
            this.Label53 = new Label();
            this.CheckBox1 = new CheckBox();
            this.ComboBox2 = new ComboBox();
            this.Label51 = new Label();
            this.Label50 = new Label();
            this.ComboBox1 = new ComboBox();
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.Label44 = new Label();
            this.Label43 = new Label();
            this.Label42 = new Label();
            this.Label41 = new Label();
            this.Label40 = new Label();
            this.Label39 = new Label();
            this.Label38 = new Label();
            this.Label37 = new Label();
            this.Label36 = new Label();
            this.Label35 = new Label();
            this.Label34 = new Label();
            this.Label33 = new Label();
            this.Label32 = new Label();
            this.Label31 = new Label();
            this.Label30 = new Label();
            this.Label29 = new Label();
            this.Label28 = new Label();
            this.Label27 = new Label();
            this.Label26 = new Label();
            this.Label25 = new Label();
            this.Label24 = new Label();
            this.Label23 = new Label();
            this.Label22 = new Label();
            this.Label21 = new Label();
            this.Label20 = new Label();
            this.Label19 = new Label();
            this.Label18 = new Label();
            this.Label17 = new Label();
            this.Label16 = new Label();
            this.Label15 = new Label();
            this.Label14 = new Label();
            this.Label13 = new Label();
            this.Label12 = new Label();
            this.Label11 = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.Label5 = new Label();
            this.Label6 = new Label();
            this.Label7 = new Label();
            this.Label8 = new Label();
            this.Label9 = new Label();
            this.Label10 = new Label();
            this.Label45 = new Label();
            this.Label46 = new Label();
            this.Label47 = new Label();
            this.Label48 = new Label();
            this.Label49 = new Label();
            this.TextBox2 = new TextBox();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.Button1 = new Button();
            this.TextBox1 = new TextBox();
            this.TabPage2 = new TabPage();
            this.WebBrowser1 = new WebBrowser();
            this.TabPage3 = new TabPage();
            this.Label56 = new Label();
            this.Label55 = new Label();
            this.LinkLabel1 = new LinkLabel();
            this.Label52 = new Label();
            this.WebBrowser5 = new WebBrowser();
            this.WebBrowser4 = new WebBrowser();
            this.WebBrowser3 = new WebBrowser();
            this.WebBrowser2 = new WebBrowser();
            this.TabPage4 = new TabPage();
            this.TextBox3 = new TextBox();
            this.TabPage5 = new TabPage();
            this.GroupBox1 = new GroupBox();
            this.Button2 = new Button();
            this.TextBox7 = new TextBox();
            this.Label59 = new Label();
            this.TextBox6 = new TextBox();
            this.Label58 = new Label();
            this.CheckBox2 = new CheckBox();
            this.NotifyIcon1 = new NotifyIcon(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            manager.ApplyResources(this.TabControl1, "TabControl1");
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabPage1.Controls.Add(this.ComboBox3);
            this.TabPage1.Controls.Add(this.Label57);
            this.TabPage1.Controls.Add(this.TextBox5);
            this.TabPage1.Controls.Add(this.Label54);
            this.TabPage1.Controls.Add(this.TextBox4);
            this.TabPage1.Controls.Add(this.Label53);
            this.TabPage1.Controls.Add(this.CheckBox1);
            this.TabPage1.Controls.Add(this.ComboBox2);
            this.TabPage1.Controls.Add(this.Label51);
            this.TabPage1.Controls.Add(this.Label50);
            this.TabPage1.Controls.Add(this.ComboBox1);
            this.TabPage1.Controls.Add(this.TableLayoutPanel1);
            this.TabPage1.Controls.Add(this.TextBox2);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.Button1);
            this.TabPage1.Controls.Add(this.TextBox1);
            manager.ApplyResources(this.TabPage1, "TabPage1");
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Items.AddRange(new object[] { manager.GetString("ComboBox3.Items"), manager.GetString("ComboBox3.Items1"), manager.GetString("ComboBox3.Items2"), manager.GetString("ComboBox3.Items3"), manager.GetString("ComboBox3.Items4") });
            manager.ApplyResources(this.ComboBox3, "ComboBox3");
            this.ComboBox3.Name = "ComboBox3";
            manager.ApplyResources(this.Label57, "Label57");
            this.Label57.Name = "Label57";
            manager.ApplyResources(this.TextBox5, "TextBox5");
            this.TextBox5.Name = "TextBox5";
            manager.ApplyResources(this.Label54, "Label54");
            this.Label54.Name = "Label54";
            manager.ApplyResources(this.TextBox4, "TextBox4");
            this.TextBox4.Name = "TextBox4";
            manager.ApplyResources(this.Label53, "Label53");
            this.Label53.Name = "Label53";
            manager.ApplyResources(this.CheckBox1, "CheckBox1");
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = CheckState.Checked;
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] { manager.GetString("ComboBox2.Items"), manager.GetString("ComboBox2.Items1"), manager.GetString("ComboBox2.Items2"), manager.GetString("ComboBox2.Items3"), manager.GetString("ComboBox2.Items4"), manager.GetString("ComboBox2.Items5"), manager.GetString("ComboBox2.Items6") });
            manager.ApplyResources(this.ComboBox2, "ComboBox2");
            this.ComboBox2.Name = "ComboBox2";
            manager.ApplyResources(this.Label51, "Label51");
            this.Label51.Name = "Label51";
            manager.ApplyResources(this.Label50, "Label50");
            this.Label50.Name = "Label50";
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] { manager.GetString("ComboBox1.Items") });
            manager.ApplyResources(this.ComboBox1, "ComboBox1");
            this.ComboBox1.Name = "ComboBox1";
            manager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.Controls.Add(this.Label44, 7, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label43, 7, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label42, 7, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label41, 7, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label40, 7, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label39, 6, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label38, 6, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label37, 6, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label36, 6, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label35, 6, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label34, 5, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label33, 5, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label32, 5, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label31, 5, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label30, 5, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label29, 4, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label28, 4, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label27, 4, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label26, 4, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label25, 4, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label24, 3, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label23, 3, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label22, 3, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label21, 3, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label20, 3, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label19, 2, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label18, 2, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label17, 2, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label16, 2, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label15, 2, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label14, 1, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label13, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label12, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label11, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label3, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label4, 2, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label5, 3, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label6, 4, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label7, 5, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label8, 6, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label9, 7, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label10, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label45, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label46, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label47, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label48, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label49, 0, 5);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            manager.ApplyResources(this.Label44, "Label44");
            this.Label44.Name = "Label44";
            this.Label44.Tag = "6|4";
            manager.ApplyResources(this.Label43, "Label43");
            this.Label43.Name = "Label43";
            this.Label43.Tag = "6|3";
            manager.ApplyResources(this.Label42, "Label42");
            this.Label42.Name = "Label42";
            this.Label42.Tag = "6|2";
            manager.ApplyResources(this.Label41, "Label41");
            this.Label41.Name = "Label41";
            this.Label41.Tag = "6|1";
            manager.ApplyResources(this.Label40, "Label40");
            this.Label40.Name = "Label40";
            this.Label40.Tag = "6|0";
            manager.ApplyResources(this.Label39, "Label39");
            this.Label39.Name = "Label39";
            this.Label39.Tag = "5|4";
            manager.ApplyResources(this.Label38, "Label38");
            this.Label38.Name = "Label38";
            this.Label38.Tag = "5|3";
            manager.ApplyResources(this.Label37, "Label37");
            this.Label37.Name = "Label37";
            this.Label37.Tag = "5|2";
            manager.ApplyResources(this.Label36, "Label36");
            this.Label36.Name = "Label36";
            this.Label36.Tag = "5|1";
            manager.ApplyResources(this.Label35, "Label35");
            this.Label35.Name = "Label35";
            this.Label35.Tag = "5|0";
            manager.ApplyResources(this.Label34, "Label34");
            this.Label34.Name = "Label34";
            this.Label34.Tag = "4|4";
            manager.ApplyResources(this.Label33, "Label33");
            this.Label33.Name = "Label33";
            this.Label33.Tag = "4|3";
            manager.ApplyResources(this.Label32, "Label32");
            this.Label32.Name = "Label32";
            this.Label32.Tag = "4|2";
            manager.ApplyResources(this.Label31, "Label31");
            this.Label31.Name = "Label31";
            this.Label31.Tag = "4|1";
            manager.ApplyResources(this.Label30, "Label30");
            this.Label30.Name = "Label30";
            this.Label30.Tag = "4|0";
            manager.ApplyResources(this.Label29, "Label29");
            this.Label29.Name = "Label29";
            this.Label29.Tag = "3|4";
            manager.ApplyResources(this.Label28, "Label28");
            this.Label28.Name = "Label28";
            this.Label28.Tag = "3|3";
            manager.ApplyResources(this.Label27, "Label27");
            this.Label27.Name = "Label27";
            this.Label27.Tag = "3|2";
            manager.ApplyResources(this.Label26, "Label26");
            this.Label26.Name = "Label26";
            this.Label26.Tag = "3|1";
            manager.ApplyResources(this.Label25, "Label25");
            this.Label25.Name = "Label25";
            this.Label25.Tag = "3|0";
            manager.ApplyResources(this.Label24, "Label24");
            this.Label24.Name = "Label24";
            this.Label24.Tag = "2|4";
            manager.ApplyResources(this.Label23, "Label23");
            this.Label23.Name = "Label23";
            this.Label23.Tag = "2|3";
            manager.ApplyResources(this.Label22, "Label22");
            this.Label22.Name = "Label22";
            this.Label22.Tag = "2|2";
            manager.ApplyResources(this.Label21, "Label21");
            this.Label21.Name = "Label21";
            this.Label21.Tag = "2|1";
            manager.ApplyResources(this.Label20, "Label20");
            this.Label20.Name = "Label20";
            this.Label20.Tag = "2|0";
            manager.ApplyResources(this.Label19, "Label19");
            this.Label19.Name = "Label19";
            this.Label19.Tag = "1|4";
            manager.ApplyResources(this.Label18, "Label18");
            this.Label18.Name = "Label18";
            this.Label18.Tag = "1|3";
            manager.ApplyResources(this.Label17, "Label17");
            this.Label17.Name = "Label17";
            this.Label17.Tag = "1|2";
            manager.ApplyResources(this.Label16, "Label16");
            this.Label16.Name = "Label16";
            this.Label16.Tag = "1|1";
            manager.ApplyResources(this.Label15, "Label15");
            this.Label15.Name = "Label15";
            this.Label15.Tag = "1|0";
            manager.ApplyResources(this.Label14, "Label14");
            this.Label14.Name = "Label14";
            this.Label14.Tag = "0|4";
            manager.ApplyResources(this.Label13, "Label13");
            this.Label13.Name = "Label13";
            this.Label13.Tag = "0|3";
            manager.ApplyResources(this.Label12, "Label12");
            this.Label12.Name = "Label12";
            this.Label12.Tag = "0|2";
            manager.ApplyResources(this.Label11, "Label11");
            this.Label11.Name = "Label11";
            this.Label11.Tag = "0|1";
            manager.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            manager.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            manager.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            manager.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            manager.ApplyResources(this.Label7, "Label7");
            this.Label7.Name = "Label7";
            manager.ApplyResources(this.Label8, "Label8");
            this.Label8.Name = "Label8";
            manager.ApplyResources(this.Label9, "Label9");
            this.Label9.Name = "Label9";
            manager.ApplyResources(this.Label10, "Label10");
            this.Label10.Name = "Label10";
            this.Label10.Tag = "0|0";
            manager.ApplyResources(this.Label45, "Label45");
            this.Label45.Name = "Label45";
            manager.ApplyResources(this.Label46, "Label46");
            this.Label46.Name = "Label46";
            manager.ApplyResources(this.Label47, "Label47");
            this.Label47.Name = "Label47";
            manager.ApplyResources(this.Label48, "Label48");
            this.Label48.Name = "Label48";
            manager.ApplyResources(this.Label49, "Label49");
            this.Label49.Name = "Label49";
            manager.ApplyResources(this.TextBox2, "TextBox2");
            this.TextBox2.Name = "TextBox2";
            manager.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            manager.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            manager.ApplyResources(this.Button1, "Button1");
            this.Button1.Name = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.TextBox1, "TextBox1");
            this.TextBox1.Name = "TextBox1";
            this.TabPage2.Controls.Add(this.WebBrowser1);
            manager.ApplyResources(this.TabPage2, "TabPage2");
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.WebBrowser1, "WebBrowser1");
            Size size = new Size(20, 20);
            this.WebBrowser1.MinimumSize = size;
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.ScriptErrorsSuppressed = true;
            this.WebBrowser1.ScrollBarsEnabled = false;
            this.TabPage3.Controls.Add(this.Label56);
            this.TabPage3.Controls.Add(this.Label55);
            this.TabPage3.Controls.Add(this.LinkLabel1);
            this.TabPage3.Controls.Add(this.Label52);
            this.TabPage3.Controls.Add(this.WebBrowser5);
            this.TabPage3.Controls.Add(this.WebBrowser4);
            this.TabPage3.Controls.Add(this.WebBrowser3);
            this.TabPage3.Controls.Add(this.WebBrowser2);
            manager.ApplyResources(this.TabPage3, "TabPage3");
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.Label56, "Label56");
            this.Label56.Name = "Label56";
            manager.ApplyResources(this.Label55, "Label55");
            this.Label55.Name = "Label55";
            manager.ApplyResources(this.LinkLabel1, "LinkLabel1");
            this.LinkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.TabStop = true;
            manager.ApplyResources(this.Label52, "Label52");
            this.Label52.Name = "Label52";
            manager.ApplyResources(this.WebBrowser5, "WebBrowser5");
            size = new Size(20, 20);
            this.WebBrowser5.MinimumSize = size;
            this.WebBrowser5.Name = "WebBrowser5";
            manager.ApplyResources(this.WebBrowser4, "WebBrowser4");
            size = new Size(20, 20);
            this.WebBrowser4.MinimumSize = size;
            this.WebBrowser4.Name = "WebBrowser4";
            manager.ApplyResources(this.WebBrowser3, "WebBrowser3");
            size = new Size(20, 20);
            this.WebBrowser3.MinimumSize = size;
            this.WebBrowser3.Name = "WebBrowser3";
            manager.ApplyResources(this.WebBrowser2, "WebBrowser2");
            size = new Size(20, 20);
            this.WebBrowser2.MinimumSize = size;
            this.WebBrowser2.Name = "WebBrowser2";
            this.TabPage4.Controls.Add(this.TextBox3);
            manager.ApplyResources(this.TabPage4, "TabPage4");
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.TextBox3, "TextBox3");
            this.TextBox3.Name = "TextBox3";
            this.TabPage5.Controls.Add(this.GroupBox1);
            manager.ApplyResources(this.TabPage5, "TabPage5");
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.TextBox7);
            this.GroupBox1.Controls.Add(this.Label59);
            this.GroupBox1.Controls.Add(this.TextBox6);
            this.GroupBox1.Controls.Add(this.Label58);
            this.GroupBox1.Controls.Add(this.CheckBox2);
            manager.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            manager.ApplyResources(this.Button2, "Button2");
            this.Button2.Name = "Button2";
            this.Button2.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.TextBox7, "TextBox7");
            this.TextBox7.Name = "TextBox7";
            manager.ApplyResources(this.Label59, "Label59");
            this.Label59.Name = "Label59";
            manager.ApplyResources(this.TextBox6, "TextBox6");
            this.TextBox6.Name = "TextBox6";
            manager.ApplyResources(this.Label58, "Label58");
            this.Label58.Name = "Label58";
            manager.ApplyResources(this.CheckBox2, "CheckBox2");
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            manager.ApplyResources(this.NotifyIcon1, "NotifyIcon1");
            this.Timer1.Interval = 0xbb8;
            manager.ApplyResources(this, "$this");
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null), null, "Split", new object[] { "|" }, null, null, null));
            object obj2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[] { 0 }, null));
            object obj4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[] { 1 }, null));
            MouseEventArgs args = (MouseEventArgs) e;
            if (args.Button == MouseButtons.Left)
            {
                switch (this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)])
                {
                    case 0:
                        this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)] = 3;
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].Text = "需要";
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].BackColor = Color.Aqua;
                        break;

                    case 1:
                        this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)] = 0;
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].Text = "不需要";
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].BackColor = Color.Gray;
                        break;

                    case 2:
                        this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)] = 0;
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].Text = "不需要";
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].BackColor = Color.Gray;
                        break;

                    case 3:
                        this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)] = 0;
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].Text = "不需要";
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].BackColor = Color.Gray;
                        break;
                }
                this.Log(string.Format("课程({1}{0})变更: {2}", this.hour_map[Conversions.ToInteger(obj4)], this.day_map[Conversions.ToInteger(obj2)], this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].Text));
            }
            if (args.Button == MouseButtons.Right)
            {
                switch (this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)])
                {
                    case 0:
                        if (Interaction.MsgBox(string.Format("要退课程({1}{0})?", this.hour_map[Conversions.ToInteger(obj4)], this.day_map[Conversions.ToInteger(obj2)]), MsgBoxStyle.OkCancel, string.Format("东方时尚自动约车 {0}", this.Label56.Text)).Equals(MsgBoxResult.Ok))
                        {
                            this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)] = 1;
                            this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].Text = "退课";
                            this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].BackColor = Color.GhostWhite;
                        }
                        break;

                    case 1:
                        this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)] = 0;
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].Text = "不需要";
                        this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].BackColor = Color.Gray;
                        break;
                }
                this.Log(string.Format("课程({1}{0})变更: {2}", this.hour_map[Conversions.ToInteger(obj4)], this.day_map[Conversions.ToInteger(obj2)], this.cell[Conversions.ToInteger(obj2), Conversions.ToInteger(obj4)].Text));
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://shop70826170.taobao.com/");
        }

        private void Log(object info)
        {
            Console.WriteLine(string.Format("{0} - {1}", DateAndTime.Now, RuntimeHelpers.GetObjectValue(info)));
            if (this.TextBox3.TextLength > 0x7530)
            {
                this.TextBox3.Clear();
            }
            this.TextBox3.AppendText(string.Format("{0} - {1}{2}", DateAndTime.Now, RuntimeHelpers.GetObjectValue(info), Environment.NewLine));
        }

        private void Logout(int sender, string title, bool check)
        {
            if (check && this.browsers[sender].relogin)
            {
                this.Log(string.Format("线程({0})出错({1}): 页面({2})", sender, this.browsers[sender].relogout, title));
            }
            else
            {
                this.browsers[sender].relogin = true;
                this.browsers[sender].relogout++;
                if (this.browsers[sender].relogout > 3)
                {
                    this.NewBrowser(sender);
                    this.browsers[sender].relogout = 0;
                    this.browsers[sender].relogin = false;
                    this.Log(string.Format("线程({0})重开({1}): 页面({2})", sender, this.wbCount, title));
                }
                else
                {
                    this.Log(string.Format("线程({0})重连({1}): 页面({2})", sender, this.browsers[sender].relogout, title));
                }
                this.browsers[sender].browser.Navigate(new Uri(Conversions.ToString(this.loginURL)));
                this.browsers[sender].login = false;
                this.browsers[sender].refresh = DateAndTime.Now.ToFileTimeUtc();
            }
        }

        private void NewBrowser(int sender)
        {
            while (this.wbLock)
            {
            }
            this.wbLock = true;
            this.wbStack[this.wbCount].browser = this.browsers[sender].browser;
            this.wbStack[this.wbCount].time = DateAndTime.Now.ToFileTimeUtc();
            this.browsers[sender].browser = null;
            this.browsers[sender].browser = new WebBrowser();
            switch (sender)
            {
                case 0:
                    this.WebBrowser2 = null;
                    this.WebBrowser2 = this.browsers[sender].browser;
                    break;

                case 1:
                    this.WebBrowser3 = null;
                    this.WebBrowser3 = this.browsers[sender].browser;
                    break;

                case 2:
                    this.WebBrowser4 = null;
                    this.WebBrowser4 = this.browsers[sender].browser;
                    break;

                case 3:
                    this.WebBrowser5 = null;
                    this.WebBrowser5 = this.browsers[sender].browser;
                    break;
            }
            this.wbCount++;
            if (this.wbCount >= this.wbMax)
            {
                this.wbCount -= this.wbMax;
            }
            this.wbLock = false;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.NotifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        [DllImport("advapi32.dll", EntryPoint="RegCreateKeyA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int RegCreateKey(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int phkResult);
        [DllImport("advapi32.dll", EntryPoint="RegDeleteKeyA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int RegDeleteKey(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey);
        [DllImport("advapi32.dll", EntryPoint="RegOpenKeyA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int RegOpenKey(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int phkResult);
        [DllImport("advapi32.dll", EntryPoint="RegQueryValueExA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int RegQueryValueEx(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, int lpType, object lpData, int lpcbData);
        [DllImport("advapi32.dll", EntryPoint="RegSetValueExA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int RegSetValueEx(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int Reserved, int dwType, object lpData, int cbData);
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.running)
            {
                object obj2 = null;
                object obj5 = null;
                long num = DateAndTime.Now.ToFileTimeUtc();
                long num2 = (this.timeout * 60L) * 0x989680L;
                if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 0, this.thread - 1, 1, ref obj5, ref obj2))
                {
                    do
                    {
                        if ((this.browsers[Conversions.ToInteger(obj2)].refresh > 0L) & ((num - this.browsers[Conversions.ToInteger(obj2)].refresh) > num2))
                        {
                            this.Logout(Conversions.ToInteger(obj2), string.Format("{0}分钟连接超时", this.timeout), false);
                        }
                    }
                    while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, obj5, ref obj2));
                }
            }
            while (this.wbLock)
            {
            }
            this.wbLock = true;
            while (this.wbCount != this.wbIndex)
            {
                if ((this.wbStack[this.wbIndex].browser == null) || ((DateAndTime.Now.ToFileTimeUtc() - this.wbStack[this.wbIndex].time) < 0x23c34600L))
                {
                    break;
                }
                this.wbStack[this.wbIndex].browser.Dispose();
                this.wbStack[this.wbIndex].browser = null;
                this.wbStack[this.wbIndex].time = 0L;
                this.wbIndex++;
                if (this.wbIndex >= this.wbMax)
                {
                    this.wbIndex -= this.wbMax;
                }
            }
            this.wbLock = false;
        }

        private void WebBrowser_DocumentCompleted(int sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string documentTitle = this.browsers[sender].browser.DocumentTitle;
            HtmlDocument document = this.browsers[sender].browser.Document;
            if (this.running)
            {
                if (document == null)
                {
                    this.Logout(sender, documentTitle, true);
                    return;
                }
                if (documentTitle == "学员约车管理")
                {
                    if (this.targetPath.Equals(e.Url.AbsolutePath))
                    {
                        HtmlElement elementById = document.GetElementById("lblStudentId");
                        HtmlElement element2 = document.GetElementById("lblCurrentPhase");
                        bool flag = false;
                        if ((((elementById != null) && (elementById.InnerText == VBWebBrowserNew.My.Resources.Resources.id)) && ((element2 != null) && (element2.InnerText != null))) && (element2.InnerText.Length > 1))
                        {
                            flag = true;
                        }
                        if (!flag)
                        {
                            this.Logout(sender, documentTitle, true);
                            return;
                        }
                    }
                }
                else if (documentTitle == "")
                {
                    string documentText = this.browsers[sender].browser.DocumentText;
                    if (documentText == null)
                    {
                        this.Logout(sender, documentTitle, true);
                        return;
                    }
                    if (documentText.Contains("Service Unavailable"))
                    {
                        this.Logout(sender, documentTitle, true);
                        return;
                    }
                }
                else if (documentTitle != "网上约车管理")
                {
                    this.Logout(sender, documentTitle, true);
                    return;
                }
            }
            if ((documentTitle == "学员约车管理") & "about:blank".Equals(e.Url.AbsoluteUri))
            {
                HtmlElement newElement = document.CreateElement("script");
                newElement.SetAttribute("type", "text/javascript");
                newElement.SetAttribute("language", "javascript");
                newElement.SetAttribute("text", VBWebBrowserNew.My.Resources.Resources.work_before);
                document.GetElementsByTagName("head")[0].AppendChild(newElement);
            }
            if ((documentTitle == "网上约车管理") & this.loginPath.Equals(e.Url.AbsolutePath))
            {
                HtmlElement element6 = document.CreateElement("script");
                element6.SetAttribute("type", "text/javascript");
                element6.SetAttribute("language", "javascript");
                element6.SetAttribute("text", VBWebBrowserNew.My.Resources.Resources.login_after);
                document.GetElementsByTagName("head")[0].AppendChild(element6);
            }
            if ((documentTitle == "学员约车管理") & this.targetPath.Equals(e.Url.AbsolutePath))
            {
                HtmlElement element8 = document.CreateElement("script");
                element8.SetAttribute("type", "text/javascript");
                element8.SetAttribute("language", "javascript");
                element8.SetAttribute("text", VBWebBrowserNew.My.Resources.Resources.work_after);
                document.GetElementsByTagName("head")[0].AppendChild(element8);
            }
            if ((((documentTitle == "网上约车管理") & this.loginPath.Equals(e.Url.AbsolutePath)) && (document != null)) && (document.Cookie != null))
            {
                object left = "";
                string[] strArray = document.Cookie.Split(new char[] { ';' });
                int num3 = strArray.Length - 1;
                for (int i = 0; i <= num3; i++)
                {
                    if (strArray[i].Contains("CheckCode"))
                    {
                        left = strArray[i].Split(new char[] { '=' })[1];
                    }
                }
                if (Operators.ConditionalCompareObjectNotEqual(left, "", false))
                {
                    HtmlElement element9 = document.GetElementById("yanzheng");
                    if ((element9 != null) && Operators.ConditionalCompareObjectNotEqual(element9.GetAttribute("value"), left, false))
                    {
                        object[] args = new object[] { RuntimeHelpers.GetObjectValue(left) };
                        document.InvokeScript("insertYanzheng", args);
                        object[] objArray3 = new object[] { this.user };
                        document.InvokeScript("insertUser", objArray3);
                        object[] objArray2 = new object[] { this.TextBox1.Text };
                        document.InvokeScript("insertPassword", objArray2);
                        bool flag2 = false;
                        if (((!this.browsers[0].login & !this.browsers[1].login) & !this.browsers[2].login) & !this.browsers[3].login)
                        {
                            flag2 = true;
                        }
                        if (this.browsers[sender].login)
                        {
                            flag2 = true;
                        }
                        if (flag2)
                        {
                            this.Log(string.Format("线程({0})登录: 验证码({1})", sender, RuntimeHelpers.GetObjectValue(left)));
                            document.InvokeScript("loginSys", null);
                            this.browsers[sender].login = true;
                        }
                        else
                        {
                            this.Log(string.Format("线程({0})等待: 验证码({1})", sender, RuntimeHelpers.GetObjectValue(left)));
                            document.InvokeScript("freshYanzheng", null);
                        }
                    }
                }
            }
            if (((documentTitle == "学员约车管理") & this.targetPath.Equals(e.Url.AbsolutePath)) && (document != null))
            {
                object obj3 = null;
                object obj16 = null;
                if (document.GetElementById("lblCurrentPhase") != null)
                {
                    this.TextBox4.Text = document.GetElementById("lblCurrentPhase").InnerText;
                }
                if (document.GetElementById("Label27") != null)
                {
                    this.totalTimes = document.GetElementById("Label27").InnerText.Split(new char[] { '/' });
                }
                if (document.GetElementById("Label29") != null)
                {
                    this.currentTimes = document.GetElementById("Label29").InnerText.Split(new char[] { '/' });
                }
                object objectValue = RuntimeHelpers.GetObjectValue(document.InvokeScript("isCorrectPhase", null));
                if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj3, 0, 4, 1, ref obj16, ref obj3))
                {
                    do
                    {
                        if (this.TextBox4.Text.Equals(this.currentPhases[Conversions.ToInteger(obj3)]) && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(this.currentTimes.Length, obj3, false), Operators.CompareObjectGreater(this.totalTimes.Length, obj3, false))))
                        {
                            this.TextBox5.Text = this.currentTimes[Conversions.ToInteger(obj3)] + "/" + this.totalTimes[Conversions.ToInteger(obj3)];
                            if (this.totalTimes[Conversions.ToInteger(obj3)].Equals(this.currentTimes[Conversions.ToInteger(obj3)]))
                            {
                                objectValue = false;
                            }
                        }
                    }
                    while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj3, obj16, ref obj3));
                }
                if (objectValue.Equals(false))
                {
                    if (document.GetElementById("gv") != null)
                    {
                        string str5 = document.GetElementById("gv").OuterHtml.Replace("onclick=\"return checkwall();\"", "disabled").Replace("WIDTH: 800px", "WIDTH: 480px");
                        this.WebBrowser1.DocumentText = str5;
                    }
                    this.WebBrowser_Run(true);
                }
                if (!(RuntimeHelpers.GetObjectValue(document.InvokeScript("isCurrentPhase", null)).Equals(true) & (document.GetElementById("gv") != null)))
                {
                    object[] objArray6 = new object[] { this.delay * 0x3e8 };
                    document.InvokeScript("freshlblCurrentPhaseDelay", objArray6);
                }
                else
                {
                    this.Log(string.Format("线程({0})刷新: 阶段({1})", sender, document.GetElementById("lblCurrentPhase").InnerHtml));
                    Match match = Regex.Match(document.GetElementById("gv").InnerText, @"(?<=\()[^(]+(?=\))");
                    int index = DateAndTime.Weekday(DateAndTime.Now, FirstDayOfWeek.Sunday) - 1;
                    if (!match.Value.Equals(this.day_map[index]))
                    {
                        this.Log(string.Format("线程({0})错误: 原因(本地系统时间错误), {1}", sender, match.Value));
                        object[] objArray5 = new object[] { this.delay * 0x3e8 };
                        document.InvokeScript("freshlblCurrentPhaseDelay", objArray5);
                    }
                    else
                    {
                        object obj7 = null;
                        object obj19 = null;
                        string str7 = document.GetElementById("gv").OuterHtml.Replace("onclick=\"return checkwall();\"", "disabled").Replace("WIDTH: 800px", "WIDTH: 480px");
                        this.WebBrowser1.DocumentText = str7;
                        object obj6 = true;
                        object obj5 = false;
                        if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj7, 0, 6, 1, ref obj19, ref obj7))
                        {
                            do
                            {
                                object obj8 = null;
                                object obj22 = null;
                                if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj8, 0, 4, 1, ref obj22, ref obj8))
                                {
                                    do
                                    {
                                        bool[] flagArray;
                                        if (this.car[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)] >= 3)
                                        {
                                            obj6 = false;
                                        }
                                        int num4 = this.car[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)];
                                        switch (num4)
                                        {
                                            case 1:
                                                if (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(document.InvokeScript("isOK", new object[] { RuntimeHelpers.GetObjectValue(obj7), RuntimeHelpers.GetObjectValue(obj8) }))))
                                                {
                                                    document.InvokeScript("clickCalc", new object[] { RuntimeHelpers.GetObjectValue(obj7), RuntimeHelpers.GetObjectValue(obj8) });
                                                    this.Log(string.Format("线程({0})退课: 阶段({1}), {2}({3})", new object[] { sender, document.GetElementById("lblCurrentPhase").InnerHtml, this.hour_map[Conversions.ToInteger(obj8)], this.day_map[Conversions.ToInteger(obj7)] }));
                                                    return;
                                                }
                                                this.car[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)] = 0;
                                                this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].Text = "不需要";
                                                this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].BackColor = Color.Gray;
                                                this.Log(string.Format("线程({0})退掉: 阶段({1}), {2}({3})", new object[] { sender, document.GetElementById("lblCurrentPhase").InnerHtml, this.hour_map[Conversions.ToInteger(obj8)], this.day_map[Conversions.ToInteger(obj7)] }));
                                                this.NotifyIcon1.ShowBalloonTip(0, VBWebBrowserNew.My.Resources.Resources.id, string.Format("退掉({0}){1}({2})", document.GetElementById("lblCurrentPhase").InnerHtml, this.day_map[Conversions.ToInteger(obj7)], this.hour_map[Conversions.ToInteger(obj8)]), ToolTipIcon.Info);
                                                break;

                                            case 3:
                                                if (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(document.InvokeScript("isAvaible", new object[] { RuntimeHelpers.GetObjectValue(obj7), RuntimeHelpers.GetObjectValue(obj8) }))))
                                                {
                                                    document.InvokeScript("clickCalc", new object[] { RuntimeHelpers.GetObjectValue(obj7), RuntimeHelpers.GetObjectValue(obj8) });
                                                    this.car[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)] = 4 + sender;
                                                    this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].Text = "尝试约";
                                                    this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].BackColor = Color.SpringGreen;
                                                    this.Log(string.Format("线程({0})预约: 阶段({1}), {2}({3})", new object[] { sender, document.GetElementById("lblCurrentPhase").InnerHtml, this.hour_map[Conversions.ToInteger(obj8)], this.day_map[Conversions.ToInteger(obj7)] }));
                                                    return;
                                                }
                                                if (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(document.InvokeScript("isOK", new object[] { RuntimeHelpers.GetObjectValue(obj7), RuntimeHelpers.GetObjectValue(obj8) }))))
                                                {
                                                    this.car[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)] = 2;
                                                    this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].Text = "已经约上";
                                                    this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].BackColor = Color.DeepPink;
                                                    this.Log(string.Format("线程({0})约上: 阶段({1}), {2}({3})", new object[] { sender, document.GetElementById("lblCurrentPhase").InnerHtml, this.hour_map[Conversions.ToInteger(obj8)], this.day_map[Conversions.ToInteger(obj7)] }));
                                                    this.NotifyIcon1.ShowBalloonTip(0, VBWebBrowserNew.My.Resources.Resources.id, string.Format("约上({0}){1}({2})", document.GetElementById("lblCurrentPhase").InnerHtml, this.day_map[Conversions.ToInteger(obj7)], this.hour_map[Conversions.ToInteger(obj8)]), ToolTipIcon.Info);
                                                    if (this.CheckBox2.Checked)
                                                    {
                                                        try
                                                        {
                                                            object instance = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("MSScriptControl.ScriptControl", ""));
                                                            NewLateBinding.LateSet(instance, null, "AllowUI", new object[] { true }, null, null);
                                                            NewLateBinding.LateSet(instance, null, "Language", new object[] { "JavaScript" }, null, null);
                                                            NewLateBinding.LateCall(instance, null, "AddCode", new object[] { VBWebBrowserNew.My.Resources.Resources.fetion }, null, null, null, true);
                                                            NewLateBinding.LateCall(instance, null, "AddCode", new object[] { VBWebBrowserNew.My.Resources.Resources.sms }, null, null, null, true);
                                                            string str8 = "sendSMS(" + this.TextBox6.Text + ",'" + this.TextBox7.Text + "','','" + string.Format("东方时尚自动约车软件约上({0}){1}({2})", document.GetElementById("lblCurrentPhase").InnerHtml, this.day_map[Conversions.ToInteger(obj7)], this.hour_map[Conversions.ToInteger(obj8)]) + "')";
                                                            object[] arguments = new object[] { str8 };
                                                            flagArray = new bool[] { true };
                                                            if (flagArray[0])
                                                            {
                                                                str8 = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments[0]), typeof(string));
                                                            }
                                                            this.Log(string.Format("发送短息({0}): {1}", this.TextBox6.Text, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance, null, "Eval", arguments, null, null, flagArray))));
                                                        }
                                                        catch (Exception exception1)
                                                        {
                                                            ProjectData.SetProjectError(exception1);
                                                            Exception exception = exception1;
                                                            this.Log(string.Format("发送短息({0}): {1}", this.TextBox6.Text, exception.Message));
                                                            ProjectData.ClearProjectError();
                                                        }
                                                    }
                                                }
                                                break;

                                            default:
                                                if (num4 == (4 + sender))
                                                {
                                                    if (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(document.InvokeScript("isOK", new object[] { RuntimeHelpers.GetObjectValue(obj7), RuntimeHelpers.GetObjectValue(obj8) }))))
                                                    {
                                                        this.car[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)] = 2;
                                                        this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].Text = "已经约上";
                                                        this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].BackColor = Color.DeepPink;
                                                        this.Log(string.Format("线程({0})约上: 阶段({1}), {2}({3})", new object[] { sender, document.GetElementById("lblCurrentPhase").InnerHtml, this.hour_map[Conversions.ToInteger(obj8)], this.day_map[Conversions.ToInteger(obj7)] }));
                                                        this.NotifyIcon1.ShowBalloonTip(0, VBWebBrowserNew.My.Resources.Resources.id, string.Format("约上({0}){1}({2})", document.GetElementById("lblCurrentPhase").InnerHtml, this.day_map[Conversions.ToInteger(obj7)], this.hour_map[Conversions.ToInteger(obj8)]), ToolTipIcon.Info);
                                                        if (this.CheckBox2.Checked)
                                                        {
                                                            try
                                                            {
                                                                object obj13 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("MSScriptControl.ScriptControl", ""));
                                                                NewLateBinding.LateSet(obj13, null, "AllowUI", new object[] { true }, null, null);
                                                                NewLateBinding.LateSet(obj13, null, "Language", new object[] { "JavaScript" }, null, null);
                                                                NewLateBinding.LateCall(obj13, null, "AddCode", new object[] { VBWebBrowserNew.My.Resources.Resources.fetion }, null, null, null, true);
                                                                NewLateBinding.LateCall(obj13, null, "AddCode", new object[] { VBWebBrowserNew.My.Resources.Resources.sms }, null, null, null, true);
                                                                string str9 = "sendSMS(" + this.TextBox6.Text + ",'" + this.TextBox7.Text + "','','" + string.Format("东方时尚自动约车软件约上({0}){1}({2})", document.GetElementById("lblCurrentPhase").InnerHtml, this.day_map[Conversions.ToInteger(obj7)], this.hour_map[Conversions.ToInteger(obj8)]) + "')";
                                                                object[] objArray7 = new object[] { str9 };
                                                                flagArray = new bool[] { true };
                                                                if (flagArray[0])
                                                                {
                                                                    str9 = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray7[0]), typeof(string));
                                                                }
                                                                this.Log(string.Format("发送短息({0}): {1}", this.TextBox6.Text, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj13, null, "Eval", objArray7, null, null, flagArray))));
                                                            }
                                                            catch (Exception exception3)
                                                            {
                                                                ProjectData.SetProjectError(exception3);
                                                                Exception exception2 = exception3;
                                                                this.Log(string.Format("发送短息({0}): {1}", this.TextBox6.Text, exception2.Message));
                                                                ProjectData.ClearProjectError();
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        object obj12 = RuntimeHelpers.GetObjectValue(document.InvokeScript("isAvaible", new object[] { RuntimeHelpers.GetObjectValue(obj7), RuntimeHelpers.GetObjectValue(obj8) }));
                                                        if (Operators.ConditionalCompareObjectEqual(obj5, false, false) && (document.GetElementById("lblMessage") != null))
                                                        {
                                                            string innerText = document.GetElementById("lblMessage").InnerText;
                                                            if ((!innerText.Equals("成功") & !innerText.Equals("本阶段已预约完毕!")) & !innerText.Equals("上阶段未结束!"))
                                                            {
                                                                this.Log(string.Format("线程({0})错误: 原因({1}), {2}({3})", new object[] { sender, innerText, this.hour_map[Conversions.ToInteger(obj8)], this.day_map[Conversions.ToInteger(obj7)] }));
                                                                obj12 = false;
                                                                obj5 = true;
                                                            }
                                                        }
                                                        if (Conversions.ToBoolean(obj12))
                                                        {
                                                            document.InvokeScript("clickCalc", new object[] { RuntimeHelpers.GetObjectValue(obj7), RuntimeHelpers.GetObjectValue(obj8) });
                                                            this.Log(string.Format("线程({0})预约: 阶段({1}), {2}({3})", new object[] { sender, document.GetElementById("lblCurrentPhase").InnerHtml, this.hour_map[Conversions.ToInteger(obj8)], this.day_map[Conversions.ToInteger(obj7)] }));
                                                            return;
                                                        }
                                                        this.car[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)] = 3;
                                                        this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].Text = "需要";
                                                        this.cell[Conversions.ToInteger(obj7), Conversions.ToInteger(obj8)].BackColor = Color.Aqua;
                                                    }
                                                }
                                                break;
                                        }
                                    }
                                    while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj8, obj22, ref obj8));
                                }
                            }
                            while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj7, obj19, ref obj7));
                        }
                        object[] objArray4 = new object[] { this.delay * 0x3e8 };
                        document.InvokeScript("freshlblCurrentPhaseDelay", objArray4);
                        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj6, true, false), this.running)))
                        {
                            this.WebBrowser_Run(true);
                        }
                    }
                }
            }
        }

        private void WebBrowser_Navigated(int sender, WebBrowserNavigatedEventArgs e)
        {
            string documentText = this.browsers[sender].browser.DocumentText;
            HtmlDocument document = this.browsers[sender].browser.Document;
            string documentTitle = this.browsers[sender].browser.DocumentTitle;
            this.browsers[sender].refresh = DateAndTime.Now.ToFileTimeUtc();
            if (documentText.Contains("window.close"))
            {
                documentText = Strings.Replace(documentText, "window.close();", "", 1, -1, CompareMethod.Binary);
                document.Write(documentText);
            }
            else if ((documentTitle == "网上约车管理") & this.loginPath.Equals(e.Url.AbsolutePath))
            {
                HtmlElement newElement = document.CreateElement("script");
                newElement.SetAttribute("type", "text/javascript");
                newElement.SetAttribute("language", "javascript");
                newElement.SetAttribute("text", VBWebBrowserNew.My.Resources.Resources.login_before);
                document.GetElementsByTagName("head")[0].AppendChild(newElement);
            }
        }

        private void WebBrowser_NewWindow(int sender, CancelEventArgs e)
        {
            e.Cancel = true;
            try
            {
                this.browsers[sender].browser.Navigate(new Uri(Conversions.ToString(this.targetURL)));
            }
            catch (UriFormatException exception1)
            {
                ProjectData.SetProjectError(exception1);
                UriFormatException exception = exception1;
                ProjectData.ClearProjectError();
                return;
            }
            this.Log(string.Format("线程({0})跳转: URL({1})", sender, RuntimeHelpers.GetObjectValue(this.targetURL)));
            this.browsers[sender].login = false;
        }

        private void WebBrowser_Run(bool flag)
        {
            if (!flag)
            {
                object obj2 = null;
                object obj7 = null;
                if (this.TextBox1.Text.Equals(""))
                {
                    Interaction.MsgBox("请您输入密码", MsgBoxStyle.ApplicationModal, null);
                    return;
                }
                bool flag2 = true;
                bool flag3 = false;
                object dayOfWeek = DateAndTime.Now.DayOfWeek;
                if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 0, 6, 1, ref obj7, ref obj2))
                {
                    do
                    {
                        object obj3 = null;
                        object obj10 = null;
                        if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj3, 0, 4, 1, ref obj10, ref obj3))
                        {
                            do
                            {
                                if (this.car[Conversions.ToInteger(obj2), Conversions.ToInteger(obj3)] > 0)
                                {
                                    if (Operators.ConditionalCompareObjectEqual(obj2, dayOfWeek, false))
                                    {
                                        flag3 = true;
                                    }
                                    flag2 = false;
                                }
                            }
                            while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj3, obj10, ref obj3));
                        }
                    }
                    while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, obj7, ref obj2));
                }
                if (flag2)
                {
                    Interaction.MsgBox("请您至少选择一节课程", MsgBoxStyle.ApplicationModal, null);
                    return;
                }
                if (flag3 && (Interaction.MsgBox("您选择一节今天上课的课程，是否继续？", MsgBoxStyle.OkCancel, string.Format("东方时尚自动约车 {0}", this.Label56.Text)) == MsgBoxResult.Cancel))
                {
                    return;
                }
            }
            if (this.running)
            {
                this.Log(string.Format("线程(All)停止: URL({0}))", "about:blank"));
                this.running = false;
                this.Button1.Text = "开始";
                this.browsers[0].browser.Navigate(new Uri("about:blank"));
                this.browsers[1].browser.Navigate(new Uri("about:blank"));
                this.browsers[2].browser.Navigate(new Uri("about:blank"));
                this.browsers[3].browser.Navigate(new Uri("about:blank"));
                this.browsers[0].login = false;
                this.browsers[1].login = false;
                this.browsers[2].login = false;
                this.browsers[3].login = false;
                this.browsers[0].relogin = false;
                this.browsers[1].relogin = false;
                this.browsers[2].relogin = false;
                this.browsers[3].relogin = false;
                this.browsers[0].relogout = 0;
                this.browsers[1].relogout = 0;
                this.browsers[2].relogout = 0;
                this.browsers[3].relogout = 0;
                this.Fresh_Grid();
            }
            else
            {
                this.running = true;
                this.Button1.Text = "结束";
                long num2 = DateAndTime.Now.ToFileTimeUtc();
                int num3 = this.thread - 1;
                for (int i = 0; i <= num3; i++)
                {
                    this.browsers[i].browser.Navigate(new Uri(Conversions.ToString(this.loginURL)));
                    this.Log(string.Format("线程({0})启动: URL({1}))", i, RuntimeHelpers.GetObjectValue(this.loginURL)));
                    this.browsers[i].login = false;
                    this.browsers[i].refresh = num2;
                    this.browsers[i].relogin = false;
                    this.browsers[i].relogout = 0;
                }
            }
        }

        private void WebBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.WebBrowser_DocumentCompleted(0, e);
        }

        private void WebBrowser2_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.WebBrowser_Navigated(0, e);
        }

        private void WebBrowser2_NewWindow(object sender, CancelEventArgs e)
        {
            this.WebBrowser_NewWindow(0, e);
        }

        private void WebBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.WebBrowser_DocumentCompleted(1, e);
        }

        private void WebBrowser3_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.WebBrowser_Navigated(1, e);
        }

        private void WebBrowser3_NewWindow(object sender, CancelEventArgs e)
        {
            this.WebBrowser_NewWindow(1, e);
        }

        private void WebBrowser4_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.WebBrowser_DocumentCompleted(2, e);
        }

        private void WebBrowser4_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.WebBrowser_Navigated(2, e);
        }

        private void WebBrowser4_NewWindow(object sender, CancelEventArgs e)
        {
            this.WebBrowser_NewWindow(2, e);
        }

        private void WebBrowser5_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.WebBrowser_DocumentCompleted(3, e);
        }

        private void WebBrowser5_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.WebBrowser_Navigated(3, e);
        }

        private void WebBrowser5_NewWindow(object sender, CancelEventArgs e)
        {
            this.WebBrowser_NewWindow(3, e);
        }

        internal virtual Button Button1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Button1 != null)
                {
                    this._Button1.Click -= new EventHandler(this.Button1_Click);
                }
                this._Button1 = value;
                if (this._Button1 != null)
                {
                    this._Button1.Click += new EventHandler(this.Button1_Click);
                }
            }
        }

        internal virtual Button Button2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Button2 != null)
                {
                    this._Button2.Click -= new EventHandler(this.Button2_Click);
                }
                this._Button2 = value;
                if (this._Button2 != null)
                {
                    this._Button2.Click += new EventHandler(this.Button2_Click);
                }
            }
        }

        internal virtual CheckBox CheckBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._CheckBox1 = value;
            }
        }

        internal virtual CheckBox CheckBox2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._CheckBox2 = value;
            }
        }

        internal virtual ComboBox ComboBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ComboBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._ComboBox1 != null)
                {
                    this._ComboBox1.SelectedIndexChanged -= new EventHandler(this.ComboBox3_SelectedIndexChanged);
                    this._ComboBox1.SelectedIndexChanged -= new EventHandler(this.ComboBox1_SelectedIndexChanged);
                }
                this._ComboBox1 = value;
                if (this._ComboBox1 != null)
                {
                    this._ComboBox1.SelectedIndexChanged += new EventHandler(this.ComboBox3_SelectedIndexChanged);
                    this._ComboBox1.SelectedIndexChanged += new EventHandler(this.ComboBox1_SelectedIndexChanged);
                }
            }
        }

        internal virtual ComboBox ComboBox2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ComboBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._ComboBox2 != null)
                {
                    this._ComboBox2.SelectedIndexChanged -= new EventHandler(this.ComboBox2_SelectedIndexChanged);
                }
                this._ComboBox2 = value;
                if (this._ComboBox2 != null)
                {
                    this._ComboBox2.SelectedIndexChanged += new EventHandler(this.ComboBox2_SelectedIndexChanged);
                }
            }
        }

        internal virtual ComboBox ComboBox3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ComboBox3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._ComboBox3 != null)
                {
                    this._ComboBox3.SelectedIndexChanged -= new EventHandler(this.ComboBox3_SelectedIndexChanged);
                }
                this._ComboBox3 = value;
                if (this._ComboBox3 != null)
                {
                    this._ComboBox3.SelectedIndexChanged += new EventHandler(this.ComboBox3_SelectedIndexChanged);
                }
            }
        }

        internal virtual GroupBox GroupBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._GroupBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._GroupBox1 = value;
            }
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label1 = value;
            }
        }

        internal virtual Label Label10
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label10;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label10 != null)
                {
                    this._Label10.Click -= new EventHandler(this.Label_Click);
                }
                this._Label10 = value;
                if (this._Label10 != null)
                {
                    this._Label10.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label11
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label11;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label11 != null)
                {
                    this._Label11.Click -= new EventHandler(this.Label_Click);
                }
                this._Label11 = value;
                if (this._Label11 != null)
                {
                    this._Label11.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label12
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label12;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label12 != null)
                {
                    this._Label12.Click -= new EventHandler(this.Label_Click);
                }
                this._Label12 = value;
                if (this._Label12 != null)
                {
                    this._Label12.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label13
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label13;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label13 != null)
                {
                    this._Label13.Click -= new EventHandler(this.Label_Click);
                }
                this._Label13 = value;
                if (this._Label13 != null)
                {
                    this._Label13.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label14
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label14;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label14 != null)
                {
                    this._Label14.Click -= new EventHandler(this.Label_Click);
                }
                this._Label14 = value;
                if (this._Label14 != null)
                {
                    this._Label14.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label15
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label15;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label15 != null)
                {
                    this._Label15.Click -= new EventHandler(this.Label_Click);
                }
                this._Label15 = value;
                if (this._Label15 != null)
                {
                    this._Label15.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label16
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label16;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label16 != null)
                {
                    this._Label16.Click -= new EventHandler(this.Label_Click);
                }
                this._Label16 = value;
                if (this._Label16 != null)
                {
                    this._Label16.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label17
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label17;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label17 != null)
                {
                    this._Label17.Click -= new EventHandler(this.Label_Click);
                }
                this._Label17 = value;
                if (this._Label17 != null)
                {
                    this._Label17.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label18
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label18;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label18 != null)
                {
                    this._Label18.Click -= new EventHandler(this.Label_Click);
                }
                this._Label18 = value;
                if (this._Label18 != null)
                {
                    this._Label18.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label19
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label19;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label19 != null)
                {
                    this._Label19.Click -= new EventHandler(this.Label_Click);
                }
                this._Label19 = value;
                if (this._Label19 != null)
                {
                    this._Label19.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label2 = value;
            }
        }

        internal virtual Label Label20
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label20;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label20 != null)
                {
                    this._Label20.Click -= new EventHandler(this.Label_Click);
                }
                this._Label20 = value;
                if (this._Label20 != null)
                {
                    this._Label20.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label21
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label21;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label21 != null)
                {
                    this._Label21.Click -= new EventHandler(this.Label_Click);
                }
                this._Label21 = value;
                if (this._Label21 != null)
                {
                    this._Label21.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label22
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label22;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label22 != null)
                {
                    this._Label22.Click -= new EventHandler(this.Label_Click);
                }
                this._Label22 = value;
                if (this._Label22 != null)
                {
                    this._Label22.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label23
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label23;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label23 != null)
                {
                    this._Label23.Click -= new EventHandler(this.Label_Click);
                }
                this._Label23 = value;
                if (this._Label23 != null)
                {
                    this._Label23.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label24
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label24;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label24 != null)
                {
                    this._Label24.Click -= new EventHandler(this.Label_Click);
                }
                this._Label24 = value;
                if (this._Label24 != null)
                {
                    this._Label24.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label25
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label25;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label25 != null)
                {
                    this._Label25.Click -= new EventHandler(this.Label_Click);
                }
                this._Label25 = value;
                if (this._Label25 != null)
                {
                    this._Label25.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label26
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label26;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label26 != null)
                {
                    this._Label26.Click -= new EventHandler(this.Label_Click);
                }
                this._Label26 = value;
                if (this._Label26 != null)
                {
                    this._Label26.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label27
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label27;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label27 != null)
                {
                    this._Label27.Click -= new EventHandler(this.Label_Click);
                }
                this._Label27 = value;
                if (this._Label27 != null)
                {
                    this._Label27.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label28
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label28;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label28 != null)
                {
                    this._Label28.Click -= new EventHandler(this.Label_Click);
                }
                this._Label28 = value;
                if (this._Label28 != null)
                {
                    this._Label28.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label29
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label29;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label29 != null)
                {
                    this._Label29.Click -= new EventHandler(this.Label_Click);
                }
                this._Label29 = value;
                if (this._Label29 != null)
                {
                    this._Label29.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label3 = value;
            }
        }

        internal virtual Label Label30
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label30;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label30 != null)
                {
                    this._Label30.Click -= new EventHandler(this.Label_Click);
                }
                this._Label30 = value;
                if (this._Label30 != null)
                {
                    this._Label30.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label31
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label31;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label31 != null)
                {
                    this._Label31.Click -= new EventHandler(this.Label_Click);
                }
                this._Label31 = value;
                if (this._Label31 != null)
                {
                    this._Label31.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label32
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label32;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label32 != null)
                {
                    this._Label32.Click -= new EventHandler(this.Label_Click);
                }
                this._Label32 = value;
                if (this._Label32 != null)
                {
                    this._Label32.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label33
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label33;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label33 != null)
                {
                    this._Label33.Click -= new EventHandler(this.Label_Click);
                }
                this._Label33 = value;
                if (this._Label33 != null)
                {
                    this._Label33.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label34
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label34;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label34 != null)
                {
                    this._Label34.Click -= new EventHandler(this.Label_Click);
                }
                this._Label34 = value;
                if (this._Label34 != null)
                {
                    this._Label34.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label35
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label35;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label35 != null)
                {
                    this._Label35.Click -= new EventHandler(this.Label_Click);
                }
                this._Label35 = value;
                if (this._Label35 != null)
                {
                    this._Label35.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label36
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label36;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label36 != null)
                {
                    this._Label36.Click -= new EventHandler(this.Label_Click);
                }
                this._Label36 = value;
                if (this._Label36 != null)
                {
                    this._Label36.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label37
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label37;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label37 != null)
                {
                    this._Label37.Click -= new EventHandler(this.Label_Click);
                }
                this._Label37 = value;
                if (this._Label37 != null)
                {
                    this._Label37.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label38
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label38;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label38 != null)
                {
                    this._Label38.Click -= new EventHandler(this.Label_Click);
                }
                this._Label38 = value;
                if (this._Label38 != null)
                {
                    this._Label38.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label39
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label39;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label39 != null)
                {
                    this._Label39.Click -= new EventHandler(this.Label_Click);
                }
                this._Label39 = value;
                if (this._Label39 != null)
                {
                    this._Label39.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label4 = value;
            }
        }

        internal virtual Label Label40
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label40;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label40 != null)
                {
                    this._Label40.Click -= new EventHandler(this.Label_Click);
                }
                this._Label40 = value;
                if (this._Label40 != null)
                {
                    this._Label40.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label41
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label41;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label41 != null)
                {
                    this._Label41.Click -= new EventHandler(this.Label_Click);
                }
                this._Label41 = value;
                if (this._Label41 != null)
                {
                    this._Label41.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label42
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label42;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label42 != null)
                {
                    this._Label42.Click -= new EventHandler(this.Label_Click);
                }
                this._Label42 = value;
                if (this._Label42 != null)
                {
                    this._Label42.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label43
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label43;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label43 != null)
                {
                    this._Label43.Click -= new EventHandler(this.Label_Click);
                }
                this._Label43 = value;
                if (this._Label43 != null)
                {
                    this._Label43.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label44
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label44;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Label44 != null)
                {
                    this._Label44.Click -= new EventHandler(this.Label_Click);
                }
                this._Label44 = value;
                if (this._Label44 != null)
                {
                    this._Label44.Click += new EventHandler(this.Label_Click);
                }
            }
        }

        internal virtual Label Label45
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label45;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label45 = value;
            }
        }

        internal virtual Label Label46
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label46;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label46 = value;
            }
        }

        internal virtual Label Label47
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label47;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label47 = value;
            }
        }

        internal virtual Label Label48
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label48;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label48 = value;
            }
        }

        internal virtual Label Label49
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label49;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label49 = value;
            }
        }

        internal virtual Label Label5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label5 = value;
            }
        }

        internal virtual Label Label50
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label50;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label50 = value;
            }
        }

        internal virtual Label Label51
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label51;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label51 = value;
            }
        }

        internal virtual Label Label52
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label52;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label52 = value;
            }
        }

        internal virtual Label Label53
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label53;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label53 = value;
            }
        }

        internal virtual Label Label54
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label54;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label54 = value;
            }
        }

        internal virtual Label Label55
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label55;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label55 = value;
            }
        }

        internal virtual Label Label56
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label56;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label56 = value;
            }
        }

        internal virtual Label Label57
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label57;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label57 = value;
            }
        }

        internal virtual Label Label58
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label58;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label58 = value;
            }
        }

        internal virtual Label Label59
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label59;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label59 = value;
            }
        }

        internal virtual Label Label6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label6;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label6 = value;
            }
        }

        internal virtual Label Label7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label7;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label7 = value;
            }
        }

        internal virtual Label Label8
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label8;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label8 = value;
            }
        }

        internal virtual Label Label9
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label9;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label9 = value;
            }
        }

        internal virtual LinkLabel LinkLabel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LinkLabel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._LinkLabel1 != null)
                {
                    this._LinkLabel1.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
                }
                this._LinkLabel1 = value;
                if (this._LinkLabel1 != null)
                {
                    this._LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
                }
            }
        }

        internal virtual NotifyIcon NotifyIcon1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._NotifyIcon1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._NotifyIcon1 != null)
                {
                    this._NotifyIcon1.MouseDoubleClick -= new MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
                }
                this._NotifyIcon1 = value;
                if (this._NotifyIcon1 != null)
                {
                    this._NotifyIcon1.MouseDoubleClick += new MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
                }
            }
        }

        internal virtual TabControl TabControl1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabControl1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TabControl1 = value;
            }
        }

        internal virtual TableLayoutPanel TableLayoutPanel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TableLayoutPanel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TableLayoutPanel1 = value;
            }
        }

        internal virtual TabPage TabPage1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TabPage1 = value;
            }
        }

        internal virtual TabPage TabPage2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TabPage2 = value;
            }
        }

        internal virtual TabPage TabPage3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TabPage3 = value;
            }
        }

        internal virtual TabPage TabPage4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TabPage4 = value;
            }
        }

        internal virtual TabPage TabPage5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TabPage5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TabPage5 = value;
            }
        }

        internal virtual TextBox TextBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox1 = value;
            }
        }

        internal virtual TextBox TextBox2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox2 = value;
            }
        }

        internal virtual TextBox TextBox3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox3 = value;
            }
        }

        internal virtual TextBox TextBox4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox4 = value;
            }
        }

        internal virtual TextBox TextBox5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox5 = value;
            }
        }

        internal virtual TextBox TextBox6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox6;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox6 = value;
            }
        }

        internal virtual TextBox TextBox7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox7;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox7 = value;
            }
        }

        internal virtual System.Windows.Forms.Timer Timer1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Timer1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._Timer1 != null)
                {
                    this._Timer1.Tick -= new EventHandler(this.Timer1_Tick);
                }
                this._Timer1 = value;
                if (this._Timer1 != null)
                {
                    this._Timer1.Tick += new EventHandler(this.Timer1_Tick);
                }
            }
        }

        internal virtual WebBrowser WebBrowser1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._WebBrowser1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._WebBrowser1 = value;
            }
        }

        internal virtual WebBrowser WebBrowser2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._WebBrowser2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._WebBrowser2 != null)
                {
                    this._WebBrowser2.NewWindow -= new CancelEventHandler(this.WebBrowser2_NewWindow);
                    this._WebBrowser2.Navigated -= new WebBrowserNavigatedEventHandler(this.WebBrowser2_Navigated);
                    this._WebBrowser2.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(this.WebBrowser2_DocumentCompleted);
                }
                this._WebBrowser2 = value;
                if (this._WebBrowser2 != null)
                {
                    this._WebBrowser2.NewWindow += new CancelEventHandler(this.WebBrowser2_NewWindow);
                    this._WebBrowser2.Navigated += new WebBrowserNavigatedEventHandler(this.WebBrowser2_Navigated);
                    this._WebBrowser2.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser2_DocumentCompleted);
                }
            }
        }

        internal virtual WebBrowser WebBrowser3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._WebBrowser3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._WebBrowser3 != null)
                {
                    this._WebBrowser3.NewWindow -= new CancelEventHandler(this.WebBrowser3_NewWindow);
                    this._WebBrowser3.Navigated -= new WebBrowserNavigatedEventHandler(this.WebBrowser3_Navigated);
                    this._WebBrowser3.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(this.WebBrowser3_DocumentCompleted);
                }
                this._WebBrowser3 = value;
                if (this._WebBrowser3 != null)
                {
                    this._WebBrowser3.NewWindow += new CancelEventHandler(this.WebBrowser3_NewWindow);
                    this._WebBrowser3.Navigated += new WebBrowserNavigatedEventHandler(this.WebBrowser3_Navigated);
                    this._WebBrowser3.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser3_DocumentCompleted);
                }
            }
        }

        internal virtual WebBrowser WebBrowser4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._WebBrowser4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._WebBrowser4 != null)
                {
                    this._WebBrowser4.NewWindow -= new CancelEventHandler(this.WebBrowser4_NewWindow);
                    this._WebBrowser4.Navigated -= new WebBrowserNavigatedEventHandler(this.WebBrowser4_Navigated);
                    this._WebBrowser4.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(this.WebBrowser4_DocumentCompleted);
                }
                this._WebBrowser4 = value;
                if (this._WebBrowser4 != null)
                {
                    this._WebBrowser4.NewWindow += new CancelEventHandler(this.WebBrowser4_NewWindow);
                    this._WebBrowser4.Navigated += new WebBrowserNavigatedEventHandler(this.WebBrowser4_Navigated);
                    this._WebBrowser4.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser4_DocumentCompleted);
                }
            }
        }

        internal virtual WebBrowser WebBrowser5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._WebBrowser5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (this._WebBrowser5 != null)
                {
                    this._WebBrowser5.NewWindow -= new CancelEventHandler(this.WebBrowser5_NewWindow);
                    this._WebBrowser5.Navigated -= new WebBrowserNavigatedEventHandler(this.WebBrowser5_Navigated);
                    this._WebBrowser5.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(this.WebBrowser5_DocumentCompleted);
                }
                this._WebBrowser5 = value;
                if (this._WebBrowser5 != null)
                {
                    this._WebBrowser5.NewWindow += new CancelEventHandler(this.WebBrowser5_NewWindow);
                    this._WebBrowser5.Navigated += new WebBrowserNavigatedEventHandler(this.WebBrowser5_Navigated);
                    this._WebBrowser5.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser5_DocumentCompleted);
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct DFSSBrowser
        {
            public WebBrowser browser;
            public bool login;
            public long refresh;
            public int relogout;
            public bool relogin;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct DisposeBrowser
        {
            public WebBrowser browser;
            public long time;
        }

        public enum INTERNETFEATURELIST
        {
            FEATURE_OBJECT_CACHING,
            FEATURE_ZONE_ELEVATION,
            FEATURE_MIME_HANDLING,
            FEATURE_MIME_SNIFFING,
            FEATURE_WINDOW_RESTRICTIONS,
            FEATURE_WEBOC_POPUPMANAGEMENT,
            FEATURE_BEHAVIORS,
            FEATURE_DISABLE_MK_PROTOCOL,
            FEATURE_LOCALMACHINE_LOCKDOWN,
            FEATURE_SECURITYBAND,
            FEATURE_RESTRICT_ACTIVEXINSTALL,
            FEATURE_VALIDATE_NAVIGATE_URL,
            FEATURE_RESTRICT_FILEDOWNLOAD,
            FEATURE_ADDON_MANAGEMENT,
            FEATURE_PROTOCOL_LOCKDOWN,
            FEATURE_HTTP_USERNAME_PASSWORD_DISABLE,
            FEATURE_SAFE_BINDTOOBJECT,
            FEATURE_UNC_SAVEDFILECHECK,
            FEATURE_GET_URL_DOM_FILEPATH_UNENCODED,
            FEATURE_TABBED_BROWSING,
            FEATURE_SSLUX,
            FEATURE_DISABLE_NAVIGATION_SOUNDS,
            FEATURE_DISABLE_LEGACY_COMPRESSION,
            FEATURE_FORCE_ADDR_AND_STATUS,
            FEATURE_XMLHTTP,
            FEATURE_DISABLE_TELNET_PROTOCOL,
            FEATURE_FEEDS,
            FEATURE_BLOCK_INPUT_PROMPTS,
            FEATURE_ENTRY_COUNT
        }
    }
}


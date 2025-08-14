// Decompiled with JetBrains decompiler
// Type: TRCC.UCAbout
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC;

public class UCAbout : UserControl
{
  private const byte USB_PACKED_Head = 220;
  public UCAbout.delegateUCAbout ucAbout;
  private const string fileSetting = "Data\\Setting";
  private const string BanBenHaoVal = "2.0.4.txt";
  public int yuyan = 1;
  private bool toUpdate = false;
  private string banbenhao = "";
  private string updataFile = "";
  private bool isKaiJiQiDong = true;
  private int myTempMode = 1;
  public bool isReadHDD = true;
  private bool isInit = false;
  private IContainer components = (IContainer) null;
  public Label label1;
  public Label labelInfo;
  private Button gfwzButton;
  private Button buttonBCZT;
  private Button buttonPower;
  private Button button1;
  private Button buttonF;
  private Button buttonC;
  private Button buttonYP;
  public TextBox textBoxTimer;
  private Button buttonEnglish;
  private Button buttonDeutsch;
  private Button buttonPoccnr;
  private Button buttonFrancais;
  private Button buttonPortugues;
  private Button buttonRiBen;
  private Button buttonEspanol;
  private Button buttonCN;
  private Button buttonTW;

  public UCAbout()
  {
    this.InitializeComponent();
    this.buttonPower.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.gfwzButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonBCZT.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    FileStream input = new FileStream(Application.StartupPath + "\\Data\\Setting", FileMode.OpenOrCreate);
    BinaryReader binaryReader = new BinaryReader((Stream) input);
    try
    {
      if (binaryReader.ReadByte() == (byte) 220)
      {
        this.buttonCF_Click(binaryReader.ReadInt32(), false);
        this.isReadHDD = binaryReader.ReadBoolean();
        this.SetButtonYP_Click(this.isReadHDD);
        this.textBoxTimer.Text = binaryReader.ReadString();
        this.yuyan = binaryReader.ReadInt32();
      }
    }
    catch
    {
    }
    binaryReader.Close();
    binaryReader.Dispose();
    input.Close();
    input.Dispose();
    this.isInit = true;
    Form1.Language = this.yuyan;
  }

  public void UCAboutInit()
  {
    this.buttonCF_Click(this.myTempMode);
    this.ButtonLanguageSet(this.yuyan);
  }

  private void buttonBCZT_Click(object sender, EventArgs e) => this.UpdateMyApp();

  private void gfwzButton_Click(object sender, EventArgs e)
  {
    Process.Start("https://www.thermalright.com");
  }

  private void gfwzButton_MouseEnter(object sender, EventArgs e)
  {
    this.gfwzButton.ForeColor = Color.FromArgb(180, 150, 83);
  }

  private void gfwzButton_MouseLeave(object sender, EventArgs e)
  {
    this.gfwzButton.ForeColor = Color.WhiteSmoke;
  }

  public static string[] GetFileList()
  {
    StringBuilder stringBuilder = new StringBuilder();
    try
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(new Uri("ftp://47.110.136.13/update/limin/"));
      ftpWebRequest.Credentials = (ICredentials) new NetworkCredential("wh-ihjsqvkumq629vnad", "Ccy19840228");
      ftpWebRequest.Method = "NLST";
      ftpWebRequest.UseBinary = true;
      WebResponse response = ftpWebRequest.GetResponse();
      StreamReader streamReader = new StreamReader(response.GetResponseStream());
      for (string str = streamReader.ReadLine(); str != null; str = streamReader.ReadLine())
      {
        stringBuilder.Append(str);
        stringBuilder.Append("\n");
      }
      stringBuilder.Remove(stringBuilder.ToString().LastIndexOf('\n'), 1);
      streamReader.Close();
      response.Close();
      return stringBuilder.ToString().Split('\n');
    }
    catch
    {
      return (string[]) null;
    }
  }

  public void UpdateMyInfo()
  {
  }

  private void UpdateMyApp()
  {
    if (!this.toUpdate)
      return;
    try
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(new Uri("ftp://47.110.136.13/update/limin/" + this.updataFile));
      ftpWebRequest.Credentials = (ICredentials) new NetworkCredential("wh-ihjsqvkumq629vnad", "Ccy19840228");
      ftpWebRequest.Method = "RETR";
      ftpWebRequest.UseBinary = true;
      this.updataFile = "Up" + this.updataFile.Replace(this.banbenhao, "");
      FileStream fileStream = new FileStream($"{Application.StartupPath}\\{this.updataFile}", FileMode.Create);
      FtpWebResponse response = (FtpWebResponse) ftpWebRequest.GetResponse();
      Stream responseStream = response.GetResponseStream();
      byte[] buffer = new byte[1048576 /*0x100000*/];
      this.labelInfo.Text = "下载中";
      Application.DoEvents();
      int count = responseStream.Read(buffer, 0, buffer.Length);
      while (count > 0)
      {
        fileStream.Write(buffer, 0, count);
        count = responseStream.Read(buffer, 0, buffer.Length);
        this.labelInfo.Text += "。";
        Application.DoEvents();
      }
      this.labelInfo.Text = "下载完成";
      responseStream.Close();
      fileStream.Close();
      response.Close();
      responseStream.Dispose();
      fileStream.Dispose();
      response.Dispose();
      ProcessStartInfo startInfo = new ProcessStartInfo();
      startInfo.FileName = this.updataFile;
      startInfo.WorkingDirectory = Application.StartupPath;
      startInfo.WindowStyle = ProcessWindowStyle.Normal;
      try
      {
        Process.Start(startInfo);
        UCAbout.delegateUCAbout ucAbout = this.ucAbout;
        if (ucAbout == null)
          return;
        ucAbout(100);
      }
      catch
      {
        int num = (int) MessageBox.Show("error");
      }
    }
    catch
    {
      int num = (int) MessageBox.Show("当前为最新版本！");
    }
  }

  private void buttonPower_Click(object sender, EventArgs e)
  {
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout((int) byte.MaxValue);
  }

  private void buttonPower_MouseEnter(object sender, EventArgs e)
  {
    this.buttonPower.BackgroundImage = (Image) Resources.Alogout选中;
  }

  private void buttonPower_MouseLeave(object sender, EventArgs e)
  {
    this.buttonPower.BackgroundImage = (Image) Resources.Alogout默认;
  }

  private void UCAbout_MouseDown(object sender, MouseEventArgs e)
  {
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(241, data: (object) e);
  }

  private void UCAbout_MouseMove(object sender, MouseEventArgs e)
  {
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(242, data: (object) e);
  }

  private void UCAbout_MouseUp(object sender, MouseEventArgs e)
  {
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(243, data: (object) e);
  }

  public void Button1_Set(bool bl)
  {
    this.isKaiJiQiDong = bl;
    if (bl)
      this.button1.BackgroundImage = (Image) Resources.P点选框A;
    else
      this.button1.BackgroundImage = (Image) Resources.P点选框;
  }

  private void button1_Click(object sender, EventArgs e)
  {
    this.isKaiJiQiDong = !this.isKaiJiQiDong;
    this.Button1_Set(this.isKaiJiQiDong);
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(0, (object) this.isKaiJiQiDong);
  }

  public void buttonCF_Click(int mode, bool bl = true)
  {
    this.myTempMode = mode;
    if (bl)
      Form1.formSystemInfo.ucSystemInfo1.myWendu = mode;
    this.buttonC.BackgroundImage = (Image) Resources.P点选框;
    this.buttonF.BackgroundImage = (Image) Resources.P点选框;
    switch (mode)
    {
      case 1:
        this.buttonC.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 2:
        this.buttonF.BackgroundImage = (Image) Resources.P点选框A;
        break;
    }
  }

  private void SetMyNameFile()
  {
    FileStream output = new FileStream(Application.StartupPath + "\\Data\\Setting", FileMode.OpenOrCreate);
    BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
    binaryWriter.Write((byte) 220);
    binaryWriter.Write(this.myTempMode);
    binaryWriter.Write(this.isReadHDD);
    binaryWriter.Write(this.textBoxTimer.Text);
    binaryWriter.Write(this.yuyan);
    binaryWriter.Flush();
    binaryWriter.Close();
    binaryWriter.Dispose();
    output.Close();
    output.Dispose();
  }

  private void buttonC_Click(object sender, EventArgs e)
  {
    this.myTempMode = 1;
    this.buttonCF_Click(this.myTempMode);
    this.SetMyNameFile();
  }

  private void buttonF_Click(object sender, EventArgs e)
  {
    this.myTempMode = 2;
    this.buttonCF_Click(this.myTempMode);
    this.SetMyNameFile();
  }

  public void SetButtonYP_Click(bool bl)
  {
    this.isReadHDD = bl;
    if (bl)
      this.buttonYP.BackgroundImage = (Image) Resources.P点选框A;
    else
      this.buttonYP.BackgroundImage = (Image) Resources.P点选框;
  }

  private void buttonYP_Click(object sender, EventArgs e)
  {
    this.isReadHDD = !this.isReadHDD;
    this.SetButtonYP_Click(this.isReadHDD);
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout != null)
      ucAbout(16 /*0x10*/, (object) this.isReadHDD, (object) Convert.ToInt32(this.textBoxTimer.Text));
    this.SetMyNameFile();
  }

  private void textBoxTimer_TextChanged(object sender, EventArgs e)
  {
    if (!this.isInit || this.textBoxTimer.Text.Length <= 0)
      return;
    if (Convert.ToInt32(this.textBoxTimer.Text) > 100)
      this.textBoxTimer.Text = "100";
    else if (Convert.ToInt32(this.textBoxTimer.Text) <= 0)
    {
      this.textBoxTimer.Text = "1";
    }
    else
    {
      UCAbout.delegateUCAbout ucAbout = this.ucAbout;
      if (ucAbout != null)
        ucAbout(16 /*0x10*/, (object) this.isReadHDD, (object) Convert.ToInt32(this.textBoxTimer.Text));
      this.SetMyNameFile();
    }
  }

  private void textBoxTimer_KeyPress(object sender, KeyPressEventArgs e)
  {
    if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
      return;
    e.Handled = true;
  }

  public void ButtonLanguageSet(int language)
  {
    this.yuyan = language;
    this.buttonEnglish.BackgroundImage = (Image) Resources.P点选框;
    this.buttonCN.BackgroundImage = (Image) Resources.P点选框;
    this.buttonTW.BackgroundImage = (Image) Resources.P点选框;
    this.buttonDeutsch.BackgroundImage = (Image) Resources.P点选框;
    this.buttonPoccnr.BackgroundImage = (Image) Resources.P点选框;
    this.buttonFrancais.BackgroundImage = (Image) Resources.P点选框;
    this.buttonPortugues.BackgroundImage = (Image) Resources.P点选框;
    this.buttonRiBen.BackgroundImage = (Image) Resources.P点选框;
    this.buttonEspanol.BackgroundImage = (Image) Resources.P点选框;
    switch (language)
    {
      case 0:
        this.BackgroundImage = (Image) Resources.A0关于en;
        this.buttonEnglish.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 1:
        this.BackgroundImage = (Image) Resources.A0关于;
        this.buttonCN.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 2:
        this.BackgroundImage = (Image) Resources.A0关于tc;
        this.buttonTW.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 3:
        this.BackgroundImage = (Image) Resources.A0关于d;
        this.buttonDeutsch.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 4:
        this.BackgroundImage = (Image) Resources.A0关于e;
        this.buttonPoccnr.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 5:
        this.BackgroundImage = (Image) Resources.A0关于f;
        this.buttonFrancais.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 6:
        this.BackgroundImage = (Image) Resources.A0关于p;
        this.buttonPortugues.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 7:
        this.BackgroundImage = (Image) Resources.A0关于r;
        this.buttonRiBen.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 8:
        this.BackgroundImage = (Image) Resources.A0关于x;
        this.buttonEspanol.BackgroundImage = (Image) Resources.P点选框A;
        break;
    }
  }

  private void buttonEnglish_Click(object sender, EventArgs e)
  {
    this.yuyan = 0;
    this.ButtonLanguageSet(this.yuyan);
    this.SetMyNameFile();
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(32 /*0x20*/, (object) this.yuyan);
  }

  private void buttonCN_Click(object sender, EventArgs e)
  {
    this.yuyan = 1;
    this.ButtonLanguageSet(this.yuyan);
    this.SetMyNameFile();
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(32 /*0x20*/, (object) this.yuyan);
  }

  private void buttonTW_Click(object sender, EventArgs e)
  {
    this.yuyan = 2;
    this.ButtonLanguageSet(this.yuyan);
    this.SetMyNameFile();
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(32 /*0x20*/, (object) this.yuyan);
  }

  private void buttonDeutsch_Click(object sender, EventArgs e)
  {
    this.yuyan = 3;
    this.ButtonLanguageSet(this.yuyan);
    this.SetMyNameFile();
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(32 /*0x20*/, (object) this.yuyan);
  }

  private void buttonPoccnr_Click(object sender, EventArgs e)
  {
    this.yuyan = 4;
    this.ButtonLanguageSet(this.yuyan);
    this.SetMyNameFile();
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(32 /*0x20*/, (object) this.yuyan);
  }

  private void buttonFrancais_Click(object sender, EventArgs e)
  {
    this.yuyan = 5;
    this.ButtonLanguageSet(this.yuyan);
    this.SetMyNameFile();
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(32 /*0x20*/, (object) this.yuyan);
  }

  private void buttonPortugues_Click(object sender, EventArgs e)
  {
    this.yuyan = 6;
    this.ButtonLanguageSet(this.yuyan);
    this.SetMyNameFile();
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(32 /*0x20*/, (object) this.yuyan);
  }

  private void buttonRiBen_Click(object sender, EventArgs e)
  {
    this.yuyan = 7;
    this.ButtonLanguageSet(this.yuyan);
    this.SetMyNameFile();
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(32 /*0x20*/, (object) this.yuyan);
  }

  private void buttonEspanol_Click(object sender, EventArgs e)
  {
    this.yuyan = 8;
    this.ButtonLanguageSet(this.yuyan);
    this.SetMyNameFile();
    UCAbout.delegateUCAbout ucAbout = this.ucAbout;
    if (ucAbout == null)
      return;
    ucAbout(32 /*0x20*/, (object) this.yuyan);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.label1 = new Label();
    this.labelInfo = new Label();
    this.gfwzButton = new Button();
    this.buttonBCZT = new Button();
    this.buttonPower = new Button();
    this.button1 = new Button();
    this.buttonF = new Button();
    this.buttonC = new Button();
    this.buttonYP = new Button();
    this.textBoxTimer = new TextBox();
    this.buttonEnglish = new Button();
    this.buttonDeutsch = new Button();
    this.buttonPoccnr = new Button();
    this.buttonFrancais = new Button();
    this.buttonPortugues = new Button();
    this.buttonRiBen = new Button();
    this.buttonEspanol = new Button();
    this.buttonCN = new Button();
    this.buttonTW = new Button();
    this.SuspendLayout();
    this.label1.BackColor = Color.Transparent;
    this.label1.FlatStyle = FlatStyle.Flat;
    this.label1.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label1.ForeColor = Color.White;
    this.label1.Location = new Point(1175, 735);
    this.label1.Margin = new Padding(0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(87, 27);
    this.label1.TabIndex = 659;
    this.label1.Text = "2.0.4";
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.labelInfo.BackColor = Color.Transparent;
    this.labelInfo.FlatStyle = FlatStyle.Flat;
    this.labelInfo.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelInfo.ForeColor = Color.White;
    this.labelInfo.Location = new Point(594, 159);
    this.labelInfo.Margin = new Padding(0);
    this.labelInfo.Name = "labelInfo";
    this.labelInfo.Size = new Size(595, 298);
    this.labelInfo.TabIndex = 661;
    this.labelInfo.Text = "检测中。。。";
    this.labelInfo.Visible = false;
    this.gfwzButton.BackColor = Color.Transparent;
    this.gfwzButton.BackgroundImageLayout = ImageLayout.Zoom;
    this.gfwzButton.FlatAppearance.BorderSize = 0;
    this.gfwzButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.gfwzButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.gfwzButton.FlatStyle = FlatStyle.Flat;
    this.gfwzButton.Font = new Font("微软雅黑", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.gfwzButton.ForeColor = Color.WhiteSmoke;
    this.gfwzButton.Location = new Point(94, 726);
    this.gfwzButton.Margin = new Padding(0);
    this.gfwzButton.Name = "gfwzButton";
    this.gfwzButton.Size = new Size(353, 43);
    this.gfwzButton.TabIndex = 662;
    this.gfwzButton.Text = "www.thermalright.com";
    this.gfwzButton.TextAlign = ContentAlignment.MiddleLeft;
    this.gfwzButton.UseVisualStyleBackColor = false;
    this.gfwzButton.Click += new EventHandler(this.gfwzButton_Click);
    this.gfwzButton.MouseEnter += new EventHandler(this.gfwzButton_MouseEnter);
    this.gfwzButton.MouseLeave += new EventHandler(this.gfwzButton_MouseLeave);
    this.buttonBCZT.BackColor = Color.Transparent;
    this.buttonBCZT.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonBCZT.FlatAppearance.BorderSize = 0;
    this.buttonBCZT.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonBCZT.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonBCZT.FlatStyle = FlatStyle.Flat;
    this.buttonBCZT.Location = new Point(1110, 475);
    this.buttonBCZT.Margin = new Padding(0);
    this.buttonBCZT.Name = "buttonBCZT";
    this.buttonBCZT.Size = new Size(80 /*0x50*/, 26);
    this.buttonBCZT.TabIndex = 663;
    this.buttonBCZT.UseVisualStyleBackColor = false;
    this.buttonBCZT.Visible = false;
    this.buttonBCZT.Click += new EventHandler(this.buttonBCZT_Click);
    this.buttonPower.BackColor = Color.Transparent;
    this.buttonPower.BackgroundImage = (Image) Resources.Alogout默认;
    this.buttonPower.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonPower.FlatAppearance.BorderSize = 0;
    this.buttonPower.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonPower.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonPower.FlatStyle = FlatStyle.Flat;
    this.buttonPower.Location = new Point(1212, 24);
    this.buttonPower.Margin = new Padding(0);
    this.buttonPower.Name = "buttonPower";
    this.buttonPower.Size = new Size(40, 40);
    this.buttonPower.TabIndex = 664;
    this.buttonPower.UseVisualStyleBackColor = false;
    this.buttonPower.Click += new EventHandler(this.buttonPower_Click);
    this.buttonPower.MouseEnter += new EventHandler(this.buttonPower_MouseEnter);
    this.buttonPower.MouseLeave += new EventHandler(this.buttonPower_MouseLeave);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P点选框A;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(297, 174);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(14, 14);
    this.button1.TabIndex = 666;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.buttonF.BackColor = Color.Transparent;
    this.buttonF.BackgroundImage = (Image) Resources.P点选框;
    this.buttonF.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonF.FlatAppearance.BorderSize = 0;
    this.buttonF.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonF.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonF.FlatStyle = FlatStyle.Flat;
    this.buttonF.Location = new Point(387, 214);
    this.buttonF.Margin = new Padding(0);
    this.buttonF.Name = "buttonF";
    this.buttonF.Size = new Size(14, 14);
    this.buttonF.TabIndex = 670;
    this.buttonF.UseVisualStyleBackColor = false;
    this.buttonF.Click += new EventHandler(this.buttonF_Click);
    this.buttonC.BackColor = Color.Transparent;
    this.buttonC.BackgroundImage = (Image) Resources.P点选框A;
    this.buttonC.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC.FlatAppearance.BorderSize = 0;
    this.buttonC.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC.FlatStyle = FlatStyle.Flat;
    this.buttonC.Location = new Point(297, 214);
    this.buttonC.Margin = new Padding(0);
    this.buttonC.Name = "buttonC";
    this.buttonC.Size = new Size(14, 14);
    this.buttonC.TabIndex = 669;
    this.buttonC.UseVisualStyleBackColor = false;
    this.buttonC.Click += new EventHandler(this.buttonC_Click);
    this.buttonYP.BackColor = Color.Transparent;
    this.buttonYP.BackgroundImage = (Image) Resources.P点选框A;
    this.buttonYP.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonYP.FlatAppearance.BorderSize = 0;
    this.buttonYP.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonYP.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonYP.FlatStyle = FlatStyle.Flat;
    this.buttonYP.Location = new Point(297, 254);
    this.buttonYP.Margin = new Padding(0);
    this.buttonYP.Name = "buttonYP";
    this.buttonYP.Size = new Size(14, 14);
    this.buttonYP.TabIndex = 671;
    this.buttonYP.UseVisualStyleBackColor = false;
    this.buttonYP.Click += new EventHandler(this.buttonYP_Click);
    this.textBoxTimer.BackColor = Color.FromArgb(67, 67, 67);
    this.textBoxTimer.BorderStyle = BorderStyle.None;
    this.textBoxTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxTimer.ForeColor = Color.White;
    this.textBoxTimer.ImeMode = ImeMode.NoControl;
    this.textBoxTimer.Location = new Point(299, 291);
    this.textBoxTimer.MaxLength = 3;
    this.textBoxTimer.Name = "textBoxTimer";
    this.textBoxTimer.Size = new Size(36, 16 /*0x10*/);
    this.textBoxTimer.TabIndex = 704;
    this.textBoxTimer.Text = "1";
    this.textBoxTimer.TextAlign = HorizontalAlignment.Center;
    this.textBoxTimer.TextChanged += new EventHandler(this.textBoxTimer_TextChanged);
    this.textBoxTimer.KeyPress += new KeyPressEventHandler(this.textBoxTimer_KeyPress);
    this.buttonEnglish.BackColor = Color.Transparent;
    this.buttonEnglish.BackgroundImage = (Image) Resources.P点选框A;
    this.buttonEnglish.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonEnglish.FlatAppearance.BorderSize = 0;
    this.buttonEnglish.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonEnglish.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonEnglish.FlatStyle = FlatStyle.Flat;
    this.buttonEnglish.Location = new Point(297, 373);
    this.buttonEnglish.Margin = new Padding(0);
    this.buttonEnglish.Name = "buttonEnglish";
    this.buttonEnglish.Size = new Size(14, 14);
    this.buttonEnglish.TabIndex = 705;
    this.buttonEnglish.UseVisualStyleBackColor = false;
    this.buttonEnglish.Click += new EventHandler(this.buttonEnglish_Click);
    this.buttonDeutsch.BackColor = Color.Transparent;
    this.buttonDeutsch.BackgroundImage = (Image) Resources.P点选框;
    this.buttonDeutsch.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDeutsch.FlatAppearance.BorderSize = 0;
    this.buttonDeutsch.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDeutsch.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDeutsch.FlatStyle = FlatStyle.Flat;
    this.buttonDeutsch.Location = new Point(387, 373);
    this.buttonDeutsch.Margin = new Padding(0);
    this.buttonDeutsch.Name = "buttonDeutsch";
    this.buttonDeutsch.Size = new Size(14, 14);
    this.buttonDeutsch.TabIndex = 706;
    this.buttonDeutsch.UseVisualStyleBackColor = false;
    this.buttonDeutsch.Click += new EventHandler(this.buttonDeutsch_Click);
    this.buttonPoccnr.BackColor = Color.Transparent;
    this.buttonPoccnr.BackgroundImage = (Image) Resources.P点选框;
    this.buttonPoccnr.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonPoccnr.FlatAppearance.BorderSize = 0;
    this.buttonPoccnr.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonPoccnr.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonPoccnr.FlatStyle = FlatStyle.Flat;
    this.buttonPoccnr.Location = new Point(477, 373);
    this.buttonPoccnr.Margin = new Padding(0);
    this.buttonPoccnr.Name = "buttonPoccnr";
    this.buttonPoccnr.Size = new Size(14, 14);
    this.buttonPoccnr.TabIndex = 707;
    this.buttonPoccnr.UseVisualStyleBackColor = false;
    this.buttonPoccnr.Click += new EventHandler(this.buttonPoccnr_Click);
    this.buttonFrancais.BackColor = Color.Transparent;
    this.buttonFrancais.BackgroundImage = (Image) Resources.P点选框;
    this.buttonFrancais.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonFrancais.FlatAppearance.BorderSize = 0;
    this.buttonFrancais.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonFrancais.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonFrancais.FlatStyle = FlatStyle.Flat;
    this.buttonFrancais.Location = new Point(567, 373);
    this.buttonFrancais.Margin = new Padding(0);
    this.buttonFrancais.Name = "buttonFrancais";
    this.buttonFrancais.Size = new Size(14, 14);
    this.buttonFrancais.TabIndex = 708;
    this.buttonFrancais.UseVisualStyleBackColor = false;
    this.buttonFrancais.Click += new EventHandler(this.buttonFrancais_Click);
    this.buttonPortugues.BackColor = Color.Transparent;
    this.buttonPortugues.BackgroundImage = (Image) Resources.P点选框;
    this.buttonPortugues.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonPortugues.FlatAppearance.BorderSize = 0;
    this.buttonPortugues.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonPortugues.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonPortugues.FlatStyle = FlatStyle.Flat;
    this.buttonPortugues.Location = new Point(657, 373);
    this.buttonPortugues.Margin = new Padding(0);
    this.buttonPortugues.Name = "buttonPortugues";
    this.buttonPortugues.Size = new Size(14, 14);
    this.buttonPortugues.TabIndex = 709;
    this.buttonPortugues.UseVisualStyleBackColor = false;
    this.buttonPortugues.Click += new EventHandler(this.buttonPortugues_Click);
    this.buttonRiBen.BackColor = Color.Transparent;
    this.buttonRiBen.BackgroundImage = (Image) Resources.P点选框;
    this.buttonRiBen.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonRiBen.FlatAppearance.BorderSize = 0;
    this.buttonRiBen.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonRiBen.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonRiBen.FlatStyle = FlatStyle.Flat;
    this.buttonRiBen.Location = new Point(297, 403);
    this.buttonRiBen.Margin = new Padding(0);
    this.buttonRiBen.Name = "buttonRiBen";
    this.buttonRiBen.Size = new Size(14, 14);
    this.buttonRiBen.TabIndex = 710;
    this.buttonRiBen.UseVisualStyleBackColor = false;
    this.buttonRiBen.Click += new EventHandler(this.buttonRiBen_Click);
    this.buttonEspanol.BackColor = Color.Transparent;
    this.buttonEspanol.BackgroundImage = (Image) Resources.P点选框;
    this.buttonEspanol.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonEspanol.FlatAppearance.BorderSize = 0;
    this.buttonEspanol.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonEspanol.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonEspanol.FlatStyle = FlatStyle.Flat;
    this.buttonEspanol.Location = new Point(387, 403);
    this.buttonEspanol.Margin = new Padding(0);
    this.buttonEspanol.Name = "buttonEspanol";
    this.buttonEspanol.Size = new Size(14, 14);
    this.buttonEspanol.TabIndex = 711;
    this.buttonEspanol.UseVisualStyleBackColor = false;
    this.buttonEspanol.Click += new EventHandler(this.buttonEspanol_Click);
    this.buttonCN.BackColor = Color.Transparent;
    this.buttonCN.BackgroundImage = (Image) Resources.P点选框;
    this.buttonCN.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonCN.FlatAppearance.BorderSize = 0;
    this.buttonCN.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonCN.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonCN.FlatStyle = FlatStyle.Flat;
    this.buttonCN.Location = new Point(477, 403);
    this.buttonCN.Margin = new Padding(0);
    this.buttonCN.Name = "buttonCN";
    this.buttonCN.Size = new Size(14, 14);
    this.buttonCN.TabIndex = 712;
    this.buttonCN.UseVisualStyleBackColor = false;
    this.buttonCN.Click += new EventHandler(this.buttonCN_Click);
    this.buttonTW.BackColor = Color.Transparent;
    this.buttonTW.BackgroundImage = (Image) Resources.P点选框;
    this.buttonTW.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonTW.FlatAppearance.BorderSize = 0;
    this.buttonTW.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonTW.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonTW.FlatStyle = FlatStyle.Flat;
    this.buttonTW.Location = new Point(567, 403);
    this.buttonTW.Margin = new Padding(0);
    this.buttonTW.Name = "buttonTW";
    this.buttonTW.Size = new Size(14, 14);
    this.buttonTW.TabIndex = 713;
    this.buttonTW.UseVisualStyleBackColor = false;
    this.buttonTW.Click += new EventHandler(this.buttonTW_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackgroundImage = (Image) Resources.A0关于en;
    this.BackgroundImageLayout = ImageLayout.Zoom;
    this.Controls.Add((Control) this.buttonTW);
    this.Controls.Add((Control) this.buttonCN);
    this.Controls.Add((Control) this.buttonEspanol);
    this.Controls.Add((Control) this.buttonRiBen);
    this.Controls.Add((Control) this.buttonPortugues);
    this.Controls.Add((Control) this.buttonFrancais);
    this.Controls.Add((Control) this.buttonPoccnr);
    this.Controls.Add((Control) this.buttonDeutsch);
    this.Controls.Add((Control) this.buttonEnglish);
    this.Controls.Add((Control) this.textBoxTimer);
    this.Controls.Add((Control) this.buttonYP);
    this.Controls.Add((Control) this.buttonF);
    this.Controls.Add((Control) this.buttonC);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.buttonPower);
    this.Controls.Add((Control) this.buttonBCZT);
    this.Controls.Add((Control) this.gfwzButton);
    this.Controls.Add((Control) this.labelInfo);
    this.Controls.Add((Control) this.label1);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCAbout);
    this.Size = new Size(1274, 800);
    this.MouseDown += new MouseEventHandler(this.UCAbout_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCAbout_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCAbout_MouseUp);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void delegateUCAbout(int cmd, object info = null, object data = null);
}

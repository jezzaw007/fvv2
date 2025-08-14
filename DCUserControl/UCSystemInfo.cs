// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCSystemInfo
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCSystemInfo : UserControl
{
  private const int shareMemorySize0 = 1048576 /*0x100000*/;
  private const int shareMemorySize = 2097152 /*0x200000*/;
  private const string shareMemoryName = "shareMemory_SysInfo";
  private MemoryMappedFile shareMemory;
  private byte[] shareMemoryVal = new byte[1048576 /*0x100000*/];
  private bool isMouseDown;
  private int xPos;
  private int yPos;
  private const int selectionH = 22;
  private int first = 1;
  private int imageY = 0;
  private const int imageVX = 442;
  private const int imageVY = 0;
  private const int imageH = 708;
  public System.Timers.Timer m_timer;
  private ArrayList buttonList;
  public ArrayList myListVal;
  public ArrayList myListName;
  private int myDCount = 3;
  public int myWendu = 1;
  public int myCount = 0;
  public UCSystemInfo.delegate_UCSystemInfo upDateUCInfo;
  public float CpuPower = 0.0f;
  public float GpuPower = 0.0f;
  public float MemTemperature = 100000f;
  public float MemClock = 100000f;
  public float MemUsed = 100000f;
  public float MemRatio = 100000f;
  public float MemTcas = 100000f;
  public float MemTrcd = 100000f;
  public float MemTrp = 100000f;
  public float MemTras = 100000f;
  public float MemTrc = 100000f;
  public float MemTrfc = 100000f;
  public float MemLoad = 100000f;
  private IContainer components = (IContainer) null;
  public Panel panel1;

  public ArrayList HardDiskInfo { get; private set; }

  private void InitMemorySize()
  {
    this.shareMemory = MemoryMappedFile.CreateOrOpen("shareMemory_SysInfo", 2097152L /*0x200000*/);
  }

  private void ReadShareMemory(int n = 0)
  {
    MemoryMappedViewStream viewStream = this.shareMemory.CreateViewStream((long) (n * 1048576 /*0x100000*/), 1048576L /*0x100000*/);
    viewStream.Read(this.shareMemoryVal, 0, 1048576 /*0x100000*/);
    viewStream.Close();
    viewStream.Dispose();
  }

  public void WriteShareMemory(int n, byte[] b, int count = 1048576 /*0x100000*/)
  {
    MemoryMappedViewStream viewStream = this.shareMemory.CreateViewStream((long) (n * 1048576 /*0x100000*/), (long) count);
    viewStream.Write(b, 0, count);
    viewStream.Close();
    viewStream.Dispose();
  }

  private void CloseShareMemory() => this.shareMemory.Dispose();

  private void FormInitDc()
  {
    try
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Contains("HWINFO"))
          process.Kill();
      }
    }
    catch (Exception ex)
    {
    }
    Thread.Sleep(200);
    ProcessStartInfo startInfo = new ProcessStartInfo();
    startInfo.FileName = "HWINFO.exe";
    startInfo.WorkingDirectory = Application.StartupPath;
    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
    Process process1;
    try
    {
      process1 = Process.Start(startInfo);
    }
    catch
    {
    }
    for (int index = 0; index < 60; ++index)
    {
      this.ReadShareMemory();
      if (!new ASCIIEncoding().GetString(this.shareMemoryVal, 0, 100).Contains("HWi32_GetNumberOfDetectedSensors"))
      {
        bool flag = false;
        try
        {
          foreach (Process process2 in Process.GetProcesses())
          {
            if (process2.ProcessName.Contains("HWINFO"))
              flag = true;
          }
        }
        catch (Exception ex)
        {
        }
        if (!flag)
        {
          try
          {
            process1 = Process.Start(startInfo);
          }
          catch
          {
          }
        }
        Thread.Sleep(1000);
      }
      else
        break;
    }
    this.m_timer = new System.Timers.Timer(1000.0);
    this.m_timer.Elapsed += new ElapsedEventHandler(this.timer_event);
    this.m_timer.AutoReset = true;
    this.m_timer.Start();
    while (Form1.formStart == null)
      Thread.Sleep(1000);
    Form1.formStart.SetMyClose();
  }

  public UCSystemInfo()
  {
    this.InitializeComponent();
    this.InitMemorySize();
    this.isMouseDown = false;
    this.xPos = 0;
    this.yPos = 0;
    this.buttonList = new ArrayList();
    this.myListName = new ArrayList();
    this.myListVal = new ArrayList();
    this.HardDiskInfo = new ArrayList();
    this.MouseWheel += new MouseEventHandler(this.FrmMain_MouseWheel);
  }

  public void ThreadStart() => new Thread(new System.Threading.ThreadStart(this.FormInitDc)).Start();

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams = base.CreateParams;
      createParams.ExStyle |= 33554432 /*0x02000000*/;
      return createParams;
    }
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (this.panel1.Height <= this.Height)
      return;
    graphics.DrawImage((Image) Resources.P滚动条底图, 442, 8, 20, 661);
    graphics.DrawImage((Image) Resources.P滚动条按钮, 442, this.imageY);
  }

  public void ResetSystemInfoVal(ArrayList arrayList)
  {
    for (int index = 0; index < arrayList.Count; ++index)
    {
      ArrayList array = (ArrayList) arrayList[index];
      ((Control) this.myListName[index]).Text = (string) array[1];
      ((Control) this.myListVal[index]).Text = (string) array[2];
      if (!this.panel1.Controls[index].Visible)
        this.panel1.Controls[index].Show();
    }
    for (int count = arrayList.Count; count < this.panel1.Controls.Count; ++count)
    {
      if (this.panel1.Controls[count].Visible)
        this.panel1.Controls[count].Hide();
    }
    if (this.panel1.Height == arrayList.Count * 22)
      return;
    this.panel1.Height = arrayList.Count * 22;
    this.Invalidate(new Rectangle(442, 0, 20, this.Height));
  }

  public void SetSystemInfoVal(ArrayList arrayList)
  {
    int num = 0;
    for (int index = 0; index < this.panel1.Controls.Count; ++index)
      this.panel1.Controls[index].Controls.Clear();
    this.panel1.Controls.Clear();
    for (int index = 0; index < arrayList.Count; ++index)
    {
      ArrayList array = (ArrayList) arrayList[index];
      Label label1 = new Label();
      label1.BorderStyle = BorderStyle.None;
      label1.FlatStyle = FlatStyle.Flat;
      label1.Location = new Point(0, 22 * num);
      label1.Name = "label" + num.ToString();
      label1.Size = new Size(680, 22);
      label1.BackColor = Color.Transparent;
      label1.TabIndex = 1000 + num;
      Button button = new Button();
      button.BackColor = Color.Transparent;
      if ((int) array[0] == 1)
        button.BackgroundImage = (Image) Resources.P点选框A;
      else
        button.BackgroundImage = (Image) Resources.P点选框;
      button.BackgroundImageLayout = ImageLayout.Stretch;
      button.FlatAppearance.BorderSize = 0;
      button.FlatAppearance.MouseDownBackColor = Color.Transparent;
      button.FlatAppearance.MouseOverBackColor = Color.Transparent;
      button.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
      button.FlatStyle = FlatStyle.Flat;
      button.Location = new Point(8, 3);
      button.Margin = new Padding(0);
      button.Name = "buttonC" + num.ToString();
      button.Size = new Size(14, 14);
      button.TabIndex = 2000 + num;
      button.UseVisualStyleBackColor = false;
      label1.Controls.Add((Control) button);
      button.Click += new EventHandler(this.button_Click);
      this.buttonList.Add((object) button);
      Label label2 = new Label();
      label2.BorderStyle = BorderStyle.None;
      label2.FlatStyle = FlatStyle.Flat;
      label2.Location = new Point(76, 0);
      label2.Name = "label1L" + num.ToString();
      label2.Size = new Size(258, 22);
      label2.BackColor = Color.Transparent;
      label2.ForeColor = Color.FromArgb(129, 129, 129);
      label2.TabIndex = 3000 + num;
      label2.Text = (string) array[1];
      label2.TextAlign = ContentAlignment.MiddleLeft;
      label1.Controls.Add((Control) label2);
      this.myListName.Add((object) label2);
      Label label3 = new Label();
      label3.BorderStyle = BorderStyle.None;
      label3.FlatStyle = FlatStyle.Flat;
      label3.Location = new Point(335, 0);
      label3.Name = "label1C" + num.ToString();
      label3.Size = new Size(70, 22);
      label3.BackColor = Color.Transparent;
      label3.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      label3.TabIndex = 4000 + num;
      label3.Text = (string) array[2];
      label3.TextAlign = ContentAlignment.MiddleLeft;
      this.myListVal.Add((object) label3);
      label1.Controls.Add((Control) label3);
      this.panel1.Controls.Add((Control) label1);
      ++num;
    }
    this.panel1.Height = num * 22;
    if (this.panel1.Height > this.Height)
      this.Invalidate(new Rectangle(442, 0, 20, this.Height));
    for (int index = 0; index < 30; ++index)
    {
      Label label4 = new Label();
      label4.BorderStyle = BorderStyle.None;
      label4.FlatStyle = FlatStyle.Flat;
      label4.Location = new Point(0, 22 * num);
      label4.Name = "label" + num.ToString();
      label4.Size = new Size(680, 22);
      label4.BackColor = Color.Transparent;
      label4.TabIndex = 1000 + num;
      Button button = new Button();
      button.BackColor = Color.Transparent;
      button.BackgroundImage = (Image) Resources.P点选框;
      button.BackgroundImageLayout = ImageLayout.Stretch;
      button.FlatAppearance.BorderSize = 0;
      button.FlatAppearance.MouseDownBackColor = Color.Transparent;
      button.FlatAppearance.MouseOverBackColor = Color.Transparent;
      button.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
      button.FlatStyle = FlatStyle.Flat;
      button.Location = new Point(8, 3);
      button.Margin = new Padding(0);
      button.Name = "buttonC" + num.ToString();
      button.Size = new Size(14, 14);
      button.TabIndex = 2000 + num;
      button.UseVisualStyleBackColor = false;
      label4.Controls.Add((Control) button);
      button.Click += new EventHandler(this.button_Click);
      this.buttonList.Add((object) button);
      Label label5 = new Label();
      label5.BorderStyle = BorderStyle.None;
      label5.FlatStyle = FlatStyle.Flat;
      label5.Location = new Point(76, 0);
      label5.Name = "label1L" + num.ToString();
      label5.Size = new Size(258, 22);
      label5.BackColor = Color.Transparent;
      label5.ForeColor = Color.FromArgb(129, 129, 129);
      label5.TabIndex = 3000 + num;
      label5.Text = "";
      label5.TextAlign = ContentAlignment.MiddleLeft;
      label4.Controls.Add((Control) label5);
      this.myListName.Add((object) label5);
      Label label6 = new Label();
      label6.BorderStyle = BorderStyle.None;
      label6.FlatStyle = FlatStyle.Flat;
      label6.Location = new Point(335, 0);
      label6.Name = "label1C" + num.ToString();
      label6.Size = new Size(70, 22);
      label6.BackColor = Color.Transparent;
      label6.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      label6.TabIndex = 4000 + num;
      label6.Text = "";
      label6.TextAlign = ContentAlignment.MiddleLeft;
      label4.Controls.Add((Control) label6);
      this.myListVal.Add((object) label6);
      label4.Hide();
      this.panel1.Controls.Add((Control) label4);
      ++num;
    }
  }

  public void ButtonClick(int n)
  {
    if (n < 0 || n >= this.buttonList.Count)
      return;
    for (int index = 0; index < this.buttonList.Count; ++index)
    {
      if (index == n)
      {
        Image backgroundImage = ((Control) this.buttonList[index]).BackgroundImage;
        ((Control) this.buttonList[index]).BackgroundImage = (Image) Resources.P点选框A;
        backgroundImage.Dispose();
        this.myCount = index;
      }
      else
      {
        Image backgroundImage = ((Control) this.buttonList[index]).BackgroundImage;
        ((Control) this.buttonList[index]).BackgroundImage = (Image) Resources.P点选框;
        backgroundImage.Dispose();
      }
    }
  }

  private void button_Click(object sender, EventArgs e)
  {
    Button button = (Button) sender;
    for (int index = 0; index < this.buttonList.Count; ++index)
    {
      if (button.TabIndex == ((Control) this.buttonList[index]).TabIndex)
      {
        Image backgroundImage = button.BackgroundImage;
        button.BackgroundImage = (Image) Resources.P点选框A;
        backgroundImage.Dispose();
        this.myCount = index;
      }
      else
      {
        Image backgroundImage = ((Control) this.buttonList[index]).BackgroundImage;
        ((Control) this.buttonList[index]).BackgroundImage = (Image) Resources.P点选框;
        backgroundImage.Dispose();
      }
    }
  }

  public int strlen(byte[] s)
  {
    int index = 0;
    while (s[index] > (byte) 0)
      ++index;
    return index;
  }

  public void DoSystemInfoUI(ArrayList array)
  {
    if (this.first == 1)
    {
      this.first = 0;
      this.SetSystemInfoVal(array);
      UCSystemInfo.delegate_UCSystemInfo upDateUcInfo = this.upDateUCInfo;
      if (upDateUcInfo != null)
        upDateUcInfo(254);
    }
    else
    {
      this.ResetSystemInfoVal(array);
      if (this.myDCount > 0)
      {
        --this.myDCount;
        if (this.myDCount == 1)
        {
          UCSystemInfo.delegate_UCSystemInfo upDateUcInfo = this.upDateUCInfo;
          if (upDateUcInfo != null)
            upDateUcInfo(0);
        }
        if (this.myDCount == 0)
        {
          UCSystemInfo.delegate_UCSystemInfo upDateUcInfo = this.upDateUCInfo;
          if (upDateUcInfo != null)
            upDateUcInfo(16 /*0x10*/);
        }
      }
    }
    UCSystemInfo.delegate_UCSystemInfo upDateUcInfo1 = this.upDateUCInfo;
    if (upDateUcInfo1 != null)
      upDateUcInfo1((int) byte.MaxValue);
    array.Clear();
  }

  public void UpdateSystemInfo(object b)
  {
    this.BeginInvoke((Delegate) new UCSystemInfo.DoSystemInfoInvoke(this.DoSystemInfoUI), b);
  }

  private bool SetSystemVal(string strjs, string str, string types, ref float sysVal, int n = 1)
  {
    string str1;
    while (true)
    {
      int num1 = strjs.IndexOf(str);
      if (num1 > 0)
      {
        int startIndex = num1 + (str.Length + 1);
        string str2 = strjs.Substring(startIndex);
        int num2 = str2.IndexOf("}");
        JObject jobject = JObject.Parse(strjs.Substring(startIndex, num2 + 1));
        string str3 = jobject["type"].ToString();
        str1 = jobject["value"].ToString();
        if (!str3.Contains(types))
          strjs = str2;
        else
          break;
      }
      else
        goto label_4;
    }
    string str4 = str1.Substring(0, str1.IndexOf("."));
    sysVal = Convert.ToSingle(str4) * (float) n;
    return true;
label_4:
    return false;
  }

  private void GetHarddiskInfo(string head, string info)
  {
    if (this.HardDiskInfo.Count == 0)
    {
      string str1 = head;
      for (int index = str1.IndexOf("drive: "); index > 0; index = str1.IndexOf("drive: "))
      {
        int startIndex1 = index + 7;
        int num = str1.Substring(startIndex1).IndexOf(")");
        this.HardDiskInfo.Add((object) new ArrayList()
        {
          (object) str1.Substring(startIndex1, num + 1),
          (object) 100000,
          (object) 100000,
          (object) 100000,
          (object) 100000
        });
        int startIndex2 = startIndex1 + num;
        str1 = str1.Substring(startIndex2);
      }
      int index1 = 0;
      string str2 = head;
      for (int index2 = str2.IndexOf("s.m.a.r.t.: "); index2 > 0; index2 = str2.IndexOf("s.m.a.r.t.: "))
      {
        int startIndex3 = index2 + 12;
        int length = str2.Substring(startIndex3).IndexOf(")");
        string str3 = str2.Substring(startIndex3, length);
        int index3;
        for (index3 = 0; index3 < this.HardDiskInfo.Count; ++index3)
        {
          ArrayList arrayList = (ArrayList) this.HardDiskInfo[index3];
          if (((string) arrayList[0]).Contains(str3))
          {
            arrayList.Add((object) str3);
            break;
          }
        }
        if (index3 == this.HardDiskInfo.Count)
        {
          try
          {
            ((ArrayList) this.HardDiskInfo[index1]).Add((object) str3);
          }
          catch
          {
          }
        }
        ++index1;
        int startIndex4 = startIndex3 + length;
        str2 = str2.Substring(startIndex4);
      }
    }
    for (int index = 0; index < this.HardDiskInfo.Count; ++index)
    {
      try
      {
        ArrayList arrayList = (ArrayList) this.HardDiskInfo[index];
        string str4 = (string) arrayList[0];
        int startIndex5 = info.IndexOf("drive: " + str4);
        string strjs1 = info.Substring(startIndex5);
        float sysVal1 = 10000f;
        this.SetSystemVal(strjs1, "\"Total Activity\"", "usage", ref sysVal1);
        arrayList[2] = (object) (int) sysVal1;
        float sysVal2 = 10000f;
        this.SetSystemVal(strjs1, "\"Read Rate\"", "other", ref sysVal2);
        arrayList[3] = (object) (int) sysVal2;
        float sysVal3 = 10000f;
        this.SetSystemVal(strjs1, "\"Write Rate\"", "other", ref sysVal3);
        arrayList[4] = (object) (int) sysVal3;
        string str5 = (string) arrayList[5];
        int startIndex6 = info.IndexOf("s.m.a.r.t.: " + str5);
        string strjs2 = info.Substring(startIndex6);
        sysVal3 = 10000f;
        this.SetSystemVal(strjs2, "\"Drive Temperature\"", "temperature", ref sysVal3);
        arrayList[1] = (object) (int) sysVal3;
      }
      catch
      {
      }
    }
  }

  private void timer_event(object sender, ElapsedEventArgs e)
  {
    bool flag = false;
    int startIndex1 = 0;
    try
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Contains("HWINFO"))
          flag = true;
      }
    }
    catch (Exception ex)
    {
    }
    if (!flag)
    {
      ProcessStartInfo startInfo = new ProcessStartInfo();
      startInfo.FileName = "HWINFO.exe";
      startInfo.WorkingDirectory = Application.StartupPath;
      startInfo.WindowStyle = ProcessWindowStyle.Hidden;
      try
      {
        Process.Start(startInfo);
      }
      catch
      {
      }
    }
    this.ReadShareMemory();
    string str1 = new ASCIIEncoding().GetString(this.shareMemoryVal, 0, this.strlen(this.shareMemoryVal));
    string str2;
    string head;
    try
    {
      int num = str1.IndexOf("{");
      str2 = str1.Substring(num);
      head = str1.Substring(0, num);
    }
    catch
    {
      return;
    }
    ArrayList parameter = new ArrayList();
    do
    {
      startIndex1 = str2.IndexOf("\"type\":\"temperature\"", startIndex1);
      if (startIndex1 > 0)
      {
        ArrayList arrayList = new ArrayList();
        int num1 = str2.LastIndexOf("{\"", startIndex1 - 1);
        if (num1 > 0)
        {
          int num2 = str2.IndexOf("\"", num1 + 2);
          if (num2 > 0 && num2 < startIndex1)
          {
            string str3 = str2.Substring(num1 + 2, num2 - num1 - 2);
            arrayList.Add((object) str3);
            int num3 = str2.IndexOf("value", startIndex1 + 1);
            if (num3 > 0)
            {
              int num4 = str2.IndexOf("\"", num3 + 6);
              int num5 = str2.IndexOf("\"", num4 + 1);
              string str4 = str2.Substring(num4 + 1, num5 - num4 - 1);
              int num6 = (int) float.Parse(str4.Substring(0, str4.IndexOf(".")));
              if (this.myWendu == 1)
                arrayList.Add((object) (num6.ToString() + "℃"));
              else if (this.myWendu == 2)
              {
                num6 = num6 * 9 / 5 + 32 /*0x20*/;
                arrayList.Add((object) (num6.ToString() + "℉"));
              }
            }
            else if (this.myWendu == 1)
              arrayList.Add((object) "0℃");
            else if (this.myWendu == 2)
              arrayList.Add((object) "32℉");
            arrayList.Insert(0, (object) 0);
            if (((string) arrayList[1]).ToLower().Contains("core "))
              arrayList.Clear();
            else
              parameter.Add((object) arrayList);
          }
        }
        startIndex1 += 20;
      }
    }
    while (startIndex1 > 0);
    int startIndex2 = 0;
    do
    {
      startIndex2 = str2.IndexOf("\"type\":\"fan\"", startIndex2);
      if (startIndex2 > 0)
      {
        ArrayList arrayList = new ArrayList();
        int num7 = str2.LastIndexOf("{\"", startIndex2 - 1);
        if (num7 > 0)
        {
          int num8 = str2.IndexOf("\"", num7 + 2);
          if (num8 > 0 && num8 < startIndex2)
          {
            string str5 = str2.Substring(num7 + 2, num8 - num7 - 2);
            arrayList.Add((object) str5);
            int num9 = str2.IndexOf("value", startIndex2 + 1);
            if (num9 > 0)
            {
              int num10 = str2.IndexOf("\"", num9 + 6);
              int num11 = str2.IndexOf("\"", num10 + 1);
              string str6 = str2.Substring(num10 + 1, num11 - num10 - 1);
              int num12 = (int) float.Parse(str6.Substring(0, str6.IndexOf(".")));
              arrayList.Add((object) (num12.ToString() + "RPM"));
            }
            else
              arrayList.Add((object) "0RPM");
            arrayList.Insert(0, (object) 0);
            parameter.Add((object) arrayList);
          }
        }
        startIndex2 += 12;
      }
    }
    while (startIndex2 > 0);
    int startIndex3 = 0;
    do
    {
      startIndex3 = str2.IndexOf("\"type\":\"clock\"", startIndex3);
      if (startIndex3 > 0)
      {
        ArrayList arrayList = new ArrayList();
        int num13 = str2.LastIndexOf("{\"", startIndex3 - 1);
        if (num13 > 0)
        {
          int num14 = str2.IndexOf("\"", num13 + 2);
          if (num14 > 0 && num14 < startIndex3)
          {
            string str7 = str2.Substring(num13 + 2, num14 - num13 - 2);
            arrayList.Add((object) str7);
            int num15 = str2.IndexOf("value", startIndex3 + 1);
            if (num15 > 0)
            {
              int num16 = str2.IndexOf("\"", num15 + 6);
              int num17 = str2.IndexOf("\"", num16 + 1);
              string str8 = str2.Substring(num16 + 1, num17 - num16 - 1);
              int num18 = (int) float.Parse(str8.Substring(0, str8.IndexOf(".")));
              arrayList.Add((object) (num18.ToString() + "MHz"));
            }
            else
              arrayList.Add((object) "0MHz");
            arrayList.Insert(0, (object) 0);
            parameter.Add((object) arrayList);
          }
        }
        startIndex3 += 14;
      }
    }
    while (startIndex3 > 0);
    int startIndex4 = 0;
    do
    {
      startIndex4 = str2.IndexOf("\"type\":\"usage\"", startIndex4);
      if (startIndex4 > 0)
      {
        ArrayList arrayList = new ArrayList();
        int num19 = str2.LastIndexOf("{\"", startIndex4 - 1);
        if (num19 > 0)
        {
          int num20 = str2.IndexOf("\"", num19 + 2);
          if (num20 > 0 && num20 < startIndex4)
          {
            string str9 = str2.Substring(num19 + 2, num20 - num19 - 2);
            arrayList.Add((object) str9);
            int num21 = str2.IndexOf("value", startIndex4 + 1);
            if (num21 > 0)
            {
              int num22 = str2.IndexOf("\"", num21 + 6);
              int num23 = str2.IndexOf("\"", num22 + 1);
              string str10 = str2.Substring(num22 + 1, num23 - num22 - 1);
              int num24 = (int) float.Parse(str10.Substring(0, str10.IndexOf(".")));
              arrayList.Add((object) (num24.ToString() + "%"));
            }
            else
              arrayList.Add((object) "0%");
            arrayList.Insert(0, (object) 0);
            if (((string) arrayList[1]).Contains("core "))
              arrayList.Clear();
            else
              parameter.Add((object) arrayList);
          }
        }
        startIndex4 += 14;
      }
    }
    while (startIndex4 > 0);
    int startIndex5 = 0;
    do
    {
      startIndex5 = str2.IndexOf("\"type\":\"power\"", startIndex5);
      if (startIndex5 > 0)
      {
        ArrayList arrayList = new ArrayList();
        int num25 = str2.LastIndexOf("{\"", startIndex5 - 1);
        if (num25 > 0)
        {
          int num26 = str2.IndexOf("\"", num25 + 2);
          if (num26 > 0 && num26 < startIndex5)
          {
            string str11 = str2.Substring(num25 + 2, num26 - num25 - 2);
            arrayList.Add((object) str11);
            int num27 = str2.IndexOf("value", startIndex5 + 1);
            if (num27 > 0)
            {
              int num28 = str2.IndexOf("\"", num27 + 6);
              int num29 = str2.IndexOf("\"", num28 + 1);
              string str12 = str2.Substring(num28 + 1, num29 - num28 - 1);
              int num30 = (int) float.Parse(str12.Substring(0, str12.IndexOf(".")));
              arrayList.Add((object) (num30.ToString() + "W"));
            }
            else
              arrayList.Add((object) "0W");
            arrayList.Insert(0, (object) 0);
            parameter.Add((object) arrayList);
          }
        }
        startIndex5 += 14;
      }
    }
    while (startIndex5 > 0);
    int startIndex6 = 0;
    do
    {
      startIndex6 = str2.IndexOf("\"type\":\"other\"", startIndex6);
      if (startIndex6 > 0)
      {
        ArrayList arrayList = new ArrayList();
        int num31 = str2.LastIndexOf("{\"", startIndex6 - 1);
        if (num31 > 0)
        {
          int num32 = str2.IndexOf("\"", num31 + 2);
          if (num32 > 0 && num32 < startIndex6)
          {
            string str13 = str2.Substring(num31 + 2, num32 - num31 - 2);
            arrayList.Add((object) str13);
            int num33 = str2.IndexOf("value", startIndex6 + 1);
            if (num33 > 0)
            {
              int num34 = str2.IndexOf("\"", num33 + 6);
              int num35 = str2.IndexOf("\"", num34 + 1);
              string str14 = str2.Substring(num34 + 1, num35 - num34 - 1);
              int num36 = (int) float.Parse(str14.Substring(0, str14.IndexOf(".")));
              arrayList.Add((object) (num36.ToString() ?? ""));
            }
            else
              arrayList.Add((object) "0");
            arrayList.Insert(0, (object) 0);
            parameter.Add((object) arrayList);
          }
        }
        startIndex6 += 14;
      }
    }
    while (startIndex6 > 0);
    this.SetSystemVal(str2, "\"CPU Package Power\"", "power", ref this.CpuPower);
    if (!this.SetSystemVal(str2, "\"Total Graphics Power (TGP)\"", "power", ref this.GpuPower) && !this.SetSystemVal(str2, "\"GPU Power\"", "power", ref this.GpuPower) && !this.SetSystemVal(str2, "\"GPU ASIC Power\"", "power", ref this.GpuPower))
      this.GpuPower = this.CpuPower;
    this.SetSystemVal(str2, "\"SPD Hub Temperature\"", "temperature", ref this.MemTemperature);
    this.SetSystemVal(str2, "\"Memory Clock\"", "clock", ref this.MemClock);
    this.SetSystemVal(str2, "\"Physical Memory Used\"", "other", ref this.MemUsed);
    this.SetSystemVal(str2, "\"Memory Clock Ratio\"", "other", ref this.MemRatio);
    this.SetSystemVal(str2, "\"Tcas\"", "other", ref this.MemTcas);
    this.SetSystemVal(str2, "\"Trcd\"", "other", ref this.MemTrcd);
    this.SetSystemVal(str2, "\"Trp\"", "other", ref this.MemTrp);
    this.SetSystemVal(str2, "\"Tras\"", "other", ref this.MemTras);
    this.SetSystemVal(str2, "\"Trc\"", "other", ref this.MemTrc);
    this.SetSystemVal(str2, "\"Trfc\"", "other", ref this.MemTrfc);
    this.SetSystemVal(str2, "\"Physical Memory Load\"", "other", ref this.MemLoad);
    this.GetHarddiskInfo(head, str2);
    new Thread(new ParameterizedThreadStart(this.UpdateSystemInfo)).Start((object) parameter);
  }

  public void ucSystemInfoClose()
  {
    this.m_timer.Stop();
    this.m_timer.Close();
    this.m_timer.Dispose();
    this.CloseShareMemory();
    try
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Contains("HWINFO"))
          process.Kill();
      }
    }
    catch (Exception ex)
    {
    }
  }

  private void FrmMain_MouseWheel(object sender, MouseEventArgs e)
  {
    this.imageY -= e.Delta * 3 / 10;
    if (this.imageY < 0)
      this.imageY = 0;
    if (this.imageY > 708)
      this.imageY = 708;
    this.Invalidate(new Rectangle(442, 0, 20, this.Height));
    if (this.panel1.Height <= this.Height)
      return;
    this.panel1.Top = -(this.imageY * (this.panel1.Height - this.Height) / 708);
  }

  private void UCSystemInfo_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this.xPos = e.X;
    this.yPos = e.Y;
    this.isMouseDown = true;
    this.imageY = this.yPos - 15;
    if (this.imageY < 0)
      this.imageY = 0;
    if (this.imageY > 708)
      this.imageY = 708;
    this.Invalidate(new Rectangle(442, 0, 20, this.Height));
    if (this.panel1.Height > this.Height)
      this.panel1.Top = -(this.imageY * (this.panel1.Height - this.Height) / 708);
  }

  private void UCSystemInfo_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    this.xPos = e.X;
    this.yPos = e.Y;
    this.imageY = this.yPos - 15;
    if (this.imageY < 0)
      this.imageY = 0;
    if (this.imageY > 708)
      this.imageY = 708;
    this.Invalidate(new Rectangle(442, 0, 20, this.Height));
    if (this.panel1.Height > this.Height)
      this.panel1.Top = -(this.imageY * (this.panel1.Height - this.Height) / 708);
  }

  private void UCSystemInfo_MouseUp(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    this.isMouseDown = false;
    this.xPos = e.X;
    this.yPos = e.Y;
    this.imageY = this.yPos - 15;
    if (this.imageY < 0)
      this.imageY = 0;
    if (this.imageY > 708)
      this.imageY = 708;
    this.Invalidate(new Rectangle(442, 0, 20, this.Height));
    if (this.panel1.Height > this.Height)
      this.panel1.Top = -(this.imageY * (this.panel1.Height - this.Height) / 708);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.panel1 = new Panel();
    this.SuspendLayout();
    this.panel1.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.panel1.Location = new Point(0, 0);
    this.panel1.Margin = new Padding(0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(436, 742);
    this.panel1.TabIndex = 90;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImageLayout = ImageLayout.Zoom;
    this.Controls.Add((Control) this.panel1);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCSystemInfo);
    this.Size = new Size(466, 742);
    this.MouseDown += new MouseEventHandler(this.UCSystemInfo_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCSystemInfo_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCSystemInfo_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegate_UCSystemInfo(int mode);

  public delegate void DoSystemInfoInvoke(ArrayList array);
}

// Decompiled with JetBrains decompiler
// Type: TRCC.Form1
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using Microsoft.Win32;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TRCC.CZTV;
using TRCC.LED;
using TRCC.Properties;

#nullable disable
namespace TRCC;

public class Form1 : Form
{
  public static int CPUUsage = 0;
  public static float CPUTemp = 0.0f;
  public static string CPUFrequency = "0";
  public static int GPUUsage = 0;
  public static float GPUTemp = 0.0f;
  public static string GPUFrequency = "0";
  private bool isMouseDown;
  private Point _mousePoint;
  private System.Windows.Forms.Timer m_timer;
  private ArrayList formDeviceArray = (ArrayList) null;
  private bool kaiji = false;
  private int nowFormDevice = 0;
  private int nowFormDeviceRGB = 0;
  private int myMode = 1;
  private int timerCount = 0;
  private int timerCountRGB = 0;
  public static FormStart formStart = (FormStart) null;
  public static FormSystemInfo formSystemInfo = (FormSystemInfo) null;
  public static UCSystemInfoOptions ucSystemInfoOptions1 = (UCSystemInfoOptions) null;
  private const int AllCZTVCount = 10;
  private ArrayList formCZTVArray = (ArrayList) null;
  private int formCZTVRgbArrayCount = 0;
  private int formCZTVSpiArrayCount = 0;
  public const int GIFMaxCount = 20000;
  public const int shareMemorySizeCount = 250;
  public const int shareMemorySize0 = 153600;
  private const int shareMemorySize = 38400000;
  private const string shareMemoryName = "shareMemory_Image";
  private MemoryMappedFile shareMemory;
  private byte[] shareMemoryVal = new byte[153600];
  public const int shareMemorySizeCountRGB = 50;
  public const int shareMemorySize1 = 691200;
  private const int shareMemorySizeRGB = 34560000;
  private const string shareMemoryNameRGB = "shareMemory_ImageRGB";
  private MemoryMappedFile shareMemoryRGB;
  private byte[] shareMemoryValRGB = new byte[691200];
  private bool myPowerMode = false;
  private int oneTimerCount = 0;
  public static int Language = 0;
  private const string TaskName = "TRCCAppStartup";
  private IContainer components = (IContainer) null;
  private ContextMenuStrip contextMenuStrip1;
  private ToolStripMenuItem 退出ToolStripMenuItem;
  private NotifyIcon mainNotifyIcon;
  private Button buttonPower;
  private UCDevice ucDevice1;
  private UCAbout ucAbout1;
  private Button buttonHelp;
  private Button buttonNet60;

  private void InitMemorySize()
  {
    this.shareMemory = MemoryMappedFile.CreateOrOpen("shareMemory_Image", 38400000L);
  }

  private void ReadShareMemory(int n = 0)
  {
    MemoryMappedViewStream viewStream = this.shareMemory.CreateViewStream((long) (n * 153600), 153600L);
    viewStream.Read(this.shareMemoryVal, 0, 153600);
    viewStream.Close();
    viewStream.Dispose();
  }

  private void WriteShareMemory(int n, byte[] b, int count = 153600)
  {
    MemoryMappedViewStream viewStream = this.shareMemory.CreateViewStream((long) (n * 153600), (long) count);
    viewStream.Write(b, 0, count);
    viewStream.Close();
    viewStream.Dispose();
  }

  private void CloseShareMemory() => this.shareMemory.Dispose();

  private void InitMemorySizeRGB()
  {
    this.shareMemoryRGB = MemoryMappedFile.CreateOrOpen("shareMemory_ImageRGB", 34560000L);
  }

  private void ReadShareMemoryRGB(int n = 0, int count = 691200)
  {
    MemoryMappedViewStream viewStream = this.shareMemoryRGB.CreateViewStream((long) (n * 691200), (long) count);
    viewStream.Read(this.shareMemoryValRGB, 0, count);
    viewStream.Close();
    viewStream.Dispose();
  }

  private void WriteShareMemoryRGB(int n, byte[] b, int count = 691200)
  {
    MemoryMappedViewStream viewStream = this.shareMemoryRGB.CreateViewStream((long) (n * 691200), (long) count);
    viewStream.Write(b, 0, count);
    viewStream.Close();
    viewStream.Dispose();
  }

  private void CloseShareMemoryRGB() => this.shareMemoryRGB.Dispose();

  private void ClearButtonBouns()
  {
    this.buttonPower.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
  }

  private bool IsTaskSetAutoStart(string taskName)
  {
    ProcessStartInfo startInfo = new ProcessStartInfo()
    {
      FileName = "schtasks.exe",
      Arguments = $"/query /tn \"{taskName}\" /v",
      RedirectStandardOutput = true,
      UseShellExecute = false,
      CreateNoWindow = true
    };
    try
    {
      using (Process process = Process.Start(startInfo))
      {
        string end = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        return end.Contains(taskName);
      }
    }
    catch
    {
      return false;
    }
  }

  private void TaskChenge(string taskVal, string taskName)
  {
    int num1 = taskVal.IndexOf("<Settings>");
    if (num1 <= 0)
      return;
    try
    {
      StringBuilder stringBuilder1 = new StringBuilder(taskVal);
      stringBuilder1.Insert(num1 + 10, "\r\n   <ExecutionTimeLimit>PT0H</ExecutionTimeLimit>");
      taskVal = stringBuilder1.ToString();
      int num2 = taskVal.IndexOf("<DisallowStartIfOnBatteries>");
      if (num2 > 0)
      {
        StringBuilder stringBuilder2 = new StringBuilder(taskVal);
        stringBuilder2.Remove(num2 + 28, 4);
        stringBuilder2.Insert(num2 + 28, "false");
        taskVal = stringBuilder2.ToString();
      }
      int num3 = taskVal.IndexOf("<StopIfGoingOnBatteries>");
      if (num3 > 0)
      {
        StringBuilder stringBuilder3 = new StringBuilder(taskVal);
        stringBuilder3.Remove(num3 + 24, 4);
        stringBuilder3.Insert(num3 + 24, "false");
        taskVal = stringBuilder3.ToString();
      }
      File.WriteAllText(Application.StartupPath + "\\taskval.xml", taskVal, (Encoding) new UnicodeEncoding());
      Process.Start("schtasks", $"/create /xml \"{Application.StartupPath}\\taskval.xml\" /tn \"{taskName}\" /f");
      Thread.Sleep(100);
      File.Delete(Application.StartupPath + "\\taskval.xml");
    }
    catch
    {
    }
  }

  private bool TaskQueryAndChenge(string taskName)
  {
    ProcessStartInfo startInfo = new ProcessStartInfo()
    {
      FileName = "schtasks.exe",
      Arguments = $"/query /tn \"{taskName}\" /xml",
      RedirectStandardOutput = true,
      UseShellExecute = false,
      CreateNoWindow = true
    };
    try
    {
      using (Process process = Process.Start(startInfo))
      {
        string end = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        this.TaskChenge(end, taskName);
        return end.Contains(taskName);
      }
    }
    catch
    {
      return false;
    }
  }

  private void TaskSetAutoCreate(string taskName)
  {
    Process.Start("schtasks", $"/create /tn \"{taskName}\" /tr \"\\\"{Application.ExecutablePath}\\\"\" /sc onlogon /rl highest /f");
    Thread.Sleep(100);
    this.TaskQueryAndChenge(taskName);
  }

  private void TaskSetAutoDelete(string taskName)
  {
    Process.Start("schtasks", $"/delete /tn \"{taskName}\" /f");
  }

  private void KaijiQidongOld()
  {
    string executablePath = Application.ExecutablePath;
    RegistryKey localMachine = Registry.LocalMachine;
    RegistryKey subKey = localMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
    string str = (string) subKey.GetValue("TRCC");
    if (str == null)
    {
      subKey.SetValue("TRCC", (object) executablePath);
      this.ucAbout1.Button1_Set(true);
    }
    else if (File.Exists(Application.StartupPath + "\\Data\\boot"))
    {
      if (!str.Equals(executablePath))
        this.ucAbout1.Button1_Set(false);
      else
        this.ucAbout1.Button1_Set(true);
    }
    else
    {
      subKey.SetValue("TRCC", (object) executablePath);
      this.ucAbout1.Button1_Set(true);
      File.Create(Application.StartupPath + "\\Data\\boot");
    }
    subKey.Close();
    localMachine.Close();
  }

  private void KaijiQidong()
  {
    if (File.Exists(Application.StartupPath + "\\Data\\boot"))
    {
      if (!this.IsTaskSetAutoStart("TRCCAppStartup"))
        this.ucAbout1.Button1_Set(false);
      else
        this.ucAbout1.Button1_Set(true);
    }
    else
    {
      this.TaskSetAutoCreate("TRCCAppStartup");
      this.ucAbout1.Button1_Set(true);
      File.Create(Application.StartupPath + "\\Data\\boot");
      try
      {
        RegistryKey localMachine = Registry.LocalMachine;
        RegistryKey subKey = localMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
        if ((string) subKey.GetValue("TRCC") != null)
          subKey.SetValue("TRCC", (object) "");
        subKey.Close();
        localMachine.Close();
      }
      catch
      {
      }
    }
  }

  private void KaijiQidongSetOld(bool bl)
  {
    string executablePath = Application.ExecutablePath;
    RegistryKey localMachine = Registry.LocalMachine;
    RegistryKey subKey = localMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
    if ((string) subKey.GetValue("TRCC") == null)
    {
      subKey.SetValue("TRCC", (object) executablePath);
      this.ucAbout1.Button1_Set(true);
    }
    else if (bl)
      subKey.SetValue("TRCC", (object) executablePath);
    else
      subKey.SetValue("TRCC", (object) "");
    subKey.Close();
    localMachine.Close();
  }

  private void KaijiQidongSet(bool bl)
  {
    if (bl)
      this.TaskSetAutoCreate("TRCCAppStartup");
    else
      this.TaskSetAutoDelete("TRCCAppStartup");
  }

  private void GengGaiRegedit()
  {
    RegistryKey localMachine = Registry.LocalMachine;
    RegistryKey subKey = localMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
    if ((int) subKey.GetValue("EnableLUA") != 0)
      subKey.SetValue("EnableLUA", (object) 0);
    subKey.Close();
    localMachine.Close();
  }

  private void InitializeForm()
  {
    this.ucDevice1.delegateUcDevice = new UCDevice.delegateUCDevice(this.DelegateUCDevice);
    this.ucAbout1.ucAbout = new UCAbout.delegateUCAbout(this.DelegateUCAbout);
    byte[] b = new byte[6]
    {
      (byte) 218,
      (byte) 219,
      (byte) 220,
      (byte) 221,
      !this.ucAbout1.isReadHDD ? (byte) 1 : (byte) 0,
      (byte) (Convert.ToInt32(this.ucAbout1.textBoxTimer.Text) - 1)
    };
    Form1.formSystemInfo = new FormSystemInfo();
    Form1.formSystemInfo.ucSystemInfo1.WriteShareMemory(1, b, b.Length);
    Form1.formSystemInfo.ThreadStart();
    Form1.formSystemInfo.Show();
    Thread.Sleep(1);
    Form1.formSystemInfo.Hide();
    Form1.formSystemInfo.upDateInfo = new FormSystemInfo.delegate_SystemInfo(this.UpSystemInfo);
    this.ucAbout1.UCAboutInit();
    Form1.ucSystemInfoOptions1 = new UCSystemInfoOptions();
    Form1.ucSystemInfoOptions1.Location = new Point(190, 98);
    this.Controls.Add((Control) Form1.ucSystemInfoOptions1);
    Form1.ucSystemInfoOptions1.Show();
  }

  private void CheckDirectoryExist()
  {
    if (Directory.Exists(Application.StartupPath + "\\Data"))
      return;
    Directory.CreateDirectory(Application.StartupPath + "\\Data");
  }

  public Form1()
  {
    this.InitializeComponent();
    this.ClearButtonBouns();
    this.KaijiQidong();
    this.CheckDirectoryExist();
    this.InitMemorySize();
    this.WriteShareMemory(0, new byte[4], 4);
    this.InitMemorySizeRGB();
    this.WriteShareMemoryRGB(0, new byte[4], 4);
    this.InitializeForm();
    this.formDeviceArray = new ArrayList();
    this.formCZTVArray = new ArrayList();
    this.m_timer = new System.Windows.Forms.Timer();
    this.m_timer.Tick += new EventHandler(this.Timer_event);
    this.m_timer.Enabled = true;
    this.m_timer.Interval = 15;
    this.m_timer.Stop();
    try
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Contains("USBLCD"))
          process.Kill();
      }
    }
    catch (Exception ex)
    {
    }
    Form1.formStart = new FormStart();
    Form1.formStart.Show();
    Thread.Sleep(1);
    Form1.formStart.Hide();
    this.ucDevice1.Scan_UsbHid();
    this.DelegateUCAbout(32 /*0x20*/, (object) Form1.Language, (object) null);
    this.m_timer.Start();
    SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(this.OnPowerModeChanged);
  }

  private void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
  {
    switch (e.Mode)
    {
      case PowerModes.Resume:
        this.myPowerMode = true;
        break;
      case PowerModes.Suspend:
        try
        {
          foreach (Process process in Process.GetProcesses())
          {
            if (process.ProcessName.Contains("USBLCD"))
              process.Kill();
          }
        }
        catch (Exception ex)
        {
        }
        this.myPowerMode = false;
        this.ResetAllDevice();
        break;
    }
  }

  protected override void WndProc(ref Message m)
  {
    try
    {
      if (m.WParam.ToInt32() == 7)
        this.ucDevice1.Scan_UsbHid();
    }
    catch
    {
    }
    base.WndProc(ref m);
  }

  private void Form1_Shown(object sender, EventArgs e)
  {
    if (!this.kaiji)
    {
      this.kaiji = true;
      this.mainNotifyIcon.Visible = true;
      this.Hide();
    }
    else
      this.mainNotifyIcon.Visible = true;
  }

  private void Form1_Activated(object sender, EventArgs e)
  {
    if (!this.mainNotifyIcon.Visible)
      this.mainNotifyIcon.Visible = true;
    if (!Form1.formSystemInfo.Visible)
      return;
    Form1.formSystemInfo.Hide();
  }

  private void mainNotifyIcon_MouseClick(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    if (this.Visible)
    {
      this.Hide();
    }
    else
    {
      this.Show();
      this.Activate();
    }
  }

  private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
  {
    for (int index = 0; index < this.formCZTVArray.Count; ++index)
    {
      FormCZTV formCztv = (FormCZTV) this.formCZTVArray[index];
      formCztv.formJP.FormScreenshot_DoubleClick((object) null, (EventArgs) null);
      if (formCztv.formScreenImage == null)
        ;
    }
    int count = this.ucDevice1.hidList1.Count;
    int num = 0;
    while (num < this.ucDevice1.hidList2.Count)
    {
      try
      {
        ((FormCZTV) ((ArrayList) this.formDeviceArray[count])[1]).formJP.FormScreenshot_DoubleClick((object) null, (EventArgs) null);
      }
      catch
      {
        return;
      }
      ++num;
      ++count;
    }
    this.Close();
    this.Dispose();
    Environment.Exit(0);
  }

  private void buttonPower_Click(object sender, EventArgs e) => this.Hide();

  private void buttonPower_MouseEnter(object sender, EventArgs e)
  {
    this.buttonPower.BackgroundImage = (Image) Resources.Alogout选中;
  }

  private void buttonPower_MouseLeave(object sender, EventArgs e)
  {
    this.buttonPower.BackgroundImage = (Image) Resources.Alogout默认;
  }

  private void Form1_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    int x = -e.X;
    int y = -e.Y;
    if (sender == null)
      x -= 180;
    this._mousePoint = new Point(x, y);
    this.isMouseDown = true;
  }

  private void Form1_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    Point mousePosition = Control.MousePosition;
    mousePosition.Offset(this._mousePoint.X, this._mousePoint.Y);
    this.Location = mousePosition;
  }

  private void Form1_MouseUp(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this.isMouseDown = false;
    if (this._mousePoint.IsEmpty)
      ;
  }

  private void Form1_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this.m_timer != null)
    {
      this.m_timer.Stop();
      this.m_timer.Dispose();
    }
    try
    {
      Thread.Sleep(100);
      this.WriteShareMemoryRGB(0, new byte[4]
      {
        (byte) 170,
        (byte) 187,
        (byte) 204,
        (byte) 221
      }, 4);
      Thread.Sleep(200);
    }
    catch
    {
    }
    try
    {
      this.CloseShareMemory();
      this.CloseShareMemoryRGB();
    }
    catch
    {
    }
    try
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Contains("USBLCD"))
          process.Kill();
      }
    }
    catch (Exception ex)
    {
    }
    try
    {
      this.ucDevice1.UCDeviceClose();
      Form1.formSystemInfo.FormSystemInfoClose();
    }
    catch
    {
    }
  }

  private void Timer_Form_event()
  {
    ++this.timerCount;
    if (this.timerCount >= 10)
    {
      this.timerCount = 0;
      for (int index = 0; index < this.ucDevice1.hidList1.Count; ++index)
      {
        try
        {
          ((FormLED) ((ArrayList) this.formDeviceArray[index])[1]).MyTimer_Event();
        }
        catch
        {
          return;
        }
      }
    }
    int count = this.ucDevice1.hidList1.Count;
    int num = 0;
    while (num < this.ucDevice1.hidList2.Count)
    {
      try
      {
        ((FormCZTV) ((ArrayList) this.formDeviceArray[count])[1]).Timer_event();
      }
      catch
      {
        break;
      }
      ++num;
      ++count;
    }
  }

  private void Timer_One_LCD_event()
  {
    if (this.myPowerMode)
    {
      ++this.oneTimerCount;
      if (this.oneTimerCount < 128 /*0x80*/)
        return;
      this.oneTimerCount = 0;
      bool flag1 = false;
      bool flag2 = false;
      try
      {
        foreach (Process process in Process.GetProcesses())
        {
          if (process.ProcessName.Equals("USBLCD"))
            flag1 = true;
          if (process.ProcessName.Equals("USBLCDNEW"))
            flag2 = true;
        }
      }
      catch (Exception ex)
      {
      }
      if (!flag1)
      {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "USBLCD.exe";
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
      if (!flag2)
      {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "USBLCDNEW.exe";
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
    }
    else
      this.oneTimerCount = 0;
  }

  private void Timer_RGB_LCD_event()
  {
    if (this.formCZTVArray.Count > 0)
    {
      for (int index = 0; index < this.formCZTVArray.Count; ++index)
        ((FormCZTV) this.formCZTVArray[index]).Timer_event();
    }
    if (this.ucDevice1.timerStart)
      return;
    ++this.timerCountRGB;
    if (this.timerCountRGB < 64 /*0x40*/)
      return;
    this.timerCountRGB = 0;
    if (this.formCZTVRgbArrayCount < 10)
    {
      this.ReadShareMemoryRGB(this.formCZTVRgbArrayCount * 2, 100);
      if (this.shareMemoryValRGB[6] == (byte) 220 && this.shareMemoryValRGB[2] == (byte) 72 && (this.shareMemoryValRGB[0] == (byte) 0 && this.shareMemoryValRGB[7] != (byte) 85 || this.shareMemoryValRGB[0] == (byte) 1 || this.shareMemoryValRGB[0] >= (byte) 4 && this.shareMemoryValRGB[0] <= (byte) 100))
      {
        this.m_timer.Stop();
        this.buttonPower.Hide();
        this.buttonHelp.Hide();
        this.buttonNet60.Hide();
        Form1.ucSystemInfoOptions1.Hide();
        string name;
        try
        {
          name = Encoding.UTF8.GetString(this.shareMemoryValRGB, 9, (int) this.shareMemoryValRGB[8]);
        }
        catch
        {
          name = "";
        }
        FormCZTV.ClearMemoryMy();
        FormCZTV formCztv = new FormCZTV();
        formCztv.TopLevel = false;
        this.Controls.Add((Control) formCztv);
        formCztv.delegateForm = new FormCZTV.delegateFormCZTV(this.DelegateFormCZTV);
        if (this.formCZTVRgbArrayCount == 0 && this.formCZTVSpiArrayCount == 0)
        {
          formCztv.Show();
          this.ucDevice1.button1.BackgroundImage = (Image) Resources.A1传感器;
          this.ucDevice1.buttonSetting.BackgroundImage = (Image) Resources.A1关于;
        }
        formCztv.FormCZTVInit(72, 2, this.formCZTVRgbArrayCount, pm: (int) this.shareMemoryValRGB[4], name: name, pmSub: (int) this.shareMemoryValRGB[1]);
        this.formCZTVArray.Add((object) formCztv);
        this.ucDevice1.RGB_ADD_Device(this.shareMemoryValRGB[4], this.shareMemoryValRGB[1]);
        ++this.formCZTVRgbArrayCount;
        this.m_timer.Start();
        return;
      }
      if (this.shareMemoryValRGB[6] == (byte) 221 && this.shareMemoryValRGB[5] == (byte) 220 && this.shareMemoryValRGB[7] == (byte) 220)
      {
        this.m_timer.Stop();
        this.buttonPower.Hide();
        this.buttonHelp.Hide();
        this.buttonNet60.Hide();
        Form1.ucSystemInfoOptions1.Hide();
        string name;
        try
        {
          name = Encoding.UTF8.GetString(this.shareMemoryValRGB, 9, (int) this.shareMemoryValRGB[8]);
        }
        catch
        {
          name = "";
        }
        FormCZTV.ClearMemoryMy();
        FormCZTV formCztv = new FormCZTV();
        formCztv.TopLevel = false;
        this.Controls.Add((Control) formCztv);
        formCztv.delegateForm = new FormCZTV.delegateFormCZTV(this.DelegateFormCZTV);
        if (this.formCZTVRgbArrayCount == 0 && this.formCZTVSpiArrayCount == 0)
        {
          formCztv.Show();
          this.ucDevice1.button1.BackgroundImage = (Image) Resources.A1传感器;
          this.ucDevice1.buttonSetting.BackgroundImage = (Image) Resources.A1关于;
        }
        formCztv.FormCZTVInit((int) this.shareMemoryValRGB[0], 10, this.formCZTVRgbArrayCount, name: name);
        this.formCZTVArray.Add((object) formCztv);
        this.ucDevice1.RGB_ADD_Device(this.shareMemoryValRGB[0]);
        ++this.formCZTVRgbArrayCount;
        this.m_timer.Start();
        return;
      }
      if (this.shareMemoryValRGB[6] == (byte) 220 && this.shareMemoryValRGB[2] == (byte) 54)
      {
        this.m_timer.Stop();
        this.buttonPower.Hide();
        this.buttonHelp.Hide();
        this.buttonNet60.Hide();
        Form1.ucSystemInfoOptions1.Hide();
        string name;
        try
        {
          name = Encoding.UTF8.GetString(this.shareMemoryValRGB, 9, (int) this.shareMemoryValRGB[8]);
        }
        catch
        {
          name = "";
        }
        FormCZTV.ClearMemoryMy();
        FormCZTV formCztv = new FormCZTV();
        formCztv.TopLevel = false;
        this.Controls.Add((Control) formCztv);
        formCztv.delegateForm = new FormCZTV.delegateFormCZTV(this.DelegateFormCZTV);
        if (this.formCZTVRgbArrayCount == 0 && this.formCZTVSpiArrayCount == 0)
        {
          formCztv.Show();
          this.ucDevice1.button1.BackgroundImage = (Image) Resources.A1传感器;
          this.ucDevice1.buttonSetting.BackgroundImage = (Image) Resources.A1关于;
        }
        formCztv.FormCZTVInit((int) this.shareMemoryValRGB[1], 3, this.formCZTVRgbArrayCount, pm: 100, name: name, pmSub: (int) this.shareMemoryValRGB[0]);
        this.formCZTVArray.Add((object) formCztv);
        this.ucDevice1.RGB_ADD_Device(this.shareMemoryValRGB[1], this.shareMemoryValRGB[0]);
        ++this.formCZTVRgbArrayCount;
        this.m_timer.Start();
        return;
      }
    }
    if (this.formCZTVSpiArrayCount >= 1)
      return;
    this.ReadShareMemory(this.formCZTVSpiArrayCount * 4);
    if (this.shareMemoryVal[153598] != (byte) 220)
      return;
    this.m_timer.Stop();
    this.buttonPower.Hide();
    this.buttonHelp.Hide();
    this.buttonNet60.Hide();
    Form1.ucSystemInfoOptions1.Hide();
    FormCZTV.ClearMemoryMy();
    FormCZTV formCztv1 = new FormCZTV();
    formCztv1.TopLevel = false;
    this.Controls.Add((Control) formCztv1);
    formCztv1.delegateForm = new FormCZTV.delegateFormCZTV(this.DelegateFormCZTV);
    if (this.formCZTVRgbArrayCount == 0 && this.formCZTVSpiArrayCount == 0)
    {
      formCztv1.Show();
      this.ucDevice1.button1.BackgroundImage = (Image) Resources.A1传感器;
      this.ucDevice1.buttonSetting.BackgroundImage = (Image) Resources.A1关于;
    }
    formCztv1.FormCZTVInit((int) this.shareMemoryVal[153599], count: this.formCZTVSpiArrayCount);
    this.formCZTVArray.Add((object) formCztv1);
    this.ucDevice1.RGB_ADD_Device(this.shareMemoryVal[153599]);
    ++this.formCZTVSpiArrayCount;
    this.m_timer.Start();
  }

  private void Timer_event(object sender, EventArgs e)
  {
    this.Timer_Form_event();
    this.Timer_One_LCD_event();
    this.Timer_RGB_LCD_event();
  }

  private void DelegateFormLED(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 16 /*0x10*/:
        this.ucDevice1.SendDeviceData1((int) info, (byte[]) data, (int) data1);
        break;
      case 241:
        this.Form1_MouseDown((object) null, (MouseEventArgs) data);
        break;
      case 242:
        this.Form1_MouseMove((object) null, (MouseEventArgs) data);
        break;
      case 243:
        this.Form1_MouseUp((object) null, (MouseEventArgs) data);
        break;
      case (int) byte.MaxValue:
        this.buttonPower_Click((object) null, (EventArgs) null);
        break;
    }
  }

  private void ResetFormCZTV(FormCZTV form)
  {
    for (int index = 0; index < this.formCZTVArray.Count; ++index)
    {
      FormCZTV formCztv = (FormCZTV) this.formCZTVArray[index];
      if (formCztv != form)
      {
        formCztv.ReadFileTheme(false);
        formCztv.ChangeFileTheme();
      }
    }
    int count = this.ucDevice1.hidList1.Count;
    int num = 0;
    while (num < this.ucDevice1.hidList2.Count)
    {
      try
      {
        FormCZTV formCztv = (FormCZTV) ((ArrayList) this.formDeviceArray[count])[1];
        if (formCztv != form)
        {
          formCztv.ReadFileTheme(false);
          formCztv.ChangeFileTheme();
        }
      }
      catch
      {
        break;
      }
      ++num;
      ++count;
    }
  }

  private void DelegateFormCZTV(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 0:
        this.WriteShareMemory((int) info, (byte[]) data, (int) data1);
        break;
      case 1:
        this.WriteShareMemoryRGB((int) info, (byte[]) data, (int) data1);
        break;
      case 128 /*0x80*/:
        this.ResetFormCZTV((FormCZTV) info);
        break;
      case 241:
        this.Form1_MouseDown((object) null, (MouseEventArgs) data);
        break;
      case 242:
        this.Form1_MouseMove((object) null, (MouseEventArgs) data);
        break;
      case 243:
        this.Form1_MouseUp((object) null, (MouseEventArgs) data);
        break;
      case (int) byte.MaxValue:
        this.buttonPower_Click((object) null, (EventArgs) null);
        break;
    }
  }

  private void DelegateFormCZTVHid(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 0:
      case 1:
        int num = (int) info;
        if (num % 2 == 0)
          break;
        this.ucDevice1.SendDeviceData2((num - 1) / 2, (byte[]) data, (int) data1);
        break;
      case 128 /*0x80*/:
        this.ResetFormCZTV((FormCZTV) info);
        break;
      case 241:
        this.Form1_MouseDown((object) null, (MouseEventArgs) data);
        break;
      case 242:
        this.Form1_MouseMove((object) null, (MouseEventArgs) data);
        break;
      case 243:
        this.Form1_MouseUp((object) null, (MouseEventArgs) data);
        break;
      case (int) byte.MaxValue:
        this.buttonPower_Click((object) null, (EventArgs) null);
        break;
    }
  }

  private void HideDeviceEvent()
  {
    if (this.nowFormDevice >= this.formDeviceArray.Count)
      this.nowFormDevice = 0;
    for (int index = 0; index < this.formDeviceArray.Count; ++index)
    {
      ArrayList formDevice = (ArrayList) this.formDeviceArray[index];
      if ((int) formDevice[0] == 1)
      {
        FormLED formLed = (FormLED) formDevice[1];
        if (formLed.Visible)
          formLed.Hide();
      }
      else if ((int) formDevice[0] == 2)
      {
        FormCZTV formCztv = (FormCZTV) formDevice[1];
        if (formCztv.Visible)
          formCztv.Hide();
      }
      else if ((int) formDevice[0] == 3 || (int) formDevice[0] != 4)
        ;
    }
    if (this.nowFormDeviceRGB >= this.formCZTVArray.Count)
      this.nowFormDeviceRGB = 0;
    for (int index = 0; index < this.formCZTVArray.Count; ++index)
    {
      FormCZTV formCztv = (FormCZTV) this.formCZTVArray[index];
      if (formCztv.Visible)
        formCztv.Hide();
    }
  }

  private void HideDeviceEventOld()
  {
    if (this.nowFormDevice >= this.formDeviceArray.Count)
      this.nowFormDevice = 0;
    if (this.formDeviceArray.Count > 0)
    {
      ArrayList formDevice = (ArrayList) this.formDeviceArray[this.nowFormDevice];
      if ((int) formDevice[0] == 1)
        ((Control) formDevice[1]).Hide();
      else if ((int) formDevice[0] == 2)
        ((Control) formDevice[1]).Hide();
      else if ((int) formDevice[0] == 3 || (int) formDevice[0] != 4)
        ;
    }
    if (this.nowFormDeviceRGB >= this.formCZTVArray.Count)
      this.nowFormDeviceRGB = 0;
    if (this.formCZTVArray.Count <= 0)
      return;
    ((Control) this.formCZTVArray[this.nowFormDeviceRGB]).Hide();
  }

  private void ShowDeviceEvent(int mode, int count)
  {
    switch (mode)
    {
      case 1:
        ArrayList formDevice = (ArrayList) this.formDeviceArray[count];
        if ((int) formDevice[0] == 1)
          ((Control) formDevice[1]).Show();
        else if ((int) formDevice[0] == 2)
          ((Control) formDevice[1]).Show();
        else if ((int) formDevice[0] == 3 || (int) formDevice[0] != 4)
          ;
        this.nowFormDevice = count;
        break;
      case 2:
        ((Control) this.formCZTVArray[count]).Show();
        this.nowFormDeviceRGB = count;
        break;
    }
  }

  private void DelegateUCDevice(int cmd, object info, object data, object name)
  {
    switch (cmd)
    {
      case 0:
        int index1 = 0;
        ArrayList arrayList = (ArrayList) null;
        if ((int) info == 1)
        {
          index1 = (int) data;
          arrayList = (ArrayList) this.formDeviceArray[index1];
          FormLED formLed = (FormLED) arrayList[1];
          this.Controls.Remove((Control) formLed);
          formLed.Dispose();
          for (int index2 = 0; index2 < this.ucDevice1.hidList1.Count; ++index2)
          {
            arrayList = (ArrayList) this.formDeviceArray[index2];
            ((FormLED) arrayList[1]).myDeviceCount = index2;
          }
        }
        else if ((int) info == 2)
        {
          index1 = this.ucDevice1.hidList1.Count + (int) data;
          arrayList = (ArrayList) this.formDeviceArray[index1];
          FormCZTV formCztv = (FormCZTV) arrayList[1];
          this.Controls.Remove((Control) formCztv);
          formCztv.FormCZTVRemove();
          formCztv.Dispose();
          for (int count = this.ucDevice1.hidList1.Count; count < this.ucDevice1.hidList1.Count + this.ucDevice1.hidList2.Count; ++count)
          {
            arrayList = (ArrayList) this.formDeviceArray[count];
            ((FormCZTV) arrayList[1]).myDeviceCount = count - this.ucDevice1.hidList1.Count;
          }
        }
        else if ((int) info == 3)
        {
          index1 = this.ucDevice1.hidList1.Count + this.ucDevice1.hidList2.Count + (int) data;
          arrayList = (ArrayList) this.formDeviceArray[index1];
        }
        else if ((int) info == 4)
        {
          index1 = this.ucDevice1.hidList1.Count + this.ucDevice1.hidList2.Count + this.ucDevice1.hidList3.Count + (int) data;
          arrayList = (ArrayList) this.formDeviceArray[index1];
        }
        this.formDeviceArray.Remove((object) arrayList);
        arrayList.Clear();
        if (this.nowFormDevice == index1)
        {
          this.nowFormDevice = 0;
          if (this.formDeviceArray.Count > 0 && this.myMode == 1)
          {
            ArrayList formDevice = (ArrayList) this.formDeviceArray[0];
            if ((int) formDevice[0] == 1)
              ((Control) formDevice[1]).Show();
            else if ((int) formDevice[0] == 2)
              ((Control) formDevice[1]).Show();
            else if ((int) formDevice[0] == 3 || (int) formDevice[0] != 4)
              ;
          }
        }
        if (this.formDeviceArray.Count != 0)
          break;
        this.buttonPower.Show();
        Form1.ucSystemInfoOptions1.Show();
        break;
      case 1:
        this.buttonPower.Hide();
        this.buttonHelp.Hide();
        this.buttonNet60.Hide();
        Form1.ucSystemInfoOptions1.Hide();
        if ((int) info == 1)
        {
          FormLED formLed = new FormLED();
          formLed.TopLevel = false;
          this.Controls.Add((Control) formLed);
          formLed.delegateForm = new FormLED.delegateFormLED(this.DelegateFormLED);
          this.formDeviceArray.Insert(this.ucDevice1.hidList1.Count, (object) new ArrayList()
          {
            info,
            (object) formLed
          });
          if (this.formDeviceArray.Count == 1 && this.myMode == 1)
          {
            this.nowFormDevice = 0;
            formLed.Show();
            this.ucDevice1.button1.BackgroundImage = (Image) Resources.A1传感器;
            this.ucDevice1.buttonSetting.BackgroundImage = (Image) Resources.A1关于;
          }
          formLed.FormLEDInit((int) (byte) data, 1, this.ucDevice1.hidList1.Count, (string) name);
          break;
        }
        if ((int) info == 2)
        {
          FormCZTV.ClearMemoryMy();
          FormCZTV formCztv = new FormCZTV();
          formCztv.TopLevel = false;
          this.Controls.Add((Control) formCztv);
          formCztv.delegateForm = new FormCZTV.delegateFormCZTV(this.DelegateFormCZTVHid);
          this.formDeviceArray.Insert(this.ucDevice1.hidList1.Count + this.ucDevice1.hidList2.Count, (object) new ArrayList()
          {
            info,
            (object) formCztv
          });
          formCztv.FormCZTVInit((int) (byte) data, 3, this.ucDevice1.hidList2.Count, pm: 100, name: (string) name);
          this.buttonPower.Hide();
          this.buttonHelp.Hide();
          this.buttonNet60.Hide();
          this.ucAbout1.Hide();
          Form1.ucSystemInfoOptions1.Hide();
          this.HideDeviceEvent();
          this.ShowDeviceEvent(1, 0);
          if (this.formDeviceArray.Count != 1)
            break;
          this.ucDevice1.button1.BackgroundImage = (Image) Resources.A1传感器;
          this.ucDevice1.buttonSetting.BackgroundImage = (Image) Resources.A1关于;
          break;
        }
        if ((int) info == 3 || (int) info != 4)
          break;
        break;
      case 2:
        switch ((ushort) info)
        {
          case 1:
            ArrayList formDevice1 = (ArrayList) this.formDeviceArray[(int) ((byte[]) data)[11]];
            return;
          case 2:
            ((FormCZTV) ((ArrayList) this.formDeviceArray[this.ucDevice1.hidList1.Count + (int) ((byte[]) data)[9]])[1]).DeviceDataReceived((byte[]) data);
            return;
          case 3:
            ArrayList formDevice2 = (ArrayList) this.formDeviceArray[this.ucDevice1.hidList1.Count + this.ucDevice1.hidList2.Count + (int) ((byte[]) data)[11]];
            return;
          case 4:
            ArrayList formDevice3 = (ArrayList) this.formDeviceArray[this.ucDevice1.hidList1.Count + this.ucDevice1.hidList2.Count + this.ucDevice1.hidList3.Count + (int) ((byte[]) data)[11]];
            return;
          default:
            return;
        }
      case 240 /*0xF0*/:
        this.myMode = 0;
        this.HideDeviceEvent();
        this.buttonPower.Hide();
        this.buttonHelp.Hide();
        this.buttonNet60.Hide();
        Form1.ucSystemInfoOptions1.Hide();
        this.ucAbout1.Show();
        break;
      case 241:
        this.Form1_MouseDown(info, (MouseEventArgs) data);
        break;
      case 242:
        this.Form1_MouseMove(info, (MouseEventArgs) data);
        break;
      case 243:
        this.Form1_MouseUp(info, (MouseEventArgs) data);
        break;
      case 256 /*0x0100*/:
        this.myMode = 1;
        this.buttonPower.Hide();
        this.buttonHelp.Hide();
        this.buttonNet60.Hide();
        this.ucAbout1.Hide();
        Form1.ucSystemInfoOptions1.Hide();
        this.HideDeviceEvent();
        this.ShowDeviceEvent(1, (int) info);
        break;
      case 512 /*0x0200*/:
        this.myMode = 0;
        this.HideDeviceEvent();
        this.buttonPower.Show();
        this.buttonHelp.Show();
        this.buttonNet60.Show();
        Form1.ucSystemInfoOptions1.Show();
        this.ucAbout1.Hide();
        break;
      case 768 /*0x0300*/:
        this.myMode = 0;
        this.buttonPower.Hide();
        this.buttonHelp.Hide();
        this.buttonNet60.Hide();
        this.ucAbout1.Hide();
        Form1.ucSystemInfoOptions1.Hide();
        this.HideDeviceEvent();
        this.ShowDeviceEvent(2, (int) info);
        break;
    }
  }

  private void DelegateUCAbout(int cmd, object info, object data)
  {
    switch (cmd)
    {
      case 0:
        this.KaijiQidongSet((bool) info);
        break;
      case 16 /*0x10*/:
        byte[] b = new byte[6]
        {
          (byte) 218,
          (byte) 219,
          (byte) 220,
          (byte) 221,
          !this.ucAbout1.isReadHDD ? (byte) 1 : (byte) 0,
          (byte) (Convert.ToInt32(this.ucAbout1.textBoxTimer.Text) - 1)
        };
        Form1.formSystemInfo.ucSystemInfo1.WriteShareMemory(1, b, b.Length);
        try
        {
          foreach (Process process in Process.GetProcesses())
          {
            if (process.ProcessName.Contains("HWINFO"))
              process.Kill();
          }
          break;
        }
        catch (Exception ex)
        {
          break;
        }
      case 32 /*0x20*/:
        Form1.Language = (int) info;
        switch (Form1.Language)
        {
          case 0:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P1系统信息en;
            this.contextMenuStrip1.Items[0].Text = "Exit";
            break;
          case 1:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P0系统信息;
            this.contextMenuStrip1.Items[0].Text = "退出";
            break;
          case 2:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P1系统信息tc;
            this.contextMenuStrip1.Items[0].Text = "退出";
            break;
          case 3:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P0系统信息d;
            this.contextMenuStrip1.Items[0].Text = "Exit";
            break;
          case 4:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P0系统信息e;
            this.contextMenuStrip1.Items[0].Text = "Exit";
            break;
          case 5:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P0系统信息f;
            this.contextMenuStrip1.Items[0].Text = "Exit";
            break;
          case 6:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P0系统信息p;
            this.contextMenuStrip1.Items[0].Text = "Exit";
            break;
          case 7:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P0系统信息r;
            this.contextMenuStrip1.Items[0].Text = "Exit";
            break;
          case 8:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P0系统信息x;
            this.contextMenuStrip1.Items[0].Text = "Exit";
            break;
          default:
            Form1.formSystemInfo.BackgroundImage = (Image) Resources.P1系统信息en;
            this.contextMenuStrip1.Items[0].Text = "Exit";
            break;
        }
        for (int index = 0; index < this.formCZTVArray.Count; ++index)
          ((FormCZTV) this.formCZTVArray[index]).FormCZTVLanguageSet();
        for (int index = 0; index < this.ucDevice1.hidList1.Count; ++index)
        {
          try
          {
            ((FormLED) ((ArrayList) this.formDeviceArray[index])[1]).FormLEDLanguageSet();
          }
          catch
          {
          }
        }
        int num = 0;
        int count = this.ucDevice1.hidList1.Count;
        while (num < this.ucDevice1.hidList2.Count)
        {
          try
          {
            ((FormCZTV) ((ArrayList) this.formDeviceArray[count])[1]).FormCZTVLanguageSet();
          }
          catch
          {
          }
          ++num;
          ++count;
        }
        break;
      case 100:
        this.Close();
        this.Dispose();
        Environment.Exit(0);
        break;
      case 241:
        this.Form1_MouseDown((object) null, (MouseEventArgs) data);
        break;
      case 242:
        this.Form1_MouseMove((object) null, (MouseEventArgs) data);
        break;
      case 243:
        this.Form1_MouseUp((object) null, (MouseEventArgs) data);
        break;
      case (int) byte.MaxValue:
        this.buttonPower_Click((object) null, (EventArgs) null);
        break;
    }
  }

  private void UpSystemInfo(int mode, int val, string name)
  {
    switch (mode)
    {
      case 0:
        switch (val)
        {
          case 0:
            ProcessStartInfo startInfo1 = new ProcessStartInfo();
            startInfo1.FileName = "USBLCDNEW.exe";
            startInfo1.WorkingDirectory = Application.StartupPath;
            startInfo1.WindowStyle = ProcessWindowStyle.Hidden;
            try
            {
              Process.Start(startInfo1);
              return;
            }
            catch
            {
              return;
            }
          case 16 /*0x10*/:
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo2.FileName = "USBLCD.exe";
            startInfo2.WorkingDirectory = Application.StartupPath;
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            try
            {
              Process.Start(startInfo2);
            }
            catch
            {
            }
            this.ucAbout1.UpdateMyInfo();
            this.myPowerMode = true;
            return;
          case 254:
            Form1.ucSystemInfoOptions1.GetMyNameFile();
            return;
          case (int) byte.MaxValue:
            Form1.ucSystemInfoOptions1.UCSystemInfoOptionsTimer();
            return;
          default:
            return;
        }
      case 1:
        Form1.ucSystemInfoOptions1.FormSystemInfoSet(val, name);
        break;
    }
  }

  private void buttonHelp_Click(object sender, EventArgs e)
  {
    try
    {
      Process.Start(Application.StartupPath + "\\LCDHelp.pdf");
    }
    catch
    {
    }
  }

  private void buttonNet60_Click(object sender, EventArgs e)
  {
    try
    {
      Process.Start(Application.StartupPath + "\\dotnet6.exe");
    }
    catch
    {
    }
  }

  private void ResetAllDevice()
  {
    this.m_timer.Stop();
    for (int index = 0; index < this.formCZTVArray.Count; ++index)
    {
      FormCZTV formCztv = (FormCZTV) this.formCZTVArray[index];
      this.Controls.Remove((Control) formCztv);
      formCztv.FormCZTVRemove();
      formCztv.Dispose();
    }
    this.formCZTVArray.Clear();
    for (int index = 0; index < this.ucDevice1.hidList1.Count; ++index)
    {
      FormLED formLed = (FormLED) ((ArrayList) this.formDeviceArray[index])[1];
      this.Controls.Remove((Control) formLed);
      formLed.Dispose();
    }
    for (int count = this.ucDevice1.hidList1.Count; count < this.ucDevice1.hidList1.Count + this.ucDevice1.hidList2.Count; ++count)
    {
      FormCZTV formCztv = (FormCZTV) ((ArrayList) this.formDeviceArray[count])[1];
      this.Controls.Remove((Control) formCztv);
      formCztv.FormCZTVRemove();
      formCztv.Dispose();
    }
    this.formDeviceArray.Clear();
    this.formCZTVRgbArrayCount = 0;
    this.formCZTVSpiArrayCount = 0;
    this.ucDevice1.Remove_RGB_Device();
    byte[] b = new byte[8];
    Array.Clear((Array) b, 0, 8);
    this.WriteShareMemoryRGB(0, b, b.Length);
    this.WriteShareMemoryRGB(2, b, b.Length);
    this.WriteShareMemoryRGB(4, b, b.Length);
    this.WriteShareMemoryRGB(6, b, b.Length);
    this.WriteShareMemoryRGB(8, b, b.Length);
    this.WriteShareMemoryRGB(10, b, b.Length);
    this.WriteShareMemoryRGB(12, b, b.Length);
    this.WriteShareMemoryRGB(14, b, b.Length);
    this.WriteShareMemoryRGB(16 /*0x10*/, b, b.Length);
    this.WriteShareMemoryRGB(18, b, b.Length);
    Array.Clear((Array) this.shareMemoryVal, 0, this.shareMemoryVal.Length);
    this.WriteShareMemory(0, this.shareMemoryVal);
    this.m_timer.Start();
  }

  public void ResetAllDeviceButton()
  {
    this.m_timer.Stop();
    Thread.Sleep(100);
    this.WriteShareMemoryRGB(0, new byte[4]
    {
      (byte) 170,
      (byte) 187,
      (byte) 204,
      (byte) 221
    }, 4);
    Thread.Sleep(200);
    try
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Contains("USBLCD"))
          process.Kill();
      }
    }
    catch (Exception ex)
    {
    }
    this.ResetAllDevice();
    this.ucDevice1.Scan_UsbHid();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
    this.contextMenuStrip1 = new ContextMenuStrip(this.components);
    this.退出ToolStripMenuItem = new ToolStripMenuItem();
    this.mainNotifyIcon = new NotifyIcon(this.components);
    this.buttonPower = new Button();
    this.buttonHelp = new Button();
    this.buttonNet60 = new Button();
    this.ucAbout1 = new UCAbout();
    this.ucDevice1 = new UCDevice();
    this.contextMenuStrip1.SuspendLayout();
    this.SuspendLayout();
    this.contextMenuStrip1.ImageScalingSize = new Size(24, 24);
    this.contextMenuStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.退出ToolStripMenuItem
    });
    this.contextMenuStrip1.Name = "contextMenuStrip1";
    this.contextMenuStrip1.Size = new Size(101, 26);
    this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
    this.退出ToolStripMenuItem.Size = new Size(100, 22);
    this.退出ToolStripMenuItem.Text = "退出";
    this.退出ToolStripMenuItem.Click += new EventHandler(this.退出ToolStripMenuItem_Click);
    this.mainNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
    this.mainNotifyIcon.Icon = (Icon) componentResourceManager.GetObject("mainNotifyIcon.Icon");
    this.mainNotifyIcon.Text = "TRCC";
    this.mainNotifyIcon.Visible = true;
    this.mainNotifyIcon.MouseClick += new MouseEventHandler(this.mainNotifyIcon_MouseClick);
    this.buttonPower.BackColor = System.Drawing.Color.Transparent;
    this.buttonPower.BackgroundImage = (Image) Resources.Alogout默认;
    this.buttonPower.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonPower.FlatAppearance.BorderSize = 0;
    this.buttonPower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
    this.buttonPower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
    this.buttonPower.FlatStyle = FlatStyle.Flat;
    this.buttonPower.Location = new Point(1392, 24);
    this.buttonPower.Margin = new Padding(0);
    this.buttonPower.Name = "buttonPower";
    this.buttonPower.Size = new Size(40, 40);
    this.buttonPower.TabIndex = 135;
    this.buttonPower.UseVisualStyleBackColor = false;
    this.buttonPower.Click += new EventHandler(this.buttonPower_Click);
    this.buttonPower.MouseEnter += new EventHandler(this.buttonPower_MouseEnter);
    this.buttonPower.MouseLeave += new EventHandler(this.buttonPower_MouseLeave);
    this.buttonHelp.BackColor = System.Drawing.Color.Transparent;
    this.buttonHelp.BackgroundImage = (Image) Resources.P帮助;
    this.buttonHelp.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonHelp.FlatAppearance.BorderSize = 0;
    this.buttonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
    this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
    this.buttonHelp.FlatStyle = FlatStyle.Flat;
    this.buttonHelp.Location = new Point(1342, 24);
    this.buttonHelp.Margin = new Padding(0);
    this.buttonHelp.Name = "buttonHelp";
    this.buttonHelp.Size = new Size(40, 40);
    this.buttonHelp.TabIndex = 138;
    this.buttonHelp.UseVisualStyleBackColor = false;
    this.buttonHelp.Click += new EventHandler(this.buttonHelp_Click);
    this.buttonNet60.BackColor = System.Drawing.Color.Transparent;
    this.buttonNet60.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonNet60.FlatAppearance.BorderSize = 0;
    this.buttonNet60.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
    this.buttonNet60.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
    this.buttonNet60.FlatStyle = FlatStyle.Flat;
    this.buttonNet60.Location = new Point(651, 742);
    this.buttonNet60.Margin = new Padding(0);
    this.buttonNet60.Name = "buttonNet60";
    this.buttonNet60.Size = new Size(333, 51);
    this.buttonNet60.TabIndex = 139;
    this.buttonNet60.UseVisualStyleBackColor = false;
    this.buttonNet60.Click += new EventHandler(this.buttonNet60_Click);
    this.ucAbout1.BackgroundImageLayout = ImageLayout.Zoom;
    this.ucAbout1.Location = new Point(180, 0);
    this.ucAbout1.Margin = new Padding(0);
    this.ucAbout1.Name = "ucAbout1";
    this.ucAbout1.Size = new Size(1274, 800);
    this.ucAbout1.TabIndex = 137;
    this.ucAbout1.Visible = false;
    this.ucDevice1.BackColor = System.Drawing.Color.Transparent;
    this.ucDevice1.BackgroundImage = (Image) Resources.A0硬件列表;
    this.ucDevice1.BackgroundImageLayout = ImageLayout.Zoom;
    this.ucDevice1.Location = new Point(0, 0);
    this.ucDevice1.Margin = new Padding(0);
    this.ucDevice1.Name = "ucDevice1";
    this.ucDevice1.Size = new Size(180, 800);
    this.ucDevice1.TabIndex = 136;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = System.Drawing.Color.FromArgb(35, 34, 39);
    this.BackgroundImage = (Image) Resources.A0无设备;
    this.BackgroundImageLayout = ImageLayout.None;
    this.ClientSize = new Size(1454, 800);
    this.Controls.Add((Control) this.buttonNet60);
    this.Controls.Add((Control) this.ucDevice1);
    this.Controls.Add((Control) this.buttonPower);
    this.Controls.Add((Control) this.buttonHelp);
    this.Controls.Add((Control) this.ucAbout1);
    this.DoubleBuffered = true;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Form1);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "TRCC";
    this.Activated += new EventHandler(this.Form1_Activated);
    this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
    this.Shown += new EventHandler(this.Form1_Shown);
    this.MouseDown += new MouseEventHandler(this.Form1_MouseDown);
    this.MouseMove += new MouseEventHandler(this.Form1_MouseMove);
    this.MouseUp += new MouseEventHandler(this.Form1_MouseUp);
    this.contextMenuStrip1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}

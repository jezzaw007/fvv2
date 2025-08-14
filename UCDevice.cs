// Decompiled with JetBrains decompiler
// Type: TRCC.UCDevice
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using TRCC.DCUserControl;
using TRCC.Properties;
using UsbHid;
using UsbHid.USB.Classes.Messaging;

#nullable disable
namespace TRCC;

public class UCDevice : UserControl
{
  public UCDevice.delegateUCDevice delegateUcDevice;
  public const ushort USB_BRAND_1 = 1;
  public const ushort USB_ID_0 = 0;
  public const ushort USB_ID_1 = 1;
  public const ushort USB_ID_2 = 2;
  public const ushort USB_ID_3 = 3;
  public const ushort USB_ID_4 = 4;
  public const ushort USB_ID_5 = 5;
  public const ushort USB_ID_6 = 6;
  public const ushort USB_ID_7 = 7;
  public const ushort USB_ID_8 = 8;
  public const ushort USB_ID_9 = 9;
  public const ushort USB_ID_10 = 10;
  public const ushort USB_ID1_1 = 257;
  public const byte USB_PACKED_Head = 220;
  public const byte USB_PACKED_Head1 = 221;
  public const byte USB_PACKED_ONOFF = 0;
  public const byte USB_PACKED_STATE = 1;
  public const byte USB_PACKED_GET_STATE = 2;
  public const byte USB_PACKED_AUDIO = 4;
  public const byte USB_PACKED_MOTOR = 5;
  public const byte USB_PACKED_FAN = 6;
  public const byte USB_PACKED_LED = 16 /*0x10*/;
  public const byte USB_PACKED_LCD = 48 /*0x30*/;
  private const byte LED_MODE_RGB = 1;
  private const int UserButtonY = 60;
  private const int USB_LEN0 = 64 /*0x40*/;
  private const int USB_LEN = 512 /*0x0200*/;
  private bool[] isSendUsbThread0 = new bool[10];
  private const int SendUsbBuff = 2;
  private const int SendUsbAllCount = 10;
  private ArrayList sendUsbArray = (ArrayList) null;
  private bool[] isSendUsbThread = new bool[10];
  private ArrayList hidNameList1 = (ArrayList) null;
  private ArrayList hidNameList2 = (ArrayList) null;
  private ArrayList hidNameList3 = (ArrayList) null;
  private ArrayList hidNameList4 = (ArrayList) null;
  public ArrayList hidList1 = (ArrayList) null;
  public ArrayList hidList2 = (ArrayList) null;
  public ArrayList hidList3 = (ArrayList) null;
  public ArrayList hidList4 = (ArrayList) null;
  public ArrayList rgbList = (ArrayList) null;
  private ArrayList myButtonList = (ArrayList) null;
  private UsbHidDevice device1 = (UsbHidDevice) null;
  private UsbHidDevice device2 = (UsbHidDevice) null;
  private UsbHidDevice device3 = (UsbHidDevice) null;
  private UsbHidDevice device4 = (UsbHidDevice) null;
  private int scanCount = 0;
  public int nowUserButton = 0;
  private bool workingcon = false;
  private bool workingDis = false;
  private bool isTimerIN = false;
  private System.Timers.Timer m_timer = (System.Timers.Timer) null;
  private int timerStartCount = 0;
  private int timerStartCountVal = 10;
  private IContainer components = (IContainer) null;
  public Button buttonSetting;
  public Button button1;

  public bool timerStart { get; private set; } = false;

  public UCDevice()
  {
    this.InitializeComponent();
    this.buttonSetting.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.hidNameList1 = new ArrayList();
    this.hidNameList2 = new ArrayList();
    this.hidNameList3 = new ArrayList();
    this.hidNameList4 = new ArrayList();
    this.hidList1 = new ArrayList();
    this.hidList2 = new ArrayList();
    this.hidList3 = new ArrayList();
    this.hidList4 = new ArrayList();
    this.rgbList = new ArrayList();
    this.myButtonList = new ArrayList();
    this.sendUsbArray = new ArrayList();
    for (int index = 0; index < 10; ++index)
      this.sendUsbArray.Add((object) new ArrayList());
    this.m_timer = new System.Timers.Timer(100.0);
    this.m_timer.Elapsed += new ElapsedEventHandler(this.Timer_event);
    this.m_timer.AutoReset = true;
    this.m_timer.Start();
  }

  public void UCDeviceClose()
  {
    this.m_timer.Stop();
    this.m_timer.Dispose();
  }

  public void Scan_UsbHid(bool bl = true)
  {
    this.scanCount = 0;
    this.timerStartCount = 0;
    this.timerStartCountVal = 20;
    this.timerStart = bl;
  }

  private void Timer_event(object sender, ElapsedEventArgs e)
  {
    if (!this.timerStart || this.isTimerIN)
      return;
    this.isTimerIN = true;
    ++this.timerStartCount;
    if (this.timerStartCount >= this.timerStartCountVal)
    {
      this.timerStartCount = 0;
      ++this.scanCount;
      if (this.scanCount == 1)
        this.timerStartCountVal = 2;
      else if (this.scanCount == 2)
        this.timerStartCountVal = 30;
      if (this.scanCount >= 3)
      {
        this.Scan_UsbHid(false);
        if (this.device1 != null)
        {
          this.device1.Dispose();
          this.device1 = (UsbHidDevice) null;
        }
        if (this.device2 != null)
        {
          this.device2.Dispose();
          this.device2 = (UsbHidDevice) null;
        }
        if (this.device3 != null)
        {
          this.device3.Dispose();
          this.device3 = (UsbHidDevice) null;
        }
        if (this.device4 != null)
        {
          this.device4.Dispose();
          this.device4 = (UsbHidDevice) null;
        }
        this.workingcon = false;
        this.workingDis = false;
      }
      else
      {
        if (this.device1 == null)
        {
          this.device1 = new UsbHidDevice(1046, 32769, this.hidNameList1, 64 /*0x40*/);
          this.device1.OnConnected += new UsbHidDevice.ConnectedDelegate(this.DeviceOnConnected1);
          this.device1.OnDisConnected += new UsbHidDevice.DisConnectedDelegate(this.DeviceOnDisConnected1);
          this.device1.DataReceived += new UsbHidDevice.DataReceivedDelegate(this.DeviceDataReceived1);
        }
        else if (!this.device1.IsDeviceConnected)
          this.device1.Connect();
        if (this.device2 == null)
        {
          this.device2 = new UsbHidDevice(1046, 21250, this.hidNameList2);
          this.device2.OnConnected += new UsbHidDevice.ConnectedDelegate(this.DeviceOnConnected2);
          this.device2.OnDisConnected += new UsbHidDevice.DisConnectedDelegate(this.DeviceOnDisConnected2);
          this.device2.DataReceived += new UsbHidDevice.DataReceivedDelegate(this.DeviceDataReceived2);
        }
        else if (!this.device2.IsDeviceConnected)
          this.device2.Connect();
        if (this.device3 == null)
        {
          this.device3 = new UsbHidDevice(1048, 21251, this.hidNameList3, 64 /*0x40*/);
          this.device3.OnConnected += new UsbHidDevice.ConnectedDelegate(this.DeviceOnConnected3);
          this.device3.OnDisConnected += new UsbHidDevice.DisConnectedDelegate(this.DeviceOnDisConnected3);
          this.device3.DataReceived += new UsbHidDevice.DataReceivedDelegate(this.DeviceDataReceived3);
        }
        else if (!this.device3.IsDeviceConnected)
          this.device3.Connect();
        if (this.device4 == null)
        {
          this.device4 = new UsbHidDevice(1048, 21252, this.hidNameList4);
          this.device4.OnConnected += new UsbHidDevice.ConnectedDelegate(this.DeviceOnConnected4);
          this.device4.OnDisConnected += new UsbHidDevice.DisConnectedDelegate(this.DeviceOnDisConnected4);
          this.device4.DataReceived += new UsbHidDevice.DataReceivedDelegate(this.DeviceDataReceived4);
        }
        else if (!this.device4.IsDeviceConnected)
          this.device4.Connect();
      }
    }
    this.isTimerIN = false;
  }

  private void userButton_Click(object sender, EventArgs e)
  {
    for (int index = 0; index < this.myButtonList.Count; ++index)
    {
      UCButton ucButton1 = (UCButton) ((ArrayList) this.myButtonList[index])[1];
      UCButton ucButton2 = (UCButton) sender;
      if (ucButton1 == ucButton2)
      {
        this.nowUserButton = index;
        ucButton1.BackgroundImage = (Image) ucButton1.bitmap2;
      }
      else
        ucButton1.BackgroundImage = (Image) ucButton1.bitmap1;
    }
    if (((UCButton) sender).myType == 257)
    {
      int num = this.hidList1.Count + this.hidList2.Count + this.hidList3.Count + this.hidList4.Count;
      UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
      if (delegateUcDevice != null)
        delegateUcDevice(768 /*0x0300*/, (object) (this.nowUserButton - num));
    }
    else
    {
      UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
      if (delegateUcDevice != null)
        delegateUcDevice(256 /*0x0100*/, (object) this.nowUserButton);
    }
    this.button1.BackgroundImage = (Image) Resources.A1传感器;
    this.buttonSetting.BackgroundImage = (Image) Resources.A1关于;
  }

  private void UserButtonArrange()
  {
    for (int index = 0; index < this.myButtonList.Count; ++index)
      ((Control) ((ArrayList) this.myButtonList[index])[1]).Location = new Point(25, 160 /*0xA0*/ + index * 60);
  }

  private void ADDUserButton(int ID, byte pm = 50, byte sub = 0)
  {
    UCButton ucButton = new UCButton();
    ucButton.BackColor = Color.Transparent;
    ucButton.BackgroundImage = (Image) null;
    ucButton.BackgroundImageLayout = ImageLayout.Stretch;
    ucButton.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    ucButton.Location = new Point(25, 160 /*0xA0*/);
    ucButton.Margin = new Padding(0);
    ucButton.Name = "userButton" + this.myButtonList.Count.ToString();
    ucButton.Size = new Size(140, 50);
    this.Controls.Add((Control) ucButton);
    ucButton.Click += new EventHandler(this.userButton_Click);
    ucButton.myType = ID;
    switch (ID)
    {
      case 1:
        switch (pm)
        {
          case 1:
            ucButton.BackgroundImage = (Image) Resources.A1FROZEN_HORIZON_PRO;
            ucButton.bitmap1 = Resources.A1FROZEN_HORIZON_PRO;
            ucButton.bitmap2 = Resources.A1FROZEN_HORIZON_PROa;
            break;
          case 2:
            ucButton.BackgroundImage = (Image) Resources.A1FROZEN_MAGIC_PRO;
            ucButton.bitmap1 = Resources.A1FROZEN_MAGIC_PRO;
            ucButton.bitmap2 = Resources.A1FROZEN_MAGIC_PROa;
            break;
          case 3:
            ucButton.BackgroundImage = (Image) Resources.A1AX120_DIGITAL;
            ucButton.bitmap1 = Resources.A1AX120_DIGITAL;
            ucButton.bitmap2 = Resources.A1AX120_DIGITALa;
            break;
          case 16 /*0x10*/:
            ucButton.BackgroundImage = (Image) Resources.A1PA120_DIGITAL;
            ucButton.bitmap1 = Resources.A1PA120_DIGITAL;
            ucButton.bitmap2 = Resources.A1PA120_DIGITALa;
            break;
          case 23:
            ucButton.BackgroundImage = (Image) Resources.A1RK120_DIGITAL;
            ucButton.bitmap1 = Resources.A1RK120_DIGITAL;
            ucButton.bitmap2 = Resources.A1RK120_DIGITALa;
            break;
          case 32 /*0x20*/:
            ucButton.BackgroundImage = (Image) Resources.A1AK120_Digital;
            ucButton.bitmap1 = Resources.A1AK120_Digital;
            ucButton.bitmap2 = Resources.A1AK120_Digitala;
            break;
          case 48 /*0x30*/:
            ucButton.BackgroundImage = (Image) Resources.A1LF8;
            ucButton.bitmap1 = Resources.A1LF8;
            ucButton.bitmap2 = Resources.A1LF8a;
            break;
          case 49:
            ucButton.BackgroundImage = (Image) Resources.A1LF10;
            ucButton.bitmap1 = Resources.A1LF10;
            ucButton.bitmap2 = Resources.A1LF10a;
            break;
          case 80 /*0x50*/:
            ucButton.BackgroundImage = (Image) Resources.A1LF12;
            ucButton.bitmap1 = Resources.A1LF12;
            ucButton.bitmap2 = Resources.A1LF12a;
            break;
          case 96 /*0x60*/:
            ucButton.BackgroundImage = (Image) Resources.A1LF10;
            ucButton.bitmap1 = Resources.A1LF10;
            ucButton.bitmap2 = Resources.A1LF10a;
            break;
          case 112 /*0x70*/:
            ucButton.BackgroundImage = (Image) Resources.A1LC2;
            ucButton.bitmap1 = Resources.A1LC2;
            ucButton.bitmap2 = Resources.A1LC2a;
            break;
          case 128 /*0x80*/:
            ucButton.BackgroundImage = (Image) Resources.A1LC1;
            ucButton.bitmap1 = Resources.A1LC1;
            ucButton.bitmap2 = Resources.A1LC1a;
            break;
          case 129:
            ucButton.BackgroundImage = (Image) Resources.A1LF11;
            ucButton.bitmap1 = Resources.A1LF11;
            ucButton.bitmap2 = Resources.A1LF11a;
            break;
          case 144 /*0x90*/:
            ucButton.BackgroundImage = (Image) Resources.A1LF15;
            ucButton.bitmap1 = Resources.A1LF15;
            ucButton.bitmap2 = Resources.A1LF15a;
            break;
          case 160 /*0xA0*/:
            ucButton.BackgroundImage = (Image) Resources.A1LF13;
            ucButton.bitmap1 = Resources.A1LF13;
            ucButton.bitmap2 = Resources.A1LF13a;
            break;
          case 208 /*0xD0*/:
            ucButton.BackgroundImage = (Image) Resources.A1CZ1;
            ucButton.bitmap1 = Resources.A1CZ1;
            ucButton.bitmap2 = Resources.A1CZ1a;
            break;
          default:
            ucButton.BackgroundImage = (Image) Resources.A1KVMALEDC6;
            ucButton.bitmap1 = Resources.A1KVMALEDC6;
            ucButton.bitmap2 = Resources.A1KVMALEDC6a;
            break;
        }
        break;
      case 2:
        switch (pm)
        {
          case 36:
            ucButton.BackgroundImage = (Image) Resources.A1AS120_VISION;
            ucButton.bitmap1 = Resources.A1AS120_VISION;
            ucButton.bitmap2 = Resources.A1AS120_VISIONa;
            break;
          case 50:
            ucButton.BackgroundImage = (Image) Resources.A1FROZEN_WARFRAME;
            ucButton.bitmap1 = Resources.A1FROZEN_WARFRAME;
            ucButton.bitmap2 = Resources.A1FROZEN_WARFRAMEa;
            break;
          case 51:
            ucButton.BackgroundImage = (Image) Resources.A1FROZEN_WARFRAME;
            ucButton.bitmap1 = Resources.A1FROZEN_WARFRAME;
            ucButton.bitmap2 = Resources.A1FROZEN_WARFRAMEa;
            break;
          case 52:
            ucButton.BackgroundImage = (Image) Resources.A1BA120_VISION;
            ucButton.bitmap1 = Resources.A1BA120_VISION;
            ucButton.bitmap2 = Resources.A1BA120_VISIONa;
            break;
          case 53:
            ucButton.BackgroundImage = (Image) Resources.A1BA120_VISION;
            ucButton.bitmap1 = Resources.A1BA120_VISION;
            ucButton.bitmap2 = Resources.A1BA120_VISIONa;
            break;
          case 54:
            ucButton.BackgroundImage = (Image) Resources.A1LC5;
            ucButton.bitmap1 = Resources.A1LC5;
            ucButton.bitmap2 = Resources.A1LC5a;
            break;
          case 58:
            if (sub == (byte) 0)
            {
              ucButton.BackgroundImage = (Image) Resources.A1FROZEN_WARFRAME_SE;
              ucButton.bitmap1 = Resources.A1FROZEN_WARFRAME_SE;
              ucButton.bitmap2 = Resources.A1FROZEN_WARFRAME_SEa;
              break;
            }
            ucButton.BackgroundImage = (Image) Resources.A1LM26;
            ucButton.bitmap1 = Resources.A1LM26;
            ucButton.bitmap2 = Resources.A1LM26a;
            break;
          case 100:
            ucButton.BackgroundImage = (Image) Resources.A1FROZEN_WARFRAME_PRO;
            ucButton.bitmap1 = Resources.A1FROZEN_WARFRAME_PRO;
            ucButton.bitmap2 = Resources.A1FROZEN_WARFRAME_PROa;
            break;
          case 101:
            ucButton.BackgroundImage = (Image) Resources.A1ELITE_VISION;
            ucButton.bitmap1 = Resources.A1ELITE_VISION;
            ucButton.bitmap2 = Resources.A1ELITE_VISIONa;
            break;
          case 128 /*0x80*/:
            ucButton.BackgroundImage = (Image) Resources.A1LM24;
            ucButton.bitmap1 = Resources.A1LM24;
            ucButton.bitmap2 = Resources.A1LM24a;
            break;
          default:
            ucButton.BackgroundImage = (Image) Resources.A1CZTV;
            ucButton.bitmap1 = Resources.A1CZTV;
            ucButton.bitmap2 = Resources.A1CZTVa;
            break;
        }
        break;
      case 3:
        ucButton.BackgroundImage = (Image) Resources.A1CZTV;
        ucButton.bitmap1 = Resources.A1CZTV;
        ucButton.bitmap2 = Resources.A1CZTVa;
        break;
      case 4:
        ucButton.BackgroundImage = (Image) Resources.A1CZTV;
        ucButton.bitmap1 = Resources.A1CZTV;
        ucButton.bitmap2 = Resources.A1CZTVa;
        break;
      case 257:
        switch (pm)
        {
          case 1:
            if (sub <= (byte) 1)
            {
              ucButton.BackgroundImage = (Image) Resources.A1GRAND_VISION;
              ucButton.bitmap1 = Resources.A1GRAND_VISION;
              ucButton.bitmap2 = Resources.A1GRAND_VISIONa;
              break;
            }
            if (sub == (byte) 48 /*0x30*/)
            {
              ucButton.BackgroundImage = (Image) Resources.A1LM22;
              ucButton.bitmap1 = Resources.A1LM22;
              ucButton.bitmap2 = Resources.A1LM22a;
              break;
            }
            if (sub == (byte) 49)
            {
              ucButton.BackgroundImage = (Image) Resources.A1LF14;
              ucButton.bitmap1 = Resources.A1LF14;
              ucButton.bitmap2 = Resources.A1LF14a;
              break;
            }
            break;
          case 3:
            ucButton.BackgroundImage = (Image) Resources.A1CORE_VISION;
            ucButton.bitmap1 = Resources.A1CORE_VISION;
            ucButton.bitmap2 = Resources.A1CORE_VISIONa;
            break;
          case 4:
            switch (sub)
            {
              case 1:
                ucButton.BackgroundImage = (Image) Resources.A1HYPER_VISION;
                ucButton.bitmap1 = Resources.A1HYPER_VISION;
                ucButton.bitmap2 = Resources.A1HYPER_VISIONa;
                break;
              case 2:
                ucButton.BackgroundImage = (Image) Resources.A1RP130_VISION;
                ucButton.bitmap1 = Resources.A1RP130_VISION;
                ucButton.bitmap2 = Resources.A1RP130_VISIONa;
                break;
              case 3:
                ucButton.BackgroundImage = (Image) Resources.A1LM16SE;
                ucButton.bitmap1 = Resources.A1LM16SE;
                ucButton.bitmap2 = Resources.A1LM16SEa;
                break;
              case 4:
                ucButton.BackgroundImage = (Image) Resources.A1LF10V;
                ucButton.bitmap1 = Resources.A1LF10V;
                ucButton.bitmap2 = Resources.A1LF10Va;
                break;
              case 5:
                ucButton.BackgroundImage = (Image) Resources.A1LM19SE;
                ucButton.bitmap1 = Resources.A1LM19SE;
                ucButton.bitmap2 = Resources.A1LM19SEa;
                break;
            }
            break;
          case 5:
            ucButton.BackgroundImage = (Image) Resources.A1Mjolnir_VISION;
            ucButton.bitmap1 = Resources.A1Mjolnir_VISION;
            ucButton.bitmap2 = Resources.A1Mjolnir_VISIONa;
            break;
          case 6:
            switch (sub)
            {
              case 1:
                ucButton.BackgroundImage = (Image) Resources.FROZEN_WARFRAME_Ultra;
                ucButton.bitmap1 = Resources.FROZEN_WARFRAME_Ultra;
                ucButton.bitmap2 = Resources.FROZEN_WARFRAME_Ultraa;
                break;
              case 2:
                ucButton.BackgroundImage = (Image) Resources.A1FROZEN_VISION_V2;
                ucButton.bitmap1 = Resources.A1FROZEN_VISION_V2;
                ucButton.bitmap2 = Resources.A1FROZEN_VISION_V2a;
                break;
            }
            break;
          case 7:
            switch (sub)
            {
              case 1:
                ucButton.BackgroundImage = (Image) Resources.A1Stream_Vision;
                ucButton.bitmap1 = Resources.A1Stream_Vision;
                ucButton.bitmap2 = Resources.A1Stream_Visiona;
                break;
              case 2:
                ucButton.BackgroundImage = (Image) Resources.A1Mjolnir_VISION_PRO;
                ucButton.bitmap1 = Resources.A1Mjolnir_VISION_PRO;
                ucButton.bitmap2 = Resources.A1Mjolnir_VISION_PROa;
                break;
            }
            break;
          case 9:
            ucButton.BackgroundImage = (Image) Resources.A1LC2JD;
            ucButton.bitmap1 = Resources.A1LC2JD;
            ucButton.bitmap2 = Resources.A1LC2JDa;
            break;
          case 10:
            switch (sub)
            {
              case 5:
                ucButton.BackgroundImage = (Image) Resources.A1LF16;
                ucButton.bitmap1 = Resources.A1LF16;
                ucButton.bitmap2 = Resources.A1LF16a;
                break;
              case 6:
                ucButton.BackgroundImage = (Image) Resources.A1LF18;
                ucButton.bitmap1 = Resources.A1LF18;
                ucButton.bitmap2 = Resources.A1LF18a;
                break;
              default:
                ucButton.BackgroundImage = (Image) Resources.A1LC3;
                ucButton.bitmap1 = Resources.A1LC3;
                ucButton.bitmap2 = Resources.A1LC3a;
                break;
            }
            break;
          case 11:
            ucButton.BackgroundImage = (Image) Resources.A1LF19;
            ucButton.bitmap1 = Resources.A1LF19;
            ucButton.bitmap2 = Resources.A1LF19a;
            break;
          case 12:
            ucButton.BackgroundImage = (Image) Resources.A1LF167;
            ucButton.bitmap1 = Resources.A1LF167;
            ucButton.bitmap2 = Resources.A1LF17a;
            break;
          case 13:
            ucButton.BackgroundImage = (Image) Resources.A1PC1;
            ucButton.bitmap1 = Resources.A1PC1;
            ucButton.bitmap2 = Resources.A1PC1a;
            break;
          case 32 /*0x20*/:
            switch (sub)
            {
              case 0:
                ucButton.BackgroundImage = (Image) Resources.A1ELITE_VISION;
                ucButton.bitmap1 = Resources.A1ELITE_VISION;
                ucButton.bitmap2 = Resources.A1ELITE_VISIONa;
                break;
              case 1:
                ucButton.BackgroundImage = (Image) Resources.A1FROZEN_WARFRAME_PRO;
                ucButton.bitmap1 = Resources.A1FROZEN_WARFRAME_PRO;
                ucButton.bitmap2 = Resources.A1FROZEN_WARFRAME_PROa;
                break;
            }
            break;
          case 50:
            ucButton.BackgroundImage = (Image) Resources.A1FROZEN_WARFRAME;
            ucButton.bitmap1 = Resources.A1FROZEN_WARFRAME;
            ucButton.bitmap2 = Resources.A1FROZEN_WARFRAMEa;
            break;
          case 51:
            ucButton.BackgroundImage = (Image) Resources.A1FROZEN_WARFRAME;
            ucButton.bitmap1 = Resources.A1FROZEN_WARFRAME;
            ucButton.bitmap2 = Resources.A1FROZEN_WARFRAMEa;
            break;
          case 64 /*0x40*/:
            switch (sub)
            {
              case 0:
                ucButton.BackgroundImage = (Image) Resources.A1FROZEN_WARFRAME_PRO;
                ucButton.bitmap1 = Resources.A1FROZEN_WARFRAME_PRO;
                ucButton.bitmap2 = Resources.A1FROZEN_WARFRAME_PROa;
                break;
              case 1:
                ucButton.BackgroundImage = (Image) Resources.A1LM22;
                ucButton.bitmap1 = Resources.A1LM22;
                ucButton.bitmap2 = Resources.A1LM22a;
                break;
              case 2:
                ucButton.BackgroundImage = (Image) Resources.A1LM27;
                ucButton.bitmap1 = Resources.A1LM27;
                ucButton.bitmap2 = Resources.A1LM27a;
                break;
            }
            break;
          case 65:
            switch (sub)
            {
              case 0:
                ucButton.BackgroundImage = (Image) Resources.A1ELITE_VISION;
                ucButton.bitmap1 = Resources.A1ELITE_VISION;
                ucButton.bitmap2 = Resources.A1ELITE_VISIONa;
                break;
              case 1:
                ucButton.BackgroundImage = (Image) Resources.A1LF14;
                ucButton.bitmap1 = Resources.A1LF14;
                ucButton.bitmap2 = Resources.A1LF14a;
                break;
            }
            break;
          case 100:
            switch (sub)
            {
              case 0:
                ucButton.BackgroundImage = (Image) Resources.A1FROZEN_WARFRAME_PRO;
                ucButton.bitmap1 = Resources.A1FROZEN_WARFRAME_PRO;
                ucButton.bitmap2 = Resources.A1FROZEN_WARFRAME_PROa;
                break;
              case 1:
                ucButton.BackgroundImage = (Image) Resources.A1LM22;
                ucButton.bitmap1 = Resources.A1LM22;
                ucButton.bitmap2 = Resources.A1LM22a;
                break;
            }
            break;
          case 101:
            switch (sub)
            {
              case 0:
                ucButton.BackgroundImage = (Image) Resources.A1ELITE_VISION;
                ucButton.bitmap1 = Resources.A1ELITE_VISION;
                ucButton.bitmap2 = Resources.A1ELITE_VISIONa;
                break;
              case 1:
                ucButton.BackgroundImage = (Image) Resources.A1LF14;
                ucButton.bitmap1 = Resources.A1LF14;
                ucButton.bitmap2 = Resources.A1LF14a;
                break;
            }
            break;
          case 128 /*0x80*/:
            ucButton.BackgroundImage = (Image) Resources.A1LM24;
            ucButton.bitmap1 = Resources.A1LM24;
            ucButton.bitmap2 = Resources.A1LM24a;
            break;
        }
        break;
    }
    ArrayList arrayList = new ArrayList();
    arrayList.Add((object) ("SerialNumber:" + ID.ToString()));
    arrayList.Add((object) ucButton);
    if (this.myButtonList.Count == 0)
      ucButton.BackgroundImage = (Image) ucButton.bitmap2;
    switch (ID)
    {
      case 1:
        this.myButtonList.Insert(this.hidList1.Count, (object) arrayList);
        break;
      case 2:
        this.myButtonList.Insert(this.hidList1.Count + this.hidList2.Count, (object) arrayList);
        break;
      case 3:
        this.myButtonList.Insert(this.hidList1.Count + this.hidList2.Count + this.hidList3.Count, (object) arrayList);
        break;
      case 4:
        this.myButtonList.Insert(this.hidList1.Count + this.hidList2.Count + this.hidList3.Count + this.hidList4.Count, (object) arrayList);
        break;
      case 257:
        this.myButtonList.Insert(this.hidList1.Count + this.hidList2.Count + this.hidList3.Count + this.hidList4.Count + this.rgbList.Count, (object) arrayList);
        break;
    }
    this.UserButtonArrange();
  }

  private void DeleteUserButton(int ID, int count)
  {
    ArrayList arrayList = (ArrayList) null;
    switch (ID)
    {
      case 1:
        arrayList = (ArrayList) this.myButtonList[count];
        break;
      case 2:
        count = this.hidList1.Count + count;
        arrayList = (ArrayList) this.myButtonList[count];
        break;
      case 3:
        count = this.hidList1.Count + this.hidList2.Count + count;
        arrayList = (ArrayList) this.myButtonList[count];
        break;
      case 4:
        count = this.hidList1.Count + this.hidList2.Count + this.hidList3.Count + count;
        arrayList = (ArrayList) this.myButtonList[count];
        break;
    }
    if (arrayList == null)
      return;
    UCButton ucButton1 = (UCButton) arrayList[1];
    this.Controls.Remove((Control) ucButton1);
    ucButton1.Dispose();
    arrayList.Clear();
    this.myButtonList.RemoveAt(count);
    if (this.nowUserButton == count)
    {
      this.nowUserButton = 0;
      if (this.myButtonList.Count > 0)
      {
        UCButton ucButton2 = (UCButton) ((ArrayList) this.myButtonList[0])[1];
        ucButton2.BackgroundImage = (Image) ucButton2.bitmap2;
      }
    }
    this.UserButtonArrange();
  }

  private void DelhidDeviceList(ArrayList array, int ID)
  {
    if (array.Count <= 0)
      return;
    for (int index = array.Count - 1; index >= 0; --index)
    {
      UsbHidDevice usbHidDevice = (UsbHidDevice) array[index];
      if (!usbHidDevice.IsDeviceConnected)
      {
        this.DeleteUserButton(ID, index);
        UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
        if (delegateUcDevice != null)
          delegateUcDevice(0, (object) ID, (object) index);
        array.RemoveAt(index);
        usbHidDevice.Dispose();
      }
    }
  }

  private void AddhidDeviceList(
    ArrayList array,
    UsbHidDevice device,
    int ID,
    byte[] receive = null,
    string name = "")
  {
    CommandMessage message = new CommandMessage(new byte[14]
    {
      (byte) 220,
      (byte) 221,
      (byte) 1,
      (byte) 0,
      (byte) ID,
      (byte) (ID >> 8),
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) array.Count,
      (byte) 1,
      (byte) 0,
      (byte) 0
    });
    if (ID == 4)
    {
      device.SendMessage((IMesage) message);
      this.ADDUserButton(ID);
      UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
      if (delegateUcDevice != null)
        delegateUcDevice(1, (object) ID);
    }
    else
    {
      this.ADDUserButton(ID, receive[6], receive[5]);
      UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
      if (delegateUcDevice != null)
        delegateUcDevice(1, (object) ID, (object) receive[6], (object) name);
    }
    array.Add((object) device);
    switch (ID)
    {
      case 1:
        this.device1 = (UsbHidDevice) null;
        break;
      case 2:
        this.device2 = (UsbHidDevice) null;
        break;
      case 3:
        this.device3 = (UsbHidDevice) null;
        break;
      case 4:
        this.device4 = (UsbHidDevice) null;
        break;
    }
    this.Scan_UsbHid();
  }

  private void DoUsbHidEvent(object val)
  {
    ArrayList arrayList = (ArrayList) val;
    switch ((int) arrayList[0])
    {
      case 0:
        this.DelhidDeviceList(this.hidList1, 1);
        this.workingDis = false;
        break;
      case 1:
        this.DelhidDeviceList(this.hidList2, 2);
        this.workingDis = false;
        break;
      case 2:
        this.DelhidDeviceList(this.hidList3, 3);
        this.workingDis = false;
        break;
      case 3:
        this.DelhidDeviceList(this.hidList4, 4);
        this.workingDis = false;
        break;
      case 4096 /*0x1000*/:
        this.AddhidDeviceList(this.hidList1, this.device1, 1, (byte[]) arrayList[1], (string) arrayList[2]);
        this.workingcon = false;
        break;
      case 4097:
        this.AddhidDeviceList(this.hidList2, this.device2, 2, (byte[]) arrayList[1], (string) arrayList[2]);
        this.workingcon = false;
        break;
      case 4098:
        this.AddhidDeviceList(this.hidList3, this.device3, 3);
        this.workingcon = false;
        break;
      case 4099:
        this.AddhidDeviceList(this.hidList4, this.device4, 4);
        this.workingcon = false;
        break;
      case 8192 /*0x2000*/:
        byte[] data1 = (byte[]) arrayList[1];
        UCDevice.delegateUCDevice delegateUcDevice1 = this.delegateUcDevice;
        if (delegateUcDevice1 == null)
          break;
        delegateUcDevice1(2, (object) (ushort) 1, (object) data1);
        break;
      case 8193:
        byte[] data2 = (byte[]) arrayList[1];
        UCDevice.delegateUCDevice delegateUcDevice2 = this.delegateUcDevice;
        if (delegateUcDevice2 == null)
          break;
        delegateUcDevice2(2, (object) (ushort) 2, (object) data2);
        break;
      case 8194:
        byte[] data3 = (byte[]) arrayList[1];
        UCDevice.delegateUCDevice delegateUcDevice3 = this.delegateUcDevice;
        if (delegateUcDevice3 == null)
          break;
        delegateUcDevice3(2, (object) (ushort) 3, (object) data3);
        break;
      case 8195:
        byte[] data4 = (byte[]) arrayList[1];
        UCDevice.delegateUCDevice delegateUcDevice4 = this.delegateUcDevice;
        if (delegateUcDevice4 != null)
          delegateUcDevice4(2, (object) (ushort) 4, (object) data4);
        break;
    }
  }

  private void UsbHidEvent(object hid)
  {
    this.BeginInvoke((Delegate) new UCDevice.DoUsbHidInvoke(this.DoUsbHidEvent), hid);
  }

  private void DeviceOnConnected1()
  {
    while (this.workingcon)
      Thread.Sleep(1);
    this.workingcon = true;
    this.device1.SendMessage((IMesage) new CommandMessage(new byte[20]
    {
      (byte) 218,
      (byte) 219,
      (byte) 220,
      (byte) 221,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    }));
  }

  private void DeviceOnDisConnected1()
  {
    while (this.workingDis)
      Thread.Sleep(1);
    this.workingDis = true;
    new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) new ArrayList()
    {
      (object) 0
    });
  }

  private void DeviceDataReceived1(byte[] data, object device)
  {
    if (this.device1 == null || data.Length == 0)
      return;
    this.timerStartCountVal = 300;
    UsbHidDevice usbHidDevice = (UsbHidDevice) device;
    if (!usbHidDevice.DevicePath.Equals(this.device1.DevicePath))
      return;
    ArrayList parameter = new ArrayList();
    parameter.Add((object) 4096 /*0x1000*/);
    parameter.Add((object) data);
    if (data[17] == (byte) 16 /*0x10*/ && data.Length >= 37)
    {
      string str = BitConverter.ToString(data, 21).Replace("-", "");
      parameter.Add((object) str);
    }
    else
    {
      string legalChars = "0123456789abcdefABCDEF";
      string str = this.RemoveIllegalCharacters(usbHidDevice.DevicePath, legalChars);
      parameter.Add((object) str);
    }
    new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) parameter);
  }

  private void ThreadSendDeviceData1(object obj)
  {
    ArrayList arrayList = (ArrayList) obj;
    try
    {
      int index = (int) arrayList[0];
      if (this.isSendUsbThread0[index])
        return;
      this.isSendUsbThread0[index] = true;
      UsbHidDevice usbHidDevice = (UsbHidDevice) this.hidList1[index];
      byte[] sourceArray = (byte[]) arrayList[1];
      int length = (int) arrayList[2];
      int sourceIndex = 0;
      do
      {
        if (length > 64 /*0x40*/)
        {
          byte[] numArray = new byte[64 /*0x40*/];
          Array.Copy((Array) sourceArray, sourceIndex, (Array) numArray, 0, 64 /*0x40*/);
          length -= 64 /*0x40*/;
          sourceIndex += 64 /*0x40*/;
          CommandMessage message = new CommandMessage(numArray);
          usbHidDevice.SendMessage((IMesage) message);
        }
        else
        {
          byte[] numArray = new byte[length];
          Array.Copy((Array) sourceArray, sourceIndex, (Array) numArray, 0, length);
          length = 0;
          CommandMessage message = new CommandMessage(numArray);
          usbHidDevice.SendMessage((IMesage) message);
        }
      }
      while (length > 0);
    }
    catch
    {
    }
    Thread.Sleep(30);
    this.isSendUsbThread0[(int) arrayList[0]] = false;
    arrayList.Clear();
  }

  public void SendDeviceData1(int n, byte[] data, int len)
  {
    new Thread(new ParameterizedThreadStart(this.ThreadSendDeviceData1))
    {
      Priority = ThreadPriority.Normal
    }.Start((object) new ArrayList()
    {
      (object) n,
      (object) data,
      (object) len
    });
  }

  public string RemoveIllegalCharacters(string input, string legalChars)
  {
    string pattern = $"[^{Regex.Escape(legalChars)}]";
    return Regex.Replace(input, pattern, string.Empty);
  }

  private void DeviceOnConnected2()
  {
    while (this.workingcon)
      Thread.Sleep(1);
    this.workingcon = true;
    CommandMessage commandMessage = new CommandMessage(new byte[512 /*0x0200*/]);
    int num = 0;
    while (num < 400)
      ++num;
    this.device2.SendMessage((IMesage) new CommandMessage(new byte[20]
    {
      (byte) 218,
      (byte) 219,
      (byte) 220,
      (byte) 221,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    }));
  }

  private void DeviceOnDisConnected2()
  {
    while (this.workingDis)
      Thread.Sleep(1);
    this.workingDis = true;
    new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) new ArrayList()
    {
      (object) 1
    });
  }

  private void DeviceDataReceived2(byte[] data, object device)
  {
    if (data.Length != 0 && this.device2 == device && data[1] == (byte) 218 && data[2] == (byte) 219 && data[3] == (byte) 220 && data[4] == (byte) 221 && data[13] == (byte) 1)
    {
      this.timerStartCountVal = 300;
      UsbHidDevice usbHidDevice = (UsbHidDevice) device;
      if (!usbHidDevice.DevicePath.Equals(this.device2.DevicePath))
        return;
      ArrayList parameter = new ArrayList();
      parameter.Add((object) 4097);
      parameter.Add((object) data);
      if (data[17] == (byte) 16 /*0x10*/ && data.Length >= 37)
      {
        string str = BitConverter.ToString(data, 21).Replace("-", "");
        parameter.Add((object) str);
      }
      else
      {
        string legalChars = "0123456789abcdefABCDEF";
        string str = this.RemoveIllegalCharacters(usbHidDevice.DevicePath, legalChars);
        parameter.Add((object) str);
      }
      new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) parameter);
    }
    else
    {
      if (data.Length == 0 || data[1] != (byte) 218 || data[2] != (byte) 219 || data[3] != (byte) 220 || data[4] != (byte) 221 || data[13] != (byte) 8)
        return;
      for (int index = 0; index < this.hidList2.Count; ++index)
      {
        if (device == this.hidList2[index])
        {
          data[9] = (byte) index;
          new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) new ArrayList()
          {
            (object) 8193,
            (object) data
          });
          break;
        }
      }
    }
  }

  private void ThreadSendDeviceData2(object obj)
  {
    int index = (int) obj;
    if (this.isSendUsbThread[index])
      return;
    this.isSendUsbThread[index] = true;
    ArrayList sendUsb = (ArrayList) this.sendUsbArray[index];
    UsbHidDevice usbHidDevice = (UsbHidDevice) this.hidList2[index];
    try
    {
      do
      {
        ArrayList arrayList = (ArrayList) sendUsb[0];
        byte[] sourceArray = (byte[]) arrayList[1];
        int length = (int) arrayList[2];
        int sourceIndex = 0;
        do
        {
          if (length > 512 /*0x0200*/)
          {
            byte[] numArray = new byte[512 /*0x0200*/];
            Array.Copy((Array) sourceArray, sourceIndex, (Array) numArray, 0, 512 /*0x0200*/);
            length -= 512 /*0x0200*/;
            sourceIndex += 512 /*0x0200*/;
            CommandMessage message = new CommandMessage(numArray);
            usbHidDevice.SendMessage((IMesage) message);
          }
          else
          {
            byte[] numArray = new byte[length];
            Array.Copy((Array) sourceArray, sourceIndex, (Array) numArray, 0, length);
            length = 0;
            CommandMessage message = new CommandMessage(numArray);
            usbHidDevice.SendMessage((IMesage) message);
          }
        }
        while (length > 0);
        arrayList.Clear();
        sendUsb.RemoveAt(0);
      }
      while (sendUsb.Count > 0);
    }
    catch
    {
      sendUsb.Clear();
      Console.WriteLine("Dai: UsbHidDevice myUsbList is Null!");
    }
    this.isSendUsbThread[index] = false;
  }

  public void SendDeviceData2(int n, byte[] data, int len)
  {
    if (((ArrayList) this.sendUsbArray[n]).Count > 2)
      return;
    ((ArrayList) this.sendUsbArray[n]).Add((object) new ArrayList()
    {
      (object) n,
      (object) data,
      (object) len
    });
    if (((ArrayList) this.sendUsbArray[n]).Count == 1)
      new Thread(new ParameterizedThreadStart(this.ThreadSendDeviceData2))
      {
        Priority = ThreadPriority.AboveNormal
      }.Start((object) n);
  }

  private void DeviceOnConnected3()
  {
    while (this.workingcon)
      Thread.Sleep(1);
    this.workingcon = true;
    new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) new ArrayList()
    {
      (object) 4098
    });
  }

  private void DeviceOnDisConnected3()
  {
    while (this.workingDis)
      Thread.Sleep(1);
    this.workingDis = true;
    new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) new ArrayList()
    {
      (object) 2
    });
  }

  private void DeviceDataReceived3(byte[] data, object device)
  {
    if (data.Length == 0)
      return;
    new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) new ArrayList()
    {
      (object) 8194,
      (object) data
    });
  }

  public void SendDeviceData3(int count, byte[] cmd, byte[] data)
  {
  }

  private void DeviceOnConnected4()
  {
    while (this.workingcon)
      Thread.Sleep(1);
    this.workingcon = true;
    new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) new ArrayList()
    {
      (object) 4099
    });
  }

  private void DeviceOnDisConnected4()
  {
    while (this.workingDis)
      Thread.Sleep(1);
    this.workingDis = true;
    new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) new ArrayList()
    {
      (object) 3
    });
  }

  private void DeviceDataReceived4(byte[] data, object device)
  {
    if (data.Length == 0)
      return;
    new Thread(new ParameterizedThreadStart(this.UsbHidEvent)).Start((object) new ArrayList()
    {
      (object) 8195,
      (object) data
    });
  }

  public void SendDeviceData4(int count, byte[] cmd, byte[] data)
  {
  }

  public void SendDeviceData0(byte[] data)
  {
  }

  private void UCDevice_MouseDown(object sender, MouseEventArgs e)
  {
    UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
    if (delegateUcDevice == null)
      return;
    delegateUcDevice(241, (object) this, (object) e);
  }

  private void UCDevice_MouseMove(object sender, MouseEventArgs e)
  {
    UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
    if (delegateUcDevice == null)
      return;
    delegateUcDevice(242, (object) this, (object) e);
  }

  private void UCDevice_MouseUp(object sender, MouseEventArgs e)
  {
    UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
    if (delegateUcDevice == null)
      return;
    delegateUcDevice(243, (object) this, (object) e);
  }

  private void buttonSetting_Click(object sender, EventArgs e)
  {
    this.button1.BackgroundImage = (Image) Resources.A1传感器;
    this.buttonSetting.BackgroundImage = (Image) Resources.A1关于a;
    for (int index = 0; index < this.myButtonList.Count; ++index)
    {
      UCButton ucButton = (UCButton) ((ArrayList) this.myButtonList[index])[1];
      ucButton.BackgroundImage = (Image) ucButton.bitmap1;
    }
    UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
    if (delegateUcDevice == null)
      return;
    delegateUcDevice(240 /*0xF0*/);
  }

  private void button1_Click(object sender, EventArgs e)
  {
    this.button1.BackgroundImage = (Image) Resources.A1传感器a;
    this.buttonSetting.BackgroundImage = (Image) Resources.A1关于;
    for (int index = 0; index < this.myButtonList.Count; ++index)
    {
      UCButton ucButton = (UCButton) ((ArrayList) this.myButtonList[index])[1];
      ucButton.BackgroundImage = (Image) ucButton.bitmap1;
    }
    UCDevice.delegateUCDevice delegateUcDevice = this.delegateUcDevice;
    if (delegateUcDevice == null)
      return;
    delegateUcDevice(512 /*0x0200*/);
  }

  public void RGB_ADD_Device(byte pm = 50, byte sub = 0)
  {
    this.ADDUserButton(257, pm, sub);
    this.rgbList.Add((object) (this.rgbList.Count + 1));
  }

  public void Remove_RGB_Device()
  {
    for (int index = this.myButtonList.Count - 1; index >= 0; --index)
    {
      ArrayList button = (ArrayList) this.myButtonList[index];
      if (button == null)
        return;
      UCButton ucButton = (UCButton) button[1];
      this.Controls.Remove((Control) ucButton);
      ucButton.Dispose();
      button.Clear();
      this.myButtonList.RemoveAt(index);
    }
    for (int index = 0; index < this.hidList1.Count; ++index)
    {
      UsbHidDevice usbHidDevice = (UsbHidDevice) this.hidList1[index];
      usbHidDevice.Disconnect();
      usbHidDevice.Dispose();
      this.workingDis = false;
    }
    this.hidList1.Clear();
    for (int index = 0; index < this.hidList2.Count; ++index)
    {
      UsbHidDevice usbHidDevice = (UsbHidDevice) this.hidList2[index];
      usbHidDevice.Disconnect();
      usbHidDevice.Dispose();
      this.workingDis = false;
    }
    this.hidList2.Clear();
    this.hidNameList1.Clear();
    this.hidNameList2.Clear();
    this.rgbList.Clear();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonSetting = new Button();
    this.button1 = new Button();
    this.SuspendLayout();
    this.buttonSetting.BackColor = Color.Transparent;
    this.buttonSetting.BackgroundImage = (Image) Resources.A1关于;
    this.buttonSetting.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonSetting.FlatAppearance.BorderSize = 0;
    this.buttonSetting.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonSetting.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonSetting.FlatStyle = FlatStyle.Flat;
    this.buttonSetting.Location = new Point(25, 730);
    this.buttonSetting.Margin = new Padding(0);
    this.buttonSetting.Name = "buttonSetting";
    this.buttonSetting.Size = new Size(140, 50);
    this.buttonSetting.TabIndex = 138;
    this.buttonSetting.UseVisualStyleBackColor = false;
    this.buttonSetting.Click += new EventHandler(this.buttonSetting_Click);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.A1传感器a;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(25, 100);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(140, 50);
    this.button1.TabIndex = 139;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.A0硬件列表;
    this.BackgroundImageLayout = ImageLayout.Zoom;
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.buttonSetting);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCDevice);
    this.Size = new Size(180, 800);
    this.MouseDown += new MouseEventHandler(this.UCDevice_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCDevice_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCDevice_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCDevice(int cmd, object info = null, object data = null, object name = null);

  private delegate void DoUsbHidInvoke(object val);
}

// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCVideoCut
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCVideoCut : UserControl
{
  public UCVideoCut.delegateUCVideoCut ucVideoCut;
  private Bitmap bitmap1 = (Bitmap) null;
  private int bitmapCX1 = 0;
  private int bitmapCY1 = 0;
  private int bitmapW1 = 0;
  private int bitmapH1 = 0;
  private Bitmap bitmap2 = (Bitmap) null;
  private int bitmapCX2 = 0;
  private int bitmapCY2 = 0;
  private int bitmapW2 = 0;
  private int bitmapH2 = 0;
  private Bitmap bitmapJindu = (Bitmap) null;
  private int bitmapJDX = 0;
  private int bitmapJDY = 0;
  private int bitmapJDW = 0;
  private int bitmapJDH = 0;
  private const int gdtX1 = 9;
  private const int gdtY1 = 564;
  private const int gdtX2 = 489;
  private const int gdtY2 = 575;
  private const int gdtX = 8;
  private const int gdtY = 565;
  private const int CenterVal = 15;
  public bool isFanZhuan = false;
  public bool is240x240 = false;
  public bool is320x320 = false;
  public bool is360x360 = false;
  public bool is480x480 = false;
  public bool is640x480 = false;
  public bool is1600x720 = false;
  public bool is1280x480 = false;
  public bool is1920x462 = false;
  public bool is854x480 = false;
  public bool is960x540 = false;
  public bool is800x480 = false;
  public bool is960x320 = false;
  public bool isBiliPingmu = false;
  private int xVal = 0;
  private int yVal = 0;
  private int wVal = 320;
  private int hVal = 240 /*0xF0*/;
  private int xValSub = 0;
  private int yValSub = 0;
  private int wValSub = 320;
  private int hValSub = 240 /*0xF0*/;
  private bool isGetVideoInfo = false;
  private int originalImageW = 480;
  private int originalImageH = 480;
  private int originalImageHz = 15;
  private long originalTimerLen = 1000;
  private long startTimerVal = 0;
  private long stopTimerVal = 1000;
  private bool isMouseDown1 = false;
  private bool isMouseDown2 = false;
  private bool isMouseMove = false;
  private bool isMouse1 = true;
  private bool isMouse2 = false;
  private int xPos = 0;
  private int yPos = 0;
  private int mouseDownCount = 0;
  private bool isGetOneImage = false;
  private bool isTPJCW = true;
  private int bitAngle = 0;
  private int bitAngleW = 480;
  private int bitAngleH = 480;
  private string myName = (string) null;
  public Bitmap imageSub = (Bitmap) null;
  private string onePic = "";
  public string allPicAddr = "";
  private const byte USB_PACKED_Head = 220;
  private const string fileName = "Theme.zt";
  private const int AllTimerVal = 300000;
  private int jindu = 0;
  private bool isZhuanma = false;
  private bool isYulan = false;
  private int yuLanTimer = 0;
  private int yuLanCount = 1;
  private int yuLanHz = 15;
  private IContainer components = (IContainer) null;
  private Button buttonTPJCOK;
  private Button buttonXuanzhuan;
  private Button buttonTPJCW;
  private Button buttonTPJCH;
  private Button buttonYulan;
  private Button buttonClose;
  public Label labelAllTimer;
  public Label labelStartTimer;
  public Label labelStopTimer;
  public Label labelInfo;
  private Button button1;
  private Button button2;
  public Label labelTimer;

  public UCVideoCut()
  {
    this.InitializeComponent();
    this.buttonTPJCOK.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.bitmap1 = Resources.P剪辑块a;
    this.bitmapW1 = this.bitmap1.Width;
    this.bitmapH1 = this.bitmap1.Height;
    this.bitmapCX1 = 9;
    this.bitmapCY1 = 564;
    this.bitmap2 = Resources.P剪辑块b;
    this.bitmapW2 = this.bitmap2.Width;
    this.bitmapH2 = this.bitmap2.Height;
    this.bitmapCX2 = 489;
    this.bitmapCY2 = 575;
    this.bitmapJindu = Resources.P进度条;
    this.bitmapJDX = 8;
    this.bitmapJDY = 565;
    this.bitmapJDW = this.bitmapJindu.Width;
    this.bitmapJDH = this.bitmapJindu.Height;
    this.onePic = Application.StartupPath + "\\Data\\Temp\\0.png";
    this.allPicAddr = Application.StartupPath + "\\Data\\Temp\\";
    if (Form1.Language == 1)
      this.labelInfo.Text = "正在渲染";
    else if (Form1.Language == 2)
      this.labelInfo.Text = "Rendering";
    else
      this.labelInfo.Text = "Rendering";
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (this.jindu != 0)
    {
      graphics.DrawImage((Image) this.bitmapJindu, this.bitmapJDX, this.bitmapJDY, this.jindu, this.bitmapJDH);
    }
    else
    {
      graphics.DrawImage((Image) this.bitmap1, this.bitmapCX1 - this.bitmapW1 / 2, this.bitmapCY1 - this.bitmapH1 / 2);
      graphics.DrawImage((Image) this.bitmap2, this.bitmapCX2 - this.bitmapW2 / 2, this.bitmapCY2 - this.bitmapH2 / 2);
    }
    if (this.imageSub == null)
      return;
    graphics.DrawImage((Image) this.imageSub, this.xValSub, this.yValSub);
  }

  private void KillFFmpegYulan(bool kill = true)
  {
    this.isYulan = false;
    this.buttonYulan.BackgroundImage = (Image) Resources.P0预览;
    if (!kill)
      return;
    try
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Equals("ffmpeg"))
          process.Kill();
      }
    }
    catch (Exception ex)
    {
    }
  }

  public void Timer_event()
  {
    if (this.isMouseDown1)
    {
      ++this.mouseDownCount;
      if (this.mouseDownCount < 32 /*0x20*/)
        return;
      this.mouseDownCount = 0;
      this.GetOneImage(this.labelStartTimer.Text);
    }
    else if (this.isMouseDown2)
    {
      ++this.mouseDownCount;
      if (this.mouseDownCount < 32 /*0x20*/)
        return;
      this.mouseDownCount = 0;
      this.GetOneImage(this.labelStopTimer.Text);
    }
    else
    {
      this.mouseDownCount = 0;
      if (this.isYulan)
      {
        ++this.yuLanTimer;
        if ((double) this.yuLanTimer * 15.625 < (double) this.yuLanCount * 1000.0 / (double) this.yuLanHz)
          return;
        string str = this.yuLanCount.ToString("0000");
        if (File.Exists($"{this.allPicAddr}{str}.bmp"))
        {
          try
          {
            if (this.imageSub != null)
            {
              this.imageSub.Dispose();
              this.imageSub = (Bitmap) null;
            }
            Image image = Image.FromFile($"{this.allPicAddr}{str}.bmp");
            this.imageSub = new Bitmap(this.wValSub, this.hValSub);
            Graphics graphics = Graphics.FromImage((Image) this.imageSub);
            graphics.DrawImage(image, this.xVal, this.yVal);
            graphics.Dispose();
            image.Dispose();
            this.Invalidate();
          }
          catch
          {
          }
          ++this.yuLanCount;
        }
        else
        {
          this.yuLanCount = 1;
          this.yuLanTimer = 0;
        }
      }
      else
      {
        this.yuLanCount = 1;
        this.yuLanTimer = 0;
      }
    }
  }

  private void buttonClose_Click(object sender, EventArgs e)
  {
    if (this.isZhuanma)
      return;
    this.KillFFmpegYulan();
    UCVideoCut.delegateUCVideoCut ucVideoCut = this.ucVideoCut;
    if (ucVideoCut == null)
      return;
    ucVideoCut((ArrayList) null);
  }

  private void buttonTPJCH_Click(object sender, EventArgs e)
  {
    if (this.isZhuanma)
      return;
    this.KillFFmpegYulan();
    if (this.is240x240)
    {
      this.xValSub = 130;
      this.yValSub = 130;
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 240 /*0xF0*/;
      this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
      this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else if (this.is320x320)
    {
      this.xValSub = 90;
      this.yValSub = 90;
      this.wValSub = 320;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 320;
      this.wVal = this.bitAngleW * 320 / this.bitAngleH;
      this.xVal += (320 - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else if (this.is360x360)
    {
      this.xValSub = 70;
      this.yValSub = 70;
      this.wValSub = 360;
      this.hValSub = 360;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 360;
      this.wVal = this.bitAngleW * 360 / this.bitAngleH;
      this.xVal += (360 - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else if (this.is480x480)
    {
      this.xValSub = 10;
      this.yValSub = 10;
      this.wValSub = 480;
      this.hValSub = 480;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 480;
      this.wVal = this.bitAngleW * 480 / this.bitAngleH;
      this.xVal += (480 - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else if (this.is1600x720)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 50;
        this.xValSub = 160 /*0xA0*/;
        this.hValSub = 400;
        this.wValSub = 180;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 400;
        this.wVal = this.bitAngleW * 400 / this.bitAngleH;
        this.xVal += (180 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.xValSub = 50;
        this.yValSub = 160 /*0xA0*/;
        this.wValSub = 400;
        this.hValSub = 180;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 180;
        this.wVal = this.bitAngleW * 180 / this.bitAngleH;
        this.xVal += (400 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is800x480)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 50;
        this.xValSub = 130;
        this.hValSub = 400;
        this.wValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 400;
        this.wVal = this.bitAngleW * 400 / this.bitAngleH;
        this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.xValSub = 50;
        this.yValSub = 130;
        this.wValSub = 400;
        this.hValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 240 /*0xF0*/;
        this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
        this.xVal += (400 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is854x480)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 36;
        this.xValSub = 130;
        this.hValSub = 427;
        this.wValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 427;
        this.wVal = this.bitAngleW * 427 / this.bitAngleH;
        this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.xValSub = 36;
        this.yValSub = 130;
        this.wValSub = 427;
        this.hValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 240 /*0xF0*/;
        this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
        this.xVal += (427 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is960x540)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 10;
        this.xValSub = 115;
        this.hValSub = 480;
        this.wValSub = 270;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.bitAngleW * 480 / this.bitAngleH;
        this.xVal += (270 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.xValSub = 10;
        this.yValSub = 115;
        this.wValSub = 480;
        this.hValSub = 270;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 270;
        this.wVal = this.bitAngleW * 270 / this.bitAngleH;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is960x320)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 10;
        this.xValSub = 170;
        this.hValSub = 480;
        this.wValSub = 160 /*0xA0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.bitAngleW * 480 / this.bitAngleH;
        this.xVal += (160 /*0xA0*/ - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.xValSub = 10;
        this.yValSub = 170;
        this.wValSub = 480;
        this.hValSub = 160 /*0xA0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 160 /*0xA0*/;
        this.wVal = this.bitAngleW * 160 /*0xA0*/ / this.bitAngleH;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is1920x462)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 10;
        this.xValSub = 192 /*0xC0*/;
        this.hValSub = 480;
        this.wValSub = 116;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.bitAngleW * 480 / this.bitAngleH;
        this.xVal += (116 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.xValSub = 10;
        this.yValSub = 192 /*0xC0*/;
        this.wValSub = 480;
        this.hValSub = 116;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 116;
        this.wVal = this.bitAngleW * 116 / this.bitAngleH;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is1280x480)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 10;
        this.xValSub = 160 /*0xA0*/;
        this.hValSub = 480;
        this.wValSub = 180;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.bitAngleW * 480 / this.bitAngleH;
        this.xVal += (180 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.xValSub = 10;
        this.yValSub = 160 /*0xA0*/;
        this.wValSub = 480;
        this.hValSub = 180;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 180;
        this.wVal = this.bitAngleW * 180 / this.bitAngleH;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.isFanZhuan)
    {
      this.xValSub = 130;
      this.yValSub = 90;
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 320;
      this.wVal = this.bitAngleW * 320 / this.bitAngleH;
      this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else
    {
      this.xValSub = 90;
      this.yValSub = 130;
      this.wValSub = 320;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 240 /*0xF0*/;
      this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
      this.xVal += (320 - this.wVal) / 2;
      this.isTPJCW = false;
    }
    if (this.isMouse1)
    {
      this.GetOneImage(this.labelStartTimer.Text);
    }
    else
    {
      if (!this.isMouse2)
        return;
      this.GetOneImage(this.labelStopTimer.Text);
    }
  }

  private void buttonTPJCW_Click(object sender, EventArgs e)
  {
    if (this.isZhuanma)
      return;
    this.KillFFmpegYulan();
    if (this.is240x240)
    {
      this.xValSub = 130;
      this.yValSub = 130;
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 240 /*0xF0*/;
      this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
      this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else if (this.is320x320)
    {
      this.xValSub = 90;
      this.yValSub = 90;
      this.wValSub = 320;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 320;
      this.hVal = this.bitAngleH * 320 / this.bitAngleW;
      this.yVal += (320 - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else if (this.is360x360)
    {
      this.xValSub = 70;
      this.yValSub = 70;
      this.wValSub = 360;
      this.hValSub = 360;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 360;
      this.hVal = this.bitAngleH * 360 / this.bitAngleW;
      this.yVal += (360 - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else if (this.is480x480)
    {
      this.xValSub = 10;
      this.yValSub = 10;
      this.wValSub = 480;
      this.hValSub = 480;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 480;
      this.hVal = this.bitAngleH * 480 / this.bitAngleW;
      this.yVal += (480 - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else if (this.is1600x720)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 50;
        this.xValSub = 160 /*0xA0*/;
        this.hValSub = 400;
        this.wValSub = 180;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 180;
        this.hVal = this.bitAngleH * 180 / this.bitAngleW;
        this.yVal += (400 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.xValSub = 50;
        this.yValSub = 160 /*0xA0*/;
        this.wValSub = 400;
        this.hValSub = 180;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 400;
        this.hVal = this.bitAngleH * 400 / this.bitAngleW;
        this.yVal += (180 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is800x480)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 50;
        this.xValSub = 130;
        this.hValSub = 400;
        this.wValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 240 /*0xF0*/;
        this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
        this.yVal += (400 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.xValSub = 50;
        this.yValSub = 130;
        this.wValSub = 400;
        this.hValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 400;
        this.hVal = this.bitAngleH * 400 / this.bitAngleW;
        this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is854x480)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 36;
        this.xValSub = 130;
        this.hValSub = 427;
        this.wValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 240 /*0xF0*/;
        this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
        this.yVal += (427 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.xValSub = 36;
        this.yValSub = 130;
        this.wValSub = 427;
        this.hValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 427;
        this.hVal = this.bitAngleH * 427 / this.bitAngleW;
        this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is960x540)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 10;
        this.xValSub = 115;
        this.hValSub = 480;
        this.wValSub = 270;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 270;
        this.hVal = this.bitAngleH * 270 / this.bitAngleW;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.xValSub = 10;
        this.yValSub = 115;
        this.wValSub = 480;
        this.hValSub = 270;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.bitAngleH * 480 / this.bitAngleW;
        this.yVal += (270 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is960x320)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 10;
        this.xValSub = 170;
        this.hValSub = 480;
        this.wValSub = 160 /*0xA0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 160 /*0xA0*/;
        this.hVal = this.bitAngleH * 160 /*0xA0*/ / this.bitAngleW;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.xValSub = 10;
        this.yValSub = 170;
        this.wValSub = 480;
        this.hValSub = 160 /*0xA0*/;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.bitAngleH * 480 / this.bitAngleW;
        this.yVal += (160 /*0xA0*/ - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is1920x462)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 10;
        this.xValSub = 192 /*0xC0*/;
        this.hValSub = 480;
        this.wValSub = 116;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 116;
        this.hVal = this.bitAngleH * 116 / this.bitAngleW;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.xValSub = 10;
        this.yValSub = 192 /*0xC0*/;
        this.wValSub = 480;
        this.hValSub = 116;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.bitAngleH * 480 / this.bitAngleW;
        this.yVal += (116 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is1280x480)
    {
      if (this.isFanZhuan)
      {
        this.yValSub = 10;
        this.xValSub = 160 /*0xA0*/;
        this.hValSub = 480;
        this.wValSub = 180;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 180;
        this.hVal = this.bitAngleH * 180 / this.bitAngleW;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.xValSub = 10;
        this.yValSub = 160 /*0xA0*/;
        this.wValSub = 480;
        this.hValSub = 180;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.bitAngleH * 480 / this.bitAngleW;
        this.yVal += (180 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.isFanZhuan)
    {
      this.xValSub = 130;
      this.yValSub = 90;
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 240 /*0xF0*/;
      this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
      this.yVal += (320 - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else
    {
      this.xValSub = 90;
      this.yValSub = 130;
      this.wValSub = 320;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 320;
      this.hVal = this.bitAngleH * 320 / this.bitAngleW;
      this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
      this.isTPJCW = true;
    }
    if (this.isMouse1)
    {
      this.GetOneImage(this.labelStartTimer.Text);
    }
    else
    {
      if (!this.isMouse2)
        return;
      this.GetOneImage(this.labelStopTimer.Text);
    }
  }

  private void buttonXuanzhuan_Click(object sender, EventArgs e)
  {
    if (this.isZhuanma)
      return;
    this.KillFFmpegYulan();
    this.bitAngle = (this.bitAngle + 270) % 360;
    switch (this.bitAngle)
    {
      case 0:
        this.bitAngleW = this.originalImageW;
        this.bitAngleH = this.originalImageH;
        break;
      case 90:
        this.bitAngleH = this.originalImageW;
        this.bitAngleW = this.originalImageH;
        break;
      case 180:
        this.bitAngleW = this.originalImageW;
        this.bitAngleH = this.originalImageH;
        break;
      case 270:
        this.bitAngleH = this.originalImageW;
        this.bitAngleW = this.originalImageH;
        break;
    }
    if (this.isTPJCW)
      this.buttonTPJCW_Click((object) null, (EventArgs) null);
    else
      this.buttonTPJCH_Click((object) null, (EventArgs) null);
  }

  public void ResetAllTempFile()
  {
    if (Directory.Exists(this.allPicAddr))
      Directory.Delete(this.allPicAddr, true);
    Directory.CreateDirectory(this.allPicAddr);
  }

  public byte[] BitmapToByte(Bitmap Bit)
  {
    bool flag = true;
    byte[] numArray = (byte[]) null;
    while (flag)
    {
      try
      {
        MemoryStream memoryStream = new MemoryStream();
        Bit.Save((Stream) memoryStream, ImageFormat.Jpeg);
        memoryStream.Position = 0L;
        numArray = memoryStream.GetBuffer();
        memoryStream.Close();
        memoryStream.Dispose();
        flag = false;
      }
      catch
      {
        Thread.Sleep(100);
        Application.DoEvents();
      }
    }
    return numArray;
  }

  public void BmpToThemeFile()
  {
    ArrayList arrayList = new ArrayList();
    FileStream output = new FileStream(this.allPicAddr + "Theme.zt", FileMode.OpenOrCreate);
    BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
    int num1 = 1;
    double num2 = 125.0 / 3.0;
    int num3 = 0;
    binaryWriter.Write((byte) 220);
    while (num3 < 100)
    {
      string str = num1.ToString("0000");
      if (File.Exists($"{this.allPicAddr}{str}.bmp"))
      {
        try
        {
          Image Bit = Image.FromFile($"{this.allPicAddr}{str}.bmp");
          byte[] numArray = this.BitmapToByte((Bitmap) Bit);
          arrayList.Add((object) numArray);
          Bit.Dispose();
          File.Delete($"{this.allPicAddr}{str}.bmp");
          num3 = 0;
          ++num1;
        }
        catch
        {
          Thread.Sleep(1);
        }
      }
      else
      {
        ++num3;
        Thread.Sleep(1);
      }
    }
    binaryWriter.Write(num1 - 1);
    for (int index = 1; index < num1; ++index)
    {
      int num4 = (int) (num2 * (double) index);
      binaryWriter.Write(num4);
    }
    for (int index = 0; index < arrayList.Count; ++index)
    {
      byte[] buffer = (byte[]) arrayList[index];
      binaryWriter.Write(buffer.Length);
      binaryWriter.Write(buffer);
    }
    binaryWriter.Flush();
    binaryWriter.Close();
    binaryWriter.Dispose();
    output.Close();
    output.Dispose();
    arrayList.Clear();
  }

  private void ZhuanMaPanDuan(bool isFF)
  {
    if (this.is1600x720 || this.is1920x462)
    {
      this.KillFFmpegYulan();
      this.ResetAllTempFile();
      if (this.stopTimerVal - this.startTimerVal > 300000L)
      {
        this.stopTimerVal = this.startTimerVal + 300000L;
        this.bitmapCX2 = this.UCVideoCut_TimerMouse(this.stopTimerVal);
        this.labelStopTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal);
        this.Invalidate(new Rectangle(0, 536, this.Width, 600));
        Application.DoEvents();
      }
      Process process = new Process()
      {
        StartInfo = new ProcessStartInfo("cmd.exe")
        {
          UseShellExecute = false
        }
      };
      process.StartInfo.RedirectStandardInput = true;
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.CreateNoWindow = true;
      process.Start();
      string str = string.Format("ffmpeg -display_rotation {6} -ss {4} -t {5} -i \"{0}\" -y -r {1} -s {2}x{3} -f image2 \"{7}%04d.bmp\"", (object) this.myName, (object) this.originalImageHz, (object) (this.wVal * 4), (object) (this.hVal * 4), (object) this.UCVideoCut_LongToTimer(this.startTimerVal), (object) this.UCVideoCut_LongToTimer(this.stopTimerVal - this.startTimerVal), (object) this.bitAngle, (object) this.allPicAddr);
      process.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
      process.StandardInput.WriteLine(str);
      Thread.Sleep(100);
      process.Close();
      process.Dispose();
    }
    else if (this.is1280x480)
    {
      this.KillFFmpegYulan();
      this.ResetAllTempFile();
      if (this.stopTimerVal - this.startTimerVal > 300000L)
      {
        this.stopTimerVal = this.startTimerVal + 300000L;
        this.bitmapCX2 = this.UCVideoCut_TimerMouse(this.stopTimerVal);
        this.labelStopTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal);
        this.Invalidate(new Rectangle(0, 536, this.Width, 600));
        Application.DoEvents();
      }
      Process process = new Process()
      {
        StartInfo = new ProcessStartInfo("cmd.exe")
        {
          UseShellExecute = false
        }
      };
      process.StartInfo.RedirectStandardInput = true;
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.CreateNoWindow = true;
      process.Start();
      string str = string.Format("ffmpeg -display_rotation {6} -ss {4} -t {5} -i \"{0}\" -y -r {1} -s {2}x{3} -f image2 \"{7}%04d.bmp\"", (object) this.myName, (object) this.originalImageHz, (object) (int) ((double) this.wVal / 0.375), (object) (int) ((double) this.hVal / 0.375), (object) this.UCVideoCut_LongToTimer(this.startTimerVal), (object) this.UCVideoCut_LongToTimer(this.stopTimerVal - this.startTimerVal), (object) this.bitAngle, (object) this.allPicAddr);
      process.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
      process.StandardInput.WriteLine(str);
      Thread.Sleep(100);
      process.Close();
      process.Dispose();
    }
    else if (this.is640x480 || this.is800x480 || this.is854x480 || this.is960x540 || this.is960x320)
    {
      this.KillFFmpegYulan();
      this.ResetAllTempFile();
      if (this.stopTimerVal - this.startTimerVal > 300000L)
      {
        this.stopTimerVal = this.startTimerVal + 300000L;
        this.bitmapCX2 = this.UCVideoCut_TimerMouse(this.stopTimerVal);
        this.labelStopTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal);
        this.Invalidate(new Rectangle(0, 536, this.Width, 600));
        Application.DoEvents();
      }
      Process process = new Process()
      {
        StartInfo = new ProcessStartInfo("cmd.exe")
        {
          UseShellExecute = false
        }
      };
      process.StartInfo.RedirectStandardInput = true;
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.CreateNoWindow = true;
      process.Start();
      string str = string.Format("ffmpeg -display_rotation {6} -ss {4} -t {5} -i \"{0}\" -y -r {1} -s {2}x{3} -f image2 \"{7}%04d.bmp\"", (object) this.myName, (object) this.originalImageHz, (object) (this.wVal * 2), (object) (this.hVal * 2), (object) this.UCVideoCut_LongToTimer(this.startTimerVal), (object) this.UCVideoCut_LongToTimer(this.stopTimerVal - this.startTimerVal), (object) this.bitAngle, (object) this.allPicAddr);
      process.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
      process.StandardInput.WriteLine(str);
      Thread.Sleep(100);
      process.Close();
      process.Dispose();
    }
    else if (isFF)
    {
      if (this.stopTimerVal - this.startTimerVal > 300000L)
      {
        this.stopTimerVal = this.startTimerVal + 300000L;
        this.bitmapCX2 = this.UCVideoCut_TimerMouse(this.stopTimerVal);
        this.labelStopTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal);
        this.Invalidate(new Rectangle(0, 536, this.Width, 600));
        Application.DoEvents();
      }
      this.ResetAllTempFile();
      Process process = new Process()
      {
        StartInfo = new ProcessStartInfo("cmd.exe")
        {
          UseShellExecute = false
        }
      };
      process.StartInfo.RedirectStandardInput = true;
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.CreateNoWindow = true;
      process.Start();
      string str = string.Format("ffmpeg -display_rotation {6} -ss {4} -t {5} -i \"{0}\" -y -r {1} -s {2}x{3} -f image2 \"{7}%04d.bmp\"", (object) this.myName, (object) this.originalImageHz, (object) this.wVal, (object) this.hVal, (object) this.UCVideoCut_LongToTimer(this.startTimerVal), (object) this.UCVideoCut_LongToTimer(this.stopTimerVal - this.startTimerVal), (object) this.bitAngle, (object) this.allPicAddr);
      process.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
      process.StandardInput.WriteLine(str);
      Thread.Sleep(100);
      process.Close();
      process.Dispose();
    }
    ArrayList arrayList = new ArrayList();
    FileStream output = new FileStream(this.allPicAddr + "Theme.zt", FileMode.OpenOrCreate);
    BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
    int num1 = 1;
    double num2 = 1000.0 / (double) this.originalImageHz;
    int num3 = 0;
    int num4 = (int) ((double) (this.stopTimerVal - this.startTimerVal) / 1000.0 * (double) this.originalImageHz);
    int num5 = 24;
    binaryWriter.Write((byte) 220);
    while (num3 < 100)
    {
      string str = num1.ToString("0000");
      if (File.Exists($"{this.allPicAddr}{str}.bmp"))
      {
        try
        {
          Image image = Image.FromFile($"{this.allPicAddr}{str}.bmp");
          Bitmap Bit = new Bitmap(this.is1600x720 || this.is1920x462 ? this.wValSub * 4 : (this.is640x480 || this.is800x480 || this.is854x480 || this.is960x540 || this.is960x320 ? this.wValSub * 2 : (this.is1280x480 ? (int) ((double) this.wValSub / 0.375) : this.wValSub)), this.is1600x720 || this.is1920x462 ? this.hValSub * 4 : (this.is640x480 || this.is800x480 || this.is854x480 || this.is960x540 || this.is960x320 ? this.hValSub * 2 : (this.is1280x480 ? (int) ((double) this.hValSub / 0.375) : this.hValSub)));
          Graphics graphics = Graphics.FromImage((Image) Bit);
          graphics.DrawImage(image, this.is1600x720 || this.is1920x462 ? this.xVal * 4 : (this.is640x480 || this.is800x480 || this.is854x480 || this.is960x540 || this.is960x320 ? this.xVal * 2 : (this.is1280x480 ? (int) ((double) this.xVal / 0.375) : this.xVal)), this.is1600x720 || this.is1920x462 ? this.yVal * 4 : (this.is640x480 || this.is800x480 || this.is854x480 || this.is960x540 || this.is960x320 ? this.yVal * 2 : (this.is1280x480 ? (int) ((double) this.yVal / 0.375) : this.yVal)));
          graphics.Dispose();
          image.Dispose();
          byte[] numArray = this.BitmapToByte(Bit);
          arrayList.Add((object) numArray);
          Bit.Dispose();
          File.Delete($"{this.allPicAddr}{str}.bmp");
          int num6 = (int) ((double) num1 * 1.0 / (double) num4 * (double) this.bitmapJDW);
          if (num6 > this.bitmapJDW)
            num6 = this.bitmapJDW;
          this.jindu = num6;
          if (this.jindu >= num5)
          {
            num5 = this.jindu + 24;
            this.Invalidate(new Rectangle(0, 536, this.Width, 600));
            Application.DoEvents();
          }
          num3 = 0;
          ++num1;
        }
        catch
        {
          Thread.Sleep(1);
        }
      }
      else
      {
        ++num3;
        Thread.Sleep(1);
      }
    }
    binaryWriter.Write(num1 - 1);
    for (int index = 1; index < num1; ++index)
    {
      int num7 = (int) (num2 * (double) index);
      binaryWriter.Write(num7);
    }
    for (int index = 0; index < arrayList.Count; ++index)
    {
      byte[] buffer = (byte[]) arrayList[index];
      binaryWriter.Write(buffer.Length);
      binaryWriter.Write(buffer);
    }
    binaryWriter.Flush();
    binaryWriter.Close();
    binaryWriter.Dispose();
    output.Close();
    output.Dispose();
    arrayList.Clear();
    this.jindu = 0;
  }

  private void buttonTPJCOK_Click(object sender, EventArgs e)
  {
    if (this.isZhuanma)
      return;
    this.isZhuanma = true;
    bool flag = !this.isYulan;
    this.KillFFmpegYulan(flag);
    this.labelInfo.Show();
    Application.DoEvents();
    this.ZhuanMaPanDuan(flag);
    ArrayList array = new ArrayList();
    array.Add((object) (this.allPicAddr + "Theme.zt"));
    UCVideoCut.delegateUCVideoCut ucVideoCut = this.ucVideoCut;
    if (ucVideoCut != null)
      ucVideoCut(array);
    array.Clear();
    this.labelInfo.Hide();
    this.isZhuanma = false;
  }

  private void buttonYulan_Click(object sender, EventArgs e)
  {
    if (this.isZhuanma || this.isYulan)
      return;
    this.KillFFmpegYulan();
    this.ResetAllTempFile();
    Process process = new Process()
    {
      StartInfo = new ProcessStartInfo("cmd.exe")
      {
        UseShellExecute = false
      }
    };
    process.StartInfo.RedirectStandardInput = true;
    process.StartInfo.RedirectStandardOutput = true;
    process.StartInfo.CreateNoWindow = true;
    process.Start();
    string str = string.Format("ffmpeg -display_rotation {6} -ss {4} -t {5} -i \"{0}\" -y -r {1} -s {2}x{3} -f image2 \"{7}%04d.bmp\"", (object) this.myName, (object) this.originalImageHz, (object) this.wVal, (object) this.hVal, (object) this.UCVideoCut_LongToTimer(this.startTimerVal), (object) this.UCVideoCut_LongToTimer(this.stopTimerVal - this.startTimerVal), (object) this.bitAngle, (object) this.allPicAddr);
    process.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
    process.StandardInput.WriteLine(str);
    process.Close();
    process.Dispose();
    this.yuLanHz = this.originalImageHz;
    this.isYulan = true;
    this.buttonYulan.BackgroundImage = (Image) Resources.P0预览a;
  }

  private long UCVideoCut_MouseTimer(int val)
  {
    double num = (double) this.originalTimerLen * 1.0 / 480.0;
    return (long) ((double) (val - 9) * num);
  }

  private int UCVideoCut_TimerMouse(long timer)
  {
    int num = 480;
    return (int) Math.Round((double) timer * 1.0 / (double) this.originalTimerLen * (double) num + 9.0, 0);
  }

  private long UCVideoCut_TimerToLong(string timer)
  {
    string str1 = timer.Split(':')[2];
    string str2 = str1.Substring(0, str1.IndexOf("."));
    string str3 = str1.Substring(str1.IndexOf(".") + 1);
    double num = (double) Convert.ToInt32(str2) + (double) Convert.ToInt32(str3) * Math.Pow(10.0, (double) -str3.Length);
    return (long) (Math.Round((double) (Convert.ToInt32(timer.Split(':')[0]) * 3600 + Convert.ToInt32(timer.Split(':')[1]) * 60) + num, 2) * 1000.0);
  }

  private string UCVideoCut_LongToTimer(long val)
  {
    int num1 = (int) (val % 1000L);
    val /= 1000L;
    int num2 = (int) (val % 60L);
    val /= 60L;
    int num3 = (int) (val % 60L);
    return $"{((int) (val / 60L)).ToString("00")}:{num3.ToString("00")}:{num2.ToString("00")}.{num1.ToString("000")}";
  }

  private void GetOneImage(string timer)
  {
    if (this.isGetOneImage)
      return;
    this.isGetOneImage = true;
    File.Delete(this.onePic);
    Process process = new Process()
    {
      StartInfo = new ProcessStartInfo("cmd.exe")
      {
        UseShellExecute = false
      }
    };
    process.StartInfo.RedirectStandardInput = true;
    process.StartInfo.RedirectStandardOutput = true;
    process.StartInfo.CreateNoWindow = true;
    process.Start();
    if (this.UCVideoCut_TimerToLong(timer) + 1000L > this.originalTimerLen)
      timer = this.UCVideoCut_LongToTimer(this.originalTimerLen - 1000L);
    string str = string.Format("ffmpeg -display_rotation {5} -ss {3} -i \"{0}\" -y -s {1}x{2} -frames:v 1 -f image2 \"{4}\"", (object) this.myName, (object) this.wVal, (object) this.hVal, (object) timer, (object) this.onePic, (object) this.bitAngle);
    process.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
    process.StandardInput.WriteLine(str);
    int num = 0;
    while (!File.Exists(this.onePic))
    {
      Thread.Sleep(1);
      ++num;
      if (num >= 100)
      {
        this.isGetOneImage = false;
        return;
      }
    }
    process.Close();
    process.Dispose();
    if (this.imageSub != null)
    {
      this.imageSub.Dispose();
      this.imageSub = (Bitmap) null;
    }
    this.imageSub = new Bitmap(this.wValSub, this.hValSub);
    Image image = Image.FromFile(this.onePic);
    Graphics graphics = Graphics.FromImage((Image) this.imageSub);
    graphics.DrawImage(image, this.xVal, this.yVal);
    graphics.Dispose();
    image.Dispose();
    this.Invalidate();
    this.isGetOneImage = false;
  }

  private void UCVideoCut_MouseDown(object sender, MouseEventArgs e)
  {
    if (this.isZhuanma)
      return;
    this.isMouseMove = false;
    if (e.Y < 546 || e.Y > 592)
      return;
    this.xPos = e.X;
    this.yPos = e.Y;
    if (this.xPos < 9)
      this.xPos = 9;
    if (this.xPos > 489)
      this.xPos = 489;
    if (Math.Abs(this.xPos - this.bitmapCX1) < 15 && Math.Abs(this.yPos - this.bitmapCY1) < 15)
    {
      this.KillFFmpegYulan();
      this.isMouseDown1 = true;
      this.bitmapCX1 = this.xPos;
      if (this.bitmapCX1 >= this.bitmapCX2)
        this.bitmapCX1 = this.bitmapCX2 - 1;
      this.startTimerVal = this.UCVideoCut_MouseTimer(this.bitmapCX1);
      this.labelStartTimer.Text = this.UCVideoCut_LongToTimer(this.startTimerVal);
      if (this.stopTimerVal - this.startTimerVal > 300000L)
      {
        this.stopTimerVal = this.startTimerVal + 300000L;
        this.bitmapCX2 = this.UCVideoCut_TimerMouse(this.stopTimerVal);
        this.labelStopTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal);
      }
      this.labelTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal - this.startTimerVal);
      this.Invalidate(new Rectangle(0, 536, this.Width, 600));
    }
    else if (Math.Abs(this.xPos - this.bitmapCX2) < 15 && Math.Abs(this.yPos - this.bitmapCY2) < 15)
    {
      this.KillFFmpegYulan();
      this.isMouseDown2 = true;
      this.bitmapCX2 = this.xPos;
      if (this.bitmapCX1 >= this.bitmapCX2)
        this.bitmapCX2 = this.bitmapCX1 + 1;
      this.stopTimerVal = this.UCVideoCut_MouseTimer(this.bitmapCX2);
      this.labelStopTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal);
      if (this.stopTimerVal - this.startTimerVal > 300000L)
      {
        this.startTimerVal = this.stopTimerVal - 300000L;
        this.bitmapCX1 = this.UCVideoCut_TimerMouse(this.startTimerVal);
        this.labelStartTimer.Text = this.UCVideoCut_LongToTimer(this.startTimerVal);
      }
      this.labelTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal - this.startTimerVal);
      this.Invalidate(new Rectangle(0, 536, this.Width, 600));
    }
  }

  private void UCVideoCut_MouseMove(object sender, MouseEventArgs e)
  {
    if (this.isMouseDown1)
    {
      if (this.isMouseMove)
        return;
      this.isMouseMove = true;
      this.xPos = e.X;
      if (this.xPos < 9)
        this.xPos = 9;
      if (this.xPos > 489)
        this.xPos = 489;
      this.bitmapCX1 = this.xPos;
      if (this.bitmapCX1 >= this.bitmapCX2)
        this.bitmapCX1 = this.bitmapCX2 - 1;
      this.startTimerVal = this.UCVideoCut_MouseTimer(this.bitmapCX1);
      this.labelStartTimer.Text = this.UCVideoCut_LongToTimer(this.startTimerVal);
      if (this.stopTimerVal - this.startTimerVal > 300000L)
      {
        this.stopTimerVal = this.startTimerVal + 300000L;
        this.bitmapCX2 = this.UCVideoCut_TimerMouse(this.stopTimerVal);
        this.labelStopTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal);
      }
      this.labelTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal - this.startTimerVal);
      this.Invalidate(new Rectangle(0, 536, this.Width, 600));
      this.isMouseMove = false;
    }
    else
    {
      if (!this.isMouseDown2 || this.isMouseMove)
        return;
      this.isMouseMove = true;
      this.xPos = e.X;
      if (this.xPos < 9)
        this.xPos = 9;
      if (this.xPos > 489)
        this.xPos = 489;
      this.bitmapCX2 = this.xPos;
      if (this.bitmapCX1 >= this.bitmapCX2)
        this.bitmapCX2 = this.bitmapCX1 + 1;
      this.stopTimerVal = this.UCVideoCut_MouseTimer(this.bitmapCX2);
      this.labelStopTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal);
      if (this.stopTimerVal - this.startTimerVal > 300000L)
      {
        this.startTimerVal = this.stopTimerVal - 300000L;
        this.bitmapCX1 = this.UCVideoCut_TimerMouse(this.startTimerVal);
        this.labelStartTimer.Text = this.UCVideoCut_LongToTimer(this.startTimerVal);
      }
      this.labelTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal - this.startTimerVal);
      this.Invalidate(new Rectangle(0, 536, this.Width, 600));
      this.isMouseMove = false;
    }
  }

  private void UCVideoCut_MouseUp(object sender, MouseEventArgs e)
  {
    if (this.isMouseDown1)
    {
      this.isMouse1 = true;
      this.isMouse2 = false;
      this.ResetAllTempFile();
      this.GetOneImage(this.labelStartTimer.Text);
    }
    if (this.isMouseDown2)
    {
      this.isMouse1 = false;
      this.isMouse2 = true;
      this.ResetAllTempFile();
      this.GetOneImage(this.labelStopTimer.Text);
    }
    this.isMouseDown1 = false;
    this.isMouseDown2 = false;
    this.isMouseMove = false;
  }

  public void SetImage(string name)
  {
    if (this.isZhuanma)
      return;
    this.KillFFmpegYulan();
    this.jindu = 0;
    this.isGetVideoInfo = false;
    this.myName = name;
    this.bitmapCX1 = 9;
    this.bitmapCX2 = 489;
    this.ResetAllTempFile();
    Process process1 = new Process()
    {
      StartInfo = new ProcessStartInfo("cmd.exe")
      {
        UseShellExecute = false
      }
    };
    process1.StartInfo.RedirectStandardInput = true;
    process1.StartInfo.RedirectStandardOutput = true;
    process1.StartInfo.CreateNoWindow = true;
    process1.Start();
    string str1 = $"ffmpeg -i \"{name}\" > \"{Application.StartupPath}\\log.txt\" 2>&1";
    process1.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
    process1.StandardInput.WriteLine(str1);
    process1.StandardInput.WriteLine("");
    process1.StandardInput.WriteLine("exit");
    process1.WaitForExit();
    process1.Close();
    process1.Dispose();
    FileStream fileStream = (FileStream) null;
    StreamReader streamReader = (StreamReader) null;
    try
    {
      try
      {
        fileStream = new FileStream(Application.StartupPath + "\\log.txt", FileMode.Open);
        streamReader = new StreamReader((Stream) fileStream);
        str1 = streamReader.ReadToEnd();
        streamReader.Close();
        streamReader.Dispose();
        fileStream.Close();
        fileStream.Dispose();
      }
      catch
      {
        try
        {
          streamReader.Close();
          streamReader.Dispose();
        }
        catch
        {
        }
        try
        {
          fileStream.Close();
          fileStream.Dispose();
        }
        catch
        {
        }
      }
      string str2 = str1.Substring(str1.IndexOf("Duration: ") + 10);
      string timer = str2.Substring(0, str2.IndexOf(","));
      this.labelAllTimer.Text = timer;
      this.labelStopTimer.Text = timer;
      this.labelStartTimer.Text = "00:00:00.000";
      this.originalTimerLen = this.UCVideoCut_TimerToLong(timer);
      this.startTimerVal = 0L;
      this.stopTimerVal = this.originalTimerLen;
      if (this.stopTimerVal > 300000L)
      {
        this.stopTimerVal = 300000L;
        this.bitmapCX2 = this.UCVideoCut_TimerMouse(this.stopTimerVal);
        this.labelStopTimer.Text = this.UCVideoCut_LongToTimer(this.stopTimerVal);
      }
      this.labelTimer.Text = this.labelStopTimer.Text;
      if (str2.Contains("Video: av1"))
      {
        switch (Form1.Language)
        {
          case 1:
            int num1 = (int) MessageBox.Show("不支持AV1的编码格式！请使用专业转码软件将视频文件转码为分辨率小于3840X2160，编码格式为H.264的MP4文件。");
            break;
          case 2:
            int num2 = (int) MessageBox.Show("不支持AV1的編碼格式！請使用專業轉碼軟件將視頻檔案轉碼為分辯率小於3840X2160，編碼格式為H.264的MP4檔案。");
            break;
          default:
            int num3 = (int) MessageBox.Show("The encoding format of AV1 is not supported! Please use professional transcoding software to transcode video files into MP4 files with a resolution of less than 3840X2160 and an encoding format of H.264.");
            break;
        }
      }
      else
      {
        string str3 = str2.Substring(str2.IndexOf("Video: ") + 7);
        try
        {
          str3 = str3.Substring(0, str3.IndexOf("Metadata:"));
        }
        catch
        {
        }
        char[] videoRatio = this.GetVideoRatio(str3.ToCharArray());
        if (videoRatio != null)
        {
          string str4 = new string(videoRatio);
          try
          {
            this.bitAngleW = this.originalImageW = Convert.ToInt32(str4.Split('x')[0]);
            this.bitAngleH = this.originalImageH = Convert.ToInt32(str4.Split('x')[1]);
            this.bitAngle = 0;
            this.isGetVideoInfo = true;
          }
          catch
          {
          }
        }
        if (!this.isGetVideoInfo)
        {
          switch (Form1.Language)
          {
            case 1:
              int num4 = (int) MessageBox.Show("格式不支持，请修改文件路径和文件名为纯英文再试，如若依然不支持，请使用第三方转码软件将视频文件转码为H.264的MP4文件");
              break;
            case 2:
              int num5 = (int) MessageBox.Show("格式不支持，請修改檔案路徑和檔名為純英文再試，如若依然不支持，請使用專業轉碼軟件將視頻檔案轉碼為H.264的MP4檔案。");
              break;
            default:
              int num6 = (int) MessageBox.Show("The format is not supported. Please try changing the path and name to pure English and try again. If the error persists, please use professional video transcoding software to convert the video file into an MP4 file encoded as H.264.");
              break;
          }
        }
      }
    }
    catch
    {
      this.isGetVideoInfo = false;
      switch (Form1.Language)
      {
        case 1:
          int num7 = (int) MessageBox.Show("格式不支持，请修改文件路径和文件名为纯英文再试，如若依然不支持，请使用第三方转码软件将视频文件转码为H.264的MP4文件");
          break;
        case 2:
          int num8 = (int) MessageBox.Show("格式不支持，請修改檔案路徑和檔名為純英文再試，如若依然不支持，請使用專業轉碼軟件將視頻檔案轉碼為H.264的MP4檔案。");
          break;
        default:
          int num9 = (int) MessageBox.Show("The format is not supported. Please try changing the path and name to pure English and try again. If the error persists, please use professional video transcoding software to convert the video file into an MP4 file encoded as H.264.");
          break;
      }
    }
    finally
    {
      try
      {
        File.Delete(Application.StartupPath + "\\log.txt");
      }
      catch
      {
      }
    }
    if (this.isGetVideoInfo && this.originalImageW * this.originalImageH > 8294400)
    {
      this.isGetVideoInfo = false;
      switch (Form1.Language)
      {
        case 1:
          int num10 = (int) MessageBox.Show("分辨率过高！请使用专业转码软件将视频文件转码为分辨率小于3840X2160，编码格式为H.264的MP4文件。");
          break;
        case 2:
          int num11 = (int) MessageBox.Show("分辯率過高！請使用專業轉碼軟件將視頻檔案轉碼為分辯率小於3840X2160，編碼格式為H.264的MP4檔案。");
          break;
        default:
          int num12 = (int) MessageBox.Show("The resolution is too high!  Please use professional transcoding software to transcode the video file into an MP4 file with a resolution of less than 3840X2160 and an encoding format of H.264.");
          break;
      }
    }
    if (!this.isGetVideoInfo)
    {
      UCVideoCut.delegateUCVideoCut ucVideoCut = this.ucVideoCut;
      if (ucVideoCut == null)
        return;
      ucVideoCut((ArrayList) null);
    }
    else
    {
      if (this.is240x240)
      {
        this.xValSub = 130;
        this.yValSub = 130;
        this.wValSub = 240 /*0xF0*/;
        this.hValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        if (this.bitAngleH > this.bitAngleW)
        {
          this.hVal = 240 /*0xF0*/;
          this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
          this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 240 /*0xF0*/;
          this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
          this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else if (this.is320x320)
      {
        this.xValSub = 90;
        this.yValSub = 90;
        this.wValSub = 320;
        this.hValSub = 320;
        this.xVal = 0;
        this.yVal = 0;
        if (this.bitAngleH > this.bitAngleW)
        {
          this.hVal = 320;
          this.wVal = this.bitAngleW * 320 / this.bitAngleH;
          this.xVal += (320 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 320;
          this.hVal = this.bitAngleH * 320 / this.bitAngleW;
          this.yVal += (320 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else if (this.is360x360)
      {
        this.xValSub = 70;
        this.yValSub = 70;
        this.wValSub = 360;
        this.hValSub = 360;
        this.xVal = 0;
        this.yVal = 0;
        if (this.bitAngleH > this.bitAngleW)
        {
          this.hVal = 360;
          this.wVal = this.bitAngleW * 360 / this.bitAngleH;
          this.xVal += (360 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 360;
          this.hVal = this.bitAngleH * 360 / this.bitAngleW;
          this.yVal += (360 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else if (this.is480x480)
      {
        this.xValSub = 10;
        this.yValSub = 10;
        this.wValSub = 480;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        if (this.bitAngleH > this.bitAngleW)
        {
          this.hVal = 480;
          this.wVal = this.bitAngleW * 480 / this.bitAngleH;
          this.xVal += (480 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 480;
          this.hVal = this.bitAngleH * 480 / this.bitAngleW;
          this.yVal += (480 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else if (this.is1600x720)
      {
        if (this.isFanZhuan)
        {
          this.yValSub = 50;
          this.xValSub = 160 /*0xA0*/;
          this.hValSub = 400;
          this.wValSub = 180;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleH * 0.45 > (double) this.bitAngleW)
          {
            this.hVal = 400;
            this.wVal = this.bitAngleW * 400 / this.bitAngleH;
            this.xVal += (180 - this.wVal) / 2;
            this.isTPJCW = false;
          }
          else
          {
            this.wVal = 180;
            this.hVal = this.bitAngleH * 180 / this.bitAngleW;
            this.yVal += (400 - this.hVal) / 2;
            this.isTPJCW = true;
          }
        }
        else
        {
          this.xValSub = 50;
          this.yValSub = 160 /*0xA0*/;
          this.wValSub = 400;
          this.hValSub = 180;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleW * 0.45 > (double) this.bitAngleH)
          {
            this.wVal = 400;
            this.hVal = this.bitAngleH * 400 / this.bitAngleW;
            this.yVal += (180 - this.hVal) / 2;
            this.isTPJCW = true;
          }
          else
          {
            this.hVal = 180;
            this.wVal = this.bitAngleW * 180 / this.bitAngleH;
            this.xVal += (400 - this.wVal) / 2;
            this.isTPJCW = false;
          }
        }
      }
      else if (this.is800x480)
      {
        if (this.isFanZhuan)
        {
          this.yValSub = 50;
          this.xValSub = 130;
          this.hValSub = 400;
          this.wValSub = 240 /*0xF0*/;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleH * 0.6 > (double) this.bitAngleW)
          {
            this.hVal = 400;
            this.wVal = this.bitAngleW * 400 / this.bitAngleH;
            this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
            this.isTPJCW = false;
          }
          else
          {
            this.wVal = 240 /*0xF0*/;
            this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
            this.yVal += (400 - this.hVal) / 2;
            this.isTPJCW = true;
          }
        }
        else
        {
          this.xValSub = 50;
          this.yValSub = 130;
          this.wValSub = 400;
          this.hValSub = 240 /*0xF0*/;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleW * 0.6 > (double) this.bitAngleH)
          {
            this.wVal = 400;
            this.hVal = this.bitAngleH * 400 / this.bitAngleW;
            this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
            this.isTPJCW = true;
          }
          else
          {
            this.hVal = 240 /*0xF0*/;
            this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
            this.xVal += (400 - this.wVal) / 2;
            this.isTPJCW = false;
          }
        }
      }
      else if (this.is854x480)
      {
        if (this.isFanZhuan)
        {
          this.yValSub = 36;
          this.xValSub = 130;
          this.hValSub = 427;
          this.wValSub = 240 /*0xF0*/;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleH * 0.56206 > (double) this.bitAngleW)
          {
            this.hVal = 427;
            this.wVal = this.bitAngleW * 427 / this.bitAngleH;
            this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
            this.isTPJCW = false;
          }
          else
          {
            this.wVal = 240 /*0xF0*/;
            this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
            this.yVal += (427 - this.hVal) / 2;
            this.isTPJCW = true;
          }
        }
        else
        {
          this.xValSub = 36;
          this.yValSub = 130;
          this.wValSub = 427;
          this.hValSub = 240 /*0xF0*/;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleW * 0.56206 > (double) this.bitAngleH)
          {
            this.wVal = 427;
            this.hVal = this.bitAngleH * 427 / this.bitAngleW;
            this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
            this.isTPJCW = true;
          }
          else
          {
            this.hVal = 240 /*0xF0*/;
            this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
            this.xVal += (427 - this.wVal) / 2;
            this.isTPJCW = false;
          }
        }
      }
      else if (this.is960x540)
      {
        if (this.isFanZhuan)
        {
          this.yValSub = 10;
          this.xValSub = 115;
          this.hValSub = 480;
          this.wValSub = 270;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleH * (9.0 / 16.0) > (double) this.bitAngleW)
          {
            this.hVal = 480;
            this.wVal = this.bitAngleW * 480 / this.bitAngleH;
            this.xVal += (270 - this.wVal) / 2;
            this.isTPJCW = false;
          }
          else
          {
            this.wVal = 270;
            this.hVal = this.bitAngleH * 270 / this.bitAngleW;
            this.yVal += (480 - this.hVal) / 2;
            this.isTPJCW = true;
          }
        }
        else
        {
          this.xValSub = 10;
          this.yValSub = 115;
          this.wValSub = 480;
          this.hValSub = 270;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleW * (9.0 / 16.0) > (double) this.bitAngleH)
          {
            this.wVal = 480;
            this.hVal = this.bitAngleH * 480 / this.bitAngleW;
            this.yVal += (270 - this.hVal) / 2;
            this.isTPJCW = true;
          }
          else
          {
            this.hVal = 270;
            this.wVal = this.bitAngleW * 270 / this.bitAngleH;
            this.xVal += (480 - this.wVal) / 2;
            this.isTPJCW = false;
          }
        }
      }
      else if (this.is960x320)
      {
        if (this.isFanZhuan)
        {
          this.yValSub = 10;
          this.xValSub = 170;
          this.hValSub = 480;
          this.wValSub = 160 /*0xA0*/;
          this.xVal = 0;
          this.yVal = 0;
          if (this.bitAngleH > this.bitAngleW * 3)
          {
            this.hVal = 480;
            this.wVal = this.bitAngleW * 480 / this.bitAngleH;
            this.xVal += (160 /*0xA0*/ - this.wVal) / 2;
            this.isTPJCW = false;
          }
          else
          {
            this.wVal = 160 /*0xA0*/;
            this.hVal = this.bitAngleH * 160 /*0xA0*/ / this.bitAngleW;
            this.yVal += (480 - this.hVal) / 2;
            this.isTPJCW = true;
          }
        }
        else
        {
          this.xValSub = 10;
          this.yValSub = 170;
          this.wValSub = 480;
          this.hValSub = 160 /*0xA0*/;
          this.xVal = 0;
          this.yVal = 0;
          if (this.bitAngleW > this.bitAngleH * 3)
          {
            this.wVal = 480;
            this.hVal = this.bitAngleH * 480 / this.bitAngleW;
            this.yVal += (160 /*0xA0*/ - this.hVal) / 2;
            this.isTPJCW = true;
          }
          else
          {
            this.hVal = 160 /*0xA0*/;
            this.wVal = this.bitAngleW * 160 /*0xA0*/ / this.bitAngleH;
            this.xVal += (480 - this.wVal) / 2;
            this.isTPJCW = false;
          }
        }
      }
      else if (this.is1920x462)
      {
        if (this.isFanZhuan)
        {
          this.yValSub = 10;
          this.xValSub = 192 /*0xC0*/;
          this.hValSub = 480;
          this.wValSub = 116;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleH * (77.0 / 320.0) > (double) this.bitAngleW)
          {
            this.hVal = 480;
            this.wVal = this.bitAngleW * 480 / this.bitAngleH;
            this.xVal += (116 - this.wVal) / 2;
            this.isTPJCW = false;
          }
          else
          {
            this.wVal = 116;
            this.hVal = this.bitAngleH * 116 / this.bitAngleW;
            this.yVal += (480 - this.hVal) / 2;
            this.isTPJCW = true;
          }
        }
        else
        {
          this.xValSub = 10;
          this.yValSub = 192 /*0xC0*/;
          this.wValSub = 480;
          this.hValSub = 116;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleW * (77.0 / 320.0) > (double) this.bitAngleH)
          {
            this.wVal = 480;
            this.hVal = this.bitAngleH * 480 / this.bitAngleW;
            this.yVal += (116 - this.hVal) / 2;
            this.isTPJCW = true;
          }
          else
          {
            this.hVal = 116;
            this.wVal = this.bitAngleW * 116 / this.bitAngleH;
            this.xVal += (480 - this.wVal) / 2;
            this.isTPJCW = false;
          }
        }
      }
      else if (this.is1280x480)
      {
        if (this.isFanZhuan)
        {
          this.yValSub = 10;
          this.xValSub = 160 /*0xA0*/;
          this.hValSub = 480;
          this.wValSub = 180;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleH * 0.375 > (double) this.bitAngleW)
          {
            this.hVal = 480;
            this.wVal = this.bitAngleW * 480 / this.bitAngleH;
            this.xVal += (180 - this.wVal) / 2;
            this.isTPJCW = false;
          }
          else
          {
            this.wVal = 180;
            this.hVal = this.bitAngleH * 180 / this.bitAngleW;
            this.yVal += (480 - this.hVal) / 2;
            this.isTPJCW = true;
          }
        }
        else
        {
          this.xValSub = 10;
          this.yValSub = 160 /*0xA0*/;
          this.wValSub = 480;
          this.hValSub = 180;
          this.xVal = 0;
          this.yVal = 0;
          if ((double) this.bitAngleW * 0.375 > (double) this.bitAngleH)
          {
            this.wVal = 480;
            this.hVal = this.bitAngleH * 480 / this.bitAngleW;
            this.yVal += (180 - this.hVal) / 2;
            this.isTPJCW = true;
          }
          else
          {
            this.hVal = 180;
            this.wVal = this.bitAngleW * 180 / this.bitAngleH;
            this.xVal += (480 - this.wVal) / 2;
            this.isTPJCW = false;
          }
        }
      }
      else if (this.isFanZhuan)
      {
        this.xValSub = 130;
        this.yValSub = 90;
        this.wValSub = 240 /*0xF0*/;
        this.hValSub = 320;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleH * 0.75 > (double) this.bitAngleW)
        {
          this.hVal = 320;
          this.wVal = this.bitAngleW * 320 / this.bitAngleH;
          this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 240 /*0xF0*/;
          this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
          this.yVal += (320 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.xValSub = 90;
        this.yValSub = 130;
        this.wValSub = 320;
        this.hValSub = 240 /*0xF0*/;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleW * 0.75 > (double) this.bitAngleH)
        {
          this.wVal = 320;
          this.hVal = this.bitAngleH * 320 / this.bitAngleW;
          this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 240 /*0xF0*/;
          this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
          this.xVal += (320 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
      Process process2 = new Process()
      {
        StartInfo = new ProcessStartInfo("cmd.exe")
        {
          UseShellExecute = false
        }
      };
      process2.StartInfo.RedirectStandardInput = true;
      process2.StartInfo.RedirectStandardOutput = true;
      process2.StartInfo.CreateNoWindow = true;
      process2.Start();
      string str5 = $"ffmpeg -i \"{this.myName}\" -y -s {this.wVal}x{this.hVal} -ss {this.startTimerVal} -frames:v 1 -f image2 \"{this.onePic}\"";
      process2.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
      process2.StandardInput.WriteLine(str5);
      process2.StandardInput.WriteLine("");
      process2.StandardInput.WriteLine("exit");
      process2.WaitForExit();
      process2.Close();
      process2.Dispose();
      if (this.imageSub != null)
      {
        this.imageSub.Dispose();
        this.imageSub = (Bitmap) null;
      }
      this.imageSub = new Bitmap(this.wValSub, this.hValSub);
      Image image = Image.FromFile(this.onePic);
      Graphics graphics = Graphics.FromImage((Image) this.imageSub);
      graphics.DrawImage(image, this.xVal, this.yVal);
      graphics.Dispose();
      image.Dispose();
      this.Invalidate();
    }
  }

  private char[] GetVideoRatio(char[] chs)
  {
    char[] videoRatio = (char[]) null;
    for (int index = 0; index < chs.Length - 8; ++index)
    {
      if (chs[index] >= '0' && chs[index] <= '9' && chs[index + 1] >= '0' && chs[index + 1] <= '9' && chs[index + 2] >= '0' && chs[index + 2] <= '9' && chs[index + 3] >= '0' && chs[index + 3] <= '9' && chs[index + 4] == 'x' && chs[index + 5] >= '0' && chs[index + 5] <= '9' && chs[index + 6] >= '0' && chs[index + 6] <= '9' && chs[index + 7] >= '0' && chs[index + 7] <= '9' && chs[index + 8] >= '0' && chs[index + 8] <= '9')
        return new char[9]
        {
          chs[index],
          chs[index + 1],
          chs[index + 2],
          chs[index + 3],
          chs[index + 4],
          chs[index + 5],
          chs[index + 6],
          chs[index + 7],
          chs[index + 8]
        };
    }
    for (int index = 0; index < chs.Length - 7; ++index)
    {
      if (chs[index] >= '0' && chs[index] <= '9' && chs[index + 1] >= '0' && chs[index + 1] <= '9' && chs[index + 2] >= '0' && chs[index + 2] <= '9' && chs[index + 3] >= '0' && chs[index + 3] <= '9' && chs[index + 4] == 'x' && chs[index + 5] >= '0' && chs[index + 5] <= '9' && chs[index + 6] >= '0' && chs[index + 6] <= '9' && chs[index + 7] >= '0' && chs[index + 7] <= '9')
        return new char[8]
        {
          chs[index],
          chs[index + 1],
          chs[index + 2],
          chs[index + 3],
          chs[index + 4],
          chs[index + 5],
          chs[index + 6],
          chs[index + 7]
        };
    }
    for (int index = 0; index < chs.Length - 7; ++index)
    {
      if (chs[index] >= '0' && chs[index] <= '9' && chs[index + 1] >= '0' && chs[index + 1] <= '9' && chs[index + 2] >= '0' && chs[index + 2] <= '9' && chs[index + 3] == 'x' && chs[index + 4] >= '0' && chs[index + 4] <= '9' && chs[index + 5] >= '0' && chs[index + 5] <= '9' && chs[index + 6] >= '0' && chs[index + 6] <= '9' && chs[index + 7] >= '0' && chs[index + 7] <= '9')
        return new char[8]
        {
          chs[index],
          chs[index + 1],
          chs[index + 2],
          chs[index + 3],
          chs[index + 4],
          chs[index + 5],
          chs[index + 6],
          chs[index + 7]
        };
    }
    for (int index = 0; index < chs.Length - 7; ++index)
    {
      if (chs[index] >= '0' && chs[index] <= '9' && chs[index + 1] >= '0' && chs[index + 1] <= '9' && chs[index + 2] >= '0' && chs[index + 2] <= '9' && chs[index + 3] == 'x' && chs[index + 4] >= '0' && chs[index + 4] <= '9' && chs[index + 5] >= '0' && chs[index + 5] <= '9' && chs[index + 6] >= '0' && chs[index + 6] <= '9')
        return new char[7]
        {
          chs[index],
          chs[index + 1],
          chs[index + 2],
          chs[index + 3],
          chs[index + 4],
          chs[index + 5],
          chs[index + 6]
        };
    }
    return videoRatio;
  }

  private void button1_Click(object sender, EventArgs e)
  {
    this.button1.BackgroundImage = (Image) Resources.P点选框A;
    this.button2.BackgroundImage = (Image) Resources.P点选框;
    this.originalImageHz = 15;
  }

  private void button2_Click(object sender, EventArgs e)
  {
    this.button2.BackgroundImage = (Image) Resources.P点选框A;
    this.button1.BackgroundImage = (Image) Resources.P点选框;
    this.originalImageHz = 24;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonTPJCOK = new Button();
    this.buttonXuanzhuan = new Button();
    this.buttonTPJCW = new Button();
    this.buttonTPJCH = new Button();
    this.buttonYulan = new Button();
    this.buttonClose = new Button();
    this.labelAllTimer = new Label();
    this.labelStartTimer = new Label();
    this.labelStopTimer = new Label();
    this.labelInfo = new Label();
    this.button1 = new Button();
    this.button2 = new Button();
    this.labelTimer = new Label();
    this.SuspendLayout();
    this.buttonTPJCOK.BackColor = Color.Transparent;
    this.buttonTPJCOK.BackgroundImage = (Image) Resources.P裁减;
    this.buttonTPJCOK.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonTPJCOK.FlatAppearance.BorderSize = 0;
    this.buttonTPJCOK.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonTPJCOK.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonTPJCOK.FlatStyle = FlatStyle.Flat;
    this.buttonTPJCOK.Location = new Point(446, 656);
    this.buttonTPJCOK.Margin = new Padding(0);
    this.buttonTPJCOK.Name = "buttonTPJCOK";
    this.buttonTPJCOK.Size = new Size(34, 26);
    this.buttonTPJCOK.TabIndex = 653;
    this.buttonTPJCOK.UseVisualStyleBackColor = false;
    this.buttonTPJCOK.Click += new EventHandler(this.buttonTPJCOK_Click);
    this.buttonXuanzhuan.BackColor = Color.Transparent;
    this.buttonXuanzhuan.BackgroundImage = (Image) Resources.P旋转;
    this.buttonXuanzhuan.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXuanzhuan.FlatAppearance.BorderSize = 0;
    this.buttonXuanzhuan.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXuanzhuan.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXuanzhuan.FlatStyle = FlatStyle.Flat;
    this.buttonXuanzhuan.Location = new Point(297, 656);
    this.buttonXuanzhuan.Margin = new Padding(0);
    this.buttonXuanzhuan.Name = "buttonXuanzhuan";
    this.buttonXuanzhuan.Size = new Size(34, 26);
    this.buttonXuanzhuan.TabIndex = 652;
    this.buttonXuanzhuan.UseVisualStyleBackColor = false;
    this.buttonXuanzhuan.Click += new EventHandler(this.buttonXuanzhuan_Click);
    this.buttonTPJCW.BackColor = Color.Transparent;
    this.buttonTPJCW.BackgroundImage = (Image) Resources.P宽度适应;
    this.buttonTPJCW.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonTPJCW.FlatAppearance.BorderSize = 0;
    this.buttonTPJCW.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonTPJCW.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonTPJCW.FlatStyle = FlatStyle.Flat;
    this.buttonTPJCW.Location = new Point(233, 656);
    this.buttonTPJCW.Margin = new Padding(0);
    this.buttonTPJCW.Name = "buttonTPJCW";
    this.buttonTPJCW.Size = new Size(34, 26);
    this.buttonTPJCW.TabIndex = 651;
    this.buttonTPJCW.UseVisualStyleBackColor = false;
    this.buttonTPJCW.Click += new EventHandler(this.buttonTPJCW_Click);
    this.buttonTPJCH.BackColor = Color.Transparent;
    this.buttonTPJCH.BackgroundImage = (Image) Resources.P高度适应;
    this.buttonTPJCH.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonTPJCH.FlatAppearance.BorderSize = 0;
    this.buttonTPJCH.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonTPJCH.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonTPJCH.FlatStyle = FlatStyle.Flat;
    this.buttonTPJCH.Location = new Point(169, 656);
    this.buttonTPJCH.Margin = new Padding(0);
    this.buttonTPJCH.Name = "buttonTPJCH";
    this.buttonTPJCH.Size = new Size(34, 26);
    this.buttonTPJCH.TabIndex = 650;
    this.buttonTPJCH.UseVisualStyleBackColor = false;
    this.buttonTPJCH.Click += new EventHandler(this.buttonTPJCH_Click);
    this.buttonYulan.BackColor = Color.Transparent;
    this.buttonYulan.BackgroundImage = (Image) Resources.P0预览;
    this.buttonYulan.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonYulan.FlatAppearance.BorderSize = 0;
    this.buttonYulan.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonYulan.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonYulan.FlatStyle = FlatStyle.Flat;
    this.buttonYulan.Location = new Point(233, 513);
    this.buttonYulan.Margin = new Padding(0);
    this.buttonYulan.Name = "buttonYulan";
    this.buttonYulan.Size = new Size(34, 20);
    this.buttonYulan.TabIndex = 654;
    this.buttonYulan.UseVisualStyleBackColor = false;
    this.buttonYulan.Click += new EventHandler(this.buttonYulan_Click);
    this.buttonClose.BackColor = Color.Transparent;
    this.buttonClose.BackgroundImage = (Image) Resources.P关闭按钮;
    this.buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonClose.FlatAppearance.BorderSize = 0;
    this.buttonClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonClose.FlatStyle = FlatStyle.Flat;
    this.buttonClose.Location = new Point(474, 510);
    this.buttonClose.Margin = new Padding(0);
    this.buttonClose.Name = "buttonClose";
    this.buttonClose.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.buttonClose.TabIndex = 655;
    this.buttonClose.UseVisualStyleBackColor = false;
    this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
    this.labelAllTimer.BackColor = Color.Transparent;
    this.labelAllTimer.FlatStyle = FlatStyle.Flat;
    this.labelAllTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelAllTimer.ForeColor = Color.LightGray;
    this.labelAllTimer.Location = new Point(408, 531);
    this.labelAllTimer.Margin = new Padding(0);
    this.labelAllTimer.Name = "labelAllTimer";
    this.labelAllTimer.Size = new Size(88, 20);
    this.labelAllTimer.TabIndex = 700;
    this.labelAllTimer.Text = "00:00:00:000";
    this.labelAllTimer.TextAlign = ContentAlignment.MiddleCenter;
    this.labelStartTimer.BackColor = Color.Transparent;
    this.labelStartTimer.FlatStyle = FlatStyle.Flat;
    this.labelStartTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelStartTimer.ForeColor = Color.LightGray;
    this.labelStartTimer.Location = new Point(32 /*0x20*/, 597);
    this.labelStartTimer.Margin = new Padding(0);
    this.labelStartTimer.Name = "labelStartTimer";
    this.labelStartTimer.Size = new Size(88, 20);
    this.labelStartTimer.TabIndex = 701;
    this.labelStartTimer.Text = "00:00:00:000";
    this.labelStartTimer.TextAlign = ContentAlignment.MiddleCenter;
    this.labelStopTimer.BackColor = Color.Transparent;
    this.labelStopTimer.FlatStyle = FlatStyle.Flat;
    this.labelStopTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelStopTimer.ForeColor = Color.LightGray;
    this.labelStopTimer.Location = new Point(408, 597);
    this.labelStopTimer.Margin = new Padding(0);
    this.labelStopTimer.Name = "labelStopTimer";
    this.labelStopTimer.Size = new Size(88, 20);
    this.labelStopTimer.TabIndex = 702;
    this.labelStopTimer.Text = "00:00:00:000";
    this.labelStopTimer.TextAlign = ContentAlignment.MiddleCenter;
    this.labelInfo.BackColor = Color.Transparent;
    this.labelInfo.FlatStyle = FlatStyle.Flat;
    this.labelInfo.Font = new Font("微软雅黑", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
    this.labelInfo.ForeColor = Color.LightGray;
    this.labelInfo.Location = new Point(106, 582);
    this.labelInfo.Margin = new Padding(0);
    this.labelInfo.Name = "labelInfo";
    this.labelInfo.Size = new Size(288, 28);
    this.labelInfo.TabIndex = 703;
    this.labelInfo.Text = "正在渲染";
    this.labelInfo.TextAlign = ContentAlignment.MiddleCenter;
    this.labelInfo.Visible = false;
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P点选框A;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(40, 661);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(14, 14);
    this.button1.TabIndex = 704;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button2.BackColor = Color.Transparent;
    this.button2.BackgroundImage = (Image) Resources.P点选框;
    this.button2.BackgroundImageLayout = ImageLayout.Stretch;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Location = new Point(110, 661);
    this.button2.Margin = new Padding(0);
    this.button2.Name = "button2";
    this.button2.Size = new Size(14, 14);
    this.button2.TabIndex = 705;
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.labelTimer.BackColor = Color.Transparent;
    this.labelTimer.FlatStyle = FlatStyle.Flat;
    this.labelTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelTimer.ForeColor = Color.LightGray;
    this.labelTimer.Location = new Point(32 /*0x20*/, 531);
    this.labelTimer.Margin = new Padding(0);
    this.labelTimer.Name = "labelTimer";
    this.labelTimer.Size = new Size(88, 20);
    this.labelTimer.TabIndex = 706;
    this.labelTimer.Text = "00:00:00:000";
    this.labelTimer.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P0裁减320320;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.labelTimer);
    this.Controls.Add((Control) this.labelStartTimer);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.labelInfo);
    this.Controls.Add((Control) this.buttonClose);
    this.Controls.Add((Control) this.labelStopTimer);
    this.Controls.Add((Control) this.labelAllTimer);
    this.Controls.Add((Control) this.buttonYulan);
    this.Controls.Add((Control) this.buttonTPJCOK);
    this.Controls.Add((Control) this.buttonXuanzhuan);
    this.Controls.Add((Control) this.buttonTPJCW);
    this.Controls.Add((Control) this.buttonTPJCH);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCVideoCut);
    this.Size = new Size(500, 702);
    this.MouseDown += new MouseEventHandler(this.UCVideoCut_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCVideoCut_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCVideoCut_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCVideoCut(ArrayList array);
}

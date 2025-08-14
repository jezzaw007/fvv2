// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCImageCut
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCImageCut : UserControl
{
  public UCImageCut.delegateUCImageCut ucImageCut;
  public Image imageAll = (Image) null;
  public Bitmap imageSub0 = (Bitmap) null;
  public Bitmap imageSub = (Bitmap) null;
  private Bitmap bitmap = (Bitmap) null;
  private int bitmapCX = 0;
  private int bitmapCY = 0;
  private int bitmapW = 0;
  private int bitmapH = 0;
  private const int gdtX = 248;
  private const int gdtY = 569;
  private const int gdtX1 = 12;
  private const int gdtX2 = 484;
  private bool isMouseDownGdt = false;
  private const int XS_Val = 130;
  private const int YS_Val = 90;
  private const int X_Val = 90;
  private const int Y_Val = 130;
  private const int X_Val360 = 70;
  private const int Y_Val360 = 70;
  private const int X_Val480 = 10;
  private const int Y_Val480 = 10;
  private const int X_Val400 = 50;
  private const int Y_Val180 = 160 /*0xA0*/;
  private const int X_Val180 = 160 /*0xA0*/;
  private const int Y_Val400 = 50;
  public bool isFanZhuan = false;
  public bool is240x240 = false;
  public bool is320x320 = false;
  public bool is360x360 = false;
  public bool is640x480 = false;
  public bool is480x480 = false;
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
  private float bili = 1f;
  private float oldBili = 1f;
  private bool isMouseDown = false;
  private int xPos = 0;
  private int yPos = 0;
  private bool isTPJCW = true;
  private IContainer components = (IContainer) null;
  private Button buttonClose;
  private Button buttonTPJCH;
  private Button buttonTPJCW;
  private Button button1;
  private Button buttonTPJCOK;

  public UCImageCut()
  {
    this.InitializeComponent();
    this.bitmap = Resources.P滑动条按钮;
    this.bitmapW = this.bitmap.Width;
    this.bitmapH = this.bitmap.Height;
    this.bitmapCX = 248;
    this.bitmapCY = 569;
  }

  public void SetImage(Image image)
  {
    Image imageAll = this.imageAll;
    this.imageAll = image;
    imageAll?.Dispose();
    if (this.imageSub0 != null)
      this.imageSub0.Dispose();
    if (this.imageSub != null)
    {
      this.imageSub.Dispose();
      this.imageSub = (Bitmap) null;
    }
    if (this.is320x320)
    {
      this.imageSub = new Bitmap(320, 320);
      this.xVal = 0;
      this.yVal = 0;
      if (image.Height > image.Width)
      {
        this.hVal = 320;
        this.wVal = image.Width * 320 / image.Height;
        this.xVal += (320 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 320;
        this.hVal = image.Height * 320 / image.Width;
        this.yVal += (320 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is360x360)
    {
      this.imageSub = new Bitmap(360, 360);
      this.xVal = 0;
      this.yVal = 0;
      if (image.Height > image.Width)
      {
        this.hVal = 360;
        this.wVal = image.Width * 360 / image.Height;
        this.xVal += (360 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 360;
        this.hVal = image.Height * 360 / image.Width;
        this.yVal += (360 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is240x240)
    {
      this.imageSub = new Bitmap(240 /*0xF0*/, 240 /*0xF0*/);
      this.xVal = 0;
      this.yVal = 0;
      if (image.Height > image.Width)
      {
        this.hVal = 240 /*0xF0*/;
        this.wVal = image.Width * 240 /*0xF0*/ / image.Height;
        this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 240 /*0xF0*/;
        this.hVal = image.Height * 240 /*0xF0*/ / image.Width;
        this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is480x480)
    {
      this.imageSub = new Bitmap(480, 480);
      this.xVal = 0;
      this.yVal = 0;
      if (image.Height > image.Width)
      {
        this.hVal = 480;
        this.wVal = image.Width * 480 / image.Height;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 480;
        this.hVal = image.Height * 480 / image.Width;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is1600x720)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(720, 1600);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Width > (double) image.Height * 0.45)
        {
          this.wVal = 720;
          this.hVal = image.Height * 720 / image.Width;
          this.yVal += (1600 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 1600;
          this.wVal = image.Width * 1600 / image.Height;
          this.xVal += (720 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
      else
      {
        this.imageSub = new Bitmap(1600, 720);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Height > (double) image.Width * 0.45)
        {
          this.hVal = 720;
          this.wVal = image.Width * 720 / image.Height;
          this.xVal += (1600 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 1600;
          this.hVal = image.Height * 1600 / image.Width;
          this.yVal += (720 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
    }
    else if (this.is800x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 800);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Width > (double) image.Height * 0.6)
        {
          this.wVal = 480;
          this.hVal = image.Height * 480 / image.Width;
          this.yVal += (800 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 800;
          this.wVal = image.Width * 800 / image.Height;
          this.xVal += (480 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
      else
      {
        this.imageSub = new Bitmap(800, 480);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Height > (double) image.Width * 0.6)
        {
          this.hVal = 480;
          this.wVal = image.Width * 480 / image.Height;
          this.xVal += (800 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 800;
          this.hVal = image.Height * 800 / image.Width;
          this.yVal += (480 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
    }
    else if (this.is854x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 854);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Width > (double) image.Height * 0.56206)
        {
          this.wVal = 480;
          this.hVal = image.Height * 480 / image.Width;
          this.yVal += (854 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 854;
          this.wVal = image.Width * 854 / image.Height;
          this.xVal += (480 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
      else
      {
        this.imageSub = new Bitmap(854, 480);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Height > (double) image.Width * 0.56206)
        {
          this.hVal = 480;
          this.wVal = image.Width * 480 / image.Height;
          this.xVal += (854 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 854;
          this.hVal = image.Height * 854 / image.Width;
          this.yVal += (480 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
    }
    else if (this.is960x540)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(540, 960);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Width > (double) image.Height * (9.0 / 16.0))
        {
          this.wVal = 540;
          this.hVal = image.Height * 540 / image.Width;
          this.yVal += (960 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 960;
          this.wVal = image.Width * 960 / image.Height;
          this.xVal += (540 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
      else
      {
        this.imageSub = new Bitmap(960, 540);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Height > (double) image.Width * (9.0 / 16.0))
        {
          this.hVal = 540;
          this.wVal = image.Width * 540 / image.Height;
          this.xVal += (960 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 960;
          this.hVal = image.Height * 960 / image.Width;
          this.yVal += (540 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
    }
    else if (this.is960x320)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(320, 960);
        this.xVal = 0;
        this.yVal = 0;
        if (image.Width > image.Height / 3)
        {
          this.wVal = 320;
          this.hVal = image.Height * 320 / image.Width;
          this.yVal += (960 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 960;
          this.wVal = image.Width * 960 / image.Height;
          this.xVal += (320 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
      else
      {
        this.imageSub = new Bitmap(960, 320);
        this.xVal = 0;
        this.yVal = 0;
        if (image.Height > image.Width / 3)
        {
          this.hVal = 320;
          this.wVal = image.Width * 320 / image.Height;
          this.xVal += (960 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 960;
          this.hVal = image.Height * 960 / image.Width;
          this.yVal += (320 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
    }
    else if (this.is1920x462)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(462, 1920);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Width > (double) image.Height * (77.0 / 320.0))
        {
          this.wVal = 462;
          this.hVal = image.Height * 462 / image.Width;
          this.yVal += (1920 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 1920;
          this.wVal = image.Width * 1920 / image.Height;
          this.xVal += (462 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
      else
      {
        this.imageSub = new Bitmap(1920, 462);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Height > (double) image.Width * (77.0 / 320.0))
        {
          this.hVal = 462;
          this.wVal = image.Width * 462 / image.Height;
          this.xVal += (1920 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 1920;
          this.hVal = image.Height * 1920 / image.Width;
          this.yVal += (462 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
    }
    else if (this.is1280x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 1280 /*0x0500*/);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Width > (double) image.Height * 0.375)
        {
          this.wVal = 480;
          this.hVal = image.Height * 480 / image.Width;
          this.yVal += (1280 /*0x0500*/ - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 1280 /*0x0500*/;
          this.wVal = image.Width * 1280 /*0x0500*/ / image.Height;
          this.xVal += (480 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
      else
      {
        this.imageSub = new Bitmap(1280 /*0x0500*/, 480);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Height > (double) image.Width * 0.375)
        {
          this.hVal = 480;
          this.wVal = image.Width * 480 / image.Height;
          this.xVal += (1280 /*0x0500*/ - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 1280 /*0x0500*/;
          this.hVal = image.Height * 1280 /*0x0500*/ / image.Width;
          this.yVal += (480 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
    }
    else if (this.is640x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 640);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Height * 0.75 > (double) image.Width)
        {
          this.hVal = 640;
          this.wVal = image.Width * 640 / image.Height;
          this.xVal += (480 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 480;
          this.hVal = image.Height * 480 / image.Width;
          this.yVal += (640 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.imageSub = new Bitmap(640, 480);
        this.xVal = 0;
        this.yVal = 0;
        if ((double) image.Width * 0.75 > (double) image.Height)
        {
          this.wVal = 640;
          this.hVal = image.Height * 640 / image.Width;
          this.yVal += (480 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 480;
          this.wVal = image.Width * 480 / image.Height;
          this.xVal += (640 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
    }
    else if (this.isFanZhuan)
    {
      this.imageSub = new Bitmap(240 /*0xF0*/, 320);
      this.xVal = 0;
      this.yVal = 0;
      if ((double) image.Height * 0.75 > (double) image.Width)
      {
        this.hVal = 320;
        this.wVal = image.Width * 320 / image.Height;
        this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 240 /*0xF0*/;
        this.hVal = image.Height * 240 /*0xF0*/ / image.Width;
        this.yVal += (320 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else
    {
      this.imageSub = new Bitmap(320, 240 /*0xF0*/);
      this.xVal = 0;
      this.yVal = 0;
      if ((double) image.Width * 0.75 > (double) image.Height)
      {
        this.wVal = 320;
        this.hVal = image.Height * 320 / image.Width;
        this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.hVal = 240 /*0xF0*/;
        this.wVal = image.Width * 240 /*0xF0*/ / image.Height;
        this.xVal += (320 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    this.imageSub0 = new Bitmap(this.wVal, this.hVal);
    Graphics graphics1 = Graphics.FromImage((Image) this.imageSub0);
    graphics1.DrawImage(this.imageAll, 0, 0, this.wVal, this.hVal);
    graphics1.Dispose();
    Graphics graphics2 = Graphics.FromImage((Image) this.imageSub);
    graphics2.DrawImage((Image) this.imageSub0, this.xVal, this.yVal);
    graphics2.Dispose();
    this.bili = 1f;
    this.oldBili = 1f;
    this.bitmapCX = 248;
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (this.imageSub != null)
    {
      if (this.is320x320)
        graphics.DrawImage((Image) this.imageSub, 90, 90);
      else if (this.is360x360)
        graphics.DrawImage((Image) this.imageSub, 70, 70);
      else if (this.is240x240)
        graphics.DrawImage((Image) this.imageSub, 130, 130);
      else if (this.is480x480)
        graphics.DrawImage((Image) this.imageSub, 10, 10);
      else if (this.is1600x720)
      {
        if (this.isFanZhuan)
          graphics.DrawImage((Image) this.imageSub, 160 /*0xA0*/, 50, 180, 400);
        else
          graphics.DrawImage((Image) this.imageSub, 50, 160 /*0xA0*/, 400, 180);
      }
      else if (this.is800x480)
      {
        if (this.isFanZhuan)
          graphics.DrawImage((Image) this.imageSub, 130, 50, 240 /*0xF0*/, 400);
        else
          graphics.DrawImage((Image) this.imageSub, 50, 130, 400, 240 /*0xF0*/);
      }
      else if (this.is854x480)
      {
        if (this.isFanZhuan)
          graphics.DrawImage((Image) this.imageSub, 130, 36, 240 /*0xF0*/, 427);
        else
          graphics.DrawImage((Image) this.imageSub, 36, 130, 427, 240 /*0xF0*/);
      }
      else if (this.is960x540)
      {
        if (this.isFanZhuan)
          graphics.DrawImage((Image) this.imageSub, 115, 10, 270, 480);
        else
          graphics.DrawImage((Image) this.imageSub, 10, 115, 480, 270);
      }
      else if (this.is960x320)
      {
        if (this.isFanZhuan)
          graphics.DrawImage((Image) this.imageSub, 170, 10, 160 /*0xA0*/, 480);
        else
          graphics.DrawImage((Image) this.imageSub, 10, 170, 480, 160 /*0xA0*/);
      }
      else if (this.is1920x462)
      {
        if (this.isFanZhuan)
          graphics.DrawImage((Image) this.imageSub, 192 /*0xC0*/, 10, 116, 480);
        else
          graphics.DrawImage((Image) this.imageSub, 10, 192 /*0xC0*/, 480, 116);
      }
      else if (this.is1280x480)
      {
        if (this.isFanZhuan)
          graphics.DrawImage((Image) this.imageSub, 160 /*0xA0*/, 10, 180, 480);
        else
          graphics.DrawImage((Image) this.imageSub, 10, 160 /*0xA0*/, 480, 180);
      }
      else if (this.isFanZhuan)
        graphics.DrawImage((Image) this.imageSub, 130, 90, 240 /*0xF0*/, 320);
      else
        graphics.DrawImage((Image) this.imageSub, 90, 130, 320, 240 /*0xF0*/);
    }
    graphics.DrawImage((Image) this.bitmap, this.bitmapCX - this.bitmapW / 2, this.bitmapCY - this.bitmapH / 2);
  }

  private void buttonTPJCW_Click(object sender, EventArgs e)
  {
    this.isTPJCW = true;
    if (this.imageSub0 != null)
      this.imageSub0.Dispose();
    if (this.imageSub != null)
    {
      this.imageSub.Dispose();
      this.imageSub = (Bitmap) null;
    }
    if (this.is320x320)
    {
      this.imageSub = new Bitmap(320, 320);
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 320;
      this.hVal = this.imageAll.Height * 320 / this.imageAll.Width;
      this.yVal += (320 - this.hVal) / 2;
    }
    else if (this.is360x360)
    {
      this.imageSub = new Bitmap(360, 360);
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 360;
      this.hVal = this.imageAll.Height * 360 / this.imageAll.Width;
      this.yVal += (360 - this.hVal) / 2;
    }
    else if (this.is240x240)
    {
      this.imageSub = new Bitmap(240 /*0xF0*/, 240 /*0xF0*/);
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 240 /*0xF0*/;
      this.hVal = this.imageAll.Height * 240 /*0xF0*/ / this.imageAll.Width;
      this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
    }
    else if (this.is480x480)
    {
      this.imageSub = new Bitmap(480, 480);
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 480;
      this.hVal = this.imageAll.Height * 480 / this.imageAll.Width;
      this.yVal += (480 - this.hVal) / 2;
    }
    else if (this.is1600x720)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(720, 1600);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 720;
        this.hVal = this.imageAll.Height * 720 / this.imageAll.Width;
        this.yVal += (1600 - this.hVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(1600, 720);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 1600;
        this.hVal = this.imageAll.Height * 1600 / this.imageAll.Width;
        this.yVal += (720 - this.hVal) / 2;
      }
    }
    else if (this.is800x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 800);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.imageAll.Height * 480 / this.imageAll.Width;
        this.yVal += (800 - this.hVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(800, 480);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 800;
        this.hVal = this.imageAll.Height * 800 / this.imageAll.Width;
        this.yVal += (480 - this.hVal) / 2;
      }
    }
    else if (this.is854x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 854);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.imageAll.Height * 480 / this.imageAll.Width;
        this.yVal += (854 - this.hVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(854, 480);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 854;
        this.hVal = this.imageAll.Height * 854 / this.imageAll.Width;
        this.yVal += (480 - this.hVal) / 2;
      }
    }
    else if (this.is960x540)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(540, 960);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 540;
        this.hVal = this.imageAll.Height * 540 / this.imageAll.Width;
        this.yVal += (960 - this.hVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(960, 540);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 960;
        this.hVal = this.imageAll.Height * 960 / this.imageAll.Width;
        this.yVal += (540 - this.hVal) / 2;
      }
    }
    else if (this.is960x320)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(320, 960);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 320;
        this.hVal = this.imageAll.Height * 320 / this.imageAll.Width;
        this.yVal += (960 - this.hVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(960, 320);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 960;
        this.hVal = this.imageAll.Height * 960 / this.imageAll.Width;
        this.yVal += (320 - this.hVal) / 2;
      }
    }
    else if (this.is1920x462)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(462, 1920);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 462;
        this.hVal = this.imageAll.Height * 462 / this.imageAll.Width;
        this.yVal += (1920 - this.hVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(1920, 462);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 1920;
        this.hVal = this.imageAll.Height * 1920 / this.imageAll.Width;
        this.yVal += (462 - this.hVal) / 2;
      }
    }
    else if (this.is1280x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 1280 /*0x0500*/);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.imageAll.Height * 480 / this.imageAll.Width;
        this.yVal += (1280 /*0x0500*/ - this.hVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(1280 /*0x0500*/, 480);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 1280 /*0x0500*/;
        this.hVal = this.imageAll.Height * 1280 /*0x0500*/ / this.imageAll.Width;
        this.yVal += (480 - this.hVal) / 2;
      }
    }
    else if (this.is640x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 640);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.imageAll.Height * 480 / this.imageAll.Width;
        this.yVal += (640 - this.hVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(640, 480);
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 640;
        this.hVal = this.imageAll.Height * 640 / this.imageAll.Width;
        this.yVal += (480 - this.hVal) / 2;
      }
    }
    else if (this.isFanZhuan)
    {
      this.imageSub = new Bitmap(240 /*0xF0*/, 320);
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 240 /*0xF0*/;
      this.hVal = this.imageAll.Height * 240 /*0xF0*/ / this.imageAll.Width;
      this.yVal += (320 - this.hVal) / 2;
    }
    else
    {
      this.imageSub = new Bitmap(320, 240 /*0xF0*/);
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 320;
      this.hVal = this.imageAll.Height * 320 / this.imageAll.Width;
      this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
    }
    this.imageSub0 = new Bitmap(this.wVal, this.hVal);
    Graphics graphics1 = Graphics.FromImage((Image) this.imageSub0);
    graphics1.DrawImage(this.imageAll, 0, 0, this.wVal, this.hVal);
    graphics1.Dispose();
    Graphics graphics2 = Graphics.FromImage((Image) this.imageSub);
    graphics2.DrawImage((Image) this.imageSub0, this.xVal, this.yVal);
    graphics2.Dispose();
    this.bili = 1f;
    this.oldBili = 1f;
    this.bitmapCX = 248;
    this.Invalidate();
  }

  private void buttonTPJCH_Click(object sender, EventArgs e)
  {
    this.isTPJCW = false;
    if (this.imageSub0 != null)
      this.imageSub0.Dispose();
    if (this.imageSub != null)
    {
      this.imageSub.Dispose();
      this.imageSub = (Bitmap) null;
    }
    if (this.is320x320)
    {
      this.imageSub = new Bitmap(320, 320);
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 320;
      this.wVal = this.imageAll.Width * 320 / this.imageAll.Height;
      this.xVal += (320 - this.wVal) / 2;
    }
    else if (this.is360x360)
    {
      this.imageSub = new Bitmap(360, 360);
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 360;
      this.wVal = this.imageAll.Width * 360 / this.imageAll.Height;
      this.xVal += (360 - this.wVal) / 2;
    }
    else if (this.is240x240)
    {
      this.imageSub = new Bitmap(240 /*0xF0*/, 240 /*0xF0*/);
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 240 /*0xF0*/;
      this.wVal = this.imageAll.Width * 240 /*0xF0*/ / this.imageAll.Height;
      this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
    }
    else if (this.is480x480)
    {
      this.imageSub = new Bitmap(480, 480);
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 480;
      this.wVal = this.imageAll.Width * 480 / this.imageAll.Height;
      this.xVal += (480 - this.wVal) / 2;
    }
    else if (this.is1600x720)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(720, 1600);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 1600;
        this.wVal = this.imageAll.Width * 1600 / this.imageAll.Height;
        this.xVal += (720 - this.wVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(1600, 720);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 720;
        this.wVal = this.imageAll.Width * 720 / this.imageAll.Height;
        this.xVal += (1600 - this.wVal) / 2;
      }
    }
    else if (this.is800x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 800);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 800;
        this.wVal = this.imageAll.Width * 800 / this.imageAll.Height;
        this.xVal += (480 - this.wVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(800, 480);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.imageAll.Width * 480 / this.imageAll.Height;
        this.xVal += (800 - this.wVal) / 2;
      }
    }
    else if (this.is854x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 854);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 854;
        this.wVal = this.imageAll.Width * 854 / this.imageAll.Height;
        this.xVal += (480 - this.wVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(854, 480);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.imageAll.Width * 480 / this.imageAll.Height;
        this.xVal += (854 - this.wVal) / 2;
      }
    }
    else if (this.is960x540)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(540, 960);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 960;
        this.wVal = this.imageAll.Width * 960 / this.imageAll.Height;
        this.xVal += (540 - this.wVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(960, 540);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 540;
        this.wVal = this.imageAll.Width * 540 / this.imageAll.Height;
        this.xVal += (960 - this.wVal) / 2;
      }
    }
    else if (this.is960x320)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(320, 960);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 960;
        this.wVal = this.imageAll.Width * 960 / this.imageAll.Height;
        this.xVal += (320 - this.wVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(960, 320);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 320;
        this.wVal = this.imageAll.Width * 320 / this.imageAll.Height;
        this.xVal += (960 - this.wVal) / 2;
      }
    }
    else if (this.is1920x462)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(462, 1920);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 1920;
        this.wVal = this.imageAll.Width * 1920 / this.imageAll.Height;
        this.xVal += (462 - this.wVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(1920, 462);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 462;
        this.wVal = this.imageAll.Width * 462 / this.imageAll.Height;
        this.xVal += (1920 - this.wVal) / 2;
      }
    }
    else if (this.is1280x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 1280 /*0x0500*/);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 1280 /*0x0500*/;
        this.wVal = this.imageAll.Width * 1280 /*0x0500*/ / this.imageAll.Height;
        this.xVal += (480 - this.wVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(1280 /*0x0500*/, 480);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.imageAll.Width * 480 / this.imageAll.Height;
        this.xVal += (1280 /*0x0500*/ - this.wVal) / 2;
      }
    }
    else if (this.is640x480)
    {
      if (this.isFanZhuan)
      {
        this.imageSub = new Bitmap(480, 640);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 640;
        this.wVal = this.imageAll.Width * 640 / this.imageAll.Height;
        this.xVal += (480 - this.wVal) / 2;
      }
      else
      {
        this.imageSub = new Bitmap(640, 480);
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.imageAll.Width * 480 / this.imageAll.Height;
        this.xVal += (640 - this.wVal) / 2;
      }
    }
    else if (this.isFanZhuan)
    {
      this.imageSub = new Bitmap(240 /*0xF0*/, 320);
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 320;
      this.wVal = this.imageAll.Width * 320 / this.imageAll.Height;
      this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
    }
    else
    {
      this.imageSub = new Bitmap(320, 240 /*0xF0*/);
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 240 /*0xF0*/;
      this.wVal = this.imageAll.Width * 240 /*0xF0*/ / this.imageAll.Height;
      this.xVal += (320 - this.wVal) / 2;
    }
    this.imageSub0 = new Bitmap(this.wVal, this.hVal);
    Graphics graphics1 = Graphics.FromImage((Image) this.imageSub0);
    graphics1.DrawImage(this.imageAll, 0, 0, this.wVal, this.hVal);
    graphics1.Dispose();
    Graphics graphics2 = Graphics.FromImage((Image) this.imageSub);
    graphics2.DrawImage((Image) this.imageSub0, this.xVal, this.yVal);
    graphics2.Dispose();
    this.bili = 1f;
    this.oldBili = 1f;
    this.bitmapCX = 248;
    this.Invalidate();
  }

  private void buttonTPJCOK_Click(object sender, EventArgs e)
  {
    UCImageCut.delegateUCImageCut ucImageCut = this.ucImageCut;
    if (ucImageCut == null)
      return;
    ucImageCut((Image) this.imageSub);
  }

  private void buttonClose_Click(object sender, EventArgs e)
  {
    UCImageCut.delegateUCImageCut ucImageCut = this.ucImageCut;
    if (ucImageCut == null)
      return;
    ucImageCut((Image) null);
  }

  public Image RotateImg(Image img, float angle)
  {
    int width = img.Width;
    int height = img.Height;
    Matrix matrix = new Matrix();
    matrix.RotateAt(angle, new PointF((float) (width / 2), (float) (height / 2)), MatrixOrder.Append);
    GraphicsPath graphicsPath = new GraphicsPath();
    graphicsPath.AddRectangle(new RectangleF(0.0f, 0.0f, (float) width, (float) height));
    RectangleF bounds = graphicsPath.GetBounds(matrix);
    bounds.X = (float) Math.Round((double) bounds.X, 0);
    bounds.Y = (float) Math.Round((double) bounds.Y, 0);
    bounds.Width = (float) Math.Round((double) bounds.Width, 0);
    bounds.Height = (float) Math.Round((double) bounds.Height, 0);
    Bitmap bitmap = new Bitmap((int) bounds.Width, (int) bounds.Height);
    Graphics graphics = Graphics.FromImage((Image) bitmap);
    graphics.InterpolationMode = InterpolationMode.Bilinear;
    graphics.SmoothingMode = SmoothingMode.HighQuality;
    Point point1 = new Point((int) ((double) bounds.Width - (double) width) / 2, (int) ((double) bounds.Height - (double) height) / 2);
    Rectangle rect = new Rectangle(point1.X, point1.Y, width, height);
    Point point2 = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
    graphics.TranslateTransform((float) point2.X, (float) point2.Y);
    graphics.RotateTransform(angle);
    graphics.TranslateTransform((float) -point2.X, (float) -point2.Y);
    graphics.DrawImage(img, rect);
    graphics.ResetTransform();
    graphics.Save();
    graphics.Dispose();
    graphicsPath.Dispose();
    return (Image) bitmap;
  }

  private void button1_Click(object sender, EventArgs e)
  {
    Image image = this.RotateImg(this.imageAll, 90f);
    this.imageAll.Dispose();
    this.imageAll = (Image) null;
    this.imageAll = image;
    if (this.isTPJCW)
      this.buttonTPJCW_Click((object) null, (EventArgs) null);
    else
      this.buttonTPJCH_Click((object) null, (EventArgs) null);
  }

  private void ImageBiliBianhuan()
  {
    this.bili = this.bitmapCX <= 248 ? (float) (1.0 / (1.0 + (double) (248 - this.bitmapCX) * 0.029999999329447746)) : (float) (1.0 + (double) (this.bitmapCX - 248) * 0.029999999329447746);
    int width = (int) ((double) this.wVal * (double) this.bili);
    int height = (int) ((double) this.hVal * (double) this.bili);
    int num1 = (int) ((double) this.wVal * (double) this.oldBili);
    int num2 = (int) ((double) this.hVal * (double) this.oldBili);
    this.oldBili = this.bili;
    this.xVal -= (width - num1) / 2;
    this.yVal -= (height - num2) / 2;
    if (this.imageSub != null)
    {
      this.imageSub.Dispose();
      this.imageSub = (Bitmap) null;
    }
    this.imageSub = !this.is320x320 ? (!this.is360x360 ? (!this.is240x240 ? (!this.is480x480 ? (!this.is1600x720 ? (!this.is800x480 ? (!this.is854x480 ? (!this.is960x540 ? (!this.is960x320 ? (!this.is1920x462 ? (!this.is1280x480 ? (!this.is640x480 ? (!this.isFanZhuan ? new Bitmap(320, 240 /*0xF0*/) : new Bitmap(240 /*0xF0*/, 320)) : (!this.isFanZhuan ? new Bitmap(640, 480) : new Bitmap(480, 640))) : (!this.isFanZhuan ? new Bitmap(1280 /*0x0500*/, 480) : new Bitmap(480, 1280 /*0x0500*/))) : (!this.isFanZhuan ? new Bitmap(1920, 462) : new Bitmap(462, 1920))) : (!this.isFanZhuan ? new Bitmap(960, 320) : new Bitmap(320, 960))) : (!this.isFanZhuan ? new Bitmap(960, 540) : new Bitmap(540, 960))) : (!this.isFanZhuan ? new Bitmap(854, 480) : new Bitmap(480, 854))) : (!this.isFanZhuan ? new Bitmap(800, 480) : new Bitmap(480, 800))) : (!this.isFanZhuan ? new Bitmap(1600, 720) : new Bitmap(720, 1600))) : new Bitmap(480, 480)) : new Bitmap(240 /*0xF0*/, 240 /*0xF0*/)) : new Bitmap(360, 360)) : new Bitmap(320, 320);
    Graphics graphics = Graphics.FromImage((Image) this.imageSub);
    graphics.DrawImage((Image) this.imageSub0, this.xVal, this.yVal, width, height);
    graphics.Dispose();
  }

  private void ImageBiliBianhuanUp()
  {
    this.bili = this.bitmapCX <= 248 ? (float) (1.0 / (1.0 + (double) (248 - this.bitmapCX) * 0.029999999329447746)) : (float) (1.0 + (double) (this.bitmapCX - 248) * 0.029999999329447746);
    int width = (int) ((double) this.wVal * (double) this.bili);
    int height = (int) ((double) this.hVal * (double) this.bili);
    int num1 = (int) ((double) this.wVal * (double) this.oldBili);
    int num2 = (int) ((double) this.hVal * (double) this.oldBili);
    this.oldBili = this.bili;
    this.xVal -= (width - num1) / 2;
    this.yVal -= (height - num2) / 2;
    if (this.imageSub0 != null)
      this.imageSub0.Dispose();
    if (this.imageSub != null)
    {
      this.imageSub.Dispose();
      this.imageSub = (Bitmap) null;
    }
    this.imageSub = !this.is320x320 ? (!this.is360x360 ? (!this.is240x240 ? (!this.is480x480 ? (!this.is1600x720 ? (!this.is800x480 ? (!this.is854x480 ? (!this.is960x540 ? (!this.is960x320 ? (!this.is1920x462 ? (!this.is1280x480 ? (!this.is640x480 ? (!this.isFanZhuan ? new Bitmap(320, 240 /*0xF0*/) : new Bitmap(240 /*0xF0*/, 320)) : (!this.isFanZhuan ? new Bitmap(640, 480) : new Bitmap(480, 640))) : (!this.isFanZhuan ? new Bitmap(1280 /*0x0500*/, 480) : new Bitmap(480, 1280 /*0x0500*/))) : (!this.isFanZhuan ? new Bitmap(1920, 462) : new Bitmap(462, 1920))) : (!this.isFanZhuan ? new Bitmap(960, 320) : new Bitmap(320, 960))) : (!this.isFanZhuan ? new Bitmap(960, 540) : new Bitmap(540, 960))) : (!this.isFanZhuan ? new Bitmap(854, 480) : new Bitmap(480, 854))) : (!this.isFanZhuan ? new Bitmap(800, 480) : new Bitmap(480, 800))) : (!this.isFanZhuan ? new Bitmap(1600, 720) : new Bitmap(720, 1600))) : new Bitmap(480, 480)) : new Bitmap(240 /*0xF0*/, 240 /*0xF0*/)) : new Bitmap(360, 360)) : new Bitmap(320, 320);
    this.imageSub0 = new Bitmap(width, height);
    Graphics graphics1 = Graphics.FromImage((Image) this.imageSub0);
    graphics1.DrawImage(this.imageAll, 0, 0, width, height);
    graphics1.Dispose();
    Graphics graphics2 = Graphics.FromImage((Image) this.imageSub);
    graphics2.DrawImage((Image) this.imageSub0, this.xVal, this.yVal);
    graphics2.Dispose();
  }

  private void UCImageCut_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Y <= 546 || e.Y >= 592)
    {
      this.isMouseDown = true;
      this.xPos = e.X;
      this.yPos = e.Y;
    }
    else
    {
      this.isMouseDownGdt = true;
      this.bitmapCX = e.X;
      if (this.bitmapCX < 12)
        this.bitmapCX = 12;
      if (this.bitmapCX > 484)
        this.bitmapCX = 484;
      this.ImageBiliBianhuan();
      this.Invalidate();
    }
  }

  private void UCImageCut_MouseMove(object sender, MouseEventArgs e)
  {
    if (this.isMouseDown)
    {
      if (this.is1600x720 || this.is1920x462)
      {
        this.xVal += (e.X - this.xPos) * 4;
        this.yVal += (e.Y - this.yPos) * 4;
      }
      else if (this.is1280x480)
      {
        this.xVal += (int) ((double) (e.X - this.xPos) / 0.375);
        this.yVal += (int) ((double) (e.Y - this.yPos) / 0.375);
      }
      else if (this.is640x480 || this.is800x480 || this.is854x480 || this.is960x540 || this.is960x320)
      {
        this.xVal += (e.X - this.xPos) * 2;
        this.yVal += (e.Y - this.yPos) * 2;
      }
      else
      {
        this.xVal += e.X - this.xPos;
        this.yVal += e.Y - this.yPos;
      }
      this.xPos = e.X;
      this.yPos = e.Y;
      if (this.imageSub != null)
      {
        this.imageSub.Dispose();
        this.imageSub = (Bitmap) null;
      }
      this.imageSub = !this.is320x320 ? (!this.is360x360 ? (!this.is240x240 ? (!this.is480x480 ? (!this.is1600x720 ? (!this.is800x480 ? (!this.is854x480 ? (!this.is960x540 ? (!this.is960x320 ? (!this.is1920x462 ? (!this.is1280x480 ? (!this.is640x480 ? (!this.isFanZhuan ? new Bitmap(320, 240 /*0xF0*/) : new Bitmap(240 /*0xF0*/, 320)) : (!this.isFanZhuan ? new Bitmap(640, 480) : new Bitmap(480, 640))) : (!this.isFanZhuan ? new Bitmap(1280 /*0x0500*/, 480) : new Bitmap(480, 1280 /*0x0500*/))) : (!this.isFanZhuan ? new Bitmap(1920, 462) : new Bitmap(462, 1920))) : (!this.isFanZhuan ? new Bitmap(960, 320) : new Bitmap(320, 960))) : (!this.isFanZhuan ? new Bitmap(960, 540) : new Bitmap(540, 960))) : (!this.isFanZhuan ? new Bitmap(854, 480) : new Bitmap(480, 854))) : (!this.isFanZhuan ? new Bitmap(800, 480) : new Bitmap(480, 800))) : (!this.isFanZhuan ? new Bitmap(1600, 720) : new Bitmap(720, 1600))) : new Bitmap(480, 480)) : new Bitmap(240 /*0xF0*/, 240 /*0xF0*/)) : new Bitmap(360, 360)) : new Bitmap(320, 320);
      Graphics graphics = Graphics.FromImage((Image) this.imageSub);
      graphics.DrawImage((Image) this.imageSub0, this.xVal, this.yVal);
      graphics.Dispose();
      this.Invalidate();
    }
    if (!this.isMouseDownGdt)
      return;
    this.bitmapCX = e.X;
    if (this.bitmapCX < 12)
      this.bitmapCX = 12;
    if (this.bitmapCX > 484)
      this.bitmapCX = 484;
    this.ImageBiliBianhuan();
    this.Invalidate();
  }

  private void UCImageCut_MouseUp(object sender, MouseEventArgs e)
  {
    if (this.isMouseDownGdt)
    {
      this.ImageBiliBianhuanUp();
      this.Invalidate();
    }
    this.isMouseDown = false;
    this.isMouseDownGdt = false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonClose = new Button();
    this.buttonTPJCH = new Button();
    this.buttonTPJCW = new Button();
    this.button1 = new Button();
    this.buttonTPJCOK = new Button();
    this.SuspendLayout();
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
    this.buttonClose.TabIndex = 138;
    this.buttonClose.UseVisualStyleBackColor = false;
    this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
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
    this.buttonTPJCH.TabIndex = 646;
    this.buttonTPJCH.UseVisualStyleBackColor = false;
    this.buttonTPJCH.Click += new EventHandler(this.buttonTPJCH_Click);
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
    this.buttonTPJCW.TabIndex = 647;
    this.buttonTPJCW.UseVisualStyleBackColor = false;
    this.buttonTPJCW.Click += new EventHandler(this.buttonTPJCW_Click);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P旋转;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(297, 656);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(34, 26);
    this.button1.TabIndex = 648;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
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
    this.buttonTPJCOK.TabIndex = 649;
    this.buttonTPJCOK.UseVisualStyleBackColor = false;
    this.buttonTPJCOK.Click += new EventHandler(this.buttonTPJCOK_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P0图片裁减320240;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.buttonTPJCOK);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.buttonTPJCW);
    this.Controls.Add((Control) this.buttonTPJCH);
    this.Controls.Add((Control) this.buttonClose);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCImageCut);
    this.Size = new Size(500, 702);
    this.MouseDown += new MouseEventHandler(this.UCImageCut_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCImageCut_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCImageCut_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCImageCut(Image image);
}

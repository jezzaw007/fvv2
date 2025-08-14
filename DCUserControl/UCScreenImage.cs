// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCScreenImage
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCScreenImage : UserControl
{
  private Graphics gF = (Graphics) null;
  private int isMouseDown = -1;
  private int isDMouseDown = -1;
  private bool isMouseDownMB = false;
  private bool isDMouseDownMB = false;
  private int xPos;
  private int yPos;
  public int XvalMB = 0;
  public int YvalMB = 0;
  public int WvalMB = 0;
  public int HvalMB = 0;
  private bool isDrawBkImage = true;
  private bool isDrawMbImage = true;
  private bool isDrawXitongXinxi = true;
  public Bitmap bitmapBGK = (Bitmap) null;
  private Bitmap bitmapBGK1 = (Bitmap) null;
  private Bitmap bitmapBGK2 = (Bitmap) null;
  private Bitmap bitmapBGK3 = (Bitmap) null;
  public Bitmap bitmapMB = (Bitmap) null;
  private Image myImage = (Image) null;
  private StringFormat m_format = new StringFormat();
  public bool is240x240 = false;
  public bool is320x320 = false;
  public bool is360x360 = false;
  public bool is480x480 = false;
  public bool is640x480 = false;
  public int myDevicePingMu = 1;
  public bool isFanZhuan = false;
  private int directionB = 0;
  public int myLddVal = 2;
  public bool is1600x720 = false;
  public bool is1280x480 = false;
  public bool is1920x462 = false;
  public bool is800x480 = false;
  public bool is854x480 = false;
  public bool is960x540 = false;
  public bool is960x320 = false;
  public bool isBiliPingmu = false;
  private ArrayList arrayXianshi = new ArrayList();
  public UCScreenImage.delegateUCScreenImage ucScreenImage;
  private IContainer components = (IContainer) null;

  public UCScreenImage()
  {
    this.InitializeComponent();
    this.m_format.LineAlignment = StringAlignment.Center;
    this.m_format.Alignment = StringAlignment.Center;
    this.gF = this.CreateGraphics();
    this.bitmapBGK1 = Resources.P320240;
    this.bitmapBGK2 = Resources.P预览圆形遮罩480480圆;
    this.bitmapBGK3 = Resources.P预览圆形遮罩360360圆;
  }

  public void SetMyUCScreenImage(int angle)
  {
    if (this.is240x240 || this.is320x320 || this.is480x480)
    {
      if (this.is240x240)
      {
        this.Left = 130;
        this.Top = 130;
        this.Width = 240 /*0xF0*/;
        this.Height = 240 /*0xF0*/;
        this.bitmapBGK1 = Resources.P240240;
      }
      else if (this.is320x320)
      {
        this.Left = 90;
        this.Top = 90;
        this.Width = 320;
        this.Height = 320;
        this.bitmapBGK1 = Resources.P320320;
      }
      else
      {
        this.Left = 10;
        this.Top = 10;
        this.Width = 480;
        this.Height = 480;
        this.bitmapBGK1 = Resources.P320320;
      }
    }
    else if (this.is360x360)
    {
      this.Left = 70;
      this.Top = 70;
      this.Width = 360;
      this.Height = 360;
      this.bitmapBGK1 = Resources.P320320;
    }
    else if (this.is1600x720)
    {
      if (angle == 0 || angle == 180)
      {
        if (this.isBiliPingmu)
        {
          this.Left = 50;
          this.Top = 160 /*0xA0*/;
          this.Width = 400;
          this.Height = 180;
        }
        else
        {
          this.Left = 10;
          this.Top = 50;
          this.Width = 800;
          this.Height = 360;
        }
      }
      else if (this.isBiliPingmu)
      {
        this.Left = 160 /*0xA0*/;
        this.Top = 50;
        this.Width = 180;
        this.Height = 400;
      }
      else
      {
        this.Left = 10;
        this.Top = 50;
        this.Width = 360;
        this.Height = 800;
      }
      this.bitmapBGK1 = Resources.P320320;
    }
    else if (this.is1280x480)
    {
      if (angle == 0 || angle == 180)
      {
        if (this.isBiliPingmu)
        {
          this.Left = 10;
          this.Top = 160 /*0xA0*/;
          this.Width = 480;
          this.Height = 180;
        }
        else
        {
          this.Left = 10;
          this.Top = 50;
          this.Width = 640;
          this.Height = 240 /*0xF0*/;
        }
      }
      else if (this.isBiliPingmu)
      {
        this.Left = 160 /*0xA0*/;
        this.Top = 10;
        this.Width = 180;
        this.Height = 480;
      }
      else
      {
        this.Left = 10;
        this.Top = 50;
        this.Width = 240 /*0xF0*/;
        this.Height = 640;
      }
      this.bitmapBGK1 = Resources.P320320;
    }
    else if (this.is1920x462)
    {
      if (angle == 0 || angle == 180)
      {
        if (this.isBiliPingmu)
        {
          this.Left = 10;
          this.Top = 192 /*0xC0*/;
          this.Width = 480;
          this.Height = 116;
        }
        else
        {
          this.Left = 10;
          this.Top = 50;
          this.Width = 960;
          this.Height = 231;
        }
      }
      else if (this.isBiliPingmu)
      {
        this.Left = 192 /*0xC0*/;
        this.Top = 10;
        this.Width = 116;
        this.Height = 480;
      }
      else
      {
        this.Left = 10;
        this.Top = 50;
        this.Width = 231;
        this.Height = 960;
      }
      this.bitmapBGK1 = Resources.P320320;
    }
    else if (this.is800x480)
    {
      if (angle == 0 || angle == 180)
      {
        if (this.isBiliPingmu)
        {
          this.Left = 50;
          this.Top = 130;
          this.Width = 400;
          this.Height = 240 /*0xF0*/;
        }
        else
        {
          this.Left = 10;
          this.Top = 50;
          this.Width = 800;
          this.Height = 480;
        }
      }
      else if (this.isBiliPingmu)
      {
        this.Left = 130;
        this.Top = 50;
        this.Width = 240 /*0xF0*/;
        this.Height = 400;
      }
      else
      {
        this.Left = 10;
        this.Top = 50;
        this.Width = 480;
        this.Height = 800;
      }
      this.bitmapBGK1 = Resources.P320320;
    }
    else if (this.is854x480)
    {
      if (angle == 0 || angle == 180)
      {
        if (this.isBiliPingmu)
        {
          this.Left = 36;
          this.Top = 130;
          this.Width = 427;
          this.Height = 240 /*0xF0*/;
        }
        else
        {
          this.Left = 10;
          this.Top = 50;
          this.Width = 854;
          this.Height = 480;
        }
      }
      else if (this.isBiliPingmu)
      {
        this.Left = 130;
        this.Top = 36;
        this.Width = 240 /*0xF0*/;
        this.Height = 427;
      }
      else
      {
        this.Left = 10;
        this.Top = 50;
        this.Width = 480;
        this.Height = 854;
      }
      this.bitmapBGK1 = Resources.P320320;
    }
    else if (this.is960x540)
    {
      if (angle == 0 || angle == 180)
      {
        if (this.isBiliPingmu)
        {
          this.Left = 10;
          this.Top = 115;
          this.Width = 480;
          this.Height = 270;
        }
        else
        {
          this.Left = 10;
          this.Top = 50;
          this.Width = 960;
          this.Height = 540;
        }
      }
      else if (this.isBiliPingmu)
      {
        this.Left = 115;
        this.Top = 10;
        this.Width = 270;
        this.Height = 480;
      }
      else
      {
        this.Left = 10;
        this.Top = 50;
        this.Width = 540;
        this.Height = 960;
      }
      this.bitmapBGK1 = Resources.P320320;
    }
    else if (this.is960x320)
    {
      if (angle == 0 || angle == 180)
      {
        if (this.isBiliPingmu)
        {
          this.Left = 10;
          this.Top = 170;
          this.Width = 480;
          this.Height = 160 /*0xA0*/;
        }
        else
        {
          this.Left = 10;
          this.Top = 50;
          this.Width = 960;
          this.Height = 320;
        }
      }
      else if (this.isBiliPingmu)
      {
        this.Left = 170;
        this.Top = 10;
        this.Width = 160 /*0xA0*/;
        this.Height = 480;
      }
      else
      {
        this.Left = 10;
        this.Top = 50;
        this.Width = 320;
        this.Height = 960;
      }
      this.bitmapBGK1 = Resources.P320320;
    }
    else
    {
      switch (angle)
      {
        case 0:
          this.Left = 90;
          this.Top = 130;
          this.Width = 320;
          this.Height = 240 /*0xF0*/;
          this.bitmapBGK1 = Resources.P320240;
          break;
        case 90:
          this.Left = 130;
          this.Top = 90;
          this.Width = 240 /*0xF0*/;
          this.Height = 320;
          this.bitmapBGK1 = Resources.P240320;
          break;
        case 180:
          this.Left = 90;
          this.Top = 130;
          this.Width = 320;
          this.Height = 240 /*0xF0*/;
          this.bitmapBGK1 = Resources.P320240;
          break;
        case 270:
          this.Left = 130;
          this.Top = 90;
          this.Width = 240 /*0xF0*/;
          this.Height = 320;
          this.bitmapBGK1 = Resources.P240320;
          break;
      }
    }
    this.directionB = angle;
    this.isFanZhuan = angle != 0 && angle != 180;
    if (this.myImage != null)
      this.myImage.Dispose();
    this.myImage = (Image) null;
    this.Invalidate();
  }

  public void SetDrawMengBan(bool bl) => this.isDrawMbImage = bl;

  public void SetDrawXiTong(bool bl) => this.isDrawXitongXinxi = bl;

  public void SetDrawBkImage(bool bl) => this.isDrawBkImage = bl;

  public Image SetUCState(int angle, ArrayList array, int hn)
  {
    try
    {
      this.arrayXianshi = array;
      this.GenerateImage(angle, array, hn);
      this.Invalidate();
    }
    catch
    {
    }
    return this.myImage;
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

  public Image RotateImgHei(Image img, float angle)
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
    if (this.is480x480)
    {
      for (int index = 0; index < 480; ++index)
      {
        bitmap.SetPixel(index, 0, Color.Black);
        bitmap.SetPixel(index, 479, Color.Black);
        bitmap.SetPixel(0, index, Color.Black);
        bitmap.SetPixel(479, index, Color.Black);
      }
    }
    return (Image) bitmap;
  }

  public Image RotateImgBu(Image img, float angle)
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
    if (this.is480x480)
    {
      for (int index = 160 /*0xA0*/; index < 320; ++index)
      {
        bitmap.SetPixel(index, 0, bitmap.GetPixel(index, 1));
        bitmap.SetPixel(index, 479, bitmap.GetPixel(index, 478));
        bitmap.SetPixel(0, index, bitmap.GetPixel(1, index));
        bitmap.SetPixel(479, index, bitmap.GetPixel(478, index));
      }
    }
    return (Image) bitmap;
  }

  public Bitmap RotateImg2(Bitmap b, float angle)
  {
    angle %= 360f;
    double num1 = (double) angle * Math.PI / 180.0;
    double num2 = Math.Cos(num1);
    double num3 = Math.Sin(num1);
    int width1 = b.Width;
    int height1 = b.Height;
    int width2 = (int) Math.Max(Math.Abs((double) width1 * num2 - (double) height1 * num3), Math.Abs((double) width1 * num2 + (double) height1 * num3));
    int height2 = (int) Math.Max(Math.Abs((double) width1 * num3 - (double) height1 * num2), Math.Abs((double) width1 * num3 + (double) height1 * num2));
    Bitmap bitmap = new Bitmap(width2, height2);
    Graphics graphics = Graphics.FromImage((Image) bitmap);
    graphics.InterpolationMode = InterpolationMode.Bilinear;
    graphics.SmoothingMode = SmoothingMode.HighQuality;
    Point point1 = new Point((width2 - width1) / 2, (height2 - height1) / 2);
    Rectangle rect = new Rectangle(point1.X, point1.Y, width1, height1);
    Point point2 = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
    graphics.TranslateTransform((float) point2.X, (float) point2.Y);
    graphics.RotateTransform(360f - angle);
    graphics.TranslateTransform((float) -point2.X, (float) -point2.Y);
    graphics.DrawImage((Image) b, rect);
    graphics.ResetTransform();
    graphics.Save();
    graphics.Dispose();
    return bitmap;
  }

  public Bitmap CropImage(Bitmap originImage, Rectangle region)
  {
    Bitmap bitmap = new Bitmap(region.Width, region.Height);
    Graphics.FromImage((Image) bitmap).DrawImage((Image) originImage, new Rectangle(0, 0, region.Width, region.Height), region, GraphicsUnit.Pixel);
    return bitmap;
  }

  public Bitmap DrawPic(Bitmap b, float angle)
  {
    Bitmap bitmap = this.RotateImg2(b, angle);
    int width1 = bitmap.Width;
    int height1 = bitmap.Height;
    int width2 = bitmap.Width;
    int height2 = bitmap.Height;
    int dx = (width1 - width2) / 2;
    int dy = (height1 - height2) / 2;
    Bitmap originImage = new Bitmap(width1, height1);
    for (int x = 0; x < width1; ++x)
    {
      for (int y = 0; y < height1; ++y)
        originImage.SetPixel(x, y, Color.FromArgb(0, 0, 0));
    }
    Graphics graphics = Graphics.FromImage((Image) originImage);
    graphics.TranslateTransform((float) dx, (float) dy);
    graphics.DrawImage((Image) bitmap, new PointF(0.0f, 0.0f));
    Rectangle region = new Rectangle((width1 - b.Width) / 2, (height1 - b.Height) / 2, b.Width, b.Height);
    return this.CropImage(originImage, region);
  }

  public void GenerateImage(int angle, ArrayList array, int hn)
  {
    SolidBrush solidBrush1 = new SolidBrush(Color.Black);
    Bitmap bitmap;
    Graphics graphics;
    if (this.is320x320)
    {
      bitmap = new Bitmap(320, 320);
      graphics = Graphics.FromImage((Image) bitmap);
      graphics.FillRectangle((Brush) solidBrush1, 0, 0, 320, 320);
    }
    else if (this.is360x360)
    {
      bitmap = new Bitmap(360, 360);
      graphics = Graphics.FromImage((Image) bitmap);
      graphics.FillRectangle((Brush) solidBrush1, 0, 0, 360, 360);
    }
    else if (this.is240x240)
    {
      bitmap = new Bitmap(240 /*0xF0*/, 240 /*0xF0*/);
      graphics = Graphics.FromImage((Image) bitmap);
      graphics.FillRectangle((Brush) solidBrush1, 0, 0, 240 /*0xF0*/, 240 /*0xF0*/);
    }
    else if (this.is480x480)
    {
      bitmap = new Bitmap(480, 480);
      graphics = Graphics.FromImage((Image) bitmap);
      graphics.FillRectangle((Brush) solidBrush1, 0, 0, 480, 480);
    }
    else if (this.is1600x720)
    {
      if (angle == 0 || angle == 180)
      {
        bitmap = new Bitmap(1600, 720);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 1600, 720);
      }
      else
      {
        bitmap = new Bitmap(720, 1600);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 720, 1600);
      }
    }
    else if (this.is800x480)
    {
      if (angle == 0 || angle == 180)
      {
        bitmap = new Bitmap(800, 480);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 800, 480);
      }
      else
      {
        bitmap = new Bitmap(480, 800);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 480, 800);
      }
    }
    else if (this.is854x480)
    {
      if (angle == 0 || angle == 180)
      {
        bitmap = new Bitmap(854, 480);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 854, 480);
      }
      else
      {
        bitmap = new Bitmap(480, 854);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 480, 854);
      }
    }
    else if (this.is960x540)
    {
      if (angle == 0 || angle == 180)
      {
        bitmap = new Bitmap(960, 540);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 960, 540);
      }
      else
      {
        bitmap = new Bitmap(540, 960);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 540, 960);
      }
    }
    else if (this.is960x320)
    {
      if (angle == 0 || angle == 180)
      {
        bitmap = new Bitmap(960, 320);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 960, 320);
      }
      else
      {
        bitmap = new Bitmap(320, 960);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 320, 960);
      }
    }
    else if (this.is1920x462)
    {
      if (angle == 0 || angle == 180)
      {
        bitmap = new Bitmap(1920, 462);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 1920, 462);
      }
      else
      {
        bitmap = new Bitmap(462, 1920);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 462, 1920);
      }
    }
    else if (this.is1280x480)
    {
      if (angle == 0 || angle == 180)
      {
        bitmap = new Bitmap(1280 /*0x0500*/, 480);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 1280 /*0x0500*/, 480);
      }
      else
      {
        bitmap = new Bitmap(480, 1280 /*0x0500*/);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 480, 1280 /*0x0500*/);
      }
    }
    else if (this.is640x480)
    {
      if (angle == 0 || angle == 180)
      {
        bitmap = new Bitmap(640, 480);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 640, 480);
      }
      else
      {
        bitmap = new Bitmap(480, 640);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.FillRectangle((Brush) solidBrush1, 0, 0, 480, 640);
      }
    }
    else if (angle == 0 || angle == 180)
    {
      bitmap = new Bitmap(320, 240 /*0xF0*/);
      graphics = Graphics.FromImage((Image) bitmap);
      graphics.FillRectangle((Brush) solidBrush1, 0, 0, 320, 240 /*0xF0*/);
    }
    else
    {
      bitmap = new Bitmap(240 /*0xF0*/, 320);
      graphics = Graphics.FromImage((Image) bitmap);
      graphics.FillRectangle((Brush) solidBrush1, 0, 0, 240 /*0xF0*/, 320);
    }
    if (this.isDrawBkImage && this.bitmapBGK != null)
    {
      if (this.bitmapBGK.Width <= bitmap.Width + 2)
        graphics.DrawImage((Image) this.bitmapBGK, 0, 0);
      else
        graphics.DrawImage((Image) this.bitmapBGK1, 0, 0);
    }
    if (this.isDrawMbImage && this.bitmapMB != null)
      graphics.DrawImage((Image) this.bitmapMB, this.XvalMB - this.WvalMB / 2, this.YvalMB - this.HvalMB / 2, this.bitmapMB.Width, this.bitmapMB.Height);
    if (this.is1600x720)
    {
      switch (this.myLddVal)
      {
        case 1:
          switch (this.directionB)
          {
            case 0:
              graphics.DrawImage((Image) Resources.P灵动岛, 0, 0);
              break;
            case 90:
              graphics.DrawImage((Image) Resources.P灵动岛90, 0, 0);
              break;
            case 180:
              graphics.DrawImage((Image) Resources.P灵动岛180, 0, 0);
              break;
            case 270:
              graphics.DrawImage((Image) Resources.P灵动岛270, 0, 0);
              break;
          }
          break;
        case 2:
          switch (this.directionB)
          {
            case 0:
              graphics.DrawImage((Image) Resources.P灵动岛a, 0, 0);
              break;
            case 90:
              graphics.DrawImage((Image) Resources.P灵动岛a90, 0, 0);
              break;
            case 180:
              graphics.DrawImage((Image) Resources.P灵动岛a180, 0, 0);
              break;
            case 270:
              graphics.DrawImage((Image) Resources.P灵动岛a270, 0, 0);
              break;
          }
          break;
        case 3:
          switch (this.directionB)
          {
            case 0:
              graphics.DrawImage((Image) Resources.P灵动岛b, 0, 0);
              break;
            case 90:
              graphics.DrawImage((Image) Resources.P灵动岛b90, 0, 0);
              break;
            case 180:
              graphics.DrawImage((Image) Resources.P灵动岛b180, 0, 0);
              break;
            case 270:
              graphics.DrawImage((Image) Resources.P灵动岛b270, 0, 0);
              break;
          }
          break;
      }
    }
    if (this.isDrawXitongXinxi)
    {
      graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
      for (int index = 0; index < array.Count; ++index)
      {
        if (index != hn)
        {
          UCXiTongXianShiSub xiTongXianShiSub = (UCXiTongXianShiSub) array[index];
          string str = xiTongXianShiSub.myMode != 0 ? xiTongXianShiSub.label2.Text : (xiTongXianShiSub.myModeSub != 1 ? xiTongXianShiSub.label2.Text : xiTongXianShiSub.label2.Text + xiTongXianShiSub.label3.Text);
          if (str.Length > 0)
          {
            SolidBrush solidBrush2 = new SolidBrush(xiTongXianShiSub.myColor);
            SizeF sizeF = this.gF.MeasureString(str, xiTongXianShiSub.myFont);
            int width = (int) sizeF.Width + 2;
            int height = (int) sizeF.Height;
            RectangleF layoutRectangle = new RectangleF((float) (xiTongXianShiSub.myX - width / 2), (float) (xiTongXianShiSub.myY - height / 2), (float) width, (float) height);
            graphics.DrawString(str, xiTongXianShiSub.myFont, (Brush) solidBrush2, layoutRectangle, this.m_format);
            solidBrush2.Dispose();
          }
        }
      }
    }
    graphics.Dispose();
    solidBrush1.Dispose();
    if (this.myImage != null)
      this.myImage.Dispose();
    this.myImage = (Image) bitmap;
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (this.is480x480)
    {
      if (this.myImage != null)
        graphics.DrawImage(this.myImage, 0, 0);
      if (this.myDevicePingMu != 3)
        return;
      graphics.DrawImage((Image) this.bitmapBGK2, 0, 0);
    }
    else if (this.is360x360)
    {
      if (this.myImage != null)
        graphics.DrawImage(this.myImage, 0, 0);
      if (this.myDevicePingMu != 100)
        return;
      graphics.DrawImage((Image) this.bitmapBGK3, 0, 0);
    }
    else if (this.is1600x720)
    {
      if (this.isBiliPingmu)
      {
        if (this.myImage == null)
          return;
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 180, 400);
        else
          graphics.DrawImage(this.myImage, 0, 0, 400, 180);
      }
      else if (this.myImage != null)
      {
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 360, 800);
        else
          graphics.DrawImage(this.myImage, 0, 0, 800, 360);
      }
    }
    else if (this.is800x480)
    {
      if (this.isBiliPingmu)
      {
        if (this.myImage == null)
          return;
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 240 /*0xF0*/, 400);
        else
          graphics.DrawImage(this.myImage, 0, 0, 400, 240 /*0xF0*/);
      }
      else if (this.myImage != null)
      {
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 480, 800);
        else
          graphics.DrawImage(this.myImage, 0, 0, 800, 480);
      }
    }
    else if (this.is854x480)
    {
      if (this.isBiliPingmu)
      {
        if (this.myImage == null)
          return;
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 240 /*0xF0*/, 427);
        else
          graphics.DrawImage(this.myImage, 0, 0, 427, 240 /*0xF0*/);
      }
      else if (this.myImage != null)
      {
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 480, 854);
        else
          graphics.DrawImage(this.myImage, 0, 0, 854, 480);
      }
    }
    else if (this.is960x540)
    {
      if (this.isBiliPingmu)
      {
        if (this.myImage == null)
          return;
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 270, 480);
        else
          graphics.DrawImage(this.myImage, 0, 0, 480, 270);
      }
      else if (this.myImage != null)
      {
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 540, 960);
        else
          graphics.DrawImage(this.myImage, 0, 0, 960, 540);
      }
    }
    else if (this.is960x320)
    {
      if (this.isBiliPingmu)
      {
        if (this.myImage == null)
          return;
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 160 /*0xA0*/, 480);
        else
          graphics.DrawImage(this.myImage, 0, 0, 480, 160 /*0xA0*/);
      }
      else if (this.myImage != null)
      {
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 320, 960);
        else
          graphics.DrawImage(this.myImage, 0, 0, 960, 320);
      }
    }
    else if (this.is1280x480)
    {
      if (this.isBiliPingmu)
      {
        if (this.myImage == null)
          return;
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 180, 480);
        else
          graphics.DrawImage(this.myImage, 0, 0, 480, 180);
      }
      else if (this.myImage != null)
      {
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 240 /*0xF0*/, 640);
        else
          graphics.DrawImage(this.myImage, 0, 0, 640, 240 /*0xF0*/);
      }
    }
    else if (this.is1920x462)
    {
      if (this.isBiliPingmu)
      {
        if (this.myImage == null)
          return;
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 116, 480);
        else
          graphics.DrawImage(this.myImage, 0, 0, 480, 116);
      }
      else if (this.myImage != null)
      {
        if (this.isFanZhuan)
          graphics.DrawImage(this.myImage, 0, 0, 231, 960);
        else
          graphics.DrawImage(this.myImage, 0, 0, 960, 231);
      }
    }
    else if (this.is640x480)
    {
      if (this.myImage == null)
        return;
      graphics.DrawImage(this.myImage, 0, 0, this.myImage.Width / 2, this.myImage.Height / 2);
    }
    else if (this.myImage != null)
      graphics.DrawImage(this.myImage, 0, 0);
  }

  private void SetTextPos(int n, int xNew, int yNew, float bili = 1f)
  {
    int num1 = xNew - this.xPos;
    int num2 = yNew - this.yPos;
    if (n == 100)
    {
      int num3 = num1 + this.XvalMB;
      int num4 = num2 + this.YvalMB;
      if (num3 < this.WvalMB / 2)
        num3 = this.WvalMB / 2;
      if (num4 < this.HvalMB / 2)
        num4 = this.HvalMB / 2;
      if ((double) (num3 + this.WvalMB / 2) > (double) this.Width * (double) bili)
        num3 = (int) ((double) this.Width * (double) bili - (double) (this.WvalMB / 2));
      if ((double) (num4 + this.HvalMB / 2) > (double) this.Height * (double) bili)
        num4 = (int) ((double) this.Height * (double) bili - (double) (this.HvalMB / 2));
      this.XvalMB = num3;
      this.YvalMB = num4;
    }
    else
    {
      try
      {
        UCXiTongXianShiSub xiTongXianShiSub = (UCXiTongXianShiSub) this.arrayXianshi[n];
        int x = num1 + xiTongXianShiSub.myX;
        int y = num2 + xiTongXianShiSub.myY;
        if (x < 0)
          x = 0;
        if (y < 0)
          y = 0;
        if ((double) x > (double) this.Width * (double) bili)
          x = (int) ((double) this.Width * (double) bili);
        if ((double) y > (double) this.Height * (double) bili)
          y = (int) ((double) this.Height * (double) bili);
        xiTongXianShiSub.ScreenXYSet(x, y);
      }
      catch
      {
      }
    }
    this.xPos = xNew;
    this.yPos = yNew;
  }

  private void UCScreenImage_MouseDoubleClick(object sender, MouseEventArgs e)
  {
    if (!this.isBiliPingmu)
      return;
    UCScreenImage.delegateUCScreenImage ucScreenImage = this.ucScreenImage;
    if (ucScreenImage != null)
      ucScreenImage(0);
  }

  private void UCScreenImage_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this.xPos = e.X;
    this.yPos = e.Y;
    this.isDMouseDown = -1;
    this.isDMouseDownMB = false;
    if (this.isBiliPingmu)
      return;
    if (this.is1600x720 || this.is640x480 || this.is1920x462 || this.is1280x480)
    {
      this.xPos = e.X * 2;
      this.yPos = e.Y * 2;
    }
    try
    {
      if (this.isDrawXitongXinxi)
      {
        for (int index = 0; index < this.arrayXianshi.Count; ++index)
        {
          UCXiTongXianShiSub xiTongXianShiSub = (UCXiTongXianShiSub) this.arrayXianshi[index];
          string text = xiTongXianShiSub.myMode != 0 ? xiTongXianShiSub.label2.Text : (xiTongXianShiSub.myModeSub != 1 ? xiTongXianShiSub.label2.Text : xiTongXianShiSub.label2.Text + xiTongXianShiSub.label3.Text);
          if (text.Length > 0)
          {
            SizeF sizeF = this.gF.MeasureString(text, xiTongXianShiSub.myFont);
            int num = (int) sizeF.Width + 2;
            int height = (int) sizeF.Height;
            if (this.xPos > xiTongXianShiSub.myX - num / 2 && this.xPos < xiTongXianShiSub.myX + num / 2 && this.yPos > xiTongXianShiSub.myY - height / 2 && this.yPos < xiTongXianShiSub.myY + height / 2)
            {
              this.isMouseDown = index;
              this.isDMouseDown = index;
              UCScreenImage.delegateUCScreenImage ucScreenImage = this.ucScreenImage;
              if (ucScreenImage != null)
              {
                ucScreenImage(1, this.isDMouseDown);
                break;
              }
              break;
            }
          }
        }
      }
    }
    catch
    {
    }
    if (this.isMouseDown == -1 && this.isDrawMbImage && this.xPos > this.XvalMB - this.WvalMB / 2 && this.xPos < this.XvalMB + this.WvalMB / 2 && this.yPos > this.YvalMB - this.HvalMB / 2 && this.yPos < this.YvalMB + this.HvalMB / 2)
    {
      this.isMouseDownMB = true;
      this.isDMouseDownMB = true;
    }
  }

  private void UCScreenImage_MouseMove(object sender, MouseEventArgs e)
  {
    if (e.X < 0 || e.X > this.Width || e.Y < 0 || e.Y > this.Height)
      return;
    if (this.is1600x720 || this.is640x480 || this.is1920x462 || this.is1280x480)
    {
      int xNew = e.X * 2;
      int yNew = e.Y * 2;
      if (this.isMouseDown > -1)
      {
        this.SetTextPos(this.isMouseDown, xNew, yNew, 2f);
      }
      else
      {
        if (!this.isMouseDownMB)
          return;
        this.SetTextPos(100, xNew, yNew, 2f);
      }
    }
    else if (this.isMouseDown > -1)
    {
      this.SetTextPos(this.isMouseDown, e.X, e.Y);
    }
    else
    {
      if (!this.isMouseDownMB)
        return;
      this.SetTextPos(100, e.X, e.Y);
    }
  }

  private void UCScreenImage_MouseUp(object sender, MouseEventArgs e)
  {
    this.isMouseDown = -1;
    this.isMouseDownMB = false;
  }

  public void SetDMouseDown(int n)
  {
    if (n != -1)
      this.isDMouseDownMB = false;
    this.isDMouseDown = n;
    this.Focus();
  }

  private void UCScreenImage_KeyDown(object sender, KeyEventArgs e)
  {
    float num1 = 1f;
    int num2;
    int num3;
    if (e.KeyCode == Keys.W)
    {
      num2 = 0;
      num3 = e.Shift ? -10 : -1;
    }
    else if (e.KeyCode == Keys.S)
    {
      num2 = 0;
      num3 = e.Shift ? 10 : 1;
    }
    else if (e.KeyCode == Keys.A)
    {
      num2 = e.Shift ? -10 : -1;
      num3 = 0;
    }
    else
    {
      if (e.KeyCode != Keys.D)
        return;
      num2 = e.Shift ? 10 : 1;
      num3 = 0;
    }
    if (this.isBiliPingmu)
      return;
    if (this.is1600x720 && !this.isBiliPingmu || this.is1920x462 && !this.isBiliPingmu || this.is1280x480 || this.is640x480)
      num1 = 2f;
    if (this.isDMouseDown > -1)
    {
      try
      {
        UCXiTongXianShiSub xiTongXianShiSub = (UCXiTongXianShiSub) this.arrayXianshi[this.isDMouseDown];
        int x = num2 + xiTongXianShiSub.myX;
        int y = num3 + xiTongXianShiSub.myY;
        if (x < 0)
          x = 0;
        if (y < 0)
          y = 0;
        if ((double) x > (double) this.Width * (double) num1)
          x = (int) ((double) this.Width * (double) num1);
        if ((double) y > (double) this.Height * (double) num1)
          y = (int) ((double) this.Height * (double) num1);
        xiTongXianShiSub.ScreenXYSet(x, y);
      }
      catch
      {
      }
    }
    else
    {
      if (!this.isDMouseDownMB)
        return;
      int num4 = num2 + this.XvalMB;
      int num5 = num3 + this.YvalMB;
      if (num4 < this.WvalMB / 2)
        num4 = this.WvalMB / 2;
      if (num5 < this.HvalMB / 2)
        num5 = this.HvalMB / 2;
      if ((double) (num4 + this.WvalMB / 2) > (double) this.Width * (double) num1)
        num4 = (int) ((double) this.Width * (double) num1 - (double) (this.WvalMB / 2));
      if ((double) (num5 + this.HvalMB / 2) > (double) this.Height * (double) num1)
        num5 = (int) ((double) this.Height * (double) num1 - (double) (this.HvalMB / 2));
      this.XvalMB = num4;
      this.YvalMB = num5;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Black;
    this.BackgroundImageLayout = ImageLayout.Zoom;
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCScreenImage);
    this.Size = new Size(320, 240 /*0xF0*/);
    this.KeyDown += new KeyEventHandler(this.UCScreenImage_KeyDown);
    this.MouseDoubleClick += new MouseEventHandler(this.UCScreenImage_MouseDoubleClick);
    this.MouseDown += new MouseEventHandler(this.UCScreenImage_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCScreenImage_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCScreenImage_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCScreenImage(int mode, int count = 0);
}

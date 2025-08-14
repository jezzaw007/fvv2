// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCInfoImage
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCInfoImage : UserControl
{
  public int myLine = 0;
  public string myName = "";
  public const int TempMaxVal = 100;
  public const int TempMinValF = 32 /*0x20*/;
  public const int TempMaxValF = 212;
  public const int FanMaxVal = 5000;
  public Color myLineColor = Color.White;
  public Font fontNumber = new Font("微软雅黑", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
  public Font fontName = new Font("微软雅黑", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
  public Font fontText = new Font("微软雅黑", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
  public SolidBrush fontNumberBrush = new SolidBrush(Color.White);
  public SolidBrush fontNameBrush = new SolidBrush(Color.White);
  public SolidBrush fontTextBrush = new SolidBrush(Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
  public int myMode = 1;
  public int myTextMode = 1;
  public int myVal = 100;
  public string val1 = "";
  public string val2 = "";
  public string val3 = "";
  public string Mval = "";
  public Bitmap bitmap = (Bitmap) null;
  private Image myImage = (Image) null;
  private StringFormat m_format = new StringFormat();
  private IContainer components = (IContainer) null;

  public UCInfoImage()
  {
    this.InitializeComponent();
    this.m_format.LineAlignment = StringAlignment.Center;
    this.m_format.Alignment = StringAlignment.Far;
    this.bitmap = Resources.P环H1;
  }

  public void SetUCState(int val = 0, string str1 = "", string str2 = "", string str3 = "")
  {
    if (this.myTextMode == 1)
    {
      if (val < 0)
        val = 0;
      if (val > 100)
        val = 100;
    }
    else if (this.myTextMode == 2)
    {
      if (val < 0)
        val = 0;
      if (val > 5000)
        val = 5000;
    }
    else if (this.myTextMode == 17)
    {
      if (val < 32 /*0x20*/)
        val = 32 /*0x20*/;
      if (val > 212)
        val = 212;
      val = (val - 32 /*0x20*/) * 5 / 9;
    }
    this.myVal = val;
    this.val1 = str1;
    this.val2 = str2;
    this.val3 = str3;
    this.GenerateImage();
    this.Invalidate();
  }

  public void SetTextMode(int mode) => this.myTextMode = mode;

  public void GenerateImage()
  {
    Bitmap bitmap = new Bitmap(this.Width, this.Height);
    Graphics graphics = Graphics.FromImage((Image) bitmap);
    RectangleF layoutRectangle = new RectangleF(0.0f, 3f, (float) this.Width, this.fontName.Size * 2f);
    if (this.myMode == 1)
    {
      if (this.myVal != 0)
      {
        if (this.myTextMode == 1 || this.myTextMode == 17)
          graphics.DrawImage((Image) this.bitmap, 35, 22, this.myVal * 2, 3);
        else
          graphics.DrawImage((Image) this.bitmap, 35, 22, this.myVal / 25, 3);
      }
      layoutRectangle = new RectangleF(0.0f, 2f, (float) (this.Width - 5), this.fontNumber.Size * 2f);
      graphics.DrawString(this.val1, this.fontNumber, (Brush) this.fontNumberBrush, layoutRectangle, this.m_format);
    }
    graphics.Dispose();
    Image image = this.myImage;
    this.myImage = (Image) bitmap;
    image?.Dispose();
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (this.myImage == null)
      return;
    graphics.DrawImage(this.myImage, 0, 0);
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
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P0M1;
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCInfoImage);
    this.Size = new Size(240 /*0xF0*/, 30);
    this.ResumeLayout(false);
  }
}

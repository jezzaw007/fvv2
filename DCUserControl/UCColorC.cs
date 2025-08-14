// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCColorC
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCColorC : UserControl
{
  public Color MyColor = Color.Red;
  public Bitmap MyBitmap = (Bitmap) null;
  private bool isMouseDown = false;
  private int colorX = 4;
  private int colorY = 4;
  private Bitmap colorBitmap = (Bitmap) null;
  public UCColorC.delegateUCColorC delegateUCColor;
  private IContainer components = (IContainer) null;

  public UCColorC()
  {
    this.InitializeComponent();
    this.MyBitmap = new Bitmap(this.Width - 8, this.Height - 8);
    this.colorBitmap = Resources.P颜色选择圈;
    this.ColorToBitmap();
  }

  private Color InterpolateColor(Color startColor, Color endColor, double fraction)
  {
    if (fraction < 0.0)
      fraction = 0.0;
    if (fraction > 1.0)
      fraction = 1.0;
    return Color.FromArgb((int) ((double) startColor.R * (1.0 - fraction) + (double) endColor.R * fraction), (int) ((double) startColor.G * (1.0 - fraction) + (double) endColor.G * fraction), (int) ((double) startColor.B * (1.0 - fraction) + (double) endColor.B * fraction));
  }

  private void ColorToBitmap()
  {
    for (int x = 0; x < this.MyBitmap.Width; ++x)
    {
      this.MyBitmap.SetPixel(x, 0, this.InterpolateColor(this.MyColor, Color.White, (double) x * 1.0 / (double) (this.MyBitmap.Width - 1)));
      for (int y = 1; y < this.MyBitmap.Height; ++y)
        this.MyBitmap.SetPixel(x, y, this.InterpolateColor(this.MyBitmap.GetPixel(x, 0), Color.Black, (double) y * 1.0 / (double) (this.MyBitmap.Height - 1)));
    }
  }

  public void SetUCColorC(int r, int g, int b)
  {
    this.colorX = this.colorY = 4;
    this.MyColor = Color.FromArgb(r, g, b);
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (!this.isMouseDown)
      this.ColorToBitmap();
    graphics.DrawImage((Image) this.MyBitmap, 4, 4);
    graphics.DrawImage((Image) this.colorBitmap, this.colorX - 4, this.colorY - 4);
  }

  private void UCColorC_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this.colorX = e.X;
    this.colorY = e.Y;
    if (this.colorX < 4)
      this.colorX = 4;
    if (this.colorX > this.MyBitmap.Width + 3)
      this.colorX = this.MyBitmap.Width + 3;
    if (this.colorY < 4)
      this.colorY = 4;
    if (this.colorY > this.MyBitmap.Height + 3)
      this.colorY = this.MyBitmap.Height + 3;
    Color pixel = this.MyBitmap.GetPixel(this.colorX - 4, this.colorY - 4);
    UCColorC.delegateUCColorC delegateUcColor = this.delegateUCColor;
    if (delegateUcColor != null)
      delegateUcColor(1, (int) pixel.R, (int) pixel.G, (int) pixel.B);
    this.isMouseDown = true;
    this.Invalidate();
  }

  private void UCColorC_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    this.colorX = e.X;
    this.colorY = e.Y;
    if (this.colorX < 4)
      this.colorX = 4;
    if (this.colorX > this.MyBitmap.Width + 3)
      this.colorX = this.MyBitmap.Width + 3;
    if (this.colorY < 4)
      this.colorY = 4;
    if (this.colorY > this.MyBitmap.Height + 3)
      this.colorY = this.MyBitmap.Height + 3;
    Color pixel = this.MyBitmap.GetPixel(this.colorX - 4, this.colorY - 4);
    UCColorC.delegateUCColorC delegateUcColor = this.delegateUCColor;
    if (delegateUcColor != null)
      delegateUcColor(1, (int) pixel.R, (int) pixel.G, (int) pixel.B);
    this.Invalidate();
  }

  private void UCColorC_MouseUp(object sender, MouseEventArgs e) => this.isMouseDown = false;

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
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCColorC);
    this.Size = new Size(214, 136);
    this.MouseDown += new MouseEventHandler(this.UCColorC_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCColorC_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCColorC_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCColorC(int cmd, int R = 0, int G = 0, int B = 0);
}

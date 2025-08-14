// Decompiled with JetBrains decompiler
// Type: TRCC.CZTV.FormGetColor
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#nullable disable
namespace TRCC.CZTV;

public class FormGetColor : Form
{
  public FormGetColor.delegateFormGetColor ucdelegateForm;
  private double sfblJP = 1.0;
  private const int MY_W_H = 12;
  private Color myColor = Color.FromArgb(0, 0, 0);
  private Bitmap myBitmap = (Bitmap) null;
  private int myX;
  private int myY;
  private IContainer components = (IContainer) null;

  public FormGetColor() => this.InitializeComponent();

  public void InitFormGetColor(double val)
  {
    this.sfblJP = val;
    this.myBitmap = new Bitmap((int) (12.0 * this.sfblJP), (int) (12.0 * this.sfblJP));
  }

  private void FormGetColor_MouseMove(object sender, MouseEventArgs e)
  {
    this.myX = (int) ((double) e.X * this.sfblJP) - this.myBitmap.Width / 2;
    this.myY = (int) ((double) e.Y * this.sfblJP) - this.myBitmap.Height / 2;
  }

  public void MyTimer()
  {
    if (!this.Visible)
      return;
    Graphics graphics = Graphics.FromImage((Image) this.myBitmap);
    graphics.CompositingQuality = CompositingQuality.HighSpeed;
    try
    {
      graphics.CopyFromScreen(this.myX, this.myY, 0, 0, new Size(this.myBitmap.Width, this.myBitmap.Height));
    }
    catch
    {
      graphics.Dispose();
      return;
    }
    graphics.Dispose();
    this.myColor = this.myBitmap.GetPixel(this.myBitmap.Width / 2, this.myBitmap.Height / 2);
    FormGetColor.delegateFormGetColor ucdelegateForm = this.ucdelegateForm;
    if (ucdelegateForm != null)
      ucdelegateForm(1, this.myColor, this.myBitmap);
  }

  private void FormGetColor_MouseClick(object sender, MouseEventArgs e)
  {
    this.Hide();
    if (e.Button == MouseButtons.Left)
    {
      FormGetColor.delegateFormGetColor ucdelegateForm = this.ucdelegateForm;
      if (ucdelegateForm == null)
        return;
      ucdelegateForm(0, this.myColor);
    }
    else
    {
      FormGetColor.delegateFormGetColor ucdelegateForm = this.ucdelegateForm;
      if (ucdelegateForm != null)
        ucdelegateForm(2, this.myColor);
    }
  }

  private void FormGetColor_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = true;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormGetColor));
    this.SuspendLayout();
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.FromArgb(1, 2, 3);
    this.BackgroundImageLayout = ImageLayout.None;
    this.ClientSize = new Size(320, 240 /*0xF0*/);
    this.Cursor = Cursors.Cross;
    this.DoubleBuffered = true;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormGetColor);
    this.TopMost = true;
    this.TransparencyKey = Color.FromArgb(1, 2, 3);
    this.FormClosing += new FormClosingEventHandler(this.FormGetColor_FormClosing);
    this.MouseClick += new MouseEventHandler(this.FormGetColor_MouseClick);
    this.MouseMove += new MouseEventHandler(this.FormGetColor_MouseMove);
    this.ResumeLayout(false);
  }

  public delegate void delegateFormGetColor(int mode, Color color, Bitmap bitmap = null);
}

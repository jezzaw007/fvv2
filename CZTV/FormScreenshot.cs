// Decompiled with JetBrains decompiler
// Type: TRCC.CZTV.FormScreenshot
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace TRCC.CZTV;

public class FormScreenshot : Form
{
  public FormScreenshot.delegateFormScreenshot ucdelegateForm;
  public bool isMouseDown = false;
  private Point _mousePoint;
  private IContainer components = (IContainer) null;

  public FormScreenshot() => this.InitializeComponent();

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    Pen pen = new Pen(Color.FromArgb(200, 200, 200), 5f);
    graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
    pen.Dispose();
  }

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams = base.CreateParams;
      createParams.ExStyle |= 33554432 /*0x02000000*/;
      return createParams;
    }
  }

  private void FormScreenshot_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = true;

  public void FormScreenshot_DoubleClick(object sender, EventArgs e)
  {
    this.Hide();
    FormScreenshot.delegateFormScreenshot ucdelegateForm = this.ucdelegateForm;
    if (ucdelegateForm == null)
      return;
    ucdelegateForm(0, 0, 0);
  }

  private void FormScreenshot_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this._mousePoint = new Point(-e.X, -e.Y);
    this.isMouseDown = true;
  }

  private void FormScreenshot_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    Point mousePosition = Control.MousePosition;
    mousePosition.Offset(this._mousePoint.X, this._mousePoint.Y);
    this.Location = mousePosition;
  }

  private void FormScreenshot_MouseUp(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    if (!this._mousePoint.IsEmpty)
    {
      FormScreenshot.delegateFormScreenshot ucdelegateForm = this.ucdelegateForm;
      if (ucdelegateForm != null)
        ucdelegateForm(1, this.Left, this.Top);
    }
    this.isMouseDown = false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormScreenshot));
    this.SuspendLayout();
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.FromArgb(1, 2, 3);
    this.BackgroundImageLayout = ImageLayout.None;
    this.ClientSize = new Size(320, 240 /*0xF0*/);
    this.DoubleBuffered = true;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormScreenshot);
    this.TopMost = true;
    this.TransparencyKey = Color.FromArgb(1, 2, 3);
    this.FormClosing += new FormClosingEventHandler(this.FormScreenshot_FormClosing);
    this.DoubleClick += new EventHandler(this.FormScreenshot_DoubleClick);
    this.MouseDown += new MouseEventHandler(this.FormScreenshot_MouseDown);
    this.MouseMove += new MouseEventHandler(this.FormScreenshot_MouseMove);
    this.MouseUp += new MouseEventHandler(this.FormScreenshot_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateFormScreenshot(int mode, int x, int y);
}

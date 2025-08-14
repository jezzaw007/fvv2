// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCScrollA
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCScrollA : UserControl
{
  private int myVal = (int) byte.MaxValue;
  private bool isMouseDown = false;
  public Image imageBB = (Image) Resources.D3滑动条按钮;
  public UCScrollA.delegate_UCScrollA upDateUCScroll;
  private IContainer components = (IContainer) null;

  private void Math_myVal(int x)
  {
    int num = x;
    if (num < 0)
      num = 0;
    if (num > this.Width - this.imageBB.Width)
      num = this.Width - this.imageBB.Width;
    this.myVal = num * (int) byte.MaxValue / (this.Width - this.imageBB.Width);
  }

  private void UCScrollA_MouseDown(object sender, MouseEventArgs e)
  {
    if (this.isMouseDown || e.Button != MouseButtons.Left)
      return;
    this.isMouseDown = true;
    this.Math_myVal(e.X);
    this.Invalidate();
  }

  private void UCScrollA_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    this.Math_myVal(e.X);
    this.Invalidate();
    UCScrollA.delegate_UCScrollA upDateUcScroll = this.upDateUCScroll;
    if (upDateUcScroll != null)
      upDateUcScroll(this.myVal);
  }

  private void UCScrollA_MouseUp(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    this.Math_myVal(e.X);
    this.Invalidate();
    this.isMouseDown = false;
    UCScrollA.delegate_UCScrollA upDateUcScroll = this.upDateUCScroll;
    if (upDateUcScroll != null)
      upDateUcScroll(this.myVal);
  }

  public UCScrollA() => this.InitializeComponent();

  public void SetUCScrollA(int val)
  {
    this.myVal = val;
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    pe.Graphics.DrawImage(this.imageBB, (this.Width - this.imageBB.Width) * this.myVal / (int) byte.MaxValue, 0);
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
    this.BackgroundImageLayout = ImageLayout.None;
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCScrollA);
    this.Size = new Size(190, 20);
    this.MouseDown += new MouseEventHandler(this.UCScrollA_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCScrollA_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCScrollA_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegate_UCScrollA(int val);
}

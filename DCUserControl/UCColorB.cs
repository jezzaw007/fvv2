// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCColorB
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCColorB : UserControl
{
  private Image imageSelect = (Image) Resources.P颜色滑动块;
  private int imageCenterX = 0;
  private int myColorR = (int) byte.MaxValue;
  private int myColorG = 0;
  private int myColorB = 0;
  private bool isMouseDown = false;
  public UCColorB.delegateUCColorB delegateUCColor;
  private IContainer components = (IContainer) null;

  public UCColorB()
  {
    this.InitializeComponent();
    this.imageCenterX = this.imageSelect.Width / 2;
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    pe.Graphics.DrawImage(this.imageSelect, this.imageCenterX - this.imageSelect.Width / 2, 0);
  }

  private void UCColorB_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this.imageCenterX = e.X;
    if (this.imageCenterX < this.imageSelect.Width / 2)
      this.imageCenterX = this.imageSelect.Width / 2;
    if (this.imageCenterX > this.Width - this.imageSelect.Width / 2)
      this.imageCenterX = this.Width - this.imageSelect.Width / 2;
    this.isMouseDown = true;
    this.Invalidate();
    this.UCColorB_Color();
    UCColorB.delegateUCColorB delegateUcColor = this.delegateUCColor;
    if (delegateUcColor != null)
      delegateUcColor(1, this.myColorR, this.myColorG, this.myColorB);
  }

  private void UCColorB_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    this.imageCenterX = e.X;
    if (this.imageCenterX < this.imageSelect.Width / 2)
      this.imageCenterX = this.imageSelect.Width / 2;
    if (this.imageCenterX > this.Width - this.imageSelect.Width / 2)
      this.imageCenterX = this.Width - this.imageSelect.Width / 2;
    this.Invalidate();
    this.UCColorB_Color();
    UCColorB.delegateUCColorB delegateUcColor = this.delegateUCColor;
    if (delegateUcColor != null)
      delegateUcColor(1, this.myColorR, this.myColorG, this.myColorB);
  }

  private void UCColorB_MouseUp(object sender, MouseEventArgs e) => this.isMouseDown = false;

  private void UCColorB_Color()
  {
    int num1 = this.Width - this.imageSelect.Width;
    int num2 = this.imageCenterX - this.imageSelect.Width / 2;
    int num3 = num1 / 6;
    if (num2 < num3)
    {
      this.myColorR = (int) byte.MaxValue;
      this.myColorG = (int) byte.MaxValue * num2 / num3;
      this.myColorB = 0;
    }
    else if (num2 < num3 * 2)
    {
      this.myColorR = (int) byte.MaxValue - (int) byte.MaxValue * (num2 - num3) / num3;
      this.myColorG = (int) byte.MaxValue;
      this.myColorB = 0;
    }
    else if (num2 < num3 * 3)
    {
      int num4 = num2 - num3 * 2;
      this.myColorR = 0;
      this.myColorG = (int) byte.MaxValue;
      this.myColorB = (int) byte.MaxValue * num4 / num3;
    }
    else if (num2 < num3 * 4)
    {
      int num5 = num2 - num3 * 3;
      this.myColorR = 0;
      this.myColorG = (int) byte.MaxValue - (int) byte.MaxValue * num5 / num3;
      this.myColorB = (int) byte.MaxValue;
    }
    else if (num2 < num3 * 5)
    {
      this.myColorR = (int) byte.MaxValue * (num2 - num3 * 4) / num3;
      this.myColorG = 0;
      this.myColorB = (int) byte.MaxValue;
    }
    else
    {
      int num6 = num2 - num3 * 5;
      this.myColorR = (int) byte.MaxValue;
      this.myColorG = 0;
      this.myColorB = (int) byte.MaxValue - (int) byte.MaxValue * num6 / num3;
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
    this.BackColor = Color.Transparent;
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCColorB);
    this.Size = new Size(158, 19);
    this.MouseDown += new MouseEventHandler(this.UCColorB_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCColorB_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCColorB_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCColorB(int cmd, int R = 0, int G = 0, int B = 0);
}

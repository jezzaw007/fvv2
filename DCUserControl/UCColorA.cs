// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCColorA
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCColorA : UserControl
{
  public UCColorA.delegate_UCColorA upDateUCColor;
  public UCColorA.delegate_UCColorOnoff upDateUCColorOnoff;
  private readonly Image pointImg = (Image) Resources.D3旋钮0;
  public int imageX = 0;
  public int imageY = 0;
  private bool isMouseDown = false;
  private int xPos;
  private int yPos;
  private int centerX;
  private int centerY;
  private readonly int MaxR = 110;
  private readonly int MinR = 60;
  private readonly int RGBR = 78;
  private double rgbVal = 0.0;
  public byte colourR = byte.MaxValue;
  public byte colourG = 0;
  public byte colourB = 0;
  public byte onOFF = 1;
  private IContainer components = (IContainer) null;
  public Button buttonDSHX;

  public UCColorA()
  {
    this.InitializeComponent();
    this.centerX = this.Width / 2;
    this.centerY = this.Height / 2;
    this.imageX = this.centerX - this.pointImg.Width / 2;
    this.imageY = this.centerY - this.RGBR - this.pointImg.Height / 2;
    this.buttonDSHX.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public void SetButtonDSHX(byte val)
  {
    this.onOFF = val;
    if (val == (byte) 1)
      this.buttonDSHX.BackgroundImage = (Image) Resources.D3开关a;
    else if (val == (byte) 0)
      this.buttonDSHX.BackgroundImage = (Image) Resources.D3开关;
    else
      this.buttonDSHX.BackgroundImage = (Image) Resources.D3开关b;
  }

  private void buttonDSHX_Click(object sender, EventArgs e)
  {
    if (this.onOFF == (byte) 1)
    {
      this.onOFF = (byte) 0;
      this.buttonDSHX.BackgroundImage = (Image) Resources.D3开关;
    }
    else
    {
      this.onOFF = (byte) 1;
      this.buttonDSHX.BackgroundImage = (Image) Resources.D3开关a;
    }
    UCColorA.delegate_UCColorOnoff dateUcColorOnoff = this.upDateUCColorOnoff;
    if (dateUcColorOnoff == null)
      return;
    dateUcColorOnoff(this.onOFF);
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    pe.Graphics.DrawImage(this.pointImg, new Rectangle(this.imageX, this.imageY, this.pointImg.Width, this.pointImg.Height));
  }

  private void DCColourSelect_Move()
  {
    if (this.xPos == this.centerX)
    {
      if (this.yPos > this.centerY)
      {
        this.imageX = this.xPos - this.pointImg.Width / 2;
        this.imageY = this.centerY + this.RGBR - this.pointImg.Height / 2;
      }
      else
      {
        this.imageX = this.xPos - this.pointImg.Width / 2;
        this.imageY = this.centerY - this.RGBR - this.pointImg.Height / 2;
      }
    }
    else if (this.xPos > this.centerX)
    {
      double num1 = (double) (this.yPos - this.centerY) / (double) (this.xPos - this.centerX);
      double num2 = Math.Pow((double) (this.RGBR * this.RGBR) / (1.0 + num1 * num1), 0.5);
      double num3 = num1 * num2;
      this.imageX = (int) (num2 + (double) this.centerX - (double) (this.pointImg.Width / 2));
      this.imageY = (int) (num3 + (double) this.centerY - (double) (this.pointImg.Height / 2));
    }
    else
    {
      double num4 = (double) (this.yPos - this.centerY) / (double) (this.xPos - this.centerX);
      double num5 = -Math.Pow((double) (this.RGBR * this.RGBR) / (1.0 + num4 * num4), 0.5);
      double num6 = num4 * num5;
      this.imageX = (int) (num5 + (double) this.centerX - (double) (this.pointImg.Width / 2));
      this.imageY = (int) (num6 + (double) this.centerY - (double) (this.pointImg.Height / 2));
    }
  }

  private void setRGBVal(double val)
  {
    int r = 0;
    int g = 0;
    int b = 0;
    if (val < 0.0)
      val += 360.0;
    val = (val + 0.0) % 360.0;
    if (val <= 60.0)
    {
      r = (int) byte.MaxValue;
      b = (int) ((double) byte.MaxValue * val / 60.0);
    }
    else if (val <= 120.0)
    {
      r = (int) ((double) byte.MaxValue * (120.0 - val) / 60.0);
      b = (int) byte.MaxValue;
    }
    else if (val <= 180.0)
    {
      g = (int) ((double) byte.MaxValue * (val - 120.0) / 60.0);
      b = (int) byte.MaxValue;
    }
    else if (val <= 240.0)
    {
      g = (int) byte.MaxValue;
      b = (int) ((double) byte.MaxValue * (240.0 - val) / 60.0);
    }
    else if (val <= 300.0)
    {
      g = (int) byte.MaxValue;
      r = (int) ((double) byte.MaxValue * (val - 240.0) / 60.0);
    }
    else
    {
      r = (int) byte.MaxValue;
      g = (int) ((double) byte.MaxValue * (360.0 - val) / 60.0);
    }
    this.colourR = (byte) r;
    this.colourB = (byte) b;
    this.colourG = (byte) g;
    UCColorA.delegate_UCColorA upDateUcColor = this.upDateUCColor;
    if (upDateUcColor == null)
      return;
    upDateUcColor(r, g, b);
  }

  private void UCColorA_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this.xPos = e.X;
    this.yPos = e.Y;
    if ((this.xPos - this.centerX) * (this.xPos - this.centerX) + (this.yPos - this.centerY) * (this.yPos - this.centerY) < this.MaxR * this.MaxR && (this.xPos - this.centerX) * (this.xPos - this.centerX) + (this.yPos - this.centerY) * (this.yPos - this.centerY) > this.MinR * this.MinR)
    {
      this.isMouseDown = true;
      this.DCColourSelect_Move();
      this.Invalidate();
    }
  }

  private void UCColorA_MouseMove(object sender, MouseEventArgs e)
  {
    this.xPos = e.X;
    this.yPos = e.Y;
    if (!this.isMouseDown)
      return;
    this.DCColourSelect_Move();
    this.Invalidate();
  }

  private void UCColorA_MouseUp(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    this.DCColourSelect_Move();
    this.isMouseDown = false;
    double centerX = (double) this.centerX;
    double centerY = (double) this.centerY;
    double num1 = (double) e.X - centerX;
    double num2 = (double) e.Y - centerY;
    if (num2 < 0.0)
      this.rgbVal = Math.Atan(num1 / num2) * 180.0 / Math.PI;
    else if (num2 > 0.0)
    {
      this.rgbVal = Math.Atan(num1 / num2) * 180.0 / Math.PI;
      this.rgbVal += 180.0;
    }
    else
      this.rgbVal = num1 <= 0.0 ? 90.0 : 270.0;
    this.setRGBVal(this.rgbVal);
    this.Invalidate();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonDSHX = new Button();
    this.SuspendLayout();
    this.buttonDSHX.BackColor = Color.Transparent;
    this.buttonDSHX.BackgroundImage = (Image) Resources.D3开关a;
    this.buttonDSHX.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDSHX.FlatAppearance.BorderSize = 0;
    this.buttonDSHX.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDSHX.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDSHX.FlatStyle = FlatStyle.Flat;
    this.buttonDSHX.Location = new Point(83, 83);
    this.buttonDSHX.Margin = new Padding(0);
    this.buttonDSHX.Name = "buttonDSHX";
    this.buttonDSHX.Size = new Size(50, 50);
    this.buttonDSHX.TabIndex = 99;
    this.buttonDSHX.UseVisualStyleBackColor = false;
    this.buttonDSHX.Click += new EventHandler(this.buttonDSHX_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.D3旋钮;
    this.BackgroundImageLayout = ImageLayout.Center;
    this.Controls.Add((Control) this.buttonDSHX);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCColorA);
    this.Size = new Size(216, 216);
    this.MouseDown += new MouseEventHandler(this.UCColorA_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCColorA_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCColorA_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegate_UCColorA(int r, int g, int b);

  public delegate void delegate_UCColorOnoff(byte onOff);
}

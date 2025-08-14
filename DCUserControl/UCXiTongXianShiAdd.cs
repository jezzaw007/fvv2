// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCXiTongXianShiAdd
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCXiTongXianShiAdd : UserControl
{
  public UCXiTongXianShiAdd.delegateXiTongXianShiAdd delegateAdd;
  public Font myFont = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
  public SolidBrush myFontBrush = new SolidBrush(UCSystemInfoOptionsOne.myColorZDY);
  private StringFormat myFormat = new StringFormat();
  private const int myImageXS = 12;
  private const int myImageYS = 67;
  private const int myImageY = 20;
  private const int myImageW_2 = 92;
  private const int myImageX_W = 104;
  private const int myImageW = 189;
  private const int myImageH = 20;
  private const int myImageButtonX = 199;
  private const int myImageButtonY = 90;
  private const int myGundongtiaoXS = 215;
  private const int myGundongtiaoYS = 64 /*0x40*/;
  private const int myGundongtiaoOffset = 6;
  private Bitmap bitmapAdd;
  private Bitmap bitmapAdda;
  private Image imageGdt;
  private Image imageBk;
  private bool isMouseDown = false;
  private bool isMouseDownButton = false;
  private int imageY = 0;
  private int offsetY = 0;
  private int nowCoutMain = -1;
  private int nowCoutSub = -1;
  private int myX = 0;
  private int myY = 0;
  public bool isFanLcd = false;
  public int fanLcdVal = 0;
  private IContainer components = (IContainer) null;
  private Button buttonTimer;
  private Button buttonWeek;
  private Button buttonDate;
  private Button buttonText;

  public UCXiTongXianShiAdd()
  {
    this.InitializeComponent();
    this.buttonTimer.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonWeek.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonDate.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonText.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.bitmapAdd = Resources.P点选框;
    this.bitmapAdda = Resources.P点选框A;
    this.imageGdt = (Image) Resources.P滚动条按钮;
    this.imageBk = (Image) Resources.P01增加内容遮罩;
    this.myFormat.LineAlignment = StringAlignment.Center;
    this.myFormat.Alignment = StringAlignment.Near;
    this.imageY = 64 /*0x40*/ + this.imageGdt.Height / 2;
    this.MouseWheel += new MouseEventHandler(this.FrmMain_MouseWheel);
  }

  private void buttonTimer_Click(object sender, EventArgs e)
  {
    UCXiTongXianShiAdd.delegateXiTongXianShiAdd delegateAdd = this.delegateAdd;
    if (delegateAdd != null)
      delegateAdd(32 /*0x20*/);
    this.Hide();
  }

  private void buttonWeek_Click(object sender, EventArgs e)
  {
    UCXiTongXianShiAdd.delegateXiTongXianShiAdd delegateAdd = this.delegateAdd;
    if (delegateAdd != null)
      delegateAdd(48 /*0x30*/);
    this.Hide();
  }

  private void buttonDate_Click(object sender, EventArgs e)
  {
    UCXiTongXianShiAdd.delegateXiTongXianShiAdd delegateAdd = this.delegateAdd;
    if (delegateAdd != null)
      delegateAdd(64 /*0x40*/);
    this.Hide();
  }

  private void buttonText_Click(object sender, EventArgs e)
  {
    UCXiTongXianShiAdd.delegateXiTongXianShiAdd delegateAdd = this.delegateAdd;
    if (delegateAdd != null)
      delegateAdd(80 /*0x50*/);
    this.Hide();
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    try
    {
      for (int index = 0; index < Form1.ucSystemInfoOptions1.configArrayList.Count; ++index)
      {
        ArrayList configArray = (ArrayList) Form1.ucSystemInfoOptions1.configArrayList[index];
        UCSystemInfoOptionsOne systemInfoOptionsOne = (UCSystemInfoOptionsOne) Form1.ucSystemInfoOptions1.UCSystemInfoOptionsOneList[index];
        Color color;
        switch ((int) configArray[0])
        {
          case 0:
            color = UCSystemInfoOptionsOne.myColorZDY;
            break;
          case 1:
            color = UCSystemInfoOptionsOne.myColorCpu;
            break;
          case 2:
            color = UCSystemInfoOptionsOne.myColorGpu;
            break;
          case 3:
            color = UCSystemInfoOptionsOne.myColorMem;
            break;
          case 4:
            color = UCSystemInfoOptionsOne.myColorHdd;
            break;
          case 5:
            color = UCSystemInfoOptionsOne.myColorNet;
            break;
          case 6:
            color = UCSystemInfoOptionsOne.myColorFan;
            break;
          default:
            color = UCSystemInfoOptionsOne.myColorZDY;
            break;
        }
        this.myFontBrush.Color = color;
        this.myFormat.Alignment = StringAlignment.Near;
        int x1 = 12;
        int y1 = 67 + index * 5 * 20 + this.offsetY;
        Rectangle layoutRectangle = new Rectangle(x1, y1, 189, 20);
        graphics.DrawString((string) configArray[1], this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y2 = 67 + index * 5 * 20 + 20 + this.offsetY;
        layoutRectangle = new Rectangle(x1, y2, 92, 20);
        graphics.DrawString((string) configArray[2], this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y3 = 67 + index * 5 * 20 + 40 + this.offsetY;
        layoutRectangle = new Rectangle(x1, y3, 92, 20);
        graphics.DrawString((string) configArray[5], this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y4 = 67 + index * 5 * 20 + 60 + this.offsetY;
        layoutRectangle = new Rectangle(x1, y4, 92, 20);
        graphics.DrawString((string) configArray[8], this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y5 = 67 + index * 5 * 20 + 80 /*0x50*/ + this.offsetY;
        layoutRectangle = new Rectangle(x1, y5, 92, 20);
        graphics.DrawString((string) configArray[11], this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        this.myFormat.Alignment = StringAlignment.Far;
        int x2 = 104;
        int y6 = 67 + index * 5 * 20 + 20 + this.offsetY;
        layoutRectangle = new Rectangle(x2, y6, 92, 20);
        graphics.DrawString(systemInfoOptionsOne.label1.Text, this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y7 = 67 + index * 5 * 20 + 40 + this.offsetY;
        layoutRectangle = new Rectangle(x2, y7, 92, 20);
        graphics.DrawString(systemInfoOptionsOne.label2.Text, this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y8 = 67 + index * 5 * 20 + 60 + this.offsetY;
        layoutRectangle = new Rectangle(x2, y8, 92, 20);
        graphics.DrawString(systemInfoOptionsOne.label3.Text, this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y9 = 67 + index * 5 * 20 + 80 /*0x50*/ + this.offsetY;
        layoutRectangle = new Rectangle(x2, y9, 92, 20);
        graphics.DrawString(systemInfoOptionsOne.label4.Text, this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y10 = 90 + index * 5 * 20 + this.offsetY;
        if (this.myY > y10 && this.myY < y10 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
          graphics.DrawImage((Image) this.bitmapAdda, 199, y10, this.bitmapAdd.Width, this.bitmapAdd.Height);
        else
          graphics.DrawImage((Image) this.bitmapAdd, 199, y10, this.bitmapAdd.Width, this.bitmapAdd.Height);
        int y11 = 90 + index * 5 * 20 + 20 + this.offsetY;
        if (this.myY > y11 && this.myY < y11 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
          graphics.DrawImage((Image) this.bitmapAdda, 199, y11, this.bitmapAdd.Width, this.bitmapAdd.Height);
        else
          graphics.DrawImage((Image) this.bitmapAdd, 199, y11, this.bitmapAdd.Width, this.bitmapAdd.Height);
        int y12 = 90 + index * 5 * 20 + 40 + this.offsetY;
        if (this.myY > y12 && this.myY < y12 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
          graphics.DrawImage((Image) this.bitmapAdda, 199, y12, this.bitmapAdd.Width, this.bitmapAdd.Height);
        else
          graphics.DrawImage((Image) this.bitmapAdd, 199, y12, this.bitmapAdd.Width, this.bitmapAdd.Height);
        int y13 = 90 + index * 5 * 20 + 60 + this.offsetY;
        if (this.myY > y13 && this.myY < y13 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
          graphics.DrawImage((Image) this.bitmapAdda, 199, y13, this.bitmapAdd.Width, this.bitmapAdd.Height);
        else
          graphics.DrawImage((Image) this.bitmapAdd, 199, y13, this.bitmapAdd.Width, this.bitmapAdd.Height);
      }
      if (this.isFanLcd)
      {
        this.myFontBrush.Color = UCSystemInfoOptionsOne.myColorFan;
        this.myFormat.Alignment = StringAlignment.Near;
        int x = 12;
        int y14 = 67 + Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20 + this.offsetY;
        Rectangle layoutRectangle = new Rectangle(x, y14, 189, 20);
        graphics.DrawString("LC5", this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y15 = 67 + Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20 + 20 + this.offsetY;
        layoutRectangle = new Rectangle(x, y15, 92, 20);
        graphics.DrawString("FAN", this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        this.myFormat.Alignment = StringAlignment.Far;
        layoutRectangle = new Rectangle(104, 67 + Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20 + 20 + this.offsetY, 92, 20);
        graphics.DrawString(this.fanLcdVal.ToString() + "RPM", this.myFont, (Brush) this.myFontBrush, (RectangleF) layoutRectangle, this.myFormat);
        int y16 = 90 + Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20 + this.offsetY;
        if (this.myY > y16 && this.myY < y16 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
          graphics.DrawImage((Image) this.bitmapAdda, 199, y16, this.bitmapAdd.Width, this.bitmapAdd.Height);
        else
          graphics.DrawImage((Image) this.bitmapAdd, 199, y16, this.bitmapAdd.Width, this.bitmapAdd.Height);
      }
    }
    catch
    {
    }
    graphics.DrawImage(this.imageGdt, 215, this.imageY - this.imageGdt.Height / 2);
    graphics.DrawImage(this.imageBk, 0, 0);
  }

  private void FrmMain_MouseWheel(object sender, MouseEventArgs e)
  {
    int num1 = Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20;
    if (this.isFanLcd)
      num1 += 40;
    float num2 = (float) (-e.Delta * 200 / num1);
    if ((double) Math.Abs(num2) < 1.0)
      num2 = (double) num2 <= 0.0 ? -1f : 1f;
    this.imageY += (int) num2;
    if (this.imageY < 64 /*0x40*/ + this.imageGdt.Height / 2)
      this.imageY = 64 /*0x40*/ + this.imageGdt.Height / 2;
    if (this.imageY > this.Height - 6 - this.imageGdt.Height / 2)
      this.imageY = this.Height - 6 - this.imageGdt.Height / 2;
    this.offsetY = -(this.imageY - this.imageGdt.Height / 2 - 64 /*0x40*/) * (num1 - this.Height + 64 /*0x40*/ + 6) / (this.Height - this.imageGdt.Height - 6 - 64 /*0x40*/);
    this.Invalidate();
  }

  private void UCXiTongXianShiAdd_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.X > 199 && e.X < 215)
    {
      this.isMouseDownButton = true;
      this.myX = e.X;
      this.myY = e.Y;
      this.nowCoutMain = this.nowCoutSub = -1;
      for (int index = 0; index < Form1.ucSystemInfoOptions1.configArrayList.Count; ++index)
      {
        int num1 = 90 + index * 5 * 20 + this.offsetY;
        if (this.myY > num1 && this.myY < num1 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          this.nowCoutMain = index;
          this.nowCoutSub = 1;
          break;
        }
        int num2 = 90 + index * 5 * 20 + 20 + this.offsetY;
        if (this.myY > num2 && this.myY < num2 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          this.nowCoutMain = index;
          this.nowCoutSub = 2;
          break;
        }
        int num3 = 90 + index * 5 * 20 + 40 + this.offsetY;
        if (this.myY > num3 && this.myY < num3 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          this.nowCoutMain = index;
          this.nowCoutSub = 3;
          break;
        }
        int num4 = 90 + index * 5 * 20 + 60 + this.offsetY;
        if (this.myY > num4 && this.myY < num4 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          this.nowCoutMain = index;
          this.nowCoutSub = 4;
          break;
        }
      }
      if (this.isFanLcd)
      {
        int num = 90 + Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20 + this.offsetY;
        if (this.myY > num && this.myY < num + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          this.nowCoutMain = 10000;
          this.nowCoutSub = 1;
        }
      }
      this.Invalidate(new Rectangle(199, 67, 16 /*0x10*/, this.Height - 67));
    }
    else
    {
      if (e.X <= 215)
        return;
      this.isMouseDown = true;
      this.imageY = e.Y;
      if (this.imageY < 64 /*0x40*/ + this.imageGdt.Height / 2)
        this.imageY = 64 /*0x40*/ + this.imageGdt.Height / 2;
      if (this.imageY > this.Height - 6 - this.imageGdt.Height / 2)
        this.imageY = this.Height - 6 - this.imageGdt.Height / 2;
      int num = Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20;
      if (this.isFanLcd)
        num += 40;
      this.offsetY = -(this.imageY - this.imageGdt.Height / 2 - 64 /*0x40*/) * (num - this.Height + 64 /*0x40*/ + 6) / (this.Height - this.imageGdt.Height - 6 - 64 /*0x40*/);
      this.Invalidate();
    }
  }

  private void UCXiTongXianShiAdd_MouseMove(object sender, MouseEventArgs e)
  {
    if (this.isMouseDown)
    {
      this.imageY = e.Y;
      if (this.imageY < 64 /*0x40*/ + this.imageGdt.Height / 2)
        this.imageY = 64 /*0x40*/ + this.imageGdt.Height / 2;
      if (this.imageY > this.Height - 6 - this.imageGdt.Height / 2)
        this.imageY = this.Height - 6 - this.imageGdt.Height / 2;
      int num = Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20;
      if (this.isFanLcd)
        num += 40;
      this.offsetY = -(this.imageY - this.imageGdt.Height / 2 - 64 /*0x40*/) * (num - this.Height + 64 /*0x40*/ + 6) / (this.Height - this.imageGdt.Height - 6 - 64 /*0x40*/);
      this.Invalidate();
    }
    else
    {
      if (this.isMouseDownButton)
        return;
      this.myX = e.X;
      this.myY = e.Y;
      this.Invalidate(new Rectangle(199, 67, 16 /*0x10*/, this.Height - 67));
    }
  }

  private void UCXiTongXianShiAdd_MouseUp(object sender, MouseEventArgs e)
  {
    if (this.isMouseDownButton)
    {
      this.myX = e.X;
      this.myY = e.Y;
      int num1 = -1;
      int num2 = -1;
      for (int index = 0; index < Form1.ucSystemInfoOptions1.configArrayList.Count; ++index)
      {
        int num3 = 90 + index * 5 * 20 + this.offsetY;
        if (this.myY > num3 && this.myY < num3 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          num1 = index;
          num2 = 1;
          break;
        }
        int num4 = 90 + index * 5 * 20 + 20 + this.offsetY;
        if (this.myY > num4 && this.myY < num4 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          num1 = index;
          num2 = 2;
          break;
        }
        int num5 = 90 + index * 5 * 20 + 40 + this.offsetY;
        if (this.myY > num5 && this.myY < num5 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          num1 = index;
          num2 = 3;
          break;
        }
        int num6 = 90 + index * 5 * 20 + 60 + this.offsetY;
        if (this.myY > num6 && this.myY < num6 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          num1 = index;
          num2 = 4;
          break;
        }
      }
      if (this.isFanLcd)
      {
        int num7 = 90 + Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20 + this.offsetY;
        if (this.myY > num7 && this.myY < num7 + this.bitmapAdd.Height && this.myX > 199 && this.myX < 199 + this.bitmapAdd.Width)
        {
          num1 = 10000;
          num2 = 1;
        }
      }
      if (num1 == this.nowCoutMain && num2 == this.nowCoutSub && this.nowCoutMain >= 0)
      {
        UCXiTongXianShiAdd.delegateXiTongXianShiAdd delegateAdd = this.delegateAdd;
        if (delegateAdd != null)
          delegateAdd(16 /*0x10*/, (object) this.nowCoutMain, (object) this.nowCoutSub);
        this.Hide();
      }
    }
    if (this.isMouseDown)
    {
      this.imageY = e.Y;
      if (this.imageY < 64 /*0x40*/ + this.imageGdt.Height / 2)
        this.imageY = 64 /*0x40*/ + this.imageGdt.Height / 2;
      if (this.imageY > this.Height - 6 - this.imageGdt.Height / 2)
        this.imageY = this.Height - 6 - this.imageGdt.Height / 2;
      int num = Form1.ucSystemInfoOptions1.configArrayList.Count * 5 * 20;
      if (this.isFanLcd)
        num += 40;
      this.offsetY = -(this.imageY - this.imageGdt.Height / 2 - 64 /*0x40*/) * (num - this.Height + 64 /*0x40*/ + 6) / (this.Height - this.imageGdt.Height - 6 - 64 /*0x40*/);
    }
    this.Invalidate();
    this.isMouseDown = false;
    this.isMouseDownButton = false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonTimer = new Button();
    this.buttonWeek = new Button();
    this.buttonDate = new Button();
    this.buttonText = new Button();
    this.SuspendLayout();
    this.buttonTimer.BackColor = Color.Transparent;
    this.buttonTimer.BackgroundImage = (Image) Resources.P增加时间;
    this.buttonTimer.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonTimer.FlatAppearance.BorderSize = 0;
    this.buttonTimer.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonTimer.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonTimer.FlatStyle = FlatStyle.Flat;
    this.buttonTimer.Location = new Point(14, 31 /*0x1F*/);
    this.buttonTimer.Margin = new Padding(0);
    this.buttonTimer.Name = "buttonTimer";
    this.buttonTimer.Size = new Size(46, 24);
    this.buttonTimer.TabIndex = 139;
    this.buttonTimer.UseVisualStyleBackColor = false;
    this.buttonTimer.Click += new EventHandler(this.buttonTimer_Click);
    this.buttonWeek.BackColor = Color.Transparent;
    this.buttonWeek.BackgroundImage = (Image) Resources.P增加星期;
    this.buttonWeek.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWeek.FlatAppearance.BorderSize = 0;
    this.buttonWeek.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWeek.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWeek.FlatStyle = FlatStyle.Flat;
    this.buttonWeek.Location = new Point(66, 31 /*0x1F*/);
    this.buttonWeek.Margin = new Padding(0);
    this.buttonWeek.Name = "buttonWeek";
    this.buttonWeek.Size = new Size(46, 24);
    this.buttonWeek.TabIndex = 140;
    this.buttonWeek.UseVisualStyleBackColor = false;
    this.buttonWeek.Click += new EventHandler(this.buttonWeek_Click);
    this.buttonDate.BackColor = Color.Transparent;
    this.buttonDate.BackgroundImage = (Image) Resources.P增加日期;
    this.buttonDate.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDate.FlatAppearance.BorderSize = 0;
    this.buttonDate.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDate.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDate.FlatStyle = FlatStyle.Flat;
    this.buttonDate.Location = new Point(118, 31 /*0x1F*/);
    this.buttonDate.Margin = new Padding(0);
    this.buttonDate.Name = "buttonDate";
    this.buttonDate.Size = new Size(46, 24);
    this.buttonDate.TabIndex = 141;
    this.buttonDate.UseVisualStyleBackColor = false;
    this.buttonDate.Click += new EventHandler(this.buttonDate_Click);
    this.buttonText.BackColor = Color.Transparent;
    this.buttonText.BackgroundImage = (Image) Resources.P增加文本;
    this.buttonText.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonText.FlatAppearance.BorderSize = 0;
    this.buttonText.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonText.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonText.FlatStyle = FlatStyle.Flat;
    this.buttonText.Location = new Point(170, 31 /*0x1F*/);
    this.buttonText.Margin = new Padding(0);
    this.buttonText.Name = "buttonText";
    this.buttonText.Size = new Size(46, 24);
    this.buttonText.TabIndex = 142;
    this.buttonText.UseVisualStyleBackColor = false;
    this.buttonText.Click += new EventHandler(this.buttonText_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01增加内容;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.buttonText);
    this.Controls.Add((Control) this.buttonDate);
    this.Controls.Add((Control) this.buttonWeek);
    this.Controls.Add((Control) this.buttonTimer);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCXiTongXianShiAdd);
    this.Size = new Size(230, 430);
    this.MouseDown += new MouseEventHandler(this.UCXiTongXianShiAdd_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCXiTongXianShiAdd_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCXiTongXianShiAdd_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateXiTongXianShiAdd(int cmd, object info = null, object data = null, object data1 = null);
}

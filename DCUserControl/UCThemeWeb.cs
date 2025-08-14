// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCThemeWeb
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

public class UCThemeWeb : UserControl
{
  public UCThemeWeb.delegateThemeWeb delegateWeb;
  public Font fontName = new Font("微软雅黑", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
  public SolidBrush fontNameBrush = new SolidBrush(Color.FromArgb(198, 198, 198));
  private StringFormat m_format = new StringFormat();
  private const int myImageXS = 30;
  private const int myImageYS = 60;
  private const int myImageX = 135;
  private const int myImageY = 150;
  private const int myImageW = 120;
  private const int myImageH = 120;
  private const int myImageCountX = 5;
  private const int myGundongtiaoXS = 692;
  private const int myGundongtiaoYS = 51;
  private const int myGundongtiaoOffset = 3;
  private int myMode = 0;
  private ArrayList arrayThemeWeb;
  private bool isMouseDown = false;
  private int imageY;
  private bool isOffsetY = false;
  private int allImageY = 100;
  private int offsetY = 0;
  private Image imageGdt;
  public Image imageBk;
  private int myDirectionB = 0;
  private bool isDownLoad = true;
  private IContainer components = (IContainer) null;
  private Button buttonAll;
  private Button button1;
  private Button button2;
  private Button button3;
  private Button button4;
  private Button button5;
  private Button button6;

  public UCThemeWeb()
  {
    this.InitializeComponent();
    this.buttonAll.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.arrayThemeWeb = new ArrayList();
    this.m_format.LineAlignment = StringAlignment.Center;
    this.m_format.Alignment = StringAlignment.Center;
    this.imageGdt = (Image) Resources.P滚动条按钮;
    this.imageBk = (Image) Resources.p0云端背景;
    this.MouseWheel += new MouseEventHandler(this.FrmMain_MouseWheel);
  }

  public void UCThemeWebRemove()
  {
    for (int index = 0; index < this.arrayThemeWeb.Count; ++index)
      ((Image) ((ArrayList) this.arrayThemeWeb[index])[0]).Dispose();
    this.arrayThemeWeb.Clear();
  }

  public void CheakDirectionB(int direction)
  {
    if (this.myDirectionB == direction)
      return;
    this.myDirectionB = direction;
    this.Display_Button();
  }

  private void FrmMain_MouseWheel(object sender, MouseEventArgs e)
  {
    if (!this.isOffsetY)
      return;
    float num = (float) (-e.Delta * 200 / this.allImageY);
    if ((double) Math.Abs(num) < 1.0)
      num = (double) num <= 0.0 ? -1f : 1f;
    this.imageY += (int) num;
    if (this.imageY < 51 + this.imageGdt.Height / 2)
      this.imageY = 51 + this.imageGdt.Height / 2;
    if (this.imageY > this.Height - this.imageGdt.Height / 2 - 3)
      this.imageY = this.Height - this.imageGdt.Height / 2 - 3;
    if (this.allImageY > this.Height - 51 - 3)
    {
      this.offsetY = -(this.imageY - this.imageGdt.Height / 2 - 51) * (this.allImageY - this.Height) / (this.Height - this.imageGdt.Height - 51 - 3);
      this.Invalidate();
    }
  }

  public void Button_Set(int mode)
  {
    this.myMode = mode;
    this.buttonAll.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button1.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button2.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button3.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button4.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button5.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button6.BackgroundImage = (Image) Resources.P主题分类选择;
    switch (mode)
    {
      case 0:
        this.buttonAll.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
      case 1:
        this.button1.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
      case 2:
        this.button2.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
      case 3:
        this.button3.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
      case 4:
        this.button4.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
      case 5:
        this.button5.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
      case 6:
        this.button6.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
    }
  }

  public void Display_Button()
  {
    UCThemeWeb.delegateThemeWeb delegateWeb = this.delegateWeb;
    if (delegateWeb != null)
      delegateWeb(this.myMode);
    this.isDownLoad = false;
  }

  private void buttonAll_Click(object sender, EventArgs e)
  {
    if (this.isDownLoad)
      return;
    this.isDownLoad = true;
    this.myMode = 0;
    this.Button_Set(this.myMode);
    this.Display_Button();
  }

  private void button1_Click(object sender, EventArgs e)
  {
    if (this.isDownLoad)
      return;
    this.isDownLoad = true;
    this.myMode = 1;
    this.Button_Set(this.myMode);
    this.Display_Button();
  }

  private void button2_Click(object sender, EventArgs e)
  {
    if (this.isDownLoad)
      return;
    this.isDownLoad = true;
    this.myMode = 2;
    this.Button_Set(this.myMode);
    this.Display_Button();
  }

  private void button3_Click(object sender, EventArgs e)
  {
    if (this.isDownLoad)
      return;
    this.isDownLoad = true;
    this.myMode = 3;
    this.Button_Set(this.myMode);
    this.Display_Button();
  }

  private void button4_Click(object sender, EventArgs e)
  {
    if (this.isDownLoad)
      return;
    this.isDownLoad = true;
    this.myMode = 4;
    this.Button_Set(this.myMode);
    this.Display_Button();
  }

  private void button5_Click(object sender, EventArgs e)
  {
    if (this.isDownLoad)
      return;
    this.isDownLoad = true;
    this.myMode = 5;
    this.Button_Set(this.myMode);
    this.Display_Button();
  }

  private void button6_Click(object sender, EventArgs e)
  {
    if (this.isDownLoad)
      return;
    this.isDownLoad = true;
    this.myMode = 6;
    this.Button_Set(this.myMode);
    this.Display_Button();
  }

  public void SetThemeWeb(ArrayList imageArray, ArrayList nameArray)
  {
    for (int index = 0; index < this.arrayThemeWeb.Count; ++index)
      ((Image) ((ArrayList) this.arrayThemeWeb[index])[0]).Dispose();
    this.arrayThemeWeb.Clear();
    for (int index = 0; index < imageArray.Count; ++index)
    {
      ArrayList arrayList = new ArrayList();
      int num1 = 30 + 135 * (index % 5);
      int num2 = 60 + 150 * (index / 5);
      int num3;
      int num4;
      if (((Image) imageArray[index]).Width > ((Image) imageArray[index]).Height)
      {
        num3 = 120;
        num4 = 120 * ((Image) imageArray[index]).Height / ((Image) imageArray[index]).Width;
      }
      else
      {
        num4 = 120;
        num3 = 120 * ((Image) imageArray[index]).Width / ((Image) imageArray[index]).Height;
      }
      arrayList.Add(imageArray[index]);
      arrayList.Add((object) num1);
      arrayList.Add((object) num2);
      arrayList.Add((object) num3);
      arrayList.Add((object) num4);
      arrayList.Add(nameArray[index]);
      this.arrayThemeWeb.Add((object) arrayList);
    }
    try
    {
      this.allImageY = (int) ((ArrayList) this.arrayThemeWeb[this.arrayThemeWeb.Count - 1])[2] + 150;
      if (this.allImageY > this.Height - 51 - 3)
      {
        this.isOffsetY = true;
        this.offsetY = 0;
      }
      else
      {
        this.isOffsetY = false;
        this.offsetY = 0;
      }
    }
    catch
    {
      this.allImageY = 100;
      this.isOffsetY = false;
      this.offsetY = 0;
    }
    this.imageY = 51 + this.imageGdt.Height / 2;
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    for (int index = 0; index < this.arrayThemeWeb.Count; ++index)
    {
      ArrayList arrayList = (ArrayList) this.arrayThemeWeb[index];
      Bitmap bitmap = (Bitmap) arrayList[0];
      int x = (int) arrayList[1];
      int num = (int) arrayList[2];
      int width = (int) arrayList[3];
      int height = (int) arrayList[4];
      graphics.DrawImage((Image) bitmap, x + (120 - width) / 2, num + (120 - height) / 2 + this.offsetY, width, height);
      Rectangle layoutRectangle = new Rectangle(x, num + 120 + this.offsetY, 120, 20);
      graphics.DrawString((string) arrayList[5], this.fontName, (Brush) this.fontNameBrush, (RectangleF) layoutRectangle, this.m_format);
    }
    graphics.DrawImage(this.imageBk, 0, 0);
    if (!this.isOffsetY)
      return;
    graphics.DrawImage(this.imageGdt, 702, this.imageY - this.imageGdt.Height / 2);
  }

  private void UCThemeWeb_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.X > 692)
    {
      this.isMouseDown = true;
      this.imageY = e.Y;
      if (this.imageY < 51 + this.imageGdt.Height / 2)
        this.imageY = 51 + this.imageGdt.Height / 2;
      if (this.imageY > this.Height - this.imageGdt.Height / 2 - 3)
        this.imageY = this.Height - this.imageGdt.Height / 2 - 3;
      if (this.allImageY > this.Height - 51 - 3)
      {
        this.offsetY = -(this.imageY - this.imageGdt.Height / 2 - 51) * (this.allImageY - this.Height) / (this.Height - this.imageGdt.Height - 51 - 3);
        this.Invalidate();
      }
      else
        this.isMouseDown = false;
    }
    else
    {
      if (this.isDownLoad)
        return;
      this.isDownLoad = true;
      for (int index = 0; index < this.arrayThemeWeb.Count; ++index)
      {
        ArrayList arrayList = (ArrayList) this.arrayThemeWeb[index];
        int num1 = (int) arrayList[1];
        int num2 = (int) arrayList[2];
        int num3 = 120 + num1;
        int num4 = 120 + num2;
        string info = (string) arrayList[5];
        if (e.X >= num1 && e.X <= num3 && e.Y >= num2 + this.offsetY && e.Y <= num4 + this.offsetY)
        {
          UCThemeWeb.delegateThemeWeb delegateWeb = this.delegateWeb;
          if (delegateWeb != null)
          {
            delegateWeb(16 /*0x10*/, (object) info);
            break;
          }
          break;
        }
      }
      this.isDownLoad = false;
    }
  }

  private void UCThemeWeb_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    this.imageY = e.Y;
    if (this.imageY < 51 + this.imageGdt.Height / 2)
      this.imageY = 51 + this.imageGdt.Height / 2;
    if (this.imageY > this.Height - this.imageGdt.Height / 2 - 3)
      this.imageY = this.Height - this.imageGdt.Height / 2 - 3;
    if (this.allImageY > this.Height - 51 - 3)
    {
      this.offsetY = -(this.imageY - this.imageGdt.Height / 2 - 51) * (this.allImageY - this.Height) / (this.Height - this.imageGdt.Height - 51 - 3);
      this.Invalidate();
    }
    else
      this.isMouseDown = false;
  }

  private void UCThemeWeb_MouseUp(object sender, MouseEventArgs e) => this.isMouseDown = false;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonAll = new Button();
    this.button1 = new Button();
    this.button2 = new Button();
    this.button3 = new Button();
    this.button4 = new Button();
    this.button5 = new Button();
    this.button6 = new Button();
    this.SuspendLayout();
    this.buttonAll.BackColor = Color.Transparent;
    this.buttonAll.BackgroundImage = (Image) Resources.P主题分类选择0;
    this.buttonAll.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonAll.FlatAppearance.BorderSize = 0;
    this.buttonAll.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonAll.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonAll.FlatStyle = FlatStyle.Flat;
    this.buttonAll.Location = new Point(21, 29);
    this.buttonAll.Margin = new Padding(0);
    this.buttonAll.Name = "buttonAll";
    this.buttonAll.Size = new Size(63 /*0x3F*/, 18);
    this.buttonAll.TabIndex = 645;
    this.buttonAll.UseVisualStyleBackColor = false;
    this.buttonAll.Click += new EventHandler(this.buttonAll_Click);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(120, 29);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(63 /*0x3F*/, 18);
    this.button1.TabIndex = 646;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button2.BackColor = Color.Transparent;
    this.button2.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button2.BackgroundImageLayout = ImageLayout.Stretch;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Location = new Point(221, 29);
    this.button2.Margin = new Padding(0);
    this.button2.Name = "button2";
    this.button2.Size = new Size(63 /*0x3F*/, 18);
    this.button2.TabIndex = 647;
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button3.BackColor = Color.Transparent;
    this.button3.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button3.BackgroundImageLayout = ImageLayout.Stretch;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Location = new Point(322, 29);
    this.button3.Margin = new Padding(0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(63 /*0x3F*/, 18);
    this.button3.TabIndex = 648;
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button4.BackColor = Color.Transparent;
    this.button4.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button4.BackgroundImageLayout = ImageLayout.Stretch;
    this.button4.FlatAppearance.BorderSize = 0;
    this.button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button4.FlatStyle = FlatStyle.Flat;
    this.button4.Location = new Point(421, 29);
    this.button4.Margin = new Padding(0);
    this.button4.Name = "button4";
    this.button4.Size = new Size(63 /*0x3F*/, 18);
    this.button4.TabIndex = 649;
    this.button4.UseVisualStyleBackColor = false;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.button5.BackColor = Color.Transparent;
    this.button5.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button5.BackgroundImageLayout = ImageLayout.Stretch;
    this.button5.FlatAppearance.BorderSize = 0;
    this.button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button5.FlatStyle = FlatStyle.Flat;
    this.button5.Location = new Point(520, 29);
    this.button5.Margin = new Padding(0);
    this.button5.Name = "button5";
    this.button5.Size = new Size(63 /*0x3F*/, 18);
    this.button5.TabIndex = 650;
    this.button5.UseVisualStyleBackColor = false;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.button6.BackColor = Color.Transparent;
    this.button6.BackgroundImage = (Image) Resources.P主题分类选择;
    this.button6.BackgroundImageLayout = ImageLayout.Stretch;
    this.button6.FlatAppearance.BorderSize = 0;
    this.button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button6.FlatStyle = FlatStyle.Flat;
    this.button6.Location = new Point(621, 29);
    this.button6.Margin = new Padding(0);
    this.button6.Name = "button6";
    this.button6.Size = new Size(63 /*0x3F*/, 18);
    this.button6.TabIndex = 651;
    this.button6.UseVisualStyleBackColor = false;
    this.button6.Click += new EventHandler(this.button6_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.p0云端背景;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.button6);
    this.Controls.Add((Control) this.button5);
    this.Controls.Add((Control) this.button4);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.buttonAll);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCThemeWeb);
    this.Size = new Size(732, 652);
    this.MouseDown += new MouseEventHandler(this.UCThemeWeb_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCThemeWeb_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCThemeWeb_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateThemeWeb(int cmd, object info = null, object data = null, object data1 = null);
}

// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCThemeMask
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

public class UCThemeMask : UserControl
{
  public UCThemeMask.delegateThemeMask delegateMask;
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
  private ArrayList arrayThemeMask;
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

  public UCThemeMask()
  {
    this.InitializeComponent();
    this.arrayThemeMask = new ArrayList();
    this.m_format.LineAlignment = StringAlignment.Center;
    this.m_format.Alignment = StringAlignment.Center;
    this.imageGdt = (Image) Resources.P滚动条按钮;
    this.imageBk = (Image) Resources.p0云端主题;
    this.MouseWheel += new MouseEventHandler(this.FrmMain_MouseWheel);
  }

  public void UCThemeMaskRemove()
  {
    for (int index = 0; index < this.arrayThemeMask.Count; ++index)
      ((Image) ((ArrayList) this.arrayThemeMask[index])[0]).Dispose();
    this.arrayThemeMask.Clear();
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

  public void Display_Button()
  {
    UCThemeMask.delegateThemeMask delegateMask = this.delegateMask;
    if (delegateMask != null)
      delegateMask(this.myMode);
    this.isDownLoad = false;
  }

  public void SetThemeMask(ArrayList imageArray, ArrayList nameArray)
  {
    for (int index = 0; index < this.arrayThemeMask.Count; ++index)
      ((Image) ((ArrayList) this.arrayThemeMask[index])[0]).Dispose();
    this.arrayThemeMask.Clear();
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
      this.arrayThemeMask.Add((object) arrayList);
    }
    try
    {
      this.allImageY = (int) ((ArrayList) this.arrayThemeMask[this.arrayThemeMask.Count - 1])[2] + 150;
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
    for (int index = 0; index < this.arrayThemeMask.Count; ++index)
    {
      ArrayList arrayList = (ArrayList) this.arrayThemeMask[index];
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

  private void UCThemeMask_MouseDown(object sender, MouseEventArgs e)
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
      for (int index = 0; index < this.arrayThemeMask.Count; ++index)
      {
        ArrayList arrayList = (ArrayList) this.arrayThemeMask[index];
        int num1 = (int) arrayList[1];
        int num2 = (int) arrayList[2];
        int num3 = 120 + num1;
        int num4 = 120 + num2;
        if (e.X >= num1 && e.X <= num3 && e.Y >= num2 + this.offsetY && e.Y <= num4 + this.offsetY)
        {
          UCThemeMask.delegateThemeMask delegateMask = this.delegateMask;
          if (delegateMask != null)
          {
            delegateMask(16 /*0x10*/, arrayList[5]);
            break;
          }
          break;
        }
      }
      this.isDownLoad = false;
    }
  }

  private void UCThemeMask_MouseMove(object sender, MouseEventArgs e)
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

  private void UCThemeMask_MouseUp(object sender, MouseEventArgs e) => this.isMouseDown = false;

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
    this.BackgroundImage = (Image) Resources.p0云端主题;
    this.BackgroundImageLayout = ImageLayout.None;
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCThemeMask);
    this.Size = new Size(732, 652);
    this.MouseDown += new MouseEventHandler(this.UCThemeMask_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCThemeMask_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCThemeMask_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateThemeMask(int cmd, object info = null, object data = null, object data1 = null);
}

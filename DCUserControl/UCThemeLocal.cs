// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCThemeLocal
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCThemeLocal : UserControl
{
  public UCThemeLocal.delegateThemeLocal delegateLocal;
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
  public const int MyThemeCount = 5;
  private ArrayList arrayThemeLocal;
  private bool isMouseDown = false;
  private int imageY;
  private bool isOffsetY = false;
  private int allImageY = 100;
  private int offsetY = 0;
  private Image imageGdt;
  public Image imageBk;
  private const int LunBoArrayCount = 6;
  public int myLunBoTimer = 3;
  public bool isLunbo = false;
  public int lunBoCount = 0;
  public int[] lunBoArray = new int[6]
  {
    -1,
    -1,
    -1,
    -1,
    -1,
    -1
  };
  private IContainer components = (IContainer) null;
  private Button buttonAll;
  private Button buttonDefault;
  private Button buttonUser;
  private Button buttonLunbo;
  public TextBox textBoxTimer;
  private Button buttonThemeOut;

  public UCThemeLocal()
  {
    this.InitializeComponent();
    this.buttonAll.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonDefault.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonUser.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonLunbo.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonThemeOut.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.arrayThemeLocal = new ArrayList();
    this.m_format.LineAlignment = StringAlignment.Center;
    this.m_format.Alignment = StringAlignment.Center;
    this.imageGdt = (Image) Resources.P滚动条按钮;
    this.imageBk = (Image) Resources.P0本地主题;
    this.MouseWheel += new MouseEventHandler(this.FrmMain_MouseWheel);
  }

  public void UCThemeLocalRemove()
  {
    for (int index = 0; index < this.arrayThemeLocal.Count; ++index)
      ((Image) ((ArrayList) this.arrayThemeLocal[index])[0]).Dispose();
    this.arrayThemeLocal.Clear();
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
    this.buttonDefault.BackgroundImage = (Image) Resources.P主题分类选择;
    this.buttonUser.BackgroundImage = (Image) Resources.P主题分类选择;
    switch (mode)
    {
      case 0:
        this.buttonAll.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
      case 1:
        this.buttonDefault.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
      case 2:
        this.buttonUser.BackgroundImage = (Image) Resources.P主题分类选择0;
        break;
    }
  }

  public void Reset_Button()
  {
    UCThemeLocal.delegateThemeLocal delegateLocal = this.delegateLocal;
    if (delegateLocal == null)
      return;
    delegateLocal(this.myMode);
  }

  private void buttonAll_Click(object sender, EventArgs e)
  {
    this.myMode = 0;
    this.Button_Set(this.myMode);
    UCThemeLocal.delegateThemeLocal delegateLocal = this.delegateLocal;
    if (delegateLocal == null)
      return;
    delegateLocal(this.myMode);
  }

  private void buttonDefault_Click(object sender, EventArgs e)
  {
    this.myMode = 1;
    this.Button_Set(this.myMode);
    UCThemeLocal.delegateThemeLocal delegateLocal = this.delegateLocal;
    if (delegateLocal == null)
      return;
    delegateLocal(this.myMode);
  }

  private void buttonUser_Click(object sender, EventArgs e)
  {
    this.myMode = 2;
    this.Button_Set(this.myMode);
    UCThemeLocal.delegateThemeLocal delegateLocal = this.delegateLocal;
    if (delegateLocal == null)
      return;
    delegateLocal(this.myMode);
  }

  public Bitmap ByteToBitmap(byte[] buffer)
  {
    MemoryStream memoryStream = new MemoryStream(buffer);
    memoryStream.Position = 0L;
    Image bitmap = Image.FromStream((Stream) memoryStream);
    memoryStream.Close();
    memoryStream.Dispose();
    return (Bitmap) bitmap;
  }

  public byte[] BitmapToByte(Bitmap Bit)
  {
    MemoryStream memoryStream = new MemoryStream();
    Bit.Save((Stream) memoryStream, ImageFormat.Png);
    memoryStream.Position = 0L;
    byte[] buffer = memoryStream.GetBuffer();
    memoryStream.Close();
    memoryStream.Dispose();
    return buffer;
  }

  public void SetThemeLocal(
    ArrayList array,
    string GifDirectory,
    string fileName,
    byte USB_PACKED_Head)
  {
    for (int index = 0; index < this.arrayThemeLocal.Count; ++index)
      ((Image) ((ArrayList) this.arrayThemeLocal[index])[0]).Dispose();
    this.arrayThemeLocal.Clear();
    for (int index1 = 0; index1 < array.Count; ++index1)
    {
      ArrayList arrayList = new ArrayList();
      Bitmap bitmap1 = (Bitmap) null;
      if (File.Exists($"{GifDirectory}{(string) array[index1]}\\Theme.png"))
      {
        Bitmap Bit = new Bitmap($"{GifDirectory}{(string) array[index1]}\\Theme.png");
        byte[] buffer = this.BitmapToByte(Bit);
        Bit.Dispose();
        bitmap1 = this.ByteToBitmap(buffer);
      }
      else if (File.Exists($"{GifDirectory}{(string) array[index1]}\\00.png"))
      {
        Bitmap Bit = new Bitmap($"{GifDirectory}{(string) array[index1]}\\00.png");
        byte[] buffer = this.BitmapToByte(Bit);
        Bit.Dispose();
        bitmap1 = this.ByteToBitmap(buffer);
      }
      else
      {
        FileStream input = new FileStream($"{GifDirectory}{(string) array[index1]}\\{fileName}", FileMode.OpenOrCreate);
        BinaryReader binaryReader = new BinaryReader((Stream) input);
        try
        {
          if ((int) binaryReader.ReadByte() == (int) USB_PACKED_Head)
          {
            int num = binaryReader.ReadInt32();
            for (int index2 = 0; index2 < num; ++index2)
              binaryReader.ReadInt32();
            int count = binaryReader.ReadInt32();
            bitmap1 = this.ByteToBitmap(binaryReader.ReadBytes(count));
          }
        }
        catch
        {
          bitmap1 = (Bitmap) null;
        }
        binaryReader.Close();
        binaryReader.Dispose();
        input.Close();
        input.Dispose();
      }
      int num1 = 30 + 135 * (index1 % 5);
      int num2 = 60 + 150 * (index1 / 5);
      int width;
      int height;
      if (bitmap1.Width > bitmap1.Height)
      {
        width = 120;
        height = 120 * bitmap1.Height / bitmap1.Width;
      }
      else
      {
        height = 120;
        width = 120 * bitmap1.Width / bitmap1.Height;
      }
      Bitmap bitmap2 = new Bitmap(width, height);
      Graphics graphics = Graphics.FromImage((Image) bitmap2);
      graphics.DrawImage((Image) bitmap1, 0, 0, width, height);
      graphics.Dispose();
      bitmap1.Dispose();
      arrayList.Add((object) bitmap2);
      arrayList.Add((object) num1);
      arrayList.Add((object) num2);
      arrayList.Add((object) width);
      arrayList.Add((object) height);
      arrayList.Add(array[index1]);
      this.arrayThemeLocal.Add((object) arrayList);
    }
    try
    {
      this.allImageY = (int) ((ArrayList) this.arrayThemeLocal[this.arrayThemeLocal.Count - 1])[2] + 150;
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
    for (int index = 0; index < this.arrayThemeLocal.Count; ++index)
    {
      ArrayList arrayList = (ArrayList) this.arrayThemeLocal[index];
      Bitmap bitmap = (Bitmap) arrayList[0];
      int x = (int) arrayList[1];
      int num = (int) arrayList[2];
      int width = (int) arrayList[3];
      int height = (int) arrayList[4];
      graphics.DrawImage((Image) bitmap, x + (120 - width) / 2, num + (120 - height) / 2 + this.offsetY, width, height);
      Rectangle layoutRectangle = new Rectangle(x, num + 120 + this.offsetY, 120, 20);
      graphics.DrawString((string) arrayList[5], this.fontName, (Brush) this.fontNameBrush, (RectangleF) layoutRectangle, this.m_format);
    }
    if (this.isLunbo)
    {
      for (int index1 = 0; index1 < this.arrayThemeLocal.Count; ++index1)
      {
        ArrayList arrayList = (ArrayList) this.arrayThemeLocal[index1];
        int num1 = -1;
        for (int index2 = 0; index2 < this.lunBoCount; ++index2)
        {
          if (this.lunBoArray[index2] == index1)
          {
            num1 = index2;
            break;
          }
        }
        Bitmap bitmap;
        switch (num1)
        {
          case 0:
            bitmap = Resources.P轮播1;
            break;
          case 1:
            bitmap = Resources.P轮播2;
            break;
          case 2:
            bitmap = Resources.P轮播3;
            break;
          case 3:
            bitmap = Resources.P轮播4;
            break;
          case 4:
            bitmap = Resources.P轮播5;
            break;
          case 5:
            bitmap = Resources.P轮播6;
            break;
          default:
            bitmap = Resources.P轮播选框;
            break;
        }
        int num2 = (int) arrayList[1];
        int num3 = (int) arrayList[2];
        int num4 = num2 + (120 + (int) arrayList[3]) / 2;
        int num5 = num3 + (60 + (int) arrayList[4] / 2 - bitmap.Height);
        graphics.DrawImage((Image) bitmap, num4 - 2 - bitmap.Width, num5 - 2 + this.offsetY);
        bitmap.Dispose();
      }
    }
    else if (this.myMode < 2)
    {
      for (int index = 5; index < this.arrayThemeLocal.Count; ++index)
      {
        ArrayList arrayList = (ArrayList) this.arrayThemeLocal[index];
        Bitmap p关闭按钮2 = Resources.P关闭按钮2;
        int num6 = (int) arrayList[1];
        int num7 = (int) arrayList[2];
        int num8 = num6 + ((120 - (int) arrayList[3]) / 2 + (int) arrayList[3]);
        int num9 = num7 + (120 - (int) arrayList[4]) / 2;
        graphics.DrawImage((Image) p关闭按钮2, num8 - 2 - p关闭按钮2.Width, num9 + 2 + this.offsetY);
        p关闭按钮2.Dispose();
      }
    }
    else
    {
      for (int index = 0; index < this.arrayThemeLocal.Count; ++index)
      {
        ArrayList arrayList = (ArrayList) this.arrayThemeLocal[index];
        Bitmap p关闭按钮2 = Resources.P关闭按钮2;
        int num10 = (int) arrayList[1];
        int num11 = (int) arrayList[2];
        int num12 = num10 + (120 + (int) arrayList[3]) / 2;
        int num13 = num11 + (120 - (int) arrayList[4]) / 2;
        graphics.DrawImage((Image) p关闭按钮2, num12 - 2 - p关闭按钮2.Width, num13 + 2 + this.offsetY);
        p关闭按钮2.Dispose();
      }
    }
    graphics.DrawImage(this.imageBk, 0, 0);
    if (!this.isOffsetY)
      return;
    graphics.DrawImage(this.imageGdt, 702, this.imageY - this.imageGdt.Height / 2);
  }

  private void UCThemeLocal_MouseDown(object sender, MouseEventArgs e)
  {
    this.textBoxTimer_Leave((object) null, (EventArgs) null);
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
      for (int index1 = 0; index1 < this.arrayThemeLocal.Count; ++index1)
      {
        ArrayList arrayList = (ArrayList) this.arrayThemeLocal[index1];
        int num1 = (int) arrayList[1];
        int num2 = (int) arrayList[2];
        int num3 = 120 + num1;
        int num4 = 120 + num2;
        if (e.X >= num1 && e.X <= num3 && e.Y >= num2 + this.offsetY && e.Y <= num4 + this.offsetY)
        {
          int num5 = num1 + (120 + (int) arrayList[3]) / 2 - 20;
          int num6 = num2 + (120 - (int) arrayList[4]) / 2 + 20;
          int num7 = num2 + (120 + (int) arrayList[4]) / 2 - 20;
          if (!this.isLunbo && e.X > num5 && e.Y < num6 + this.offsetY)
          {
            if (this.myMode < 2)
            {
              if (index1 >= 5)
              {
                UCThemeLocal.delegateThemeLocal delegateLocal1 = this.delegateLocal;
                if (delegateLocal1 != null)
                  delegateLocal1(32 /*0x20*/, (object) index1, (object) (this.myMode < 2 ? 0 : 1));
                for (int index2 = 0; index2 < this.lunBoCount; ++index2)
                {
                  if (this.lunBoArray[index2] == index1)
                  {
                    this.lunBoCount = 0;
                    this.lunBoArray = new int[6]
                    {
                      -1,
                      -1,
                      -1,
                      -1,
                      -1,
                      -1
                    };
                    UCThemeLocal.delegateThemeLocal delegateLocal2 = this.delegateLocal;
                    if (delegateLocal2 != null)
                    {
                      delegateLocal2(48 /*0x30*/);
                      break;
                    }
                    break;
                  }
                }
                break;
              }
            }
            else
            {
              UCThemeLocal.delegateThemeLocal delegateLocal = this.delegateLocal;
              if (delegateLocal != null)
              {
                delegateLocal(32 /*0x20*/, (object) index1, (object) (this.myMode < 2 ? 0 : 1));
                break;
              }
              break;
            }
          }
          if (this.isLunbo && e.X > num5 && e.Y > num7)
          {
            int num8 = -1;
            for (int index3 = 0; index3 < this.lunBoCount; ++index3)
            {
              if (this.lunBoArray[index3] == index1)
              {
                num8 = index3;
                break;
              }
            }
            if (num8 == -1)
            {
              if (this.lunBoCount < 6)
                this.lunBoArray[this.lunBoCount++] = index1;
            }
            else
            {
              for (int index4 = num8; index4 < this.lunBoCount - 1; ++index4)
                this.lunBoArray[index4] = this.lunBoArray[index4 + 1];
              --this.lunBoCount;
            }
            UCThemeLocal.delegateThemeLocal delegateLocal = this.delegateLocal;
            if (delegateLocal != null)
              delegateLocal(48 /*0x30*/);
            this.Invalidate();
            break;
          }
          if (!this.isLunbo)
          {
            UCThemeLocal.delegateThemeLocal delegateLocal = this.delegateLocal;
            if (delegateLocal != null)
              delegateLocal(16 /*0x10*/, (object) index1, (object) (this.myMode < 2 ? 0 : 1));
          }
          this.Invalidate();
          break;
        }
      }
    }
  }

  private void UCThemeLocal_MouseMove(object sender, MouseEventArgs e)
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

  private void UCThemeLocal_MouseUp(object sender, MouseEventArgs e) => this.isMouseDown = false;

  private void textBoxTimer_TextChanged(object sender, EventArgs e)
  {
    if (this.textBoxTimer.Text.Length <= 0)
      return;
    try
    {
      this.myLunBoTimer = Convert.ToInt32(this.textBoxTimer.Text);
      if (this.myLunBoTimer >= 3)
      {
        UCThemeLocal.delegateThemeLocal delegateLocal = this.delegateLocal;
        if (delegateLocal != null)
          delegateLocal(48 /*0x30*/);
      }
      else
        this.myLunBoTimer = 3;
    }
    catch
    {
    }
  }

  private void textBoxTimer_KeyPress(object sender, KeyPressEventArgs e)
  {
    if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
      return;
    e.Handled = true;
  }

  public void textBoxTimer_Leave(object sender, EventArgs e)
  {
    if (this.myLunBoTimer > 3)
      return;
    this.textBoxTimer.Text = "3";
  }

  public void buttonLunbo_Set(bool bl)
  {
    this.isLunbo = bl;
    if (bl)
      this.buttonLunbo.BackgroundImage = (Image) Resources.P主题轮播a;
    else
      this.buttonLunbo.BackgroundImage = (Image) Resources.P主题轮播;
  }

  private void buttonLunbo_Click(object sender, EventArgs e)
  {
    this.isLunbo = !this.isLunbo;
    this.buttonLunbo_Set(this.isLunbo);
    this.Invalidate();
    UCThemeLocal.delegateThemeLocal delegateLocal = this.delegateLocal;
    if (delegateLocal == null)
      return;
    delegateLocal(48 /*0x30*/);
  }

  private void buttonThemeOut_Click(object sender, EventArgs e)
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonAll = new Button();
    this.buttonDefault = new Button();
    this.buttonUser = new Button();
    this.buttonLunbo = new Button();
    this.textBoxTimer = new TextBox();
    this.buttonThemeOut = new Button();
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
    this.buttonAll.TabIndex = 644;
    this.buttonAll.UseVisualStyleBackColor = false;
    this.buttonAll.Click += new EventHandler(this.buttonAll_Click);
    this.buttonDefault.BackColor = Color.Transparent;
    this.buttonDefault.BackgroundImage = (Image) Resources.P主题分类选择;
    this.buttonDefault.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDefault.FlatAppearance.BorderSize = 0;
    this.buttonDefault.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDefault.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDefault.FlatStyle = FlatStyle.Flat;
    this.buttonDefault.Location = new Point(121, 29);
    this.buttonDefault.Margin = new Padding(0);
    this.buttonDefault.Name = "buttonDefault";
    this.buttonDefault.Size = new Size(63 /*0x3F*/, 18);
    this.buttonDefault.TabIndex = 645;
    this.buttonDefault.UseVisualStyleBackColor = false;
    this.buttonDefault.Visible = false;
    this.buttonDefault.Click += new EventHandler(this.buttonDefault_Click);
    this.buttonUser.BackColor = Color.Transparent;
    this.buttonUser.BackgroundImage = (Image) Resources.P主题分类选择;
    this.buttonUser.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonUser.FlatAppearance.BorderSize = 0;
    this.buttonUser.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonUser.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonUser.FlatStyle = FlatStyle.Flat;
    this.buttonUser.Location = new Point(221, 29);
    this.buttonUser.Margin = new Padding(0);
    this.buttonUser.Name = "buttonUser";
    this.buttonUser.Size = new Size(63 /*0x3F*/, 18);
    this.buttonUser.TabIndex = 646;
    this.buttonUser.UseVisualStyleBackColor = false;
    this.buttonUser.Visible = false;
    this.buttonUser.Click += new EventHandler(this.buttonUser_Click);
    this.buttonLunbo.BackColor = Color.Transparent;
    this.buttonLunbo.BackgroundImage = (Image) Resources.P主题轮播;
    this.buttonLunbo.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonLunbo.FlatAppearance.BorderSize = 0;
    this.buttonLunbo.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonLunbo.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonLunbo.FlatStyle = FlatStyle.Flat;
    this.buttonLunbo.Location = new Point(531, 28);
    this.buttonLunbo.Margin = new Padding(0);
    this.buttonLunbo.Name = "buttonLunbo";
    this.buttonLunbo.Size = new Size(40, 17);
    this.buttonLunbo.TabIndex = 648;
    this.buttonLunbo.UseVisualStyleBackColor = false;
    this.buttonLunbo.Click += new EventHandler(this.buttonLunbo_Click);
    this.textBoxTimer.BackColor = Color.FromArgb(35, 34, 39);
    this.textBoxTimer.BorderStyle = BorderStyle.None;
    this.textBoxTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxTimer.ForeColor = Color.White;
    this.textBoxTimer.ImeMode = ImeMode.NoControl;
    this.textBoxTimer.Location = new Point(602, 29);
    this.textBoxTimer.MaxLength = 3;
    this.textBoxTimer.Name = "textBoxTimer";
    this.textBoxTimer.Size = new Size(24, 16 /*0x10*/);
    this.textBoxTimer.TabIndex = 649;
    this.textBoxTimer.Text = "3";
    this.textBoxTimer.TextAlign = HorizontalAlignment.Center;
    this.textBoxTimer.TextChanged += new EventHandler(this.textBoxTimer_TextChanged);
    this.textBoxTimer.KeyPress += new KeyPressEventHandler(this.textBoxTimer_KeyPress);
    this.textBoxTimer.Leave += new EventHandler(this.textBoxTimer_Leave);
    this.buttonThemeOut.BackColor = Color.Transparent;
    this.buttonThemeOut.BackgroundImage = (Image) Resources.P导出所有主题;
    this.buttonThemeOut.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonThemeOut.FlatAppearance.BorderSize = 0;
    this.buttonThemeOut.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonThemeOut.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonThemeOut.FlatStyle = FlatStyle.Flat;
    this.buttonThemeOut.Location = new Point(651, 27);
    this.buttonThemeOut.Margin = new Padding(0);
    this.buttonThemeOut.Name = "buttonThemeOut";
    this.buttonThemeOut.Size = new Size(60, 18);
    this.buttonThemeOut.TabIndex = 650;
    this.buttonThemeOut.UseVisualStyleBackColor = false;
    this.buttonThemeOut.Visible = false;
    this.buttonThemeOut.Click += new EventHandler(this.buttonThemeOut_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P0本地主题;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.buttonThemeOut);
    this.Controls.Add((Control) this.textBoxTimer);
    this.Controls.Add((Control) this.buttonLunbo);
    this.Controls.Add((Control) this.buttonUser);
    this.Controls.Add((Control) this.buttonDefault);
    this.Controls.Add((Control) this.buttonAll);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCThemeLocal);
    this.Size = new Size(732, 652);
    this.MouseDown += new MouseEventHandler(this.UCThemeLocal_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCThemeLocal_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCThemeLocal_MouseUp);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void delegateThemeLocal(int cmd, object info = null, object data = null, object data1 = null);
}

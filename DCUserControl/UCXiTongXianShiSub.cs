// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCXiTongXianShiSub
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCXiTongXianShiSub : UserControl
{
  public UCXiTongXianShiSub.delegateXiTongXianShiSub delegateXiTongSub;
  public int myMode = 0;
  public int myModeSub = 0;
  public int myX = 100;
  public int myY = 100;
  public int myMainCount = 0;
  public int mySubCount = 1;
  public Color myColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
  public Font myFont = new Font("微软雅黑", 36f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
  public bool isSelect = false;
  private Image imageSelect;
  public string myText = "";
  private IContainer components = (IContainer) null;
  public Label label1;
  public Label label2;
  public Label label3;

  public UCXiTongXianShiSub()
  {
    this.InitializeComponent();
    this.imageSelect = (Image) Resources.P选中;
  }

  public void InitUCXiTongXianShiSub()
  {
    switch (this.myMode)
    {
      case 0:
        this.BackgroundImage = (Image) Resources.P数据;
        switch (this.myMainCount)
        {
          case 0:
            this.label1.ForeColor = UCSystemInfoOptionsOne.myColorCpu;
            break;
          case 1:
            this.label1.ForeColor = UCSystemInfoOptionsOne.myColorGpu;
            break;
          case 2:
            this.label1.ForeColor = UCSystemInfoOptionsOne.myColorMem;
            break;
          case 3:
            this.label1.ForeColor = UCSystemInfoOptionsOne.myColorHdd;
            break;
          case 4:
            this.label1.ForeColor = UCSystemInfoOptionsOne.myColorNet;
            break;
          case 5:
            this.label1.ForeColor = UCSystemInfoOptionsOne.myColorFan;
            break;
          case 10000:
            this.label1.ForeColor = UCSystemInfoOptionsOne.myColorFan;
            break;
          default:
            this.label1.ForeColor = UCSystemInfoOptionsOne.myColorZDY;
            break;
        }
        this.label2.ForeColor = this.myColor;
        this.label3.ForeColor = this.myColor;
        break;
      case 1:
        this.BackgroundImage = (Image) Resources.P时间;
        this.label1.Hide();
        this.label3.Hide();
        this.label2.ForeColor = this.myColor;
        break;
      case 2:
        this.BackgroundImage = (Image) Resources.P星期;
        this.label1.Hide();
        this.label3.Hide();
        this.label2.ForeColor = this.myColor;
        break;
      case 3:
        this.BackgroundImage = (Image) Resources.P日期;
        this.label1.Hide();
        this.label3.Hide();
        this.label2.ForeColor = this.myColor;
        break;
      case 4:
        this.BackgroundImage = (Image) Resources.P文本;
        this.label1.Hide();
        this.label3.Hide();
        this.label2.ForeColor = this.myColor;
        this.label2.Text = this.myText;
        break;
    }
  }

  public void XYSet(int x, int y)
  {
    this.myX = x;
    this.myY = y;
  }

  public void ScreenXYSet(int x, int y)
  {
    this.myX = x;
    this.myY = y;
    UCXiTongXianShiSub.delegateXiTongXianShiSub delegateXiTongSub = this.delegateXiTongSub;
    if (delegateXiTongSub == null)
      return;
    delegateXiTongSub(3, (object) this, (object) x, (object) y);
  }

  public void ColorSet(Color color)
  {
    this.myColor = color;
    this.label2.ForeColor = this.myColor;
    this.label3.ForeColor = this.myColor;
  }

  public void TextSet(string str)
  {
    this.myText = str;
    if (this.myMode != 4)
      return;
    this.label2.Text = this.myText;
  }

  public void FontSet(Font font)
  {
    Font font1 = this.myFont;
    this.myFont = font;
    if (font1 == null || font1 == SystemFonts.DefaultFont)
      return;
    font1.Dispose();
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (!this.isSelect)
      return;
    graphics.DrawImage(this.imageSelect, 0, 0);
  }

  private void UCXiTongXianShiSub_Click(object sender, EventArgs e)
  {
    UCXiTongXianShiSub.delegateXiTongXianShiSub delegateXiTongSub = this.delegateXiTongSub;
    if (delegateXiTongSub == null)
      return;
    delegateXiTongSub(1, (object) this);
  }

  private void UCXiTongXianShiSub_DoubleClick(object sender, EventArgs e)
  {
    UCXiTongXianShiSub.delegateXiTongXianShiSub delegateXiTongSub = this.delegateXiTongSub;
    if (delegateXiTongSub == null)
      return;
    delegateXiTongSub(2, (object) this);
  }

  private void label_Click(object sender, EventArgs e) => this.UCXiTongXianShiSub_Click(sender, e);

  private void label_DoubleClick(object sender, EventArgs e)
  {
    this.UCXiTongXianShiSub_DoubleClick(sender, e);
  }

  public void UCXiTongXianShiSubTimer(string val = "", string dw = "")
  {
    if (this.myMainCount == 10000)
    {
      this.label1.Text = "FAN";
      this.label2.Text = val;
      this.label3.Text = dw;
    }
    else
    {
      switch (this.myMode)
      {
        case 0:
          UCSystemInfoOptionsOne systemInfoOptionsOne = (UCSystemInfoOptionsOne) Form1.ucSystemInfoOptions1.UCSystemInfoOptionsOneList[this.myMainCount];
          switch (this.mySubCount)
          {
            case 1:
              this.label1.Text = systemInfoOptionsOne.textBox1.Text;
              this.label2.Text = Regex.Replace(systemInfoOptionsOne.label1.Text, "[^\\d]", "");
              this.label3.Text = systemInfoOptionsOne.label1.Text.Replace(this.label2.Text, "");
              return;
            case 2:
              this.label1.Text = systemInfoOptionsOne.textBox2.Text;
              this.label2.Text = Regex.Replace(systemInfoOptionsOne.label2.Text, "[^\\d]", "");
              this.label3.Text = systemInfoOptionsOne.label2.Text.Replace(this.label2.Text, "");
              return;
            case 3:
              this.label1.Text = systemInfoOptionsOne.textBox3.Text;
              this.label2.Text = Regex.Replace(systemInfoOptionsOne.label3.Text, "[^\\d]", "");
              this.label3.Text = systemInfoOptionsOne.label3.Text.Replace(this.label2.Text, "");
              return;
            case 4:
              this.label1.Text = systemInfoOptionsOne.textBox4.Text;
              this.label2.Text = Regex.Replace(systemInfoOptionsOne.label4.Text, "[^\\d]", "");
              this.label3.Text = systemInfoOptionsOne.label4.Text.Replace(this.label2.Text, "");
              return;
            default:
              return;
          }
        case 1:
          switch (this.myModeSub)
          {
            case 0:
              this.myText = DateTime.Now.ToString("HH:mm");
              break;
            case 1:
              this.myText = DateTime.Now.ToString("hh:mm tt", (IFormatProvider) CultureInfo.InvariantCulture);
              break;
            case 2:
              this.myText = DateTime.Now.ToString("HH:mm");
              break;
          }
          this.label2.Text = this.myText;
          break;
        case 2:
          string[] strArray;
          switch (Form1.Language)
          {
            case 1:
              strArray = new string[7]
              {
                "星期日",
                "星期一",
                "星期二",
                "星期三",
                "星期四",
                "星期五",
                "星期六"
              };
              break;
            case 2:
              strArray = new string[7]
              {
                "SUN",
                "MON",
                "TUE",
                "WED",
                "THU",
                "FRI",
                "SAT"
              };
              break;
            default:
              strArray = new string[7]
              {
                "SUN",
                "MON",
                "TUE",
                "WED",
                "THU",
                "FRI",
                "SAT"
              };
              break;
          }
          this.myText = strArray[Convert.ToInt32(DateTime.Now.DayOfWeek.ToString("d"))].ToString();
          this.label2.Text = this.myText;
          break;
        case 3:
          switch (this.myModeSub)
          {
            case 0:
            case 1:
              this.myText = DateTime.Now.ToString("yyyy/MM/dd");
              break;
            case 2:
              this.myText = DateTime.Now.ToString("dd/MM/yyyy");
              break;
            case 3:
              this.myText = DateTime.Now.ToString("MM/dd");
              break;
            case 4:
              this.myText = DateTime.Now.ToString("dd/MM");
              break;
          }
          this.label2.Text = this.myText;
          break;
        case 4:
          this.label2.Text = this.myText;
          break;
      }
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
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.SuspendLayout();
    this.label1.BackColor = Color.Transparent;
    this.label1.FlatStyle = FlatStyle.Flat;
    this.label1.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label1.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.label1.Location = new Point(2, 1);
    this.label1.Margin = new Padding(0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(56, 18);
    this.label1.TabIndex = 687;
    this.label1.TextAlign = ContentAlignment.MiddleCenter;
    this.label1.Click += new EventHandler(this.label_Click);
    this.label1.DoubleClick += new EventHandler(this.label_DoubleClick);
    this.label2.BackColor = Color.Transparent;
    this.label2.FlatStyle = FlatStyle.Flat;
    this.label2.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label2.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.label2.Location = new Point(2, 21);
    this.label2.Margin = new Padding(0);
    this.label2.Name = "label2";
    this.label2.Size = new Size(56, 18);
    this.label2.TabIndex = 688;
    this.label2.TextAlign = ContentAlignment.MiddleCenter;
    this.label2.Click += new EventHandler(this.label_Click);
    this.label2.DoubleClick += new EventHandler(this.label_DoubleClick);
    this.label3.BackColor = Color.Transparent;
    this.label3.FlatStyle = FlatStyle.Flat;
    this.label3.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label3.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.label3.Location = new Point(2, 41);
    this.label3.Margin = new Padding(0);
    this.label3.Name = "label3";
    this.label3.Size = new Size(56, 18);
    this.label3.TabIndex = 689;
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.label3.Click += new EventHandler(this.label_Click);
    this.label3.DoubleClick += new EventHandler(this.label_DoubleClick);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P数据;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCXiTongXianShiSub);
    this.Size = new Size(60, 60);
    this.Click += new EventHandler(this.UCXiTongXianShiSub_Click);
    this.DoubleClick += new EventHandler(this.UCXiTongXianShiSub_DoubleClick);
    this.ResumeLayout(false);
  }

  public delegate void delegateXiTongXianShiSub(int cmd, object info = null, object data = null, object data1 = null);
}

// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCComboBoxB
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

public class UCComboBoxB : UserControl
{
  private const int buttonH0 = 20;
  private int imageX = 0;
  private int imageY = 20;
  public Image pointImg = (Image) Resources.D下拉菜单;
  private readonly Color color1 = Color.White;
  private readonly Color color2 = Color.Silver;
  public int myMode = 2;
  public int myCount = 3;
  public string[] boxNameArray = new string[8]
  {
    "1",
    "2",
    "4",
    "8",
    "16",
    "32",
    "64",
    "128"
  };
  public UCComboBoxB.delegateUCComboBoxB ucComboBoxB;
  private IContainer components = (IContainer) null;
  public Button button0;
  private Button button1;
  private Button button2;
  private Button button3;
  private Button button4;
  private Button button5;
  private Button button6;
  private Button button7;
  private Button button8;

  public UCComboBoxB()
  {
    this.InitializeComponent();
    this.button0.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button7.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button8.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public void SetBoxNameArray(string[] array)
  {
    this.boxNameArray = array;
    this.button1.Text = array[0];
    this.button2.Text = array[1];
    this.button3.Text = array[2];
    this.button4.Text = array[3];
    this.button5.Text = array[4];
    this.button6.Text = array[5];
    this.button7.Text = array[6];
    this.button8.Text = array[7];
    this.SetUCComboBoxMode(this.myMode);
  }

  public void ReSetUCComboBoxMode() => this.SetUCComboBoxMode(this.myMode);

  public void SetUCComboBoxMode(int m)
  {
    switch (m)
    {
      case 1:
        this.myMode = 1;
        this.Height = 20;
        this.button0.Text = this.button1.Text;
        break;
      case 2:
        this.myMode = 2;
        this.Height = 20;
        this.button0.Text = this.button2.Text;
        break;
      case 3:
        this.myMode = 3;
        this.Height = 20;
        this.button0.Text = this.button3.Text;
        break;
      case 4:
        this.myMode = 4;
        this.Height = 20;
        this.button0.Text = this.button4.Text;
        break;
      case 5:
        this.myMode = 5;
        this.Height = 20;
        this.button0.Text = this.button5.Text;
        break;
      case 6:
        this.myMode = 6;
        this.Height = 20;
        this.button0.Text = this.button6.Text;
        break;
      case 7:
        this.myMode = 7;
        this.Height = 20;
        this.button0.Text = this.button7.Text;
        break;
      case 8:
        this.myMode = 8;
        this.Height = 20;
        this.button0.Text = this.button8.Text;
        break;
    }
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    pe.Graphics.DrawImage(this.pointImg, new Rectangle(this.imageX, this.imageY, this.pointImg.Width, this.pointImg.Height));
  }

  private void button0_Click(object sender, EventArgs e)
  {
    if (this.myCount == 1)
      return;
    if (this.Height == 20)
      this.Height = this.imageY + this.imageY * this.myCount;
    else
      this.Height = 20;
  }

  private void button1_Click(object sender, EventArgs e)
  {
    this.SetUCComboBoxMode(1);
    UCComboBoxB.delegateUCComboBoxB ucComboBoxB = this.ucComboBoxB;
    if (ucComboBoxB == null)
      return;
    ucComboBoxB(this.myMode);
  }

  private void button2_Click(object sender, EventArgs e)
  {
    this.SetUCComboBoxMode(2);
    UCComboBoxB.delegateUCComboBoxB ucComboBoxB = this.ucComboBoxB;
    if (ucComboBoxB == null)
      return;
    ucComboBoxB(this.myMode);
  }

  private void button3_Click(object sender, EventArgs e)
  {
    this.SetUCComboBoxMode(3);
    UCComboBoxB.delegateUCComboBoxB ucComboBoxB = this.ucComboBoxB;
    if (ucComboBoxB == null)
      return;
    ucComboBoxB(this.myMode);
  }

  private void button4_Click(object sender, EventArgs e)
  {
    this.SetUCComboBoxMode(4);
    UCComboBoxB.delegateUCComboBoxB ucComboBoxB = this.ucComboBoxB;
    if (ucComboBoxB == null)
      return;
    ucComboBoxB(this.myMode);
  }

  private void button5_Click(object sender, EventArgs e)
  {
    this.SetUCComboBoxMode(5);
    UCComboBoxB.delegateUCComboBoxB ucComboBoxB = this.ucComboBoxB;
    if (ucComboBoxB == null)
      return;
    ucComboBoxB(this.myMode);
  }

  private void button6_Click(object sender, EventArgs e)
  {
    this.SetUCComboBoxMode(6);
    UCComboBoxB.delegateUCComboBoxB ucComboBoxB = this.ucComboBoxB;
    if (ucComboBoxB == null)
      return;
    ucComboBoxB(this.myMode);
  }

  private void button7_Click(object sender, EventArgs e)
  {
    this.SetUCComboBoxMode(7);
    UCComboBoxB.delegateUCComboBoxB ucComboBoxB = this.ucComboBoxB;
    if (ucComboBoxB == null)
      return;
    ucComboBoxB(this.myMode);
  }

  private void button8_Click(object sender, EventArgs e)
  {
    this.SetUCComboBoxMode(8);
    UCComboBoxB.delegateUCComboBoxB ucComboBoxB = this.ucComboBoxB;
    if (ucComboBoxB == null)
      return;
    ucComboBoxB(this.myMode);
  }

  private void button_MouseEnter(object sender, EventArgs e)
  {
    Button button = (Button) sender;
    button.BackgroundImage = (Image) Resources.A2下拉框选择条;
    button.ForeColor = this.color1;
  }

  private void button_MouseLeave(object sender, EventArgs e)
  {
    Button button = (Button) sender;
    button.BackgroundImage.Dispose();
    button.BackgroundImage = (Image) null;
    button.ForeColor = this.color2;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.button2 = new Button();
    this.button1 = new Button();
    this.button3 = new Button();
    this.button4 = new Button();
    this.button5 = new Button();
    this.button6 = new Button();
    this.button7 = new Button();
    this.button8 = new Button();
    this.button0 = new Button();
    this.SuspendLayout();
    this.button2.BackColor = Color.Transparent;
    this.button2.BackgroundImageLayout = ImageLayout.Stretch;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("微软雅黑", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.button2.ForeColor = Color.Silver;
    this.button2.Location = new Point(0, 40);
    this.button2.Margin = new Padding(0);
    this.button2.Name = "button2";
    this.button2.Size = new Size(58, 20);
    this.button2.TabIndex = 82;
    this.button2.Text = "2";
    this.button2.TextAlign = ContentAlignment.TopCenter;
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button2.MouseEnter += new EventHandler(this.button_MouseEnter);
    this.button2.MouseLeave += new EventHandler(this.button_MouseLeave);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("微软雅黑", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.button1.ForeColor = Color.Silver;
    this.button1.Location = new Point(0, 20);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(58, 20);
    this.button1.TabIndex = 81;
    this.button1.Text = "1";
    this.button1.TextAlign = ContentAlignment.TopCenter;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button1.MouseEnter += new EventHandler(this.button_MouseEnter);
    this.button1.MouseLeave += new EventHandler(this.button_MouseLeave);
    this.button3.BackColor = Color.Transparent;
    this.button3.BackgroundImageLayout = ImageLayout.Stretch;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Font = new Font("微软雅黑", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.button3.ForeColor = Color.Silver;
    this.button3.Location = new Point(0, 60);
    this.button3.Margin = new Padding(0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(58, 20);
    this.button3.TabIndex = 83;
    this.button3.Text = "4";
    this.button3.TextAlign = ContentAlignment.TopCenter;
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button3.MouseEnter += new EventHandler(this.button_MouseEnter);
    this.button3.MouseLeave += new EventHandler(this.button_MouseLeave);
    this.button4.BackColor = Color.Transparent;
    this.button4.BackgroundImageLayout = ImageLayout.Stretch;
    this.button4.FlatAppearance.BorderSize = 0;
    this.button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button4.FlatStyle = FlatStyle.Flat;
    this.button4.Font = new Font("微软雅黑", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.button4.ForeColor = Color.Silver;
    this.button4.Location = new Point(0, 80 /*0x50*/);
    this.button4.Margin = new Padding(0);
    this.button4.Name = "button4";
    this.button4.Size = new Size(58, 20);
    this.button4.TabIndex = 84;
    this.button4.Text = "8";
    this.button4.TextAlign = ContentAlignment.TopCenter;
    this.button4.UseVisualStyleBackColor = false;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.button4.MouseEnter += new EventHandler(this.button_MouseEnter);
    this.button4.MouseLeave += new EventHandler(this.button_MouseLeave);
    this.button5.BackColor = Color.Transparent;
    this.button5.BackgroundImageLayout = ImageLayout.Stretch;
    this.button5.FlatAppearance.BorderSize = 0;
    this.button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button5.FlatStyle = FlatStyle.Flat;
    this.button5.Font = new Font("微软雅黑", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.button5.ForeColor = Color.Silver;
    this.button5.Location = new Point(0, 100);
    this.button5.Margin = new Padding(0);
    this.button5.Name = "button5";
    this.button5.Size = new Size(58, 20);
    this.button5.TabIndex = 85;
    this.button5.Text = "16";
    this.button5.TextAlign = ContentAlignment.TopCenter;
    this.button5.UseVisualStyleBackColor = false;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.button5.MouseEnter += new EventHandler(this.button_MouseEnter);
    this.button5.MouseLeave += new EventHandler(this.button_MouseLeave);
    this.button6.BackColor = Color.Transparent;
    this.button6.BackgroundImageLayout = ImageLayout.Stretch;
    this.button6.FlatAppearance.BorderSize = 0;
    this.button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button6.FlatStyle = FlatStyle.Flat;
    this.button6.Font = new Font("微软雅黑", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.button6.ForeColor = Color.Silver;
    this.button6.Location = new Point(0, 120);
    this.button6.Margin = new Padding(0);
    this.button6.Name = "button6";
    this.button6.Size = new Size(58, 20);
    this.button6.TabIndex = 86;
    this.button6.Text = "32";
    this.button6.TextAlign = ContentAlignment.TopCenter;
    this.button6.UseVisualStyleBackColor = false;
    this.button6.Click += new EventHandler(this.button6_Click);
    this.button6.MouseEnter += new EventHandler(this.button_MouseEnter);
    this.button6.MouseLeave += new EventHandler(this.button_MouseLeave);
    this.button7.BackColor = Color.Transparent;
    this.button7.BackgroundImageLayout = ImageLayout.Stretch;
    this.button7.FlatAppearance.BorderSize = 0;
    this.button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button7.FlatStyle = FlatStyle.Flat;
    this.button7.Font = new Font("微软雅黑", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.button7.ForeColor = Color.Silver;
    this.button7.Location = new Point(0, 140);
    this.button7.Margin = new Padding(0);
    this.button7.Name = "button7";
    this.button7.Size = new Size(58, 20);
    this.button7.TabIndex = 87;
    this.button7.Text = "64";
    this.button7.TextAlign = ContentAlignment.TopCenter;
    this.button7.UseVisualStyleBackColor = false;
    this.button7.Click += new EventHandler(this.button7_Click);
    this.button7.MouseEnter += new EventHandler(this.button_MouseEnter);
    this.button7.MouseLeave += new EventHandler(this.button_MouseLeave);
    this.button8.BackColor = Color.Transparent;
    this.button8.BackgroundImageLayout = ImageLayout.Stretch;
    this.button8.FlatAppearance.BorderSize = 0;
    this.button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button8.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button8.FlatStyle = FlatStyle.Flat;
    this.button8.Font = new Font("微软雅黑", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.button8.ForeColor = Color.Silver;
    this.button8.Location = new Point(0, 160 /*0xA0*/);
    this.button8.Margin = new Padding(0);
    this.button8.Name = "button8";
    this.button8.Size = new Size(58, 20);
    this.button8.TabIndex = 88;
    this.button8.Text = "128";
    this.button8.TextAlign = ContentAlignment.TopCenter;
    this.button8.UseVisualStyleBackColor = false;
    this.button8.Click += new EventHandler(this.button8_Click);
    this.button8.MouseEnter += new EventHandler(this.button_MouseEnter);
    this.button8.MouseLeave += new EventHandler(this.button_MouseLeave);
    this.button0.BackColor = Color.Transparent;
    this.button0.BackgroundImage = (Image) Resources.D下拉框;
    this.button0.BackgroundImageLayout = ImageLayout.Stretch;
    this.button0.FlatAppearance.BorderSize = 0;
    this.button0.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button0.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button0.FlatStyle = FlatStyle.Flat;
    this.button0.Font = new Font("微软雅黑", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.button0.ForeColor = Color.Silver;
    this.button0.Location = new Point(0, 0);
    this.button0.Margin = new Padding(0);
    this.button0.Name = "button0";
    this.button0.Size = new Size(58, 20);
    this.button0.TabIndex = 80 /*0x50*/;
    this.button0.Text = "2";
    this.button0.TextAlign = ContentAlignment.TopCenter;
    this.button0.UseVisualStyleBackColor = false;
    this.button0.Click += new EventHandler(this.button0_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.button8);
    this.Controls.Add((Control) this.button7);
    this.Controls.Add((Control) this.button6);
    this.Controls.Add((Control) this.button5);
    this.Controls.Add((Control) this.button4);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.button0);
    this.DoubleBuffered = true;
    this.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.Margin = new Padding(0);
    this.Name = nameof (UCComboBoxB);
    this.Size = new Size(58, 20);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCComboBoxB(int mode);
}

// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCSystemInfoOptionsOne
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

public class UCSystemInfoOptionsOne : UserControl
{
  private int myMode = 0;
  public static readonly Color myColorZDY = Color.FromArgb(147, 117, (int) byte.MaxValue);
  public static readonly Color myColorCpu = Color.FromArgb(50, 197, (int) byte.MaxValue);
  public static readonly Color myColorGpu = Color.FromArgb(68, 215, 182);
  public static readonly Color myColorMem = Color.FromArgb(109, 212, 1);
  public static readonly Color myColorHdd = Color.FromArgb(247, 181, 1);
  public static readonly Color myColorNet = Color.FromArgb(250, 100, 1);
  public static readonly Color myColorFan = Color.FromArgb(224 /*0xE0*/, 32 /*0x20*/, 32 /*0x20*/);
  public UCSystemInfoOptionsOne.delegate_UCSystemInfoOptionsOne upDateUCSystemInfoOne;
  private IContainer components = (IContainer) null;
  private Button button1;
  private Button button2;
  private Button button3;
  private Button button4;
  public TextBox textBox1;
  public TextBox textBoxName;
  public TextBox textBox2;
  public TextBox textBox3;
  public TextBox textBox4;
  public Label label1;
  public Label label2;
  public Label label3;
  public Label label4;
  private Button buttonDelete;

  public UCSystemInfoOptionsOne()
  {
    this.InitializeComponent();
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public void SetUCSystemInfoOptionsOneColor(int mode)
  {
    this.myMode = mode;
    Color color;
    switch (this.myMode)
    {
      case 0:
        this.buttonDelete.Show();
        color = UCSystemInfoOptionsOne.myColorZDY;
        this.BackgroundImage = (Image) Resources.A自定义;
        break;
      case 1:
        color = UCSystemInfoOptionsOne.myColorCpu;
        this.BackgroundImage = (Image) Resources.Acpu;
        break;
      case 2:
        color = UCSystemInfoOptionsOne.myColorGpu;
        this.BackgroundImage = (Image) Resources.Agpu;
        break;
      case 3:
        color = UCSystemInfoOptionsOne.myColorMem;
        this.BackgroundImage = (Image) Resources.Adram;
        break;
      case 4:
        color = UCSystemInfoOptionsOne.myColorHdd;
        this.BackgroundImage = (Image) Resources.Ahdd;
        break;
      case 5:
        color = UCSystemInfoOptionsOne.myColorNet;
        this.BackgroundImage = (Image) Resources.Anet;
        break;
      case 6:
        color = UCSystemInfoOptionsOne.myColorFan;
        this.BackgroundImage = (Image) Resources.Afan;
        break;
      default:
        color = UCSystemInfoOptionsOne.myColorZDY;
        this.BackgroundImage = (Image) Resources.A自定义;
        break;
    }
    this.textBoxName.ForeColor = color;
    this.textBox1.ForeColor = color;
    this.textBox2.ForeColor = color;
    this.textBox3.ForeColor = color;
    this.textBox4.ForeColor = color;
    this.label1.ForeColor = color;
    this.label2.ForeColor = color;
    this.label3.ForeColor = color;
    this.label4.ForeColor = color;
  }

  private void button1_Click(object sender, EventArgs e)
  {
    UCSystemInfoOptionsOne.delegate_UCSystemInfoOptionsOne dateUcSystemInfoOne = this.upDateUCSystemInfoOne;
    if (dateUcSystemInfoOne == null)
      return;
    dateUcSystemInfoOne(1, (object) this);
  }

  private void button2_Click(object sender, EventArgs e)
  {
    UCSystemInfoOptionsOne.delegate_UCSystemInfoOptionsOne dateUcSystemInfoOne = this.upDateUCSystemInfoOne;
    if (dateUcSystemInfoOne == null)
      return;
    dateUcSystemInfoOne(2, (object) this);
  }

  private void button3_Click(object sender, EventArgs e)
  {
    UCSystemInfoOptionsOne.delegate_UCSystemInfoOptionsOne dateUcSystemInfoOne = this.upDateUCSystemInfoOne;
    if (dateUcSystemInfoOne == null)
      return;
    dateUcSystemInfoOne(3, (object) this);
  }

  private void button4_Click(object sender, EventArgs e)
  {
    UCSystemInfoOptionsOne.delegate_UCSystemInfoOptionsOne dateUcSystemInfoOne = this.upDateUCSystemInfoOne;
    if (dateUcSystemInfoOne == null)
      return;
    dateUcSystemInfoOne(4, (object) this);
  }

  private void textBoxAll_TextChanged(object sender, EventArgs e)
  {
    UCSystemInfoOptionsOne.delegate_UCSystemInfoOptionsOne dateUcSystemInfoOne = this.upDateUCSystemInfoOne;
    if (dateUcSystemInfoOne == null)
      return;
    dateUcSystemInfoOne(16 /*0x10*/);
  }

  private void buttonDelete_Click(object sender, EventArgs e)
  {
    DialogResult dialogResult;
    switch (Form1.Language)
    {
      case 1:
        dialogResult = MessageBox.Show("是<删除>，否<取消>", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        break;
      case 2:
        dialogResult = MessageBox.Show("是<删除>，否<取消>", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        break;
      default:
        dialogResult = MessageBox.Show("Yes<Delete>,No<Cancel>", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        break;
    }
    if (dialogResult == DialogResult.No)
      return;
    UCSystemInfoOptionsOne.delegate_UCSystemInfoOptionsOne dateUcSystemInfoOne = this.upDateUCSystemInfoOne;
    if (dateUcSystemInfoOne == null)
      return;
    dateUcSystemInfoOne(0, (object) this);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.button1 = new Button();
    this.button2 = new Button();
    this.button3 = new Button();
    this.button4 = new Button();
    this.textBox1 = new TextBox();
    this.textBoxName = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.buttonDelete = new Button();
    this.SuspendLayout();
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.A数据选择;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(245, 49);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(16 /*0x10*/, 30);
    this.button1.TabIndex = 667;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button2.BackColor = Color.Transparent;
    this.button2.BackgroundImage = (Image) Resources.A数据选择;
    this.button2.BackgroundImageLayout = ImageLayout.Stretch;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Location = new Point(245, 84);
    this.button2.Margin = new Padding(0);
    this.button2.Name = "button2";
    this.button2.Size = new Size(16 /*0x10*/, 30);
    this.button2.TabIndex = 668;
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button3.BackColor = Color.Transparent;
    this.button3.BackgroundImage = (Image) Resources.A数据选择;
    this.button3.BackgroundImageLayout = ImageLayout.Stretch;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Location = new Point(245, 119);
    this.button3.Margin = new Padding(0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(16 /*0x10*/, 30);
    this.button3.TabIndex = 669;
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button4.BackColor = Color.Transparent;
    this.button4.BackgroundImage = (Image) Resources.A数据选择;
    this.button4.BackgroundImageLayout = ImageLayout.Stretch;
    this.button4.FlatAppearance.BorderSize = 0;
    this.button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button4.FlatStyle = FlatStyle.Flat;
    this.button4.Location = new Point(245, 154);
    this.button4.Margin = new Padding(0);
    this.button4.Name = "button4";
    this.button4.Size = new Size(16 /*0x10*/, 30);
    this.button4.TabIndex = 670;
    this.button4.UseVisualStyleBackColor = false;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.textBox1.BackColor = Color.FromArgb(35, 34, 39);
    this.textBox1.BorderStyle = BorderStyle.None;
    this.textBox1.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBox1.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.textBox1.ImeMode = ImeMode.NoControl;
    this.textBox1.Location = new Point(39, 55);
    this.textBox1.MaxLength = 12;
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new Size(96 /*0x60*/, 19);
    this.textBox1.TabIndex = 671;
    this.textBox1.Text = "TEMP";
    this.textBox1.TextChanged += new EventHandler(this.textBoxAll_TextChanged);
    this.textBoxName.BackColor = Color.FromArgb(35, 34, 39);
    this.textBoxName.BorderStyle = BorderStyle.None;
    this.textBoxName.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxName.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.textBoxName.ImeMode = ImeMode.NoControl;
    this.textBoxName.Location = new Point(49, 24);
    this.textBoxName.MaxLength = 100;
    this.textBoxName.Name = "textBoxName";
    this.textBoxName.Size = new Size(210, 16 /*0x10*/);
    this.textBoxName.TabIndex = 672;
    this.textBoxName.Text = "CPU";
    this.textBoxName.TextChanged += new EventHandler(this.textBoxAll_TextChanged);
    this.textBox2.BackColor = Color.FromArgb(35, 34, 39);
    this.textBox2.BorderStyle = BorderStyle.None;
    this.textBox2.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBox2.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.textBox2.ImeMode = ImeMode.NoControl;
    this.textBox2.Location = new Point(39, 90);
    this.textBox2.MaxLength = 12;
    this.textBox2.Name = "textBox2";
    this.textBox2.Size = new Size(96 /*0x60*/, 19);
    this.textBox2.TabIndex = 673;
    this.textBox2.Text = "Usage";
    this.textBox2.TextChanged += new EventHandler(this.textBoxAll_TextChanged);
    this.textBox3.BackColor = Color.FromArgb(35, 34, 39);
    this.textBox3.BorderStyle = BorderStyle.None;
    this.textBox3.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBox3.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.textBox3.ImeMode = ImeMode.NoControl;
    this.textBox3.Location = new Point(39, 125);
    this.textBox3.MaxLength = 12;
    this.textBox3.Name = "textBox3";
    this.textBox3.Size = new Size(96 /*0x60*/, 19);
    this.textBox3.TabIndex = 674;
    this.textBox3.Text = "Clock";
    this.textBox3.TextChanged += new EventHandler(this.textBoxAll_TextChanged);
    this.textBox4.BackColor = Color.FromArgb(35, 34, 39);
    this.textBox4.BorderStyle = BorderStyle.None;
    this.textBox4.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBox4.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.textBox4.ImeMode = ImeMode.NoControl;
    this.textBox4.Location = new Point(39, 160 /*0xA0*/);
    this.textBox4.MaxLength = 12;
    this.textBox4.Name = "textBox4";
    this.textBox4.Size = new Size(96 /*0x60*/, 19);
    this.textBox4.TabIndex = 675;
    this.textBox4.Text = "Power";
    this.textBox4.TextChanged += new EventHandler(this.textBoxAll_TextChanged);
    this.label1.BackColor = Color.Transparent;
    this.label1.FlatStyle = FlatStyle.Flat;
    this.label1.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label1.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.label1.Location = new Point(138, 52);
    this.label1.Margin = new Padding(0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(108, 27);
    this.label1.TabIndex = 686;
    this.label1.Text = "88℃";
    this.label1.TextAlign = ContentAlignment.MiddleRight;
    this.label2.BackColor = Color.Transparent;
    this.label2.FlatStyle = FlatStyle.Flat;
    this.label2.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label2.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.label2.Location = new Point(138, 86);
    this.label2.Margin = new Padding(0);
    this.label2.Name = "label2";
    this.label2.Size = new Size(108, 27);
    this.label2.TabIndex = 687;
    this.label2.Text = "88%";
    this.label2.TextAlign = ContentAlignment.MiddleRight;
    this.label3.BackColor = Color.Transparent;
    this.label3.FlatStyle = FlatStyle.Flat;
    this.label3.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label3.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.label3.Location = new Point(138, 121);
    this.label3.Margin = new Padding(0);
    this.label3.Name = "label3";
    this.label3.Size = new Size(108, 27);
    this.label3.TabIndex = 688;
    this.label3.Text = "88MHz";
    this.label3.TextAlign = ContentAlignment.MiddleRight;
    this.label4.BackColor = Color.Transparent;
    this.label4.FlatStyle = FlatStyle.Flat;
    this.label4.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label4.ForeColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.label4.Location = new Point(142, 156);
    this.label4.Margin = new Padding(0);
    this.label4.Name = "label4";
    this.label4.Size = new Size(104, 27);
    this.label4.TabIndex = 689;
    this.label4.Text = "88W";
    this.label4.TextAlign = ContentAlignment.MiddleRight;
    this.buttonDelete.BackColor = Color.Transparent;
    this.buttonDelete.BackgroundImage = (Image) Resources.P关闭按钮2;
    this.buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDelete.FlatAppearance.BorderSize = 0;
    this.buttonDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDelete.FlatStyle = FlatStyle.Flat;
    this.buttonDelete.Location = new Point(245, 5);
    this.buttonDelete.Margin = new Padding(0);
    this.buttonDelete.Name = "buttonDelete";
    this.buttonDelete.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.buttonDelete.TabIndex = 690;
    this.buttonDelete.UseVisualStyleBackColor = false;
    this.buttonDelete.Visible = false;
    this.buttonDelete.Click += new EventHandler(this.buttonDelete_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.Acpu;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.buttonDelete);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.textBox4);
    this.Controls.Add((Control) this.textBox3);
    this.Controls.Add((Control) this.textBox2);
    this.Controls.Add((Control) this.textBoxName);
    this.Controls.Add((Control) this.textBox1);
    this.Controls.Add((Control) this.button4);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCSystemInfoOptionsOne);
    this.Size = new Size(266, 189);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void delegate_UCSystemInfoOptionsOne(int mode, object val = null);
}

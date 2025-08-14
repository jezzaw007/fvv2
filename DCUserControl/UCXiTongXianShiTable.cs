// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCXiTongXianShiTable
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

public class UCXiTongXianShiTable : UserControl
{
  public UCXiTongXianShiTable.delegateXiTongXianShiTable delegateXiTongTable;
  public int myMode = 0;
  public int myModeSub = 0;
  private IContainer components = (IContainer) null;
  private Button button0;
  public TextBox textBox1;
  private Button button1;
  private Button button3;

  public UCXiTongXianShiTable() => this.InitializeComponent();

  public void UCXiTongXianShiTable0(int mode, int sub)
  {
    this.myMode = mode;
    this.myModeSub = sub;
    this.textBox1.Hide();
    this.button1.Hide();
    this.button3.Hide();
    this.button0.Show();
    if (this.myModeSub == 0)
      this.button0.BackgroundImage = (Image) Resources.P单位开关;
    else
      this.button0.BackgroundImage = (Image) Resources.P单位开关a;
  }

  public void UCXiTongXianShiTable1(int mode, int sub)
  {
    this.myMode = mode;
    this.myModeSub = sub;
    this.textBox1.Hide();
    this.button0.Hide();
    this.button3.Hide();
    this.button1.Show();
    if (this.myModeSub == 1)
      this.button1.BackgroundImage = (Image) Resources.P12H;
    else
      this.button1.BackgroundImage = (Image) Resources.P24H;
  }

  public void UCXiTongXianShiTable2(int mode, int sub)
  {
    this.myMode = mode;
    this.myModeSub = sub;
    this.textBox1.Hide();
    this.button0.Hide();
    this.button1.Hide();
    this.button3.Hide();
  }

  public void UCXiTongXianShiTable3(int mode, int sub)
  {
    this.myMode = mode;
    this.myModeSub = sub;
    this.textBox1.Hide();
    this.button0.Hide();
    this.button1.Hide();
    this.button3.Show();
    if (this.myModeSub == 1)
      this.button3.BackgroundImage = (Image) Resources.PYMD;
    else if (this.myModeSub == 2)
      this.button3.BackgroundImage = (Image) Resources.PDMY;
    else if (this.myModeSub == 3)
      this.button3.BackgroundImage = (Image) Resources.PMD;
    else
      this.button3.BackgroundImage = (Image) Resources.PDM;
  }

  public void UCXiTongXianShiTable4(int mode, int sub)
  {
    this.myMode = mode;
    this.myModeSub = sub;
    this.button0.Hide();
    this.button1.Hide();
    this.button3.Hide();
    this.textBox1.Show();
  }

  private void button0_Click(object sender, EventArgs e)
  {
    this.myModeSub = this.myModeSub != 0 ? 0 : 1;
    this.UCXiTongXianShiTable0(this.myMode, this.myModeSub);
    UCXiTongXianShiTable.delegateXiTongXianShiTable delegateXiTongTable = this.delegateXiTongTable;
    if (delegateXiTongTable == null)
      return;
    delegateXiTongTable(this.myMode, (object) this.myModeSub);
  }

  private void button1_Click(object sender, EventArgs e)
  {
    this.myModeSub = this.myModeSub != 1 ? 1 : 2;
    this.UCXiTongXianShiTable1(this.myMode, this.myModeSub);
    UCXiTongXianShiTable.delegateXiTongXianShiTable delegateXiTongTable = this.delegateXiTongTable;
    if (delegateXiTongTable == null)
      return;
    delegateXiTongTable(this.myMode, (object) this.myModeSub);
  }

  private void button3_Click(object sender, EventArgs e)
  {
    this.myModeSub = this.myModeSub != 1 ? (this.myModeSub != 2 ? (this.myModeSub != 3 ? 1 : 4) : 3) : 2;
    this.UCXiTongXianShiTable3(this.myMode, this.myModeSub);
    UCXiTongXianShiTable.delegateXiTongXianShiTable delegateXiTongTable = this.delegateXiTongTable;
    if (delegateXiTongTable == null)
      return;
    delegateXiTongTable(this.myMode, (object) this.myModeSub);
  }

  private void textBox1_TextChanged(object sender, EventArgs e)
  {
    UCXiTongXianShiTable.delegateXiTongXianShiTable delegateXiTongTable = this.delegateXiTongTable;
    if (delegateXiTongTable == null)
      return;
    delegateXiTongTable(this.myMode, (object) this.myModeSub, (object) this.textBox1.Text);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.button0 = new Button();
    this.textBox1 = new TextBox();
    this.button1 = new Button();
    this.button3 = new Button();
    this.SuspendLayout();
    this.button0.BackColor = Color.Transparent;
    this.button0.BackgroundImage = (Image) Resources.P单位开关a;
    this.button0.BackgroundImageLayout = ImageLayout.Stretch;
    this.button0.FlatAppearance.BorderSize = 0;
    this.button0.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button0.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button0.FlatStyle = FlatStyle.Flat;
    this.button0.Location = new Point(80 /*0x50*/, 15);
    this.button0.Margin = new Padding(0);
    this.button0.Name = "button0";
    this.button0.Size = new Size(70, 24);
    this.button0.TabIndex = 616;
    this.button0.UseVisualStyleBackColor = false;
    this.button0.Visible = false;
    this.button0.Click += new EventHandler(this.button0_Click);
    this.textBox1.BackColor = Color.White;
    this.textBox1.BorderStyle = BorderStyle.None;
    this.textBox1.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBox1.ForeColor = Color.DimGray;
    this.textBox1.ImeMode = ImeMode.NoControl;
    this.textBox1.Location = new Point(15, 15);
    this.textBox1.MaxLength = 100;
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new Size(200, 22);
    this.textBox1.TabIndex = 673;
    this.textBox1.Text = "0";
    this.textBox1.TextAlign = HorizontalAlignment.Center;
    this.textBox1.Visible = false;
    this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P24H;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(88, 16 /*0x10*/);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(54, 22);
    this.button1.TabIndex = 674;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Visible = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button3.BackColor = Color.Transparent;
    this.button3.BackgroundImage = (Image) Resources.PDMY;
    this.button3.BackgroundImageLayout = ImageLayout.Stretch;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Location = new Point(88, 16 /*0x10*/);
    this.button3.Margin = new Padding(0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(54, 22);
    this.button3.TabIndex = 675;
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Visible = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01模块设置;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.button0);
    this.Controls.Add((Control) this.textBox1);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCXiTongXianShiTable);
    this.Size = new Size(230, 54);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void delegateXiTongXianShiTable(int cmd, object info = null, object data = null, object data1 = null);
}

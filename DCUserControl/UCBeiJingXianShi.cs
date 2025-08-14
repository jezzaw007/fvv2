// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCBeiJingXianShi
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

public class UCBeiJingXianShi : UserControl
{
  public UCBeiJingXianShi.delegateUCBeiJingXianShi delegateUCBeiJing;
  private bool buttonOn = true;
  private IContainer components = (IContainer) null;
  private Button buttonOnOff;
  private Button button1;
  private Button button2;
  private Button button3;
  private Button button4;

  public UCBeiJingXianShi()
  {
    this.InitializeComponent();
    this.buttonOnOff.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public void buttonOnOff_Set(bool bl)
  {
    this.buttonOn = bl;
    this.button1.Enabled = bl;
    this.button2.Enabled = bl;
    this.button3.Enabled = bl;
    this.button4.Enabled = bl;
    if (bl)
      this.buttonOnOff.BackgroundImage = (Image) Resources.P功能选择a;
    else
      this.buttonOnOff.BackgroundImage = (Image) Resources.P功能选择;
  }

  private void buttonOnOff_Click(object sender, EventArgs e)
  {
    this.buttonOn = false;
    this.buttonOn = !this.buttonOn;
    this.buttonOnOff_Set(this.buttonOn);
    UCBeiJingXianShi.delegateUCBeiJingXianShi delegateUcBeiJing = this.delegateUCBeiJing;
    if (delegateUcBeiJing == null)
      return;
    delegateUcBeiJing(0, (object) this.buttonOn);
  }

  private void button1_Click(object sender, EventArgs e)
  {
    UCBeiJingXianShi.delegateUCBeiJingXianShi delegateUcBeiJing = this.delegateUCBeiJing;
    if (delegateUcBeiJing == null)
      return;
    delegateUcBeiJing(1);
  }

  private void button2_Click(object sender, EventArgs e)
  {
    UCBeiJingXianShi.delegateUCBeiJingXianShi delegateUcBeiJing = this.delegateUCBeiJing;
    if (delegateUcBeiJing == null)
      return;
    delegateUcBeiJing(2);
  }

  private void button3_Click(object sender, EventArgs e)
  {
    UCBeiJingXianShi.delegateUCBeiJingXianShi delegateUcBeiJing = this.delegateUCBeiJing;
    if (delegateUcBeiJing == null)
      return;
    delegateUcBeiJing(3);
  }

  private void button4_Click(object sender, EventArgs e)
  {
    UCBeiJingXianShi.delegateUCBeiJingXianShi delegateUcBeiJing = this.delegateUCBeiJing;
    if (delegateUcBeiJing == null)
      return;
    delegateUcBeiJing(4);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonOnOff = new Button();
    this.button1 = new Button();
    this.button2 = new Button();
    this.button3 = new Button();
    this.button4 = new Button();
    this.SuspendLayout();
    this.buttonOnOff.BackColor = Color.Transparent;
    this.buttonOnOff.BackgroundImage = (Image) Resources.P功能选择a;
    this.buttonOnOff.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonOnOff.FlatAppearance.BorderSize = 0;
    this.buttonOnOff.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonOnOff.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonOnOff.FlatStyle = FlatStyle.Flat;
    this.buttonOnOff.Location = new Point(0, 0);
    this.buttonOnOff.Margin = new Padding(0);
    this.buttonOnOff.Name = "buttonOnOff";
    this.buttonOnOff.Size = new Size(50, 50);
    this.buttonOnOff.TabIndex = 613;
    this.buttonOnOff.UseVisualStyleBackColor = false;
    this.buttonOnOff.Click += new EventHandler(this.buttonOnOff_Click);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P图片;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(149, 30);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(40, 40);
    this.button1.TabIndex = 614;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button2.BackColor = Color.Transparent;
    this.button2.BackgroundImage = (Image) Resources.P动画;
    this.button2.BackgroundImageLayout = ImageLayout.Stretch;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Location = new Point(149, 111);
    this.button2.Margin = new Padding(0);
    this.button2.Name = "button2";
    this.button2.Size = new Size(40, 40);
    this.button2.TabIndex = 615;
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Visible = false;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button3.BackColor = Color.Transparent;
    this.button3.BackgroundImage = (Image) Resources.P网络;
    this.button3.BackgroundImageLayout = ImageLayout.Stretch;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Location = new Point(219, 111);
    this.button3.Margin = new Padding(0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(40, 40);
    this.button3.TabIndex = 616;
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Visible = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button4.BackColor = Color.Transparent;
    this.button4.BackgroundImage = (Image) Resources.P视频;
    this.button4.BackgroundImageLayout = ImageLayout.Stretch;
    this.button4.FlatAppearance.BorderSize = 0;
    this.button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button4.FlatStyle = FlatStyle.Flat;
    this.button4.Location = new Point(219, 30);
    this.button4.Margin = new Padding(0);
    this.button4.Name = "button4";
    this.button4.Size = new Size(40, 40);
    this.button4.TabIndex = 617;
    this.button4.UseVisualStyleBackColor = false;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01背景显示;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.button4);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCBeiJingXianShi);
    this.Size = new Size(351, 100);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCBeiJingXianShi(int cmd, object info = null, object data = null, object data1 = null);
}

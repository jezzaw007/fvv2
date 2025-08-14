// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCDingYiWenBen
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

public class UCDingYiWenBen : UserControl
{
  public UCDingYiWenBen.delegateUCDingYiWenBen delegateUCWenBen;
  private bool buttonOn = true;
  private IContainer components = (IContainer) null;
  private Button buttonOnOff;
  private Button buttonWZZT;
  public Label labelColor;
  public Label labelFont;
  public Label labelSize;
  public TextBox textBox;

  public UCDingYiWenBen()
  {
    this.InitializeComponent();
    this.buttonOnOff.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonWZZT.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public void buttonOnOff_Set(bool bl)
  {
    this.buttonOn = bl;
    if (bl)
      this.buttonOnOff.BackgroundImage = (Image) Resources.P滑动开;
    else
      this.buttonOnOff.BackgroundImage = (Image) Resources.P滑动关;
  }

  private void buttonOnOff_Click(object sender, EventArgs e)
  {
    this.buttonOn = !this.buttonOn;
    this.buttonOnOff_Set(this.buttonOn);
    UCDingYiWenBen.delegateUCDingYiWenBen delegateUcWenBen = this.delegateUCWenBen;
    if (delegateUcWenBen == null)
      return;
    delegateUcWenBen(0, (object) this.buttonOn);
  }

  private void textBox_TextChanged(object sender, EventArgs e)
  {
    UCDingYiWenBen.delegateUCDingYiWenBen delegateUcWenBen = this.delegateUCWenBen;
    if (delegateUcWenBen == null)
      return;
    delegateUcWenBen(1, (object) this.textBox.Text);
  }

  private void buttonWZZT_Click(object sender, EventArgs e)
  {
    UCDingYiWenBen.delegateUCDingYiWenBen delegateUcWenBen = this.delegateUCWenBen;
    if (delegateUcWenBen == null)
      return;
    delegateUcWenBen(2);
  }

  private void labelColor_Click(object sender, EventArgs e)
  {
    UCDingYiWenBen.delegateUCDingYiWenBen delegateUcWenBen = this.delegateUCWenBen;
    if (delegateUcWenBen == null)
      return;
    delegateUcWenBen(3);
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
    this.textBox = new TextBox();
    this.buttonWZZT = new Button();
    this.labelColor = new Label();
    this.labelFont = new Label();
    this.labelSize = new Label();
    this.SuspendLayout();
    this.buttonOnOff.BackColor = Color.Transparent;
    this.buttonOnOff.BackgroundImage = (Image) Resources.P滑动开;
    this.buttonOnOff.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonOnOff.FlatAppearance.BorderSize = 0;
    this.buttonOnOff.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonOnOff.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonOnOff.FlatStyle = FlatStyle.Flat;
    this.buttonOnOff.Location = new Point(5, 5);
    this.buttonOnOff.Margin = new Padding(0);
    this.buttonOnOff.Name = "buttonOnOff";
    this.buttonOnOff.Size = new Size(36, 18);
    this.buttonOnOff.TabIndex = 612;
    this.buttonOnOff.UseVisualStyleBackColor = false;
    this.buttonOnOff.Click += new EventHandler(this.buttonOnOff_Click);
    this.textBox.AcceptsReturn = true;
    this.textBox.AcceptsTab = true;
    this.textBox.BackColor = Color.FromArgb(238, 238, 238);
    this.textBox.BorderStyle = BorderStyle.None;
    this.textBox.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBox.ForeColor = Color.Black;
    this.textBox.ImeMode = ImeMode.NoControl;
    this.textBox.Location = new Point(175, 38);
    this.textBox.MaxLength = 1000;
    this.textBox.Multiline = true;
    this.textBox.Name = "textBox";
    this.textBox.Size = new Size(264, 24);
    this.textBox.TabIndex = 659;
    this.textBox.TextChanged += new EventHandler(this.textBox_TextChanged);
    this.buttonWZZT.BackColor = Color.Transparent;
    this.buttonWZZT.BackgroundImage = (Image) Resources.P文字字体;
    this.buttonWZZT.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWZZT.FlatAppearance.BorderSize = 0;
    this.buttonWZZT.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWZZT.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWZZT.FlatStyle = FlatStyle.Flat;
    this.buttonWZZT.Location = new Point(508, 38);
    this.buttonWZZT.Margin = new Padding(0);
    this.buttonWZZT.Name = "buttonWZZT";
    this.buttonWZZT.Size = new Size(32 /*0x20*/, 24);
    this.buttonWZZT.TabIndex = 660;
    this.buttonWZZT.UseVisualStyleBackColor = false;
    this.buttonWZZT.Click += new EventHandler(this.buttonWZZT_Click);
    this.labelColor.BackColor = Color.White;
    this.labelColor.FlatStyle = FlatStyle.Flat;
    this.labelColor.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelColor.ForeColor = Color.Gray;
    this.labelColor.Location = new Point(484, 40);
    this.labelColor.Margin = new Padding(0);
    this.labelColor.Name = "labelColor";
    this.labelColor.Size = new Size(20, 20);
    this.labelColor.TabIndex = 661;
    this.labelColor.TextAlign = ContentAlignment.MiddleLeft;
    this.labelColor.Click += new EventHandler(this.labelColor_Click);
    this.labelFont.BackColor = Color.Transparent;
    this.labelFont.FlatStyle = FlatStyle.Flat;
    this.labelFont.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelFont.ForeColor = Color.Gray;
    this.labelFont.Location = new Point(544, 40);
    this.labelFont.Margin = new Padding(0);
    this.labelFont.Name = "labelFont";
    this.labelFont.Size = new Size(92, 20);
    this.labelFont.TabIndex = 662;
    this.labelFont.Text = "微软雅黑";
    this.labelFont.TextAlign = ContentAlignment.MiddleCenter;
    this.labelSize.BackColor = Color.Transparent;
    this.labelSize.FlatStyle = FlatStyle.Flat;
    this.labelSize.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelSize.ForeColor = Color.Gray;
    this.labelSize.Location = new Point(653, 40);
    this.labelSize.Margin = new Padding(0);
    this.labelSize.Name = "labelSize";
    this.labelSize.Size = new Size(36, 20);
    this.labelSize.TabIndex = 663;
    this.labelSize.Text = "9";
    this.labelSize.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01自定文字;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.labelSize);
    this.Controls.Add((Control) this.labelFont);
    this.Controls.Add((Control) this.labelColor);
    this.Controls.Add((Control) this.buttonWZZT);
    this.Controls.Add((Control) this.textBox);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCDingYiWenBen);
    this.Size = new Size(712, 100);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void delegateUCDingYiWenBen(int cmd, object info = null, object data = null, object data1 = null);
}

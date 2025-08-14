// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCLEDMemoryInfo
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace TRCC.DCUserControl;

public class UCLEDMemoryInfo : UserControl
{
  private IContainer components = (IContainer) null;
  public UCComboBoxB ucComboBoxB1;
  public Label label2;
  public Label label1;
  public Label label3;
  public Label label4;
  public Label label5;
  public Label label6;
  public Label label7;
  public Label label2_1;
  public Label label8;
  public Label label9;
  public Label label10;

  public UCLEDMemoryInfo() => this.InitializeComponent();

  private void UCLEDMemoryInfo_Click(object sender, EventArgs e)
  {
    this.ucComboBoxB1.ReSetUCComboBoxMode();
  }

  public void SetUCLEDMemoryInfo(
    string str1,
    string str2,
    string str3,
    string str4,
    string str5,
    string str6,
    string str7,
    string str8,
    string str9,
    string str10,
    string str11)
  {
    this.label1.Text = str1;
    this.label2.Text = str2;
    this.label3.Text = str3;
    this.label4.Text = str4;
    this.label5.Text = str5;
    this.label6.Text = str6;
    this.label7.Text = str7;
    this.label8.Text = str8;
    this.label9.Text = str9;
    this.label10.Text = str10;
    this.label2_1.Text = str11;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.label2 = new Label();
    this.label1 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label2_1 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.ucComboBoxB1 = new UCComboBoxB();
    this.SuspendLayout();
    this.label2.BackColor = Color.Transparent;
    this.label2.FlatStyle = FlatStyle.Flat;
    this.label2.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label2.ForeColor = Color.FromArgb(180, 150, 83);
    this.label2.Location = new Point(136, 35);
    this.label2.Margin = new Padding(0);
    this.label2.Name = "label2";
    this.label2.Size = new Size(166, 23);
    this.label2.TabIndex = 680;
    this.label2.TextAlign = ContentAlignment.MiddleLeft;
    this.label1.BackColor = Color.Transparent;
    this.label1.FlatStyle = FlatStyle.Flat;
    this.label1.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label1.ForeColor = Color.FromArgb(180, 150, 83);
    this.label1.Location = new Point(136, 15);
    this.label1.Margin = new Padding(0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(166, 23);
    this.label1.TabIndex = 681;
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.label3.BackColor = Color.Transparent;
    this.label3.FlatStyle = FlatStyle.Flat;
    this.label3.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label3.ForeColor = Color.FromArgb(180, 150, 83);
    this.label3.Location = new Point(136, 54);
    this.label3.Margin = new Padding(0);
    this.label3.Name = "label3";
    this.label3.Size = new Size(166, 23);
    this.label3.TabIndex = 682;
    this.label3.TextAlign = ContentAlignment.MiddleLeft;
    this.label4.BackColor = Color.Transparent;
    this.label4.FlatStyle = FlatStyle.Flat;
    this.label4.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label4.ForeColor = Color.FromArgb(180, 150, 83);
    this.label4.Location = new Point(136, 74);
    this.label4.Margin = new Padding(0);
    this.label4.Name = "label4";
    this.label4.Size = new Size(166, 23);
    this.label4.TabIndex = 683;
    this.label4.TextAlign = ContentAlignment.MiddleLeft;
    this.label5.BackColor = Color.Transparent;
    this.label5.FlatStyle = FlatStyle.Flat;
    this.label5.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label5.ForeColor = Color.FromArgb(180, 150, 83);
    this.label5.Location = new Point(169, 94);
    this.label5.Margin = new Padding(0);
    this.label5.Name = "label5";
    this.label5.Size = new Size(38, 23);
    this.label5.TabIndex = 684;
    this.label5.TextAlign = ContentAlignment.MiddleLeft;
    this.label6.BackColor = Color.Transparent;
    this.label6.FlatStyle = FlatStyle.Flat;
    this.label6.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label6.ForeColor = Color.FromArgb(180, 150, 83);
    this.label6.Location = new Point(228, 94);
    this.label6.Margin = new Padding(0);
    this.label6.Name = "label6";
    this.label6.Size = new Size(38, 23);
    this.label6.TabIndex = 685;
    this.label6.TextAlign = ContentAlignment.MiddleLeft;
    this.label7.BackColor = Color.Transparent;
    this.label7.FlatStyle = FlatStyle.Flat;
    this.label7.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label7.ForeColor = Color.FromArgb(180, 150, 83);
    this.label7.Location = new Point(283, 94);
    this.label7.Margin = new Padding(0);
    this.label7.Name = "label7";
    this.label7.Size = new Size(38, 23);
    this.label7.TabIndex = 686;
    this.label7.TextAlign = ContentAlignment.MiddleLeft;
    this.label2_1.BackColor = Color.Transparent;
    this.label2_1.FlatStyle = FlatStyle.Flat;
    this.label2_1.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label2_1.ForeColor = Color.FromArgb(180, 150, 83);
    this.label2_1.Location = new Point(311, 35);
    this.label2_1.Margin = new Padding(0);
    this.label2_1.Name = "label2_1";
    this.label2_1.Size = new Size(128 /*0x80*/, 23);
    this.label2_1.TabIndex = 687;
    this.label2_1.TextAlign = ContentAlignment.MiddleLeft;
    this.label8.BackColor = Color.Transparent;
    this.label8.FlatStyle = FlatStyle.Flat;
    this.label8.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label8.ForeColor = Color.FromArgb(180, 150, 83);
    this.label8.Location = new Point(346, 94);
    this.label8.Margin = new Padding(0);
    this.label8.Name = "label8";
    this.label8.Size = new Size(38, 23);
    this.label8.TabIndex = 688;
    this.label8.TextAlign = ContentAlignment.MiddleLeft;
    this.label9.BackColor = Color.Transparent;
    this.label9.FlatStyle = FlatStyle.Flat;
    this.label9.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label9.ForeColor = Color.FromArgb(180, 150, 83);
    this.label9.Location = new Point(401, 94);
    this.label9.Margin = new Padding(0);
    this.label9.Name = "label9";
    this.label9.Size = new Size(38, 23);
    this.label9.TabIndex = 689;
    this.label9.TextAlign = ContentAlignment.MiddleLeft;
    this.label10.BackColor = Color.Transparent;
    this.label10.FlatStyle = FlatStyle.Flat;
    this.label10.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label10.ForeColor = Color.FromArgb(180, 150, 83);
    this.label10.Location = new Point(464, 94);
    this.label10.Margin = new Padding(0);
    this.label10.Name = "label10";
    this.label10.Size = new Size(38, 23);
    this.label10.TabIndex = 690;
    this.label10.TextAlign = ContentAlignment.MiddleLeft;
    this.ucComboBoxB1.BackColor = Color.Transparent;
    this.ucComboBoxB1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.ucComboBoxB1.Location = new Point(430, 35);
    this.ucComboBoxB1.Margin = new Padding(0);
    this.ucComboBoxB1.Name = "ucComboBoxB1";
    this.ucComboBoxB1.Size = new Size(58, 20);
    this.ucComboBoxB1.TabIndex = 691;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.ucComboBoxB1);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.label2_1);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.label2);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCLEDMemoryInfo);
    this.Size = new Size(506, 132);
    this.Click += new EventHandler(this.UCLEDMemoryInfo_Click);
    this.ResumeLayout(false);
  }
}

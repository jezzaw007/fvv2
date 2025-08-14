// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCLEDHarddiskInfo
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace TRCC.DCUserControl;

public class UCLEDHarddiskInfo : UserControl
{
  private IContainer components = (IContainer) null;
  public Label label4;
  public Label label3;
  public Label label1;
  public Label label2;
  public UCComboBoxC ucComboBoxC1;

  public UCLEDHarddiskInfo() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.label4 = new Label();
    this.label3 = new Label();
    this.label1 = new Label();
    this.label2 = new Label();
    this.ucComboBoxC1 = new UCComboBoxC();
    this.SuspendLayout();
    this.label4.BackColor = Color.Transparent;
    this.label4.FlatStyle = FlatStyle.Flat;
    this.label4.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label4.ForeColor = Color.FromArgb(180, 150, 83);
    this.label4.Location = new Point(170, 88);
    this.label4.Margin = new Padding(0);
    this.label4.Name = "label4";
    this.label4.Size = new Size(166, 23);
    this.label4.TabIndex = 687;
    this.label4.TextAlign = ContentAlignment.MiddleLeft;
    this.label3.BackColor = Color.Transparent;
    this.label3.FlatStyle = FlatStyle.Flat;
    this.label3.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label3.ForeColor = Color.FromArgb(180, 150, 83);
    this.label3.Location = new Point(170, 66);
    this.label3.Margin = new Padding(0);
    this.label3.Name = "label3";
    this.label3.Size = new Size(166, 23);
    this.label3.TabIndex = 686;
    this.label3.TextAlign = ContentAlignment.MiddleLeft;
    this.label1.BackColor = Color.Transparent;
    this.label1.FlatStyle = FlatStyle.Flat;
    this.label1.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label1.ForeColor = Color.FromArgb(180, 150, 83);
    this.label1.Location = new Point(170, 21);
    this.label1.Margin = new Padding(0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(166, 23);
    this.label1.TabIndex = 685;
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.label2.BackColor = Color.Transparent;
    this.label2.FlatStyle = FlatStyle.Flat;
    this.label2.Font = new Font("微软雅黑", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label2.ForeColor = Color.FromArgb(180, 150, 83);
    this.label2.Location = new Point(170, 43);
    this.label2.Margin = new Padding(0);
    this.label2.Name = "label2";
    this.label2.Size = new Size(166, 23);
    this.label2.TabIndex = 684;
    this.label2.TextAlign = ContentAlignment.MiddleLeft;
    this.ucComboBoxC1.BackColor = Color.Transparent;
    this.ucComboBoxC1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.ucComboBoxC1.Location = new Point(304, 21);
    this.ucComboBoxC1.Margin = new Padding(0);
    this.ucComboBoxC1.Name = "ucComboBoxC1";
    this.ucComboBoxC1.Size = new Size(180, 24);
    this.ucComboBoxC1.TabIndex = 688;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.ucComboBoxC1);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.label2);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCLEDHarddiskInfo);
    this.Size = new Size(506, 132);
    this.ResumeLayout(false);
  }
}

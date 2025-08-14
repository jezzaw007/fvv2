// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCJianPanLianDongC
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCJianPanLianDongC : UserControl
{
  private IContainer components = (IContainer) null;
  private Button buttonOnOff;
  private Button buttonWL1;
  private Button buttonXZ1;
  private Button buttonYL1;
  public Label labelSize;
  public Label labelFont;
  public Label labelColor;
  private Button buttonWZZT;

  public UCJianPanLianDongC() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonOnOff = new Button();
    this.buttonWL1 = new Button();
    this.buttonXZ1 = new Button();
    this.buttonYL1 = new Button();
    this.labelSize = new Label();
    this.labelFont = new Label();
    this.labelColor = new Label();
    this.buttonWZZT = new Button();
    this.SuspendLayout();
    this.buttonOnOff.BackColor = Color.Transparent;
    this.buttonOnOff.BackgroundImage = (Image) Resources.P滑动开;
    this.buttonOnOff.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonOnOff.FlatAppearance.BorderSize = 0;
    this.buttonOnOff.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonOnOff.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonOnOff.FlatStyle = FlatStyle.Flat;
    this.buttonOnOff.Location = new Point(22, 24);
    this.buttonOnOff.Margin = new Padding(0);
    this.buttonOnOff.Name = "buttonOnOff";
    this.buttonOnOff.Size = new Size(18, 36);
    this.buttonOnOff.TabIndex = 614;
    this.buttonOnOff.UseVisualStyleBackColor = false;
    this.buttonWL1.BackColor = Color.Transparent;
    this.buttonWL1.BackgroundImage = (Image) Resources.P网络按钮;
    this.buttonWL1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWL1.FlatAppearance.BorderSize = 0;
    this.buttonWL1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWL1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWL1.FlatStyle = FlatStyle.Flat;
    this.buttonWL1.Location = new Point(344, 32 /*0x20*/);
    this.buttonWL1.Margin = new Padding(0);
    this.buttonWL1.Name = "buttonWL1";
    this.buttonWL1.Size = new Size(20, 20);
    this.buttonWL1.TabIndex = 666;
    this.buttonWL1.UseVisualStyleBackColor = false;
    this.buttonXZ1.BackColor = Color.Transparent;
    this.buttonXZ1.BackgroundImage = (Image) Resources.P载入动画;
    this.buttonXZ1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXZ1.FlatAppearance.BorderSize = 0;
    this.buttonXZ1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXZ1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXZ1.FlatStyle = FlatStyle.Flat;
    this.buttonXZ1.Location = new Point(289, 32 /*0x20*/);
    this.buttonXZ1.Margin = new Padding(0);
    this.buttonXZ1.Name = "buttonXZ1";
    this.buttonXZ1.Size = new Size(50, 20);
    this.buttonXZ1.TabIndex = 665;
    this.buttonXZ1.UseVisualStyleBackColor = false;
    this.buttonYL1.BackColor = Color.Transparent;
    this.buttonYL1.BackgroundImage = (Image) Resources.P预览动画;
    this.buttonYL1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonYL1.FlatAppearance.BorderSize = 0;
    this.buttonYL1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonYL1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonYL1.FlatStyle = FlatStyle.Flat;
    this.buttonYL1.Location = new Point(229, 32 /*0x20*/);
    this.buttonYL1.Margin = new Padding(0);
    this.buttonYL1.Name = "buttonYL1";
    this.buttonYL1.Size = new Size(50, 20);
    this.buttonYL1.TabIndex = 664;
    this.buttonYL1.UseVisualStyleBackColor = false;
    this.labelSize.BackColor = Color.Transparent;
    this.labelSize.FlatStyle = FlatStyle.Flat;
    this.labelSize.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelSize.ForeColor = Color.Gray;
    this.labelSize.Location = new Point(490, 48 /*0x30*/);
    this.labelSize.Margin = new Padding(0);
    this.labelSize.Name = "labelSize";
    this.labelSize.Size = new Size(40, 20);
    this.labelSize.TabIndex = 670;
    this.labelSize.Text = "9";
    this.labelSize.TextAlign = ContentAlignment.MiddleCenter;
    this.labelFont.BackColor = Color.Transparent;
    this.labelFont.FlatStyle = FlatStyle.Flat;
    this.labelFont.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelFont.ForeColor = Color.Gray;
    this.labelFont.Location = new Point(394, 48 /*0x30*/);
    this.labelFont.Margin = new Padding(0);
    this.labelFont.Name = "labelFont";
    this.labelFont.Size = new Size(92, 20);
    this.labelFont.TabIndex = 669;
    this.labelFont.Text = "微软雅黑";
    this.labelFont.TextAlign = ContentAlignment.MiddleCenter;
    this.labelColor.BackColor = Color.White;
    this.labelColor.FlatStyle = FlatStyle.Flat;
    this.labelColor.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelColor.ForeColor = Color.Gray;
    this.labelColor.Location = new Point(434, 14);
    this.labelColor.Margin = new Padding(0);
    this.labelColor.Name = "labelColor";
    this.labelColor.Size = new Size(24, 24);
    this.labelColor.TabIndex = 668;
    this.labelColor.TextAlign = ContentAlignment.MiddleLeft;
    this.buttonWZZT.BackColor = Color.Transparent;
    this.buttonWZZT.BackgroundImage = (Image) Resources.P文字字体;
    this.buttonWZZT.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWZZT.FlatAppearance.BorderSize = 0;
    this.buttonWZZT.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWZZT.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWZZT.FlatStyle = FlatStyle.Flat;
    this.buttonWZZT.Location = new Point(391, 14);
    this.buttonWZZT.Margin = new Padding(0);
    this.buttonWZZT.Name = "buttonWZZT";
    this.buttonWZZT.Size = new Size(40, 24);
    this.buttonWZZT.TabIndex = 667;
    this.buttonWZZT.UseVisualStyleBackColor = false;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01键盘联动3;
    this.Controls.Add((Control) this.labelSize);
    this.Controls.Add((Control) this.labelFont);
    this.Controls.Add((Control) this.labelColor);
    this.Controls.Add((Control) this.buttonWZZT);
    this.Controls.Add((Control) this.buttonWL1);
    this.Controls.Add((Control) this.buttonXZ1);
    this.Controls.Add((Control) this.buttonYL1);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCJianPanLianDongC);
    this.Size = new Size(682, 84);
    this.ResumeLayout(false);
  }
}

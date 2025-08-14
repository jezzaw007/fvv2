// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCJianPanLianDongB
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCJianPanLianDongB : UserControl
{
  private IContainer components = (IContainer) null;
  private Button buttonOnOff;
  private Button buttonWL2;
  private Button buttonWL1;
  private Button buttonXZ2;
  private Button buttonXZ1;
  private Button buttonYL2;
  private Button buttonYL1;

  public UCJianPanLianDongB() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.buttonOnOff = new Button();
    this.buttonWL2 = new Button();
    this.buttonWL1 = new Button();
    this.buttonXZ2 = new Button();
    this.buttonXZ1 = new Button();
    this.buttonYL2 = new Button();
    this.buttonYL1 = new Button();
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
    this.buttonWL2.BackColor = Color.Transparent;
    this.buttonWL2.BackgroundImage = (Image) Resources.P网络按钮;
    this.buttonWL2.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWL2.FlatAppearance.BorderSize = 0;
    this.buttonWL2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWL2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWL2.FlatStyle = FlatStyle.Flat;
    this.buttonWL2.Location = new Point(384, 47);
    this.buttonWL2.Margin = new Padding(0);
    this.buttonWL2.Name = "buttonWL2";
    this.buttonWL2.Size = new Size(20, 20);
    this.buttonWL2.TabIndex = 664;
    this.buttonWL2.UseVisualStyleBackColor = false;
    this.buttonWL1.BackColor = Color.Transparent;
    this.buttonWL1.BackgroundImage = (Image) Resources.P网络按钮;
    this.buttonWL1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWL1.FlatAppearance.BorderSize = 0;
    this.buttonWL1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWL1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWL1.FlatStyle = FlatStyle.Flat;
    this.buttonWL1.Location = new Point(384, 18);
    this.buttonWL1.Margin = new Padding(0);
    this.buttonWL1.Name = "buttonWL1";
    this.buttonWL1.Size = new Size(20, 20);
    this.buttonWL1.TabIndex = 663;
    this.buttonWL1.UseVisualStyleBackColor = false;
    this.buttonXZ2.BackColor = Color.Transparent;
    this.buttonXZ2.BackgroundImage = (Image) Resources.P载入动画;
    this.buttonXZ2.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXZ2.FlatAppearance.BorderSize = 0;
    this.buttonXZ2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXZ2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXZ2.FlatStyle = FlatStyle.Flat;
    this.buttonXZ2.Location = new Point(329, 47);
    this.buttonXZ2.Margin = new Padding(0);
    this.buttonXZ2.Name = "buttonXZ2";
    this.buttonXZ2.Size = new Size(50, 20);
    this.buttonXZ2.TabIndex = 662;
    this.buttonXZ2.UseVisualStyleBackColor = false;
    this.buttonXZ1.BackColor = Color.Transparent;
    this.buttonXZ1.BackgroundImage = (Image) Resources.P载入动画;
    this.buttonXZ1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXZ1.FlatAppearance.BorderSize = 0;
    this.buttonXZ1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXZ1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXZ1.FlatStyle = FlatStyle.Flat;
    this.buttonXZ1.Location = new Point(329, 18);
    this.buttonXZ1.Margin = new Padding(0);
    this.buttonXZ1.Name = "buttonXZ1";
    this.buttonXZ1.Size = new Size(50, 20);
    this.buttonXZ1.TabIndex = 661;
    this.buttonXZ1.UseVisualStyleBackColor = false;
    this.buttonYL2.BackColor = Color.Transparent;
    this.buttonYL2.BackgroundImage = (Image) Resources.P预览动画;
    this.buttonYL2.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonYL2.FlatAppearance.BorderSize = 0;
    this.buttonYL2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonYL2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonYL2.FlatStyle = FlatStyle.Flat;
    this.buttonYL2.Location = new Point(269, 47);
    this.buttonYL2.Margin = new Padding(0);
    this.buttonYL2.Name = "buttonYL2";
    this.buttonYL2.Size = new Size(50, 20);
    this.buttonYL2.TabIndex = 660;
    this.buttonYL2.UseVisualStyleBackColor = false;
    this.buttonYL1.BackColor = Color.Transparent;
    this.buttonYL1.BackgroundImage = (Image) Resources.P预览动画;
    this.buttonYL1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonYL1.FlatAppearance.BorderSize = 0;
    this.buttonYL1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonYL1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonYL1.FlatStyle = FlatStyle.Flat;
    this.buttonYL1.Location = new Point(269, 18);
    this.buttonYL1.Margin = new Padding(0);
    this.buttonYL1.Name = "buttonYL1";
    this.buttonYL1.Size = new Size(50, 20);
    this.buttonYL1.TabIndex = 659;
    this.buttonYL1.UseVisualStyleBackColor = false;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01键盘联动2;
    this.Controls.Add((Control) this.buttonWL2);
    this.Controls.Add((Control) this.buttonWL1);
    this.Controls.Add((Control) this.buttonXZ2);
    this.Controls.Add((Control) this.buttonXZ1);
    this.Controls.Add((Control) this.buttonYL2);
    this.Controls.Add((Control) this.buttonYL1);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCJianPanLianDongB);
    this.Size = new Size(682, 84);
    this.ResumeLayout(false);
  }
}

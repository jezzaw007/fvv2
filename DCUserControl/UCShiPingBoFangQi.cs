// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCShiPingBoFangQi
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

public class UCShiPingBoFangQi : UserControl
{
  public UCShiPingBoFangQi.delegateUCShiPingBoFangQi delegateUCShiPing;
  private bool buttonOn = false;
  private IContainer components = (IContainer) null;
  private Button button1;
  private Button buttonOnOff;

  public UCShiPingBoFangQi()
  {
    this.InitializeComponent();
    this.buttonOnOff.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public void buttonOnOff_Set(bool bl)
  {
    this.buttonOn = bl;
    this.button1.Enabled = bl;
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
    UCShiPingBoFangQi.delegateUCShiPingBoFangQi delegateUcShiPing = this.delegateUCShiPing;
    if (delegateUcShiPing == null)
      return;
    delegateUcShiPing(0, (object) this.buttonOn);
  }

  private void button1_Click(object sender, EventArgs e)
  {
    UCShiPingBoFangQi.delegateUCShiPingBoFangQi delegateUcShiPing = this.delegateUCShiPing;
    if (delegateUcShiPing == null)
      return;
    delegateUcShiPing(1);
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
    this.buttonOnOff = new Button();
    this.SuspendLayout();
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P直播视频载入;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.Enabled = false;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(149, 30);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(40, 40);
    this.button1.TabIndex = 616;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.buttonOnOff.BackColor = Color.Transparent;
    this.buttonOnOff.BackgroundImage = (Image) Resources.P功能选择;
    this.buttonOnOff.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonOnOff.FlatAppearance.BorderSize = 0;
    this.buttonOnOff.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonOnOff.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonOnOff.FlatStyle = FlatStyle.Flat;
    this.buttonOnOff.Location = new Point(0, 0);
    this.buttonOnOff.Margin = new Padding(0);
    this.buttonOnOff.Name = "buttonOnOff";
    this.buttonOnOff.Size = new Size(50, 50);
    this.buttonOnOff.TabIndex = 615;
    this.buttonOnOff.UseVisualStyleBackColor = false;
    this.buttonOnOff.Click += new EventHandler(this.buttonOnOff_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01播放器;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCShiPingBoFangQi);
    this.Size = new Size(351, 100);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCShiPingBoFangQi(int cmd, object info = null, object data = null, object data1 = null);
}

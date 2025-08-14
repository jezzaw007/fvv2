// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCMengBanXianShi
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

public class UCMengBanXianShi : UserControl
{
  public UCMengBanXianShi.delegateUCMengBanXianShi delegateUCMengBan;
  private bool buttonOn = true;
  private IContainer components = (IContainer) null;
  private Button buttonOnOff;
  private Button button3;
  private Button button1;

  public UCMengBanXianShi() => this.InitializeComponent();

  public void ButtonOnOff_Set(bool bl)
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
    this.ButtonOnOff_Set(this.buttonOn);
    UCMengBanXianShi.delegateUCMengBanXianShi delegateUcMengBan = this.delegateUCMengBan;
    if (delegateUcMengBan == null)
      return;
    delegateUcMengBan(0, (object) this.buttonOn);
  }

  private void button1_Click(object sender, EventArgs e)
  {
    UCMengBanXianShi.delegateUCMengBanXianShi delegateUcMengBan = this.delegateUCMengBan;
    if (delegateUcMengBan == null)
      return;
    delegateUcMengBan(1);
  }

  private void button3_Click(object sender, EventArgs e)
  {
    UCMengBanXianShi.delegateUCMengBanXianShi delegateUcMengBan = this.delegateUCMengBan;
    if (delegateUcMengBan == null)
      return;
    delegateUcMengBan(3);
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
    this.button3 = new Button();
    this.button1 = new Button();
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
    this.buttonOnOff.TabIndex = 614;
    this.buttonOnOff.UseVisualStyleBackColor = false;
    this.buttonOnOff.Click += new EventHandler(this.buttonOnOff_Click);
    this.button3.BackColor = Color.Transparent;
    this.button3.BackgroundImage = (Image) Resources.P网络;
    this.button3.BackgroundImageLayout = ImageLayout.Stretch;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Location = new Point(149, 118);
    this.button3.Margin = new Padding(0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(40, 40);
    this.button3.TabIndex = 618;
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Visible = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P蒙板;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(149, 30);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(40, 40);
    this.button1.TabIndex = 617;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01布局蒙板;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCMengBanXianShi);
    this.Size = new Size(351, 100);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCMengBanXianShi(int cmd, object info = null, object data = null, object data1 = null);
}

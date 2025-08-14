// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCXiTongXinXi
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

public class UCXiTongXinXi : UserControl
{
  public UCXiTongXinXi.delegateUCXiTongXinXi delegateUCXinxi;
  private bool buttonOn = true;
  private bool isLunbo = false;
  private int mMode = -1;
  private int mIndex = 1;
  private bool m1 = false;
  private bool m2 = false;
  private bool m3 = false;
  private bool m4 = false;
  private bool m5 = false;
  private bool m6 = false;
  private IContainer components = (IContainer) null;
  private Button buttonM1;
  private Button buttonM2;
  private Button buttonM3;
  private Button buttonM4;
  private Button buttonM5;
  private Button buttonM6;
  private Button button1;
  private Button button2;
  private Button button3;
  private Button button4;
  private Button button5;
  private Button button6;
  private Button buttonDuoXuan;
  private Button buttonLunBo;
  public Label labelTSize;
  public Label labelTFont;
  public Label labelTColor;
  private Button buttonWZZT;
  public Label labelNSize;
  public Label labelNFont;
  public Label labelNColor;
  private Button buttonSZZT;
  public TextBox textBoxTimer;
  public Button buttonOnOff;
  private Button buttonMode;
  public Button buttonDWXS;

  public UCXiTongXinXi()
  {
    this.InitializeComponent();
    this.buttonOnOff.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonM1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonM2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonM3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonM4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonM5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonM6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonDuoXuan.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonLunBo.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonWZZT.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonSZZT.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonMode.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
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
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(0, (object) this.buttonOn);
  }

  public void ButtonM_Set(int mode)
  {
    this.mIndex = mode;
    this.buttonM1.BackgroundImage = (Image) Resources.PM1;
    this.buttonM2.BackgroundImage = (Image) Resources.PM2;
    this.buttonM3.BackgroundImage = (Image) Resources.PM3;
    this.buttonM4.BackgroundImage = (Image) Resources.PM4;
    this.buttonM5.BackgroundImage = (Image) Resources.PM5;
    this.buttonM6.BackgroundImage = (Image) Resources.PM6;
    switch (mode)
    {
      case 1:
        this.buttonM1.BackgroundImage = (Image) Resources.PM1a;
        break;
      case 2:
        this.buttonM2.BackgroundImage = (Image) Resources.PM2a;
        break;
      case 3:
        this.buttonM3.BackgroundImage = (Image) Resources.PM3a;
        break;
      case 4:
        this.buttonM4.BackgroundImage = (Image) Resources.PM4a;
        break;
      case 5:
        this.buttonM5.BackgroundImage = (Image) Resources.PM5a;
        break;
      case 6:
        this.buttonM6.BackgroundImage = (Image) Resources.PM6a;
        break;
    }
  }

  private void buttonM1_Click(object sender, EventArgs e)
  {
    this.mIndex = 1;
    this.ButtonM_Set(this.mIndex);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(1, (object) this.mIndex);
  }

  private void buttonM2_Click(object sender, EventArgs e)
  {
    this.mIndex = 2;
    this.ButtonM_Set(this.mIndex);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(1, (object) this.mIndex);
  }

  private void buttonM3_Click(object sender, EventArgs e)
  {
    this.mIndex = 3;
    this.ButtonM_Set(this.mIndex);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(1, (object) this.mIndex);
  }

  private void buttonM4_Click(object sender, EventArgs e)
  {
    this.mIndex = 4;
    this.ButtonM_Set(this.mIndex);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(1, (object) this.mIndex);
  }

  private void buttonM5_Click(object sender, EventArgs e)
  {
    this.mIndex = 5;
    this.ButtonM_Set(this.mIndex);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(1, (object) this.mIndex);
  }

  private void buttonM6_Click(object sender, EventArgs e)
  {
    this.mIndex = 6;
    this.ButtonM_Set(this.mIndex);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(1, (object) this.mIndex);
  }

  public void Button_Set(bool a1, bool a2, bool a3, bool a4, bool a5, bool a6)
  {
    this.m1 = a1;
    this.m2 = a2;
    this.m3 = a3;
    this.m4 = a4;
    this.m5 = a5;
    this.m6 = a6;
    if (a1)
      this.button1.BackgroundImage = (Image) Resources.P选择框Ma;
    else
      this.button1.BackgroundImage = (Image) Resources.P选择框M;
    if (a2)
      this.button2.BackgroundImage = (Image) Resources.P选择框Ma;
    else
      this.button2.BackgroundImage = (Image) Resources.P选择框M;
    if (a3)
      this.button3.BackgroundImage = (Image) Resources.P选择框Ma;
    else
      this.button3.BackgroundImage = (Image) Resources.P选择框M;
    if (a4)
      this.button4.BackgroundImage = (Image) Resources.P选择框Ma;
    else
      this.button4.BackgroundImage = (Image) Resources.P选择框M;
    if (a5)
      this.button5.BackgroundImage = (Image) Resources.P选择框Ma;
    else
      this.button5.BackgroundImage = (Image) Resources.P选择框M;
    if (a6)
      this.button6.BackgroundImage = (Image) Resources.P选择框Ma;
    else
      this.button6.BackgroundImage = (Image) Resources.P选择框M;
  }

  private void button1_Click(object sender, EventArgs e)
  {
    this.m1 = !this.m1;
    this.mMode = (this.m1 ? 1 : 0) + (this.m2 ? 1 : 0) + (this.m3 ? 1 : 0) + (this.m4 ? 1 : 0) + (this.m5 ? 1 : 0) + (this.m6 ? 1 : 0);
    this.Button_Set(this.m1, this.m2, this.m3, this.m4, this.m5, this.m6);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(2, (object) 1, (object) (this.isLunbo ? -1 : this.mMode), (object) this.m1);
  }

  private void button2_Click(object sender, EventArgs e)
  {
    this.m2 = !this.m2;
    this.mMode = (this.m1 ? 1 : 0) + (this.m2 ? 1 : 0) + (this.m3 ? 1 : 0) + (this.m4 ? 1 : 0) + (this.m5 ? 1 : 0) + (this.m6 ? 1 : 0);
    this.Button_Set(this.m1, this.m2, this.m3, this.m4, this.m5, this.m6);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(2, (object) 2, (object) (this.isLunbo ? -1 : this.mMode), (object) this.m2);
  }

  private void button3_Click(object sender, EventArgs e)
  {
    this.m3 = !this.m3;
    this.mMode = (this.m1 ? 1 : 0) + (this.m2 ? 1 : 0) + (this.m3 ? 1 : 0) + (this.m4 ? 1 : 0) + (this.m5 ? 1 : 0) + (this.m6 ? 1 : 0);
    this.Button_Set(this.m1, this.m2, this.m3, this.m4, this.m5, this.m6);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(2, (object) 3, (object) (this.isLunbo ? -1 : this.mMode), (object) this.m3);
  }

  private void button4_Click(object sender, EventArgs e)
  {
    this.m4 = !this.m4;
    this.mMode = (this.m1 ? 1 : 0) + (this.m2 ? 1 : 0) + (this.m3 ? 1 : 0) + (this.m4 ? 1 : 0) + (this.m5 ? 1 : 0) + (this.m6 ? 1 : 0);
    this.Button_Set(this.m1, this.m2, this.m3, this.m4, this.m5, this.m6);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(2, (object) 4, (object) (this.isLunbo ? -1 : this.mMode), (object) this.m4);
  }

  private void button5_Click(object sender, EventArgs e)
  {
    this.m5 = !this.m5;
    this.mMode = (this.m1 ? 1 : 0) + (this.m2 ? 1 : 0) + (this.m3 ? 1 : 0) + (this.m4 ? 1 : 0) + (this.m5 ? 1 : 0) + (this.m6 ? 1 : 0);
    this.Button_Set(this.m1, this.m2, this.m3, this.m4, this.m5, this.m6);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(2, (object) 5, (object) (this.isLunbo ? -1 : this.mMode), (object) this.m5);
  }

  private void button6_Click(object sender, EventArgs e)
  {
    this.m6 = !this.m6;
    this.mMode = (this.m1 ? 1 : 0) + (this.m2 ? 1 : 0) + (this.m3 ? 1 : 0) + (this.m4 ? 1 : 0) + (this.m5 ? 1 : 0) + (this.m6 ? 1 : 0);
    this.Button_Set(this.m1, this.m2, this.m3, this.m4, this.m5, this.m6);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(2, (object) 6, (object) (this.isLunbo ? -1 : this.mMode), (object) this.m6);
  }

  public void ButtonDL_Set(int mode)
  {
    this.mMode = mode;
    if (mode < 0)
    {
      this.isLunbo = true;
      this.buttonDuoXuan.BackgroundImage = (Image) Resources.P多选;
      this.buttonLunBo.BackgroundImage = (Image) Resources.P轮播a;
      this.buttonMode.BackgroundImage = (Image) Resources.P轮播a;
      this.buttonM1.Enabled = false;
      this.buttonM2.Enabled = false;
      this.buttonM3.Enabled = false;
      this.buttonM4.Enabled = false;
      this.buttonM5.Enabled = false;
      this.buttonM6.Enabled = false;
    }
    else
    {
      this.isLunbo = false;
      this.buttonDuoXuan.BackgroundImage = (Image) Resources.P多选a;
      this.buttonLunBo.BackgroundImage = (Image) Resources.P轮播;
      this.buttonMode.BackgroundImage = (Image) Resources.P多选a;
      this.buttonM1.Enabled = true;
      this.buttonM2.Enabled = true;
      this.buttonM3.Enabled = true;
      this.buttonM4.Enabled = true;
      this.buttonM5.Enabled = true;
      this.buttonM6.Enabled = true;
    }
  }

  private void buttonDuoXuan_Click(object sender, EventArgs e)
  {
    this.mMode = (this.m1 ? 1 : 0) + (this.m2 ? 1 : 0) + (this.m3 ? 1 : 0) + (this.m4 ? 1 : 0) + (this.m5 ? 1 : 0) + (this.m6 ? 1 : 0);
    this.ButtonDL_Set(this.mMode);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(2, (object) 0, (object) this.mMode);
  }

  private void buttonLunBo_Click(object sender, EventArgs e)
  {
    this.mMode = -1;
    this.buttonM1_Click((object) null, (EventArgs) null);
    this.ButtonDL_Set(this.mMode);
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(2, (object) 0, (object) this.mMode);
  }

  private void textBox_KeyPress(object sender, KeyPressEventArgs e)
  {
    if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
      return;
    e.Handled = true;
  }

  private void textBoxTimer_TextChanged(object sender, EventArgs e)
  {
    if (this.textBoxTimer.Text.Length <= 0)
      return;
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(3, (object) this.textBoxTimer.Text);
  }

  private void buttonSZZT_Click(object sender, EventArgs e)
  {
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(4);
  }

  private void labelNColor_Click(object sender, EventArgs e)
  {
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(6);
  }

  private void buttonWZZT_Click(object sender, EventArgs e)
  {
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(5);
  }

  private void labelTColor_Click(object sender, EventArgs e)
  {
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(7);
  }

  private void buttonMode_Click(object sender, EventArgs e)
  {
    if (this.isLunbo)
    {
      this.isLunbo = false;
      this.buttonDuoXuan_Click(sender, e);
    }
    else
    {
      this.isLunbo = true;
      this.buttonLunBo_Click(sender, e);
    }
  }

  private void buttonDWXS_Click(object sender, EventArgs e)
  {
    UCXiTongXinXi.delegateUCXiTongXinXi delegateUcXinxi = this.delegateUCXinxi;
    if (delegateUcXinxi == null)
      return;
    delegateUcXinxi(8);
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
    this.buttonM1 = new Button();
    this.buttonM2 = new Button();
    this.buttonM3 = new Button();
    this.buttonM4 = new Button();
    this.buttonM5 = new Button();
    this.buttonM6 = new Button();
    this.button1 = new Button();
    this.button2 = new Button();
    this.button3 = new Button();
    this.button4 = new Button();
    this.button5 = new Button();
    this.button6 = new Button();
    this.buttonDuoXuan = new Button();
    this.buttonLunBo = new Button();
    this.textBoxTimer = new TextBox();
    this.labelTSize = new Label();
    this.labelTFont = new Label();
    this.labelTColor = new Label();
    this.buttonWZZT = new Button();
    this.labelNSize = new Label();
    this.labelNFont = new Label();
    this.labelNColor = new Label();
    this.buttonSZZT = new Button();
    this.buttonMode = new Button();
    this.buttonDWXS = new Button();
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
    this.buttonOnOff.TabIndex = 613;
    this.buttonOnOff.UseVisualStyleBackColor = false;
    this.buttonOnOff.Click += new EventHandler(this.buttonOnOff_Click);
    this.buttonM1.BackColor = Color.Transparent;
    this.buttonM1.BackgroundImage = (Image) Resources.PM1a;
    this.buttonM1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonM1.FlatAppearance.BorderSize = 0;
    this.buttonM1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonM1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonM1.FlatStyle = FlatStyle.Flat;
    this.buttonM1.Location = new Point(271, 22);
    this.buttonM1.Margin = new Padding(0);
    this.buttonM1.Name = "buttonM1";
    this.buttonM1.Size = new Size(36, 24);
    this.buttonM1.TabIndex = 614;
    this.buttonM1.UseVisualStyleBackColor = false;
    this.buttonM1.Click += new EventHandler(this.buttonM1_Click);
    this.buttonM2.BackColor = Color.Transparent;
    this.buttonM2.BackgroundImage = (Image) Resources.PM2a;
    this.buttonM2.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonM2.FlatAppearance.BorderSize = 0;
    this.buttonM2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonM2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonM2.FlatStyle = FlatStyle.Flat;
    this.buttonM2.Location = new Point(331, 22);
    this.buttonM2.Margin = new Padding(0);
    this.buttonM2.Name = "buttonM2";
    this.buttonM2.Size = new Size(36, 24);
    this.buttonM2.TabIndex = 615;
    this.buttonM2.UseVisualStyleBackColor = false;
    this.buttonM2.Click += new EventHandler(this.buttonM2_Click);
    this.buttonM3.BackColor = Color.Transparent;
    this.buttonM3.BackgroundImage = (Image) Resources.PM3a;
    this.buttonM3.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonM3.FlatAppearance.BorderSize = 0;
    this.buttonM3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonM3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonM3.FlatStyle = FlatStyle.Flat;
    this.buttonM3.Location = new Point(391, 22);
    this.buttonM3.Margin = new Padding(0);
    this.buttonM3.Name = "buttonM3";
    this.buttonM3.Size = new Size(36, 24);
    this.buttonM3.TabIndex = 616;
    this.buttonM3.UseVisualStyleBackColor = false;
    this.buttonM3.Click += new EventHandler(this.buttonM3_Click);
    this.buttonM4.BackColor = Color.Transparent;
    this.buttonM4.BackgroundImage = (Image) Resources.PM4a;
    this.buttonM4.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonM4.FlatAppearance.BorderSize = 0;
    this.buttonM4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonM4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonM4.FlatStyle = FlatStyle.Flat;
    this.buttonM4.Location = new Point(271, 54);
    this.buttonM4.Margin = new Padding(0);
    this.buttonM4.Name = "buttonM4";
    this.buttonM4.Size = new Size(36, 24);
    this.buttonM4.TabIndex = 617;
    this.buttonM4.UseVisualStyleBackColor = false;
    this.buttonM4.Click += new EventHandler(this.buttonM4_Click);
    this.buttonM5.BackColor = Color.Transparent;
    this.buttonM5.BackgroundImage = (Image) Resources.PM5a;
    this.buttonM5.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonM5.FlatAppearance.BorderSize = 0;
    this.buttonM5.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonM5.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonM5.FlatStyle = FlatStyle.Flat;
    this.buttonM5.Location = new Point(331, 54);
    this.buttonM5.Margin = new Padding(0);
    this.buttonM5.Name = "buttonM5";
    this.buttonM5.Size = new Size(36, 24);
    this.buttonM5.TabIndex = 618;
    this.buttonM5.UseVisualStyleBackColor = false;
    this.buttonM5.Click += new EventHandler(this.buttonM5_Click);
    this.buttonM6.BackColor = Color.Transparent;
    this.buttonM6.BackgroundImage = (Image) Resources.PM6a;
    this.buttonM6.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonM6.FlatAppearance.BorderSize = 0;
    this.buttonM6.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonM6.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonM6.FlatStyle = FlatStyle.Flat;
    this.buttonM6.Location = new Point(391, 54);
    this.buttonM6.Margin = new Padding(0);
    this.buttonM6.Name = "buttonM6";
    this.buttonM6.Size = new Size(36, 24);
    this.buttonM6.TabIndex = 619;
    this.buttonM6.UseVisualStyleBackColor = false;
    this.buttonM6.Click += new EventHandler(this.buttonM6_Click);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P选择框Ma;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(307, 22);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(14, 24);
    this.button1.TabIndex = 620;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button2.BackColor = Color.Transparent;
    this.button2.BackgroundImage = (Image) Resources.P选择框Ma;
    this.button2.BackgroundImageLayout = ImageLayout.Stretch;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Location = new Point(367, 22);
    this.button2.Margin = new Padding(0);
    this.button2.Name = "button2";
    this.button2.Size = new Size(14, 24);
    this.button2.TabIndex = 621;
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button3.BackColor = Color.Transparent;
    this.button3.BackgroundImage = (Image) Resources.P选择框Ma;
    this.button3.BackgroundImageLayout = ImageLayout.Stretch;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Location = new Point(427, 22);
    this.button3.Margin = new Padding(0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(14, 24);
    this.button3.TabIndex = 622;
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button4.BackColor = Color.Transparent;
    this.button4.BackgroundImage = (Image) Resources.P选择框Ma;
    this.button4.BackgroundImageLayout = ImageLayout.Stretch;
    this.button4.FlatAppearance.BorderSize = 0;
    this.button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button4.FlatStyle = FlatStyle.Flat;
    this.button4.Location = new Point(307, 54);
    this.button4.Margin = new Padding(0);
    this.button4.Name = "button4";
    this.button4.Size = new Size(14, 24);
    this.button4.TabIndex = 623;
    this.button4.UseVisualStyleBackColor = false;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.button5.BackColor = Color.Transparent;
    this.button5.BackgroundImage = (Image) Resources.P选择框Ma;
    this.button5.BackgroundImageLayout = ImageLayout.Stretch;
    this.button5.FlatAppearance.BorderSize = 0;
    this.button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button5.FlatStyle = FlatStyle.Flat;
    this.button5.Location = new Point(367, 54);
    this.button5.Margin = new Padding(0);
    this.button5.Name = "button5";
    this.button5.Size = new Size(14, 24);
    this.button5.TabIndex = 624;
    this.button5.UseVisualStyleBackColor = false;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.button6.BackColor = Color.Transparent;
    this.button6.BackgroundImage = (Image) Resources.P选择框Ma;
    this.button6.BackgroundImageLayout = ImageLayout.Stretch;
    this.button6.FlatAppearance.BorderSize = 0;
    this.button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button6.FlatStyle = FlatStyle.Flat;
    this.button6.Location = new Point(427, 54);
    this.button6.Margin = new Padding(0);
    this.button6.Name = "button6";
    this.button6.Size = new Size(14, 24);
    this.button6.TabIndex = 625;
    this.button6.UseVisualStyleBackColor = false;
    this.button6.Click += new EventHandler(this.button6_Click);
    this.buttonDuoXuan.BackColor = Color.Transparent;
    this.buttonDuoXuan.BackgroundImage = (Image) Resources.P多选a;
    this.buttonDuoXuan.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDuoXuan.FlatAppearance.BorderSize = 0;
    this.buttonDuoXuan.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDuoXuan.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDuoXuan.FlatStyle = FlatStyle.Flat;
    this.buttonDuoXuan.Location = new Point(143, 117);
    this.buttonDuoXuan.Margin = new Padding(0);
    this.buttonDuoXuan.Name = "buttonDuoXuan";
    this.buttonDuoXuan.Size = new Size(50, 24);
    this.buttonDuoXuan.TabIndex = 626;
    this.buttonDuoXuan.UseVisualStyleBackColor = false;
    this.buttonDuoXuan.Visible = false;
    this.buttonDuoXuan.Click += new EventHandler(this.buttonDuoXuan_Click);
    this.buttonLunBo.BackColor = Color.Transparent;
    this.buttonLunBo.BackgroundImage = (Image) Resources.P轮播a;
    this.buttonLunBo.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonLunBo.FlatAppearance.BorderSize = 0;
    this.buttonLunBo.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonLunBo.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonLunBo.FlatStyle = FlatStyle.Flat;
    this.buttonLunBo.Location = new Point(84, 117);
    this.buttonLunBo.Margin = new Padding(0);
    this.buttonLunBo.Name = "buttonLunBo";
    this.buttonLunBo.Size = new Size(46, 24);
    this.buttonLunBo.TabIndex = 627;
    this.buttonLunBo.UseVisualStyleBackColor = false;
    this.buttonLunBo.Visible = false;
    this.buttonLunBo.Click += new EventHandler(this.buttonLunBo_Click);
    this.textBoxTimer.BackColor = Color.FromArgb(35, 34, 39);
    this.textBoxTimer.BorderStyle = BorderStyle.None;
    this.textBoxTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxTimer.ForeColor = Color.White;
    this.textBoxTimer.ImeMode = ImeMode.NoControl;
    this.textBoxTimer.Location = new Point(226, 58);
    this.textBoxTimer.MaxLength = 2;
    this.textBoxTimer.Name = "textBoxTimer";
    this.textBoxTimer.Size = new Size(18, 16 /*0x10*/);
    this.textBoxTimer.TabIndex = 628;
    this.textBoxTimer.Text = "2";
    this.textBoxTimer.TextAlign = HorizontalAlignment.Center;
    this.textBoxTimer.TextChanged += new EventHandler(this.textBoxTimer_TextChanged);
    this.textBoxTimer.KeyPress += new KeyPressEventHandler(this.textBox_KeyPress);
    this.labelTSize.BackColor = Color.Transparent;
    this.labelTSize.FlatStyle = FlatStyle.Flat;
    this.labelTSize.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelTSize.ForeColor = Color.Gray;
    this.labelTSize.Location = new Point(644, 55);
    this.labelTSize.Margin = new Padding(0);
    this.labelTSize.Name = "labelTSize";
    this.labelTSize.Size = new Size(40, 20);
    this.labelTSize.TabIndex = 667;
    this.labelTSize.Text = "9";
    this.labelTSize.TextAlign = ContentAlignment.MiddleCenter;
    this.labelTFont.BackColor = Color.Transparent;
    this.labelTFont.FlatStyle = FlatStyle.Flat;
    this.labelTFont.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelTFont.ForeColor = Color.Gray;
    this.labelTFont.Location = new Point(538, 57);
    this.labelTFont.Margin = new Padding(0);
    this.labelTFont.Name = "labelTFont";
    this.labelTFont.Size = new Size(92, 20);
    this.labelTFont.TabIndex = 666;
    this.labelTFont.Text = "微软雅黑";
    this.labelTFont.TextAlign = ContentAlignment.MiddleCenter;
    this.labelTColor.BackColor = Color.White;
    this.labelTColor.FlatStyle = FlatStyle.Flat;
    this.labelTColor.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelTColor.ForeColor = Color.Gray;
    this.labelTColor.Location = new Point(484, 56);
    this.labelTColor.Margin = new Padding(0);
    this.labelTColor.Name = "labelTColor";
    this.labelTColor.Size = new Size(20, 20);
    this.labelTColor.TabIndex = 665;
    this.labelTColor.TextAlign = ContentAlignment.MiddleLeft;
    this.labelTColor.Click += new EventHandler(this.labelTColor_Click);
    this.buttonWZZT.BackColor = Color.Transparent;
    this.buttonWZZT.BackgroundImage = (Image) Resources.P文字字体;
    this.buttonWZZT.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWZZT.FlatAppearance.BorderSize = 0;
    this.buttonWZZT.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWZZT.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWZZT.FlatStyle = FlatStyle.Flat;
    this.buttonWZZT.Location = new Point(508, 54);
    this.buttonWZZT.Margin = new Padding(0);
    this.buttonWZZT.Name = "buttonWZZT";
    this.buttonWZZT.Size = new Size(32 /*0x20*/, 24);
    this.buttonWZZT.TabIndex = 664;
    this.buttonWZZT.UseVisualStyleBackColor = false;
    this.buttonWZZT.Click += new EventHandler(this.buttonWZZT_Click);
    this.labelNSize.BackColor = Color.Transparent;
    this.labelNSize.FlatStyle = FlatStyle.Flat;
    this.labelNSize.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelNSize.ForeColor = Color.Gray;
    this.labelNSize.Location = new Point(644, 24);
    this.labelNSize.Margin = new Padding(0);
    this.labelNSize.Name = "labelNSize";
    this.labelNSize.Size = new Size(40, 20);
    this.labelNSize.TabIndex = 671;
    this.labelNSize.Text = "9";
    this.labelNSize.TextAlign = ContentAlignment.MiddleCenter;
    this.labelNFont.BackColor = Color.Transparent;
    this.labelNFont.FlatStyle = FlatStyle.Flat;
    this.labelNFont.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelNFont.ForeColor = Color.Gray;
    this.labelNFont.Location = new Point(538, 24);
    this.labelNFont.Margin = new Padding(0);
    this.labelNFont.Name = "labelNFont";
    this.labelNFont.Size = new Size(92, 20);
    this.labelNFont.TabIndex = 670;
    this.labelNFont.Text = "微软雅黑";
    this.labelNFont.TextAlign = ContentAlignment.MiddleCenter;
    this.labelNColor.BackColor = Color.White;
    this.labelNColor.FlatStyle = FlatStyle.Flat;
    this.labelNColor.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelNColor.ForeColor = Color.Gray;
    this.labelNColor.Location = new Point(484, 24);
    this.labelNColor.Margin = new Padding(0);
    this.labelNColor.Name = "labelNColor";
    this.labelNColor.Size = new Size(20, 20);
    this.labelNColor.TabIndex = 669;
    this.labelNColor.TextAlign = ContentAlignment.MiddleLeft;
    this.labelNColor.Click += new EventHandler(this.labelNColor_Click);
    this.buttonSZZT.BackColor = Color.Transparent;
    this.buttonSZZT.BackgroundImage = (Image) Resources.P数字字体;
    this.buttonSZZT.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonSZZT.FlatAppearance.BorderSize = 0;
    this.buttonSZZT.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonSZZT.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonSZZT.FlatStyle = FlatStyle.Flat;
    this.buttonSZZT.Location = new Point(508, 22);
    this.buttonSZZT.Margin = new Padding(0);
    this.buttonSZZT.Name = "buttonSZZT";
    this.buttonSZZT.Size = new Size(32 /*0x20*/, 24);
    this.buttonSZZT.TabIndex = 668;
    this.buttonSZZT.UseVisualStyleBackColor = false;
    this.buttonSZZT.Click += new EventHandler(this.buttonSZZT_Click);
    this.buttonMode.BackColor = Color.Transparent;
    this.buttonMode.BackgroundImage = (Image) Resources.P轮播a;
    this.buttonMode.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonMode.FlatAppearance.BorderSize = 0;
    this.buttonMode.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonMode.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonMode.FlatStyle = FlatStyle.Flat;
    this.buttonMode.Location = new Point(149, 54);
    this.buttonMode.Margin = new Padding(0);
    this.buttonMode.Name = "buttonMode";
    this.buttonMode.Size = new Size(46, 24);
    this.buttonMode.TabIndex = 672;
    this.buttonMode.UseVisualStyleBackColor = false;
    this.buttonMode.Click += new EventHandler(this.buttonMode_Click);
    this.buttonDWXS.BackColor = Color.Transparent;
    this.buttonDWXS.BackgroundImage = (Image) Resources.P选择框Ma;
    this.buttonDWXS.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDWXS.FlatAppearance.BorderSize = 0;
    this.buttonDWXS.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDWXS.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDWXS.FlatStyle = FlatStyle.Flat;
    this.buttonDWXS.Location = new Point(225, 22);
    this.buttonDWXS.Margin = new Padding(0);
    this.buttonDWXS.Name = "buttonDWXS";
    this.buttonDWXS.Size = new Size(14, 24);
    this.buttonDWXS.TabIndex = 673;
    this.buttonDWXS.UseVisualStyleBackColor = false;
    this.buttonDWXS.Click += new EventHandler(this.buttonDWXS_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01系统信息;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.buttonDWXS);
    this.Controls.Add((Control) this.buttonSZZT);
    this.Controls.Add((Control) this.buttonWZZT);
    this.Controls.Add((Control) this.buttonMode);
    this.Controls.Add((Control) this.labelNSize);
    this.Controls.Add((Control) this.labelNFont);
    this.Controls.Add((Control) this.labelNColor);
    this.Controls.Add((Control) this.labelTSize);
    this.Controls.Add((Control) this.labelTFont);
    this.Controls.Add((Control) this.labelTColor);
    this.Controls.Add((Control) this.textBoxTimer);
    this.Controls.Add((Control) this.buttonLunBo);
    this.Controls.Add((Control) this.buttonDuoXuan);
    this.Controls.Add((Control) this.button6);
    this.Controls.Add((Control) this.button5);
    this.Controls.Add((Control) this.button4);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.buttonM6);
    this.Controls.Add((Control) this.buttonM5);
    this.Controls.Add((Control) this.buttonM4);
    this.Controls.Add((Control) this.buttonM3);
    this.Controls.Add((Control) this.buttonM2);
    this.Controls.Add((Control) this.buttonM1);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCXiTongXinXi);
    this.Size = new Size(712, 100);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void delegateUCXiTongXinXi(int cmd, object info = null, object data = null, object data1 = null);
}

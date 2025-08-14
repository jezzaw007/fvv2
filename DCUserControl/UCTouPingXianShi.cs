// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCTouPingXianShi
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

public class UCTouPingXianShi : UserControl
{
  public UCTouPingXianShi.delegateUCTouPingXianShi delegateUCTouPing;
  private bool mySdbl = true;
  private bool isToChangedText = true;
  public bool buttonOn = true;
  public bool myYcbk = true;
  public bool is240x240 = false;
  public bool is320x320 = false;
  public bool is360x360 = false;
  public bool is480x480 = false;
  public bool is640x480 = false;
  public bool is1600x720 = false;
  public bool is1280x480 = false;
  public bool is1920x462 = false;
  public bool is854x480 = false;
  public bool is960x540 = false;
  public bool is800x480 = false;
  public bool is960x320 = false;
  private IContainer components = (IContainer) null;
  public Button buttonOnOff;
  public Button buttonXSBK;
  public TextBox textBoxX;
  public TextBox textBoxY;
  public TextBox textBoxW;
  public TextBox textBoxH;
  private Button buttonAddX;
  private Button buttonSubX;
  private Button buttonSubW;
  private Button buttonAddW;
  private Button buttonSubY;
  private Button buttonAddY;
  private Button buttonSubH;
  private Button buttonAddH;

  public UCTouPingXianShi()
  {
    this.InitializeComponent();
    this.buttonOnOff.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonXSBK.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonAddX.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonSubX.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonSubW.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonAddW.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonSubY.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonAddY.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonSubH.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonAddH.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public void TouPingXianShiBackgroundImageSet90du(bool bl)
  {
    if (bl)
    {
      switch (Form1.Language)
      {
        case 1:
          this.BackgroundImage = (Image) Resources.P01投屏显示xy;
          break;
        case 2:
          this.BackgroundImage = (Image) Resources.P01投屏显示xytc;
          break;
        case 3:
          this.BackgroundImage = (Image) Resources.P01投屏显示xyd;
          break;
        case 4:
          this.BackgroundImage = (Image) Resources.P01投屏显示xye;
          break;
        case 5:
          this.BackgroundImage = (Image) Resources.P01投屏显示xyf;
          break;
        case 6:
          this.BackgroundImage = (Image) Resources.P01投屏显示xyp;
          break;
        case 7:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxr;
          break;
        case 8:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxx;
          break;
        default:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxen;
          break;
      }
    }
    else
    {
      switch (Form1.Language)
      {
        case 1:
          this.BackgroundImage = (Image) Resources.P01投屏显示yx;
          break;
        case 2:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxtc;
          break;
        case 3:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxd;
          break;
        case 4:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxe;
          break;
        case 5:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxf;
          break;
        case 6:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxp;
          break;
        case 7:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxr;
          break;
        case 8:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxx;
          break;
        default:
          this.BackgroundImage = (Image) Resources.P01投屏显示yxen;
          break;
      }
    }
  }

  public void buttonOnOff_Set(bool bl)
  {
    this.buttonOn = bl;
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
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(0, (object) this.buttonOn);
  }

  private void buttonAddX_Click(object sender, EventArgs e)
  {
    int info = Convert.ToInt32(this.textBoxX.Text) + 1;
    if (info > 9999)
      info = 9999;
    this.textBoxX.Text = info.ToString();
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(1, (object) info);
  }

  private void buttonSubX_Click(object sender, EventArgs e)
  {
    int info = Convert.ToInt32(this.textBoxX.Text) - 1;
    if (info < 0)
      info = 0;
    this.textBoxX.Text = info.ToString();
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(1, (object) info);
  }

  private void buttonAddY_Click(object sender, EventArgs e)
  {
    int info = Convert.ToInt32(this.textBoxY.Text) + 1;
    if (info > 9999)
      info = 9999;
    this.textBoxY.Text = info.ToString();
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(2, (object) info);
  }

  private void buttonSubY_Click(object sender, EventArgs e)
  {
    int info = Convert.ToInt32(this.textBoxY.Text) - 1;
    if (info < 0)
      info = 0;
    this.textBoxY.Text = info.ToString();
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(2, (object) info);
  }

  private void buttonAddW_Click(object sender, EventArgs e)
  {
    int info = Convert.ToInt32(this.textBoxW.Text) + 1;
    if (info > 9999)
      info = 9999;
    this.textBoxW.Text = info.ToString();
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(3, (object) info);
  }

  private void buttonSubW_Click(object sender, EventArgs e)
  {
    int info = Convert.ToInt32(this.textBoxW.Text) - 1;
    if (info < 0)
      info = 0;
    this.textBoxW.Text = info.ToString();
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(3, (object) info);
  }

  private void buttonAddH_Click(object sender, EventArgs e)
  {
    int info = Convert.ToInt32(this.textBoxH.Text) + 1;
    if (info > 9999)
      info = 9999;
    this.textBoxH.Text = info.ToString();
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(4, (object) info);
  }

  private void buttonSubH_Click(object sender, EventArgs e)
  {
    int info = Convert.ToInt32(this.textBoxH.Text) - 1;
    if (info < 0)
      info = 0;
    this.textBoxH.Text = info.ToString();
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(4, (object) info);
  }

  public void buttonXSBK_Set(bool bl)
  {
    this.myYcbk = bl;
    if (bl)
      this.buttonXSBK.BackgroundImage = (Image) Resources.P显示边框A;
    else
      this.buttonXSBK.BackgroundImage = (Image) Resources.P显示边框;
  }

  private void buttonXSBK_Click(object sender, EventArgs e)
  {
    this.myYcbk = !this.myYcbk;
    this.buttonXSBK_Set(this.myYcbk);
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(5, (object) this.myYcbk);
  }

  private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
  {
    if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
      return;
    e.Handled = true;
  }

  private void textBoxX_TextChanged(object sender, EventArgs e)
  {
    if (this.textBoxX.Text.Length <= 0)
      return;
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(1, (object) Convert.ToInt32(this.textBoxX.Text));
  }

  private void textBoxY_TextChanged(object sender, EventArgs e)
  {
    if (this.textBoxY.Text.Length <= 0)
      return;
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing = this.delegateUCTouPing;
    if (delegateUcTouPing == null)
      return;
    delegateUcTouPing(2, (object) Convert.ToInt32(this.textBoxY.Text));
  }

  private void textBoxW_TextChanged(object sender, EventArgs e)
  {
    if (!this.isToChangedText || this.textBoxW.Text.Length <= 0)
      return;
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing1 = this.delegateUCTouPing;
    if (delegateUcTouPing1 != null)
      delegateUcTouPing1(3, (object) Convert.ToInt32(this.textBoxW.Text));
    if (this.mySdbl)
    {
      this.isToChangedText = false;
      int info = !this.is240x240 && !this.is320x320 && !this.is360x360 && !this.is480x480 ? (!this.is1600x720 ? (!this.is854x480 ? (!this.is960x540 ? (!this.is960x320 ? (!this.is800x480 ? (!this.is1920x462 ? (!this.is1280x480 ? (int) ((double) Convert.ToInt32(this.textBoxW.Text) / 0.75) : (int) ((double) Convert.ToInt32(this.textBoxW.Text) / 0.375)) : (int) ((double) Convert.ToInt32(this.textBoxW.Text) / (77.0 / 320.0))) : (int) ((double) Convert.ToInt32(this.textBoxW.Text) / 0.6)) : Convert.ToInt32(this.textBoxW.Text) * 3) : (int) ((double) Convert.ToInt32(this.textBoxW.Text) / (9.0 / 16.0))) : (int) ((double) Convert.ToInt32(this.textBoxW.Text) / (240.0 / 427.0))) : (int) ((double) Convert.ToInt32(this.textBoxW.Text) / 0.45)) : Convert.ToInt32(this.textBoxW.Text);
      UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing2 = this.delegateUCTouPing;
      if (delegateUcTouPing2 != null)
        delegateUcTouPing2(4, (object) info);
      this.textBoxH.Text = info.ToString();
      this.isToChangedText = true;
    }
  }

  private void textBoxH_TextChanged(object sender, EventArgs e)
  {
    if (!this.isToChangedText || this.textBoxH.Text.Length <= 0)
      return;
    UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing1 = this.delegateUCTouPing;
    if (delegateUcTouPing1 != null)
      delegateUcTouPing1(4, (object) Convert.ToInt32(this.textBoxH.Text));
    if (this.mySdbl)
    {
      this.isToChangedText = false;
      int info = !this.is240x240 && !this.is320x320 && !this.is360x360 && !this.is480x480 ? (!this.is1600x720 ? (!this.is854x480 ? (!this.is960x540 ? (!this.is960x320 ? (!this.is800x480 ? (!this.is1920x462 ? (!this.is1280x480 ? (int) ((double) Convert.ToInt32(this.textBoxH.Text) * 0.75) : (int) ((double) Convert.ToInt32(this.textBoxH.Text) * 0.375)) : (int) ((double) Convert.ToInt32(this.textBoxH.Text) * (77.0 / 320.0))) : (int) ((double) Convert.ToInt32(this.textBoxH.Text) * 0.6)) : Convert.ToInt32(this.textBoxH.Text) / 3) : (int) ((double) Convert.ToInt32(this.textBoxH.Text) * (9.0 / 16.0))) : (int) ((double) Convert.ToInt32(this.textBoxH.Text) * (240.0 / 427.0))) : (int) ((double) Convert.ToInt32(this.textBoxH.Text) * 0.45)) : Convert.ToInt32(this.textBoxW.Text);
      UCTouPingXianShi.delegateUCTouPingXianShi delegateUcTouPing2 = this.delegateUCTouPing;
      if (delegateUcTouPing2 != null)
        delegateUcTouPing2(3, (object) info);
      this.textBoxW.Text = info.ToString();
      this.isToChangedText = true;
    }
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
    this.buttonXSBK = new Button();
    this.textBoxX = new TextBox();
    this.textBoxY = new TextBox();
    this.textBoxW = new TextBox();
    this.textBoxH = new TextBox();
    this.buttonAddX = new Button();
    this.buttonSubX = new Button();
    this.buttonSubW = new Button();
    this.buttonAddW = new Button();
    this.buttonSubY = new Button();
    this.buttonAddY = new Button();
    this.buttonSubH = new Button();
    this.buttonAddH = new Button();
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
    this.buttonOnOff.TabIndex = 614;
    this.buttonOnOff.UseVisualStyleBackColor = false;
    this.buttonOnOff.Click += new EventHandler(this.buttonOnOff_Click);
    this.buttonXSBK.BackColor = Color.Transparent;
    this.buttonXSBK.BackgroundImage = (Image) Resources.P显示边框A;
    this.buttonXSBK.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXSBK.FlatAppearance.BorderSize = 0;
    this.buttonXSBK.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXSBK.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXSBK.FlatStyle = FlatStyle.Flat;
    this.buttonXSBK.Location = new Point(309, 16 /*0x10*/);
    this.buttonXSBK.Margin = new Padding(0);
    this.buttonXSBK.Name = "buttonXSBK";
    this.buttonXSBK.Size = new Size(24, 16 /*0x10*/);
    this.buttonXSBK.TabIndex = 615;
    this.buttonXSBK.UseVisualStyleBackColor = false;
    this.buttonXSBK.Click += new EventHandler(this.buttonXSBK_Click);
    this.textBoxX.BackColor = Color.Black;
    this.textBoxX.BorderStyle = BorderStyle.None;
    this.textBoxX.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxX.ForeColor = Color.FromArgb(180, 150, 83);
    this.textBoxX.ImeMode = ImeMode.NoControl;
    this.textBoxX.Location = new Point(110, 40);
    this.textBoxX.MaxLength = 4;
    this.textBoxX.Name = "textBoxX";
    this.textBoxX.Size = new Size(56, 16 /*0x10*/);
    this.textBoxX.TabIndex = 638;
    this.textBoxX.Text = "0";
    this.textBoxX.TextAlign = HorizontalAlignment.Center;
    this.textBoxX.TextChanged += new EventHandler(this.textBoxX_TextChanged);
    this.textBoxX.KeyPress += new KeyPressEventHandler(this.textBoxX_KeyPress);
    this.textBoxY.BackColor = Color.Black;
    this.textBoxY.BorderStyle = BorderStyle.None;
    this.textBoxY.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxY.ForeColor = Color.FromArgb(180, 150, 83);
    this.textBoxY.ImeMode = ImeMode.NoControl;
    this.textBoxY.Location = new Point(110, 65);
    this.textBoxY.MaxLength = 4;
    this.textBoxY.Name = "textBoxY";
    this.textBoxY.Size = new Size(56, 16 /*0x10*/);
    this.textBoxY.TabIndex = 639;
    this.textBoxY.Text = "0";
    this.textBoxY.TextAlign = HorizontalAlignment.Center;
    this.textBoxY.TextChanged += new EventHandler(this.textBoxY_TextChanged);
    this.textBoxY.KeyPress += new KeyPressEventHandler(this.textBoxX_KeyPress);
    this.textBoxW.BackColor = Color.Black;
    this.textBoxW.BorderStyle = BorderStyle.None;
    this.textBoxW.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxW.ForeColor = Color.FromArgb(180, 150, 83);
    this.textBoxW.ImeMode = ImeMode.NoControl;
    this.textBoxW.Location = new Point(241, 40);
    this.textBoxW.MaxLength = 4;
    this.textBoxW.Name = "textBoxW";
    this.textBoxW.Size = new Size(56, 16 /*0x10*/);
    this.textBoxW.TabIndex = 640;
    this.textBoxW.Text = "0";
    this.textBoxW.TextAlign = HorizontalAlignment.Center;
    this.textBoxW.TextChanged += new EventHandler(this.textBoxW_TextChanged);
    this.textBoxW.KeyPress += new KeyPressEventHandler(this.textBoxX_KeyPress);
    this.textBoxH.BackColor = Color.Black;
    this.textBoxH.BorderStyle = BorderStyle.None;
    this.textBoxH.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxH.ForeColor = Color.FromArgb(180, 150, 83);
    this.textBoxH.ImeMode = ImeMode.NoControl;
    this.textBoxH.Location = new Point(241, 65);
    this.textBoxH.MaxLength = 4;
    this.textBoxH.Name = "textBoxH";
    this.textBoxH.Size = new Size(56, 16 /*0x10*/);
    this.textBoxH.TabIndex = 641;
    this.textBoxH.Text = "0";
    this.textBoxH.TextAlign = HorizontalAlignment.Center;
    this.textBoxH.TextChanged += new EventHandler(this.textBoxH_TextChanged);
    this.textBoxH.KeyPress += new KeyPressEventHandler(this.textBoxX_KeyPress);
    this.buttonAddX.BackColor = Color.Transparent;
    this.buttonAddX.BackgroundImage = (Image) Resources.P加;
    this.buttonAddX.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonAddX.FlatAppearance.BorderSize = 0;
    this.buttonAddX.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonAddX.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonAddX.FlatStyle = FlatStyle.Flat;
    this.buttonAddX.Location = new Point(171, 42);
    this.buttonAddX.Margin = new Padding(0);
    this.buttonAddX.Name = "buttonAddX";
    this.buttonAddX.Size = new Size(14, 14);
    this.buttonAddX.TabIndex = 642;
    this.buttonAddX.UseVisualStyleBackColor = false;
    this.buttonAddX.Click += new EventHandler(this.buttonAddX_Click);
    this.buttonSubX.BackColor = Color.Transparent;
    this.buttonSubX.BackgroundImage = (Image) Resources.P减;
    this.buttonSubX.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonSubX.FlatAppearance.BorderSize = 0;
    this.buttonSubX.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonSubX.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonSubX.FlatStyle = FlatStyle.Flat;
    this.buttonSubX.Location = new Point(189, 42);
    this.buttonSubX.Margin = new Padding(0);
    this.buttonSubX.Name = "buttonSubX";
    this.buttonSubX.Size = new Size(14, 14);
    this.buttonSubX.TabIndex = 643;
    this.buttonSubX.UseVisualStyleBackColor = false;
    this.buttonSubX.Click += new EventHandler(this.buttonSubX_Click);
    this.buttonSubW.BackColor = Color.Transparent;
    this.buttonSubW.BackgroundImage = (Image) Resources.P减;
    this.buttonSubW.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonSubW.FlatAppearance.BorderSize = 0;
    this.buttonSubW.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonSubW.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonSubW.FlatStyle = FlatStyle.Flat;
    this.buttonSubW.Location = new Point(319, 42);
    this.buttonSubW.Margin = new Padding(0);
    this.buttonSubW.Name = "buttonSubW";
    this.buttonSubW.Size = new Size(14, 14);
    this.buttonSubW.TabIndex = 645;
    this.buttonSubW.UseVisualStyleBackColor = false;
    this.buttonSubW.Click += new EventHandler(this.buttonSubW_Click);
    this.buttonAddW.BackColor = Color.Transparent;
    this.buttonAddW.BackgroundImage = (Image) Resources.P加;
    this.buttonAddW.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonAddW.FlatAppearance.BorderSize = 0;
    this.buttonAddW.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonAddW.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonAddW.FlatStyle = FlatStyle.Flat;
    this.buttonAddW.Location = new Point(301, 42);
    this.buttonAddW.Margin = new Padding(0);
    this.buttonAddW.Name = "buttonAddW";
    this.buttonAddW.Size = new Size(14, 14);
    this.buttonAddW.TabIndex = 644;
    this.buttonAddW.UseVisualStyleBackColor = false;
    this.buttonAddW.Click += new EventHandler(this.buttonAddW_Click);
    this.buttonSubY.BackColor = Color.Transparent;
    this.buttonSubY.BackgroundImage = (Image) Resources.P减;
    this.buttonSubY.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonSubY.FlatAppearance.BorderSize = 0;
    this.buttonSubY.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonSubY.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonSubY.FlatStyle = FlatStyle.Flat;
    this.buttonSubY.Location = new Point(189, 67);
    this.buttonSubY.Margin = new Padding(0);
    this.buttonSubY.Name = "buttonSubY";
    this.buttonSubY.Size = new Size(14, 14);
    this.buttonSubY.TabIndex = 647;
    this.buttonSubY.UseVisualStyleBackColor = false;
    this.buttonSubY.Click += new EventHandler(this.buttonSubY_Click);
    this.buttonAddY.BackColor = Color.Transparent;
    this.buttonAddY.BackgroundImage = (Image) Resources.P加;
    this.buttonAddY.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonAddY.FlatAppearance.BorderSize = 0;
    this.buttonAddY.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonAddY.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonAddY.FlatStyle = FlatStyle.Flat;
    this.buttonAddY.Location = new Point(171, 67);
    this.buttonAddY.Margin = new Padding(0);
    this.buttonAddY.Name = "buttonAddY";
    this.buttonAddY.Size = new Size(14, 14);
    this.buttonAddY.TabIndex = 646;
    this.buttonAddY.UseVisualStyleBackColor = false;
    this.buttonAddY.Click += new EventHandler(this.buttonAddY_Click);
    this.buttonSubH.BackColor = Color.Transparent;
    this.buttonSubH.BackgroundImage = (Image) Resources.P减;
    this.buttonSubH.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonSubH.FlatAppearance.BorderSize = 0;
    this.buttonSubH.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonSubH.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonSubH.FlatStyle = FlatStyle.Flat;
    this.buttonSubH.Location = new Point(319, 67);
    this.buttonSubH.Margin = new Padding(0);
    this.buttonSubH.Name = "buttonSubH";
    this.buttonSubH.Size = new Size(14, 14);
    this.buttonSubH.TabIndex = 649;
    this.buttonSubH.UseVisualStyleBackColor = false;
    this.buttonSubH.Click += new EventHandler(this.buttonSubH_Click);
    this.buttonAddH.BackColor = Color.Transparent;
    this.buttonAddH.BackgroundImage = (Image) Resources.P加;
    this.buttonAddH.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonAddH.FlatAppearance.BorderSize = 0;
    this.buttonAddH.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonAddH.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonAddH.FlatStyle = FlatStyle.Flat;
    this.buttonAddH.Location = new Point(301, 67);
    this.buttonAddH.Margin = new Padding(0);
    this.buttonAddH.Name = "buttonAddH";
    this.buttonAddH.Size = new Size(14, 14);
    this.buttonAddH.TabIndex = 648;
    this.buttonAddH.UseVisualStyleBackColor = false;
    this.buttonAddH.Click += new EventHandler(this.buttonAddH_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01投屏显示xy;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.buttonSubH);
    this.Controls.Add((Control) this.buttonAddH);
    this.Controls.Add((Control) this.buttonSubY);
    this.Controls.Add((Control) this.buttonAddY);
    this.Controls.Add((Control) this.buttonSubW);
    this.Controls.Add((Control) this.buttonAddW);
    this.Controls.Add((Control) this.buttonSubX);
    this.Controls.Add((Control) this.buttonAddX);
    this.Controls.Add((Control) this.textBoxH);
    this.Controls.Add((Control) this.textBoxW);
    this.Controls.Add((Control) this.textBoxY);
    this.Controls.Add((Control) this.textBoxX);
    this.Controls.Add((Control) this.buttonXSBK);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCTouPingXianShi);
    this.Size = new Size(351, 100);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void delegateUCTouPingXianShi(int cmd, object info = null, object data = null, object data1 = null);
}

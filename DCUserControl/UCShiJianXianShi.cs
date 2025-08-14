// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCShiJianXianShi
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

public class UCShiJianXianShi : UserControl
{
  public UCShiJianXianShi.delegateUCShiJianXianShi delegateUCShiJian;
  private bool buttonOn = true;
  private int nyrMode = 1;
  private int sjMode = 1;
  private bool isNyr = true;
  private bool isXs = true;
  private bool isXq = true;
  private IContainer components = (IContainer) null;
  private Button buttonOnOff;
  private Button buttonNYR1;
  private Button buttonNYR2;
  private Button buttonXS1;
  private Button buttonXS2;
  private Button buttonNYR;
  private Button buttonXS;
  public Label labelNSize;
  public Label labelNFont;
  public Label labelNColor;
  private Button buttonNYRZT;
  public Label labelXSize;
  public Label labelXFont;
  public Label labelXColor;
  private Button buttonXSZT;
  private Button buttonNYR3;
  private Button buttonNYR4;
  private Button buttonXQ;
  private Button buttonXQZT;
  public Label labelXQColor;
  public Label labelXQFont;
  public Label labelXQSize;
  private Button buttonXiaoshi;
  private Button buttonRiQi;

  public UCShiJianXianShi()
  {
    this.InitializeComponent();
    this.buttonOnOff.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonNYR1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonNYR2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonXS1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonXS2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonNYRZT.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonXSZT.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

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
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(0, (object) this.buttonOn);
  }

  public void ButtonNYR_Set(int nyr)
  {
    this.nyrMode = nyr;
    switch (nyr)
    {
      case 1:
        this.buttonNYR1.BackgroundImage = (Image) Resources.P点选框A;
        this.buttonNYR2.BackgroundImage = (Image) Resources.P点选框;
        this.buttonNYR3.BackgroundImage = (Image) Resources.P点选框;
        this.buttonNYR4.BackgroundImage = (Image) Resources.P点选框;
        this.buttonRiQi.BackgroundImage = (Image) Resources.PYMD;
        break;
      case 2:
        this.buttonNYR2.BackgroundImage = (Image) Resources.P点选框A;
        this.buttonNYR1.BackgroundImage = (Image) Resources.P点选框;
        this.buttonNYR3.BackgroundImage = (Image) Resources.P点选框;
        this.buttonNYR4.BackgroundImage = (Image) Resources.P点选框;
        this.buttonRiQi.BackgroundImage = (Image) Resources.PDMY;
        break;
      case 3:
        this.buttonNYR1.BackgroundImage = (Image) Resources.P点选框;
        this.buttonNYR2.BackgroundImage = (Image) Resources.P点选框;
        this.buttonNYR3.BackgroundImage = (Image) Resources.P点选框A;
        this.buttonNYR4.BackgroundImage = (Image) Resources.P点选框;
        this.buttonRiQi.BackgroundImage = (Image) Resources.PMD;
        break;
      case 4:
        this.buttonNYR1.BackgroundImage = (Image) Resources.P点选框;
        this.buttonNYR2.BackgroundImage = (Image) Resources.P点选框;
        this.buttonNYR3.BackgroundImage = (Image) Resources.P点选框;
        this.buttonNYR4.BackgroundImage = (Image) Resources.P点选框A;
        this.buttonRiQi.BackgroundImage = (Image) Resources.PDM;
        break;
    }
  }

  private void buttonNYR1_Click(object sender, EventArgs e)
  {
    this.nyrMode = 1;
    this.ButtonNYR_Set(this.nyrMode);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(1, (object) this.nyrMode);
  }

  private void buttonNYR2_Click(object sender, EventArgs e)
  {
    this.nyrMode = 2;
    this.ButtonNYR_Set(this.nyrMode);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(1, (object) this.nyrMode);
  }

  private void buttonNYR3_Click(object sender, EventArgs e)
  {
    this.nyrMode = 3;
    this.ButtonNYR_Set(this.nyrMode);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(1, (object) this.nyrMode);
  }

  private void buttonNYR4_Click(object sender, EventArgs e)
  {
    this.nyrMode = 4;
    this.ButtonNYR_Set(this.nyrMode);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(1, (object) this.nyrMode);
  }

  public void ButtonXS_Set(int sj)
  {
    this.sjMode = sj;
    if (sj == 1)
    {
      this.buttonXS1.BackgroundImage = (Image) Resources.P点选框A;
      this.buttonXS2.BackgroundImage = (Image) Resources.P点选框;
      this.buttonXiaoshi.BackgroundImage = (Image) Resources.P12H;
    }
    else
    {
      if (sj != 2)
        return;
      this.buttonXS2.BackgroundImage = (Image) Resources.P点选框A;
      this.buttonXS1.BackgroundImage = (Image) Resources.P点选框;
      this.buttonXiaoshi.BackgroundImage = (Image) Resources.P24H;
    }
  }

  private void buttonXS1_Click(object sender, EventArgs e)
  {
    this.sjMode = 1;
    this.ButtonXS_Set(this.sjMode);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(2, (object) this.sjMode);
  }

  private void buttonXS2_Click(object sender, EventArgs e)
  {
    this.sjMode = 2;
    this.ButtonXS_Set(this.sjMode);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(2, (object) this.sjMode);
  }

  public void ButtonNYR_Set(bool bl)
  {
    this.isNyr = bl;
    if (bl)
      this.buttonNYR.BackgroundImage = (Image) Resources.P选择框Ma;
    else
      this.buttonNYR.BackgroundImage = (Image) Resources.P选择框M;
  }

  private void buttonNYR_Click(object sender, EventArgs e)
  {
    this.isNyr = !this.isNyr;
    this.ButtonNYR_Set(this.isNyr);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(3, (object) this.isNyr);
  }

  public void ButtonXS_Set(bool bl)
  {
    this.isXs = bl;
    if (bl)
      this.buttonXS.BackgroundImage = (Image) Resources.P选择框Ma;
    else
      this.buttonXS.BackgroundImage = (Image) Resources.P选择框M;
  }

  private void buttonXS_Click(object sender, EventArgs e)
  {
    this.isXs = !this.isXs;
    this.ButtonXS_Set(this.isXs);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(4, (object) this.isXs);
  }

  private void buttonNYRZT_Click(object sender, EventArgs e)
  {
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(5);
  }

  private void labelNColor_Click(object sender, EventArgs e)
  {
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(6);
  }

  private void buttonXSZT_Click(object sender, EventArgs e)
  {
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(7);
  }

  private void labelXColor_Click(object sender, EventArgs e)
  {
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(8);
  }

  public void ButtonXQ_Set(bool bl)
  {
    this.isXq = bl;
    if (bl)
      this.buttonXQ.BackgroundImage = (Image) Resources.P选择框Ma;
    else
      this.buttonXQ.BackgroundImage = (Image) Resources.P选择框M;
  }

  private void buttonXQ_Click(object sender, EventArgs e)
  {
    this.isXq = !this.isXq;
    this.ButtonXQ_Set(this.isXq);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(9, (object) this.isXq);
  }

  private void buttonXQZT_Click(object sender, EventArgs e)
  {
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(10);
  }

  private void labelXQColor_Click(object sender, EventArgs e)
  {
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(11);
  }

  private void buttonXiaoshi_Click(object sender, EventArgs e)
  {
    this.sjMode = this.sjMode != 1 ? 1 : 2;
    this.ButtonXS_Set(this.sjMode);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(2, (object) this.sjMode);
  }

  private void buttonRiQi_Click(object sender, EventArgs e)
  {
    ++this.nyrMode;
    if (this.nyrMode == 5)
      this.nyrMode = 1;
    this.ButtonNYR_Set(this.nyrMode);
    UCShiJianXianShi.delegateUCShiJianXianShi delegateUcShiJian = this.delegateUCShiJian;
    if (delegateUcShiJian == null)
      return;
    delegateUcShiJian(1, (object) this.nyrMode);
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
    this.buttonNYR1 = new Button();
    this.buttonNYR2 = new Button();
    this.buttonXS1 = new Button();
    this.buttonXS2 = new Button();
    this.buttonNYR = new Button();
    this.buttonXS = new Button();
    this.labelNSize = new Label();
    this.labelNFont = new Label();
    this.labelNColor = new Label();
    this.buttonNYRZT = new Button();
    this.labelXSize = new Label();
    this.labelXFont = new Label();
    this.labelXColor = new Label();
    this.buttonXSZT = new Button();
    this.buttonNYR3 = new Button();
    this.buttonNYR4 = new Button();
    this.buttonXQ = new Button();
    this.buttonXQZT = new Button();
    this.labelXQColor = new Label();
    this.labelXQFont = new Label();
    this.labelXQSize = new Label();
    this.buttonXiaoshi = new Button();
    this.buttonRiQi = new Button();
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
    this.buttonNYR1.BackColor = Color.Transparent;
    this.buttonNYR1.BackgroundImage = (Image) Resources.P点选框A;
    this.buttonNYR1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonNYR1.FlatAppearance.BorderSize = 0;
    this.buttonNYR1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonNYR1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonNYR1.FlatStyle = FlatStyle.Flat;
    this.buttonNYR1.Location = new Point(197, 136);
    this.buttonNYR1.Margin = new Padding(0);
    this.buttonNYR1.Name = "buttonNYR1";
    this.buttonNYR1.Size = new Size(14, 14);
    this.buttonNYR1.TabIndex = 687;
    this.buttonNYR1.UseVisualStyleBackColor = false;
    this.buttonNYR1.Visible = false;
    this.buttonNYR1.Click += new EventHandler(this.buttonNYR1_Click);
    this.buttonNYR2.BackColor = Color.Transparent;
    this.buttonNYR2.BackgroundImage = (Image) Resources.P点选框;
    this.buttonNYR2.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonNYR2.FlatAppearance.BorderSize = 0;
    this.buttonNYR2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonNYR2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonNYR2.FlatStyle = FlatStyle.Flat;
    this.buttonNYR2.Location = new Point(197, 157);
    this.buttonNYR2.Margin = new Padding(0);
    this.buttonNYR2.Name = "buttonNYR2";
    this.buttonNYR2.Size = new Size(14, 14);
    this.buttonNYR2.TabIndex = 688;
    this.buttonNYR2.UseVisualStyleBackColor = false;
    this.buttonNYR2.Visible = false;
    this.buttonNYR2.Click += new EventHandler(this.buttonNYR2_Click);
    this.buttonXS1.BackColor = Color.Transparent;
    this.buttonXS1.BackgroundImage = (Image) Resources.P点选框A;
    this.buttonXS1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXS1.FlatAppearance.BorderSize = 0;
    this.buttonXS1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXS1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXS1.FlatStyle = FlatStyle.Flat;
    this.buttonXS1.Location = new Point(197, 185);
    this.buttonXS1.Margin = new Padding(0);
    this.buttonXS1.Name = "buttonXS1";
    this.buttonXS1.Size = new Size(14, 14);
    this.buttonXS1.TabIndex = 689;
    this.buttonXS1.UseVisualStyleBackColor = false;
    this.buttonXS1.Visible = false;
    this.buttonXS1.Click += new EventHandler(this.buttonXS1_Click);
    this.buttonXS2.BackColor = Color.Transparent;
    this.buttonXS2.BackgroundImage = (Image) Resources.P点选框;
    this.buttonXS2.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXS2.FlatAppearance.BorderSize = 0;
    this.buttonXS2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXS2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXS2.FlatStyle = FlatStyle.Flat;
    this.buttonXS2.Location = new Point(287, 185);
    this.buttonXS2.Margin = new Padding(0);
    this.buttonXS2.Name = "buttonXS2";
    this.buttonXS2.Size = new Size(14, 14);
    this.buttonXS2.TabIndex = 690;
    this.buttonXS2.UseVisualStyleBackColor = false;
    this.buttonXS2.Visible = false;
    this.buttonXS2.Click += new EventHandler(this.buttonXS2_Click);
    this.buttonNYR.BackColor = Color.Transparent;
    this.buttonNYR.BackgroundImage = (Image) Resources.P选择框Ma;
    this.buttonNYR.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonNYR.FlatAppearance.BorderSize = 0;
    this.buttonNYR.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonNYR.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonNYR.FlatStyle = FlatStyle.Flat;
    this.buttonNYR.Location = new Point(427, 64 /*0x40*/);
    this.buttonNYR.Margin = new Padding(0);
    this.buttonNYR.Name = "buttonNYR";
    this.buttonNYR.Size = new Size(14, 24);
    this.buttonNYR.TabIndex = 691;
    this.buttonNYR.UseVisualStyleBackColor = false;
    this.buttonNYR.Click += new EventHandler(this.buttonNYR_Click);
    this.buttonXS.BackColor = Color.Transparent;
    this.buttonXS.BackgroundImage = (Image) Resources.P选择框Ma;
    this.buttonXS.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXS.FlatAppearance.BorderSize = 0;
    this.buttonXS.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXS.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXS.FlatStyle = FlatStyle.Flat;
    this.buttonXS.Location = new Point(427, 12);
    this.buttonXS.Margin = new Padding(0);
    this.buttonXS.Name = "buttonXS";
    this.buttonXS.Size = new Size(14, 24);
    this.buttonXS.TabIndex = 692;
    this.buttonXS.UseVisualStyleBackColor = false;
    this.buttonXS.Click += new EventHandler(this.buttonXS_Click);
    this.labelNSize.BackColor = Color.Transparent;
    this.labelNSize.FlatStyle = FlatStyle.Flat;
    this.labelNSize.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelNSize.ForeColor = Color.Gray;
    this.labelNSize.Location = new Point(650, 66);
    this.labelNSize.Margin = new Padding(0);
    this.labelNSize.Name = "labelNSize";
    this.labelNSize.Size = new Size(40, 20);
    this.labelNSize.TabIndex = 700;
    this.labelNSize.Text = "9";
    this.labelNSize.TextAlign = ContentAlignment.MiddleCenter;
    this.labelNFont.BackColor = Color.Transparent;
    this.labelNFont.FlatStyle = FlatStyle.Flat;
    this.labelNFont.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelNFont.ForeColor = Color.Gray;
    this.labelNFont.Location = new Point(543, 66);
    this.labelNFont.Margin = new Padding(0);
    this.labelNFont.Name = "labelNFont";
    this.labelNFont.Size = new Size(92, 20);
    this.labelNFont.TabIndex = 699;
    this.labelNFont.Text = "微软雅黑";
    this.labelNFont.TextAlign = ContentAlignment.MiddleCenter;
    this.labelNColor.BackColor = Color.White;
    this.labelNColor.FlatStyle = FlatStyle.Flat;
    this.labelNColor.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelNColor.ForeColor = Color.Gray;
    this.labelNColor.Location = new Point(484, 66);
    this.labelNColor.Margin = new Padding(0);
    this.labelNColor.Name = "labelNColor";
    this.labelNColor.Size = new Size(20, 20);
    this.labelNColor.TabIndex = 698;
    this.labelNColor.TextAlign = ContentAlignment.MiddleLeft;
    this.labelNColor.Click += new EventHandler(this.labelNColor_Click);
    this.buttonNYRZT.BackColor = Color.Transparent;
    this.buttonNYRZT.BackgroundImage = (Image) Resources.P文字字体;
    this.buttonNYRZT.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonNYRZT.FlatAppearance.BorderSize = 0;
    this.buttonNYRZT.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonNYRZT.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonNYRZT.FlatStyle = FlatStyle.Flat;
    this.buttonNYRZT.Location = new Point(508, 64 /*0x40*/);
    this.buttonNYRZT.Margin = new Padding(0);
    this.buttonNYRZT.Name = "buttonNYRZT";
    this.buttonNYRZT.Size = new Size(32 /*0x20*/, 24);
    this.buttonNYRZT.TabIndex = 697;
    this.buttonNYRZT.UseVisualStyleBackColor = false;
    this.buttonNYRZT.Click += new EventHandler(this.buttonNYRZT_Click);
    this.labelXSize.BackColor = Color.Transparent;
    this.labelXSize.FlatStyle = FlatStyle.Flat;
    this.labelXSize.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelXSize.ForeColor = Color.Gray;
    this.labelXSize.Location = new Point(650, 14);
    this.labelXSize.Margin = new Padding(0);
    this.labelXSize.Name = "labelXSize";
    this.labelXSize.Size = new Size(40, 20);
    this.labelXSize.TabIndex = 696;
    this.labelXSize.Text = "9";
    this.labelXSize.TextAlign = ContentAlignment.MiddleCenter;
    this.labelXFont.BackColor = Color.Transparent;
    this.labelXFont.FlatStyle = FlatStyle.Flat;
    this.labelXFont.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelXFont.ForeColor = Color.Gray;
    this.labelXFont.Location = new Point(543, 14);
    this.labelXFont.Margin = new Padding(0);
    this.labelXFont.Name = "labelXFont";
    this.labelXFont.Size = new Size(92, 20);
    this.labelXFont.TabIndex = 695;
    this.labelXFont.Text = "微软雅黑";
    this.labelXFont.TextAlign = ContentAlignment.MiddleCenter;
    this.labelXColor.BackColor = Color.White;
    this.labelXColor.FlatStyle = FlatStyle.Flat;
    this.labelXColor.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelXColor.ForeColor = Color.Gray;
    this.labelXColor.Location = new Point(484, 14);
    this.labelXColor.Margin = new Padding(0);
    this.labelXColor.Name = "labelXColor";
    this.labelXColor.Size = new Size(20, 20);
    this.labelXColor.TabIndex = 694;
    this.labelXColor.TextAlign = ContentAlignment.MiddleLeft;
    this.labelXColor.Click += new EventHandler(this.labelXColor_Click);
    this.buttonXSZT.BackColor = Color.Transparent;
    this.buttonXSZT.BackgroundImage = (Image) Resources.P文字字体;
    this.buttonXSZT.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXSZT.FlatAppearance.BorderSize = 0;
    this.buttonXSZT.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXSZT.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXSZT.FlatStyle = FlatStyle.Flat;
    this.buttonXSZT.Location = new Point(508, 12);
    this.buttonXSZT.Margin = new Padding(0);
    this.buttonXSZT.Name = "buttonXSZT";
    this.buttonXSZT.Size = new Size(32 /*0x20*/, 24);
    this.buttonXSZT.TabIndex = 693;
    this.buttonXSZT.UseVisualStyleBackColor = false;
    this.buttonXSZT.Click += new EventHandler(this.buttonXSZT_Click);
    this.buttonNYR3.BackColor = Color.Transparent;
    this.buttonNYR3.BackgroundImage = (Image) Resources.P点选框;
    this.buttonNYR3.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonNYR3.FlatAppearance.BorderSize = 0;
    this.buttonNYR3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonNYR3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonNYR3.FlatStyle = FlatStyle.Flat;
    this.buttonNYR3.Location = new Point(287, 136);
    this.buttonNYR3.Margin = new Padding(0);
    this.buttonNYR3.Name = "buttonNYR3";
    this.buttonNYR3.Size = new Size(14, 14);
    this.buttonNYR3.TabIndex = 701;
    this.buttonNYR3.UseVisualStyleBackColor = false;
    this.buttonNYR3.Visible = false;
    this.buttonNYR3.Click += new EventHandler(this.buttonNYR3_Click);
    this.buttonNYR4.BackColor = Color.Transparent;
    this.buttonNYR4.BackgroundImage = (Image) Resources.P点选框;
    this.buttonNYR4.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonNYR4.FlatAppearance.BorderSize = 0;
    this.buttonNYR4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonNYR4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonNYR4.FlatStyle = FlatStyle.Flat;
    this.buttonNYR4.Location = new Point(287, 157);
    this.buttonNYR4.Margin = new Padding(0);
    this.buttonNYR4.Name = "buttonNYR4";
    this.buttonNYR4.Size = new Size(14, 14);
    this.buttonNYR4.TabIndex = 702;
    this.buttonNYR4.UseVisualStyleBackColor = false;
    this.buttonNYR4.Visible = false;
    this.buttonNYR4.Click += new EventHandler(this.buttonNYR4_Click);
    this.buttonXQ.BackColor = Color.Transparent;
    this.buttonXQ.BackgroundImage = (Image) Resources.P选择框Ma;
    this.buttonXQ.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXQ.FlatAppearance.BorderSize = 0;
    this.buttonXQ.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXQ.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXQ.FlatStyle = FlatStyle.Flat;
    this.buttonXQ.Location = new Point(427, 38);
    this.buttonXQ.Margin = new Padding(0);
    this.buttonXQ.Name = "buttonXQ";
    this.buttonXQ.Size = new Size(14, 24);
    this.buttonXQ.TabIndex = 703;
    this.buttonXQ.UseVisualStyleBackColor = false;
    this.buttonXQ.Click += new EventHandler(this.buttonXQ_Click);
    this.buttonXQZT.BackColor = Color.Transparent;
    this.buttonXQZT.BackgroundImage = (Image) Resources.P文字字体;
    this.buttonXQZT.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXQZT.FlatAppearance.BorderSize = 0;
    this.buttonXQZT.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXQZT.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXQZT.FlatStyle = FlatStyle.Flat;
    this.buttonXQZT.Location = new Point(508, 38);
    this.buttonXQZT.Margin = new Padding(0);
    this.buttonXQZT.Name = "buttonXQZT";
    this.buttonXQZT.Size = new Size(32 /*0x20*/, 24);
    this.buttonXQZT.TabIndex = 704;
    this.buttonXQZT.UseVisualStyleBackColor = false;
    this.buttonXQZT.Click += new EventHandler(this.buttonXQZT_Click);
    this.labelXQColor.BackColor = Color.White;
    this.labelXQColor.FlatStyle = FlatStyle.Flat;
    this.labelXQColor.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelXQColor.ForeColor = Color.Gray;
    this.labelXQColor.Location = new Point(484, 40);
    this.labelXQColor.Margin = new Padding(0);
    this.labelXQColor.Name = "labelXQColor";
    this.labelXQColor.Size = new Size(20, 20);
    this.labelXQColor.TabIndex = 705;
    this.labelXQColor.TextAlign = ContentAlignment.MiddleLeft;
    this.labelXQColor.Click += new EventHandler(this.labelXQColor_Click);
    this.labelXQFont.BackColor = Color.Transparent;
    this.labelXQFont.FlatStyle = FlatStyle.Flat;
    this.labelXQFont.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelXQFont.ForeColor = Color.Gray;
    this.labelXQFont.Location = new Point(543, 41);
    this.labelXQFont.Margin = new Padding(0);
    this.labelXQFont.Name = "labelXQFont";
    this.labelXQFont.Size = new Size(92, 20);
    this.labelXQFont.TabIndex = 706;
    this.labelXQFont.Text = "微软雅黑";
    this.labelXQFont.TextAlign = ContentAlignment.MiddleCenter;
    this.labelXQSize.BackColor = Color.Transparent;
    this.labelXQSize.FlatStyle = FlatStyle.Flat;
    this.labelXQSize.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelXQSize.ForeColor = Color.Gray;
    this.labelXQSize.Location = new Point(650, 41);
    this.labelXQSize.Margin = new Padding(0);
    this.labelXQSize.Name = "labelXQSize";
    this.labelXQSize.Size = new Size(40, 20);
    this.labelXQSize.TabIndex = 707;
    this.labelXQSize.Text = "9";
    this.labelXQSize.TextAlign = ContentAlignment.MiddleCenter;
    this.buttonXiaoshi.BackColor = Color.Transparent;
    this.buttonXiaoshi.BackgroundImage = (Image) Resources.P24H;
    this.buttonXiaoshi.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonXiaoshi.FlatAppearance.BorderSize = 0;
    this.buttonXiaoshi.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonXiaoshi.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonXiaoshi.FlatStyle = FlatStyle.Flat;
    this.buttonXiaoshi.Location = new Point(337, 13);
    this.buttonXiaoshi.Margin = new Padding(0);
    this.buttonXiaoshi.Name = "buttonXiaoshi";
    this.buttonXiaoshi.Size = new Size(54, 22);
    this.buttonXiaoshi.TabIndex = 708;
    this.buttonXiaoshi.UseVisualStyleBackColor = false;
    this.buttonXiaoshi.Click += new EventHandler(this.buttonXiaoshi_Click);
    this.buttonRiQi.BackColor = Color.Transparent;
    this.buttonRiQi.BackgroundImage = (Image) Resources.PYMD;
    this.buttonRiQi.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonRiQi.FlatAppearance.BorderSize = 0;
    this.buttonRiQi.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonRiQi.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonRiQi.FlatStyle = FlatStyle.Flat;
    this.buttonRiQi.Location = new Point(337, 65);
    this.buttonRiQi.Margin = new Padding(0);
    this.buttonRiQi.Name = "buttonRiQi";
    this.buttonRiQi.Size = new Size(54, 22);
    this.buttonRiQi.TabIndex = 709;
    this.buttonRiQi.UseVisualStyleBackColor = false;
    this.buttonRiQi.Click += new EventHandler(this.buttonRiQi_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.LightGray;
    this.BackgroundImage = (Image) Resources.P01时间显示;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.buttonRiQi);
    this.Controls.Add((Control) this.buttonXiaoshi);
    this.Controls.Add((Control) this.labelXQSize);
    this.Controls.Add((Control) this.labelXQFont);
    this.Controls.Add((Control) this.labelXQColor);
    this.Controls.Add((Control) this.buttonXQZT);
    this.Controls.Add((Control) this.buttonXQ);
    this.Controls.Add((Control) this.buttonNYR4);
    this.Controls.Add((Control) this.buttonNYR3);
    this.Controls.Add((Control) this.labelNSize);
    this.Controls.Add((Control) this.labelNFont);
    this.Controls.Add((Control) this.labelNColor);
    this.Controls.Add((Control) this.buttonNYRZT);
    this.Controls.Add((Control) this.labelXSize);
    this.Controls.Add((Control) this.labelXFont);
    this.Controls.Add((Control) this.labelXColor);
    this.Controls.Add((Control) this.buttonXSZT);
    this.Controls.Add((Control) this.buttonXS);
    this.Controls.Add((Control) this.buttonNYR);
    this.Controls.Add((Control) this.buttonXS2);
    this.Controls.Add((Control) this.buttonXS1);
    this.Controls.Add((Control) this.buttonNYR2);
    this.Controls.Add((Control) this.buttonNYR1);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCShiJianXianShi);
    this.Size = new Size(712, 100);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCShiJianXianShi(int cmd, object info = null, object data = null, object data1 = null);
}

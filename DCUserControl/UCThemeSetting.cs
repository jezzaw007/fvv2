// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCThemeSetting
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCThemeSetting : UserControl
{
  public UCThemeSetting.delegateUCThemeSetting delegateUCSetting;
  private IContainer components = (IContainer) null;
  public UCBeiJingXianShi ucBeiJingXianShi1;
  public UCTouPingXianShi ucTouPingXianShi1;
  public UCDongHuaLianDong ucDongHuaLianDong1;
  public UCJianPanLianDongA ucJianPanLianDongA1;
  public UCJianPanLianDongB ucJianPanLianDongB1;
  public UCJianPanLianDongC ucJianPanLianDongC1;
  public UCMengBanXianShi ucMengBanXianShi1;
  public UCShiPingBoFangQi ucShiPingBoFangQi1;
  public UCXiTongXianShiAdd ucXiTongXianShiAdd1;
  public UCXiTongXianShi ucXiTongXianShi1;
  public UCXiTongXianShiColor ucXiTongXianShiColor1;
  private UCXiTongXianShiTable ucXiTongXianShiTable1;

  public UCThemeSetting()
  {
    this.InitializeComponent();
    this.ucTouPingXianShi1.delegateUCTouPing = new UCTouPingXianShi.delegateUCTouPingXianShi(this.TouPingXianShi);
    this.ucBeiJingXianShi1.delegateUCBeiJing = new UCBeiJingXianShi.delegateUCBeiJingXianShi(this.BeiJingXianShi);
    this.ucMengBanXianShi1.delegateUCMengBan = new UCMengBanXianShi.delegateUCMengBanXianShi(this.MengBanXianShi);
    this.ucShiPingBoFangQi1.delegateUCShiPing = new UCShiPingBoFangQi.delegateUCShiPingBoFangQi(this.ShiPingBoFangQi);
    this.ucXiTongXianShiAdd1.delegateAdd = new UCXiTongXianShiAdd.delegateXiTongXianShiAdd(this.XiTongXianShiAdd);
    this.ucXiTongXianShi1.delegateXiTong = new UCXiTongXianShi.delegateXiTongXianShi(this.XiTongXianShi);
    this.ucXiTongXianShiColor1.ucdelegateColor = new UCXiTongXianShiColor.delegateUCXiTongXianShiColor(this.XianShiColor);
    this.ucXiTongXianShiTable1.delegateXiTongTable = new UCXiTongXianShiTable.delegateXiTongXianShiTable(this.XiTongTable);
  }

  private void XiTongTable(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 0:
      case 1:
      case 2:
      case 3:
        this.ucXiTongXianShi1.SetXiTongNowSub((int) info);
        break;
      case 4:
        this.ucXiTongXianShi1.SetXiTongNowSub((int) info, (string) data);
        break;
    }
  }

  private void XianShiColor(int mode, int r, int g, int b, Font font)
  {
    switch (mode)
    {
      case 1:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting = this.delegateUCSetting;
        if (delegateUcSetting == null)
          break;
        delegateUcSetting(112 /*0x70*/);
        break;
      case 2:
        this.ucXiTongXianShi1.UCXiTongXianShiSetOneColor(r, g, b);
        break;
      case 3:
        this.ucXiTongXianShi1.UCXiTongXianShiSetOneXY(r, g);
        break;
      case 4:
        this.ucXiTongXianShi1.UCXiTongXianShiSetOneFont(font);
        break;
    }
  }

  private void XiTongXianShi(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 0:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting1 = this.delegateUCSetting;
        if (delegateUcSetting1 == null)
          break;
        delegateUcSetting1(128 /*0x80*/, info);
        break;
      case 1:
        this.ucXiTongXianShiColor1.Hide();
        this.ucXiTongXianShiTable1.Hide();
        this.ucXiTongXianShiAdd1.Show();
        break;
      case 3:
        this.ucXiTongXianShiAdd1.Hide();
        this.ucXiTongXianShiColor1.Show();
        this.ucXiTongXianShiTable1.Show();
        switch ((int) info)
        {
          case 0:
            this.ucXiTongXianShiTable1.UCXiTongXianShiTable0(0, (int) data);
            break;
          case 1:
            this.ucXiTongXianShiTable1.UCXiTongXianShiTable1(1, (int) data);
            break;
          case 2:
            this.ucXiTongXianShiTable1.UCXiTongXianShiTable2(2, (int) data);
            break;
          case 3:
            this.ucXiTongXianShiTable1.UCXiTongXianShiTable3(3, (int) data);
            break;
          case 4:
            this.ucXiTongXianShiTable1.UCXiTongXianShiTable4(4, (int) data);
            this.ucXiTongXianShiTable1.textBox1.Text = (string) ((ArrayList) data1)[4];
            break;
        }
        this.ucXiTongXianShiColor1.UCXiTongXianShiBackupColorSave();
        this.ucXiTongXianShiColor1.UCXiTongXianShiColorSet((ArrayList) data1);
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting2 = this.delegateUCSetting;
        if (delegateUcSetting2 == null)
          break;
        delegateUcSetting2(129, ((ArrayList) data1)[5]);
        break;
      case 4:
        this.ucXiTongXianShiColor1.ChangedTextBoxXY((int) data, (int) data1);
        break;
    }
  }

  private void XiTongXianShiAdd(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 16 /*0x10*/:
        this.ucXiTongXianShi1.UCXiTongXianShiAdd(0, main: (int) info, sub: (int) data);
        break;
      case 32 /*0x20*/:
        this.ucXiTongXianShi1.UCXiTongXianShiAdd(1);
        break;
      case 48 /*0x30*/:
        this.ucXiTongXianShi1.UCXiTongXianShiAdd(2);
        break;
      case 64 /*0x40*/:
        this.ucXiTongXianShi1.UCXiTongXianShiAdd(3);
        break;
      case 80 /*0x50*/:
        this.ucXiTongXianShi1.UCXiTongXianShiAdd(4);
        break;
    }
    this.ucXiTongXianShiColor1.Show();
    this.ucXiTongXianShiTable1.Show();
  }

  private void MengBanXianShi(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 0:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting1 = this.delegateUCSetting;
        if (delegateUcSetting1 == null)
          break;
        delegateUcSetting1(96 /*0x60*/, info);
        break;
      case 1:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting2 = this.delegateUCSetting;
        if (delegateUcSetting2 == null)
          break;
        delegateUcSetting2(97);
        break;
      case 3:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting3 = this.delegateUCSetting;
        if (delegateUcSetting3 != null)
          delegateUcSetting3(99);
        break;
    }
  }

  private void BeiJingXianShi(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 0:
        this.ucTouPingXianShi1.buttonOnOff_Set(false);
        this.ucShiPingBoFangQi1.buttonOnOff_Set(false);
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting1 = this.delegateUCSetting;
        if (delegateUcSetting1 == null)
          break;
        delegateUcSetting1(1, info);
        break;
      case 1:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting2 = this.delegateUCSetting;
        if (delegateUcSetting2 == null)
          break;
        delegateUcSetting2(49);
        break;
      case 2:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting3 = this.delegateUCSetting;
        if (delegateUcSetting3 == null)
          break;
        delegateUcSetting3(50);
        break;
      case 3:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting4 = this.delegateUCSetting;
        if (delegateUcSetting4 == null)
          break;
        delegateUcSetting4(51);
        break;
      case 4:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting5 = this.delegateUCSetting;
        if (delegateUcSetting5 != null)
          delegateUcSetting5(52);
        break;
    }
  }

  private void TouPingXianShi(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 0:
        this.ucBeiJingXianShi1.buttonOnOff_Set(false);
        this.ucShiPingBoFangQi1.buttonOnOff_Set(false);
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting1 = this.delegateUCSetting;
        if (delegateUcSetting1 == null)
          break;
        delegateUcSetting1(2, info);
        break;
      case 1:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting2 = this.delegateUCSetting;
        if (delegateUcSetting2 == null)
          break;
        delegateUcSetting2(65, info);
        break;
      case 2:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting3 = this.delegateUCSetting;
        if (delegateUcSetting3 == null)
          break;
        delegateUcSetting3(66, info);
        break;
      case 3:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting4 = this.delegateUCSetting;
        if (delegateUcSetting4 == null)
          break;
        delegateUcSetting4(67, info);
        break;
      case 4:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting5 = this.delegateUCSetting;
        if (delegateUcSetting5 == null)
          break;
        delegateUcSetting5(68, info);
        break;
      case 5:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting6 = this.delegateUCSetting;
        if (delegateUcSetting6 != null)
          delegateUcSetting6(69, info);
        break;
    }
  }

  private void ShiPingBoFangQi(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 0:
        this.ucBeiJingXianShi1.buttonOnOff_Set(false);
        this.ucTouPingXianShi1.buttonOnOff_Set(false);
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting1 = this.delegateUCSetting;
        if (delegateUcSetting1 == null)
          break;
        delegateUcSetting1(3, info);
        break;
      case 1:
        UCThemeSetting.delegateUCThemeSetting delegateUcSetting2 = this.delegateUCSetting;
        if (delegateUcSetting2 != null)
          delegateUcSetting2(10);
        break;
    }
  }

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams = base.CreateParams;
      createParams.ExStyle |= 33554432 /*0x02000000*/;
      return createParams;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UCThemeSetting));
    this.ucXiTongXianShiColor1 = new UCXiTongXianShiColor();
    this.ucXiTongXianShi1 = new UCXiTongXianShi();
    this.ucXiTongXianShiAdd1 = new UCXiTongXianShiAdd();
    this.ucShiPingBoFangQi1 = new UCShiPingBoFangQi();
    this.ucBeiJingXianShi1 = new UCBeiJingXianShi();
    this.ucMengBanXianShi1 = new UCMengBanXianShi();
    this.ucJianPanLianDongC1 = new UCJianPanLianDongC();
    this.ucJianPanLianDongB1 = new UCJianPanLianDongB();
    this.ucJianPanLianDongA1 = new UCJianPanLianDongA();
    this.ucDongHuaLianDong1 = new UCDongHuaLianDong();
    this.ucTouPingXianShi1 = new UCTouPingXianShi();
    this.ucXiTongXianShiTable1 = new UCXiTongXianShiTable();
    this.SuspendLayout();
    this.ucXiTongXianShiColor1.BackColor = Color.Transparent;
    this.ucXiTongXianShiColor1.BackgroundImage = (Image) componentResourceManager.GetObject("ucXiTongXianShiColor1.BackgroundImage");
    this.ucXiTongXianShiColor1.BackgroundImageLayout = ImageLayout.None;
    this.ucXiTongXianShiColor1.Location = new Point(492, 1);
    this.ucXiTongXianShiColor1.Margin = new Padding(0);
    this.ucXiTongXianShiColor1.Name = "ucXiTongXianShiColor1";
    this.ucXiTongXianShiColor1.Size = new Size(230, 374);
    this.ucXiTongXianShiColor1.TabIndex = 12;
    this.ucXiTongXianShi1.BackColor = Color.Transparent;
    this.ucXiTongXianShi1.BackgroundImage = (Image) componentResourceManager.GetObject("ucXiTongXianShi1.BackgroundImage");
    this.ucXiTongXianShi1.BackgroundImageLayout = ImageLayout.None;
    this.ucXiTongXianShi1.Location = new Point(10, 1);
    this.ucXiTongXianShi1.Margin = new Padding(0);
    this.ucXiTongXianShi1.Name = "ucXiTongXianShi1";
    this.ucXiTongXianShi1.Size = new Size(472, 430);
    this.ucXiTongXianShi1.TabIndex = 0;
    this.ucXiTongXianShiAdd1.BackColor = Color.Transparent;
    this.ucXiTongXianShiAdd1.BackgroundImage = (Image) componentResourceManager.GetObject("ucXiTongXianShiAdd1.BackgroundImage");
    this.ucXiTongXianShiAdd1.BackgroundImageLayout = ImageLayout.None;
    this.ucXiTongXianShiAdd1.Location = new Point(492, 1);
    this.ucXiTongXianShiAdd1.Margin = new Padding(0);
    this.ucXiTongXianShiAdd1.Name = "ucXiTongXianShiAdd1";
    this.ucXiTongXianShiAdd1.Size = new Size(230, 430);
    this.ucXiTongXianShiAdd1.TabIndex = 11;
    this.ucXiTongXianShiAdd1.Visible = false;
    this.ucShiPingBoFangQi1.BackColor = Color.Transparent;
    this.ucShiPingBoFangQi1.BackgroundImage = (Image) Resources.P01播放器;
    this.ucShiPingBoFangQi1.BackgroundImageLayout = ImageLayout.None;
    this.ucShiPingBoFangQi1.Location = new Point(371, 551);
    this.ucShiPingBoFangQi1.Margin = new Padding(0);
    this.ucShiPingBoFangQi1.Name = "ucShiPingBoFangQi1";
    this.ucShiPingBoFangQi1.Size = new Size(351, 100);
    this.ucShiPingBoFangQi1.TabIndex = 10;
    this.ucBeiJingXianShi1.BackColor = Color.Transparent;
    this.ucBeiJingXianShi1.BackgroundImage = (Image) Resources.P01背景显示;
    this.ucBeiJingXianShi1.BackgroundImageLayout = ImageLayout.None;
    this.ucBeiJingXianShi1.Location = new Point(371, 441);
    this.ucBeiJingXianShi1.Margin = new Padding(0);
    this.ucBeiJingXianShi1.Name = "ucBeiJingXianShi1";
    this.ucBeiJingXianShi1.Size = new Size(351, 100);
    this.ucBeiJingXianShi1.TabIndex = 2;
    this.ucMengBanXianShi1.BackColor = Color.Transparent;
    this.ucMengBanXianShi1.BackgroundImage = (Image) Resources.P01布局蒙板;
    this.ucMengBanXianShi1.BackgroundImageLayout = ImageLayout.None;
    this.ucMengBanXianShi1.Location = new Point(10, 441);
    this.ucMengBanXianShi1.Margin = new Padding(0);
    this.ucMengBanXianShi1.Name = "ucMengBanXianShi1";
    this.ucMengBanXianShi1.Size = new Size(351, 100);
    this.ucMengBanXianShi1.TabIndex = 8;
    this.ucJianPanLianDongC1.BackColor = Color.Transparent;
    this.ucJianPanLianDongC1.BackgroundImage = (Image) Resources.P01键盘联动3;
    this.ucJianPanLianDongC1.Location = new Point(10, 960);
    this.ucJianPanLianDongC1.Margin = new Padding(0);
    this.ucJianPanLianDongC1.Name = "ucJianPanLianDongC1";
    this.ucJianPanLianDongC1.Size = new Size(682, 84);
    this.ucJianPanLianDongC1.TabIndex = 7;
    this.ucJianPanLianDongC1.Visible = false;
    this.ucJianPanLianDongB1.BackColor = Color.Transparent;
    this.ucJianPanLianDongB1.BackgroundImage = (Image) Resources.P01键盘联动2;
    this.ucJianPanLianDongB1.Location = new Point(10, 870);
    this.ucJianPanLianDongB1.Margin = new Padding(0);
    this.ucJianPanLianDongB1.Name = "ucJianPanLianDongB1";
    this.ucJianPanLianDongB1.Size = new Size(682, 84);
    this.ucJianPanLianDongB1.TabIndex = 6;
    this.ucJianPanLianDongB1.Visible = false;
    this.ucJianPanLianDongA1.BackColor = Color.Transparent;
    this.ucJianPanLianDongA1.BackgroundImage = (Image) Resources.P01键盘联动1;
    this.ucJianPanLianDongA1.Location = new Point(10, 780);
    this.ucJianPanLianDongA1.Margin = new Padding(0);
    this.ucJianPanLianDongA1.Name = "ucJianPanLianDongA1";
    this.ucJianPanLianDongA1.Size = new Size(682, 84);
    this.ucJianPanLianDongA1.TabIndex = 5;
    this.ucJianPanLianDongA1.Visible = false;
    this.ucDongHuaLianDong1.BackColor = Color.Transparent;
    this.ucDongHuaLianDong1.BackgroundImage = (Image) Resources.P01动画联动;
    this.ucDongHuaLianDong1.Location = new Point(10, 690);
    this.ucDongHuaLianDong1.Margin = new Padding(0);
    this.ucDongHuaLianDong1.Name = "ucDongHuaLianDong1";
    this.ucDongHuaLianDong1.Size = new Size(682, 84);
    this.ucDongHuaLianDong1.TabIndex = 4;
    this.ucDongHuaLianDong1.Visible = false;
    this.ucTouPingXianShi1.BackColor = Color.Transparent;
    this.ucTouPingXianShi1.BackgroundImage = (Image) Resources.P01投屏显示xy;
    this.ucTouPingXianShi1.BackgroundImageLayout = ImageLayout.None;
    this.ucTouPingXianShi1.Location = new Point(10, 551);
    this.ucTouPingXianShi1.Margin = new Padding(0);
    this.ucTouPingXianShi1.Name = "ucTouPingXianShi1";
    this.ucTouPingXianShi1.Size = new Size(351, 100);
    this.ucTouPingXianShi1.TabIndex = 3;
    this.ucXiTongXianShiTable1.BackColor = Color.Transparent;
    this.ucXiTongXianShiTable1.BackgroundImage = (Image) componentResourceManager.GetObject("ucXiTongXianShiTable1.BackgroundImage");
    this.ucXiTongXianShiTable1.BackgroundImageLayout = ImageLayout.None;
    this.ucXiTongXianShiTable1.Location = new Point(492, 376);
    this.ucXiTongXianShiTable1.Margin = new Padding(0);
    this.ucXiTongXianShiTable1.Name = "ucXiTongXianShiTable1";
    this.ucXiTongXianShiTable1.Size = new Size(230, 54);
    this.ucXiTongXianShiTable1.TabIndex = 13;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P0主题设置;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.ucXiTongXianShiTable1);
    this.Controls.Add((Control) this.ucXiTongXianShiColor1);
    this.Controls.Add((Control) this.ucXiTongXianShi1);
    this.Controls.Add((Control) this.ucXiTongXianShiAdd1);
    this.Controls.Add((Control) this.ucShiPingBoFangQi1);
    this.Controls.Add((Control) this.ucBeiJingXianShi1);
    this.Controls.Add((Control) this.ucMengBanXianShi1);
    this.Controls.Add((Control) this.ucJianPanLianDongC1);
    this.Controls.Add((Control) this.ucJianPanLianDongB1);
    this.Controls.Add((Control) this.ucJianPanLianDongA1);
    this.Controls.Add((Control) this.ucDongHuaLianDong1);
    this.Controls.Add((Control) this.ucTouPingXianShi1);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCThemeSetting);
    this.Size = new Size(732, 661);
    this.ResumeLayout(false);
  }

  public delegate void delegateUCThemeSetting(int cmd, object info = null, object data = null, object data1 = null);
}

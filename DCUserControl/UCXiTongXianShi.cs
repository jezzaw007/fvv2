// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCXiTongXianShi
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCXiTongXianShi : UserControl
{
  public UCXiTongXianShi.delegateXiTongXianShi delegateXiTong;
  private bool buttonOn = true;
  private int nowCount = -1;
  public ArrayList UCXiTongXianShiSubArray;
  private const int startX = 5;
  private const int startY = 35;
  private const int addX = 67;
  private const int addY = 66;
  public bool isFanLcd = false;
  public int fanLcdVal = 0;
  private IContainer components = (IContainer) null;
  private Button buttonOnOff;
  private Button buttonAdd;

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams = base.CreateParams;
      createParams.ExStyle |= 33554432 /*0x02000000*/;
      return createParams;
    }
  }

  public UCXiTongXianShi()
  {
    this.InitializeComponent();
    this.buttonOnOff.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.UCXiTongXianShiSubArray = new ArrayList();
  }

  public void UCXiTongXianShiSetOneFont(Font font)
  {
    if (this.nowCount == -1)
      return;
    try
    {
      ((UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[this.nowCount]).FontSet(font);
    }
    catch
    {
    }
  }

  public void UCXiTongXianShiSetOneXY(int x, int y)
  {
    if (this.nowCount == -1)
      return;
    try
    {
      ((UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[this.nowCount]).XYSet(x, y);
    }
    catch
    {
    }
  }

  public void UCXiTongXianShiSetOneColor(int r, int g, int b)
  {
    if (this.nowCount == -1)
      return;
    try
    {
      ((UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[this.nowCount]).ColorSet(Color.FromArgb(r, g, b));
    }
    catch
    {
    }
  }

  public void UCXiTongXianShiSet_UCXiTongXianShiSubArray(ArrayList arrayList)
  {
    for (int index = this.UCXiTongXianShiSubArray.Count - 1; index >= 0; --index)
    {
      UCXiTongXianShiSub xiTongXianShiSub = (UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[index];
      this.Controls.Remove((Control) xiTongXianShiSub);
      this.UCXiTongXianShiSubArray.Remove((object) xiTongXianShiSub);
      xiTongXianShiSub.Dispose();
    }
    for (int index = 0; index < arrayList.Count; ++index)
    {
      ArrayList array = (ArrayList) arrayList[index];
      UCXiTongXianShiSub xiTongXianShiSub = new UCXiTongXianShiSub();
      xiTongXianShiSub.myMode = (int) array[0];
      xiTongXianShiSub.myModeSub = (int) array[1];
      xiTongXianShiSub.myX = (int) array[2] > 1920 ? 1920 : (int) array[2];
      xiTongXianShiSub.myY = (int) array[3] > 1920 ? 1920 : (int) array[3];
      xiTongXianShiSub.myMainCount = (int) array[4];
      xiTongXianShiSub.mySubCount = (int) array[5];
      xiTongXianShiSub.myColor = (Color) array[6];
      xiTongXianShiSub.myFont = (Font) array[7];
      xiTongXianShiSub.myText = (string) array[8];
      xiTongXianShiSub.Left = 5 + index % 7 * 67;
      xiTongXianShiSub.Top = 35 + index / 7 * 66;
      this.UCXiTongXianShiSubArray.Add((object) xiTongXianShiSub);
      this.Controls.Add((Control) xiTongXianShiSub);
      xiTongXianShiSub.InitUCXiTongXianShiSub();
      xiTongXianShiSub.Show();
      xiTongXianShiSub.delegateXiTongSub = new UCXiTongXianShiSub.delegateXiTongXianShiSub(this.XiTongXianShiSub);
    }
    if (arrayList.Count < 42)
    {
      this.buttonAdd.Left = 5 + arrayList.Count % 7 * 67;
      this.buttonAdd.Top = 35 + arrayList.Count / 7 * 66;
      this.buttonAdd.Show();
    }
    else
      this.buttonAdd.Hide();
  }

  public void UCXiTongXianShiAdd(int mode, int subMode = 1, int main = 0, int sub = 1)
  {
    UCXiTongXianShiSub xiTongXianShiSub = new UCXiTongXianShiSub();
    xiTongXianShiSub.myMode = mode;
    xiTongXianShiSub.myModeSub = subMode;
    xiTongXianShiSub.myMainCount = main;
    xiTongXianShiSub.mySubCount = sub;
    xiTongXianShiSub.Left = 5 + this.UCXiTongXianShiSubArray.Count % 7 * 67;
    xiTongXianShiSub.Top = 35 + this.UCXiTongXianShiSubArray.Count / 7 * 66;
    this.UCXiTongXianShiSubArray.Add((object) xiTongXianShiSub);
    this.Controls.Add((Control) xiTongXianShiSub);
    xiTongXianShiSub.InitUCXiTongXianShiSub();
    xiTongXianShiSub.isSelect = true;
    xiTongXianShiSub.Show();
    xiTongXianShiSub.delegateXiTongSub = new UCXiTongXianShiSub.delegateXiTongXianShiSub(this.XiTongXianShiSub);
    if (this.UCXiTongXianShiSubArray.Count < 42)
    {
      this.buttonAdd.Left = 5 + this.UCXiTongXianShiSubArray.Count % 7 * 67;
      this.buttonAdd.Top = 35 + this.UCXiTongXianShiSubArray.Count / 7 * 66;
      this.buttonAdd.Show();
    }
    else
      this.buttonAdd.Hide();
    this.nowCount = this.UCXiTongXianShiSubArray.Count - 1;
    ArrayList data1 = new ArrayList()
    {
      (object) xiTongXianShiSub.myX,
      (object) xiTongXianShiSub.myY,
      (object) xiTongXianShiSub.myColor,
      (object) xiTongXianShiSub.myFont,
      (object) xiTongXianShiSub.myText,
      (object) this.nowCount
    };
    UCXiTongXianShi.delegateXiTongXianShi delegateXiTong = this.delegateXiTong;
    if (delegateXiTong != null)
      delegateXiTong(3, (object) xiTongXianShiSub.myMode, (object) xiTongXianShiSub.myModeSub, (object) data1);
    data1.Clear();
    for (int index = 0; index < this.UCXiTongXianShiSubArray.Count - 1; ++index)
    {
      ((UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[index]).isSelect = false;
      ((Control) this.UCXiTongXianShiSubArray[index]).Invalidate();
    }
  }

  public void UCXiTongXianShiSelect(int count)
  {
    this.nowCount = count;
    for (int index = 0; index < this.UCXiTongXianShiSubArray.Count; ++index)
    {
      if (index == this.nowCount)
      {
        ((UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[this.nowCount]).isSelect = true;
        ((Control) this.UCXiTongXianShiSubArray[this.nowCount]).Invalidate();
      }
      else
      {
        ((UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[index]).isSelect = false;
        ((Control) this.UCXiTongXianShiSubArray[index]).Invalidate();
      }
    }
    if (this.nowCount < 0)
      return;
    UCXiTongXianShiSub xiTongXianShiSub = (UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[this.nowCount];
    ArrayList data1 = new ArrayList()
    {
      (object) xiTongXianShiSub.myX,
      (object) xiTongXianShiSub.myY,
      (object) xiTongXianShiSub.myColor,
      (object) xiTongXianShiSub.myFont,
      (object) xiTongXianShiSub.myText,
      (object) this.nowCount
    };
    UCXiTongXianShi.delegateXiTongXianShi delegateXiTong = this.delegateXiTong;
    if (delegateXiTong != null)
      delegateXiTong(3, (object) xiTongXianShiSub.myMode, (object) xiTongXianShiSub.myModeSub, (object) data1);
    data1.Clear();
  }

  private void XiTongXianShiSub(int cmd, object info, object data, object data1)
  {
    switch (cmd)
    {
      case 1:
        for (int index = 0; index < this.UCXiTongXianShiSubArray.Count; ++index)
        {
          if (info == this.UCXiTongXianShiSubArray[index])
          {
            ((UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[index]).isSelect = true;
            this.nowCount = index;
          }
          else
            ((UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[index]).isSelect = false;
          ((Control) this.UCXiTongXianShiSubArray[index]).Invalidate();
        }
        ArrayList data1_1 = new ArrayList()
        {
          (object) ((UCXiTongXianShiSub) info).myX,
          (object) ((UCXiTongXianShiSub) info).myY,
          (object) ((UCXiTongXianShiSub) info).myColor,
          (object) ((UCXiTongXianShiSub) info).myFont,
          (object) ((UCXiTongXianShiSub) info).myText,
          (object) this.nowCount
        };
        UCXiTongXianShi.delegateXiTongXianShi delegateXiTong1 = this.delegateXiTong;
        if (delegateXiTong1 != null)
          delegateXiTong1(3, (object) ((UCXiTongXianShiSub) info).myMode, (object) ((UCXiTongXianShiSub) info).myModeSub, (object) data1_1);
        data1_1.Clear();
        break;
      case 2:
        for (int index = 0; index < this.UCXiTongXianShiSubArray.Count; ++index)
        {
          if (info == this.UCXiTongXianShiSubArray[index])
          {
            this.Controls.Remove((Control) info);
            this.UCXiTongXianShiSubArray.Remove(info);
            ((Component) info).Dispose();
            break;
          }
        }
        for (int index = 0; index < this.UCXiTongXianShiSubArray.Count; ++index)
        {
          UCXiTongXianShiSub xiTongXianShiSub = (UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[index];
          xiTongXianShiSub.Left = 5 + index % 7 * 67;
          xiTongXianShiSub.Top = 35 + index / 7 * 66;
          if (index == 0)
          {
            this.nowCount = -1;
            xiTongXianShiSub.Invalidate();
          }
        }
        this.buttonAdd.Left = 5 + this.UCXiTongXianShiSubArray.Count % 7 * 67;
        this.buttonAdd.Top = 35 + this.UCXiTongXianShiSubArray.Count / 7 * 66;
        this.buttonAdd.Show();
        UCXiTongXianShi.delegateXiTongXianShi delegateXiTong2 = this.delegateXiTong;
        if (delegateXiTong2 == null)
          break;
        delegateXiTong2(2);
        break;
      case 3:
        UCXiTongXianShi.delegateXiTongXianShi delegateXiTong3 = this.delegateXiTong;
        if (delegateXiTong3 == null)
          break;
        delegateXiTong3(4, info, data, data1);
        break;
    }
  }

  public void UCXiTongXianShiTimer()
  {
    for (int index = 0; index < this.UCXiTongXianShiSubArray.Count; ++index)
    {
      UCXiTongXianShiSub xiTongXianShiSub = (UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[index];
      try
      {
        if (this.isFanLcd)
          xiTongXianShiSub.UCXiTongXianShiSubTimer(this.fanLcdVal.ToString(), "RPM");
        else
          xiTongXianShiSub.UCXiTongXianShiSubTimer();
      }
      catch
      {
      }
    }
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
    UCXiTongXianShi.delegateXiTongXianShi delegateXiTong = this.delegateXiTong;
    if (delegateXiTong == null)
      return;
    delegateXiTong(0, (object) this.buttonOn);
  }

  private void buttonAdd_Click(object sender, EventArgs e)
  {
    UCXiTongXianShi.delegateXiTongXianShi delegateXiTong = this.delegateXiTong;
    if (delegateXiTong == null)
      return;
    delegateXiTong(1);
  }

  public void SetXiTongNowSub(int sub, string str = "")
  {
    if (this.nowCount == -1)
      return;
    try
    {
      UCXiTongXianShiSub xiTongXianShiSub = (UCXiTongXianShiSub) this.UCXiTongXianShiSubArray[this.nowCount];
      xiTongXianShiSub.myModeSub = sub;
      xiTongXianShiSub.myText = str;
    }
    catch
    {
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
    this.buttonAdd = new Button();
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
    this.buttonOnOff.TabIndex = 615;
    this.buttonOnOff.UseVisualStyleBackColor = false;
    this.buttonOnOff.Click += new EventHandler(this.buttonOnOff_Click);
    this.buttonAdd.BackColor = Color.Transparent;
    this.buttonAdd.BackgroundImage = (Image) Resources.P增加内容;
    this.buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonAdd.FlatAppearance.BorderSize = 0;
    this.buttonAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonAdd.FlatStyle = FlatStyle.Flat;
    this.buttonAdd.Location = new Point(5, 35);
    this.buttonAdd.Margin = new Padding(0);
    this.buttonAdd.Name = "buttonAdd";
    this.buttonAdd.Size = new Size(60, 60);
    this.buttonAdd.TabIndex = 616;
    this.buttonAdd.UseVisualStyleBackColor = false;
    this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01内容;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.buttonAdd);
    this.Controls.Add((Control) this.buttonOnOff);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCXiTongXianShi);
    this.Size = new Size(472, 430);
    this.ResumeLayout(false);
  }

  public delegate void delegateXiTongXianShi(int cmd, object info = null, object data = null, object data1 = null);
}

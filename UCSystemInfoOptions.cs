// Decompiled with JetBrains decompiler
// Type: TRCC.UCSystemInfoOptions
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TRCC.DCUserControl;
using TRCC.Properties;

#nullable disable
namespace TRCC;

public class UCSystemInfoOptions : UserControl
{
  private const string fileSetting = "Data\\config";
  private const int startX = 44;
  private const int startY = 36;
  private const int addX = 300;
  private const int addY = 199;
  private bool myTextChengeEn = false;
  private int oneCount = 0;
  private int oneCountSub = 0;
  private int nowPage = 0;
  private const int ConfigArrayListPageCount = 12;
  public ArrayList configArrayList = (ArrayList) null;
  public ArrayList UCSystemInfoOptionsOneList = (ArrayList) null;
  private IContainer components = (IContainer) null;
  private Button buttonAdd;
  private Button buttonUp;
  private Button buttonDown;

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams = base.CreateParams;
      createParams.ExStyle |= 33554432 /*0x02000000*/;
      return createParams;
    }
  }

  public UCSystemInfoOptions()
  {
    this.InitializeComponent();
    this.configArrayList = new ArrayList();
    this.UCSystemInfoOptionsOneList = new ArrayList();
    this.buttonAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonUp.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonDown.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public void InitUCSystemInfoOptionsOneVal(int n)
  {
    ArrayList arrayList = new ArrayList();
    arrayList.Add((object) n);
    switch (n)
    {
      case 1:
        arrayList.Add((object) "CPU");
        arrayList.Add((object) "TEMP");
        arrayList.Add((object) Form1.formSystemInfo.GetSystemInfo(1));
        arrayList.Add((object) 0);
        arrayList.Add((object) "Usage");
        arrayList.Add((object) Form1.formSystemInfo.GetSystemInfo(2));
        arrayList.Add((object) 0);
        arrayList.Add((object) "Clock");
        arrayList.Add((object) Form1.formSystemInfo.GetSystemInfo(3));
        arrayList.Add((object) 0);
        arrayList.Add((object) "Power");
        arrayList.Add((object) "CPU Package Power");
        arrayList.Add((object) 0);
        break;
      case 2:
        arrayList.Add((object) "GPU");
        arrayList.Add((object) "TEMP");
        arrayList.Add((object) Form1.formSystemInfo.GetSystemInfo(4));
        arrayList.Add((object) 0);
        arrayList.Add((object) "Usage");
        arrayList.Add((object) Form1.formSystemInfo.GetSystemInfo(5));
        arrayList.Add((object) 0);
        arrayList.Add((object) "Clock");
        arrayList.Add((object) Form1.formSystemInfo.GetSystemInfo(6));
        arrayList.Add((object) 0);
        arrayList.Add((object) "Power");
        arrayList.Add((object) Form1.formSystemInfo.GetSystemInfo(7));
        arrayList.Add((object) 0);
        break;
      case 3:
        arrayList.Add((object) "Memory");
        arrayList.Add((object) "TEMP");
        arrayList.Add((object) "SPD Hub Temperature");
        arrayList.Add((object) 0);
        arrayList.Add((object) "Usage");
        arrayList.Add((object) "Physical Memory Load");
        arrayList.Add((object) 0);
        arrayList.Add((object) "Clock");
        arrayList.Add((object) "Memory Clock");
        arrayList.Add((object) 0);
        arrayList.Add((object) "Available");
        arrayList.Add((object) "Physical Memory Available");
        arrayList.Add((object) 0);
        break;
      case 4:
        arrayList.Add((object) "HDD");
        arrayList.Add((object) "TEMP");
        arrayList.Add((object) "Drive Temperature");
        arrayList.Add((object) 0);
        arrayList.Add((object) "Activity");
        arrayList.Add((object) "Total Activity");
        arrayList.Add((object) 0);
        arrayList.Add((object) "Read");
        arrayList.Add((object) "Read Rate");
        arrayList.Add((object) 0);
        arrayList.Add((object) "Write");
        arrayList.Add((object) "Write Rate");
        arrayList.Add((object) 0);
        break;
      case 5:
        arrayList.Add((object) "Network");
        arrayList.Add((object) "UP rate");
        arrayList.Add((object) "Current UP rate");
        arrayList.Add((object) 0);
        arrayList.Add((object) "DL rate");
        arrayList.Add((object) "Current DL rate");
        arrayList.Add((object) 0);
        arrayList.Add((object) "Total UP");
        arrayList.Add((object) "Total UP");
        arrayList.Add((object) 0);
        arrayList.Add((object) "Total DL");
        arrayList.Add((object) "Total DL");
        arrayList.Add((object) 0);
        break;
      case 6:
        arrayList.Add((object) "FAN");
        arrayList.Add((object) "CPUFAN");
        arrayList.Add((object) "CPU");
        arrayList.Add((object) 1);
        arrayList.Add((object) "GPUFAN");
        arrayList.Add((object) Form1.formSystemInfo.GetSystemInfo(8));
        arrayList.Add((object) 0);
        arrayList.Add((object) "FAN1");
        arrayList.Add((object) "PUMP1");
        arrayList.Add((object) 0);
        arrayList.Add((object) "FAN2");
        arrayList.Add((object) "System 1");
        arrayList.Add((object) 0);
        break;
    }
    this.configArrayList.Add((object) arrayList);
  }

  public void GetMyNameFile()
  {
    FileStream input = new FileStream(Application.StartupPath + "\\Data\\config", FileMode.OpenOrCreate);
    BinaryReader binaryReader = new BinaryReader((Stream) input);
    try
    {
      if (binaryReader.ReadByte() == (byte) 220)
      {
        int num = binaryReader.ReadInt32();
        for (int index = 0; index < num; ++index)
          this.configArrayList.Add((object) new ArrayList()
          {
            (object) binaryReader.ReadInt32(),
            (object) binaryReader.ReadString(),
            (object) binaryReader.ReadString(),
            (object) binaryReader.ReadString(),
            (object) binaryReader.ReadInt32(),
            (object) binaryReader.ReadString(),
            (object) binaryReader.ReadString(),
            (object) binaryReader.ReadInt32(),
            (object) binaryReader.ReadString(),
            (object) binaryReader.ReadString(),
            (object) binaryReader.ReadInt32(),
            (object) binaryReader.ReadString(),
            (object) binaryReader.ReadString(),
            (object) binaryReader.ReadInt32()
          });
      }
    }
    catch
    {
      this.InitUCSystemInfoOptionsOneVal(1);
      this.InitUCSystemInfoOptionsOneVal(2);
      this.InitUCSystemInfoOptionsOneVal(3);
      this.InitUCSystemInfoOptionsOneVal(4);
      this.InitUCSystemInfoOptionsOneVal(5);
      this.InitUCSystemInfoOptionsOneVal(6);
    }
    binaryReader.Close();
    binaryReader.Dispose();
    input.Close();
    input.Dispose();
    this.InitUCSystemInfoOptionsOneList();
    this.myTextChengeEn = true;
  }

  public void SetMyNameFile()
  {
    FileStream output = new FileStream(Application.StartupPath + "\\Data\\config", FileMode.OpenOrCreate);
    BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
    binaryWriter.Write((byte) 220);
    binaryWriter.Write(this.configArrayList.Count);
    for (int index = 0; index < this.configArrayList.Count; ++index)
    {
      ArrayList configArray = (ArrayList) this.configArrayList[index];
      binaryWriter.Write((int) configArray[0]);
      binaryWriter.Write((string) configArray[1]);
      binaryWriter.Write((string) configArray[2]);
      binaryWriter.Write((string) configArray[3]);
      binaryWriter.Write((int) configArray[4]);
      binaryWriter.Write((string) configArray[5]);
      binaryWriter.Write((string) configArray[6]);
      binaryWriter.Write((int) configArray[7]);
      binaryWriter.Write((string) configArray[8]);
      binaryWriter.Write((string) configArray[9]);
      binaryWriter.Write((int) configArray[10]);
      binaryWriter.Write((string) configArray[11]);
      binaryWriter.Write((string) configArray[12]);
      binaryWriter.Write((int) configArray[13]);
    }
    binaryWriter.Flush();
    binaryWriter.Close();
    binaryWriter.Dispose();
    output.Close();
    output.Dispose();
  }

  private void InitUCSystemInfoOptionsOneList()
  {
    for (int index = 0; index < this.configArrayList.Count; ++index)
    {
      ArrayList configArray = (ArrayList) this.configArrayList[index];
      UCSystemInfoOptionsOne systemInfoOptionsOne = new UCSystemInfoOptionsOne();
      systemInfoOptionsOne.SetUCSystemInfoOptionsOneColor((int) configArray[0]);
      systemInfoOptionsOne.textBoxName.Text = (string) configArray[1];
      systemInfoOptionsOne.textBox1.Text = (string) configArray[2];
      systemInfoOptionsOne.textBox2.Text = (string) configArray[5];
      systemInfoOptionsOne.textBox3.Text = (string) configArray[8];
      systemInfoOptionsOne.textBox4.Text = (string) configArray[11];
      systemInfoOptionsOne.Top = 36 + index / 4 * 199;
      systemInfoOptionsOne.Left = 44 + index % 4 * 300;
      systemInfoOptionsOne.Top -= index / 12 * 199 * 3;
      this.UCSystemInfoOptionsOneList.Add((object) systemInfoOptionsOne);
      systemInfoOptionsOne.upDateUCSystemInfoOne = new UCSystemInfoOptionsOne.delegate_UCSystemInfoOptionsOne(this.UpdateOne);
      this.Controls.Add((Control) systemInfoOptionsOne);
    }
    this.ButtonSetTopLeftAndHideShow();
  }

  private void ButtonSetTopLeftAndHideShow()
  {
    if (this.configArrayList.Count < 12)
    {
      this.buttonAdd.Top = 36 + this.configArrayList.Count / 4 * 199;
      this.buttonAdd.Left = 44 + this.configArrayList.Count % 4 * 300;
      this.buttonAdd.Show();
      this.buttonUp.Hide();
      this.buttonDown.Hide();
      for (int index = 0; index < this.UCSystemInfoOptionsOneList.Count; ++index)
        ((Control) this.UCSystemInfoOptionsOneList[index]).Show();
    }
    else if (this.nowPage == 0)
    {
      this.buttonAdd.Hide();
      this.buttonUp.Hide();
      this.buttonDown.Show();
      for (int index = 0; index < 12; ++index)
        ((Control) this.UCSystemInfoOptionsOneList[index]).Show();
      for (int index = 12; index < this.UCSystemInfoOptionsOneList.Count; ++index)
        ((Control) this.UCSystemInfoOptionsOneList[index]).Hide();
    }
    else
    {
      if (this.configArrayList.Count >= 24)
        this.buttonAdd.Hide();
      else
        this.buttonAdd.Show();
      this.buttonUp.Show();
      this.buttonDown.Hide();
      int num = this.configArrayList.Count - 12;
      this.buttonAdd.Top = 36 + num / 4 * 199;
      this.buttonAdd.Left = 44 + num % 4 * 300;
      for (int index = 0; index < 12; ++index)
        ((Control) this.UCSystemInfoOptionsOneList[index]).Hide();
      for (int index = 12; index < this.UCSystemInfoOptionsOneList.Count; ++index)
        ((Control) this.UCSystemInfoOptionsOneList[index]).Show();
    }
  }

  private void FormSystemInfoShow(int mode, object val)
  {
    for (int index = 0; index < this.configArrayList.Count; ++index)
    {
      if (val == (UCSystemInfoOptionsOne) this.UCSystemInfoOptionsOneList[index])
      {
        this.oneCount = index;
        break;
      }
    }
    this.oneCountSub = mode;
    ArrayList configArray = (ArrayList) this.configArrayList[this.oneCount];
    Form1.formSystemInfo.Show();
    Form1.formSystemInfo.ButtonClick((int) configArray[1 + mode * 3], (string) configArray[mode * 3]);
  }

  public void FormSystemInfoSet(int n, string name)
  {
    ArrayList configArray = (ArrayList) this.configArrayList[this.oneCount];
    configArray[1 + this.oneCountSub * 3] = (object) n;
    configArray[this.oneCountSub * 3] = (object) name;
    this.SetMyNameFile();
  }

  private void FormSystemDelete(object val)
  {
    for (int index = 0; index < this.configArrayList.Count; ++index)
    {
      if (val == (UCSystemInfoOptionsOne) this.UCSystemInfoOptionsOneList[index])
      {
        this.oneCount = index;
        break;
      }
    }
    this.Controls.Remove((Control) val);
    this.configArrayList.RemoveAt(this.oneCount);
    this.UCSystemInfoOptionsOneList.RemoveAt(this.oneCount);
    ((Component) val).Dispose();
    for (int index = 0; index < this.configArrayList.Count; ++index)
    {
      UCSystemInfoOptionsOne systemInfoOptionsOne = (UCSystemInfoOptionsOne) this.UCSystemInfoOptionsOneList[index];
      systemInfoOptionsOne.Top = 36 + index / 4 * 199;
      systemInfoOptionsOne.Left = 44 + index % 4 * 300;
      systemInfoOptionsOne.Top -= index / 12 * 199 * 3;
    }
    this.ButtonSetTopLeftAndHideShow();
    this.SetMyNameFile();
  }

  private void UpdateOne(int mode, object val)
  {
    switch (mode)
    {
      case 0:
        this.FormSystemDelete(val);
        break;
      case 1:
        this.FormSystemInfoShow(mode, val);
        break;
      case 2:
        this.FormSystemInfoShow(mode, val);
        break;
      case 3:
        this.FormSystemInfoShow(mode, val);
        break;
      case 4:
        this.FormSystemInfoShow(mode, val);
        break;
      case 16 /*0x10*/:
        if (!this.myTextChengeEn)
          break;
        for (int index = 0; index < this.configArrayList.Count; ++index)
        {
          ArrayList configArray = (ArrayList) this.configArrayList[index];
          UCSystemInfoOptionsOne systemInfoOptionsOne = (UCSystemInfoOptionsOne) this.UCSystemInfoOptionsOneList[index];
          configArray[1] = (object) systemInfoOptionsOne.textBoxName.Text;
          configArray[2] = (object) systemInfoOptionsOne.textBox1.Text;
          configArray[5] = (object) systemInfoOptionsOne.textBox2.Text;
          configArray[8] = (object) systemInfoOptionsOne.textBox3.Text;
          configArray[11] = (object) systemInfoOptionsOne.textBox4.Text;
        }
        this.SetMyNameFile();
        break;
    }
  }

  public void UCSystemInfoOptionsTimer()
  {
    for (int index = 0; index < this.configArrayList.Count; ++index)
    {
      ArrayList configArray = (ArrayList) this.configArrayList[index];
      UCSystemInfoOptionsOne systemInfoOptionsOne = (UCSystemInfoOptionsOne) this.UCSystemInfoOptionsOneList[index];
      string val = "";
      Form1.formSystemInfo.GetSystemInfoVal((string) configArray[3], (int) configArray[4], ref val);
      systemInfoOptionsOne.label1.Text = val;
      if ((int) configArray[0] == 5)
        systemInfoOptionsOne.label1.Text += "KB/s";
      Form1.formSystemInfo.GetSystemInfoVal((string) configArray[6], (int) configArray[7], ref val);
      systemInfoOptionsOne.label2.Text = val;
      if ((int) configArray[0] == 3)
        systemInfoOptionsOne.label2.Text += "%";
      if ((int) configArray[0] == 5)
        systemInfoOptionsOne.label2.Text += "KB/s";
      Form1.formSystemInfo.GetSystemInfoVal((string) configArray[9], (int) configArray[10], ref val);
      systemInfoOptionsOne.label3.Text = val;
      if ((int) configArray[0] == 4)
        systemInfoOptionsOne.label3.Text += "MB/s";
      if ((int) configArray[0] == 5)
        systemInfoOptionsOne.label3.Text += "MB";
      Form1.formSystemInfo.GetSystemInfoVal((string) configArray[12], (int) configArray[13], ref val);
      systemInfoOptionsOne.label4.Text = val;
      if ((int) configArray[0] == 3)
        systemInfoOptionsOne.label4.Text += "MB";
      if ((int) configArray[0] == 4)
        systemInfoOptionsOne.label4.Text += "MB/s";
      if ((int) configArray[0] == 5)
        systemInfoOptionsOne.label4.Text += "MB";
    }
  }

  private void buttonAdd_Click(object sender, EventArgs e)
  {
    ArrayList arrayList = new ArrayList()
    {
      (object) 0,
      (object) "Custom",
      (object) "Custom1",
      (object) "",
      (object) 0,
      (object) "Custom2",
      (object) "",
      (object) 0,
      (object) "Custom3",
      (object) "",
      (object) 0,
      (object) "Custom4",
      (object) "",
      (object) 0
    };
    UCSystemInfoOptionsOne systemInfoOptionsOne = new UCSystemInfoOptionsOne();
    systemInfoOptionsOne.SetUCSystemInfoOptionsOneColor((int) arrayList[0]);
    systemInfoOptionsOne.textBoxName.Text = (string) arrayList[1];
    systemInfoOptionsOne.textBox1.Text = (string) arrayList[2];
    systemInfoOptionsOne.textBox2.Text = (string) arrayList[5];
    systemInfoOptionsOne.textBox3.Text = (string) arrayList[8];
    systemInfoOptionsOne.textBox4.Text = (string) arrayList[11];
    systemInfoOptionsOne.Top = 36 + this.configArrayList.Count / 4 * 199;
    systemInfoOptionsOne.Left = 44 + this.configArrayList.Count % 4 * 300;
    systemInfoOptionsOne.Top -= this.configArrayList.Count / 12 * 199 * 3;
    this.UCSystemInfoOptionsOneList.Add((object) systemInfoOptionsOne);
    systemInfoOptionsOne.upDateUCSystemInfoOne = new UCSystemInfoOptionsOne.delegate_UCSystemInfoOptionsOne(this.UpdateOne);
    this.Controls.Add((Control) systemInfoOptionsOne);
    this.configArrayList.Add((object) arrayList);
    this.ButtonSetTopLeftAndHideShow();
    this.SetMyNameFile();
  }

  private void buttonUp_Click(object sender, EventArgs e)
  {
    this.nowPage = 0;
    this.ButtonSetTopLeftAndHideShow();
  }

  private void buttonDown_Click(object sender, EventArgs e)
  {
    this.nowPage = 1;
    this.ButtonSetTopLeftAndHideShow();
  }

  public void GetSystemInfoVal(int main, int sub, ref string val)
  {
    UCSystemInfoOptionsOne systemInfoOptionsOne = (UCSystemInfoOptionsOne) this.UCSystemInfoOptionsOneList[main];
    switch (sub)
    {
      case 1:
        val = systemInfoOptionsOne.label1.Text;
        break;
      case 2:
        val = systemInfoOptionsOne.label2.Text;
        break;
      case 3:
        val = systemInfoOptionsOne.label3.Text;
        break;
      case 4:
        val = systemInfoOptionsOne.label4.Text;
        break;
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
    this.buttonAdd = new Button();
    this.buttonUp = new Button();
    this.buttonDown = new Button();
    this.SuspendLayout();
    this.buttonAdd.BackColor = Color.Transparent;
    this.buttonAdd.BackgroundImage = (Image) Resources.A增加数组;
    this.buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonAdd.FlatAppearance.BorderSize = 0;
    this.buttonAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonAdd.FlatStyle = FlatStyle.Flat;
    this.buttonAdd.Location = new Point(44, 36);
    this.buttonAdd.Margin = new Padding(0);
    this.buttonAdd.Name = "buttonAdd";
    this.buttonAdd.Size = new Size(266, 189);
    this.buttonAdd.TabIndex = 136;
    this.buttonAdd.UseVisualStyleBackColor = false;
    this.buttonAdd.Visible = false;
    this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
    this.buttonUp.BackColor = Color.Transparent;
    this.buttonUp.BackgroundImage = (Image) Resources.A上一页a;
    this.buttonUp.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonUp.FlatAppearance.BorderSize = 0;
    this.buttonUp.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonUp.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonUp.FlatStyle = FlatStyle.Flat;
    this.buttonUp.Location = new Point(145, 653);
    this.buttonUp.Margin = new Padding(0);
    this.buttonUp.Name = "buttonUp";
    this.buttonUp.Size = new Size(64 /*0x40*/, 24);
    this.buttonUp.TabIndex = 137;
    this.buttonUp.UseVisualStyleBackColor = false;
    this.buttonUp.Visible = false;
    this.buttonUp.Click += new EventHandler(this.buttonUp_Click);
    this.buttonDown.BackColor = Color.Transparent;
    this.buttonDown.BackgroundImage = (Image) Resources.A下一页a;
    this.buttonDown.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDown.FlatAppearance.BorderSize = 0;
    this.buttonDown.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDown.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDown.FlatStyle = FlatStyle.Flat;
    this.buttonDown.Location = new Point(1045, 653);
    this.buttonDown.Margin = new Padding(0);
    this.buttonDown.Name = "buttonDown";
    this.buttonDown.Size = new Size(64 /*0x40*/, 24);
    this.buttonDown.TabIndex = 138;
    this.buttonDown.UseVisualStyleBackColor = false;
    this.buttonDown.Visible = false;
    this.buttonDown.Click += new EventHandler(this.buttonDown_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackgroundImage = (Image) Resources.A0数据列表;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.buttonDown);
    this.Controls.Add((Control) this.buttonUp);
    this.Controls.Add((Control) this.buttonAdd);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCSystemInfoOptions);
    this.Size = new Size(1254, 692);
    this.ResumeLayout(false);
  }
}

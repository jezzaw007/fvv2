// Decompiled with JetBrains decompiler
// Type: TRCC.FormSystemInfo
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.DCUserControl;
using TRCC.Properties;

#nullable disable
namespace TRCC;

public class FormSystemInfo : Form
{
  public FormSystemInfo.delegate_SystemInfo upDateInfo;
  private Point _mousePoint;
  private bool isMouseDown = false;
  private IContainer components = (IContainer) null;
  private Button buttonOK;
  private Button buttonCancel;
  public UCSystemInfo ucSystemInfo1;

  public FormSystemInfo()
  {
    this.InitializeComponent();
    this.buttonOK.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonCancel.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.ucSystemInfo1.upDateUCInfo = new UCSystemInfo.delegate_UCSystemInfo(this.UpDateUCInfo);
  }

  private void UpDateUCInfo(int mode)
  {
    FormSystemInfo.delegate_SystemInfo upDateInfo = this.upDateInfo;
    if (upDateInfo == null)
      return;
    upDateInfo(0, mode);
  }

  public void ThreadStart() => this.ucSystemInfo1.ThreadStart();

  public void FormSystemInfoClose() => this.ucSystemInfo1.ucSystemInfoClose();

  private void FormSystemInfo_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = true;

  public string GetSystemInfo(int n)
  {
    string systemInfo = "";
    switch (n)
    {
      case 1:
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("CPU") && (((Control) this.ucSystemInfo1.myListVal[index]).Text.Contains("℃") || ((Control) this.ucSystemInfo1.myListVal[index]).Text.Contains("℉")))
            return "CPU";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("CPU Package"))
            return "CPU Package";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("CPU Die (average)"))
            return "CPU Die (average)";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("CPU (Tctl/Tdie)"))
            return "CPU (Tctl/Tdie)";
        }
        break;
      case 2:
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("Total CPU Usage"))
            return "Total CPU Usage";
        }
        break;
      case 3:
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("P-core 0 Clock"))
            return "P-core 0 Clock";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Contains("Core 0 Clock"))
            return ((Control) this.ucSystemInfo1.myListName[index]).Text;
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("Ring/LLC Clock"))
            return "Ring/LLC Clock";
        }
        break;
      case 4:
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU Temperature"))
            return "GPU Temperature";
        }
        break;
      case 5:
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU Utilization"))
            return "GPU Utilization";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU Core Load"))
            return "GPU Core Load";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU D3D Usage"))
            return "GPU D3D Usage";
        }
        break;
      case 6:
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU Clock"))
            return "GPU Clock";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU Shader Clock"))
            return "GPU Shader Clock";
        }
        break;
      case 7:
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("Total Graphics Power (TGP)"))
            return "Total Graphics Power (TGP)";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU Power"))
            return "GPU Power";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU ASIC Power"))
            return "GPU ASIC Power";
        }
        break;
      case 8:
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU Fan1"))
            return "GPU Fan1";
        }
        for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
        {
          if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals("GPU Fan"))
            return "GPU Fan";
        }
        break;
    }
    return systemInfo;
  }

  public void GetSystemInfoVal(string iName, int n, ref string val)
  {
    int num = 0;
    int index;
    for (index = 0; index < this.ucSystemInfo1.panel1.Controls.Count; ++index)
    {
      if (((Control) this.ucSystemInfo1.myListName[index]).Text.Equals(iName))
      {
        if (num != n)
          ++num;
        else
          break;
      }
    }
    if (index < this.ucSystemInfo1.panel1.Controls.Count)
      val = ((Control) this.ucSystemInfo1.myListVal[index]).Text;
    else
      val = "";
  }

  public void ButtonClick(int n, string name)
  {
    for (int index = 0; index < this.ucSystemInfo1.myListName.Count; ++index)
    {
      if (name.Equals(((Control) this.ucSystemInfo1.myListName[index]).Text))
      {
        if (n > 0)
        {
          --n;
        }
        else
        {
          this.ucSystemInfo1.ButtonClick(index);
          break;
        }
      }
    }
  }

  private void buttonOK_Click(object sender, EventArgs e)
  {
    string text = ((Control) this.ucSystemInfo1.myListName[this.ucSystemInfo1.myCount]).Text;
    int val = 0;
    for (int index = 0; index < this.ucSystemInfo1.myCount; ++index)
    {
      if (text.Equals(((Control) this.ucSystemInfo1.myListName[index]).Text))
        ++val;
    }
    FormSystemInfo.delegate_SystemInfo upDateInfo = this.upDateInfo;
    if (upDateInfo != null)
      upDateInfo(1, val, text);
    this.Hide();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    FormSystemInfo.delegate_SystemInfo upDateInfo = this.upDateInfo;
    if (upDateInfo != null)
      upDateInfo(2);
    this.Hide();
  }

  private void FormSystemInfo_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this._mousePoint = new Point(-e.X, -e.Y);
    this.isMouseDown = true;
  }

  private void FormSystemInfo_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    Point mousePosition = Control.MousePosition;
    mousePosition.Offset(this._mousePoint.X, this._mousePoint.Y);
    this.Location = mousePosition;
  }

  private void FormSystemInfo_MouseUp(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this.isMouseDown = false;
    if (this._mousePoint.IsEmpty)
      ;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSystemInfo));
    this.buttonOK = new Button();
    this.buttonCancel = new Button();
    this.ucSystemInfo1 = new UCSystemInfo();
    this.SuspendLayout();
    this.buttonOK.BackColor = Color.Transparent;
    this.buttonOK.BackgroundImage = (Image) Resources.P圆形确定;
    this.buttonOK.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonOK.FlatAppearance.BorderSize = 0;
    this.buttonOK.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonOK.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonOK.FlatStyle = FlatStyle.Flat;
    this.buttonOK.Location = new Point(411, 12);
    this.buttonOK.Margin = new Padding(0);
    this.buttonOK.Name = "buttonOK";
    this.buttonOK.Size = new Size(24, 24);
    this.buttonOK.TabIndex = 664;
    this.buttonOK.UseVisualStyleBackColor = false;
    this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
    this.buttonCancel.BackColor = Color.Transparent;
    this.buttonCancel.BackgroundImage = (Image) Resources.P圆形关闭;
    this.buttonCancel.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonCancel.FlatAppearance.BorderSize = 0;
    this.buttonCancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonCancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonCancel.FlatStyle = FlatStyle.Flat;
    this.buttonCancel.Location = new Point(451, 12);
    this.buttonCancel.Margin = new Padding(0);
    this.buttonCancel.Name = "buttonCancel";
    this.buttonCancel.Size = new Size(24, 24);
    this.buttonCancel.TabIndex = 665;
    this.buttonCancel.UseVisualStyleBackColor = false;
    this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
    this.ucSystemInfo1.BackColor = Color.Transparent;
    this.ucSystemInfo1.BackgroundImageLayout = ImageLayout.Zoom;
    this.ucSystemInfo1.Location = new Point(20, 50);
    this.ucSystemInfo1.Margin = new Padding(0);
    this.ucSystemInfo1.Name = "ucSystemInfo1";
    this.ucSystemInfo1.Size = new Size(466, 742);
    this.ucSystemInfo1.TabIndex = 0;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackgroundImage = (Image) Resources.P0系统信息;
    this.BackgroundImageLayout = ImageLayout.None;
    this.ClientSize = new Size(490, 800);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonOK);
    this.Controls.Add((Control) this.ucSystemInfo1);
    this.DoubleBuffered = true;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormSystemInfo);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "SystemInfo";
    this.FormClosing += new FormClosingEventHandler(this.FormSystemInfo_FormClosing);
    this.MouseDown += new MouseEventHandler(this.FormSystemInfo_MouseDown);
    this.MouseMove += new MouseEventHandler(this.FormSystemInfo_MouseMove);
    this.MouseUp += new MouseEventHandler(this.FormSystemInfo_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegate_SystemInfo(int mode, int val = 0, string name = "");
}

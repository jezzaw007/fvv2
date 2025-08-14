// Decompiled with JetBrains decompiler
// Type: TRCC.CZTV.FormScreenImage
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
namespace TRCC.CZTV;

public class FormScreenImage : Form
{
  public UCScreenImage ucScreenImage1 = (UCScreenImage) null;
  private bool isMouseDown;
  private Point _mousePoint;
  public FormScreenImage.delegateFScreenImage ucScreenImage;
  private IContainer components = (IContainer) null;
  public Button buttonPower;

  public FormScreenImage()
  {
    this.InitializeComponent();
    this.buttonPower.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public void ResetFormScreenImage()
  {
    this.Width = this.BackgroundImage.Width;
    this.Height = this.BackgroundImage.Height;
    this.buttonPower.Left = this.Width - 44;
  }

  private void FormScreenImage_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    int x = -e.X;
    int y = -e.Y;
    if (sender == null)
      x -= 180;
    this._mousePoint = new Point(x, y);
    this.isMouseDown = true;
  }

  private void FormScreenImage_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown)
      return;
    Point mousePosition = Control.MousePosition;
    mousePosition.Offset(this._mousePoint.X, this._mousePoint.Y);
    this.Location = mousePosition;
  }

  private void FormScreenImage_MouseUp(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this.isMouseDown = false;
    if (this._mousePoint.IsEmpty)
      ;
  }

  private void buttonPower_Click(object sender, EventArgs e)
  {
    this.Hide();
    FormScreenImage.delegateFScreenImage ucScreenImage = this.ucScreenImage;
    if (ucScreenImage == null)
      return;
    ucScreenImage(0);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormScreenImage));
    this.buttonPower = new Button();
    this.SuspendLayout();
    this.buttonPower.BackColor = Color.Transparent;
    this.buttonPower.BackgroundImage = (Image) Resources.Alogout默认;
    this.buttonPower.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonPower.FlatAppearance.BorderSize = 0;
    this.buttonPower.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonPower.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonPower.FlatStyle = FlatStyle.Flat;
    this.buttonPower.Location = new Point(776, 2);
    this.buttonPower.Margin = new Padding(0);
    this.buttonPower.Name = "buttonPower";
    this.buttonPower.Size = new Size(40, 40);
    this.buttonPower.TabIndex = 138;
    this.buttonPower.UseVisualStyleBackColor = false;
    this.buttonPower.Click += new EventHandler(this.buttonPower_Click);
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.White;
    this.BackgroundImage = (Image) Resources.P0预览弹窗800X360;
    this.BackgroundImageLayout = ImageLayout.None;
    this.ClientSize = new Size(820, 420);
    this.Controls.Add((Control) this.buttonPower);
    this.DoubleBuffered = true;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormScreenImage);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (FormScreenImage);
    this.TopMost = true;
    this.MouseDown += new MouseEventHandler(this.FormScreenImage_MouseDown);
    this.MouseMove += new MouseEventHandler(this.FormScreenImage_MouseMove);
    this.MouseUp += new MouseEventHandler(this.FormScreenImage_MouseUp);
    this.ResumeLayout(false);
  }

  public delegate void delegateFScreenImage(int mode);
}

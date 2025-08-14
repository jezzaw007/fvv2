// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCScreenImageBK
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCScreenImageBK : UserControl
{
  private IContainer components = (IContainer) null;
  public UCScreenImage ucScreenImage1;

  public UCScreenImageBK() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.ucScreenImage1 = new UCScreenImage();
    this.SuspendLayout();
    this.ucScreenImage1.BackColor = Color.Black;
    this.ucScreenImage1.BackgroundImageLayout = ImageLayout.Zoom;
    this.ucScreenImage1.Location = new Point(90, 130);
    this.ucScreenImage1.Margin = new Padding(0);
    this.ucScreenImage1.Name = "ucScreenImage1";
    this.ucScreenImage1.Size = new Size(320, 240 /*0xF0*/);
    this.ucScreenImage1.TabIndex = 0;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P预览320X240;
    this.BackgroundImageLayout = ImageLayout.Stretch;
    this.Controls.Add((Control) this.ucScreenImage1);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCScreenImageBK);
    this.Size = new Size(500, 500);
    this.ResumeLayout(false);
  }
}

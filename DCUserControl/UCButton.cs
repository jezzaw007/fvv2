// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCButton
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCButton : UserControl
{
  public int myType = 1;
  public Bitmap bitmap1 = (Bitmap) null;
  public Bitmap bitmap2 = (Bitmap) null;
  private IContainer components = (IContainer) null;

  public UCButton() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.A1CZTVa;
    this.BackgroundImageLayout = ImageLayout.Stretch;
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCButton);
    this.Size = new Size(140, 50);
    this.ResumeLayout(false);
  }
}

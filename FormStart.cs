// Decompiled with JetBrains decompiler
// Type: TRCC.FormStart
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC;

public class FormStart : Form
{
  private System.Timers.Timer m_timer;
  private const int JDT_Start_X = 282;
  private const int JDT_End_X = 556;
  private const int JDT_Y = 345;
  private const int JDT_W = 80 /*0x50*/;
  private const int JDT_H = 35;
  private int jdt_X = 282;
  private int jdt_N_X = 0;
  private readonly Image image = (Image) Resources.A滚动条;
  private IContainer components = (IContainer) null;

  public FormStart()
  {
    this.InitializeComponent();
    this.m_timer = new System.Timers.Timer(50.0);
    this.m_timer.Elapsed += new ElapsedEventHandler(this.timer_event);
    this.m_timer.AutoReset = true;
    this.m_timer.Start();
  }

  private void timer_event(object sender, ElapsedEventArgs e)
  {
    this.Invalidate(new Rectangle(282, 345, 556, 35));
  }

  public void OpenFormStart()
  {
    this.m_timer.Start();
    int num = (int) this.ShowDialog();
  }

  public void SetMyClose()
  {
    Control.CheckForIllegalCrossThreadCalls = false;
    this.m_timer.Stop();
    this.Hide();
    Control.CheckForIllegalCrossThreadCalls = true;
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (this.jdt_X == 282 && this.jdt_N_X < 80 /*0x50*/)
    {
      graphics.DrawImage(this.image, this.jdt_X, 345, this.jdt_N_X, 35);
      this.jdt_N_X += 5;
    }
    else if (this.jdt_X < 556)
    {
      this.jdt_X += 5;
      graphics.DrawImage(this.image, this.jdt_X, 345, this.jdt_N_X, 35);
    }
    else if (this.jdt_X >= 556 && this.jdt_N_X > 0)
    {
      this.jdt_X += 5;
      this.jdt_N_X -= 5;
      graphics.DrawImage(this.image, this.jdt_X, 345, this.jdt_N_X, 35);
    }
    else
    {
      this.jdt_X = 282;
      this.jdt_N_X = 0;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormStart));
    this.SuspendLayout();
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackgroundImage = (Image) Resources.A0启动界面;
    this.BackgroundImageLayout = ImageLayout.Zoom;
    this.ClientSize = new Size(920, 640);
    this.DoubleBuffered = true;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormStart);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Start";
    this.ResumeLayout(false);
  }
}

// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCBoFangQiKongZhi
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCBoFangQiKongZhi : UserControl
{
  private const string BoFangQiMuLu = "\\Data\\Player\\";
  private const string BoFangQiFile = "1.mp4";
  private string boFangQiMuLu;
  private string boFangQiFile;
  private bool boFangQiFileExist = false;
  private bool isStart = false;
  public Bitmap imageSub = (Bitmap) null;
  private int dirVal = 1;
  private int dirCount = 0;
  private int nowDir = 1;
  private const int gdtX1 = 10;
  private const int gdtX2 = 489;
  private const int gdtX = 10;
  private const int gdtY = 10;
  private Bitmap bitmapJindu = (Bitmap) null;
  private int bitmapJDX = 0;
  private int bitmapJDY = 0;
  private int bitmapJDW = 0;
  private int bitmapJDH = 0;
  public bool isFanZhuan = false;
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
  public bool isBiliPingmu = false;
  private int xVal = 0;
  private int yVal = 0;
  private int wVal = 320;
  private int hVal = 240 /*0xF0*/;
  private int wValSub = 320;
  private int hValSub = 240 /*0xF0*/;
  private bool isGetVideoInfo = false;
  private int originalImageW = 480;
  private int originalImageH = 480;
  private int originalImageHz = 16 /*0x10*/;
  private long originalTimerLen = 1000;
  private double nowTimerVal = 0.0;
  private long nowStopTimerVal = 0;
  private bool isMouseDown = false;
  private bool isMouseMove = false;
  private int xPos = 0;
  private long jdtTimerVal = 0;
  private bool isTPJCW = true;
  private int bitAngleW = 480;
  private int bitAngleH = 480;
  private const int ffTimer = 5;
  private const int ffWaitTimer = 35;
  private IContainer components = (IContainer) null;
  private Button button1;
  private Button buttonTPJCW;
  private Button buttonTPJCH;
  public Label labelAllTimer;
  public Label labelNowTimer;

  public UCBoFangQiKongZhi()
  {
    this.InitializeComponent();
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonTPJCH.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonTPJCW.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.boFangQiMuLu = Application.StartupPath + "\\Data\\Player\\";
    this.boFangQiFile = this.boFangQiMuLu + "1.mp4";
    this.boFangQiFileExist = File.Exists(this.boFangQiFile);
    if (this.boFangQiFileExist)
    {
      try
      {
        File.Delete(this.boFangQiFile);
      }
      catch
      {
      }
    }
    this.bitmapJindu = Resources.P进度条;
    this.bitmapJDX = 10;
    this.bitmapJDY = 10;
    this.bitmapJDW = 0;
    this.bitmapJDH = this.bitmapJindu.Height;
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (this.bitmapJDW <= 0)
      return;
    graphics.DrawImage((Image) this.bitmapJindu, this.bitmapJDX, this.bitmapJDY, this.bitmapJDW, this.bitmapJDH);
  }

  private long TimerToLong(string timer)
  {
    string str1 = timer.Split(':')[2];
    string str2 = str1.Substring(0, str1.IndexOf("."));
    string str3 = str1.Substring(str1.IndexOf(".") + 1);
    double num = (double) Convert.ToInt32(str2) + (double) Convert.ToInt32(str3) * Math.Pow(10.0, (double) -str3.Length);
    return (long) (Math.Round((double) (Convert.ToInt32(timer.Split(':')[0]) * 3600 + Convert.ToInt32(timer.Split(':')[1]) * 60) + num, 2) * 1000.0);
  }

  private string LongToTimer(long val)
  {
    int num1 = (int) (val % 1000L);
    val /= 1000L;
    int num2 = (int) (val % 60L);
    val /= 60L;
    int num3 = (int) (val % 60L);
    return $"{((int) (val / 60L)).ToString("00")}:{num3.ToString("00")}:{num2.ToString("00")}.{num1.ToString("000")}";
  }

  private int LongToWidth(long timer)
  {
    int num = 479;
    return (int) Math.Round((double) timer * 1.0 / (double) this.originalTimerLen * (double) num, 0);
  }

  private char[] GetVideoRatio(char[] chs)
  {
    char[] videoRatio = (char[]) null;
    for (int index = 0; index < chs.Length - 8; ++index)
    {
      if (chs[index] >= '0' && chs[index] <= '9' && chs[index + 1] >= '0' && chs[index + 1] <= '9' && chs[index + 2] >= '0' && chs[index + 2] <= '9' && chs[index + 3] >= '0' && chs[index + 3] <= '9' && chs[index + 4] == 'x' && chs[index + 5] >= '0' && chs[index + 5] <= '9' && chs[index + 6] >= '0' && chs[index + 6] <= '9' && chs[index + 7] >= '0' && chs[index + 7] <= '9' && chs[index + 8] >= '0' && chs[index + 8] <= '9')
        return new char[9]
        {
          chs[index],
          chs[index + 1],
          chs[index + 2],
          chs[index + 3],
          chs[index + 4],
          chs[index + 5],
          chs[index + 6],
          chs[index + 7],
          chs[index + 8]
        };
    }
    for (int index = 0; index < chs.Length - 7; ++index)
    {
      if (chs[index] >= '0' && chs[index] <= '9' && chs[index + 1] >= '0' && chs[index + 1] <= '9' && chs[index + 2] >= '0' && chs[index + 2] <= '9' && chs[index + 3] >= '0' && chs[index + 3] <= '9' && chs[index + 4] == 'x' && chs[index + 5] >= '0' && chs[index + 5] <= '9' && chs[index + 6] >= '0' && chs[index + 6] <= '9' && chs[index + 7] >= '0' && chs[index + 7] <= '9')
        return new char[8]
        {
          chs[index],
          chs[index + 1],
          chs[index + 2],
          chs[index + 3],
          chs[index + 4],
          chs[index + 5],
          chs[index + 6],
          chs[index + 7]
        };
    }
    for (int index = 0; index < chs.Length - 7; ++index)
    {
      if (chs[index] >= '0' && chs[index] <= '9' && chs[index + 1] >= '0' && chs[index + 1] <= '9' && chs[index + 2] >= '0' && chs[index + 2] <= '9' && chs[index + 3] == 'x' && chs[index + 4] >= '0' && chs[index + 4] <= '9' && chs[index + 5] >= '0' && chs[index + 5] <= '9' && chs[index + 6] >= '0' && chs[index + 6] <= '9' && chs[index + 7] >= '0' && chs[index + 7] <= '9')
        return new char[8]
        {
          chs[index],
          chs[index + 1],
          chs[index + 2],
          chs[index + 3],
          chs[index + 4],
          chs[index + 5],
          chs[index + 6],
          chs[index + 7]
        };
    }
    for (int index = 0; index < chs.Length - 7; ++index)
    {
      if (chs[index] >= '0' && chs[index] <= '9' && chs[index + 1] >= '0' && chs[index + 1] <= '9' && chs[index + 2] >= '0' && chs[index + 2] <= '9' && chs[index + 3] == 'x' && chs[index + 4] >= '0' && chs[index + 4] <= '9' && chs[index + 5] >= '0' && chs[index + 5] <= '9' && chs[index + 6] >= '0' && chs[index + 6] <= '9')
        return new char[7]
        {
          chs[index],
          chs[index + 1],
          chs[index + 2],
          chs[index + 3],
          chs[index + 4],
          chs[index + 5],
          chs[index + 6]
        };
    }
    return videoRatio;
  }

  public void SetImage(bool bl = false)
  {
    if (bl)
    {
      this.dirVal = 1;
      this.dirCount = 0;
      this.nowDir = 1;
    }
    if (this.dirCount != 0)
      return;
    string boFangQiFile = this.boFangQiFile;
    this.isGetVideoInfo = false;
    this.isStart = false;
    this.ResetAllTempFile(this.boFangQiMuLu + "1\\");
    this.ResetAllTempFile(this.boFangQiMuLu + "2\\");
    if (!File.Exists(this.boFangQiFile))
      return;
    Process process = new Process()
    {
      StartInfo = new ProcessStartInfo("cmd.exe")
      {
        UseShellExecute = false
      }
    };
    process.StartInfo.RedirectStandardInput = true;
    process.StartInfo.RedirectStandardOutput = true;
    process.StartInfo.CreateNoWindow = true;
    process.Start();
    string str1 = $"ffmpeg -i \"{boFangQiFile}\" > log.txt 2>&1";
    process.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
    process.StandardInput.WriteLine(str1);
    process.StandardInput.WriteLine("");
    process.StandardInput.WriteLine("exit");
    process.WaitForExit();
    process.Close();
    process.Dispose();
    try
    {
      FileStream fileStream = new FileStream(Application.StartupPath + "\\log.txt", FileMode.Open);
      StreamReader streamReader = new StreamReader((Stream) fileStream);
      string end = streamReader.ReadToEnd();
      streamReader.Close();
      streamReader.Dispose();
      fileStream.Close();
      fileStream.Dispose();
      string str2 = end.Substring(end.IndexOf("Duration: ") + 10);
      string timer = str2.Substring(0, str2.IndexOf(","));
      this.labelAllTimer.Text = timer;
      this.labelNowTimer.Text = "00:00:00.000/" + this.labelAllTimer.Text;
      this.originalTimerLen = this.TimerToLong(timer);
      this.nowTimerVal = 0.0;
      this.nowStopTimerVal = 0L;
      if (str2.Contains("Video: av1"))
      {
        switch (Form1.Language)
        {
          case 1:
            int num1 = (int) MessageBox.Show("不支持AV1的编码格式！请使用专业转码软件将视频文件转码为分辨率小于3840X2160，编码格式为H.264的MP4文件。");
            break;
          case 2:
            int num2 = (int) MessageBox.Show("不支持AV1的編碼格式！請使用專業轉碼軟件將視頻檔案轉碼為分辯率小於3840X2160，編碼格式為H.264的MP4檔案。");
            break;
          default:
            int num3 = (int) MessageBox.Show("The encoding format of AV1 is not supported! Please use professional transcoding software to transcode video files into MP4 files with a resolution of less than 3840X2160 and an encoding format of H.264.");
            break;
        }
      }
      else
      {
        string str3 = str2.Substring(str2.IndexOf("Video: ") + 7);
        try
        {
          str3 = str3.Substring(0, str3.IndexOf("Metadata:"));
        }
        catch
        {
        }
        char[] videoRatio = this.GetVideoRatio(str3.ToCharArray());
        if (videoRatio != null)
        {
          string str4 = new string(videoRatio);
          try
          {
            this.bitAngleW = this.originalImageW = Convert.ToInt32(str4.Split('x')[0]);
            this.bitAngleH = this.originalImageH = Convert.ToInt32(str4.Split('x')[1]);
            this.isGetVideoInfo = true;
          }
          catch
          {
          }
        }
        if (!this.isGetVideoInfo)
        {
          switch (Form1.Language)
          {
            case 1:
              int num4 = (int) MessageBox.Show("格式不支持，请修改文件路径和文件名为纯英文再试，如若依然不支持，请使用第三方转码软件将视频文件转码为H.264的MP4文件");
              break;
            case 2:
              int num5 = (int) MessageBox.Show("格式不支持，請修改檔案路徑和檔名為純英文再試，如若依然不支持，請使用專業轉碼軟件將視頻檔案轉碼為H.264的MP4檔案。");
              break;
            default:
              int num6 = (int) MessageBox.Show("The format is not supported. Please try changing the path and name to pure English and try again. If the error persists, please use professional video transcoding software to convert the video file into an MP4 file encoded as H.264.");
              break;
          }
        }
      }
    }
    catch
    {
      this.isGetVideoInfo = false;
      switch (Form1.Language)
      {
        case 1:
          int num7 = (int) MessageBox.Show("格式不支持，请修改文件路径和文件名为纯英文再试，如若依然不支持，请使用第三方转码软件将视频文件转码为H.264的MP4文件");
          break;
        case 2:
          int num8 = (int) MessageBox.Show("格式不支持，請修改檔案路徑和檔名為純英文再試，如若依然不支持，請使用專業轉碼軟件將視頻檔案轉碼為H.264的MP4檔案。");
          break;
        default:
          int num9 = (int) MessageBox.Show("The format is not supported. Please try changing the path and name to pure English and try again. If the error persists, please use professional video transcoding software to convert the video file into an MP4 file encoded as H.264.");
          break;
      }
    }
    finally
    {
      try
      {
        File.Delete(Application.StartupPath + "\\log.txt");
      }
      catch
      {
      }
    }
    if (this.isGetVideoInfo && this.originalImageW * this.originalImageH > 8294400)
    {
      this.isGetVideoInfo = false;
      switch (Form1.Language)
      {
        case 1:
          int num10 = (int) MessageBox.Show("分辨率过高！请使用专业转码软件将视频文件转码为分辨率小于3840X2160，编码格式为H.264的MP4文件。");
          break;
        case 2:
          int num11 = (int) MessageBox.Show("分辯率過高！請使用專業轉碼軟件將視頻檔案轉碼為分辯率小於3840X2160，編碼格式為H.264的MP4檔案。");
          break;
        default:
          int num12 = (int) MessageBox.Show("The resolution is too high!  Please use professional transcoding software to transcode the video file into an MP4 file with a resolution of less than 3840X2160 and an encoding format of H.264.");
          break;
      }
    }
    if (!this.isGetVideoInfo)
      return;
    if (this.is240x240)
    {
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      if (this.bitAngleH > this.bitAngleW)
      {
        this.hVal = 240 /*0xF0*/;
        this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
        this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 240 /*0xF0*/;
        this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
        this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is320x320)
    {
      this.wValSub = 320;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      if (this.bitAngleH > this.bitAngleW)
      {
        this.hVal = 320;
        this.wVal = this.bitAngleW * 320 / this.bitAngleH;
        this.xVal += (320 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 320;
        this.hVal = this.bitAngleH * 320 / this.bitAngleW;
        this.yVal += (320 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is360x360)
    {
      this.wValSub = 360;
      this.hValSub = 360;
      this.xVal = 0;
      this.yVal = 0;
      if (this.bitAngleH > this.bitAngleW)
      {
        this.hVal = 360;
        this.wVal = this.bitAngleW * 360 / this.bitAngleH;
        this.xVal += (360 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 360;
        this.hVal = this.bitAngleH * 360 / this.bitAngleW;
        this.yVal += (360 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is480x480)
    {
      this.wValSub = 480;
      this.hValSub = 480;
      this.xVal = 0;
      this.yVal = 0;
      if (this.bitAngleH > this.bitAngleW)
      {
        this.hVal = 480;
        this.wVal = this.bitAngleW * 480 / this.bitAngleH;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 480;
        this.hVal = this.bitAngleH * 480 / this.bitAngleW;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is1600x720)
    {
      if (this.isFanZhuan)
      {
        this.wValSub = 720;
        this.hValSub = 1600;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleH * 0.45 > (double) this.bitAngleW)
        {
          this.hVal = 1600;
          this.wVal = this.bitAngleW * 1600 / this.bitAngleH;
          this.xVal += (720 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 720;
          this.hVal = this.bitAngleH * 720 / this.bitAngleW;
          this.yVal += (1600 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.wValSub = 1600;
        this.hValSub = 720;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleW * 0.45 > (double) this.bitAngleH)
        {
          this.wVal = 1600;
          this.hVal = this.bitAngleH * 1600 / this.bitAngleW;
          this.yVal += (720 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 720;
          this.wVal = this.bitAngleW * 720 / this.bitAngleH;
          this.xVal += (1600 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
    }
    else if (this.is854x480)
    {
      if (this.isFanZhuan)
      {
        this.wValSub = 480;
        this.hValSub = 854;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleH * 0.56206 > (double) this.bitAngleW)
        {
          this.hVal = 854;
          this.wVal = this.bitAngleW * 854 / this.bitAngleH;
          this.xVal += (480 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 480;
          this.hVal = this.bitAngleH * 480 / this.bitAngleW;
          this.yVal += (854 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.wValSub = 854;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleW * 0.56206 > (double) this.bitAngleH)
        {
          this.wVal = 854;
          this.hVal = this.bitAngleH * 854 / this.bitAngleW;
          this.yVal += (480 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 480;
          this.wVal = this.bitAngleW * 480 / this.bitAngleH;
          this.xVal += (854 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
    }
    else if (this.is960x540)
    {
      if (this.isFanZhuan)
      {
        this.wValSub = 540;
        this.hValSub = 960;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleH * (9.0 / 16.0) > (double) this.bitAngleW)
        {
          this.hVal = 960;
          this.wVal = this.bitAngleW * 960 / this.bitAngleH;
          this.xVal += (540 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 540;
          this.hVal = this.bitAngleH * 540 / this.bitAngleW;
          this.yVal += (960 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.wValSub = 960;
        this.hValSub = 540;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleW * (9.0 / 16.0) > (double) this.bitAngleH)
        {
          this.wVal = 960;
          this.hVal = this.bitAngleH * 960 / this.bitAngleW;
          this.yVal += (540 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 540;
          this.wVal = this.bitAngleW * 540 / this.bitAngleH;
          this.xVal += (960 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
    }
    else if (this.is960x320)
    {
      if (this.isFanZhuan)
      {
        this.wValSub = 320;
        this.hValSub = 960;
        this.xVal = 0;
        this.yVal = 0;
        if (this.bitAngleH > this.bitAngleW * 3)
        {
          this.hVal = 960;
          this.wVal = this.bitAngleW * 960 / this.bitAngleH;
          this.xVal += (320 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 320;
          this.hVal = this.bitAngleH * 320 / this.bitAngleW;
          this.yVal += (960 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.wValSub = 960;
        this.hValSub = 320;
        this.xVal = 0;
        this.yVal = 0;
        if (this.bitAngleW > this.bitAngleH * 3)
        {
          this.wVal = 960;
          this.hVal = this.bitAngleH * 960 / this.bitAngleW;
          this.yVal += (320 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 320;
          this.wVal = this.bitAngleW * 320 / this.bitAngleH;
          this.xVal += (960 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
    }
    else if (this.is800x480)
    {
      if (this.isFanZhuan)
      {
        this.wValSub = 480;
        this.hValSub = 800;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleH * 0.6 > (double) this.bitAngleW)
        {
          this.hVal = 800;
          this.wVal = this.bitAngleW * 800 / this.bitAngleH;
          this.xVal += (480 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 480;
          this.hVal = this.bitAngleH * 480 / this.bitAngleW;
          this.yVal += (800 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.wValSub = 800;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleW * 0.6 > (double) this.bitAngleH)
        {
          this.wVal = 800;
          this.hVal = this.bitAngleH * 800 / this.bitAngleW;
          this.yVal += (480 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 480;
          this.wVal = this.bitAngleW * 480 / this.bitAngleH;
          this.xVal += (800 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
    }
    else if (this.is1920x462)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 1920;
        this.wValSub = 462;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleH * (77.0 / 320.0) > (double) this.bitAngleW)
        {
          this.hVal = 1920;
          this.wVal = this.bitAngleW * 1920 / this.bitAngleH;
          this.xVal += (462 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 462;
          this.hVal = this.bitAngleH * 462 / this.bitAngleW;
          this.yVal += (1920 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.wValSub = 1920;
        this.hValSub = 462;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleW * (77.0 / 320.0) > (double) this.bitAngleH)
        {
          this.wVal = 1920;
          this.hVal = this.bitAngleH * 1920 / this.bitAngleW;
          this.yVal += (462 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 462;
          this.wVal = this.bitAngleW * 462 / this.bitAngleH;
          this.xVal += (1920 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
    }
    else if (this.is1280x480)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 1280 /*0x0500*/;
        this.wValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleH * 0.375 > (double) this.bitAngleW)
        {
          this.hVal = 1280 /*0x0500*/;
          this.wVal = this.bitAngleW * 1280 /*0x0500*/ / this.bitAngleH;
          this.xVal += (480 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 480;
          this.hVal = this.bitAngleH * 480 / this.bitAngleW;
          this.yVal += (1280 /*0x0500*/ - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.wValSub = 1280 /*0x0500*/;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleW * 0.375 > (double) this.bitAngleH)
        {
          this.wVal = 1280 /*0x0500*/;
          this.hVal = this.bitAngleH * 1280 /*0x0500*/ / this.bitAngleW;
          this.yVal += (480 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 480;
          this.wVal = this.bitAngleW * 480 / this.bitAngleH;
          this.xVal += (1280 /*0x0500*/ - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
    }
    else if (this.is640x480)
    {
      if (this.isFanZhuan)
      {
        this.wValSub = 480;
        this.hValSub = 640;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleH * 0.75 > (double) this.bitAngleW)
        {
          this.hVal = 640;
          this.wVal = this.bitAngleW * 640 / this.bitAngleH;
          this.xVal += (480 - this.wVal) / 2;
          this.isTPJCW = false;
        }
        else
        {
          this.wVal = 480;
          this.hVal = this.bitAngleH * 480 / this.bitAngleW;
          this.yVal += (640 - this.hVal) / 2;
          this.isTPJCW = true;
        }
      }
      else
      {
        this.wValSub = 640;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        if ((double) this.bitAngleW * 0.75 > (double) this.bitAngleH)
        {
          this.wVal = 640;
          this.hVal = this.bitAngleH * 640 / this.bitAngleW;
          this.yVal += (480 - this.hVal) / 2;
          this.isTPJCW = true;
        }
        else
        {
          this.hVal = 480;
          this.wVal = this.bitAngleW * 480 / this.bitAngleH;
          this.xVal += (640 - this.wVal) / 2;
          this.isTPJCW = false;
        }
      }
    }
    else if (this.isFanZhuan)
    {
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      if ((double) this.bitAngleH * 0.75 > (double) this.bitAngleW)
      {
        this.hVal = 320;
        this.wVal = this.bitAngleW * 320 / this.bitAngleH;
        this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wVal = 240 /*0xF0*/;
        this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
        this.yVal += (320 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else
    {
      this.wValSub = 320;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      if ((double) this.bitAngleW * 0.75 > (double) this.bitAngleH)
      {
        this.wVal = 320;
        this.hVal = this.bitAngleH * 320 / this.bitAngleW;
        this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.hVal = 240 /*0xF0*/;
        this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
        this.xVal += (320 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
  }

  public void ResetAllTempFile(string allPicAddr)
  {
    if (Directory.Exists(allPicAddr))
    {
      try
      {
        Directory.Delete(allPicAddr, true);
      }
      catch
      {
        Thread.Sleep(200);
        try
        {
          Directory.Delete(allPicAddr, true);
        }
        catch
        {
          Console.WriteLine("catch");
        }
      }
    }
    Directory.CreateDirectory(allPicAddr);
  }

  public Bitmap Timer_Get_Image()
  {
    if (this.isStart)
    {
      if (File.Exists($"{this.boFangQiMuLu}{this.nowDir.ToString()}\\{this.dirVal.ToString("0000")}.bmp"))
      {
        try
        {
          Image image = Image.FromFile($"{this.boFangQiMuLu}{this.nowDir.ToString()}\\{this.dirVal.ToString("0000")}.bmp");
          Bitmap bitmap = new Bitmap(this.wValSub, this.hValSub);
          Graphics graphics = Graphics.FromImage((Image) bitmap);
          graphics.DrawImage(image, this.xVal, this.yVal);
          graphics.Dispose();
          image.Dispose();
          Image imageSub = (Image) this.imageSub;
          this.imageSub = bitmap;
          imageSub?.Dispose();
        }
        catch
        {
        }
        ++this.dirVal;
        this.nowTimerVal += 62.5;
        if (this.nowTimerVal >= (double) this.originalTimerLen)
          this.nowTimerVal = 0.0;
      }
      else
      {
        if (this.dirVal != 81)
        {
          if (this.nowTimerVal >= (double) (this.originalTimerLen - 125L))
            this.nowTimerVal = 0.0;
        }
        else if (this.nowTimerVal >= (double) (this.originalTimerLen - 100L))
          this.nowTimerVal = 0.0;
        this.nowDir = this.nowDir != 1 ? 1 : 2;
        this.dirVal = 1;
      }
      if (this.dirCount == this.nowDir)
      {
        this.dirCount = this.dirCount != 1 ? 1 : 2;
        this.FFmpeg_Video_Bmp();
      }
      if (!this.isMouseDown)
      {
        long num = (long) Math.Round(this.nowTimerVal, 0);
        this.labelNowTimer.Text = $"{this.LongToTimer(num)}/{this.labelAllTimer.Text}";
        this.bitmapJDW = this.LongToWidth(num);
        this.Invalidate();
      }
    }
    return this.imageSub;
  }

  private void FFmpeg_Video_Bmp()
  {
    try
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Equals("ffmpeg"))
        {
          process.Kill();
          Thread.Sleep(1);
        }
      }
    }
    catch (Exception ex)
    {
    }
    if (!this.isGetVideoInfo)
      return;
    this.ResetAllTempFile($"{this.boFangQiMuLu}{this.dirCount.ToString()}\\");
    long nowStopTimerVal = this.nowStopTimerVal;
    long val;
    if (this.nowStopTimerVal + 5000L >= this.originalTimerLen)
    {
      val = this.originalTimerLen - this.nowStopTimerVal;
      this.nowStopTimerVal = 0L;
    }
    else
    {
      val = 4875L;
      this.nowStopTimerVal += 5000L;
    }
    Process process1 = new Process()
    {
      StartInfo = new ProcessStartInfo("cmd.exe")
      {
        UseShellExecute = false
      }
    };
    process1.StartInfo.RedirectStandardInput = true;
    process1.StartInfo.RedirectStandardOutput = true;
    process1.StartInfo.CreateNoWindow = true;
    process1.Start();
    string str = string.Format("ffmpeg -ss {4} -t {5} -i \"{0}\" -y -r {1} -s {2}x{3} -f image2 \"{6}%04d.bmp\"", (object) this.boFangQiFile, (object) this.originalImageHz, (object) this.wVal, (object) this.hVal, (object) this.LongToTimer(nowStopTimerVal), (object) this.LongToTimer(val), (object) $"{this.boFangQiMuLu}{this.dirCount.ToString()}\\");
    process1.StandardInput.WriteLine("cd /d \"{0}\"", (object) Application.StartupPath);
    process1.StandardInput.WriteLine(str);
    process1.Close();
    process1.Dispose();
  }

  public void Player()
  {
    if (!this.isGetVideoInfo || this.isStart)
      return;
    this.button1_Click((object) null, (EventArgs) null);
  }

  public void ClosePlayer()
  {
    this.isStart = false;
    this.button1.BackgroundImage = (Image) Resources.P0播放;
  }

  private void button1_Click(object sender, EventArgs e)
  {
    if (!this.isGetVideoInfo)
    {
      if (Form1.Language == 1)
      {
        int num1 = (int) MessageBox.Show("格式不支持");
      }
      else if (Form1.Language == 2)
      {
        int num2 = (int) MessageBox.Show("格式不支持");
      }
      else
      {
        int num3 = (int) MessageBox.Show("The format is not supported.");
      }
    }
    else if (this.isStart)
    {
      this.isStart = false;
      this.button1.BackgroundImage = (Image) Resources.P0播放;
    }
    else
    {
      this.button1.BackgroundImage = (Image) Resources.P0暂停;
      if (this.dirCount == 0)
      {
        this.dirVal = 1;
        this.dirCount = 1;
        this.nowDir = 1;
        Thread.Sleep(100);
        this.FFmpeg_Video_Bmp();
        for (int index = 0; index < 35; ++index)
        {
          Thread.Sleep(100);
          if (File.Exists(this.boFangQiMuLu + "1\\0001.bmp"))
            break;
        }
      }
      this.isStart = true;
    }
  }

  private void buttonTPJCH_Click(object sender, EventArgs e)
  {
    if (!this.isTPJCW)
      return;
    bool isStart = this.isStart;
    this.isStart = false;
    if (this.is240x240)
    {
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 240 /*0xF0*/;
      this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
      this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else if (this.is320x320)
    {
      this.wValSub = 320;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 320;
      this.wVal = this.bitAngleW * 320 / this.bitAngleH;
      this.xVal += (320 - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else if (this.is360x360)
    {
      this.wValSub = 360;
      this.hValSub = 360;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 360;
      this.wVal = this.bitAngleW * 360 / this.bitAngleH;
      this.xVal += (360 - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else if (this.is480x480)
    {
      this.wValSub = 480;
      this.hValSub = 480;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 480;
      this.wVal = this.bitAngleW * 480 / this.bitAngleH;
      this.xVal += (480 - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else if (this.is1600x720)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 1600;
        this.wValSub = 720;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 1600;
        this.wVal = this.bitAngleW * 1600 / this.bitAngleH;
        this.xVal += (720 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wValSub = 1600;
        this.hValSub = 720;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 720;
        this.wVal = this.bitAngleW * 720 / this.bitAngleH;
        this.xVal += (1600 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is800x480)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 800;
        this.wValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 800;
        this.wVal = this.bitAngleW * 800 / this.bitAngleH;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wValSub = 800;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.bitAngleW * 480 / this.bitAngleH;
        this.xVal += (800 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is854x480)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 854;
        this.wValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 854;
        this.wVal = this.bitAngleW * 854 / this.bitAngleH;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wValSub = 854;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.bitAngleW * 480 / this.bitAngleH;
        this.xVal += (854 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is960x540)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 960;
        this.wValSub = 540;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 960;
        this.wVal = this.bitAngleW * 960 / this.bitAngleH;
        this.xVal += (540 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wValSub = 960;
        this.hValSub = 540;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 540;
        this.wVal = this.bitAngleW * 540 / this.bitAngleH;
        this.xVal += (960 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is960x320)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 960;
        this.wValSub = 320;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 960;
        this.wVal = this.bitAngleW * 960 / this.bitAngleH;
        this.xVal += (320 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wValSub = 960;
        this.hValSub = 320;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 320;
        this.wVal = this.bitAngleW * 320 / this.bitAngleH;
        this.xVal += (960 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is1920x462)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 1920;
        this.wValSub = 462;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 1920;
        this.wVal = this.bitAngleW * 1920 / this.bitAngleH;
        this.xVal += (462 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wValSub = 1920;
        this.hValSub = 462;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 462;
        this.wVal = this.bitAngleW * 462 / this.bitAngleH;
        this.xVal += (1920 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is1280x480)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 1280 /*0x0500*/;
        this.wValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 1280 /*0x0500*/;
        this.wVal = this.bitAngleW * 1280 /*0x0500*/ / this.bitAngleH;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wValSub = 1280 /*0x0500*/;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.bitAngleW * 480 / this.bitAngleH;
        this.xVal += (1280 /*0x0500*/ - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.is640x480)
    {
      if (this.isFanZhuan)
      {
        this.wValSub = 480;
        this.hValSub = 640;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 640;
        this.wVal = this.bitAngleW * 640 / this.bitAngleH;
        this.xVal += (480 - this.wVal) / 2;
        this.isTPJCW = false;
      }
      else
      {
        this.wValSub = 640;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.hVal = 480;
        this.wVal = this.bitAngleW * 480 / this.bitAngleH;
        this.xVal += (640 - this.wVal) / 2;
        this.isTPJCW = false;
      }
    }
    else if (this.isFanZhuan)
    {
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 320;
      this.wVal = this.bitAngleW * 320 / this.bitAngleH;
      this.xVal += (240 /*0xF0*/ - this.wVal) / 2;
      this.isTPJCW = false;
    }
    else
    {
      this.wValSub = 320;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      this.hVal = 240 /*0xF0*/;
      this.wVal = this.bitAngleW * 240 /*0xF0*/ / this.bitAngleH;
      this.xVal += (320 - this.wVal) / 2;
      this.isTPJCW = false;
    }
    this.dirVal = 1;
    this.dirCount = 1;
    this.nowDir = 1;
    Thread.Sleep(100);
    this.nowStopTimerVal = (long) (int) this.nowTimerVal;
    this.FFmpeg_Video_Bmp();
    for (int index = 0; index < 35; ++index)
    {
      Thread.Sleep(100);
      if (File.Exists(this.boFangQiMuLu + "1\\0001.bmp"))
        break;
    }
    this.isStart = isStart;
  }

  private void buttonTPJCW_Click(object sender, EventArgs e)
  {
    if (this.isTPJCW)
      return;
    bool isStart = this.isStart;
    this.isStart = false;
    if (this.is240x240)
    {
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 240 /*0xF0*/;
      this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
      this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else if (this.is320x320)
    {
      this.wValSub = 320;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 320;
      this.hVal = this.bitAngleH * 320 / this.bitAngleW;
      this.yVal += (320 - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else if (this.is360x360)
    {
      this.wValSub = 360;
      this.hValSub = 360;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 360;
      this.hVal = this.bitAngleH * 360 / this.bitAngleW;
      this.yVal += (360 - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else if (this.is480x480)
    {
      this.wValSub = 480;
      this.hValSub = 480;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 480;
      this.hVal = this.bitAngleH * 480 / this.bitAngleW;
      this.yVal += (480 - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else if (this.is1600x720)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 1600;
        this.wValSub = 720;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 720;
        this.hVal = this.bitAngleH * 720 / this.bitAngleW;
        this.yVal += (1600 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.wValSub = 1600;
        this.hValSub = 720;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 1600;
        this.hVal = this.bitAngleH * 1600 / this.bitAngleW;
        this.yVal += (720 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is800x480)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 800;
        this.wValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.bitAngleH * 480 / this.bitAngleW;
        this.yVal += (800 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.wValSub = 800;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 800;
        this.hVal = this.bitAngleH * 800 / this.bitAngleW;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is854x480)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 854;
        this.wValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.bitAngleH * 480 / this.bitAngleW;
        this.yVal += (854 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.wValSub = 854;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 854;
        this.hVal = this.bitAngleH * 854 / this.bitAngleW;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is960x540)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 960;
        this.wValSub = 540;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 540;
        this.hVal = this.bitAngleH * 540 / this.bitAngleW;
        this.yVal += (960 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.wValSub = 960;
        this.hValSub = 540;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 960;
        this.hVal = this.bitAngleH * 960 / this.bitAngleW;
        this.yVal += (540 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is960x320)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 960;
        this.wValSub = 320;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 320;
        this.hVal = this.bitAngleH * 320 / this.bitAngleW;
        this.yVal += (960 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.wValSub = 960;
        this.hValSub = 320;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 960;
        this.hVal = this.bitAngleH * 960 / this.bitAngleW;
        this.yVal += (320 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is1920x462)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 1920;
        this.wValSub = 462;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 462;
        this.hVal = this.bitAngleH * 462 / this.bitAngleW;
        this.yVal += (1920 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.wValSub = 1920;
        this.hValSub = 462;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 1920;
        this.hVal = this.bitAngleH * 1920 / this.bitAngleW;
        this.yVal += (462 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is1280x480)
    {
      if (this.isFanZhuan)
      {
        this.hValSub = 1280 /*0x0500*/;
        this.wValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.bitAngleH * 480 / this.bitAngleW;
        this.yVal += (1280 /*0x0500*/ - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.wValSub = 1280 /*0x0500*/;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 1280 /*0x0500*/;
        this.hVal = this.bitAngleH * 1280 /*0x0500*/ / this.bitAngleW;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.is640x480)
    {
      if (this.isFanZhuan)
      {
        this.wValSub = 480;
        this.hValSub = 640;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 480;
        this.hVal = this.bitAngleH * 480 / this.bitAngleW;
        this.yVal += (640 - this.hVal) / 2;
        this.isTPJCW = true;
      }
      else
      {
        this.wValSub = 640;
        this.hValSub = 480;
        this.xVal = 0;
        this.yVal = 0;
        this.wVal = 640;
        this.hVal = this.bitAngleH * 640 / this.bitAngleW;
        this.yVal += (480 - this.hVal) / 2;
        this.isTPJCW = true;
      }
    }
    else if (this.isFanZhuan)
    {
      this.wValSub = 240 /*0xF0*/;
      this.hValSub = 320;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 240 /*0xF0*/;
      this.hVal = this.bitAngleH * 240 /*0xF0*/ / this.bitAngleW;
      this.yVal += (320 - this.hVal) / 2;
      this.isTPJCW = true;
    }
    else
    {
      this.wValSub = 320;
      this.hValSub = 240 /*0xF0*/;
      this.xVal = 0;
      this.yVal = 0;
      this.wVal = 320;
      this.hVal = this.bitAngleH * 320 / this.bitAngleW;
      this.yVal += (240 /*0xF0*/ - this.hVal) / 2;
      this.isTPJCW = true;
    }
    this.dirVal = 1;
    this.dirCount = 1;
    this.nowDir = 1;
    Thread.Sleep(100);
    this.nowStopTimerVal = (long) (int) this.nowTimerVal;
    this.FFmpeg_Video_Bmp();
    for (int index = 0; index < 35; ++index)
    {
      Thread.Sleep(100);
      if (File.Exists(this.boFangQiMuLu + "1\\0001.bmp"))
        break;
    }
    this.isStart = isStart;
  }

  private void UCBoFangQiKongZhi_MouseDown(object sender, MouseEventArgs e)
  {
    this.isMouseMove = false;
    if (e.Y >= this.button1.Top)
      return;
    this.isMouseDown = true;
    this.xPos = e.X;
    if (this.xPos < 10)
      this.xPos = 10;
    if (this.xPos > 489)
      this.xPos = 489;
    this.bitmapJDW = this.xPos - 10;
    this.jdtTimerVal = (long) this.bitmapJDW * this.originalTimerLen / 479L;
    this.labelNowTimer.Text = $"{this.LongToTimer(this.jdtTimerVal)}/{this.labelAllTimer.Text}";
    this.Invalidate();
  }

  private void UCBoFangQiKongZhi_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this.isMouseDown || this.isMouseMove)
      return;
    this.isMouseMove = true;
    this.xPos = e.X;
    if (this.xPos < 10)
      this.xPos = 10;
    if (this.xPos > 489)
      this.xPos = 489;
    this.bitmapJDW = this.xPos - 10;
    this.jdtTimerVal = (long) this.bitmapJDW * this.originalTimerLen / 479L;
    this.labelNowTimer.Text = $"{this.LongToTimer(this.jdtTimerVal)}/{this.labelAllTimer.Text}";
    this.Invalidate();
    this.isMouseMove = false;
  }

  private void UCBoFangQiKongZhi_MouseUp(object sender, MouseEventArgs e)
  {
    if (this.isMouseDown)
    {
      this.isStart = false;
      if (this.isGetVideoInfo)
      {
        this.dirVal = 1;
        this.dirCount = 1;
        this.nowDir = 1;
        this.nowTimerVal = (double) this.jdtTimerVal;
        if (this.nowTimerVal + 500.0 > (double) this.originalTimerLen)
          this.nowTimerVal = (double) (this.originalTimerLen - 500L);
        Thread.Sleep(100);
        this.nowStopTimerVal = (long) (int) this.nowTimerVal;
        this.ResetAllTempFile(this.boFangQiMuLu + "1\\");
        this.ResetAllTempFile(this.boFangQiMuLu + "2\\");
        this.FFmpeg_Video_Bmp();
        int num;
        for (num = 0; num < 35; ++num)
        {
          Thread.Sleep(100);
          if (File.Exists(this.boFangQiMuLu + "1\\0001.bmp"))
            break;
        }
        if (num == 35)
        {
          this.nowTimerVal = 0.0;
          this.nowStopTimerVal = (long) (int) this.nowTimerVal;
          this.FFmpeg_Video_Bmp();
          for (int index = 0; index < 35; ++index)
          {
            Thread.Sleep(100);
            if (File.Exists(this.boFangQiMuLu + "1\\0001.bmp"))
              break;
          }
        }
        this.isStart = true;
        this.button1.BackgroundImage = (Image) Resources.P0暂停;
      }
      else
      {
        this.isStart = false;
        this.button1.BackgroundImage = (Image) Resources.P0播放;
      }
    }
    this.isMouseDown = false;
  }

  public void SetNewFile(string name)
  {
    this.isStart = false;
    try
    {
      foreach (Process process in Process.GetProcesses())
      {
        if (process.ProcessName.Equals("ffmpeg"))
          process.Kill();
      }
    }
    catch (Exception ex)
    {
    }
    Thread.Sleep(100);
    this.boFangQiFile = name;
    this.SetImage(true);
    if (!this.isGetVideoInfo)
      return;
    this.button1_Click((object) null, (EventArgs) null);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.button1 = new Button();
    this.buttonTPJCW = new Button();
    this.buttonTPJCH = new Button();
    this.labelAllTimer = new Label();
    this.labelNowTimer = new Label();
    this.SuspendLayout();
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.P0播放;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(10, 26);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(34, 26);
    this.button1.TabIndex = 616;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.buttonTPJCW.BackColor = Color.Transparent;
    this.buttonTPJCW.BackgroundImage = (Image) Resources.P宽度适应;
    this.buttonTPJCW.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonTPJCW.FlatAppearance.BorderSize = 0;
    this.buttonTPJCW.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonTPJCW.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonTPJCW.FlatStyle = FlatStyle.Flat;
    this.buttonTPJCW.Location = new Point(108, 26);
    this.buttonTPJCW.Margin = new Padding(0);
    this.buttonTPJCW.Name = "buttonTPJCW";
    this.buttonTPJCW.Size = new Size(34, 26);
    this.buttonTPJCW.TabIndex = 653;
    this.buttonTPJCW.UseVisualStyleBackColor = false;
    this.buttonTPJCW.Click += new EventHandler(this.buttonTPJCW_Click);
    this.buttonTPJCH.BackColor = Color.Transparent;
    this.buttonTPJCH.BackgroundImage = (Image) Resources.P高度适应;
    this.buttonTPJCH.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonTPJCH.FlatAppearance.BorderSize = 0;
    this.buttonTPJCH.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonTPJCH.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonTPJCH.FlatStyle = FlatStyle.Flat;
    this.buttonTPJCH.Location = new Point(64 /*0x40*/, 26);
    this.buttonTPJCH.Margin = new Padding(0);
    this.buttonTPJCH.Name = "buttonTPJCH";
    this.buttonTPJCH.Size = new Size(34, 26);
    this.buttonTPJCH.TabIndex = 652;
    this.buttonTPJCH.UseVisualStyleBackColor = false;
    this.buttonTPJCH.Click += new EventHandler(this.buttonTPJCH_Click);
    this.labelAllTimer.BackColor = Color.Transparent;
    this.labelAllTimer.FlatStyle = FlatStyle.Flat;
    this.labelAllTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelAllTimer.ForeColor = Color.LightGray;
    this.labelAllTimer.Location = new Point(162, 26);
    this.labelAllTimer.Margin = new Padding(0);
    this.labelAllTimer.Name = "labelAllTimer";
    this.labelAllTimer.Size = new Size(88, 20);
    this.labelAllTimer.TabIndex = 701;
    this.labelAllTimer.Text = "00:00:00:000";
    this.labelAllTimer.TextAlign = ContentAlignment.MiddleCenter;
    this.labelAllTimer.Visible = false;
    this.labelNowTimer.BackColor = Color.Transparent;
    this.labelNowTimer.FlatStyle = FlatStyle.Flat;
    this.labelNowTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelNowTimer.ForeColor = Color.LightGray;
    this.labelNowTimer.Location = new Point(274, 26);
    this.labelNowTimer.Margin = new Padding(0);
    this.labelNowTimer.Name = "labelNowTimer";
    this.labelNowTimer.Size = new Size(220, 20);
    this.labelNowTimer.TabIndex = 702;
    this.labelNowTimer.Text = "00:00:00:000";
    this.labelNowTimer.TextAlign = ContentAlignment.MiddleRight;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P0播放器控制;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.labelAllTimer);
    this.Controls.Add((Control) this.labelNowTimer);
    this.Controls.Add((Control) this.buttonTPJCW);
    this.Controls.Add((Control) this.buttonTPJCH);
    this.Controls.Add((Control) this.button1);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCBoFangQiKongZhi);
    this.Size = new Size(500, 56);
    this.MouseDown += new MouseEventHandler(this.UCBoFangQiKongZhi_MouseDown);
    this.MouseMove += new MouseEventHandler(this.UCBoFangQiKongZhi_MouseMove);
    this.MouseUp += new MouseEventHandler(this.UCBoFangQiKongZhi_MouseUp);
    this.ResumeLayout(false);
  }
}

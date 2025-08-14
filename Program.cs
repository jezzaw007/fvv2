// Decompiled with JetBrains decompiler
// Type: TRCC.Program
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace TRCC;

internal static class Program
{
  public const int SW_RESTORE = 9;
  public static IntPtr formhwnd;

  [DllImport("user32.dll")]
  public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

  [DllImport("user32.dll ", SetLastError = true)]
  private static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

  [STAThread]
  private static void Main()
  {
    Process currentProcess = Process.GetCurrentProcess();
    Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName.Replace(".vshost", string.Empty));
    if (processesByName.Length > 1)
    {
      foreach (Process process in processesByName)
      {
        if (process.Id != currentProcess.Id)
        {
          if (process.MainWindowHandle.ToInt32() == 0)
          {
            Program.formhwnd = Program.FindWindow((string) null, "TRCC");
            Program.ShowWindow(Program.formhwnd, 9);
            Program.SwitchToThisWindow(Program.formhwnd, true);
          }
          else
            Program.SwitchToThisWindow(process.MainWindowHandle, true);
        }
      }
    }
    else
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}

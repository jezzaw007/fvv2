// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCScreenLED
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCScreenLED : UserControl
{
  public byte nowLedStyle = 1;
  public int myLedMode = 4;
  public Image imageBk;
  public const int LedCountVal1 = 30;
  public const int LedCountVal1s = 10;
  public const int LedCountVal2 = 84;
  public const int LedCountVal2s = 18;
  public const int LedCountVal3 = 64 /*0x40*/;
  public const int LedCountVal3s = 10;
  public const int LedCountVal4 = 31 /*0x1F*/;
  public const int LedCountVal4s = 14;
  public const int LedCountVal5 = 93;
  public const int LedCountVal5s = 23;
  public const int LedCountVal60 = 141;
  public const int LedCountVal6 = 124;
  public const int LedCountVal61 = 93;
  public const int LedCountVal6s = 72;
  private const int ZhuangshiX61 = 26;
  private const int ZhuangshiY61 = 17;
  private const int ZhuangshiX62 = 23;
  private const int ZhuangshiY62 = 221;
  private const int ZhuangshiX63 = 293;
  private const int ZhuangshiY63 = 274;
  private Image imageBk61;
  private Image imageBk62;
  private Image imageBk63;
  public const int LedCountVal70 = 146;
  public const int LedCountVal7 = 116;
  public const int LedCountVal71 = 104;
  public const int LedCountVal7s = 12;
  private const int ZhuangshiX71 = 30;
  private const int ZhuangshiY71 = 217;
  private const int ZhuangshiX72 = 195;
  private const int ZhuangshiY72 = 268;
  private Image imageBk71;
  public const int LedCountVal80 = 50;
  public const int LedCountVal8 = 18;
  public const int LedCountVal8s = 13;
  public const int LedCountVal90 = 63 /*0x3F*/;
  public const int LedCountVal9 = 61;
  public const int LedCountVal9s = 31 /*0x1F*/;
  private Image imageBk81;
  public const int LedCountVal10 = 38;
  public const int LedCountVal10s = 17;
  public const int LedCountValLF150 = 137;
  public const int LedCountValLF15 = 93;
  public const int LedCountValLF15s = 72;
  public const int LedCountValLF13s = 62;
  private Image imageLF13;
  public int Logo1 = 0;
  public int Logo2 = 1;
  public int MTNo = 1;
  public int GNo = 2;
  public int WATT = 1;
  public int MHz = 5;
  public int Cpu1 = 2;
  public int Cpu2 = 3;
  public int Gpu1 = 4;
  public int Gpu2 = 5;
  public int SSD = 6;
  public int HSD = 7;
  public int BFB = 8;
  public int SSD1 = 6;
  public int HSD1 = 7;
  public int BFB1 = 8;
  public int LEDA1 = 9;
  public int LEDB1 = 10;
  public int LEDC1 = 11;
  public int LEDD1 = 12;
  public int LEDE1 = 13;
  public int LEDF1 = 14;
  public int LEDG1 = 15;
  public int LEDA2 = 16 /*0x10*/;
  public int LEDB2 = 17;
  public int LEDC2 = 18;
  public int LEDD2 = 19;
  public int LEDE2 = 20;
  public int LEDF2 = 21;
  public int LEDG2 = 22;
  public int LEDA3 = 23;
  public int LEDB3 = 24;
  public int LEDC3 = 25;
  public int LEDD3 = 26;
  public int LEDE3 = 27;
  public int LEDF3 = 28;
  public int LEDG3 = 29;
  public int LEDA4 = 31 /*0x1F*/;
  public int LEDB4 = 32 /*0x20*/;
  public int LEDC4 = 33;
  public int LEDD4 = 34;
  public int LEDE4 = 35;
  public int LEDF4 = 36;
  public int LEDG4 = 37;
  public int LEDA5 = 38;
  public int LEDB5 = 39;
  public int LEDC5 = 40;
  public int LEDD5 = 41;
  public int LEDE5 = 42;
  public int LEDF5 = 43;
  public int LEDG5 = 44;
  public int LEDA6 = 45;
  public int LEDB6 = 46;
  public int LEDC6 = 47;
  public int LEDD6 = 48 /*0x30*/;
  public int LEDE6 = 49;
  public int LEDF6 = 50;
  public int LEDG6 = 51;
  public int LEDA7 = 52;
  public int LEDB7 = 53;
  public int LEDC7 = 54;
  public int LEDD7 = 55;
  public int LEDE7 = 56;
  public int LEDF7 = 57;
  public int LEDG7 = 58;
  public int LEDA8 = 59;
  public int LEDB8 = 60;
  public int LEDC8 = 61;
  public int LEDD8 = 62;
  public int LEDE8 = 63 /*0x3F*/;
  public int LEDF8 = 64 /*0x40*/;
  public int LEDG8 = 65;
  public int LEDA9 = 66;
  public int LEDB9 = 67;
  public int LEDC9 = 68;
  public int LEDD9 = 69;
  public int LEDE9 = 70;
  public int LEDF9 = 71;
  public int LEDG9 = 72;
  public int LEDA10 = 73;
  public int LEDB10 = 74;
  public int LEDC10 = 75;
  public int LEDD10 = 76;
  public int LEDE10 = 77;
  public int LEDF10 = 78;
  public int LEDG10 = 79;
  public int LEDB11 = 80 /*0x50*/;
  public int LEDC11 = 81;
  public int LEDB12 = 82;
  public int LEDC12 = 83;
  public int LEDA11 = 100;
  public int LEDD11 = 100;
  public int LEDE11 = 100;
  public int LEDF11 = 100;
  public int LEDG11 = 100;
  public int LEDA12 = 100;
  public int LEDD12 = 100;
  public int LEDE12 = 100;
  public int LEDF12 = 100;
  public int LEDG12 = 100;
  public int LEDA13 = 100;
  public int LEDB13 = 100;
  public int LEDC13 = 100;
  public int LEDD13 = 100;
  public int LEDE13 = 100;
  public int LEDF13 = 100;
  public int LEDG13 = 100;
  public int ZhuangShi1 = 93;
  public int ZhuangShi2 = 94;
  public int ZhuangShi3 = 95;
  public int ZhuangShi4 = 96 /*0x60*/;
  public int ZhuangShi5 = 97;
  public int ZhuangShi6 = 98;
  public int ZhuangShi7 = 99;
  public int ZhuangShi8 = 100;
  public int ZhuangShi9 = 101;
  public int ZhuangShi10 = 102;
  public int ZhuangShi11 = 103;
  public int ZhuangShi12 = 104;
  public int ZhuangShi13 = 105;
  public int ZhuangShi14 = 106;
  public int ZhuangShi15 = 107;
  public int ZhuangShi16 = 108;
  public int ZhuangShi17 = 109;
  public int ZhuangShi18 = 110;
  public int ZhuangShi19 = 111;
  public int ZhuangShi20 = 112 /*0x70*/;
  public int ZhuangShi21 = 113;
  public int ZhuangShi22 = 114;
  public int ZhuangShi23 = 115;
  public int ZhuangShi24 = 116;
  public int ZhuangShi25 = 117;
  public int ZhuangShi26 = 118;
  public int ZhuangShi27 = 119;
  public int ZhuangShi28 = 120;
  public int ZhuangShi29 = 121;
  public int ZhuangShi30 = 122;
  public int ZhuangShi31 = 123;
  public int ZhuangShi32 = 124;
  public int Shijian1 = 0;
  public int Shijian2 = 1;
  public int Riqi = 2;
  public int LEDH1 = 13;
  public int LEDI1 = 14;
  public int LEDJ1 = 15;
  public int LEDK1 = 16 /*0x10*/;
  public int LEDL1 = 17;
  public int LEDM1 = 18;
  public int LEDH2 = 26;
  public int LEDI2 = 27;
  public int LEDJ2 = 28;
  public int LEDK2 = 29;
  public int LEDL2 = 30;
  public int LEDM2 = 31 /*0x1F*/;
  public int LEDH3 = 39;
  public int LEDI3 = 40;
  public int LEDJ3 = 41;
  public int LEDK3 = 42;
  public int LEDL3 = 43;
  public int LEDM3 = 44;
  public int LEDH4 = 52;
  public int LEDI4 = 53;
  public int LEDJ4 = 54;
  public int LEDK4 = 55;
  public int LEDL4 = 56;
  public int LEDM4 = 57;
  public int LEDH5 = 65;
  public int LEDI5 = 66;
  public int LEDJ5 = 67;
  public int LEDK5 = 68;
  public int LEDL5 = 69;
  public int LEDM5 = 70;
  public int LEDH6 = 78;
  public int LEDI6 = 79;
  public int LEDJ6 = 80 /*0x50*/;
  public int LEDK6 = 81;
  public int LEDL6 = 82;
  public int LEDM6 = 83;
  public int[,] ledPosition1 = new int[30, 4]
  {
    {
      207,
      53,
      23,
      46
    },
    {
      230,
      53,
      23,
      46
    },
    {
      105,
      123,
      29,
      24
    },
    {
      134,
      123,
      29,
      24
    },
    {
      257,
      123,
      29,
      24
    },
    {
      286,
      123,
      29,
      24
    },
    {
      360,
      163,
      25,
      26
    },
    {
      360,
      222,
      25,
      26
    },
    {
      360,
      284,
      25,
      26
    },
    {
      80 /*0x50*/,
      163,
      68,
      12
    },
    {
      141,
      170,
      12,
      62
    },
    {
      141,
      241,
      12,
      62
    },
    {
      80 /*0x50*/,
      298,
      68,
      12
    },
    {
      75,
      241,
      12,
      62
    },
    {
      75,
      170,
      12,
      62
    },
    {
      84,
      229,
      60,
      15
    },
    {
      176 /*0xB0*/,
      163,
      68,
      12
    },
    {
      237,
      170,
      12,
      62
    },
    {
      237,
      241,
      12,
      62
    },
    {
      178,
      298,
      68,
      12
    },
    {
      171,
      241,
      12,
      62
    },
    {
      171,
      170,
      12,
      62
    },
    {
      180,
      229,
      60,
      15
    },
    {
      272,
      163,
      68,
      12
    },
    {
      333,
      170,
      12,
      62
    },
    {
      333,
      241,
      12,
      62
    },
    {
      272,
      298,
      68,
      12
    },
    {
      267,
      241,
      12,
      62
    },
    {
      267,
      170,
      12,
      62
    },
    {
      276,
      229,
      60,
      15
    }
  };
  public bool[] isOn1 = new bool[30]
  {
    true,
    true,
    true,
    true,
    false,
    false,
    true,
    false,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
  };
  public byte[,] ledColor1 = new byte[30, 3]
  {
    {
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue
    },
    {
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition2 = new int[84, 4]
  {
    {
      49,
      63 /*0x3F*/,
      39,
      25
    },
    {
      88,
      63 /*0x3F*/,
      39,
      25
    },
    {
      49,
      245,
      39,
      25
    },
    {
      88,
      245,
      39,
      25
    },
    {
      236,
      108,
      19,
      22
    },
    {
      231,
      167,
      20,
      22
    },
    {
      399,
      167,
      21,
      22
    },
    {
      236,
      290,
      19,
      22
    },
    {
      231,
      349,
      20,
      22
    },
    {
      399,
      349,
      21,
      22
    },
    {
      50,
      109,
      37,
      9
    },
    {
      81,
      116,
      12,
      29
    },
    {
      77,
      155,
      11,
      30
    },
    {
      44,
      182,
      37,
      9
    },
    {
      40,
      155,
      11,
      29
    },
    {
      42,
      115,
      12,
      30
    },
    {
      49,
      145,
      34,
      9
    },
    {
      112 /*0x70*/,
      109,
      37,
      9
    },
    {
      143,
      116,
      12,
      29
    },
    {
      139,
      155,
      11,
      30
    },
    {
      106,
      182,
      37,
      9
    },
    {
      102,
      155,
      11,
      29
    },
    {
      104,
      115,
      12,
      30
    },
    {
      111,
      145,
      34,
      9
    },
    {
      174,
      109,
      37,
      9
    },
    {
      205,
      116,
      12,
      29
    },
    {
      201,
      155,
      11,
      30
    },
    {
      168,
      182,
      37,
      9
    },
    {
      164,
      155,
      11,
      29
    },
    {
      166,
      115,
      12,
      30
    },
    {
      173,
      145,
      34,
      9
    },
    {
      303,
      126,
      29,
      7
    },
    {
      328,
      131,
      9,
      23
    },
    {
      325,
      161,
      9,
      23
    },
    {
      298,
      181,
      29,
      7
    },
    {
      294,
      161,
      9,
      22
    },
    {
      296,
      130,
      10,
      23
    },
    {
      302,
      153,
      27,
      7
    },
    {
      353,
      126,
      29,
      7
    },
    {
      378,
      131,
      9,
      23
    },
    {
      375,
      161,
      9,
      23
    },
    {
      348,
      181,
      29,
      7
    },
    {
      344,
      161,
      9,
      22
    },
    {
      346,
      130,
      10,
      23
    },
    {
      352,
      153,
      27,
      7
    },
    {
      50,
      291,
      37,
      9
    },
    {
      81,
      298,
      12,
      29
    },
    {
      77,
      337,
      11,
      30
    },
    {
      44,
      364,
      37,
      9
    },
    {
      40,
      337,
      11,
      29
    },
    {
      42,
      297,
      12,
      30
    },
    {
      49,
      327,
      34,
      9
    },
    {
      112 /*0x70*/,
      291,
      37,
      9
    },
    {
      143,
      298,
      12,
      29
    },
    {
      139,
      337,
      11,
      30
    },
    {
      106,
      364,
      37,
      9
    },
    {
      102,
      337,
      11,
      29
    },
    {
      104,
      297,
      12,
      30
    },
    {
      111,
      327,
      34,
      9
    },
    {
      174,
      291,
      37,
      9
    },
    {
      205,
      298,
      12,
      29
    },
    {
      201,
      337,
      11,
      30
    },
    {
      168,
      364,
      37,
      9
    },
    {
      164,
      337,
      11,
      29
    },
    {
      166,
      297,
      12,
      30
    },
    {
      173,
      327,
      34,
      9
    },
    {
      303,
      308,
      29,
      7
    },
    {
      328,
      313,
      9,
      23
    },
    {
      325,
      343,
      9,
      23
    },
    {
      298,
      363,
      29,
      7
    },
    {
      294,
      343,
      9,
      22
    },
    {
      296,
      312,
      10,
      23
    },
    {
      302,
      335,
      27,
      7
    },
    {
      353,
      308,
      29,
      7
    },
    {
      378,
      313,
      9,
      23
    },
    {
      375,
      343,
      9,
      23
    },
    {
      348,
      363,
      29,
      7
    },
    {
      344,
      343,
      9,
      22
    },
    {
      346,
      312,
      10,
      23
    },
    {
      352,
      335,
      27,
      7
    },
    {
      278,
      131,
      9,
      23
    },
    {
      275,
      161,
      9,
      23
    },
    {
      278,
      313,
      9,
      23
    },
    {
      275,
      343,
      9,
      23
    }
  };
  public bool[] isOn2 = new bool[84]
  {
    true,
    true,
    true,
    true,
    true,
    false,
    true,
    true,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
  };
  public byte[,] ledColor2 = new byte[84, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition3 = new int[64 /*0x40*/, 4]
  {
    {
      202,
      34,
      56,
      20
    },
    {
      312,
      (int) sbyte.MaxValue,
      29,
      29
    },
    {
      312,
      190,
      29,
      29
    },
    {
      312,
      241,
      29,
      29
    },
    {
      312,
      355,
      29,
      29
    },
    {
      202,
      405,
      56,
      20
    },
    {
      124,
      69,
      43,
      8
    },
    {
      163,
      73,
      8,
      40
    },
    {
      163,
      119,
      8,
      40
    },
    {
      124,
      155,
      43,
      8
    },
    {
      120,
      119,
      8,
      40
    },
    {
      120,
      73,
      8,
      40
    },
    {
      126,
      111,
      39,
      10
    },
    {
      186,
      69,
      43,
      8
    },
    {
      225,
      73,
      8,
      40
    },
    {
      225,
      119,
      8,
      40
    },
    {
      186,
      155,
      43,
      8
    },
    {
      182,
      119,
      8,
      40
    },
    {
      182,
      73,
      8,
      40
    },
    {
      188,
      111,
      39,
      10
    },
    {
      248,
      69,
      43,
      8
    },
    {
      287,
      73,
      8,
      40
    },
    {
      287,
      119,
      8,
      40
    },
    {
      248,
      155,
      43,
      8
    },
    {
      244,
      119,
      8,
      40
    },
    {
      244,
      73,
      8,
      40
    },
    {
      250,
      111,
      39,
      10
    },
    {
      124,
      183,
      43,
      8
    },
    {
      163,
      187,
      8,
      40
    },
    {
      163,
      233,
      8,
      40
    },
    {
      124,
      269,
      43,
      8
    },
    {
      120,
      233,
      8,
      40
    },
    {
      120,
      187,
      8,
      40
    },
    {
      126,
      225,
      39,
      10
    },
    {
      186,
      183,
      43,
      8
    },
    {
      225,
      187,
      8,
      40
    },
    {
      225,
      233,
      8,
      40
    },
    {
      186,
      269,
      43,
      8
    },
    {
      182,
      233,
      8,
      40
    },
    {
      182,
      187,
      8,
      40
    },
    {
      188,
      225,
      39,
      10
    },
    {
      248,
      183,
      43,
      8
    },
    {
      287,
      187,
      8,
      40
    },
    {
      287,
      233,
      8,
      40
    },
    {
      248,
      269,
      43,
      8
    },
    {
      244,
      233,
      8,
      40
    },
    {
      244,
      187,
      8,
      40
    },
    {
      250,
      225,
      39,
      10
    },
    {
      186,
      297,
      43,
      8
    },
    {
      225,
      301,
      8,
      40
    },
    {
      225,
      347,
      8,
      40
    },
    {
      186,
      383,
      43,
      8
    },
    {
      182,
      347,
      8,
      40
    },
    {
      182,
      301,
      8,
      40
    },
    {
      188,
      339,
      39,
      10
    },
    {
      248,
      297,
      43,
      8
    },
    {
      287,
      301,
      8,
      40
    },
    {
      287,
      347,
      8,
      40
    },
    {
      248,
      383,
      43,
      8
    },
    {
      244,
      347,
      8,
      40
    },
    {
      244,
      301,
      8,
      40
    },
    {
      250,
      339,
      39,
      10
    },
    {
      163,
      301,
      8,
      40
    },
    {
      163,
      347,
      8,
      40
    }
  };
  public bool[] isOn3 = new bool[64 /*0x40*/]
  {
    true,
    true,
    true,
    false,
    true,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
  };
  public byte[,] ledColor3 = new byte[64 /*0x40*/, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition4 = new int[31 /*0x1F*/, 4]
  {
    {
      277,
      162,
      12,
      12
    },
    {
      370,
      190,
      26,
      27
    },
    {
      370,
      243,
      26,
      27
    },
    {
      73,
      179,
      40,
      8
    },
    {
      113,
      187,
      8,
      36
    },
    {
      113,
      237,
      8,
      36
    },
    {
      73,
      273,
      40,
      8
    },
    {
      65,
      237,
      8,
      36
    },
    {
      65,
      187,
      8,
      36
    },
    {
      73,
      226,
      40,
      8
    },
    {
      149,
      179,
      40,
      8
    },
    {
      189,
      187,
      8,
      36
    },
    {
      189,
      237,
      8,
      36
    },
    {
      149,
      273,
      40,
      8
    },
    {
      141,
      237,
      8,
      36
    },
    {
      141,
      187,
      8,
      36
    },
    {
      149,
      226,
      40,
      8
    },
    {
      225,
      179,
      40,
      8
    },
    {
      265,
      187,
      8,
      36
    },
    {
      265,
      237,
      8,
      36
    },
    {
      225,
      273,
      40,
      8
    },
    {
      217,
      237,
      8,
      36
    },
    {
      217,
      187,
      8,
      36
    },
    {
      225,
      226,
      40,
      8
    },
    {
      301,
      179,
      40,
      8
    },
    {
      341,
      187,
      8,
      36
    },
    {
      341,
      237,
      8,
      36
    },
    {
      301,
      273,
      40,
      8
    },
    {
      293,
      237,
      8,
      36
    },
    {
      293,
      187,
      8,
      36
    },
    {
      301,
      226,
      40,
      8
    }
  };
  public bool[] isOn4 = new bool[31 /*0x1F*/]
  {
    true,
    false,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    false,
    false,
    true,
    true,
    true,
    false
  };
  public byte[,] ledColor4 = new byte[31 /*0x1F*/, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition5 = new int[93, 4]
  {
    {
      43,
      98,
      46,
      20
    },
    {
      99,
      98,
      46,
      20
    },
    {
      211,
      136,
      27,
      27
    },
    {
      213,
      179,
      27,
      27
    },
    {
      404,
      189,
      22,
      18
    },
    {
      249,
      330,
      42,
      26
    },
    {
      408,
      335,
      22,
      22
    },
    {
      49,
      133,
      34,
      6
    },
    {
      81,
      137,
      6,
      32 /*0x20*/
    },
    {
      81,
      173,
      6,
      32 /*0x20*/
    },
    {
      49,
      203,
      34,
      6
    },
    {
      45,
      173,
      6,
      32 /*0x20*/
    },
    {
      45,
      137,
      6,
      32 /*0x20*/
    },
    {
      49,
      167,
      34,
      8
    },
    {
      105,
      133,
      34,
      6
    },
    {
      137,
      137,
      6,
      32 /*0x20*/
    },
    {
      137,
      173,
      6,
      32 /*0x20*/
    },
    {
      105,
      203,
      34,
      6
    },
    {
      101,
      173,
      6,
      32 /*0x20*/
    },
    {
      101,
      137,
      6,
      32 /*0x20*/
    },
    {
      105,
      167,
      34,
      8
    },
    {
      161,
      133,
      34,
      6
    },
    {
      193,
      137,
      6,
      32 /*0x20*/
    },
    {
      193,
      173,
      6,
      32 /*0x20*/
    },
    {
      161,
      203,
      34,
      6
    },
    {
      157,
      173,
      6,
      32 /*0x20*/
    },
    {
      157,
      137,
      6,
      32 /*0x20*/
    },
    {
      161,
      167,
      34,
      8
    },
    {
      274,
      152,
      27,
      4
    },
    {
      300,
      155,
      4,
      24
    },
    {
      300,
      182,
      4,
      24
    },
    {
      274,
      205,
      27,
      4
    },
    {
      271,
      182,
      4,
      24
    },
    {
      271,
      155,
      4,
      24
    },
    {
      274,
      178,
      27,
      5
    },
    {
      317,
      152,
      27,
      4
    },
    {
      343,
      155,
      4,
      24
    },
    {
      343,
      182,
      4,
      24
    },
    {
      317,
      205,
      27,
      4
    },
    {
      314,
      182,
      4,
      24
    },
    {
      314,
      155,
      4,
      24
    },
    {
      317,
      178,
      27,
      5
    },
    {
      360,
      152,
      27,
      4
    },
    {
      386,
      155,
      4,
      24
    },
    {
      386,
      182,
      4,
      24
    },
    {
      360,
      205,
      27,
      4
    },
    {
      357,
      182,
      4,
      24
    },
    {
      357,
      155,
      4,
      24
    },
    {
      360,
      178,
      27,
      5
    },
    {
      30,
      283,
      34,
      6
    },
    {
      62,
      287,
      6,
      32 /*0x20*/
    },
    {
      62,
      323,
      6,
      32 /*0x20*/
    },
    {
      30,
      353,
      34,
      6
    },
    {
      26,
      323,
      6,
      32 /*0x20*/
    },
    {
      26,
      287,
      6,
      32 /*0x20*/
    },
    {
      30,
      317,
      34,
      8
    },
    {
      86,
      283,
      34,
      6
    },
    {
      118,
      287,
      6,
      32 /*0x20*/
    },
    {
      118,
      323,
      6,
      32 /*0x20*/
    },
    {
      86,
      353,
      34,
      6
    },
    {
      82,
      323,
      6,
      32 /*0x20*/
    },
    {
      82,
      287,
      6,
      32 /*0x20*/
    },
    {
      86,
      317,
      34,
      8
    },
    {
      142,
      283,
      34,
      6
    },
    {
      174,
      287,
      6,
      32 /*0x20*/
    },
    {
      174,
      323,
      6,
      32 /*0x20*/
    },
    {
      142,
      353,
      34,
      6
    },
    {
      138,
      323,
      6,
      32 /*0x20*/
    },
    {
      138,
      287,
      6,
      32 /*0x20*/
    },
    {
      142,
      317,
      34,
      8
    },
    {
      197,
      283,
      34,
      6
    },
    {
      229,
      287,
      6,
      32 /*0x20*/
    },
    {
      229,
      323,
      6,
      32 /*0x20*/
    },
    {
      197,
      353,
      34,
      6
    },
    {
      193,
      323,
      6,
      32 /*0x20*/
    },
    {
      193,
      287,
      6,
      32 /*0x20*/
    },
    {
      197,
      317,
      34,
      8
    },
    {
      321,
      302,
      27,
      4
    },
    {
      347,
      305,
      4,
      24
    },
    {
      347,
      332,
      4,
      24
    },
    {
      321,
      355,
      27,
      4
    },
    {
      318,
      332,
      4,
      24
    },
    {
      318,
      305,
      4,
      24
    },
    {
      321,
      328,
      27,
      5
    },
    {
      364,
      302,
      27,
      4
    },
    {
      390,
      305,
      4,
      24
    },
    {
      390,
      332,
      4,
      24
    },
    {
      364,
      355,
      27,
      4
    },
    {
      361,
      332,
      4,
      24
    },
    {
      361,
      305,
      4,
      24
    },
    {
      364,
      328,
      27,
      5
    },
    {
      304,
      305,
      4,
      24
    },
    {
      304,
      332,
      4,
      24
    }
  };
  public bool[] isOn5 = new bool[93]
  {
    true,
    false,
    true,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
  };
  public byte[,] ledColor5 = new byte[93, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition6 = new int[93, 4]
  {
    {
      106,
      121,
      36,
      18
    },
    {
      183,
      121,
      36,
      18
    },
    {
      228,
      155,
      18,
      17
    },
    {
      228,
      183,
      18,
      17
    },
    {
      363,
      190,
      10,
      11
    },
    {
      246,
      313,
      32 /*0x20*/,
      18
    },
    {
      376,
      323,
      8,
      11
    },
    {
      110,
      152,
      24,
      4
    },
    {
      133,
      155,
      4,
      22
    },
    {
      133,
      179,
      4,
      22
    },
    {
      110,
      200,
      24,
      4
    },
    {
      107,
      179,
      4,
      22
    },
    {
      107,
      155,
      4,
      22
    },
    {
      110,
      176 /*0xB0*/,
      24,
      4
    },
    {
      150,
      152,
      24,
      4
    },
    {
      173,
      155,
      4,
      22
    },
    {
      173,
      179,
      4,
      22
    },
    {
      150,
      200,
      24,
      4
    },
    {
      147,
      179,
      4,
      22
    },
    {
      147,
      155,
      4,
      22
    },
    {
      150,
      176 /*0xB0*/,
      24,
      4
    },
    {
      190,
      152,
      24,
      4
    },
    {
      213,
      155,
      4,
      22
    },
    {
      213,
      179,
      4,
      22
    },
    {
      190,
      200,
      24,
      4
    },
    {
      187,
      179,
      4,
      22
    },
    {
      187,
      155,
      4,
      22
    },
    {
      190,
      176 /*0xB0*/,
      24,
      4
    },
    {
      270,
      163,
      19,
      3
    },
    {
      288,
      165,
      3,
      17
    },
    {
      288,
      185,
      3,
      17
    },
    {
      270,
      201,
      19,
      3
    },
    {
      268,
      185,
      3,
      17
    },
    {
      268,
      165,
      3,
      17
    },
    {
      269,
      182,
      21,
      3
    },
    {
      301,
      163,
      19,
      3
    },
    {
      319,
      165,
      3,
      17
    },
    {
      319,
      185,
      3,
      17
    },
    {
      301,
      201,
      19,
      3
    },
    {
      299,
      185,
      3,
      17
    },
    {
      299,
      165,
      3,
      17
    },
    {
      300,
      182,
      21,
      3
    },
    {
      332,
      163,
      19,
      3
    },
    {
      350,
      165,
      3,
      17
    },
    {
      350,
      185,
      3,
      17
    },
    {
      332,
      201,
      19,
      3
    },
    {
      330,
      185,
      3,
      17
    },
    {
      330,
      165,
      3,
      17
    },
    {
      331,
      182,
      21,
      3
    },
    {
      88,
      282,
      24,
      4
    },
    {
      111,
      285,
      4,
      22
    },
    {
      111,
      309,
      4,
      22
    },
    {
      88,
      330,
      24,
      4
    },
    {
      85,
      309,
      4,
      22
    },
    {
      85,
      285,
      4,
      22
    },
    {
      88,
      306,
      24,
      4
    },
    {
      128 /*0x80*/,
      282,
      24,
      4
    },
    {
      151,
      285,
      4,
      22
    },
    {
      151,
      309,
      4,
      22
    },
    {
      128 /*0x80*/,
      330,
      24,
      4
    },
    {
      125,
      309,
      4,
      22
    },
    {
      125,
      285,
      4,
      22
    },
    {
      128 /*0x80*/,
      306,
      24,
      4
    },
    {
      168,
      282,
      24,
      4
    },
    {
      191,
      285,
      4,
      22
    },
    {
      191,
      309,
      4,
      22
    },
    {
      168,
      330,
      24,
      4
    },
    {
      165,
      309,
      4,
      22
    },
    {
      165,
      285,
      4,
      22
    },
    {
      168,
      306,
      24,
      4
    },
    {
      208 /*0xD0*/,
      282,
      24,
      4
    },
    {
      231,
      285,
      4,
      22
    },
    {
      231,
      309,
      4,
      22
    },
    {
      208 /*0xD0*/,
      330,
      24,
      4
    },
    {
      205,
      309,
      4,
      22
    },
    {
      205,
      285,
      4,
      22
    },
    {
      208 /*0xD0*/,
      306,
      24,
      4
    },
    {
      312,
      293,
      19,
      3
    },
    {
      330,
      295,
      3,
      17
    },
    {
      330,
      315,
      3,
      17
    },
    {
      312,
      331,
      19,
      3
    },
    {
      310,
      315,
      3,
      17
    },
    {
      310,
      295,
      3,
      17
    },
    {
      311,
      312,
      21,
      3
    },
    {
      343,
      293,
      19,
      3
    },
    {
      361,
      295,
      3,
      17
    },
    {
      361,
      315,
      3,
      17
    },
    {
      343,
      331,
      19,
      3
    },
    {
      341,
      315,
      3,
      17
    },
    {
      341,
      295,
      3,
      17
    },
    {
      342,
      312,
      21,
      3
    },
    {
      299,
      295,
      3,
      17
    },
    {
      299,
      315,
      3,
      17
    }
  };
  public bool[] isOn6 = new bool[124]
  {
    true,
    false,
    true,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
  };
  public byte[,] ledColor6 = new byte[124, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition7 = new int[104, 4]
  {
    {
      50,
      279,
      42,
      15
    },
    {
      167,
      310,
      22,
      28
    },
    {
      167,
      342,
      22,
      28
    },
    {
      276,
      279,
      42,
      15
    },
    {
      393,
      310,
      22,
      28
    },
    {
      393,
      342,
      22,
      28
    },
    {
      45,
      318,
      5,
      5
    },
    {
      52,
      318,
      19,
      5
    },
    {
      73,
      318,
      5,
      5
    },
    {
      73,
      325,
      5,
      12
    },
    {
      73,
      339,
      5,
      5
    },
    {
      73,
      346,
      5,
      12
    },
    {
      73,
      360,
      5,
      5
    },
    {
      52,
      360,
      19,
      5
    },
    {
      45,
      360,
      5,
      5
    },
    {
      45,
      346,
      5,
      12
    },
    {
      45,
      339,
      5,
      5
    },
    {
      45,
      325,
      5,
      12
    },
    {
      52,
      339,
      19,
      5
    },
    {
      85,
      318,
      5,
      5
    },
    {
      92,
      318,
      19,
      5
    },
    {
      113,
      318,
      5,
      5
    },
    {
      113,
      325,
      5,
      12
    },
    {
      113,
      339,
      5,
      5
    },
    {
      113,
      346,
      5,
      12
    },
    {
      113,
      360,
      5,
      5
    },
    {
      92,
      360,
      19,
      5
    },
    {
      85,
      360,
      5,
      5
    },
    {
      85,
      346,
      5,
      12
    },
    {
      85,
      339,
      5,
      5
    },
    {
      85,
      325,
      5,
      12
    },
    {
      92,
      339,
      19,
      5
    },
    {
      125,
      318,
      5,
      5
    },
    {
      132,
      318,
      19,
      5
    },
    {
      153,
      318,
      5,
      5
    },
    {
      153,
      325,
      5,
      12
    },
    {
      153,
      339,
      5,
      5
    },
    {
      153,
      346,
      5,
      12
    },
    {
      153,
      360,
      5,
      5
    },
    {
      132,
      360,
      19,
      5
    },
    {
      125,
      360,
      5,
      5
    },
    {
      125,
      346,
      5,
      12
    },
    {
      125,
      339,
      5,
      5
    },
    {
      125,
      325,
      5,
      12
    },
    {
      132,
      339,
      19,
      5
    },
    {
      271,
      318,
      5,
      5
    },
    {
      278,
      318,
      19,
      5
    },
    {
      299,
      318,
      5,
      5
    },
    {
      299,
      325,
      5,
      12
    },
    {
      299,
      339,
      5,
      5
    },
    {
      299,
      346,
      5,
      12
    },
    {
      299,
      360,
      5,
      5
    },
    {
      278,
      360,
      19,
      5
    },
    {
      271,
      360,
      5,
      5
    },
    {
      271,
      346,
      5,
      12
    },
    {
      271,
      339,
      5,
      5
    },
    {
      271,
      325,
      5,
      12
    },
    {
      278,
      339,
      19,
      5
    },
    {
      311,
      318,
      5,
      5
    },
    {
      318,
      318,
      19,
      5
    },
    {
      339,
      318,
      5,
      5
    },
    {
      339,
      325,
      5,
      12
    },
    {
      339,
      339,
      5,
      5
    },
    {
      339,
      346,
      5,
      12
    },
    {
      339,
      360,
      5,
      5
    },
    {
      318,
      360,
      19,
      5
    },
    {
      311,
      360,
      5,
      5
    },
    {
      311,
      346,
      5,
      12
    },
    {
      311,
      339,
      5,
      5
    },
    {
      311,
      325,
      5,
      12
    },
    {
      318,
      339,
      19,
      5
    },
    {
      351,
      318,
      5,
      5
    },
    {
      358,
      318,
      19,
      5
    },
    {
      379,
      318,
      5,
      5
    },
    {
      379,
      325,
      5,
      12
    },
    {
      379,
      339,
      5,
      5
    },
    {
      379,
      346,
      5,
      12
    },
    {
      379,
      360,
      5,
      5
    },
    {
      358,
      360,
      19,
      5
    },
    {
      351,
      360,
      5,
      5
    },
    {
      351,
      346,
      5,
      12
    },
    {
      351,
      339,
      5,
      5
    },
    {
      351,
      325,
      5,
      12
    },
    {
      358,
      339,
      19,
      5
    },
    {
      48 /*0x30*/,
      392,
      8,
      21
    },
    {
      61,
      392,
      8,
      21
    },
    {
      74,
      392,
      8,
      21
    },
    {
      87,
      392,
      8,
      21
    },
    {
      100,
      392,
      8,
      21
    },
    {
      113,
      392,
      8,
      21
    },
    {
      126,
      392,
      8,
      21
    },
    {
      139,
      392,
      8,
      21
    },
    {
      152,
      392,
      8,
      21
    },
    {
      165,
      392,
      8,
      21
    },
    {
      274,
      392,
      8,
      21
    },
    {
      287,
      392,
      8,
      21
    },
    {
      300,
      392,
      8,
      21
    },
    {
      313,
      392,
      8,
      21
    },
    {
      326,
      392,
      8,
      21
    },
    {
      339,
      392,
      8,
      21
    },
    {
      352,
      392,
      8,
      21
    },
    {
      365,
      392,
      8,
      21
    },
    {
      378,
      392,
      8,
      21
    },
    {
      391,
      392,
      8,
      21
    }
  };
  public bool[] isOn7 = new bool[116]
  {
    true,
    true,
    false,
    true,
    true,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
  };
  public byte[,] ledColor7 = new byte[116, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition8 = new int[18, 4]
  {
    {
      73,
      114,
      73,
      16 /*0x10*/
    },
    {
      313,
      114,
      73,
      16 /*0x10*/
    },
    {
      73,
      330,
      73,
      16 /*0x10*/
    },
    {
      313,
      330,
      73,
      16 /*0x10*/
    },
    {
      24,
      0,
      172,
      30
    },
    {
      190,
      24,
      30,
      196
    },
    {
      190,
      240 /*0xF0*/,
      30,
      196
    },
    {
      24,
      430,
      172,
      30
    },
    {
      0,
      240 /*0xF0*/,
      30,
      196
    },
    {
      0,
      24,
      30,
      196
    },
    {
      24,
      215,
      172,
      30
    },
    {
      264,
      0,
      172,
      30
    },
    {
      430,
      24,
      30,
      196
    },
    {
      430,
      240 /*0xF0*/,
      30,
      196
    },
    {
      264,
      430,
      172,
      30
    },
    {
      240 /*0xF0*/,
      240 /*0xF0*/,
      30,
      196
    },
    {
      240 /*0xF0*/,
      24,
      30,
      196
    },
    {
      264,
      215,
      172,
      30
    }
  };
  public bool[] isOn8 = new bool[18]
  {
    true,
    false,
    false,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
  };
  public byte[,] ledColor8 = new byte[18, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition9 = new int[61, 4]
  {
    {
      223,
      122,
      14,
      14
    },
    {
      223,
      166,
      14,
      14
    },
    {
      230,
      236,
      44,
      74
    },
    {
      80 /*0x50*/,
      103,
      44,
      7
    },
    {
      122,
      108,
      7,
      41
    },
    {
      122,
      153,
      7,
      41
    },
    {
      80 /*0x50*/,
      192 /*0xC0*/,
      44,
      7
    },
    {
      75,
      153,
      7,
      41
    },
    {
      75,
      108,
      7,
      41
    },
    {
      80 /*0x50*/,
      147,
      44,
      8
    },
    {
      154,
      103,
      44,
      7
    },
    {
      196,
      108,
      7,
      41
    },
    {
      196,
      153,
      7,
      41
    },
    {
      154,
      192 /*0xC0*/,
      44,
      7
    },
    {
      149,
      153,
      7,
      41
    },
    {
      149,
      108,
      7,
      41
    },
    {
      154,
      147,
      44,
      8
    },
    {
      262,
      103,
      44,
      7
    },
    {
      304,
      108,
      7,
      41
    },
    {
      304,
      153,
      7,
      41
    },
    {
      262,
      192 /*0xC0*/,
      44,
      7
    },
    {
      257,
      153,
      7,
      41
    },
    {
      257,
      108,
      7,
      41
    },
    {
      262,
      147,
      44,
      8
    },
    {
      336,
      103,
      44,
      7
    },
    {
      378,
      108,
      7,
      41
    },
    {
      378,
      153,
      7,
      41
    },
    {
      336,
      192 /*0xC0*/,
      44,
      7
    },
    {
      331,
      153,
      7,
      41
    },
    {
      331,
      108,
      7,
      41
    },
    {
      336,
      147,
      44,
      8
    },
    {
      184,
      233,
      36,
      7
    },
    {
      218,
      238,
      7,
      33
    },
    {
      218,
      275,
      7,
      33
    },
    {
      184,
      306,
      36,
      7
    },
    {
      179,
      275,
      7,
      33
    },
    {
      179,
      238,
      7,
      33
    },
    {
      184,
      269,
      36,
      8
    },
    {
      284,
      233,
      36,
      7
    },
    {
      318,
      238,
      7,
      33
    },
    {
      318,
      275,
      7,
      33
    },
    {
      284,
      306,
      36,
      7
    },
    {
      279,
      275,
      7,
      33
    },
    {
      279,
      238,
      7,
      33
    },
    {
      284,
      269,
      36,
      8
    },
    {
      344,
      233,
      36,
      7
    },
    {
      378,
      238,
      7,
      33
    },
    {
      378,
      275,
      7,
      33
    },
    {
      344,
      306,
      36,
      7
    },
    {
      339,
      275,
      7,
      33
    },
    {
      339,
      238,
      7,
      33
    },
    {
      344,
      269,
      36,
      8
    },
    {
      158,
      238,
      7,
      33
    },
    {
      158,
      275,
      7,
      33
    },
    {
      54,
      343,
      40,
      14
    },
    {
      106,
      343,
      40,
      14
    },
    {
      158,
      343,
      40,
      14
    },
    {
      210,
      343,
      40,
      14
    },
    {
      262,
      343,
      40,
      14
    },
    {
      314,
      343,
      40,
      14
    },
    {
      366,
      343,
      40,
      14
    }
  };
  public bool[] isOn9 = new bool[61]
  {
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
  };
  public byte[,] ledColor9 = new byte[61, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition10 = new int[38, 4]
  {
    {
      318,
      163,
      10,
      10
    },
    {
      410,
      190,
      26,
      27
    },
    {
      410,
      243,
      26,
      27
    },
    {
      37,
      179,
      40,
      8
    },
    {
      77,
      187,
      8,
      36
    },
    {
      77,
      237,
      8,
      36
    },
    {
      37,
      273,
      40,
      8
    },
    {
      29,
      237,
      8,
      36
    },
    {
      29,
      187,
      8,
      36
    },
    {
      37,
      226,
      40,
      8
    },
    {
      113,
      179,
      40,
      8
    },
    {
      153,
      187,
      8,
      36
    },
    {
      153,
      237,
      8,
      36
    },
    {
      113,
      273,
      40,
      8
    },
    {
      105,
      237,
      8,
      36
    },
    {
      105,
      187,
      8,
      36
    },
    {
      113,
      226,
      40,
      8
    },
    {
      189,
      179,
      40,
      8
    },
    {
      229,
      187,
      8,
      36
    },
    {
      229,
      237,
      8,
      36
    },
    {
      189,
      273,
      40,
      8
    },
    {
      181,
      237,
      8,
      36
    },
    {
      181,
      187,
      8,
      36
    },
    {
      189,
      226,
      40,
      8
    },
    {
      265,
      179,
      40,
      8
    },
    {
      305,
      187,
      8,
      36
    },
    {
      305,
      237,
      8,
      36
    },
    {
      265,
      273,
      40,
      8
    },
    {
      257,
      237,
      8,
      36
    },
    {
      257,
      187,
      8,
      36
    },
    {
      265,
      226,
      40,
      8
    },
    {
      341,
      179,
      40,
      8
    },
    {
      381,
      187,
      8,
      36
    },
    {
      381,
      237,
      8,
      36
    },
    {
      341,
      273,
      40,
      8
    },
    {
      333,
      237,
      8,
      36
    },
    {
      333,
      187,
      8,
      36
    },
    {
      341,
      226,
      40,
      8
    }
  };
  public bool[] isOn10 = new bool[38]
  {
    true,
    false,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    false,
    false,
    true,
    true,
    true,
    false
  };
  public byte[,] ledColor10 = new byte[38, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPositionLF15 = new int[93, 4]
  {
    {
      84,
      131,
      36,
      18
    },
    {
      84,
      151,
      36,
      18
    },
    {
      206,
      185,
      18,
      17
    },
    {
      206,
      213,
      18,
      17
    },
    {
      341,
      220,
      10,
      11
    },
    {
      246,
      313,
      32 /*0x20*/,
      18
    },
    {
      376,
      323,
      8,
      11
    },
    {
      88,
      182,
      24,
      4
    },
    {
      111,
      185,
      4,
      22
    },
    {
      111,
      209,
      4,
      22
    },
    {
      88,
      230,
      24,
      4
    },
    {
      85,
      209,
      4,
      22
    },
    {
      85,
      185,
      4,
      22
    },
    {
      88,
      206,
      24,
      4
    },
    {
      128 /*0x80*/,
      182,
      24,
      4
    },
    {
      151,
      185,
      4,
      22
    },
    {
      151,
      209,
      4,
      22
    },
    {
      128 /*0x80*/,
      230,
      24,
      4
    },
    {
      125,
      209,
      4,
      22
    },
    {
      125,
      185,
      4,
      22
    },
    {
      128 /*0x80*/,
      206,
      24,
      4
    },
    {
      168,
      182,
      24,
      4
    },
    {
      191,
      185,
      4,
      22
    },
    {
      191,
      209,
      4,
      22
    },
    {
      168,
      230,
      24,
      4
    },
    {
      165,
      209,
      4,
      22
    },
    {
      165,
      185,
      4,
      22
    },
    {
      168,
      206,
      24,
      4
    },
    {
      248,
      193,
      19,
      3
    },
    {
      266,
      195,
      3,
      17
    },
    {
      266,
      215,
      3,
      17
    },
    {
      248,
      231,
      19,
      3
    },
    {
      246,
      215,
      3,
      17
    },
    {
      246,
      195,
      3,
      17
    },
    {
      247,
      212,
      21,
      3
    },
    {
      279,
      193,
      19,
      3
    },
    {
      297,
      195,
      3,
      17
    },
    {
      297,
      215,
      3,
      17
    },
    {
      279,
      231,
      19,
      3
    },
    {
      277,
      215,
      3,
      17
    },
    {
      277,
      195,
      3,
      17
    },
    {
      278,
      212,
      21,
      3
    },
    {
      310,
      193,
      19,
      3
    },
    {
      328,
      195,
      3,
      17
    },
    {
      328,
      215,
      3,
      17
    },
    {
      310,
      231,
      19,
      3
    },
    {
      308,
      215,
      3,
      17
    },
    {
      308,
      195,
      3,
      17
    },
    {
      309,
      212,
      21,
      3
    },
    {
      88,
      282,
      24,
      4
    },
    {
      111,
      285,
      4,
      22
    },
    {
      111,
      309,
      4,
      22
    },
    {
      88,
      330,
      24,
      4
    },
    {
      85,
      309,
      4,
      22
    },
    {
      85,
      285,
      4,
      22
    },
    {
      88,
      306,
      24,
      4
    },
    {
      128 /*0x80*/,
      282,
      24,
      4
    },
    {
      151,
      285,
      4,
      22
    },
    {
      151,
      309,
      4,
      22
    },
    {
      128 /*0x80*/,
      330,
      24,
      4
    },
    {
      125,
      309,
      4,
      22
    },
    {
      125,
      285,
      4,
      22
    },
    {
      128 /*0x80*/,
      306,
      24,
      4
    },
    {
      168,
      282,
      24,
      4
    },
    {
      191,
      285,
      4,
      22
    },
    {
      191,
      309,
      4,
      22
    },
    {
      168,
      330,
      24,
      4
    },
    {
      165,
      309,
      4,
      22
    },
    {
      165,
      285,
      4,
      22
    },
    {
      168,
      306,
      24,
      4
    },
    {
      208 /*0xD0*/,
      282,
      24,
      4
    },
    {
      231,
      285,
      4,
      22
    },
    {
      231,
      309,
      4,
      22
    },
    {
      208 /*0xD0*/,
      330,
      24,
      4
    },
    {
      205,
      309,
      4,
      22
    },
    {
      205,
      285,
      4,
      22
    },
    {
      208 /*0xD0*/,
      306,
      24,
      4
    },
    {
      312,
      293,
      19,
      3
    },
    {
      330,
      295,
      3,
      17
    },
    {
      330,
      315,
      3,
      17
    },
    {
      312,
      331,
      19,
      3
    },
    {
      310,
      315,
      3,
      17
    },
    {
      310,
      295,
      3,
      17
    },
    {
      311,
      312,
      21,
      3
    },
    {
      343,
      293,
      19,
      3
    },
    {
      361,
      295,
      3,
      17
    },
    {
      361,
      315,
      3,
      17
    },
    {
      343,
      331,
      19,
      3
    },
    {
      341,
      315,
      3,
      17
    },
    {
      341,
      295,
      3,
      17
    },
    {
      342,
      312,
      21,
      3
    },
    {
      299,
      295,
      3,
      17
    },
    {
      299,
      315,
      3,
      17
    }
  };
  public bool[] isOnLF15 = new bool[93]
  {
    true,
    false,
    true,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
  };
  public byte[,] ledColorLF15 = new byte[93, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPositionLF13 = new int[1, 4]
  {
    {
      0,
      0,
      460,
      460
    }
  };
  public bool[] isOnLF13 = new bool[1]{ true };
  public byte[,] ledColorLF13 = new byte[1, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    }
  };
  public int[,] ledPosition;
  public bool[] isOn;
  public byte[,] ledColor;
  private IContainer components = (IContainer) null;

  public UCScreenLED()
  {
    this.InitializeComponent();
    this.ledPosition = this.ledPosition1;
    this.isOn = this.isOn1;
    this.ledColor = this.ledColor1;
    this.imageBk = (Image) Resources.DFROZEN_HORIZON_PRO;
    this.SetMyNumeral(36);
  }

  public void ReSetUCScreenLED1()
  {
  }

  public void ReSetUCScreenLED2()
  {
    this.ledPosition = this.ledPosition2;
    this.isOn = this.isOn2;
    this.ledColor = this.ledColor2;
    this.nowLedStyle = (byte) 2;
    this.Cpu1 = 0;
    this.Cpu2 = 1;
    this.Gpu1 = 2;
    this.Gpu2 = 3;
    this.SSD = 4;
    this.HSD = 5;
    this.BFB = 6;
    this.SSD1 = 7;
    this.HSD1 = 8;
    this.BFB1 = 9;
    this.LEDA1 = 10;
    this.LEDB1 = 11;
    this.LEDC1 = 12;
    this.LEDD1 = 13;
    this.LEDE1 = 14;
    this.LEDF1 = 15;
    this.LEDG1 = 16 /*0x10*/;
    this.LEDA2 = 17;
    this.LEDB2 = 18;
    this.LEDC2 = 19;
    this.LEDD2 = 20;
    this.LEDE2 = 21;
    this.LEDF2 = 22;
    this.LEDG2 = 23;
    this.LEDA3 = 24;
    this.LEDB3 = 25;
    this.LEDC3 = 26;
    this.LEDD3 = 27;
    this.LEDE3 = 28;
    this.LEDF3 = 29;
    this.LEDG3 = 30;
  }

  public void ReSetUCScreenLED3()
  {
    this.ledPosition = this.ledPosition3;
    this.isOn = this.isOn3;
    this.ledColor = this.ledColor3;
    this.nowLedStyle = (byte) 3;
    this.Cpu1 = 0;
    this.WATT = 1;
    this.SSD = 2;
    this.HSD = 3;
    this.BFB = 4;
    this.Gpu1 = 5;
    this.LEDA1 = 6;
    this.LEDB1 = 7;
    this.LEDC1 = 8;
    this.LEDD1 = 9;
    this.LEDE1 = 10;
    this.LEDF1 = 11;
    this.LEDG1 = 12;
    this.LEDA2 = 13;
    this.LEDB2 = 14;
    this.LEDC2 = 15;
    this.LEDD2 = 16 /*0x10*/;
    this.LEDE2 = 17;
    this.LEDF2 = 18;
    this.LEDG2 = 19;
    this.LEDA3 = 20;
    this.LEDB3 = 21;
    this.LEDC3 = 22;
    this.LEDD3 = 23;
    this.LEDE3 = 24;
    this.LEDF3 = 25;
    this.LEDG3 = 26;
    this.LEDA4 = 27;
    this.LEDB4 = 28;
    this.LEDC4 = 29;
    this.LEDD4 = 30;
    this.LEDE4 = 31 /*0x1F*/;
    this.LEDF4 = 32 /*0x20*/;
    this.LEDG4 = 33;
    this.LEDA5 = 34;
    this.LEDB5 = 35;
    this.LEDC5 = 36;
    this.LEDD5 = 37;
    this.LEDE5 = 38;
    this.LEDF5 = 39;
    this.LEDG5 = 40;
    this.LEDA6 = 41;
    this.LEDB6 = 42;
    this.LEDC6 = 43;
    this.LEDD6 = 44;
    this.LEDE6 = 45;
    this.LEDF6 = 46;
    this.LEDG6 = 47;
    this.LEDA7 = 48 /*0x30*/;
    this.LEDB7 = 49;
    this.LEDC7 = 50;
    this.LEDD7 = 51;
    this.LEDE7 = 52;
    this.LEDF7 = 53;
    this.LEDG7 = 54;
    this.LEDA8 = 55;
    this.LEDB8 = 56;
    this.LEDC8 = 57;
    this.LEDD8 = 58;
    this.LEDE8 = 59;
    this.LEDF8 = 60;
    this.LEDG8 = 61;
    this.LEDB9 = 62;
    this.LEDC9 = 63 /*0x3F*/;
  }

  public void ReSetUCScreenLED4()
  {
    this.ledPosition = this.ledPosition4;
    this.isOn = this.isOn4;
    this.ledColor = this.ledColor4;
    this.nowLedStyle = (byte) 4;
    this.SSD = 0;
    this.MTNo = 1;
    this.GNo = 2;
    this.LEDA1 = 3;
    this.LEDB1 = 4;
    this.LEDC1 = 5;
    this.LEDD1 = 6;
    this.LEDE1 = 7;
    this.LEDF1 = 8;
    this.LEDG1 = 9;
    this.LEDA2 = 10;
    this.LEDB2 = 11;
    this.LEDC2 = 12;
    this.LEDD2 = 13;
    this.LEDE2 = 14;
    this.LEDF2 = 15;
    this.LEDG2 = 16 /*0x10*/;
    this.LEDA3 = 17;
    this.LEDB3 = 18;
    this.LEDC3 = 19;
    this.LEDD3 = 20;
    this.LEDE3 = 21;
    this.LEDF3 = 22;
    this.LEDG3 = 23;
    this.LEDA4 = 24;
    this.LEDB4 = 25;
    this.LEDC4 = 26;
    this.LEDD4 = 27;
    this.LEDE4 = 28;
    this.LEDF4 = 29;
    this.LEDG4 = 30;
  }

  public void ReSetUCScreenLED5()
  {
    this.ledPosition = this.ledPosition5;
    this.isOn = this.isOn5;
    this.ledColor = this.ledColor5;
    this.nowLedStyle = (byte) 5;
    this.Cpu1 = 0;
    this.Gpu1 = 1;
    this.SSD = 2;
    this.HSD = 3;
    this.WATT = 4;
    this.MHz = 5;
    this.BFB = 6;
    this.LEDA1 = 7;
    this.LEDB1 = 8;
    this.LEDC1 = 9;
    this.LEDD1 = 10;
    this.LEDE1 = 11;
    this.LEDF1 = 12;
    this.LEDG1 = 13;
    this.LEDA2 = 14;
    this.LEDB2 = 15;
    this.LEDC2 = 16 /*0x10*/;
    this.LEDD2 = 17;
    this.LEDE2 = 18;
    this.LEDF2 = 19;
    this.LEDG2 = 20;
    this.LEDA3 = 21;
    this.LEDB3 = 22;
    this.LEDC3 = 23;
    this.LEDD3 = 24;
    this.LEDE3 = 25;
    this.LEDF3 = 26;
    this.LEDG3 = 27;
    this.LEDA4 = 28;
    this.LEDB4 = 29;
    this.LEDC4 = 30;
    this.LEDD4 = 31 /*0x1F*/;
    this.LEDE4 = 32 /*0x20*/;
    this.LEDF4 = 33;
    this.LEDG4 = 34;
    this.LEDA5 = 35;
    this.LEDB5 = 36;
    this.LEDC5 = 37;
    this.LEDD5 = 38;
    this.LEDE5 = 39;
    this.LEDF5 = 40;
    this.LEDG5 = 41;
    this.LEDA6 = 42;
    this.LEDB6 = 43;
    this.LEDC6 = 44;
    this.LEDD6 = 45;
    this.LEDE6 = 46;
    this.LEDF6 = 47;
    this.LEDG6 = 48 /*0x30*/;
    this.LEDA7 = 49;
    this.LEDB7 = 50;
    this.LEDC7 = 51;
    this.LEDD7 = 52;
    this.LEDE7 = 53;
    this.LEDF7 = 54;
    this.LEDG7 = 55;
    this.LEDA8 = 56;
    this.LEDB8 = 57;
    this.LEDC8 = 58;
    this.LEDD8 = 59;
    this.LEDE8 = 60;
    this.LEDF8 = 61;
    this.LEDG8 = 62;
    this.LEDA9 = 63 /*0x3F*/;
    this.LEDB9 = 64 /*0x40*/;
    this.LEDC9 = 65;
    this.LEDD9 = 66;
    this.LEDE9 = 67;
    this.LEDF9 = 68;
    this.LEDG9 = 69;
    this.LEDA10 = 70;
    this.LEDB10 = 71;
    this.LEDC10 = 72;
    this.LEDD10 = 73;
    this.LEDE10 = 74;
    this.LEDF10 = 75;
    this.LEDG10 = 76;
    this.LEDA11 = 77;
    this.LEDB11 = 78;
    this.LEDC11 = 79;
    this.LEDD11 = 80 /*0x50*/;
    this.LEDE11 = 81;
    this.LEDF11 = 82;
    this.LEDG11 = 83;
    this.LEDA12 = 84;
    this.LEDB12 = 85;
    this.LEDC12 = 86;
    this.LEDD12 = 87;
    this.LEDE12 = 88;
    this.LEDF12 = 89;
    this.LEDG12 = 90;
    this.LEDB13 = 91;
    this.LEDC13 = 92;
  }

  public void ReSetUCScreenLED6()
  {
    this.ledPosition = this.ledPosition6;
    this.isOn = this.isOn6;
    this.ledColor = this.ledColor6;
    this.nowLedStyle = (byte) 6;
    this.imageBk61 = (Image) Resources.Dch2;
    this.imageBk62 = (Image) Resources.Dch3;
    this.imageBk63 = (Image) Resources.Dch4;
    this.Cpu1 = 0;
    this.Gpu1 = 1;
    this.SSD = 2;
    this.HSD = 3;
    this.WATT = 4;
    this.MHz = 5;
    this.BFB = 6;
    this.LEDA1 = 7;
    this.LEDB1 = 8;
    this.LEDC1 = 9;
    this.LEDD1 = 10;
    this.LEDE1 = 11;
    this.LEDF1 = 12;
    this.LEDG1 = 13;
    this.LEDA2 = 14;
    this.LEDB2 = 15;
    this.LEDC2 = 16 /*0x10*/;
    this.LEDD2 = 17;
    this.LEDE2 = 18;
    this.LEDF2 = 19;
    this.LEDG2 = 20;
    this.LEDA3 = 21;
    this.LEDB3 = 22;
    this.LEDC3 = 23;
    this.LEDD3 = 24;
    this.LEDE3 = 25;
    this.LEDF3 = 26;
    this.LEDG3 = 27;
    this.LEDA4 = 28;
    this.LEDB4 = 29;
    this.LEDC4 = 30;
    this.LEDD4 = 31 /*0x1F*/;
    this.LEDE4 = 32 /*0x20*/;
    this.LEDF4 = 33;
    this.LEDG4 = 34;
    this.LEDA5 = 35;
    this.LEDB5 = 36;
    this.LEDC5 = 37;
    this.LEDD5 = 38;
    this.LEDE5 = 39;
    this.LEDF5 = 40;
    this.LEDG5 = 41;
    this.LEDA6 = 42;
    this.LEDB6 = 43;
    this.LEDC6 = 44;
    this.LEDD6 = 45;
    this.LEDE6 = 46;
    this.LEDF6 = 47;
    this.LEDG6 = 48 /*0x30*/;
    this.LEDA7 = 49;
    this.LEDB7 = 50;
    this.LEDC7 = 51;
    this.LEDD7 = 52;
    this.LEDE7 = 53;
    this.LEDF7 = 54;
    this.LEDG7 = 55;
    this.LEDA8 = 56;
    this.LEDB8 = 57;
    this.LEDC8 = 58;
    this.LEDD8 = 59;
    this.LEDE8 = 60;
    this.LEDF8 = 61;
    this.LEDG8 = 62;
    this.LEDA9 = 63 /*0x3F*/;
    this.LEDB9 = 64 /*0x40*/;
    this.LEDC9 = 65;
    this.LEDD9 = 66;
    this.LEDE9 = 67;
    this.LEDF9 = 68;
    this.LEDG9 = 69;
    this.LEDA10 = 70;
    this.LEDB10 = 71;
    this.LEDC10 = 72;
    this.LEDD10 = 73;
    this.LEDE10 = 74;
    this.LEDF10 = 75;
    this.LEDG10 = 76;
    this.LEDA11 = 77;
    this.LEDB11 = 78;
    this.LEDC11 = 79;
    this.LEDD11 = 80 /*0x50*/;
    this.LEDE11 = 81;
    this.LEDF11 = 82;
    this.LEDG11 = 83;
    this.LEDA12 = 84;
    this.LEDB12 = 85;
    this.LEDC12 = 86;
    this.LEDD12 = 87;
    this.LEDE12 = 88;
    this.LEDF12 = 89;
    this.LEDG12 = 90;
    this.LEDB13 = 91;
    this.LEDC13 = 92;
  }

  public void ReSetUCScreenLED7()
  {
    this.ledPosition = this.ledPosition7;
    this.isOn = this.isOn7;
    this.ledColor = this.ledColor7;
    this.nowLedStyle = (byte) 7;
    this.imageBk71 = (Image) Resources.Dch1;
    this.Cpu1 = 0;
    this.SSD = 1;
    this.HSD = 2;
    this.Gpu1 = 3;
    this.SSD1 = 4;
    this.HSD1 = 5;
    this.LEDA1 = 6;
    this.LEDB1 = 7;
    this.LEDC1 = 8;
    this.LEDD1 = 9;
    this.LEDE1 = 10;
    this.LEDF1 = 11;
    this.LEDG1 = 12;
    this.LEDH1 = 13;
    this.LEDI1 = 14;
    this.LEDJ1 = 15;
    this.LEDK1 = 16 /*0x10*/;
    this.LEDL1 = 17;
    this.LEDM1 = 18;
    this.LEDA2 = 19;
    this.LEDB2 = 20;
    this.LEDC2 = 21;
    this.LEDD2 = 22;
    this.LEDE2 = 23;
    this.LEDF2 = 24;
    this.LEDG2 = 25;
    this.LEDH2 = 26;
    this.LEDI2 = 27;
    this.LEDJ2 = 28;
    this.LEDK2 = 29;
    this.LEDL2 = 30;
    this.LEDM2 = 31 /*0x1F*/;
    this.LEDA3 = 32 /*0x20*/;
    this.LEDB3 = 33;
    this.LEDC3 = 34;
    this.LEDD3 = 35;
    this.LEDE3 = 36;
    this.LEDF3 = 37;
    this.LEDG3 = 38;
    this.LEDH3 = 39;
    this.LEDI3 = 40;
    this.LEDJ3 = 41;
    this.LEDK3 = 42;
    this.LEDL3 = 43;
    this.LEDM3 = 44;
    this.LEDA4 = 45;
    this.LEDB4 = 46;
    this.LEDC4 = 47;
    this.LEDD4 = 48 /*0x30*/;
    this.LEDE4 = 49;
    this.LEDF4 = 50;
    this.LEDG4 = 51;
    this.LEDH4 = 52;
    this.LEDI4 = 53;
    this.LEDJ4 = 54;
    this.LEDK4 = 55;
    this.LEDL4 = 56;
    this.LEDM4 = 57;
    this.LEDA5 = 58;
    this.LEDB5 = 59;
    this.LEDC5 = 60;
    this.LEDD5 = 61;
    this.LEDE5 = 62;
    this.LEDF5 = 63 /*0x3F*/;
    this.LEDG5 = 64 /*0x40*/;
    this.LEDH5 = 65;
    this.LEDI5 = 66;
    this.LEDJ5 = 67;
    this.LEDK5 = 68;
    this.LEDL5 = 69;
    this.LEDM5 = 70;
    this.LEDA6 = 71;
    this.LEDB6 = 72;
    this.LEDC6 = 73;
    this.LEDD6 = 74;
    this.LEDE6 = 75;
    this.LEDF6 = 76;
    this.LEDG6 = 77;
    this.LEDH6 = 78;
    this.LEDI6 = 79;
    this.LEDJ6 = 80 /*0x50*/;
    this.LEDK6 = 81;
    this.LEDL6 = 82;
    this.LEDM6 = 83;
    this.ZhuangShi1 = 84;
    this.ZhuangShi2 = 85;
    this.ZhuangShi3 = 86;
    this.ZhuangShi4 = 87;
    this.ZhuangShi5 = 88;
    this.ZhuangShi6 = 89;
    this.ZhuangShi7 = 90;
    this.ZhuangShi8 = 91;
    this.ZhuangShi9 = 92;
    this.ZhuangShi10 = 93;
    this.ZhuangShi11 = 94;
    this.ZhuangShi12 = 95;
    this.ZhuangShi13 = 96 /*0x60*/;
    this.ZhuangShi14 = 97;
    this.ZhuangShi15 = 98;
    this.ZhuangShi16 = 99;
    this.ZhuangShi17 = 100;
    this.ZhuangShi18 = 101;
    this.ZhuangShi19 = 102;
    this.ZhuangShi20 = 103;
    this.ZhuangShi21 = 104;
    this.ZhuangShi22 = 105;
    this.ZhuangShi23 = 106;
    this.ZhuangShi24 = 107;
    this.ZhuangShi25 = 108;
    this.ZhuangShi26 = 109;
    this.ZhuangShi27 = 110;
    this.ZhuangShi28 = 111;
    this.ZhuangShi29 = 112 /*0x70*/;
    this.ZhuangShi30 = 113;
    this.ZhuangShi31 = 114;
    this.ZhuangShi32 = 115;
  }

  public void ReSetUCScreenLED8()
  {
    this.ledPosition = this.ledPosition8;
    this.isOn = this.isOn8;
    this.ledColor = this.ledColor8;
    this.nowLedStyle = (byte) 8;
    this.imageBk81 = (Image) Resources.Dchcz1;
    this.Cpu1 = 0;
    this.Gpu1 = 1;
    this.Cpu2 = 2;
    this.Gpu2 = 3;
    this.LEDA1 = 4;
    this.LEDB1 = 5;
    this.LEDC1 = 6;
    this.LEDD1 = 7;
    this.LEDE1 = 8;
    this.LEDF1 = 9;
    this.LEDG1 = 10;
    this.LEDA2 = 11;
    this.LEDB2 = 12;
    this.LEDC2 = 13;
    this.LEDD2 = 14;
    this.LEDE2 = 15;
    this.LEDF2 = 16 /*0x10*/;
    this.LEDG2 = 17;
  }

  public void ReSetUCScreenLED9()
  {
    this.ledPosition = this.ledPosition9;
    this.isOn = this.isOn9;
    this.ledColor = this.ledColor9;
    this.nowLedStyle = (byte) 9;
    this.LEDA1 = 3;
    this.LEDB1 = 4;
    this.LEDC1 = 5;
    this.LEDD1 = 6;
    this.LEDE1 = 7;
    this.LEDF1 = 8;
    this.LEDG1 = 9;
    this.LEDA2 = 10;
    this.LEDB2 = 11;
    this.LEDC2 = 12;
    this.LEDD2 = 13;
    this.LEDE2 = 14;
    this.LEDF2 = 15;
    this.LEDG2 = 16 /*0x10*/;
    this.LEDA3 = 17;
    this.LEDB3 = 18;
    this.LEDC3 = 19;
    this.LEDD3 = 20;
    this.LEDE3 = 21;
    this.LEDF3 = 22;
    this.LEDG3 = 23;
    this.LEDA4 = 24;
    this.LEDB4 = 25;
    this.LEDC4 = 26;
    this.LEDD4 = 27;
    this.LEDE4 = 28;
    this.LEDF4 = 29;
    this.LEDG4 = 30;
    this.LEDA5 = 31 /*0x1F*/;
    this.LEDB5 = 32 /*0x20*/;
    this.LEDC5 = 33;
    this.LEDD5 = 34;
    this.LEDE5 = 35;
    this.LEDF5 = 36;
    this.LEDG5 = 37;
    this.LEDA6 = 38;
    this.LEDB6 = 39;
    this.LEDC6 = 40;
    this.LEDD6 = 41;
    this.LEDE6 = 42;
    this.LEDF6 = 43;
    this.LEDG6 = 44;
    this.LEDA7 = 45;
    this.LEDB7 = 46;
    this.LEDC7 = 47;
    this.LEDD7 = 48 /*0x30*/;
    this.LEDE7 = 49;
    this.LEDF7 = 50;
    this.LEDG7 = 51;
    this.LEDB8 = 52;
    this.LEDC8 = 53;
    this.ZhuangShi1 = 54;
    this.ZhuangShi2 = 55;
    this.ZhuangShi3 = 56;
    this.ZhuangShi4 = 57;
    this.ZhuangShi5 = 58;
    this.ZhuangShi6 = 59;
    this.ZhuangShi7 = 60;
  }

  public void ReSetUCScreenLED10()
  {
    this.ledPosition = this.ledPosition10;
    this.isOn = this.isOn10;
    this.ledColor = this.ledColor10;
    this.nowLedStyle = (byte) 10;
    this.SSD = 0;
    this.MTNo = this.BFB = 1;
    this.GNo = this.MHz = 2;
    this.LEDA1 = 3;
    this.LEDB1 = 4;
    this.LEDC1 = 5;
    this.LEDD1 = 6;
    this.LEDE1 = 7;
    this.LEDF1 = 8;
    this.LEDG1 = 9;
    this.LEDA2 = 10;
    this.LEDB2 = 11;
    this.LEDC2 = 12;
    this.LEDD2 = 13;
    this.LEDE2 = 14;
    this.LEDF2 = 15;
    this.LEDG2 = 16 /*0x10*/;
    this.LEDA3 = 17;
    this.LEDB3 = 18;
    this.LEDC3 = 19;
    this.LEDD3 = 20;
    this.LEDE3 = 21;
    this.LEDF3 = 22;
    this.LEDG3 = 23;
    this.LEDA4 = 24;
    this.LEDB4 = 25;
    this.LEDC4 = 26;
    this.LEDD4 = 27;
    this.LEDE4 = 28;
    this.LEDF4 = 29;
    this.LEDG4 = 30;
    this.LEDA5 = 31 /*0x1F*/;
    this.LEDB5 = 32 /*0x20*/;
    this.LEDC5 = 33;
    this.LEDD5 = 34;
    this.LEDE5 = 35;
    this.LEDF5 = 36;
    this.LEDG5 = 37;
  }

  public void ReSetUCScreenLEDLF15()
  {
    this.ledPosition = this.ledPositionLF15;
    this.isOn = this.isOnLF15;
    this.ledColor = this.ledColorLF15;
    this.nowLedStyle = (byte) 11;
    this.Cpu1 = 0;
    this.Gpu1 = 1;
    this.SSD = 2;
    this.HSD = 3;
    this.WATT = 4;
    this.MHz = 5;
    this.BFB = 6;
    this.LEDA1 = 7;
    this.LEDB1 = 8;
    this.LEDC1 = 9;
    this.LEDD1 = 10;
    this.LEDE1 = 11;
    this.LEDF1 = 12;
    this.LEDG1 = 13;
    this.LEDA2 = 14;
    this.LEDB2 = 15;
    this.LEDC2 = 16 /*0x10*/;
    this.LEDD2 = 17;
    this.LEDE2 = 18;
    this.LEDF2 = 19;
    this.LEDG2 = 20;
    this.LEDA3 = 21;
    this.LEDB3 = 22;
    this.LEDC3 = 23;
    this.LEDD3 = 24;
    this.LEDE3 = 25;
    this.LEDF3 = 26;
    this.LEDG3 = 27;
    this.LEDA4 = 28;
    this.LEDB4 = 29;
    this.LEDC4 = 30;
    this.LEDD4 = 31 /*0x1F*/;
    this.LEDE4 = 32 /*0x20*/;
    this.LEDF4 = 33;
    this.LEDG4 = 34;
    this.LEDA5 = 35;
    this.LEDB5 = 36;
    this.LEDC5 = 37;
    this.LEDD5 = 38;
    this.LEDE5 = 39;
    this.LEDF5 = 40;
    this.LEDG5 = 41;
    this.LEDA6 = 42;
    this.LEDB6 = 43;
    this.LEDC6 = 44;
    this.LEDD6 = 45;
    this.LEDE6 = 46;
    this.LEDF6 = 47;
    this.LEDG6 = 48 /*0x30*/;
    this.LEDA7 = 49;
    this.LEDB7 = 50;
    this.LEDC7 = 51;
    this.LEDD7 = 52;
    this.LEDE7 = 53;
    this.LEDF7 = 54;
    this.LEDG7 = 55;
    this.LEDA8 = 56;
    this.LEDB8 = 57;
    this.LEDC8 = 58;
    this.LEDD8 = 59;
    this.LEDE8 = 60;
    this.LEDF8 = 61;
    this.LEDG8 = 62;
    this.LEDA9 = 63 /*0x3F*/;
    this.LEDB9 = 64 /*0x40*/;
    this.LEDC9 = 65;
    this.LEDD9 = 66;
    this.LEDE9 = 67;
    this.LEDF9 = 68;
    this.LEDG9 = 69;
    this.LEDA10 = 70;
    this.LEDB10 = 71;
    this.LEDC10 = 72;
    this.LEDD10 = 73;
    this.LEDE10 = 74;
    this.LEDF10 = 75;
    this.LEDG10 = 76;
    this.LEDA11 = 77;
    this.LEDB11 = 78;
    this.LEDC11 = 79;
    this.LEDD11 = 80 /*0x50*/;
    this.LEDE11 = 81;
    this.LEDF11 = 82;
    this.LEDG11 = 83;
    this.LEDA12 = 84;
    this.LEDB12 = 85;
    this.LEDC12 = 86;
    this.LEDD12 = 87;
    this.LEDE12 = 88;
    this.LEDF12 = 89;
    this.LEDG12 = 90;
    this.LEDB13 = 91;
    this.LEDC13 = 92;
  }

  public void ReSetUCScreenLEDLF13()
  {
    this.ledPosition = this.ledPositionLF13;
    this.isOn = this.isOnLF13;
    this.ledColor = this.ledColorLF13;
    this.imageLF13 = (Image) Resources.D0rgblf13;
    this.nowLedStyle = (byte) 12;
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    base.OnPaint(pe);
    Graphics graphics = pe.Graphics;
    if (this.nowLedStyle == (byte) 6)
    {
      if (this.myLedMode == 4)
      {
        try
        {
          graphics.DrawImage(this.imageBk61, 26, 17);
          graphics.DrawImage(this.imageBk62, 23, 221);
          graphics.DrawImage(this.imageBk63, 293, 274);
        }
        catch
        {
        }
      }
      else
      {
        try
        {
          Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) this.ledColor[0, 0], (int) this.ledColor[0, 1], (int) this.ledColor[0, 2]));
          graphics.FillRectangle(brush, 26, 17, this.imageBk61.Width, this.imageBk61.Height);
          graphics.FillRectangle(brush, 23, 221, this.imageBk62.Width, this.imageBk62.Height);
          graphics.FillRectangle(brush, 293, 274 + this.imageBk63.Height - 40, this.imageBk63.Width, 40);
          graphics.FillRectangle(brush, 293 + this.imageBk63.Width - 40, 274, 40, this.imageBk63.Height);
          brush.Dispose();
        }
        catch
        {
        }
      }
    }
    else if (this.nowLedStyle == (byte) 7)
    {
      if (this.myLedMode == 4)
      {
        try
        {
          if (this.isOn[this.ZhuangShi21])
            graphics.DrawImage(this.imageBk71, 30, 217);
        }
        catch
        {
        }
      }
      else
      {
        try
        {
          if (this.isOn[this.ZhuangShi21])
          {
            Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) this.ledColor[this.ZhuangShi21, 0], (int) this.ledColor[this.ZhuangShi21, 1], (int) this.ledColor[this.ZhuangShi21, 2]));
            graphics.FillRectangle(brush, 30, 217, this.imageBk71.Width, 70);
            graphics.FillRectangle(brush, 195, 268, 70, 170);
            brush.Dispose();
          }
        }
        catch
        {
        }
      }
    }
    else if (this.nowLedStyle == (byte) 8)
    {
      if (this.myLedMode == 4)
      {
        try
        {
          graphics.DrawImage(this.imageBk81, 0, 0);
          for (int index = 0; index < this.ledPosition.GetLength(0); ++index)
          {
            if (!this.isOn[index])
            {
              Brush brush = (Brush) new SolidBrush(Color.Black);
              graphics.FillRectangle(brush, this.ledPosition[index, 0], this.ledPosition[index, 1], this.ledPosition[index, 2], this.ledPosition[index, 3]);
              brush.Dispose();
            }
          }
        }
        catch
        {
        }
      }
      else
      {
        for (int index = 0; index < this.ledPosition.GetLength(0); ++index)
        {
          if (this.isOn[index])
          {
            Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) this.ledColor[index, 0], (int) this.ledColor[index, 1], (int) this.ledColor[index, 2]));
            graphics.FillRectangle(brush, this.ledPosition[index, 0], this.ledPosition[index, 1], this.ledPosition[index, 2], this.ledPosition[index, 3]);
            brush.Dispose();
          }
        }
      }
    }
    else if (this.nowLedStyle == (byte) 12)
    {
      if (this.myLedMode == 4)
      {
        try
        {
          if (this.isOn[0])
            graphics.DrawImage(this.imageLF13, 0, 0);
        }
        catch
        {
        }
      }
      else if (this.isOn[0])
      {
        Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) this.ledColor[0, 0], (int) this.ledColor[0, 1], (int) this.ledColor[0, 2]));
        graphics.FillRectangle(brush, 0, 0, this.ledPosition[0, 2], this.ledPosition[0, 3]);
        brush.Dispose();
      }
    }
    if (this.nowLedStyle != (byte) 8 && this.nowLedStyle != (byte) 12)
    {
      for (int index = 0; index < this.ledPosition.GetLength(0); ++index)
      {
        if (this.isOn[index])
        {
          Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) this.ledColor[index, 0], (int) this.ledColor[index, 1], (int) this.ledColor[index, 2]));
          graphics.FillRectangle(brush, this.ledPosition[index, 0], this.ledPosition[index, 1], this.ledPosition[index, 2], this.ledPosition[index, 3]);
          brush.Dispose();
        }
      }
    }
    graphics.DrawImage(this.imageBk, 0, 0);
  }

  public void SetMyNumeral(int val)
  {
    int num1 = val / 100;
    int num2 = val % 100 / 10;
    int num3 = val % 10;
    switch (num1)
    {
      case 0:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 1:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 2:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 3:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 4:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 5:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 6:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 7:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 8:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 9:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      default:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
    }
    switch (num2)
    {
      case 0:
        if (num1 == 0)
        {
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        }
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = false;
        break;
      case 1:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 2:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = false;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 3:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 4:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 5:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 6:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 7:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 8:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 9:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
    }
    switch (num3)
    {
      case 0:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = false;
        break;
      case 1:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 2:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = false;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 3:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 4:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 5:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 6:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 7:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 8:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 9:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
    }
  }

  public void SetMyNumeral(int cpuTemp, int cpuUse, int gpuTemp, int gpuUse)
  {
    int num1 = cpuTemp / 100;
    int num2 = cpuTemp % 100 / 10;
    int num3 = cpuTemp % 10;
    switch (num1)
    {
      case 0:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 1:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 2:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 3:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 4:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 5:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 6:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 7:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 8:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 9:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      default:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
    }
    switch (num2)
    {
      case 0:
        if (num1 == 0)
        {
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        }
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = false;
        break;
      case 1:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 2:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = false;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 3:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 4:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 5:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 6:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 7:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 8:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 9:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
    }
    switch (num3)
    {
      case 0:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = false;
        break;
      case 1:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 2:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = false;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 3:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 4:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 5:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 6:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 7:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 8:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 9:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
    }
    int num4 = cpuUse / 100;
    int num5 = cpuUse % 100 / 10;
    int num6 = cpuUse % 10;
    switch (num4)
    {
      case 0:
        this.isOn[this.LEDB11] = false;
        this.isOn[this.LEDC11] = false;
        break;
      case 1:
        this.isOn[this.LEDB11] = true;
        this.isOn[this.LEDC11] = true;
        break;
      default:
        this.isOn[this.LEDB11] = false;
        this.isOn[this.LEDC11] = false;
        break;
    }
    switch (num5)
    {
      case 0:
        if (num4 == 0)
        {
          this.isOn[this.LEDA4] = false;
          this.isOn[this.LEDB4] = false;
          this.isOn[this.LEDC4] = false;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = false;
          break;
        }
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = false;
        break;
      case 1:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 2:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = true;
        break;
      case 3:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = true;
        break;
      case 4:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 5:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 6:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 7:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 8:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 9:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
    }
    switch (num6)
    {
      case 0:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = false;
        break;
      case 1:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = false;
        break;
      case 2:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = false;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = true;
        break;
      case 3:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = true;
        break;
      case 4:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 5:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 6:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 7:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = false;
        break;
      case 8:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 9:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
    }
    int num7 = gpuTemp / 100;
    int num8 = gpuTemp % 100 / 10;
    int num9 = gpuTemp % 10;
    switch (num7)
    {
      case 0:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = false;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 1:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 2:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = false;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = true;
        break;
      case 3:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = true;
        break;
      case 4:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 5:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 6:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 7:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 8:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 9:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      default:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = false;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
    }
    switch (num8)
    {
      case 0:
        if (num7 == 0)
        {
          this.isOn[this.LEDA7] = false;
          this.isOn[this.LEDB7] = false;
          this.isOn[this.LEDC7] = false;
          this.isOn[this.LEDD7] = false;
          this.isOn[this.LEDE7] = false;
          this.isOn[this.LEDF7] = false;
          this.isOn[this.LEDG7] = false;
          break;
        }
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = false;
        break;
      case 1:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
      case 2:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = false;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = true;
        break;
      case 3:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = true;
        break;
      case 4:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 5:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 6:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 7:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
      case 8:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 9:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
    }
    switch (num9)
    {
      case 0:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = false;
        break;
      case 1:
        this.isOn[this.LEDA8] = false;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = false;
        break;
      case 2:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = false;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = true;
        break;
      case 3:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = true;
        break;
      case 4:
        this.isOn[this.LEDA8] = false;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 5:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = false;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 6:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = false;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 7:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = false;
        break;
      case 8:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 9:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
    }
    int num10 = gpuUse / 100;
    int num11 = gpuUse % 100 / 10;
    int num12 = gpuUse % 10;
    switch (num10)
    {
      case 0:
        this.isOn[this.LEDB12] = false;
        this.isOn[this.LEDC12] = false;
        break;
      case 1:
        this.isOn[this.LEDB12] = true;
        this.isOn[this.LEDC12] = true;
        break;
      default:
        this.isOn[this.LEDB12] = false;
        this.isOn[this.LEDC12] = false;
        break;
    }
    switch (num11)
    {
      case 0:
        if (num10 == 0)
        {
          this.isOn[this.LEDA9] = false;
          this.isOn[this.LEDB9] = false;
          this.isOn[this.LEDC9] = false;
          this.isOn[this.LEDD9] = false;
          this.isOn[this.LEDE9] = false;
          this.isOn[this.LEDF9] = false;
          this.isOn[this.LEDG9] = false;
          break;
        }
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = true;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = false;
        break;
      case 1:
        this.isOn[this.LEDA9] = false;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = false;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = false;
        this.isOn[this.LEDG9] = false;
        break;
      case 2:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = false;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = true;
        this.isOn[this.LEDF9] = false;
        this.isOn[this.LEDG9] = true;
        break;
      case 3:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = false;
        this.isOn[this.LEDG9] = true;
        break;
      case 4:
        this.isOn[this.LEDA9] = false;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = false;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
      case 5:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = false;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
      case 6:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = false;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = true;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
      case 7:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = false;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = false;
        this.isOn[this.LEDG9] = false;
        break;
      case 8:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = true;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
      case 9:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
    }
    switch (num12)
    {
      case 0:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = true;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = false;
        break;
      case 1:
        this.isOn[this.LEDA10] = false;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = false;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = false;
        this.isOn[this.LEDG10] = false;
        break;
      case 2:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = false;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = true;
        this.isOn[this.LEDF10] = false;
        this.isOn[this.LEDG10] = true;
        break;
      case 3:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = false;
        this.isOn[this.LEDG10] = true;
        break;
      case 4:
        this.isOn[this.LEDA10] = false;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = false;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
      case 5:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = false;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
      case 6:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = false;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = true;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
      case 7:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = false;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = false;
        this.isOn[this.LEDG10] = false;
        break;
      case 8:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = true;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
      case 9:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
    }
  }

  public void SetMyNumeral(int watt, int temp, int use)
  {
    int num1 = watt / 100;
    int num2 = watt % 100 / 10;
    int num3 = watt % 10;
    switch (num1)
    {
      case 0:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 1:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 2:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 3:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 4:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 5:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 6:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 7:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 8:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 9:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      default:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
    }
    switch (num2)
    {
      case 0:
        if (num1 == 0)
        {
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        }
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = false;
        break;
      case 1:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 2:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = false;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 3:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 4:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 5:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 6:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 7:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 8:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 9:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
    }
    switch (num3)
    {
      case 0:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = false;
        break;
      case 1:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 2:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = false;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 3:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 4:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 5:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 6:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 7:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 8:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 9:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
    }
    int num4 = temp / 100;
    int num5 = temp % 100 / 10;
    int num6 = temp % 10;
    switch (num4)
    {
      case 0:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 1:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 2:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = true;
        break;
      case 3:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = true;
        break;
      case 4:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 5:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 6:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 7:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 8:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 9:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      default:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
    }
    switch (num5)
    {
      case 0:
        if (num4 == 0)
        {
          this.isOn[this.LEDA5] = false;
          this.isOn[this.LEDB5] = false;
          this.isOn[this.LEDC5] = false;
          this.isOn[this.LEDD5] = false;
          this.isOn[this.LEDE5] = false;
          this.isOn[this.LEDF5] = false;
          this.isOn[this.LEDG5] = false;
          break;
        }
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = false;
        break;
      case 1:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = false;
        break;
      case 2:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = false;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = true;
        break;
      case 3:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = true;
        break;
      case 4:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 5:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 6:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 7:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = false;
        break;
      case 8:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 9:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
    }
    switch (num6)
    {
      case 0:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = false;
        break;
      case 1:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 2:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = false;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = true;
        break;
      case 3:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = true;
        break;
      case 4:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 5:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 6:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 7:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 8:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 9:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
    }
    int num7 = use / 100;
    int num8 = use % 100 / 10;
    int num9 = use % 10;
    switch (num7)
    {
      case 0:
        this.isOn[this.LEDB9] = false;
        this.isOn[this.LEDC9] = false;
        break;
      case 1:
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        break;
      default:
        this.isOn[this.LEDB9] = false;
        this.isOn[this.LEDC9] = false;
        break;
    }
    switch (num8)
    {
      case 0:
        if (num7 == 0)
        {
          this.isOn[this.LEDA7] = false;
          this.isOn[this.LEDB7] = false;
          this.isOn[this.LEDC7] = false;
          this.isOn[this.LEDD7] = false;
          this.isOn[this.LEDE7] = false;
          this.isOn[this.LEDF7] = false;
          this.isOn[this.LEDG7] = false;
          break;
        }
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = false;
        break;
      case 1:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
      case 2:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = false;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = true;
        break;
      case 3:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = true;
        break;
      case 4:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 5:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 6:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 7:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
      case 8:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 9:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
    }
    switch (num9)
    {
      case 0:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = false;
        break;
      case 1:
        this.isOn[this.LEDA8] = false;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = false;
        break;
      case 2:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = false;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = true;
        break;
      case 3:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = true;
        break;
      case 4:
        this.isOn[this.LEDA8] = false;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 5:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = false;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 6:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = false;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 7:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = false;
        break;
      case 8:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 9:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
    }
  }

  public void SetMyNumeral(int mode, int val)
  {
    if (mode <= 0)
    {
      this.isOn[this.SSD] = true;
      this.isOn[this.MTNo] = false;
      this.isOn[this.GNo] = false;
      if (mode == 0)
      {
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = false;
      }
      else
      {
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
      }
      int num1 = val / 100;
      int num2 = val % 100 / 10;
      int num3 = val % 10;
      switch (num1)
      {
        case 0:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        case 1:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        case 2:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = true;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = true;
          break;
        case 3:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = true;
          break;
        case 4:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 5:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 6:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = true;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 7:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        case 8:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = true;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 9:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        default:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
      }
      switch (num2)
      {
        case 0:
          if (num1 == 0)
          {
            this.isOn[this.LEDA2] = false;
            this.isOn[this.LEDB2] = false;
            this.isOn[this.LEDC2] = false;
            this.isOn[this.LEDD2] = false;
            this.isOn[this.LEDE2] = false;
            this.isOn[this.LEDF2] = false;
            this.isOn[this.LEDG2] = false;
            break;
          }
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = false;
          break;
        case 1:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        case 2:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = true;
          break;
        case 3:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = true;
          break;
        case 4:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 5:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 6:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 7:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        case 8:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 9:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
      }
      switch (num3)
      {
        case 0:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = false;
          break;
        case 1:
          this.isOn[this.LEDA3] = false;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = false;
          break;
        case 2:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = false;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = true;
          break;
        case 3:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = true;
          break;
        case 4:
          this.isOn[this.LEDA3] = false;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 5:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = false;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 6:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = false;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 7:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = false;
          break;
        case 8:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 9:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
      }
    }
    else
    {
      if (mode == 1)
      {
        this.isOn[this.MTNo] = true;
        this.isOn[this.GNo] = false;
        this.isOn[this.SSD] = false;
      }
      else
      {
        this.isOn[this.MTNo] = false;
        this.isOn[this.GNo] = true;
        this.isOn[this.SSD] = false;
      }
      int num4 = val / 1000;
      int num5 = val / 100 % 10;
      int num6 = val % 100 / 10;
      int num7 = val % 10;
      switch (num4)
      {
        case 0:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        case 1:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        case 2:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = true;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = true;
          break;
        case 3:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = true;
          break;
        case 4:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 5:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 6:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = true;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 7:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        case 8:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = true;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 9:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        default:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
      }
      switch (num5)
      {
        case 0:
          if (num4 == 0)
          {
            this.isOn[this.LEDA2] = false;
            this.isOn[this.LEDB2] = false;
            this.isOn[this.LEDC2] = false;
            this.isOn[this.LEDD2] = false;
            this.isOn[this.LEDE2] = false;
            this.isOn[this.LEDF2] = false;
            this.isOn[this.LEDG2] = false;
            break;
          }
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = false;
          break;
        case 1:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        case 2:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = true;
          break;
        case 3:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = true;
          break;
        case 4:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 5:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 6:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 7:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        case 8:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 9:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        default:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
      }
      switch (num6)
      {
        case 0:
          if (num5 == 0 && num4 == 0)
          {
            this.isOn[this.LEDA3] = false;
            this.isOn[this.LEDB3] = false;
            this.isOn[this.LEDC3] = false;
            this.isOn[this.LEDD3] = false;
            this.isOn[this.LEDE3] = false;
            this.isOn[this.LEDF3] = false;
            this.isOn[this.LEDG3] = false;
            break;
          }
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = false;
          break;
        case 1:
          this.isOn[this.LEDA3] = false;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = false;
          break;
        case 2:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = false;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = true;
          break;
        case 3:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = true;
          break;
        case 4:
          this.isOn[this.LEDA3] = false;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 5:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = false;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 6:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = false;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 7:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = false;
          break;
        case 8:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 9:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
      }
      switch (num7)
      {
        case 0:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = false;
          break;
        case 1:
          this.isOn[this.LEDA4] = false;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = false;
          break;
        case 2:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = false;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = true;
          break;
        case 3:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = true;
          break;
        case 4:
          this.isOn[this.LEDA4] = false;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 5:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = false;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 6:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = false;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 7:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = false;
          break;
        case 8:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 9:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
      }
    }
  }

  public void SetMyNumeralHardDisk(int mode, int val)
  {
    if (mode <= 0)
    {
      this.isOn[this.SSD] = true;
      this.isOn[this.MTNo] = false;
      this.isOn[this.GNo] = false;
      if (mode == 0)
      {
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = false;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = false;
      }
      else
      {
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = false;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
      }
      this.isOn[this.LEDA1] = false;
      this.isOn[this.LEDB1] = false;
      this.isOn[this.LEDC1] = false;
      this.isOn[this.LEDD1] = false;
      this.isOn[this.LEDE1] = false;
      this.isOn[this.LEDF1] = false;
      this.isOn[this.LEDG1] = false;
      int num1 = val / 100;
      int num2 = val % 100 / 10;
      int num3 = val % 10;
      switch (num1)
      {
        case 0:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        case 1:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        case 2:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = true;
          break;
        case 3:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = true;
          break;
        case 4:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 5:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 6:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 7:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        case 8:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 9:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        default:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
      }
      switch (num2)
      {
        case 0:
          if (num1 == 0)
          {
            this.isOn[this.LEDA3] = false;
            this.isOn[this.LEDB3] = false;
            this.isOn[this.LEDC3] = false;
            this.isOn[this.LEDD3] = false;
            this.isOn[this.LEDE3] = false;
            this.isOn[this.LEDF3] = false;
            this.isOn[this.LEDG3] = false;
            break;
          }
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = false;
          break;
        case 1:
          this.isOn[this.LEDA3] = false;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = false;
          break;
        case 2:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = false;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = true;
          break;
        case 3:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = true;
          break;
        case 4:
          this.isOn[this.LEDA3] = false;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 5:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = false;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 6:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = false;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 7:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = false;
          break;
        case 8:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 9:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
      }
      switch (num3)
      {
        case 0:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = false;
          break;
        case 1:
          this.isOn[this.LEDA4] = false;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = false;
          break;
        case 2:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = false;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = true;
          break;
        case 3:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = true;
          break;
        case 4:
          this.isOn[this.LEDA4] = false;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 5:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = false;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 6:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = false;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 7:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = false;
          break;
        case 8:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 9:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
      }
    }
    else
    {
      if (mode == 1)
      {
        this.isOn[this.BFB] = true;
        this.isOn[this.MHz] = false;
        this.isOn[this.SSD] = false;
      }
      else
      {
        this.isOn[this.BFB] = false;
        this.isOn[this.MHz] = true;
        this.isOn[this.SSD] = false;
      }
      int num4 = val / 10000;
      int num5 = val / 1000 % 10;
      int num6 = val / 100 % 10;
      int num7 = val % 100 / 10;
      int num8 = val % 10;
      switch (num4)
      {
        case 0:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        case 1:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        case 2:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = true;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = true;
          break;
        case 3:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = true;
          break;
        case 4:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 5:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 6:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = true;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 7:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        case 8:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = true;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        case 9:
          this.isOn[this.LEDA1] = true;
          this.isOn[this.LEDB1] = true;
          this.isOn[this.LEDC1] = true;
          this.isOn[this.LEDD1] = true;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = true;
          this.isOn[this.LEDG1] = true;
          break;
        default:
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
      }
      switch (num5)
      {
        case 0:
          if (num4 == 0)
          {
            this.isOn[this.LEDA2] = false;
            this.isOn[this.LEDB2] = false;
            this.isOn[this.LEDC2] = false;
            this.isOn[this.LEDD2] = false;
            this.isOn[this.LEDE2] = false;
            this.isOn[this.LEDF2] = false;
            this.isOn[this.LEDG2] = false;
            break;
          }
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = false;
          break;
        case 1:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        case 2:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = true;
          break;
        case 3:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = true;
          break;
        case 4:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 5:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 6:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 7:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        case 8:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = true;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        case 9:
          this.isOn[this.LEDA2] = true;
          this.isOn[this.LEDB2] = true;
          this.isOn[this.LEDC2] = true;
          this.isOn[this.LEDD2] = true;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = true;
          this.isOn[this.LEDG2] = true;
          break;
        default:
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
      }
      switch (num6)
      {
        case 0:
          if (num4 == 0 && num5 == 0)
          {
            this.isOn[this.LEDA3] = false;
            this.isOn[this.LEDB3] = false;
            this.isOn[this.LEDC3] = false;
            this.isOn[this.LEDD3] = false;
            this.isOn[this.LEDE3] = false;
            this.isOn[this.LEDF3] = false;
            this.isOn[this.LEDG3] = false;
            break;
          }
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = false;
          break;
        case 1:
          this.isOn[this.LEDA3] = false;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = false;
          break;
        case 2:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = false;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = true;
          break;
        case 3:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = true;
          break;
        case 4:
          this.isOn[this.LEDA3] = false;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 5:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = false;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 6:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = false;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 7:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = false;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = false;
          this.isOn[this.LEDG3] = false;
          break;
        case 8:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = true;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
        case 9:
          this.isOn[this.LEDA3] = true;
          this.isOn[this.LEDB3] = true;
          this.isOn[this.LEDC3] = true;
          this.isOn[this.LEDD3] = true;
          this.isOn[this.LEDE3] = false;
          this.isOn[this.LEDF3] = true;
          this.isOn[this.LEDG3] = true;
          break;
      }
      switch (num7)
      {
        case 0:
          if (val < 10)
          {
            this.isOn[this.LEDA4] = false;
            this.isOn[this.LEDB4] = false;
            this.isOn[this.LEDC4] = false;
            this.isOn[this.LEDD4] = false;
            this.isOn[this.LEDE4] = false;
            this.isOn[this.LEDF4] = false;
            this.isOn[this.LEDG4] = false;
            break;
          }
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = false;
          break;
        case 1:
          this.isOn[this.LEDA4] = false;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = false;
          break;
        case 2:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = false;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = true;
          break;
        case 3:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = true;
          break;
        case 4:
          this.isOn[this.LEDA4] = false;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 5:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = false;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 6:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = false;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 7:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = false;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = false;
          this.isOn[this.LEDG4] = false;
          break;
        case 8:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = true;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
        case 9:
          this.isOn[this.LEDA4] = true;
          this.isOn[this.LEDB4] = true;
          this.isOn[this.LEDC4] = true;
          this.isOn[this.LEDD4] = true;
          this.isOn[this.LEDE4] = false;
          this.isOn[this.LEDF4] = true;
          this.isOn[this.LEDG4] = true;
          break;
      }
      switch (num8)
      {
        case 0:
          this.isOn[this.LEDA5] = true;
          this.isOn[this.LEDB5] = true;
          this.isOn[this.LEDC5] = true;
          this.isOn[this.LEDD5] = true;
          this.isOn[this.LEDE5] = true;
          this.isOn[this.LEDF5] = true;
          this.isOn[this.LEDG5] = false;
          break;
        case 1:
          this.isOn[this.LEDA5] = false;
          this.isOn[this.LEDB5] = true;
          this.isOn[this.LEDC5] = true;
          this.isOn[this.LEDD5] = false;
          this.isOn[this.LEDE5] = false;
          this.isOn[this.LEDF5] = false;
          this.isOn[this.LEDG5] = false;
          break;
        case 2:
          this.isOn[this.LEDA5] = true;
          this.isOn[this.LEDB5] = true;
          this.isOn[this.LEDC5] = false;
          this.isOn[this.LEDD5] = true;
          this.isOn[this.LEDE5] = true;
          this.isOn[this.LEDF5] = false;
          this.isOn[this.LEDG5] = true;
          break;
        case 3:
          this.isOn[this.LEDA5] = true;
          this.isOn[this.LEDB5] = true;
          this.isOn[this.LEDC5] = true;
          this.isOn[this.LEDD5] = true;
          this.isOn[this.LEDE5] = false;
          this.isOn[this.LEDF5] = false;
          this.isOn[this.LEDG5] = true;
          break;
        case 4:
          this.isOn[this.LEDA5] = false;
          this.isOn[this.LEDB5] = true;
          this.isOn[this.LEDC5] = true;
          this.isOn[this.LEDD5] = false;
          this.isOn[this.LEDE5] = false;
          this.isOn[this.LEDF5] = true;
          this.isOn[this.LEDG5] = true;
          break;
        case 5:
          this.isOn[this.LEDA5] = true;
          this.isOn[this.LEDB5] = false;
          this.isOn[this.LEDC5] = true;
          this.isOn[this.LEDD5] = true;
          this.isOn[this.LEDE5] = false;
          this.isOn[this.LEDF5] = true;
          this.isOn[this.LEDG5] = true;
          break;
        case 6:
          this.isOn[this.LEDA5] = true;
          this.isOn[this.LEDB5] = false;
          this.isOn[this.LEDC5] = true;
          this.isOn[this.LEDD5] = true;
          this.isOn[this.LEDE5] = true;
          this.isOn[this.LEDF5] = true;
          this.isOn[this.LEDG5] = true;
          break;
        case 7:
          this.isOn[this.LEDA5] = true;
          this.isOn[this.LEDB5] = true;
          this.isOn[this.LEDC5] = true;
          this.isOn[this.LEDD5] = false;
          this.isOn[this.LEDE5] = false;
          this.isOn[this.LEDF5] = false;
          this.isOn[this.LEDG5] = false;
          break;
        case 8:
          this.isOn[this.LEDA5] = true;
          this.isOn[this.LEDB5] = true;
          this.isOn[this.LEDC5] = true;
          this.isOn[this.LEDD5] = true;
          this.isOn[this.LEDE5] = true;
          this.isOn[this.LEDF5] = true;
          this.isOn[this.LEDG5] = true;
          break;
        case 9:
          this.isOn[this.LEDA5] = true;
          this.isOn[this.LEDB5] = true;
          this.isOn[this.LEDC5] = true;
          this.isOn[this.LEDD5] = true;
          this.isOn[this.LEDE5] = false;
          this.isOn[this.LEDF5] = true;
          this.isOn[this.LEDG5] = true;
          break;
      }
    }
  }

  public void SetMyNumeral(int temp, int watt, int mhz, byte use)
  {
    int num1 = temp / 100 % 10;
    int num2 = temp % 100 / 10;
    int num3 = temp % 10;
    switch (num1)
    {
      case 0:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 1:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 2:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 3:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 4:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 5:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 6:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 7:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 8:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 9:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      default:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
    }
    switch (num2)
    {
      case 0:
        if (num1 == 0)
        {
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          break;
        }
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = false;
        break;
      case 1:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 2:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = false;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 3:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 4:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 5:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 6:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 7:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 8:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 9:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
    }
    switch (num3)
    {
      case 0:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = false;
        break;
      case 1:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 2:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = false;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 3:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 4:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 5:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 6:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 7:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 8:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 9:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
    }
    int num4 = watt / 100 % 10;
    int num5 = watt % 100 / 10;
    int num6 = watt % 10;
    switch (num4)
    {
      case 0:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 1:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 2:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = true;
        break;
      case 3:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = true;
        break;
      case 4:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 5:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 6:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 7:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 8:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 9:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      default:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
    }
    switch (num5)
    {
      case 0:
        if (num4 == 0)
        {
          this.isOn[this.LEDA5] = false;
          this.isOn[this.LEDB5] = false;
          this.isOn[this.LEDC5] = false;
          this.isOn[this.LEDD5] = false;
          this.isOn[this.LEDE5] = false;
          this.isOn[this.LEDF5] = false;
          this.isOn[this.LEDG5] = false;
          break;
        }
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = false;
        break;
      case 1:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = false;
        break;
      case 2:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = false;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = true;
        break;
      case 3:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = true;
        break;
      case 4:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 5:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 6:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 7:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = false;
        break;
      case 8:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 9:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
    }
    switch (num6)
    {
      case 0:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = false;
        break;
      case 1:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 2:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = false;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = true;
        break;
      case 3:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = true;
        break;
      case 4:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 5:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 6:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 7:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 8:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 9:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
    }
    int num7 = mhz / 1000;
    int num8 = mhz / 100 % 10;
    int num9 = mhz % 100 / 10;
    int num10 = mhz % 10;
    switch (num7)
    {
      case 0:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = false;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
      case 1:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
      case 2:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = false;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = true;
        break;
      case 3:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = true;
        break;
      case 4:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 5:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 6:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 7:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
      case 8:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 9:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      default:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = false;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
    }
    switch (num8)
    {
      case 0:
        if (num7 == 0)
        {
          this.isOn[this.LEDA8] = false;
          this.isOn[this.LEDB8] = false;
          this.isOn[this.LEDC8] = false;
          this.isOn[this.LEDD8] = false;
          this.isOn[this.LEDE8] = false;
          this.isOn[this.LEDF8] = false;
          this.isOn[this.LEDG8] = false;
          break;
        }
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = false;
        break;
      case 1:
        this.isOn[this.LEDA8] = false;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = false;
        break;
      case 2:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = false;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = true;
        break;
      case 3:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = true;
        break;
      case 4:
        this.isOn[this.LEDA8] = false;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 5:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = false;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 6:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = false;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 7:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = false;
        break;
      case 8:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = true;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      case 9:
        this.isOn[this.LEDA8] = true;
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        this.isOn[this.LEDD8] = true;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = true;
        this.isOn[this.LEDG8] = true;
        break;
      default:
        this.isOn[this.LEDA8] = false;
        this.isOn[this.LEDB8] = false;
        this.isOn[this.LEDC8] = false;
        this.isOn[this.LEDD8] = false;
        this.isOn[this.LEDE8] = false;
        this.isOn[this.LEDF8] = false;
        this.isOn[this.LEDG8] = false;
        break;
    }
    switch (num9)
    {
      case 0:
        if (num8 == 0 && num7 == 0)
        {
          this.isOn[this.LEDA9] = false;
          this.isOn[this.LEDB9] = false;
          this.isOn[this.LEDC9] = false;
          this.isOn[this.LEDD9] = false;
          this.isOn[this.LEDE9] = false;
          this.isOn[this.LEDF9] = false;
          this.isOn[this.LEDG9] = false;
          break;
        }
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = true;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = false;
        break;
      case 1:
        this.isOn[this.LEDA9] = false;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = false;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = false;
        this.isOn[this.LEDG9] = false;
        break;
      case 2:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = false;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = true;
        this.isOn[this.LEDF9] = false;
        this.isOn[this.LEDG9] = true;
        break;
      case 3:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = false;
        this.isOn[this.LEDG9] = true;
        break;
      case 4:
        this.isOn[this.LEDA9] = false;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = false;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
      case 5:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = false;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
      case 6:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = false;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = true;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
      case 7:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = false;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = false;
        this.isOn[this.LEDG9] = false;
        break;
      case 8:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = true;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
      case 9:
        this.isOn[this.LEDA9] = true;
        this.isOn[this.LEDB9] = true;
        this.isOn[this.LEDC9] = true;
        this.isOn[this.LEDD9] = true;
        this.isOn[this.LEDE9] = false;
        this.isOn[this.LEDF9] = true;
        this.isOn[this.LEDG9] = true;
        break;
    }
    switch (num10)
    {
      case 0:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = true;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = false;
        break;
      case 1:
        this.isOn[this.LEDA10] = false;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = false;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = false;
        this.isOn[this.LEDG10] = false;
        break;
      case 2:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = false;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = true;
        this.isOn[this.LEDF10] = false;
        this.isOn[this.LEDG10] = true;
        break;
      case 3:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = false;
        this.isOn[this.LEDG10] = true;
        break;
      case 4:
        this.isOn[this.LEDA10] = false;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = false;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
      case 5:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = false;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
      case 6:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = false;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = true;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
      case 7:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = false;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = false;
        this.isOn[this.LEDG10] = false;
        break;
      case 8:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = true;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
      case 9:
        this.isOn[this.LEDA10] = true;
        this.isOn[this.LEDB10] = true;
        this.isOn[this.LEDC10] = true;
        this.isOn[this.LEDD10] = true;
        this.isOn[this.LEDE10] = false;
        this.isOn[this.LEDF10] = true;
        this.isOn[this.LEDG10] = true;
        break;
    }
    int num11 = (int) use / 100 % 10;
    int num12 = (int) use % 100 / 10;
    int num13 = (int) use % 10;
    switch (num11)
    {
      case 0:
        this.isOn[this.LEDB13] = false;
        this.isOn[this.LEDC13] = false;
        break;
      case 1:
        this.isOn[this.LEDB13] = true;
        this.isOn[this.LEDC13] = true;
        break;
      default:
        this.isOn[this.LEDB13] = false;
        this.isOn[this.LEDC13] = false;
        break;
    }
    switch (num12)
    {
      case 0:
        if (num11 == 0)
        {
          this.isOn[this.LEDA11] = false;
          this.isOn[this.LEDB11] = false;
          this.isOn[this.LEDC11] = false;
          this.isOn[this.LEDD11] = false;
          this.isOn[this.LEDE11] = false;
          this.isOn[this.LEDF11] = false;
          this.isOn[this.LEDG11] = false;
          break;
        }
        this.isOn[this.LEDA11] = true;
        this.isOn[this.LEDB11] = true;
        this.isOn[this.LEDC11] = true;
        this.isOn[this.LEDD11] = true;
        this.isOn[this.LEDE11] = true;
        this.isOn[this.LEDF11] = true;
        this.isOn[this.LEDG11] = false;
        break;
      case 1:
        this.isOn[this.LEDA11] = false;
        this.isOn[this.LEDB11] = true;
        this.isOn[this.LEDC11] = true;
        this.isOn[this.LEDD11] = false;
        this.isOn[this.LEDE11] = false;
        this.isOn[this.LEDF11] = false;
        this.isOn[this.LEDG11] = false;
        break;
      case 2:
        this.isOn[this.LEDA11] = true;
        this.isOn[this.LEDB11] = true;
        this.isOn[this.LEDC11] = false;
        this.isOn[this.LEDD11] = true;
        this.isOn[this.LEDE11] = true;
        this.isOn[this.LEDF11] = false;
        this.isOn[this.LEDG11] = true;
        break;
      case 3:
        this.isOn[this.LEDA11] = true;
        this.isOn[this.LEDB11] = true;
        this.isOn[this.LEDC11] = true;
        this.isOn[this.LEDD11] = true;
        this.isOn[this.LEDE11] = false;
        this.isOn[this.LEDF11] = false;
        this.isOn[this.LEDG11] = true;
        break;
      case 4:
        this.isOn[this.LEDA11] = false;
        this.isOn[this.LEDB11] = true;
        this.isOn[this.LEDC11] = true;
        this.isOn[this.LEDD11] = false;
        this.isOn[this.LEDE11] = false;
        this.isOn[this.LEDF11] = true;
        this.isOn[this.LEDG11] = true;
        break;
      case 5:
        this.isOn[this.LEDA11] = true;
        this.isOn[this.LEDB11] = false;
        this.isOn[this.LEDC11] = true;
        this.isOn[this.LEDD11] = true;
        this.isOn[this.LEDE11] = false;
        this.isOn[this.LEDF11] = true;
        this.isOn[this.LEDG11] = true;
        break;
      case 6:
        this.isOn[this.LEDA11] = true;
        this.isOn[this.LEDB11] = false;
        this.isOn[this.LEDC11] = true;
        this.isOn[this.LEDD11] = true;
        this.isOn[this.LEDE11] = true;
        this.isOn[this.LEDF11] = true;
        this.isOn[this.LEDG11] = true;
        break;
      case 7:
        this.isOn[this.LEDA11] = true;
        this.isOn[this.LEDB11] = true;
        this.isOn[this.LEDC11] = true;
        this.isOn[this.LEDD11] = false;
        this.isOn[this.LEDE11] = false;
        this.isOn[this.LEDF11] = false;
        this.isOn[this.LEDG11] = false;
        break;
      case 8:
        this.isOn[this.LEDA11] = true;
        this.isOn[this.LEDB11] = true;
        this.isOn[this.LEDC11] = true;
        this.isOn[this.LEDD11] = true;
        this.isOn[this.LEDE11] = true;
        this.isOn[this.LEDF11] = true;
        this.isOn[this.LEDG11] = true;
        break;
      case 9:
        this.isOn[this.LEDA11] = true;
        this.isOn[this.LEDB11] = true;
        this.isOn[this.LEDC11] = true;
        this.isOn[this.LEDD11] = true;
        this.isOn[this.LEDE11] = false;
        this.isOn[this.LEDF11] = true;
        this.isOn[this.LEDG11] = true;
        break;
    }
    switch (num13)
    {
      case 0:
        this.isOn[this.LEDA12] = true;
        this.isOn[this.LEDB12] = true;
        this.isOn[this.LEDC12] = true;
        this.isOn[this.LEDD12] = true;
        this.isOn[this.LEDE12] = true;
        this.isOn[this.LEDF12] = true;
        this.isOn[this.LEDG12] = false;
        break;
      case 1:
        this.isOn[this.LEDA12] = false;
        this.isOn[this.LEDB12] = true;
        this.isOn[this.LEDC12] = true;
        this.isOn[this.LEDD12] = false;
        this.isOn[this.LEDE12] = false;
        this.isOn[this.LEDF12] = false;
        this.isOn[this.LEDG12] = false;
        break;
      case 2:
        this.isOn[this.LEDA12] = true;
        this.isOn[this.LEDB12] = true;
        this.isOn[this.LEDC12] = false;
        this.isOn[this.LEDD12] = true;
        this.isOn[this.LEDE12] = true;
        this.isOn[this.LEDF12] = false;
        this.isOn[this.LEDG12] = true;
        break;
      case 3:
        this.isOn[this.LEDA12] = true;
        this.isOn[this.LEDB12] = true;
        this.isOn[this.LEDC12] = true;
        this.isOn[this.LEDD12] = true;
        this.isOn[this.LEDE12] = false;
        this.isOn[this.LEDF12] = false;
        this.isOn[this.LEDG12] = true;
        break;
      case 4:
        this.isOn[this.LEDA12] = false;
        this.isOn[this.LEDB12] = true;
        this.isOn[this.LEDC12] = true;
        this.isOn[this.LEDD12] = false;
        this.isOn[this.LEDE12] = false;
        this.isOn[this.LEDF12] = true;
        this.isOn[this.LEDG12] = true;
        break;
      case 5:
        this.isOn[this.LEDA12] = true;
        this.isOn[this.LEDB12] = false;
        this.isOn[this.LEDC12] = true;
        this.isOn[this.LEDD12] = true;
        this.isOn[this.LEDE12] = false;
        this.isOn[this.LEDF12] = true;
        this.isOn[this.LEDG12] = true;
        break;
      case 6:
        this.isOn[this.LEDA12] = true;
        this.isOn[this.LEDB12] = false;
        this.isOn[this.LEDC12] = true;
        this.isOn[this.LEDD12] = true;
        this.isOn[this.LEDE12] = true;
        this.isOn[this.LEDF12] = true;
        this.isOn[this.LEDG12] = true;
        break;
      case 7:
        this.isOn[this.LEDA12] = true;
        this.isOn[this.LEDB12] = true;
        this.isOn[this.LEDC12] = true;
        this.isOn[this.LEDD12] = false;
        this.isOn[this.LEDE12] = false;
        this.isOn[this.LEDF12] = false;
        this.isOn[this.LEDG12] = false;
        break;
      case 8:
        this.isOn[this.LEDA12] = true;
        this.isOn[this.LEDB12] = true;
        this.isOn[this.LEDC12] = true;
        this.isOn[this.LEDD12] = true;
        this.isOn[this.LEDE12] = true;
        this.isOn[this.LEDF12] = true;
        this.isOn[this.LEDG12] = true;
        break;
      case 9:
        this.isOn[this.LEDA12] = true;
        this.isOn[this.LEDB12] = true;
        this.isOn[this.LEDC12] = true;
        this.isOn[this.LEDD12] = true;
        this.isOn[this.LEDE12] = false;
        this.isOn[this.LEDF12] = true;
        this.isOn[this.LEDG12] = true;
        break;
    }
  }

  public void SetMyNumeralNew(int cpuTemp, int gpuTemp)
  {
    int num1 = cpuTemp / 100;
    int num2 = cpuTemp % 100 / 10;
    int num3 = cpuTemp % 10;
    switch (num1)
    {
      case 0:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        this.isOn[this.LEDH1] = false;
        this.isOn[this.LEDI1] = false;
        this.isOn[this.LEDJ1] = false;
        this.isOn[this.LEDK1] = false;
        this.isOn[this.LEDL1] = false;
        this.isOn[this.LEDM1] = false;
        break;
      case 1:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        this.isOn[this.LEDH1] = false;
        this.isOn[this.LEDI1] = false;
        this.isOn[this.LEDJ1] = false;
        this.isOn[this.LEDK1] = false;
        this.isOn[this.LEDL1] = false;
        this.isOn[this.LEDM1] = false;
        break;
      case 2:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        this.isOn[this.LEDH1] = true;
        this.isOn[this.LEDI1] = true;
        this.isOn[this.LEDJ1] = true;
        this.isOn[this.LEDK1] = true;
        this.isOn[this.LEDL1] = false;
        this.isOn[this.LEDM1] = true;
        break;
      case 3:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        this.isOn[this.LEDH1] = true;
        this.isOn[this.LEDI1] = true;
        this.isOn[this.LEDJ1] = false;
        this.isOn[this.LEDK1] = true;
        this.isOn[this.LEDL1] = false;
        this.isOn[this.LEDM1] = true;
        break;
      case 4:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        this.isOn[this.LEDH1] = false;
        this.isOn[this.LEDI1] = false;
        this.isOn[this.LEDJ1] = false;
        this.isOn[this.LEDK1] = true;
        this.isOn[this.LEDL1] = true;
        this.isOn[this.LEDM1] = true;
        break;
      case 5:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        this.isOn[this.LEDH1] = true;
        this.isOn[this.LEDI1] = true;
        this.isOn[this.LEDJ1] = false;
        this.isOn[this.LEDK1] = true;
        this.isOn[this.LEDL1] = true;
        this.isOn[this.LEDM1] = true;
        break;
      case 6:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        this.isOn[this.LEDH1] = true;
        this.isOn[this.LEDI1] = true;
        this.isOn[this.LEDJ1] = true;
        this.isOn[this.LEDK1] = true;
        this.isOn[this.LEDL1] = true;
        this.isOn[this.LEDM1] = true;
        break;
      case 7:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        this.isOn[this.LEDH1] = false;
        this.isOn[this.LEDI1] = false;
        this.isOn[this.LEDJ1] = false;
        this.isOn[this.LEDK1] = false;
        this.isOn[this.LEDL1] = false;
        this.isOn[this.LEDM1] = false;
        break;
      case 8:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        this.isOn[this.LEDH1] = true;
        this.isOn[this.LEDI1] = true;
        this.isOn[this.LEDJ1] = true;
        this.isOn[this.LEDK1] = true;
        this.isOn[this.LEDL1] = true;
        this.isOn[this.LEDM1] = true;
        break;
      case 9:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        this.isOn[this.LEDH1] = true;
        this.isOn[this.LEDI1] = true;
        this.isOn[this.LEDJ1] = false;
        this.isOn[this.LEDK1] = true;
        this.isOn[this.LEDL1] = true;
        this.isOn[this.LEDM1] = true;
        break;
      default:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        this.isOn[this.LEDH1] = false;
        this.isOn[this.LEDI1] = false;
        this.isOn[this.LEDJ1] = false;
        this.isOn[this.LEDK1] = false;
        this.isOn[this.LEDL1] = false;
        this.isOn[this.LEDM1] = false;
        break;
    }
    switch (num2)
    {
      case 0:
        if (num1 == 0)
        {
          this.isOn[this.LEDA2] = false;
          this.isOn[this.LEDB2] = false;
          this.isOn[this.LEDC2] = false;
          this.isOn[this.LEDD2] = false;
          this.isOn[this.LEDE2] = false;
          this.isOn[this.LEDF2] = false;
          this.isOn[this.LEDG2] = false;
          this.isOn[this.LEDH2] = false;
          this.isOn[this.LEDI2] = false;
          this.isOn[this.LEDJ2] = false;
          this.isOn[this.LEDK2] = false;
          this.isOn[this.LEDL2] = false;
          this.isOn[this.LEDM2] = false;
          break;
        }
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = true;
        this.isOn[this.LEDI2] = true;
        this.isOn[this.LEDJ2] = true;
        this.isOn[this.LEDK2] = true;
        this.isOn[this.LEDL2] = true;
        this.isOn[this.LEDM2] = false;
        break;
      case 1:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = false;
        this.isOn[this.LEDI2] = false;
        this.isOn[this.LEDJ2] = false;
        this.isOn[this.LEDK2] = false;
        this.isOn[this.LEDL2] = false;
        this.isOn[this.LEDM2] = false;
        break;
      case 2:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = true;
        this.isOn[this.LEDI2] = true;
        this.isOn[this.LEDJ2] = true;
        this.isOn[this.LEDK2] = true;
        this.isOn[this.LEDL2] = false;
        this.isOn[this.LEDM2] = true;
        break;
      case 3:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = true;
        this.isOn[this.LEDI2] = true;
        this.isOn[this.LEDJ2] = false;
        this.isOn[this.LEDK2] = true;
        this.isOn[this.LEDL2] = false;
        this.isOn[this.LEDM2] = true;
        break;
      case 4:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = false;
        this.isOn[this.LEDI2] = false;
        this.isOn[this.LEDJ2] = false;
        this.isOn[this.LEDK2] = true;
        this.isOn[this.LEDL2] = true;
        this.isOn[this.LEDM2] = true;
        break;
      case 5:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = true;
        this.isOn[this.LEDI2] = true;
        this.isOn[this.LEDJ2] = false;
        this.isOn[this.LEDK2] = true;
        this.isOn[this.LEDL2] = true;
        this.isOn[this.LEDM2] = true;
        break;
      case 6:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = true;
        this.isOn[this.LEDI2] = true;
        this.isOn[this.LEDJ2] = true;
        this.isOn[this.LEDK2] = true;
        this.isOn[this.LEDL2] = true;
        this.isOn[this.LEDM2] = true;
        break;
      case 7:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = false;
        this.isOn[this.LEDI2] = false;
        this.isOn[this.LEDJ2] = false;
        this.isOn[this.LEDK2] = false;
        this.isOn[this.LEDL2] = false;
        this.isOn[this.LEDM2] = false;
        break;
      case 8:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = true;
        this.isOn[this.LEDI2] = true;
        this.isOn[this.LEDJ2] = true;
        this.isOn[this.LEDK2] = true;
        this.isOn[this.LEDL2] = true;
        this.isOn[this.LEDM2] = true;
        break;
      case 9:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        this.isOn[this.LEDH2] = true;
        this.isOn[this.LEDI2] = true;
        this.isOn[this.LEDJ2] = false;
        this.isOn[this.LEDK2] = true;
        this.isOn[this.LEDL2] = true;
        this.isOn[this.LEDM2] = true;
        break;
      default:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = false;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        this.isOn[this.LEDH2] = false;
        this.isOn[this.LEDI2] = false;
        this.isOn[this.LEDJ2] = false;
        this.isOn[this.LEDK2] = false;
        this.isOn[this.LEDL2] = false;
        this.isOn[this.LEDM2] = false;
        break;
    }
    switch (num3)
    {
      case 0:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = true;
        this.isOn[this.LEDI3] = true;
        this.isOn[this.LEDJ3] = true;
        this.isOn[this.LEDK3] = true;
        this.isOn[this.LEDL3] = true;
        this.isOn[this.LEDM3] = false;
        break;
      case 1:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = false;
        this.isOn[this.LEDI3] = false;
        this.isOn[this.LEDJ3] = false;
        this.isOn[this.LEDK3] = false;
        this.isOn[this.LEDL3] = false;
        this.isOn[this.LEDM3] = false;
        break;
      case 2:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = true;
        this.isOn[this.LEDI3] = true;
        this.isOn[this.LEDJ3] = true;
        this.isOn[this.LEDK3] = true;
        this.isOn[this.LEDL3] = false;
        this.isOn[this.LEDM3] = true;
        break;
      case 3:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = true;
        this.isOn[this.LEDI3] = true;
        this.isOn[this.LEDJ3] = false;
        this.isOn[this.LEDK3] = true;
        this.isOn[this.LEDL3] = false;
        this.isOn[this.LEDM3] = true;
        break;
      case 4:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = false;
        this.isOn[this.LEDI3] = false;
        this.isOn[this.LEDJ3] = false;
        this.isOn[this.LEDK3] = true;
        this.isOn[this.LEDL3] = true;
        this.isOn[this.LEDM3] = true;
        break;
      case 5:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = true;
        this.isOn[this.LEDI3] = true;
        this.isOn[this.LEDJ3] = false;
        this.isOn[this.LEDK3] = true;
        this.isOn[this.LEDL3] = true;
        this.isOn[this.LEDM3] = true;
        break;
      case 6:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = true;
        this.isOn[this.LEDI3] = true;
        this.isOn[this.LEDJ3] = true;
        this.isOn[this.LEDK3] = true;
        this.isOn[this.LEDL3] = true;
        this.isOn[this.LEDM3] = true;
        break;
      case 7:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = false;
        this.isOn[this.LEDI3] = false;
        this.isOn[this.LEDJ3] = false;
        this.isOn[this.LEDK3] = false;
        this.isOn[this.LEDL3] = false;
        this.isOn[this.LEDM3] = false;
        break;
      case 8:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = true;
        this.isOn[this.LEDI3] = true;
        this.isOn[this.LEDJ3] = true;
        this.isOn[this.LEDK3] = true;
        this.isOn[this.LEDL3] = true;
        this.isOn[this.LEDM3] = true;
        break;
      case 9:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        this.isOn[this.LEDH3] = true;
        this.isOn[this.LEDI3] = true;
        this.isOn[this.LEDJ3] = false;
        this.isOn[this.LEDK3] = true;
        this.isOn[this.LEDL3] = true;
        this.isOn[this.LEDM3] = true;
        break;
      default:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = false;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        this.isOn[this.LEDH3] = false;
        this.isOn[this.LEDI3] = false;
        this.isOn[this.LEDJ3] = false;
        this.isOn[this.LEDK3] = false;
        this.isOn[this.LEDL3] = false;
        this.isOn[this.LEDM3] = false;
        break;
    }
    int num4 = gpuTemp / 100;
    int num5 = gpuTemp % 100 / 10;
    int num6 = gpuTemp % 10;
    switch (num4)
    {
      case 0:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        this.isOn[this.LEDH4] = false;
        this.isOn[this.LEDI4] = false;
        this.isOn[this.LEDJ4] = false;
        this.isOn[this.LEDK4] = false;
        this.isOn[this.LEDL4] = false;
        this.isOn[this.LEDM4] = false;
        break;
      case 1:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        this.isOn[this.LEDH4] = false;
        this.isOn[this.LEDI4] = false;
        this.isOn[this.LEDJ4] = false;
        this.isOn[this.LEDK4] = false;
        this.isOn[this.LEDL4] = false;
        this.isOn[this.LEDM4] = false;
        break;
      case 2:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = true;
        this.isOn[this.LEDH4] = true;
        this.isOn[this.LEDI4] = true;
        this.isOn[this.LEDJ4] = true;
        this.isOn[this.LEDK4] = true;
        this.isOn[this.LEDL4] = false;
        this.isOn[this.LEDM4] = true;
        break;
      case 3:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        this.isOn[this.LEDH4] = true;
        this.isOn[this.LEDI4] = true;
        this.isOn[this.LEDJ4] = false;
        this.isOn[this.LEDK4] = true;
        this.isOn[this.LEDL4] = false;
        this.isOn[this.LEDM4] = true;
        break;
      case 4:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        this.isOn[this.LEDH4] = false;
        this.isOn[this.LEDI4] = false;
        this.isOn[this.LEDJ4] = false;
        this.isOn[this.LEDK4] = true;
        this.isOn[this.LEDL4] = true;
        this.isOn[this.LEDM4] = true;
        break;
      case 5:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        this.isOn[this.LEDH4] = true;
        this.isOn[this.LEDI4] = true;
        this.isOn[this.LEDJ4] = false;
        this.isOn[this.LEDK4] = true;
        this.isOn[this.LEDL4] = true;
        this.isOn[this.LEDM4] = true;
        break;
      case 6:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        this.isOn[this.LEDH4] = true;
        this.isOn[this.LEDI4] = true;
        this.isOn[this.LEDJ4] = true;
        this.isOn[this.LEDK4] = true;
        this.isOn[this.LEDL4] = true;
        this.isOn[this.LEDM4] = true;
        break;
      case 7:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        this.isOn[this.LEDH4] = false;
        this.isOn[this.LEDI4] = false;
        this.isOn[this.LEDJ4] = false;
        this.isOn[this.LEDK4] = false;
        this.isOn[this.LEDL4] = false;
        this.isOn[this.LEDM4] = false;
        break;
      case 8:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        this.isOn[this.LEDH4] = true;
        this.isOn[this.LEDI4] = true;
        this.isOn[this.LEDJ4] = true;
        this.isOn[this.LEDK4] = true;
        this.isOn[this.LEDL4] = true;
        this.isOn[this.LEDM4] = true;
        break;
      case 9:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        this.isOn[this.LEDH4] = true;
        this.isOn[this.LEDI4] = true;
        this.isOn[this.LEDJ4] = false;
        this.isOn[this.LEDK4] = true;
        this.isOn[this.LEDL4] = true;
        this.isOn[this.LEDM4] = true;
        break;
      default:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        this.isOn[this.LEDH4] = false;
        this.isOn[this.LEDI4] = false;
        this.isOn[this.LEDJ4] = false;
        this.isOn[this.LEDK4] = false;
        this.isOn[this.LEDL4] = false;
        this.isOn[this.LEDM4] = false;
        break;
    }
    switch (num5)
    {
      case 0:
        if (num4 == 0)
        {
          this.isOn[this.LEDA5] = false;
          this.isOn[this.LEDB5] = false;
          this.isOn[this.LEDC5] = false;
          this.isOn[this.LEDD5] = false;
          this.isOn[this.LEDE5] = false;
          this.isOn[this.LEDF5] = false;
          this.isOn[this.LEDG5] = false;
          this.isOn[this.LEDH5] = false;
          this.isOn[this.LEDI5] = false;
          this.isOn[this.LEDJ5] = false;
          this.isOn[this.LEDK5] = false;
          this.isOn[this.LEDL5] = false;
          this.isOn[this.LEDM5] = false;
          break;
        }
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = true;
        this.isOn[this.LEDI5] = true;
        this.isOn[this.LEDJ5] = true;
        this.isOn[this.LEDK5] = true;
        this.isOn[this.LEDL5] = true;
        this.isOn[this.LEDM5] = false;
        break;
      case 1:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = false;
        this.isOn[this.LEDI5] = false;
        this.isOn[this.LEDJ5] = false;
        this.isOn[this.LEDK5] = false;
        this.isOn[this.LEDL5] = false;
        this.isOn[this.LEDM5] = false;
        break;
      case 2:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = true;
        this.isOn[this.LEDI5] = true;
        this.isOn[this.LEDJ5] = true;
        this.isOn[this.LEDK5] = true;
        this.isOn[this.LEDL5] = false;
        this.isOn[this.LEDM5] = true;
        break;
      case 3:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = true;
        this.isOn[this.LEDI5] = true;
        this.isOn[this.LEDJ5] = false;
        this.isOn[this.LEDK5] = true;
        this.isOn[this.LEDL5] = false;
        this.isOn[this.LEDM5] = true;
        break;
      case 4:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = false;
        this.isOn[this.LEDI5] = false;
        this.isOn[this.LEDJ5] = false;
        this.isOn[this.LEDK5] = true;
        this.isOn[this.LEDL5] = true;
        this.isOn[this.LEDM5] = true;
        break;
      case 5:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = true;
        this.isOn[this.LEDI5] = true;
        this.isOn[this.LEDJ5] = false;
        this.isOn[this.LEDK5] = true;
        this.isOn[this.LEDL5] = true;
        this.isOn[this.LEDM5] = true;
        break;
      case 6:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = true;
        this.isOn[this.LEDI5] = true;
        this.isOn[this.LEDJ5] = true;
        this.isOn[this.LEDK5] = true;
        this.isOn[this.LEDL5] = true;
        this.isOn[this.LEDM5] = true;
        break;
      case 7:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = false;
        this.isOn[this.LEDI5] = false;
        this.isOn[this.LEDJ5] = false;
        this.isOn[this.LEDK5] = false;
        this.isOn[this.LEDL5] = false;
        this.isOn[this.LEDM5] = false;
        break;
      case 8:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = true;
        this.isOn[this.LEDI5] = true;
        this.isOn[this.LEDJ5] = true;
        this.isOn[this.LEDK5] = true;
        this.isOn[this.LEDL5] = true;
        this.isOn[this.LEDM5] = true;
        break;
      case 9:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        this.isOn[this.LEDH5] = true;
        this.isOn[this.LEDI5] = true;
        this.isOn[this.LEDJ5] = false;
        this.isOn[this.LEDK5] = true;
        this.isOn[this.LEDL5] = true;
        this.isOn[this.LEDM5] = true;
        break;
      default:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = false;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = false;
        this.isOn[this.LEDH5] = false;
        this.isOn[this.LEDI5] = false;
        this.isOn[this.LEDJ5] = false;
        this.isOn[this.LEDK5] = false;
        this.isOn[this.LEDL5] = false;
        this.isOn[this.LEDM5] = false;
        break;
    }
    switch (num6)
    {
      case 0:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = true;
        this.isOn[this.LEDI6] = true;
        this.isOn[this.LEDJ6] = true;
        this.isOn[this.LEDK6] = true;
        this.isOn[this.LEDL6] = true;
        this.isOn[this.LEDM6] = false;
        break;
      case 1:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = false;
        this.isOn[this.LEDI6] = false;
        this.isOn[this.LEDJ6] = false;
        this.isOn[this.LEDK6] = false;
        this.isOn[this.LEDL6] = false;
        this.isOn[this.LEDM6] = false;
        break;
      case 2:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = true;
        this.isOn[this.LEDI6] = true;
        this.isOn[this.LEDJ6] = true;
        this.isOn[this.LEDK6] = true;
        this.isOn[this.LEDL6] = false;
        this.isOn[this.LEDM6] = true;
        break;
      case 3:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = true;
        this.isOn[this.LEDI6] = true;
        this.isOn[this.LEDJ6] = false;
        this.isOn[this.LEDK6] = true;
        this.isOn[this.LEDL6] = false;
        this.isOn[this.LEDM6] = true;
        break;
      case 4:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = false;
        this.isOn[this.LEDI6] = false;
        this.isOn[this.LEDJ6] = false;
        this.isOn[this.LEDK6] = true;
        this.isOn[this.LEDL6] = true;
        this.isOn[this.LEDM6] = true;
        break;
      case 5:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = true;
        this.isOn[this.LEDI6] = true;
        this.isOn[this.LEDJ6] = false;
        this.isOn[this.LEDK6] = true;
        this.isOn[this.LEDL6] = true;
        this.isOn[this.LEDM6] = true;
        break;
      case 6:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = true;
        this.isOn[this.LEDI6] = true;
        this.isOn[this.LEDJ6] = true;
        this.isOn[this.LEDK6] = true;
        this.isOn[this.LEDL6] = true;
        this.isOn[this.LEDM6] = true;
        break;
      case 7:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = false;
        this.isOn[this.LEDI6] = false;
        this.isOn[this.LEDJ6] = false;
        this.isOn[this.LEDK6] = false;
        this.isOn[this.LEDL6] = false;
        this.isOn[this.LEDM6] = false;
        break;
      case 8:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = true;
        this.isOn[this.LEDI6] = true;
        this.isOn[this.LEDJ6] = true;
        this.isOn[this.LEDK6] = true;
        this.isOn[this.LEDL6] = true;
        this.isOn[this.LEDM6] = true;
        break;
      case 9:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        this.isOn[this.LEDH6] = true;
        this.isOn[this.LEDI6] = true;
        this.isOn[this.LEDJ6] = false;
        this.isOn[this.LEDK6] = true;
        this.isOn[this.LEDL6] = true;
        this.isOn[this.LEDM6] = true;
        break;
      default:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = false;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        this.isOn[this.LEDH6] = false;
        this.isOn[this.LEDI6] = false;
        this.isOn[this.LEDJ6] = false;
        this.isOn[this.LEDK6] = false;
        this.isOn[this.LEDL6] = false;
        this.isOn[this.LEDM6] = false;
        break;
    }
  }

  public void SetMyNumeralNew(int val)
  {
    int num1 = val / 100;
    int num2 = val % 100 / 10;
    int num3 = val % 10;
    switch (num2)
    {
      case 0:
        if (num1 == 0)
        {
          this.isOn[this.LEDA1] = false;
          this.isOn[this.LEDB1] = false;
          this.isOn[this.LEDC1] = false;
          this.isOn[this.LEDD1] = false;
          this.isOn[this.LEDE1] = false;
          this.isOn[this.LEDF1] = false;
          this.isOn[this.LEDG1] = false;
          break;
        }
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = false;
        break;
      case 1:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 2:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 3:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 4:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 5:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 6:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 7:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 8:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 9:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      default:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
    }
    switch (num3)
    {
      case 0:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = false;
        break;
      case 1:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 2:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = false;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 3:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 4:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 5:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 6:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 7:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 8:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 9:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
    }
  }

  public void SetMyTimer(int M, int d, int h, int m, int w)
  {
    int num1 = h % 100 / 10;
    int num2 = h % 10;
    switch (num1)
    {
      case 0:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = false;
        break;
      case 1:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 2:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = false;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 3:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = true;
        break;
      case 4:
        this.isOn[this.LEDA1] = false;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 5:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 6:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = false;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 7:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = false;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = false;
        this.isOn[this.LEDG1] = false;
        break;
      case 8:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = true;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
      case 9:
        this.isOn[this.LEDA1] = true;
        this.isOn[this.LEDB1] = true;
        this.isOn[this.LEDC1] = true;
        this.isOn[this.LEDD1] = true;
        this.isOn[this.LEDE1] = false;
        this.isOn[this.LEDF1] = true;
        this.isOn[this.LEDG1] = true;
        break;
    }
    switch (num2)
    {
      case 0:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = false;
        break;
      case 1:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 2:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = false;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 3:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = true;
        break;
      case 4:
        this.isOn[this.LEDA2] = false;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 5:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 6:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = false;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 7:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = false;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = false;
        this.isOn[this.LEDG2] = false;
        break;
      case 8:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = true;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
      case 9:
        this.isOn[this.LEDA2] = true;
        this.isOn[this.LEDB2] = true;
        this.isOn[this.LEDC2] = true;
        this.isOn[this.LEDD2] = true;
        this.isOn[this.LEDE2] = false;
        this.isOn[this.LEDF2] = true;
        this.isOn[this.LEDG2] = true;
        break;
    }
    int num3 = m % 100 / 10;
    int num4 = m % 10;
    switch (num3)
    {
      case 0:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = false;
        break;
      case 1:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 2:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = false;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 3:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = true;
        break;
      case 4:
        this.isOn[this.LEDA3] = false;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 5:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 6:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = false;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 7:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = false;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = false;
        this.isOn[this.LEDG3] = false;
        break;
      case 8:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = true;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
      case 9:
        this.isOn[this.LEDA3] = true;
        this.isOn[this.LEDB3] = true;
        this.isOn[this.LEDC3] = true;
        this.isOn[this.LEDD3] = true;
        this.isOn[this.LEDE3] = false;
        this.isOn[this.LEDF3] = true;
        this.isOn[this.LEDG3] = true;
        break;
    }
    switch (num4)
    {
      case 0:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = false;
        break;
      case 1:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 2:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = false;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = true;
        break;
      case 3:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = true;
        break;
      case 4:
        this.isOn[this.LEDA4] = false;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 5:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 6:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = false;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 7:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = false;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = false;
        this.isOn[this.LEDG4] = false;
        break;
      case 8:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = true;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
      case 9:
        this.isOn[this.LEDA4] = true;
        this.isOn[this.LEDB4] = true;
        this.isOn[this.LEDC4] = true;
        this.isOn[this.LEDD4] = true;
        this.isOn[this.LEDE4] = false;
        this.isOn[this.LEDF4] = true;
        this.isOn[this.LEDG4] = true;
        break;
    }
    int num5 = M % 100 / 10;
    int num6 = M % 10;
    switch (num5)
    {
      case 0:
        this.isOn[this.LEDB8] = false;
        this.isOn[this.LEDC8] = false;
        break;
      case 1:
        this.isOn[this.LEDB8] = true;
        this.isOn[this.LEDC8] = true;
        break;
    }
    switch (num6)
    {
      case 0:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = false;
        break;
      case 1:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = false;
        break;
      case 2:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = false;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = true;
        break;
      case 3:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = true;
        break;
      case 4:
        this.isOn[this.LEDA5] = false;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 5:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 6:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = false;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 7:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = false;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = false;
        this.isOn[this.LEDG5] = false;
        break;
      case 8:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = true;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
      case 9:
        this.isOn[this.LEDA5] = true;
        this.isOn[this.LEDB5] = true;
        this.isOn[this.LEDC5] = true;
        this.isOn[this.LEDD5] = true;
        this.isOn[this.LEDE5] = false;
        this.isOn[this.LEDF5] = true;
        this.isOn[this.LEDG5] = true;
        break;
    }
    int num7 = d % 100 / 10;
    int num8 = d % 10;
    switch (num7)
    {
      case 0:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = false;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 1:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 2:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = false;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = true;
        break;
      case 3:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = true;
        break;
      case 4:
        this.isOn[this.LEDA6] = false;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 5:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 6:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = false;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 7:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = false;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = false;
        this.isOn[this.LEDG6] = false;
        break;
      case 8:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = true;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
      case 9:
        this.isOn[this.LEDA6] = true;
        this.isOn[this.LEDB6] = true;
        this.isOn[this.LEDC6] = true;
        this.isOn[this.LEDD6] = true;
        this.isOn[this.LEDE6] = false;
        this.isOn[this.LEDF6] = true;
        this.isOn[this.LEDG6] = true;
        break;
    }
    switch (num8)
    {
      case 0:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = false;
        break;
      case 1:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
      case 2:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = false;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = true;
        break;
      case 3:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = true;
        break;
      case 4:
        this.isOn[this.LEDA7] = false;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 5:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 6:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = false;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 7:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = false;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = false;
        this.isOn[this.LEDG7] = false;
        break;
      case 8:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = true;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
      case 9:
        this.isOn[this.LEDA7] = true;
        this.isOn[this.LEDB7] = true;
        this.isOn[this.LEDC7] = true;
        this.isOn[this.LEDD7] = true;
        this.isOn[this.LEDE7] = false;
        this.isOn[this.LEDF7] = true;
        this.isOn[this.LEDG7] = true;
        break;
    }
    this.isOn[this.ZhuangShi1] = true;
    this.isOn[this.ZhuangShi2] = w > 0;
    this.isOn[this.ZhuangShi3] = w > 1;
    this.isOn[this.ZhuangShi4] = w > 2;
    this.isOn[this.ZhuangShi5] = w > 3;
    this.isOn[this.ZhuangShi6] = w > 4;
    if (w > 5)
      this.isOn[this.ZhuangShi7] = true;
    else
      this.isOn[this.ZhuangShi7] = false;
  }

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
    this.BackgroundImage = (Image) Resources.DLF13;
    this.BackgroundImageLayout = ImageLayout.None;
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCScreenLED);
    this.Size = new Size(460, 460);
    this.ResumeLayout(false);
  }
}

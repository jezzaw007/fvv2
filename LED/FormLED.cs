// Decompiled with JetBrains decompiler
// Type: TRCC.LED.FormLED
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TRCC.DCUserControl;
using TRCC.Properties;

#nullable disable
namespace TRCC.LED;

public class FormLED : Form
{
  private int rgbR1 = (int) byte.MaxValue;
  private int rgbG1 = 0;
  private int rgbB1 = 0;
  private byte myOnOff = 1;
  private byte myBrightness = 65;
  private int myLedMode = 4;
  private int myTempMode = 1;
  private bool isLunBo = false;
  private bool LunBo1 = true;
  private bool LunBo2 = false;
  private bool LunBo3 = false;
  private bool LunBo4 = false;
  private int nowLunbo = 0;
  public int myDeviceCount = 0;
  private string myName = "";
  public FormLED.delegateFormLED delegateForm;
  private const byte USB_PACKED_Head = 220;
  private const string fileSetting = "Data\\Digital\\Setting";
  private int InfoCount = 0;
  private int ValCount = 0;
  private bool isSaveTimer = false;
  private int nowJianbian = 0;
  private int nowJianbianTimer = 0;
  private int rgbTimer = 0;
  private int rgbTimer1 = 0;
  private int rgbTimer2 = 0;
  private const int RGB_ALL_VAL = 255 /*0xFF*/;
  private const int RGB_BREATHING_TIMER = 33;
  private const int RGB_COLORFUL_TIMER = 28;
  private const int MyColorVal = 255 /*0xFF*/;
  private const int RGBTableCount = 768 /*0x0300*/;
  private readonly byte[,] RGBTable = new byte[768 /*0x0300*/, 3]
  {
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 2,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 4,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 6,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 8,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 10,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 12,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 14,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 16 /*0x10*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 18,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 20,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 22,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 24,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 26,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 28,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 30,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 32 /*0x20*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 34,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 36,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 38,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 40,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 42,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 44,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 46,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 48 /*0x30*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 50,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 52,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 54,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 56,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 58,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 60,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 62,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 64 /*0x40*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 66,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 68,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 70,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 72,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 74,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 76,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 78,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 80 /*0x50*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 82,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 84,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 86,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 88,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 90,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 92,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 94,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 96 /*0x60*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 98,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 100,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 102,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 104,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 106,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 108,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 110,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 112 /*0x70*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 114,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 116,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 118,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 120,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 122,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 124,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 126,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 128 /*0x80*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 130,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 132,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 134,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 136,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 138,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 140,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 142,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 144 /*0x90*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 146,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 148,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 150,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 152,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 154,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 156,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 158,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 160 /*0xA0*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 162,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 164,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 166,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 168,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 170,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 172,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 174,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 176 /*0xB0*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 178,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 180,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 182,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 184,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 186,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 188,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 190,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 192 /*0xC0*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 194,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 196,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 198,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 200,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 202,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 204,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 206,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 208 /*0xD0*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 210,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 212,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 214,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 216,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 218,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 220,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 222,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 224 /*0xE0*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 226,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 228,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 230,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 232,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 234,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 236,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 238,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 240 /*0xF0*/,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 242,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 244,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 246,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 248,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 250,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 252,
      (byte) 0
    },
    {
      byte.MaxValue,
      (byte) 254,
      (byte) 0
    },
    {
      byte.MaxValue,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 253,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 251,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 249,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 247,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 245,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 243,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 241,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 239,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 237,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 235,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 233,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 231,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 229,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 227,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 225,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 223,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 221,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 219,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 217,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 215,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 213,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 211,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 209,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 207,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 205,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 203,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 201,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 199,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 197,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 195,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 193,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 191,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 189,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 187,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 185,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 183,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 181,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 179,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 177,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 175,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 173,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 171,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 169,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 167,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 165,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 163,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 161,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 159,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 157,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 155,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 153,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 151,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 149,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 147,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 145,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 143,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 141,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 139,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 137,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 135,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 133,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 131,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 129,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 127 /*0x7F*/,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 125,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 123,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 121,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 119,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 117,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 115,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 113,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 111,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 109,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 107,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 105,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 103,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 101,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 99,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 97,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 95,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 93,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 91,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 89,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 87,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 85,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 83,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 81,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 79,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 77,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 75,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 73,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 71,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 69,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 67,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 65,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 63 /*0x3F*/,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 61,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 59,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 57,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 55,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 53,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 51,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 49,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 47,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 45,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 43,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 41,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 39,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 37,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 35,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 33,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 31 /*0x1F*/,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 29,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 27,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 25,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 23,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 21,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 19,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 17,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 15,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 13,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 11,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 9,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 7,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 5,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 3,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 1,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 0
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 2
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 4
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 6
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 8
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 10
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 12
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 14
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 16 /*0x10*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 18
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 20
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 22
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 24
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 26
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 28
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 30
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 32 /*0x20*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 34
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 36
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 38
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 40
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 42
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 44
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 46
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 48 /*0x30*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 50
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 52
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 54
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 56
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 58
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 60
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 62
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 64 /*0x40*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 66
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 68
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 70
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 72
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 74
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 76
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 78
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 80 /*0x50*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 82
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 84
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 86
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 88
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 90
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 92
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 94
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 96 /*0x60*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 98
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 100
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 102
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 104
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 106
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 108
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 110
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 112 /*0x70*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 114
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 116
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 118
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 120
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 122
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 124
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 126
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 128 /*0x80*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 130
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 132
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 134
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 136
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 138
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 140
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 142
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 144 /*0x90*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 146
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 148
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 150
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 152
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 154
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 156
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 158
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 160 /*0xA0*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 162
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 164
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 166
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 168
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 170
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 172
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 174
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 176 /*0xB0*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 178
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 180
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 182
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 184
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 186
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 188
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 190
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 192 /*0xC0*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 194
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 196
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 198
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 200
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 202
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 204
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 206
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 208 /*0xD0*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 210
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 212
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 214
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 216
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 218
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 220
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 222
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 224 /*0xE0*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 226
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 228
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 230
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 232
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 234
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 236
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 238
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 240 /*0xF0*/
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 242
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 244
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 246
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 248
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 250
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 252
    },
    {
      (byte) 0,
      byte.MaxValue,
      (byte) 254
    },
    {
      (byte) 0,
      byte.MaxValue,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 253,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 251,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 249,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 247,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 245,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 243,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 241,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 239,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 237,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 235,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 233,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 231,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 229,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 227,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 225,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 223,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 221,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 219,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 217,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 215,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 213,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 211,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 209,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 207,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 205,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 203,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 201,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 199,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 197,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 195,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 193,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 191,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 189,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 187,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 185,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 183,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 181,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 179,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 177,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 175,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 173,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 171,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 169,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 167,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 165,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 163,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 161,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 159,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 157,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 155,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 153,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 151,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 149,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 147,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 145,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 143,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 141,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 139,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 137,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 135,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 133,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 131,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 129,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 127 /*0x7F*/,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 125,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 123,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 121,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 119,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 117,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 115,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 113,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 111,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 109,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 107,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 105,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 103,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 101,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 99,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 97,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 95,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 93,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 91,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 89,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 87,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 85,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 83,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 81,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 79,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 77,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 75,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 73,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 71,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 69,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 67,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 65,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 63 /*0x3F*/,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 61,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 59,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 57,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 55,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 53,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 51,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 49,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 47,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 45,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 43,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 41,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 39,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 37,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 35,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 33,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 31 /*0x1F*/,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 29,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 27,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 25,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 23,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 21,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 19,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 17,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 15,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 13,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 11,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 9,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 7,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 5,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 3,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 1,
      byte.MaxValue
    },
    {
      (byte) 0,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 2,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 4,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 6,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 8,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 10,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 12,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 14,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 16 /*0x10*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 18,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 20,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 22,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 24,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 26,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 28,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 30,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 32 /*0x20*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 34,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 36,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 38,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 40,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 42,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 44,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 46,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 48 /*0x30*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 50,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 52,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 54,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 56,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 58,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 60,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 62,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 64 /*0x40*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 66,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 68,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 70,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 72,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 74,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 76,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 78,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 80 /*0x50*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 82,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 84,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 86,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 88,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 90,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 92,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 94,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 96 /*0x60*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 98,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 100,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 102,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 104,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 106,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 108,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 110,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 112 /*0x70*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 114,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 116,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 118,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 120,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 122,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 124,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 126,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 128 /*0x80*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 130,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 132,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 134,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 136,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 138,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 140,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 142,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 144 /*0x90*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 146,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 148,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 150,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 152,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 154,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 156,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 158,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 160 /*0xA0*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 162,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 164,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 166,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 168,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 170,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 172,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 174,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 176 /*0xB0*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 178,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 180,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 182,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 184,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 186,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 188,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 190,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 192 /*0xC0*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 194,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 196,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 198,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 200,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 202,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 204,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 206,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 208 /*0xD0*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 210,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 212,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 214,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 216,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 218,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 220,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 222,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 224 /*0xE0*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 226,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 228,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 230,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 232,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 234,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 236,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 238,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 240 /*0xF0*/,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 242,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 244,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 246,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 248,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 250,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 252,
      (byte) 0,
      byte.MaxValue
    },
    {
      (byte) 254,
      (byte) 0,
      byte.MaxValue
    },
    {
      byte.MaxValue,
      (byte) 0,
      byte.MaxValue
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 253
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 251
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 249
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 247
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 245
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 243
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 241
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 239
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 237
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 235
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 233
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 231
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 229
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 227
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 225
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 223
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 221
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 219
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 217
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 215
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 213
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 211
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 209
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 207
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 205
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 203
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 201
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 199
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 197
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 195
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 193
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 191
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 189
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 187
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 185
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 183
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 181
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 179
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 177
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 175
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 173
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 171
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 169
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 167
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 165
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 163
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 161
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 159
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 157
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 155
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 153
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 151
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 149
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 147
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 145
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 143
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 141
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 139
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 137
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 135
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 133
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 131
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 129
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 127 /*0x7F*/
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 125
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 123
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 121
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 119
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 117
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 115
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 113
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 111
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 109
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 107
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 105
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 103
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 101
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 99
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 97
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 95
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 93
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 91
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 89
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 87
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 85
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 83
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 81
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 79
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 77
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 75
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 73
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 71
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 69
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 67
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 65
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 63 /*0x3F*/
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 61
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 59
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 57
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 55
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 53
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 51
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 49
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 47
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 45
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 43
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 41
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 39
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 37
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 35
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 33
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 31 /*0x1F*/
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 29
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 27
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 25
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 23
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 21
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 19
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 17
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 15
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 13
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 11
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 9
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 7
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 5
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 3
    },
    {
      byte.MaxValue,
      (byte) 0,
      (byte) 1
    }
  };
  private byte[,] ledVal = new byte[10, 3];
  private byte ledHuxi = byte.MaxValue;
  private byte[] ledQicai = new byte[3]
  {
    byte.MaxValue,
    (byte) 0,
    (byte) 0
  };
  private byte[] ledWendu = new byte[3]
  {
    byte.MaxValue,
    (byte) 0,
    (byte) 0
  };
  private byte[] ledFuzai = new byte[3]
  {
    byte.MaxValue,
    (byte) 0,
    (byte) 0
  };
  private byte[,] ledValCaihong = new byte[18, 3];
  private byte[,] ledVal4 = new byte[14, 3];
  private byte[,] ledVal5 = new byte[23, 3];
  private byte[,] ledVal6 = new byte[72, 3];
  private byte[,] ledValCaihong7 = new byte[12, 3];
  private byte[,] ledVal8 = new byte[13, 3];
  private byte[,] ledVal9 = new byte[31 /*0x1F*/, 3];
  private byte[,] ledVal10 = new byte[17, 3];
  private byte[,] ledValLF15 = new byte[72, 3];
  private byte[,] ledValLF13 = new byte[62, 3];
  private int nowNo = 1;
  private byte nowLedStyle = 1;
  private byte nowLedStyleSub = 0;
  private int myLedMode1 = 1;
  private int myLedMode2 = 1;
  private int myLedMode3 = 1;
  private int myLedMode4 = 1;
  private int rgbR1_1 = (int) byte.MaxValue;
  private int rgbG1_1 = 0;
  private int rgbB1_1 = 0;
  private byte myOnOff1 = 1;
  private byte myBrightness1 = 65;
  private int rgbR1_2 = (int) byte.MaxValue;
  private int rgbG1_2 = 0;
  private int rgbB1_2 = 0;
  private byte myOnOff2 = 1;
  private byte myBrightness2 = 65;
  private int rgbR1_3 = (int) byte.MaxValue;
  private int rgbG1_3 = 0;
  private int rgbB1_3 = 0;
  private byte myOnOff3 = 1;
  private byte myBrightness3 = 65;
  private int rgbR1_4 = (int) byte.MaxValue;
  private int rgbG1_4 = 0;
  private int rgbB1_4 = 0;
  private byte myOnOff4 = 1;
  private byte myBrightness4 = 65;
  private int testTimer = 0;
  private int testCount = 0;
  private int memoryRatio = 2;
  private int hardDiskCount = 1;
  private bool isTimer24 = true;
  private bool isWeekSun = true;
  private const int CPUMain = 0;
  private const int GPUMain = 1;
  private const int CPUTEMP = 1;
  private const int CPUClock = 3;
  private const int CPUUsage = 2;
  private const int GPUTEMP = 1;
  private const int GPUClock = 3;
  private const int GPUUsage = 2;
  private IContainer components = (IContainer) null;
  private UCScreenLED ucScreenLED1;
  private Button buttonC;
  private Button buttonF;
  private Button buttonDSHX;
  private Button buttonDSCL;
  private Button buttonQCJB;
  private Button buttonCHMS;
  private Button buttonWDLD;
  private Button buttonFZLD;
  private UCColorA ucColorA1;
  public Label labelB;
  public Label labelG;
  public Label labelR;
  private UCScrollA ucScrollAB;
  private UCScrollA ucScrollAG;
  private UCScrollA ucScrollAR;
  private Button buttonC8;
  private Button buttonC7;
  private Button buttonC6;
  private Button buttonC5;
  private Button buttonC4;
  private Button buttonC3;
  private Button buttonC2;
  private Button buttonC1;
  private UCScrollA ucScrollA;
  private Button buttonLB;
  private Button button4;
  private Button button1;
  private Button button2;
  private Button button3;
  private Button buttonPower;
  public TextBox textBoxTimer;
  private CheckBox checkBox1;
  private Button button5;
  private Button button6;
  public TextBox textBoxR;
  public TextBox textBoxG;
  public TextBox textBoxB;
  private Button buttonN1;
  private Button buttonN2;
  private Button buttonN3;
  private Button buttonN4;
  private UCInfoImage ucInfoImage1;
  private UCInfoImage ucInfoImage2;
  private UCInfoImage ucInfoImage3;
  private UCInfoImage ucInfoImage4;
  private UCInfoImage ucInfoImage5;
  private UCInfoImage ucInfoImage6;
  private UCLEDMemoryInfo ucledMemoryInfo1;
  private UCLEDHarddiskInfo ucledHarddiskInfo1;
  private Button buttonH24;
  private Button buttonH12;
  private Button buttonWeek7;
  private Button buttonWeek1;

  private void ClearButtonBouns()
  {
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonN1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonN2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonN3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonN4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC7.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC8.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonF.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonDSCL.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonDSHX.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonQCJB.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonCHMS.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonWDLD.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonFZLD.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonLB.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  private void InitControl()
  {
    this.ucScrollAG.SetUCScrollA(0);
    this.ucScrollAB.SetUCScrollA(0);
    this.ucScrollA.SetUCScrollA(165);
    this.ucColorA1.upDateUCColor = new UCColorA.delegate_UCColorA(this.ucColor1Delegate);
    this.ucColorA1.upDateUCColorOnoff = new UCColorA.delegate_UCColorOnoff(this.ucColor2Delegate);
    this.ucScrollAR.upDateUCScroll = new UCScrollA.delegate_UCScrollA(this.ucScrollRDelegate);
    this.ucScrollAG.upDateUCScroll = new UCScrollA.delegate_UCScrollA(this.ucScrollGDelegate);
    this.ucScrollAB.upDateUCScroll = new UCScrollA.delegate_UCScrollA(this.ucScrollBDelegate);
    this.ucScrollA.upDateUCScroll = new UCScrollA.delegate_UCScrollA(this.ucScrollWDelegate);
  }

  public FormLED()
  {
    this.InitializeComponent();
    this.ClearButtonBouns();
    this.InitControl();
    this.M1_M6_Init();
  }

  public void FormLEDLanguageSet()
  {
    int nowNo = this.nowNo;
    switch (nowNo)
    {
      case 1:
        switch (Form1.Language)
        {
          case 0:
            this.BackgroundImage = (Image) Resources.D0数码屏en;
            return;
          case 1:
            this.BackgroundImage = (Image) Resources.D0数码屏;
            return;
          case 2:
            this.BackgroundImage = (Image) Resources.D0数码屏tc;
            return;
          case 3:
            this.BackgroundImage = (Image) Resources.D0数码屏d;
            return;
          case 4:
            this.BackgroundImage = (Image) Resources.D0数码屏e;
            return;
          case 5:
            this.BackgroundImage = (Image) Resources.D0数码屏f;
            return;
          case 6:
            this.BackgroundImage = (Image) Resources.D0数码屏p;
            return;
          case 7:
            this.BackgroundImage = (Image) Resources.D0数码屏r;
            return;
          case 8:
            this.BackgroundImage = (Image) Resources.D0数码屏x;
            return;
          default:
            return;
        }
      case 2:
        switch (Form1.Language)
        {
          case 0:
            this.BackgroundImage = (Image) Resources.D0数码屏en;
            return;
          case 1:
            this.BackgroundImage = (Image) Resources.D0数码屏;
            return;
          case 2:
            this.BackgroundImage = (Image) Resources.D0数码屏tc;
            return;
          case 3:
            this.BackgroundImage = (Image) Resources.D0数码屏d;
            return;
          case 4:
            this.BackgroundImage = (Image) Resources.D0数码屏e;
            return;
          case 5:
            this.BackgroundImage = (Image) Resources.D0数码屏f;
            return;
          case 6:
            this.BackgroundImage = (Image) Resources.D0数码屏p;
            return;
          case 7:
            this.BackgroundImage = (Image) Resources.D0数码屏r;
            return;
          case 8:
            this.BackgroundImage = (Image) Resources.D0数码屏x;
            return;
          default:
            return;
        }
      case 3:
        switch (Form1.Language)
        {
          case 0:
            this.BackgroundImage = (Image) Resources.D0数码屏en;
            return;
          case 1:
            this.BackgroundImage = (Image) Resources.D0数码屏;
            return;
          case 2:
            this.BackgroundImage = (Image) Resources.D0数码屏tc;
            return;
          case 3:
            this.BackgroundImage = (Image) Resources.D0数码屏d;
            return;
          case 4:
            this.BackgroundImage = (Image) Resources.D0数码屏e;
            return;
          case 5:
            this.BackgroundImage = (Image) Resources.D0数码屏f;
            return;
          case 6:
            this.BackgroundImage = (Image) Resources.D0数码屏p;
            return;
          case 7:
            this.BackgroundImage = (Image) Resources.D0数码屏r;
            return;
          case 8:
            this.BackgroundImage = (Image) Resources.D0数码屏x;
            return;
          default:
            return;
        }
      default:
        if (nowNo >= 16 /*0x10*/ && nowNo < 32 /*0x20*/)
        {
          switch (Form1.Language)
          {
            case 0:
              this.BackgroundImage = (Image) Resources.D0数码屏4区域en;
              return;
            case 1:
              this.BackgroundImage = (Image) Resources.D0数码屏4区域;
              return;
            case 2:
              this.BackgroundImage = (Image) Resources.D0数码屏4区域tc;
              return;
            case 3:
              this.BackgroundImage = (Image) Resources.D0数码屏4区域d;
              return;
            case 4:
              this.BackgroundImage = (Image) Resources.D0数码屏4区域e;
              return;
            case 5:
              this.BackgroundImage = (Image) Resources.D0数码屏4区域f;
              return;
            case 6:
              this.BackgroundImage = (Image) Resources.D0数码屏4区域p;
              return;
            case 7:
              this.BackgroundImage = (Image) Resources.D0数码屏4区域r;
              return;
            case 8:
              this.BackgroundImage = (Image) Resources.D0数码屏4区域x;
              return;
            default:
              return;
          }
        }
        else
        {
          int num;
          switch (nowNo)
          {
            case 32 /*0x20*/:
              switch (Form1.Language)
              {
                case 0:
                  this.BackgroundImage = (Image) Resources.D0数码屏en;
                  return;
                case 1:
                  this.BackgroundImage = (Image) Resources.D0数码屏;
                  return;
                case 2:
                  this.BackgroundImage = (Image) Resources.D0数码屏tc;
                  return;
                case 3:
                  this.BackgroundImage = (Image) Resources.D0数码屏d;
                  return;
                case 4:
                  this.BackgroundImage = (Image) Resources.D0数码屏e;
                  return;
                case 5:
                  this.BackgroundImage = (Image) Resources.D0数码屏f;
                  return;
                case 6:
                  this.BackgroundImage = (Image) Resources.D0数码屏p;
                  return;
                case 7:
                  this.BackgroundImage = (Image) Resources.D0数码屏r;
                  return;
                case 8:
                  this.BackgroundImage = (Image) Resources.D0数码屏x;
                  return;
                default:
                  return;
              }
            case 48 /*0x30*/:
              num = 1;
              break;
            default:
              num = nowNo == 49 ? 1 : 0;
              break;
          }
          if (num != 0)
          {
            switch (Form1.Language)
            {
              case 0:
                this.BackgroundImage = (Image) Resources.D0LF8en;
                return;
              case 1:
                this.BackgroundImage = (Image) Resources.D0LF8;
                return;
              case 2:
                this.BackgroundImage = (Image) Resources.D0LF8tc;
                return;
              case 3:
                this.BackgroundImage = (Image) Resources.D0LF8d;
                return;
              case 4:
                this.BackgroundImage = (Image) Resources.D0LF8e;
                return;
              case 5:
                this.BackgroundImage = (Image) Resources.D0LF8f;
                return;
              case 6:
                this.BackgroundImage = (Image) Resources.D0LF8p;
                return;
              case 7:
                this.BackgroundImage = (Image) Resources.D0LF8r;
                return;
              case 8:
                this.BackgroundImage = (Image) Resources.D0LF8x;
                return;
              default:
                return;
            }
          }
          else
          {
            switch (nowNo)
            {
              case 80 /*0x50*/:
                switch (Form1.Language)
                {
                  case 0:
                    this.BackgroundImage = (Image) Resources.D0LF12en;
                    return;
                  case 1:
                    this.BackgroundImage = (Image) Resources.D0LF12;
                    return;
                  case 2:
                    this.BackgroundImage = (Image) Resources.D0LF12tc;
                    return;
                  case 3:
                    this.BackgroundImage = (Image) Resources.D0LF12d;
                    return;
                  case 4:
                    this.BackgroundImage = (Image) Resources.D0LF12e;
                    return;
                  case 5:
                    this.BackgroundImage = (Image) Resources.D0LF12f;
                    return;
                  case 6:
                    this.BackgroundImage = (Image) Resources.D0LF12p;
                    return;
                  case 7:
                    this.BackgroundImage = (Image) Resources.D0LF12r;
                    return;
                  case 8:
                    this.BackgroundImage = (Image) Resources.D0LF12x;
                    return;
                  default:
                    return;
                }
              case 96 /*0x60*/:
                switch (Form1.Language)
                {
                  case 0:
                    this.BackgroundImage = (Image) Resources.D0LF10en;
                    return;
                  case 1:
                    this.BackgroundImage = (Image) Resources.D0LF10;
                    return;
                  case 2:
                    this.BackgroundImage = (Image) Resources.D0LF10tc;
                    return;
                  case 3:
                    this.BackgroundImage = (Image) Resources.D0LF10d;
                    return;
                  case 4:
                    this.BackgroundImage = (Image) Resources.D0LF10e;
                    return;
                  case 5:
                    this.BackgroundImage = (Image) Resources.D0LF10f;
                    return;
                  case 6:
                    this.BackgroundImage = (Image) Resources.D0LF10p;
                    return;
                  case 7:
                    this.BackgroundImage = (Image) Resources.D0LF10r;
                    return;
                  case 8:
                    this.BackgroundImage = (Image) Resources.D0LF10x;
                    return;
                  default:
                    return;
                }
              case 112 /*0x70*/:
                switch (Form1.Language)
                {
                  case 0:
                    this.BackgroundImage = (Image) Resources.D0LC2en;
                    return;
                  case 1:
                    this.BackgroundImage = (Image) Resources.D0LC2;
                    return;
                  case 2:
                    this.BackgroundImage = (Image) Resources.D0LC2tc;
                    return;
                  case 3:
                    this.BackgroundImage = (Image) Resources.D0LC2d;
                    return;
                  case 4:
                    this.BackgroundImage = (Image) Resources.D0LC2e;
                    return;
                  case 5:
                    this.BackgroundImage = (Image) Resources.D0LC2f;
                    return;
                  case 6:
                    this.BackgroundImage = (Image) Resources.D0LC2p;
                    return;
                  case 7:
                    this.BackgroundImage = (Image) Resources.D0LC2r;
                    return;
                  case 8:
                    this.BackgroundImage = (Image) Resources.D0LC2x;
                    return;
                  default:
                    return;
                }
              case 128 /*0x80*/:
                switch (Form1.Language)
                {
                  case 0:
                    this.BackgroundImage = (Image) Resources.D0LC1en;
                    return;
                  case 1:
                    this.BackgroundImage = (Image) Resources.D0LC1;
                    return;
                  case 2:
                    this.BackgroundImage = (Image) Resources.D0LC1tc;
                    return;
                  case 3:
                    this.BackgroundImage = (Image) Resources.D0LC1d;
                    return;
                  case 4:
                    this.BackgroundImage = (Image) Resources.D0LC1e;
                    return;
                  case 5:
                    this.BackgroundImage = (Image) Resources.D0LC1f;
                    return;
                  case 6:
                    this.BackgroundImage = (Image) Resources.D0LC1p;
                    return;
                  case 7:
                    this.BackgroundImage = (Image) Resources.D0LC1r;
                    return;
                  case 8:
                    this.BackgroundImage = (Image) Resources.D0LC1x;
                    return;
                  default:
                    return;
                }
              case 129:
                switch (Form1.Language)
                {
                  case 0:
                    this.BackgroundImage = (Image) Resources.D0LF11en;
                    return;
                  case 1:
                    this.BackgroundImage = (Image) Resources.D0LF11;
                    return;
                  case 2:
                    this.BackgroundImage = (Image) Resources.D0LF11tc;
                    return;
                  case 3:
                    this.BackgroundImage = (Image) Resources.D0LF11d;
                    return;
                  case 4:
                    this.BackgroundImage = (Image) Resources.D0LF11e;
                    return;
                  case 5:
                    this.BackgroundImage = (Image) Resources.D0LF11f;
                    return;
                  case 6:
                    this.BackgroundImage = (Image) Resources.D0LF11p;
                    return;
                  case 7:
                    this.BackgroundImage = (Image) Resources.D0LF11r;
                    return;
                  case 8:
                    this.BackgroundImage = (Image) Resources.D0LF11x;
                    return;
                  default:
                    return;
                }
              case 144 /*0x90*/:
                switch (Form1.Language)
                {
                  case 0:
                    this.BackgroundImage = (Image) Resources.D0LF15en;
                    return;
                  case 1:
                    this.BackgroundImage = (Image) Resources.D0LF15;
                    return;
                  case 2:
                    this.BackgroundImage = (Image) Resources.D0LF15tc;
                    return;
                  case 3:
                    this.BackgroundImage = (Image) Resources.D0LF15d;
                    return;
                  case 4:
                    this.BackgroundImage = (Image) Resources.D0LF15e;
                    return;
                  case 5:
                    this.BackgroundImage = (Image) Resources.D0LF15f;
                    return;
                  case 6:
                    this.BackgroundImage = (Image) Resources.D0LF15p;
                    return;
                  case 7:
                    this.BackgroundImage = (Image) Resources.D0LF15r;
                    return;
                  case 8:
                    this.BackgroundImage = (Image) Resources.D0LF15x;
                    return;
                  default:
                    return;
                }
              case 160 /*0xA0*/:
                switch (Form1.Language)
                {
                  case 0:
                    this.BackgroundImage = (Image) Resources.D0LF13en;
                    return;
                  case 1:
                    this.BackgroundImage = (Image) Resources.D0LF13;
                    return;
                  case 2:
                    this.BackgroundImage = (Image) Resources.D0LF13tc;
                    return;
                  case 3:
                    this.BackgroundImage = (Image) Resources.D0LF13d;
                    return;
                  case 4:
                    this.BackgroundImage = (Image) Resources.D0LF13e;
                    return;
                  case 5:
                    this.BackgroundImage = (Image) Resources.D0LF13f;
                    return;
                  case 6:
                    this.BackgroundImage = (Image) Resources.D0LF13p;
                    return;
                  case 7:
                    this.BackgroundImage = (Image) Resources.D0LF13r;
                    return;
                  case 8:
                    this.BackgroundImage = (Image) Resources.D0LF13x;
                    return;
                  default:
                    return;
                }
              case 208 /*0xD0*/:
                switch (Form1.Language)
                {
                  case 0:
                    this.BackgroundImage = (Image) Resources.D0CZ1en;
                    break;
                  case 1:
                    this.BackgroundImage = (Image) Resources.D0CZ1;
                    break;
                  case 2:
                    this.BackgroundImage = (Image) Resources.D0CZ1tc;
                    break;
                  case 3:
                    this.BackgroundImage = (Image) Resources.D0CZ1d;
                    break;
                  case 4:
                    this.BackgroundImage = (Image) Resources.D0CZ1e;
                    break;
                  case 5:
                    this.BackgroundImage = (Image) Resources.D0CZ1f;
                    break;
                  case 6:
                    this.BackgroundImage = (Image) Resources.D0CZ1p;
                    break;
                  case 7:
                    this.BackgroundImage = (Image) Resources.D0CZ1r;
                    break;
                  case 8:
                    this.BackgroundImage = (Image) Resources.D0CZ1x;
                    break;
                }
                return;
              default:
                return;
            }
          }
        }
    }
  }

  public void FormLEDInit(int NO, int mode, int count, string name)
  {
    this.myDeviceCount = count;
    this.nowNo = NO;
    this.FormLEDLanguageSet();
    switch (NO)
    {
      case 1:
        this.ucScreenLED1.BackgroundImage = (Image) Resources.DFROZEN_HORIZON_PRO;
        this.ucScreenLED1.imageBk = (Image) Resources.DFROZEN_HORIZON_PRO;
        break;
      case 2:
        this.ucScreenLED1.BackgroundImage = (Image) Resources.DFROZEN_MAGIC_PRO;
        this.ucScreenLED1.imageBk = (Image) Resources.DFROZEN_MAGIC_PRO;
        break;
      case 3:
        this.ucScreenLED1.BackgroundImage = (Image) Resources.DAX120_DIGITAL;
        this.ucScreenLED1.imageBk = (Image) Resources.DAX120_DIGITAL;
        break;
      default:
        if (NO >= 16 /*0x10*/ && NO < 32 /*0x20*/)
        {
          this.ucScreenLED1.BackgroundImage = (Image) Resources.DPA120_DIGITAL;
          this.ucScreenLED1.imageBk = (Image) Resources.DPA120_DIGITAL;
          this.ucScreenLED1.ReSetUCScreenLED2();
          this.nowLedStyle = (byte) 2;
          this.textBoxTimer.Hide();
          break;
        }
        int num;
        switch (NO)
        {
          case 32 /*0x20*/:
            this.ucScreenLED1.BackgroundImage = (Image) Resources.DAK120_DIGITAL;
            this.ucScreenLED1.imageBk = (Image) Resources.DAK120_DIGITAL;
            this.ucScreenLED1.ReSetUCScreenLED3();
            this.nowLedStyle = (byte) 3;
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.button5.Top = this.button1.Top;
            this.button6.Top = this.button2.Top;
            this.button5.Show();
            this.button6.Show();
            goto label_21;
          case 48 /*0x30*/:
            num = 1;
            break;
          default:
            num = NO == 49 ? 1 : 0;
            break;
        }
        if (num != 0)
        {
          this.ucScreenLED1.BackgroundImage = (Image) Resources.DLF8;
          this.ucScreenLED1.imageBk = (Image) Resources.DLF8;
          this.ucScreenLED1.ReSetUCScreenLED5();
          this.nowLedStyle = (byte) 5;
          this.button1.Hide();
          this.button2.Hide();
          this.button3.Hide();
          this.button4.Hide();
          this.button5.Top = this.button1.Top;
          this.button6.Top = this.button2.Top;
          this.button5.Show();
          this.button6.Show();
          break;
        }
        switch (NO)
        {
          case 80 /*0x50*/:
            this.ucScreenLED1.BackgroundImage = (Image) Resources.DLF12;
            this.ucScreenLED1.imageBk = (Image) Resources.DLF12;
            this.ucScreenLED1.ReSetUCScreenLED6();
            this.nowLedStyle = (byte) 6;
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.button5.Top = this.button1.Top;
            this.button6.Top = this.button2.Top;
            this.button5.Show();
            this.button6.Show();
            break;
          case 96 /*0x60*/:
            this.ucScreenLED1.BackgroundImage = (Image) Resources.DLF10;
            this.ucScreenLED1.imageBk = (Image) Resources.DLF10;
            this.ucScreenLED1.ReSetUCScreenLED7();
            this.nowLedStyle = (byte) 7;
            this.textBoxTimer.Hide();
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.buttonN1.Top = this.button1.Top;
            this.buttonN2.Top = this.button2.Top;
            this.buttonN3.Top = this.button3.Top;
            this.buttonN1.Show();
            this.buttonN2.Show();
            this.buttonN3.Show();
            break;
          case 112 /*0x70*/:
            this.ucScreenLED1.BackgroundImage = (Image) Resources.DLC2;
            this.ucScreenLED1.imageBk = (Image) Resources.DLC2;
            this.ucScreenLED1.ReSetUCScreenLED9();
            this.nowLedStyle = (byte) 9;
            this.textBoxTimer.Hide();
            this.buttonLB.Hide();
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.buttonH24.Show();
            this.buttonH12.Show();
            this.buttonWeek1.Show();
            this.buttonWeek7.Show();
            break;
          case 128 /*0x80*/:
            this.ucScreenLED1.BackgroundImage = (Image) Resources.DLC1;
            this.ucScreenLED1.imageBk = (Image) Resources.DLC1;
            this.ucScreenLED1.ReSetUCScreenLED4();
            this.nowLedStyle = (byte) 4;
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.buttonN1.Top = this.button1.Top;
            this.buttonN2.Top = this.button2.Top;
            this.buttonN3.Top = this.button3.Top;
            this.buttonN1.Show();
            this.buttonN2.Show();
            this.buttonN3.Show();
            this.ucInfoImage1.Hide();
            this.ucInfoImage2.Hide();
            this.ucInfoImage3.Hide();
            this.ucInfoImage4.Hide();
            this.ucInfoImage5.Hide();
            this.ucInfoImage6.Hide();
            this.ucledMemoryInfo1.Show();
            this.ucledMemoryInfo1.ucComboBoxB1.ucComboBoxB = new UCComboBoxB.delegateUCComboBoxB(this.ucComboBoxB);
            break;
          case 129:
            this.nowLedStyleSub = (byte) 1;
            this.ucScreenLED1.BackgroundImage = (Image) Resources.DLF11;
            this.ucScreenLED1.imageBk = (Image) Resources.DLF11;
            this.ucScreenLED1.ReSetUCScreenLED10();
            this.nowLedStyle = (byte) 10;
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.buttonN1.Top = this.button1.Top;
            this.buttonN2.Top = this.button2.Top;
            this.buttonN3.Top = this.button3.Top;
            this.buttonN4.Top = this.button3.Top;
            this.buttonN1.Show();
            this.buttonN2.Show();
            this.buttonN3.Show();
            this.buttonN4.Show();
            this.ucInfoImage1.Hide();
            this.ucInfoImage2.Hide();
            this.ucInfoImage3.Hide();
            this.ucInfoImage4.Hide();
            this.ucInfoImage5.Hide();
            this.ucInfoImage6.Hide();
            this.ucledHarddiskInfo1.Show();
            this.ucledHarddiskInfo1.ucComboBoxC1.ucComboBoxC = new UCComboBoxC.delegateucComboBoxC(this.ucComboBoxC);
            break;
          case 144 /*0x90*/:
            this.ucScreenLED1.BackgroundImage = (Image) Resources.DLF15;
            this.ucScreenLED1.imageBk = (Image) Resources.DLF15;
            this.ucScreenLED1.ReSetUCScreenLEDLF15();
            this.nowLedStyle = (byte) 11;
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.button5.Top = this.button1.Top;
            this.button6.Top = this.button2.Top;
            this.button5.Show();
            this.button6.Show();
            break;
          case 160 /*0xA0*/:
            this.ucScreenLED1.BackgroundImage = (Image) Resources.DLF13;
            this.ucScreenLED1.imageBk = (Image) Resources.DLF13;
            this.ucScreenLED1.ReSetUCScreenLEDLF13();
            this.nowLedStyle = (byte) 12;
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.buttonLB.Hide();
            this.textBoxTimer.Hide();
            break;
          case 208 /*0xD0*/:
            this.ucScreenLED1.BackgroundImage = (Image) Resources.DCZ1;
            this.ucScreenLED1.imageBk = (Image) Resources.DCZ1;
            this.ucScreenLED1.ReSetUCScreenLED8();
            this.nowLedStyle = (byte) 8;
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.buttonN1.Top = this.button1.Top;
            this.buttonN2.Top = this.button2.Top;
            this.buttonN3.Top = this.button3.Top;
            this.buttonN4.Top = this.button4.Top;
            this.buttonN1.Show();
            this.buttonN2.Show();
            this.buttonN3.Show();
            this.buttonN4.Show();
            break;
        }
        break;
    }
label_21:
    this.myName = "Data\\Digital\\Setting" + name;
    FileStream input = new FileStream($"{Application.StartupPath}\\{this.myName}", FileMode.OpenOrCreate);
    BinaryReader binaryReader = new BinaryReader((Stream) input);
    try
    {
      if (binaryReader.ReadByte() == (byte) 220)
      {
        this.rgbR1 = binaryReader.ReadInt32();
        this.rgbG1 = binaryReader.ReadInt32();
        this.rgbB1 = binaryReader.ReadInt32();
        this.myOnOff = binaryReader.ReadByte();
        this.myBrightness = binaryReader.ReadByte();
        this.myLedMode = binaryReader.ReadInt32();
        this.myTempMode = binaryReader.ReadInt32();
        this.isLunBo = binaryReader.ReadBoolean();
        this.LunBo1 = binaryReader.ReadBoolean();
        this.LunBo2 = binaryReader.ReadBoolean();
        this.LunBo3 = binaryReader.ReadBoolean();
        this.LunBo4 = binaryReader.ReadBoolean();
        this.textBoxR.Text = this.labelR.Text = this.rgbR1.ToString();
        this.textBoxG.Text = this.labelG.Text = this.rgbG1.ToString();
        this.textBoxB.Text = this.labelB.Text = this.rgbB1.ToString();
        this.ucColorA1.SetButtonDSHX(this.myOnOff);
        this.ucScrollAR.SetUCScrollA(this.rgbR1);
        this.ucScrollAG.SetUCScrollA(this.rgbG1);
        this.ucScrollAB.SetUCScrollA(this.rgbB1);
        this.ucScrollA.SetUCScrollA((int) this.myBrightness * (int) byte.MaxValue / 100);
        this.ButtonDengGuang_Click(this.myLedMode);
        this.buttonCF_Click(this.myTempMode);
        this.ButtonLB_Set(this.isLunBo);
        this.buttonLB_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
        this.buttonLBN_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
        this.buttonLB_Click(this.LunBo1, this.LunBo2);
        this.myLedMode1 = binaryReader.ReadInt32();
        this.myLedMode2 = binaryReader.ReadInt32();
        this.myLedMode3 = binaryReader.ReadInt32();
        this.myLedMode4 = binaryReader.ReadInt32();
        this.rgbR1_1 = binaryReader.ReadInt32();
        this.rgbG1_1 = binaryReader.ReadInt32();
        this.rgbB1_1 = binaryReader.ReadInt32();
        this.myOnOff1 = binaryReader.ReadByte();
        this.myBrightness1 = binaryReader.ReadByte();
        this.rgbR1_2 = binaryReader.ReadInt32();
        this.rgbG1_2 = binaryReader.ReadInt32();
        this.rgbB1_2 = binaryReader.ReadInt32();
        this.myOnOff2 = binaryReader.ReadByte();
        this.myBrightness2 = binaryReader.ReadByte();
        this.rgbR1_3 = binaryReader.ReadInt32();
        this.rgbG1_3 = binaryReader.ReadInt32();
        this.rgbB1_3 = binaryReader.ReadInt32();
        this.myOnOff3 = binaryReader.ReadByte();
        this.myBrightness3 = binaryReader.ReadByte();
        this.rgbR1_4 = binaryReader.ReadInt32();
        this.rgbG1_4 = binaryReader.ReadInt32();
        this.rgbB1_4 = binaryReader.ReadInt32();
        this.myOnOff4 = binaryReader.ReadByte();
        this.myBrightness4 = binaryReader.ReadByte();
        this.textBoxTimer.Text = binaryReader.ReadString();
        this.memoryRatio = binaryReader.ReadInt32();
        switch (this.memoryRatio)
        {
          case 1:
          case 2:
            this.ucledMemoryInfo1.ucComboBoxB1.SetUCComboBoxMode(this.memoryRatio);
            break;
          case 4:
            this.ucledMemoryInfo1.ucComboBoxB1.SetUCComboBoxMode(3);
            break;
        }
        this.hardDiskCount = binaryReader.ReadInt32();
        this.ucledHarddiskInfo1.ucComboBoxC1.SetUCComboBoxMode(this.hardDiskCount);
        if (this.nowLedStyle == (byte) 6 || this.nowLedStyle == (byte) 8 || this.nowLedStyle == (byte) 12)
          this.ucScreenLED1.myLedMode = this.myLedMode;
        if (this.nowLedStyle == (byte) 7)
          this.ucScreenLED1.myLedMode = this.myLedMode3;
        if (this.nowLedStyle == (byte) 9)
        {
          try
          {
            this.isTimer24 = binaryReader.ReadBoolean();
            this.isWeekSun = binaryReader.ReadBoolean();
            this.ButtonH24orH12(this.isTimer24);
            this.ButtonWeek(this.isWeekSun);
          }
          catch
          {
          }
        }
      }
    }
    catch
    {
      if (this.nowLedStyle == (byte) 2 || this.nowLedStyle == (byte) 7)
        this.buttonLB_Click((object) null, (EventArgs) null);
    }
    this.isSaveTimer = true;
    binaryReader.Close();
    binaryReader.Dispose();
    input.Close();
    input.Dispose();
  }

  private void ucComboBoxB(int mode)
  {
    switch (mode)
    {
      case 1:
        this.memoryRatio = 1;
        break;
      case 2:
        this.memoryRatio = 2;
        break;
      case 3:
        this.memoryRatio = 4;
        break;
    }
    this.SetMyNameFile();
  }

  private void ucComboBoxC(int mode)
  {
    this.hardDiskCount = mode;
    this.SetMyNameFile();
  }

  private void SetMyNameFile()
  {
    FileStream output = new FileStream($"{Application.StartupPath}\\{this.myName}", FileMode.OpenOrCreate);
    BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
    binaryWriter.Write((byte) 220);
    binaryWriter.Write(this.rgbR1);
    binaryWriter.Write(this.rgbG1);
    binaryWriter.Write(this.rgbB1);
    binaryWriter.Write(this.myOnOff);
    binaryWriter.Write(this.myBrightness);
    binaryWriter.Write(this.myLedMode);
    binaryWriter.Write(this.myTempMode);
    binaryWriter.Write(this.isLunBo);
    binaryWriter.Write(this.LunBo1);
    binaryWriter.Write(this.LunBo2);
    binaryWriter.Write(this.LunBo3);
    binaryWriter.Write(this.LunBo4);
    binaryWriter.Write(this.myLedMode1);
    binaryWriter.Write(this.myLedMode2);
    binaryWriter.Write(this.myLedMode3);
    binaryWriter.Write(this.myLedMode4);
    binaryWriter.Write(this.rgbR1_1);
    binaryWriter.Write(this.rgbG1_1);
    binaryWriter.Write(this.rgbB1_1);
    binaryWriter.Write(this.myOnOff1);
    binaryWriter.Write(this.myBrightness1);
    binaryWriter.Write(this.rgbR1_2);
    binaryWriter.Write(this.rgbG1_2);
    binaryWriter.Write(this.rgbB1_2);
    binaryWriter.Write(this.myOnOff2);
    binaryWriter.Write(this.myBrightness2);
    binaryWriter.Write(this.rgbR1_3);
    binaryWriter.Write(this.rgbG1_3);
    binaryWriter.Write(this.rgbB1_3);
    binaryWriter.Write(this.myOnOff3);
    binaryWriter.Write(this.myBrightness3);
    binaryWriter.Write(this.rgbR1_4);
    binaryWriter.Write(this.rgbG1_4);
    binaryWriter.Write(this.rgbB1_4);
    binaryWriter.Write(this.myOnOff4);
    binaryWriter.Write(this.myBrightness4);
    binaryWriter.Write(this.textBoxTimer.Text);
    binaryWriter.Write(this.memoryRatio);
    binaryWriter.Write(this.hardDiskCount);
    if (this.nowLedStyle == (byte) 9)
    {
      binaryWriter.Write(this.isTimer24);
      binaryWriter.Write(this.isWeekSun);
    }
    binaryWriter.Flush();
    binaryWriter.Close();
    binaryWriter.Dispose();
    output.Close();
    output.Dispose();
  }

  private void ucColor1Delegate(int r, int b, int g)
  {
    this.rgbR1 = r;
    this.rgbG1 = g;
    this.rgbB1 = b;
    if (this.nowLedStyle == (byte) 2 || this.nowLedStyle == (byte) 7)
    {
      if (this.isLunBo)
      {
        this.rgbR1_1 = r;
        this.rgbG1_1 = g;
        this.rgbB1_1 = b;
        this.rgbR1_2 = r;
        this.rgbG1_2 = g;
        this.rgbB1_2 = b;
        this.rgbR1_3 = r;
        this.rgbG1_3 = g;
        this.rgbB1_3 = b;
        this.rgbR1_4 = r;
        this.rgbG1_4 = g;
        this.rgbB1_4 = b;
      }
      else
      {
        if (this.LunBo1)
        {
          this.rgbR1_1 = r;
          this.rgbG1_1 = g;
          this.rgbB1_1 = b;
        }
        if (this.LunBo2)
        {
          this.rgbR1_2 = r;
          this.rgbG1_2 = g;
          this.rgbB1_2 = b;
        }
        if (this.LunBo3)
        {
          this.rgbR1_3 = r;
          this.rgbG1_3 = g;
          this.rgbB1_3 = b;
        }
        if (this.LunBo4)
        {
          this.rgbR1_4 = r;
          this.rgbG1_4 = g;
          this.rgbB1_4 = b;
        }
      }
    }
    this.isSaveTimer = false;
    this.textBoxR.Text = this.labelR.Text = r.ToString();
    this.textBoxG.Text = this.labelG.Text = g.ToString();
    this.textBoxB.Text = this.labelB.Text = b.ToString();
    this.isSaveTimer = true;
    this.ucScrollAR.SetUCScrollA(r);
    this.ucScrollAG.SetUCScrollA(g);
    this.ucScrollAB.SetUCScrollA(b);
    this.SetMyNameFile();
  }

  private void ucColor2Delegate(byte onOff)
  {
    this.myOnOff = onOff;
    if (this.nowLedStyle == (byte) 2 || this.nowLedStyle == (byte) 7)
    {
      if (this.isLunBo)
      {
        this.myOnOff1 = this.myOnOff;
        this.myOnOff2 = this.myOnOff;
        this.myOnOff3 = this.myOnOff;
        this.myOnOff4 = this.myOnOff;
      }
      else
      {
        if (this.LunBo1)
          this.myOnOff1 = this.myOnOff;
        if (this.LunBo2)
          this.myOnOff2 = this.myOnOff;
        if (this.LunBo3)
          this.myOnOff3 = this.myOnOff;
        if (this.LunBo4)
          this.myOnOff4 = this.myOnOff;
      }
    }
    this.SetMyNameFile();
  }

  private void ucScrollRDelegate(int val)
  {
    this.rgbR1 = val;
    if (this.nowLedStyle == (byte) 2 || this.nowLedStyle == (byte) 7)
    {
      if (this.isLunBo)
      {
        this.rgbR1_1 = val;
        this.rgbR1_2 = val;
        this.rgbR1_3 = val;
        this.rgbR1_4 = val;
      }
      else
      {
        if (this.LunBo1)
          this.rgbR1_1 = val;
        if (this.LunBo2)
          this.rgbR1_2 = val;
        if (this.LunBo3)
          this.rgbR1_3 = val;
        if (this.LunBo4)
          this.rgbR1_4 = val;
      }
    }
    this.isSaveTimer = false;
    this.textBoxR.Text = this.labelR.Text = val.ToString();
    this.isSaveTimer = true;
    this.SetMyNameFile();
  }

  private void ucScrollGDelegate(int val)
  {
    this.rgbG1 = val;
    if (this.nowLedStyle == (byte) 2 || this.nowLedStyle == (byte) 7)
    {
      if (this.isLunBo)
      {
        this.rgbG1_1 = val;
        this.rgbG1_2 = val;
        this.rgbG1_3 = val;
        this.rgbG1_4 = val;
      }
      else
      {
        if (this.LunBo1)
          this.rgbG1_1 = val;
        if (this.LunBo2)
          this.rgbG1_2 = val;
        if (this.LunBo3)
          this.rgbG1_3 = val;
        if (this.LunBo4)
          this.rgbG1_4 = val;
      }
    }
    this.isSaveTimer = false;
    this.textBoxG.Text = this.labelG.Text = val.ToString();
    this.isSaveTimer = true;
    this.SetMyNameFile();
  }

  private void ucScrollBDelegate(int val)
  {
    this.rgbB1 = val;
    if (this.nowLedStyle == (byte) 2 || this.nowLedStyle == (byte) 7)
    {
      if (this.isLunBo)
      {
        this.rgbB1_1 = val;
        this.rgbB1_2 = val;
        this.rgbB1_3 = val;
        this.rgbB1_4 = val;
      }
      else
      {
        if (this.LunBo1)
          this.rgbB1_1 = val;
        if (this.LunBo2)
          this.rgbB1_2 = val;
        if (this.LunBo3)
          this.rgbB1_3 = val;
        if (this.LunBo4)
          this.rgbB1_4 = val;
      }
    }
    this.isSaveTimer = false;
    this.textBoxB.Text = this.labelB.Text = val.ToString();
    this.isSaveTimer = true;
    this.SetMyNameFile();
  }

  private void ucScrollWDelegate(int val)
  {
    this.myBrightness = (byte) (val * 100 / (int) byte.MaxValue);
    if (this.nowLedStyle == (byte) 2 || this.nowLedStyle == (byte) 7)
    {
      if (this.isLunBo)
      {
        this.myBrightness1 = this.myBrightness;
        this.myBrightness2 = this.myBrightness;
        this.myBrightness3 = this.myBrightness;
        this.myBrightness4 = this.myBrightness;
      }
      else
      {
        if (this.LunBo1)
          this.myBrightness1 = this.myBrightness;
        if (this.LunBo2)
          this.myBrightness2 = this.myBrightness;
        if (this.LunBo3)
          this.myBrightness3 = this.myBrightness;
        if (this.LunBo4)
          this.myBrightness4 = this.myBrightness;
      }
    }
    this.SetMyNameFile();
  }

  private void buttonC1_Click(object sender, EventArgs e)
  {
    this.ucColor1Delegate((int) byte.MaxValue, 42, 0);
  }

  private void buttonC2_Click(object sender, EventArgs e)
  {
    this.ucColor1Delegate((int) byte.MaxValue, 0, 110);
  }

  private void buttonC3_Click(object sender, EventArgs e)
  {
    this.ucColor1Delegate((int) byte.MaxValue, 0, (int) byte.MaxValue);
  }

  private void buttonC4_Click(object sender, EventArgs e)
  {
    this.ucColor1Delegate(0, 0, (int) byte.MaxValue);
  }

  private void buttonC5_Click(object sender, EventArgs e)
  {
    this.ucColor1Delegate(0, (int) byte.MaxValue, (int) byte.MaxValue);
  }

  private void buttonC6_Click(object sender, EventArgs e)
  {
    this.ucColor1Delegate(0, (int) byte.MaxValue, 91);
  }

  private void buttonC7_Click(object sender, EventArgs e)
  {
    this.ucColor1Delegate(214, (int) byte.MaxValue, 0);
  }

  private void buttonC8_Click(object sender, EventArgs e)
  {
    this.ucColor1Delegate((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
  }

  private void M1_M6_Init()
  {
    this.ucInfoImage2.bitmap = Resources.P环H2;
    this.ucInfoImage3.bitmap = Resources.P环H3;
    this.ucInfoImage4.bitmap = Resources.P环H4;
    this.ucInfoImage5.bitmap = Resources.P环H5;
    this.ucInfoImage6.bitmap = Resources.P环H6;
    this.ucInfoImage1.Mval = "CPU";
    this.ucInfoImage2.Mval = "CPU";
    this.ucInfoImage3.Mval = "CPU";
    this.ucInfoImage4.Mval = "GPU";
    this.ucInfoImage5.Mval = "GPU";
    this.ucInfoImage6.Mval = "GPU";
    try
    {
      this.ucInfoImage1.SetUCState(100);
    }
    catch
    {
      this.ucInfoImage1.SetUCState(100);
    }
    try
    {
      this.ucInfoImage2.SetUCState(100);
    }
    catch
    {
      this.ucInfoImage2.SetUCState(100);
    }
    try
    {
      this.ucInfoImage3.SetUCState(100);
    }
    catch
    {
      this.ucInfoImage3.SetUCState(100);
    }
    try
    {
      this.ucInfoImage4.SetUCState(100);
    }
    catch
    {
      this.ucInfoImage4.SetUCState(100);
    }
    try
    {
      this.ucInfoImage5.SetUCState(100);
    }
    catch
    {
      this.ucInfoImage5.SetUCState(100);
    }
    try
    {
      this.ucInfoImage6.SetUCState(100);
    }
    catch
    {
      this.ucInfoImage6.SetUCState(100);
    }
  }

  public void buttonCF_Click(int mode)
  {
    this.myTempMode = mode;
    this.buttonC.BackgroundImage = (Image) Resources.P点选框;
    this.buttonF.BackgroundImage = (Image) Resources.P点选框;
    switch (mode)
    {
      case 1:
        this.buttonC.BackgroundImage = (Image) Resources.P点选框A;
        break;
      case 2:
        this.buttonF.BackgroundImage = (Image) Resources.P点选框A;
        break;
    }
  }

  private void buttonC_Click(object sender, EventArgs e)
  {
    this.myTempMode = 1;
    this.buttonCF_Click(this.myTempMode);
    this.SetMyNameFile();
  }

  private void buttonF_Click(object sender, EventArgs e)
  {
    this.myTempMode = 2;
    this.buttonCF_Click(this.myTempMode);
    this.SetMyNameFile();
  }

  public void ButtonDengGuang_Click(int mode)
  {
    this.myLedMode = mode;
    if (this.nowLedStyle == (byte) 2 || this.nowLedStyle == (byte) 7)
    {
      if (this.isLunBo)
      {
        this.myLedMode1 = this.myLedMode;
        this.myLedMode2 = this.myLedMode;
        this.myLedMode3 = this.myLedMode;
        this.myLedMode4 = this.myLedMode;
      }
      else
      {
        if (this.LunBo1)
          this.myLedMode1 = this.myLedMode;
        if (this.LunBo2)
          this.myLedMode2 = this.myLedMode;
        if (this.LunBo3)
          this.myLedMode3 = this.myLedMode;
        if (this.LunBo4)
          this.myLedMode4 = this.myLedMode;
      }
    }
    if (this.nowLedStyle == (byte) 6 || this.nowLedStyle == (byte) 8 || this.nowLedStyle == (byte) 12)
      this.ucScreenLED1.myLedMode = mode;
    if (this.nowLedStyle == (byte) 7)
      this.ucScreenLED1.myLedMode = this.myLedMode3;
    this.buttonDSCL.BackgroundImage = (Image) Resources.D2灯光1;
    this.buttonDSHX.BackgroundImage = (Image) Resources.D2灯光2;
    this.buttonQCJB.BackgroundImage = (Image) Resources.D2灯光3;
    this.buttonCHMS.BackgroundImage = (Image) Resources.D2灯光4;
    this.buttonWDLD.BackgroundImage = (Image) Resources.D2灯光5;
    this.buttonFZLD.BackgroundImage = (Image) Resources.D2灯光6;
    switch (mode)
    {
      case 1:
        this.buttonDSCL.BackgroundImage = (Image) Resources.D2灯光1a;
        break;
      case 2:
        this.buttonDSHX.BackgroundImage = (Image) Resources.D2灯光2a;
        break;
      case 3:
        this.buttonQCJB.BackgroundImage = (Image) Resources.D2灯光3a;
        break;
      case 4:
        this.buttonCHMS.BackgroundImage = (Image) Resources.D2灯光4a;
        break;
      case 5:
        this.buttonWDLD.BackgroundImage = (Image) Resources.D2灯光5a;
        break;
      case 6:
        this.buttonFZLD.BackgroundImage = (Image) Resources.D2灯光6a;
        break;
    }
  }

  private void buttonDSCL_Click(object sender, EventArgs e)
  {
    this.myLedMode = 1;
    this.ButtonDengGuang_Click(this.myLedMode);
    this.SetMyNameFile();
  }

  private void buttonDSHX_Click(object sender, EventArgs e)
  {
    this.myLedMode = 2;
    this.ButtonDengGuang_Click(this.myLedMode);
    this.SetMyNameFile();
  }

  private void buttonQCJB_Click(object sender, EventArgs e)
  {
    this.myLedMode = 3;
    this.nowJianbian = 0;
    this.ButtonDengGuang_Click(this.myLedMode);
    this.SetMyNameFile();
  }

  private void buttonCHMS_Click(object sender, EventArgs e)
  {
    this.myLedMode = 4;
    this.ButtonDengGuang_Click(this.myLedMode);
    this.SetMyNameFile();
  }

  private void buttonWDLD_Click(object sender, EventArgs e)
  {
    this.myLedMode = 5;
    this.ButtonDengGuang_Click(this.myLedMode);
    this.SetMyNameFile();
  }

  private void buttonFZLD_Click(object sender, EventArgs e)
  {
    this.myLedMode = 6;
    this.ButtonDengGuang_Click(this.myLedMode);
    this.SetMyNameFile();
  }

  public void ButtonLB_Set(bool bl)
  {
    this.isLunBo = bl;
    if (bl)
      this.buttonLB.BackgroundImage = (Image) Resources.P点选框A;
    else
      this.buttonLB.BackgroundImage = (Image) Resources.P点选框;
  }

  private void buttonLB_Click(object sender, EventArgs e)
  {
    this.isLunBo = !this.isLunBo;
    this.ButtonLB_Set(this.isLunBo);
    if (this.nowLedStyle == (byte) 2)
    {
      if (this.isLunBo)
      {
        this.myLedMode1 = this.myLedMode;
        this.myLedMode2 = this.myLedMode;
        this.myLedMode3 = this.myLedMode;
        this.myLedMode4 = this.myLedMode;
      }
      this.buttonLB_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    }
    else if (this.nowLedStyle == (byte) 7)
    {
      if (this.isLunBo)
      {
        this.myLedMode1 = this.myLedMode;
        this.myLedMode2 = this.myLedMode;
        this.myLedMode3 = this.myLedMode;
        this.myLedMode4 = this.myLedMode;
      }
      this.buttonLBN_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    }
    else if (this.nowLedStyle == (byte) 3 || this.nowLedStyle == (byte) 5 || this.nowLedStyle == (byte) 6 || this.nowLedStyle == (byte) 11)
    {
      if (!this.isLunBo && (this.LunBo1 ? 1 : 0) + (this.LunBo2 ? 1 : 0) > 1)
      {
        if (this.LunBo1)
          this.LunBo2 = this.LunBo3 = this.LunBo4 = false;
        else if (this.LunBo2)
          this.LunBo3 = this.LunBo4 = false;
        else if (this.LunBo3)
          this.LunBo4 = false;
        this.buttonLB_Click(this.LunBo1, this.LunBo2);
      }
    }
    else if (this.nowLedStyle == (byte) 4 || this.nowLedStyle == (byte) 8 || this.nowLedStyle == (byte) 10)
    {
      if (!this.isLunBo && (this.LunBo1 ? 1 : 0) + (this.LunBo2 ? 1 : 0) + (this.LunBo3 ? 1 : 0) + (this.LunBo4 ? 1 : 0) > 1)
      {
        if (this.LunBo1)
          this.LunBo2 = this.LunBo3 = this.LunBo4 = false;
        else if (this.LunBo2)
          this.LunBo3 = this.LunBo4 = false;
        else if (this.LunBo3)
          this.LunBo4 = false;
        this.buttonLBN_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
      }
    }
    else if (!this.isLunBo && (this.LunBo1 ? 1 : 0) + (this.LunBo2 ? 1 : 0) + (this.LunBo3 ? 1 : 0) + (this.LunBo4 ? 1 : 0) > 1)
    {
      if (this.LunBo1)
        this.LunBo2 = this.LunBo3 = this.LunBo4 = false;
      else if (this.LunBo2)
        this.LunBo3 = this.LunBo4 = false;
      else if (this.LunBo3)
        this.LunBo4 = false;
      this.buttonLB_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    }
    if (sender == null)
      return;
    this.SetMyNameFile();
  }

  public void buttonLB_Click(bool bl1, bool bl2, bool bl3, bool bl4)
  {
    this.LunBo1 = bl1;
    this.LunBo2 = bl2;
    this.LunBo3 = bl3;
    this.LunBo4 = bl4;
    if (this.nowLedStyle == (byte) 2 && this.isLunBo)
    {
      this.button1.BackgroundImage = (Image) Resources.D4模式1a;
      this.button2.BackgroundImage = (Image) Resources.D4模式2a;
      this.button3.BackgroundImage = (Image) Resources.D4模式3a;
      this.button4.BackgroundImage = (Image) Resources.D4模式4a;
    }
    else
    {
      if (bl1)
        this.button1.BackgroundImage = (Image) Resources.D4模式1a;
      else
        this.button1.BackgroundImage = (Image) Resources.D4模式1;
      if (bl2)
        this.button2.BackgroundImage = (Image) Resources.D4模式2a;
      else
        this.button2.BackgroundImage = (Image) Resources.D4模式2;
      if (bl3)
        this.button3.BackgroundImage = (Image) Resources.D4模式3a;
      else
        this.button3.BackgroundImage = (Image) Resources.D4模式3;
      if (bl4)
        this.button4.BackgroundImage = (Image) Resources.D4模式4a;
      else
        this.button4.BackgroundImage = (Image) Resources.D4模式4;
    }
  }

  public void buttonLBN_Click(bool bl1, bool bl2, bool bl3, bool bl4)
  {
    this.LunBo1 = bl1;
    this.LunBo2 = bl2;
    this.LunBo3 = bl3;
    this.LunBo4 = bl4;
    if (this.nowLedStyle == (byte) 7 && this.isLunBo)
    {
      this.buttonN1.BackgroundImage = (Image) Resources.D4按钮1a;
      this.buttonN2.BackgroundImage = (Image) Resources.D4按钮2a;
      this.buttonN3.BackgroundImage = (Image) Resources.D4按钮3a;
      this.buttonN4.BackgroundImage = (Image) Resources.D4按钮4a;
    }
    else
    {
      if (bl1)
        this.buttonN1.BackgroundImage = (Image) Resources.D4按钮1a;
      else
        this.buttonN1.BackgroundImage = (Image) Resources.D4按钮1;
      if (bl2)
        this.buttonN2.BackgroundImage = (Image) Resources.D4按钮2a;
      else
        this.buttonN2.BackgroundImage = (Image) Resources.D4按钮2;
      if (bl3)
        this.buttonN3.BackgroundImage = (Image) Resources.D4按钮3a;
      else
        this.buttonN3.BackgroundImage = (Image) Resources.D4按钮3;
      if (bl4)
        this.buttonN4.BackgroundImage = (Image) Resources.D4按钮4a;
      else
        this.buttonN4.BackgroundImage = (Image) Resources.D4按钮4;
    }
  }

  public void buttonLB_Click(bool bl1, bool bl2)
  {
    this.LunBo1 = bl1;
    this.LunBo2 = bl2;
    if (bl1)
      this.button5.BackgroundImage = (Image) Resources.D4模式5a;
    else
      this.button5.BackgroundImage = (Image) Resources.D4模式5;
    if (bl2)
      this.button6.BackgroundImage = (Image) Resources.D4模式6a;
    else
      this.button6.BackgroundImage = (Image) Resources.D4模式6;
  }

  private void button1_Click(object sender, EventArgs e)
  {
    if (this.nowLedStyle == (byte) 2)
    {
      if (!this.LunBo1)
        this.LunBo1 = true;
      else if (this.LunBo2 || this.LunBo3 || this.LunBo4)
        this.LunBo1 = false;
    }
    else if (this.isLunBo)
    {
      if (!this.LunBo1)
        this.LunBo1 = true;
      else if (this.LunBo2 || this.LunBo3 || this.LunBo4)
        this.LunBo1 = false;
    }
    else
    {
      this.LunBo1 = true;
      this.LunBo2 = false;
      this.LunBo3 = false;
      this.LunBo4 = false;
    }
    this.buttonLB_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    this.SetMyNameFile();
  }

  private void button2_Click(object sender, EventArgs e)
  {
    if (this.nowLedStyle == (byte) 2)
    {
      if (!this.LunBo2)
        this.LunBo2 = true;
      else if (this.LunBo1 || this.LunBo3 || this.LunBo4)
        this.LunBo2 = false;
    }
    else if (this.isLunBo)
    {
      if (!this.LunBo2)
        this.LunBo2 = true;
      else if (this.LunBo1 || this.LunBo3 || this.LunBo4)
        this.LunBo2 = false;
    }
    else
    {
      this.LunBo2 = true;
      this.LunBo1 = false;
      this.LunBo3 = false;
      this.LunBo4 = false;
    }
    this.buttonLB_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    this.SetMyNameFile();
  }

  private void button3_Click(object sender, EventArgs e)
  {
    if (this.nowLedStyle == (byte) 2)
    {
      if (!this.LunBo3)
        this.LunBo3 = true;
      else if (this.LunBo1 || this.LunBo2 || this.LunBo4)
        this.LunBo3 = false;
    }
    else if (this.isLunBo)
    {
      if (!this.LunBo3)
        this.LunBo3 = true;
      else if (this.LunBo1 || this.LunBo2 || this.LunBo4)
        this.LunBo3 = false;
    }
    else
    {
      this.LunBo3 = true;
      this.LunBo1 = false;
      this.LunBo2 = false;
      this.LunBo4 = false;
    }
    this.buttonLB_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    this.SetMyNameFile();
  }

  private void button4_Click(object sender, EventArgs e)
  {
    if (this.nowLedStyle == (byte) 2)
    {
      if (!this.LunBo4)
        this.LunBo4 = true;
      else if (this.LunBo1 || this.LunBo2 || this.LunBo3)
        this.LunBo4 = false;
    }
    else if (this.isLunBo)
    {
      if (!this.LunBo4)
        this.LunBo4 = true;
      else if (this.LunBo1 || this.LunBo2 || this.LunBo3)
        this.LunBo4 = false;
    }
    else
    {
      this.LunBo4 = true;
      this.LunBo1 = false;
      this.LunBo2 = false;
      this.LunBo3 = false;
    }
    this.buttonLB_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    this.SetMyNameFile();
  }

  private void button5_Click(object sender, EventArgs e)
  {
    if (this.isLunBo)
    {
      if (!this.LunBo1)
        this.LunBo1 = true;
      else if (this.LunBo2)
        this.LunBo1 = false;
    }
    else
    {
      this.LunBo1 = true;
      this.LunBo2 = false;
    }
    this.buttonLB_Click(this.LunBo1, this.LunBo2);
    this.SetMyNameFile();
  }

  private void button6_Click(object sender, EventArgs e)
  {
    if (this.isLunBo)
    {
      if (!this.LunBo2)
        this.LunBo2 = true;
      else if (this.LunBo1)
        this.LunBo2 = false;
    }
    else
    {
      this.LunBo2 = true;
      this.LunBo1 = false;
    }
    this.buttonLB_Click(this.LunBo1, this.LunBo2);
    this.SetMyNameFile();
  }

  private void buttonN1_Click(object sender, EventArgs e)
  {
    if (this.nowLedStyle == (byte) 7)
    {
      if (!this.LunBo1)
        this.LunBo1 = true;
      else if (this.LunBo2 || this.LunBo3)
        this.LunBo1 = false;
    }
    else if (this.isLunBo)
    {
      if (!this.LunBo1)
        this.LunBo1 = true;
      else if (this.LunBo2 || this.LunBo3 || this.LunBo4)
        this.LunBo1 = false;
    }
    else
    {
      this.LunBo1 = true;
      this.LunBo2 = false;
      this.LunBo3 = false;
      this.LunBo4 = false;
    }
    this.buttonLBN_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    this.SetMyNameFile();
  }

  private void buttonN2_Click(object sender, EventArgs e)
  {
    if (this.nowLedStyle == (byte) 7)
    {
      if (!this.LunBo2)
        this.LunBo2 = true;
      else if (this.LunBo1 || this.LunBo3)
        this.LunBo2 = false;
    }
    else if (this.isLunBo)
    {
      if (!this.LunBo2)
        this.LunBo2 = true;
      else if (this.LunBo1 || this.LunBo3 || this.LunBo4)
        this.LunBo2 = false;
    }
    else
    {
      this.LunBo2 = true;
      this.LunBo1 = false;
      this.LunBo3 = false;
      this.LunBo4 = false;
    }
    this.buttonLBN_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    this.SetMyNameFile();
  }

  private void buttonN3_Click(object sender, EventArgs e)
  {
    if (this.nowLedStyle == (byte) 7)
    {
      if (!this.LunBo3)
        this.LunBo3 = true;
      else if (this.LunBo2 || this.LunBo1)
        this.LunBo3 = false;
    }
    else if (this.isLunBo)
    {
      if (!this.LunBo3)
        this.LunBo3 = true;
      else if (this.LunBo2 || this.LunBo1 || this.LunBo4)
        this.LunBo3 = false;
    }
    else
    {
      this.LunBo3 = true;
      this.LunBo2 = false;
      this.LunBo1 = false;
      this.LunBo4 = false;
    }
    this.buttonLBN_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    this.SetMyNameFile();
  }

  private void buttonN4_Click(object sender, EventArgs e)
  {
    if (this.isLunBo)
    {
      if (!this.LunBo4)
        this.LunBo4 = true;
      else if (this.LunBo2 || this.LunBo3 || this.LunBo1)
        this.LunBo4 = false;
    }
    else
    {
      this.LunBo4 = true;
      this.LunBo2 = false;
      this.LunBo3 = false;
      this.LunBo1 = false;
    }
    this.buttonLBN_Click(this.LunBo1, this.LunBo2, this.LunBo3, this.LunBo4);
    this.SetMyNameFile();
  }

  private void GetSystemInfo()
  {
    ++this.InfoCount;
    if (this.InfoCount < 6)
      return;
    this.InfoCount = 0;
    this.GetSystemInfoVal();
    if (this.nowLedStyle == (byte) 4 && this.nowLedStyleSub == (byte) 0)
    {
      if ((double) Form1.formSystemInfo.ucSystemInfo1.MemTemperature == 100000.0)
      {
        this.ucledMemoryInfo1.label1.Text = "NC";
      }
      else
      {
        float memTemperature = Form1.formSystemInfo.ucSystemInfo1.MemTemperature;
        if (this.ucInfoImage1.myTextMode == 1)
          this.ucledMemoryInfo1.label1.Text = memTemperature.ToString() + "℃";
        else
          this.ucledMemoryInfo1.label1.Text = ((float) ((double) memTemperature * 9.0 / 5.0 + 32.0)).ToString() + "℉";
      }
      float memClock = Form1.formSystemInfo.ucSystemInfo1.MemClock;
      this.ucledMemoryInfo1.label2_1.Text = memClock.ToString() + "MHz";
      this.ucledMemoryInfo1.label2.Text = (memClock * (float) this.memoryRatio).ToString() + "MT/S";
      this.ucledMemoryInfo1.label3.Text = (Form1.formSystemInfo.ucSystemInfo1.MemUsed / 1000f).ToString() + "GB";
      float num = Form1.formSystemInfo.ucSystemInfo1.MemRatio;
      this.ucledMemoryInfo1.label4.Text = num.ToString() + "X";
      num = Form1.formSystemInfo.ucSystemInfo1.MemTcas;
      this.ucledMemoryInfo1.label5.Text = num.ToString();
      num = Form1.formSystemInfo.ucSystemInfo1.MemTrcd;
      this.ucledMemoryInfo1.label6.Text = num.ToString();
      num = Form1.formSystemInfo.ucSystemInfo1.MemTrp;
      this.ucledMemoryInfo1.label7.Text = num.ToString();
      num = Form1.formSystemInfo.ucSystemInfo1.MemTras;
      this.ucledMemoryInfo1.label8.Text = num.ToString();
      num = Form1.formSystemInfo.ucSystemInfo1.MemTrc;
      this.ucledMemoryInfo1.label9.Text = num.ToString();
      num = Form1.formSystemInfo.ucSystemInfo1.MemTrfc;
      this.ucledMemoryInfo1.label10.Text = num.ToString();
    }
    else if (this.nowLedStyle == (byte) 10 && this.nowLedStyleSub == (byte) 1)
    {
      if (this.ucledHarddiskInfo1.ucComboBoxC1.myCount == 0)
      {
        string[] array = new string[8];
        this.ucledHarddiskInfo1.ucComboBoxC1.myCount = Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo.Count;
        for (int index = 0; index < Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo.Count; ++index)
        {
          string str = (string) ((ArrayList) Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo[index])[0];
          array[index] = str.Substring(0, str.IndexOf("(") - 1);
        }
        this.ucledHarddiskInfo1.ucComboBoxC1.SetBoxNameArray(array);
      }
      ArrayList arrayList = (ArrayList) Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo[this.hardDiskCount - 1];
      if ((int) arrayList[1] == 100000)
      {
        this.ucledHarddiskInfo1.label1.Text = "NC";
      }
      else
      {
        int num = (int) arrayList[1];
        if (this.ucInfoImage1.myTextMode == 1)
          this.ucledHarddiskInfo1.label1.Text = num.ToString() + "℃";
        else
          this.ucledHarddiskInfo1.label1.Text = (num * 9 / 5 + 32 /*0x20*/).ToString() + "℉";
      }
      this.ucledHarddiskInfo1.label2.Text = ((int) arrayList[2]).ToString() + "%";
      int num1 = (int) arrayList[3];
      this.ucledHarddiskInfo1.label3.Text = num1.ToString() + "MB/S";
      num1 = (int) arrayList[4];
      this.ucledHarddiskInfo1.label4.Text = num1.ToString() + "MB/S";
    }
  }

  private void GetSystemInfoVal()
  {
    string val = "";
    try
    {
      Form1.ucSystemInfoOptions1.GetSystemInfoVal(0, 1, ref val);
      if (val.Length > 0)
      {
        string str1 = "";
        if (val.Contains("℃"))
        {
          str1 = val.Replace("℃", "");
          this.ucInfoImage1.SetTextMode(1);
          this.myTempMode = 1;
        }
        else if (val.Contains("RPM"))
        {
          str1 = val.Replace("RPM", "");
          this.ucInfoImage1.SetTextMode(2);
        }
        else if (val.Contains("℉"))
        {
          str1 = val.Replace("℉", "");
          this.ucInfoImage1.SetTextMode(17);
          this.myTempMode = 2;
        }
        else if (val.Contains("MHz"))
        {
          str1 = val.Replace("MHz", "");
          this.ucInfoImage1.SetTextMode(2);
        }
        else if (val.Contains("%"))
        {
          str1 = val.Replace("%", "");
          this.ucInfoImage1.SetTextMode(1);
        }
        this.ucInfoImage1.SetUCState(Convert.ToInt32(str1), str1, this.ucInfoImage1.Mval, val);
      }
    }
    catch
    {
    }
    try
    {
      Form1.ucSystemInfoOptions1.GetSystemInfoVal(0, 3, ref val);
      if (val.Length > 0)
      {
        string str1 = "";
        if (val.Contains("℃"))
        {
          str1 = val.Replace("℃", "");
          this.ucInfoImage2.SetTextMode(1);
        }
        else if (val.Contains("RPM"))
        {
          str1 = val.Replace("RPM", "");
          this.ucInfoImage2.SetTextMode(2);
        }
        else if (val.Contains("℉"))
        {
          str1 = val.Replace("℉", "");
          this.ucInfoImage2.SetTextMode(17);
        }
        else if (val.Contains("MHz"))
        {
          str1 = val.Replace("MHz", "");
          this.ucInfoImage2.SetTextMode(2);
        }
        else if (val.Contains("%"))
        {
          str1 = val.Replace("%", "");
          this.ucInfoImage2.SetTextMode(1);
        }
        this.ucInfoImage2.SetUCState(Convert.ToInt32(str1), str1, this.ucInfoImage2.Mval, val);
      }
    }
    catch
    {
    }
    try
    {
      Form1.ucSystemInfoOptions1.GetSystemInfoVal(0, 2, ref val);
      if (val.Length > 0)
      {
        string str1 = "";
        if (val.Contains("℃"))
        {
          str1 = val.Replace("℃", "");
          this.ucInfoImage3.SetTextMode(1);
        }
        else if (val.Contains("RPM"))
        {
          str1 = val.Replace("RPM", "");
          this.ucInfoImage3.SetTextMode(2);
        }
        else if (val.Contains("℉"))
        {
          str1 = val.Replace("℉", "");
          this.ucInfoImage3.SetTextMode(17);
        }
        else if (val.Contains("MHz"))
        {
          str1 = val.Replace("MHz", "");
          this.ucInfoImage3.SetTextMode(2);
        }
        else if (val.Contains("%"))
        {
          str1 = val.Replace("%", "");
          this.ucInfoImage3.SetTextMode(1);
        }
        this.ucInfoImage3.SetUCState(Convert.ToInt32(str1), str1, this.ucInfoImage3.Mval, val);
      }
    }
    catch
    {
    }
    try
    {
      Form1.ucSystemInfoOptions1.GetSystemInfoVal(1, 1, ref val);
      if (val.Length > 0)
      {
        string str1 = "";
        if (val.Contains("℃"))
        {
          str1 = val.Replace("℃", "");
          this.ucInfoImage4.SetTextMode(1);
        }
        else if (val.Contains("RPM"))
        {
          str1 = val.Replace("RPM", "");
          this.ucInfoImage4.SetTextMode(2);
        }
        else if (val.Contains("℉"))
        {
          str1 = val.Replace("℉", "");
          this.ucInfoImage4.SetTextMode(17);
        }
        else if (val.Contains("MHz"))
        {
          str1 = val.Replace("MHz", "");
          this.ucInfoImage4.SetTextMode(2);
        }
        else if (val.Contains("%"))
        {
          str1 = val.Replace("%", "");
          this.ucInfoImage4.SetTextMode(1);
        }
        this.ucInfoImage4.SetUCState(Convert.ToInt32(str1), str1, this.ucInfoImage4.Mval, val);
      }
    }
    catch
    {
    }
    try
    {
      Form1.ucSystemInfoOptions1.GetSystemInfoVal(1, 3, ref val);
      if (val.Length > 0)
      {
        string str1 = "";
        if (val.Contains("℃"))
        {
          str1 = val.Replace("℃", "");
          this.ucInfoImage5.SetTextMode(1);
        }
        else if (val.Contains("RPM"))
        {
          str1 = val.Replace("RPM", "");
          this.ucInfoImage5.SetTextMode(2);
        }
        else if (val.Contains("℉"))
        {
          str1 = val.Replace("℉", "");
          this.ucInfoImage5.SetTextMode(17);
        }
        else if (val.Contains("MHz"))
        {
          str1 = val.Replace("MHz", "");
          this.ucInfoImage5.SetTextMode(2);
        }
        else if (val.Contains("%"))
        {
          str1 = val.Replace("%", "");
          this.ucInfoImage5.SetTextMode(1);
        }
        this.ucInfoImage5.SetUCState(Convert.ToInt32(str1), str1, this.ucInfoImage5.Mval, val);
      }
    }
    catch
    {
    }
    try
    {
      Form1.ucSystemInfoOptions1.GetSystemInfoVal(1, 2, ref val);
      if (val.Length <= 0)
        return;
      string str1 = "";
      if (val.Contains("℃"))
      {
        str1 = val.Replace("℃", "");
        this.ucInfoImage6.SetTextMode(1);
      }
      else if (val.Contains("RPM"))
      {
        str1 = val.Replace("RPM", "");
        this.ucInfoImage6.SetTextMode(2);
      }
      else if (val.Contains("℉"))
      {
        str1 = val.Replace("℉", "");
        this.ucInfoImage6.SetTextMode(17);
      }
      else if (val.Contains("MHz"))
      {
        str1 = val.Replace("MHz", "");
        this.ucInfoImage6.SetTextMode(2);
      }
      else if (val.Contains("%"))
      {
        str1 = val.Replace("%", "");
        this.ucInfoImage6.SetTextMode(1);
      }
      this.ucInfoImage6.SetUCState(Convert.ToInt32(str1), str1, this.ucInfoImage6.Mval, val);
    }
    catch
    {
    }
  }

  private void GetVal()
  {
    if (this.ucInfoImage1.val1.Length == 0)
      this.ucInfoImage1.val1 = "10000";
    if (this.ucInfoImage2.val1.Length == 0)
      this.ucInfoImage2.val1 = "10000";
    if (this.ucInfoImage3.val1.Length == 0)
      this.ucInfoImage3.val1 = "10000";
    if (this.ucInfoImage4.val1.Length == 0)
      this.ucInfoImage4.val1 = "10000";
    if (this.ucInfoImage5.val1.Length == 0)
      this.ucInfoImage5.val1 = "10000";
    if (this.ucInfoImage6.val1.Length == 0)
      this.ucInfoImage6.val1 = "10000";
    if (this.nowLedStyle == (byte) 2)
    {
      this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = true;
      this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2] = true;
      this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = true;
      this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2] = true;
      this.ucScreenLED1.isOn[this.ucScreenLED1.BFB] = true;
      this.ucScreenLED1.isOn[this.ucScreenLED1.BFB1] = true;
      if (this.myTempMode == 1)
      {
        this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.SSD1] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.HSD1] = false;
      }
      else
      {
        this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.SSD1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.HSD1] = true;
      }
      this.ucScreenLED1.SetMyNumeral(Convert.ToInt32(this.ucInfoImage1.val1), Convert.ToInt32(this.ucInfoImage3.val1), Convert.ToInt32(this.ucInfoImage4.val1), Convert.ToInt32(this.ucInfoImage6.val1));
    }
    else if (this.nowLedStyle == (byte) 3)
    {
      this.ucScreenLED1.isOn[this.ucScreenLED1.WATT] = true;
      this.ucScreenLED1.isOn[this.ucScreenLED1.BFB] = true;
      if (this.isLunBo)
      {
        ++this.ValCount;
        if (this.ValCount >= 6 * Convert.ToInt32(this.textBoxTimer.Text))
        {
          this.ValCount = 0;
          ArrayList arrayList = new ArrayList();
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          for (int index = this.nowLunbo + 1; index < arrayList.Count; ++index)
          {
            if ((bool) arrayList[index])
            {
              this.nowLunbo = index % 2;
              break;
            }
          }
        }
        switch (this.nowLunbo)
        {
          case 0:
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = true;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
            if (this.ucInfoImage1.myTextMode == 1)
            {
              this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
              this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
            }
            else
            {
              this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
              this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
            }
            this.ucScreenLED1.SetMyNumeral((int) Form1.formSystemInfo.ucSystemInfo1.CpuPower, Convert.ToInt32(this.ucInfoImage1.val1), Convert.ToInt32(this.ucInfoImage3.val1));
            break;
          case 1:
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = true;
            if (this.ucInfoImage1.myTextMode == 1)
            {
              this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
              this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
            }
            else
            {
              this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
              this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
            }
            this.ucScreenLED1.SetMyNumeral((int) Form1.formSystemInfo.ucSystemInfo1.GpuPower, Convert.ToInt32(this.ucInfoImage4.val1), Convert.ToInt32(this.ucInfoImage6.val1));
            break;
        }
      }
      else if (this.LunBo1)
      {
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
        if (this.ucInfoImage1.myTextMode == 1)
        {
          this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
          this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
        }
        else
        {
          this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
          this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
        }
        this.ucScreenLED1.SetMyNumeral((int) Form1.formSystemInfo.ucSystemInfo1.CpuPower, Convert.ToInt32(this.ucInfoImage1.val1), Convert.ToInt32(this.ucInfoImage3.val1));
      }
      else if (this.LunBo2)
      {
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = true;
        if (this.ucInfoImage1.myTextMode == 1)
        {
          this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
          this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
        }
        else
        {
          this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
          this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
        }
        this.ucScreenLED1.SetMyNumeral((int) Form1.formSystemInfo.ucSystemInfo1.GpuPower, Convert.ToInt32(this.ucInfoImage4.val1), Convert.ToInt32(this.ucInfoImage6.val1));
      }
    }
    else if (this.nowLedStyle == (byte) 4 && this.nowLedStyleSub == (byte) 0)
    {
      if (this.isLunBo)
      {
        ++this.ValCount;
        if (this.ValCount >= 6 * Convert.ToInt32(this.textBoxTimer.Text))
        {
          this.ValCount = 0;
          ArrayList arrayList = new ArrayList();
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo3);
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo3);
          for (int index = this.nowLunbo + 1; index < arrayList.Count; ++index)
          {
            if ((bool) arrayList[index])
            {
              this.nowLunbo = index % 3;
              break;
            }
          }
        }
        switch (this.nowLunbo)
        {
          case 0:
            if (this.ucInfoImage1.myTextMode == 1)
            {
              this.ucScreenLED1.SetMyNumeral(0, (int) Form1.formSystemInfo.ucSystemInfo1.MemTemperature);
              break;
            }
            this.ucScreenLED1.SetMyNumeral(-1, (int) Form1.formSystemInfo.ucSystemInfo1.MemTemperature * 9 / 5 + 32 /*0x20*/);
            break;
          case 1:
            this.ucScreenLED1.SetMyNumeral(1, (int) Form1.formSystemInfo.ucSystemInfo1.MemClock * this.memoryRatio);
            break;
          case 2:
            this.ucScreenLED1.SetMyNumeral(2, (int) ((double) Form1.formSystemInfo.ucSystemInfo1.MemUsed / 1000.0));
            break;
        }
      }
      else if (this.LunBo1)
      {
        if (this.ucInfoImage1.myTextMode == 1)
          this.ucScreenLED1.SetMyNumeral(0, (int) Form1.formSystemInfo.ucSystemInfo1.MemTemperature);
        else
          this.ucScreenLED1.SetMyNumeral(-1, (int) Form1.formSystemInfo.ucSystemInfo1.MemTemperature * 9 / 5 + 32 /*0x20*/);
      }
      else if (this.LunBo2)
        this.ucScreenLED1.SetMyNumeral(1, (int) Form1.formSystemInfo.ucSystemInfo1.MemClock * this.memoryRatio);
      else if (this.LunBo3)
        this.ucScreenLED1.SetMyNumeral(2, (int) ((double) Form1.formSystemInfo.ucSystemInfo1.MemUsed / 1000.0));
    }
    else if (this.nowLedStyle == (byte) 10 && this.nowLedStyleSub == (byte) 1)
    {
      if (this.isLunBo)
      {
        ++this.ValCount;
        if (this.ValCount >= 6 * Convert.ToInt32(this.textBoxTimer.Text))
        {
          this.ValCount = 0;
          ArrayList arrayList = new ArrayList();
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo3);
          arrayList.Add((object) this.LunBo4);
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo3);
          arrayList.Add((object) this.LunBo4);
          for (int index = this.nowLunbo + 1; index < arrayList.Count; ++index)
          {
            if ((bool) arrayList[index])
            {
              this.nowLunbo = index % 4;
              break;
            }
          }
        }
        ArrayList arrayList1 = (ArrayList) Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo[this.hardDiskCount - 1];
        switch (this.nowLunbo)
        {
          case 0:
            if (this.ucInfoImage1.myTextMode == 1)
            {
              this.ucScreenLED1.SetMyNumeralHardDisk(0, (int) arrayList1[1]);
              break;
            }
            this.ucScreenLED1.SetMyNumeralHardDisk(-1, (int) arrayList1[1] * 9 / 5 + 32 /*0x20*/);
            break;
          case 1:
            this.ucScreenLED1.SetMyNumeralHardDisk(1, (int) arrayList1[2]);
            break;
          case 2:
            this.ucScreenLED1.SetMyNumeralHardDisk(2, (int) arrayList1[3]);
            break;
          case 3:
            this.ucScreenLED1.SetMyNumeralHardDisk(2, (int) arrayList1[4]);
            break;
        }
      }
      else
      {
        ArrayList arrayList = (ArrayList) Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo[this.hardDiskCount - 1];
        if (this.LunBo1)
        {
          if (this.ucInfoImage1.myTextMode == 1)
            this.ucScreenLED1.SetMyNumeralHardDisk(0, (int) arrayList[1]);
          else
            this.ucScreenLED1.SetMyNumeralHardDisk(-1, (int) arrayList[1] * 9 / 5 + 32 /*0x20*/);
        }
        else if (this.LunBo2)
          this.ucScreenLED1.SetMyNumeralHardDisk(1, (int) arrayList[2]);
        else if (this.LunBo3)
          this.ucScreenLED1.SetMyNumeralHardDisk(2, (int) arrayList[3]);
        else if (this.LunBo4)
          this.ucScreenLED1.SetMyNumeralHardDisk(2, (int) arrayList[4]);
      }
    }
    else if (this.nowLedStyle == (byte) 5 || this.nowLedStyle == (byte) 6 || this.nowLedStyle == (byte) 11)
    {
      this.ucScreenLED1.isOn[this.ucScreenLED1.WATT] = true;
      this.ucScreenLED1.isOn[this.ucScreenLED1.MHz] = true;
      this.ucScreenLED1.isOn[this.ucScreenLED1.BFB] = true;
      if (this.isLunBo)
      {
        ++this.ValCount;
        if (this.ValCount >= 6 * Convert.ToInt32(this.textBoxTimer.Text))
        {
          this.ValCount = 0;
          ArrayList arrayList = new ArrayList();
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          for (int index = this.nowLunbo + 1; index < arrayList.Count; ++index)
          {
            if ((bool) arrayList[index])
            {
              this.nowLunbo = index % 2;
              break;
            }
          }
        }
        switch (this.nowLunbo)
        {
          case 0:
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = true;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
            if (this.ucInfoImage1.myTextMode == 1)
            {
              this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
              this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
            }
            else
            {
              this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
              this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
            }
            this.ucScreenLED1.SetMyNumeral(Convert.ToInt32(this.ucInfoImage1.val1), (int) Form1.formSystemInfo.ucSystemInfo1.CpuPower, Convert.ToInt32(this.ucInfoImage2.val1), Convert.ToByte(this.ucInfoImage3.val1));
            break;
          case 1:
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = true;
            if (this.ucInfoImage1.myTextMode == 1)
            {
              this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
              this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
            }
            else
            {
              this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
              this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
            }
            this.ucScreenLED1.SetMyNumeral(Convert.ToInt32(this.ucInfoImage4.val1), (int) Form1.formSystemInfo.ucSystemInfo1.GpuPower, Convert.ToInt32(this.ucInfoImage5.val1), Convert.ToByte(this.ucInfoImage6.val1));
            break;
        }
      }
      else if (this.LunBo1)
      {
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
        if (this.ucInfoImage1.myTextMode == 1)
        {
          this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
          this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
        }
        else
        {
          this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
          this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
        }
        this.ucScreenLED1.SetMyNumeral(Convert.ToInt32(this.ucInfoImage1.val1), (int) Form1.formSystemInfo.ucSystemInfo1.CpuPower, Convert.ToInt32(this.ucInfoImage2.val1), Convert.ToByte(this.ucInfoImage3.val1));
      }
      else if (this.LunBo2)
      {
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = true;
        if (this.ucInfoImage1.myTextMode == 1)
        {
          this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
          this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
        }
        else
        {
          this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
          this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
        }
        this.ucScreenLED1.SetMyNumeral(Convert.ToInt32(this.ucInfoImage4.val1), (int) Form1.formSystemInfo.ucSystemInfo1.GpuPower, Convert.ToInt32(this.ucInfoImage5.val1), Convert.ToByte(this.ucInfoImage6.val1));
      }
    }
    else if (this.nowLedStyle == (byte) 7)
    {
      this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = true;
      this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = true;
      if (this.myTempMode == 1)
      {
        this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.SSD1] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.HSD1] = false;
      }
      else
      {
        this.ucScreenLED1.isOn[this.ucScreenLED1.SSD] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.SSD1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.HSD] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.HSD1] = true;
      }
      this.ucScreenLED1.SetMyNumeralNew(Convert.ToInt32(this.ucInfoImage1.val1), Convert.ToInt32(this.ucInfoImage4.val1));
    }
    else if (this.nowLedStyle == (byte) 8)
    {
      if (this.isLunBo)
      {
        ++this.ValCount;
        if (this.ValCount >= 6 * Convert.ToInt32(this.textBoxTimer.Text))
        {
          this.ValCount = 0;
          ArrayList arrayList = new ArrayList();
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo3);
          arrayList.Add((object) this.LunBo4);
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo3);
          arrayList.Add((object) this.LunBo4);
          for (int index = this.nowLunbo + 1; index < arrayList.Count; ++index)
          {
            if ((bool) arrayList[index])
            {
              this.nowLunbo = index % 4;
              break;
            }
          }
        }
        switch (this.nowLunbo)
        {
          case 0:
            int int32_1 = Convert.ToInt32(this.ucInfoImage1.val1);
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = true;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2] = false;
            this.ucScreenLED1.SetMyNumeralNew(int32_1);
            break;
          case 1:
            int int32_2 = Convert.ToInt32(this.ucInfoImage3.val1);
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2] = true;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2] = false;
            this.ucScreenLED1.SetMyNumeralNew(int32_2);
            break;
          case 2:
            int int32_3 = Convert.ToInt32(this.ucInfoImage4.val1);
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = true;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2] = false;
            this.ucScreenLED1.SetMyNumeralNew(int32_3);
            break;
          case 3:
            int int32_4 = Convert.ToInt32(this.ucInfoImage6.val1);
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2] = false;
            this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2] = true;
            this.ucScreenLED1.SetMyNumeralNew(int32_4);
            break;
        }
      }
      else if (this.LunBo1)
      {
        int int32 = Convert.ToInt32(this.ucInfoImage1.val1);
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2] = false;
        this.ucScreenLED1.SetMyNumeralNew(int32);
      }
      else if (this.LunBo2)
      {
        int int32 = Convert.ToInt32(this.ucInfoImage3.val1);
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2] = false;
        this.ucScreenLED1.SetMyNumeralNew(int32);
      }
      else if (this.LunBo3)
      {
        int int32 = Convert.ToInt32(this.ucInfoImage4.val1);
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = true;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2] = false;
        this.ucScreenLED1.SetMyNumeralNew(int32);
      }
      else if (this.LunBo4)
      {
        int int32 = Convert.ToInt32(this.ucInfoImage6.val1);
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2] = false;
        this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2] = true;
        this.ucScreenLED1.SetMyNumeralNew(int32);
      }
    }
    else if (this.nowLedStyle == (byte) 9)
    {
      DateTime now = DateTime.Now;
      int month = now.Month;
      int day = now.Day;
      int h = now.Hour;
      if (!this.isTimer24)
      {
        h %= 12;
        if (h == 0)
          h = 12;
      }
      int minute = now.Minute;
      int w = (int) now.DayOfWeek;
      if (!this.isWeekSun)
      {
        --w;
        if (w == -1)
          w = 6;
      }
      this.ucScreenLED1.SetMyTimer(month, day, h, minute, w);
    }
    else
    {
      if (this.nowLedStyle == (byte) 12)
        return;
      this.ucScreenLED1.isOn[0] = true;
      this.ucScreenLED1.isOn[1] = true;
      if (this.isLunBo)
      {
        ++this.ValCount;
        if (this.ValCount >= 6 * Convert.ToInt32(this.textBoxTimer.Text))
        {
          this.ValCount = 0;
          ArrayList arrayList = new ArrayList();
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo3);
          arrayList.Add((object) this.LunBo4);
          arrayList.Add((object) this.LunBo1);
          arrayList.Add((object) this.LunBo2);
          arrayList.Add((object) this.LunBo3);
          arrayList.Add((object) this.LunBo4);
          for (int index = this.nowLunbo + 1; index < arrayList.Count; ++index)
          {
            if ((bool) arrayList[index])
            {
              this.nowLunbo = index % 4;
              break;
            }
          }
        }
        switch (this.nowLunbo)
        {
          case 0:
            int int32_5 = Convert.ToInt32(this.ucInfoImage1.val1);
            this.ucScreenLED1.isOn[2] = true;
            this.ucScreenLED1.isOn[3] = true;
            this.ucScreenLED1.isOn[4] = false;
            this.ucScreenLED1.isOn[5] = false;
            if (this.ucInfoImage1.myTextMode == 1)
            {
              this.ucScreenLED1.isOn[6] = true;
              this.ucScreenLED1.isOn[7] = false;
              this.ucScreenLED1.isOn[8] = false;
            }
            else
            {
              this.ucScreenLED1.isOn[6] = false;
              this.ucScreenLED1.isOn[7] = true;
              this.ucScreenLED1.isOn[8] = false;
            }
            this.ucScreenLED1.SetMyNumeral(int32_5);
            break;
          case 1:
            int int32_6 = Convert.ToInt32(this.ucInfoImage3.val1);
            this.ucScreenLED1.isOn[2] = true;
            this.ucScreenLED1.isOn[3] = true;
            this.ucScreenLED1.isOn[4] = false;
            this.ucScreenLED1.isOn[5] = false;
            this.ucScreenLED1.isOn[6] = false;
            this.ucScreenLED1.isOn[7] = false;
            this.ucScreenLED1.isOn[8] = true;
            this.ucScreenLED1.SetMyNumeral(int32_6);
            break;
          case 2:
            int int32_7 = Convert.ToInt32(this.ucInfoImage4.val1);
            this.ucScreenLED1.isOn[2] = false;
            this.ucScreenLED1.isOn[3] = false;
            this.ucScreenLED1.isOn[4] = true;
            this.ucScreenLED1.isOn[5] = true;
            if (this.ucInfoImage1.myTextMode == 1)
            {
              this.ucScreenLED1.isOn[6] = true;
              this.ucScreenLED1.isOn[7] = false;
              this.ucScreenLED1.isOn[8] = false;
            }
            else
            {
              this.ucScreenLED1.isOn[6] = false;
              this.ucScreenLED1.isOn[7] = true;
              this.ucScreenLED1.isOn[8] = false;
            }
            this.ucScreenLED1.SetMyNumeral(int32_7);
            break;
          case 3:
            int int32_8 = Convert.ToInt32(this.ucInfoImage6.val1);
            this.ucScreenLED1.isOn[2] = false;
            this.ucScreenLED1.isOn[3] = false;
            this.ucScreenLED1.isOn[4] = true;
            this.ucScreenLED1.isOn[5] = true;
            this.ucScreenLED1.isOn[6] = false;
            this.ucScreenLED1.isOn[7] = false;
            this.ucScreenLED1.isOn[8] = true;
            this.ucScreenLED1.SetMyNumeral(int32_8);
            break;
        }
      }
      else if (this.LunBo1)
      {
        int int32 = Convert.ToInt32(this.ucInfoImage1.val1);
        this.ucScreenLED1.isOn[2] = true;
        this.ucScreenLED1.isOn[3] = true;
        this.ucScreenLED1.isOn[4] = false;
        this.ucScreenLED1.isOn[5] = false;
        if (this.ucInfoImage1.myTextMode == 1)
        {
          this.ucScreenLED1.isOn[6] = true;
          this.ucScreenLED1.isOn[7] = false;
          this.ucScreenLED1.isOn[8] = false;
        }
        else
        {
          this.ucScreenLED1.isOn[6] = false;
          this.ucScreenLED1.isOn[7] = true;
          this.ucScreenLED1.isOn[8] = false;
        }
        this.ucScreenLED1.SetMyNumeral(int32);
      }
      else if (this.LunBo2)
      {
        int int32 = Convert.ToInt32(this.ucInfoImage3.val1);
        this.ucScreenLED1.isOn[2] = true;
        this.ucScreenLED1.isOn[3] = true;
        this.ucScreenLED1.isOn[4] = false;
        this.ucScreenLED1.isOn[5] = false;
        this.ucScreenLED1.isOn[6] = false;
        this.ucScreenLED1.isOn[7] = false;
        this.ucScreenLED1.isOn[8] = true;
        this.ucScreenLED1.SetMyNumeral(int32);
      }
      else if (this.LunBo3)
      {
        int int32 = Convert.ToInt32(this.ucInfoImage4.val1);
        this.ucScreenLED1.isOn[2] = false;
        this.ucScreenLED1.isOn[3] = false;
        this.ucScreenLED1.isOn[4] = true;
        this.ucScreenLED1.isOn[5] = true;
        if (this.ucInfoImage1.myTextMode == 1)
        {
          this.ucScreenLED1.isOn[6] = true;
          this.ucScreenLED1.isOn[7] = false;
          this.ucScreenLED1.isOn[8] = false;
        }
        else
        {
          this.ucScreenLED1.isOn[6] = false;
          this.ucScreenLED1.isOn[7] = true;
          this.ucScreenLED1.isOn[8] = false;
        }
        this.ucScreenLED1.SetMyNumeral(int32);
      }
      else if (this.LunBo4)
      {
        int int32 = Convert.ToInt32(this.ucInfoImage6.val1);
        this.ucScreenLED1.isOn[2] = false;
        this.ucScreenLED1.isOn[3] = false;
        this.ucScreenLED1.isOn[4] = true;
        this.ucScreenLED1.isOn[5] = true;
        this.ucScreenLED1.isOn[6] = false;
        this.ucScreenLED1.isOn[7] = false;
        this.ucScreenLED1.isOn[8] = true;
        this.ucScreenLED1.SetMyNumeral(int32);
      }
    }
  }

  public void MyTimer_Event()
  {
    this.GetSystemInfo();
    this.GetVal();
    if (this.nowLedStyle == (byte) 2 || this.nowLedStyle == (byte) 7)
    {
      this.DSHX_Timer_New();
      this.QCJB_Timer_New();
      if (this.nowLedStyle == (byte) 2)
        this.CHMS_Timer_New();
      else if (this.nowLedStyle == (byte) 7)
        this.CHMS_Timer_New_7();
      this.WDLD_Timer_New();
      this.FZLD_Timer_New();
    }
    else if (this.nowLedStyle == (byte) 4)
    {
      switch (this.myLedMode)
      {
        case 1:
          this.DSCL_Timer4();
          break;
        case 2:
          this.DSHX_Timer4();
          break;
        case 3:
          this.QCJB_Timer4();
          break;
        case 4:
          this.CHMS_Timer4();
          break;
        case 5:
          this.WDLD_Timer4();
          break;
        case 6:
          this.FZLD_Timer4();
          break;
      }
    }
    else if (this.nowLedStyle == (byte) 5)
    {
      switch (this.myLedMode)
      {
        case 1:
          this.DSCL_Timer5();
          break;
        case 2:
          this.DSHX_Timer5();
          break;
        case 3:
          this.QCJB_Timer5();
          break;
        case 4:
          this.CHMS_Timer5();
          break;
        case 5:
          this.WDLD_Timer5();
          break;
        case 6:
          this.FZLD_Timer5();
          break;
      }
    }
    else if (this.nowLedStyle == (byte) 6)
    {
      switch (this.myLedMode)
      {
        case 1:
          this.DSCL_Timer6();
          break;
        case 2:
          this.DSHX_Timer6();
          break;
        case 3:
          this.QCJB_Timer6();
          break;
        case 4:
          this.CHMS_Timer6();
          break;
        case 5:
          this.WDLD_Timer6();
          break;
        case 6:
          this.FZLD_Timer6();
          break;
      }
    }
    else if (this.nowLedStyle == (byte) 8)
    {
      switch (this.myLedMode)
      {
        case 1:
          this.DSCL_Timer8();
          break;
        case 2:
          this.DSHX_Timer8();
          break;
        case 3:
          this.QCJB_Timer8();
          break;
        case 4:
          this.CHMS_Timer8();
          break;
        case 5:
          this.WDLD_Timer8();
          break;
        case 6:
          this.FZLD_Timer8();
          break;
      }
    }
    else if (this.nowLedStyle == (byte) 9)
    {
      switch (this.myLedMode)
      {
        case 1:
          this.DSCL_Timer9();
          break;
        case 2:
          this.DSHX_Timer9();
          break;
        case 3:
          this.QCJB_Timer9();
          break;
        case 4:
          this.CHMS_Timer9();
          break;
        case 5:
          this.WDLD_Timer9();
          break;
        case 6:
          this.FZLD_Timer9();
          break;
      }
    }
    else if (this.nowLedStyle == (byte) 10)
    {
      switch (this.myLedMode)
      {
        case 1:
          this.DSCL_Timer10();
          break;
        case 2:
          this.DSHX_Timer10();
          break;
        case 3:
          this.QCJB_Timer10();
          break;
        case 4:
          this.CHMS_Timer10();
          break;
        case 5:
          this.WDLD_Timer10();
          break;
        case 6:
          this.FZLD_Timer10();
          break;
      }
    }
    else if (this.nowLedStyle == (byte) 11)
    {
      switch (this.myLedMode)
      {
        case 1:
          this.DSCL_TimerLF15();
          break;
        case 2:
          this.DSHX_TimerLF15();
          break;
        case 3:
          this.QCJB_TimerLF15();
          break;
        case 4:
          this.CHMS_TimerLF15();
          break;
        case 5:
          this.WDLD_TimerLF15();
          break;
        case 6:
          this.FZLD_TimerLF15();
          break;
      }
    }
    else if (this.nowLedStyle == (byte) 12)
    {
      switch (this.myLedMode)
      {
        case 1:
          this.DSCL_TimerLF13();
          break;
        case 2:
          this.DSHX_TimerLF13();
          break;
        case 3:
          this.QCJB_TimerLF13();
          break;
        case 4:
          this.CHMS_TimerLF13();
          break;
        case 5:
          this.WDLD_TimerLF13();
          break;
        case 6:
          this.FZLD_TimerLF13();
          break;
      }
    }
    else
    {
      switch (this.myLedMode)
      {
        case 1:
          this.DSCL_Timer();
          break;
        case 2:
          this.DSHX_Timer();
          break;
        case 3:
          this.QCJB_Timer();
          break;
        case 4:
          this.CHMS_Timer();
          break;
        case 5:
          this.WDLD_Timer();
          break;
        case 6:
          this.FZLD_Timer();
          break;
      }
    }
    this.LedValToScreenLed();
    this.SendHidVal();
    this.Invalidate();
  }

  private void SendHidVal()
  {
    byte num1 = 0;
    float num2 = 0.4f;
    if (this.checkBox1.Checked)
    {
      ++this.testTimer;
      if (this.testTimer >= 10)
      {
        this.testTimer = 0;
        ++this.testCount;
        if (this.testCount >= 4)
          this.testCount = 0;
      }
      byte[] second = new byte[252];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) second.Length,
        (byte) 0,
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 84; ++index)
      {
        if (this.testCount == 0)
        {
          second[index * 3] = (byte) 1;
          second[index * 3 + 1] = (byte) 1;
          second[index * 3 + 2] = (byte) 1;
        }
        else if (this.testCount == 1)
        {
          second[index * 3] = (byte) 1;
          second[index * 3 + 1] = (byte) 0;
          second[index * 3 + 2] = (byte) 0;
        }
        else if (this.testCount == 2)
        {
          second[index * 3] = (byte) 0;
          second[index * 3 + 1] = (byte) 1;
          second[index * 3 + 2] = (byte) 0;
        }
        else if (this.testCount == 3)
        {
          second[index * 3] = (byte) 0;
          second[index * 3 + 1] = (byte) 0;
          second[index * 3 + 2] = (byte) 1;
        }
      }
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 2)
    {
      byte[] numArray1 = new byte[252];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray1.Length,
        (byte) 0,
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 84; ++index)
      {
        if (this.ucScreenLED1.isOn[index])
        {
          numArray1[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2);
          numArray1[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2);
          numArray1[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2);
        }
        else
        {
          numArray1[index * 3] = (byte) 0;
          numArray1[index * 3 + 1] = (byte) 0;
          numArray1[index * 3 + 2] = (byte) 0;
        }
      }
      int num3 = 0;
      byte[] second = new byte[numArray1.Length];
      byte[] numArray2 = second;
      int num4 = num3;
      int num5 = num4 + 1;
      int index1 = num4;
      int num6 = (int) numArray1[this.ucScreenLED1.Cpu2 * 3];
      numArray2[index1] = (byte) num6;
      byte[] numArray3 = second;
      int num7 = num5;
      int num8 = num7 + 1;
      int index2 = num7;
      int num9 = (int) numArray1[this.ucScreenLED1.Cpu2 * 3 + 1];
      numArray3[index2] = (byte) num9;
      byte[] numArray4 = second;
      int num10 = num8;
      int num11 = num10 + 1;
      int index3 = num10;
      int num12 = (int) numArray1[this.ucScreenLED1.Cpu2 * 3 + 2];
      numArray4[index3] = (byte) num12;
      byte[] numArray5 = second;
      int num13 = num11;
      int num14 = num13 + 1;
      int index4 = num13;
      int num15 = (int) numArray1[this.ucScreenLED1.Cpu1 * 3];
      numArray5[index4] = (byte) num15;
      byte[] numArray6 = second;
      int num16 = num14;
      int num17 = num16 + 1;
      int index5 = num16;
      int num18 = (int) numArray1[this.ucScreenLED1.Cpu1 * 3 + 1];
      numArray6[index5] = (byte) num18;
      byte[] numArray7 = second;
      int num19 = num17;
      int num20 = num19 + 1;
      int index6 = num19;
      int num21 = (int) numArray1[this.ucScreenLED1.Cpu1 * 3 + 2];
      numArray7[index6] = (byte) num21;
      byte[] numArray8 = second;
      int num22 = num20;
      int num23 = num22 + 1;
      int index7 = num22;
      int num24 = (int) numArray1[this.ucScreenLED1.LEDF1 * 3];
      numArray8[index7] = (byte) num24;
      byte[] numArray9 = second;
      int num25 = num23;
      int num26 = num25 + 1;
      int index8 = num25;
      int num27 = (int) numArray1[this.ucScreenLED1.LEDF1 * 3 + 1];
      numArray9[index8] = (byte) num27;
      byte[] numArray10 = second;
      int num28 = num26;
      int num29 = num28 + 1;
      int index9 = num28;
      int num30 = (int) numArray1[this.ucScreenLED1.LEDF1 * 3 + 2];
      numArray10[index9] = (byte) num30;
      byte[] numArray11 = second;
      int num31 = num29;
      int num32 = num31 + 1;
      int index10 = num31;
      int num33 = (int) numArray1[this.ucScreenLED1.LEDA1 * 3];
      numArray11[index10] = (byte) num33;
      byte[] numArray12 = second;
      int num34 = num32;
      int num35 = num34 + 1;
      int index11 = num34;
      int num36 = (int) numArray1[this.ucScreenLED1.LEDA1 * 3 + 1];
      numArray12[index11] = (byte) num36;
      byte[] numArray13 = second;
      int num37 = num35;
      int num38 = num37 + 1;
      int index12 = num37;
      int num39 = (int) numArray1[this.ucScreenLED1.LEDA1 * 3 + 2];
      numArray13[index12] = (byte) num39;
      byte[] numArray14 = second;
      int num40 = num38;
      int num41 = num40 + 1;
      int index13 = num40;
      int num42 = (int) numArray1[this.ucScreenLED1.LEDB1 * 3];
      numArray14[index13] = (byte) num42;
      byte[] numArray15 = second;
      int num43 = num41;
      int num44 = num43 + 1;
      int index14 = num43;
      int num45 = (int) numArray1[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray15[index14] = (byte) num45;
      byte[] numArray16 = second;
      int num46 = num44;
      int num47 = num46 + 1;
      int index15 = num46;
      int num48 = (int) numArray1[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray16[index15] = (byte) num48;
      byte[] numArray17 = second;
      int num49 = num47;
      int num50 = num49 + 1;
      int index16 = num49;
      int num51 = (int) numArray1[this.ucScreenLED1.LEDG1 * 3];
      numArray17[index16] = (byte) num51;
      byte[] numArray18 = second;
      int num52 = num50;
      int num53 = num52 + 1;
      int index17 = num52;
      int num54 = (int) numArray1[this.ucScreenLED1.LEDG1 * 3 + 1];
      numArray18[index17] = (byte) num54;
      byte[] numArray19 = second;
      int num55 = num53;
      int num56 = num55 + 1;
      int index18 = num55;
      int num57 = (int) numArray1[this.ucScreenLED1.LEDG1 * 3 + 2];
      numArray19[index18] = (byte) num57;
      byte[] numArray20 = second;
      int num58 = num56;
      int num59 = num58 + 1;
      int index19 = num58;
      int num60 = (int) numArray1[this.ucScreenLED1.LEDE1 * 3];
      numArray20[index19] = (byte) num60;
      byte[] numArray21 = second;
      int num61 = num59;
      int num62 = num61 + 1;
      int index20 = num61;
      int num63 = (int) numArray1[this.ucScreenLED1.LEDE1 * 3 + 1];
      numArray21[index20] = (byte) num63;
      byte[] numArray22 = second;
      int num64 = num62;
      int num65 = num64 + 1;
      int index21 = num64;
      int num66 = (int) numArray1[this.ucScreenLED1.LEDE1 * 3 + 2];
      numArray22[index21] = (byte) num66;
      byte[] numArray23 = second;
      int num67 = num65;
      int num68 = num67 + 1;
      int index22 = num67;
      int num69 = (int) numArray1[this.ucScreenLED1.LEDD1 * 3];
      numArray23[index22] = (byte) num69;
      byte[] numArray24 = second;
      int num70 = num68;
      int num71 = num70 + 1;
      int index23 = num70;
      int num72 = (int) numArray1[this.ucScreenLED1.LEDD1 * 3 + 1];
      numArray24[index23] = (byte) num72;
      byte[] numArray25 = second;
      int num73 = num71;
      int num74 = num73 + 1;
      int index24 = num73;
      int num75 = (int) numArray1[this.ucScreenLED1.LEDD1 * 3 + 2];
      numArray25[index24] = (byte) num75;
      byte[] numArray26 = second;
      int num76 = num74;
      int num77 = num76 + 1;
      int index25 = num76;
      int num78 = (int) numArray1[this.ucScreenLED1.LEDC1 * 3];
      numArray26[index25] = (byte) num78;
      byte[] numArray27 = second;
      int num79 = num77;
      int num80 = num79 + 1;
      int index26 = num79;
      int num81 = (int) numArray1[this.ucScreenLED1.LEDC1 * 3 + 1];
      numArray27[index26] = (byte) num81;
      byte[] numArray28 = second;
      int num82 = num80;
      int num83 = num82 + 1;
      int index27 = num82;
      int num84 = (int) numArray1[this.ucScreenLED1.LEDC1 * 3 + 2];
      numArray28[index27] = (byte) num84;
      byte[] numArray29 = second;
      int num85 = num83;
      int num86 = num85 + 1;
      int index28 = num85;
      int num87 = (int) numArray1[this.ucScreenLED1.LEDF2 * 3];
      numArray29[index28] = (byte) num87;
      byte[] numArray30 = second;
      int num88 = num86;
      int num89 = num88 + 1;
      int index29 = num88;
      int num90 = (int) numArray1[this.ucScreenLED1.LEDF2 * 3 + 1];
      numArray30[index29] = (byte) num90;
      byte[] numArray31 = second;
      int num91 = num89;
      int num92 = num91 + 1;
      int index30 = num91;
      int num93 = (int) numArray1[this.ucScreenLED1.LEDF2 * 3 + 2];
      numArray31[index30] = (byte) num93;
      byte[] numArray32 = second;
      int num94 = num92;
      int num95 = num94 + 1;
      int index31 = num94;
      int num96 = (int) numArray1[this.ucScreenLED1.LEDA2 * 3];
      numArray32[index31] = (byte) num96;
      byte[] numArray33 = second;
      int num97 = num95;
      int num98 = num97 + 1;
      int index32 = num97;
      int num99 = (int) numArray1[this.ucScreenLED1.LEDA2 * 3 + 1];
      numArray33[index32] = (byte) num99;
      byte[] numArray34 = second;
      int num100 = num98;
      int num101 = num100 + 1;
      int index33 = num100;
      int num102 = (int) numArray1[this.ucScreenLED1.LEDA2 * 3 + 2];
      numArray34[index33] = (byte) num102;
      byte[] numArray35 = second;
      int num103 = num101;
      int num104 = num103 + 1;
      int index34 = num103;
      int num105 = (int) numArray1[this.ucScreenLED1.LEDB2 * 3];
      numArray35[index34] = (byte) num105;
      byte[] numArray36 = second;
      int num106 = num104;
      int num107 = num106 + 1;
      int index35 = num106;
      int num108 = (int) numArray1[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray36[index35] = (byte) num108;
      byte[] numArray37 = second;
      int num109 = num107;
      int num110 = num109 + 1;
      int index36 = num109;
      int num111 = (int) numArray1[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray37[index36] = (byte) num111;
      byte[] numArray38 = second;
      int num112 = num110;
      int num113 = num112 + 1;
      int index37 = num112;
      int num114 = (int) numArray1[this.ucScreenLED1.LEDG2 * 3];
      numArray38[index37] = (byte) num114;
      byte[] numArray39 = second;
      int num115 = num113;
      int num116 = num115 + 1;
      int index38 = num115;
      int num117 = (int) numArray1[this.ucScreenLED1.LEDG2 * 3 + 1];
      numArray39[index38] = (byte) num117;
      byte[] numArray40 = second;
      int num118 = num116;
      int num119 = num118 + 1;
      int index39 = num118;
      int num120 = (int) numArray1[this.ucScreenLED1.LEDG2 * 3 + 2];
      numArray40[index39] = (byte) num120;
      byte[] numArray41 = second;
      int num121 = num119;
      int num122 = num121 + 1;
      int index40 = num121;
      int num123 = (int) numArray1[this.ucScreenLED1.LEDE2 * 3];
      numArray41[index40] = (byte) num123;
      byte[] numArray42 = second;
      int num124 = num122;
      int num125 = num124 + 1;
      int index41 = num124;
      int num126 = (int) numArray1[this.ucScreenLED1.LEDE2 * 3 + 1];
      numArray42[index41] = (byte) num126;
      byte[] numArray43 = second;
      int num127 = num125;
      int num128 = num127 + 1;
      int index42 = num127;
      int num129 = (int) numArray1[this.ucScreenLED1.LEDE2 * 3 + 2];
      numArray43[index42] = (byte) num129;
      byte[] numArray44 = second;
      int num130 = num128;
      int num131 = num130 + 1;
      int index43 = num130;
      int num132 = (int) numArray1[this.ucScreenLED1.LEDD2 * 3];
      numArray44[index43] = (byte) num132;
      byte[] numArray45 = second;
      int num133 = num131;
      int num134 = num133 + 1;
      int index44 = num133;
      int num135 = (int) numArray1[this.ucScreenLED1.LEDD2 * 3 + 1];
      numArray45[index44] = (byte) num135;
      byte[] numArray46 = second;
      int num136 = num134;
      int num137 = num136 + 1;
      int index45 = num136;
      int num138 = (int) numArray1[this.ucScreenLED1.LEDD2 * 3 + 2];
      numArray46[index45] = (byte) num138;
      byte[] numArray47 = second;
      int num139 = num137;
      int num140 = num139 + 1;
      int index46 = num139;
      int num141 = (int) numArray1[this.ucScreenLED1.LEDC2 * 3];
      numArray47[index46] = (byte) num141;
      byte[] numArray48 = second;
      int num142 = num140;
      int num143 = num142 + 1;
      int index47 = num142;
      int num144 = (int) numArray1[this.ucScreenLED1.LEDC2 * 3 + 1];
      numArray48[index47] = (byte) num144;
      byte[] numArray49 = second;
      int num145 = num143;
      int num146 = num145 + 1;
      int index48 = num145;
      int num147 = (int) numArray1[this.ucScreenLED1.LEDC2 * 3 + 2];
      numArray49[index48] = (byte) num147;
      byte[] numArray50 = second;
      int num148 = num146;
      int num149 = num148 + 1;
      int index49 = num148;
      int num150 = (int) numArray1[this.ucScreenLED1.LEDF3 * 3];
      numArray50[index49] = (byte) num150;
      byte[] numArray51 = second;
      int num151 = num149;
      int num152 = num151 + 1;
      int index50 = num151;
      int num153 = (int) numArray1[this.ucScreenLED1.LEDF3 * 3 + 1];
      numArray51[index50] = (byte) num153;
      byte[] numArray52 = second;
      int num154 = num152;
      int num155 = num154 + 1;
      int index51 = num154;
      int num156 = (int) numArray1[this.ucScreenLED1.LEDF3 * 3 + 2];
      numArray52[index51] = (byte) num156;
      byte[] numArray53 = second;
      int num157 = num155;
      int num158 = num157 + 1;
      int index52 = num157;
      int num159 = (int) numArray1[this.ucScreenLED1.LEDA3 * 3];
      numArray53[index52] = (byte) num159;
      byte[] numArray54 = second;
      int num160 = num158;
      int num161 = num160 + 1;
      int index53 = num160;
      int num162 = (int) numArray1[this.ucScreenLED1.LEDA3 * 3 + 1];
      numArray54[index53] = (byte) num162;
      byte[] numArray55 = second;
      int num163 = num161;
      int num164 = num163 + 1;
      int index54 = num163;
      int num165 = (int) numArray1[this.ucScreenLED1.LEDA3 * 3 + 2];
      numArray55[index54] = (byte) num165;
      byte[] numArray56 = second;
      int num166 = num164;
      int num167 = num166 + 1;
      int index55 = num166;
      int num168 = (int) numArray1[this.ucScreenLED1.LEDB3 * 3];
      numArray56[index55] = (byte) num168;
      byte[] numArray57 = second;
      int num169 = num167;
      int num170 = num169 + 1;
      int index56 = num169;
      int num171 = (int) numArray1[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray57[index56] = (byte) num171;
      byte[] numArray58 = second;
      int num172 = num170;
      int num173 = num172 + 1;
      int index57 = num172;
      int num174 = (int) numArray1[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray58[index57] = (byte) num174;
      byte[] numArray59 = second;
      int num175 = num173;
      int num176 = num175 + 1;
      int index58 = num175;
      int num177 = (int) numArray1[this.ucScreenLED1.LEDG3 * 3];
      numArray59[index58] = (byte) num177;
      byte[] numArray60 = second;
      int num178 = num176;
      int num179 = num178 + 1;
      int index59 = num178;
      int num180 = (int) numArray1[this.ucScreenLED1.LEDG3 * 3 + 1];
      numArray60[index59] = (byte) num180;
      byte[] numArray61 = second;
      int num181 = num179;
      int num182 = num181 + 1;
      int index60 = num181;
      int num183 = (int) numArray1[this.ucScreenLED1.LEDG3 * 3 + 2];
      numArray61[index60] = (byte) num183;
      byte[] numArray62 = second;
      int num184 = num182;
      int num185 = num184 + 1;
      int index61 = num184;
      int num186 = (int) numArray1[this.ucScreenLED1.LEDE3 * 3];
      numArray62[index61] = (byte) num186;
      byte[] numArray63 = second;
      int num187 = num185;
      int num188 = num187 + 1;
      int index62 = num187;
      int num189 = (int) numArray1[this.ucScreenLED1.LEDE3 * 3 + 1];
      numArray63[index62] = (byte) num189;
      byte[] numArray64 = second;
      int num190 = num188;
      int num191 = num190 + 1;
      int index63 = num190;
      int num192 = (int) numArray1[this.ucScreenLED1.LEDE3 * 3 + 2];
      numArray64[index63] = (byte) num192;
      byte[] numArray65 = second;
      int num193 = num191;
      int num194 = num193 + 1;
      int index64 = num193;
      int num195 = (int) numArray1[this.ucScreenLED1.LEDD3 * 3];
      numArray65[index64] = (byte) num195;
      byte[] numArray66 = second;
      int num196 = num194;
      int num197 = num196 + 1;
      int index65 = num196;
      int num198 = (int) numArray1[this.ucScreenLED1.LEDD3 * 3 + 1];
      numArray66[index65] = (byte) num198;
      byte[] numArray67 = second;
      int num199 = num197;
      int num200 = num199 + 1;
      int index66 = num199;
      int num201 = (int) numArray1[this.ucScreenLED1.LEDD3 * 3 + 2];
      numArray67[index66] = (byte) num201;
      byte[] numArray68 = second;
      int num202 = num200;
      int num203 = num202 + 1;
      int index67 = num202;
      int num204 = (int) numArray1[this.ucScreenLED1.LEDC3 * 3];
      numArray68[index67] = (byte) num204;
      byte[] numArray69 = second;
      int num205 = num203;
      int num206 = num205 + 1;
      int index68 = num205;
      int num207 = (int) numArray1[this.ucScreenLED1.LEDC3 * 3 + 1];
      numArray69[index68] = (byte) num207;
      byte[] numArray70 = second;
      int num208 = num206;
      int num209 = num208 + 1;
      int index69 = num208;
      int num210 = (int) numArray1[this.ucScreenLED1.LEDC3 * 3 + 2];
      numArray70[index69] = (byte) num210;
      byte[] numArray71 = second;
      int num211 = num209;
      int num212 = num211 + 1;
      int index70 = num211;
      int num213 = (int) numArray1[this.ucScreenLED1.SSD * 3];
      numArray71[index70] = (byte) num213;
      byte[] numArray72 = second;
      int num214 = num212;
      int num215 = num214 + 1;
      int index71 = num214;
      int num216 = (int) numArray1[this.ucScreenLED1.SSD * 3 + 1];
      numArray72[index71] = (byte) num216;
      byte[] numArray73 = second;
      int num217 = num215;
      int num218 = num217 + 1;
      int index72 = num217;
      int num219 = (int) numArray1[this.ucScreenLED1.SSD * 3 + 2];
      numArray73[index72] = (byte) num219;
      byte[] numArray74 = second;
      int num220 = num218;
      int num221 = num220 + 1;
      int index73 = num220;
      int num222 = (int) numArray1[this.ucScreenLED1.HSD * 3];
      numArray74[index73] = (byte) num222;
      byte[] numArray75 = second;
      int num223 = num221;
      int num224 = num223 + 1;
      int index74 = num223;
      int num225 = (int) numArray1[this.ucScreenLED1.HSD * 3 + 1];
      numArray75[index74] = (byte) num225;
      byte[] numArray76 = second;
      int num226 = num224;
      int num227 = num226 + 1;
      int index75 = num226;
      int num228 = (int) numArray1[this.ucScreenLED1.HSD * 3 + 2];
      numArray76[index75] = (byte) num228;
      byte[] numArray77 = second;
      int num229 = num227;
      int num230 = num229 + 1;
      int index76 = num229;
      int num231 = (int) numArray1[this.ucScreenLED1.LEDC11 * 3];
      numArray77[index76] = (byte) num231;
      byte[] numArray78 = second;
      int num232 = num230;
      int num233 = num232 + 1;
      int index77 = num232;
      int num234 = (int) numArray1[this.ucScreenLED1.LEDC11 * 3 + 1];
      numArray78[index77] = (byte) num234;
      byte[] numArray79 = second;
      int num235 = num233;
      int num236 = num235 + 1;
      int index78 = num235;
      int num237 = (int) numArray1[this.ucScreenLED1.LEDC11 * 3 + 2];
      numArray79[index78] = (byte) num237;
      byte[] numArray80 = second;
      int num238 = num236;
      int num239 = num238 + 1;
      int index79 = num238;
      int num240 = (int) numArray1[this.ucScreenLED1.LEDB11 * 3];
      numArray80[index79] = (byte) num240;
      byte[] numArray81 = second;
      int num241 = num239;
      int num242 = num241 + 1;
      int index80 = num241;
      int num243 = (int) numArray1[this.ucScreenLED1.LEDB11 * 3 + 1];
      numArray81[index80] = (byte) num243;
      byte[] numArray82 = second;
      int num244 = num242;
      int num245 = num244 + 1;
      int index81 = num244;
      int num246 = (int) numArray1[this.ucScreenLED1.LEDB11 * 3 + 2];
      numArray82[index81] = (byte) num246;
      byte[] numArray83 = second;
      int num247 = num245;
      int num248 = num247 + 1;
      int index82 = num247;
      int num249 = (int) numArray1[this.ucScreenLED1.LEDF4 * 3];
      numArray83[index82] = (byte) num249;
      byte[] numArray84 = second;
      int num250 = num248;
      int num251 = num250 + 1;
      int index83 = num250;
      int num252 = (int) numArray1[this.ucScreenLED1.LEDF4 * 3 + 1];
      numArray84[index83] = (byte) num252;
      byte[] numArray85 = second;
      int num253 = num251;
      int num254 = num253 + 1;
      int index84 = num253;
      int num255 = (int) numArray1[this.ucScreenLED1.LEDF4 * 3 + 2];
      numArray85[index84] = (byte) num255;
      byte[] numArray86 = second;
      int num256 = num254;
      int num257 = num256 + 1;
      int index85 = num256;
      int num258 = (int) numArray1[this.ucScreenLED1.LEDA4 * 3];
      numArray86[index85] = (byte) num258;
      byte[] numArray87 = second;
      int num259 = num257;
      int num260 = num259 + 1;
      int index86 = num259;
      int num261 = (int) numArray1[this.ucScreenLED1.LEDA4 * 3 + 1];
      numArray87[index86] = (byte) num261;
      byte[] numArray88 = second;
      int num262 = num260;
      int num263 = num262 + 1;
      int index87 = num262;
      int num264 = (int) numArray1[this.ucScreenLED1.LEDA4 * 3 + 2];
      numArray88[index87] = (byte) num264;
      byte[] numArray89 = second;
      int num265 = num263;
      int num266 = num265 + 1;
      int index88 = num265;
      int num267 = (int) numArray1[this.ucScreenLED1.LEDB4 * 3];
      numArray89[index88] = (byte) num267;
      byte[] numArray90 = second;
      int num268 = num266;
      int num269 = num268 + 1;
      int index89 = num268;
      int num270 = (int) numArray1[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray90[index89] = (byte) num270;
      byte[] numArray91 = second;
      int num271 = num269;
      int num272 = num271 + 1;
      int index90 = num271;
      int num273 = (int) numArray1[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray91[index90] = (byte) num273;
      byte[] numArray92 = second;
      int num274 = num272;
      int num275 = num274 + 1;
      int index91 = num274;
      int num276 = (int) numArray1[this.ucScreenLED1.LEDG4 * 3];
      numArray92[index91] = (byte) num276;
      byte[] numArray93 = second;
      int num277 = num275;
      int num278 = num277 + 1;
      int index92 = num277;
      int num279 = (int) numArray1[this.ucScreenLED1.LEDG4 * 3 + 1];
      numArray93[index92] = (byte) num279;
      byte[] numArray94 = second;
      int num280 = num278;
      int num281 = num280 + 1;
      int index93 = num280;
      int num282 = (int) numArray1[this.ucScreenLED1.LEDG4 * 3 + 2];
      numArray94[index93] = (byte) num282;
      byte[] numArray95 = second;
      int num283 = num281;
      int num284 = num283 + 1;
      int index94 = num283;
      int num285 = (int) numArray1[this.ucScreenLED1.LEDE4 * 3];
      numArray95[index94] = (byte) num285;
      byte[] numArray96 = second;
      int num286 = num284;
      int num287 = num286 + 1;
      int index95 = num286;
      int num288 = (int) numArray1[this.ucScreenLED1.LEDE4 * 3 + 1];
      numArray96[index95] = (byte) num288;
      byte[] numArray97 = second;
      int num289 = num287;
      int num290 = num289 + 1;
      int index96 = num289;
      int num291 = (int) numArray1[this.ucScreenLED1.LEDE4 * 3 + 2];
      numArray97[index96] = (byte) num291;
      byte[] numArray98 = second;
      int num292 = num290;
      int num293 = num292 + 1;
      int index97 = num292;
      int num294 = (int) numArray1[this.ucScreenLED1.LEDD4 * 3];
      numArray98[index97] = (byte) num294;
      byte[] numArray99 = second;
      int num295 = num293;
      int num296 = num295 + 1;
      int index98 = num295;
      int num297 = (int) numArray1[this.ucScreenLED1.LEDD4 * 3 + 1];
      numArray99[index98] = (byte) num297;
      byte[] numArray100 = second;
      int num298 = num296;
      int num299 = num298 + 1;
      int index99 = num298;
      int num300 = (int) numArray1[this.ucScreenLED1.LEDD4 * 3 + 2];
      numArray100[index99] = (byte) num300;
      byte[] numArray101 = second;
      int num301 = num299;
      int num302 = num301 + 1;
      int index100 = num301;
      int num303 = (int) numArray1[this.ucScreenLED1.LEDC4 * 3];
      numArray101[index100] = (byte) num303;
      byte[] numArray102 = second;
      int num304 = num302;
      int num305 = num304 + 1;
      int index101 = num304;
      int num306 = (int) numArray1[this.ucScreenLED1.LEDC4 * 3 + 1];
      numArray102[index101] = (byte) num306;
      byte[] numArray103 = second;
      int num307 = num305;
      int num308 = num307 + 1;
      int index102 = num307;
      int num309 = (int) numArray1[this.ucScreenLED1.LEDC4 * 3 + 2];
      numArray103[index102] = (byte) num309;
      byte[] numArray104 = second;
      int num310 = num308;
      int num311 = num310 + 1;
      int index103 = num310;
      int num312 = (int) numArray1[this.ucScreenLED1.LEDF5 * 3];
      numArray104[index103] = (byte) num312;
      byte[] numArray105 = second;
      int num313 = num311;
      int num314 = num313 + 1;
      int index104 = num313;
      int num315 = (int) numArray1[this.ucScreenLED1.LEDF5 * 3 + 1];
      numArray105[index104] = (byte) num315;
      byte[] numArray106 = second;
      int num316 = num314;
      int num317 = num316 + 1;
      int index105 = num316;
      int num318 = (int) numArray1[this.ucScreenLED1.LEDF5 * 3 + 2];
      numArray106[index105] = (byte) num318;
      byte[] numArray107 = second;
      int num319 = num317;
      int num320 = num319 + 1;
      int index106 = num319;
      int num321 = (int) numArray1[this.ucScreenLED1.LEDA5 * 3];
      numArray107[index106] = (byte) num321;
      byte[] numArray108 = second;
      int num322 = num320;
      int num323 = num322 + 1;
      int index107 = num322;
      int num324 = (int) numArray1[this.ucScreenLED1.LEDA5 * 3 + 1];
      numArray108[index107] = (byte) num324;
      byte[] numArray109 = second;
      int num325 = num323;
      int num326 = num325 + 1;
      int index108 = num325;
      int num327 = (int) numArray1[this.ucScreenLED1.LEDA5 * 3 + 2];
      numArray109[index108] = (byte) num327;
      byte[] numArray110 = second;
      int num328 = num326;
      int num329 = num328 + 1;
      int index109 = num328;
      int num330 = (int) numArray1[this.ucScreenLED1.LEDB5 * 3];
      numArray110[index109] = (byte) num330;
      byte[] numArray111 = second;
      int num331 = num329;
      int num332 = num331 + 1;
      int index110 = num331;
      int num333 = (int) numArray1[this.ucScreenLED1.LEDB5 * 3 + 1];
      numArray111[index110] = (byte) num333;
      byte[] numArray112 = second;
      int num334 = num332;
      int num335 = num334 + 1;
      int index111 = num334;
      int num336 = (int) numArray1[this.ucScreenLED1.LEDB5 * 3 + 2];
      numArray112[index111] = (byte) num336;
      byte[] numArray113 = second;
      int num337 = num335;
      int num338 = num337 + 1;
      int index112 = num337;
      int num339 = (int) numArray1[this.ucScreenLED1.LEDG5 * 3];
      numArray113[index112] = (byte) num339;
      byte[] numArray114 = second;
      int num340 = num338;
      int num341 = num340 + 1;
      int index113 = num340;
      int num342 = (int) numArray1[this.ucScreenLED1.LEDG5 * 3 + 1];
      numArray114[index113] = (byte) num342;
      byte[] numArray115 = second;
      int num343 = num341;
      int num344 = num343 + 1;
      int index114 = num343;
      int num345 = (int) numArray1[this.ucScreenLED1.LEDG5 * 3 + 2];
      numArray115[index114] = (byte) num345;
      byte[] numArray116 = second;
      int num346 = num344;
      int num347 = num346 + 1;
      int index115 = num346;
      int num348 = (int) numArray1[this.ucScreenLED1.LEDE5 * 3];
      numArray116[index115] = (byte) num348;
      byte[] numArray117 = second;
      int num349 = num347;
      int num350 = num349 + 1;
      int index116 = num349;
      int num351 = (int) numArray1[this.ucScreenLED1.LEDE5 * 3 + 1];
      numArray117[index116] = (byte) num351;
      byte[] numArray118 = second;
      int num352 = num350;
      int num353 = num352 + 1;
      int index117 = num352;
      int num354 = (int) numArray1[this.ucScreenLED1.LEDE5 * 3 + 2];
      numArray118[index117] = (byte) num354;
      byte[] numArray119 = second;
      int num355 = num353;
      int num356 = num355 + 1;
      int index118 = num355;
      int num357 = (int) numArray1[this.ucScreenLED1.LEDD5 * 3];
      numArray119[index118] = (byte) num357;
      byte[] numArray120 = second;
      int num358 = num356;
      int num359 = num358 + 1;
      int index119 = num358;
      int num360 = (int) numArray1[this.ucScreenLED1.LEDD5 * 3 + 1];
      numArray120[index119] = (byte) num360;
      byte[] numArray121 = second;
      int num361 = num359;
      int num362 = num361 + 1;
      int index120 = num361;
      int num363 = (int) numArray1[this.ucScreenLED1.LEDD5 * 3 + 2];
      numArray121[index120] = (byte) num363;
      byte[] numArray122 = second;
      int num364 = num362;
      int num365 = num364 + 1;
      int index121 = num364;
      int num366 = (int) numArray1[this.ucScreenLED1.LEDC5 * 3];
      numArray122[index121] = (byte) num366;
      byte[] numArray123 = second;
      int num367 = num365;
      int num368 = num367 + 1;
      int index122 = num367;
      int num369 = (int) numArray1[this.ucScreenLED1.LEDC5 * 3 + 1];
      numArray123[index122] = (byte) num369;
      byte[] numArray124 = second;
      int num370 = num368;
      int num371 = num370 + 1;
      int index123 = num370;
      int num372 = (int) numArray1[this.ucScreenLED1.LEDC5 * 3 + 2];
      numArray124[index123] = (byte) num372;
      byte[] numArray125 = second;
      int num373 = num371;
      int num374 = num373 + 1;
      int index124 = num373;
      int num375 = (int) numArray1[this.ucScreenLED1.BFB * 3];
      numArray125[index124] = (byte) num375;
      byte[] numArray126 = second;
      int num376 = num374;
      int num377 = num376 + 1;
      int index125 = num376;
      int num378 = (int) numArray1[this.ucScreenLED1.BFB * 3 + 1];
      numArray126[index125] = (byte) num378;
      byte[] numArray127 = second;
      int num379 = num377;
      int num380 = num379 + 1;
      int index126 = num379;
      int num381 = (int) numArray1[this.ucScreenLED1.BFB * 3 + 2];
      numArray127[index126] = (byte) num381;
      byte[] numArray128 = second;
      int num382 = num380;
      int num383 = num382 + 1;
      int index127 = num382;
      int num384 = (int) numArray1[this.ucScreenLED1.BFB1 * 3];
      numArray128[index127] = (byte) num384;
      byte[] numArray129 = second;
      int num385 = num383;
      int num386 = num385 + 1;
      int index128 = num385;
      int num387 = (int) numArray1[this.ucScreenLED1.BFB1 * 3 + 1];
      numArray129[index128] = (byte) num387;
      byte[] numArray130 = second;
      int num388 = num386;
      int num389 = num388 + 1;
      int index129 = num388;
      int num390 = (int) numArray1[this.ucScreenLED1.BFB1 * 3 + 2];
      numArray130[index129] = (byte) num390;
      byte[] numArray131 = second;
      int num391 = num389;
      int num392 = num391 + 1;
      int index130 = num391;
      int num393 = (int) numArray1[this.ucScreenLED1.LEDC10 * 3];
      numArray131[index130] = (byte) num393;
      byte[] numArray132 = second;
      int num394 = num392;
      int num395 = num394 + 1;
      int index131 = num394;
      int num396 = (int) numArray1[this.ucScreenLED1.LEDC10 * 3 + 1];
      numArray132[index131] = (byte) num396;
      byte[] numArray133 = second;
      int num397 = num395;
      int num398 = num397 + 1;
      int index132 = num397;
      int num399 = (int) numArray1[this.ucScreenLED1.LEDC10 * 3 + 2];
      numArray133[index132] = (byte) num399;
      byte[] numArray134 = second;
      int num400 = num398;
      int num401 = num400 + 1;
      int index133 = num400;
      int num402 = (int) numArray1[this.ucScreenLED1.LEDD10 * 3];
      numArray134[index133] = (byte) num402;
      byte[] numArray135 = second;
      int num403 = num401;
      int num404 = num403 + 1;
      int index134 = num403;
      int num405 = (int) numArray1[this.ucScreenLED1.LEDD10 * 3 + 1];
      numArray135[index134] = (byte) num405;
      byte[] numArray136 = second;
      int num406 = num404;
      int num407 = num406 + 1;
      int index135 = num406;
      int num408 = (int) numArray1[this.ucScreenLED1.LEDD10 * 3 + 2];
      numArray136[index135] = (byte) num408;
      byte[] numArray137 = second;
      int num409 = num407;
      int num410 = num409 + 1;
      int index136 = num409;
      int num411 = (int) numArray1[this.ucScreenLED1.LEDE10 * 3];
      numArray137[index136] = (byte) num411;
      byte[] numArray138 = second;
      int num412 = num410;
      int num413 = num412 + 1;
      int index137 = num412;
      int num414 = (int) numArray1[this.ucScreenLED1.LEDE10 * 3 + 1];
      numArray138[index137] = (byte) num414;
      byte[] numArray139 = second;
      int num415 = num413;
      int num416 = num415 + 1;
      int index138 = num415;
      int num417 = (int) numArray1[this.ucScreenLED1.LEDE10 * 3 + 2];
      numArray139[index138] = (byte) num417;
      byte[] numArray140 = second;
      int num418 = num416;
      int num419 = num418 + 1;
      int index139 = num418;
      int num420 = (int) numArray1[this.ucScreenLED1.LEDG10 * 3];
      numArray140[index139] = (byte) num420;
      byte[] numArray141 = second;
      int num421 = num419;
      int num422 = num421 + 1;
      int index140 = num421;
      int num423 = (int) numArray1[this.ucScreenLED1.LEDG10 * 3 + 1];
      numArray141[index140] = (byte) num423;
      byte[] numArray142 = second;
      int num424 = num422;
      int num425 = num424 + 1;
      int index141 = num424;
      int num426 = (int) numArray1[this.ucScreenLED1.LEDG10 * 3 + 2];
      numArray142[index141] = (byte) num426;
      byte[] numArray143 = second;
      int num427 = num425;
      int num428 = num427 + 1;
      int index142 = num427;
      int num429 = (int) numArray1[this.ucScreenLED1.LEDB10 * 3];
      numArray143[index142] = (byte) num429;
      byte[] numArray144 = second;
      int num430 = num428;
      int num431 = num430 + 1;
      int index143 = num430;
      int num432 = (int) numArray1[this.ucScreenLED1.LEDB10 * 3 + 1];
      numArray144[index143] = (byte) num432;
      byte[] numArray145 = second;
      int num433 = num431;
      int num434 = num433 + 1;
      int index144 = num433;
      int num435 = (int) numArray1[this.ucScreenLED1.LEDB10 * 3 + 2];
      numArray145[index144] = (byte) num435;
      byte[] numArray146 = second;
      int num436 = num434;
      int num437 = num436 + 1;
      int index145 = num436;
      int num438 = (int) numArray1[this.ucScreenLED1.LEDA10 * 3];
      numArray146[index145] = (byte) num438;
      byte[] numArray147 = second;
      int num439 = num437;
      int num440 = num439 + 1;
      int index146 = num439;
      int num441 = (int) numArray1[this.ucScreenLED1.LEDA10 * 3 + 1];
      numArray147[index146] = (byte) num441;
      byte[] numArray148 = second;
      int num442 = num440;
      int num443 = num442 + 1;
      int index147 = num442;
      int num444 = (int) numArray1[this.ucScreenLED1.LEDA10 * 3 + 2];
      numArray148[index147] = (byte) num444;
      byte[] numArray149 = second;
      int num445 = num443;
      int num446 = num445 + 1;
      int index148 = num445;
      int num447 = (int) numArray1[this.ucScreenLED1.LEDF10 * 3];
      numArray149[index148] = (byte) num447;
      byte[] numArray150 = second;
      int num448 = num446;
      int num449 = num448 + 1;
      int index149 = num448;
      int num450 = (int) numArray1[this.ucScreenLED1.LEDF10 * 3 + 1];
      numArray150[index149] = (byte) num450;
      byte[] numArray151 = second;
      int num451 = num449;
      int num452 = num451 + 1;
      int index150 = num451;
      int num453 = (int) numArray1[this.ucScreenLED1.LEDF10 * 3 + 2];
      numArray151[index150] = (byte) num453;
      byte[] numArray152 = second;
      int num454 = num452;
      int num455 = num454 + 1;
      int index151 = num454;
      int num456 = (int) numArray1[this.ucScreenLED1.LEDC9 * 3];
      numArray152[index151] = (byte) num456;
      byte[] numArray153 = second;
      int num457 = num455;
      int num458 = num457 + 1;
      int index152 = num457;
      int num459 = (int) numArray1[this.ucScreenLED1.LEDC9 * 3 + 1];
      numArray153[index152] = (byte) num459;
      byte[] numArray154 = second;
      int num460 = num458;
      int num461 = num460 + 1;
      int index153 = num460;
      int num462 = (int) numArray1[this.ucScreenLED1.LEDC9 * 3 + 2];
      numArray154[index153] = (byte) num462;
      byte[] numArray155 = second;
      int num463 = num461;
      int num464 = num463 + 1;
      int index154 = num463;
      int num465 = (int) numArray1[this.ucScreenLED1.LEDD9 * 3];
      numArray155[index154] = (byte) num465;
      byte[] numArray156 = second;
      int num466 = num464;
      int num467 = num466 + 1;
      int index155 = num466;
      int num468 = (int) numArray1[this.ucScreenLED1.LEDD9 * 3 + 1];
      numArray156[index155] = (byte) num468;
      byte[] numArray157 = second;
      int num469 = num467;
      int num470 = num469 + 1;
      int index156 = num469;
      int num471 = (int) numArray1[this.ucScreenLED1.LEDD9 * 3 + 2];
      numArray157[index156] = (byte) num471;
      byte[] numArray158 = second;
      int num472 = num470;
      int num473 = num472 + 1;
      int index157 = num472;
      int num474 = (int) numArray1[this.ucScreenLED1.LEDE9 * 3];
      numArray158[index157] = (byte) num474;
      byte[] numArray159 = second;
      int num475 = num473;
      int num476 = num475 + 1;
      int index158 = num475;
      int num477 = (int) numArray1[this.ucScreenLED1.LEDE9 * 3 + 1];
      numArray159[index158] = (byte) num477;
      byte[] numArray160 = second;
      int num478 = num476;
      int num479 = num478 + 1;
      int index159 = num478;
      int num480 = (int) numArray1[this.ucScreenLED1.LEDE9 * 3 + 2];
      numArray160[index159] = (byte) num480;
      byte[] numArray161 = second;
      int num481 = num479;
      int num482 = num481 + 1;
      int index160 = num481;
      int num483 = (int) numArray1[this.ucScreenLED1.LEDG9 * 3];
      numArray161[index160] = (byte) num483;
      byte[] numArray162 = second;
      int num484 = num482;
      int num485 = num484 + 1;
      int index161 = num484;
      int num486 = (int) numArray1[this.ucScreenLED1.LEDG9 * 3 + 1];
      numArray162[index161] = (byte) num486;
      byte[] numArray163 = second;
      int num487 = num485;
      int num488 = num487 + 1;
      int index162 = num487;
      int num489 = (int) numArray1[this.ucScreenLED1.LEDG9 * 3 + 2];
      numArray163[index162] = (byte) num489;
      byte[] numArray164 = second;
      int num490 = num488;
      int num491 = num490 + 1;
      int index163 = num490;
      int num492 = (int) numArray1[this.ucScreenLED1.LEDB9 * 3];
      numArray164[index163] = (byte) num492;
      byte[] numArray165 = second;
      int num493 = num491;
      int num494 = num493 + 1;
      int index164 = num493;
      int num495 = (int) numArray1[this.ucScreenLED1.LEDB9 * 3 + 1];
      numArray165[index164] = (byte) num495;
      byte[] numArray166 = second;
      int num496 = num494;
      int num497 = num496 + 1;
      int index165 = num496;
      int num498 = (int) numArray1[this.ucScreenLED1.LEDB9 * 3 + 2];
      numArray166[index165] = (byte) num498;
      byte[] numArray167 = second;
      int num499 = num497;
      int num500 = num499 + 1;
      int index166 = num499;
      int num501 = (int) numArray1[this.ucScreenLED1.LEDA9 * 3];
      numArray167[index166] = (byte) num501;
      byte[] numArray168 = second;
      int num502 = num500;
      int num503 = num502 + 1;
      int index167 = num502;
      int num504 = (int) numArray1[this.ucScreenLED1.LEDA9 * 3 + 1];
      numArray168[index167] = (byte) num504;
      byte[] numArray169 = second;
      int num505 = num503;
      int num506 = num505 + 1;
      int index168 = num505;
      int num507 = (int) numArray1[this.ucScreenLED1.LEDA9 * 3 + 2];
      numArray169[index168] = (byte) num507;
      byte[] numArray170 = second;
      int num508 = num506;
      int num509 = num508 + 1;
      int index169 = num508;
      int num510 = (int) numArray1[this.ucScreenLED1.LEDF9 * 3];
      numArray170[index169] = (byte) num510;
      byte[] numArray171 = second;
      int num511 = num509;
      int num512 = num511 + 1;
      int index170 = num511;
      int num513 = (int) numArray1[this.ucScreenLED1.LEDF9 * 3 + 1];
      numArray171[index170] = (byte) num513;
      byte[] numArray172 = second;
      int num514 = num512;
      int num515 = num514 + 1;
      int index171 = num514;
      int num516 = (int) numArray1[this.ucScreenLED1.LEDF9 * 3 + 2];
      numArray172[index171] = (byte) num516;
      byte[] numArray173 = second;
      int num517 = num515;
      int num518 = num517 + 1;
      int index172 = num517;
      int num519 = (int) numArray1[this.ucScreenLED1.LEDB12 * 3];
      numArray173[index172] = (byte) num519;
      byte[] numArray174 = second;
      int num520 = num518;
      int num521 = num520 + 1;
      int index173 = num520;
      int num522 = (int) numArray1[this.ucScreenLED1.LEDB12 * 3 + 1];
      numArray174[index173] = (byte) num522;
      byte[] numArray175 = second;
      int num523 = num521;
      int num524 = num523 + 1;
      int index174 = num523;
      int num525 = (int) numArray1[this.ucScreenLED1.LEDB12 * 3 + 2];
      numArray175[index174] = (byte) num525;
      byte[] numArray176 = second;
      int num526 = num524;
      int num527 = num526 + 1;
      int index175 = num526;
      int num528 = (int) numArray1[this.ucScreenLED1.LEDC12 * 3];
      numArray176[index175] = (byte) num528;
      byte[] numArray177 = second;
      int num529 = num527;
      int num530 = num529 + 1;
      int index176 = num529;
      int num531 = (int) numArray1[this.ucScreenLED1.LEDC12 * 3 + 1];
      numArray177[index176] = (byte) num531;
      byte[] numArray178 = second;
      int num532 = num530;
      int num533 = num532 + 1;
      int index177 = num532;
      int num534 = (int) numArray1[this.ucScreenLED1.LEDC12 * 3 + 2];
      numArray178[index177] = (byte) num534;
      byte[] numArray179 = second;
      int num535 = num533;
      int num536 = num535 + 1;
      int index178 = num535;
      int num537 = (int) numArray1[this.ucScreenLED1.SSD1 * 3];
      numArray179[index178] = (byte) num537;
      byte[] numArray180 = second;
      int num538 = num536;
      int num539 = num538 + 1;
      int index179 = num538;
      int num540 = (int) numArray1[this.ucScreenLED1.SSD1 * 3 + 1];
      numArray180[index179] = (byte) num540;
      byte[] numArray181 = second;
      int num541 = num539;
      int num542 = num541 + 1;
      int index180 = num541;
      int num543 = (int) numArray1[this.ucScreenLED1.SSD1 * 3 + 2];
      numArray181[index180] = (byte) num543;
      byte[] numArray182 = second;
      int num544 = num542;
      int num545 = num544 + 1;
      int index181 = num544;
      int num546 = (int) numArray1[this.ucScreenLED1.HSD1 * 3];
      numArray182[index181] = (byte) num546;
      byte[] numArray183 = second;
      int num547 = num545;
      int num548 = num547 + 1;
      int index182 = num547;
      int num549 = (int) numArray1[this.ucScreenLED1.HSD1 * 3 + 1];
      numArray183[index182] = (byte) num549;
      byte[] numArray184 = second;
      int num550 = num548;
      int num551 = num550 + 1;
      int index183 = num550;
      int num552 = (int) numArray1[this.ucScreenLED1.HSD1 * 3 + 2];
      numArray184[index183] = (byte) num552;
      byte[] numArray185 = second;
      int num553 = num551;
      int num554 = num553 + 1;
      int index184 = num553;
      int num555 = (int) numArray1[this.ucScreenLED1.LEDC8 * 3];
      numArray185[index184] = (byte) num555;
      byte[] numArray186 = second;
      int num556 = num554;
      int num557 = num556 + 1;
      int index185 = num556;
      int num558 = (int) numArray1[this.ucScreenLED1.LEDC8 * 3 + 1];
      numArray186[index185] = (byte) num558;
      byte[] numArray187 = second;
      int num559 = num557;
      int num560 = num559 + 1;
      int index186 = num559;
      int num561 = (int) numArray1[this.ucScreenLED1.LEDC8 * 3 + 2];
      numArray187[index186] = (byte) num561;
      byte[] numArray188 = second;
      int num562 = num560;
      int num563 = num562 + 1;
      int index187 = num562;
      int num564 = (int) numArray1[this.ucScreenLED1.LEDD8 * 3];
      numArray188[index187] = (byte) num564;
      byte[] numArray189 = second;
      int num565 = num563;
      int num566 = num565 + 1;
      int index188 = num565;
      int num567 = (int) numArray1[this.ucScreenLED1.LEDD8 * 3 + 1];
      numArray189[index188] = (byte) num567;
      byte[] numArray190 = second;
      int num568 = num566;
      int num569 = num568 + 1;
      int index189 = num568;
      int num570 = (int) numArray1[this.ucScreenLED1.LEDD8 * 3 + 2];
      numArray190[index189] = (byte) num570;
      byte[] numArray191 = second;
      int num571 = num569;
      int num572 = num571 + 1;
      int index190 = num571;
      int num573 = (int) numArray1[this.ucScreenLED1.LEDE8 * 3];
      numArray191[index190] = (byte) num573;
      byte[] numArray192 = second;
      int num574 = num572;
      int num575 = num574 + 1;
      int index191 = num574;
      int num576 = (int) numArray1[this.ucScreenLED1.LEDE8 * 3 + 1];
      numArray192[index191] = (byte) num576;
      byte[] numArray193 = second;
      int num577 = num575;
      int num578 = num577 + 1;
      int index192 = num577;
      int num579 = (int) numArray1[this.ucScreenLED1.LEDE8 * 3 + 2];
      numArray193[index192] = (byte) num579;
      byte[] numArray194 = second;
      int num580 = num578;
      int num581 = num580 + 1;
      int index193 = num580;
      int num582 = (int) numArray1[this.ucScreenLED1.LEDG8 * 3];
      numArray194[index193] = (byte) num582;
      byte[] numArray195 = second;
      int num583 = num581;
      int num584 = num583 + 1;
      int index194 = num583;
      int num585 = (int) numArray1[this.ucScreenLED1.LEDG8 * 3 + 1];
      numArray195[index194] = (byte) num585;
      byte[] numArray196 = second;
      int num586 = num584;
      int num587 = num586 + 1;
      int index195 = num586;
      int num588 = (int) numArray1[this.ucScreenLED1.LEDG8 * 3 + 2];
      numArray196[index195] = (byte) num588;
      byte[] numArray197 = second;
      int num589 = num587;
      int num590 = num589 + 1;
      int index196 = num589;
      int num591 = (int) numArray1[this.ucScreenLED1.LEDB8 * 3];
      numArray197[index196] = (byte) num591;
      byte[] numArray198 = second;
      int num592 = num590;
      int num593 = num592 + 1;
      int index197 = num592;
      int num594 = (int) numArray1[this.ucScreenLED1.LEDB8 * 3 + 1];
      numArray198[index197] = (byte) num594;
      byte[] numArray199 = second;
      int num595 = num593;
      int num596 = num595 + 1;
      int index198 = num595;
      int num597 = (int) numArray1[this.ucScreenLED1.LEDB8 * 3 + 2];
      numArray199[index198] = (byte) num597;
      byte[] numArray200 = second;
      int num598 = num596;
      int num599 = num598 + 1;
      int index199 = num598;
      int num600 = (int) numArray1[this.ucScreenLED1.LEDA8 * 3];
      numArray200[index199] = (byte) num600;
      byte[] numArray201 = second;
      int num601 = num599;
      int num602 = num601 + 1;
      int index200 = num601;
      int num603 = (int) numArray1[this.ucScreenLED1.LEDA8 * 3 + 1];
      numArray201[index200] = (byte) num603;
      byte[] numArray202 = second;
      int num604 = num602;
      int num605 = num604 + 1;
      int index201 = num604;
      int num606 = (int) numArray1[this.ucScreenLED1.LEDA8 * 3 + 2];
      numArray202[index201] = (byte) num606;
      byte[] numArray203 = second;
      int num607 = num605;
      int num608 = num607 + 1;
      int index202 = num607;
      int num609 = (int) numArray1[this.ucScreenLED1.LEDF8 * 3];
      numArray203[index202] = (byte) num609;
      byte[] numArray204 = second;
      int num610 = num608;
      int num611 = num610 + 1;
      int index203 = num610;
      int num612 = (int) numArray1[this.ucScreenLED1.LEDF8 * 3 + 1];
      numArray204[index203] = (byte) num612;
      byte[] numArray205 = second;
      int num613 = num611;
      int num614 = num613 + 1;
      int index204 = num613;
      int num615 = (int) numArray1[this.ucScreenLED1.LEDF8 * 3 + 2];
      numArray205[index204] = (byte) num615;
      byte[] numArray206 = second;
      int num616 = num614;
      int num617 = num616 + 1;
      int index205 = num616;
      int num618 = (int) numArray1[this.ucScreenLED1.LEDC7 * 3];
      numArray206[index205] = (byte) num618;
      byte[] numArray207 = second;
      int num619 = num617;
      int num620 = num619 + 1;
      int index206 = num619;
      int num621 = (int) numArray1[this.ucScreenLED1.LEDC7 * 3 + 1];
      numArray207[index206] = (byte) num621;
      byte[] numArray208 = second;
      int num622 = num620;
      int num623 = num622 + 1;
      int index207 = num622;
      int num624 = (int) numArray1[this.ucScreenLED1.LEDC7 * 3 + 2];
      numArray208[index207] = (byte) num624;
      byte[] numArray209 = second;
      int num625 = num623;
      int num626 = num625 + 1;
      int index208 = num625;
      int num627 = (int) numArray1[this.ucScreenLED1.LEDD7 * 3];
      numArray209[index208] = (byte) num627;
      byte[] numArray210 = second;
      int num628 = num626;
      int num629 = num628 + 1;
      int index209 = num628;
      int num630 = (int) numArray1[this.ucScreenLED1.LEDD7 * 3 + 1];
      numArray210[index209] = (byte) num630;
      byte[] numArray211 = second;
      int num631 = num629;
      int num632 = num631 + 1;
      int index210 = num631;
      int num633 = (int) numArray1[this.ucScreenLED1.LEDD7 * 3 + 2];
      numArray211[index210] = (byte) num633;
      byte[] numArray212 = second;
      int num634 = num632;
      int num635 = num634 + 1;
      int index211 = num634;
      int num636 = (int) numArray1[this.ucScreenLED1.LEDE7 * 3];
      numArray212[index211] = (byte) num636;
      byte[] numArray213 = second;
      int num637 = num635;
      int num638 = num637 + 1;
      int index212 = num637;
      int num639 = (int) numArray1[this.ucScreenLED1.LEDE7 * 3 + 1];
      numArray213[index212] = (byte) num639;
      byte[] numArray214 = second;
      int num640 = num638;
      int num641 = num640 + 1;
      int index213 = num640;
      int num642 = (int) numArray1[this.ucScreenLED1.LEDE7 * 3 + 2];
      numArray214[index213] = (byte) num642;
      byte[] numArray215 = second;
      int num643 = num641;
      int num644 = num643 + 1;
      int index214 = num643;
      int num645 = (int) numArray1[this.ucScreenLED1.LEDG7 * 3];
      numArray215[index214] = (byte) num645;
      byte[] numArray216 = second;
      int num646 = num644;
      int num647 = num646 + 1;
      int index215 = num646;
      int num648 = (int) numArray1[this.ucScreenLED1.LEDG7 * 3 + 1];
      numArray216[index215] = (byte) num648;
      byte[] numArray217 = second;
      int num649 = num647;
      int num650 = num649 + 1;
      int index216 = num649;
      int num651 = (int) numArray1[this.ucScreenLED1.LEDG7 * 3 + 2];
      numArray217[index216] = (byte) num651;
      byte[] numArray218 = second;
      int num652 = num650;
      int num653 = num652 + 1;
      int index217 = num652;
      int num654 = (int) numArray1[this.ucScreenLED1.LEDB7 * 3];
      numArray218[index217] = (byte) num654;
      byte[] numArray219 = second;
      int num655 = num653;
      int num656 = num655 + 1;
      int index218 = num655;
      int num657 = (int) numArray1[this.ucScreenLED1.LEDB7 * 3 + 1];
      numArray219[index218] = (byte) num657;
      byte[] numArray220 = second;
      int num658 = num656;
      int num659 = num658 + 1;
      int index219 = num658;
      int num660 = (int) numArray1[this.ucScreenLED1.LEDB7 * 3 + 2];
      numArray220[index219] = (byte) num660;
      byte[] numArray221 = second;
      int num661 = num659;
      int num662 = num661 + 1;
      int index220 = num661;
      int num663 = (int) numArray1[this.ucScreenLED1.LEDA7 * 3];
      numArray221[index220] = (byte) num663;
      byte[] numArray222 = second;
      int num664 = num662;
      int num665 = num664 + 1;
      int index221 = num664;
      int num666 = (int) numArray1[this.ucScreenLED1.LEDA7 * 3 + 1];
      numArray222[index221] = (byte) num666;
      byte[] numArray223 = second;
      int num667 = num665;
      int num668 = num667 + 1;
      int index222 = num667;
      int num669 = (int) numArray1[this.ucScreenLED1.LEDA7 * 3 + 2];
      numArray223[index222] = (byte) num669;
      byte[] numArray224 = second;
      int num670 = num668;
      int num671 = num670 + 1;
      int index223 = num670;
      int num672 = (int) numArray1[this.ucScreenLED1.LEDF7 * 3];
      numArray224[index223] = (byte) num672;
      byte[] numArray225 = second;
      int num673 = num671;
      int num674 = num673 + 1;
      int index224 = num673;
      int num675 = (int) numArray1[this.ucScreenLED1.LEDF7 * 3 + 1];
      numArray225[index224] = (byte) num675;
      byte[] numArray226 = second;
      int num676 = num674;
      int num677 = num676 + 1;
      int index225 = num676;
      int num678 = (int) numArray1[this.ucScreenLED1.LEDF7 * 3 + 2];
      numArray226[index225] = (byte) num678;
      byte[] numArray227 = second;
      int num679 = num677;
      int num680 = num679 + 1;
      int index226 = num679;
      int num681 = (int) numArray1[this.ucScreenLED1.LEDC6 * 3];
      numArray227[index226] = (byte) num681;
      byte[] numArray228 = second;
      int num682 = num680;
      int num683 = num682 + 1;
      int index227 = num682;
      int num684 = (int) numArray1[this.ucScreenLED1.LEDC6 * 3 + 1];
      numArray228[index227] = (byte) num684;
      byte[] numArray229 = second;
      int num685 = num683;
      int num686 = num685 + 1;
      int index228 = num685;
      int num687 = (int) numArray1[this.ucScreenLED1.LEDC6 * 3 + 2];
      numArray229[index228] = (byte) num687;
      byte[] numArray230 = second;
      int num688 = num686;
      int num689 = num688 + 1;
      int index229 = num688;
      int num690 = (int) numArray1[this.ucScreenLED1.LEDD6 * 3];
      numArray230[index229] = (byte) num690;
      byte[] numArray231 = second;
      int num691 = num689;
      int num692 = num691 + 1;
      int index230 = num691;
      int num693 = (int) numArray1[this.ucScreenLED1.LEDD6 * 3 + 1];
      numArray231[index230] = (byte) num693;
      byte[] numArray232 = second;
      int num694 = num692;
      int num695 = num694 + 1;
      int index231 = num694;
      int num696 = (int) numArray1[this.ucScreenLED1.LEDD6 * 3 + 2];
      numArray232[index231] = (byte) num696;
      byte[] numArray233 = second;
      int num697 = num695;
      int num698 = num697 + 1;
      int index232 = num697;
      int num699 = (int) numArray1[this.ucScreenLED1.LEDE6 * 3];
      numArray233[index232] = (byte) num699;
      byte[] numArray234 = second;
      int num700 = num698;
      int num701 = num700 + 1;
      int index233 = num700;
      int num702 = (int) numArray1[this.ucScreenLED1.LEDE6 * 3 + 1];
      numArray234[index233] = (byte) num702;
      byte[] numArray235 = second;
      int num703 = num701;
      int num704 = num703 + 1;
      int index234 = num703;
      int num705 = (int) numArray1[this.ucScreenLED1.LEDE6 * 3 + 2];
      numArray235[index234] = (byte) num705;
      byte[] numArray236 = second;
      int num706 = num704;
      int num707 = num706 + 1;
      int index235 = num706;
      int num708 = (int) numArray1[this.ucScreenLED1.LEDG6 * 3];
      numArray236[index235] = (byte) num708;
      byte[] numArray237 = second;
      int num709 = num707;
      int num710 = num709 + 1;
      int index236 = num709;
      int num711 = (int) numArray1[this.ucScreenLED1.LEDG6 * 3 + 1];
      numArray237[index236] = (byte) num711;
      byte[] numArray238 = second;
      int num712 = num710;
      int num713 = num712 + 1;
      int index237 = num712;
      int num714 = (int) numArray1[this.ucScreenLED1.LEDG6 * 3 + 2];
      numArray238[index237] = (byte) num714;
      byte[] numArray239 = second;
      int num715 = num713;
      int num716 = num715 + 1;
      int index238 = num715;
      int num717 = (int) numArray1[this.ucScreenLED1.LEDB6 * 3];
      numArray239[index238] = (byte) num717;
      byte[] numArray240 = second;
      int num718 = num716;
      int num719 = num718 + 1;
      int index239 = num718;
      int num720 = (int) numArray1[this.ucScreenLED1.LEDB6 * 3 + 1];
      numArray240[index239] = (byte) num720;
      byte[] numArray241 = second;
      int num721 = num719;
      int num722 = num721 + 1;
      int index240 = num721;
      int num723 = (int) numArray1[this.ucScreenLED1.LEDB6 * 3 + 2];
      numArray241[index240] = (byte) num723;
      byte[] numArray242 = second;
      int num724 = num722;
      int num725 = num724 + 1;
      int index241 = num724;
      int num726 = (int) numArray1[this.ucScreenLED1.LEDA6 * 3];
      numArray242[index241] = (byte) num726;
      byte[] numArray243 = second;
      int num727 = num725;
      int num728 = num727 + 1;
      int index242 = num727;
      int num729 = (int) numArray1[this.ucScreenLED1.LEDA6 * 3 + 1];
      numArray243[index242] = (byte) num729;
      byte[] numArray244 = second;
      int num730 = num728;
      int num731 = num730 + 1;
      int index243 = num730;
      int num732 = (int) numArray1[this.ucScreenLED1.LEDA6 * 3 + 2];
      numArray244[index243] = (byte) num732;
      byte[] numArray245 = second;
      int num733 = num731;
      int num734 = num733 + 1;
      int index244 = num733;
      int num735 = (int) numArray1[this.ucScreenLED1.LEDF6 * 3];
      numArray245[index244] = (byte) num735;
      byte[] numArray246 = second;
      int num736 = num734;
      int num737 = num736 + 1;
      int index245 = num736;
      int num738 = (int) numArray1[this.ucScreenLED1.LEDF6 * 3 + 1];
      numArray246[index245] = (byte) num738;
      byte[] numArray247 = second;
      int num739 = num737;
      int num740 = num739 + 1;
      int index246 = num739;
      int num741 = (int) numArray1[this.ucScreenLED1.LEDF6 * 3 + 2];
      numArray247[index246] = (byte) num741;
      byte[] numArray248 = second;
      int num742 = num740;
      int num743 = num742 + 1;
      int index247 = num742;
      int num744 = (int) numArray1[this.ucScreenLED1.Gpu1 * 3];
      numArray248[index247] = (byte) num744;
      byte[] numArray249 = second;
      int num745 = num743;
      int num746 = num745 + 1;
      int index248 = num745;
      int num747 = (int) numArray1[this.ucScreenLED1.Gpu1 * 3 + 1];
      numArray249[index248] = (byte) num747;
      byte[] numArray250 = second;
      int num748 = num746;
      int num749 = num748 + 1;
      int index249 = num748;
      int num750 = (int) numArray1[this.ucScreenLED1.Gpu1 * 3 + 2];
      numArray250[index249] = (byte) num750;
      byte[] numArray251 = second;
      int num751 = num749;
      int num752 = num751 + 1;
      int index250 = num751;
      int num753 = (int) numArray1[this.ucScreenLED1.Gpu2 * 3];
      numArray251[index250] = (byte) num753;
      byte[] numArray252 = second;
      int num754 = num752;
      int num755 = num754 + 1;
      int index251 = num754;
      int num756 = (int) numArray1[this.ucScreenLED1.Gpu2 * 3 + 1];
      numArray252[index251] = (byte) num756;
      byte[] numArray253 = second;
      int num757 = num755;
      int num758 = num757 + 1;
      int index252 = num757;
      int num759 = (int) numArray1[this.ucScreenLED1.Gpu2 * 3 + 2];
      numArray253[index252] = (byte) num759;
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 3)
    {
      byte[] numArray254 = new byte[192 /*0xC0*/];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray254.Length,
        (byte) 0,
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 64 /*0x40*/; ++index)
      {
        if (this.myOnOff == (byte) 0)
        {
          numArray254[index * 3] = (byte) 0;
          numArray254[index * 3 + 1] = (byte) 0;
          numArray254[index * 3 + 2] = (byte) 0;
        }
        else if (this.ucScreenLED1.isOn[index])
        {
          numArray254[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2 + (double) num1);
          numArray254[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2 + (double) num1);
          numArray254[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2 + (double) num1);
        }
        else
        {
          numArray254[index * 3] = (byte) 0;
          numArray254[index * 3 + 1] = (byte) 0;
          numArray254[index * 3 + 2] = (byte) 0;
        }
      }
      int num760 = 0;
      byte[] second = new byte[numArray254.Length];
      byte[] numArray255 = second;
      int num761 = num760;
      int num762 = num761 + 1;
      int index253 = num761;
      int num763 = (int) numArray254[this.ucScreenLED1.WATT * 3];
      numArray255[index253] = (byte) num763;
      byte[] numArray256 = second;
      int num764 = num762;
      int num765 = num764 + 1;
      int index254 = num764;
      int num766 = (int) numArray254[this.ucScreenLED1.WATT * 3 + 1];
      numArray256[index254] = (byte) num766;
      byte[] numArray257 = second;
      int num767 = num765;
      int num768 = num767 + 1;
      int index255 = num767;
      int num769 = (int) numArray254[this.ucScreenLED1.WATT * 3 + 2];
      numArray257[index255] = (byte) num769;
      byte[] numArray258 = second;
      int num770 = num768;
      int num771 = num770 + 1;
      int index256 = num770;
      int num772 = (int) numArray254[this.ucScreenLED1.LEDC3 * 3];
      numArray258[index256] = (byte) num772;
      byte[] numArray259 = second;
      int num773 = num771;
      int num774 = num773 + 1;
      int index257 = num773;
      int num775 = (int) numArray254[this.ucScreenLED1.LEDC3 * 3 + 1];
      numArray259[index257] = (byte) num775;
      byte[] numArray260 = second;
      int num776 = num774;
      int num777 = num776 + 1;
      int index258 = num776;
      int num778 = (int) numArray254[this.ucScreenLED1.LEDC3 * 3 + 2];
      numArray260[index258] = (byte) num778;
      byte[] numArray261 = second;
      int num779 = num777;
      int num780 = num779 + 1;
      int index259 = num779;
      int num781 = (int) numArray254[this.ucScreenLED1.LEDD3 * 3];
      numArray261[index259] = (byte) num781;
      byte[] numArray262 = second;
      int num782 = num780;
      int num783 = num782 + 1;
      int index260 = num782;
      int num784 = (int) numArray254[this.ucScreenLED1.LEDD3 * 3 + 1];
      numArray262[index260] = (byte) num784;
      byte[] numArray263 = second;
      int num785 = num783;
      int num786 = num785 + 1;
      int index261 = num785;
      int num787 = (int) numArray254[this.ucScreenLED1.LEDD3 * 3 + 2];
      numArray263[index261] = (byte) num787;
      byte[] numArray264 = second;
      int num788 = num786;
      int num789 = num788 + 1;
      int index262 = num788;
      int num790 = (int) numArray254[this.ucScreenLED1.LEDE3 * 3];
      numArray264[index262] = (byte) num790;
      byte[] numArray265 = second;
      int num791 = num789;
      int num792 = num791 + 1;
      int index263 = num791;
      int num793 = (int) numArray254[this.ucScreenLED1.LEDE3 * 3 + 1];
      numArray265[index263] = (byte) num793;
      byte[] numArray266 = second;
      int num794 = num792;
      int num795 = num794 + 1;
      int index264 = num794;
      int num796 = (int) numArray254[this.ucScreenLED1.LEDE3 * 3 + 2];
      numArray266[index264] = (byte) num796;
      byte[] numArray267 = second;
      int num797 = num795;
      int num798 = num797 + 1;
      int index265 = num797;
      int num799 = (int) numArray254[this.ucScreenLED1.LEDG3 * 3];
      numArray267[index265] = (byte) num799;
      byte[] numArray268 = second;
      int num800 = num798;
      int num801 = num800 + 1;
      int index266 = num800;
      int num802 = (int) numArray254[this.ucScreenLED1.LEDG3 * 3 + 1];
      numArray268[index266] = (byte) num802;
      byte[] numArray269 = second;
      int num803 = num801;
      int num804 = num803 + 1;
      int index267 = num803;
      int num805 = (int) numArray254[this.ucScreenLED1.LEDG3 * 3 + 2];
      numArray269[index267] = (byte) num805;
      byte[] numArray270 = second;
      int num806 = num804;
      int num807 = num806 + 1;
      int index268 = num806;
      int num808 = (int) numArray254[this.ucScreenLED1.LEDB3 * 3];
      numArray270[index268] = (byte) num808;
      byte[] numArray271 = second;
      int num809 = num807;
      int num810 = num809 + 1;
      int index269 = num809;
      int num811 = (int) numArray254[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray271[index269] = (byte) num811;
      byte[] numArray272 = second;
      int num812 = num810;
      int num813 = num812 + 1;
      int index270 = num812;
      int num814 = (int) numArray254[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray272[index270] = (byte) num814;
      byte[] numArray273 = second;
      int num815 = num813;
      int num816 = num815 + 1;
      int index271 = num815;
      int num817 = (int) numArray254[this.ucScreenLED1.LEDA3 * 3];
      numArray273[index271] = (byte) num817;
      byte[] numArray274 = second;
      int num818 = num816;
      int num819 = num818 + 1;
      int index272 = num818;
      int num820 = (int) numArray254[this.ucScreenLED1.LEDA3 * 3 + 1];
      numArray274[index272] = (byte) num820;
      byte[] numArray275 = second;
      int num821 = num819;
      int num822 = num821 + 1;
      int index273 = num821;
      int num823 = (int) numArray254[this.ucScreenLED1.LEDA3 * 3 + 2];
      numArray275[index273] = (byte) num823;
      byte[] numArray276 = second;
      int num824 = num822;
      int num825 = num824 + 1;
      int index274 = num824;
      int num826 = (int) numArray254[this.ucScreenLED1.LEDF3 * 3];
      numArray276[index274] = (byte) num826;
      byte[] numArray277 = second;
      int num827 = num825;
      int num828 = num827 + 1;
      int index275 = num827;
      int num829 = (int) numArray254[this.ucScreenLED1.LEDF3 * 3 + 1];
      numArray277[index275] = (byte) num829;
      byte[] numArray278 = second;
      int num830 = num828;
      int num831 = num830 + 1;
      int index276 = num830;
      int num832 = (int) numArray254[this.ucScreenLED1.LEDF3 * 3 + 2];
      numArray278[index276] = (byte) num832;
      byte[] numArray279 = second;
      int num833 = num831;
      int num834 = num833 + 1;
      int index277 = num833;
      int num835 = (int) numArray254[this.ucScreenLED1.LEDB2 * 3];
      numArray279[index277] = (byte) num835;
      byte[] numArray280 = second;
      int num836 = num834;
      int num837 = num836 + 1;
      int index278 = num836;
      int num838 = (int) numArray254[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray280[index278] = (byte) num838;
      byte[] numArray281 = second;
      int num839 = num837;
      int num840 = num839 + 1;
      int index279 = num839;
      int num841 = (int) numArray254[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray281[index279] = (byte) num841;
      byte[] numArray282 = second;
      int num842 = num840;
      int num843 = num842 + 1;
      int index280 = num842;
      int num844 = (int) numArray254[this.ucScreenLED1.Cpu1 * 3];
      numArray282[index280] = (byte) num844;
      byte[] numArray283 = second;
      int num845 = num843;
      int num846 = num845 + 1;
      int index281 = num845;
      int num847 = (int) numArray254[this.ucScreenLED1.Cpu1 * 3 + 1];
      numArray283[index281] = (byte) num847;
      byte[] numArray284 = second;
      int num848 = num846;
      int num849 = num848 + 1;
      int index282 = num848;
      int num850 = (int) numArray254[this.ucScreenLED1.Cpu1 * 3 + 2];
      numArray284[index282] = (byte) num850;
      byte[] numArray285 = second;
      int num851 = num849;
      int num852 = num851 + 1;
      int index283 = num851;
      int num853 = (int) numArray254[this.ucScreenLED1.LEDA2 * 3];
      numArray285[index283] = (byte) num853;
      byte[] numArray286 = second;
      int num854 = num852;
      int num855 = num854 + 1;
      int index284 = num854;
      int num856 = (int) numArray254[this.ucScreenLED1.LEDA2 * 3 + 1];
      numArray286[index284] = (byte) num856;
      byte[] numArray287 = second;
      int num857 = num855;
      int num858 = num857 + 1;
      int index285 = num857;
      int num859 = (int) numArray254[this.ucScreenLED1.LEDA2 * 3 + 2];
      numArray287[index285] = (byte) num859;
      byte[] numArray288 = second;
      int num860 = num858;
      int num861 = num860 + 1;
      int index286 = num860;
      int num862 = (int) numArray254[this.ucScreenLED1.LEDF2 * 3];
      numArray288[index286] = (byte) num862;
      byte[] numArray289 = second;
      int num863 = num861;
      int num864 = num863 + 1;
      int index287 = num863;
      int num865 = (int) numArray254[this.ucScreenLED1.LEDF2 * 3 + 1];
      numArray289[index287] = (byte) num865;
      byte[] numArray290 = second;
      int num866 = num864;
      int num867 = num866 + 1;
      int index288 = num866;
      int num868 = (int) numArray254[this.ucScreenLED1.LEDF2 * 3 + 2];
      numArray290[index288] = (byte) num868;
      byte[] numArray291 = second;
      int num869 = num867;
      int num870 = num869 + 1;
      int index289 = num869;
      int num871 = (int) numArray254[this.ucScreenLED1.LEDG2 * 3];
      numArray291[index289] = (byte) num871;
      byte[] numArray292 = second;
      int num872 = num870;
      int num873 = num872 + 1;
      int index290 = num872;
      int num874 = (int) numArray254[this.ucScreenLED1.LEDG2 * 3 + 1];
      numArray292[index290] = (byte) num874;
      byte[] numArray293 = second;
      int num875 = num873;
      int num876 = num875 + 1;
      int index291 = num875;
      int num877 = (int) numArray254[this.ucScreenLED1.LEDG2 * 3 + 2];
      numArray293[index291] = (byte) num877;
      byte[] numArray294 = second;
      int num878 = num876;
      int num879 = num878 + 1;
      int index292 = num878;
      int num880 = (int) numArray254[this.ucScreenLED1.LEDC2 * 3];
      numArray294[index292] = (byte) num880;
      byte[] numArray295 = second;
      int num881 = num879;
      int num882 = num881 + 1;
      int index293 = num881;
      int num883 = (int) numArray254[this.ucScreenLED1.LEDC2 * 3 + 1];
      numArray295[index293] = (byte) num883;
      byte[] numArray296 = second;
      int num884 = num882;
      int num885 = num884 + 1;
      int index294 = num884;
      int num886 = (int) numArray254[this.ucScreenLED1.LEDC2 * 3 + 2];
      numArray296[index294] = (byte) num886;
      byte[] numArray297 = second;
      int num887 = num885;
      int num888 = num887 + 1;
      int index295 = num887;
      int num889 = (int) numArray254[this.ucScreenLED1.LEDD2 * 3];
      numArray297[index295] = (byte) num889;
      byte[] numArray298 = second;
      int num890 = num888;
      int num891 = num890 + 1;
      int index296 = num890;
      int num892 = (int) numArray254[this.ucScreenLED1.LEDD2 * 3 + 1];
      numArray298[index296] = (byte) num892;
      byte[] numArray299 = second;
      int num893 = num891;
      int num894 = num893 + 1;
      int index297 = num893;
      int num895 = (int) numArray254[this.ucScreenLED1.LEDD2 * 3 + 2];
      numArray299[index297] = (byte) num895;
      byte[] numArray300 = second;
      int num896 = num894;
      int num897 = num896 + 1;
      int index298 = num896;
      int num898 = (int) numArray254[this.ucScreenLED1.LEDE2 * 3];
      numArray300[index298] = (byte) num898;
      byte[] numArray301 = second;
      int num899 = num897;
      int num900 = num899 + 1;
      int index299 = num899;
      int num901 = (int) numArray254[this.ucScreenLED1.LEDE2 * 3 + 1];
      numArray301[index299] = (byte) num901;
      byte[] numArray302 = second;
      int num902 = num900;
      int num903 = num902 + 1;
      int index300 = num902;
      int num904 = (int) numArray254[this.ucScreenLED1.LEDE2 * 3 + 2];
      numArray302[index300] = (byte) num904;
      byte[] numArray303 = second;
      int num905 = num903;
      int num906 = num905 + 1;
      int index301 = num905;
      int num907 = (int) numArray254[this.ucScreenLED1.LEDB1 * 3];
      numArray303[index301] = (byte) num907;
      byte[] numArray304 = second;
      int num908 = num906;
      int num909 = num908 + 1;
      int index302 = num908;
      int num910 = (int) numArray254[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray304[index302] = (byte) num910;
      byte[] numArray305 = second;
      int num911 = num909;
      int num912 = num911 + 1;
      int index303 = num911;
      int num913 = (int) numArray254[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray305[index303] = (byte) num913;
      byte[] numArray306 = second;
      int num914 = num912;
      int num915 = num914 + 1;
      int index304 = num914;
      int num916 = (int) numArray254[this.ucScreenLED1.LEDA1 * 3];
      numArray306[index304] = (byte) num916;
      byte[] numArray307 = second;
      int num917 = num915;
      int num918 = num917 + 1;
      int index305 = num917;
      int num919 = (int) numArray254[this.ucScreenLED1.LEDA1 * 3 + 1];
      numArray307[index305] = (byte) num919;
      byte[] numArray308 = second;
      int num920 = num918;
      int num921 = num920 + 1;
      int index306 = num920;
      int num922 = (int) numArray254[this.ucScreenLED1.LEDA1 * 3 + 2];
      numArray308[index306] = (byte) num922;
      byte[] numArray309 = second;
      int num923 = num921;
      int num924 = num923 + 1;
      int index307 = num923;
      int num925 = (int) numArray254[this.ucScreenLED1.LEDF1 * 3];
      numArray309[index307] = (byte) num925;
      byte[] numArray310 = second;
      int num926 = num924;
      int num927 = num926 + 1;
      int index308 = num926;
      int num928 = (int) numArray254[this.ucScreenLED1.LEDF1 * 3 + 1];
      numArray310[index308] = (byte) num928;
      byte[] numArray311 = second;
      int num929 = num927;
      int num930 = num929 + 1;
      int index309 = num929;
      int num931 = (int) numArray254[this.ucScreenLED1.LEDF1 * 3 + 2];
      numArray311[index309] = (byte) num931;
      byte[] numArray312 = second;
      int num932 = num930;
      int num933 = num932 + 1;
      int index310 = num932;
      int num934 = (int) numArray254[this.ucScreenLED1.LEDG1 * 3];
      numArray312[index310] = (byte) num934;
      byte[] numArray313 = second;
      int num935 = num933;
      int num936 = num935 + 1;
      int index311 = num935;
      int num937 = (int) numArray254[this.ucScreenLED1.LEDG1 * 3 + 1];
      numArray313[index311] = (byte) num937;
      byte[] numArray314 = second;
      int num938 = num936;
      int num939 = num938 + 1;
      int index312 = num938;
      int num940 = (int) numArray254[this.ucScreenLED1.LEDG1 * 3 + 2];
      numArray314[index312] = (byte) num940;
      byte[] numArray315 = second;
      int num941 = num939;
      int num942 = num941 + 1;
      int index313 = num941;
      int num943 = (int) numArray254[this.ucScreenLED1.LEDC1 * 3];
      numArray315[index313] = (byte) num943;
      byte[] numArray316 = second;
      int num944 = num942;
      int num945 = num944 + 1;
      int index314 = num944;
      int num946 = (int) numArray254[this.ucScreenLED1.LEDC1 * 3 + 1];
      numArray316[index314] = (byte) num946;
      byte[] numArray317 = second;
      int num947 = num945;
      int num948 = num947 + 1;
      int index315 = num947;
      int num949 = (int) numArray254[this.ucScreenLED1.LEDC1 * 3 + 2];
      numArray317[index315] = (byte) num949;
      byte[] numArray318 = second;
      int num950 = num948;
      int num951 = num950 + 1;
      int index316 = num950;
      int num952 = (int) numArray254[this.ucScreenLED1.LEDD1 * 3];
      numArray318[index316] = (byte) num952;
      byte[] numArray319 = second;
      int num953 = num951;
      int num954 = num953 + 1;
      int index317 = num953;
      int num955 = (int) numArray254[this.ucScreenLED1.LEDD1 * 3 + 1];
      numArray319[index317] = (byte) num955;
      byte[] numArray320 = second;
      int num956 = num954;
      int num957 = num956 + 1;
      int index318 = num956;
      int num958 = (int) numArray254[this.ucScreenLED1.LEDD1 * 3 + 2];
      numArray320[index318] = (byte) num958;
      byte[] numArray321 = second;
      int num959 = num957;
      int num960 = num959 + 1;
      int index319 = num959;
      int num961 = (int) numArray254[this.ucScreenLED1.LEDE1 * 3];
      numArray321[index319] = (byte) num961;
      byte[] numArray322 = second;
      int num962 = num960;
      int num963 = num962 + 1;
      int index320 = num962;
      int num964 = (int) numArray254[this.ucScreenLED1.LEDE1 * 3 + 1];
      numArray322[index320] = (byte) num964;
      byte[] numArray323 = second;
      int num965 = num963;
      int num966 = num965 + 1;
      int index321 = num965;
      int num967 = (int) numArray254[this.ucScreenLED1.LEDE1 * 3 + 2];
      numArray323[index321] = (byte) num967;
      byte[] numArray324 = second;
      int num968 = num966;
      int num969 = num968 + 1;
      int index322 = num968;
      int num970 = (int) numArray254[this.ucScreenLED1.LEDF4 * 3];
      numArray324[index322] = (byte) num970;
      byte[] numArray325 = second;
      int num971 = num969;
      int num972 = num971 + 1;
      int index323 = num971;
      int num973 = (int) numArray254[this.ucScreenLED1.LEDF4 * 3 + 1];
      numArray325[index323] = (byte) num973;
      byte[] numArray326 = second;
      int num974 = num972;
      int num975 = num974 + 1;
      int index324 = num974;
      int num976 = (int) numArray254[this.ucScreenLED1.LEDF4 * 3 + 2];
      numArray326[index324] = (byte) num976;
      byte[] numArray327 = second;
      int num977 = num975;
      int num978 = num977 + 1;
      int index325 = num977;
      int num979 = (int) numArray254[this.ucScreenLED1.LEDA4 * 3];
      numArray327[index325] = (byte) num979;
      byte[] numArray328 = second;
      int num980 = num978;
      int num981 = num980 + 1;
      int index326 = num980;
      int num982 = (int) numArray254[this.ucScreenLED1.LEDA4 * 3 + 1];
      numArray328[index326] = (byte) num982;
      byte[] numArray329 = second;
      int num983 = num981;
      int num984 = num983 + 1;
      int index327 = num983;
      int num985 = (int) numArray254[this.ucScreenLED1.LEDA4 * 3 + 2];
      numArray329[index327] = (byte) num985;
      byte[] numArray330 = second;
      int num986 = num984;
      int num987 = num986 + 1;
      int index328 = num986;
      int num988 = (int) numArray254[this.ucScreenLED1.LEDB4 * 3];
      numArray330[index328] = (byte) num988;
      byte[] numArray331 = second;
      int num989 = num987;
      int num990 = num989 + 1;
      int index329 = num989;
      int num991 = (int) numArray254[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray331[index329] = (byte) num991;
      byte[] numArray332 = second;
      int num992 = num990;
      int num993 = num992 + 1;
      int index330 = num992;
      int num994 = (int) numArray254[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray332[index330] = (byte) num994;
      byte[] numArray333 = second;
      int num995 = num993;
      int num996 = num995 + 1;
      int index331 = num995;
      int num997 = (int) numArray254[this.ucScreenLED1.LEDG4 * 3];
      numArray333[index331] = (byte) num997;
      byte[] numArray334 = second;
      int num998 = num996;
      int num999 = num998 + 1;
      int index332 = num998;
      int num1000 = (int) numArray254[this.ucScreenLED1.LEDG4 * 3 + 1];
      numArray334[index332] = (byte) num1000;
      byte[] numArray335 = second;
      int num1001 = num999;
      int num1002 = num1001 + 1;
      int index333 = num1001;
      int num1003 = (int) numArray254[this.ucScreenLED1.LEDG4 * 3 + 2];
      numArray335[index333] = (byte) num1003;
      byte[] numArray336 = second;
      int num1004 = num1002;
      int num1005 = num1004 + 1;
      int index334 = num1004;
      int num1006 = (int) numArray254[this.ucScreenLED1.LEDE4 * 3];
      numArray336[index334] = (byte) num1006;
      byte[] numArray337 = second;
      int num1007 = num1005;
      int num1008 = num1007 + 1;
      int index335 = num1007;
      int num1009 = (int) numArray254[this.ucScreenLED1.LEDE4 * 3 + 1];
      numArray337[index335] = (byte) num1009;
      byte[] numArray338 = second;
      int num1010 = num1008;
      int num1011 = num1010 + 1;
      int index336 = num1010;
      int num1012 = (int) numArray254[this.ucScreenLED1.LEDE4 * 3 + 2];
      numArray338[index336] = (byte) num1012;
      byte[] numArray339 = second;
      int num1013 = num1011;
      int num1014 = num1013 + 1;
      int index337 = num1013;
      int num1015 = (int) numArray254[this.ucScreenLED1.LEDD4 * 3];
      numArray339[index337] = (byte) num1015;
      byte[] numArray340 = second;
      int num1016 = num1014;
      int num1017 = num1016 + 1;
      int index338 = num1016;
      int num1018 = (int) numArray254[this.ucScreenLED1.LEDD4 * 3 + 1];
      numArray340[index338] = (byte) num1018;
      byte[] numArray341 = second;
      int num1019 = num1017;
      int num1020 = num1019 + 1;
      int index339 = num1019;
      int num1021 = (int) numArray254[this.ucScreenLED1.LEDD4 * 3 + 2];
      numArray341[index339] = (byte) num1021;
      byte[] numArray342 = second;
      int num1022 = num1020;
      int num1023 = num1022 + 1;
      int index340 = num1022;
      int num1024 = (int) numArray254[this.ucScreenLED1.LEDC4 * 3];
      numArray342[index340] = (byte) num1024;
      byte[] numArray343 = second;
      int num1025 = num1023;
      int num1026 = num1025 + 1;
      int index341 = num1025;
      int num1027 = (int) numArray254[this.ucScreenLED1.LEDC4 * 3 + 1];
      numArray343[index341] = (byte) num1027;
      byte[] numArray344 = second;
      int num1028 = num1026;
      int num1029 = num1028 + 1;
      int index342 = num1028;
      int num1030 = (int) numArray254[this.ucScreenLED1.LEDC4 * 3 + 2];
      numArray344[index342] = (byte) num1030;
      byte[] numArray345 = second;
      int num1031 = num1029;
      int num1032 = num1031 + 1;
      int index343 = num1031;
      int num1033 = (int) numArray254[this.ucScreenLED1.LEDF5 * 3];
      numArray345[index343] = (byte) num1033;
      byte[] numArray346 = second;
      int num1034 = num1032;
      int num1035 = num1034 + 1;
      int index344 = num1034;
      int num1036 = (int) numArray254[this.ucScreenLED1.LEDF5 * 3 + 1];
      numArray346[index344] = (byte) num1036;
      byte[] numArray347 = second;
      int num1037 = num1035;
      int num1038 = num1037 + 1;
      int index345 = num1037;
      int num1039 = (int) numArray254[this.ucScreenLED1.LEDF5 * 3 + 2];
      numArray347[index345] = (byte) num1039;
      byte[] numArray348 = second;
      int num1040 = num1038;
      int num1041 = num1040 + 1;
      int index346 = num1040;
      int num1042 = (int) numArray254[this.ucScreenLED1.LEDA5 * 3];
      numArray348[index346] = (byte) num1042;
      byte[] numArray349 = second;
      int num1043 = num1041;
      int num1044 = num1043 + 1;
      int index347 = num1043;
      int num1045 = (int) numArray254[this.ucScreenLED1.LEDA5 * 3 + 1];
      numArray349[index347] = (byte) num1045;
      byte[] numArray350 = second;
      int num1046 = num1044;
      int num1047 = num1046 + 1;
      int index348 = num1046;
      int num1048 = (int) numArray254[this.ucScreenLED1.LEDA5 * 3 + 2];
      numArray350[index348] = (byte) num1048;
      byte[] numArray351 = second;
      int num1049 = num1047;
      int num1050 = num1049 + 1;
      int index349 = num1049;
      int num1051 = (int) numArray254[this.ucScreenLED1.LEDB5 * 3];
      numArray351[index349] = (byte) num1051;
      byte[] numArray352 = second;
      int num1052 = num1050;
      int num1053 = num1052 + 1;
      int index350 = num1052;
      int num1054 = (int) numArray254[this.ucScreenLED1.LEDB5 * 3 + 1];
      numArray352[index350] = (byte) num1054;
      byte[] numArray353 = second;
      int num1055 = num1053;
      int num1056 = num1055 + 1;
      int index351 = num1055;
      int num1057 = (int) numArray254[this.ucScreenLED1.LEDB5 * 3 + 2];
      numArray353[index351] = (byte) num1057;
      byte[] numArray354 = second;
      int num1058 = num1056;
      int num1059 = num1058 + 1;
      int index352 = num1058;
      int num1060 = (int) numArray254[this.ucScreenLED1.LEDG5 * 3];
      numArray354[index352] = (byte) num1060;
      byte[] numArray355 = second;
      int num1061 = num1059;
      int num1062 = num1061 + 1;
      int index353 = num1061;
      int num1063 = (int) numArray254[this.ucScreenLED1.LEDG5 * 3 + 1];
      numArray355[index353] = (byte) num1063;
      byte[] numArray356 = second;
      int num1064 = num1062;
      int num1065 = num1064 + 1;
      int index354 = num1064;
      int num1066 = (int) numArray254[this.ucScreenLED1.LEDG5 * 3 + 2];
      numArray356[index354] = (byte) num1066;
      byte[] numArray357 = second;
      int num1067 = num1065;
      int num1068 = num1067 + 1;
      int index355 = num1067;
      int num1069 = (int) numArray254[this.ucScreenLED1.LEDE5 * 3];
      numArray357[index355] = (byte) num1069;
      byte[] numArray358 = second;
      int num1070 = num1068;
      int num1071 = num1070 + 1;
      int index356 = num1070;
      int num1072 = (int) numArray254[this.ucScreenLED1.LEDE5 * 3 + 1];
      numArray358[index356] = (byte) num1072;
      byte[] numArray359 = second;
      int num1073 = num1071;
      int num1074 = num1073 + 1;
      int index357 = num1073;
      int num1075 = (int) numArray254[this.ucScreenLED1.LEDE5 * 3 + 2];
      numArray359[index357] = (byte) num1075;
      byte[] numArray360 = second;
      int num1076 = num1074;
      int num1077 = num1076 + 1;
      int index358 = num1076;
      int num1078 = (int) numArray254[this.ucScreenLED1.LEDD5 * 3];
      numArray360[index358] = (byte) num1078;
      byte[] numArray361 = second;
      int num1079 = num1077;
      int num1080 = num1079 + 1;
      int index359 = num1079;
      int num1081 = (int) numArray254[this.ucScreenLED1.LEDD5 * 3 + 1];
      numArray361[index359] = (byte) num1081;
      byte[] numArray362 = second;
      int num1082 = num1080;
      int num1083 = num1082 + 1;
      int index360 = num1082;
      int num1084 = (int) numArray254[this.ucScreenLED1.LEDD5 * 3 + 2];
      numArray362[index360] = (byte) num1084;
      byte[] numArray363 = second;
      int num1085 = num1083;
      int num1086 = num1085 + 1;
      int index361 = num1085;
      int num1087 = (int) numArray254[this.ucScreenLED1.LEDC5 * 3];
      numArray363[index361] = (byte) num1087;
      byte[] numArray364 = second;
      int num1088 = num1086;
      int num1089 = num1088 + 1;
      int index362 = num1088;
      int num1090 = (int) numArray254[this.ucScreenLED1.LEDC5 * 3 + 1];
      numArray364[index362] = (byte) num1090;
      byte[] numArray365 = second;
      int num1091 = num1089;
      int num1092 = num1091 + 1;
      int index363 = num1091;
      int num1093 = (int) numArray254[this.ucScreenLED1.LEDC5 * 3 + 2];
      numArray365[index363] = (byte) num1093;
      byte[] numArray366 = second;
      int num1094 = num1092;
      int num1095 = num1094 + 1;
      int index364 = num1094;
      int num1096 = (int) numArray254[this.ucScreenLED1.LEDF6 * 3];
      numArray366[index364] = (byte) num1096;
      byte[] numArray367 = second;
      int num1097 = num1095;
      int num1098 = num1097 + 1;
      int index365 = num1097;
      int num1099 = (int) numArray254[this.ucScreenLED1.LEDF6 * 3 + 1];
      numArray367[index365] = (byte) num1099;
      byte[] numArray368 = second;
      int num1100 = num1098;
      int num1101 = num1100 + 1;
      int index366 = num1100;
      int num1102 = (int) numArray254[this.ucScreenLED1.LEDF6 * 3 + 2];
      numArray368[index366] = (byte) num1102;
      byte[] numArray369 = second;
      int num1103 = num1101;
      int num1104 = num1103 + 1;
      int index367 = num1103;
      int num1105 = (int) numArray254[this.ucScreenLED1.LEDA6 * 3];
      numArray369[index367] = (byte) num1105;
      byte[] numArray370 = second;
      int num1106 = num1104;
      int num1107 = num1106 + 1;
      int index368 = num1106;
      int num1108 = (int) numArray254[this.ucScreenLED1.LEDA6 * 3 + 1];
      numArray370[index368] = (byte) num1108;
      byte[] numArray371 = second;
      int num1109 = num1107;
      int num1110 = num1109 + 1;
      int index369 = num1109;
      int num1111 = (int) numArray254[this.ucScreenLED1.LEDA6 * 3 + 2];
      numArray371[index369] = (byte) num1111;
      byte[] numArray372 = second;
      int num1112 = num1110;
      int num1113 = num1112 + 1;
      int index370 = num1112;
      int num1114 = (int) numArray254[this.ucScreenLED1.LEDB6 * 3];
      numArray372[index370] = (byte) num1114;
      byte[] numArray373 = second;
      int num1115 = num1113;
      int num1116 = num1115 + 1;
      int index371 = num1115;
      int num1117 = (int) numArray254[this.ucScreenLED1.LEDB6 * 3 + 1];
      numArray373[index371] = (byte) num1117;
      byte[] numArray374 = second;
      int num1118 = num1116;
      int num1119 = num1118 + 1;
      int index372 = num1118;
      int num1120 = (int) numArray254[this.ucScreenLED1.LEDB6 * 3 + 2];
      numArray374[index372] = (byte) num1120;
      byte[] numArray375 = second;
      int num1121 = num1119;
      int num1122 = num1121 + 1;
      int index373 = num1121;
      int num1123 = (int) numArray254[this.ucScreenLED1.LEDG6 * 3];
      numArray375[index373] = (byte) num1123;
      byte[] numArray376 = second;
      int num1124 = num1122;
      int num1125 = num1124 + 1;
      int index374 = num1124;
      int num1126 = (int) numArray254[this.ucScreenLED1.LEDG6 * 3 + 1];
      numArray376[index374] = (byte) num1126;
      byte[] numArray377 = second;
      int num1127 = num1125;
      int num1128 = num1127 + 1;
      int index375 = num1127;
      int num1129 = (int) numArray254[this.ucScreenLED1.LEDG6 * 3 + 2];
      numArray377[index375] = (byte) num1129;
      byte[] numArray378 = second;
      int num1130 = num1128;
      int num1131 = num1130 + 1;
      int index376 = num1130;
      int num1132 = (int) numArray254[this.ucScreenLED1.LEDE6 * 3];
      numArray378[index376] = (byte) num1132;
      byte[] numArray379 = second;
      int num1133 = num1131;
      int num1134 = num1133 + 1;
      int index377 = num1133;
      int num1135 = (int) numArray254[this.ucScreenLED1.LEDE6 * 3 + 1];
      numArray379[index377] = (byte) num1135;
      byte[] numArray380 = second;
      int num1136 = num1134;
      int num1137 = num1136 + 1;
      int index378 = num1136;
      int num1138 = (int) numArray254[this.ucScreenLED1.LEDE6 * 3 + 2];
      numArray380[index378] = (byte) num1138;
      byte[] numArray381 = second;
      int num1139 = num1137;
      int num1140 = num1139 + 1;
      int index379 = num1139;
      int num1141 = (int) numArray254[this.ucScreenLED1.LEDD6 * 3];
      numArray381[index379] = (byte) num1141;
      byte[] numArray382 = second;
      int num1142 = num1140;
      int num1143 = num1142 + 1;
      int index380 = num1142;
      int num1144 = (int) numArray254[this.ucScreenLED1.LEDD6 * 3 + 1];
      numArray382[index380] = (byte) num1144;
      byte[] numArray383 = second;
      int num1145 = num1143;
      int num1146 = num1145 + 1;
      int index381 = num1145;
      int num1147 = (int) numArray254[this.ucScreenLED1.LEDD6 * 3 + 2];
      numArray383[index381] = (byte) num1147;
      byte[] numArray384 = second;
      int num1148 = num1146;
      int num1149 = num1148 + 1;
      int index382 = num1148;
      int num1150 = (int) numArray254[this.ucScreenLED1.LEDC6 * 3];
      numArray384[index382] = (byte) num1150;
      byte[] numArray385 = second;
      int num1151 = num1149;
      int num1152 = num1151 + 1;
      int index383 = num1151;
      int num1153 = (int) numArray254[this.ucScreenLED1.LEDC6 * 3 + 1];
      numArray385[index383] = (byte) num1153;
      byte[] numArray386 = second;
      int num1154 = num1152;
      int num1155 = num1154 + 1;
      int index384 = num1154;
      int num1156 = (int) numArray254[this.ucScreenLED1.LEDC6 * 3 + 2];
      numArray386[index384] = (byte) num1156;
      byte[] numArray387 = second;
      int num1157 = num1155;
      int num1158 = num1157 + 1;
      int index385 = num1157;
      int num1159 = (int) numArray254[this.ucScreenLED1.SSD * 3];
      numArray387[index385] = (byte) num1159;
      byte[] numArray388 = second;
      int num1160 = num1158;
      int num1161 = num1160 + 1;
      int index386 = num1160;
      int num1162 = (int) numArray254[this.ucScreenLED1.SSD * 3 + 1];
      numArray388[index386] = (byte) num1162;
      byte[] numArray389 = second;
      int num1163 = num1161;
      int num1164 = num1163 + 1;
      int index387 = num1163;
      int num1165 = (int) numArray254[this.ucScreenLED1.SSD * 3 + 2];
      numArray389[index387] = (byte) num1165;
      byte[] numArray390 = second;
      int num1166 = num1164;
      int num1167 = num1166 + 1;
      int index388 = num1166;
      int num1168 = (int) numArray254[this.ucScreenLED1.HSD * 3];
      numArray390[index388] = (byte) num1168;
      byte[] numArray391 = second;
      int num1169 = num1167;
      int num1170 = num1169 + 1;
      int index389 = num1169;
      int num1171 = (int) numArray254[this.ucScreenLED1.HSD * 3 + 1];
      numArray391[index389] = (byte) num1171;
      byte[] numArray392 = second;
      int num1172 = num1170;
      int num1173 = num1172 + 1;
      int index390 = num1172;
      int num1174 = (int) numArray254[this.ucScreenLED1.HSD * 3 + 2];
      numArray392[index390] = (byte) num1174;
      byte[] numArray393 = second;
      int num1175 = num1173;
      int num1176 = num1175 + 1;
      int index391 = num1175;
      int num1177 = (int) numArray254[this.ucScreenLED1.BFB * 3];
      numArray393[index391] = (byte) num1177;
      byte[] numArray394 = second;
      int num1178 = num1176;
      int num1179 = num1178 + 1;
      int index392 = num1178;
      int num1180 = (int) numArray254[this.ucScreenLED1.BFB * 3 + 1];
      numArray394[index392] = (byte) num1180;
      byte[] numArray395 = second;
      int num1181 = num1179;
      int num1182 = num1181 + 1;
      int index393 = num1181;
      int num1183 = (int) numArray254[this.ucScreenLED1.BFB * 3 + 2];
      numArray395[index393] = (byte) num1183;
      byte[] numArray396 = second;
      int num1184 = num1182;
      int num1185 = num1184 + 1;
      int index394 = num1184;
      int num1186 = (int) numArray254[this.ucScreenLED1.LEDC8 * 3];
      numArray396[index394] = (byte) num1186;
      byte[] numArray397 = second;
      int num1187 = num1185;
      int num1188 = num1187 + 1;
      int index395 = num1187;
      int num1189 = (int) numArray254[this.ucScreenLED1.LEDC8 * 3 + 1];
      numArray397[index395] = (byte) num1189;
      byte[] numArray398 = second;
      int num1190 = num1188;
      int num1191 = num1190 + 1;
      int index396 = num1190;
      int num1192 = (int) numArray254[this.ucScreenLED1.LEDC8 * 3 + 2];
      numArray398[index396] = (byte) num1192;
      byte[] numArray399 = second;
      int num1193 = num1191;
      int num1194 = num1193 + 1;
      int index397 = num1193;
      int num1195 = (int) numArray254[this.ucScreenLED1.LEDD8 * 3];
      numArray399[index397] = (byte) num1195;
      byte[] numArray400 = second;
      int num1196 = num1194;
      int num1197 = num1196 + 1;
      int index398 = num1196;
      int num1198 = (int) numArray254[this.ucScreenLED1.LEDD8 * 3 + 1];
      numArray400[index398] = (byte) num1198;
      byte[] numArray401 = second;
      int num1199 = num1197;
      int num1200 = num1199 + 1;
      int index399 = num1199;
      int num1201 = (int) numArray254[this.ucScreenLED1.LEDD8 * 3 + 2];
      numArray401[index399] = (byte) num1201;
      byte[] numArray402 = second;
      int num1202 = num1200;
      int num1203 = num1202 + 1;
      int index400 = num1202;
      int num1204 = (int) numArray254[this.ucScreenLED1.LEDE8 * 3];
      numArray402[index400] = (byte) num1204;
      byte[] numArray403 = second;
      int num1205 = num1203;
      int num1206 = num1205 + 1;
      int index401 = num1205;
      int num1207 = (int) numArray254[this.ucScreenLED1.LEDE8 * 3 + 1];
      numArray403[index401] = (byte) num1207;
      byte[] numArray404 = second;
      int num1208 = num1206;
      int num1209 = num1208 + 1;
      int index402 = num1208;
      int num1210 = (int) numArray254[this.ucScreenLED1.LEDE8 * 3 + 2];
      numArray404[index402] = (byte) num1210;
      byte[] numArray405 = second;
      int num1211 = num1209;
      int num1212 = num1211 + 1;
      int index403 = num1211;
      int num1213 = (int) numArray254[this.ucScreenLED1.LEDG8 * 3];
      numArray405[index403] = (byte) num1213;
      byte[] numArray406 = second;
      int num1214 = num1212;
      int num1215 = num1214 + 1;
      int index404 = num1214;
      int num1216 = (int) numArray254[this.ucScreenLED1.LEDG8 * 3 + 1];
      numArray406[index404] = (byte) num1216;
      byte[] numArray407 = second;
      int num1217 = num1215;
      int num1218 = num1217 + 1;
      int index405 = num1217;
      int num1219 = (int) numArray254[this.ucScreenLED1.LEDG8 * 3 + 2];
      numArray407[index405] = (byte) num1219;
      byte[] numArray408 = second;
      int num1220 = num1218;
      int num1221 = num1220 + 1;
      int index406 = num1220;
      int num1222 = (int) numArray254[this.ucScreenLED1.LEDB8 * 3];
      numArray408[index406] = (byte) num1222;
      byte[] numArray409 = second;
      int num1223 = num1221;
      int num1224 = num1223 + 1;
      int index407 = num1223;
      int num1225 = (int) numArray254[this.ucScreenLED1.LEDB8 * 3 + 1];
      numArray409[index407] = (byte) num1225;
      byte[] numArray410 = second;
      int num1226 = num1224;
      int num1227 = num1226 + 1;
      int index408 = num1226;
      int num1228 = (int) numArray254[this.ucScreenLED1.LEDB8 * 3 + 2];
      numArray410[index408] = (byte) num1228;
      byte[] numArray411 = second;
      int num1229 = num1227;
      int num1230 = num1229 + 1;
      int index409 = num1229;
      int num1231 = (int) numArray254[this.ucScreenLED1.LEDA8 * 3];
      numArray411[index409] = (byte) num1231;
      byte[] numArray412 = second;
      int num1232 = num1230;
      int num1233 = num1232 + 1;
      int index410 = num1232;
      int num1234 = (int) numArray254[this.ucScreenLED1.LEDA8 * 3 + 1];
      numArray412[index410] = (byte) num1234;
      byte[] numArray413 = second;
      int num1235 = num1233;
      int num1236 = num1235 + 1;
      int index411 = num1235;
      int num1237 = (int) numArray254[this.ucScreenLED1.LEDA8 * 3 + 2];
      numArray413[index411] = (byte) num1237;
      byte[] numArray414 = second;
      int num1238 = num1236;
      int num1239 = num1238 + 1;
      int index412 = num1238;
      int num1240 = (int) numArray254[this.ucScreenLED1.LEDF8 * 3];
      numArray414[index412] = (byte) num1240;
      byte[] numArray415 = second;
      int num1241 = num1239;
      int num1242 = num1241 + 1;
      int index413 = num1241;
      int num1243 = (int) numArray254[this.ucScreenLED1.LEDF8 * 3 + 1];
      numArray415[index413] = (byte) num1243;
      byte[] numArray416 = second;
      int num1244 = num1242;
      int num1245 = num1244 + 1;
      int index414 = num1244;
      int num1246 = (int) numArray254[this.ucScreenLED1.LEDF8 * 3 + 2];
      numArray416[index414] = (byte) num1246;
      byte[] numArray417 = second;
      int num1247 = num1245;
      int num1248 = num1247 + 1;
      int index415 = num1247;
      int num1249 = (int) numArray254[this.ucScreenLED1.LEDC7 * 3];
      numArray417[index415] = (byte) num1249;
      byte[] numArray418 = second;
      int num1250 = num1248;
      int num1251 = num1250 + 1;
      int index416 = num1250;
      int num1252 = (int) numArray254[this.ucScreenLED1.LEDC7 * 3 + 1];
      numArray418[index416] = (byte) num1252;
      byte[] numArray419 = second;
      int num1253 = num1251;
      int num1254 = num1253 + 1;
      int index417 = num1253;
      int num1255 = (int) numArray254[this.ucScreenLED1.LEDC7 * 3 + 2];
      numArray419[index417] = (byte) num1255;
      byte[] numArray420 = second;
      int num1256 = num1254;
      int num1257 = num1256 + 1;
      int index418 = num1256;
      int num1258 = (int) numArray254[this.ucScreenLED1.Gpu1 * 3];
      numArray420[index418] = (byte) num1258;
      byte[] numArray421 = second;
      int num1259 = num1257;
      int num1260 = num1259 + 1;
      int index419 = num1259;
      int num1261 = (int) numArray254[this.ucScreenLED1.Gpu1 * 3 + 1];
      numArray421[index419] = (byte) num1261;
      byte[] numArray422 = second;
      int num1262 = num1260;
      int num1263 = num1262 + 1;
      int index420 = num1262;
      int num1264 = (int) numArray254[this.ucScreenLED1.Gpu1 * 3 + 2];
      numArray422[index420] = (byte) num1264;
      byte[] numArray423 = second;
      int num1265 = num1263;
      int num1266 = num1265 + 1;
      int index421 = num1265;
      int num1267 = (int) numArray254[this.ucScreenLED1.LEDD7 * 3];
      numArray423[index421] = (byte) num1267;
      byte[] numArray424 = second;
      int num1268 = num1266;
      int num1269 = num1268 + 1;
      int index422 = num1268;
      int num1270 = (int) numArray254[this.ucScreenLED1.LEDD7 * 3 + 1];
      numArray424[index422] = (byte) num1270;
      byte[] numArray425 = second;
      int num1271 = num1269;
      int num1272 = num1271 + 1;
      int index423 = num1271;
      int num1273 = (int) numArray254[this.ucScreenLED1.LEDD7 * 3 + 2];
      numArray425[index423] = (byte) num1273;
      byte[] numArray426 = second;
      int num1274 = num1272;
      int num1275 = num1274 + 1;
      int index424 = num1274;
      int num1276 = (int) numArray254[this.ucScreenLED1.LEDE7 * 3];
      numArray426[index424] = (byte) num1276;
      byte[] numArray427 = second;
      int num1277 = num1275;
      int num1278 = num1277 + 1;
      int index425 = num1277;
      int num1279 = (int) numArray254[this.ucScreenLED1.LEDE7 * 3 + 1];
      numArray427[index425] = (byte) num1279;
      byte[] numArray428 = second;
      int num1280 = num1278;
      int num1281 = num1280 + 1;
      int index426 = num1280;
      int num1282 = (int) numArray254[this.ucScreenLED1.LEDE7 * 3 + 2];
      numArray428[index426] = (byte) num1282;
      byte[] numArray429 = second;
      int num1283 = num1281;
      int num1284 = num1283 + 1;
      int index427 = num1283;
      int num1285 = (int) numArray254[this.ucScreenLED1.LEDG7 * 3];
      numArray429[index427] = (byte) num1285;
      byte[] numArray430 = second;
      int num1286 = num1284;
      int num1287 = num1286 + 1;
      int index428 = num1286;
      int num1288 = (int) numArray254[this.ucScreenLED1.LEDG7 * 3 + 1];
      numArray430[index428] = (byte) num1288;
      byte[] numArray431 = second;
      int num1289 = num1287;
      int num1290 = num1289 + 1;
      int index429 = num1289;
      int num1291 = (int) numArray254[this.ucScreenLED1.LEDG7 * 3 + 2];
      numArray431[index429] = (byte) num1291;
      byte[] numArray432 = second;
      int num1292 = num1290;
      int num1293 = num1292 + 1;
      int index430 = num1292;
      int num1294 = (int) numArray254[this.ucScreenLED1.LEDB7 * 3];
      numArray432[index430] = (byte) num1294;
      byte[] numArray433 = second;
      int num1295 = num1293;
      int num1296 = num1295 + 1;
      int index431 = num1295;
      int num1297 = (int) numArray254[this.ucScreenLED1.LEDB7 * 3 + 1];
      numArray433[index431] = (byte) num1297;
      byte[] numArray434 = second;
      int num1298 = num1296;
      int num1299 = num1298 + 1;
      int index432 = num1298;
      int num1300 = (int) numArray254[this.ucScreenLED1.LEDB7 * 3 + 2];
      numArray434[index432] = (byte) num1300;
      byte[] numArray435 = second;
      int num1301 = num1299;
      int num1302 = num1301 + 1;
      int index433 = num1301;
      int num1303 = (int) numArray254[this.ucScreenLED1.LEDA7 * 3];
      numArray435[index433] = (byte) num1303;
      byte[] numArray436 = second;
      int num1304 = num1302;
      int num1305 = num1304 + 1;
      int index434 = num1304;
      int num1306 = (int) numArray254[this.ucScreenLED1.LEDA7 * 3 + 1];
      numArray436[index434] = (byte) num1306;
      byte[] numArray437 = second;
      int num1307 = num1305;
      int num1308 = num1307 + 1;
      int index435 = num1307;
      int num1309 = (int) numArray254[this.ucScreenLED1.LEDA7 * 3 + 2];
      numArray437[index435] = (byte) num1309;
      byte[] numArray438 = second;
      int num1310 = num1308;
      int num1311 = num1310 + 1;
      int index436 = num1310;
      int num1312 = (int) numArray254[this.ucScreenLED1.LEDF7 * 3];
      numArray438[index436] = (byte) num1312;
      byte[] numArray439 = second;
      int num1313 = num1311;
      int num1314 = num1313 + 1;
      int index437 = num1313;
      int num1315 = (int) numArray254[this.ucScreenLED1.LEDF7 * 3 + 1];
      numArray439[index437] = (byte) num1315;
      byte[] numArray440 = second;
      int num1316 = num1314;
      int num1317 = num1316 + 1;
      int index438 = num1316;
      int num1318 = (int) numArray254[this.ucScreenLED1.LEDF7 * 3 + 2];
      numArray440[index438] = (byte) num1318;
      byte[] numArray441 = second;
      int num1319 = num1317;
      int num1320 = num1319 + 1;
      int index439 = num1319;
      int num1321 = (int) numArray254[this.ucScreenLED1.LEDB9 * 3];
      numArray441[index439] = (byte) num1321;
      byte[] numArray442 = second;
      int num1322 = num1320;
      int num1323 = num1322 + 1;
      int index440 = num1322;
      int num1324 = (int) numArray254[this.ucScreenLED1.LEDB9 * 3 + 1];
      numArray442[index440] = (byte) num1324;
      byte[] numArray443 = second;
      int num1325 = num1323;
      int num1326 = num1325 + 1;
      int index441 = num1325;
      int num1327 = (int) numArray254[this.ucScreenLED1.LEDB9 * 3 + 2];
      numArray443[index441] = (byte) num1327;
      byte[] numArray444 = second;
      int num1328 = num1326;
      int num1329 = num1328 + 1;
      int index442 = num1328;
      int num1330 = (int) numArray254[this.ucScreenLED1.LEDC9 * 3];
      numArray444[index442] = (byte) num1330;
      byte[] numArray445 = second;
      int num1331 = num1329;
      int num1332 = num1331 + 1;
      int index443 = num1331;
      int num1333 = (int) numArray254[this.ucScreenLED1.LEDC9 * 3 + 1];
      numArray445[index443] = (byte) num1333;
      byte[] numArray446 = second;
      int num1334 = num1332;
      int num1335 = num1334 + 1;
      int index444 = num1334;
      int num1336 = (int) numArray254[this.ucScreenLED1.LEDC9 * 3 + 2];
      numArray446[index444] = (byte) num1336;
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 4)
    {
      byte[] numArray447 = new byte[93];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray447.Length,
        (byte) 0,
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 31 /*0x1F*/; ++index)
      {
        if (this.myOnOff == (byte) 0)
        {
          numArray447[index * 3] = (byte) 0;
          numArray447[index * 3 + 1] = (byte) 0;
          numArray447[index * 3 + 2] = (byte) 0;
        }
        else if (this.ucScreenLED1.isOn[index])
        {
          numArray447[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2 + (double) num1);
          numArray447[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2 + (double) num1);
          numArray447[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2 + (double) num1);
        }
        else
        {
          numArray447[index * 3] = (byte) 0;
          numArray447[index * 3 + 1] = (byte) 0;
          numArray447[index * 3 + 2] = (byte) 0;
        }
      }
      int num1337 = 0;
      byte[] second = new byte[numArray447.Length];
      byte[] numArray448 = second;
      int num1338 = num1337;
      int num1339 = num1338 + 1;
      int index445 = num1338;
      int num1340 = (int) numArray447[this.ucScreenLED1.GNo * 3];
      numArray448[index445] = (byte) num1340;
      byte[] numArray449 = second;
      int num1341 = num1339;
      int num1342 = num1341 + 1;
      int index446 = num1341;
      int num1343 = (int) numArray447[this.ucScreenLED1.GNo * 3 + 1];
      numArray449[index446] = (byte) num1343;
      byte[] numArray450 = second;
      int num1344 = num1342;
      int num1345 = num1344 + 1;
      int index447 = num1344;
      int num1346 = (int) numArray447[this.ucScreenLED1.GNo * 3 + 2];
      numArray450[index447] = (byte) num1346;
      byte[] numArray451 = second;
      int num1347 = num1345;
      int num1348 = num1347 + 1;
      int index448 = num1347;
      int num1349 = (int) numArray447[this.ucScreenLED1.MTNo * 3];
      numArray451[index448] = (byte) num1349;
      byte[] numArray452 = second;
      int num1350 = num1348;
      int num1351 = num1350 + 1;
      int index449 = num1350;
      int num1352 = (int) numArray447[this.ucScreenLED1.MTNo * 3 + 1];
      numArray452[index449] = (byte) num1352;
      byte[] numArray453 = second;
      int num1353 = num1351;
      int num1354 = num1353 + 1;
      int index450 = num1353;
      int num1355 = (int) numArray447[this.ucScreenLED1.MTNo * 3 + 2];
      numArray453[index450] = (byte) num1355;
      byte[] numArray454 = second;
      int num1356 = num1354;
      int num1357 = num1356 + 1;
      int index451 = num1356;
      int num1358 = (int) numArray447[this.ucScreenLED1.LEDC4 * 3];
      numArray454[index451] = (byte) num1358;
      byte[] numArray455 = second;
      int num1359 = num1357;
      int num1360 = num1359 + 1;
      int index452 = num1359;
      int num1361 = (int) numArray447[this.ucScreenLED1.LEDC4 * 3 + 1];
      numArray455[index452] = (byte) num1361;
      byte[] numArray456 = second;
      int num1362 = num1360;
      int num1363 = num1362 + 1;
      int index453 = num1362;
      int num1364 = (int) numArray447[this.ucScreenLED1.LEDC4 * 3 + 2];
      numArray456[index453] = (byte) num1364;
      byte[] numArray457 = second;
      int num1365 = num1363;
      int num1366 = num1365 + 1;
      int index454 = num1365;
      int num1367 = (int) numArray447[this.ucScreenLED1.LEDD4 * 3];
      numArray457[index454] = (byte) num1367;
      byte[] numArray458 = second;
      int num1368 = num1366;
      int num1369 = num1368 + 1;
      int index455 = num1368;
      int num1370 = (int) numArray447[this.ucScreenLED1.LEDD4 * 3 + 1];
      numArray458[index455] = (byte) num1370;
      byte[] numArray459 = second;
      int num1371 = num1369;
      int num1372 = num1371 + 1;
      int index456 = num1371;
      int num1373 = (int) numArray447[this.ucScreenLED1.LEDD4 * 3 + 2];
      numArray459[index456] = (byte) num1373;
      byte[] numArray460 = second;
      int num1374 = num1372;
      int num1375 = num1374 + 1;
      int index457 = num1374;
      int num1376 = (int) numArray447[this.ucScreenLED1.LEDE4 * 3];
      numArray460[index457] = (byte) num1376;
      byte[] numArray461 = second;
      int num1377 = num1375;
      int num1378 = num1377 + 1;
      int index458 = num1377;
      int num1379 = (int) numArray447[this.ucScreenLED1.LEDE4 * 3 + 1];
      numArray461[index458] = (byte) num1379;
      byte[] numArray462 = second;
      int num1380 = num1378;
      int num1381 = num1380 + 1;
      int index459 = num1380;
      int num1382 = (int) numArray447[this.ucScreenLED1.LEDE4 * 3 + 2];
      numArray462[index459] = (byte) num1382;
      byte[] numArray463 = second;
      int num1383 = num1381;
      int num1384 = num1383 + 1;
      int index460 = num1383;
      int num1385 = (int) numArray447[this.ucScreenLED1.LEDG4 * 3];
      numArray463[index460] = (byte) num1385;
      byte[] numArray464 = second;
      int num1386 = num1384;
      int num1387 = num1386 + 1;
      int index461 = num1386;
      int num1388 = (int) numArray447[this.ucScreenLED1.LEDG4 * 3 + 1];
      numArray464[index461] = (byte) num1388;
      byte[] numArray465 = second;
      int num1389 = num1387;
      int num1390 = num1389 + 1;
      int index462 = num1389;
      int num1391 = (int) numArray447[this.ucScreenLED1.LEDG4 * 3 + 2];
      numArray465[index462] = (byte) num1391;
      byte[] numArray466 = second;
      int num1392 = num1390;
      int num1393 = num1392 + 1;
      int index463 = num1392;
      int num1394 = (int) numArray447[this.ucScreenLED1.LEDB4 * 3];
      numArray466[index463] = (byte) num1394;
      byte[] numArray467 = second;
      int num1395 = num1393;
      int num1396 = num1395 + 1;
      int index464 = num1395;
      int num1397 = (int) numArray447[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray467[index464] = (byte) num1397;
      byte[] numArray468 = second;
      int num1398 = num1396;
      int num1399 = num1398 + 1;
      int index465 = num1398;
      int num1400 = (int) numArray447[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray468[index465] = (byte) num1400;
      byte[] numArray469 = second;
      int num1401 = num1399;
      int num1402 = num1401 + 1;
      int index466 = num1401;
      int num1403 = (int) numArray447[this.ucScreenLED1.LEDA4 * 3];
      numArray469[index466] = (byte) num1403;
      byte[] numArray470 = second;
      int num1404 = num1402;
      int num1405 = num1404 + 1;
      int index467 = num1404;
      int num1406 = (int) numArray447[this.ucScreenLED1.LEDA4 * 3 + 1];
      numArray470[index467] = (byte) num1406;
      byte[] numArray471 = second;
      int num1407 = num1405;
      int num1408 = num1407 + 1;
      int index468 = num1407;
      int num1409 = (int) numArray447[this.ucScreenLED1.LEDA4 * 3 + 2];
      numArray471[index468] = (byte) num1409;
      byte[] numArray472 = second;
      int num1410 = num1408;
      int num1411 = num1410 + 1;
      int index469 = num1410;
      int num1412 = (int) numArray447[this.ucScreenLED1.SSD * 3];
      numArray472[index469] = (byte) num1412;
      byte[] numArray473 = second;
      int num1413 = num1411;
      int num1414 = num1413 + 1;
      int index470 = num1413;
      int num1415 = (int) numArray447[this.ucScreenLED1.SSD * 3 + 1];
      numArray473[index470] = (byte) num1415;
      byte[] numArray474 = second;
      int num1416 = num1414;
      int num1417 = num1416 + 1;
      int index471 = num1416;
      int num1418 = (int) numArray447[this.ucScreenLED1.SSD * 3 + 2];
      numArray474[index471] = (byte) num1418;
      byte[] numArray475 = second;
      int num1419 = num1417;
      int num1420 = num1419 + 1;
      int index472 = num1419;
      int num1421 = (int) numArray447[this.ucScreenLED1.LEDF4 * 3];
      numArray475[index472] = (byte) num1421;
      byte[] numArray476 = second;
      int num1422 = num1420;
      int num1423 = num1422 + 1;
      int index473 = num1422;
      int num1424 = (int) numArray447[this.ucScreenLED1.LEDF4 * 3 + 1];
      numArray476[index473] = (byte) num1424;
      byte[] numArray477 = second;
      int num1425 = num1423;
      int num1426 = num1425 + 1;
      int index474 = num1425;
      int num1427 = (int) numArray447[this.ucScreenLED1.LEDF4 * 3 + 2];
      numArray477[index474] = (byte) num1427;
      byte[] numArray478 = second;
      int num1428 = num1426;
      int num1429 = num1428 + 1;
      int index475 = num1428;
      int num1430 = (int) numArray447[this.ucScreenLED1.LEDC3 * 3];
      numArray478[index475] = (byte) num1430;
      byte[] numArray479 = second;
      int num1431 = num1429;
      int num1432 = num1431 + 1;
      int index476 = num1431;
      int num1433 = (int) numArray447[this.ucScreenLED1.LEDC3 * 3 + 1];
      numArray479[index476] = (byte) num1433;
      byte[] numArray480 = second;
      int num1434 = num1432;
      int num1435 = num1434 + 1;
      int index477 = num1434;
      int num1436 = (int) numArray447[this.ucScreenLED1.LEDC3 * 3 + 2];
      numArray480[index477] = (byte) num1436;
      byte[] numArray481 = second;
      int num1437 = num1435;
      int num1438 = num1437 + 1;
      int index478 = num1437;
      int num1439 = (int) numArray447[this.ucScreenLED1.LEDD3 * 3];
      numArray481[index478] = (byte) num1439;
      byte[] numArray482 = second;
      int num1440 = num1438;
      int num1441 = num1440 + 1;
      int index479 = num1440;
      int num1442 = (int) numArray447[this.ucScreenLED1.LEDD3 * 3 + 1];
      numArray482[index479] = (byte) num1442;
      byte[] numArray483 = second;
      int num1443 = num1441;
      int num1444 = num1443 + 1;
      int index480 = num1443;
      int num1445 = (int) numArray447[this.ucScreenLED1.LEDD3 * 3 + 2];
      numArray483[index480] = (byte) num1445;
      byte[] numArray484 = second;
      int num1446 = num1444;
      int num1447 = num1446 + 1;
      int index481 = num1446;
      int num1448 = (int) numArray447[this.ucScreenLED1.LEDE3 * 3];
      numArray484[index481] = (byte) num1448;
      byte[] numArray485 = second;
      int num1449 = num1447;
      int num1450 = num1449 + 1;
      int index482 = num1449;
      int num1451 = (int) numArray447[this.ucScreenLED1.LEDE3 * 3 + 1];
      numArray485[index482] = (byte) num1451;
      byte[] numArray486 = second;
      int num1452 = num1450;
      int num1453 = num1452 + 1;
      int index483 = num1452;
      int num1454 = (int) numArray447[this.ucScreenLED1.LEDE3 * 3 + 2];
      numArray486[index483] = (byte) num1454;
      byte[] numArray487 = second;
      int num1455 = num1453;
      int num1456 = num1455 + 1;
      int index484 = num1455;
      int num1457 = (int) numArray447[this.ucScreenLED1.LEDG3 * 3];
      numArray487[index484] = (byte) num1457;
      byte[] numArray488 = second;
      int num1458 = num1456;
      int num1459 = num1458 + 1;
      int index485 = num1458;
      int num1460 = (int) numArray447[this.ucScreenLED1.LEDG3 * 3 + 1];
      numArray488[index485] = (byte) num1460;
      byte[] numArray489 = second;
      int num1461 = num1459;
      int num1462 = num1461 + 1;
      int index486 = num1461;
      int num1463 = (int) numArray447[this.ucScreenLED1.LEDG3 * 3 + 2];
      numArray489[index486] = (byte) num1463;
      byte[] numArray490 = second;
      int num1464 = num1462;
      int num1465 = num1464 + 1;
      int index487 = num1464;
      int num1466 = (int) numArray447[this.ucScreenLED1.LEDB3 * 3];
      numArray490[index487] = (byte) num1466;
      byte[] numArray491 = second;
      int num1467 = num1465;
      int num1468 = num1467 + 1;
      int index488 = num1467;
      int num1469 = (int) numArray447[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray491[index488] = (byte) num1469;
      byte[] numArray492 = second;
      int num1470 = num1468;
      int num1471 = num1470 + 1;
      int index489 = num1470;
      int num1472 = (int) numArray447[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray492[index489] = (byte) num1472;
      byte[] numArray493 = second;
      int num1473 = num1471;
      int num1474 = num1473 + 1;
      int index490 = num1473;
      int num1475 = (int) numArray447[this.ucScreenLED1.LEDA3 * 3];
      numArray493[index490] = (byte) num1475;
      byte[] numArray494 = second;
      int num1476 = num1474;
      int num1477 = num1476 + 1;
      int index491 = num1476;
      int num1478 = (int) numArray447[this.ucScreenLED1.LEDA3 * 3 + 1];
      numArray494[index491] = (byte) num1478;
      byte[] numArray495 = second;
      int num1479 = num1477;
      int num1480 = num1479 + 1;
      int index492 = num1479;
      int num1481 = (int) numArray447[this.ucScreenLED1.LEDA3 * 3 + 2];
      numArray495[index492] = (byte) num1481;
      byte[] numArray496 = second;
      int num1482 = num1480;
      int num1483 = num1482 + 1;
      int index493 = num1482;
      int num1484 = (int) numArray447[this.ucScreenLED1.LEDF3 * 3];
      numArray496[index493] = (byte) num1484;
      byte[] numArray497 = second;
      int num1485 = num1483;
      int num1486 = num1485 + 1;
      int index494 = num1485;
      int num1487 = (int) numArray447[this.ucScreenLED1.LEDF3 * 3 + 1];
      numArray497[index494] = (byte) num1487;
      byte[] numArray498 = second;
      int num1488 = num1486;
      int num1489 = num1488 + 1;
      int index495 = num1488;
      int num1490 = (int) numArray447[this.ucScreenLED1.LEDF3 * 3 + 2];
      numArray498[index495] = (byte) num1490;
      byte[] numArray499 = second;
      int num1491 = num1489;
      int num1492 = num1491 + 1;
      int index496 = num1491;
      int num1493 = (int) numArray447[this.ucScreenLED1.LEDC2 * 3];
      numArray499[index496] = (byte) num1493;
      byte[] numArray500 = second;
      int num1494 = num1492;
      int num1495 = num1494 + 1;
      int index497 = num1494;
      int num1496 = (int) numArray447[this.ucScreenLED1.LEDC2 * 3 + 1];
      numArray500[index497] = (byte) num1496;
      byte[] numArray501 = second;
      int num1497 = num1495;
      int num1498 = num1497 + 1;
      int index498 = num1497;
      int num1499 = (int) numArray447[this.ucScreenLED1.LEDC2 * 3 + 2];
      numArray501[index498] = (byte) num1499;
      byte[] numArray502 = second;
      int num1500 = num1498;
      int num1501 = num1500 + 1;
      int index499 = num1500;
      int num1502 = (int) numArray447[this.ucScreenLED1.LEDD2 * 3];
      numArray502[index499] = (byte) num1502;
      byte[] numArray503 = second;
      int num1503 = num1501;
      int num1504 = num1503 + 1;
      int index500 = num1503;
      int num1505 = (int) numArray447[this.ucScreenLED1.LEDD2 * 3 + 1];
      numArray503[index500] = (byte) num1505;
      byte[] numArray504 = second;
      int num1506 = num1504;
      int num1507 = num1506 + 1;
      int index501 = num1506;
      int num1508 = (int) numArray447[this.ucScreenLED1.LEDD2 * 3 + 2];
      numArray504[index501] = (byte) num1508;
      byte[] numArray505 = second;
      int num1509 = num1507;
      int num1510 = num1509 + 1;
      int index502 = num1509;
      int num1511 = (int) numArray447[this.ucScreenLED1.LEDE2 * 3];
      numArray505[index502] = (byte) num1511;
      byte[] numArray506 = second;
      int num1512 = num1510;
      int num1513 = num1512 + 1;
      int index503 = num1512;
      int num1514 = (int) numArray447[this.ucScreenLED1.LEDE2 * 3 + 1];
      numArray506[index503] = (byte) num1514;
      byte[] numArray507 = second;
      int num1515 = num1513;
      int num1516 = num1515 + 1;
      int index504 = num1515;
      int num1517 = (int) numArray447[this.ucScreenLED1.LEDE2 * 3 + 2];
      numArray507[index504] = (byte) num1517;
      byte[] numArray508 = second;
      int num1518 = num1516;
      int num1519 = num1518 + 1;
      int index505 = num1518;
      int num1520 = (int) numArray447[this.ucScreenLED1.LEDG2 * 3];
      numArray508[index505] = (byte) num1520;
      byte[] numArray509 = second;
      int num1521 = num1519;
      int num1522 = num1521 + 1;
      int index506 = num1521;
      int num1523 = (int) numArray447[this.ucScreenLED1.LEDG2 * 3 + 1];
      numArray509[index506] = (byte) num1523;
      byte[] numArray510 = second;
      int num1524 = num1522;
      int num1525 = num1524 + 1;
      int index507 = num1524;
      int num1526 = (int) numArray447[this.ucScreenLED1.LEDG2 * 3 + 2];
      numArray510[index507] = (byte) num1526;
      byte[] numArray511 = second;
      int num1527 = num1525;
      int num1528 = num1527 + 1;
      int index508 = num1527;
      int num1529 = (int) numArray447[this.ucScreenLED1.LEDB2 * 3];
      numArray511[index508] = (byte) num1529;
      byte[] numArray512 = second;
      int num1530 = num1528;
      int num1531 = num1530 + 1;
      int index509 = num1530;
      int num1532 = (int) numArray447[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray512[index509] = (byte) num1532;
      byte[] numArray513 = second;
      int num1533 = num1531;
      int num1534 = num1533 + 1;
      int index510 = num1533;
      int num1535 = (int) numArray447[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray513[index510] = (byte) num1535;
      byte[] numArray514 = second;
      int num1536 = num1534;
      int num1537 = num1536 + 1;
      int index511 = num1536;
      int num1538 = (int) numArray447[this.ucScreenLED1.LEDA2 * 3];
      numArray514[index511] = (byte) num1538;
      byte[] numArray515 = second;
      int num1539 = num1537;
      int num1540 = num1539 + 1;
      int index512 = num1539;
      int num1541 = (int) numArray447[this.ucScreenLED1.LEDA2 * 3 + 1];
      numArray515[index512] = (byte) num1541;
      byte[] numArray516 = second;
      int num1542 = num1540;
      int num1543 = num1542 + 1;
      int index513 = num1542;
      int num1544 = (int) numArray447[this.ucScreenLED1.LEDA2 * 3 + 2];
      numArray516[index513] = (byte) num1544;
      byte[] numArray517 = second;
      int num1545 = num1543;
      int num1546 = num1545 + 1;
      int index514 = num1545;
      int num1547 = (int) numArray447[this.ucScreenLED1.LEDF2 * 3];
      numArray517[index514] = (byte) num1547;
      byte[] numArray518 = second;
      int num1548 = num1546;
      int num1549 = num1548 + 1;
      int index515 = num1548;
      int num1550 = (int) numArray447[this.ucScreenLED1.LEDF2 * 3 + 1];
      numArray518[index515] = (byte) num1550;
      byte[] numArray519 = second;
      int num1551 = num1549;
      int num1552 = num1551 + 1;
      int index516 = num1551;
      int num1553 = (int) numArray447[this.ucScreenLED1.LEDF2 * 3 + 2];
      numArray519[index516] = (byte) num1553;
      byte[] numArray520 = second;
      int num1554 = num1552;
      int num1555 = num1554 + 1;
      int index517 = num1554;
      int num1556 = (int) numArray447[this.ucScreenLED1.LEDC1 * 3];
      numArray520[index517] = (byte) num1556;
      byte[] numArray521 = second;
      int num1557 = num1555;
      int num1558 = num1557 + 1;
      int index518 = num1557;
      int num1559 = (int) numArray447[this.ucScreenLED1.LEDC1 * 3 + 1];
      numArray521[index518] = (byte) num1559;
      byte[] numArray522 = second;
      int num1560 = num1558;
      int num1561 = num1560 + 1;
      int index519 = num1560;
      int num1562 = (int) numArray447[this.ucScreenLED1.LEDC1 * 3 + 2];
      numArray522[index519] = (byte) num1562;
      byte[] numArray523 = second;
      int num1563 = num1561;
      int num1564 = num1563 + 1;
      int index520 = num1563;
      int num1565 = (int) numArray447[this.ucScreenLED1.LEDD1 * 3];
      numArray523[index520] = (byte) num1565;
      byte[] numArray524 = second;
      int num1566 = num1564;
      int num1567 = num1566 + 1;
      int index521 = num1566;
      int num1568 = (int) numArray447[this.ucScreenLED1.LEDD1 * 3 + 1];
      numArray524[index521] = (byte) num1568;
      byte[] numArray525 = second;
      int num1569 = num1567;
      int num1570 = num1569 + 1;
      int index522 = num1569;
      int num1571 = (int) numArray447[this.ucScreenLED1.LEDD1 * 3 + 2];
      numArray525[index522] = (byte) num1571;
      byte[] numArray526 = second;
      int num1572 = num1570;
      int num1573 = num1572 + 1;
      int index523 = num1572;
      int num1574 = (int) numArray447[this.ucScreenLED1.LEDE1 * 3];
      numArray526[index523] = (byte) num1574;
      byte[] numArray527 = second;
      int num1575 = num1573;
      int num1576 = num1575 + 1;
      int index524 = num1575;
      int num1577 = (int) numArray447[this.ucScreenLED1.LEDE1 * 3 + 1];
      numArray527[index524] = (byte) num1577;
      byte[] numArray528 = second;
      int num1578 = num1576;
      int num1579 = num1578 + 1;
      int index525 = num1578;
      int num1580 = (int) numArray447[this.ucScreenLED1.LEDE1 * 3 + 2];
      numArray528[index525] = (byte) num1580;
      byte[] numArray529 = second;
      int num1581 = num1579;
      int num1582 = num1581 + 1;
      int index526 = num1581;
      int num1583 = (int) numArray447[this.ucScreenLED1.LEDG1 * 3];
      numArray529[index526] = (byte) num1583;
      byte[] numArray530 = second;
      int num1584 = num1582;
      int num1585 = num1584 + 1;
      int index527 = num1584;
      int num1586 = (int) numArray447[this.ucScreenLED1.LEDG1 * 3 + 1];
      numArray530[index527] = (byte) num1586;
      byte[] numArray531 = second;
      int num1587 = num1585;
      int num1588 = num1587 + 1;
      int index528 = num1587;
      int num1589 = (int) numArray447[this.ucScreenLED1.LEDG1 * 3 + 2];
      numArray531[index528] = (byte) num1589;
      byte[] numArray532 = second;
      int num1590 = num1588;
      int num1591 = num1590 + 1;
      int index529 = num1590;
      int num1592 = (int) numArray447[this.ucScreenLED1.LEDB1 * 3];
      numArray532[index529] = (byte) num1592;
      byte[] numArray533 = second;
      int num1593 = num1591;
      int num1594 = num1593 + 1;
      int index530 = num1593;
      int num1595 = (int) numArray447[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray533[index530] = (byte) num1595;
      byte[] numArray534 = second;
      int num1596 = num1594;
      int num1597 = num1596 + 1;
      int index531 = num1596;
      int num1598 = (int) numArray447[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray534[index531] = (byte) num1598;
      byte[] numArray535 = second;
      int num1599 = num1597;
      int num1600 = num1599 + 1;
      int index532 = num1599;
      int num1601 = (int) numArray447[this.ucScreenLED1.LEDA1 * 3];
      numArray535[index532] = (byte) num1601;
      byte[] numArray536 = second;
      int num1602 = num1600;
      int num1603 = num1602 + 1;
      int index533 = num1602;
      int num1604 = (int) numArray447[this.ucScreenLED1.LEDA1 * 3 + 1];
      numArray536[index533] = (byte) num1604;
      byte[] numArray537 = second;
      int num1605 = num1603;
      int num1606 = num1605 + 1;
      int index534 = num1605;
      int num1607 = (int) numArray447[this.ucScreenLED1.LEDA1 * 3 + 2];
      numArray537[index534] = (byte) num1607;
      byte[] numArray538 = second;
      int num1608 = num1606;
      int num1609 = num1608 + 1;
      int index535 = num1608;
      int num1610 = (int) numArray447[this.ucScreenLED1.LEDF1 * 3];
      numArray538[index535] = (byte) num1610;
      byte[] numArray539 = second;
      int num1611 = num1609;
      int num1612 = num1611 + 1;
      int index536 = num1611;
      int num1613 = (int) numArray447[this.ucScreenLED1.LEDF1 * 3 + 1];
      numArray539[index536] = (byte) num1613;
      byte[] numArray540 = second;
      int num1614 = num1612;
      int num1615 = num1614 + 1;
      int index537 = num1614;
      int num1616 = (int) numArray447[this.ucScreenLED1.LEDF1 * 3 + 2];
      numArray540[index537] = (byte) num1616;
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 5)
    {
      byte[] numArray541 = new byte[279];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray541.Length,
        (byte) (numArray541.Length >> 8),
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 93; ++index)
      {
        if (this.myOnOff == (byte) 0)
        {
          numArray541[index * 3] = (byte) 0;
          numArray541[index * 3 + 1] = (byte) 0;
          numArray541[index * 3 + 2] = (byte) 0;
        }
        else if (this.ucScreenLED1.isOn[index])
        {
          numArray541[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2 + (double) num1);
          numArray541[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2 + (double) num1);
          numArray541[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2 + (double) num1);
        }
        else
        {
          numArray541[index * 3] = (byte) 0;
          numArray541[index * 3 + 1] = (byte) 0;
          numArray541[index * 3 + 2] = (byte) 0;
        }
      }
      int num1617 = 0;
      byte[] second = new byte[numArray541.Length];
      byte[] numArray542 = second;
      int num1618 = num1617;
      int num1619 = num1618 + 1;
      int index538 = num1618;
      int num1620 = (int) numArray541[this.ucScreenLED1.BFB * 3];
      numArray542[index538] = (byte) num1620;
      byte[] numArray543 = second;
      int num1621 = num1619;
      int num1622 = num1621 + 1;
      int index539 = num1621;
      int num1623 = (int) numArray541[this.ucScreenLED1.BFB * 3 + 1];
      numArray543[index539] = (byte) num1623;
      byte[] numArray544 = second;
      int num1624 = num1622;
      int num1625 = num1624 + 1;
      int index540 = num1624;
      int num1626 = (int) numArray541[this.ucScreenLED1.BFB * 3 + 2];
      numArray544[index540] = (byte) num1626;
      byte[] numArray545 = second;
      int num1627 = num1625;
      int num1628 = num1627 + 1;
      int index541 = num1627;
      int num1629 = (int) numArray541[this.ucScreenLED1.LEDC12 * 3];
      numArray545[index541] = (byte) num1629;
      byte[] numArray546 = second;
      int num1630 = num1628;
      int num1631 = num1630 + 1;
      int index542 = num1630;
      int num1632 = (int) numArray541[this.ucScreenLED1.LEDC12 * 3 + 1];
      numArray546[index542] = (byte) num1632;
      byte[] numArray547 = second;
      int num1633 = num1631;
      int num1634 = num1633 + 1;
      int index543 = num1633;
      int num1635 = (int) numArray541[this.ucScreenLED1.LEDC12 * 3 + 2];
      numArray547[index543] = (byte) num1635;
      byte[] numArray548 = second;
      int num1636 = num1634;
      int num1637 = num1636 + 1;
      int index544 = num1636;
      int num1638 = (int) numArray541[this.ucScreenLED1.LEDD12 * 3];
      numArray548[index544] = (byte) num1638;
      byte[] numArray549 = second;
      int num1639 = num1637;
      int num1640 = num1639 + 1;
      int index545 = num1639;
      int num1641 = (int) numArray541[this.ucScreenLED1.LEDD12 * 3 + 1];
      numArray549[index545] = (byte) num1641;
      byte[] numArray550 = second;
      int num1642 = num1640;
      int num1643 = num1642 + 1;
      int index546 = num1642;
      int num1644 = (int) numArray541[this.ucScreenLED1.LEDD12 * 3 + 2];
      numArray550[index546] = (byte) num1644;
      byte[] numArray551 = second;
      int num1645 = num1643;
      int num1646 = num1645 + 1;
      int index547 = num1645;
      int num1647 = (int) numArray541[this.ucScreenLED1.LEDE12 * 3];
      numArray551[index547] = (byte) num1647;
      byte[] numArray552 = second;
      int num1648 = num1646;
      int num1649 = num1648 + 1;
      int index548 = num1648;
      int num1650 = (int) numArray541[this.ucScreenLED1.LEDE12 * 3 + 1];
      numArray552[index548] = (byte) num1650;
      byte[] numArray553 = second;
      int num1651 = num1649;
      int num1652 = num1651 + 1;
      int index549 = num1651;
      int num1653 = (int) numArray541[this.ucScreenLED1.LEDE12 * 3 + 2];
      numArray553[index549] = (byte) num1653;
      byte[] numArray554 = second;
      int num1654 = num1652;
      int num1655 = num1654 + 1;
      int index550 = num1654;
      int num1656 = (int) numArray541[this.ucScreenLED1.LEDG12 * 3];
      numArray554[index550] = (byte) num1656;
      byte[] numArray555 = second;
      int num1657 = num1655;
      int num1658 = num1657 + 1;
      int index551 = num1657;
      int num1659 = (int) numArray541[this.ucScreenLED1.LEDG12 * 3 + 1];
      numArray555[index551] = (byte) num1659;
      byte[] numArray556 = second;
      int num1660 = num1658;
      int num1661 = num1660 + 1;
      int index552 = num1660;
      int num1662 = (int) numArray541[this.ucScreenLED1.LEDG12 * 3 + 2];
      numArray556[index552] = (byte) num1662;
      byte[] numArray557 = second;
      int num1663 = num1661;
      int num1664 = num1663 + 1;
      int index553 = num1663;
      int num1665 = (int) numArray541[this.ucScreenLED1.LEDB12 * 3];
      numArray557[index553] = (byte) num1665;
      byte[] numArray558 = second;
      int num1666 = num1664;
      int num1667 = num1666 + 1;
      int index554 = num1666;
      int num1668 = (int) numArray541[this.ucScreenLED1.LEDB12 * 3 + 1];
      numArray558[index554] = (byte) num1668;
      byte[] numArray559 = second;
      int num1669 = num1667;
      int num1670 = num1669 + 1;
      int index555 = num1669;
      int num1671 = (int) numArray541[this.ucScreenLED1.LEDB12 * 3 + 2];
      numArray559[index555] = (byte) num1671;
      byte[] numArray560 = second;
      int num1672 = num1670;
      int num1673 = num1672 + 1;
      int index556 = num1672;
      int num1674 = (int) numArray541[this.ucScreenLED1.LEDA12 * 3];
      numArray560[index556] = (byte) num1674;
      byte[] numArray561 = second;
      int num1675 = num1673;
      int num1676 = num1675 + 1;
      int index557 = num1675;
      int num1677 = (int) numArray541[this.ucScreenLED1.LEDA12 * 3 + 1];
      numArray561[index557] = (byte) num1677;
      byte[] numArray562 = second;
      int num1678 = num1676;
      int num1679 = num1678 + 1;
      int index558 = num1678;
      int num1680 = (int) numArray541[this.ucScreenLED1.LEDA12 * 3 + 2];
      numArray562[index558] = (byte) num1680;
      byte[] numArray563 = second;
      int num1681 = num1679;
      int num1682 = num1681 + 1;
      int index559 = num1681;
      int num1683 = (int) numArray541[this.ucScreenLED1.LEDF12 * 3];
      numArray563[index559] = (byte) num1683;
      byte[] numArray564 = second;
      int num1684 = num1682;
      int num1685 = num1684 + 1;
      int index560 = num1684;
      int num1686 = (int) numArray541[this.ucScreenLED1.LEDF12 * 3 + 1];
      numArray564[index560] = (byte) num1686;
      byte[] numArray565 = second;
      int num1687 = num1685;
      int num1688 = num1687 + 1;
      int index561 = num1687;
      int num1689 = (int) numArray541[this.ucScreenLED1.LEDF12 * 3 + 2];
      numArray565[index561] = (byte) num1689;
      byte[] numArray566 = second;
      int num1690 = num1688;
      int num1691 = num1690 + 1;
      int index562 = num1690;
      int num1692 = (int) numArray541[this.ucScreenLED1.LEDC11 * 3];
      numArray566[index562] = (byte) num1692;
      byte[] numArray567 = second;
      int num1693 = num1691;
      int num1694 = num1693 + 1;
      int index563 = num1693;
      int num1695 = (int) numArray541[this.ucScreenLED1.LEDC11 * 3 + 1];
      numArray567[index563] = (byte) num1695;
      byte[] numArray568 = second;
      int num1696 = num1694;
      int num1697 = num1696 + 1;
      int index564 = num1696;
      int num1698 = (int) numArray541[this.ucScreenLED1.LEDC11 * 3 + 2];
      numArray568[index564] = (byte) num1698;
      byte[] numArray569 = second;
      int num1699 = num1697;
      int num1700 = num1699 + 1;
      int index565 = num1699;
      int num1701 = (int) numArray541[this.ucScreenLED1.LEDD11 * 3];
      numArray569[index565] = (byte) num1701;
      byte[] numArray570 = second;
      int num1702 = num1700;
      int num1703 = num1702 + 1;
      int index566 = num1702;
      int num1704 = (int) numArray541[this.ucScreenLED1.LEDD11 * 3 + 1];
      numArray570[index566] = (byte) num1704;
      byte[] numArray571 = second;
      int num1705 = num1703;
      int num1706 = num1705 + 1;
      int index567 = num1705;
      int num1707 = (int) numArray541[this.ucScreenLED1.LEDD11 * 3 + 2];
      numArray571[index567] = (byte) num1707;
      byte[] numArray572 = second;
      int num1708 = num1706;
      int num1709 = num1708 + 1;
      int index568 = num1708;
      int num1710 = (int) numArray541[this.ucScreenLED1.LEDE11 * 3];
      numArray572[index568] = (byte) num1710;
      byte[] numArray573 = second;
      int num1711 = num1709;
      int num1712 = num1711 + 1;
      int index569 = num1711;
      int num1713 = (int) numArray541[this.ucScreenLED1.LEDE11 * 3 + 1];
      numArray573[index569] = (byte) num1713;
      byte[] numArray574 = second;
      int num1714 = num1712;
      int num1715 = num1714 + 1;
      int index570 = num1714;
      int num1716 = (int) numArray541[this.ucScreenLED1.LEDE11 * 3 + 2];
      numArray574[index570] = (byte) num1716;
      byte[] numArray575 = second;
      int num1717 = num1715;
      int num1718 = num1717 + 1;
      int index571 = num1717;
      int num1719 = (int) numArray541[this.ucScreenLED1.LEDG11 * 3];
      numArray575[index571] = (byte) num1719;
      byte[] numArray576 = second;
      int num1720 = num1718;
      int num1721 = num1720 + 1;
      int index572 = num1720;
      int num1722 = (int) numArray541[this.ucScreenLED1.LEDG11 * 3 + 1];
      numArray576[index572] = (byte) num1722;
      byte[] numArray577 = second;
      int num1723 = num1721;
      int num1724 = num1723 + 1;
      int index573 = num1723;
      int num1725 = (int) numArray541[this.ucScreenLED1.LEDG11 * 3 + 2];
      numArray577[index573] = (byte) num1725;
      byte[] numArray578 = second;
      int num1726 = num1724;
      int num1727 = num1726 + 1;
      int index574 = num1726;
      int num1728 = (int) numArray541[this.ucScreenLED1.LEDB11 * 3];
      numArray578[index574] = (byte) num1728;
      byte[] numArray579 = second;
      int num1729 = num1727;
      int num1730 = num1729 + 1;
      int index575 = num1729;
      int num1731 = (int) numArray541[this.ucScreenLED1.LEDB11 * 3 + 1];
      numArray579[index575] = (byte) num1731;
      byte[] numArray580 = second;
      int num1732 = num1730;
      int num1733 = num1732 + 1;
      int index576 = num1732;
      int num1734 = (int) numArray541[this.ucScreenLED1.LEDB11 * 3 + 2];
      numArray580[index576] = (byte) num1734;
      byte[] numArray581 = second;
      int num1735 = num1733;
      int num1736 = num1735 + 1;
      int index577 = num1735;
      int num1737 = (int) numArray541[this.ucScreenLED1.LEDA11 * 3];
      numArray581[index577] = (byte) num1737;
      byte[] numArray582 = second;
      int num1738 = num1736;
      int num1739 = num1738 + 1;
      int index578 = num1738;
      int num1740 = (int) numArray541[this.ucScreenLED1.LEDA11 * 3 + 1];
      numArray582[index578] = (byte) num1740;
      byte[] numArray583 = second;
      int num1741 = num1739;
      int num1742 = num1741 + 1;
      int index579 = num1741;
      int num1743 = (int) numArray541[this.ucScreenLED1.LEDA11 * 3 + 2];
      numArray583[index579] = (byte) num1743;
      byte[] numArray584 = second;
      int num1744 = num1742;
      int num1745 = num1744 + 1;
      int index580 = num1744;
      int num1746 = (int) numArray541[this.ucScreenLED1.LEDF11 * 3];
      numArray584[index580] = (byte) num1746;
      byte[] numArray585 = second;
      int num1747 = num1745;
      int num1748 = num1747 + 1;
      int index581 = num1747;
      int num1749 = (int) numArray541[this.ucScreenLED1.LEDF11 * 3 + 1];
      numArray585[index581] = (byte) num1749;
      byte[] numArray586 = second;
      int num1750 = num1748;
      int num1751 = num1750 + 1;
      int index582 = num1750;
      int num1752 = (int) numArray541[this.ucScreenLED1.LEDF11 * 3 + 2];
      numArray586[index582] = (byte) num1752;
      byte[] numArray587 = second;
      int num1753 = num1751;
      int num1754 = num1753 + 1;
      int index583 = num1753;
      int num1755 = (int) numArray541[this.ucScreenLED1.LEDB13 * 3];
      numArray587[index583] = (byte) num1755;
      byte[] numArray588 = second;
      int num1756 = num1754;
      int num1757 = num1756 + 1;
      int index584 = num1756;
      int num1758 = (int) numArray541[this.ucScreenLED1.LEDB13 * 3 + 1];
      numArray588[index584] = (byte) num1758;
      byte[] numArray589 = second;
      int num1759 = num1757;
      int num1760 = num1759 + 1;
      int index585 = num1759;
      int num1761 = (int) numArray541[this.ucScreenLED1.LEDB13 * 3 + 2];
      numArray589[index585] = (byte) num1761;
      byte[] numArray590 = second;
      int num1762 = num1760;
      int num1763 = num1762 + 1;
      int index586 = num1762;
      int num1764 = (int) numArray541[this.ucScreenLED1.MHz * 3];
      numArray590[index586] = (byte) num1764;
      byte[] numArray591 = second;
      int num1765 = num1763;
      int num1766 = num1765 + 1;
      int index587 = num1765;
      int num1767 = (int) numArray541[this.ucScreenLED1.MHz * 3 + 1];
      numArray591[index587] = (byte) num1767;
      byte[] numArray592 = second;
      int num1768 = num1766;
      int num1769 = num1768 + 1;
      int index588 = num1768;
      int num1770 = (int) numArray541[this.ucScreenLED1.MHz * 3 + 2];
      numArray592[index588] = (byte) num1770;
      byte[] numArray593 = second;
      int num1771 = num1769;
      int num1772 = num1771 + 1;
      int index589 = num1771;
      int num1773 = (int) numArray541[this.ucScreenLED1.LEDC10 * 3];
      numArray593[index589] = (byte) num1773;
      byte[] numArray594 = second;
      int num1774 = num1772;
      int num1775 = num1774 + 1;
      int index590 = num1774;
      int num1776 = (int) numArray541[this.ucScreenLED1.LEDC10 * 3 + 1];
      numArray594[index590] = (byte) num1776;
      byte[] numArray595 = second;
      int num1777 = num1775;
      int num1778 = num1777 + 1;
      int index591 = num1777;
      int num1779 = (int) numArray541[this.ucScreenLED1.LEDC10 * 3 + 2];
      numArray595[index591] = (byte) num1779;
      byte[] numArray596 = second;
      int num1780 = num1778;
      int num1781 = num1780 + 1;
      int index592 = num1780;
      int num1782 = (int) numArray541[this.ucScreenLED1.LEDD10 * 3];
      numArray596[index592] = (byte) num1782;
      byte[] numArray597 = second;
      int num1783 = num1781;
      int num1784 = num1783 + 1;
      int index593 = num1783;
      int num1785 = (int) numArray541[this.ucScreenLED1.LEDD10 * 3 + 1];
      numArray597[index593] = (byte) num1785;
      byte[] numArray598 = second;
      int num1786 = num1784;
      int num1787 = num1786 + 1;
      int index594 = num1786;
      int num1788 = (int) numArray541[this.ucScreenLED1.LEDD10 * 3 + 2];
      numArray598[index594] = (byte) num1788;
      byte[] numArray599 = second;
      int num1789 = num1787;
      int num1790 = num1789 + 1;
      int index595 = num1789;
      int num1791 = (int) numArray541[this.ucScreenLED1.LEDE10 * 3];
      numArray599[index595] = (byte) num1791;
      byte[] numArray600 = second;
      int num1792 = num1790;
      int num1793 = num1792 + 1;
      int index596 = num1792;
      int num1794 = (int) numArray541[this.ucScreenLED1.LEDE10 * 3 + 1];
      numArray600[index596] = (byte) num1794;
      byte[] numArray601 = second;
      int num1795 = num1793;
      int num1796 = num1795 + 1;
      int index597 = num1795;
      int num1797 = (int) numArray541[this.ucScreenLED1.LEDE10 * 3 + 2];
      numArray601[index597] = (byte) num1797;
      byte[] numArray602 = second;
      int num1798 = num1796;
      int num1799 = num1798 + 1;
      int index598 = num1798;
      int num1800 = (int) numArray541[this.ucScreenLED1.LEDG10 * 3];
      numArray602[index598] = (byte) num1800;
      byte[] numArray603 = second;
      int num1801 = num1799;
      int num1802 = num1801 + 1;
      int index599 = num1801;
      int num1803 = (int) numArray541[this.ucScreenLED1.LEDG10 * 3 + 1];
      numArray603[index599] = (byte) num1803;
      byte[] numArray604 = second;
      int num1804 = num1802;
      int num1805 = num1804 + 1;
      int index600 = num1804;
      int num1806 = (int) numArray541[this.ucScreenLED1.LEDG10 * 3 + 2];
      numArray604[index600] = (byte) num1806;
      byte[] numArray605 = second;
      int num1807 = num1805;
      int num1808 = num1807 + 1;
      int index601 = num1807;
      int num1809 = (int) numArray541[this.ucScreenLED1.LEDB10 * 3];
      numArray605[index601] = (byte) num1809;
      byte[] numArray606 = second;
      int num1810 = num1808;
      int num1811 = num1810 + 1;
      int index602 = num1810;
      int num1812 = (int) numArray541[this.ucScreenLED1.LEDB10 * 3 + 1];
      numArray606[index602] = (byte) num1812;
      byte[] numArray607 = second;
      int num1813 = num1811;
      int num1814 = num1813 + 1;
      int index603 = num1813;
      int num1815 = (int) numArray541[this.ucScreenLED1.LEDB10 * 3 + 2];
      numArray607[index603] = (byte) num1815;
      byte[] numArray608 = second;
      int num1816 = num1814;
      int num1817 = num1816 + 1;
      int index604 = num1816;
      int num1818 = (int) numArray541[this.ucScreenLED1.LEDA10 * 3];
      numArray608[index604] = (byte) num1818;
      byte[] numArray609 = second;
      int num1819 = num1817;
      int num1820 = num1819 + 1;
      int index605 = num1819;
      int num1821 = (int) numArray541[this.ucScreenLED1.LEDA10 * 3 + 1];
      numArray609[index605] = (byte) num1821;
      byte[] numArray610 = second;
      int num1822 = num1820;
      int num1823 = num1822 + 1;
      int index606 = num1822;
      int num1824 = (int) numArray541[this.ucScreenLED1.LEDA10 * 3 + 2];
      numArray610[index606] = (byte) num1824;
      byte[] numArray611 = second;
      int num1825 = num1823;
      int num1826 = num1825 + 1;
      int index607 = num1825;
      int num1827 = (int) numArray541[this.ucScreenLED1.LEDF10 * 3];
      numArray611[index607] = (byte) num1827;
      byte[] numArray612 = second;
      int num1828 = num1826;
      int num1829 = num1828 + 1;
      int index608 = num1828;
      int num1830 = (int) numArray541[this.ucScreenLED1.LEDF10 * 3 + 1];
      numArray612[index608] = (byte) num1830;
      byte[] numArray613 = second;
      int num1831 = num1829;
      int num1832 = num1831 + 1;
      int index609 = num1831;
      int num1833 = (int) numArray541[this.ucScreenLED1.LEDF10 * 3 + 2];
      numArray613[index609] = (byte) num1833;
      byte[] numArray614 = second;
      int num1834 = num1832;
      int num1835 = num1834 + 1;
      int index610 = num1834;
      int num1836 = (int) numArray541[this.ucScreenLED1.LEDC9 * 3];
      numArray614[index610] = (byte) num1836;
      byte[] numArray615 = second;
      int num1837 = num1835;
      int num1838 = num1837 + 1;
      int index611 = num1837;
      int num1839 = (int) numArray541[this.ucScreenLED1.LEDC9 * 3 + 1];
      numArray615[index611] = (byte) num1839;
      byte[] numArray616 = second;
      int num1840 = num1838;
      int num1841 = num1840 + 1;
      int index612 = num1840;
      int num1842 = (int) numArray541[this.ucScreenLED1.LEDC9 * 3 + 2];
      numArray616[index612] = (byte) num1842;
      byte[] numArray617 = second;
      int num1843 = num1841;
      int num1844 = num1843 + 1;
      int index613 = num1843;
      int num1845 = (int) numArray541[this.ucScreenLED1.LEDD9 * 3];
      numArray617[index613] = (byte) num1845;
      byte[] numArray618 = second;
      int num1846 = num1844;
      int num1847 = num1846 + 1;
      int index614 = num1846;
      int num1848 = (int) numArray541[this.ucScreenLED1.LEDD9 * 3 + 1];
      numArray618[index614] = (byte) num1848;
      byte[] numArray619 = second;
      int num1849 = num1847;
      int num1850 = num1849 + 1;
      int index615 = num1849;
      int num1851 = (int) numArray541[this.ucScreenLED1.LEDD9 * 3 + 2];
      numArray619[index615] = (byte) num1851;
      byte[] numArray620 = second;
      int num1852 = num1850;
      int num1853 = num1852 + 1;
      int index616 = num1852;
      int num1854 = (int) numArray541[this.ucScreenLED1.LEDE9 * 3];
      numArray620[index616] = (byte) num1854;
      byte[] numArray621 = second;
      int num1855 = num1853;
      int num1856 = num1855 + 1;
      int index617 = num1855;
      int num1857 = (int) numArray541[this.ucScreenLED1.LEDE9 * 3 + 1];
      numArray621[index617] = (byte) num1857;
      byte[] numArray622 = second;
      int num1858 = num1856;
      int num1859 = num1858 + 1;
      int index618 = num1858;
      int num1860 = (int) numArray541[this.ucScreenLED1.LEDE9 * 3 + 2];
      numArray622[index618] = (byte) num1860;
      byte[] numArray623 = second;
      int num1861 = num1859;
      int num1862 = num1861 + 1;
      int index619 = num1861;
      int num1863 = (int) numArray541[this.ucScreenLED1.LEDG9 * 3];
      numArray623[index619] = (byte) num1863;
      byte[] numArray624 = second;
      int num1864 = num1862;
      int num1865 = num1864 + 1;
      int index620 = num1864;
      int num1866 = (int) numArray541[this.ucScreenLED1.LEDG9 * 3 + 1];
      numArray624[index620] = (byte) num1866;
      byte[] numArray625 = second;
      int num1867 = num1865;
      int num1868 = num1867 + 1;
      int index621 = num1867;
      int num1869 = (int) numArray541[this.ucScreenLED1.LEDG9 * 3 + 2];
      numArray625[index621] = (byte) num1869;
      byte[] numArray626 = second;
      int num1870 = num1868;
      int num1871 = num1870 + 1;
      int index622 = num1870;
      int num1872 = (int) numArray541[this.ucScreenLED1.LEDB9 * 3];
      numArray626[index622] = (byte) num1872;
      byte[] numArray627 = second;
      int num1873 = num1871;
      int num1874 = num1873 + 1;
      int index623 = num1873;
      int num1875 = (int) numArray541[this.ucScreenLED1.LEDB9 * 3 + 1];
      numArray627[index623] = (byte) num1875;
      byte[] numArray628 = second;
      int num1876 = num1874;
      int num1877 = num1876 + 1;
      int index624 = num1876;
      int num1878 = (int) numArray541[this.ucScreenLED1.LEDB9 * 3 + 2];
      numArray628[index624] = (byte) num1878;
      byte[] numArray629 = second;
      int num1879 = num1877;
      int num1880 = num1879 + 1;
      int index625 = num1879;
      int num1881 = (int) numArray541[this.ucScreenLED1.LEDA9 * 3];
      numArray629[index625] = (byte) num1881;
      byte[] numArray630 = second;
      int num1882 = num1880;
      int num1883 = num1882 + 1;
      int index626 = num1882;
      int num1884 = (int) numArray541[this.ucScreenLED1.LEDA9 * 3 + 1];
      numArray630[index626] = (byte) num1884;
      byte[] numArray631 = second;
      int num1885 = num1883;
      int num1886 = num1885 + 1;
      int index627 = num1885;
      int num1887 = (int) numArray541[this.ucScreenLED1.LEDA9 * 3 + 2];
      numArray631[index627] = (byte) num1887;
      byte[] numArray632 = second;
      int num1888 = num1886;
      int num1889 = num1888 + 1;
      int index628 = num1888;
      int num1890 = (int) numArray541[this.ucScreenLED1.LEDF9 * 3];
      numArray632[index628] = (byte) num1890;
      byte[] numArray633 = second;
      int num1891 = num1889;
      int num1892 = num1891 + 1;
      int index629 = num1891;
      int num1893 = (int) numArray541[this.ucScreenLED1.LEDF9 * 3 + 1];
      numArray633[index629] = (byte) num1893;
      byte[] numArray634 = second;
      int num1894 = num1892;
      int num1895 = num1894 + 1;
      int index630 = num1894;
      int num1896 = (int) numArray541[this.ucScreenLED1.LEDF9 * 3 + 2];
      numArray634[index630] = (byte) num1896;
      byte[] numArray635 = second;
      int num1897 = num1895;
      int num1898 = num1897 + 1;
      int index631 = num1897;
      int num1899 = (int) numArray541[this.ucScreenLED1.LEDC8 * 3];
      numArray635[index631] = (byte) num1899;
      byte[] numArray636 = second;
      int num1900 = num1898;
      int num1901 = num1900 + 1;
      int index632 = num1900;
      int num1902 = (int) numArray541[this.ucScreenLED1.LEDC8 * 3 + 1];
      numArray636[index632] = (byte) num1902;
      byte[] numArray637 = second;
      int num1903 = num1901;
      int num1904 = num1903 + 1;
      int index633 = num1903;
      int num1905 = (int) numArray541[this.ucScreenLED1.LEDC8 * 3 + 2];
      numArray637[index633] = (byte) num1905;
      byte[] numArray638 = second;
      int num1906 = num1904;
      int num1907 = num1906 + 1;
      int index634 = num1906;
      int num1908 = (int) numArray541[this.ucScreenLED1.LEDD8 * 3];
      numArray638[index634] = (byte) num1908;
      byte[] numArray639 = second;
      int num1909 = num1907;
      int num1910 = num1909 + 1;
      int index635 = num1909;
      int num1911 = (int) numArray541[this.ucScreenLED1.LEDD8 * 3 + 1];
      numArray639[index635] = (byte) num1911;
      byte[] numArray640 = second;
      int num1912 = num1910;
      int num1913 = num1912 + 1;
      int index636 = num1912;
      int num1914 = (int) numArray541[this.ucScreenLED1.LEDD8 * 3 + 2];
      numArray640[index636] = (byte) num1914;
      byte[] numArray641 = second;
      int num1915 = num1913;
      int num1916 = num1915 + 1;
      int index637 = num1915;
      int num1917 = (int) numArray541[this.ucScreenLED1.LEDE8 * 3];
      numArray641[index637] = (byte) num1917;
      byte[] numArray642 = second;
      int num1918 = num1916;
      int num1919 = num1918 + 1;
      int index638 = num1918;
      int num1920 = (int) numArray541[this.ucScreenLED1.LEDE8 * 3 + 1];
      numArray642[index638] = (byte) num1920;
      byte[] numArray643 = second;
      int num1921 = num1919;
      int num1922 = num1921 + 1;
      int index639 = num1921;
      int num1923 = (int) numArray541[this.ucScreenLED1.LEDE8 * 3 + 2];
      numArray643[index639] = (byte) num1923;
      byte[] numArray644 = second;
      int num1924 = num1922;
      int num1925 = num1924 + 1;
      int index640 = num1924;
      int num1926 = (int) numArray541[this.ucScreenLED1.LEDG8 * 3];
      numArray644[index640] = (byte) num1926;
      byte[] numArray645 = second;
      int num1927 = num1925;
      int num1928 = num1927 + 1;
      int index641 = num1927;
      int num1929 = (int) numArray541[this.ucScreenLED1.LEDG8 * 3 + 1];
      numArray645[index641] = (byte) num1929;
      byte[] numArray646 = second;
      int num1930 = num1928;
      int num1931 = num1930 + 1;
      int index642 = num1930;
      int num1932 = (int) numArray541[this.ucScreenLED1.LEDG8 * 3 + 2];
      numArray646[index642] = (byte) num1932;
      byte[] numArray647 = second;
      int num1933 = num1931;
      int num1934 = num1933 + 1;
      int index643 = num1933;
      int num1935 = (int) numArray541[this.ucScreenLED1.LEDB8 * 3];
      numArray647[index643] = (byte) num1935;
      byte[] numArray648 = second;
      int num1936 = num1934;
      int num1937 = num1936 + 1;
      int index644 = num1936;
      int num1938 = (int) numArray541[this.ucScreenLED1.LEDB8 * 3 + 1];
      numArray648[index644] = (byte) num1938;
      byte[] numArray649 = second;
      int num1939 = num1937;
      int num1940 = num1939 + 1;
      int index645 = num1939;
      int num1941 = (int) numArray541[this.ucScreenLED1.LEDB8 * 3 + 2];
      numArray649[index645] = (byte) num1941;
      byte[] numArray650 = second;
      int num1942 = num1940;
      int num1943 = num1942 + 1;
      int index646 = num1942;
      int num1944 = (int) numArray541[this.ucScreenLED1.LEDA8 * 3];
      numArray650[index646] = (byte) num1944;
      byte[] numArray651 = second;
      int num1945 = num1943;
      int num1946 = num1945 + 1;
      int index647 = num1945;
      int num1947 = (int) numArray541[this.ucScreenLED1.LEDA8 * 3 + 1];
      numArray651[index647] = (byte) num1947;
      byte[] numArray652 = second;
      int num1948 = num1946;
      int num1949 = num1948 + 1;
      int index648 = num1948;
      int num1950 = (int) numArray541[this.ucScreenLED1.LEDA8 * 3 + 2];
      numArray652[index648] = (byte) num1950;
      byte[] numArray653 = second;
      int num1951 = num1949;
      int num1952 = num1951 + 1;
      int index649 = num1951;
      int num1953 = (int) numArray541[this.ucScreenLED1.LEDF8 * 3];
      numArray653[index649] = (byte) num1953;
      byte[] numArray654 = second;
      int num1954 = num1952;
      int num1955 = num1954 + 1;
      int index650 = num1954;
      int num1956 = (int) numArray541[this.ucScreenLED1.LEDF8 * 3 + 1];
      numArray654[index650] = (byte) num1956;
      byte[] numArray655 = second;
      int num1957 = num1955;
      int num1958 = num1957 + 1;
      int index651 = num1957;
      int num1959 = (int) numArray541[this.ucScreenLED1.LEDF8 * 3 + 2];
      numArray655[index651] = (byte) num1959;
      byte[] numArray656 = second;
      int num1960 = num1958;
      int num1961 = num1960 + 1;
      int index652 = num1960;
      int num1962 = (int) numArray541[this.ucScreenLED1.LEDC7 * 3];
      numArray656[index652] = (byte) num1962;
      byte[] numArray657 = second;
      int num1963 = num1961;
      int num1964 = num1963 + 1;
      int index653 = num1963;
      int num1965 = (int) numArray541[this.ucScreenLED1.LEDC7 * 3 + 1];
      numArray657[index653] = (byte) num1965;
      byte[] numArray658 = second;
      int num1966 = num1964;
      int num1967 = num1966 + 1;
      int index654 = num1966;
      int num1968 = (int) numArray541[this.ucScreenLED1.LEDC7 * 3 + 2];
      numArray658[index654] = (byte) num1968;
      byte[] numArray659 = second;
      int num1969 = num1967;
      int num1970 = num1969 + 1;
      int index655 = num1969;
      int num1971 = (int) numArray541[this.ucScreenLED1.LEDD7 * 3];
      numArray659[index655] = (byte) num1971;
      byte[] numArray660 = second;
      int num1972 = num1970;
      int num1973 = num1972 + 1;
      int index656 = num1972;
      int num1974 = (int) numArray541[this.ucScreenLED1.LEDD7 * 3 + 1];
      numArray660[index656] = (byte) num1974;
      byte[] numArray661 = second;
      int num1975 = num1973;
      int num1976 = num1975 + 1;
      int index657 = num1975;
      int num1977 = (int) numArray541[this.ucScreenLED1.LEDD7 * 3 + 2];
      numArray661[index657] = (byte) num1977;
      byte[] numArray662 = second;
      int num1978 = num1976;
      int num1979 = num1978 + 1;
      int index658 = num1978;
      int num1980 = (int) numArray541[this.ucScreenLED1.LEDE7 * 3];
      numArray662[index658] = (byte) num1980;
      byte[] numArray663 = second;
      int num1981 = num1979;
      int num1982 = num1981 + 1;
      int index659 = num1981;
      int num1983 = (int) numArray541[this.ucScreenLED1.LEDE7 * 3 + 1];
      numArray663[index659] = (byte) num1983;
      byte[] numArray664 = second;
      int num1984 = num1982;
      int num1985 = num1984 + 1;
      int index660 = num1984;
      int num1986 = (int) numArray541[this.ucScreenLED1.LEDE7 * 3 + 2];
      numArray664[index660] = (byte) num1986;
      byte[] numArray665 = second;
      int num1987 = num1985;
      int num1988 = num1987 + 1;
      int index661 = num1987;
      int num1989 = (int) numArray541[this.ucScreenLED1.LEDG7 * 3];
      numArray665[index661] = (byte) num1989;
      byte[] numArray666 = second;
      int num1990 = num1988;
      int num1991 = num1990 + 1;
      int index662 = num1990;
      int num1992 = (int) numArray541[this.ucScreenLED1.LEDG7 * 3 + 1];
      numArray666[index662] = (byte) num1992;
      byte[] numArray667 = second;
      int num1993 = num1991;
      int num1994 = num1993 + 1;
      int index663 = num1993;
      int num1995 = (int) numArray541[this.ucScreenLED1.LEDG7 * 3 + 2];
      numArray667[index663] = (byte) num1995;
      byte[] numArray668 = second;
      int num1996 = num1994;
      int num1997 = num1996 + 1;
      int index664 = num1996;
      int num1998 = (int) numArray541[this.ucScreenLED1.LEDB7 * 3];
      numArray668[index664] = (byte) num1998;
      byte[] numArray669 = second;
      int num1999 = num1997;
      int num2000 = num1999 + 1;
      int index665 = num1999;
      int num2001 = (int) numArray541[this.ucScreenLED1.LEDB7 * 3 + 1];
      numArray669[index665] = (byte) num2001;
      byte[] numArray670 = second;
      int num2002 = num2000;
      int num2003 = num2002 + 1;
      int index666 = num2002;
      int num2004 = (int) numArray541[this.ucScreenLED1.LEDB7 * 3 + 2];
      numArray670[index666] = (byte) num2004;
      byte[] numArray671 = second;
      int num2005 = num2003;
      int num2006 = num2005 + 1;
      int index667 = num2005;
      int num2007 = (int) numArray541[this.ucScreenLED1.LEDA7 * 3];
      numArray671[index667] = (byte) num2007;
      byte[] numArray672 = second;
      int num2008 = num2006;
      int num2009 = num2008 + 1;
      int index668 = num2008;
      int num2010 = (int) numArray541[this.ucScreenLED1.LEDA7 * 3 + 1];
      numArray672[index668] = (byte) num2010;
      byte[] numArray673 = second;
      int num2011 = num2009;
      int num2012 = num2011 + 1;
      int index669 = num2011;
      int num2013 = (int) numArray541[this.ucScreenLED1.LEDA7 * 3 + 2];
      numArray673[index669] = (byte) num2013;
      byte[] numArray674 = second;
      int num2014 = num2012;
      int num2015 = num2014 + 1;
      int index670 = num2014;
      int num2016 = (int) numArray541[this.ucScreenLED1.LEDF7 * 3];
      numArray674[index670] = (byte) num2016;
      byte[] numArray675 = second;
      int num2017 = num2015;
      int num2018 = num2017 + 1;
      int index671 = num2017;
      int num2019 = (int) numArray541[this.ucScreenLED1.LEDF7 * 3 + 1];
      numArray675[index671] = (byte) num2019;
      byte[] numArray676 = second;
      int num2020 = num2018;
      int num2021 = num2020 + 1;
      int index672 = num2020;
      int num2022 = (int) numArray541[this.ucScreenLED1.LEDF7 * 3 + 2];
      numArray676[index672] = (byte) num2022;
      byte[] numArray677 = second;
      int num2023 = num2021;
      int num2024 = num2023 + 1;
      int index673 = num2023;
      int num2025 = (int) numArray541[this.ucScreenLED1.LEDE1 * 3];
      numArray677[index673] = (byte) num2025;
      byte[] numArray678 = second;
      int num2026 = num2024;
      int num2027 = num2026 + 1;
      int index674 = num2026;
      int num2028 = (int) numArray541[this.ucScreenLED1.LEDE1 * 3 + 1];
      numArray678[index674] = (byte) num2028;
      byte[] numArray679 = second;
      int num2029 = num2027;
      int num2030 = num2029 + 1;
      int index675 = num2029;
      int num2031 = (int) numArray541[this.ucScreenLED1.LEDE1 * 3 + 2];
      numArray679[index675] = (byte) num2031;
      byte[] numArray680 = second;
      int num2032 = num2030;
      int num2033 = num2032 + 1;
      int index676 = num2032;
      int num2034 = (int) numArray541[this.ucScreenLED1.LEDD1 * 3];
      numArray680[index676] = (byte) num2034;
      byte[] numArray681 = second;
      int num2035 = num2033;
      int num2036 = num2035 + 1;
      int index677 = num2035;
      int num2037 = (int) numArray541[this.ucScreenLED1.LEDD1 * 3 + 1];
      numArray681[index677] = (byte) num2037;
      byte[] numArray682 = second;
      int num2038 = num2036;
      int num2039 = num2038 + 1;
      int index678 = num2038;
      int num2040 = (int) numArray541[this.ucScreenLED1.LEDD1 * 3 + 2];
      numArray682[index678] = (byte) num2040;
      byte[] numArray683 = second;
      int num2041 = num2039;
      int num2042 = num2041 + 1;
      int index679 = num2041;
      int num2043 = (int) numArray541[this.ucScreenLED1.LEDC1 * 3];
      numArray683[index679] = (byte) num2043;
      byte[] numArray684 = second;
      int num2044 = num2042;
      int num2045 = num2044 + 1;
      int index680 = num2044;
      int num2046 = (int) numArray541[this.ucScreenLED1.LEDC1 * 3 + 1];
      numArray684[index680] = (byte) num2046;
      byte[] numArray685 = second;
      int num2047 = num2045;
      int num2048 = num2047 + 1;
      int index681 = num2047;
      int num2049 = (int) numArray541[this.ucScreenLED1.LEDC1 * 3 + 2];
      numArray685[index681] = (byte) num2049;
      byte[] numArray686 = second;
      int num2050 = num2048;
      int num2051 = num2050 + 1;
      int index682 = num2050;
      int num2052 = (int) numArray541[this.ucScreenLED1.LEDG1 * 3];
      numArray686[index682] = (byte) num2052;
      byte[] numArray687 = second;
      int num2053 = num2051;
      int num2054 = num2053 + 1;
      int index683 = num2053;
      int num2055 = (int) numArray541[this.ucScreenLED1.LEDG1 * 3 + 1];
      numArray687[index683] = (byte) num2055;
      byte[] numArray688 = second;
      int num2056 = num2054;
      int num2057 = num2056 + 1;
      int index684 = num2056;
      int num2058 = (int) numArray541[this.ucScreenLED1.LEDG1 * 3 + 2];
      numArray688[index684] = (byte) num2058;
      byte[] numArray689 = second;
      int num2059 = num2057;
      int num2060 = num2059 + 1;
      int index685 = num2059;
      int num2061 = (int) numArray541[this.ucScreenLED1.LEDF1 * 3];
      numArray689[index685] = (byte) num2061;
      byte[] numArray690 = second;
      int num2062 = num2060;
      int num2063 = num2062 + 1;
      int index686 = num2062;
      int num2064 = (int) numArray541[this.ucScreenLED1.LEDF1 * 3 + 1];
      numArray690[index686] = (byte) num2064;
      byte[] numArray691 = second;
      int num2065 = num2063;
      int num2066 = num2065 + 1;
      int index687 = num2065;
      int num2067 = (int) numArray541[this.ucScreenLED1.LEDF1 * 3 + 2];
      numArray691[index687] = (byte) num2067;
      byte[] numArray692 = second;
      int num2068 = num2066;
      int num2069 = num2068 + 1;
      int index688 = num2068;
      int num2070 = (int) numArray541[this.ucScreenLED1.LEDA1 * 3];
      numArray692[index688] = (byte) num2070;
      byte[] numArray693 = second;
      int num2071 = num2069;
      int num2072 = num2071 + 1;
      int index689 = num2071;
      int num2073 = (int) numArray541[this.ucScreenLED1.LEDA1 * 3 + 1];
      numArray693[index689] = (byte) num2073;
      byte[] numArray694 = second;
      int num2074 = num2072;
      int num2075 = num2074 + 1;
      int index690 = num2074;
      int num2076 = (int) numArray541[this.ucScreenLED1.LEDA1 * 3 + 2];
      numArray694[index690] = (byte) num2076;
      byte[] numArray695 = second;
      int num2077 = num2075;
      int num2078 = num2077 + 1;
      int index691 = num2077;
      int num2079 = (int) numArray541[this.ucScreenLED1.Cpu1 * 3];
      numArray695[index691] = (byte) num2079;
      byte[] numArray696 = second;
      int num2080 = num2078;
      int num2081 = num2080 + 1;
      int index692 = num2080;
      int num2082 = (int) numArray541[this.ucScreenLED1.Cpu1 * 3 + 1];
      numArray696[index692] = (byte) num2082;
      byte[] numArray697 = second;
      int num2083 = num2081;
      int num2084 = num2083 + 1;
      int index693 = num2083;
      int num2085 = (int) numArray541[this.ucScreenLED1.Cpu1 * 3 + 2];
      numArray697[index693] = (byte) num2085;
      byte[] numArray698 = second;
      int num2086 = num2084;
      int num2087 = num2086 + 1;
      int index694 = num2086;
      int num2088 = (int) numArray541[this.ucScreenLED1.LEDB1 * 3];
      numArray698[index694] = (byte) num2088;
      byte[] numArray699 = second;
      int num2089 = num2087;
      int num2090 = num2089 + 1;
      int index695 = num2089;
      int num2091 = (int) numArray541[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray699[index695] = (byte) num2091;
      byte[] numArray700 = second;
      int num2092 = num2090;
      int num2093 = num2092 + 1;
      int index696 = num2092;
      int num2094 = (int) numArray541[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray700[index696] = (byte) num2094;
      byte[] numArray701 = second;
      int num2095 = num2093;
      int num2096 = num2095 + 1;
      int index697 = num2095;
      int num2097 = (int) numArray541[this.ucScreenLED1.LEDE2 * 3];
      numArray701[index697] = (byte) num2097;
      byte[] numArray702 = second;
      int num2098 = num2096;
      int num2099 = num2098 + 1;
      int index698 = num2098;
      int num2100 = (int) numArray541[this.ucScreenLED1.LEDE2 * 3 + 1];
      numArray702[index698] = (byte) num2100;
      byte[] numArray703 = second;
      int num2101 = num2099;
      int num2102 = num2101 + 1;
      int index699 = num2101;
      int num2103 = (int) numArray541[this.ucScreenLED1.LEDE2 * 3 + 2];
      numArray703[index699] = (byte) num2103;
      byte[] numArray704 = second;
      int num2104 = num2102;
      int num2105 = num2104 + 1;
      int index700 = num2104;
      int num2106 = (int) numArray541[this.ucScreenLED1.LEDD2 * 3];
      numArray704[index700] = (byte) num2106;
      byte[] numArray705 = second;
      int num2107 = num2105;
      int num2108 = num2107 + 1;
      int index701 = num2107;
      int num2109 = (int) numArray541[this.ucScreenLED1.LEDD2 * 3 + 1];
      numArray705[index701] = (byte) num2109;
      byte[] numArray706 = second;
      int num2110 = num2108;
      int num2111 = num2110 + 1;
      int index702 = num2110;
      int num2112 = (int) numArray541[this.ucScreenLED1.LEDD2 * 3 + 2];
      numArray706[index702] = (byte) num2112;
      byte[] numArray707 = second;
      int num2113 = num2111;
      int num2114 = num2113 + 1;
      int index703 = num2113;
      int num2115 = (int) numArray541[this.ucScreenLED1.LEDC2 * 3];
      numArray707[index703] = (byte) num2115;
      byte[] numArray708 = second;
      int num2116 = num2114;
      int num2117 = num2116 + 1;
      int index704 = num2116;
      int num2118 = (int) numArray541[this.ucScreenLED1.LEDC2 * 3 + 1];
      numArray708[index704] = (byte) num2118;
      byte[] numArray709 = second;
      int num2119 = num2117;
      int num2120 = num2119 + 1;
      int index705 = num2119;
      int num2121 = (int) numArray541[this.ucScreenLED1.LEDC2 * 3 + 2];
      numArray709[index705] = (byte) num2121;
      byte[] numArray710 = second;
      int num2122 = num2120;
      int num2123 = num2122 + 1;
      int index706 = num2122;
      int num2124 = (int) numArray541[this.ucScreenLED1.LEDG2 * 3];
      numArray710[index706] = (byte) num2124;
      byte[] numArray711 = second;
      int num2125 = num2123;
      int num2126 = num2125 + 1;
      int index707 = num2125;
      int num2127 = (int) numArray541[this.ucScreenLED1.LEDG2 * 3 + 1];
      numArray711[index707] = (byte) num2127;
      byte[] numArray712 = second;
      int num2128 = num2126;
      int num2129 = num2128 + 1;
      int index708 = num2128;
      int num2130 = (int) numArray541[this.ucScreenLED1.LEDG2 * 3 + 2];
      numArray712[index708] = (byte) num2130;
      byte[] numArray713 = second;
      int num2131 = num2129;
      int num2132 = num2131 + 1;
      int index709 = num2131;
      int num2133 = (int) numArray541[this.ucScreenLED1.LEDF2 * 3];
      numArray713[index709] = (byte) num2133;
      byte[] numArray714 = second;
      int num2134 = num2132;
      int num2135 = num2134 + 1;
      int index710 = num2134;
      int num2136 = (int) numArray541[this.ucScreenLED1.LEDF2 * 3 + 1];
      numArray714[index710] = (byte) num2136;
      byte[] numArray715 = second;
      int num2137 = num2135;
      int num2138 = num2137 + 1;
      int index711 = num2137;
      int num2139 = (int) numArray541[this.ucScreenLED1.LEDF2 * 3 + 2];
      numArray715[index711] = (byte) num2139;
      byte[] numArray716 = second;
      int num2140 = num2138;
      int num2141 = num2140 + 1;
      int index712 = num2140;
      int num2142 = (int) numArray541[this.ucScreenLED1.LEDA2 * 3];
      numArray716[index712] = (byte) num2142;
      byte[] numArray717 = second;
      int num2143 = num2141;
      int num2144 = num2143 + 1;
      int index713 = num2143;
      int num2145 = (int) numArray541[this.ucScreenLED1.LEDA2 * 3 + 1];
      numArray717[index713] = (byte) num2145;
      byte[] numArray718 = second;
      int num2146 = num2144;
      int num2147 = num2146 + 1;
      int index714 = num2146;
      int num2148 = (int) numArray541[this.ucScreenLED1.LEDA2 * 3 + 2];
      numArray718[index714] = (byte) num2148;
      byte[] numArray719 = second;
      int num2149 = num2147;
      int num2150 = num2149 + 1;
      int index715 = num2149;
      int num2151 = (int) numArray541[this.ucScreenLED1.Gpu1 * 3];
      numArray719[index715] = (byte) num2151;
      byte[] numArray720 = second;
      int num2152 = num2150;
      int num2153 = num2152 + 1;
      int index716 = num2152;
      int num2154 = (int) numArray541[this.ucScreenLED1.Gpu1 * 3 + 1];
      numArray720[index716] = (byte) num2154;
      byte[] numArray721 = second;
      int num2155 = num2153;
      int num2156 = num2155 + 1;
      int index717 = num2155;
      int num2157 = (int) numArray541[this.ucScreenLED1.Gpu1 * 3 + 2];
      numArray721[index717] = (byte) num2157;
      byte[] numArray722 = second;
      int num2158 = num2156;
      int num2159 = num2158 + 1;
      int index718 = num2158;
      int num2160 = (int) numArray541[this.ucScreenLED1.LEDB2 * 3];
      numArray722[index718] = (byte) num2160;
      byte[] numArray723 = second;
      int num2161 = num2159;
      int num2162 = num2161 + 1;
      int index719 = num2161;
      int num2163 = (int) numArray541[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray723[index719] = (byte) num2163;
      byte[] numArray724 = second;
      int num2164 = num2162;
      int num2165 = num2164 + 1;
      int index720 = num2164;
      int num2166 = (int) numArray541[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray724[index720] = (byte) num2166;
      byte[] numArray725 = second;
      int num2167 = num2165;
      int num2168 = num2167 + 1;
      int index721 = num2167;
      int num2169 = (int) numArray541[this.ucScreenLED1.LEDE3 * 3];
      numArray725[index721] = (byte) num2169;
      byte[] numArray726 = second;
      int num2170 = num2168;
      int num2171 = num2170 + 1;
      int index722 = num2170;
      int num2172 = (int) numArray541[this.ucScreenLED1.LEDE3 * 3 + 1];
      numArray726[index722] = (byte) num2172;
      byte[] numArray727 = second;
      int num2173 = num2171;
      int num2174 = num2173 + 1;
      int index723 = num2173;
      int num2175 = (int) numArray541[this.ucScreenLED1.LEDE3 * 3 + 2];
      numArray727[index723] = (byte) num2175;
      byte[] numArray728 = second;
      int num2176 = num2174;
      int num2177 = num2176 + 1;
      int index724 = num2176;
      int num2178 = (int) numArray541[this.ucScreenLED1.LEDD3 * 3];
      numArray728[index724] = (byte) num2178;
      byte[] numArray729 = second;
      int num2179 = num2177;
      int num2180 = num2179 + 1;
      int index725 = num2179;
      int num2181 = (int) numArray541[this.ucScreenLED1.LEDD3 * 3 + 1];
      numArray729[index725] = (byte) num2181;
      byte[] numArray730 = second;
      int num2182 = num2180;
      int num2183 = num2182 + 1;
      int index726 = num2182;
      int num2184 = (int) numArray541[this.ucScreenLED1.LEDD3 * 3 + 2];
      numArray730[index726] = (byte) num2184;
      byte[] numArray731 = second;
      int num2185 = num2183;
      int num2186 = num2185 + 1;
      int index727 = num2185;
      int num2187 = (int) numArray541[this.ucScreenLED1.LEDC3 * 3];
      numArray731[index727] = (byte) num2187;
      byte[] numArray732 = second;
      int num2188 = num2186;
      int num2189 = num2188 + 1;
      int index728 = num2188;
      int num2190 = (int) numArray541[this.ucScreenLED1.LEDC3 * 3 + 1];
      numArray732[index728] = (byte) num2190;
      byte[] numArray733 = second;
      int num2191 = num2189;
      int num2192 = num2191 + 1;
      int index729 = num2191;
      int num2193 = (int) numArray541[this.ucScreenLED1.LEDC3 * 3 + 2];
      numArray733[index729] = (byte) num2193;
      byte[] numArray734 = second;
      int num2194 = num2192;
      int num2195 = num2194 + 1;
      int index730 = num2194;
      int num2196 = (int) numArray541[this.ucScreenLED1.LEDG3 * 3];
      numArray734[index730] = (byte) num2196;
      byte[] numArray735 = second;
      int num2197 = num2195;
      int num2198 = num2197 + 1;
      int index731 = num2197;
      int num2199 = (int) numArray541[this.ucScreenLED1.LEDG3 * 3 + 1];
      numArray735[index731] = (byte) num2199;
      byte[] numArray736 = second;
      int num2200 = num2198;
      int num2201 = num2200 + 1;
      int index732 = num2200;
      int num2202 = (int) numArray541[this.ucScreenLED1.LEDG3 * 3 + 2];
      numArray736[index732] = (byte) num2202;
      byte[] numArray737 = second;
      int num2203 = num2201;
      int num2204 = num2203 + 1;
      int index733 = num2203;
      int num2205 = (int) numArray541[this.ucScreenLED1.LEDF3 * 3];
      numArray737[index733] = (byte) num2205;
      byte[] numArray738 = second;
      int num2206 = num2204;
      int num2207 = num2206 + 1;
      int index734 = num2206;
      int num2208 = (int) numArray541[this.ucScreenLED1.LEDF3 * 3 + 1];
      numArray738[index734] = (byte) num2208;
      byte[] numArray739 = second;
      int num2209 = num2207;
      int num2210 = num2209 + 1;
      int index735 = num2209;
      int num2211 = (int) numArray541[this.ucScreenLED1.LEDF3 * 3 + 2];
      numArray739[index735] = (byte) num2211;
      byte[] numArray740 = second;
      int num2212 = num2210;
      int num2213 = num2212 + 1;
      int index736 = num2212;
      int num2214 = (int) numArray541[this.ucScreenLED1.LEDA3 * 3];
      numArray740[index736] = (byte) num2214;
      byte[] numArray741 = second;
      int num2215 = num2213;
      int num2216 = num2215 + 1;
      int index737 = num2215;
      int num2217 = (int) numArray541[this.ucScreenLED1.LEDA3 * 3 + 1];
      numArray741[index737] = (byte) num2217;
      byte[] numArray742 = second;
      int num2218 = num2216;
      int num2219 = num2218 + 1;
      int index738 = num2218;
      int num2220 = (int) numArray541[this.ucScreenLED1.LEDA3 * 3 + 2];
      numArray742[index738] = (byte) num2220;
      byte[] numArray743 = second;
      int num2221 = num2219;
      int num2222 = num2221 + 1;
      int index739 = num2221;
      int num2223 = (int) numArray541[this.ucScreenLED1.LEDB3 * 3];
      numArray743[index739] = (byte) num2223;
      byte[] numArray744 = second;
      int num2224 = num2222;
      int num2225 = num2224 + 1;
      int index740 = num2224;
      int num2226 = (int) numArray541[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray744[index740] = (byte) num2226;
      byte[] numArray745 = second;
      int num2227 = num2225;
      int num2228 = num2227 + 1;
      int index741 = num2227;
      int num2229 = (int) numArray541[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray745[index741] = (byte) num2229;
      byte[] numArray746 = second;
      int num2230 = num2228;
      int num2231 = num2230 + 1;
      int index742 = num2230;
      int num2232 = (int) numArray541[this.ucScreenLED1.HSD * 3];
      numArray746[index742] = (byte) num2232;
      byte[] numArray747 = second;
      int num2233 = num2231;
      int num2234 = num2233 + 1;
      int index743 = num2233;
      int num2235 = (int) numArray541[this.ucScreenLED1.HSD * 3 + 1];
      numArray747[index743] = (byte) num2235;
      byte[] numArray748 = second;
      int num2236 = num2234;
      int num2237 = num2236 + 1;
      int index744 = num2236;
      int num2238 = (int) numArray541[this.ucScreenLED1.HSD * 3 + 2];
      numArray748[index744] = (byte) num2238;
      byte[] numArray749 = second;
      int num2239 = num2237;
      int num2240 = num2239 + 1;
      int index745 = num2239;
      int num2241 = (int) numArray541[this.ucScreenLED1.SSD * 3];
      numArray749[index745] = (byte) num2241;
      byte[] numArray750 = second;
      int num2242 = num2240;
      int num2243 = num2242 + 1;
      int index746 = num2242;
      int num2244 = (int) numArray541[this.ucScreenLED1.SSD * 3 + 1];
      numArray750[index746] = (byte) num2244;
      byte[] numArray751 = second;
      int num2245 = num2243;
      int num2246 = num2245 + 1;
      int index747 = num2245;
      int num2247 = (int) numArray541[this.ucScreenLED1.SSD * 3 + 2];
      numArray751[index747] = (byte) num2247;
      byte[] numArray752 = second;
      int num2248 = num2246;
      int num2249 = num2248 + 1;
      int index748 = num2248;
      int num2250 = (int) numArray541[this.ucScreenLED1.LEDE4 * 3];
      numArray752[index748] = (byte) num2250;
      byte[] numArray753 = second;
      int num2251 = num2249;
      int num2252 = num2251 + 1;
      int index749 = num2251;
      int num2253 = (int) numArray541[this.ucScreenLED1.LEDE4 * 3 + 1];
      numArray753[index749] = (byte) num2253;
      byte[] numArray754 = second;
      int num2254 = num2252;
      int num2255 = num2254 + 1;
      int index750 = num2254;
      int num2256 = (int) numArray541[this.ucScreenLED1.LEDE4 * 3 + 2];
      numArray754[index750] = (byte) num2256;
      byte[] numArray755 = second;
      int num2257 = num2255;
      int num2258 = num2257 + 1;
      int index751 = num2257;
      int num2259 = (int) numArray541[this.ucScreenLED1.LEDD4 * 3];
      numArray755[index751] = (byte) num2259;
      byte[] numArray756 = second;
      int num2260 = num2258;
      int num2261 = num2260 + 1;
      int index752 = num2260;
      int num2262 = (int) numArray541[this.ucScreenLED1.LEDD4 * 3 + 1];
      numArray756[index752] = (byte) num2262;
      byte[] numArray757 = second;
      int num2263 = num2261;
      int num2264 = num2263 + 1;
      int index753 = num2263;
      int num2265 = (int) numArray541[this.ucScreenLED1.LEDD4 * 3 + 2];
      numArray757[index753] = (byte) num2265;
      byte[] numArray758 = second;
      int num2266 = num2264;
      int num2267 = num2266 + 1;
      int index754 = num2266;
      int num2268 = (int) numArray541[this.ucScreenLED1.LEDC4 * 3];
      numArray758[index754] = (byte) num2268;
      byte[] numArray759 = second;
      int num2269 = num2267;
      int num2270 = num2269 + 1;
      int index755 = num2269;
      int num2271 = (int) numArray541[this.ucScreenLED1.LEDC4 * 3 + 1];
      numArray759[index755] = (byte) num2271;
      byte[] numArray760 = second;
      int num2272 = num2270;
      int num2273 = num2272 + 1;
      int index756 = num2272;
      int num2274 = (int) numArray541[this.ucScreenLED1.LEDC4 * 3 + 2];
      numArray760[index756] = (byte) num2274;
      byte[] numArray761 = second;
      int num2275 = num2273;
      int num2276 = num2275 + 1;
      int index757 = num2275;
      int num2277 = (int) numArray541[this.ucScreenLED1.LEDG4 * 3];
      numArray761[index757] = (byte) num2277;
      byte[] numArray762 = second;
      int num2278 = num2276;
      int num2279 = num2278 + 1;
      int index758 = num2278;
      int num2280 = (int) numArray541[this.ucScreenLED1.LEDG4 * 3 + 1];
      numArray762[index758] = (byte) num2280;
      byte[] numArray763 = second;
      int num2281 = num2279;
      int num2282 = num2281 + 1;
      int index759 = num2281;
      int num2283 = (int) numArray541[this.ucScreenLED1.LEDG4 * 3 + 2];
      numArray763[index759] = (byte) num2283;
      byte[] numArray764 = second;
      int num2284 = num2282;
      int num2285 = num2284 + 1;
      int index760 = num2284;
      int num2286 = (int) numArray541[this.ucScreenLED1.LEDF4 * 3];
      numArray764[index760] = (byte) num2286;
      byte[] numArray765 = second;
      int num2287 = num2285;
      int num2288 = num2287 + 1;
      int index761 = num2287;
      int num2289 = (int) numArray541[this.ucScreenLED1.LEDF4 * 3 + 1];
      numArray765[index761] = (byte) num2289;
      byte[] numArray766 = second;
      int num2290 = num2288;
      int num2291 = num2290 + 1;
      int index762 = num2290;
      int num2292 = (int) numArray541[this.ucScreenLED1.LEDF4 * 3 + 2];
      numArray766[index762] = (byte) num2292;
      byte[] numArray767 = second;
      int num2293 = num2291;
      int num2294 = num2293 + 1;
      int index763 = num2293;
      int num2295 = (int) numArray541[this.ucScreenLED1.LEDA4 * 3];
      numArray767[index763] = (byte) num2295;
      byte[] numArray768 = second;
      int num2296 = num2294;
      int num2297 = num2296 + 1;
      int index764 = num2296;
      int num2298 = (int) numArray541[this.ucScreenLED1.LEDA4 * 3 + 1];
      numArray768[index764] = (byte) num2298;
      byte[] numArray769 = second;
      int num2299 = num2297;
      int num2300 = num2299 + 1;
      int index765 = num2299;
      int num2301 = (int) numArray541[this.ucScreenLED1.LEDA4 * 3 + 2];
      numArray769[index765] = (byte) num2301;
      byte[] numArray770 = second;
      int num2302 = num2300;
      int num2303 = num2302 + 1;
      int index766 = num2302;
      int num2304 = (int) numArray541[this.ucScreenLED1.LEDB4 * 3];
      numArray770[index766] = (byte) num2304;
      byte[] numArray771 = second;
      int num2305 = num2303;
      int num2306 = num2305 + 1;
      int index767 = num2305;
      int num2307 = (int) numArray541[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray771[index767] = (byte) num2307;
      byte[] numArray772 = second;
      int num2308 = num2306;
      int num2309 = num2308 + 1;
      int index768 = num2308;
      int num2310 = (int) numArray541[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray772[index768] = (byte) num2310;
      byte[] numArray773 = second;
      int num2311 = num2309;
      int num2312 = num2311 + 1;
      int index769 = num2311;
      int num2313 = (int) numArray541[this.ucScreenLED1.LEDE5 * 3];
      numArray773[index769] = (byte) num2313;
      byte[] numArray774 = second;
      int num2314 = num2312;
      int num2315 = num2314 + 1;
      int index770 = num2314;
      int num2316 = (int) numArray541[this.ucScreenLED1.LEDE5 * 3 + 1];
      numArray774[index770] = (byte) num2316;
      byte[] numArray775 = second;
      int num2317 = num2315;
      int num2318 = num2317 + 1;
      int index771 = num2317;
      int num2319 = (int) numArray541[this.ucScreenLED1.LEDE5 * 3 + 2];
      numArray775[index771] = (byte) num2319;
      byte[] numArray776 = second;
      int num2320 = num2318;
      int num2321 = num2320 + 1;
      int index772 = num2320;
      int num2322 = (int) numArray541[this.ucScreenLED1.LEDD5 * 3];
      numArray776[index772] = (byte) num2322;
      byte[] numArray777 = second;
      int num2323 = num2321;
      int num2324 = num2323 + 1;
      int index773 = num2323;
      int num2325 = (int) numArray541[this.ucScreenLED1.LEDD5 * 3 + 1];
      numArray777[index773] = (byte) num2325;
      byte[] numArray778 = second;
      int num2326 = num2324;
      int num2327 = num2326 + 1;
      int index774 = num2326;
      int num2328 = (int) numArray541[this.ucScreenLED1.LEDD5 * 3 + 2];
      numArray778[index774] = (byte) num2328;
      byte[] numArray779 = second;
      int num2329 = num2327;
      int num2330 = num2329 + 1;
      int index775 = num2329;
      int num2331 = (int) numArray541[this.ucScreenLED1.LEDC5 * 3];
      numArray779[index775] = (byte) num2331;
      byte[] numArray780 = second;
      int num2332 = num2330;
      int num2333 = num2332 + 1;
      int index776 = num2332;
      int num2334 = (int) numArray541[this.ucScreenLED1.LEDC5 * 3 + 1];
      numArray780[index776] = (byte) num2334;
      byte[] numArray781 = second;
      int num2335 = num2333;
      int num2336 = num2335 + 1;
      int index777 = num2335;
      int num2337 = (int) numArray541[this.ucScreenLED1.LEDC5 * 3 + 2];
      numArray781[index777] = (byte) num2337;
      byte[] numArray782 = second;
      int num2338 = num2336;
      int num2339 = num2338 + 1;
      int index778 = num2338;
      int num2340 = (int) numArray541[this.ucScreenLED1.LEDG5 * 3];
      numArray782[index778] = (byte) num2340;
      byte[] numArray783 = second;
      int num2341 = num2339;
      int num2342 = num2341 + 1;
      int index779 = num2341;
      int num2343 = (int) numArray541[this.ucScreenLED1.LEDG5 * 3 + 1];
      numArray783[index779] = (byte) num2343;
      byte[] numArray784 = second;
      int num2344 = num2342;
      int num2345 = num2344 + 1;
      int index780 = num2344;
      int num2346 = (int) numArray541[this.ucScreenLED1.LEDG5 * 3 + 2];
      numArray784[index780] = (byte) num2346;
      byte[] numArray785 = second;
      int num2347 = num2345;
      int num2348 = num2347 + 1;
      int index781 = num2347;
      int num2349 = (int) numArray541[this.ucScreenLED1.LEDF5 * 3];
      numArray785[index781] = (byte) num2349;
      byte[] numArray786 = second;
      int num2350 = num2348;
      int num2351 = num2350 + 1;
      int index782 = num2350;
      int num2352 = (int) numArray541[this.ucScreenLED1.LEDF5 * 3 + 1];
      numArray786[index782] = (byte) num2352;
      byte[] numArray787 = second;
      int num2353 = num2351;
      int num2354 = num2353 + 1;
      int index783 = num2353;
      int num2355 = (int) numArray541[this.ucScreenLED1.LEDF5 * 3 + 2];
      numArray787[index783] = (byte) num2355;
      byte[] numArray788 = second;
      int num2356 = num2354;
      int num2357 = num2356 + 1;
      int index784 = num2356;
      int num2358 = (int) numArray541[this.ucScreenLED1.LEDA5 * 3];
      numArray788[index784] = (byte) num2358;
      byte[] numArray789 = second;
      int num2359 = num2357;
      int num2360 = num2359 + 1;
      int index785 = num2359;
      int num2361 = (int) numArray541[this.ucScreenLED1.LEDA5 * 3 + 1];
      numArray789[index785] = (byte) num2361;
      byte[] numArray790 = second;
      int num2362 = num2360;
      int num2363 = num2362 + 1;
      int index786 = num2362;
      int num2364 = (int) numArray541[this.ucScreenLED1.LEDA5 * 3 + 2];
      numArray790[index786] = (byte) num2364;
      byte[] numArray791 = second;
      int num2365 = num2363;
      int num2366 = num2365 + 1;
      int index787 = num2365;
      int num2367 = (int) numArray541[this.ucScreenLED1.LEDB5 * 3];
      numArray791[index787] = (byte) num2367;
      byte[] numArray792 = second;
      int num2368 = num2366;
      int num2369 = num2368 + 1;
      int index788 = num2368;
      int num2370 = (int) numArray541[this.ucScreenLED1.LEDB5 * 3 + 1];
      numArray792[index788] = (byte) num2370;
      byte[] numArray793 = second;
      int num2371 = num2369;
      int num2372 = num2371 + 1;
      int index789 = num2371;
      int num2373 = (int) numArray541[this.ucScreenLED1.LEDB5 * 3 + 2];
      numArray793[index789] = (byte) num2373;
      byte[] numArray794 = second;
      int num2374 = num2372;
      int num2375 = num2374 + 1;
      int index790 = num2374;
      int num2376 = (int) numArray541[this.ucScreenLED1.LEDE6 * 3];
      numArray794[index790] = (byte) num2376;
      byte[] numArray795 = second;
      int num2377 = num2375;
      int num2378 = num2377 + 1;
      int index791 = num2377;
      int num2379 = (int) numArray541[this.ucScreenLED1.LEDE6 * 3 + 1];
      numArray795[index791] = (byte) num2379;
      byte[] numArray796 = second;
      int num2380 = num2378;
      int num2381 = num2380 + 1;
      int index792 = num2380;
      int num2382 = (int) numArray541[this.ucScreenLED1.LEDE6 * 3 + 2];
      numArray796[index792] = (byte) num2382;
      byte[] numArray797 = second;
      int num2383 = num2381;
      int num2384 = num2383 + 1;
      int index793 = num2383;
      int num2385 = (int) numArray541[this.ucScreenLED1.LEDD6 * 3];
      numArray797[index793] = (byte) num2385;
      byte[] numArray798 = second;
      int num2386 = num2384;
      int num2387 = num2386 + 1;
      int index794 = num2386;
      int num2388 = (int) numArray541[this.ucScreenLED1.LEDD6 * 3 + 1];
      numArray798[index794] = (byte) num2388;
      byte[] numArray799 = second;
      int num2389 = num2387;
      int num2390 = num2389 + 1;
      int index795 = num2389;
      int num2391 = (int) numArray541[this.ucScreenLED1.LEDD6 * 3 + 2];
      numArray799[index795] = (byte) num2391;
      byte[] numArray800 = second;
      int num2392 = num2390;
      int num2393 = num2392 + 1;
      int index796 = num2392;
      int num2394 = (int) numArray541[this.ucScreenLED1.LEDC6 * 3];
      numArray800[index796] = (byte) num2394;
      byte[] numArray801 = second;
      int num2395 = num2393;
      int num2396 = num2395 + 1;
      int index797 = num2395;
      int num2397 = (int) numArray541[this.ucScreenLED1.LEDC6 * 3 + 1];
      numArray801[index797] = (byte) num2397;
      byte[] numArray802 = second;
      int num2398 = num2396;
      int num2399 = num2398 + 1;
      int index798 = num2398;
      int num2400 = (int) numArray541[this.ucScreenLED1.LEDC6 * 3 + 2];
      numArray802[index798] = (byte) num2400;
      byte[] numArray803 = second;
      int num2401 = num2399;
      int num2402 = num2401 + 1;
      int index799 = num2401;
      int num2403 = (int) numArray541[this.ucScreenLED1.LEDG6 * 3];
      numArray803[index799] = (byte) num2403;
      byte[] numArray804 = second;
      int num2404 = num2402;
      int num2405 = num2404 + 1;
      int index800 = num2404;
      int num2406 = (int) numArray541[this.ucScreenLED1.LEDG6 * 3 + 1];
      numArray804[index800] = (byte) num2406;
      byte[] numArray805 = second;
      int num2407 = num2405;
      int num2408 = num2407 + 1;
      int index801 = num2407;
      int num2409 = (int) numArray541[this.ucScreenLED1.LEDG6 * 3 + 2];
      numArray805[index801] = (byte) num2409;
      byte[] numArray806 = second;
      int num2410 = num2408;
      int num2411 = num2410 + 1;
      int index802 = num2410;
      int num2412 = (int) numArray541[this.ucScreenLED1.LEDF6 * 3];
      numArray806[index802] = (byte) num2412;
      byte[] numArray807 = second;
      int num2413 = num2411;
      int num2414 = num2413 + 1;
      int index803 = num2413;
      int num2415 = (int) numArray541[this.ucScreenLED1.LEDF6 * 3 + 1];
      numArray807[index803] = (byte) num2415;
      byte[] numArray808 = second;
      int num2416 = num2414;
      int num2417 = num2416 + 1;
      int index804 = num2416;
      int num2418 = (int) numArray541[this.ucScreenLED1.LEDF6 * 3 + 2];
      numArray808[index804] = (byte) num2418;
      byte[] numArray809 = second;
      int num2419 = num2417;
      int num2420 = num2419 + 1;
      int index805 = num2419;
      int num2421 = (int) numArray541[this.ucScreenLED1.LEDA6 * 3];
      numArray809[index805] = (byte) num2421;
      byte[] numArray810 = second;
      int num2422 = num2420;
      int num2423 = num2422 + 1;
      int index806 = num2422;
      int num2424 = (int) numArray541[this.ucScreenLED1.LEDA6 * 3 + 1];
      numArray810[index806] = (byte) num2424;
      byte[] numArray811 = second;
      int num2425 = num2423;
      int num2426 = num2425 + 1;
      int index807 = num2425;
      int num2427 = (int) numArray541[this.ucScreenLED1.LEDA6 * 3 + 2];
      numArray811[index807] = (byte) num2427;
      byte[] numArray812 = second;
      int num2428 = num2426;
      int num2429 = num2428 + 1;
      int index808 = num2428;
      int num2430 = (int) numArray541[this.ucScreenLED1.LEDB6 * 3];
      numArray812[index808] = (byte) num2430;
      byte[] numArray813 = second;
      int num2431 = num2429;
      int num2432 = num2431 + 1;
      int index809 = num2431;
      int num2433 = (int) numArray541[this.ucScreenLED1.LEDB6 * 3 + 1];
      numArray813[index809] = (byte) num2433;
      byte[] numArray814 = second;
      int num2434 = num2432;
      int num2435 = num2434 + 1;
      int index810 = num2434;
      int num2436 = (int) numArray541[this.ucScreenLED1.LEDB6 * 3 + 2];
      numArray814[index810] = (byte) num2436;
      byte[] numArray815 = second;
      int num2437 = num2435;
      int num2438 = num2437 + 1;
      int index811 = num2437;
      int num2439 = (int) numArray541[this.ucScreenLED1.WATT * 3];
      numArray815[index811] = (byte) num2439;
      byte[] numArray816 = second;
      int num2440 = num2438;
      int num2441 = num2440 + 1;
      int index812 = num2440;
      int num2442 = (int) numArray541[this.ucScreenLED1.WATT * 3 + 1];
      numArray816[index812] = (byte) num2442;
      byte[] numArray817 = second;
      int num2443 = num2441;
      int num2444 = num2443 + 1;
      int index813 = num2443;
      int num2445 = (int) numArray541[this.ucScreenLED1.WATT * 3 + 2];
      numArray817[index813] = (byte) num2445;
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 6)
    {
      byte[] numArray818 = new byte[423];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray818.Length,
        (byte) (numArray818.Length >> 8),
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 124; ++index)
      {
        if (this.myOnOff == (byte) 0)
        {
          numArray818[index * 3] = (byte) 0;
          numArray818[index * 3 + 1] = (byte) 0;
          numArray818[index * 3 + 2] = (byte) 0;
        }
        else if (this.ucScreenLED1.isOn[index])
        {
          numArray818[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2 + (double) num1);
          numArray818[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2 + (double) num1);
          numArray818[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2 + (double) num1);
        }
        else
        {
          numArray818[index * 3] = (byte) 0;
          numArray818[index * 3 + 1] = (byte) 0;
          numArray818[index * 3 + 2] = (byte) 0;
        }
      }
      int num2446 = 0;
      byte[] second = new byte[numArray818.Length];
      byte[] numArray819 = second;
      int num2447 = num2446;
      int num2448 = num2447 + 1;
      int index814 = num2447;
      int num2449 = (int) numArray818[this.ucScreenLED1.ZhuangShi27 * 3];
      numArray819[index814] = (byte) num2449;
      byte[] numArray820 = second;
      int num2450 = num2448;
      int num2451 = num2450 + 1;
      int index815 = num2450;
      int num2452 = (int) numArray818[this.ucScreenLED1.ZhuangShi27 * 3 + 1];
      numArray820[index815] = (byte) num2452;
      byte[] numArray821 = second;
      int num2453 = num2451;
      int num2454 = num2453 + 1;
      int index816 = num2453;
      int num2455 = (int) numArray818[this.ucScreenLED1.ZhuangShi27 * 3 + 2];
      numArray821[index816] = (byte) num2455;
      byte[] numArray822 = second;
      int num2456 = num2454;
      int num2457 = num2456 + 1;
      int index817 = num2456;
      int num2458 = (int) numArray818[this.ucScreenLED1.ZhuangShi28 * 3];
      numArray822[index817] = (byte) num2458;
      byte[] numArray823 = second;
      int num2459 = num2457;
      int num2460 = num2459 + 1;
      int index818 = num2459;
      int num2461 = (int) numArray818[this.ucScreenLED1.ZhuangShi28 * 3 + 1];
      numArray823[index818] = (byte) num2461;
      byte[] numArray824 = second;
      int num2462 = num2460;
      int num2463 = num2462 + 1;
      int index819 = num2462;
      int num2464 = (int) numArray818[this.ucScreenLED1.ZhuangShi28 * 3 + 2];
      numArray824[index819] = (byte) num2464;
      byte[] numArray825 = second;
      int num2465 = num2463;
      int num2466 = num2465 + 1;
      int index820 = num2465;
      int num2467 = (int) numArray818[this.ucScreenLED1.ZhuangShi29 * 3];
      numArray825[index820] = (byte) num2467;
      byte[] numArray826 = second;
      int num2468 = num2466;
      int num2469 = num2468 + 1;
      int index821 = num2468;
      int num2470 = (int) numArray818[this.ucScreenLED1.ZhuangShi29 * 3 + 1];
      numArray826[index821] = (byte) num2470;
      byte[] numArray827 = second;
      int num2471 = num2469;
      int num2472 = num2471 + 1;
      int index822 = num2471;
      int num2473 = (int) numArray818[this.ucScreenLED1.ZhuangShi29 * 3 + 2];
      numArray827[index822] = (byte) num2473;
      byte[] numArray828 = second;
      int num2474 = num2472;
      int num2475 = num2474 + 1;
      int index823 = num2474;
      int num2476 = (int) numArray818[this.ucScreenLED1.ZhuangShi30 * 3];
      numArray828[index823] = (byte) num2476;
      byte[] numArray829 = second;
      int num2477 = num2475;
      int num2478 = num2477 + 1;
      int index824 = num2477;
      int num2479 = (int) numArray818[this.ucScreenLED1.ZhuangShi30 * 3 + 1];
      numArray829[index824] = (byte) num2479;
      byte[] numArray830 = second;
      int num2480 = num2478;
      int num2481 = num2480 + 1;
      int index825 = num2480;
      int num2482 = (int) numArray818[this.ucScreenLED1.ZhuangShi30 * 3 + 2];
      numArray830[index825] = (byte) num2482;
      byte[] numArray831 = second;
      int num2483 = num2481;
      int num2484 = num2483 + 1;
      int index826 = num2483;
      int num2485 = (int) numArray818[this.ucScreenLED1.ZhuangShi31 * 3];
      numArray831[index826] = (byte) num2485;
      byte[] numArray832 = second;
      int num2486 = num2484;
      int num2487 = num2486 + 1;
      int index827 = num2486;
      int num2488 = (int) numArray818[this.ucScreenLED1.ZhuangShi31 * 3 + 1];
      numArray832[index827] = (byte) num2488;
      byte[] numArray833 = second;
      int num2489 = num2487;
      int num2490 = num2489 + 1;
      int index828 = num2489;
      int num2491 = (int) numArray818[this.ucScreenLED1.ZhuangShi31 * 3 + 2];
      numArray833[index828] = (byte) num2491;
      byte[] numArray834 = second;
      int num2492 = num2490;
      int num2493 = num2492 + 1;
      int index829 = num2492;
      int num2494 = (int) numArray818[this.ucScreenLED1.ZhuangShi30 * 3];
      numArray834[index829] = (byte) num2494;
      byte[] numArray835 = second;
      int num2495 = num2493;
      int num2496 = num2495 + 1;
      int index830 = num2495;
      int num2497 = (int) numArray818[this.ucScreenLED1.ZhuangShi30 * 3 + 1];
      numArray835[index830] = (byte) num2497;
      byte[] numArray836 = second;
      int num2498 = num2496;
      int num2499 = num2498 + 1;
      int index831 = num2498;
      int num2500 = (int) numArray818[this.ucScreenLED1.ZhuangShi30 * 3 + 2];
      numArray836[index831] = (byte) num2500;
      byte[] numArray837 = second;
      int num2501 = num2499;
      int num2502 = num2501 + 1;
      int index832 = num2501;
      int num2503 = (int) numArray818[this.ucScreenLED1.ZhuangShi29 * 3];
      numArray837[index832] = (byte) num2503;
      byte[] numArray838 = second;
      int num2504 = num2502;
      int num2505 = num2504 + 1;
      int index833 = num2504;
      int num2506 = (int) numArray818[this.ucScreenLED1.ZhuangShi29 * 3 + 1];
      numArray838[index833] = (byte) num2506;
      byte[] numArray839 = second;
      int num2507 = num2505;
      int num2508 = num2507 + 1;
      int index834 = num2507;
      int num2509 = (int) numArray818[this.ucScreenLED1.ZhuangShi29 * 3 + 2];
      numArray839[index834] = (byte) num2509;
      byte[] numArray840 = second;
      int num2510 = num2508;
      int num2511 = num2510 + 1;
      int index835 = num2510;
      int num2512 = (int) numArray818[this.ucScreenLED1.ZhuangShi28 * 3];
      numArray840[index835] = (byte) num2512;
      byte[] numArray841 = second;
      int num2513 = num2511;
      int num2514 = num2513 + 1;
      int index836 = num2513;
      int num2515 = (int) numArray818[this.ucScreenLED1.ZhuangShi28 * 3 + 1];
      numArray841[index836] = (byte) num2515;
      byte[] numArray842 = second;
      int num2516 = num2514;
      int num2517 = num2516 + 1;
      int index837 = num2516;
      int num2518 = (int) numArray818[this.ucScreenLED1.ZhuangShi28 * 3 + 2];
      numArray842[index837] = (byte) num2518;
      byte[] numArray843 = second;
      int num2519 = num2517;
      int num2520 = num2519 + 1;
      int index838 = num2519;
      int num2521 = (int) numArray818[this.ucScreenLED1.ZhuangShi27 * 3];
      numArray843[index838] = (byte) num2521;
      byte[] numArray844 = second;
      int num2522 = num2520;
      int num2523 = num2522 + 1;
      int index839 = num2522;
      int num2524 = (int) numArray818[this.ucScreenLED1.ZhuangShi27 * 3 + 1];
      numArray844[index839] = (byte) num2524;
      byte[] numArray845 = second;
      int num2525 = num2523;
      int num2526 = num2525 + 1;
      int index840 = num2525;
      int num2527 = (int) numArray818[this.ucScreenLED1.ZhuangShi27 * 3 + 2];
      numArray845[index840] = (byte) num2527;
      byte[] numArray846 = second;
      int num2528 = num2526;
      int num2529 = num2528 + 1;
      int index841 = num2528;
      int num2530 = (int) numArray818[this.ucScreenLED1.BFB * 3];
      numArray846[index841] = (byte) num2530;
      byte[] numArray847 = second;
      int num2531 = num2529;
      int num2532 = num2531 + 1;
      int index842 = num2531;
      int num2533 = (int) numArray818[this.ucScreenLED1.BFB * 3 + 1];
      numArray847[index842] = (byte) num2533;
      byte[] numArray848 = second;
      int num2534 = num2532;
      int num2535 = num2534 + 1;
      int index843 = num2534;
      int num2536 = (int) numArray818[this.ucScreenLED1.BFB * 3 + 2];
      numArray848[index843] = (byte) num2536;
      byte[] numArray849 = second;
      int num2537 = num2535;
      int num2538 = num2537 + 1;
      int index844 = num2537;
      int num2539 = (int) numArray818[this.ucScreenLED1.BFB * 3];
      numArray849[index844] = (byte) num2539;
      byte[] numArray850 = second;
      int num2540 = num2538;
      int num2541 = num2540 + 1;
      int index845 = num2540;
      int num2542 = (int) numArray818[this.ucScreenLED1.BFB * 3 + 1];
      numArray850[index845] = (byte) num2542;
      byte[] numArray851 = second;
      int num2543 = num2541;
      int num2544 = num2543 + 1;
      int index846 = num2543;
      int num2545 = (int) numArray818[this.ucScreenLED1.BFB * 3 + 2];
      numArray851[index846] = (byte) num2545;
      byte[] numArray852 = second;
      int num2546 = num2544;
      int num2547 = num2546 + 1;
      int index847 = num2546;
      int num2548 = (int) numArray818[this.ucScreenLED1.LEDC12 * 3];
      numArray852[index847] = (byte) num2548;
      byte[] numArray853 = second;
      int num2549 = num2547;
      int num2550 = num2549 + 1;
      int index848 = num2549;
      int num2551 = (int) numArray818[this.ucScreenLED1.LEDC12 * 3 + 1];
      numArray853[index848] = (byte) num2551;
      byte[] numArray854 = second;
      int num2552 = num2550;
      int num2553 = num2552 + 1;
      int index849 = num2552;
      int num2554 = (int) numArray818[this.ucScreenLED1.LEDC12 * 3 + 2];
      numArray854[index849] = (byte) num2554;
      byte[] numArray855 = second;
      int num2555 = num2553;
      int num2556 = num2555 + 1;
      int index850 = num2555;
      int num2557 = (int) numArray818[this.ucScreenLED1.LEDD12 * 3];
      numArray855[index850] = (byte) num2557;
      byte[] numArray856 = second;
      int num2558 = num2556;
      int num2559 = num2558 + 1;
      int index851 = num2558;
      int num2560 = (int) numArray818[this.ucScreenLED1.LEDD12 * 3 + 1];
      numArray856[index851] = (byte) num2560;
      byte[] numArray857 = second;
      int num2561 = num2559;
      int num2562 = num2561 + 1;
      int index852 = num2561;
      int num2563 = (int) numArray818[this.ucScreenLED1.LEDD12 * 3 + 2];
      numArray857[index852] = (byte) num2563;
      byte[] numArray858 = second;
      int num2564 = num2562;
      int num2565 = num2564 + 1;
      int index853 = num2564;
      int num2566 = (int) numArray818[this.ucScreenLED1.LEDE12 * 3];
      numArray858[index853] = (byte) num2566;
      byte[] numArray859 = second;
      int num2567 = num2565;
      int num2568 = num2567 + 1;
      int index854 = num2567;
      int num2569 = (int) numArray818[this.ucScreenLED1.LEDE12 * 3 + 1];
      numArray859[index854] = (byte) num2569;
      byte[] numArray860 = second;
      int num2570 = num2568;
      int num2571 = num2570 + 1;
      int index855 = num2570;
      int num2572 = (int) numArray818[this.ucScreenLED1.LEDE12 * 3 + 2];
      numArray860[index855] = (byte) num2572;
      byte[] numArray861 = second;
      int num2573 = num2571;
      int num2574 = num2573 + 1;
      int index856 = num2573;
      int num2575 = (int) numArray818[this.ucScreenLED1.LEDG12 * 3];
      numArray861[index856] = (byte) num2575;
      byte[] numArray862 = second;
      int num2576 = num2574;
      int num2577 = num2576 + 1;
      int index857 = num2576;
      int num2578 = (int) numArray818[this.ucScreenLED1.LEDG12 * 3 + 1];
      numArray862[index857] = (byte) num2578;
      byte[] numArray863 = second;
      int num2579 = num2577;
      int num2580 = num2579 + 1;
      int index858 = num2579;
      int num2581 = (int) numArray818[this.ucScreenLED1.LEDG12 * 3 + 2];
      numArray863[index858] = (byte) num2581;
      byte[] numArray864 = second;
      int num2582 = num2580;
      int num2583 = num2582 + 1;
      int index859 = num2582;
      int num2584 = (int) numArray818[this.ucScreenLED1.LEDB12 * 3];
      numArray864[index859] = (byte) num2584;
      byte[] numArray865 = second;
      int num2585 = num2583;
      int num2586 = num2585 + 1;
      int index860 = num2585;
      int num2587 = (int) numArray818[this.ucScreenLED1.LEDB12 * 3 + 1];
      numArray865[index860] = (byte) num2587;
      byte[] numArray866 = second;
      int num2588 = num2586;
      int num2589 = num2588 + 1;
      int index861 = num2588;
      int num2590 = (int) numArray818[this.ucScreenLED1.LEDB12 * 3 + 2];
      numArray866[index861] = (byte) num2590;
      byte[] numArray867 = second;
      int num2591 = num2589;
      int num2592 = num2591 + 1;
      int index862 = num2591;
      int num2593 = (int) numArray818[this.ucScreenLED1.LEDA12 * 3];
      numArray867[index862] = (byte) num2593;
      byte[] numArray868 = second;
      int num2594 = num2592;
      int num2595 = num2594 + 1;
      int index863 = num2594;
      int num2596 = (int) numArray818[this.ucScreenLED1.LEDA12 * 3 + 1];
      numArray868[index863] = (byte) num2596;
      byte[] numArray869 = second;
      int num2597 = num2595;
      int num2598 = num2597 + 1;
      int index864 = num2597;
      int num2599 = (int) numArray818[this.ucScreenLED1.LEDA12 * 3 + 2];
      numArray869[index864] = (byte) num2599;
      byte[] numArray870 = second;
      int num2600 = num2598;
      int num2601 = num2600 + 1;
      int index865 = num2600;
      int num2602 = (int) numArray818[this.ucScreenLED1.LEDF12 * 3];
      numArray870[index865] = (byte) num2602;
      byte[] numArray871 = second;
      int num2603 = num2601;
      int num2604 = num2603 + 1;
      int index866 = num2603;
      int num2605 = (int) numArray818[this.ucScreenLED1.LEDF12 * 3 + 1];
      numArray871[index866] = (byte) num2605;
      byte[] numArray872 = second;
      int num2606 = num2604;
      int num2607 = num2606 + 1;
      int index867 = num2606;
      int num2608 = (int) numArray818[this.ucScreenLED1.LEDF12 * 3 + 2];
      numArray872[index867] = (byte) num2608;
      byte[] numArray873 = second;
      int num2609 = num2607;
      int num2610 = num2609 + 1;
      int index868 = num2609;
      int num2611 = (int) numArray818[this.ucScreenLED1.LEDC11 * 3];
      numArray873[index868] = (byte) num2611;
      byte[] numArray874 = second;
      int num2612 = num2610;
      int num2613 = num2612 + 1;
      int index869 = num2612;
      int num2614 = (int) numArray818[this.ucScreenLED1.LEDC11 * 3 + 1];
      numArray874[index869] = (byte) num2614;
      byte[] numArray875 = second;
      int num2615 = num2613;
      int num2616 = num2615 + 1;
      int index870 = num2615;
      int num2617 = (int) numArray818[this.ucScreenLED1.LEDC11 * 3 + 2];
      numArray875[index870] = (byte) num2617;
      byte[] numArray876 = second;
      int num2618 = num2616;
      int num2619 = num2618 + 1;
      int index871 = num2618;
      int num2620 = (int) numArray818[this.ucScreenLED1.LEDD11 * 3];
      numArray876[index871] = (byte) num2620;
      byte[] numArray877 = second;
      int num2621 = num2619;
      int num2622 = num2621 + 1;
      int index872 = num2621;
      int num2623 = (int) numArray818[this.ucScreenLED1.LEDD11 * 3 + 1];
      numArray877[index872] = (byte) num2623;
      byte[] numArray878 = second;
      int num2624 = num2622;
      int num2625 = num2624 + 1;
      int index873 = num2624;
      int num2626 = (int) numArray818[this.ucScreenLED1.LEDD11 * 3 + 2];
      numArray878[index873] = (byte) num2626;
      byte[] numArray879 = second;
      int num2627 = num2625;
      int num2628 = num2627 + 1;
      int index874 = num2627;
      int num2629 = (int) numArray818[this.ucScreenLED1.LEDE11 * 3];
      numArray879[index874] = (byte) num2629;
      byte[] numArray880 = second;
      int num2630 = num2628;
      int num2631 = num2630 + 1;
      int index875 = num2630;
      int num2632 = (int) numArray818[this.ucScreenLED1.LEDE11 * 3 + 1];
      numArray880[index875] = (byte) num2632;
      byte[] numArray881 = second;
      int num2633 = num2631;
      int num2634 = num2633 + 1;
      int index876 = num2633;
      int num2635 = (int) numArray818[this.ucScreenLED1.LEDE11 * 3 + 2];
      numArray881[index876] = (byte) num2635;
      byte[] numArray882 = second;
      int num2636 = num2634;
      int num2637 = num2636 + 1;
      int index877 = num2636;
      int num2638 = (int) numArray818[this.ucScreenLED1.LEDG11 * 3];
      numArray882[index877] = (byte) num2638;
      byte[] numArray883 = second;
      int num2639 = num2637;
      int num2640 = num2639 + 1;
      int index878 = num2639;
      int num2641 = (int) numArray818[this.ucScreenLED1.LEDG11 * 3 + 1];
      numArray883[index878] = (byte) num2641;
      byte[] numArray884 = second;
      int num2642 = num2640;
      int num2643 = num2642 + 1;
      int index879 = num2642;
      int num2644 = (int) numArray818[this.ucScreenLED1.LEDG11 * 3 + 2];
      numArray884[index879] = (byte) num2644;
      byte[] numArray885 = second;
      int num2645 = num2643;
      int num2646 = num2645 + 1;
      int index880 = num2645;
      int num2647 = (int) numArray818[this.ucScreenLED1.LEDB11 * 3];
      numArray885[index880] = (byte) num2647;
      byte[] numArray886 = second;
      int num2648 = num2646;
      int num2649 = num2648 + 1;
      int index881 = num2648;
      int num2650 = (int) numArray818[this.ucScreenLED1.LEDB11 * 3 + 1];
      numArray886[index881] = (byte) num2650;
      byte[] numArray887 = second;
      int num2651 = num2649;
      int num2652 = num2651 + 1;
      int index882 = num2651;
      int num2653 = (int) numArray818[this.ucScreenLED1.LEDB11 * 3 + 2];
      numArray887[index882] = (byte) num2653;
      byte[] numArray888 = second;
      int num2654 = num2652;
      int num2655 = num2654 + 1;
      int index883 = num2654;
      int num2656 = (int) numArray818[this.ucScreenLED1.LEDA11 * 3];
      numArray888[index883] = (byte) num2656;
      byte[] numArray889 = second;
      int num2657 = num2655;
      int num2658 = num2657 + 1;
      int index884 = num2657;
      int num2659 = (int) numArray818[this.ucScreenLED1.LEDA11 * 3 + 1];
      numArray889[index884] = (byte) num2659;
      byte[] numArray890 = second;
      int num2660 = num2658;
      int num2661 = num2660 + 1;
      int index885 = num2660;
      int num2662 = (int) numArray818[this.ucScreenLED1.LEDA11 * 3 + 2];
      numArray890[index885] = (byte) num2662;
      byte[] numArray891 = second;
      int num2663 = num2661;
      int num2664 = num2663 + 1;
      int index886 = num2663;
      int num2665 = (int) numArray818[this.ucScreenLED1.LEDF11 * 3];
      numArray891[index886] = (byte) num2665;
      byte[] numArray892 = second;
      int num2666 = num2664;
      int num2667 = num2666 + 1;
      int index887 = num2666;
      int num2668 = (int) numArray818[this.ucScreenLED1.LEDF11 * 3 + 1];
      numArray892[index887] = (byte) num2668;
      byte[] numArray893 = second;
      int num2669 = num2667;
      int num2670 = num2669 + 1;
      int index888 = num2669;
      int num2671 = (int) numArray818[this.ucScreenLED1.LEDF11 * 3 + 2];
      numArray893[index888] = (byte) num2671;
      byte[] numArray894 = second;
      int num2672 = num2670;
      int num2673 = num2672 + 1;
      int index889 = num2672;
      int num2674 = (int) numArray818[this.ucScreenLED1.LEDC13 * 3];
      numArray894[index889] = (byte) num2674;
      byte[] numArray895 = second;
      int num2675 = num2673;
      int num2676 = num2675 + 1;
      int index890 = num2675;
      int num2677 = (int) numArray818[this.ucScreenLED1.LEDC13 * 3 + 1];
      numArray895[index890] = (byte) num2677;
      byte[] numArray896 = second;
      int num2678 = num2676;
      int num2679 = num2678 + 1;
      int index891 = num2678;
      int num2680 = (int) numArray818[this.ucScreenLED1.LEDC13 * 3 + 2];
      numArray896[index891] = (byte) num2680;
      byte[] numArray897 = second;
      int num2681 = num2679;
      int num2682 = num2681 + 1;
      int index892 = num2681;
      int num2683 = (int) numArray818[this.ucScreenLED1.LEDB13 * 3];
      numArray897[index892] = (byte) num2683;
      byte[] numArray898 = second;
      int num2684 = num2682;
      int num2685 = num2684 + 1;
      int index893 = num2684;
      int num2686 = (int) numArray818[this.ucScreenLED1.LEDB13 * 3 + 1];
      numArray898[index893] = (byte) num2686;
      byte[] numArray899 = second;
      int num2687 = num2685;
      int num2688 = num2687 + 1;
      int index894 = num2687;
      int num2689 = (int) numArray818[this.ucScreenLED1.LEDB13 * 3 + 2];
      numArray899[index894] = (byte) num2689;
      byte[] numArray900 = second;
      int num2690 = num2688;
      int num2691 = num2690 + 1;
      int index895 = num2690;
      int num2692 = (int) numArray818[this.ucScreenLED1.MHz * 3];
      numArray900[index895] = (byte) num2692;
      byte[] numArray901 = second;
      int num2693 = num2691;
      int num2694 = num2693 + 1;
      int index896 = num2693;
      int num2695 = (int) numArray818[this.ucScreenLED1.MHz * 3 + 1];
      numArray901[index896] = (byte) num2695;
      byte[] numArray902 = second;
      int num2696 = num2694;
      int num2697 = num2696 + 1;
      int index897 = num2696;
      int num2698 = (int) numArray818[this.ucScreenLED1.MHz * 3 + 2];
      numArray902[index897] = (byte) num2698;
      byte[] numArray903 = second;
      int num2699 = num2697;
      int num2700 = num2699 + 1;
      int index898 = num2699;
      int num2701 = (int) numArray818[this.ucScreenLED1.LEDC10 * 3];
      numArray903[index898] = (byte) num2701;
      byte[] numArray904 = second;
      int num2702 = num2700;
      int num2703 = num2702 + 1;
      int index899 = num2702;
      int num2704 = (int) numArray818[this.ucScreenLED1.LEDC10 * 3 + 1];
      numArray904[index899] = (byte) num2704;
      byte[] numArray905 = second;
      int num2705 = num2703;
      int num2706 = num2705 + 1;
      int index900 = num2705;
      int num2707 = (int) numArray818[this.ucScreenLED1.LEDC10 * 3 + 2];
      numArray905[index900] = (byte) num2707;
      byte[] numArray906 = second;
      int num2708 = num2706;
      int num2709 = num2708 + 1;
      int index901 = num2708;
      int num2710 = (int) numArray818[this.ucScreenLED1.LEDD10 * 3];
      numArray906[index901] = (byte) num2710;
      byte[] numArray907 = second;
      int num2711 = num2709;
      int num2712 = num2711 + 1;
      int index902 = num2711;
      int num2713 = (int) numArray818[this.ucScreenLED1.LEDD10 * 3 + 1];
      numArray907[index902] = (byte) num2713;
      byte[] numArray908 = second;
      int num2714 = num2712;
      int num2715 = num2714 + 1;
      int index903 = num2714;
      int num2716 = (int) numArray818[this.ucScreenLED1.LEDD10 * 3 + 2];
      numArray908[index903] = (byte) num2716;
      byte[] numArray909 = second;
      int num2717 = num2715;
      int num2718 = num2717 + 1;
      int index904 = num2717;
      int num2719 = (int) numArray818[this.ucScreenLED1.LEDE10 * 3];
      numArray909[index904] = (byte) num2719;
      byte[] numArray910 = second;
      int num2720 = num2718;
      int num2721 = num2720 + 1;
      int index905 = num2720;
      int num2722 = (int) numArray818[this.ucScreenLED1.LEDE10 * 3 + 1];
      numArray910[index905] = (byte) num2722;
      byte[] numArray911 = second;
      int num2723 = num2721;
      int num2724 = num2723 + 1;
      int index906 = num2723;
      int num2725 = (int) numArray818[this.ucScreenLED1.LEDE10 * 3 + 2];
      numArray911[index906] = (byte) num2725;
      byte[] numArray912 = second;
      int num2726 = num2724;
      int num2727 = num2726 + 1;
      int index907 = num2726;
      int num2728 = (int) numArray818[this.ucScreenLED1.LEDG10 * 3];
      numArray912[index907] = (byte) num2728;
      byte[] numArray913 = second;
      int num2729 = num2727;
      int num2730 = num2729 + 1;
      int index908 = num2729;
      int num2731 = (int) numArray818[this.ucScreenLED1.LEDG10 * 3 + 1];
      numArray913[index908] = (byte) num2731;
      byte[] numArray914 = second;
      int num2732 = num2730;
      int num2733 = num2732 + 1;
      int index909 = num2732;
      int num2734 = (int) numArray818[this.ucScreenLED1.LEDG10 * 3 + 2];
      numArray914[index909] = (byte) num2734;
      byte[] numArray915 = second;
      int num2735 = num2733;
      int num2736 = num2735 + 1;
      int index910 = num2735;
      int num2737 = (int) numArray818[this.ucScreenLED1.LEDB10 * 3];
      numArray915[index910] = (byte) num2737;
      byte[] numArray916 = second;
      int num2738 = num2736;
      int num2739 = num2738 + 1;
      int index911 = num2738;
      int num2740 = (int) numArray818[this.ucScreenLED1.LEDB10 * 3 + 1];
      numArray916[index911] = (byte) num2740;
      byte[] numArray917 = second;
      int num2741 = num2739;
      int num2742 = num2741 + 1;
      int index912 = num2741;
      int num2743 = (int) numArray818[this.ucScreenLED1.LEDB10 * 3 + 2];
      numArray917[index912] = (byte) num2743;
      byte[] numArray918 = second;
      int num2744 = num2742;
      int num2745 = num2744 + 1;
      int index913 = num2744;
      int num2746 = (int) numArray818[this.ucScreenLED1.LEDA10 * 3];
      numArray918[index913] = (byte) num2746;
      byte[] numArray919 = second;
      int num2747 = num2745;
      int num2748 = num2747 + 1;
      int index914 = num2747;
      int num2749 = (int) numArray818[this.ucScreenLED1.LEDA10 * 3 + 1];
      numArray919[index914] = (byte) num2749;
      byte[] numArray920 = second;
      int num2750 = num2748;
      int num2751 = num2750 + 1;
      int index915 = num2750;
      int num2752 = (int) numArray818[this.ucScreenLED1.LEDA10 * 3 + 2];
      numArray920[index915] = (byte) num2752;
      byte[] numArray921 = second;
      int num2753 = num2751;
      int num2754 = num2753 + 1;
      int index916 = num2753;
      int num2755 = (int) numArray818[this.ucScreenLED1.LEDF10 * 3];
      numArray921[index916] = (byte) num2755;
      byte[] numArray922 = second;
      int num2756 = num2754;
      int num2757 = num2756 + 1;
      int index917 = num2756;
      int num2758 = (int) numArray818[this.ucScreenLED1.LEDF10 * 3 + 1];
      numArray922[index917] = (byte) num2758;
      byte[] numArray923 = second;
      int num2759 = num2757;
      int num2760 = num2759 + 1;
      int index918 = num2759;
      int num2761 = (int) numArray818[this.ucScreenLED1.LEDF10 * 3 + 2];
      numArray923[index918] = (byte) num2761;
      byte[] numArray924 = second;
      int num2762 = num2760;
      int num2763 = num2762 + 1;
      int index919 = num2762;
      int num2764 = (int) numArray818[this.ucScreenLED1.LEDC9 * 3];
      numArray924[index919] = (byte) num2764;
      byte[] numArray925 = second;
      int num2765 = num2763;
      int num2766 = num2765 + 1;
      int index920 = num2765;
      int num2767 = (int) numArray818[this.ucScreenLED1.LEDC9 * 3 + 1];
      numArray925[index920] = (byte) num2767;
      byte[] numArray926 = second;
      int num2768 = num2766;
      int num2769 = num2768 + 1;
      int index921 = num2768;
      int num2770 = (int) numArray818[this.ucScreenLED1.LEDC9 * 3 + 2];
      numArray926[index921] = (byte) num2770;
      byte[] numArray927 = second;
      int num2771 = num2769;
      int num2772 = num2771 + 1;
      int index922 = num2771;
      int num2773 = (int) numArray818[this.ucScreenLED1.LEDD9 * 3];
      numArray927[index922] = (byte) num2773;
      byte[] numArray928 = second;
      int num2774 = num2772;
      int num2775 = num2774 + 1;
      int index923 = num2774;
      int num2776 = (int) numArray818[this.ucScreenLED1.LEDD9 * 3 + 1];
      numArray928[index923] = (byte) num2776;
      byte[] numArray929 = second;
      int num2777 = num2775;
      int num2778 = num2777 + 1;
      int index924 = num2777;
      int num2779 = (int) numArray818[this.ucScreenLED1.LEDD9 * 3 + 2];
      numArray929[index924] = (byte) num2779;
      byte[] numArray930 = second;
      int num2780 = num2778;
      int num2781 = num2780 + 1;
      int index925 = num2780;
      int num2782 = (int) numArray818[this.ucScreenLED1.LEDE9 * 3];
      numArray930[index925] = (byte) num2782;
      byte[] numArray931 = second;
      int num2783 = num2781;
      int num2784 = num2783 + 1;
      int index926 = num2783;
      int num2785 = (int) numArray818[this.ucScreenLED1.LEDE9 * 3 + 1];
      numArray931[index926] = (byte) num2785;
      byte[] numArray932 = second;
      int num2786 = num2784;
      int num2787 = num2786 + 1;
      int index927 = num2786;
      int num2788 = (int) numArray818[this.ucScreenLED1.LEDE9 * 3 + 2];
      numArray932[index927] = (byte) num2788;
      byte[] numArray933 = second;
      int num2789 = num2787;
      int num2790 = num2789 + 1;
      int index928 = num2789;
      int num2791 = (int) numArray818[this.ucScreenLED1.LEDG9 * 3];
      numArray933[index928] = (byte) num2791;
      byte[] numArray934 = second;
      int num2792 = num2790;
      int num2793 = num2792 + 1;
      int index929 = num2792;
      int num2794 = (int) numArray818[this.ucScreenLED1.LEDG9 * 3 + 1];
      numArray934[index929] = (byte) num2794;
      byte[] numArray935 = second;
      int num2795 = num2793;
      int num2796 = num2795 + 1;
      int index930 = num2795;
      int num2797 = (int) numArray818[this.ucScreenLED1.LEDG9 * 3 + 2];
      numArray935[index930] = (byte) num2797;
      byte[] numArray936 = second;
      int num2798 = num2796;
      int num2799 = num2798 + 1;
      int index931 = num2798;
      int num2800 = (int) numArray818[this.ucScreenLED1.LEDB9 * 3];
      numArray936[index931] = (byte) num2800;
      byte[] numArray937 = second;
      int num2801 = num2799;
      int num2802 = num2801 + 1;
      int index932 = num2801;
      int num2803 = (int) numArray818[this.ucScreenLED1.LEDB9 * 3 + 1];
      numArray937[index932] = (byte) num2803;
      byte[] numArray938 = second;
      int num2804 = num2802;
      int num2805 = num2804 + 1;
      int index933 = num2804;
      int num2806 = (int) numArray818[this.ucScreenLED1.LEDB9 * 3 + 2];
      numArray938[index933] = (byte) num2806;
      byte[] numArray939 = second;
      int num2807 = num2805;
      int num2808 = num2807 + 1;
      int index934 = num2807;
      int num2809 = (int) numArray818[this.ucScreenLED1.LEDA9 * 3];
      numArray939[index934] = (byte) num2809;
      byte[] numArray940 = second;
      int num2810 = num2808;
      int num2811 = num2810 + 1;
      int index935 = num2810;
      int num2812 = (int) numArray818[this.ucScreenLED1.LEDA9 * 3 + 1];
      numArray940[index935] = (byte) num2812;
      byte[] numArray941 = second;
      int num2813 = num2811;
      int num2814 = num2813 + 1;
      int index936 = num2813;
      int num2815 = (int) numArray818[this.ucScreenLED1.LEDA9 * 3 + 2];
      numArray941[index936] = (byte) num2815;
      byte[] numArray942 = second;
      int num2816 = num2814;
      int num2817 = num2816 + 1;
      int index937 = num2816;
      int num2818 = (int) numArray818[this.ucScreenLED1.LEDF9 * 3];
      numArray942[index937] = (byte) num2818;
      byte[] numArray943 = second;
      int num2819 = num2817;
      int num2820 = num2819 + 1;
      int index938 = num2819;
      int num2821 = (int) numArray818[this.ucScreenLED1.LEDF9 * 3 + 1];
      numArray943[index938] = (byte) num2821;
      byte[] numArray944 = second;
      int num2822 = num2820;
      int num2823 = num2822 + 1;
      int index939 = num2822;
      int num2824 = (int) numArray818[this.ucScreenLED1.LEDF9 * 3 + 2];
      numArray944[index939] = (byte) num2824;
      byte[] numArray945 = second;
      int num2825 = num2823;
      int num2826 = num2825 + 1;
      int index940 = num2825;
      int num2827 = (int) numArray818[this.ucScreenLED1.LEDC8 * 3];
      numArray945[index940] = (byte) num2827;
      byte[] numArray946 = second;
      int num2828 = num2826;
      int num2829 = num2828 + 1;
      int index941 = num2828;
      int num2830 = (int) numArray818[this.ucScreenLED1.LEDC8 * 3 + 1];
      numArray946[index941] = (byte) num2830;
      byte[] numArray947 = second;
      int num2831 = num2829;
      int num2832 = num2831 + 1;
      int index942 = num2831;
      int num2833 = (int) numArray818[this.ucScreenLED1.LEDC8 * 3 + 2];
      numArray947[index942] = (byte) num2833;
      byte[] numArray948 = second;
      int num2834 = num2832;
      int num2835 = num2834 + 1;
      int index943 = num2834;
      int num2836 = (int) numArray818[this.ucScreenLED1.LEDD8 * 3];
      numArray948[index943] = (byte) num2836;
      byte[] numArray949 = second;
      int num2837 = num2835;
      int num2838 = num2837 + 1;
      int index944 = num2837;
      int num2839 = (int) numArray818[this.ucScreenLED1.LEDD8 * 3 + 1];
      numArray949[index944] = (byte) num2839;
      byte[] numArray950 = second;
      int num2840 = num2838;
      int num2841 = num2840 + 1;
      int index945 = num2840;
      int num2842 = (int) numArray818[this.ucScreenLED1.LEDD8 * 3 + 2];
      numArray950[index945] = (byte) num2842;
      byte[] numArray951 = second;
      int num2843 = num2841;
      int num2844 = num2843 + 1;
      int index946 = num2843;
      int num2845 = (int) numArray818[this.ucScreenLED1.LEDE8 * 3];
      numArray951[index946] = (byte) num2845;
      byte[] numArray952 = second;
      int num2846 = num2844;
      int num2847 = num2846 + 1;
      int index947 = num2846;
      int num2848 = (int) numArray818[this.ucScreenLED1.LEDE8 * 3 + 1];
      numArray952[index947] = (byte) num2848;
      byte[] numArray953 = second;
      int num2849 = num2847;
      int num2850 = num2849 + 1;
      int index948 = num2849;
      int num2851 = (int) numArray818[this.ucScreenLED1.LEDE8 * 3 + 2];
      numArray953[index948] = (byte) num2851;
      byte[] numArray954 = second;
      int num2852 = num2850;
      int num2853 = num2852 + 1;
      int index949 = num2852;
      int num2854 = (int) numArray818[this.ucScreenLED1.LEDG8 * 3];
      numArray954[index949] = (byte) num2854;
      byte[] numArray955 = second;
      int num2855 = num2853;
      int num2856 = num2855 + 1;
      int index950 = num2855;
      int num2857 = (int) numArray818[this.ucScreenLED1.LEDG8 * 3 + 1];
      numArray955[index950] = (byte) num2857;
      byte[] numArray956 = second;
      int num2858 = num2856;
      int num2859 = num2858 + 1;
      int index951 = num2858;
      int num2860 = (int) numArray818[this.ucScreenLED1.LEDG8 * 3 + 2];
      numArray956[index951] = (byte) num2860;
      byte[] numArray957 = second;
      int num2861 = num2859;
      int num2862 = num2861 + 1;
      int index952 = num2861;
      int num2863 = (int) numArray818[this.ucScreenLED1.LEDB8 * 3];
      numArray957[index952] = (byte) num2863;
      byte[] numArray958 = second;
      int num2864 = num2862;
      int num2865 = num2864 + 1;
      int index953 = num2864;
      int num2866 = (int) numArray818[this.ucScreenLED1.LEDB8 * 3 + 1];
      numArray958[index953] = (byte) num2866;
      byte[] numArray959 = second;
      int num2867 = num2865;
      int num2868 = num2867 + 1;
      int index954 = num2867;
      int num2869 = (int) numArray818[this.ucScreenLED1.LEDB8 * 3 + 2];
      numArray959[index954] = (byte) num2869;
      byte[] numArray960 = second;
      int num2870 = num2868;
      int num2871 = num2870 + 1;
      int index955 = num2870;
      int num2872 = (int) numArray818[this.ucScreenLED1.LEDA8 * 3];
      numArray960[index955] = (byte) num2872;
      byte[] numArray961 = second;
      int num2873 = num2871;
      int num2874 = num2873 + 1;
      int index956 = num2873;
      int num2875 = (int) numArray818[this.ucScreenLED1.LEDA8 * 3 + 1];
      numArray961[index956] = (byte) num2875;
      byte[] numArray962 = second;
      int num2876 = num2874;
      int num2877 = num2876 + 1;
      int index957 = num2876;
      int num2878 = (int) numArray818[this.ucScreenLED1.LEDA8 * 3 + 2];
      numArray962[index957] = (byte) num2878;
      byte[] numArray963 = second;
      int num2879 = num2877;
      int num2880 = num2879 + 1;
      int index958 = num2879;
      int num2881 = (int) numArray818[this.ucScreenLED1.LEDF8 * 3];
      numArray963[index958] = (byte) num2881;
      byte[] numArray964 = second;
      int num2882 = num2880;
      int num2883 = num2882 + 1;
      int index959 = num2882;
      int num2884 = (int) numArray818[this.ucScreenLED1.LEDF8 * 3 + 1];
      numArray964[index959] = (byte) num2884;
      byte[] numArray965 = second;
      int num2885 = num2883;
      int num2886 = num2885 + 1;
      int index960 = num2885;
      int num2887 = (int) numArray818[this.ucScreenLED1.LEDF8 * 3 + 2];
      numArray965[index960] = (byte) num2887;
      byte[] numArray966 = second;
      int num2888 = num2886;
      int num2889 = num2888 + 1;
      int index961 = num2888;
      int num2890 = (int) numArray818[this.ucScreenLED1.LEDC7 * 3];
      numArray966[index961] = (byte) num2890;
      byte[] numArray967 = second;
      int num2891 = num2889;
      int num2892 = num2891 + 1;
      int index962 = num2891;
      int num2893 = (int) numArray818[this.ucScreenLED1.LEDC7 * 3 + 1];
      numArray967[index962] = (byte) num2893;
      byte[] numArray968 = second;
      int num2894 = num2892;
      int num2895 = num2894 + 1;
      int index963 = num2894;
      int num2896 = (int) numArray818[this.ucScreenLED1.LEDC7 * 3 + 2];
      numArray968[index963] = (byte) num2896;
      byte[] numArray969 = second;
      int num2897 = num2895;
      int num2898 = num2897 + 1;
      int index964 = num2897;
      int num2899 = (int) numArray818[this.ucScreenLED1.LEDD7 * 3];
      numArray969[index964] = (byte) num2899;
      byte[] numArray970 = second;
      int num2900 = num2898;
      int num2901 = num2900 + 1;
      int index965 = num2900;
      int num2902 = (int) numArray818[this.ucScreenLED1.LEDD7 * 3 + 1];
      numArray970[index965] = (byte) num2902;
      byte[] numArray971 = second;
      int num2903 = num2901;
      int num2904 = num2903 + 1;
      int index966 = num2903;
      int num2905 = (int) numArray818[this.ucScreenLED1.LEDD7 * 3 + 2];
      numArray971[index966] = (byte) num2905;
      byte[] numArray972 = second;
      int num2906 = num2904;
      int num2907 = num2906 + 1;
      int index967 = num2906;
      int num2908 = (int) numArray818[this.ucScreenLED1.LEDE7 * 3];
      numArray972[index967] = (byte) num2908;
      byte[] numArray973 = second;
      int num2909 = num2907;
      int num2910 = num2909 + 1;
      int index968 = num2909;
      int num2911 = (int) numArray818[this.ucScreenLED1.LEDE7 * 3 + 1];
      numArray973[index968] = (byte) num2911;
      byte[] numArray974 = second;
      int num2912 = num2910;
      int num2913 = num2912 + 1;
      int index969 = num2912;
      int num2914 = (int) numArray818[this.ucScreenLED1.LEDE7 * 3 + 2];
      numArray974[index969] = (byte) num2914;
      byte[] numArray975 = second;
      int num2915 = num2913;
      int num2916 = num2915 + 1;
      int index970 = num2915;
      int num2917 = (int) numArray818[this.ucScreenLED1.LEDG7 * 3];
      numArray975[index970] = (byte) num2917;
      byte[] numArray976 = second;
      int num2918 = num2916;
      int num2919 = num2918 + 1;
      int index971 = num2918;
      int num2920 = (int) numArray818[this.ucScreenLED1.LEDG7 * 3 + 1];
      numArray976[index971] = (byte) num2920;
      byte[] numArray977 = second;
      int num2921 = num2919;
      int num2922 = num2921 + 1;
      int index972 = num2921;
      int num2923 = (int) numArray818[this.ucScreenLED1.LEDG7 * 3 + 2];
      numArray977[index972] = (byte) num2923;
      byte[] numArray978 = second;
      int num2924 = num2922;
      int num2925 = num2924 + 1;
      int index973 = num2924;
      int num2926 = (int) numArray818[this.ucScreenLED1.LEDB7 * 3];
      numArray978[index973] = (byte) num2926;
      byte[] numArray979 = second;
      int num2927 = num2925;
      int num2928 = num2927 + 1;
      int index974 = num2927;
      int num2929 = (int) numArray818[this.ucScreenLED1.LEDB7 * 3 + 1];
      numArray979[index974] = (byte) num2929;
      byte[] numArray980 = second;
      int num2930 = num2928;
      int num2931 = num2930 + 1;
      int index975 = num2930;
      int num2932 = (int) numArray818[this.ucScreenLED1.LEDB7 * 3 + 2];
      numArray980[index975] = (byte) num2932;
      byte[] numArray981 = second;
      int num2933 = num2931;
      int num2934 = num2933 + 1;
      int index976 = num2933;
      int num2935 = (int) numArray818[this.ucScreenLED1.LEDA7 * 3];
      numArray981[index976] = (byte) num2935;
      byte[] numArray982 = second;
      int num2936 = num2934;
      int num2937 = num2936 + 1;
      int index977 = num2936;
      int num2938 = (int) numArray818[this.ucScreenLED1.LEDA7 * 3 + 1];
      numArray982[index977] = (byte) num2938;
      byte[] numArray983 = second;
      int num2939 = num2937;
      int num2940 = num2939 + 1;
      int index978 = num2939;
      int num2941 = (int) numArray818[this.ucScreenLED1.LEDA7 * 3 + 2];
      numArray983[index978] = (byte) num2941;
      byte[] numArray984 = second;
      int num2942 = num2940;
      int num2943 = num2942 + 1;
      int index979 = num2942;
      int num2944 = (int) numArray818[this.ucScreenLED1.LEDF7 * 3];
      numArray984[index979] = (byte) num2944;
      byte[] numArray985 = second;
      int num2945 = num2943;
      int num2946 = num2945 + 1;
      int index980 = num2945;
      int num2947 = (int) numArray818[this.ucScreenLED1.LEDF7 * 3 + 1];
      numArray985[index980] = (byte) num2947;
      byte[] numArray986 = second;
      int num2948 = num2946;
      int num2949 = num2948 + 1;
      int index981 = num2948;
      int num2950 = (int) numArray818[this.ucScreenLED1.LEDF7 * 3 + 2];
      numArray986[index981] = (byte) num2950;
      byte[] numArray987 = second;
      int num2951 = num2949;
      int num2952 = num2951 + 1;
      int index982 = num2951;
      int num2953 = (int) numArray818[this.ucScreenLED1.ZhuangShi13 * 3];
      numArray987[index982] = (byte) num2953;
      byte[] numArray988 = second;
      int num2954 = num2952;
      int num2955 = num2954 + 1;
      int index983 = num2954;
      int num2956 = (int) numArray818[this.ucScreenLED1.ZhuangShi13 * 3 + 1];
      numArray988[index983] = (byte) num2956;
      byte[] numArray989 = second;
      int num2957 = num2955;
      int num2958 = num2957 + 1;
      int index984 = num2957;
      int num2959 = (int) numArray818[this.ucScreenLED1.ZhuangShi13 * 3 + 2];
      numArray989[index984] = (byte) num2959;
      byte[] numArray990 = second;
      int num2960 = num2958;
      int num2961 = num2960 + 1;
      int index985 = num2960;
      int num2962 = (int) numArray818[this.ucScreenLED1.ZhuangShi14 * 3];
      numArray990[index985] = (byte) num2962;
      byte[] numArray991 = second;
      int num2963 = num2961;
      int num2964 = num2963 + 1;
      int index986 = num2963;
      int num2965 = (int) numArray818[this.ucScreenLED1.ZhuangShi14 * 3 + 1];
      numArray991[index986] = (byte) num2965;
      byte[] numArray992 = second;
      int num2966 = num2964;
      int num2967 = num2966 + 1;
      int index987 = num2966;
      int num2968 = (int) numArray818[this.ucScreenLED1.ZhuangShi14 * 3 + 2];
      numArray992[index987] = (byte) num2968;
      byte[] numArray993 = second;
      int num2969 = num2967;
      int num2970 = num2969 + 1;
      int index988 = num2969;
      int num2971 = (int) numArray818[this.ucScreenLED1.ZhuangShi15 * 3];
      numArray993[index988] = (byte) num2971;
      byte[] numArray994 = second;
      int num2972 = num2970;
      int num2973 = num2972 + 1;
      int index989 = num2972;
      int num2974 = (int) numArray818[this.ucScreenLED1.ZhuangShi15 * 3 + 1];
      numArray994[index989] = (byte) num2974;
      byte[] numArray995 = second;
      int num2975 = num2973;
      int num2976 = num2975 + 1;
      int index990 = num2975;
      int num2977 = (int) numArray818[this.ucScreenLED1.ZhuangShi15 * 3 + 2];
      numArray995[index990] = (byte) num2977;
      byte[] numArray996 = second;
      int num2978 = num2976;
      int num2979 = num2978 + 1;
      int index991 = num2978;
      int num2980 = (int) numArray818[this.ucScreenLED1.ZhuangShi16 * 3];
      numArray996[index991] = (byte) num2980;
      byte[] numArray997 = second;
      int num2981 = num2979;
      int num2982 = num2981 + 1;
      int index992 = num2981;
      int num2983 = (int) numArray818[this.ucScreenLED1.ZhuangShi16 * 3 + 1];
      numArray997[index992] = (byte) num2983;
      byte[] numArray998 = second;
      int num2984 = num2982;
      int num2985 = num2984 + 1;
      int index993 = num2984;
      int num2986 = (int) numArray818[this.ucScreenLED1.ZhuangShi16 * 3 + 2];
      numArray998[index993] = (byte) num2986;
      byte[] numArray999 = second;
      int num2987 = num2985;
      int num2988 = num2987 + 1;
      int index994 = num2987;
      int num2989 = (int) numArray818[this.ucScreenLED1.ZhuangShi17 * 3];
      numArray999[index994] = (byte) num2989;
      byte[] numArray1000 = second;
      int num2990 = num2988;
      int num2991 = num2990 + 1;
      int index995 = num2990;
      int num2992 = (int) numArray818[this.ucScreenLED1.ZhuangShi17 * 3 + 1];
      numArray1000[index995] = (byte) num2992;
      byte[] numArray1001 = second;
      int num2993 = num2991;
      int num2994 = num2993 + 1;
      int index996 = num2993;
      int num2995 = (int) numArray818[this.ucScreenLED1.ZhuangShi17 * 3 + 2];
      numArray1001[index996] = (byte) num2995;
      byte[] numArray1002 = second;
      int num2996 = num2994;
      int num2997 = num2996 + 1;
      int index997 = num2996;
      int num2998 = (int) numArray818[this.ucScreenLED1.ZhuangShi18 * 3];
      numArray1002[index997] = (byte) num2998;
      byte[] numArray1003 = second;
      int num2999 = num2997;
      int num3000 = num2999 + 1;
      int index998 = num2999;
      int num3001 = (int) numArray818[this.ucScreenLED1.ZhuangShi18 * 3 + 1];
      numArray1003[index998] = (byte) num3001;
      byte[] numArray1004 = second;
      int num3002 = num3000;
      int num3003 = num3002 + 1;
      int index999 = num3002;
      int num3004 = (int) numArray818[this.ucScreenLED1.ZhuangShi18 * 3 + 2];
      numArray1004[index999] = (byte) num3004;
      byte[] numArray1005 = second;
      int num3005 = num3003;
      int num3006 = num3005 + 1;
      int index1000 = num3005;
      int num3007 = (int) numArray818[this.ucScreenLED1.ZhuangShi19 * 3];
      numArray1005[index1000] = (byte) num3007;
      byte[] numArray1006 = second;
      int num3008 = num3006;
      int num3009 = num3008 + 1;
      int index1001 = num3008;
      int num3010 = (int) numArray818[this.ucScreenLED1.ZhuangShi19 * 3 + 1];
      numArray1006[index1001] = (byte) num3010;
      byte[] numArray1007 = second;
      int num3011 = num3009;
      int num3012 = num3011 + 1;
      int index1002 = num3011;
      int num3013 = (int) numArray818[this.ucScreenLED1.ZhuangShi19 * 3 + 2];
      numArray1007[index1002] = (byte) num3013;
      byte[] numArray1008 = second;
      int num3014 = num3012;
      int num3015 = num3014 + 1;
      int index1003 = num3014;
      int num3016 = (int) numArray818[this.ucScreenLED1.ZhuangShi20 * 3];
      numArray1008[index1003] = (byte) num3016;
      byte[] numArray1009 = second;
      int num3017 = num3015;
      int num3018 = num3017 + 1;
      int index1004 = num3017;
      int num3019 = (int) numArray818[this.ucScreenLED1.ZhuangShi20 * 3 + 1];
      numArray1009[index1004] = (byte) num3019;
      byte[] numArray1010 = second;
      int num3020 = num3018;
      int num3021 = num3020 + 1;
      int index1005 = num3020;
      int num3022 = (int) numArray818[this.ucScreenLED1.ZhuangShi20 * 3 + 2];
      numArray1010[index1005] = (byte) num3022;
      byte[] numArray1011 = second;
      int num3023 = num3021;
      int num3024 = num3023 + 1;
      int index1006 = num3023;
      int num3025 = (int) numArray818[this.ucScreenLED1.ZhuangShi21 * 3];
      numArray1011[index1006] = (byte) num3025;
      byte[] numArray1012 = second;
      int num3026 = num3024;
      int num3027 = num3026 + 1;
      int index1007 = num3026;
      int num3028 = (int) numArray818[this.ucScreenLED1.ZhuangShi21 * 3 + 1];
      numArray1012[index1007] = (byte) num3028;
      byte[] numArray1013 = second;
      int num3029 = num3027;
      int num3030 = num3029 + 1;
      int index1008 = num3029;
      int num3031 = (int) numArray818[this.ucScreenLED1.ZhuangShi21 * 3 + 2];
      numArray1013[index1008] = (byte) num3031;
      byte[] numArray1014 = second;
      int num3032 = num3030;
      int num3033 = num3032 + 1;
      int index1009 = num3032;
      int num3034 = (int) numArray818[this.ucScreenLED1.ZhuangShi22 * 3];
      numArray1014[index1009] = (byte) num3034;
      byte[] numArray1015 = second;
      int num3035 = num3033;
      int num3036 = num3035 + 1;
      int index1010 = num3035;
      int num3037 = (int) numArray818[this.ucScreenLED1.ZhuangShi22 * 3 + 1];
      numArray1015[index1010] = (byte) num3037;
      byte[] numArray1016 = second;
      int num3038 = num3036;
      int num3039 = num3038 + 1;
      int index1011 = num3038;
      int num3040 = (int) numArray818[this.ucScreenLED1.ZhuangShi22 * 3 + 2];
      numArray1016[index1011] = (byte) num3040;
      byte[] numArray1017 = second;
      int num3041 = num3039;
      int num3042 = num3041 + 1;
      int index1012 = num3041;
      int num3043 = (int) numArray818[this.ucScreenLED1.ZhuangShi23 * 3];
      numArray1017[index1012] = (byte) num3043;
      byte[] numArray1018 = second;
      int num3044 = num3042;
      int num3045 = num3044 + 1;
      int index1013 = num3044;
      int num3046 = (int) numArray818[this.ucScreenLED1.ZhuangShi23 * 3 + 1];
      numArray1018[index1013] = (byte) num3046;
      byte[] numArray1019 = second;
      int num3047 = num3045;
      int num3048 = num3047 + 1;
      int index1014 = num3047;
      int num3049 = (int) numArray818[this.ucScreenLED1.ZhuangShi23 * 3 + 2];
      numArray1019[index1014] = (byte) num3049;
      byte[] numArray1020 = second;
      int num3050 = num3048;
      int num3051 = num3050 + 1;
      int index1015 = num3050;
      int num3052 = (int) numArray818[this.ucScreenLED1.ZhuangShi24 * 3];
      numArray1020[index1015] = (byte) num3052;
      byte[] numArray1021 = second;
      int num3053 = num3051;
      int num3054 = num3053 + 1;
      int index1016 = num3053;
      int num3055 = (int) numArray818[this.ucScreenLED1.ZhuangShi24 * 3 + 1];
      numArray1021[index1016] = (byte) num3055;
      byte[] numArray1022 = second;
      int num3056 = num3054;
      int num3057 = num3056 + 1;
      int index1017 = num3056;
      int num3058 = (int) numArray818[this.ucScreenLED1.ZhuangShi24 * 3 + 2];
      numArray1022[index1017] = (byte) num3058;
      byte[] numArray1023 = second;
      int num3059 = num3057;
      int num3060 = num3059 + 1;
      int index1018 = num3059;
      int num3061 = (int) numArray818[this.ucScreenLED1.ZhuangShi25 * 3];
      numArray1023[index1018] = (byte) num3061;
      byte[] numArray1024 = second;
      int num3062 = num3060;
      int num3063 = num3062 + 1;
      int index1019 = num3062;
      int num3064 = (int) numArray818[this.ucScreenLED1.ZhuangShi25 * 3 + 1];
      numArray1024[index1019] = (byte) num3064;
      byte[] numArray1025 = second;
      int num3065 = num3063;
      int num3066 = num3065 + 1;
      int index1020 = num3065;
      int num3067 = (int) numArray818[this.ucScreenLED1.ZhuangShi25 * 3 + 2];
      numArray1025[index1020] = (byte) num3067;
      byte[] numArray1026 = second;
      int num3068 = num3066;
      int num3069 = num3068 + 1;
      int index1021 = num3068;
      int num3070 = (int) numArray818[this.ucScreenLED1.ZhuangShi26 * 3];
      numArray1026[index1021] = (byte) num3070;
      byte[] numArray1027 = second;
      int num3071 = num3069;
      int num3072 = num3071 + 1;
      int index1022 = num3071;
      int num3073 = (int) numArray818[this.ucScreenLED1.ZhuangShi26 * 3 + 1];
      numArray1027[index1022] = (byte) num3073;
      byte[] numArray1028 = second;
      int num3074 = num3072;
      int num3075 = num3074 + 1;
      int index1023 = num3074;
      int num3076 = (int) numArray818[this.ucScreenLED1.ZhuangShi26 * 3 + 2];
      numArray1028[index1023] = (byte) num3076;
      byte[] numArray1029 = second;
      int num3077 = num3075;
      int num3078 = num3077 + 1;
      int index1024 = num3077;
      int num3079 = (int) numArray818[this.ucScreenLED1.WATT * 3];
      numArray1029[index1024] = (byte) num3079;
      byte[] numArray1030 = second;
      int num3080 = num3078;
      int num3081 = num3080 + 1;
      int index1025 = num3080;
      int num3082 = (int) numArray818[this.ucScreenLED1.WATT * 3 + 1];
      numArray1030[index1025] = (byte) num3082;
      byte[] numArray1031 = second;
      int num3083 = num3081;
      int num3084 = num3083 + 1;
      int index1026 = num3083;
      int num3085 = (int) numArray818[this.ucScreenLED1.WATT * 3 + 2];
      numArray1031[index1026] = (byte) num3085;
      byte[] numArray1032 = second;
      int num3086 = num3084;
      int num3087 = num3086 + 1;
      int index1027 = num3086;
      int num3088 = (int) numArray818[this.ucScreenLED1.LEDC6 * 3];
      numArray1032[index1027] = (byte) num3088;
      byte[] numArray1033 = second;
      int num3089 = num3087;
      int num3090 = num3089 + 1;
      int index1028 = num3089;
      int num3091 = (int) numArray818[this.ucScreenLED1.LEDC6 * 3 + 1];
      numArray1033[index1028] = (byte) num3091;
      byte[] numArray1034 = second;
      int num3092 = num3090;
      int num3093 = num3092 + 1;
      int index1029 = num3092;
      int num3094 = (int) numArray818[this.ucScreenLED1.LEDC6 * 3 + 2];
      numArray1034[index1029] = (byte) num3094;
      byte[] numArray1035 = second;
      int num3095 = num3093;
      int num3096 = num3095 + 1;
      int index1030 = num3095;
      int num3097 = (int) numArray818[this.ucScreenLED1.LEDD6 * 3];
      numArray1035[index1030] = (byte) num3097;
      byte[] numArray1036 = second;
      int num3098 = num3096;
      int num3099 = num3098 + 1;
      int index1031 = num3098;
      int num3100 = (int) numArray818[this.ucScreenLED1.LEDD6 * 3 + 1];
      numArray1036[index1031] = (byte) num3100;
      byte[] numArray1037 = second;
      int num3101 = num3099;
      int num3102 = num3101 + 1;
      int index1032 = num3101;
      int num3103 = (int) numArray818[this.ucScreenLED1.LEDD6 * 3 + 2];
      numArray1037[index1032] = (byte) num3103;
      byte[] numArray1038 = second;
      int num3104 = num3102;
      int num3105 = num3104 + 1;
      int index1033 = num3104;
      int num3106 = (int) numArray818[this.ucScreenLED1.LEDE6 * 3];
      numArray1038[index1033] = (byte) num3106;
      byte[] numArray1039 = second;
      int num3107 = num3105;
      int num3108 = num3107 + 1;
      int index1034 = num3107;
      int num3109 = (int) numArray818[this.ucScreenLED1.LEDE6 * 3 + 1];
      numArray1039[index1034] = (byte) num3109;
      byte[] numArray1040 = second;
      int num3110 = num3108;
      int num3111 = num3110 + 1;
      int index1035 = num3110;
      int num3112 = (int) numArray818[this.ucScreenLED1.LEDE6 * 3 + 2];
      numArray1040[index1035] = (byte) num3112;
      byte[] numArray1041 = second;
      int num3113 = num3111;
      int num3114 = num3113 + 1;
      int index1036 = num3113;
      int num3115 = (int) numArray818[this.ucScreenLED1.LEDG6 * 3];
      numArray1041[index1036] = (byte) num3115;
      byte[] numArray1042 = second;
      int num3116 = num3114;
      int num3117 = num3116 + 1;
      int index1037 = num3116;
      int num3118 = (int) numArray818[this.ucScreenLED1.LEDG6 * 3 + 1];
      numArray1042[index1037] = (byte) num3118;
      byte[] numArray1043 = second;
      int num3119 = num3117;
      int num3120 = num3119 + 1;
      int index1038 = num3119;
      int num3121 = (int) numArray818[this.ucScreenLED1.LEDG6 * 3 + 2];
      numArray1043[index1038] = (byte) num3121;
      byte[] numArray1044 = second;
      int num3122 = num3120;
      int num3123 = num3122 + 1;
      int index1039 = num3122;
      int num3124 = (int) numArray818[this.ucScreenLED1.LEDB6 * 3];
      numArray1044[index1039] = (byte) num3124;
      byte[] numArray1045 = second;
      int num3125 = num3123;
      int num3126 = num3125 + 1;
      int index1040 = num3125;
      int num3127 = (int) numArray818[this.ucScreenLED1.LEDB6 * 3 + 1];
      numArray1045[index1040] = (byte) num3127;
      byte[] numArray1046 = second;
      int num3128 = num3126;
      int num3129 = num3128 + 1;
      int index1041 = num3128;
      int num3130 = (int) numArray818[this.ucScreenLED1.LEDB6 * 3 + 2];
      numArray1046[index1041] = (byte) num3130;
      byte[] numArray1047 = second;
      int num3131 = num3129;
      int num3132 = num3131 + 1;
      int index1042 = num3131;
      int num3133 = (int) numArray818[this.ucScreenLED1.LEDA6 * 3];
      numArray1047[index1042] = (byte) num3133;
      byte[] numArray1048 = second;
      int num3134 = num3132;
      int num3135 = num3134 + 1;
      int index1043 = num3134;
      int num3136 = (int) numArray818[this.ucScreenLED1.LEDA6 * 3 + 1];
      numArray1048[index1043] = (byte) num3136;
      byte[] numArray1049 = second;
      int num3137 = num3135;
      int num3138 = num3137 + 1;
      int index1044 = num3137;
      int num3139 = (int) numArray818[this.ucScreenLED1.LEDA6 * 3 + 2];
      numArray1049[index1044] = (byte) num3139;
      byte[] numArray1050 = second;
      int num3140 = num3138;
      int num3141 = num3140 + 1;
      int index1045 = num3140;
      int num3142 = (int) numArray818[this.ucScreenLED1.LEDF6 * 3];
      numArray1050[index1045] = (byte) num3142;
      byte[] numArray1051 = second;
      int num3143 = num3141;
      int num3144 = num3143 + 1;
      int index1046 = num3143;
      int num3145 = (int) numArray818[this.ucScreenLED1.LEDF6 * 3 + 1];
      numArray1051[index1046] = (byte) num3145;
      byte[] numArray1052 = second;
      int num3146 = num3144;
      int num3147 = num3146 + 1;
      int index1047 = num3146;
      int num3148 = (int) numArray818[this.ucScreenLED1.LEDF6 * 3 + 2];
      numArray1052[index1047] = (byte) num3148;
      byte[] numArray1053 = second;
      int num3149 = num3147;
      int num3150 = num3149 + 1;
      int index1048 = num3149;
      int num3151 = (int) numArray818[this.ucScreenLED1.LEDC5 * 3];
      numArray1053[index1048] = (byte) num3151;
      byte[] numArray1054 = second;
      int num3152 = num3150;
      int num3153 = num3152 + 1;
      int index1049 = num3152;
      int num3154 = (int) numArray818[this.ucScreenLED1.LEDC5 * 3 + 1];
      numArray1054[index1049] = (byte) num3154;
      byte[] numArray1055 = second;
      int num3155 = num3153;
      int num3156 = num3155 + 1;
      int index1050 = num3155;
      int num3157 = (int) numArray818[this.ucScreenLED1.LEDC5 * 3 + 2];
      numArray1055[index1050] = (byte) num3157;
      byte[] numArray1056 = second;
      int num3158 = num3156;
      int num3159 = num3158 + 1;
      int index1051 = num3158;
      int num3160 = (int) numArray818[this.ucScreenLED1.LEDD5 * 3];
      numArray1056[index1051] = (byte) num3160;
      byte[] numArray1057 = second;
      int num3161 = num3159;
      int num3162 = num3161 + 1;
      int index1052 = num3161;
      int num3163 = (int) numArray818[this.ucScreenLED1.LEDD5 * 3 + 1];
      numArray1057[index1052] = (byte) num3163;
      byte[] numArray1058 = second;
      int num3164 = num3162;
      int num3165 = num3164 + 1;
      int index1053 = num3164;
      int num3166 = (int) numArray818[this.ucScreenLED1.LEDD5 * 3 + 2];
      numArray1058[index1053] = (byte) num3166;
      byte[] numArray1059 = second;
      int num3167 = num3165;
      int num3168 = num3167 + 1;
      int index1054 = num3167;
      int num3169 = (int) numArray818[this.ucScreenLED1.LEDE5 * 3];
      numArray1059[index1054] = (byte) num3169;
      byte[] numArray1060 = second;
      int num3170 = num3168;
      int num3171 = num3170 + 1;
      int index1055 = num3170;
      int num3172 = (int) numArray818[this.ucScreenLED1.LEDE5 * 3 + 1];
      numArray1060[index1055] = (byte) num3172;
      byte[] numArray1061 = second;
      int num3173 = num3171;
      int num3174 = num3173 + 1;
      int index1056 = num3173;
      int num3175 = (int) numArray818[this.ucScreenLED1.LEDE5 * 3 + 2];
      numArray1061[index1056] = (byte) num3175;
      byte[] numArray1062 = second;
      int num3176 = num3174;
      int num3177 = num3176 + 1;
      int index1057 = num3176;
      int num3178 = (int) numArray818[this.ucScreenLED1.LEDG5 * 3];
      numArray1062[index1057] = (byte) num3178;
      byte[] numArray1063 = second;
      int num3179 = num3177;
      int num3180 = num3179 + 1;
      int index1058 = num3179;
      int num3181 = (int) numArray818[this.ucScreenLED1.LEDG5 * 3 + 1];
      numArray1063[index1058] = (byte) num3181;
      byte[] numArray1064 = second;
      int num3182 = num3180;
      int num3183 = num3182 + 1;
      int index1059 = num3182;
      int num3184 = (int) numArray818[this.ucScreenLED1.LEDG5 * 3 + 2];
      numArray1064[index1059] = (byte) num3184;
      byte[] numArray1065 = second;
      int num3185 = num3183;
      int num3186 = num3185 + 1;
      int index1060 = num3185;
      int num3187 = (int) numArray818[this.ucScreenLED1.LEDB5 * 3];
      numArray1065[index1060] = (byte) num3187;
      byte[] numArray1066 = second;
      int num3188 = num3186;
      int num3189 = num3188 + 1;
      int index1061 = num3188;
      int num3190 = (int) numArray818[this.ucScreenLED1.LEDB5 * 3 + 1];
      numArray1066[index1061] = (byte) num3190;
      byte[] numArray1067 = second;
      int num3191 = num3189;
      int num3192 = num3191 + 1;
      int index1062 = num3191;
      int num3193 = (int) numArray818[this.ucScreenLED1.LEDB5 * 3 + 2];
      numArray1067[index1062] = (byte) num3193;
      byte[] numArray1068 = second;
      int num3194 = num3192;
      int num3195 = num3194 + 1;
      int index1063 = num3194;
      int num3196 = (int) numArray818[this.ucScreenLED1.LEDA5 * 3];
      numArray1068[index1063] = (byte) num3196;
      byte[] numArray1069 = second;
      int num3197 = num3195;
      int num3198 = num3197 + 1;
      int index1064 = num3197;
      int num3199 = (int) numArray818[this.ucScreenLED1.LEDA5 * 3 + 1];
      numArray1069[index1064] = (byte) num3199;
      byte[] numArray1070 = second;
      int num3200 = num3198;
      int num3201 = num3200 + 1;
      int index1065 = num3200;
      int num3202 = (int) numArray818[this.ucScreenLED1.LEDA5 * 3 + 2];
      numArray1070[index1065] = (byte) num3202;
      byte[] numArray1071 = second;
      int num3203 = num3201;
      int num3204 = num3203 + 1;
      int index1066 = num3203;
      int num3205 = (int) numArray818[this.ucScreenLED1.LEDF5 * 3];
      numArray1071[index1066] = (byte) num3205;
      byte[] numArray1072 = second;
      int num3206 = num3204;
      int num3207 = num3206 + 1;
      int index1067 = num3206;
      int num3208 = (int) numArray818[this.ucScreenLED1.LEDF5 * 3 + 1];
      numArray1072[index1067] = (byte) num3208;
      byte[] numArray1073 = second;
      int num3209 = num3207;
      int num3210 = num3209 + 1;
      int index1068 = num3209;
      int num3211 = (int) numArray818[this.ucScreenLED1.LEDF5 * 3 + 2];
      numArray1073[index1068] = (byte) num3211;
      byte[] numArray1074 = second;
      int num3212 = num3210;
      int num3213 = num3212 + 1;
      int index1069 = num3212;
      int num3214 = (int) numArray818[this.ucScreenLED1.LEDC4 * 3];
      numArray1074[index1069] = (byte) num3214;
      byte[] numArray1075 = second;
      int num3215 = num3213;
      int num3216 = num3215 + 1;
      int index1070 = num3215;
      int num3217 = (int) numArray818[this.ucScreenLED1.LEDC4 * 3 + 1];
      numArray1075[index1070] = (byte) num3217;
      byte[] numArray1076 = second;
      int num3218 = num3216;
      int num3219 = num3218 + 1;
      int index1071 = num3218;
      int num3220 = (int) numArray818[this.ucScreenLED1.LEDC4 * 3 + 2];
      numArray1076[index1071] = (byte) num3220;
      byte[] numArray1077 = second;
      int num3221 = num3219;
      int num3222 = num3221 + 1;
      int index1072 = num3221;
      int num3223 = (int) numArray818[this.ucScreenLED1.LEDD4 * 3];
      numArray1077[index1072] = (byte) num3223;
      byte[] numArray1078 = second;
      int num3224 = num3222;
      int num3225 = num3224 + 1;
      int index1073 = num3224;
      int num3226 = (int) numArray818[this.ucScreenLED1.LEDD4 * 3 + 1];
      numArray1078[index1073] = (byte) num3226;
      byte[] numArray1079 = second;
      int num3227 = num3225;
      int num3228 = num3227 + 1;
      int index1074 = num3227;
      int num3229 = (int) numArray818[this.ucScreenLED1.LEDD4 * 3 + 2];
      numArray1079[index1074] = (byte) num3229;
      byte[] numArray1080 = second;
      int num3230 = num3228;
      int num3231 = num3230 + 1;
      int index1075 = num3230;
      int num3232 = (int) numArray818[this.ucScreenLED1.LEDE4 * 3];
      numArray1080[index1075] = (byte) num3232;
      byte[] numArray1081 = second;
      int num3233 = num3231;
      int num3234 = num3233 + 1;
      int index1076 = num3233;
      int num3235 = (int) numArray818[this.ucScreenLED1.LEDE4 * 3 + 1];
      numArray1081[index1076] = (byte) num3235;
      byte[] numArray1082 = second;
      int num3236 = num3234;
      int num3237 = num3236 + 1;
      int index1077 = num3236;
      int num3238 = (int) numArray818[this.ucScreenLED1.LEDE4 * 3 + 2];
      numArray1082[index1077] = (byte) num3238;
      byte[] numArray1083 = second;
      int num3239 = num3237;
      int num3240 = num3239 + 1;
      int index1078 = num3239;
      int num3241 = (int) numArray818[this.ucScreenLED1.LEDG4 * 3];
      numArray1083[index1078] = (byte) num3241;
      byte[] numArray1084 = second;
      int num3242 = num3240;
      int num3243 = num3242 + 1;
      int index1079 = num3242;
      int num3244 = (int) numArray818[this.ucScreenLED1.LEDG4 * 3 + 1];
      numArray1084[index1079] = (byte) num3244;
      byte[] numArray1085 = second;
      int num3245 = num3243;
      int num3246 = num3245 + 1;
      int index1080 = num3245;
      int num3247 = (int) numArray818[this.ucScreenLED1.LEDG4 * 3 + 2];
      numArray1085[index1080] = (byte) num3247;
      byte[] numArray1086 = second;
      int num3248 = num3246;
      int num3249 = num3248 + 1;
      int index1081 = num3248;
      int num3250 = (int) numArray818[this.ucScreenLED1.LEDB4 * 3];
      numArray1086[index1081] = (byte) num3250;
      byte[] numArray1087 = second;
      int num3251 = num3249;
      int num3252 = num3251 + 1;
      int index1082 = num3251;
      int num3253 = (int) numArray818[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray1087[index1082] = (byte) num3253;
      byte[] numArray1088 = second;
      int num3254 = num3252;
      int num3255 = num3254 + 1;
      int index1083 = num3254;
      int num3256 = (int) numArray818[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray1088[index1083] = (byte) num3256;
      byte[] numArray1089 = second;
      int num3257 = num3255;
      int num3258 = num3257 + 1;
      int index1084 = num3257;
      int num3259 = (int) numArray818[this.ucScreenLED1.LEDA4 * 3];
      numArray1089[index1084] = (byte) num3259;
      byte[] numArray1090 = second;
      int num3260 = num3258;
      int num3261 = num3260 + 1;
      int index1085 = num3260;
      int num3262 = (int) numArray818[this.ucScreenLED1.LEDA4 * 3 + 1];
      numArray1090[index1085] = (byte) num3262;
      byte[] numArray1091 = second;
      int num3263 = num3261;
      int num3264 = num3263 + 1;
      int index1086 = num3263;
      int num3265 = (int) numArray818[this.ucScreenLED1.LEDA4 * 3 + 2];
      numArray1091[index1086] = (byte) num3265;
      byte[] numArray1092 = second;
      int num3266 = num3264;
      int num3267 = num3266 + 1;
      int index1087 = num3266;
      int num3268 = (int) numArray818[this.ucScreenLED1.LEDF4 * 3];
      numArray1092[index1087] = (byte) num3268;
      byte[] numArray1093 = second;
      int num3269 = num3267;
      int num3270 = num3269 + 1;
      int index1088 = num3269;
      int num3271 = (int) numArray818[this.ucScreenLED1.LEDF4 * 3 + 1];
      numArray1093[index1088] = (byte) num3271;
      byte[] numArray1094 = second;
      int num3272 = num3270;
      int num3273 = num3272 + 1;
      int index1089 = num3272;
      int num3274 = (int) numArray818[this.ucScreenLED1.LEDF4 * 3 + 2];
      numArray1094[index1089] = (byte) num3274;
      byte[] numArray1095 = second;
      int num3275 = num3273;
      int num3276 = num3275 + 1;
      int index1090 = num3275;
      int num3277 = (int) numArray818[this.ucScreenLED1.SSD * 3];
      numArray1095[index1090] = (byte) num3277;
      byte[] numArray1096 = second;
      int num3278 = num3276;
      int num3279 = num3278 + 1;
      int index1091 = num3278;
      int num3280 = (int) numArray818[this.ucScreenLED1.SSD * 3 + 1];
      numArray1096[index1091] = (byte) num3280;
      byte[] numArray1097 = second;
      int num3281 = num3279;
      int num3282 = num3281 + 1;
      int index1092 = num3281;
      int num3283 = (int) numArray818[this.ucScreenLED1.SSD * 3 + 2];
      numArray1097[index1092] = (byte) num3283;
      byte[] numArray1098 = second;
      int num3284 = num3282;
      int num3285 = num3284 + 1;
      int index1093 = num3284;
      int num3286 = (int) numArray818[this.ucScreenLED1.HSD * 3];
      numArray1098[index1093] = (byte) num3286;
      byte[] numArray1099 = second;
      int num3287 = num3285;
      int num3288 = num3287 + 1;
      int index1094 = num3287;
      int num3289 = (int) numArray818[this.ucScreenLED1.HSD * 3 + 1];
      numArray1099[index1094] = (byte) num3289;
      byte[] numArray1100 = second;
      int num3290 = num3288;
      int num3291 = num3290 + 1;
      int index1095 = num3290;
      int num3292 = (int) numArray818[this.ucScreenLED1.HSD * 3 + 2];
      numArray1100[index1095] = (byte) num3292;
      byte[] numArray1101 = second;
      int num3293 = num3291;
      int num3294 = num3293 + 1;
      int index1096 = num3293;
      int num3295 = (int) numArray818[this.ucScreenLED1.LEDC3 * 3];
      numArray1101[index1096] = (byte) num3295;
      byte[] numArray1102 = second;
      int num3296 = num3294;
      int num3297 = num3296 + 1;
      int index1097 = num3296;
      int num3298 = (int) numArray818[this.ucScreenLED1.LEDC3 * 3 + 1];
      numArray1102[index1097] = (byte) num3298;
      byte[] numArray1103 = second;
      int num3299 = num3297;
      int num3300 = num3299 + 1;
      int index1098 = num3299;
      int num3301 = (int) numArray818[this.ucScreenLED1.LEDC3 * 3 + 2];
      numArray1103[index1098] = (byte) num3301;
      byte[] numArray1104 = second;
      int num3302 = num3300;
      int num3303 = num3302 + 1;
      int index1099 = num3302;
      int num3304 = (int) numArray818[this.ucScreenLED1.LEDD3 * 3];
      numArray1104[index1099] = (byte) num3304;
      byte[] numArray1105 = second;
      int num3305 = num3303;
      int num3306 = num3305 + 1;
      int index1100 = num3305;
      int num3307 = (int) numArray818[this.ucScreenLED1.LEDD3 * 3 + 1];
      numArray1105[index1100] = (byte) num3307;
      byte[] numArray1106 = second;
      int num3308 = num3306;
      int num3309 = num3308 + 1;
      int index1101 = num3308;
      int num3310 = (int) numArray818[this.ucScreenLED1.LEDD3 * 3 + 2];
      numArray1106[index1101] = (byte) num3310;
      byte[] numArray1107 = second;
      int num3311 = num3309;
      int num3312 = num3311 + 1;
      int index1102 = num3311;
      int num3313 = (int) numArray818[this.ucScreenLED1.LEDE3 * 3];
      numArray1107[index1102] = (byte) num3313;
      byte[] numArray1108 = second;
      int num3314 = num3312;
      int num3315 = num3314 + 1;
      int index1103 = num3314;
      int num3316 = (int) numArray818[this.ucScreenLED1.LEDE3 * 3 + 1];
      numArray1108[index1103] = (byte) num3316;
      byte[] numArray1109 = second;
      int num3317 = num3315;
      int num3318 = num3317 + 1;
      int index1104 = num3317;
      int num3319 = (int) numArray818[this.ucScreenLED1.LEDE3 * 3 + 2];
      numArray1109[index1104] = (byte) num3319;
      byte[] numArray1110 = second;
      int num3320 = num3318;
      int num3321 = num3320 + 1;
      int index1105 = num3320;
      int num3322 = (int) numArray818[this.ucScreenLED1.LEDG3 * 3];
      numArray1110[index1105] = (byte) num3322;
      byte[] numArray1111 = second;
      int num3323 = num3321;
      int num3324 = num3323 + 1;
      int index1106 = num3323;
      int num3325 = (int) numArray818[this.ucScreenLED1.LEDG3 * 3 + 1];
      numArray1111[index1106] = (byte) num3325;
      byte[] numArray1112 = second;
      int num3326 = num3324;
      int num3327 = num3326 + 1;
      int index1107 = num3326;
      int num3328 = (int) numArray818[this.ucScreenLED1.LEDG3 * 3 + 2];
      numArray1112[index1107] = (byte) num3328;
      byte[] numArray1113 = second;
      int num3329 = num3327;
      int num3330 = num3329 + 1;
      int index1108 = num3329;
      int num3331 = (int) numArray818[this.ucScreenLED1.LEDB3 * 3];
      numArray1113[index1108] = (byte) num3331;
      byte[] numArray1114 = second;
      int num3332 = num3330;
      int num3333 = num3332 + 1;
      int index1109 = num3332;
      int num3334 = (int) numArray818[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray1114[index1109] = (byte) num3334;
      byte[] numArray1115 = second;
      int num3335 = num3333;
      int num3336 = num3335 + 1;
      int index1110 = num3335;
      int num3337 = (int) numArray818[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray1115[index1110] = (byte) num3337;
      byte[] numArray1116 = second;
      int num3338 = num3336;
      int num3339 = num3338 + 1;
      int index1111 = num3338;
      int num3340 = (int) numArray818[this.ucScreenLED1.LEDA3 * 3];
      numArray1116[index1111] = (byte) num3340;
      byte[] numArray1117 = second;
      int num3341 = num3339;
      int num3342 = num3341 + 1;
      int index1112 = num3341;
      int num3343 = (int) numArray818[this.ucScreenLED1.LEDA3 * 3 + 1];
      numArray1117[index1112] = (byte) num3343;
      byte[] numArray1118 = second;
      int num3344 = num3342;
      int num3345 = num3344 + 1;
      int index1113 = num3344;
      int num3346 = (int) numArray818[this.ucScreenLED1.LEDA3 * 3 + 2];
      numArray1118[index1113] = (byte) num3346;
      byte[] numArray1119 = second;
      int num3347 = num3345;
      int num3348 = num3347 + 1;
      int index1114 = num3347;
      int num3349 = (int) numArray818[this.ucScreenLED1.Gpu1 * 3];
      numArray1119[index1114] = (byte) num3349;
      byte[] numArray1120 = second;
      int num3350 = num3348;
      int num3351 = num3350 + 1;
      int index1115 = num3350;
      int num3352 = (int) numArray818[this.ucScreenLED1.Gpu1 * 3 + 1];
      numArray1120[index1115] = (byte) num3352;
      byte[] numArray1121 = second;
      int num3353 = num3351;
      int num3354 = num3353 + 1;
      int index1116 = num3353;
      int num3355 = (int) numArray818[this.ucScreenLED1.Gpu1 * 3 + 2];
      numArray1121[index1116] = (byte) num3355;
      byte[] numArray1122 = second;
      int num3356 = num3354;
      int num3357 = num3356 + 1;
      int index1117 = num3356;
      int num3358 = (int) numArray818[this.ucScreenLED1.LEDF3 * 3];
      numArray1122[index1117] = (byte) num3358;
      byte[] numArray1123 = second;
      int num3359 = num3357;
      int num3360 = num3359 + 1;
      int index1118 = num3359;
      int num3361 = (int) numArray818[this.ucScreenLED1.LEDF3 * 3 + 1];
      numArray1123[index1118] = (byte) num3361;
      byte[] numArray1124 = second;
      int num3362 = num3360;
      int num3363 = num3362 + 1;
      int index1119 = num3362;
      int num3364 = (int) numArray818[this.ucScreenLED1.LEDF3 * 3 + 2];
      numArray1124[index1119] = (byte) num3364;
      byte[] numArray1125 = second;
      int num3365 = num3363;
      int num3366 = num3365 + 1;
      int index1120 = num3365;
      int num3367 = (int) numArray818[this.ucScreenLED1.LEDC2 * 3];
      numArray1125[index1120] = (byte) num3367;
      byte[] numArray1126 = second;
      int num3368 = num3366;
      int num3369 = num3368 + 1;
      int index1121 = num3368;
      int num3370 = (int) numArray818[this.ucScreenLED1.LEDC2 * 3 + 1];
      numArray1126[index1121] = (byte) num3370;
      byte[] numArray1127 = second;
      int num3371 = num3369;
      int num3372 = num3371 + 1;
      int index1122 = num3371;
      int num3373 = (int) numArray818[this.ucScreenLED1.LEDC2 * 3 + 2];
      numArray1127[index1122] = (byte) num3373;
      byte[] numArray1128 = second;
      int num3374 = num3372;
      int num3375 = num3374 + 1;
      int index1123 = num3374;
      int num3376 = (int) numArray818[this.ucScreenLED1.LEDD2 * 3];
      numArray1128[index1123] = (byte) num3376;
      byte[] numArray1129 = second;
      int num3377 = num3375;
      int num3378 = num3377 + 1;
      int index1124 = num3377;
      int num3379 = (int) numArray818[this.ucScreenLED1.LEDD2 * 3 + 1];
      numArray1129[index1124] = (byte) num3379;
      byte[] numArray1130 = second;
      int num3380 = num3378;
      int num3381 = num3380 + 1;
      int index1125 = num3380;
      int num3382 = (int) numArray818[this.ucScreenLED1.LEDD2 * 3 + 2];
      numArray1130[index1125] = (byte) num3382;
      byte[] numArray1131 = second;
      int num3383 = num3381;
      int num3384 = num3383 + 1;
      int index1126 = num3383;
      int num3385 = (int) numArray818[this.ucScreenLED1.LEDE2 * 3];
      numArray1131[index1126] = (byte) num3385;
      byte[] numArray1132 = second;
      int num3386 = num3384;
      int num3387 = num3386 + 1;
      int index1127 = num3386;
      int num3388 = (int) numArray818[this.ucScreenLED1.LEDE2 * 3 + 1];
      numArray1132[index1127] = (byte) num3388;
      byte[] numArray1133 = second;
      int num3389 = num3387;
      int num3390 = num3389 + 1;
      int index1128 = num3389;
      int num3391 = (int) numArray818[this.ucScreenLED1.LEDE2 * 3 + 2];
      numArray1133[index1128] = (byte) num3391;
      byte[] numArray1134 = second;
      int num3392 = num3390;
      int num3393 = num3392 + 1;
      int index1129 = num3392;
      int num3394 = (int) numArray818[this.ucScreenLED1.LEDG2 * 3];
      numArray1134[index1129] = (byte) num3394;
      byte[] numArray1135 = second;
      int num3395 = num3393;
      int num3396 = num3395 + 1;
      int index1130 = num3395;
      int num3397 = (int) numArray818[this.ucScreenLED1.LEDG2 * 3 + 1];
      numArray1135[index1130] = (byte) num3397;
      byte[] numArray1136 = second;
      int num3398 = num3396;
      int num3399 = num3398 + 1;
      int index1131 = num3398;
      int num3400 = (int) numArray818[this.ucScreenLED1.LEDG2 * 3 + 2];
      numArray1136[index1131] = (byte) num3400;
      byte[] numArray1137 = second;
      int num3401 = num3399;
      int num3402 = num3401 + 1;
      int index1132 = num3401;
      int num3403 = (int) numArray818[this.ucScreenLED1.LEDB2 * 3];
      numArray1137[index1132] = (byte) num3403;
      byte[] numArray1138 = second;
      int num3404 = num3402;
      int num3405 = num3404 + 1;
      int index1133 = num3404;
      int num3406 = (int) numArray818[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray1138[index1133] = (byte) num3406;
      byte[] numArray1139 = second;
      int num3407 = num3405;
      int num3408 = num3407 + 1;
      int index1134 = num3407;
      int num3409 = (int) numArray818[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray1139[index1134] = (byte) num3409;
      byte[] numArray1140 = second;
      int num3410 = num3408;
      int num3411 = num3410 + 1;
      int index1135 = num3410;
      int num3412 = (int) numArray818[this.ucScreenLED1.LEDA2 * 3];
      numArray1140[index1135] = (byte) num3412;
      byte[] numArray1141 = second;
      int num3413 = num3411;
      int num3414 = num3413 + 1;
      int index1136 = num3413;
      int num3415 = (int) numArray818[this.ucScreenLED1.LEDA2 * 3 + 1];
      numArray1141[index1136] = (byte) num3415;
      byte[] numArray1142 = second;
      int num3416 = num3414;
      int num3417 = num3416 + 1;
      int index1137 = num3416;
      int num3418 = (int) numArray818[this.ucScreenLED1.LEDA2 * 3 + 2];
      numArray1142[index1137] = (byte) num3418;
      byte[] numArray1143 = second;
      int num3419 = num3417;
      int num3420 = num3419 + 1;
      int index1138 = num3419;
      int num3421 = (int) numArray818[this.ucScreenLED1.LEDF2 * 3];
      numArray1143[index1138] = (byte) num3421;
      byte[] numArray1144 = second;
      int num3422 = num3420;
      int num3423 = num3422 + 1;
      int index1139 = num3422;
      int num3424 = (int) numArray818[this.ucScreenLED1.LEDF2 * 3 + 1];
      numArray1144[index1139] = (byte) num3424;
      byte[] numArray1145 = second;
      int num3425 = num3423;
      int num3426 = num3425 + 1;
      int index1140 = num3425;
      int num3427 = (int) numArray818[this.ucScreenLED1.LEDF2 * 3 + 2];
      numArray1145[index1140] = (byte) num3427;
      byte[] numArray1146 = second;
      int num3428 = num3426;
      int num3429 = num3428 + 1;
      int index1141 = num3428;
      int num3430 = (int) numArray818[this.ucScreenLED1.LEDC1 * 3];
      numArray1146[index1141] = (byte) num3430;
      byte[] numArray1147 = second;
      int num3431 = num3429;
      int num3432 = num3431 + 1;
      int index1142 = num3431;
      int num3433 = (int) numArray818[this.ucScreenLED1.LEDC1 * 3 + 1];
      numArray1147[index1142] = (byte) num3433;
      byte[] numArray1148 = second;
      int num3434 = num3432;
      int num3435 = num3434 + 1;
      int index1143 = num3434;
      int num3436 = (int) numArray818[this.ucScreenLED1.LEDC1 * 3 + 2];
      numArray1148[index1143] = (byte) num3436;
      byte[] numArray1149 = second;
      int num3437 = num3435;
      int num3438 = num3437 + 1;
      int index1144 = num3437;
      int num3439 = (int) numArray818[this.ucScreenLED1.LEDD1 * 3];
      numArray1149[index1144] = (byte) num3439;
      byte[] numArray1150 = second;
      int num3440 = num3438;
      int num3441 = num3440 + 1;
      int index1145 = num3440;
      int num3442 = (int) numArray818[this.ucScreenLED1.LEDD1 * 3 + 1];
      numArray1150[index1145] = (byte) num3442;
      byte[] numArray1151 = second;
      int num3443 = num3441;
      int num3444 = num3443 + 1;
      int index1146 = num3443;
      int num3445 = (int) numArray818[this.ucScreenLED1.LEDD1 * 3 + 2];
      numArray1151[index1146] = (byte) num3445;
      byte[] numArray1152 = second;
      int num3446 = num3444;
      int num3447 = num3446 + 1;
      int index1147 = num3446;
      int num3448 = (int) numArray818[this.ucScreenLED1.LEDE1 * 3];
      numArray1152[index1147] = (byte) num3448;
      byte[] numArray1153 = second;
      int num3449 = num3447;
      int num3450 = num3449 + 1;
      int index1148 = num3449;
      int num3451 = (int) numArray818[this.ucScreenLED1.LEDE1 * 3 + 1];
      numArray1153[index1148] = (byte) num3451;
      byte[] numArray1154 = second;
      int num3452 = num3450;
      int num3453 = num3452 + 1;
      int index1149 = num3452;
      int num3454 = (int) numArray818[this.ucScreenLED1.LEDE1 * 3 + 2];
      numArray1154[index1149] = (byte) num3454;
      byte[] numArray1155 = second;
      int num3455 = num3453;
      int num3456 = num3455 + 1;
      int index1150 = num3455;
      int num3457 = (int) numArray818[this.ucScreenLED1.LEDG1 * 3];
      numArray1155[index1150] = (byte) num3457;
      byte[] numArray1156 = second;
      int num3458 = num3456;
      int num3459 = num3458 + 1;
      int index1151 = num3458;
      int num3460 = (int) numArray818[this.ucScreenLED1.LEDG1 * 3 + 1];
      numArray1156[index1151] = (byte) num3460;
      byte[] numArray1157 = second;
      int num3461 = num3459;
      int num3462 = num3461 + 1;
      int index1152 = num3461;
      int num3463 = (int) numArray818[this.ucScreenLED1.LEDG1 * 3 + 2];
      numArray1157[index1152] = (byte) num3463;
      byte[] numArray1158 = second;
      int num3464 = num3462;
      int num3465 = num3464 + 1;
      int index1153 = num3464;
      int num3466 = (int) numArray818[this.ucScreenLED1.LEDB1 * 3];
      numArray1158[index1153] = (byte) num3466;
      byte[] numArray1159 = second;
      int num3467 = num3465;
      int num3468 = num3467 + 1;
      int index1154 = num3467;
      int num3469 = (int) numArray818[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray1159[index1154] = (byte) num3469;
      byte[] numArray1160 = second;
      int num3470 = num3468;
      int num3471 = num3470 + 1;
      int index1155 = num3470;
      int num3472 = (int) numArray818[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray1160[index1155] = (byte) num3472;
      byte[] numArray1161 = second;
      int num3473 = num3471;
      int num3474 = num3473 + 1;
      int index1156 = num3473;
      int num3475 = (int) numArray818[this.ucScreenLED1.LEDA1 * 3];
      numArray1161[index1156] = (byte) num3475;
      byte[] numArray1162 = second;
      int num3476 = num3474;
      int num3477 = num3476 + 1;
      int index1157 = num3476;
      int num3478 = (int) numArray818[this.ucScreenLED1.LEDA1 * 3 + 1];
      numArray1162[index1157] = (byte) num3478;
      byte[] numArray1163 = second;
      int num3479 = num3477;
      int num3480 = num3479 + 1;
      int index1158 = num3479;
      int num3481 = (int) numArray818[this.ucScreenLED1.LEDA1 * 3 + 2];
      numArray1163[index1158] = (byte) num3481;
      byte[] numArray1164 = second;
      int num3482 = num3480;
      int num3483 = num3482 + 1;
      int index1159 = num3482;
      int num3484 = (int) numArray818[this.ucScreenLED1.LEDF1 * 3];
      numArray1164[index1159] = (byte) num3484;
      byte[] numArray1165 = second;
      int num3485 = num3483;
      int num3486 = num3485 + 1;
      int index1160 = num3485;
      int num3487 = (int) numArray818[this.ucScreenLED1.LEDF1 * 3 + 1];
      numArray1165[index1160] = (byte) num3487;
      byte[] numArray1166 = second;
      int num3488 = num3486;
      int num3489 = num3488 + 1;
      int index1161 = num3488;
      int num3490 = (int) numArray818[this.ucScreenLED1.LEDF1 * 3 + 2];
      numArray1166[index1161] = (byte) num3490;
      byte[] numArray1167 = second;
      int num3491 = num3489;
      int num3492 = num3491 + 1;
      int index1162 = num3491;
      int num3493 = (int) numArray818[this.ucScreenLED1.Cpu1 * 3];
      numArray1167[index1162] = (byte) num3493;
      byte[] numArray1168 = second;
      int num3494 = num3492;
      int num3495 = num3494 + 1;
      int index1163 = num3494;
      int num3496 = (int) numArray818[this.ucScreenLED1.Cpu1 * 3 + 1];
      numArray1168[index1163] = (byte) num3496;
      byte[] numArray1169 = second;
      int num3497 = num3495;
      int num3498 = num3497 + 1;
      int index1164 = num3497;
      int num3499 = (int) numArray818[this.ucScreenLED1.Cpu1 * 3 + 2];
      numArray1169[index1164] = (byte) num3499;
      byte[] numArray1170 = second;
      int num3500 = num3498;
      int num3501 = num3500 + 1;
      int index1165 = num3500;
      int num3502 = (int) numArray818[this.ucScreenLED1.ZhuangShi1 * 3];
      numArray1170[index1165] = (byte) num3502;
      byte[] numArray1171 = second;
      int num3503 = num3501;
      int num3504 = num3503 + 1;
      int index1166 = num3503;
      int num3505 = (int) numArray818[this.ucScreenLED1.ZhuangShi1 * 3 + 1];
      numArray1171[index1166] = (byte) num3505;
      byte[] numArray1172 = second;
      int num3506 = num3504;
      int num3507 = num3506 + 1;
      int index1167 = num3506;
      int num3508 = (int) numArray818[this.ucScreenLED1.ZhuangShi1 * 3 + 2];
      numArray1172[index1167] = (byte) num3508;
      byte[] numArray1173 = second;
      int num3509 = num3507;
      int num3510 = num3509 + 1;
      int index1168 = num3509;
      int num3511 = (int) numArray818[this.ucScreenLED1.ZhuangShi1 * 3];
      numArray1173[index1168] = (byte) num3511;
      byte[] numArray1174 = second;
      int num3512 = num3510;
      int num3513 = num3512 + 1;
      int index1169 = num3512;
      int num3514 = (int) numArray818[this.ucScreenLED1.ZhuangShi1 * 3 + 1];
      numArray1174[index1169] = (byte) num3514;
      byte[] numArray1175 = second;
      int num3515 = num3513;
      int num3516 = num3515 + 1;
      int index1170 = num3515;
      int num3517 = (int) numArray818[this.ucScreenLED1.ZhuangShi1 * 3 + 2];
      numArray1175[index1170] = (byte) num3517;
      byte[] numArray1176 = second;
      int num3518 = num3516;
      int num3519 = num3518 + 1;
      int index1171 = num3518;
      int num3520 = (int) numArray818[this.ucScreenLED1.ZhuangShi2 * 3];
      numArray1176[index1171] = (byte) num3520;
      byte[] numArray1177 = second;
      int num3521 = num3519;
      int num3522 = num3521 + 1;
      int index1172 = num3521;
      int num3523 = (int) numArray818[this.ucScreenLED1.ZhuangShi2 * 3 + 1];
      numArray1177[index1172] = (byte) num3523;
      byte[] numArray1178 = second;
      int num3524 = num3522;
      int num3525 = num3524 + 1;
      int index1173 = num3524;
      int num3526 = (int) numArray818[this.ucScreenLED1.ZhuangShi2 * 3 + 2];
      numArray1178[index1173] = (byte) num3526;
      byte[] numArray1179 = second;
      int num3527 = num3525;
      int num3528 = num3527 + 1;
      int index1174 = num3527;
      int num3529 = (int) numArray818[this.ucScreenLED1.ZhuangShi2 * 3];
      numArray1179[index1174] = (byte) num3529;
      byte[] numArray1180 = second;
      int num3530 = num3528;
      int num3531 = num3530 + 1;
      int index1175 = num3530;
      int num3532 = (int) numArray818[this.ucScreenLED1.ZhuangShi2 * 3 + 1];
      numArray1180[index1175] = (byte) num3532;
      byte[] numArray1181 = second;
      int num3533 = num3531;
      int num3534 = num3533 + 1;
      int index1176 = num3533;
      int num3535 = (int) numArray818[this.ucScreenLED1.ZhuangShi2 * 3 + 2];
      numArray1181[index1176] = (byte) num3535;
      byte[] numArray1182 = second;
      int num3536 = num3534;
      int num3537 = num3536 + 1;
      int index1177 = num3536;
      int num3538 = (int) numArray818[this.ucScreenLED1.ZhuangShi3 * 3];
      numArray1182[index1177] = (byte) num3538;
      byte[] numArray1183 = second;
      int num3539 = num3537;
      int num3540 = num3539 + 1;
      int index1178 = num3539;
      int num3541 = (int) numArray818[this.ucScreenLED1.ZhuangShi3 * 3 + 1];
      numArray1183[index1178] = (byte) num3541;
      byte[] numArray1184 = second;
      int num3542 = num3540;
      int num3543 = num3542 + 1;
      int index1179 = num3542;
      int num3544 = (int) numArray818[this.ucScreenLED1.ZhuangShi3 * 3 + 2];
      numArray1184[index1179] = (byte) num3544;
      byte[] numArray1185 = second;
      int num3545 = num3543;
      int num3546 = num3545 + 1;
      int index1180 = num3545;
      int num3547 = (int) numArray818[this.ucScreenLED1.ZhuangShi3 * 3];
      numArray1185[index1180] = (byte) num3547;
      byte[] numArray1186 = second;
      int num3548 = num3546;
      int num3549 = num3548 + 1;
      int index1181 = num3548;
      int num3550 = (int) numArray818[this.ucScreenLED1.ZhuangShi3 * 3 + 1];
      numArray1186[index1181] = (byte) num3550;
      byte[] numArray1187 = second;
      int num3551 = num3549;
      int num3552 = num3551 + 1;
      int index1182 = num3551;
      int num3553 = (int) numArray818[this.ucScreenLED1.ZhuangShi3 * 3 + 2];
      numArray1187[index1182] = (byte) num3553;
      byte[] numArray1188 = second;
      int num3554 = num3552;
      int num3555 = num3554 + 1;
      int index1183 = num3554;
      int num3556 = (int) numArray818[this.ucScreenLED1.ZhuangShi4 * 3];
      numArray1188[index1183] = (byte) num3556;
      byte[] numArray1189 = second;
      int num3557 = num3555;
      int num3558 = num3557 + 1;
      int index1184 = num3557;
      int num3559 = (int) numArray818[this.ucScreenLED1.ZhuangShi4 * 3 + 1];
      numArray1189[index1184] = (byte) num3559;
      byte[] numArray1190 = second;
      int num3560 = num3558;
      int num3561 = num3560 + 1;
      int index1185 = num3560;
      int num3562 = (int) numArray818[this.ucScreenLED1.ZhuangShi4 * 3 + 2];
      numArray1190[index1185] = (byte) num3562;
      byte[] numArray1191 = second;
      int num3563 = num3561;
      int num3564 = num3563 + 1;
      int index1186 = num3563;
      int num3565 = (int) numArray818[this.ucScreenLED1.ZhuangShi4 * 3];
      numArray1191[index1186] = (byte) num3565;
      byte[] numArray1192 = second;
      int num3566 = num3564;
      int num3567 = num3566 + 1;
      int index1187 = num3566;
      int num3568 = (int) numArray818[this.ucScreenLED1.ZhuangShi4 * 3 + 1];
      numArray1192[index1187] = (byte) num3568;
      byte[] numArray1193 = second;
      int num3569 = num3567;
      int num3570 = num3569 + 1;
      int index1188 = num3569;
      int num3571 = (int) numArray818[this.ucScreenLED1.ZhuangShi4 * 3 + 2];
      numArray1193[index1188] = (byte) num3571;
      byte[] numArray1194 = second;
      int num3572 = num3570;
      int num3573 = num3572 + 1;
      int index1189 = num3572;
      int num3574 = (int) numArray818[this.ucScreenLED1.ZhuangShi5 * 3];
      numArray1194[index1189] = (byte) num3574;
      byte[] numArray1195 = second;
      int num3575 = num3573;
      int num3576 = num3575 + 1;
      int index1190 = num3575;
      int num3577 = (int) numArray818[this.ucScreenLED1.ZhuangShi5 * 3 + 1];
      numArray1195[index1190] = (byte) num3577;
      byte[] numArray1196 = second;
      int num3578 = num3576;
      int num3579 = num3578 + 1;
      int index1191 = num3578;
      int num3580 = (int) numArray818[this.ucScreenLED1.ZhuangShi5 * 3 + 2];
      numArray1196[index1191] = (byte) num3580;
      byte[] numArray1197 = second;
      int num3581 = num3579;
      int num3582 = num3581 + 1;
      int index1192 = num3581;
      int num3583 = (int) numArray818[this.ucScreenLED1.ZhuangShi5 * 3];
      numArray1197[index1192] = (byte) num3583;
      byte[] numArray1198 = second;
      int num3584 = num3582;
      int num3585 = num3584 + 1;
      int index1193 = num3584;
      int num3586 = (int) numArray818[this.ucScreenLED1.ZhuangShi5 * 3 + 1];
      numArray1198[index1193] = (byte) num3586;
      byte[] numArray1199 = second;
      int num3587 = num3585;
      int num3588 = num3587 + 1;
      int index1194 = num3587;
      int num3589 = (int) numArray818[this.ucScreenLED1.ZhuangShi5 * 3 + 2];
      numArray1199[index1194] = (byte) num3589;
      byte[] numArray1200 = second;
      int num3590 = num3588;
      int num3591 = num3590 + 1;
      int index1195 = num3590;
      int num3592 = (int) numArray818[this.ucScreenLED1.ZhuangShi6 * 3];
      numArray1200[index1195] = (byte) num3592;
      byte[] numArray1201 = second;
      int num3593 = num3591;
      int num3594 = num3593 + 1;
      int index1196 = num3593;
      int num3595 = (int) numArray818[this.ucScreenLED1.ZhuangShi6 * 3 + 1];
      numArray1201[index1196] = (byte) num3595;
      byte[] numArray1202 = second;
      int num3596 = num3594;
      int num3597 = num3596 + 1;
      int index1197 = num3596;
      int num3598 = (int) numArray818[this.ucScreenLED1.ZhuangShi6 * 3 + 2];
      numArray1202[index1197] = (byte) num3598;
      byte[] numArray1203 = second;
      int num3599 = num3597;
      int num3600 = num3599 + 1;
      int index1198 = num3599;
      int num3601 = (int) numArray818[this.ucScreenLED1.ZhuangShi6 * 3];
      numArray1203[index1198] = (byte) num3601;
      byte[] numArray1204 = second;
      int num3602 = num3600;
      int num3603 = num3602 + 1;
      int index1199 = num3602;
      int num3604 = (int) numArray818[this.ucScreenLED1.ZhuangShi6 * 3 + 1];
      numArray1204[index1199] = (byte) num3604;
      byte[] numArray1205 = second;
      int num3605 = num3603;
      int num3606 = num3605 + 1;
      int index1200 = num3605;
      int num3607 = (int) numArray818[this.ucScreenLED1.ZhuangShi6 * 3 + 2];
      numArray1205[index1200] = (byte) num3607;
      byte[] numArray1206 = second;
      int num3608 = num3606;
      int num3609 = num3608 + 1;
      int index1201 = num3608;
      int num3610 = (int) numArray818[this.ucScreenLED1.ZhuangShi7 * 3];
      numArray1206[index1201] = (byte) num3610;
      byte[] numArray1207 = second;
      int num3611 = num3609;
      int num3612 = num3611 + 1;
      int index1202 = num3611;
      int num3613 = (int) numArray818[this.ucScreenLED1.ZhuangShi7 * 3 + 1];
      numArray1207[index1202] = (byte) num3613;
      byte[] numArray1208 = second;
      int num3614 = num3612;
      int num3615 = num3614 + 1;
      int index1203 = num3614;
      int num3616 = (int) numArray818[this.ucScreenLED1.ZhuangShi7 * 3 + 2];
      numArray1208[index1203] = (byte) num3616;
      byte[] numArray1209 = second;
      int num3617 = num3615;
      int num3618 = num3617 + 1;
      int index1204 = num3617;
      int num3619 = (int) numArray818[this.ucScreenLED1.ZhuangShi7 * 3];
      numArray1209[index1204] = (byte) num3619;
      byte[] numArray1210 = second;
      int num3620 = num3618;
      int num3621 = num3620 + 1;
      int index1205 = num3620;
      int num3622 = (int) numArray818[this.ucScreenLED1.ZhuangShi7 * 3 + 1];
      numArray1210[index1205] = (byte) num3622;
      byte[] numArray1211 = second;
      int num3623 = num3621;
      int num3624 = num3623 + 1;
      int index1206 = num3623;
      int num3625 = (int) numArray818[this.ucScreenLED1.ZhuangShi7 * 3 + 2];
      numArray1211[index1206] = (byte) num3625;
      byte[] numArray1212 = second;
      int num3626 = num3624;
      int num3627 = num3626 + 1;
      int index1207 = num3626;
      int num3628 = (int) numArray818[this.ucScreenLED1.ZhuangShi8 * 3];
      numArray1212[index1207] = (byte) num3628;
      byte[] numArray1213 = second;
      int num3629 = num3627;
      int num3630 = num3629 + 1;
      int index1208 = num3629;
      int num3631 = (int) numArray818[this.ucScreenLED1.ZhuangShi8 * 3 + 1];
      numArray1213[index1208] = (byte) num3631;
      byte[] numArray1214 = second;
      int num3632 = num3630;
      int num3633 = num3632 + 1;
      int index1209 = num3632;
      int num3634 = (int) numArray818[this.ucScreenLED1.ZhuangShi8 * 3 + 2];
      numArray1214[index1209] = (byte) num3634;
      byte[] numArray1215 = second;
      int num3635 = num3633;
      int num3636 = num3635 + 1;
      int index1210 = num3635;
      int num3637 = (int) numArray818[this.ucScreenLED1.ZhuangShi8 * 3];
      numArray1215[index1210] = (byte) num3637;
      byte[] numArray1216 = second;
      int num3638 = num3636;
      int num3639 = num3638 + 1;
      int index1211 = num3638;
      int num3640 = (int) numArray818[this.ucScreenLED1.ZhuangShi8 * 3 + 1];
      numArray1216[index1211] = (byte) num3640;
      byte[] numArray1217 = second;
      int num3641 = num3639;
      int num3642 = num3641 + 1;
      int index1212 = num3641;
      int num3643 = (int) numArray818[this.ucScreenLED1.ZhuangShi8 * 3 + 2];
      numArray1217[index1212] = (byte) num3643;
      byte[] numArray1218 = second;
      int num3644 = num3642;
      int num3645 = num3644 + 1;
      int index1213 = num3644;
      int num3646 = (int) numArray818[this.ucScreenLED1.ZhuangShi9 * 3];
      numArray1218[index1213] = (byte) num3646;
      byte[] numArray1219 = second;
      int num3647 = num3645;
      int num3648 = num3647 + 1;
      int index1214 = num3647;
      int num3649 = (int) numArray818[this.ucScreenLED1.ZhuangShi9 * 3 + 1];
      numArray1219[index1214] = (byte) num3649;
      byte[] numArray1220 = second;
      int num3650 = num3648;
      int num3651 = num3650 + 1;
      int index1215 = num3650;
      int num3652 = (int) numArray818[this.ucScreenLED1.ZhuangShi9 * 3 + 2];
      numArray1220[index1215] = (byte) num3652;
      byte[] numArray1221 = second;
      int num3653 = num3651;
      int num3654 = num3653 + 1;
      int index1216 = num3653;
      int num3655 = (int) numArray818[this.ucScreenLED1.ZhuangShi9 * 3];
      numArray1221[index1216] = (byte) num3655;
      byte[] numArray1222 = second;
      int num3656 = num3654;
      int num3657 = num3656 + 1;
      int index1217 = num3656;
      int num3658 = (int) numArray818[this.ucScreenLED1.ZhuangShi9 * 3 + 1];
      numArray1222[index1217] = (byte) num3658;
      byte[] numArray1223 = second;
      int num3659 = num3657;
      int num3660 = num3659 + 1;
      int index1218 = num3659;
      int num3661 = (int) numArray818[this.ucScreenLED1.ZhuangShi9 * 3 + 2];
      numArray1223[index1218] = (byte) num3661;
      byte[] numArray1224 = second;
      int num3662 = num3660;
      int num3663 = num3662 + 1;
      int index1219 = num3662;
      int num3664 = (int) numArray818[this.ucScreenLED1.ZhuangShi10 * 3];
      numArray1224[index1219] = (byte) num3664;
      byte[] numArray1225 = second;
      int num3665 = num3663;
      int num3666 = num3665 + 1;
      int index1220 = num3665;
      int num3667 = (int) numArray818[this.ucScreenLED1.ZhuangShi10 * 3 + 1];
      numArray1225[index1220] = (byte) num3667;
      byte[] numArray1226 = second;
      int num3668 = num3666;
      int num3669 = num3668 + 1;
      int index1221 = num3668;
      int num3670 = (int) numArray818[this.ucScreenLED1.ZhuangShi10 * 3 + 2];
      numArray1226[index1221] = (byte) num3670;
      byte[] numArray1227 = second;
      int num3671 = num3669;
      int num3672 = num3671 + 1;
      int index1222 = num3671;
      int num3673 = (int) numArray818[this.ucScreenLED1.ZhuangShi10 * 3];
      numArray1227[index1222] = (byte) num3673;
      byte[] numArray1228 = second;
      int num3674 = num3672;
      int num3675 = num3674 + 1;
      int index1223 = num3674;
      int num3676 = (int) numArray818[this.ucScreenLED1.ZhuangShi10 * 3 + 1];
      numArray1228[index1223] = (byte) num3676;
      byte[] numArray1229 = second;
      int num3677 = num3675;
      int num3678 = num3677 + 1;
      int index1224 = num3677;
      int num3679 = (int) numArray818[this.ucScreenLED1.ZhuangShi10 * 3 + 2];
      numArray1229[index1224] = (byte) num3679;
      byte[] numArray1230 = second;
      int num3680 = num3678;
      int num3681 = num3680 + 1;
      int index1225 = num3680;
      int num3682 = (int) numArray818[this.ucScreenLED1.ZhuangShi11 * 3];
      numArray1230[index1225] = (byte) num3682;
      byte[] numArray1231 = second;
      int num3683 = num3681;
      int num3684 = num3683 + 1;
      int index1226 = num3683;
      int num3685 = (int) numArray818[this.ucScreenLED1.ZhuangShi11 * 3 + 1];
      numArray1231[index1226] = (byte) num3685;
      byte[] numArray1232 = second;
      int num3686 = num3684;
      int num3687 = num3686 + 1;
      int index1227 = num3686;
      int num3688 = (int) numArray818[this.ucScreenLED1.ZhuangShi11 * 3 + 2];
      numArray1232[index1227] = (byte) num3688;
      byte[] numArray1233 = second;
      int num3689 = num3687;
      int num3690 = num3689 + 1;
      int index1228 = num3689;
      int num3691 = (int) numArray818[this.ucScreenLED1.ZhuangShi11 * 3];
      numArray1233[index1228] = (byte) num3691;
      byte[] numArray1234 = second;
      int num3692 = num3690;
      int num3693 = num3692 + 1;
      int index1229 = num3692;
      int num3694 = (int) numArray818[this.ucScreenLED1.ZhuangShi11 * 3 + 1];
      numArray1234[index1229] = (byte) num3694;
      byte[] numArray1235 = second;
      int num3695 = num3693;
      int num3696 = num3695 + 1;
      int index1230 = num3695;
      int num3697 = (int) numArray818[this.ucScreenLED1.ZhuangShi11 * 3 + 2];
      numArray1235[index1230] = (byte) num3697;
      byte[] numArray1236 = second;
      int num3698 = num3696;
      int num3699 = num3698 + 1;
      int index1231 = num3698;
      int num3700 = (int) numArray818[this.ucScreenLED1.ZhuangShi12 * 3];
      numArray1236[index1231] = (byte) num3700;
      byte[] numArray1237 = second;
      int num3701 = num3699;
      int num3702 = num3701 + 1;
      int index1232 = num3701;
      int num3703 = (int) numArray818[this.ucScreenLED1.ZhuangShi12 * 3 + 1];
      numArray1237[index1232] = (byte) num3703;
      byte[] numArray1238 = second;
      int num3704 = num3702;
      int num3705 = num3704 + 1;
      int index1233 = num3704;
      int num3706 = (int) numArray818[this.ucScreenLED1.ZhuangShi12 * 3 + 2];
      numArray1238[index1233] = (byte) num3706;
      byte[] numArray1239 = second;
      int num3707 = num3705;
      int num3708 = num3707 + 1;
      int index1234 = num3707;
      int num3709 = (int) numArray818[this.ucScreenLED1.ZhuangShi12 * 3];
      numArray1239[index1234] = (byte) num3709;
      byte[] numArray1240 = second;
      int num3710 = num3708;
      int num3711 = num3710 + 1;
      int index1235 = num3710;
      int num3712 = (int) numArray818[this.ucScreenLED1.ZhuangShi12 * 3 + 1];
      numArray1240[index1235] = (byte) num3712;
      byte[] numArray1241 = second;
      int num3713 = num3711;
      int num3714 = num3713 + 1;
      int index1236 = num3713;
      int num3715 = (int) numArray818[this.ucScreenLED1.ZhuangShi12 * 3 + 2];
      numArray1241[index1236] = (byte) num3715;
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 7)
    {
      byte[] numArray1242 = new byte[438];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray1242.Length,
        (byte) (numArray1242.Length >> 8),
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 116; ++index)
      {
        if (this.ucScreenLED1.isOn[index])
        {
          numArray1242[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2);
          numArray1242[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2);
          numArray1242[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2);
        }
        else
        {
          numArray1242[index * 3] = (byte) 0;
          numArray1242[index * 3 + 1] = (byte) 0;
          numArray1242[index * 3 + 2] = (byte) 0;
        }
      }
      int num3716 = 0;
      byte[] second = new byte[numArray1242.Length];
      byte[] numArray1243 = second;
      int num3717 = num3716;
      int num3718 = num3717 + 1;
      int index1237 = num3717;
      int num3719 = (int) numArray1242[this.ucScreenLED1.ZhuangShi32 * 3];
      numArray1243[index1237] = (byte) num3719;
      byte[] numArray1244 = second;
      int num3720 = num3718;
      int num3721 = num3720 + 1;
      int index1238 = num3720;
      int num3722 = (int) numArray1242[this.ucScreenLED1.ZhuangShi32 * 3 + 1];
      numArray1244[index1238] = (byte) num3722;
      byte[] numArray1245 = second;
      int num3723 = num3721;
      int num3724 = num3723 + 1;
      int index1239 = num3723;
      int num3725 = (int) numArray1242[this.ucScreenLED1.ZhuangShi32 * 3 + 2];
      numArray1245[index1239] = (byte) num3725;
      byte[] numArray1246 = second;
      int num3726 = num3724;
      int num3727 = num3726 + 1;
      int index1240 = num3726;
      int num3728 = (int) numArray1242[this.ucScreenLED1.ZhuangShi31 * 3];
      numArray1246[index1240] = (byte) num3728;
      byte[] numArray1247 = second;
      int num3729 = num3727;
      int num3730 = num3729 + 1;
      int index1241 = num3729;
      int num3731 = (int) numArray1242[this.ucScreenLED1.ZhuangShi31 * 3 + 1];
      numArray1247[index1241] = (byte) num3731;
      byte[] numArray1248 = second;
      int num3732 = num3730;
      int num3733 = num3732 + 1;
      int index1242 = num3732;
      int num3734 = (int) numArray1242[this.ucScreenLED1.ZhuangShi31 * 3 + 2];
      numArray1248[index1242] = (byte) num3734;
      byte[] numArray1249 = second;
      int num3735 = num3733;
      int num3736 = num3735 + 1;
      int index1243 = num3735;
      int num3737 = (int) numArray1242[this.ucScreenLED1.ZhuangShi30 * 3];
      numArray1249[index1243] = (byte) num3737;
      byte[] numArray1250 = second;
      int num3738 = num3736;
      int num3739 = num3738 + 1;
      int index1244 = num3738;
      int num3740 = (int) numArray1242[this.ucScreenLED1.ZhuangShi30 * 3 + 1];
      numArray1250[index1244] = (byte) num3740;
      byte[] numArray1251 = second;
      int num3741 = num3739;
      int num3742 = num3741 + 1;
      int index1245 = num3741;
      int num3743 = (int) numArray1242[this.ucScreenLED1.ZhuangShi30 * 3 + 2];
      numArray1251[index1245] = (byte) num3743;
      byte[] numArray1252 = second;
      int num3744 = num3742;
      int num3745 = num3744 + 1;
      int index1246 = num3744;
      int num3746 = (int) numArray1242[this.ucScreenLED1.ZhuangShi29 * 3];
      numArray1252[index1246] = (byte) num3746;
      byte[] numArray1253 = second;
      int num3747 = num3745;
      int num3748 = num3747 + 1;
      int index1247 = num3747;
      int num3749 = (int) numArray1242[this.ucScreenLED1.ZhuangShi29 * 3 + 1];
      numArray1253[index1247] = (byte) num3749;
      byte[] numArray1254 = second;
      int num3750 = num3748;
      int num3751 = num3750 + 1;
      int index1248 = num3750;
      int num3752 = (int) numArray1242[this.ucScreenLED1.ZhuangShi29 * 3 + 2];
      numArray1254[index1248] = (byte) num3752;
      byte[] numArray1255 = second;
      int num3753 = num3751;
      int num3754 = num3753 + 1;
      int index1249 = num3753;
      int num3755 = (int) numArray1242[this.ucScreenLED1.ZhuangShi28 * 3];
      numArray1255[index1249] = (byte) num3755;
      byte[] numArray1256 = second;
      int num3756 = num3754;
      int num3757 = num3756 + 1;
      int index1250 = num3756;
      int num3758 = (int) numArray1242[this.ucScreenLED1.ZhuangShi28 * 3 + 1];
      numArray1256[index1250] = (byte) num3758;
      byte[] numArray1257 = second;
      int num3759 = num3757;
      int num3760 = num3759 + 1;
      int index1251 = num3759;
      int num3761 = (int) numArray1242[this.ucScreenLED1.ZhuangShi28 * 3 + 2];
      numArray1257[index1251] = (byte) num3761;
      byte[] numArray1258 = second;
      int num3762 = num3760;
      int num3763 = num3762 + 1;
      int index1252 = num3762;
      int num3764 = (int) numArray1242[this.ucScreenLED1.ZhuangShi27 * 3];
      numArray1258[index1252] = (byte) num3764;
      byte[] numArray1259 = second;
      int num3765 = num3763;
      int num3766 = num3765 + 1;
      int index1253 = num3765;
      int num3767 = (int) numArray1242[this.ucScreenLED1.ZhuangShi27 * 3 + 1];
      numArray1259[index1253] = (byte) num3767;
      byte[] numArray1260 = second;
      int num3768 = num3766;
      int num3769 = num3768 + 1;
      int index1254 = num3768;
      int num3770 = (int) numArray1242[this.ucScreenLED1.ZhuangShi27 * 3 + 2];
      numArray1260[index1254] = (byte) num3770;
      byte[] numArray1261 = second;
      int num3771 = num3769;
      int num3772 = num3771 + 1;
      int index1255 = num3771;
      int num3773 = (int) numArray1242[this.ucScreenLED1.ZhuangShi27 * 3];
      numArray1261[index1255] = (byte) num3773;
      byte[] numArray1262 = second;
      int num3774 = num3772;
      int num3775 = num3774 + 1;
      int index1256 = num3774;
      int num3776 = (int) numArray1242[this.ucScreenLED1.ZhuangShi27 * 3 + 1];
      numArray1262[index1256] = (byte) num3776;
      byte[] numArray1263 = second;
      int num3777 = num3775;
      int num3778 = num3777 + 1;
      int index1257 = num3777;
      int num3779 = (int) numArray1242[this.ucScreenLED1.ZhuangShi27 * 3 + 2];
      numArray1263[index1257] = (byte) num3779;
      byte[] numArray1264 = second;
      int num3780 = num3778;
      int num3781 = num3780 + 1;
      int index1258 = num3780;
      int num3782 = (int) numArray1242[this.ucScreenLED1.ZhuangShi28 * 3];
      numArray1264[index1258] = (byte) num3782;
      byte[] numArray1265 = second;
      int num3783 = num3781;
      int num3784 = num3783 + 1;
      int index1259 = num3783;
      int num3785 = (int) numArray1242[this.ucScreenLED1.ZhuangShi28 * 3 + 1];
      numArray1265[index1259] = (byte) num3785;
      byte[] numArray1266 = second;
      int num3786 = num3784;
      int num3787 = num3786 + 1;
      int index1260 = num3786;
      int num3788 = (int) numArray1242[this.ucScreenLED1.ZhuangShi28 * 3 + 2];
      numArray1266[index1260] = (byte) num3788;
      byte[] numArray1267 = second;
      int num3789 = num3787;
      int num3790 = num3789 + 1;
      int index1261 = num3789;
      int num3791 = (int) numArray1242[this.ucScreenLED1.ZhuangShi29 * 3];
      numArray1267[index1261] = (byte) num3791;
      byte[] numArray1268 = second;
      int num3792 = num3790;
      int num3793 = num3792 + 1;
      int index1262 = num3792;
      int num3794 = (int) numArray1242[this.ucScreenLED1.ZhuangShi29 * 3 + 1];
      numArray1268[index1262] = (byte) num3794;
      byte[] numArray1269 = second;
      int num3795 = num3793;
      int num3796 = num3795 + 1;
      int index1263 = num3795;
      int num3797 = (int) numArray1242[this.ucScreenLED1.ZhuangShi29 * 3 + 2];
      numArray1269[index1263] = (byte) num3797;
      byte[] numArray1270 = second;
      int num3798 = num3796;
      int num3799 = num3798 + 1;
      int index1264 = num3798;
      int num3800 = (int) numArray1242[this.ucScreenLED1.ZhuangShi30 * 3];
      numArray1270[index1264] = (byte) num3800;
      byte[] numArray1271 = second;
      int num3801 = num3799;
      int num3802 = num3801 + 1;
      int index1265 = num3801;
      int num3803 = (int) numArray1242[this.ucScreenLED1.ZhuangShi30 * 3 + 1];
      numArray1271[index1265] = (byte) num3803;
      byte[] numArray1272 = second;
      int num3804 = num3802;
      int num3805 = num3804 + 1;
      int index1266 = num3804;
      int num3806 = (int) numArray1242[this.ucScreenLED1.ZhuangShi30 * 3 + 2];
      numArray1272[index1266] = (byte) num3806;
      byte[] numArray1273 = second;
      int num3807 = num3805;
      int num3808 = num3807 + 1;
      int index1267 = num3807;
      int num3809 = (int) numArray1242[this.ucScreenLED1.ZhuangShi31 * 3];
      numArray1273[index1267] = (byte) num3809;
      byte[] numArray1274 = second;
      int num3810 = num3808;
      int num3811 = num3810 + 1;
      int index1268 = num3810;
      int num3812 = (int) numArray1242[this.ucScreenLED1.ZhuangShi31 * 3 + 1];
      numArray1274[index1268] = (byte) num3812;
      byte[] numArray1275 = second;
      int num3813 = num3811;
      int num3814 = num3813 + 1;
      int index1269 = num3813;
      int num3815 = (int) numArray1242[this.ucScreenLED1.ZhuangShi31 * 3 + 2];
      numArray1275[index1269] = (byte) num3815;
      byte[] numArray1276 = second;
      int num3816 = num3814;
      int num3817 = num3816 + 1;
      int index1270 = num3816;
      int num3818 = (int) numArray1242[this.ucScreenLED1.ZhuangShi32 * 3];
      numArray1276[index1270] = (byte) num3818;
      byte[] numArray1277 = second;
      int num3819 = num3817;
      int num3820 = num3819 + 1;
      int index1271 = num3819;
      int num3821 = (int) numArray1242[this.ucScreenLED1.ZhuangShi32 * 3 + 1];
      numArray1277[index1271] = (byte) num3821;
      byte[] numArray1278 = second;
      int num3822 = num3820;
      int num3823 = num3822 + 1;
      int index1272 = num3822;
      int num3824 = (int) numArray1242[this.ucScreenLED1.ZhuangShi32 * 3 + 2];
      numArray1278[index1272] = (byte) num3824;
      byte[] numArray1279 = second;
      int num3825 = num3823;
      int num3826 = num3825 + 1;
      int index1273 = num3825;
      int num3827 = (int) numArray1242[this.ucScreenLED1.ZhuangShi20 * 3];
      numArray1279[index1273] = (byte) num3827;
      byte[] numArray1280 = second;
      int num3828 = num3826;
      int num3829 = num3828 + 1;
      int index1274 = num3828;
      int num3830 = (int) numArray1242[this.ucScreenLED1.ZhuangShi20 * 3 + 1];
      numArray1280[index1274] = (byte) num3830;
      byte[] numArray1281 = second;
      int num3831 = num3829;
      int num3832 = num3831 + 1;
      int index1275 = num3831;
      int num3833 = (int) numArray1242[this.ucScreenLED1.ZhuangShi20 * 3 + 2];
      numArray1281[index1275] = (byte) num3833;
      byte[] numArray1282 = second;
      int num3834 = num3832;
      int num3835 = num3834 + 1;
      int index1276 = num3834;
      int num3836 = (int) numArray1242[this.ucScreenLED1.ZhuangShi19 * 3];
      numArray1282[index1276] = (byte) num3836;
      byte[] numArray1283 = second;
      int num3837 = num3835;
      int num3838 = num3837 + 1;
      int index1277 = num3837;
      int num3839 = (int) numArray1242[this.ucScreenLED1.ZhuangShi19 * 3 + 1];
      numArray1283[index1277] = (byte) num3839;
      byte[] numArray1284 = second;
      int num3840 = num3838;
      int num3841 = num3840 + 1;
      int index1278 = num3840;
      int num3842 = (int) numArray1242[this.ucScreenLED1.ZhuangShi19 * 3 + 2];
      numArray1284[index1278] = (byte) num3842;
      byte[] numArray1285 = second;
      int num3843 = num3841;
      int num3844 = num3843 + 1;
      int index1279 = num3843;
      int num3845 = (int) numArray1242[this.ucScreenLED1.ZhuangShi18 * 3];
      numArray1285[index1279] = (byte) num3845;
      byte[] numArray1286 = second;
      int num3846 = num3844;
      int num3847 = num3846 + 1;
      int index1280 = num3846;
      int num3848 = (int) numArray1242[this.ucScreenLED1.ZhuangShi18 * 3 + 1];
      numArray1286[index1280] = (byte) num3848;
      byte[] numArray1287 = second;
      int num3849 = num3847;
      int num3850 = num3849 + 1;
      int index1281 = num3849;
      int num3851 = (int) numArray1242[this.ucScreenLED1.ZhuangShi18 * 3 + 2];
      numArray1287[index1281] = (byte) num3851;
      byte[] numArray1288 = second;
      int num3852 = num3850;
      int num3853 = num3852 + 1;
      int index1282 = num3852;
      int num3854 = (int) numArray1242[this.ucScreenLED1.ZhuangShi17 * 3];
      numArray1288[index1282] = (byte) num3854;
      byte[] numArray1289 = second;
      int num3855 = num3853;
      int num3856 = num3855 + 1;
      int index1283 = num3855;
      int num3857 = (int) numArray1242[this.ucScreenLED1.ZhuangShi17 * 3 + 1];
      numArray1289[index1283] = (byte) num3857;
      byte[] numArray1290 = second;
      int num3858 = num3856;
      int num3859 = num3858 + 1;
      int index1284 = num3858;
      int num3860 = (int) numArray1242[this.ucScreenLED1.ZhuangShi17 * 3 + 2];
      numArray1290[index1284] = (byte) num3860;
      byte[] numArray1291 = second;
      int num3861 = num3859;
      int num3862 = num3861 + 1;
      int index1285 = num3861;
      int num3863 = (int) numArray1242[this.ucScreenLED1.ZhuangShi16 * 3];
      numArray1291[index1285] = (byte) num3863;
      byte[] numArray1292 = second;
      int num3864 = num3862;
      int num3865 = num3864 + 1;
      int index1286 = num3864;
      int num3866 = (int) numArray1242[this.ucScreenLED1.ZhuangShi16 * 3 + 1];
      numArray1292[index1286] = (byte) num3866;
      byte[] numArray1293 = second;
      int num3867 = num3865;
      int num3868 = num3867 + 1;
      int index1287 = num3867;
      int num3869 = (int) numArray1242[this.ucScreenLED1.ZhuangShi16 * 3 + 2];
      numArray1293[index1287] = (byte) num3869;
      byte[] numArray1294 = second;
      int num3870 = num3868;
      int num3871 = num3870 + 1;
      int index1288 = num3870;
      int num3872 = (int) numArray1242[this.ucScreenLED1.ZhuangShi15 * 3];
      numArray1294[index1288] = (byte) num3872;
      byte[] numArray1295 = second;
      int num3873 = num3871;
      int num3874 = num3873 + 1;
      int index1289 = num3873;
      int num3875 = (int) numArray1242[this.ucScreenLED1.ZhuangShi15 * 3 + 1];
      numArray1295[index1289] = (byte) num3875;
      byte[] numArray1296 = second;
      int num3876 = num3874;
      int num3877 = num3876 + 1;
      int index1290 = num3876;
      int num3878 = (int) numArray1242[this.ucScreenLED1.ZhuangShi15 * 3 + 2];
      numArray1296[index1290] = (byte) num3878;
      byte[] numArray1297 = second;
      int num3879 = num3877;
      int num3880 = num3879 + 1;
      int index1291 = num3879;
      int num3881 = (int) numArray1242[this.ucScreenLED1.ZhuangShi14 * 3];
      numArray1297[index1291] = (byte) num3881;
      byte[] numArray1298 = second;
      int num3882 = num3880;
      int num3883 = num3882 + 1;
      int index1292 = num3882;
      int num3884 = (int) numArray1242[this.ucScreenLED1.ZhuangShi14 * 3 + 1];
      numArray1298[index1292] = (byte) num3884;
      byte[] numArray1299 = second;
      int num3885 = num3883;
      int num3886 = num3885 + 1;
      int index1293 = num3885;
      int num3887 = (int) numArray1242[this.ucScreenLED1.ZhuangShi14 * 3 + 2];
      numArray1299[index1293] = (byte) num3887;
      byte[] numArray1300 = second;
      int num3888 = num3886;
      int num3889 = num3888 + 1;
      int index1294 = num3888;
      int num3890 = (int) numArray1242[this.ucScreenLED1.ZhuangShi13 * 3];
      numArray1300[index1294] = (byte) num3890;
      byte[] numArray1301 = second;
      int num3891 = num3889;
      int num3892 = num3891 + 1;
      int index1295 = num3891;
      int num3893 = (int) numArray1242[this.ucScreenLED1.ZhuangShi13 * 3 + 1];
      numArray1301[index1295] = (byte) num3893;
      byte[] numArray1302 = second;
      int num3894 = num3892;
      int num3895 = num3894 + 1;
      int index1296 = num3894;
      int num3896 = (int) numArray1242[this.ucScreenLED1.ZhuangShi13 * 3 + 2];
      numArray1302[index1296] = (byte) num3896;
      byte[] numArray1303 = second;
      int num3897 = num3895;
      int num3898 = num3897 + 1;
      int index1297 = num3897;
      int num3899 = (int) numArray1242[this.ucScreenLED1.ZhuangShi12 * 3];
      numArray1303[index1297] = (byte) num3899;
      byte[] numArray1304 = second;
      int num3900 = num3898;
      int num3901 = num3900 + 1;
      int index1298 = num3900;
      int num3902 = (int) numArray1242[this.ucScreenLED1.ZhuangShi12 * 3 + 1];
      numArray1304[index1298] = (byte) num3902;
      byte[] numArray1305 = second;
      int num3903 = num3901;
      int num3904 = num3903 + 1;
      int index1299 = num3903;
      int num3905 = (int) numArray1242[this.ucScreenLED1.ZhuangShi12 * 3 + 2];
      numArray1305[index1299] = (byte) num3905;
      byte[] numArray1306 = second;
      int num3906 = num3904;
      int num3907 = num3906 + 1;
      int index1300 = num3906;
      int num3908 = (int) numArray1242[this.ucScreenLED1.ZhuangShi11 * 3];
      numArray1306[index1300] = (byte) num3908;
      byte[] numArray1307 = second;
      int num3909 = num3907;
      int num3910 = num3909 + 1;
      int index1301 = num3909;
      int num3911 = (int) numArray1242[this.ucScreenLED1.ZhuangShi11 * 3 + 1];
      numArray1307[index1301] = (byte) num3911;
      byte[] numArray1308 = second;
      int num3912 = num3910;
      int num3913 = num3912 + 1;
      int index1302 = num3912;
      int num3914 = (int) numArray1242[this.ucScreenLED1.ZhuangShi11 * 3 + 2];
      numArray1308[index1302] = (byte) num3914;
      byte[] numArray1309 = second;
      int num3915 = num3913;
      int num3916 = num3915 + 1;
      int index1303 = num3915;
      int num3917 = (int) numArray1242[this.ucScreenLED1.ZhuangShi10 * 3];
      numArray1309[index1303] = (byte) num3917;
      byte[] numArray1310 = second;
      int num3918 = num3916;
      int num3919 = num3918 + 1;
      int index1304 = num3918;
      int num3920 = (int) numArray1242[this.ucScreenLED1.ZhuangShi10 * 3 + 1];
      numArray1310[index1304] = (byte) num3920;
      byte[] numArray1311 = second;
      int num3921 = num3919;
      int num3922 = num3921 + 1;
      int index1305 = num3921;
      int num3923 = (int) numArray1242[this.ucScreenLED1.ZhuangShi10 * 3 + 2];
      numArray1311[index1305] = (byte) num3923;
      byte[] numArray1312 = second;
      int num3924 = num3922;
      int num3925 = num3924 + 1;
      int index1306 = num3924;
      int num3926 = (int) numArray1242[this.ucScreenLED1.ZhuangShi9 * 3];
      numArray1312[index1306] = (byte) num3926;
      byte[] numArray1313 = second;
      int num3927 = num3925;
      int num3928 = num3927 + 1;
      int index1307 = num3927;
      int num3929 = (int) numArray1242[this.ucScreenLED1.ZhuangShi9 * 3 + 1];
      numArray1313[index1307] = (byte) num3929;
      byte[] numArray1314 = second;
      int num3930 = num3928;
      int num3931 = num3930 + 1;
      int index1308 = num3930;
      int num3932 = (int) numArray1242[this.ucScreenLED1.ZhuangShi9 * 3 + 2];
      numArray1314[index1308] = (byte) num3932;
      byte[] numArray1315 = second;
      int num3933 = num3931;
      int num3934 = num3933 + 1;
      int index1309 = num3933;
      int num3935 = (int) numArray1242[this.ucScreenLED1.ZhuangShi8 * 3];
      numArray1315[index1309] = (byte) num3935;
      byte[] numArray1316 = second;
      int num3936 = num3934;
      int num3937 = num3936 + 1;
      int index1310 = num3936;
      int num3938 = (int) numArray1242[this.ucScreenLED1.ZhuangShi8 * 3 + 1];
      numArray1316[index1310] = (byte) num3938;
      byte[] numArray1317 = second;
      int num3939 = num3937;
      int num3940 = num3939 + 1;
      int index1311 = num3939;
      int num3941 = (int) numArray1242[this.ucScreenLED1.ZhuangShi8 * 3 + 2];
      numArray1317[index1311] = (byte) num3941;
      byte[] numArray1318 = second;
      int num3942 = num3940;
      int num3943 = num3942 + 1;
      int index1312 = num3942;
      int num3944 = (int) numArray1242[this.ucScreenLED1.ZhuangShi7 * 3];
      numArray1318[index1312] = (byte) num3944;
      byte[] numArray1319 = second;
      int num3945 = num3943;
      int num3946 = num3945 + 1;
      int index1313 = num3945;
      int num3947 = (int) numArray1242[this.ucScreenLED1.ZhuangShi7 * 3 + 1];
      numArray1319[index1313] = (byte) num3947;
      byte[] numArray1320 = second;
      int num3948 = num3946;
      int num3949 = num3948 + 1;
      int index1314 = num3948;
      int num3950 = (int) numArray1242[this.ucScreenLED1.ZhuangShi7 * 3 + 2];
      numArray1320[index1314] = (byte) num3950;
      byte[] numArray1321 = second;
      int num3951 = num3949;
      int num3952 = num3951 + 1;
      int index1315 = num3951;
      int num3953 = (int) numArray1242[this.ucScreenLED1.ZhuangShi6 * 3];
      numArray1321[index1315] = (byte) num3953;
      byte[] numArray1322 = second;
      int num3954 = num3952;
      int num3955 = num3954 + 1;
      int index1316 = num3954;
      int num3956 = (int) numArray1242[this.ucScreenLED1.ZhuangShi6 * 3 + 1];
      numArray1322[index1316] = (byte) num3956;
      byte[] numArray1323 = second;
      int num3957 = num3955;
      int num3958 = num3957 + 1;
      int index1317 = num3957;
      int num3959 = (int) numArray1242[this.ucScreenLED1.ZhuangShi6 * 3 + 2];
      numArray1323[index1317] = (byte) num3959;
      byte[] numArray1324 = second;
      int num3960 = num3958;
      int num3961 = num3960 + 1;
      int index1318 = num3960;
      int num3962 = (int) numArray1242[this.ucScreenLED1.ZhuangShi5 * 3];
      numArray1324[index1318] = (byte) num3962;
      byte[] numArray1325 = second;
      int num3963 = num3961;
      int num3964 = num3963 + 1;
      int index1319 = num3963;
      int num3965 = (int) numArray1242[this.ucScreenLED1.ZhuangShi5 * 3 + 1];
      numArray1325[index1319] = (byte) num3965;
      byte[] numArray1326 = second;
      int num3966 = num3964;
      int num3967 = num3966 + 1;
      int index1320 = num3966;
      int num3968 = (int) numArray1242[this.ucScreenLED1.ZhuangShi5 * 3 + 2];
      numArray1326[index1320] = (byte) num3968;
      byte[] numArray1327 = second;
      int num3969 = num3967;
      int num3970 = num3969 + 1;
      int index1321 = num3969;
      int num3971 = (int) numArray1242[this.ucScreenLED1.ZhuangShi4 * 3];
      numArray1327[index1321] = (byte) num3971;
      byte[] numArray1328 = second;
      int num3972 = num3970;
      int num3973 = num3972 + 1;
      int index1322 = num3972;
      int num3974 = (int) numArray1242[this.ucScreenLED1.ZhuangShi4 * 3 + 1];
      numArray1328[index1322] = (byte) num3974;
      byte[] numArray1329 = second;
      int num3975 = num3973;
      int num3976 = num3975 + 1;
      int index1323 = num3975;
      int num3977 = (int) numArray1242[this.ucScreenLED1.ZhuangShi4 * 3 + 2];
      numArray1329[index1323] = (byte) num3977;
      byte[] numArray1330 = second;
      int num3978 = num3976;
      int num3979 = num3978 + 1;
      int index1324 = num3978;
      int num3980 = (int) numArray1242[this.ucScreenLED1.ZhuangShi3 * 3];
      numArray1330[index1324] = (byte) num3980;
      byte[] numArray1331 = second;
      int num3981 = num3979;
      int num3982 = num3981 + 1;
      int index1325 = num3981;
      int num3983 = (int) numArray1242[this.ucScreenLED1.ZhuangShi3 * 3 + 1];
      numArray1331[index1325] = (byte) num3983;
      byte[] numArray1332 = second;
      int num3984 = num3982;
      int num3985 = num3984 + 1;
      int index1326 = num3984;
      int num3986 = (int) numArray1242[this.ucScreenLED1.ZhuangShi3 * 3 + 2];
      numArray1332[index1326] = (byte) num3986;
      byte[] numArray1333 = second;
      int num3987 = num3985;
      int num3988 = num3987 + 1;
      int index1327 = num3987;
      int num3989 = (int) numArray1242[this.ucScreenLED1.ZhuangShi2 * 3];
      numArray1333[index1327] = (byte) num3989;
      byte[] numArray1334 = second;
      int num3990 = num3988;
      int num3991 = num3990 + 1;
      int index1328 = num3990;
      int num3992 = (int) numArray1242[this.ucScreenLED1.ZhuangShi2 * 3 + 1];
      numArray1334[index1328] = (byte) num3992;
      byte[] numArray1335 = second;
      int num3993 = num3991;
      int num3994 = num3993 + 1;
      int index1329 = num3993;
      int num3995 = (int) numArray1242[this.ucScreenLED1.ZhuangShi2 * 3 + 2];
      numArray1335[index1329] = (byte) num3995;
      byte[] numArray1336 = second;
      int num3996 = num3994;
      int num3997 = num3996 + 1;
      int index1330 = num3996;
      int num3998 = (int) numArray1242[this.ucScreenLED1.ZhuangShi1 * 3];
      numArray1336[index1330] = (byte) num3998;
      byte[] numArray1337 = second;
      int num3999 = num3997;
      int num4000 = num3999 + 1;
      int index1331 = num3999;
      int num4001 = (int) numArray1242[this.ucScreenLED1.ZhuangShi1 * 3 + 1];
      numArray1337[index1331] = (byte) num4001;
      byte[] numArray1338 = second;
      int num4002 = num4000;
      int num4003 = num4002 + 1;
      int index1332 = num4002;
      int num4004 = (int) numArray1242[this.ucScreenLED1.ZhuangShi1 * 3 + 2];
      numArray1338[index1332] = (byte) num4004;
      byte[] numArray1339 = second;
      int num4005 = num4003;
      int num4006 = num4005 + 1;
      int index1333 = num4005;
      int num4007 = (int) numArray1242[this.ucScreenLED1.ZhuangShi21 * 3];
      numArray1339[index1333] = (byte) num4007;
      byte[] numArray1340 = second;
      int num4008 = num4006;
      int num4009 = num4008 + 1;
      int index1334 = num4008;
      int num4010 = (int) numArray1242[this.ucScreenLED1.ZhuangShi21 * 3 + 1];
      numArray1340[index1334] = (byte) num4010;
      byte[] numArray1341 = second;
      int num4011 = num4009;
      int num4012 = num4011 + 1;
      int index1335 = num4011;
      int num4013 = (int) numArray1242[this.ucScreenLED1.ZhuangShi21 * 3 + 2];
      numArray1341[index1335] = (byte) num4013;
      byte[] numArray1342 = second;
      int num4014 = num4012;
      int num4015 = num4014 + 1;
      int index1336 = num4014;
      int num4016 = (int) numArray1242[this.ucScreenLED1.ZhuangShi22 * 3];
      numArray1342[index1336] = (byte) num4016;
      byte[] numArray1343 = second;
      int num4017 = num4015;
      int num4018 = num4017 + 1;
      int index1337 = num4017;
      int num4019 = (int) numArray1242[this.ucScreenLED1.ZhuangShi22 * 3 + 1];
      numArray1343[index1337] = (byte) num4019;
      byte[] numArray1344 = second;
      int num4020 = num4018;
      int num4021 = num4020 + 1;
      int index1338 = num4020;
      int num4022 = (int) numArray1242[this.ucScreenLED1.ZhuangShi22 * 3 + 2];
      numArray1344[index1338] = (byte) num4022;
      byte[] numArray1345 = second;
      int num4023 = num4021;
      int num4024 = num4023 + 1;
      int index1339 = num4023;
      int num4025 = (int) numArray1242[this.ucScreenLED1.ZhuangShi23 * 3];
      numArray1345[index1339] = (byte) num4025;
      byte[] numArray1346 = second;
      int num4026 = num4024;
      int num4027 = num4026 + 1;
      int index1340 = num4026;
      int num4028 = (int) numArray1242[this.ucScreenLED1.ZhuangShi23 * 3 + 1];
      numArray1346[index1340] = (byte) num4028;
      byte[] numArray1347 = second;
      int num4029 = num4027;
      int num4030 = num4029 + 1;
      int index1341 = num4029;
      int num4031 = (int) numArray1242[this.ucScreenLED1.ZhuangShi23 * 3 + 2];
      numArray1347[index1341] = (byte) num4031;
      byte[] numArray1348 = second;
      int num4032 = num4030;
      int num4033 = num4032 + 1;
      int index1342 = num4032;
      int num4034 = (int) numArray1242[this.ucScreenLED1.ZhuangShi24 * 3];
      numArray1348[index1342] = (byte) num4034;
      byte[] numArray1349 = second;
      int num4035 = num4033;
      int num4036 = num4035 + 1;
      int index1343 = num4035;
      int num4037 = (int) numArray1242[this.ucScreenLED1.ZhuangShi24 * 3 + 1];
      numArray1349[index1343] = (byte) num4037;
      byte[] numArray1350 = second;
      int num4038 = num4036;
      int num4039 = num4038 + 1;
      int index1344 = num4038;
      int num4040 = (int) numArray1242[this.ucScreenLED1.ZhuangShi24 * 3 + 2];
      numArray1350[index1344] = (byte) num4040;
      byte[] numArray1351 = second;
      int num4041 = num4039;
      int num4042 = num4041 + 1;
      int index1345 = num4041;
      int num4043 = (int) numArray1242[this.ucScreenLED1.ZhuangShi25 * 3];
      numArray1351[index1345] = (byte) num4043;
      byte[] numArray1352 = second;
      int num4044 = num4042;
      int num4045 = num4044 + 1;
      int index1346 = num4044;
      int num4046 = (int) numArray1242[this.ucScreenLED1.ZhuangShi25 * 3 + 1];
      numArray1352[index1346] = (byte) num4046;
      byte[] numArray1353 = second;
      int num4047 = num4045;
      int num4048 = num4047 + 1;
      int index1347 = num4047;
      int num4049 = (int) numArray1242[this.ucScreenLED1.ZhuangShi25 * 3 + 2];
      numArray1353[index1347] = (byte) num4049;
      byte[] numArray1354 = second;
      int num4050 = num4048;
      int num4051 = num4050 + 1;
      int index1348 = num4050;
      int num4052 = (int) numArray1242[this.ucScreenLED1.ZhuangShi26 * 3];
      numArray1354[index1348] = (byte) num4052;
      byte[] numArray1355 = second;
      int num4053 = num4051;
      int num4054 = num4053 + 1;
      int index1349 = num4053;
      int num4055 = (int) numArray1242[this.ucScreenLED1.ZhuangShi26 * 3 + 1];
      numArray1355[index1349] = (byte) num4055;
      byte[] numArray1356 = second;
      int num4056 = num4054;
      int num4057 = num4056 + 1;
      int index1350 = num4056;
      int num4058 = (int) numArray1242[this.ucScreenLED1.ZhuangShi26 * 3 + 2];
      numArray1356[index1350] = (byte) num4058;
      byte[] numArray1357 = second;
      int num4059 = num4057;
      int num4060 = num4059 + 1;
      int index1351 = num4059;
      int num4061 = (int) numArray1242[this.ucScreenLED1.Cpu1 * 3];
      numArray1357[index1351] = (byte) num4061;
      byte[] numArray1358 = second;
      int num4062 = num4060;
      int num4063 = num4062 + 1;
      int index1352 = num4062;
      int num4064 = (int) numArray1242[this.ucScreenLED1.Cpu1 * 3 + 1];
      numArray1358[index1352] = (byte) num4064;
      byte[] numArray1359 = second;
      int num4065 = num4063;
      int num4066 = num4065 + 1;
      int index1353 = num4065;
      int num4067 = (int) numArray1242[this.ucScreenLED1.Cpu1 * 3 + 2];
      numArray1359[index1353] = (byte) num4067;
      byte[] numArray1360 = second;
      int num4068 = num4066;
      int num4069 = num4068 + 1;
      int index1354 = num4068;
      int num4070 = (int) numArray1242[this.ucScreenLED1.Cpu1 * 3];
      numArray1360[index1354] = (byte) num4070;
      byte[] numArray1361 = second;
      int num4071 = num4069;
      int num4072 = num4071 + 1;
      int index1355 = num4071;
      int num4073 = (int) numArray1242[this.ucScreenLED1.Cpu1 * 3 + 1];
      numArray1361[index1355] = (byte) num4073;
      byte[] numArray1362 = second;
      int num4074 = num4072;
      int num4075 = num4074 + 1;
      int index1356 = num4074;
      int num4076 = (int) numArray1242[this.ucScreenLED1.Cpu1 * 3 + 2];
      numArray1362[index1356] = (byte) num4076;
      byte[] numArray1363 = second;
      int num4077 = num4075;
      int num4078 = num4077 + 1;
      int index1357 = num4077;
      int num4079 = (int) numArray1242[this.ucScreenLED1.LEDL1 * 3];
      numArray1363[index1357] = (byte) num4079;
      byte[] numArray1364 = second;
      int num4080 = num4078;
      int num4081 = num4080 + 1;
      int index1358 = num4080;
      int num4082 = (int) numArray1242[this.ucScreenLED1.LEDL1 * 3 + 1];
      numArray1364[index1358] = (byte) num4082;
      byte[] numArray1365 = second;
      int num4083 = num4081;
      int num4084 = num4083 + 1;
      int index1359 = num4083;
      int num4085 = (int) numArray1242[this.ucScreenLED1.LEDL1 * 3 + 2];
      numArray1365[index1359] = (byte) num4085;
      byte[] numArray1366 = second;
      int num4086 = num4084;
      int num4087 = num4086 + 1;
      int index1360 = num4086;
      int num4088 = (int) numArray1242[this.ucScreenLED1.LEDA1 * 3];
      numArray1366[index1360] = (byte) num4088;
      byte[] numArray1367 = second;
      int num4089 = num4087;
      int num4090 = num4089 + 1;
      int index1361 = num4089;
      int num4091 = (int) numArray1242[this.ucScreenLED1.LEDA1 * 3 + 1];
      numArray1367[index1361] = (byte) num4091;
      byte[] numArray1368 = second;
      int num4092 = num4090;
      int num4093 = num4092 + 1;
      int index1362 = num4092;
      int num4094 = (int) numArray1242[this.ucScreenLED1.LEDA1 * 3 + 2];
      numArray1368[index1362] = (byte) num4094;
      byte[] numArray1369 = second;
      int num4095 = num4093;
      int num4096 = num4095 + 1;
      int index1363 = num4095;
      int num4097 = (int) numArray1242[this.ucScreenLED1.LEDB1 * 3];
      numArray1369[index1363] = (byte) num4097;
      byte[] numArray1370 = second;
      int num4098 = num4096;
      int num4099 = num4098 + 1;
      int index1364 = num4098;
      int num4100 = (int) numArray1242[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray1370[index1364] = (byte) num4100;
      byte[] numArray1371 = second;
      int num4101 = num4099;
      int num4102 = num4101 + 1;
      int index1365 = num4101;
      int num4103 = (int) numArray1242[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray1371[index1365] = (byte) num4103;
      byte[] numArray1372 = second;
      int num4104 = num4102;
      int num4105 = num4104 + 1;
      int index1366 = num4104;
      int num4106 = (int) numArray1242[this.ucScreenLED1.LEDB1 * 3];
      numArray1372[index1366] = (byte) num4106;
      byte[] numArray1373 = second;
      int num4107 = num4105;
      int num4108 = num4107 + 1;
      int index1367 = num4107;
      int num4109 = (int) numArray1242[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray1373[index1367] = (byte) num4109;
      byte[] numArray1374 = second;
      int num4110 = num4108;
      int num4111 = num4110 + 1;
      int index1368 = num4110;
      int num4112 = (int) numArray1242[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray1374[index1368] = (byte) num4112;
      byte[] numArray1375 = second;
      int num4113 = num4111;
      int num4114 = num4113 + 1;
      int index1369 = num4113;
      int num4115 = (int) numArray1242[this.ucScreenLED1.LEDC1 * 3];
      numArray1375[index1369] = (byte) num4115;
      byte[] numArray1376 = second;
      int num4116 = num4114;
      int num4117 = num4116 + 1;
      int index1370 = num4116;
      int num4118 = (int) numArray1242[this.ucScreenLED1.LEDC1 * 3 + 1];
      numArray1376[index1370] = (byte) num4118;
      byte[] numArray1377 = second;
      int num4119 = num4117;
      int num4120 = num4119 + 1;
      int index1371 = num4119;
      int num4121 = (int) numArray1242[this.ucScreenLED1.LEDC1 * 3 + 2];
      numArray1377[index1371] = (byte) num4121;
      byte[] numArray1378 = second;
      int num4122 = num4120;
      int num4123 = num4122 + 1;
      int index1372 = num4122;
      int num4124 = (int) numArray1242[this.ucScreenLED1.LEDD1 * 3];
      numArray1378[index1372] = (byte) num4124;
      byte[] numArray1379 = second;
      int num4125 = num4123;
      int num4126 = num4125 + 1;
      int index1373 = num4125;
      int num4127 = (int) numArray1242[this.ucScreenLED1.LEDD1 * 3 + 1];
      numArray1379[index1373] = (byte) num4127;
      byte[] numArray1380 = second;
      int num4128 = num4126;
      int num4129 = num4128 + 1;
      int index1374 = num4128;
      int num4130 = (int) numArray1242[this.ucScreenLED1.LEDD1 * 3 + 2];
      numArray1380[index1374] = (byte) num4130;
      byte[] numArray1381 = second;
      int num4131 = num4129;
      int num4132 = num4131 + 1;
      int index1375 = num4131;
      int num4133 = (int) numArray1242[this.ucScreenLED1.LEDE1 * 3];
      numArray1381[index1375] = (byte) num4133;
      byte[] numArray1382 = second;
      int num4134 = num4132;
      int num4135 = num4134 + 1;
      int index1376 = num4134;
      int num4136 = (int) numArray1242[this.ucScreenLED1.LEDE1 * 3 + 1];
      numArray1382[index1376] = (byte) num4136;
      byte[] numArray1383 = second;
      int num4137 = num4135;
      int num4138 = num4137 + 1;
      int index1377 = num4137;
      int num4139 = (int) numArray1242[this.ucScreenLED1.LEDE1 * 3 + 2];
      numArray1383[index1377] = (byte) num4139;
      byte[] numArray1384 = second;
      int num4140 = num4138;
      int num4141 = num4140 + 1;
      int index1378 = num4140;
      int num4142 = (int) numArray1242[this.ucScreenLED1.LEDM1 * 3];
      numArray1384[index1378] = (byte) num4142;
      byte[] numArray1385 = second;
      int num4143 = num4141;
      int num4144 = num4143 + 1;
      int index1379 = num4143;
      int num4145 = (int) numArray1242[this.ucScreenLED1.LEDM1 * 3 + 1];
      numArray1385[index1379] = (byte) num4145;
      byte[] numArray1386 = second;
      int num4146 = num4144;
      int num4147 = num4146 + 1;
      int index1380 = num4146;
      int num4148 = (int) numArray1242[this.ucScreenLED1.LEDM1 * 3 + 2];
      numArray1386[index1380] = (byte) num4148;
      byte[] numArray1387 = second;
      int num4149 = num4147;
      int num4150 = num4149 + 1;
      int index1381 = num4149;
      int num4151 = (int) numArray1242[this.ucScreenLED1.LEDM1 * 3];
      numArray1387[index1381] = (byte) num4151;
      byte[] numArray1388 = second;
      int num4152 = num4150;
      int num4153 = num4152 + 1;
      int index1382 = num4152;
      int num4154 = (int) numArray1242[this.ucScreenLED1.LEDM1 * 3 + 1];
      numArray1388[index1382] = (byte) num4154;
      byte[] numArray1389 = second;
      int num4155 = num4153;
      int num4156 = num4155 + 1;
      int index1383 = num4155;
      int num4157 = (int) numArray1242[this.ucScreenLED1.LEDM1 * 3 + 2];
      numArray1389[index1383] = (byte) num4157;
      byte[] numArray1390 = second;
      int num4158 = num4156;
      int num4159 = num4158 + 1;
      int index1384 = num4158;
      int num4160 = (int) numArray1242[this.ucScreenLED1.LEDK1 * 3];
      numArray1390[index1384] = (byte) num4160;
      byte[] numArray1391 = second;
      int num4161 = num4159;
      int num4162 = num4161 + 1;
      int index1385 = num4161;
      int num4163 = (int) numArray1242[this.ucScreenLED1.LEDK1 * 3 + 1];
      numArray1391[index1385] = (byte) num4163;
      byte[] numArray1392 = second;
      int num4164 = num4162;
      int num4165 = num4164 + 1;
      int index1386 = num4164;
      int num4166 = (int) numArray1242[this.ucScreenLED1.LEDK1 * 3 + 2];
      numArray1392[index1386] = (byte) num4166;
      byte[] numArray1393 = second;
      int num4167 = num4165;
      int num4168 = num4167 + 1;
      int index1387 = num4167;
      int num4169 = (int) numArray1242[this.ucScreenLED1.LEDJ1 * 3];
      numArray1393[index1387] = (byte) num4169;
      byte[] numArray1394 = second;
      int num4170 = num4168;
      int num4171 = num4170 + 1;
      int index1388 = num4170;
      int num4172 = (int) numArray1242[this.ucScreenLED1.LEDJ1 * 3 + 1];
      numArray1394[index1388] = (byte) num4172;
      byte[] numArray1395 = second;
      int num4173 = num4171;
      int num4174 = num4173 + 1;
      int index1389 = num4173;
      int num4175 = (int) numArray1242[this.ucScreenLED1.LEDJ1 * 3 + 2];
      numArray1395[index1389] = (byte) num4175;
      byte[] numArray1396 = second;
      int num4176 = num4174;
      int num4177 = num4176 + 1;
      int index1390 = num4176;
      int num4178 = (int) numArray1242[this.ucScreenLED1.LEDI1 * 3];
      numArray1396[index1390] = (byte) num4178;
      byte[] numArray1397 = second;
      int num4179 = num4177;
      int num4180 = num4179 + 1;
      int index1391 = num4179;
      int num4181 = (int) numArray1242[this.ucScreenLED1.LEDI1 * 3 + 1];
      numArray1397[index1391] = (byte) num4181;
      byte[] numArray1398 = second;
      int num4182 = num4180;
      int num4183 = num4182 + 1;
      int index1392 = num4182;
      int num4184 = (int) numArray1242[this.ucScreenLED1.LEDI1 * 3 + 2];
      numArray1398[index1392] = (byte) num4184;
      byte[] numArray1399 = second;
      int num4185 = num4183;
      int num4186 = num4185 + 1;
      int index1393 = num4185;
      int num4187 = (int) numArray1242[this.ucScreenLED1.LEDH1 * 3];
      numArray1399[index1393] = (byte) num4187;
      byte[] numArray1400 = second;
      int num4188 = num4186;
      int num4189 = num4188 + 1;
      int index1394 = num4188;
      int num4190 = (int) numArray1242[this.ucScreenLED1.LEDH1 * 3 + 1];
      numArray1400[index1394] = (byte) num4190;
      byte[] numArray1401 = second;
      int num4191 = num4189;
      int num4192 = num4191 + 1;
      int index1395 = num4191;
      int num4193 = (int) numArray1242[this.ucScreenLED1.LEDH1 * 3 + 2];
      numArray1401[index1395] = (byte) num4193;
      byte[] numArray1402 = second;
      int num4194 = num4192;
      int num4195 = num4194 + 1;
      int index1396 = num4194;
      int num4196 = (int) numArray1242[this.ucScreenLED1.LEDH1 * 3];
      numArray1402[index1396] = (byte) num4196;
      byte[] numArray1403 = second;
      int num4197 = num4195;
      int num4198 = num4197 + 1;
      int index1397 = num4197;
      int num4199 = (int) numArray1242[this.ucScreenLED1.LEDH1 * 3 + 1];
      numArray1403[index1397] = (byte) num4199;
      byte[] numArray1404 = second;
      int num4200 = num4198;
      int num4201 = num4200 + 1;
      int index1398 = num4200;
      int num4202 = (int) numArray1242[this.ucScreenLED1.LEDH1 * 3 + 2];
      numArray1404[index1398] = (byte) num4202;
      byte[] numArray1405 = second;
      int num4203 = num4201;
      int num4204 = num4203 + 1;
      int index1399 = num4203;
      int num4205 = (int) numArray1242[this.ucScreenLED1.LEDG1 * 3];
      numArray1405[index1399] = (byte) num4205;
      byte[] numArray1406 = second;
      int num4206 = num4204;
      int num4207 = num4206 + 1;
      int index1400 = num4206;
      int num4208 = (int) numArray1242[this.ucScreenLED1.LEDG1 * 3 + 1];
      numArray1406[index1400] = (byte) num4208;
      byte[] numArray1407 = second;
      int num4209 = num4207;
      int num4210 = num4209 + 1;
      int index1401 = num4209;
      int num4211 = (int) numArray1242[this.ucScreenLED1.LEDG1 * 3 + 2];
      numArray1407[index1401] = (byte) num4211;
      byte[] numArray1408 = second;
      int num4212 = num4210;
      int num4213 = num4212 + 1;
      int index1402 = num4212;
      int num4214 = (int) numArray1242[this.ucScreenLED1.LEDF1 * 3];
      numArray1408[index1402] = (byte) num4214;
      byte[] numArray1409 = second;
      int num4215 = num4213;
      int num4216 = num4215 + 1;
      int index1403 = num4215;
      int num4217 = (int) numArray1242[this.ucScreenLED1.LEDF1 * 3 + 1];
      numArray1409[index1403] = (byte) num4217;
      byte[] numArray1410 = second;
      int num4218 = num4216;
      int num4219 = num4218 + 1;
      int index1404 = num4218;
      int num4220 = (int) numArray1242[this.ucScreenLED1.LEDF1 * 3 + 2];
      numArray1410[index1404] = (byte) num4220;
      byte[] numArray1411 = second;
      int num4221 = num4219;
      int num4222 = num4221 + 1;
      int index1405 = num4221;
      int num4223 = (int) numArray1242[this.ucScreenLED1.LEDJ2 * 3];
      numArray1411[index1405] = (byte) num4223;
      byte[] numArray1412 = second;
      int num4224 = num4222;
      int num4225 = num4224 + 1;
      int index1406 = num4224;
      int num4226 = (int) numArray1242[this.ucScreenLED1.LEDJ2 * 3 + 1];
      numArray1412[index1406] = (byte) num4226;
      byte[] numArray1413 = second;
      int num4227 = num4225;
      int num4228 = num4227 + 1;
      int index1407 = num4227;
      int num4229 = (int) numArray1242[this.ucScreenLED1.LEDJ2 * 3 + 2];
      numArray1413[index1407] = (byte) num4229;
      byte[] numArray1414 = second;
      int num4230 = num4228;
      int num4231 = num4230 + 1;
      int index1408 = num4230;
      int num4232 = (int) numArray1242[this.ucScreenLED1.LEDI2 * 3];
      numArray1414[index1408] = (byte) num4232;
      byte[] numArray1415 = second;
      int num4233 = num4231;
      int num4234 = num4233 + 1;
      int index1409 = num4233;
      int num4235 = (int) numArray1242[this.ucScreenLED1.LEDI2 * 3 + 1];
      numArray1415[index1409] = (byte) num4235;
      byte[] numArray1416 = second;
      int num4236 = num4234;
      int num4237 = num4236 + 1;
      int index1410 = num4236;
      int num4238 = (int) numArray1242[this.ucScreenLED1.LEDI2 * 3 + 2];
      numArray1416[index1410] = (byte) num4238;
      byte[] numArray1417 = second;
      int num4239 = num4237;
      int num4240 = num4239 + 1;
      int index1411 = num4239;
      int num4241 = (int) numArray1242[this.ucScreenLED1.LEDH2 * 3];
      numArray1417[index1411] = (byte) num4241;
      byte[] numArray1418 = second;
      int num4242 = num4240;
      int num4243 = num4242 + 1;
      int index1412 = num4242;
      int num4244 = (int) numArray1242[this.ucScreenLED1.LEDH2 * 3 + 1];
      numArray1418[index1412] = (byte) num4244;
      byte[] numArray1419 = second;
      int num4245 = num4243;
      int num4246 = num4245 + 1;
      int index1413 = num4245;
      int num4247 = (int) numArray1242[this.ucScreenLED1.LEDH2 * 3 + 2];
      numArray1419[index1413] = (byte) num4247;
      byte[] numArray1420 = second;
      int num4248 = num4246;
      int num4249 = num4248 + 1;
      int index1414 = num4248;
      int num4250 = (int) numArray1242[this.ucScreenLED1.LEDH2 * 3];
      numArray1420[index1414] = (byte) num4250;
      byte[] numArray1421 = second;
      int num4251 = num4249;
      int num4252 = num4251 + 1;
      int index1415 = num4251;
      int num4253 = (int) numArray1242[this.ucScreenLED1.LEDH2 * 3 + 1];
      numArray1421[index1415] = (byte) num4253;
      byte[] numArray1422 = second;
      int num4254 = num4252;
      int num4255 = num4254 + 1;
      int index1416 = num4254;
      int num4256 = (int) numArray1242[this.ucScreenLED1.LEDH2 * 3 + 2];
      numArray1422[index1416] = (byte) num4256;
      byte[] numArray1423 = second;
      int num4257 = num4255;
      int num4258 = num4257 + 1;
      int index1417 = num4257;
      int num4259 = (int) numArray1242[this.ucScreenLED1.LEDG2 * 3];
      numArray1423[index1417] = (byte) num4259;
      byte[] numArray1424 = second;
      int num4260 = num4258;
      int num4261 = num4260 + 1;
      int index1418 = num4260;
      int num4262 = (int) numArray1242[this.ucScreenLED1.LEDG2 * 3 + 1];
      numArray1424[index1418] = (byte) num4262;
      byte[] numArray1425 = second;
      int num4263 = num4261;
      int num4264 = num4263 + 1;
      int index1419 = num4263;
      int num4265 = (int) numArray1242[this.ucScreenLED1.LEDG2 * 3 + 2];
      numArray1425[index1419] = (byte) num4265;
      byte[] numArray1426 = second;
      int num4266 = num4264;
      int num4267 = num4266 + 1;
      int index1420 = num4266;
      int num4268 = (int) numArray1242[this.ucScreenLED1.LEDF2 * 3];
      numArray1426[index1420] = (byte) num4268;
      byte[] numArray1427 = second;
      int num4269 = num4267;
      int num4270 = num4269 + 1;
      int index1421 = num4269;
      int num4271 = (int) numArray1242[this.ucScreenLED1.LEDF2 * 3 + 1];
      numArray1427[index1421] = (byte) num4271;
      byte[] numArray1428 = second;
      int num4272 = num4270;
      int num4273 = num4272 + 1;
      int index1422 = num4272;
      int num4274 = (int) numArray1242[this.ucScreenLED1.LEDF2 * 3 + 2];
      numArray1428[index1422] = (byte) num4274;
      byte[] numArray1429 = second;
      int num4275 = num4273;
      int num4276 = num4275 + 1;
      int index1423 = num4275;
      int num4277 = (int) numArray1242[this.ucScreenLED1.LEDE2 * 3];
      numArray1429[index1423] = (byte) num4277;
      byte[] numArray1430 = second;
      int num4278 = num4276;
      int num4279 = num4278 + 1;
      int index1424 = num4278;
      int num4280 = (int) numArray1242[this.ucScreenLED1.LEDE2 * 3 + 1];
      numArray1430[index1424] = (byte) num4280;
      byte[] numArray1431 = second;
      int num4281 = num4279;
      int num4282 = num4281 + 1;
      int index1425 = num4281;
      int num4283 = (int) numArray1242[this.ucScreenLED1.LEDE2 * 3 + 2];
      numArray1431[index1425] = (byte) num4283;
      byte[] numArray1432 = second;
      int num4284 = num4282;
      int num4285 = num4284 + 1;
      int index1426 = num4284;
      int num4286 = (int) numArray1242[this.ucScreenLED1.LEDM2 * 3];
      numArray1432[index1426] = (byte) num4286;
      byte[] numArray1433 = second;
      int num4287 = num4285;
      int num4288 = num4287 + 1;
      int index1427 = num4287;
      int num4289 = (int) numArray1242[this.ucScreenLED1.LEDM2 * 3 + 1];
      numArray1433[index1427] = (byte) num4289;
      byte[] numArray1434 = second;
      int num4290 = num4288;
      int num4291 = num4290 + 1;
      int index1428 = num4290;
      int num4292 = (int) numArray1242[this.ucScreenLED1.LEDM2 * 3 + 2];
      numArray1434[index1428] = (byte) num4292;
      byte[] numArray1435 = second;
      int num4293 = num4291;
      int num4294 = num4293 + 1;
      int index1429 = num4293;
      int num4295 = (int) numArray1242[this.ucScreenLED1.LEDM2 * 3];
      numArray1435[index1429] = (byte) num4295;
      byte[] numArray1436 = second;
      int num4296 = num4294;
      int num4297 = num4296 + 1;
      int index1430 = num4296;
      int num4298 = (int) numArray1242[this.ucScreenLED1.LEDM2 * 3 + 1];
      numArray1436[index1430] = (byte) num4298;
      byte[] numArray1437 = second;
      int num4299 = num4297;
      int num4300 = num4299 + 1;
      int index1431 = num4299;
      int num4301 = (int) numArray1242[this.ucScreenLED1.LEDM2 * 3 + 2];
      numArray1437[index1431] = (byte) num4301;
      byte[] numArray1438 = second;
      int num4302 = num4300;
      int num4303 = num4302 + 1;
      int index1432 = num4302;
      int num4304 = (int) numArray1242[this.ucScreenLED1.LEDK2 * 3];
      numArray1438[index1432] = (byte) num4304;
      byte[] numArray1439 = second;
      int num4305 = num4303;
      int num4306 = num4305 + 1;
      int index1433 = num4305;
      int num4307 = (int) numArray1242[this.ucScreenLED1.LEDK2 * 3 + 1];
      numArray1439[index1433] = (byte) num4307;
      byte[] numArray1440 = second;
      int num4308 = num4306;
      int num4309 = num4308 + 1;
      int index1434 = num4308;
      int num4310 = (int) numArray1242[this.ucScreenLED1.LEDK2 * 3 + 2];
      numArray1440[index1434] = (byte) num4310;
      byte[] numArray1441 = second;
      int num4311 = num4309;
      int num4312 = num4311 + 1;
      int index1435 = num4311;
      int num4313 = (int) numArray1242[this.ucScreenLED1.LEDL2 * 3];
      numArray1441[index1435] = (byte) num4313;
      byte[] numArray1442 = second;
      int num4314 = num4312;
      int num4315 = num4314 + 1;
      int index1436 = num4314;
      int num4316 = (int) numArray1242[this.ucScreenLED1.LEDL2 * 3 + 1];
      numArray1442[index1436] = (byte) num4316;
      byte[] numArray1443 = second;
      int num4317 = num4315;
      int num4318 = num4317 + 1;
      int index1437 = num4317;
      int num4319 = (int) numArray1242[this.ucScreenLED1.LEDL2 * 3 + 2];
      numArray1443[index1437] = (byte) num4319;
      byte[] numArray1444 = second;
      int num4320 = num4318;
      int num4321 = num4320 + 1;
      int index1438 = num4320;
      int num4322 = (int) numArray1242[this.ucScreenLED1.LEDA2 * 3];
      numArray1444[index1438] = (byte) num4322;
      byte[] numArray1445 = second;
      int num4323 = num4321;
      int num4324 = num4323 + 1;
      int index1439 = num4323;
      int num4325 = (int) numArray1242[this.ucScreenLED1.LEDA2 * 3 + 1];
      numArray1445[index1439] = (byte) num4325;
      byte[] numArray1446 = second;
      int num4326 = num4324;
      int num4327 = num4326 + 1;
      int index1440 = num4326;
      int num4328 = (int) numArray1242[this.ucScreenLED1.LEDA2 * 3 + 2];
      numArray1446[index1440] = (byte) num4328;
      byte[] numArray1447 = second;
      int num4329 = num4327;
      int num4330 = num4329 + 1;
      int index1441 = num4329;
      int num4331 = (int) numArray1242[this.ucScreenLED1.LEDB2 * 3];
      numArray1447[index1441] = (byte) num4331;
      byte[] numArray1448 = second;
      int num4332 = num4330;
      int num4333 = num4332 + 1;
      int index1442 = num4332;
      int num4334 = (int) numArray1242[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray1448[index1442] = (byte) num4334;
      byte[] numArray1449 = second;
      int num4335 = num4333;
      int num4336 = num4335 + 1;
      int index1443 = num4335;
      int num4337 = (int) numArray1242[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray1449[index1443] = (byte) num4337;
      byte[] numArray1450 = second;
      int num4338 = num4336;
      int num4339 = num4338 + 1;
      int index1444 = num4338;
      int num4340 = (int) numArray1242[this.ucScreenLED1.LEDB2 * 3];
      numArray1450[index1444] = (byte) num4340;
      byte[] numArray1451 = second;
      int num4341 = num4339;
      int num4342 = num4341 + 1;
      int index1445 = num4341;
      int num4343 = (int) numArray1242[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray1451[index1445] = (byte) num4343;
      byte[] numArray1452 = second;
      int num4344 = num4342;
      int num4345 = num4344 + 1;
      int index1446 = num4344;
      int num4346 = (int) numArray1242[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray1452[index1446] = (byte) num4346;
      byte[] numArray1453 = second;
      int num4347 = num4345;
      int num4348 = num4347 + 1;
      int index1447 = num4347;
      int num4349 = (int) numArray1242[this.ucScreenLED1.LEDC2 * 3];
      numArray1453[index1447] = (byte) num4349;
      byte[] numArray1454 = second;
      int num4350 = num4348;
      int num4351 = num4350 + 1;
      int index1448 = num4350;
      int num4352 = (int) numArray1242[this.ucScreenLED1.LEDC2 * 3 + 1];
      numArray1454[index1448] = (byte) num4352;
      byte[] numArray1455 = second;
      int num4353 = num4351;
      int num4354 = num4353 + 1;
      int index1449 = num4353;
      int num4355 = (int) numArray1242[this.ucScreenLED1.LEDC2 * 3 + 2];
      numArray1455[index1449] = (byte) num4355;
      byte[] numArray1456 = second;
      int num4356 = num4354;
      int num4357 = num4356 + 1;
      int index1450 = num4356;
      int num4358 = (int) numArray1242[this.ucScreenLED1.LEDD2 * 3];
      numArray1456[index1450] = (byte) num4358;
      byte[] numArray1457 = second;
      int num4359 = num4357;
      int num4360 = num4359 + 1;
      int index1451 = num4359;
      int num4361 = (int) numArray1242[this.ucScreenLED1.LEDD2 * 3 + 1];
      numArray1457[index1451] = (byte) num4361;
      byte[] numArray1458 = second;
      int num4362 = num4360;
      int num4363 = num4362 + 1;
      int index1452 = num4362;
      int num4364 = (int) numArray1242[this.ucScreenLED1.LEDD2 * 3 + 2];
      numArray1458[index1452] = (byte) num4364;
      byte[] numArray1459 = second;
      int num4365 = num4363;
      int num4366 = num4365 + 1;
      int index1453 = num4365;
      int num4367 = (int) numArray1242[this.ucScreenLED1.LEDL3 * 3];
      numArray1459[index1453] = (byte) num4367;
      byte[] numArray1460 = second;
      int num4368 = num4366;
      int num4369 = num4368 + 1;
      int index1454 = num4368;
      int num4370 = (int) numArray1242[this.ucScreenLED1.LEDL3 * 3 + 1];
      numArray1460[index1454] = (byte) num4370;
      byte[] numArray1461 = second;
      int num4371 = num4369;
      int num4372 = num4371 + 1;
      int index1455 = num4371;
      int num4373 = (int) numArray1242[this.ucScreenLED1.LEDL3 * 3 + 2];
      numArray1461[index1455] = (byte) num4373;
      byte[] numArray1462 = second;
      int num4374 = num4372;
      int num4375 = num4374 + 1;
      int index1456 = num4374;
      int num4376 = (int) numArray1242[this.ucScreenLED1.LEDA3 * 3];
      numArray1462[index1456] = (byte) num4376;
      byte[] numArray1463 = second;
      int num4377 = num4375;
      int num4378 = num4377 + 1;
      int index1457 = num4377;
      int num4379 = (int) numArray1242[this.ucScreenLED1.LEDA3 * 3 + 1];
      numArray1463[index1457] = (byte) num4379;
      byte[] numArray1464 = second;
      int num4380 = num4378;
      int num4381 = num4380 + 1;
      int index1458 = num4380;
      int num4382 = (int) numArray1242[this.ucScreenLED1.LEDA3 * 3 + 2];
      numArray1464[index1458] = (byte) num4382;
      byte[] numArray1465 = second;
      int num4383 = num4381;
      int num4384 = num4383 + 1;
      int index1459 = num4383;
      int num4385 = (int) numArray1242[this.ucScreenLED1.LEDB3 * 3];
      numArray1465[index1459] = (byte) num4385;
      byte[] numArray1466 = second;
      int num4386 = num4384;
      int num4387 = num4386 + 1;
      int index1460 = num4386;
      int num4388 = (int) numArray1242[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray1466[index1460] = (byte) num4388;
      byte[] numArray1467 = second;
      int num4389 = num4387;
      int num4390 = num4389 + 1;
      int index1461 = num4389;
      int num4391 = (int) numArray1242[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray1467[index1461] = (byte) num4391;
      byte[] numArray1468 = second;
      int num4392 = num4390;
      int num4393 = num4392 + 1;
      int index1462 = num4392;
      int num4394 = (int) numArray1242[this.ucScreenLED1.LEDB3 * 3];
      numArray1468[index1462] = (byte) num4394;
      byte[] numArray1469 = second;
      int num4395 = num4393;
      int num4396 = num4395 + 1;
      int index1463 = num4395;
      int num4397 = (int) numArray1242[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray1469[index1463] = (byte) num4397;
      byte[] numArray1470 = second;
      int num4398 = num4396;
      int num4399 = num4398 + 1;
      int index1464 = num4398;
      int num4400 = (int) numArray1242[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray1470[index1464] = (byte) num4400;
      byte[] numArray1471 = second;
      int num4401 = num4399;
      int num4402 = num4401 + 1;
      int index1465 = num4401;
      int num4403 = (int) numArray1242[this.ucScreenLED1.LEDC3 * 3];
      numArray1471[index1465] = (byte) num4403;
      byte[] numArray1472 = second;
      int num4404 = num4402;
      int num4405 = num4404 + 1;
      int index1466 = num4404;
      int num4406 = (int) numArray1242[this.ucScreenLED1.LEDC3 * 3 + 1];
      numArray1472[index1466] = (byte) num4406;
      byte[] numArray1473 = second;
      int num4407 = num4405;
      int num4408 = num4407 + 1;
      int index1467 = num4407;
      int num4409 = (int) numArray1242[this.ucScreenLED1.LEDC3 * 3 + 2];
      numArray1473[index1467] = (byte) num4409;
      byte[] numArray1474 = second;
      int num4410 = num4408;
      int num4411 = num4410 + 1;
      int index1468 = num4410;
      int num4412 = (int) numArray1242[this.ucScreenLED1.LEDD3 * 3];
      numArray1474[index1468] = (byte) num4412;
      byte[] numArray1475 = second;
      int num4413 = num4411;
      int num4414 = num4413 + 1;
      int index1469 = num4413;
      int num4415 = (int) numArray1242[this.ucScreenLED1.LEDD3 * 3 + 1];
      numArray1475[index1469] = (byte) num4415;
      byte[] numArray1476 = second;
      int num4416 = num4414;
      int num4417 = num4416 + 1;
      int index1470 = num4416;
      int num4418 = (int) numArray1242[this.ucScreenLED1.LEDD3 * 3 + 2];
      numArray1476[index1470] = (byte) num4418;
      byte[] numArray1477 = second;
      int num4419 = num4417;
      int num4420 = num4419 + 1;
      int index1471 = num4419;
      int num4421 = (int) numArray1242[this.ucScreenLED1.LEDE3 * 3];
      numArray1477[index1471] = (byte) num4421;
      byte[] numArray1478 = second;
      int num4422 = num4420;
      int num4423 = num4422 + 1;
      int index1472 = num4422;
      int num4424 = (int) numArray1242[this.ucScreenLED1.LEDE3 * 3 + 1];
      numArray1478[index1472] = (byte) num4424;
      byte[] numArray1479 = second;
      int num4425 = num4423;
      int num4426 = num4425 + 1;
      int index1473 = num4425;
      int num4427 = (int) numArray1242[this.ucScreenLED1.LEDE3 * 3 + 2];
      numArray1479[index1473] = (byte) num4427;
      byte[] numArray1480 = second;
      int num4428 = num4426;
      int num4429 = num4428 + 1;
      int index1474 = num4428;
      int num4430 = (int) numArray1242[this.ucScreenLED1.LEDM3 * 3];
      numArray1480[index1474] = (byte) num4430;
      byte[] numArray1481 = second;
      int num4431 = num4429;
      int num4432 = num4431 + 1;
      int index1475 = num4431;
      int num4433 = (int) numArray1242[this.ucScreenLED1.LEDM3 * 3 + 1];
      numArray1481[index1475] = (byte) num4433;
      byte[] numArray1482 = second;
      int num4434 = num4432;
      int num4435 = num4434 + 1;
      int index1476 = num4434;
      int num4436 = (int) numArray1242[this.ucScreenLED1.LEDM3 * 3 + 2];
      numArray1482[index1476] = (byte) num4436;
      byte[] numArray1483 = second;
      int num4437 = num4435;
      int num4438 = num4437 + 1;
      int index1477 = num4437;
      int num4439 = (int) numArray1242[this.ucScreenLED1.LEDM3 * 3];
      numArray1483[index1477] = (byte) num4439;
      byte[] numArray1484 = second;
      int num4440 = num4438;
      int num4441 = num4440 + 1;
      int index1478 = num4440;
      int num4442 = (int) numArray1242[this.ucScreenLED1.LEDM3 * 3 + 1];
      numArray1484[index1478] = (byte) num4442;
      byte[] numArray1485 = second;
      int num4443 = num4441;
      int num4444 = num4443 + 1;
      int index1479 = num4443;
      int num4445 = (int) numArray1242[this.ucScreenLED1.LEDM3 * 3 + 2];
      numArray1485[index1479] = (byte) num4445;
      byte[] numArray1486 = second;
      int num4446 = num4444;
      int num4447 = num4446 + 1;
      int index1480 = num4446;
      int num4448 = (int) numArray1242[this.ucScreenLED1.LEDK3 * 3];
      numArray1486[index1480] = (byte) num4448;
      byte[] numArray1487 = second;
      int num4449 = num4447;
      int num4450 = num4449 + 1;
      int index1481 = num4449;
      int num4451 = (int) numArray1242[this.ucScreenLED1.LEDK3 * 3 + 1];
      numArray1487[index1481] = (byte) num4451;
      byte[] numArray1488 = second;
      int num4452 = num4450;
      int num4453 = num4452 + 1;
      int index1482 = num4452;
      int num4454 = (int) numArray1242[this.ucScreenLED1.LEDK3 * 3 + 2];
      numArray1488[index1482] = (byte) num4454;
      byte[] numArray1489 = second;
      int num4455 = num4453;
      int num4456 = num4455 + 1;
      int index1483 = num4455;
      int num4457 = (int) numArray1242[this.ucScreenLED1.LEDJ3 * 3];
      numArray1489[index1483] = (byte) num4457;
      byte[] numArray1490 = second;
      int num4458 = num4456;
      int num4459 = num4458 + 1;
      int index1484 = num4458;
      int num4460 = (int) numArray1242[this.ucScreenLED1.LEDJ3 * 3 + 1];
      numArray1490[index1484] = (byte) num4460;
      byte[] numArray1491 = second;
      int num4461 = num4459;
      int num4462 = num4461 + 1;
      int index1485 = num4461;
      int num4463 = (int) numArray1242[this.ucScreenLED1.LEDJ3 * 3 + 2];
      numArray1491[index1485] = (byte) num4463;
      byte[] numArray1492 = second;
      int num4464 = num4462;
      int num4465 = num4464 + 1;
      int index1486 = num4464;
      int num4466 = (int) numArray1242[this.ucScreenLED1.LEDI3 * 3];
      numArray1492[index1486] = (byte) num4466;
      byte[] numArray1493 = second;
      int num4467 = num4465;
      int num4468 = num4467 + 1;
      int index1487 = num4467;
      int num4469 = (int) numArray1242[this.ucScreenLED1.LEDI3 * 3 + 1];
      numArray1493[index1487] = (byte) num4469;
      byte[] numArray1494 = second;
      int num4470 = num4468;
      int num4471 = num4470 + 1;
      int index1488 = num4470;
      int num4472 = (int) numArray1242[this.ucScreenLED1.LEDI3 * 3 + 2];
      numArray1494[index1488] = (byte) num4472;
      byte[] numArray1495 = second;
      int num4473 = num4471;
      int num4474 = num4473 + 1;
      int index1489 = num4473;
      int num4475 = (int) numArray1242[this.ucScreenLED1.LEDH3 * 3];
      numArray1495[index1489] = (byte) num4475;
      byte[] numArray1496 = second;
      int num4476 = num4474;
      int num4477 = num4476 + 1;
      int index1490 = num4476;
      int num4478 = (int) numArray1242[this.ucScreenLED1.LEDH3 * 3 + 1];
      numArray1496[index1490] = (byte) num4478;
      byte[] numArray1497 = second;
      int num4479 = num4477;
      int num4480 = num4479 + 1;
      int index1491 = num4479;
      int num4481 = (int) numArray1242[this.ucScreenLED1.LEDH3 * 3 + 2];
      numArray1497[index1491] = (byte) num4481;
      byte[] numArray1498 = second;
      int num4482 = num4480;
      int num4483 = num4482 + 1;
      int index1492 = num4482;
      int num4484 = (int) numArray1242[this.ucScreenLED1.LEDH3 * 3];
      numArray1498[index1492] = (byte) num4484;
      byte[] numArray1499 = second;
      int num4485 = num4483;
      int num4486 = num4485 + 1;
      int index1493 = num4485;
      int num4487 = (int) numArray1242[this.ucScreenLED1.LEDH3 * 3 + 1];
      numArray1499[index1493] = (byte) num4487;
      byte[] numArray1500 = second;
      int num4488 = num4486;
      int num4489 = num4488 + 1;
      int index1494 = num4488;
      int num4490 = (int) numArray1242[this.ucScreenLED1.LEDH3 * 3 + 2];
      numArray1500[index1494] = (byte) num4490;
      byte[] numArray1501 = second;
      int num4491 = num4489;
      int num4492 = num4491 + 1;
      int index1495 = num4491;
      int num4493 = (int) numArray1242[this.ucScreenLED1.LEDG3 * 3];
      numArray1501[index1495] = (byte) num4493;
      byte[] numArray1502 = second;
      int num4494 = num4492;
      int num4495 = num4494 + 1;
      int index1496 = num4494;
      int num4496 = (int) numArray1242[this.ucScreenLED1.LEDG3 * 3 + 1];
      numArray1502[index1496] = (byte) num4496;
      byte[] numArray1503 = second;
      int num4497 = num4495;
      int num4498 = num4497 + 1;
      int index1497 = num4497;
      int num4499 = (int) numArray1242[this.ucScreenLED1.LEDG3 * 3 + 2];
      numArray1503[index1497] = (byte) num4499;
      byte[] numArray1504 = second;
      int num4500 = num4498;
      int num4501 = num4500 + 1;
      int index1498 = num4500;
      int num4502 = (int) numArray1242[this.ucScreenLED1.LEDF3 * 3];
      numArray1504[index1498] = (byte) num4502;
      byte[] numArray1505 = second;
      int num4503 = num4501;
      int num4504 = num4503 + 1;
      int index1499 = num4503;
      int num4505 = (int) numArray1242[this.ucScreenLED1.LEDF3 * 3 + 1];
      numArray1505[index1499] = (byte) num4505;
      byte[] numArray1506 = second;
      int num4506 = num4504;
      int num4507 = num4506 + 1;
      int index1500 = num4506;
      int num4508 = (int) numArray1242[this.ucScreenLED1.LEDF3 * 3 + 2];
      numArray1506[index1500] = (byte) num4508;
      byte[] numArray1507 = second;
      int num4509 = num4507;
      int num4510 = num4509 + 1;
      int index1501 = num4509;
      int num4511 = (int) numArray1242[this.ucScreenLED1.HSD * 3];
      numArray1507[index1501] = (byte) num4511;
      byte[] numArray1508 = second;
      int num4512 = num4510;
      int num4513 = num4512 + 1;
      int index1502 = num4512;
      int num4514 = (int) numArray1242[this.ucScreenLED1.HSD * 3 + 1];
      numArray1508[index1502] = (byte) num4514;
      byte[] numArray1509 = second;
      int num4515 = num4513;
      int num4516 = num4515 + 1;
      int index1503 = num4515;
      int num4517 = (int) numArray1242[this.ucScreenLED1.HSD * 3 + 2];
      numArray1509[index1503] = (byte) num4517;
      byte[] numArray1510 = second;
      int num4518 = num4516;
      int num4519 = num4518 + 1;
      int index1504 = num4518;
      int num4520 = (int) numArray1242[this.ucScreenLED1.HSD * 3];
      numArray1510[index1504] = (byte) num4520;
      byte[] numArray1511 = second;
      int num4521 = num4519;
      int num4522 = num4521 + 1;
      int index1505 = num4521;
      int num4523 = (int) numArray1242[this.ucScreenLED1.HSD * 3 + 1];
      numArray1511[index1505] = (byte) num4523;
      byte[] numArray1512 = second;
      int num4524 = num4522;
      int num4525 = num4524 + 1;
      int index1506 = num4524;
      int num4526 = (int) numArray1242[this.ucScreenLED1.HSD * 3 + 2];
      numArray1512[index1506] = (byte) num4526;
      byte[] numArray1513 = second;
      int num4527 = num4525;
      int num4528 = num4527 + 1;
      int index1507 = num4527;
      int num4529 = (int) numArray1242[this.ucScreenLED1.SSD * 3];
      numArray1513[index1507] = (byte) num4529;
      byte[] numArray1514 = second;
      int num4530 = num4528;
      int num4531 = num4530 + 1;
      int index1508 = num4530;
      int num4532 = (int) numArray1242[this.ucScreenLED1.SSD * 3 + 1];
      numArray1514[index1508] = (byte) num4532;
      byte[] numArray1515 = second;
      int num4533 = num4531;
      int num4534 = num4533 + 1;
      int index1509 = num4533;
      int num4535 = (int) numArray1242[this.ucScreenLED1.SSD * 3 + 2];
      numArray1515[index1509] = (byte) num4535;
      byte[] numArray1516 = second;
      int num4536 = num4534;
      int num4537 = num4536 + 1;
      int index1510 = num4536;
      int num4538 = (int) numArray1242[this.ucScreenLED1.SSD * 3];
      numArray1516[index1510] = (byte) num4538;
      byte[] numArray1517 = second;
      int num4539 = num4537;
      int num4540 = num4539 + 1;
      int index1511 = num4539;
      int num4541 = (int) numArray1242[this.ucScreenLED1.SSD * 3 + 1];
      numArray1517[index1511] = (byte) num4541;
      byte[] numArray1518 = second;
      int num4542 = num4540;
      int num4543 = num4542 + 1;
      int index1512 = num4542;
      int num4544 = (int) numArray1242[this.ucScreenLED1.SSD * 3 + 2];
      numArray1518[index1512] = (byte) num4544;
      byte[] numArray1519 = second;
      int num4545 = num4543;
      int num4546 = num4545 + 1;
      int index1513 = num4545;
      int num4547 = (int) numArray1242[this.ucScreenLED1.Gpu1 * 3];
      numArray1519[index1513] = (byte) num4547;
      byte[] numArray1520 = second;
      int num4548 = num4546;
      int num4549 = num4548 + 1;
      int index1514 = num4548;
      int num4550 = (int) numArray1242[this.ucScreenLED1.Gpu1 * 3 + 1];
      numArray1520[index1514] = (byte) num4550;
      byte[] numArray1521 = second;
      int num4551 = num4549;
      int num4552 = num4551 + 1;
      int index1515 = num4551;
      int num4553 = (int) numArray1242[this.ucScreenLED1.Gpu1 * 3 + 2];
      numArray1521[index1515] = (byte) num4553;
      byte[] numArray1522 = second;
      int num4554 = num4552;
      int num4555 = num4554 + 1;
      int index1516 = num4554;
      int num4556 = (int) numArray1242[this.ucScreenLED1.Gpu1 * 3];
      numArray1522[index1516] = (byte) num4556;
      byte[] numArray1523 = second;
      int num4557 = num4555;
      int num4558 = num4557 + 1;
      int index1517 = num4557;
      int num4559 = (int) numArray1242[this.ucScreenLED1.Gpu1 * 3 + 1];
      numArray1523[index1517] = (byte) num4559;
      byte[] numArray1524 = second;
      int num4560 = num4558;
      int num4561 = num4560 + 1;
      int index1518 = num4560;
      int num4562 = (int) numArray1242[this.ucScreenLED1.Gpu1 * 3 + 2];
      numArray1524[index1518] = (byte) num4562;
      byte[] numArray1525 = second;
      int num4563 = num4561;
      int num4564 = num4563 + 1;
      int index1519 = num4563;
      int num4565 = (int) numArray1242[this.ucScreenLED1.LEDL4 * 3];
      numArray1525[index1519] = (byte) num4565;
      byte[] numArray1526 = second;
      int num4566 = num4564;
      int num4567 = num4566 + 1;
      int index1520 = num4566;
      int num4568 = (int) numArray1242[this.ucScreenLED1.LEDL4 * 3 + 1];
      numArray1526[index1520] = (byte) num4568;
      byte[] numArray1527 = second;
      int num4569 = num4567;
      int num4570 = num4569 + 1;
      int index1521 = num4569;
      int num4571 = (int) numArray1242[this.ucScreenLED1.LEDL4 * 3 + 2];
      numArray1527[index1521] = (byte) num4571;
      byte[] numArray1528 = second;
      int num4572 = num4570;
      int num4573 = num4572 + 1;
      int index1522 = num4572;
      int num4574 = (int) numArray1242[this.ucScreenLED1.LEDA4 * 3];
      numArray1528[index1522] = (byte) num4574;
      byte[] numArray1529 = second;
      int num4575 = num4573;
      int num4576 = num4575 + 1;
      int index1523 = num4575;
      int num4577 = (int) numArray1242[this.ucScreenLED1.LEDA4 * 3 + 1];
      numArray1529[index1523] = (byte) num4577;
      byte[] numArray1530 = second;
      int num4578 = num4576;
      int num4579 = num4578 + 1;
      int index1524 = num4578;
      int num4580 = (int) numArray1242[this.ucScreenLED1.LEDA4 * 3 + 2];
      numArray1530[index1524] = (byte) num4580;
      byte[] numArray1531 = second;
      int num4581 = num4579;
      int num4582 = num4581 + 1;
      int index1525 = num4581;
      int num4583 = (int) numArray1242[this.ucScreenLED1.LEDB4 * 3];
      numArray1531[index1525] = (byte) num4583;
      byte[] numArray1532 = second;
      int num4584 = num4582;
      int num4585 = num4584 + 1;
      int index1526 = num4584;
      int num4586 = (int) numArray1242[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray1532[index1526] = (byte) num4586;
      byte[] numArray1533 = second;
      int num4587 = num4585;
      int num4588 = num4587 + 1;
      int index1527 = num4587;
      int num4589 = (int) numArray1242[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray1533[index1527] = (byte) num4589;
      byte[] numArray1534 = second;
      int num4590 = num4588;
      int num4591 = num4590 + 1;
      int index1528 = num4590;
      int num4592 = (int) numArray1242[this.ucScreenLED1.LEDB4 * 3];
      numArray1534[index1528] = (byte) num4592;
      byte[] numArray1535 = second;
      int num4593 = num4591;
      int num4594 = num4593 + 1;
      int index1529 = num4593;
      int num4595 = (int) numArray1242[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray1535[index1529] = (byte) num4595;
      byte[] numArray1536 = second;
      int num4596 = num4594;
      int num4597 = num4596 + 1;
      int index1530 = num4596;
      int num4598 = (int) numArray1242[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray1536[index1530] = (byte) num4598;
      byte[] numArray1537 = second;
      int num4599 = num4597;
      int num4600 = num4599 + 1;
      int index1531 = num4599;
      int num4601 = (int) numArray1242[this.ucScreenLED1.LEDC4 * 3];
      numArray1537[index1531] = (byte) num4601;
      byte[] numArray1538 = second;
      int num4602 = num4600;
      int num4603 = num4602 + 1;
      int index1532 = num4602;
      int num4604 = (int) numArray1242[this.ucScreenLED1.LEDC4 * 3 + 1];
      numArray1538[index1532] = (byte) num4604;
      byte[] numArray1539 = second;
      int num4605 = num4603;
      int num4606 = num4605 + 1;
      int index1533 = num4605;
      int num4607 = (int) numArray1242[this.ucScreenLED1.LEDC4 * 3 + 2];
      numArray1539[index1533] = (byte) num4607;
      byte[] numArray1540 = second;
      int num4608 = num4606;
      int num4609 = num4608 + 1;
      int index1534 = num4608;
      int num4610 = (int) numArray1242[this.ucScreenLED1.LEDD4 * 3];
      numArray1540[index1534] = (byte) num4610;
      byte[] numArray1541 = second;
      int num4611 = num4609;
      int num4612 = num4611 + 1;
      int index1535 = num4611;
      int num4613 = (int) numArray1242[this.ucScreenLED1.LEDD4 * 3 + 1];
      numArray1541[index1535] = (byte) num4613;
      byte[] numArray1542 = second;
      int num4614 = num4612;
      int num4615 = num4614 + 1;
      int index1536 = num4614;
      int num4616 = (int) numArray1242[this.ucScreenLED1.LEDD4 * 3 + 2];
      numArray1542[index1536] = (byte) num4616;
      byte[] numArray1543 = second;
      int num4617 = num4615;
      int num4618 = num4617 + 1;
      int index1537 = num4617;
      int num4619 = (int) numArray1242[this.ucScreenLED1.LEDE4 * 3];
      numArray1543[index1537] = (byte) num4619;
      byte[] numArray1544 = second;
      int num4620 = num4618;
      int num4621 = num4620 + 1;
      int index1538 = num4620;
      int num4622 = (int) numArray1242[this.ucScreenLED1.LEDE4 * 3 + 1];
      numArray1544[index1538] = (byte) num4622;
      byte[] numArray1545 = second;
      int num4623 = num4621;
      int num4624 = num4623 + 1;
      int index1539 = num4623;
      int num4625 = (int) numArray1242[this.ucScreenLED1.LEDE4 * 3 + 2];
      numArray1545[index1539] = (byte) num4625;
      byte[] numArray1546 = second;
      int num4626 = num4624;
      int num4627 = num4626 + 1;
      int index1540 = num4626;
      int num4628 = (int) numArray1242[this.ucScreenLED1.LEDM4 * 3];
      numArray1546[index1540] = (byte) num4628;
      byte[] numArray1547 = second;
      int num4629 = num4627;
      int num4630 = num4629 + 1;
      int index1541 = num4629;
      int num4631 = (int) numArray1242[this.ucScreenLED1.LEDM4 * 3 + 1];
      numArray1547[index1541] = (byte) num4631;
      byte[] numArray1548 = second;
      int num4632 = num4630;
      int num4633 = num4632 + 1;
      int index1542 = num4632;
      int num4634 = (int) numArray1242[this.ucScreenLED1.LEDM4 * 3 + 2];
      numArray1548[index1542] = (byte) num4634;
      byte[] numArray1549 = second;
      int num4635 = num4633;
      int num4636 = num4635 + 1;
      int index1543 = num4635;
      int num4637 = (int) numArray1242[this.ucScreenLED1.LEDM4 * 3];
      numArray1549[index1543] = (byte) num4637;
      byte[] numArray1550 = second;
      int num4638 = num4636;
      int num4639 = num4638 + 1;
      int index1544 = num4638;
      int num4640 = (int) numArray1242[this.ucScreenLED1.LEDM4 * 3 + 1];
      numArray1550[index1544] = (byte) num4640;
      byte[] numArray1551 = second;
      int num4641 = num4639;
      int num4642 = num4641 + 1;
      int index1545 = num4641;
      int num4643 = (int) numArray1242[this.ucScreenLED1.LEDM4 * 3 + 2];
      numArray1551[index1545] = (byte) num4643;
      byte[] numArray1552 = second;
      int num4644 = num4642;
      int num4645 = num4644 + 1;
      int index1546 = num4644;
      int num4646 = (int) numArray1242[this.ucScreenLED1.LEDK4 * 3];
      numArray1552[index1546] = (byte) num4646;
      byte[] numArray1553 = second;
      int num4647 = num4645;
      int num4648 = num4647 + 1;
      int index1547 = num4647;
      int num4649 = (int) numArray1242[this.ucScreenLED1.LEDK4 * 3 + 1];
      numArray1553[index1547] = (byte) num4649;
      byte[] numArray1554 = second;
      int num4650 = num4648;
      int num4651 = num4650 + 1;
      int index1548 = num4650;
      int num4652 = (int) numArray1242[this.ucScreenLED1.LEDK4 * 3 + 2];
      numArray1554[index1548] = (byte) num4652;
      byte[] numArray1555 = second;
      int num4653 = num4651;
      int num4654 = num4653 + 1;
      int index1549 = num4653;
      int num4655 = (int) numArray1242[this.ucScreenLED1.LEDJ4 * 3];
      numArray1555[index1549] = (byte) num4655;
      byte[] numArray1556 = second;
      int num4656 = num4654;
      int num4657 = num4656 + 1;
      int index1550 = num4656;
      int num4658 = (int) numArray1242[this.ucScreenLED1.LEDJ4 * 3 + 1];
      numArray1556[index1550] = (byte) num4658;
      byte[] numArray1557 = second;
      int num4659 = num4657;
      int num4660 = num4659 + 1;
      int index1551 = num4659;
      int num4661 = (int) numArray1242[this.ucScreenLED1.LEDJ4 * 3 + 2];
      numArray1557[index1551] = (byte) num4661;
      byte[] numArray1558 = second;
      int num4662 = num4660;
      int num4663 = num4662 + 1;
      int index1552 = num4662;
      int num4664 = (int) numArray1242[this.ucScreenLED1.LEDI4 * 3];
      numArray1558[index1552] = (byte) num4664;
      byte[] numArray1559 = second;
      int num4665 = num4663;
      int num4666 = num4665 + 1;
      int index1553 = num4665;
      int num4667 = (int) numArray1242[this.ucScreenLED1.LEDI4 * 3 + 1];
      numArray1559[index1553] = (byte) num4667;
      byte[] numArray1560 = second;
      int num4668 = num4666;
      int num4669 = num4668 + 1;
      int index1554 = num4668;
      int num4670 = (int) numArray1242[this.ucScreenLED1.LEDI4 * 3 + 2];
      numArray1560[index1554] = (byte) num4670;
      byte[] numArray1561 = second;
      int num4671 = num4669;
      int num4672 = num4671 + 1;
      int index1555 = num4671;
      int num4673 = (int) numArray1242[this.ucScreenLED1.LEDH4 * 3];
      numArray1561[index1555] = (byte) num4673;
      byte[] numArray1562 = second;
      int num4674 = num4672;
      int num4675 = num4674 + 1;
      int index1556 = num4674;
      int num4676 = (int) numArray1242[this.ucScreenLED1.LEDH4 * 3 + 1];
      numArray1562[index1556] = (byte) num4676;
      byte[] numArray1563 = second;
      int num4677 = num4675;
      int num4678 = num4677 + 1;
      int index1557 = num4677;
      int num4679 = (int) numArray1242[this.ucScreenLED1.LEDH4 * 3 + 2];
      numArray1563[index1557] = (byte) num4679;
      byte[] numArray1564 = second;
      int num4680 = num4678;
      int num4681 = num4680 + 1;
      int index1558 = num4680;
      int num4682 = (int) numArray1242[this.ucScreenLED1.LEDH4 * 3];
      numArray1564[index1558] = (byte) num4682;
      byte[] numArray1565 = second;
      int num4683 = num4681;
      int num4684 = num4683 + 1;
      int index1559 = num4683;
      int num4685 = (int) numArray1242[this.ucScreenLED1.LEDH4 * 3 + 1];
      numArray1565[index1559] = (byte) num4685;
      byte[] numArray1566 = second;
      int num4686 = num4684;
      int num4687 = num4686 + 1;
      int index1560 = num4686;
      int num4688 = (int) numArray1242[this.ucScreenLED1.LEDH4 * 3 + 2];
      numArray1566[index1560] = (byte) num4688;
      byte[] numArray1567 = second;
      int num4689 = num4687;
      int num4690 = num4689 + 1;
      int index1561 = num4689;
      int num4691 = (int) numArray1242[this.ucScreenLED1.LEDG4 * 3];
      numArray1567[index1561] = (byte) num4691;
      byte[] numArray1568 = second;
      int num4692 = num4690;
      int num4693 = num4692 + 1;
      int index1562 = num4692;
      int num4694 = (int) numArray1242[this.ucScreenLED1.LEDG4 * 3 + 1];
      numArray1568[index1562] = (byte) num4694;
      byte[] numArray1569 = second;
      int num4695 = num4693;
      int num4696 = num4695 + 1;
      int index1563 = num4695;
      int num4697 = (int) numArray1242[this.ucScreenLED1.LEDG4 * 3 + 2];
      numArray1569[index1563] = (byte) num4697;
      byte[] numArray1570 = second;
      int num4698 = num4696;
      int num4699 = num4698 + 1;
      int index1564 = num4698;
      int num4700 = (int) numArray1242[this.ucScreenLED1.LEDF4 * 3];
      numArray1570[index1564] = (byte) num4700;
      byte[] numArray1571 = second;
      int num4701 = num4699;
      int num4702 = num4701 + 1;
      int index1565 = num4701;
      int num4703 = (int) numArray1242[this.ucScreenLED1.LEDF4 * 3 + 1];
      numArray1571[index1565] = (byte) num4703;
      byte[] numArray1572 = second;
      int num4704 = num4702;
      int num4705 = num4704 + 1;
      int index1566 = num4704;
      int num4706 = (int) numArray1242[this.ucScreenLED1.LEDF4 * 3 + 2];
      numArray1572[index1566] = (byte) num4706;
      byte[] numArray1573 = second;
      int num4707 = num4705;
      int num4708 = num4707 + 1;
      int index1567 = num4707;
      int num4709 = (int) numArray1242[this.ucScreenLED1.LEDJ5 * 3];
      numArray1573[index1567] = (byte) num4709;
      byte[] numArray1574 = second;
      int num4710 = num4708;
      int num4711 = num4710 + 1;
      int index1568 = num4710;
      int num4712 = (int) numArray1242[this.ucScreenLED1.LEDJ5 * 3 + 1];
      numArray1574[index1568] = (byte) num4712;
      byte[] numArray1575 = second;
      int num4713 = num4711;
      int num4714 = num4713 + 1;
      int index1569 = num4713;
      int num4715 = (int) numArray1242[this.ucScreenLED1.LEDJ5 * 3 + 2];
      numArray1575[index1569] = (byte) num4715;
      byte[] numArray1576 = second;
      int num4716 = num4714;
      int num4717 = num4716 + 1;
      int index1570 = num4716;
      int num4718 = (int) numArray1242[this.ucScreenLED1.LEDI5 * 3];
      numArray1576[index1570] = (byte) num4718;
      byte[] numArray1577 = second;
      int num4719 = num4717;
      int num4720 = num4719 + 1;
      int index1571 = num4719;
      int num4721 = (int) numArray1242[this.ucScreenLED1.LEDI5 * 3 + 1];
      numArray1577[index1571] = (byte) num4721;
      byte[] numArray1578 = second;
      int num4722 = num4720;
      int num4723 = num4722 + 1;
      int index1572 = num4722;
      int num4724 = (int) numArray1242[this.ucScreenLED1.LEDI5 * 3 + 2];
      numArray1578[index1572] = (byte) num4724;
      byte[] numArray1579 = second;
      int num4725 = num4723;
      int num4726 = num4725 + 1;
      int index1573 = num4725;
      int num4727 = (int) numArray1242[this.ucScreenLED1.LEDH5 * 3];
      numArray1579[index1573] = (byte) num4727;
      byte[] numArray1580 = second;
      int num4728 = num4726;
      int num4729 = num4728 + 1;
      int index1574 = num4728;
      int num4730 = (int) numArray1242[this.ucScreenLED1.LEDH5 * 3 + 1];
      numArray1580[index1574] = (byte) num4730;
      byte[] numArray1581 = second;
      int num4731 = num4729;
      int num4732 = num4731 + 1;
      int index1575 = num4731;
      int num4733 = (int) numArray1242[this.ucScreenLED1.LEDH5 * 3 + 2];
      numArray1581[index1575] = (byte) num4733;
      byte[] numArray1582 = second;
      int num4734 = num4732;
      int num4735 = num4734 + 1;
      int index1576 = num4734;
      int num4736 = (int) numArray1242[this.ucScreenLED1.LEDH5 * 3];
      numArray1582[index1576] = (byte) num4736;
      byte[] numArray1583 = second;
      int num4737 = num4735;
      int num4738 = num4737 + 1;
      int index1577 = num4737;
      int num4739 = (int) numArray1242[this.ucScreenLED1.LEDH5 * 3 + 1];
      numArray1583[index1577] = (byte) num4739;
      byte[] numArray1584 = second;
      int num4740 = num4738;
      int num4741 = num4740 + 1;
      int index1578 = num4740;
      int num4742 = (int) numArray1242[this.ucScreenLED1.LEDH5 * 3 + 2];
      numArray1584[index1578] = (byte) num4742;
      byte[] numArray1585 = second;
      int num4743 = num4741;
      int num4744 = num4743 + 1;
      int index1579 = num4743;
      int num4745 = (int) numArray1242[this.ucScreenLED1.LEDG5 * 3];
      numArray1585[index1579] = (byte) num4745;
      byte[] numArray1586 = second;
      int num4746 = num4744;
      int num4747 = num4746 + 1;
      int index1580 = num4746;
      int num4748 = (int) numArray1242[this.ucScreenLED1.LEDG5 * 3 + 1];
      numArray1586[index1580] = (byte) num4748;
      byte[] numArray1587 = second;
      int num4749 = num4747;
      int num4750 = num4749 + 1;
      int index1581 = num4749;
      int num4751 = (int) numArray1242[this.ucScreenLED1.LEDG5 * 3 + 2];
      numArray1587[index1581] = (byte) num4751;
      byte[] numArray1588 = second;
      int num4752 = num4750;
      int num4753 = num4752 + 1;
      int index1582 = num4752;
      int num4754 = (int) numArray1242[this.ucScreenLED1.LEDF5 * 3];
      numArray1588[index1582] = (byte) num4754;
      byte[] numArray1589 = second;
      int num4755 = num4753;
      int num4756 = num4755 + 1;
      int index1583 = num4755;
      int num4757 = (int) numArray1242[this.ucScreenLED1.LEDF5 * 3 + 1];
      numArray1589[index1583] = (byte) num4757;
      byte[] numArray1590 = second;
      int num4758 = num4756;
      int num4759 = num4758 + 1;
      int index1584 = num4758;
      int num4760 = (int) numArray1242[this.ucScreenLED1.LEDF5 * 3 + 2];
      numArray1590[index1584] = (byte) num4760;
      byte[] numArray1591 = second;
      int num4761 = num4759;
      int num4762 = num4761 + 1;
      int index1585 = num4761;
      int num4763 = (int) numArray1242[this.ucScreenLED1.LEDE5 * 3];
      numArray1591[index1585] = (byte) num4763;
      byte[] numArray1592 = second;
      int num4764 = num4762;
      int num4765 = num4764 + 1;
      int index1586 = num4764;
      int num4766 = (int) numArray1242[this.ucScreenLED1.LEDE5 * 3 + 1];
      numArray1592[index1586] = (byte) num4766;
      byte[] numArray1593 = second;
      int num4767 = num4765;
      int num4768 = num4767 + 1;
      int index1587 = num4767;
      int num4769 = (int) numArray1242[this.ucScreenLED1.LEDE5 * 3 + 2];
      numArray1593[index1587] = (byte) num4769;
      byte[] numArray1594 = second;
      int num4770 = num4768;
      int num4771 = num4770 + 1;
      int index1588 = num4770;
      int num4772 = (int) numArray1242[this.ucScreenLED1.LEDM5 * 3];
      numArray1594[index1588] = (byte) num4772;
      byte[] numArray1595 = second;
      int num4773 = num4771;
      int num4774 = num4773 + 1;
      int index1589 = num4773;
      int num4775 = (int) numArray1242[this.ucScreenLED1.LEDM5 * 3 + 1];
      numArray1595[index1589] = (byte) num4775;
      byte[] numArray1596 = second;
      int num4776 = num4774;
      int num4777 = num4776 + 1;
      int index1590 = num4776;
      int num4778 = (int) numArray1242[this.ucScreenLED1.LEDM5 * 3 + 2];
      numArray1596[index1590] = (byte) num4778;
      byte[] numArray1597 = second;
      int num4779 = num4777;
      int num4780 = num4779 + 1;
      int index1591 = num4779;
      int num4781 = (int) numArray1242[this.ucScreenLED1.LEDM5 * 3];
      numArray1597[index1591] = (byte) num4781;
      byte[] numArray1598 = second;
      int num4782 = num4780;
      int num4783 = num4782 + 1;
      int index1592 = num4782;
      int num4784 = (int) numArray1242[this.ucScreenLED1.LEDM5 * 3 + 1];
      numArray1598[index1592] = (byte) num4784;
      byte[] numArray1599 = second;
      int num4785 = num4783;
      int num4786 = num4785 + 1;
      int index1593 = num4785;
      int num4787 = (int) numArray1242[this.ucScreenLED1.LEDM5 * 3 + 2];
      numArray1599[index1593] = (byte) num4787;
      byte[] numArray1600 = second;
      int num4788 = num4786;
      int num4789 = num4788 + 1;
      int index1594 = num4788;
      int num4790 = (int) numArray1242[this.ucScreenLED1.LEDK5 * 3];
      numArray1600[index1594] = (byte) num4790;
      byte[] numArray1601 = second;
      int num4791 = num4789;
      int num4792 = num4791 + 1;
      int index1595 = num4791;
      int num4793 = (int) numArray1242[this.ucScreenLED1.LEDK5 * 3 + 1];
      numArray1601[index1595] = (byte) num4793;
      byte[] numArray1602 = second;
      int num4794 = num4792;
      int num4795 = num4794 + 1;
      int index1596 = num4794;
      int num4796 = (int) numArray1242[this.ucScreenLED1.LEDK5 * 3 + 2];
      numArray1602[index1596] = (byte) num4796;
      byte[] numArray1603 = second;
      int num4797 = num4795;
      int num4798 = num4797 + 1;
      int index1597 = num4797;
      int num4799 = (int) numArray1242[this.ucScreenLED1.LEDL5 * 3];
      numArray1603[index1597] = (byte) num4799;
      byte[] numArray1604 = second;
      int num4800 = num4798;
      int num4801 = num4800 + 1;
      int index1598 = num4800;
      int num4802 = (int) numArray1242[this.ucScreenLED1.LEDL5 * 3 + 1];
      numArray1604[index1598] = (byte) num4802;
      byte[] numArray1605 = second;
      int num4803 = num4801;
      int num4804 = num4803 + 1;
      int index1599 = num4803;
      int num4805 = (int) numArray1242[this.ucScreenLED1.LEDL5 * 3 + 2];
      numArray1605[index1599] = (byte) num4805;
      byte[] numArray1606 = second;
      int num4806 = num4804;
      int num4807 = num4806 + 1;
      int index1600 = num4806;
      int num4808 = (int) numArray1242[this.ucScreenLED1.LEDA5 * 3];
      numArray1606[index1600] = (byte) num4808;
      byte[] numArray1607 = second;
      int num4809 = num4807;
      int num4810 = num4809 + 1;
      int index1601 = num4809;
      int num4811 = (int) numArray1242[this.ucScreenLED1.LEDA5 * 3 + 1];
      numArray1607[index1601] = (byte) num4811;
      byte[] numArray1608 = second;
      int num4812 = num4810;
      int num4813 = num4812 + 1;
      int index1602 = num4812;
      int num4814 = (int) numArray1242[this.ucScreenLED1.LEDA5 * 3 + 2];
      numArray1608[index1602] = (byte) num4814;
      byte[] numArray1609 = second;
      int num4815 = num4813;
      int num4816 = num4815 + 1;
      int index1603 = num4815;
      int num4817 = (int) numArray1242[this.ucScreenLED1.LEDB5 * 3];
      numArray1609[index1603] = (byte) num4817;
      byte[] numArray1610 = second;
      int num4818 = num4816;
      int num4819 = num4818 + 1;
      int index1604 = num4818;
      int num4820 = (int) numArray1242[this.ucScreenLED1.LEDB5 * 3 + 1];
      numArray1610[index1604] = (byte) num4820;
      byte[] numArray1611 = second;
      int num4821 = num4819;
      int num4822 = num4821 + 1;
      int index1605 = num4821;
      int num4823 = (int) numArray1242[this.ucScreenLED1.LEDB5 * 3 + 2];
      numArray1611[index1605] = (byte) num4823;
      byte[] numArray1612 = second;
      int num4824 = num4822;
      int num4825 = num4824 + 1;
      int index1606 = num4824;
      int num4826 = (int) numArray1242[this.ucScreenLED1.LEDB5 * 3];
      numArray1612[index1606] = (byte) num4826;
      byte[] numArray1613 = second;
      int num4827 = num4825;
      int num4828 = num4827 + 1;
      int index1607 = num4827;
      int num4829 = (int) numArray1242[this.ucScreenLED1.LEDB5 * 3 + 1];
      numArray1613[index1607] = (byte) num4829;
      byte[] numArray1614 = second;
      int num4830 = num4828;
      int num4831 = num4830 + 1;
      int index1608 = num4830;
      int num4832 = (int) numArray1242[this.ucScreenLED1.LEDB5 * 3 + 2];
      numArray1614[index1608] = (byte) num4832;
      byte[] numArray1615 = second;
      int num4833 = num4831;
      int num4834 = num4833 + 1;
      int index1609 = num4833;
      int num4835 = (int) numArray1242[this.ucScreenLED1.LEDC5 * 3];
      numArray1615[index1609] = (byte) num4835;
      byte[] numArray1616 = second;
      int num4836 = num4834;
      int num4837 = num4836 + 1;
      int index1610 = num4836;
      int num4838 = (int) numArray1242[this.ucScreenLED1.LEDC5 * 3 + 1];
      numArray1616[index1610] = (byte) num4838;
      byte[] numArray1617 = second;
      int num4839 = num4837;
      int num4840 = num4839 + 1;
      int index1611 = num4839;
      int num4841 = (int) numArray1242[this.ucScreenLED1.LEDC5 * 3 + 2];
      numArray1617[index1611] = (byte) num4841;
      byte[] numArray1618 = second;
      int num4842 = num4840;
      int num4843 = num4842 + 1;
      int index1612 = num4842;
      int num4844 = (int) numArray1242[this.ucScreenLED1.LEDD5 * 3];
      numArray1618[index1612] = (byte) num4844;
      byte[] numArray1619 = second;
      int num4845 = num4843;
      int num4846 = num4845 + 1;
      int index1613 = num4845;
      int num4847 = (int) numArray1242[this.ucScreenLED1.LEDD5 * 3 + 1];
      numArray1619[index1613] = (byte) num4847;
      byte[] numArray1620 = second;
      int num4848 = num4846;
      int num4849 = num4848 + 1;
      int index1614 = num4848;
      int num4850 = (int) numArray1242[this.ucScreenLED1.LEDD5 * 3 + 2];
      numArray1620[index1614] = (byte) num4850;
      byte[] numArray1621 = second;
      int num4851 = num4849;
      int num4852 = num4851 + 1;
      int index1615 = num4851;
      int num4853 = (int) numArray1242[this.ucScreenLED1.LEDL6 * 3];
      numArray1621[index1615] = (byte) num4853;
      byte[] numArray1622 = second;
      int num4854 = num4852;
      int num4855 = num4854 + 1;
      int index1616 = num4854;
      int num4856 = (int) numArray1242[this.ucScreenLED1.LEDL6 * 3 + 1];
      numArray1622[index1616] = (byte) num4856;
      byte[] numArray1623 = second;
      int num4857 = num4855;
      int num4858 = num4857 + 1;
      int index1617 = num4857;
      int num4859 = (int) numArray1242[this.ucScreenLED1.LEDL6 * 3 + 2];
      numArray1623[index1617] = (byte) num4859;
      byte[] numArray1624 = second;
      int num4860 = num4858;
      int num4861 = num4860 + 1;
      int index1618 = num4860;
      int num4862 = (int) numArray1242[this.ucScreenLED1.LEDA6 * 3];
      numArray1624[index1618] = (byte) num4862;
      byte[] numArray1625 = second;
      int num4863 = num4861;
      int num4864 = num4863 + 1;
      int index1619 = num4863;
      int num4865 = (int) numArray1242[this.ucScreenLED1.LEDA6 * 3 + 1];
      numArray1625[index1619] = (byte) num4865;
      byte[] numArray1626 = second;
      int num4866 = num4864;
      int num4867 = num4866 + 1;
      int index1620 = num4866;
      int num4868 = (int) numArray1242[this.ucScreenLED1.LEDA6 * 3 + 2];
      numArray1626[index1620] = (byte) num4868;
      byte[] numArray1627 = second;
      int num4869 = num4867;
      int num4870 = num4869 + 1;
      int index1621 = num4869;
      int num4871 = (int) numArray1242[this.ucScreenLED1.LEDB6 * 3];
      numArray1627[index1621] = (byte) num4871;
      byte[] numArray1628 = second;
      int num4872 = num4870;
      int num4873 = num4872 + 1;
      int index1622 = num4872;
      int num4874 = (int) numArray1242[this.ucScreenLED1.LEDB6 * 3 + 1];
      numArray1628[index1622] = (byte) num4874;
      byte[] numArray1629 = second;
      int num4875 = num4873;
      int num4876 = num4875 + 1;
      int index1623 = num4875;
      int num4877 = (int) numArray1242[this.ucScreenLED1.LEDB6 * 3 + 2];
      numArray1629[index1623] = (byte) num4877;
      byte[] numArray1630 = second;
      int num4878 = num4876;
      int num4879 = num4878 + 1;
      int index1624 = num4878;
      int num4880 = (int) numArray1242[this.ucScreenLED1.LEDB6 * 3];
      numArray1630[index1624] = (byte) num4880;
      byte[] numArray1631 = second;
      int num4881 = num4879;
      int num4882 = num4881 + 1;
      int index1625 = num4881;
      int num4883 = (int) numArray1242[this.ucScreenLED1.LEDB6 * 3 + 1];
      numArray1631[index1625] = (byte) num4883;
      byte[] numArray1632 = second;
      int num4884 = num4882;
      int num4885 = num4884 + 1;
      int index1626 = num4884;
      int num4886 = (int) numArray1242[this.ucScreenLED1.LEDB6 * 3 + 2];
      numArray1632[index1626] = (byte) num4886;
      byte[] numArray1633 = second;
      int num4887 = num4885;
      int num4888 = num4887 + 1;
      int index1627 = num4887;
      int num4889 = (int) numArray1242[this.ucScreenLED1.LEDC6 * 3];
      numArray1633[index1627] = (byte) num4889;
      byte[] numArray1634 = second;
      int num4890 = num4888;
      int num4891 = num4890 + 1;
      int index1628 = num4890;
      int num4892 = (int) numArray1242[this.ucScreenLED1.LEDC6 * 3 + 1];
      numArray1634[index1628] = (byte) num4892;
      byte[] numArray1635 = second;
      int num4893 = num4891;
      int num4894 = num4893 + 1;
      int index1629 = num4893;
      int num4895 = (int) numArray1242[this.ucScreenLED1.LEDC6 * 3 + 2];
      numArray1635[index1629] = (byte) num4895;
      byte[] numArray1636 = second;
      int num4896 = num4894;
      int num4897 = num4896 + 1;
      int index1630 = num4896;
      int num4898 = (int) numArray1242[this.ucScreenLED1.LEDD6 * 3];
      numArray1636[index1630] = (byte) num4898;
      byte[] numArray1637 = second;
      int num4899 = num4897;
      int num4900 = num4899 + 1;
      int index1631 = num4899;
      int num4901 = (int) numArray1242[this.ucScreenLED1.LEDD6 * 3 + 1];
      numArray1637[index1631] = (byte) num4901;
      byte[] numArray1638 = second;
      int num4902 = num4900;
      int num4903 = num4902 + 1;
      int index1632 = num4902;
      int num4904 = (int) numArray1242[this.ucScreenLED1.LEDD6 * 3 + 2];
      numArray1638[index1632] = (byte) num4904;
      byte[] numArray1639 = second;
      int num4905 = num4903;
      int num4906 = num4905 + 1;
      int index1633 = num4905;
      int num4907 = (int) numArray1242[this.ucScreenLED1.LEDE6 * 3];
      numArray1639[index1633] = (byte) num4907;
      byte[] numArray1640 = second;
      int num4908 = num4906;
      int num4909 = num4908 + 1;
      int index1634 = num4908;
      int num4910 = (int) numArray1242[this.ucScreenLED1.LEDE6 * 3 + 1];
      numArray1640[index1634] = (byte) num4910;
      byte[] numArray1641 = second;
      int num4911 = num4909;
      int num4912 = num4911 + 1;
      int index1635 = num4911;
      int num4913 = (int) numArray1242[this.ucScreenLED1.LEDE6 * 3 + 2];
      numArray1641[index1635] = (byte) num4913;
      byte[] numArray1642 = second;
      int num4914 = num4912;
      int num4915 = num4914 + 1;
      int index1636 = num4914;
      int num4916 = (int) numArray1242[this.ucScreenLED1.LEDM6 * 3];
      numArray1642[index1636] = (byte) num4916;
      byte[] numArray1643 = second;
      int num4917 = num4915;
      int num4918 = num4917 + 1;
      int index1637 = num4917;
      int num4919 = (int) numArray1242[this.ucScreenLED1.LEDM6 * 3 + 1];
      numArray1643[index1637] = (byte) num4919;
      byte[] numArray1644 = second;
      int num4920 = num4918;
      int num4921 = num4920 + 1;
      int index1638 = num4920;
      int num4922 = (int) numArray1242[this.ucScreenLED1.LEDM6 * 3 + 2];
      numArray1644[index1638] = (byte) num4922;
      byte[] numArray1645 = second;
      int num4923 = num4921;
      int num4924 = num4923 + 1;
      int index1639 = num4923;
      int num4925 = (int) numArray1242[this.ucScreenLED1.LEDM6 * 3];
      numArray1645[index1639] = (byte) num4925;
      byte[] numArray1646 = second;
      int num4926 = num4924;
      int num4927 = num4926 + 1;
      int index1640 = num4926;
      int num4928 = (int) numArray1242[this.ucScreenLED1.LEDM6 * 3 + 1];
      numArray1646[index1640] = (byte) num4928;
      byte[] numArray1647 = second;
      int num4929 = num4927;
      int num4930 = num4929 + 1;
      int index1641 = num4929;
      int num4931 = (int) numArray1242[this.ucScreenLED1.LEDM6 * 3 + 2];
      numArray1647[index1641] = (byte) num4931;
      byte[] numArray1648 = second;
      int num4932 = num4930;
      int num4933 = num4932 + 1;
      int index1642 = num4932;
      int num4934 = (int) numArray1242[this.ucScreenLED1.LEDK6 * 3];
      numArray1648[index1642] = (byte) num4934;
      byte[] numArray1649 = second;
      int num4935 = num4933;
      int num4936 = num4935 + 1;
      int index1643 = num4935;
      int num4937 = (int) numArray1242[this.ucScreenLED1.LEDK6 * 3 + 1];
      numArray1649[index1643] = (byte) num4937;
      byte[] numArray1650 = second;
      int num4938 = num4936;
      int num4939 = num4938 + 1;
      int index1644 = num4938;
      int num4940 = (int) numArray1242[this.ucScreenLED1.LEDK6 * 3 + 2];
      numArray1650[index1644] = (byte) num4940;
      byte[] numArray1651 = second;
      int num4941 = num4939;
      int num4942 = num4941 + 1;
      int index1645 = num4941;
      int num4943 = (int) numArray1242[this.ucScreenLED1.LEDJ6 * 3];
      numArray1651[index1645] = (byte) num4943;
      byte[] numArray1652 = second;
      int num4944 = num4942;
      int num4945 = num4944 + 1;
      int index1646 = num4944;
      int num4946 = (int) numArray1242[this.ucScreenLED1.LEDJ6 * 3 + 1];
      numArray1652[index1646] = (byte) num4946;
      byte[] numArray1653 = second;
      int num4947 = num4945;
      int num4948 = num4947 + 1;
      int index1647 = num4947;
      int num4949 = (int) numArray1242[this.ucScreenLED1.LEDJ6 * 3 + 2];
      numArray1653[index1647] = (byte) num4949;
      byte[] numArray1654 = second;
      int num4950 = num4948;
      int num4951 = num4950 + 1;
      int index1648 = num4950;
      int num4952 = (int) numArray1242[this.ucScreenLED1.LEDI6 * 3];
      numArray1654[index1648] = (byte) num4952;
      byte[] numArray1655 = second;
      int num4953 = num4951;
      int num4954 = num4953 + 1;
      int index1649 = num4953;
      int num4955 = (int) numArray1242[this.ucScreenLED1.LEDI6 * 3 + 1];
      numArray1655[index1649] = (byte) num4955;
      byte[] numArray1656 = second;
      int num4956 = num4954;
      int num4957 = num4956 + 1;
      int index1650 = num4956;
      int num4958 = (int) numArray1242[this.ucScreenLED1.LEDI6 * 3 + 2];
      numArray1656[index1650] = (byte) num4958;
      byte[] numArray1657 = second;
      int num4959 = num4957;
      int num4960 = num4959 + 1;
      int index1651 = num4959;
      int num4961 = (int) numArray1242[this.ucScreenLED1.LEDH6 * 3];
      numArray1657[index1651] = (byte) num4961;
      byte[] numArray1658 = second;
      int num4962 = num4960;
      int num4963 = num4962 + 1;
      int index1652 = num4962;
      int num4964 = (int) numArray1242[this.ucScreenLED1.LEDH6 * 3 + 1];
      numArray1658[index1652] = (byte) num4964;
      byte[] numArray1659 = second;
      int num4965 = num4963;
      int num4966 = num4965 + 1;
      int index1653 = num4965;
      int num4967 = (int) numArray1242[this.ucScreenLED1.LEDH6 * 3 + 2];
      numArray1659[index1653] = (byte) num4967;
      byte[] numArray1660 = second;
      int num4968 = num4966;
      int num4969 = num4968 + 1;
      int index1654 = num4968;
      int num4970 = (int) numArray1242[this.ucScreenLED1.LEDH6 * 3];
      numArray1660[index1654] = (byte) num4970;
      byte[] numArray1661 = second;
      int num4971 = num4969;
      int num4972 = num4971 + 1;
      int index1655 = num4971;
      int num4973 = (int) numArray1242[this.ucScreenLED1.LEDH6 * 3 + 1];
      numArray1661[index1655] = (byte) num4973;
      byte[] numArray1662 = second;
      int num4974 = num4972;
      int num4975 = num4974 + 1;
      int index1656 = num4974;
      int num4976 = (int) numArray1242[this.ucScreenLED1.LEDH6 * 3 + 2];
      numArray1662[index1656] = (byte) num4976;
      byte[] numArray1663 = second;
      int num4977 = num4975;
      int num4978 = num4977 + 1;
      int index1657 = num4977;
      int num4979 = (int) numArray1242[this.ucScreenLED1.LEDG6 * 3];
      numArray1663[index1657] = (byte) num4979;
      byte[] numArray1664 = second;
      int num4980 = num4978;
      int num4981 = num4980 + 1;
      int index1658 = num4980;
      int num4982 = (int) numArray1242[this.ucScreenLED1.LEDG6 * 3 + 1];
      numArray1664[index1658] = (byte) num4982;
      byte[] numArray1665 = second;
      int num4983 = num4981;
      int num4984 = num4983 + 1;
      int index1659 = num4983;
      int num4985 = (int) numArray1242[this.ucScreenLED1.LEDG6 * 3 + 2];
      numArray1665[index1659] = (byte) num4985;
      byte[] numArray1666 = second;
      int num4986 = num4984;
      int num4987 = num4986 + 1;
      int index1660 = num4986;
      int num4988 = (int) numArray1242[this.ucScreenLED1.LEDF6 * 3];
      numArray1666[index1660] = (byte) num4988;
      byte[] numArray1667 = second;
      int num4989 = num4987;
      int num4990 = num4989 + 1;
      int index1661 = num4989;
      int num4991 = (int) numArray1242[this.ucScreenLED1.LEDF6 * 3 + 1];
      numArray1667[index1661] = (byte) num4991;
      byte[] numArray1668 = second;
      int num4992 = num4990;
      int num4993 = num4992 + 1;
      int index1662 = num4992;
      int num4994 = (int) numArray1242[this.ucScreenLED1.LEDF6 * 3 + 2];
      numArray1668[index1662] = (byte) num4994;
      byte[] numArray1669 = second;
      int num4995 = num4993;
      int num4996 = num4995 + 1;
      int index1663 = num4995;
      int num4997 = (int) numArray1242[this.ucScreenLED1.HSD1 * 3];
      numArray1669[index1663] = (byte) num4997;
      byte[] numArray1670 = second;
      int num4998 = num4996;
      int num4999 = num4998 + 1;
      int index1664 = num4998;
      int num5000 = (int) numArray1242[this.ucScreenLED1.HSD1 * 3 + 1];
      numArray1670[index1664] = (byte) num5000;
      byte[] numArray1671 = second;
      int num5001 = num4999;
      int num5002 = num5001 + 1;
      int index1665 = num5001;
      int num5003 = (int) numArray1242[this.ucScreenLED1.HSD1 * 3 + 2];
      numArray1671[index1665] = (byte) num5003;
      byte[] numArray1672 = second;
      int num5004 = num5002;
      int num5005 = num5004 + 1;
      int index1666 = num5004;
      int num5006 = (int) numArray1242[this.ucScreenLED1.HSD1 * 3];
      numArray1672[index1666] = (byte) num5006;
      byte[] numArray1673 = second;
      int num5007 = num5005;
      int num5008 = num5007 + 1;
      int index1667 = num5007;
      int num5009 = (int) numArray1242[this.ucScreenLED1.HSD1 * 3 + 1];
      numArray1673[index1667] = (byte) num5009;
      byte[] numArray1674 = second;
      int num5010 = num5008;
      int num5011 = num5010 + 1;
      int index1668 = num5010;
      int num5012 = (int) numArray1242[this.ucScreenLED1.HSD1 * 3 + 2];
      numArray1674[index1668] = (byte) num5012;
      byte[] numArray1675 = second;
      int num5013 = num5011;
      int num5014 = num5013 + 1;
      int index1669 = num5013;
      int num5015 = (int) numArray1242[this.ucScreenLED1.SSD1 * 3];
      numArray1675[index1669] = (byte) num5015;
      byte[] numArray1676 = second;
      int num5016 = num5014;
      int num5017 = num5016 + 1;
      int index1670 = num5016;
      int num5018 = (int) numArray1242[this.ucScreenLED1.SSD1 * 3 + 1];
      numArray1676[index1670] = (byte) num5018;
      byte[] numArray1677 = second;
      int num5019 = num5017;
      int num5020 = num5019 + 1;
      int index1671 = num5019;
      int num5021 = (int) numArray1242[this.ucScreenLED1.SSD1 * 3 + 2];
      numArray1677[index1671] = (byte) num5021;
      byte[] numArray1678 = second;
      int num5022 = num5020;
      int num5023 = num5022 + 1;
      int index1672 = num5022;
      int num5024 = (int) numArray1242[this.ucScreenLED1.SSD1 * 3];
      numArray1678[index1672] = (byte) num5024;
      byte[] numArray1679 = second;
      int num5025 = num5023;
      int num5026 = num5025 + 1;
      int index1673 = num5025;
      int num5027 = (int) numArray1242[this.ucScreenLED1.SSD1 * 3 + 1];
      numArray1679[index1673] = (byte) num5027;
      byte[] numArray1680 = second;
      int num5028 = num5026;
      int num5029 = num5028 + 1;
      int index1674 = num5028;
      int num5030 = (int) numArray1242[this.ucScreenLED1.SSD1 * 3 + 2];
      numArray1680[index1674] = (byte) num5030;
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 8)
    {
      float num5031 = (float) ((double) ((int) this.myOnOff * (int) this.myBrightness) * 0.0099999997764825821 * 0.40000000596046448);
      byte[] numArray1681 = new byte[198];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray1681.Length,
        (byte) (numArray1681.Length >> 8),
        (byte) 0,
        (byte) 0
      };
      int num5032 = 0;
      byte[] second1 = new byte[numArray1681.Length - 48 /*0x30*/];
      int num5033;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDC2])
      {
        byte[] numArray1682 = second1;
        int num5034 = num5032;
        int num5035 = num5034 + 1;
        int index1675 = num5034;
        int num5036 = (int) (byte) ((double) this.ledVal8[10, 0] * (double) num5031);
        numArray1682[index1675] = (byte) num5036;
        byte[] numArray1683 = second1;
        int num5037 = num5035;
        int num5038 = num5037 + 1;
        int index1676 = num5037;
        int num5039 = (int) (byte) ((double) this.ledVal8[10, 1] * (double) num5031);
        numArray1683[index1676] = (byte) num5039;
        byte[] numArray1684 = second1;
        int num5040 = num5038;
        int num5041 = num5040 + 1;
        int index1677 = num5040;
        int num5042 = (int) (byte) ((double) this.ledVal8[10, 2] * (double) num5031);
        numArray1684[index1677] = (byte) num5042;
        byte[] numArray1685 = second1;
        int num5043 = num5041;
        int num5044 = num5043 + 1;
        int index1678 = num5043;
        int num5045 = (int) (byte) ((double) this.ledVal8[11, 0] * (double) num5031);
        numArray1685[index1678] = (byte) num5045;
        byte[] numArray1686 = second1;
        int num5046 = num5044;
        int num5047 = num5046 + 1;
        int index1679 = num5046;
        int num5048 = (int) (byte) ((double) this.ledVal8[11, 1] * (double) num5031);
        numArray1686[index1679] = (byte) num5048;
        byte[] numArray1687 = second1;
        int num5049 = num5047;
        int num5050 = num5049 + 1;
        int index1680 = num5049;
        int num5051 = (int) (byte) ((double) this.ledVal8[11, 2] * (double) num5031);
        numArray1687[index1680] = (byte) num5051;
        byte[] numArray1688 = second1;
        int num5052 = num5050;
        int num5053 = num5052 + 1;
        int index1681 = num5052;
        int num5054 = (int) (byte) ((double) this.ledVal8[12, 0] * (double) num5031);
        numArray1688[index1681] = (byte) num5054;
        byte[] numArray1689 = second1;
        int num5055 = num5053;
        int num5056 = num5055 + 1;
        int index1682 = num5055;
        int num5057 = (int) (byte) ((double) this.ledVal8[12, 1] * (double) num5031);
        numArray1689[index1682] = (byte) num5057;
        byte[] numArray1690 = second1;
        int num5058 = num5056;
        num5033 = num5058 + 1;
        int index1683 = num5058;
        int num5059 = (int) (byte) ((double) this.ledVal8[12, 2] * (double) num5031);
        numArray1690[index1683] = (byte) num5059;
      }
      else
      {
        byte[] numArray1691 = second1;
        int num5060 = num5032;
        int num5061 = num5060 + 1;
        int index1684 = num5060;
        numArray1691[index1684] = (byte) 0;
        byte[] numArray1692 = second1;
        int num5062 = num5061;
        int num5063 = num5062 + 1;
        int index1685 = num5062;
        numArray1692[index1685] = (byte) 0;
        byte[] numArray1693 = second1;
        int num5064 = num5063;
        int num5065 = num5064 + 1;
        int index1686 = num5064;
        numArray1693[index1686] = (byte) 0;
        byte[] numArray1694 = second1;
        int num5066 = num5065;
        int num5067 = num5066 + 1;
        int index1687 = num5066;
        numArray1694[index1687] = (byte) 0;
        byte[] numArray1695 = second1;
        int num5068 = num5067;
        int num5069 = num5068 + 1;
        int index1688 = num5068;
        numArray1695[index1688] = (byte) 0;
        byte[] numArray1696 = second1;
        int num5070 = num5069;
        int num5071 = num5070 + 1;
        int index1689 = num5070;
        numArray1696[index1689] = (byte) 0;
        byte[] numArray1697 = second1;
        int num5072 = num5071;
        int num5073 = num5072 + 1;
        int index1690 = num5072;
        numArray1697[index1690] = (byte) 0;
        byte[] numArray1698 = second1;
        int num5074 = num5073;
        int num5075 = num5074 + 1;
        int index1691 = num5074;
        numArray1698[index1691] = (byte) 0;
        byte[] numArray1699 = second1;
        int num5076 = num5075;
        num5033 = num5076 + 1;
        int index1692 = num5076;
        numArray1699[index1692] = (byte) 0;
      }
      int num5077;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDD2])
      {
        byte[] numArray1700 = second1;
        int num5078 = num5033;
        int num5079 = num5078 + 1;
        int index1693 = num5078;
        int num5080 = (int) (byte) ((double) this.ledVal8[12, 0] * (double) num5031);
        numArray1700[index1693] = (byte) num5080;
        byte[] numArray1701 = second1;
        int num5081 = num5079;
        int num5082 = num5081 + 1;
        int index1694 = num5081;
        int num5083 = (int) (byte) ((double) this.ledVal8[12, 1] * (double) num5031);
        numArray1701[index1694] = (byte) num5083;
        byte[] numArray1702 = second1;
        int num5084 = num5082;
        int num5085 = num5084 + 1;
        int index1695 = num5084;
        int num5086 = (int) (byte) ((double) this.ledVal8[12, 2] * (double) num5031);
        numArray1702[index1695] = (byte) num5086;
        byte[] numArray1703 = second1;
        int num5087 = num5085;
        int num5088 = num5087 + 1;
        int index1696 = num5087;
        int num5089 = (int) (byte) ((double) this.ledVal8[11, 0] * (double) num5031);
        numArray1703[index1696] = (byte) num5089;
        byte[] numArray1704 = second1;
        int num5090 = num5088;
        int num5091 = num5090 + 1;
        int index1697 = num5090;
        int num5092 = (int) (byte) ((double) this.ledVal8[11, 1] * (double) num5031);
        numArray1704[index1697] = (byte) num5092;
        byte[] numArray1705 = second1;
        int num5093 = num5091;
        int num5094 = num5093 + 1;
        int index1698 = num5093;
        int num5095 = (int) (byte) ((double) this.ledVal8[11, 2] * (double) num5031);
        numArray1705[index1698] = (byte) num5095;
        byte[] numArray1706 = second1;
        int num5096 = num5094;
        int num5097 = num5096 + 1;
        int index1699 = num5096;
        int num5098 = (int) (byte) ((double) this.ledVal8[10, 0] * (double) num5031);
        numArray1706[index1699] = (byte) num5098;
        byte[] numArray1707 = second1;
        int num5099 = num5097;
        int num5100 = num5099 + 1;
        int index1700 = num5099;
        int num5101 = (int) (byte) ((double) this.ledVal8[10, 1] * (double) num5031);
        numArray1707[index1700] = (byte) num5101;
        byte[] numArray1708 = second1;
        int num5102 = num5100;
        num5077 = num5102 + 1;
        int index1701 = num5102;
        int num5103 = (int) (byte) ((double) this.ledVal8[10, 2] * (double) num5031);
        numArray1708[index1701] = (byte) num5103;
      }
      else
      {
        byte[] numArray1709 = second1;
        int num5104 = num5033;
        int num5105 = num5104 + 1;
        int index1702 = num5104;
        numArray1709[index1702] = (byte) 0;
        byte[] numArray1710 = second1;
        int num5106 = num5105;
        int num5107 = num5106 + 1;
        int index1703 = num5106;
        numArray1710[index1703] = (byte) 0;
        byte[] numArray1711 = second1;
        int num5108 = num5107;
        int num5109 = num5108 + 1;
        int index1704 = num5108;
        numArray1711[index1704] = (byte) 0;
        byte[] numArray1712 = second1;
        int num5110 = num5109;
        int num5111 = num5110 + 1;
        int index1705 = num5110;
        numArray1712[index1705] = (byte) 0;
        byte[] numArray1713 = second1;
        int num5112 = num5111;
        int num5113 = num5112 + 1;
        int index1706 = num5112;
        numArray1713[index1706] = (byte) 0;
        byte[] numArray1714 = second1;
        int num5114 = num5113;
        int num5115 = num5114 + 1;
        int index1707 = num5114;
        numArray1714[index1707] = (byte) 0;
        byte[] numArray1715 = second1;
        int num5116 = num5115;
        int num5117 = num5116 + 1;
        int index1708 = num5116;
        numArray1715[index1708] = (byte) 0;
        byte[] numArray1716 = second1;
        int num5118 = num5117;
        int num5119 = num5118 + 1;
        int index1709 = num5118;
        numArray1716[index1709] = (byte) 0;
        byte[] numArray1717 = second1;
        int num5120 = num5119;
        num5077 = num5120 + 1;
        int index1710 = num5120;
        numArray1717[index1710] = (byte) 0;
      }
      int num5121;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDE2])
      {
        byte[] numArray1718 = second1;
        int num5122 = num5077;
        int num5123 = num5122 + 1;
        int index1711 = num5122;
        int num5124 = (int) (byte) ((double) this.ledVal8[9, 0] * (double) num5031);
        numArray1718[index1711] = (byte) num5124;
        byte[] numArray1719 = second1;
        int num5125 = num5123;
        int num5126 = num5125 + 1;
        int index1712 = num5125;
        int num5127 = (int) (byte) ((double) this.ledVal8[9, 1] * (double) num5031);
        numArray1719[index1712] = (byte) num5127;
        byte[] numArray1720 = second1;
        int num5128 = num5126;
        int num5129 = num5128 + 1;
        int index1713 = num5128;
        int num5130 = (int) (byte) ((double) this.ledVal8[9, 2] * (double) num5031);
        numArray1720[index1713] = (byte) num5130;
        byte[] numArray1721 = second1;
        int num5131 = num5129;
        int num5132 = num5131 + 1;
        int index1714 = num5131;
        int num5133 = (int) (byte) ((double) this.ledVal8[8, 0] * (double) num5031);
        numArray1721[index1714] = (byte) num5133;
        byte[] numArray1722 = second1;
        int num5134 = num5132;
        int num5135 = num5134 + 1;
        int index1715 = num5134;
        int num5136 = (int) (byte) ((double) this.ledVal8[8, 1] * (double) num5031);
        numArray1722[index1715] = (byte) num5136;
        byte[] numArray1723 = second1;
        int num5137 = num5135;
        int num5138 = num5137 + 1;
        int index1716 = num5137;
        int num5139 = (int) (byte) ((double) this.ledVal8[8, 2] * (double) num5031);
        numArray1723[index1716] = (byte) num5139;
        byte[] numArray1724 = second1;
        int num5140 = num5138;
        int num5141 = num5140 + 1;
        int index1717 = num5140;
        int num5142 = (int) (byte) ((double) this.ledVal8[7, 0] * (double) num5031);
        numArray1724[index1717] = (byte) num5142;
        byte[] numArray1725 = second1;
        int num5143 = num5141;
        int num5144 = num5143 + 1;
        int index1718 = num5143;
        int num5145 = (int) (byte) ((double) this.ledVal8[7, 1] * (double) num5031);
        numArray1725[index1718] = (byte) num5145;
        byte[] numArray1726 = second1;
        int num5146 = num5144;
        num5121 = num5146 + 1;
        int index1719 = num5146;
        int num5147 = (int) (byte) ((double) this.ledVal8[7, 2] * (double) num5031);
        numArray1726[index1719] = (byte) num5147;
      }
      else
      {
        byte[] numArray1727 = second1;
        int num5148 = num5077;
        int num5149 = num5148 + 1;
        int index1720 = num5148;
        numArray1727[index1720] = (byte) 0;
        byte[] numArray1728 = second1;
        int num5150 = num5149;
        int num5151 = num5150 + 1;
        int index1721 = num5150;
        numArray1728[index1721] = (byte) 0;
        byte[] numArray1729 = second1;
        int num5152 = num5151;
        int num5153 = num5152 + 1;
        int index1722 = num5152;
        numArray1729[index1722] = (byte) 0;
        byte[] numArray1730 = second1;
        int num5154 = num5153;
        int num5155 = num5154 + 1;
        int index1723 = num5154;
        numArray1730[index1723] = (byte) 0;
        byte[] numArray1731 = second1;
        int num5156 = num5155;
        int num5157 = num5156 + 1;
        int index1724 = num5156;
        numArray1731[index1724] = (byte) 0;
        byte[] numArray1732 = second1;
        int num5158 = num5157;
        int num5159 = num5158 + 1;
        int index1725 = num5158;
        numArray1732[index1725] = (byte) 0;
        byte[] numArray1733 = second1;
        int num5160 = num5159;
        int num5161 = num5160 + 1;
        int index1726 = num5160;
        numArray1733[index1726] = (byte) 0;
        byte[] numArray1734 = second1;
        int num5162 = num5161;
        int num5163 = num5162 + 1;
        int index1727 = num5162;
        numArray1734[index1727] = (byte) 0;
        byte[] numArray1735 = second1;
        int num5164 = num5163;
        num5121 = num5164 + 1;
        int index1728 = num5164;
        numArray1735[index1728] = (byte) 0;
      }
      int num5165;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDG2])
      {
        byte[] numArray1736 = second1;
        int num5166 = num5121;
        int num5167 = num5166 + 1;
        int index1729 = num5166;
        int num5168 = (int) (byte) ((double) this.ledVal8[7, 0] * (double) num5031);
        numArray1736[index1729] = (byte) num5168;
        byte[] numArray1737 = second1;
        int num5169 = num5167;
        int num5170 = num5169 + 1;
        int index1730 = num5169;
        int num5171 = (int) (byte) ((double) this.ledVal8[7, 1] * (double) num5031);
        numArray1737[index1730] = (byte) num5171;
        byte[] numArray1738 = second1;
        int num5172 = num5170;
        int num5173 = num5172 + 1;
        int index1731 = num5172;
        int num5174 = (int) (byte) ((double) this.ledVal8[7, 2] * (double) num5031);
        numArray1738[index1731] = (byte) num5174;
        byte[] numArray1739 = second1;
        int num5175 = num5173;
        int num5176 = num5175 + 1;
        int index1732 = num5175;
        int num5177 = (int) (byte) ((double) this.ledVal8[8, 0] * (double) num5031);
        numArray1739[index1732] = (byte) num5177;
        byte[] numArray1740 = second1;
        int num5178 = num5176;
        int num5179 = num5178 + 1;
        int index1733 = num5178;
        int num5180 = (int) (byte) ((double) this.ledVal8[8, 1] * (double) num5031);
        numArray1740[index1733] = (byte) num5180;
        byte[] numArray1741 = second1;
        int num5181 = num5179;
        int num5182 = num5181 + 1;
        int index1734 = num5181;
        int num5183 = (int) (byte) ((double) this.ledVal8[8, 2] * (double) num5031);
        numArray1741[index1734] = (byte) num5183;
        byte[] numArray1742 = second1;
        int num5184 = num5182;
        int num5185 = num5184 + 1;
        int index1735 = num5184;
        int num5186 = (int) (byte) ((double) this.ledVal8[9, 0] * (double) num5031);
        numArray1742[index1735] = (byte) num5186;
        byte[] numArray1743 = second1;
        int num5187 = num5185;
        int num5188 = num5187 + 1;
        int index1736 = num5187;
        int num5189 = (int) (byte) ((double) this.ledVal8[9, 1] * (double) num5031);
        numArray1743[index1736] = (byte) num5189;
        byte[] numArray1744 = second1;
        int num5190 = num5188;
        num5165 = num5190 + 1;
        int index1737 = num5190;
        int num5191 = (int) (byte) ((double) this.ledVal8[9, 2] * (double) num5031);
        numArray1744[index1737] = (byte) num5191;
      }
      else
      {
        byte[] numArray1745 = second1;
        int num5192 = num5121;
        int num5193 = num5192 + 1;
        int index1738 = num5192;
        numArray1745[index1738] = (byte) 0;
        byte[] numArray1746 = second1;
        int num5194 = num5193;
        int num5195 = num5194 + 1;
        int index1739 = num5194;
        numArray1746[index1739] = (byte) 0;
        byte[] numArray1747 = second1;
        int num5196 = num5195;
        int num5197 = num5196 + 1;
        int index1740 = num5196;
        numArray1747[index1740] = (byte) 0;
        byte[] numArray1748 = second1;
        int num5198 = num5197;
        int num5199 = num5198 + 1;
        int index1741 = num5198;
        numArray1748[index1741] = (byte) 0;
        byte[] numArray1749 = second1;
        int num5200 = num5199;
        int num5201 = num5200 + 1;
        int index1742 = num5200;
        numArray1749[index1742] = (byte) 0;
        byte[] numArray1750 = second1;
        int num5202 = num5201;
        int num5203 = num5202 + 1;
        int index1743 = num5202;
        numArray1750[index1743] = (byte) 0;
        byte[] numArray1751 = second1;
        int num5204 = num5203;
        int num5205 = num5204 + 1;
        int index1744 = num5204;
        numArray1751[index1744] = (byte) 0;
        byte[] numArray1752 = second1;
        int num5206 = num5205;
        int num5207 = num5206 + 1;
        int index1745 = num5206;
        numArray1752[index1745] = (byte) 0;
        byte[] numArray1753 = second1;
        int num5208 = num5207;
        num5165 = num5208 + 1;
        int index1746 = num5208;
        numArray1753[index1746] = (byte) 0;
      }
      int num5209;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDB2])
      {
        byte[] numArray1754 = second1;
        int num5210 = num5165;
        int num5211 = num5210 + 1;
        int index1747 = num5210;
        int num5212 = (int) (byte) ((double) this.ledVal8[9, 0] * (double) num5031);
        numArray1754[index1747] = (byte) num5212;
        byte[] numArray1755 = second1;
        int num5213 = num5211;
        int num5214 = num5213 + 1;
        int index1748 = num5213;
        int num5215 = (int) (byte) ((double) this.ledVal8[9, 1] * (double) num5031);
        numArray1755[index1748] = (byte) num5215;
        byte[] numArray1756 = second1;
        int num5216 = num5214;
        int num5217 = num5216 + 1;
        int index1749 = num5216;
        int num5218 = (int) (byte) ((double) this.ledVal8[9, 2] * (double) num5031);
        numArray1756[index1749] = (byte) num5218;
        byte[] numArray1757 = second1;
        int num5219 = num5217;
        int num5220 = num5219 + 1;
        int index1750 = num5219;
        int num5221 = (int) (byte) ((double) this.ledVal8[8, 0] * (double) num5031);
        numArray1757[index1750] = (byte) num5221;
        byte[] numArray1758 = second1;
        int num5222 = num5220;
        int num5223 = num5222 + 1;
        int index1751 = num5222;
        int num5224 = (int) (byte) ((double) this.ledVal8[8, 1] * (double) num5031);
        numArray1758[index1751] = (byte) num5224;
        byte[] numArray1759 = second1;
        int num5225 = num5223;
        int num5226 = num5225 + 1;
        int index1752 = num5225;
        int num5227 = (int) (byte) ((double) this.ledVal8[8, 2] * (double) num5031);
        numArray1759[index1752] = (byte) num5227;
        byte[] numArray1760 = second1;
        int num5228 = num5226;
        int num5229 = num5228 + 1;
        int index1753 = num5228;
        int num5230 = (int) (byte) ((double) this.ledVal8[7, 0] * (double) num5031);
        numArray1760[index1753] = (byte) num5230;
        byte[] numArray1761 = second1;
        int num5231 = num5229;
        int num5232 = num5231 + 1;
        int index1754 = num5231;
        int num5233 = (int) (byte) ((double) this.ledVal8[7, 1] * (double) num5031);
        numArray1761[index1754] = (byte) num5233;
        byte[] numArray1762 = second1;
        int num5234 = num5232;
        num5209 = num5234 + 1;
        int index1755 = num5234;
        int num5235 = (int) (byte) ((double) this.ledVal8[7, 2] * (double) num5031);
        numArray1762[index1755] = (byte) num5235;
      }
      else
      {
        byte[] numArray1763 = second1;
        int num5236 = num5165;
        int num5237 = num5236 + 1;
        int index1756 = num5236;
        numArray1763[index1756] = (byte) 0;
        byte[] numArray1764 = second1;
        int num5238 = num5237;
        int num5239 = num5238 + 1;
        int index1757 = num5238;
        numArray1764[index1757] = (byte) 0;
        byte[] numArray1765 = second1;
        int num5240 = num5239;
        int num5241 = num5240 + 1;
        int index1758 = num5240;
        numArray1765[index1758] = (byte) 0;
        byte[] numArray1766 = second1;
        int num5242 = num5241;
        int num5243 = num5242 + 1;
        int index1759 = num5242;
        numArray1766[index1759] = (byte) 0;
        byte[] numArray1767 = second1;
        int num5244 = num5243;
        int num5245 = num5244 + 1;
        int index1760 = num5244;
        numArray1767[index1760] = (byte) 0;
        byte[] numArray1768 = second1;
        int num5246 = num5245;
        int num5247 = num5246 + 1;
        int index1761 = num5246;
        numArray1768[index1761] = (byte) 0;
        byte[] numArray1769 = second1;
        int num5248 = num5247;
        int num5249 = num5248 + 1;
        int index1762 = num5248;
        numArray1769[index1762] = (byte) 0;
        byte[] numArray1770 = second1;
        int num5250 = num5249;
        int num5251 = num5250 + 1;
        int index1763 = num5250;
        numArray1770[index1763] = (byte) 0;
        byte[] numArray1771 = second1;
        int num5252 = num5251;
        num5209 = num5252 + 1;
        int index1764 = num5252;
        numArray1771[index1764] = (byte) 0;
      }
      int num5253;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDA2])
      {
        byte[] numArray1772 = second1;
        int num5254 = num5209;
        int num5255 = num5254 + 1;
        int index1765 = num5254;
        int num5256 = (int) (byte) ((double) this.ledVal8[6, 0] * (double) num5031);
        numArray1772[index1765] = (byte) num5256;
        byte[] numArray1773 = second1;
        int num5257 = num5255;
        int num5258 = num5257 + 1;
        int index1766 = num5257;
        int num5259 = (int) (byte) ((double) this.ledVal8[6, 1] * (double) num5031);
        numArray1773[index1766] = (byte) num5259;
        byte[] numArray1774 = second1;
        int num5260 = num5258;
        int num5261 = num5260 + 1;
        int index1767 = num5260;
        int num5262 = (int) (byte) ((double) this.ledVal8[6, 2] * (double) num5031);
        numArray1774[index1767] = (byte) num5262;
        byte[] numArray1775 = second1;
        int num5263 = num5261;
        int num5264 = num5263 + 1;
        int index1768 = num5263;
        int num5265 = (int) (byte) ((double) this.ledVal8[5, 0] * (double) num5031);
        numArray1775[index1768] = (byte) num5265;
        byte[] numArray1776 = second1;
        int num5266 = num5264;
        int num5267 = num5266 + 1;
        int index1769 = num5266;
        int num5268 = (int) (byte) ((double) this.ledVal8[5, 1] * (double) num5031);
        numArray1776[index1769] = (byte) num5268;
        byte[] numArray1777 = second1;
        int num5269 = num5267;
        int num5270 = num5269 + 1;
        int index1770 = num5269;
        int num5271 = (int) (byte) ((double) this.ledVal8[5, 2] * (double) num5031);
        numArray1777[index1770] = (byte) num5271;
        byte[] numArray1778 = second1;
        int num5272 = num5270;
        int num5273 = num5272 + 1;
        int index1771 = num5272;
        int num5274 = (int) (byte) ((double) this.ledVal8[4, 0] * (double) num5031);
        numArray1778[index1771] = (byte) num5274;
        byte[] numArray1779 = second1;
        int num5275 = num5273;
        int num5276 = num5275 + 1;
        int index1772 = num5275;
        int num5277 = (int) (byte) ((double) this.ledVal8[4, 1] * (double) num5031);
        numArray1779[index1772] = (byte) num5277;
        byte[] numArray1780 = second1;
        int num5278 = num5276;
        num5253 = num5278 + 1;
        int index1773 = num5278;
        int num5279 = (int) (byte) ((double) this.ledVal8[4, 2] * (double) num5031);
        numArray1780[index1773] = (byte) num5279;
      }
      else
      {
        byte[] numArray1781 = second1;
        int num5280 = num5209;
        int num5281 = num5280 + 1;
        int index1774 = num5280;
        numArray1781[index1774] = (byte) 0;
        byte[] numArray1782 = second1;
        int num5282 = num5281;
        int num5283 = num5282 + 1;
        int index1775 = num5282;
        numArray1782[index1775] = (byte) 0;
        byte[] numArray1783 = second1;
        int num5284 = num5283;
        int num5285 = num5284 + 1;
        int index1776 = num5284;
        numArray1783[index1776] = (byte) 0;
        byte[] numArray1784 = second1;
        int num5286 = num5285;
        int num5287 = num5286 + 1;
        int index1777 = num5286;
        numArray1784[index1777] = (byte) 0;
        byte[] numArray1785 = second1;
        int num5288 = num5287;
        int num5289 = num5288 + 1;
        int index1778 = num5288;
        numArray1785[index1778] = (byte) 0;
        byte[] numArray1786 = second1;
        int num5290 = num5289;
        int num5291 = num5290 + 1;
        int index1779 = num5290;
        numArray1786[index1779] = (byte) 0;
        byte[] numArray1787 = second1;
        int num5292 = num5291;
        int num5293 = num5292 + 1;
        int index1780 = num5292;
        numArray1787[index1780] = (byte) 0;
        byte[] numArray1788 = second1;
        int num5294 = num5293;
        int num5295 = num5294 + 1;
        int index1781 = num5294;
        numArray1788[index1781] = (byte) 0;
        byte[] numArray1789 = second1;
        int num5296 = num5295;
        num5253 = num5296 + 1;
        int index1782 = num5296;
        numArray1789[index1782] = (byte) 0;
      }
      int num5297;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDF2])
      {
        byte[] numArray1790 = second1;
        int num5298 = num5253;
        int num5299 = num5298 + 1;
        int index1783 = num5298;
        int num5300 = (int) (byte) ((double) this.ledVal8[4, 0] * (double) num5031);
        numArray1790[index1783] = (byte) num5300;
        byte[] numArray1791 = second1;
        int num5301 = num5299;
        int num5302 = num5301 + 1;
        int index1784 = num5301;
        int num5303 = (int) (byte) ((double) this.ledVal8[4, 1] * (double) num5031);
        numArray1791[index1784] = (byte) num5303;
        byte[] numArray1792 = second1;
        int num5304 = num5302;
        int num5305 = num5304 + 1;
        int index1785 = num5304;
        int num5306 = (int) (byte) ((double) this.ledVal8[4, 2] * (double) num5031);
        numArray1792[index1785] = (byte) num5306;
        byte[] numArray1793 = second1;
        int num5307 = num5305;
        int num5308 = num5307 + 1;
        int index1786 = num5307;
        int num5309 = (int) (byte) ((double) this.ledVal8[5, 0] * (double) num5031);
        numArray1793[index1786] = (byte) num5309;
        byte[] numArray1794 = second1;
        int num5310 = num5308;
        int num5311 = num5310 + 1;
        int index1787 = num5310;
        int num5312 = (int) (byte) ((double) this.ledVal8[5, 1] * (double) num5031);
        numArray1794[index1787] = (byte) num5312;
        byte[] numArray1795 = second1;
        int num5313 = num5311;
        int num5314 = num5313 + 1;
        int index1788 = num5313;
        int num5315 = (int) (byte) ((double) this.ledVal8[5, 2] * (double) num5031);
        numArray1795[index1788] = (byte) num5315;
        byte[] numArray1796 = second1;
        int num5316 = num5314;
        int num5317 = num5316 + 1;
        int index1789 = num5316;
        int num5318 = (int) (byte) ((double) this.ledVal8[6, 0] * (double) num5031);
        numArray1796[index1789] = (byte) num5318;
        byte[] numArray1797 = second1;
        int num5319 = num5317;
        int num5320 = num5319 + 1;
        int index1790 = num5319;
        int num5321 = (int) (byte) ((double) this.ledVal8[6, 1] * (double) num5031);
        numArray1797[index1790] = (byte) num5321;
        byte[] numArray1798 = second1;
        int num5322 = num5320;
        num5297 = num5322 + 1;
        int index1791 = num5322;
        int num5323 = (int) (byte) ((double) this.ledVal8[6, 2] * (double) num5031);
        numArray1798[index1791] = (byte) num5323;
      }
      else
      {
        byte[] numArray1799 = second1;
        int num5324 = num5253;
        int num5325 = num5324 + 1;
        int index1792 = num5324;
        numArray1799[index1792] = (byte) 0;
        byte[] numArray1800 = second1;
        int num5326 = num5325;
        int num5327 = num5326 + 1;
        int index1793 = num5326;
        numArray1800[index1793] = (byte) 0;
        byte[] numArray1801 = second1;
        int num5328 = num5327;
        int num5329 = num5328 + 1;
        int index1794 = num5328;
        numArray1801[index1794] = (byte) 0;
        byte[] numArray1802 = second1;
        int num5330 = num5329;
        int num5331 = num5330 + 1;
        int index1795 = num5330;
        numArray1802[index1795] = (byte) 0;
        byte[] numArray1803 = second1;
        int num5332 = num5331;
        int num5333 = num5332 + 1;
        int index1796 = num5332;
        numArray1803[index1796] = (byte) 0;
        byte[] numArray1804 = second1;
        int num5334 = num5333;
        int num5335 = num5334 + 1;
        int index1797 = num5334;
        numArray1804[index1797] = (byte) 0;
        byte[] numArray1805 = second1;
        int num5336 = num5335;
        int num5337 = num5336 + 1;
        int index1798 = num5336;
        numArray1805[index1798] = (byte) 0;
        byte[] numArray1806 = second1;
        int num5338 = num5337;
        int num5339 = num5338 + 1;
        int index1799 = num5338;
        numArray1806[index1799] = (byte) 0;
        byte[] numArray1807 = second1;
        int num5340 = num5339;
        num5297 = num5340 + 1;
        int index1800 = num5340;
        numArray1807[index1800] = (byte) 0;
      }
      int num5341;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDC1])
      {
        byte[] numArray1808 = second1;
        int num5342 = num5297;
        int num5343 = num5342 + 1;
        int index1801 = num5342;
        int num5344 = (int) (byte) ((double) this.ledVal8[6, 0] * (double) num5031);
        numArray1808[index1801] = (byte) num5344;
        byte[] numArray1809 = second1;
        int num5345 = num5343;
        int num5346 = num5345 + 1;
        int index1802 = num5345;
        int num5347 = (int) (byte) ((double) this.ledVal8[6, 1] * (double) num5031);
        numArray1809[index1802] = (byte) num5347;
        byte[] numArray1810 = second1;
        int num5348 = num5346;
        int num5349 = num5348 + 1;
        int index1803 = num5348;
        int num5350 = (int) (byte) ((double) this.ledVal8[6, 2] * (double) num5031);
        numArray1810[index1803] = (byte) num5350;
        byte[] numArray1811 = second1;
        int num5351 = num5349;
        int num5352 = num5351 + 1;
        int index1804 = num5351;
        int num5353 = (int) (byte) ((double) this.ledVal8[7, 0] * (double) num5031);
        numArray1811[index1804] = (byte) num5353;
        byte[] numArray1812 = second1;
        int num5354 = num5352;
        int num5355 = num5354 + 1;
        int index1805 = num5354;
        int num5356 = (int) (byte) ((double) this.ledVal8[7, 1] * (double) num5031);
        numArray1812[index1805] = (byte) num5356;
        byte[] numArray1813 = second1;
        int num5357 = num5355;
        int num5358 = num5357 + 1;
        int index1806 = num5357;
        int num5359 = (int) (byte) ((double) this.ledVal8[7, 2] * (double) num5031);
        numArray1813[index1806] = (byte) num5359;
        byte[] numArray1814 = second1;
        int num5360 = num5358;
        int num5361 = num5360 + 1;
        int index1807 = num5360;
        int num5362 = (int) (byte) ((double) this.ledVal8[8, 0] * (double) num5031);
        numArray1814[index1807] = (byte) num5362;
        byte[] numArray1815 = second1;
        int num5363 = num5361;
        int num5364 = num5363 + 1;
        int index1808 = num5363;
        int num5365 = (int) (byte) ((double) this.ledVal8[8, 1] * (double) num5031);
        numArray1815[index1808] = (byte) num5365;
        byte[] numArray1816 = second1;
        int num5366 = num5364;
        num5341 = num5366 + 1;
        int index1809 = num5366;
        int num5367 = (int) (byte) ((double) this.ledVal8[8, 2] * (double) num5031);
        numArray1816[index1809] = (byte) num5367;
      }
      else
      {
        byte[] numArray1817 = second1;
        int num5368 = num5297;
        int num5369 = num5368 + 1;
        int index1810 = num5368;
        numArray1817[index1810] = (byte) 0;
        byte[] numArray1818 = second1;
        int num5370 = num5369;
        int num5371 = num5370 + 1;
        int index1811 = num5370;
        numArray1818[index1811] = (byte) 0;
        byte[] numArray1819 = second1;
        int num5372 = num5371;
        int num5373 = num5372 + 1;
        int index1812 = num5372;
        numArray1819[index1812] = (byte) 0;
        byte[] numArray1820 = second1;
        int num5374 = num5373;
        int num5375 = num5374 + 1;
        int index1813 = num5374;
        numArray1820[index1813] = (byte) 0;
        byte[] numArray1821 = second1;
        int num5376 = num5375;
        int num5377 = num5376 + 1;
        int index1814 = num5376;
        numArray1821[index1814] = (byte) 0;
        byte[] numArray1822 = second1;
        int num5378 = num5377;
        int num5379 = num5378 + 1;
        int index1815 = num5378;
        numArray1822[index1815] = (byte) 0;
        byte[] numArray1823 = second1;
        int num5380 = num5379;
        int num5381 = num5380 + 1;
        int index1816 = num5380;
        numArray1823[index1816] = (byte) 0;
        byte[] numArray1824 = second1;
        int num5382 = num5381;
        int num5383 = num5382 + 1;
        int index1817 = num5382;
        numArray1824[index1817] = (byte) 0;
        byte[] numArray1825 = second1;
        int num5384 = num5383;
        num5341 = num5384 + 1;
        int index1818 = num5384;
        numArray1825[index1818] = (byte) 0;
      }
      int num5385;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDD1])
      {
        byte[] numArray1826 = second1;
        int num5386 = num5341;
        int num5387 = num5386 + 1;
        int index1819 = num5386;
        int num5388 = (int) (byte) ((double) this.ledVal8[8, 0] * (double) num5031);
        numArray1826[index1819] = (byte) num5388;
        byte[] numArray1827 = second1;
        int num5389 = num5387;
        int num5390 = num5389 + 1;
        int index1820 = num5389;
        int num5391 = (int) (byte) ((double) this.ledVal8[8, 1] * (double) num5031);
        numArray1827[index1820] = (byte) num5391;
        byte[] numArray1828 = second1;
        int num5392 = num5390;
        int num5393 = num5392 + 1;
        int index1821 = num5392;
        int num5394 = (int) (byte) ((double) this.ledVal8[8, 2] * (double) num5031);
        numArray1828[index1821] = (byte) num5394;
        byte[] numArray1829 = second1;
        int num5395 = num5393;
        int num5396 = num5395 + 1;
        int index1822 = num5395;
        int num5397 = (int) (byte) ((double) this.ledVal8[7, 0] * (double) num5031);
        numArray1829[index1822] = (byte) num5397;
        byte[] numArray1830 = second1;
        int num5398 = num5396;
        int num5399 = num5398 + 1;
        int index1823 = num5398;
        int num5400 = (int) (byte) ((double) this.ledVal8[7, 1] * (double) num5031);
        numArray1830[index1823] = (byte) num5400;
        byte[] numArray1831 = second1;
        int num5401 = num5399;
        int num5402 = num5401 + 1;
        int index1824 = num5401;
        int num5403 = (int) (byte) ((double) this.ledVal8[7, 2] * (double) num5031);
        numArray1831[index1824] = (byte) num5403;
        byte[] numArray1832 = second1;
        int num5404 = num5402;
        int num5405 = num5404 + 1;
        int index1825 = num5404;
        int num5406 = (int) (byte) ((double) this.ledVal8[6, 0] * (double) num5031);
        numArray1832[index1825] = (byte) num5406;
        byte[] numArray1833 = second1;
        int num5407 = num5405;
        int num5408 = num5407 + 1;
        int index1826 = num5407;
        int num5409 = (int) (byte) ((double) this.ledVal8[6, 1] * (double) num5031);
        numArray1833[index1826] = (byte) num5409;
        byte[] numArray1834 = second1;
        int num5410 = num5408;
        num5385 = num5410 + 1;
        int index1827 = num5410;
        int num5411 = (int) (byte) ((double) this.ledVal8[6, 2] * (double) num5031);
        numArray1834[index1827] = (byte) num5411;
      }
      else
      {
        byte[] numArray1835 = second1;
        int num5412 = num5341;
        int num5413 = num5412 + 1;
        int index1828 = num5412;
        numArray1835[index1828] = (byte) 0;
        byte[] numArray1836 = second1;
        int num5414 = num5413;
        int num5415 = num5414 + 1;
        int index1829 = num5414;
        numArray1836[index1829] = (byte) 0;
        byte[] numArray1837 = second1;
        int num5416 = num5415;
        int num5417 = num5416 + 1;
        int index1830 = num5416;
        numArray1837[index1830] = (byte) 0;
        byte[] numArray1838 = second1;
        int num5418 = num5417;
        int num5419 = num5418 + 1;
        int index1831 = num5418;
        numArray1838[index1831] = (byte) 0;
        byte[] numArray1839 = second1;
        int num5420 = num5419;
        int num5421 = num5420 + 1;
        int index1832 = num5420;
        numArray1839[index1832] = (byte) 0;
        byte[] numArray1840 = second1;
        int num5422 = num5421;
        int num5423 = num5422 + 1;
        int index1833 = num5422;
        numArray1840[index1833] = (byte) 0;
        byte[] numArray1841 = second1;
        int num5424 = num5423;
        int num5425 = num5424 + 1;
        int index1834 = num5424;
        numArray1841[index1834] = (byte) 0;
        byte[] numArray1842 = second1;
        int num5426 = num5425;
        int num5427 = num5426 + 1;
        int index1835 = num5426;
        numArray1842[index1835] = (byte) 0;
        byte[] numArray1843 = second1;
        int num5428 = num5427;
        num5385 = num5428 + 1;
        int index1836 = num5428;
        numArray1843[index1836] = (byte) 0;
      }
      int num5429;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDE1])
      {
        byte[] numArray1844 = second1;
        int num5430 = num5385;
        int num5431 = num5430 + 1;
        int index1837 = num5430;
        int num5432 = (int) (byte) ((double) this.ledVal8[5, 0] * (double) num5031);
        numArray1844[index1837] = (byte) num5432;
        byte[] numArray1845 = second1;
        int num5433 = num5431;
        int num5434 = num5433 + 1;
        int index1838 = num5433;
        int num5435 = (int) (byte) ((double) this.ledVal8[5, 1] * (double) num5031);
        numArray1845[index1838] = (byte) num5435;
        byte[] numArray1846 = second1;
        int num5436 = num5434;
        int num5437 = num5436 + 1;
        int index1839 = num5436;
        int num5438 = (int) (byte) ((double) this.ledVal8[5, 2] * (double) num5031);
        numArray1846[index1839] = (byte) num5438;
        byte[] numArray1847 = second1;
        int num5439 = num5437;
        int num5440 = num5439 + 1;
        int index1840 = num5439;
        int num5441 = (int) (byte) ((double) this.ledVal8[4, 0] * (double) num5031);
        numArray1847[index1840] = (byte) num5441;
        byte[] numArray1848 = second1;
        int num5442 = num5440;
        int num5443 = num5442 + 1;
        int index1841 = num5442;
        int num5444 = (int) (byte) ((double) this.ledVal8[4, 1] * (double) num5031);
        numArray1848[index1841] = (byte) num5444;
        byte[] numArray1849 = second1;
        int num5445 = num5443;
        int num5446 = num5445 + 1;
        int index1842 = num5445;
        int num5447 = (int) (byte) ((double) this.ledVal8[4, 2] * (double) num5031);
        numArray1849[index1842] = (byte) num5447;
        byte[] numArray1850 = second1;
        int num5448 = num5446;
        int num5449 = num5448 + 1;
        int index1843 = num5448;
        int num5450 = (int) (byte) ((double) this.ledVal8[3, 0] * (double) num5031);
        numArray1850[index1843] = (byte) num5450;
        byte[] numArray1851 = second1;
        int num5451 = num5449;
        int num5452 = num5451 + 1;
        int index1844 = num5451;
        int num5453 = (int) (byte) ((double) this.ledVal8[3, 1] * (double) num5031);
        numArray1851[index1844] = (byte) num5453;
        byte[] numArray1852 = second1;
        int num5454 = num5452;
        num5429 = num5454 + 1;
        int index1845 = num5454;
        int num5455 = (int) (byte) ((double) this.ledVal8[3, 2] * (double) num5031);
        numArray1852[index1845] = (byte) num5455;
      }
      else
      {
        byte[] numArray1853 = second1;
        int num5456 = num5385;
        int num5457 = num5456 + 1;
        int index1846 = num5456;
        numArray1853[index1846] = (byte) 0;
        byte[] numArray1854 = second1;
        int num5458 = num5457;
        int num5459 = num5458 + 1;
        int index1847 = num5458;
        numArray1854[index1847] = (byte) 0;
        byte[] numArray1855 = second1;
        int num5460 = num5459;
        int num5461 = num5460 + 1;
        int index1848 = num5460;
        numArray1855[index1848] = (byte) 0;
        byte[] numArray1856 = second1;
        int num5462 = num5461;
        int num5463 = num5462 + 1;
        int index1849 = num5462;
        numArray1856[index1849] = (byte) 0;
        byte[] numArray1857 = second1;
        int num5464 = num5463;
        int num5465 = num5464 + 1;
        int index1850 = num5464;
        numArray1857[index1850] = (byte) 0;
        byte[] numArray1858 = second1;
        int num5466 = num5465;
        int num5467 = num5466 + 1;
        int index1851 = num5466;
        numArray1858[index1851] = (byte) 0;
        byte[] numArray1859 = second1;
        int num5468 = num5467;
        int num5469 = num5468 + 1;
        int index1852 = num5468;
        numArray1859[index1852] = (byte) 0;
        byte[] numArray1860 = second1;
        int num5470 = num5469;
        int num5471 = num5470 + 1;
        int index1853 = num5470;
        numArray1860[index1853] = (byte) 0;
        byte[] numArray1861 = second1;
        int num5472 = num5471;
        num5429 = num5472 + 1;
        int index1854 = num5472;
        numArray1861[index1854] = (byte) 0;
      }
      int num5473;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDG1])
      {
        byte[] numArray1862 = second1;
        int num5474 = num5429;
        int num5475 = num5474 + 1;
        int index1855 = num5474;
        int num5476 = (int) (byte) ((double) this.ledVal8[3, 0] * (double) num5031);
        numArray1862[index1855] = (byte) num5476;
        byte[] numArray1863 = second1;
        int num5477 = num5475;
        int num5478 = num5477 + 1;
        int index1856 = num5477;
        int num5479 = (int) (byte) ((double) this.ledVal8[3, 1] * (double) num5031);
        numArray1863[index1856] = (byte) num5479;
        byte[] numArray1864 = second1;
        int num5480 = num5478;
        int num5481 = num5480 + 1;
        int index1857 = num5480;
        int num5482 = (int) (byte) ((double) this.ledVal8[3, 2] * (double) num5031);
        numArray1864[index1857] = (byte) num5482;
        byte[] numArray1865 = second1;
        int num5483 = num5481;
        int num5484 = num5483 + 1;
        int index1858 = num5483;
        int num5485 = (int) (byte) ((double) this.ledVal8[4, 0] * (double) num5031);
        numArray1865[index1858] = (byte) num5485;
        byte[] numArray1866 = second1;
        int num5486 = num5484;
        int num5487 = num5486 + 1;
        int index1859 = num5486;
        int num5488 = (int) (byte) ((double) this.ledVal8[4, 1] * (double) num5031);
        numArray1866[index1859] = (byte) num5488;
        byte[] numArray1867 = second1;
        int num5489 = num5487;
        int num5490 = num5489 + 1;
        int index1860 = num5489;
        int num5491 = (int) (byte) ((double) this.ledVal8[4, 2] * (double) num5031);
        numArray1867[index1860] = (byte) num5491;
        byte[] numArray1868 = second1;
        int num5492 = num5490;
        int num5493 = num5492 + 1;
        int index1861 = num5492;
        int num5494 = (int) (byte) ((double) this.ledVal8[5, 0] * (double) num5031);
        numArray1868[index1861] = (byte) num5494;
        byte[] numArray1869 = second1;
        int num5495 = num5493;
        int num5496 = num5495 + 1;
        int index1862 = num5495;
        int num5497 = (int) (byte) ((double) this.ledVal8[5, 1] * (double) num5031);
        numArray1869[index1862] = (byte) num5497;
        byte[] numArray1870 = second1;
        int num5498 = num5496;
        num5473 = num5498 + 1;
        int index1863 = num5498;
        int num5499 = (int) (byte) ((double) this.ledVal8[5, 2] * (double) num5031);
        numArray1870[index1863] = (byte) num5499;
      }
      else
      {
        byte[] numArray1871 = second1;
        int num5500 = num5429;
        int num5501 = num5500 + 1;
        int index1864 = num5500;
        numArray1871[index1864] = (byte) 0;
        byte[] numArray1872 = second1;
        int num5502 = num5501;
        int num5503 = num5502 + 1;
        int index1865 = num5502;
        numArray1872[index1865] = (byte) 0;
        byte[] numArray1873 = second1;
        int num5504 = num5503;
        int num5505 = num5504 + 1;
        int index1866 = num5504;
        numArray1873[index1866] = (byte) 0;
        byte[] numArray1874 = second1;
        int num5506 = num5505;
        int num5507 = num5506 + 1;
        int index1867 = num5506;
        numArray1874[index1867] = (byte) 0;
        byte[] numArray1875 = second1;
        int num5508 = num5507;
        int num5509 = num5508 + 1;
        int index1868 = num5508;
        numArray1875[index1868] = (byte) 0;
        byte[] numArray1876 = second1;
        int num5510 = num5509;
        int num5511 = num5510 + 1;
        int index1869 = num5510;
        numArray1876[index1869] = (byte) 0;
        byte[] numArray1877 = second1;
        int num5512 = num5511;
        int num5513 = num5512 + 1;
        int index1870 = num5512;
        numArray1877[index1870] = (byte) 0;
        byte[] numArray1878 = second1;
        int num5514 = num5513;
        int num5515 = num5514 + 1;
        int index1871 = num5514;
        numArray1878[index1871] = (byte) 0;
        byte[] numArray1879 = second1;
        int num5516 = num5515;
        num5473 = num5516 + 1;
        int index1872 = num5516;
        numArray1879[index1872] = (byte) 0;
      }
      int num5517;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDB1])
      {
        byte[] numArray1880 = second1;
        int num5518 = num5473;
        int num5519 = num5518 + 1;
        int index1873 = num5518;
        int num5520 = (int) (byte) ((double) this.ledVal8[5, 0] * (double) num5031);
        numArray1880[index1873] = (byte) num5520;
        byte[] numArray1881 = second1;
        int num5521 = num5519;
        int num5522 = num5521 + 1;
        int index1874 = num5521;
        int num5523 = (int) (byte) ((double) this.ledVal8[5, 1] * (double) num5031);
        numArray1881[index1874] = (byte) num5523;
        byte[] numArray1882 = second1;
        int num5524 = num5522;
        int num5525 = num5524 + 1;
        int index1875 = num5524;
        int num5526 = (int) (byte) ((double) this.ledVal8[5, 2] * (double) num5031);
        numArray1882[index1875] = (byte) num5526;
        byte[] numArray1883 = second1;
        int num5527 = num5525;
        int num5528 = num5527 + 1;
        int index1876 = num5527;
        int num5529 = (int) (byte) ((double) this.ledVal8[4, 0] * (double) num5031);
        numArray1883[index1876] = (byte) num5529;
        byte[] numArray1884 = second1;
        int num5530 = num5528;
        int num5531 = num5530 + 1;
        int index1877 = num5530;
        int num5532 = (int) (byte) ((double) this.ledVal8[4, 1] * (double) num5031);
        numArray1884[index1877] = (byte) num5532;
        byte[] numArray1885 = second1;
        int num5533 = num5531;
        int num5534 = num5533 + 1;
        int index1878 = num5533;
        int num5535 = (int) (byte) ((double) this.ledVal8[4, 2] * (double) num5031);
        numArray1885[index1878] = (byte) num5535;
        byte[] numArray1886 = second1;
        int num5536 = num5534;
        int num5537 = num5536 + 1;
        int index1879 = num5536;
        int num5538 = (int) (byte) ((double) this.ledVal8[3, 0] * (double) num5031);
        numArray1886[index1879] = (byte) num5538;
        byte[] numArray1887 = second1;
        int num5539 = num5537;
        int num5540 = num5539 + 1;
        int index1880 = num5539;
        int num5541 = (int) (byte) ((double) this.ledVal8[3, 1] * (double) num5031);
        numArray1887[index1880] = (byte) num5541;
        byte[] numArray1888 = second1;
        int num5542 = num5540;
        num5517 = num5542 + 1;
        int index1881 = num5542;
        int num5543 = (int) (byte) ((double) this.ledVal8[3, 2] * (double) num5031);
        numArray1888[index1881] = (byte) num5543;
      }
      else
      {
        byte[] numArray1889 = second1;
        int num5544 = num5473;
        int num5545 = num5544 + 1;
        int index1882 = num5544;
        numArray1889[index1882] = (byte) 0;
        byte[] numArray1890 = second1;
        int num5546 = num5545;
        int num5547 = num5546 + 1;
        int index1883 = num5546;
        numArray1890[index1883] = (byte) 0;
        byte[] numArray1891 = second1;
        int num5548 = num5547;
        int num5549 = num5548 + 1;
        int index1884 = num5548;
        numArray1891[index1884] = (byte) 0;
        byte[] numArray1892 = second1;
        int num5550 = num5549;
        int num5551 = num5550 + 1;
        int index1885 = num5550;
        numArray1892[index1885] = (byte) 0;
        byte[] numArray1893 = second1;
        int num5552 = num5551;
        int num5553 = num5552 + 1;
        int index1886 = num5552;
        numArray1893[index1886] = (byte) 0;
        byte[] numArray1894 = second1;
        int num5554 = num5553;
        int num5555 = num5554 + 1;
        int index1887 = num5554;
        numArray1894[index1887] = (byte) 0;
        byte[] numArray1895 = second1;
        int num5556 = num5555;
        int num5557 = num5556 + 1;
        int index1888 = num5556;
        numArray1895[index1888] = (byte) 0;
        byte[] numArray1896 = second1;
        int num5558 = num5557;
        int num5559 = num5558 + 1;
        int index1889 = num5558;
        numArray1896[index1889] = (byte) 0;
        byte[] numArray1897 = second1;
        int num5560 = num5559;
        num5517 = num5560 + 1;
        int index1890 = num5560;
        numArray1897[index1890] = (byte) 0;
      }
      int num5561;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDA1])
      {
        byte[] numArray1898 = second1;
        int num5562 = num5517;
        int num5563 = num5562 + 1;
        int index1891 = num5562;
        int num5564 = (int) (byte) ((double) this.ledVal8[2, 0] * (double) num5031);
        numArray1898[index1891] = (byte) num5564;
        byte[] numArray1899 = second1;
        int num5565 = num5563;
        int num5566 = num5565 + 1;
        int index1892 = num5565;
        int num5567 = (int) (byte) ((double) this.ledVal8[2, 1] * (double) num5031);
        numArray1899[index1892] = (byte) num5567;
        byte[] numArray1900 = second1;
        int num5568 = num5566;
        int num5569 = num5568 + 1;
        int index1893 = num5568;
        int num5570 = (int) (byte) ((double) this.ledVal8[2, 2] * (double) num5031);
        numArray1900[index1893] = (byte) num5570;
        byte[] numArray1901 = second1;
        int num5571 = num5569;
        int num5572 = num5571 + 1;
        int index1894 = num5571;
        int num5573 = (int) (byte) ((double) this.ledVal8[1, 0] * (double) num5031);
        numArray1901[index1894] = (byte) num5573;
        byte[] numArray1902 = second1;
        int num5574 = num5572;
        int num5575 = num5574 + 1;
        int index1895 = num5574;
        int num5576 = (int) (byte) ((double) this.ledVal8[1, 1] * (double) num5031);
        numArray1902[index1895] = (byte) num5576;
        byte[] numArray1903 = second1;
        int num5577 = num5575;
        int num5578 = num5577 + 1;
        int index1896 = num5577;
        int num5579 = (int) (byte) ((double) this.ledVal8[1, 2] * (double) num5031);
        numArray1903[index1896] = (byte) num5579;
        byte[] numArray1904 = second1;
        int num5580 = num5578;
        int num5581 = num5580 + 1;
        int index1897 = num5580;
        int num5582 = (int) (byte) ((double) this.ledVal8[0, 0] * (double) num5031);
        numArray1904[index1897] = (byte) num5582;
        byte[] numArray1905 = second1;
        int num5583 = num5581;
        int num5584 = num5583 + 1;
        int index1898 = num5583;
        int num5585 = (int) (byte) ((double) this.ledVal8[0, 1] * (double) num5031);
        numArray1905[index1898] = (byte) num5585;
        byte[] numArray1906 = second1;
        int num5586 = num5584;
        num5561 = num5586 + 1;
        int index1899 = num5586;
        int num5587 = (int) (byte) ((double) this.ledVal8[0, 2] * (double) num5031);
        numArray1906[index1899] = (byte) num5587;
      }
      else
      {
        byte[] numArray1907 = second1;
        int num5588 = num5517;
        int num5589 = num5588 + 1;
        int index1900 = num5588;
        numArray1907[index1900] = (byte) 0;
        byte[] numArray1908 = second1;
        int num5590 = num5589;
        int num5591 = num5590 + 1;
        int index1901 = num5590;
        numArray1908[index1901] = (byte) 0;
        byte[] numArray1909 = second1;
        int num5592 = num5591;
        int num5593 = num5592 + 1;
        int index1902 = num5592;
        numArray1909[index1902] = (byte) 0;
        byte[] numArray1910 = second1;
        int num5594 = num5593;
        int num5595 = num5594 + 1;
        int index1903 = num5594;
        numArray1910[index1903] = (byte) 0;
        byte[] numArray1911 = second1;
        int num5596 = num5595;
        int num5597 = num5596 + 1;
        int index1904 = num5596;
        numArray1911[index1904] = (byte) 0;
        byte[] numArray1912 = second1;
        int num5598 = num5597;
        int num5599 = num5598 + 1;
        int index1905 = num5598;
        numArray1912[index1905] = (byte) 0;
        byte[] numArray1913 = second1;
        int num5600 = num5599;
        int num5601 = num5600 + 1;
        int index1906 = num5600;
        numArray1913[index1906] = (byte) 0;
        byte[] numArray1914 = second1;
        int num5602 = num5601;
        int num5603 = num5602 + 1;
        int index1907 = num5602;
        numArray1914[index1907] = (byte) 0;
        byte[] numArray1915 = second1;
        int num5604 = num5603;
        num5561 = num5604 + 1;
        int index1908 = num5604;
        numArray1915[index1908] = (byte) 0;
      }
      int num5605;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.LEDF1])
      {
        byte[] numArray1916 = second1;
        int num5606 = num5561;
        int num5607 = num5606 + 1;
        int index1909 = num5606;
        int num5608 = (int) (byte) ((double) this.ledVal8[0, 0] * (double) num5031);
        numArray1916[index1909] = (byte) num5608;
        byte[] numArray1917 = second1;
        int num5609 = num5607;
        int num5610 = num5609 + 1;
        int index1910 = num5609;
        int num5611 = (int) (byte) ((double) this.ledVal8[0, 1] * (double) num5031);
        numArray1917[index1910] = (byte) num5611;
        byte[] numArray1918 = second1;
        int num5612 = num5610;
        int num5613 = num5612 + 1;
        int index1911 = num5612;
        int num5614 = (int) (byte) ((double) this.ledVal8[0, 2] * (double) num5031);
        numArray1918[index1911] = (byte) num5614;
        byte[] numArray1919 = second1;
        int num5615 = num5613;
        int num5616 = num5615 + 1;
        int index1912 = num5615;
        int num5617 = (int) (byte) ((double) this.ledVal8[1, 0] * (double) num5031);
        numArray1919[index1912] = (byte) num5617;
        byte[] numArray1920 = second1;
        int num5618 = num5616;
        int num5619 = num5618 + 1;
        int index1913 = num5618;
        int num5620 = (int) (byte) ((double) this.ledVal8[1, 1] * (double) num5031);
        numArray1920[index1913] = (byte) num5620;
        byte[] numArray1921 = second1;
        int num5621 = num5619;
        int num5622 = num5621 + 1;
        int index1914 = num5621;
        int num5623 = (int) (byte) ((double) this.ledVal8[1, 2] * (double) num5031);
        numArray1921[index1914] = (byte) num5623;
        byte[] numArray1922 = second1;
        int num5624 = num5622;
        int num5625 = num5624 + 1;
        int index1915 = num5624;
        int num5626 = (int) (byte) ((double) this.ledVal8[2, 0] * (double) num5031);
        numArray1922[index1915] = (byte) num5626;
        byte[] numArray1923 = second1;
        int num5627 = num5625;
        int num5628 = num5627 + 1;
        int index1916 = num5627;
        int num5629 = (int) (byte) ((double) this.ledVal8[2, 1] * (double) num5031);
        numArray1923[index1916] = (byte) num5629;
        byte[] numArray1924 = second1;
        int num5630 = num5628;
        num5605 = num5630 + 1;
        int index1917 = num5630;
        int num5631 = (int) (byte) ((double) this.ledVal8[2, 2] * (double) num5031);
        numArray1924[index1917] = (byte) num5631;
      }
      else
      {
        byte[] numArray1925 = second1;
        int num5632 = num5561;
        int num5633 = num5632 + 1;
        int index1918 = num5632;
        numArray1925[index1918] = (byte) 0;
        byte[] numArray1926 = second1;
        int num5634 = num5633;
        int num5635 = num5634 + 1;
        int index1919 = num5634;
        numArray1926[index1919] = (byte) 0;
        byte[] numArray1927 = second1;
        int num5636 = num5635;
        int num5637 = num5636 + 1;
        int index1920 = num5636;
        numArray1927[index1920] = (byte) 0;
        byte[] numArray1928 = second1;
        int num5638 = num5637;
        int num5639 = num5638 + 1;
        int index1921 = num5638;
        numArray1928[index1921] = (byte) 0;
        byte[] numArray1929 = second1;
        int num5640 = num5639;
        int num5641 = num5640 + 1;
        int index1922 = num5640;
        numArray1929[index1922] = (byte) 0;
        byte[] numArray1930 = second1;
        int num5642 = num5641;
        int num5643 = num5642 + 1;
        int index1923 = num5642;
        numArray1930[index1923] = (byte) 0;
        byte[] numArray1931 = second1;
        int num5644 = num5643;
        int num5645 = num5644 + 1;
        int index1924 = num5644;
        numArray1931[index1924] = (byte) 0;
        byte[] numArray1932 = second1;
        int num5646 = num5645;
        int num5647 = num5646 + 1;
        int index1925 = num5646;
        numArray1932[index1925] = (byte) 0;
        byte[] numArray1933 = second1;
        int num5648 = num5647;
        num5605 = num5648 + 1;
        int index1926 = num5648;
        numArray1933[index1926] = (byte) 0;
      }
      int num5649;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu1])
      {
        byte[] numArray1934 = second1;
        int num5650 = num5605;
        int num5651 = num5650 + 1;
        int index1927 = num5650;
        int num5652 = (int) (byte) ((double) this.ledVal8[2, 0] * (double) num5031);
        numArray1934[index1927] = (byte) num5652;
        byte[] numArray1935 = second1;
        int num5653 = num5651;
        int num5654 = num5653 + 1;
        int index1928 = num5653;
        int num5655 = (int) (byte) ((double) this.ledVal8[2, 1] * (double) num5031);
        numArray1935[index1928] = (byte) num5655;
        byte[] numArray1936 = second1;
        int num5656 = num5654;
        int num5657 = num5656 + 1;
        int index1929 = num5656;
        int num5658 = (int) (byte) ((double) this.ledVal8[2, 2] * (double) num5031);
        numArray1936[index1929] = (byte) num5658;
        byte[] numArray1937 = second1;
        int num5659 = num5657;
        int num5660 = num5659 + 1;
        int index1930 = num5659;
        int num5661 = (int) (byte) ((double) this.ledVal8[3, 0] * (double) num5031);
        numArray1937[index1930] = (byte) num5661;
        byte[] numArray1938 = second1;
        int num5662 = num5660;
        int num5663 = num5662 + 1;
        int index1931 = num5662;
        int num5664 = (int) (byte) ((double) this.ledVal8[3, 1] * (double) num5031);
        numArray1938[index1931] = (byte) num5664;
        byte[] numArray1939 = second1;
        int num5665 = num5663;
        num5649 = num5665 + 1;
        int index1932 = num5665;
        int num5666 = (int) (byte) ((double) this.ledVal8[3, 2] * (double) num5031);
        numArray1939[index1932] = (byte) num5666;
      }
      else
      {
        byte[] numArray1940 = second1;
        int num5667 = num5605;
        int num5668 = num5667 + 1;
        int index1933 = num5667;
        numArray1940[index1933] = (byte) 0;
        byte[] numArray1941 = second1;
        int num5669 = num5668;
        int num5670 = num5669 + 1;
        int index1934 = num5669;
        numArray1941[index1934] = (byte) 0;
        byte[] numArray1942 = second1;
        int num5671 = num5670;
        int num5672 = num5671 + 1;
        int index1935 = num5671;
        numArray1942[index1935] = (byte) 0;
        byte[] numArray1943 = second1;
        int num5673 = num5672;
        int num5674 = num5673 + 1;
        int index1936 = num5673;
        numArray1943[index1936] = (byte) 0;
        byte[] numArray1944 = second1;
        int num5675 = num5674;
        int num5676 = num5675 + 1;
        int index1937 = num5675;
        numArray1944[index1937] = (byte) 0;
        byte[] numArray1945 = second1;
        int num5677 = num5676;
        num5649 = num5677 + 1;
        int index1938 = num5677;
        numArray1945[index1938] = (byte) 0;
      }
      int num5678;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu1])
      {
        byte[] numArray1946 = second1;
        int num5679 = num5649;
        int num5680 = num5679 + 1;
        int index1939 = num5679;
        int num5681 = (int) (byte) ((double) this.ledVal8[6, 0] * (double) num5031);
        numArray1946[index1939] = (byte) num5681;
        byte[] numArray1947 = second1;
        int num5682 = num5680;
        int num5683 = num5682 + 1;
        int index1940 = num5682;
        int num5684 = (int) (byte) ((double) this.ledVal8[6, 1] * (double) num5031);
        numArray1947[index1940] = (byte) num5684;
        byte[] numArray1948 = second1;
        int num5685 = num5683;
        int num5686 = num5685 + 1;
        int index1941 = num5685;
        int num5687 = (int) (byte) ((double) this.ledVal8[6, 2] * (double) num5031);
        numArray1948[index1941] = (byte) num5687;
        byte[] numArray1949 = second1;
        int num5688 = num5686;
        int num5689 = num5688 + 1;
        int index1942 = num5688;
        int num5690 = (int) (byte) ((double) this.ledVal8[7, 0] * (double) num5031);
        numArray1949[index1942] = (byte) num5690;
        byte[] numArray1950 = second1;
        int num5691 = num5689;
        int num5692 = num5691 + 1;
        int index1943 = num5691;
        int num5693 = (int) (byte) ((double) this.ledVal8[7, 1] * (double) num5031);
        numArray1950[index1943] = (byte) num5693;
        byte[] numArray1951 = second1;
        int num5694 = num5692;
        num5678 = num5694 + 1;
        int index1944 = num5694;
        int num5695 = (int) (byte) ((double) this.ledVal8[7, 2] * (double) num5031);
        numArray1951[index1944] = (byte) num5695;
      }
      else
      {
        byte[] numArray1952 = second1;
        int num5696 = num5649;
        int num5697 = num5696 + 1;
        int index1945 = num5696;
        numArray1952[index1945] = (byte) 0;
        byte[] numArray1953 = second1;
        int num5698 = num5697;
        int num5699 = num5698 + 1;
        int index1946 = num5698;
        numArray1953[index1946] = (byte) 0;
        byte[] numArray1954 = second1;
        int num5700 = num5699;
        int num5701 = num5700 + 1;
        int index1947 = num5700;
        numArray1954[index1947] = (byte) 0;
        byte[] numArray1955 = second1;
        int num5702 = num5701;
        int num5703 = num5702 + 1;
        int index1948 = num5702;
        numArray1955[index1948] = (byte) 0;
        byte[] numArray1956 = second1;
        int num5704 = num5703;
        int num5705 = num5704 + 1;
        int index1949 = num5704;
        numArray1956[index1949] = (byte) 0;
        byte[] numArray1957 = second1;
        int num5706 = num5705;
        num5678 = num5706 + 1;
        int index1950 = num5706;
        numArray1957[index1950] = (byte) 0;
      }
      int num5707;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.Gpu2])
      {
        byte[] numArray1958 = second1;
        int num5708 = num5678;
        int num5709 = num5708 + 1;
        int index1951 = num5708;
        int num5710 = (int) (byte) ((double) this.ledVal8[10, 0] * (double) num5031);
        numArray1958[index1951] = (byte) num5710;
        byte[] numArray1959 = second1;
        int num5711 = num5709;
        int num5712 = num5711 + 1;
        int index1952 = num5711;
        int num5713 = (int) (byte) ((double) this.ledVal8[10, 1] * (double) num5031);
        numArray1959[index1952] = (byte) num5713;
        byte[] numArray1960 = second1;
        int num5714 = num5712;
        int num5715 = num5714 + 1;
        int index1953 = num5714;
        int num5716 = (int) (byte) ((double) this.ledVal8[10, 2] * (double) num5031);
        numArray1960[index1953] = (byte) num5716;
        byte[] numArray1961 = second1;
        int num5717 = num5715;
        int num5718 = num5717 + 1;
        int index1954 = num5717;
        int num5719 = (int) (byte) ((double) this.ledVal8[9, 0] * (double) num5031);
        numArray1961[index1954] = (byte) num5719;
        byte[] numArray1962 = second1;
        int num5720 = num5718;
        int num5721 = num5720 + 1;
        int index1955 = num5720;
        int num5722 = (int) (byte) ((double) this.ledVal8[9, 1] * (double) num5031);
        numArray1962[index1955] = (byte) num5722;
        byte[] numArray1963 = second1;
        int num5723 = num5721;
        num5707 = num5723 + 1;
        int index1956 = num5723;
        int num5724 = (int) (byte) ((double) this.ledVal8[9, 2] * (double) num5031);
        numArray1963[index1956] = (byte) num5724;
      }
      else
      {
        byte[] numArray1964 = second1;
        int num5725 = num5678;
        int num5726 = num5725 + 1;
        int index1957 = num5725;
        numArray1964[index1957] = (byte) 0;
        byte[] numArray1965 = second1;
        int num5727 = num5726;
        int num5728 = num5727 + 1;
        int index1958 = num5727;
        numArray1965[index1958] = (byte) 0;
        byte[] numArray1966 = second1;
        int num5729 = num5728;
        int num5730 = num5729 + 1;
        int index1959 = num5729;
        numArray1966[index1959] = (byte) 0;
        byte[] numArray1967 = second1;
        int num5731 = num5730;
        int num5732 = num5731 + 1;
        int index1960 = num5731;
        numArray1967[index1960] = (byte) 0;
        byte[] numArray1968 = second1;
        int num5733 = num5732;
        int num5734 = num5733 + 1;
        int index1961 = num5733;
        numArray1968[index1961] = (byte) 0;
        byte[] numArray1969 = second1;
        int num5735 = num5734;
        num5707 = num5735 + 1;
        int index1962 = num5735;
        numArray1969[index1962] = (byte) 0;
      }
      int num5736;
      if (this.ucScreenLED1.isOn[this.ucScreenLED1.Cpu2])
      {
        byte[] numArray1970 = second1;
        int num5737 = num5707;
        int num5738 = num5737 + 1;
        int index1963 = num5737;
        int num5739 = (int) (byte) ((double) this.ledVal8[6, 0] * (double) num5031);
        numArray1970[index1963] = (byte) num5739;
        byte[] numArray1971 = second1;
        int num5740 = num5738;
        int num5741 = num5740 + 1;
        int index1964 = num5740;
        int num5742 = (int) (byte) ((double) this.ledVal8[6, 1] * (double) num5031);
        numArray1971[index1964] = (byte) num5742;
        byte[] numArray1972 = second1;
        int num5743 = num5741;
        int num5744 = num5743 + 1;
        int index1965 = num5743;
        int num5745 = (int) (byte) ((double) this.ledVal8[6, 2] * (double) num5031);
        numArray1972[index1965] = (byte) num5745;
        byte[] numArray1973 = second1;
        int num5746 = num5744;
        int num5747 = num5746 + 1;
        int index1966 = num5746;
        int num5748 = (int) (byte) ((double) this.ledVal8[5, 0] * (double) num5031);
        numArray1973[index1966] = (byte) num5748;
        byte[] numArray1974 = second1;
        int num5749 = num5747;
        int num5750 = num5749 + 1;
        int index1967 = num5749;
        int num5751 = (int) (byte) ((double) this.ledVal8[5, 1] * (double) num5031);
        numArray1974[index1967] = (byte) num5751;
        byte[] numArray1975 = second1;
        int num5752 = num5750;
        num5736 = num5752 + 1;
        int index1968 = num5752;
        int num5753 = (int) (byte) ((double) this.ledVal8[5, 2] * (double) num5031);
        numArray1975[index1968] = (byte) num5753;
      }
      else
      {
        byte[] numArray1976 = second1;
        int num5754 = num5707;
        int num5755 = num5754 + 1;
        int index1969 = num5754;
        numArray1976[index1969] = (byte) 0;
        byte[] numArray1977 = second1;
        int num5756 = num5755;
        int num5757 = num5756 + 1;
        int index1970 = num5756;
        numArray1977[index1970] = (byte) 0;
        byte[] numArray1978 = second1;
        int num5758 = num5757;
        int num5759 = num5758 + 1;
        int index1971 = num5758;
        numArray1978[index1971] = (byte) 0;
        byte[] numArray1979 = second1;
        int num5760 = num5759;
        int num5761 = num5760 + 1;
        int index1972 = num5760;
        numArray1979[index1972] = (byte) 0;
        byte[] numArray1980 = second1;
        int num5762 = num5761;
        int num5763 = num5762 + 1;
        int index1973 = num5762;
        numArray1980[index1973] = (byte) 0;
        byte[] numArray1981 = second1;
        int num5764 = num5763;
        num5736 = num5764 + 1;
        int index1974 = num5764;
        numArray1981[index1974] = (byte) 0;
      }
      byte[] array1 = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second1).ToArray<byte>();
      byte[] second2 = new byte[48 /*0x30*/];
      int num5765 = 0;
      byte[] numArray1982 = second2;
      int num5766 = num5765;
      int num5767 = num5766 + 1;
      int index1975 = num5766;
      int num5768 = (int) (byte) ((double) this.ledVal8[0, 0] * (double) num5031);
      numArray1982[index1975] = (byte) num5768;
      byte[] numArray1983 = second2;
      int num5769 = num5767;
      int num5770 = num5769 + 1;
      int index1976 = num5769;
      int num5771 = (int) (byte) ((double) this.ledVal8[0, 1] * (double) num5031);
      numArray1983[index1976] = (byte) num5771;
      byte[] numArray1984 = second2;
      int num5772 = num5770;
      int num5773 = num5772 + 1;
      int index1977 = num5772;
      int num5774 = (int) (byte) ((double) this.ledVal8[0, 2] * (double) num5031);
      numArray1984[index1977] = (byte) num5774;
      byte[] numArray1985 = second2;
      int num5775 = num5773;
      int num5776 = num5775 + 1;
      int index1978 = num5775;
      int num5777 = (int) (byte) ((double) this.ledVal8[1, 0] * (double) num5031);
      numArray1985[index1978] = (byte) num5777;
      byte[] numArray1986 = second2;
      int num5778 = num5776;
      int num5779 = num5778 + 1;
      int index1979 = num5778;
      int num5780 = (int) (byte) ((double) this.ledVal8[1, 1] * (double) num5031);
      numArray1986[index1979] = (byte) num5780;
      byte[] numArray1987 = second2;
      int num5781 = num5779;
      int num5782 = num5781 + 1;
      int index1980 = num5781;
      int num5783 = (int) (byte) ((double) this.ledVal8[1, 2] * (double) num5031);
      numArray1987[index1980] = (byte) num5783;
      byte[] numArray1988 = second2;
      int num5784 = num5782;
      int num5785 = num5784 + 1;
      int index1981 = num5784;
      int num5786 = (int) (byte) ((double) this.ledVal8[2, 0] * (double) num5031);
      numArray1988[index1981] = (byte) num5786;
      byte[] numArray1989 = second2;
      int num5787 = num5785;
      int num5788 = num5787 + 1;
      int index1982 = num5787;
      int num5789 = (int) (byte) ((double) this.ledVal8[2, 1] * (double) num5031);
      numArray1989[index1982] = (byte) num5789;
      byte[] numArray1990 = second2;
      int num5790 = num5788;
      int num5791 = num5790 + 1;
      int index1983 = num5790;
      int num5792 = (int) (byte) ((double) this.ledVal8[2, 2] * (double) num5031);
      numArray1990[index1983] = (byte) num5792;
      byte[] numArray1991 = second2;
      int num5793 = num5791;
      int num5794 = num5793 + 1;
      int index1984 = num5793;
      int num5795 = (int) (byte) ((double) this.ledVal8[2, 0] * (double) num5031);
      numArray1991[index1984] = (byte) num5795;
      byte[] numArray1992 = second2;
      int num5796 = num5794;
      int num5797 = num5796 + 1;
      int index1985 = num5796;
      int num5798 = (int) (byte) ((double) this.ledVal8[2, 1] * (double) num5031);
      numArray1992[index1985] = (byte) num5798;
      byte[] numArray1993 = second2;
      int num5799 = num5797;
      int num5800 = num5799 + 1;
      int index1986 = num5799;
      int num5801 = (int) (byte) ((double) this.ledVal8[2, 2] * (double) num5031);
      numArray1993[index1986] = (byte) num5801;
      byte[] numArray1994 = second2;
      int num5802 = num5800;
      int num5803 = num5802 + 1;
      int index1987 = num5802;
      int num5804 = (int) (byte) ((double) this.ledVal8[3, 0] * (double) num5031);
      numArray1994[index1987] = (byte) num5804;
      byte[] numArray1995 = second2;
      int num5805 = num5803;
      int num5806 = num5805 + 1;
      int index1988 = num5805;
      int num5807 = (int) (byte) ((double) this.ledVal8[3, 1] * (double) num5031);
      numArray1995[index1988] = (byte) num5807;
      byte[] numArray1996 = second2;
      int num5808 = num5806;
      int num5809 = num5808 + 1;
      int index1989 = num5808;
      int num5810 = (int) (byte) ((double) this.ledVal8[3, 2] * (double) num5031);
      numArray1996[index1989] = (byte) num5810;
      byte[] numArray1997 = second2;
      int num5811 = num5809;
      int num5812 = num5811 + 1;
      int index1990 = num5811;
      int num5813 = (int) (byte) ((double) this.ledVal8[4, 0] * (double) num5031);
      numArray1997[index1990] = (byte) num5813;
      byte[] numArray1998 = second2;
      int num5814 = num5812;
      int num5815 = num5814 + 1;
      int index1991 = num5814;
      int num5816 = (int) (byte) ((double) this.ledVal8[4, 1] * (double) num5031);
      numArray1998[index1991] = (byte) num5816;
      byte[] numArray1999 = second2;
      int num5817 = num5815;
      int num5818 = num5817 + 1;
      int index1992 = num5817;
      int num5819 = (int) (byte) ((double) this.ledVal8[4, 2] * (double) num5031);
      numArray1999[index1992] = (byte) num5819;
      byte[] numArray2000 = second2;
      int num5820 = num5818;
      int num5821 = num5820 + 1;
      int index1993 = num5820;
      int num5822 = (int) (byte) ((double) this.ledVal8[5, 0] * (double) num5031);
      numArray2000[index1993] = (byte) num5822;
      byte[] numArray2001 = second2;
      int num5823 = num5821;
      int num5824 = num5823 + 1;
      int index1994 = num5823;
      int num5825 = (int) (byte) ((double) this.ledVal8[5, 1] * (double) num5031);
      numArray2001[index1994] = (byte) num5825;
      byte[] numArray2002 = second2;
      int num5826 = num5824;
      int num5827 = num5826 + 1;
      int index1995 = num5826;
      int num5828 = (int) (byte) ((double) this.ledVal8[5, 2] * (double) num5031);
      numArray2002[index1995] = (byte) num5828;
      byte[] numArray2003 = second2;
      int num5829 = num5827;
      int num5830 = num5829 + 1;
      int index1996 = num5829;
      int num5831 = (int) (byte) ((double) this.ledVal8[5, 0] * (double) num5031);
      numArray2003[index1996] = (byte) num5831;
      byte[] numArray2004 = second2;
      int num5832 = num5830;
      int num5833 = num5832 + 1;
      int index1997 = num5832;
      int num5834 = (int) (byte) ((double) this.ledVal8[5, 1] * (double) num5031);
      numArray2004[index1997] = (byte) num5834;
      byte[] numArray2005 = second2;
      int num5835 = num5833;
      int num5836 = num5835 + 1;
      int index1998 = num5835;
      int num5837 = (int) (byte) ((double) this.ledVal8[5, 2] * (double) num5031);
      numArray2005[index1998] = (byte) num5837;
      byte[] numArray2006 = second2;
      int num5838 = num5836;
      int num5839 = num5838 + 1;
      int index1999 = num5838;
      int num5840 = (int) (byte) ((double) this.ledVal8[6, 0] * (double) num5031);
      numArray2006[index1999] = (byte) num5840;
      byte[] numArray2007 = second2;
      int num5841 = num5839;
      int num5842 = num5841 + 1;
      int index2000 = num5841;
      int num5843 = (int) (byte) ((double) this.ledVal8[6, 1] * (double) num5031);
      numArray2007[index2000] = (byte) num5843;
      byte[] numArray2008 = second2;
      int num5844 = num5842;
      int num5845 = num5844 + 1;
      int index2001 = num5844;
      int num5846 = (int) (byte) ((double) this.ledVal8[6, 2] * (double) num5031);
      numArray2008[index2001] = (byte) num5846;
      byte[] numArray2009 = second2;
      int num5847 = num5845;
      int num5848 = num5847 + 1;
      int index2002 = num5847;
      int num5849 = (int) (byte) ((double) this.ledVal8[7, 0] * (double) num5031);
      numArray2009[index2002] = (byte) num5849;
      byte[] numArray2010 = second2;
      int num5850 = num5848;
      int num5851 = num5850 + 1;
      int index2003 = num5850;
      int num5852 = (int) (byte) ((double) this.ledVal8[7, 1] * (double) num5031);
      numArray2010[index2003] = (byte) num5852;
      byte[] numArray2011 = second2;
      int num5853 = num5851;
      int num5854 = num5853 + 1;
      int index2004 = num5853;
      int num5855 = (int) (byte) ((double) this.ledVal8[7, 2] * (double) num5031);
      numArray2011[index2004] = (byte) num5855;
      byte[] numArray2012 = second2;
      int num5856 = num5854;
      int num5857 = num5856 + 1;
      int index2005 = num5856;
      int num5858 = (int) (byte) ((double) this.ledVal8[8, 0] * (double) num5031);
      numArray2012[index2005] = (byte) num5858;
      byte[] numArray2013 = second2;
      int num5859 = num5857;
      int num5860 = num5859 + 1;
      int index2006 = num5859;
      int num5861 = (int) (byte) ((double) this.ledVal8[8, 1] * (double) num5031);
      numArray2013[index2006] = (byte) num5861;
      byte[] numArray2014 = second2;
      int num5862 = num5860;
      int num5863 = num5862 + 1;
      int index2007 = num5862;
      int num5864 = (int) (byte) ((double) this.ledVal8[8, 2] * (double) num5031);
      numArray2014[index2007] = (byte) num5864;
      byte[] numArray2015 = second2;
      int num5865 = num5863;
      int num5866 = num5865 + 1;
      int index2008 = num5865;
      int num5867 = (int) (byte) ((double) this.ledVal8[8, 0] * (double) num5031);
      numArray2015[index2008] = (byte) num5867;
      byte[] numArray2016 = second2;
      int num5868 = num5866;
      int num5869 = num5868 + 1;
      int index2009 = num5868;
      int num5870 = (int) (byte) ((double) this.ledVal8[8, 1] * (double) num5031);
      numArray2016[index2009] = (byte) num5870;
      byte[] numArray2017 = second2;
      int num5871 = num5869;
      int num5872 = num5871 + 1;
      int index2010 = num5871;
      int num5873 = (int) (byte) ((double) this.ledVal8[8, 2] * (double) num5031);
      numArray2017[index2010] = (byte) num5873;
      byte[] numArray2018 = second2;
      int num5874 = num5872;
      int num5875 = num5874 + 1;
      int index2011 = num5874;
      int num5876 = (int) (byte) ((double) this.ledVal8[9, 0] * (double) num5031);
      numArray2018[index2011] = (byte) num5876;
      byte[] numArray2019 = second2;
      int num5877 = num5875;
      int num5878 = num5877 + 1;
      int index2012 = num5877;
      int num5879 = (int) (byte) ((double) this.ledVal8[9, 1] * (double) num5031);
      numArray2019[index2012] = (byte) num5879;
      byte[] numArray2020 = second2;
      int num5880 = num5878;
      int num5881 = num5880 + 1;
      int index2013 = num5880;
      int num5882 = (int) (byte) ((double) this.ledVal8[9, 2] * (double) num5031);
      numArray2020[index2013] = (byte) num5882;
      byte[] numArray2021 = second2;
      int num5883 = num5881;
      int num5884 = num5883 + 1;
      int index2014 = num5883;
      int num5885 = (int) (byte) ((double) this.ledVal8[10, 0] * (double) num5031);
      numArray2021[index2014] = (byte) num5885;
      byte[] numArray2022 = second2;
      int num5886 = num5884;
      int num5887 = num5886 + 1;
      int index2015 = num5886;
      int num5888 = (int) (byte) ((double) this.ledVal8[10, 1] * (double) num5031);
      numArray2022[index2015] = (byte) num5888;
      byte[] numArray2023 = second2;
      int num5889 = num5887;
      int num5890 = num5889 + 1;
      int index2016 = num5889;
      int num5891 = (int) (byte) ((double) this.ledVal8[10, 2] * (double) num5031);
      numArray2023[index2016] = (byte) num5891;
      byte[] numArray2024 = second2;
      int num5892 = num5890;
      int num5893 = num5892 + 1;
      int index2017 = num5892;
      int num5894 = (int) (byte) ((double) this.ledVal8[11, 0] * (double) num5031);
      numArray2024[index2017] = (byte) num5894;
      byte[] numArray2025 = second2;
      int num5895 = num5893;
      int num5896 = num5895 + 1;
      int index2018 = num5895;
      int num5897 = (int) (byte) ((double) this.ledVal8[11, 1] * (double) num5031);
      numArray2025[index2018] = (byte) num5897;
      byte[] numArray2026 = second2;
      int num5898 = num5896;
      int num5899 = num5898 + 1;
      int index2019 = num5898;
      int num5900 = (int) (byte) ((double) this.ledVal8[11, 2] * (double) num5031);
      numArray2026[index2019] = (byte) num5900;
      byte[] numArray2027 = second2;
      int num5901 = num5899;
      int num5902 = num5901 + 1;
      int index2020 = num5901;
      int num5903 = (int) (byte) ((double) this.ledVal8[11, 0] * (double) num5031);
      numArray2027[index2020] = (byte) num5903;
      byte[] numArray2028 = second2;
      int num5904 = num5902;
      int num5905 = num5904 + 1;
      int index2021 = num5904;
      int num5906 = (int) (byte) ((double) this.ledVal8[11, 1] * (double) num5031);
      numArray2028[index2021] = (byte) num5906;
      byte[] numArray2029 = second2;
      int num5907 = num5905;
      num5736 = num5907 + 1;
      int index2022 = num5907;
      int num5908 = (int) (byte) ((double) this.ledVal8[11, 2] * (double) num5031);
      numArray2029[index2022] = (byte) num5908;
      byte[] array2 = ((IEnumerable<byte>) array1).Concat<byte>((IEnumerable<byte>) second2).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array2, (object) array2.Length);
    }
    else if (this.nowLedStyle == (byte) 9)
    {
      byte[] numArray2030 = new byte[189];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray2030.Length,
        (byte) (numArray2030.Length >> 8),
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 61; ++index)
      {
        if (this.myOnOff == (byte) 0)
        {
          numArray2030[index * 3] = (byte) 0;
          numArray2030[index * 3 + 1] = (byte) 0;
          numArray2030[index * 3 + 2] = (byte) 0;
        }
        else if (this.ucScreenLED1.isOn[index])
        {
          numArray2030[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2 + (double) num1);
          numArray2030[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2 + (double) num1);
          numArray2030[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2 + (double) num1);
        }
        else
        {
          numArray2030[index * 3] = (byte) 0;
          numArray2030[index * 3 + 1] = (byte) 0;
          numArray2030[index * 3 + 2] = (byte) 0;
        }
      }
      int num5909 = 0;
      byte[] second = new byte[numArray2030.Length];
      byte[] numArray2031 = second;
      int num5910 = num5909;
      int num5911 = num5910 + 1;
      int index2023 = num5910;
      int num5912 = (int) numArray2030[this.ucScreenLED1.ZhuangShi7 * 3];
      numArray2031[index2023] = (byte) num5912;
      byte[] numArray2032 = second;
      int num5913 = num5911;
      int num5914 = num5913 + 1;
      int index2024 = num5913;
      int num5915 = (int) numArray2030[this.ucScreenLED1.ZhuangShi7 * 3 + 1];
      numArray2032[index2024] = (byte) num5915;
      byte[] numArray2033 = second;
      int num5916 = num5914;
      int num5917 = num5916 + 1;
      int index2025 = num5916;
      int num5918 = (int) numArray2030[this.ucScreenLED1.ZhuangShi7 * 3 + 2];
      numArray2033[index2025] = (byte) num5918;
      byte[] numArray2034 = second;
      int num5919 = num5917;
      int num5920 = num5919 + 1;
      int index2026 = num5919;
      int num5921 = (int) numArray2030[this.ucScreenLED1.ZhuangShi6 * 3];
      numArray2034[index2026] = (byte) num5921;
      byte[] numArray2035 = second;
      int num5922 = num5920;
      int num5923 = num5922 + 1;
      int index2027 = num5922;
      int num5924 = (int) numArray2030[this.ucScreenLED1.ZhuangShi6 * 3 + 1];
      numArray2035[index2027] = (byte) num5924;
      byte[] numArray2036 = second;
      int num5925 = num5923;
      int num5926 = num5925 + 1;
      int index2028 = num5925;
      int num5927 = (int) numArray2030[this.ucScreenLED1.ZhuangShi6 * 3 + 2];
      numArray2036[index2028] = (byte) num5927;
      byte[] numArray2037 = second;
      int num5928 = num5926;
      int num5929 = num5928 + 1;
      int index2029 = num5928;
      int num5930 = (int) numArray2030[this.ucScreenLED1.ZhuangShi5 * 3];
      numArray2037[index2029] = (byte) num5930;
      byte[] numArray2038 = second;
      int num5931 = num5929;
      int num5932 = num5931 + 1;
      int index2030 = num5931;
      int num5933 = (int) numArray2030[this.ucScreenLED1.ZhuangShi5 * 3 + 1];
      numArray2038[index2030] = (byte) num5933;
      byte[] numArray2039 = second;
      int num5934 = num5932;
      int num5935 = num5934 + 1;
      int index2031 = num5934;
      int num5936 = (int) numArray2030[this.ucScreenLED1.ZhuangShi5 * 3 + 2];
      numArray2039[index2031] = (byte) num5936;
      byte[] numArray2040 = second;
      int num5937 = num5935;
      int num5938 = num5937 + 1;
      int index2032 = num5937;
      int num5939 = (int) numArray2030[this.ucScreenLED1.ZhuangShi4 * 3];
      numArray2040[index2032] = (byte) num5939;
      byte[] numArray2041 = second;
      int num5940 = num5938;
      int num5941 = num5940 + 1;
      int index2033 = num5940;
      int num5942 = (int) numArray2030[this.ucScreenLED1.ZhuangShi4 * 3 + 1];
      numArray2041[index2033] = (byte) num5942;
      byte[] numArray2042 = second;
      int num5943 = num5941;
      int num5944 = num5943 + 1;
      int index2034 = num5943;
      int num5945 = (int) numArray2030[this.ucScreenLED1.ZhuangShi4 * 3 + 2];
      numArray2042[index2034] = (byte) num5945;
      byte[] numArray2043 = second;
      int num5946 = num5944;
      int num5947 = num5946 + 1;
      int index2035 = num5946;
      int num5948 = (int) numArray2030[this.ucScreenLED1.ZhuangShi3 * 3];
      numArray2043[index2035] = (byte) num5948;
      byte[] numArray2044 = second;
      int num5949 = num5947;
      int num5950 = num5949 + 1;
      int index2036 = num5949;
      int num5951 = (int) numArray2030[this.ucScreenLED1.ZhuangShi3 * 3 + 1];
      numArray2044[index2036] = (byte) num5951;
      byte[] numArray2045 = second;
      int num5952 = num5950;
      int num5953 = num5952 + 1;
      int index2037 = num5952;
      int num5954 = (int) numArray2030[this.ucScreenLED1.ZhuangShi3 * 3 + 2];
      numArray2045[index2037] = (byte) num5954;
      byte[] numArray2046 = second;
      int num5955 = num5953;
      int num5956 = num5955 + 1;
      int index2038 = num5955;
      int num5957 = (int) numArray2030[this.ucScreenLED1.ZhuangShi2 * 3];
      numArray2046[index2038] = (byte) num5957;
      byte[] numArray2047 = second;
      int num5958 = num5956;
      int num5959 = num5958 + 1;
      int index2039 = num5958;
      int num5960 = (int) numArray2030[this.ucScreenLED1.ZhuangShi2 * 3 + 1];
      numArray2047[index2039] = (byte) num5960;
      byte[] numArray2048 = second;
      int num5961 = num5959;
      int num5962 = num5961 + 1;
      int index2040 = num5961;
      int num5963 = (int) numArray2030[this.ucScreenLED1.ZhuangShi2 * 3 + 2];
      numArray2048[index2040] = (byte) num5963;
      byte[] numArray2049 = second;
      int num5964 = num5962;
      int num5965 = num5964 + 1;
      int index2041 = num5964;
      int num5966 = (int) numArray2030[this.ucScreenLED1.ZhuangShi1 * 3];
      numArray2049[index2041] = (byte) num5966;
      byte[] numArray2050 = second;
      int num5967 = num5965;
      int num5968 = num5967 + 1;
      int index2042 = num5967;
      int num5969 = (int) numArray2030[this.ucScreenLED1.ZhuangShi1 * 3 + 1];
      numArray2050[index2042] = (byte) num5969;
      byte[] numArray2051 = second;
      int num5970 = num5968;
      int num5971 = num5970 + 1;
      int index2043 = num5970;
      int num5972 = (int) numArray2030[this.ucScreenLED1.ZhuangShi1 * 3 + 2];
      numArray2051[index2043] = (byte) num5972;
      byte[] numArray2052 = second;
      int num5973 = num5971;
      int num5974 = num5973 + 1;
      int index2044 = num5973;
      int num5975 = (int) numArray2030[this.ucScreenLED1.LEDC8 * 3];
      numArray2052[index2044] = (byte) num5975;
      byte[] numArray2053 = second;
      int num5976 = num5974;
      int num5977 = num5976 + 1;
      int index2045 = num5976;
      int num5978 = (int) numArray2030[this.ucScreenLED1.LEDC8 * 3 + 1];
      numArray2053[index2045] = (byte) num5978;
      byte[] numArray2054 = second;
      int num5979 = num5977;
      int num5980 = num5979 + 1;
      int index2046 = num5979;
      int num5981 = (int) numArray2030[this.ucScreenLED1.LEDC8 * 3 + 2];
      numArray2054[index2046] = (byte) num5981;
      byte[] numArray2055 = second;
      int num5982 = num5980;
      int num5983 = num5982 + 1;
      int index2047 = num5982;
      int num5984 = (int) numArray2030[this.ucScreenLED1.LEDB8 * 3];
      numArray2055[index2047] = (byte) num5984;
      byte[] numArray2056 = second;
      int num5985 = num5983;
      int num5986 = num5985 + 1;
      int index2048 = num5985;
      int num5987 = (int) numArray2030[this.ucScreenLED1.LEDB8 * 3 + 1];
      numArray2056[index2048] = (byte) num5987;
      byte[] numArray2057 = second;
      int num5988 = num5986;
      int num5989 = num5988 + 1;
      int index2049 = num5988;
      int num5990 = (int) numArray2030[this.ucScreenLED1.LEDB8 * 3 + 2];
      numArray2057[index2049] = (byte) num5990;
      byte[] numArray2058 = second;
      int num5991 = num5989;
      int num5992 = num5991 + 1;
      int index2050 = num5991;
      int num5993 = (int) numArray2030[this.ucScreenLED1.LEDF5 * 3];
      numArray2058[index2050] = (byte) num5993;
      byte[] numArray2059 = second;
      int num5994 = num5992;
      int num5995 = num5994 + 1;
      int index2051 = num5994;
      int num5996 = (int) numArray2030[this.ucScreenLED1.LEDF5 * 3 + 1];
      numArray2059[index2051] = (byte) num5996;
      byte[] numArray2060 = second;
      int num5997 = num5995;
      int num5998 = num5997 + 1;
      int index2052 = num5997;
      int num5999 = (int) numArray2030[this.ucScreenLED1.LEDF5 * 3 + 2];
      numArray2060[index2052] = (byte) num5999;
      byte[] numArray2061 = second;
      int num6000 = num5998;
      int num6001 = num6000 + 1;
      int index2053 = num6000;
      int num6002 = (int) numArray2030[this.ucScreenLED1.LEDA5 * 3];
      numArray2061[index2053] = (byte) num6002;
      byte[] numArray2062 = second;
      int num6003 = num6001;
      int num6004 = num6003 + 1;
      int index2054 = num6003;
      int num6005 = (int) numArray2030[this.ucScreenLED1.LEDA5 * 3 + 1];
      numArray2062[index2054] = (byte) num6005;
      byte[] numArray2063 = second;
      int num6006 = num6004;
      int num6007 = num6006 + 1;
      int index2055 = num6006;
      int num6008 = (int) numArray2030[this.ucScreenLED1.LEDA5 * 3 + 2];
      numArray2063[index2055] = (byte) num6008;
      byte[] numArray2064 = second;
      int num6009 = num6007;
      int num6010 = num6009 + 1;
      int index2056 = num6009;
      int num6011 = (int) numArray2030[this.ucScreenLED1.LEDB5 * 3];
      numArray2064[index2056] = (byte) num6011;
      byte[] numArray2065 = second;
      int num6012 = num6010;
      int num6013 = num6012 + 1;
      int index2057 = num6012;
      int num6014 = (int) numArray2030[this.ucScreenLED1.LEDB5 * 3 + 1];
      numArray2065[index2057] = (byte) num6014;
      byte[] numArray2066 = second;
      int num6015 = num6013;
      int num6016 = num6015 + 1;
      int index2058 = num6015;
      int num6017 = (int) numArray2030[this.ucScreenLED1.LEDB5 * 3 + 2];
      numArray2066[index2058] = (byte) num6017;
      byte[] numArray2067 = second;
      int num6018 = num6016;
      int num6019 = num6018 + 1;
      int index2059 = num6018;
      int num6020 = (int) numArray2030[this.ucScreenLED1.LEDG5 * 3];
      numArray2067[index2059] = (byte) num6020;
      byte[] numArray2068 = second;
      int num6021 = num6019;
      int num6022 = num6021 + 1;
      int index2060 = num6021;
      int num6023 = (int) numArray2030[this.ucScreenLED1.LEDG5 * 3 + 1];
      numArray2068[index2060] = (byte) num6023;
      byte[] numArray2069 = second;
      int num6024 = num6022;
      int num6025 = num6024 + 1;
      int index2061 = num6024;
      int num6026 = (int) numArray2030[this.ucScreenLED1.LEDG5 * 3 + 2];
      numArray2069[index2061] = (byte) num6026;
      byte[] numArray2070 = second;
      int num6027 = num6025;
      int num6028 = num6027 + 1;
      int index2062 = num6027;
      int num6029 = (int) numArray2030[this.ucScreenLED1.LEDE5 * 3];
      numArray2070[index2062] = (byte) num6029;
      byte[] numArray2071 = second;
      int num6030 = num6028;
      int num6031 = num6030 + 1;
      int index2063 = num6030;
      int num6032 = (int) numArray2030[this.ucScreenLED1.LEDE5 * 3 + 1];
      numArray2071[index2063] = (byte) num6032;
      byte[] numArray2072 = second;
      int num6033 = num6031;
      int num6034 = num6033 + 1;
      int index2064 = num6033;
      int num6035 = (int) numArray2030[this.ucScreenLED1.LEDE5 * 3 + 2];
      numArray2072[index2064] = (byte) num6035;
      byte[] numArray2073 = second;
      int num6036 = num6034;
      int num6037 = num6036 + 1;
      int index2065 = num6036;
      int num6038 = (int) numArray2030[this.ucScreenLED1.LEDD5 * 3];
      numArray2073[index2065] = (byte) num6038;
      byte[] numArray2074 = second;
      int num6039 = num6037;
      int num6040 = num6039 + 1;
      int index2066 = num6039;
      int num6041 = (int) numArray2030[this.ucScreenLED1.LEDD5 * 3 + 1];
      numArray2074[index2066] = (byte) num6041;
      byte[] numArray2075 = second;
      int num6042 = num6040;
      int num6043 = num6042 + 1;
      int index2067 = num6042;
      int num6044 = (int) numArray2030[this.ucScreenLED1.LEDD5 * 3 + 2];
      numArray2075[index2067] = (byte) num6044;
      byte[] numArray2076 = second;
      int num6045 = num6043;
      int num6046 = num6045 + 1;
      int index2068 = num6045;
      int num6047 = (int) numArray2030[this.ucScreenLED1.LEDC5 * 3];
      numArray2076[index2068] = (byte) num6047;
      byte[] numArray2077 = second;
      int num6048 = num6046;
      int num6049 = num6048 + 1;
      int index2069 = num6048;
      int num6050 = (int) numArray2030[this.ucScreenLED1.LEDC5 * 3 + 1];
      numArray2077[index2069] = (byte) num6050;
      byte[] numArray2078 = second;
      int num6051 = num6049;
      int num6052 = num6051 + 1;
      int index2070 = num6051;
      int num6053 = (int) numArray2030[this.ucScreenLED1.LEDC5 * 3 + 2];
      numArray2078[index2070] = (byte) num6053;
      byte[] numArray2079 = second;
      int num6054 = num6052;
      int num6055 = num6054 + 1;
      int index2071 = num6054;
      int num6056 = (int) numArray2030[this.ucScreenLED1.Riqi * 3];
      numArray2079[index2071] = (byte) num6056;
      byte[] numArray2080 = second;
      int num6057 = num6055;
      int num6058 = num6057 + 1;
      int index2072 = num6057;
      int num6059 = (int) numArray2030[this.ucScreenLED1.Riqi * 3 + 1];
      numArray2080[index2072] = (byte) num6059;
      byte[] numArray2081 = second;
      int num6060 = num6058;
      int num6061 = num6060 + 1;
      int index2073 = num6060;
      int num6062 = (int) numArray2030[this.ucScreenLED1.Riqi * 3 + 2];
      numArray2081[index2073] = (byte) num6062;
      byte[] numArray2082 = second;
      int num6063 = num6061;
      int num6064 = num6063 + 1;
      int index2074 = num6063;
      int num6065 = (int) numArray2030[this.ucScreenLED1.Riqi * 3];
      numArray2082[index2074] = (byte) num6065;
      byte[] numArray2083 = second;
      int num6066 = num6064;
      int num6067 = num6066 + 1;
      int index2075 = num6066;
      int num6068 = (int) numArray2030[this.ucScreenLED1.Riqi * 3 + 1];
      numArray2083[index2075] = (byte) num6068;
      byte[] numArray2084 = second;
      int num6069 = num6067;
      int num6070 = num6069 + 1;
      int index2076 = num6069;
      int num6071 = (int) numArray2030[this.ucScreenLED1.Riqi * 3 + 2];
      numArray2084[index2076] = (byte) num6071;
      byte[] numArray2085 = second;
      int num6072 = num6070;
      int num6073 = num6072 + 1;
      int index2077 = num6072;
      int num6074 = (int) numArray2030[this.ucScreenLED1.Riqi * 3];
      numArray2085[index2077] = (byte) num6074;
      byte[] numArray2086 = second;
      int num6075 = num6073;
      int num6076 = num6075 + 1;
      int index2078 = num6075;
      int num6077 = (int) numArray2030[this.ucScreenLED1.Riqi * 3 + 1];
      numArray2086[index2078] = (byte) num6077;
      byte[] numArray2087 = second;
      int num6078 = num6076;
      int num6079 = num6078 + 1;
      int index2079 = num6078;
      int num6080 = (int) numArray2030[this.ucScreenLED1.Riqi * 3 + 2];
      numArray2087[index2079] = (byte) num6080;
      byte[] numArray2088 = second;
      int num6081 = num6079;
      int num6082 = num6081 + 1;
      int index2080 = num6081;
      int num6083 = (int) numArray2030[this.ucScreenLED1.LEDF6 * 3];
      numArray2088[index2080] = (byte) num6083;
      byte[] numArray2089 = second;
      int num6084 = num6082;
      int num6085 = num6084 + 1;
      int index2081 = num6084;
      int num6086 = (int) numArray2030[this.ucScreenLED1.LEDF6 * 3 + 1];
      numArray2089[index2081] = (byte) num6086;
      byte[] numArray2090 = second;
      int num6087 = num6085;
      int num6088 = num6087 + 1;
      int index2082 = num6087;
      int num6089 = (int) numArray2030[this.ucScreenLED1.LEDF6 * 3 + 2];
      numArray2090[index2082] = (byte) num6089;
      byte[] numArray2091 = second;
      int num6090 = num6088;
      int num6091 = num6090 + 1;
      int index2083 = num6090;
      int num6092 = (int) numArray2030[this.ucScreenLED1.LEDA6 * 3];
      numArray2091[index2083] = (byte) num6092;
      byte[] numArray2092 = second;
      int num6093 = num6091;
      int num6094 = num6093 + 1;
      int index2084 = num6093;
      int num6095 = (int) numArray2030[this.ucScreenLED1.LEDA6 * 3 + 1];
      numArray2092[index2084] = (byte) num6095;
      byte[] numArray2093 = second;
      int num6096 = num6094;
      int num6097 = num6096 + 1;
      int index2085 = num6096;
      int num6098 = (int) numArray2030[this.ucScreenLED1.LEDA6 * 3 + 2];
      numArray2093[index2085] = (byte) num6098;
      byte[] numArray2094 = second;
      int num6099 = num6097;
      int num6100 = num6099 + 1;
      int index2086 = num6099;
      int num6101 = (int) numArray2030[this.ucScreenLED1.LEDB6 * 3];
      numArray2094[index2086] = (byte) num6101;
      byte[] numArray2095 = second;
      int num6102 = num6100;
      int num6103 = num6102 + 1;
      int index2087 = num6102;
      int num6104 = (int) numArray2030[this.ucScreenLED1.LEDB6 * 3 + 1];
      numArray2095[index2087] = (byte) num6104;
      byte[] numArray2096 = second;
      int num6105 = num6103;
      int num6106 = num6105 + 1;
      int index2088 = num6105;
      int num6107 = (int) numArray2030[this.ucScreenLED1.LEDB6 * 3 + 2];
      numArray2096[index2088] = (byte) num6107;
      byte[] numArray2097 = second;
      int num6108 = num6106;
      int num6109 = num6108 + 1;
      int index2089 = num6108;
      int num6110 = (int) numArray2030[this.ucScreenLED1.LEDG6 * 3];
      numArray2097[index2089] = (byte) num6110;
      byte[] numArray2098 = second;
      int num6111 = num6109;
      int num6112 = num6111 + 1;
      int index2090 = num6111;
      int num6113 = (int) numArray2030[this.ucScreenLED1.LEDG6 * 3 + 1];
      numArray2098[index2090] = (byte) num6113;
      byte[] numArray2099 = second;
      int num6114 = num6112;
      int num6115 = num6114 + 1;
      int index2091 = num6114;
      int num6116 = (int) numArray2030[this.ucScreenLED1.LEDG6 * 3 + 2];
      numArray2099[index2091] = (byte) num6116;
      byte[] numArray2100 = second;
      int num6117 = num6115;
      int num6118 = num6117 + 1;
      int index2092 = num6117;
      int num6119 = (int) numArray2030[this.ucScreenLED1.LEDE6 * 3];
      numArray2100[index2092] = (byte) num6119;
      byte[] numArray2101 = second;
      int num6120 = num6118;
      int num6121 = num6120 + 1;
      int index2093 = num6120;
      int num6122 = (int) numArray2030[this.ucScreenLED1.LEDE6 * 3 + 1];
      numArray2101[index2093] = (byte) num6122;
      byte[] numArray2102 = second;
      int num6123 = num6121;
      int num6124 = num6123 + 1;
      int index2094 = num6123;
      int num6125 = (int) numArray2030[this.ucScreenLED1.LEDE6 * 3 + 2];
      numArray2102[index2094] = (byte) num6125;
      byte[] numArray2103 = second;
      int num6126 = num6124;
      int num6127 = num6126 + 1;
      int index2095 = num6126;
      int num6128 = (int) numArray2030[this.ucScreenLED1.LEDD6 * 3];
      numArray2103[index2095] = (byte) num6128;
      byte[] numArray2104 = second;
      int num6129 = num6127;
      int num6130 = num6129 + 1;
      int index2096 = num6129;
      int num6131 = (int) numArray2030[this.ucScreenLED1.LEDD6 * 3 + 1];
      numArray2104[index2096] = (byte) num6131;
      byte[] numArray2105 = second;
      int num6132 = num6130;
      int num6133 = num6132 + 1;
      int index2097 = num6132;
      int num6134 = (int) numArray2030[this.ucScreenLED1.LEDD6 * 3 + 2];
      numArray2105[index2097] = (byte) num6134;
      byte[] numArray2106 = second;
      int num6135 = num6133;
      int num6136 = num6135 + 1;
      int index2098 = num6135;
      int num6137 = (int) numArray2030[this.ucScreenLED1.LEDC6 * 3];
      numArray2106[index2098] = (byte) num6137;
      byte[] numArray2107 = second;
      int num6138 = num6136;
      int num6139 = num6138 + 1;
      int index2099 = num6138;
      int num6140 = (int) numArray2030[this.ucScreenLED1.LEDC6 * 3 + 1];
      numArray2107[index2099] = (byte) num6140;
      byte[] numArray2108 = second;
      int num6141 = num6139;
      int num6142 = num6141 + 1;
      int index2100 = num6141;
      int num6143 = (int) numArray2030[this.ucScreenLED1.LEDC6 * 3 + 2];
      numArray2108[index2100] = (byte) num6143;
      byte[] numArray2109 = second;
      int num6144 = num6142;
      int num6145 = num6144 + 1;
      int index2101 = num6144;
      int num6146 = (int) numArray2030[this.ucScreenLED1.LEDF7 * 3];
      numArray2109[index2101] = (byte) num6146;
      byte[] numArray2110 = second;
      int num6147 = num6145;
      int num6148 = num6147 + 1;
      int index2102 = num6147;
      int num6149 = (int) numArray2030[this.ucScreenLED1.LEDF7 * 3 + 1];
      numArray2110[index2102] = (byte) num6149;
      byte[] numArray2111 = second;
      int num6150 = num6148;
      int num6151 = num6150 + 1;
      int index2103 = num6150;
      int num6152 = (int) numArray2030[this.ucScreenLED1.LEDF7 * 3 + 2];
      numArray2111[index2103] = (byte) num6152;
      byte[] numArray2112 = second;
      int num6153 = num6151;
      int num6154 = num6153 + 1;
      int index2104 = num6153;
      int num6155 = (int) numArray2030[this.ucScreenLED1.LEDA7 * 3];
      numArray2112[index2104] = (byte) num6155;
      byte[] numArray2113 = second;
      int num6156 = num6154;
      int num6157 = num6156 + 1;
      int index2105 = num6156;
      int num6158 = (int) numArray2030[this.ucScreenLED1.LEDA7 * 3 + 1];
      numArray2113[index2105] = (byte) num6158;
      byte[] numArray2114 = second;
      int num6159 = num6157;
      int num6160 = num6159 + 1;
      int index2106 = num6159;
      int num6161 = (int) numArray2030[this.ucScreenLED1.LEDA7 * 3 + 2];
      numArray2114[index2106] = (byte) num6161;
      byte[] numArray2115 = second;
      int num6162 = num6160;
      int num6163 = num6162 + 1;
      int index2107 = num6162;
      int num6164 = (int) numArray2030[this.ucScreenLED1.LEDB7 * 3];
      numArray2115[index2107] = (byte) num6164;
      byte[] numArray2116 = second;
      int num6165 = num6163;
      int num6166 = num6165 + 1;
      int index2108 = num6165;
      int num6167 = (int) numArray2030[this.ucScreenLED1.LEDB7 * 3 + 1];
      numArray2116[index2108] = (byte) num6167;
      byte[] numArray2117 = second;
      int num6168 = num6166;
      int num6169 = num6168 + 1;
      int index2109 = num6168;
      int num6170 = (int) numArray2030[this.ucScreenLED1.LEDB7 * 3 + 2];
      numArray2117[index2109] = (byte) num6170;
      byte[] numArray2118 = second;
      int num6171 = num6169;
      int num6172 = num6171 + 1;
      int index2110 = num6171;
      int num6173 = (int) numArray2030[this.ucScreenLED1.LEDG7 * 3];
      numArray2118[index2110] = (byte) num6173;
      byte[] numArray2119 = second;
      int num6174 = num6172;
      int num6175 = num6174 + 1;
      int index2111 = num6174;
      int num6176 = (int) numArray2030[this.ucScreenLED1.LEDG7 * 3 + 1];
      numArray2119[index2111] = (byte) num6176;
      byte[] numArray2120 = second;
      int num6177 = num6175;
      int num6178 = num6177 + 1;
      int index2112 = num6177;
      int num6179 = (int) numArray2030[this.ucScreenLED1.LEDG7 * 3 + 2];
      numArray2120[index2112] = (byte) num6179;
      byte[] numArray2121 = second;
      int num6180 = num6178;
      int num6181 = num6180 + 1;
      int index2113 = num6180;
      int num6182 = (int) numArray2030[this.ucScreenLED1.LEDE7 * 3];
      numArray2121[index2113] = (byte) num6182;
      byte[] numArray2122 = second;
      int num6183 = num6181;
      int num6184 = num6183 + 1;
      int index2114 = num6183;
      int num6185 = (int) numArray2030[this.ucScreenLED1.LEDE7 * 3 + 1];
      numArray2122[index2114] = (byte) num6185;
      byte[] numArray2123 = second;
      int num6186 = num6184;
      int num6187 = num6186 + 1;
      int index2115 = num6186;
      int num6188 = (int) numArray2030[this.ucScreenLED1.LEDE7 * 3 + 2];
      numArray2123[index2115] = (byte) num6188;
      byte[] numArray2124 = second;
      int num6189 = num6187;
      int num6190 = num6189 + 1;
      int index2116 = num6189;
      int num6191 = (int) numArray2030[this.ucScreenLED1.LEDD7 * 3];
      numArray2124[index2116] = (byte) num6191;
      byte[] numArray2125 = second;
      int num6192 = num6190;
      int num6193 = num6192 + 1;
      int index2117 = num6192;
      int num6194 = (int) numArray2030[this.ucScreenLED1.LEDD7 * 3 + 1];
      numArray2125[index2117] = (byte) num6194;
      byte[] numArray2126 = second;
      int num6195 = num6193;
      int num6196 = num6195 + 1;
      int index2118 = num6195;
      int num6197 = (int) numArray2030[this.ucScreenLED1.LEDD7 * 3 + 2];
      numArray2126[index2118] = (byte) num6197;
      byte[] numArray2127 = second;
      int num6198 = num6196;
      int num6199 = num6198 + 1;
      int index2119 = num6198;
      int num6200 = (int) numArray2030[this.ucScreenLED1.LEDC7 * 3];
      numArray2127[index2119] = (byte) num6200;
      byte[] numArray2128 = second;
      int num6201 = num6199;
      int num6202 = num6201 + 1;
      int index2120 = num6201;
      int num6203 = (int) numArray2030[this.ucScreenLED1.LEDC7 * 3 + 1];
      numArray2128[index2120] = (byte) num6203;
      byte[] numArray2129 = second;
      int num6204 = num6202;
      int num6205 = num6204 + 1;
      int index2121 = num6204;
      int num6206 = (int) numArray2030[this.ucScreenLED1.LEDC7 * 3 + 2];
      numArray2129[index2121] = (byte) num6206;
      byte[] numArray2130 = second;
      int num6207 = num6205;
      int num6208 = num6207 + 1;
      int index2122 = num6207;
      int num6209 = (int) numArray2030[this.ucScreenLED1.LEDC4 * 3];
      numArray2130[index2122] = (byte) num6209;
      byte[] numArray2131 = second;
      int num6210 = num6208;
      int num6211 = num6210 + 1;
      int index2123 = num6210;
      int num6212 = (int) numArray2030[this.ucScreenLED1.LEDC4 * 3 + 1];
      numArray2131[index2123] = (byte) num6212;
      byte[] numArray2132 = second;
      int num6213 = num6211;
      int num6214 = num6213 + 1;
      int index2124 = num6213;
      int num6215 = (int) numArray2030[this.ucScreenLED1.LEDC4 * 3 + 2];
      numArray2132[index2124] = (byte) num6215;
      byte[] numArray2133 = second;
      int num6216 = num6214;
      int num6217 = num6216 + 1;
      int index2125 = num6216;
      int num6218 = (int) numArray2030[this.ucScreenLED1.LEDD4 * 3];
      numArray2133[index2125] = (byte) num6218;
      byte[] numArray2134 = second;
      int num6219 = num6217;
      int num6220 = num6219 + 1;
      int index2126 = num6219;
      int num6221 = (int) numArray2030[this.ucScreenLED1.LEDD4 * 3 + 1];
      numArray2134[index2126] = (byte) num6221;
      byte[] numArray2135 = second;
      int num6222 = num6220;
      int num6223 = num6222 + 1;
      int index2127 = num6222;
      int num6224 = (int) numArray2030[this.ucScreenLED1.LEDD4 * 3 + 2];
      numArray2135[index2127] = (byte) num6224;
      byte[] numArray2136 = second;
      int num6225 = num6223;
      int num6226 = num6225 + 1;
      int index2128 = num6225;
      int num6227 = (int) numArray2030[this.ucScreenLED1.LEDE4 * 3];
      numArray2136[index2128] = (byte) num6227;
      byte[] numArray2137 = second;
      int num6228 = num6226;
      int num6229 = num6228 + 1;
      int index2129 = num6228;
      int num6230 = (int) numArray2030[this.ucScreenLED1.LEDE4 * 3 + 1];
      numArray2137[index2129] = (byte) num6230;
      byte[] numArray2138 = second;
      int num6231 = num6229;
      int num6232 = num6231 + 1;
      int index2130 = num6231;
      int num6233 = (int) numArray2030[this.ucScreenLED1.LEDE4 * 3 + 2];
      numArray2138[index2130] = (byte) num6233;
      byte[] numArray2139 = second;
      int num6234 = num6232;
      int num6235 = num6234 + 1;
      int index2131 = num6234;
      int num6236 = (int) numArray2030[this.ucScreenLED1.LEDG4 * 3];
      numArray2139[index2131] = (byte) num6236;
      byte[] numArray2140 = second;
      int num6237 = num6235;
      int num6238 = num6237 + 1;
      int index2132 = num6237;
      int num6239 = (int) numArray2030[this.ucScreenLED1.LEDG4 * 3 + 1];
      numArray2140[index2132] = (byte) num6239;
      byte[] numArray2141 = second;
      int num6240 = num6238;
      int num6241 = num6240 + 1;
      int index2133 = num6240;
      int num6242 = (int) numArray2030[this.ucScreenLED1.LEDG4 * 3 + 2];
      numArray2141[index2133] = (byte) num6242;
      byte[] numArray2142 = second;
      int num6243 = num6241;
      int num6244 = num6243 + 1;
      int index2134 = num6243;
      int num6245 = (int) numArray2030[this.ucScreenLED1.LEDB4 * 3];
      numArray2142[index2134] = (byte) num6245;
      byte[] numArray2143 = second;
      int num6246 = num6244;
      int num6247 = num6246 + 1;
      int index2135 = num6246;
      int num6248 = (int) numArray2030[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray2143[index2135] = (byte) num6248;
      byte[] numArray2144 = second;
      int num6249 = num6247;
      int num6250 = num6249 + 1;
      int index2136 = num6249;
      int num6251 = (int) numArray2030[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray2144[index2136] = (byte) num6251;
      byte[] numArray2145 = second;
      int num6252 = num6250;
      int num6253 = num6252 + 1;
      int index2137 = num6252;
      int num6254 = (int) numArray2030[this.ucScreenLED1.LEDA4 * 3];
      numArray2145[index2137] = (byte) num6254;
      byte[] numArray2146 = second;
      int num6255 = num6253;
      int num6256 = num6255 + 1;
      int index2138 = num6255;
      int num6257 = (int) numArray2030[this.ucScreenLED1.LEDA4 * 3 + 1];
      numArray2146[index2138] = (byte) num6257;
      byte[] numArray2147 = second;
      int num6258 = num6256;
      int num6259 = num6258 + 1;
      int index2139 = num6258;
      int num6260 = (int) numArray2030[this.ucScreenLED1.LEDA4 * 3 + 2];
      numArray2147[index2139] = (byte) num6260;
      byte[] numArray2148 = second;
      int num6261 = num6259;
      int num6262 = num6261 + 1;
      int index2140 = num6261;
      int num6263 = (int) numArray2030[this.ucScreenLED1.LEDF4 * 3];
      numArray2148[index2140] = (byte) num6263;
      byte[] numArray2149 = second;
      int num6264 = num6262;
      int num6265 = num6264 + 1;
      int index2141 = num6264;
      int num6266 = (int) numArray2030[this.ucScreenLED1.LEDF4 * 3 + 1];
      numArray2149[index2141] = (byte) num6266;
      byte[] numArray2150 = second;
      int num6267 = num6265;
      int num6268 = num6267 + 1;
      int index2142 = num6267;
      int num6269 = (int) numArray2030[this.ucScreenLED1.LEDF4 * 3 + 2];
      numArray2150[index2142] = (byte) num6269;
      byte[] numArray2151 = second;
      int num6270 = num6268;
      int num6271 = num6270 + 1;
      int index2143 = num6270;
      int num6272 = (int) numArray2030[this.ucScreenLED1.LEDC3 * 3];
      numArray2151[index2143] = (byte) num6272;
      byte[] numArray2152 = second;
      int num6273 = num6271;
      int num6274 = num6273 + 1;
      int index2144 = num6273;
      int num6275 = (int) numArray2030[this.ucScreenLED1.LEDC3 * 3 + 1];
      numArray2152[index2144] = (byte) num6275;
      byte[] numArray2153 = second;
      int num6276 = num6274;
      int num6277 = num6276 + 1;
      int index2145 = num6276;
      int num6278 = (int) numArray2030[this.ucScreenLED1.LEDC3 * 3 + 2];
      numArray2153[index2145] = (byte) num6278;
      byte[] numArray2154 = second;
      int num6279 = num6277;
      int num6280 = num6279 + 1;
      int index2146 = num6279;
      int num6281 = (int) numArray2030[this.ucScreenLED1.LEDD3 * 3];
      numArray2154[index2146] = (byte) num6281;
      byte[] numArray2155 = second;
      int num6282 = num6280;
      int num6283 = num6282 + 1;
      int index2147 = num6282;
      int num6284 = (int) numArray2030[this.ucScreenLED1.LEDD3 * 3 + 1];
      numArray2155[index2147] = (byte) num6284;
      byte[] numArray2156 = second;
      int num6285 = num6283;
      int num6286 = num6285 + 1;
      int index2148 = num6285;
      int num6287 = (int) numArray2030[this.ucScreenLED1.LEDD3 * 3 + 2];
      numArray2156[index2148] = (byte) num6287;
      byte[] numArray2157 = second;
      int num6288 = num6286;
      int num6289 = num6288 + 1;
      int index2149 = num6288;
      int num6290 = (int) numArray2030[this.ucScreenLED1.LEDE3 * 3];
      numArray2157[index2149] = (byte) num6290;
      byte[] numArray2158 = second;
      int num6291 = num6289;
      int num6292 = num6291 + 1;
      int index2150 = num6291;
      int num6293 = (int) numArray2030[this.ucScreenLED1.LEDE3 * 3 + 1];
      numArray2158[index2150] = (byte) num6293;
      byte[] numArray2159 = second;
      int num6294 = num6292;
      int num6295 = num6294 + 1;
      int index2151 = num6294;
      int num6296 = (int) numArray2030[this.ucScreenLED1.LEDE3 * 3 + 2];
      numArray2159[index2151] = (byte) num6296;
      byte[] numArray2160 = second;
      int num6297 = num6295;
      int num6298 = num6297 + 1;
      int index2152 = num6297;
      int num6299 = (int) numArray2030[this.ucScreenLED1.LEDG3 * 3];
      numArray2160[index2152] = (byte) num6299;
      byte[] numArray2161 = second;
      int num6300 = num6298;
      int num6301 = num6300 + 1;
      int index2153 = num6300;
      int num6302 = (int) numArray2030[this.ucScreenLED1.LEDG3 * 3 + 1];
      numArray2161[index2153] = (byte) num6302;
      byte[] numArray2162 = second;
      int num6303 = num6301;
      int num6304 = num6303 + 1;
      int index2154 = num6303;
      int num6305 = (int) numArray2030[this.ucScreenLED1.LEDG3 * 3 + 2];
      numArray2162[index2154] = (byte) num6305;
      byte[] numArray2163 = second;
      int num6306 = num6304;
      int num6307 = num6306 + 1;
      int index2155 = num6306;
      int num6308 = (int) numArray2030[this.ucScreenLED1.LEDB3 * 3];
      numArray2163[index2155] = (byte) num6308;
      byte[] numArray2164 = second;
      int num6309 = num6307;
      int num6310 = num6309 + 1;
      int index2156 = num6309;
      int num6311 = (int) numArray2030[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray2164[index2156] = (byte) num6311;
      byte[] numArray2165 = second;
      int num6312 = num6310;
      int num6313 = num6312 + 1;
      int index2157 = num6312;
      int num6314 = (int) numArray2030[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray2165[index2157] = (byte) num6314;
      byte[] numArray2166 = second;
      int num6315 = num6313;
      int num6316 = num6315 + 1;
      int index2158 = num6315;
      int num6317 = (int) numArray2030[this.ucScreenLED1.LEDA3 * 3];
      numArray2166[index2158] = (byte) num6317;
      byte[] numArray2167 = second;
      int num6318 = num6316;
      int num6319 = num6318 + 1;
      int index2159 = num6318;
      int num6320 = (int) numArray2030[this.ucScreenLED1.LEDA3 * 3 + 1];
      numArray2167[index2159] = (byte) num6320;
      byte[] numArray2168 = second;
      int num6321 = num6319;
      int num6322 = num6321 + 1;
      int index2160 = num6321;
      int num6323 = (int) numArray2030[this.ucScreenLED1.LEDA3 * 3 + 2];
      numArray2168[index2160] = (byte) num6323;
      byte[] numArray2169 = second;
      int num6324 = num6322;
      int num6325 = num6324 + 1;
      int index2161 = num6324;
      int num6326 = (int) numArray2030[this.ucScreenLED1.LEDF3 * 3];
      numArray2169[index2161] = (byte) num6326;
      byte[] numArray2170 = second;
      int num6327 = num6325;
      int num6328 = num6327 + 1;
      int index2162 = num6327;
      int num6329 = (int) numArray2030[this.ucScreenLED1.LEDF3 * 3 + 1];
      numArray2170[index2162] = (byte) num6329;
      byte[] numArray2171 = second;
      int num6330 = num6328;
      int num6331 = num6330 + 1;
      int index2163 = num6330;
      int num6332 = (int) numArray2030[this.ucScreenLED1.LEDF3 * 3 + 2];
      numArray2171[index2163] = (byte) num6332;
      byte[] numArray2172 = second;
      int num6333 = num6331;
      int num6334 = num6333 + 1;
      int index2164 = num6333;
      int num6335 = (int) numArray2030[this.ucScreenLED1.Shijian1 * 3];
      numArray2172[index2164] = (byte) num6335;
      byte[] numArray2173 = second;
      int num6336 = num6334;
      int num6337 = num6336 + 1;
      int index2165 = num6336;
      int num6338 = (int) numArray2030[this.ucScreenLED1.Shijian1 * 3 + 1];
      numArray2173[index2165] = (byte) num6338;
      byte[] numArray2174 = second;
      int num6339 = num6337;
      int num6340 = num6339 + 1;
      int index2166 = num6339;
      int num6341 = (int) numArray2030[this.ucScreenLED1.Shijian1 * 3 + 2];
      numArray2174[index2166] = (byte) num6341;
      byte[] numArray2175 = second;
      int num6342 = num6340;
      int num6343 = num6342 + 1;
      int index2167 = num6342;
      int num6344 = (int) numArray2030[this.ucScreenLED1.Shijian2 * 3];
      numArray2175[index2167] = (byte) num6344;
      byte[] numArray2176 = second;
      int num6345 = num6343;
      int num6346 = num6345 + 1;
      int index2168 = num6345;
      int num6347 = (int) numArray2030[this.ucScreenLED1.Shijian2 * 3 + 1];
      numArray2176[index2168] = (byte) num6347;
      byte[] numArray2177 = second;
      int num6348 = num6346;
      int num6349 = num6348 + 1;
      int index2169 = num6348;
      int num6350 = (int) numArray2030[this.ucScreenLED1.Shijian2 * 3 + 2];
      numArray2177[index2169] = (byte) num6350;
      byte[] numArray2178 = second;
      int num6351 = num6349;
      int num6352 = num6351 + 1;
      int index2170 = num6351;
      int num6353 = (int) numArray2030[this.ucScreenLED1.LEDC2 * 3];
      numArray2178[index2170] = (byte) num6353;
      byte[] numArray2179 = second;
      int num6354 = num6352;
      int num6355 = num6354 + 1;
      int index2171 = num6354;
      int num6356 = (int) numArray2030[this.ucScreenLED1.LEDC2 * 3 + 1];
      numArray2179[index2171] = (byte) num6356;
      byte[] numArray2180 = second;
      int num6357 = num6355;
      int num6358 = num6357 + 1;
      int index2172 = num6357;
      int num6359 = (int) numArray2030[this.ucScreenLED1.LEDC2 * 3 + 2];
      numArray2180[index2172] = (byte) num6359;
      byte[] numArray2181 = second;
      int num6360 = num6358;
      int num6361 = num6360 + 1;
      int index2173 = num6360;
      int num6362 = (int) numArray2030[this.ucScreenLED1.LEDD2 * 3];
      numArray2181[index2173] = (byte) num6362;
      byte[] numArray2182 = second;
      int num6363 = num6361;
      int num6364 = num6363 + 1;
      int index2174 = num6363;
      int num6365 = (int) numArray2030[this.ucScreenLED1.LEDD2 * 3 + 1];
      numArray2182[index2174] = (byte) num6365;
      byte[] numArray2183 = second;
      int num6366 = num6364;
      int num6367 = num6366 + 1;
      int index2175 = num6366;
      int num6368 = (int) numArray2030[this.ucScreenLED1.LEDD2 * 3 + 2];
      numArray2183[index2175] = (byte) num6368;
      byte[] numArray2184 = second;
      int num6369 = num6367;
      int num6370 = num6369 + 1;
      int index2176 = num6369;
      int num6371 = (int) numArray2030[this.ucScreenLED1.LEDE2 * 3];
      numArray2184[index2176] = (byte) num6371;
      byte[] numArray2185 = second;
      int num6372 = num6370;
      int num6373 = num6372 + 1;
      int index2177 = num6372;
      int num6374 = (int) numArray2030[this.ucScreenLED1.LEDE2 * 3 + 1];
      numArray2185[index2177] = (byte) num6374;
      byte[] numArray2186 = second;
      int num6375 = num6373;
      int num6376 = num6375 + 1;
      int index2178 = num6375;
      int num6377 = (int) numArray2030[this.ucScreenLED1.LEDE2 * 3 + 2];
      numArray2186[index2178] = (byte) num6377;
      byte[] numArray2187 = second;
      int num6378 = num6376;
      int num6379 = num6378 + 1;
      int index2179 = num6378;
      int num6380 = (int) numArray2030[this.ucScreenLED1.LEDG2 * 3];
      numArray2187[index2179] = (byte) num6380;
      byte[] numArray2188 = second;
      int num6381 = num6379;
      int num6382 = num6381 + 1;
      int index2180 = num6381;
      int num6383 = (int) numArray2030[this.ucScreenLED1.LEDG2 * 3 + 1];
      numArray2188[index2180] = (byte) num6383;
      byte[] numArray2189 = second;
      int num6384 = num6382;
      int num6385 = num6384 + 1;
      int index2181 = num6384;
      int num6386 = (int) numArray2030[this.ucScreenLED1.LEDG2 * 3 + 2];
      numArray2189[index2181] = (byte) num6386;
      byte[] numArray2190 = second;
      int num6387 = num6385;
      int num6388 = num6387 + 1;
      int index2182 = num6387;
      int num6389 = (int) numArray2030[this.ucScreenLED1.LEDB2 * 3];
      numArray2190[index2182] = (byte) num6389;
      byte[] numArray2191 = second;
      int num6390 = num6388;
      int num6391 = num6390 + 1;
      int index2183 = num6390;
      int num6392 = (int) numArray2030[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray2191[index2183] = (byte) num6392;
      byte[] numArray2192 = second;
      int num6393 = num6391;
      int num6394 = num6393 + 1;
      int index2184 = num6393;
      int num6395 = (int) numArray2030[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray2192[index2184] = (byte) num6395;
      byte[] numArray2193 = second;
      int num6396 = num6394;
      int num6397 = num6396 + 1;
      int index2185 = num6396;
      int num6398 = (int) numArray2030[this.ucScreenLED1.LEDA2 * 3];
      numArray2193[index2185] = (byte) num6398;
      byte[] numArray2194 = second;
      int num6399 = num6397;
      int num6400 = num6399 + 1;
      int index2186 = num6399;
      int num6401 = (int) numArray2030[this.ucScreenLED1.LEDA2 * 3 + 1];
      numArray2194[index2186] = (byte) num6401;
      byte[] numArray2195 = second;
      int num6402 = num6400;
      int num6403 = num6402 + 1;
      int index2187 = num6402;
      int num6404 = (int) numArray2030[this.ucScreenLED1.LEDA2 * 3 + 2];
      numArray2195[index2187] = (byte) num6404;
      byte[] numArray2196 = second;
      int num6405 = num6403;
      int num6406 = num6405 + 1;
      int index2188 = num6405;
      int num6407 = (int) numArray2030[this.ucScreenLED1.LEDF2 * 3];
      numArray2196[index2188] = (byte) num6407;
      byte[] numArray2197 = second;
      int num6408 = num6406;
      int num6409 = num6408 + 1;
      int index2189 = num6408;
      int num6410 = (int) numArray2030[this.ucScreenLED1.LEDF2 * 3 + 1];
      numArray2197[index2189] = (byte) num6410;
      byte[] numArray2198 = second;
      int num6411 = num6409;
      int num6412 = num6411 + 1;
      int index2190 = num6411;
      int num6413 = (int) numArray2030[this.ucScreenLED1.LEDF2 * 3 + 2];
      numArray2198[index2190] = (byte) num6413;
      byte[] numArray2199 = second;
      int num6414 = num6412;
      int num6415 = num6414 + 1;
      int index2191 = num6414;
      int num6416 = (int) numArray2030[this.ucScreenLED1.LEDC1 * 3];
      numArray2199[index2191] = (byte) num6416;
      byte[] numArray2200 = second;
      int num6417 = num6415;
      int num6418 = num6417 + 1;
      int index2192 = num6417;
      int num6419 = (int) numArray2030[this.ucScreenLED1.LEDC1 * 3 + 1];
      numArray2200[index2192] = (byte) num6419;
      byte[] numArray2201 = second;
      int num6420 = num6418;
      int num6421 = num6420 + 1;
      int index2193 = num6420;
      int num6422 = (int) numArray2030[this.ucScreenLED1.LEDC1 * 3 + 2];
      numArray2201[index2193] = (byte) num6422;
      byte[] numArray2202 = second;
      int num6423 = num6421;
      int num6424 = num6423 + 1;
      int index2194 = num6423;
      int num6425 = (int) numArray2030[this.ucScreenLED1.LEDD1 * 3];
      numArray2202[index2194] = (byte) num6425;
      byte[] numArray2203 = second;
      int num6426 = num6424;
      int num6427 = num6426 + 1;
      int index2195 = num6426;
      int num6428 = (int) numArray2030[this.ucScreenLED1.LEDD1 * 3 + 1];
      numArray2203[index2195] = (byte) num6428;
      byte[] numArray2204 = second;
      int num6429 = num6427;
      int num6430 = num6429 + 1;
      int index2196 = num6429;
      int num6431 = (int) numArray2030[this.ucScreenLED1.LEDD1 * 3 + 2];
      numArray2204[index2196] = (byte) num6431;
      byte[] numArray2205 = second;
      int num6432 = num6430;
      int num6433 = num6432 + 1;
      int index2197 = num6432;
      int num6434 = (int) numArray2030[this.ucScreenLED1.LEDE1 * 3];
      numArray2205[index2197] = (byte) num6434;
      byte[] numArray2206 = second;
      int num6435 = num6433;
      int num6436 = num6435 + 1;
      int index2198 = num6435;
      int num6437 = (int) numArray2030[this.ucScreenLED1.LEDE1 * 3 + 1];
      numArray2206[index2198] = (byte) num6437;
      byte[] numArray2207 = second;
      int num6438 = num6436;
      int num6439 = num6438 + 1;
      int index2199 = num6438;
      int num6440 = (int) numArray2030[this.ucScreenLED1.LEDE1 * 3 + 2];
      numArray2207[index2199] = (byte) num6440;
      byte[] numArray2208 = second;
      int num6441 = num6439;
      int num6442 = num6441 + 1;
      int index2200 = num6441;
      int num6443 = (int) numArray2030[this.ucScreenLED1.LEDG1 * 3];
      numArray2208[index2200] = (byte) num6443;
      byte[] numArray2209 = second;
      int num6444 = num6442;
      int num6445 = num6444 + 1;
      int index2201 = num6444;
      int num6446 = (int) numArray2030[this.ucScreenLED1.LEDG1 * 3 + 1];
      numArray2209[index2201] = (byte) num6446;
      byte[] numArray2210 = second;
      int num6447 = num6445;
      int num6448 = num6447 + 1;
      int index2202 = num6447;
      int num6449 = (int) numArray2030[this.ucScreenLED1.LEDG1 * 3 + 2];
      numArray2210[index2202] = (byte) num6449;
      byte[] numArray2211 = second;
      int num6450 = num6448;
      int num6451 = num6450 + 1;
      int index2203 = num6450;
      int num6452 = (int) numArray2030[this.ucScreenLED1.LEDB1 * 3];
      numArray2211[index2203] = (byte) num6452;
      byte[] numArray2212 = second;
      int num6453 = num6451;
      int num6454 = num6453 + 1;
      int index2204 = num6453;
      int num6455 = (int) numArray2030[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray2212[index2204] = (byte) num6455;
      byte[] numArray2213 = second;
      int num6456 = num6454;
      int num6457 = num6456 + 1;
      int index2205 = num6456;
      int num6458 = (int) numArray2030[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray2213[index2205] = (byte) num6458;
      byte[] numArray2214 = second;
      int num6459 = num6457;
      int num6460 = num6459 + 1;
      int index2206 = num6459;
      int num6461 = (int) numArray2030[this.ucScreenLED1.LEDA1 * 3];
      numArray2214[index2206] = (byte) num6461;
      byte[] numArray2215 = second;
      int num6462 = num6460;
      int num6463 = num6462 + 1;
      int index2207 = num6462;
      int num6464 = (int) numArray2030[this.ucScreenLED1.LEDA1 * 3 + 1];
      numArray2215[index2207] = (byte) num6464;
      byte[] numArray2216 = second;
      int num6465 = num6463;
      int num6466 = num6465 + 1;
      int index2208 = num6465;
      int num6467 = (int) numArray2030[this.ucScreenLED1.LEDA1 * 3 + 2];
      numArray2216[index2208] = (byte) num6467;
      byte[] numArray2217 = second;
      int num6468 = num6466;
      int num6469 = num6468 + 1;
      int index2209 = num6468;
      int num6470 = (int) numArray2030[this.ucScreenLED1.LEDF1 * 3];
      numArray2217[index2209] = (byte) num6470;
      byte[] numArray2218 = second;
      int num6471 = num6469;
      int num6472 = num6471 + 1;
      int index2210 = num6471;
      int num6473 = (int) numArray2030[this.ucScreenLED1.LEDF1 * 3 + 1];
      numArray2218[index2210] = (byte) num6473;
      byte[] numArray2219 = second;
      int num6474 = num6472;
      int num6475 = num6474 + 1;
      int index2211 = num6474;
      int num6476 = (int) numArray2030[this.ucScreenLED1.LEDF1 * 3 + 2];
      numArray2219[index2211] = (byte) num6476;
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 10)
    {
      byte[] numArray2220 = new byte[114];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray2220.Length,
        (byte) 0,
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 38; ++index)
      {
        if (this.myOnOff == (byte) 0)
        {
          numArray2220[index * 3] = (byte) 0;
          numArray2220[index * 3 + 1] = (byte) 0;
          numArray2220[index * 3 + 2] = (byte) 0;
        }
        else if (this.ucScreenLED1.isOn[index])
        {
          numArray2220[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2 + (double) num1);
          numArray2220[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2 + (double) num1);
          numArray2220[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2 + (double) num1);
        }
        else
        {
          numArray2220[index * 3] = (byte) 0;
          numArray2220[index * 3 + 1] = (byte) 0;
          numArray2220[index * 3 + 2] = (byte) 0;
        }
      }
      int num6477 = 0;
      byte[] second = new byte[numArray2220.Length];
      byte[] numArray2221 = second;
      int num6478 = num6477;
      int num6479 = num6478 + 1;
      int index2212 = num6478;
      int num6480 = (int) numArray2220[this.ucScreenLED1.GNo * 3];
      numArray2221[index2212] = (byte) num6480;
      byte[] numArray2222 = second;
      int num6481 = num6479;
      int num6482 = num6481 + 1;
      int index2213 = num6481;
      int num6483 = (int) numArray2220[this.ucScreenLED1.GNo * 3 + 1];
      numArray2222[index2213] = (byte) num6483;
      byte[] numArray2223 = second;
      int num6484 = num6482;
      int num6485 = num6484 + 1;
      int index2214 = num6484;
      int num6486 = (int) numArray2220[this.ucScreenLED1.GNo * 3 + 2];
      numArray2223[index2214] = (byte) num6486;
      byte[] numArray2224 = second;
      int num6487 = num6485;
      int num6488 = num6487 + 1;
      int index2215 = num6487;
      int num6489 = (int) numArray2220[this.ucScreenLED1.MTNo * 3];
      numArray2224[index2215] = (byte) num6489;
      byte[] numArray2225 = second;
      int num6490 = num6488;
      int num6491 = num6490 + 1;
      int index2216 = num6490;
      int num6492 = (int) numArray2220[this.ucScreenLED1.MTNo * 3 + 1];
      numArray2225[index2216] = (byte) num6492;
      byte[] numArray2226 = second;
      int num6493 = num6491;
      int num6494 = num6493 + 1;
      int index2217 = num6493;
      int num6495 = (int) numArray2220[this.ucScreenLED1.MTNo * 3 + 2];
      numArray2226[index2217] = (byte) num6495;
      byte[] numArray2227 = second;
      int num6496 = num6494;
      int num6497 = num6496 + 1;
      int index2218 = num6496;
      int num6498 = (int) numArray2220[this.ucScreenLED1.LEDC5 * 3];
      numArray2227[index2218] = (byte) num6498;
      byte[] numArray2228 = second;
      int num6499 = num6497;
      int num6500 = num6499 + 1;
      int index2219 = num6499;
      int num6501 = (int) numArray2220[this.ucScreenLED1.LEDC5 * 3 + 1];
      numArray2228[index2219] = (byte) num6501;
      byte[] numArray2229 = second;
      int num6502 = num6500;
      int num6503 = num6502 + 1;
      int index2220 = num6502;
      int num6504 = (int) numArray2220[this.ucScreenLED1.LEDC5 * 3 + 2];
      numArray2229[index2220] = (byte) num6504;
      byte[] numArray2230 = second;
      int num6505 = num6503;
      int num6506 = num6505 + 1;
      int index2221 = num6505;
      int num6507 = (int) numArray2220[this.ucScreenLED1.LEDD5 * 3];
      numArray2230[index2221] = (byte) num6507;
      byte[] numArray2231 = second;
      int num6508 = num6506;
      int num6509 = num6508 + 1;
      int index2222 = num6508;
      int num6510 = (int) numArray2220[this.ucScreenLED1.LEDD5 * 3 + 1];
      numArray2231[index2222] = (byte) num6510;
      byte[] numArray2232 = second;
      int num6511 = num6509;
      int num6512 = num6511 + 1;
      int index2223 = num6511;
      int num6513 = (int) numArray2220[this.ucScreenLED1.LEDD5 * 3 + 2];
      numArray2232[index2223] = (byte) num6513;
      byte[] numArray2233 = second;
      int num6514 = num6512;
      int num6515 = num6514 + 1;
      int index2224 = num6514;
      int num6516 = (int) numArray2220[this.ucScreenLED1.LEDE5 * 3];
      numArray2233[index2224] = (byte) num6516;
      byte[] numArray2234 = second;
      int num6517 = num6515;
      int num6518 = num6517 + 1;
      int index2225 = num6517;
      int num6519 = (int) numArray2220[this.ucScreenLED1.LEDE5 * 3 + 1];
      numArray2234[index2225] = (byte) num6519;
      byte[] numArray2235 = second;
      int num6520 = num6518;
      int num6521 = num6520 + 1;
      int index2226 = num6520;
      int num6522 = (int) numArray2220[this.ucScreenLED1.LEDE5 * 3 + 2];
      numArray2235[index2226] = (byte) num6522;
      byte[] numArray2236 = second;
      int num6523 = num6521;
      int num6524 = num6523 + 1;
      int index2227 = num6523;
      int num6525 = (int) numArray2220[this.ucScreenLED1.LEDG5 * 3];
      numArray2236[index2227] = (byte) num6525;
      byte[] numArray2237 = second;
      int num6526 = num6524;
      int num6527 = num6526 + 1;
      int index2228 = num6526;
      int num6528 = (int) numArray2220[this.ucScreenLED1.LEDG5 * 3 + 1];
      numArray2237[index2228] = (byte) num6528;
      byte[] numArray2238 = second;
      int num6529 = num6527;
      int num6530 = num6529 + 1;
      int index2229 = num6529;
      int num6531 = (int) numArray2220[this.ucScreenLED1.LEDG5 * 3 + 2];
      numArray2238[index2229] = (byte) num6531;
      byte[] numArray2239 = second;
      int num6532 = num6530;
      int num6533 = num6532 + 1;
      int index2230 = num6532;
      int num6534 = (int) numArray2220[this.ucScreenLED1.LEDB5 * 3];
      numArray2239[index2230] = (byte) num6534;
      byte[] numArray2240 = second;
      int num6535 = num6533;
      int num6536 = num6535 + 1;
      int index2231 = num6535;
      int num6537 = (int) numArray2220[this.ucScreenLED1.LEDB5 * 3 + 1];
      numArray2240[index2231] = (byte) num6537;
      byte[] numArray2241 = second;
      int num6538 = num6536;
      int num6539 = num6538 + 1;
      int index2232 = num6538;
      int num6540 = (int) numArray2220[this.ucScreenLED1.LEDB5 * 3 + 2];
      numArray2241[index2232] = (byte) num6540;
      byte[] numArray2242 = second;
      int num6541 = num6539;
      int num6542 = num6541 + 1;
      int index2233 = num6541;
      int num6543 = (int) numArray2220[this.ucScreenLED1.LEDA5 * 3];
      numArray2242[index2233] = (byte) num6543;
      byte[] numArray2243 = second;
      int num6544 = num6542;
      int num6545 = num6544 + 1;
      int index2234 = num6544;
      int num6546 = (int) numArray2220[this.ucScreenLED1.LEDA5 * 3 + 1];
      numArray2243[index2234] = (byte) num6546;
      byte[] numArray2244 = second;
      int num6547 = num6545;
      int num6548 = num6547 + 1;
      int index2235 = num6547;
      int num6549 = (int) numArray2220[this.ucScreenLED1.LEDA5 * 3 + 2];
      numArray2244[index2235] = (byte) num6549;
      byte[] numArray2245 = second;
      int num6550 = num6548;
      int num6551 = num6550 + 1;
      int index2236 = num6550;
      int num6552 = (int) numArray2220[this.ucScreenLED1.SSD * 3];
      numArray2245[index2236] = (byte) num6552;
      byte[] numArray2246 = second;
      int num6553 = num6551;
      int num6554 = num6553 + 1;
      int index2237 = num6553;
      int num6555 = (int) numArray2220[this.ucScreenLED1.SSD * 3 + 1];
      numArray2246[index2237] = (byte) num6555;
      byte[] numArray2247 = second;
      int num6556 = num6554;
      int num6557 = num6556 + 1;
      int index2238 = num6556;
      int num6558 = (int) numArray2220[this.ucScreenLED1.SSD * 3 + 2];
      numArray2247[index2238] = (byte) num6558;
      byte[] numArray2248 = second;
      int num6559 = num6557;
      int num6560 = num6559 + 1;
      int index2239 = num6559;
      int num6561 = (int) numArray2220[this.ucScreenLED1.LEDF5 * 3];
      numArray2248[index2239] = (byte) num6561;
      byte[] numArray2249 = second;
      int num6562 = num6560;
      int num6563 = num6562 + 1;
      int index2240 = num6562;
      int num6564 = (int) numArray2220[this.ucScreenLED1.LEDF5 * 3 + 1];
      numArray2249[index2240] = (byte) num6564;
      byte[] numArray2250 = second;
      int num6565 = num6563;
      int num6566 = num6565 + 1;
      int index2241 = num6565;
      int num6567 = (int) numArray2220[this.ucScreenLED1.LEDF5 * 3 + 2];
      numArray2250[index2241] = (byte) num6567;
      byte[] numArray2251 = second;
      int num6568 = num6566;
      int num6569 = num6568 + 1;
      int index2242 = num6568;
      int num6570 = (int) numArray2220[this.ucScreenLED1.LEDC4 * 3];
      numArray2251[index2242] = (byte) num6570;
      byte[] numArray2252 = second;
      int num6571 = num6569;
      int num6572 = num6571 + 1;
      int index2243 = num6571;
      int num6573 = (int) numArray2220[this.ucScreenLED1.LEDC4 * 3 + 1];
      numArray2252[index2243] = (byte) num6573;
      byte[] numArray2253 = second;
      int num6574 = num6572;
      int num6575 = num6574 + 1;
      int index2244 = num6574;
      int num6576 = (int) numArray2220[this.ucScreenLED1.LEDC4 * 3 + 2];
      numArray2253[index2244] = (byte) num6576;
      byte[] numArray2254 = second;
      int num6577 = num6575;
      int num6578 = num6577 + 1;
      int index2245 = num6577;
      int num6579 = (int) numArray2220[this.ucScreenLED1.LEDD4 * 3];
      numArray2254[index2245] = (byte) num6579;
      byte[] numArray2255 = second;
      int num6580 = num6578;
      int num6581 = num6580 + 1;
      int index2246 = num6580;
      int num6582 = (int) numArray2220[this.ucScreenLED1.LEDD4 * 3 + 1];
      numArray2255[index2246] = (byte) num6582;
      byte[] numArray2256 = second;
      int num6583 = num6581;
      int num6584 = num6583 + 1;
      int index2247 = num6583;
      int num6585 = (int) numArray2220[this.ucScreenLED1.LEDD4 * 3 + 2];
      numArray2256[index2247] = (byte) num6585;
      byte[] numArray2257 = second;
      int num6586 = num6584;
      int num6587 = num6586 + 1;
      int index2248 = num6586;
      int num6588 = (int) numArray2220[this.ucScreenLED1.LEDE4 * 3];
      numArray2257[index2248] = (byte) num6588;
      byte[] numArray2258 = second;
      int num6589 = num6587;
      int num6590 = num6589 + 1;
      int index2249 = num6589;
      int num6591 = (int) numArray2220[this.ucScreenLED1.LEDE4 * 3 + 1];
      numArray2258[index2249] = (byte) num6591;
      byte[] numArray2259 = second;
      int num6592 = num6590;
      int num6593 = num6592 + 1;
      int index2250 = num6592;
      int num6594 = (int) numArray2220[this.ucScreenLED1.LEDE4 * 3 + 2];
      numArray2259[index2250] = (byte) num6594;
      byte[] numArray2260 = second;
      int num6595 = num6593;
      int num6596 = num6595 + 1;
      int index2251 = num6595;
      int num6597 = (int) numArray2220[this.ucScreenLED1.LEDG4 * 3];
      numArray2260[index2251] = (byte) num6597;
      byte[] numArray2261 = second;
      int num6598 = num6596;
      int num6599 = num6598 + 1;
      int index2252 = num6598;
      int num6600 = (int) numArray2220[this.ucScreenLED1.LEDG4 * 3 + 1];
      numArray2261[index2252] = (byte) num6600;
      byte[] numArray2262 = second;
      int num6601 = num6599;
      int num6602 = num6601 + 1;
      int index2253 = num6601;
      int num6603 = (int) numArray2220[this.ucScreenLED1.LEDG4 * 3 + 2];
      numArray2262[index2253] = (byte) num6603;
      byte[] numArray2263 = second;
      int num6604 = num6602;
      int num6605 = num6604 + 1;
      int index2254 = num6604;
      int num6606 = (int) numArray2220[this.ucScreenLED1.LEDB4 * 3];
      numArray2263[index2254] = (byte) num6606;
      byte[] numArray2264 = second;
      int num6607 = num6605;
      int num6608 = num6607 + 1;
      int index2255 = num6607;
      int num6609 = (int) numArray2220[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray2264[index2255] = (byte) num6609;
      byte[] numArray2265 = second;
      int num6610 = num6608;
      int num6611 = num6610 + 1;
      int index2256 = num6610;
      int num6612 = (int) numArray2220[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray2265[index2256] = (byte) num6612;
      byte[] numArray2266 = second;
      int num6613 = num6611;
      int num6614 = num6613 + 1;
      int index2257 = num6613;
      int num6615 = (int) numArray2220[this.ucScreenLED1.LEDA4 * 3];
      numArray2266[index2257] = (byte) num6615;
      byte[] numArray2267 = second;
      int num6616 = num6614;
      int num6617 = num6616 + 1;
      int index2258 = num6616;
      int num6618 = (int) numArray2220[this.ucScreenLED1.LEDA4 * 3 + 1];
      numArray2267[index2258] = (byte) num6618;
      byte[] numArray2268 = second;
      int num6619 = num6617;
      int num6620 = num6619 + 1;
      int index2259 = num6619;
      int num6621 = (int) numArray2220[this.ucScreenLED1.LEDA4 * 3 + 2];
      numArray2268[index2259] = (byte) num6621;
      byte[] numArray2269 = second;
      int num6622 = num6620;
      int num6623 = num6622 + 1;
      int index2260 = num6622;
      int num6624 = (int) numArray2220[this.ucScreenLED1.LEDF4 * 3];
      numArray2269[index2260] = (byte) num6624;
      byte[] numArray2270 = second;
      int num6625 = num6623;
      int num6626 = num6625 + 1;
      int index2261 = num6625;
      int num6627 = (int) numArray2220[this.ucScreenLED1.LEDF4 * 3 + 1];
      numArray2270[index2261] = (byte) num6627;
      byte[] numArray2271 = second;
      int num6628 = num6626;
      int num6629 = num6628 + 1;
      int index2262 = num6628;
      int num6630 = (int) numArray2220[this.ucScreenLED1.LEDF4 * 3 + 2];
      numArray2271[index2262] = (byte) num6630;
      byte[] numArray2272 = second;
      int num6631 = num6629;
      int num6632 = num6631 + 1;
      int index2263 = num6631;
      int num6633 = (int) numArray2220[this.ucScreenLED1.LEDC3 * 3];
      numArray2272[index2263] = (byte) num6633;
      byte[] numArray2273 = second;
      int num6634 = num6632;
      int num6635 = num6634 + 1;
      int index2264 = num6634;
      int num6636 = (int) numArray2220[this.ucScreenLED1.LEDC3 * 3 + 1];
      numArray2273[index2264] = (byte) num6636;
      byte[] numArray2274 = second;
      int num6637 = num6635;
      int num6638 = num6637 + 1;
      int index2265 = num6637;
      int num6639 = (int) numArray2220[this.ucScreenLED1.LEDC3 * 3 + 2];
      numArray2274[index2265] = (byte) num6639;
      byte[] numArray2275 = second;
      int num6640 = num6638;
      int num6641 = num6640 + 1;
      int index2266 = num6640;
      int num6642 = (int) numArray2220[this.ucScreenLED1.LEDD3 * 3];
      numArray2275[index2266] = (byte) num6642;
      byte[] numArray2276 = second;
      int num6643 = num6641;
      int num6644 = num6643 + 1;
      int index2267 = num6643;
      int num6645 = (int) numArray2220[this.ucScreenLED1.LEDD3 * 3 + 1];
      numArray2276[index2267] = (byte) num6645;
      byte[] numArray2277 = second;
      int num6646 = num6644;
      int num6647 = num6646 + 1;
      int index2268 = num6646;
      int num6648 = (int) numArray2220[this.ucScreenLED1.LEDD3 * 3 + 2];
      numArray2277[index2268] = (byte) num6648;
      byte[] numArray2278 = second;
      int num6649 = num6647;
      int num6650 = num6649 + 1;
      int index2269 = num6649;
      int num6651 = (int) numArray2220[this.ucScreenLED1.LEDE3 * 3];
      numArray2278[index2269] = (byte) num6651;
      byte[] numArray2279 = second;
      int num6652 = num6650;
      int num6653 = num6652 + 1;
      int index2270 = num6652;
      int num6654 = (int) numArray2220[this.ucScreenLED1.LEDE3 * 3 + 1];
      numArray2279[index2270] = (byte) num6654;
      byte[] numArray2280 = second;
      int num6655 = num6653;
      int num6656 = num6655 + 1;
      int index2271 = num6655;
      int num6657 = (int) numArray2220[this.ucScreenLED1.LEDE3 * 3 + 2];
      numArray2280[index2271] = (byte) num6657;
      byte[] numArray2281 = second;
      int num6658 = num6656;
      int num6659 = num6658 + 1;
      int index2272 = num6658;
      int num6660 = (int) numArray2220[this.ucScreenLED1.LEDG3 * 3];
      numArray2281[index2272] = (byte) num6660;
      byte[] numArray2282 = second;
      int num6661 = num6659;
      int num6662 = num6661 + 1;
      int index2273 = num6661;
      int num6663 = (int) numArray2220[this.ucScreenLED1.LEDG3 * 3 + 1];
      numArray2282[index2273] = (byte) num6663;
      byte[] numArray2283 = second;
      int num6664 = num6662;
      int num6665 = num6664 + 1;
      int index2274 = num6664;
      int num6666 = (int) numArray2220[this.ucScreenLED1.LEDG3 * 3 + 2];
      numArray2283[index2274] = (byte) num6666;
      byte[] numArray2284 = second;
      int num6667 = num6665;
      int num6668 = num6667 + 1;
      int index2275 = num6667;
      int num6669 = (int) numArray2220[this.ucScreenLED1.LEDB3 * 3];
      numArray2284[index2275] = (byte) num6669;
      byte[] numArray2285 = second;
      int num6670 = num6668;
      int num6671 = num6670 + 1;
      int index2276 = num6670;
      int num6672 = (int) numArray2220[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray2285[index2276] = (byte) num6672;
      byte[] numArray2286 = second;
      int num6673 = num6671;
      int num6674 = num6673 + 1;
      int index2277 = num6673;
      int num6675 = (int) numArray2220[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray2286[index2277] = (byte) num6675;
      byte[] numArray2287 = second;
      int num6676 = num6674;
      int num6677 = num6676 + 1;
      int index2278 = num6676;
      int num6678 = (int) numArray2220[this.ucScreenLED1.LEDA3 * 3];
      numArray2287[index2278] = (byte) num6678;
      byte[] numArray2288 = second;
      int num6679 = num6677;
      int num6680 = num6679 + 1;
      int index2279 = num6679;
      int num6681 = (int) numArray2220[this.ucScreenLED1.LEDA3 * 3 + 1];
      numArray2288[index2279] = (byte) num6681;
      byte[] numArray2289 = second;
      int num6682 = num6680;
      int num6683 = num6682 + 1;
      int index2280 = num6682;
      int num6684 = (int) numArray2220[this.ucScreenLED1.LEDA3 * 3 + 2];
      numArray2289[index2280] = (byte) num6684;
      byte[] numArray2290 = second;
      int num6685 = num6683;
      int num6686 = num6685 + 1;
      int index2281 = num6685;
      int num6687 = (int) numArray2220[this.ucScreenLED1.LEDF3 * 3];
      numArray2290[index2281] = (byte) num6687;
      byte[] numArray2291 = second;
      int num6688 = num6686;
      int num6689 = num6688 + 1;
      int index2282 = num6688;
      int num6690 = (int) numArray2220[this.ucScreenLED1.LEDF3 * 3 + 1];
      numArray2291[index2282] = (byte) num6690;
      byte[] numArray2292 = second;
      int num6691 = num6689;
      int num6692 = num6691 + 1;
      int index2283 = num6691;
      int num6693 = (int) numArray2220[this.ucScreenLED1.LEDF3 * 3 + 2];
      numArray2292[index2283] = (byte) num6693;
      byte[] numArray2293 = second;
      int num6694 = num6692;
      int num6695 = num6694 + 1;
      int index2284 = num6694;
      int num6696 = (int) numArray2220[this.ucScreenLED1.LEDC2 * 3];
      numArray2293[index2284] = (byte) num6696;
      byte[] numArray2294 = second;
      int num6697 = num6695;
      int num6698 = num6697 + 1;
      int index2285 = num6697;
      int num6699 = (int) numArray2220[this.ucScreenLED1.LEDC2 * 3 + 1];
      numArray2294[index2285] = (byte) num6699;
      byte[] numArray2295 = second;
      int num6700 = num6698;
      int num6701 = num6700 + 1;
      int index2286 = num6700;
      int num6702 = (int) numArray2220[this.ucScreenLED1.LEDC2 * 3 + 2];
      numArray2295[index2286] = (byte) num6702;
      byte[] numArray2296 = second;
      int num6703 = num6701;
      int num6704 = num6703 + 1;
      int index2287 = num6703;
      int num6705 = (int) numArray2220[this.ucScreenLED1.LEDD2 * 3];
      numArray2296[index2287] = (byte) num6705;
      byte[] numArray2297 = second;
      int num6706 = num6704;
      int num6707 = num6706 + 1;
      int index2288 = num6706;
      int num6708 = (int) numArray2220[this.ucScreenLED1.LEDD2 * 3 + 1];
      numArray2297[index2288] = (byte) num6708;
      byte[] numArray2298 = second;
      int num6709 = num6707;
      int num6710 = num6709 + 1;
      int index2289 = num6709;
      int num6711 = (int) numArray2220[this.ucScreenLED1.LEDD2 * 3 + 2];
      numArray2298[index2289] = (byte) num6711;
      byte[] numArray2299 = second;
      int num6712 = num6710;
      int num6713 = num6712 + 1;
      int index2290 = num6712;
      int num6714 = (int) numArray2220[this.ucScreenLED1.LEDE2 * 3];
      numArray2299[index2290] = (byte) num6714;
      byte[] numArray2300 = second;
      int num6715 = num6713;
      int num6716 = num6715 + 1;
      int index2291 = num6715;
      int num6717 = (int) numArray2220[this.ucScreenLED1.LEDE2 * 3 + 1];
      numArray2300[index2291] = (byte) num6717;
      byte[] numArray2301 = second;
      int num6718 = num6716;
      int num6719 = num6718 + 1;
      int index2292 = num6718;
      int num6720 = (int) numArray2220[this.ucScreenLED1.LEDE2 * 3 + 2];
      numArray2301[index2292] = (byte) num6720;
      byte[] numArray2302 = second;
      int num6721 = num6719;
      int num6722 = num6721 + 1;
      int index2293 = num6721;
      int num6723 = (int) numArray2220[this.ucScreenLED1.LEDG2 * 3];
      numArray2302[index2293] = (byte) num6723;
      byte[] numArray2303 = second;
      int num6724 = num6722;
      int num6725 = num6724 + 1;
      int index2294 = num6724;
      int num6726 = (int) numArray2220[this.ucScreenLED1.LEDG2 * 3 + 1];
      numArray2303[index2294] = (byte) num6726;
      byte[] numArray2304 = second;
      int num6727 = num6725;
      int num6728 = num6727 + 1;
      int index2295 = num6727;
      int num6729 = (int) numArray2220[this.ucScreenLED1.LEDG2 * 3 + 2];
      numArray2304[index2295] = (byte) num6729;
      byte[] numArray2305 = second;
      int num6730 = num6728;
      int num6731 = num6730 + 1;
      int index2296 = num6730;
      int num6732 = (int) numArray2220[this.ucScreenLED1.LEDB2 * 3];
      numArray2305[index2296] = (byte) num6732;
      byte[] numArray2306 = second;
      int num6733 = num6731;
      int num6734 = num6733 + 1;
      int index2297 = num6733;
      int num6735 = (int) numArray2220[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray2306[index2297] = (byte) num6735;
      byte[] numArray2307 = second;
      int num6736 = num6734;
      int num6737 = num6736 + 1;
      int index2298 = num6736;
      int num6738 = (int) numArray2220[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray2307[index2298] = (byte) num6738;
      byte[] numArray2308 = second;
      int num6739 = num6737;
      int num6740 = num6739 + 1;
      int index2299 = num6739;
      int num6741 = (int) numArray2220[this.ucScreenLED1.LEDA2 * 3];
      numArray2308[index2299] = (byte) num6741;
      byte[] numArray2309 = second;
      int num6742 = num6740;
      int num6743 = num6742 + 1;
      int index2300 = num6742;
      int num6744 = (int) numArray2220[this.ucScreenLED1.LEDA2 * 3 + 1];
      numArray2309[index2300] = (byte) num6744;
      byte[] numArray2310 = second;
      int num6745 = num6743;
      int num6746 = num6745 + 1;
      int index2301 = num6745;
      int num6747 = (int) numArray2220[this.ucScreenLED1.LEDA2 * 3 + 2];
      numArray2310[index2301] = (byte) num6747;
      byte[] numArray2311 = second;
      int num6748 = num6746;
      int num6749 = num6748 + 1;
      int index2302 = num6748;
      int num6750 = (int) numArray2220[this.ucScreenLED1.LEDF2 * 3];
      numArray2311[index2302] = (byte) num6750;
      byte[] numArray2312 = second;
      int num6751 = num6749;
      int num6752 = num6751 + 1;
      int index2303 = num6751;
      int num6753 = (int) numArray2220[this.ucScreenLED1.LEDF2 * 3 + 1];
      numArray2312[index2303] = (byte) num6753;
      byte[] numArray2313 = second;
      int num6754 = num6752;
      int num6755 = num6754 + 1;
      int index2304 = num6754;
      int num6756 = (int) numArray2220[this.ucScreenLED1.LEDF2 * 3 + 2];
      numArray2313[index2304] = (byte) num6756;
      byte[] numArray2314 = second;
      int num6757 = num6755;
      int num6758 = num6757 + 1;
      int index2305 = num6757;
      int num6759 = (int) numArray2220[this.ucScreenLED1.LEDC1 * 3];
      numArray2314[index2305] = (byte) num6759;
      byte[] numArray2315 = second;
      int num6760 = num6758;
      int num6761 = num6760 + 1;
      int index2306 = num6760;
      int num6762 = (int) numArray2220[this.ucScreenLED1.LEDC1 * 3 + 1];
      numArray2315[index2306] = (byte) num6762;
      byte[] numArray2316 = second;
      int num6763 = num6761;
      int num6764 = num6763 + 1;
      int index2307 = num6763;
      int num6765 = (int) numArray2220[this.ucScreenLED1.LEDC1 * 3 + 2];
      numArray2316[index2307] = (byte) num6765;
      byte[] numArray2317 = second;
      int num6766 = num6764;
      int num6767 = num6766 + 1;
      int index2308 = num6766;
      int num6768 = (int) numArray2220[this.ucScreenLED1.LEDD1 * 3];
      numArray2317[index2308] = (byte) num6768;
      byte[] numArray2318 = second;
      int num6769 = num6767;
      int num6770 = num6769 + 1;
      int index2309 = num6769;
      int num6771 = (int) numArray2220[this.ucScreenLED1.LEDD1 * 3 + 1];
      numArray2318[index2309] = (byte) num6771;
      byte[] numArray2319 = second;
      int num6772 = num6770;
      int num6773 = num6772 + 1;
      int index2310 = num6772;
      int num6774 = (int) numArray2220[this.ucScreenLED1.LEDD1 * 3 + 2];
      numArray2319[index2310] = (byte) num6774;
      byte[] numArray2320 = second;
      int num6775 = num6773;
      int num6776 = num6775 + 1;
      int index2311 = num6775;
      int num6777 = (int) numArray2220[this.ucScreenLED1.LEDE1 * 3];
      numArray2320[index2311] = (byte) num6777;
      byte[] numArray2321 = second;
      int num6778 = num6776;
      int num6779 = num6778 + 1;
      int index2312 = num6778;
      int num6780 = (int) numArray2220[this.ucScreenLED1.LEDE1 * 3 + 1];
      numArray2321[index2312] = (byte) num6780;
      byte[] numArray2322 = second;
      int num6781 = num6779;
      int num6782 = num6781 + 1;
      int index2313 = num6781;
      int num6783 = (int) numArray2220[this.ucScreenLED1.LEDE1 * 3 + 2];
      numArray2322[index2313] = (byte) num6783;
      byte[] numArray2323 = second;
      int num6784 = num6782;
      int num6785 = num6784 + 1;
      int index2314 = num6784;
      int num6786 = (int) numArray2220[this.ucScreenLED1.LEDG1 * 3];
      numArray2323[index2314] = (byte) num6786;
      byte[] numArray2324 = second;
      int num6787 = num6785;
      int num6788 = num6787 + 1;
      int index2315 = num6787;
      int num6789 = (int) numArray2220[this.ucScreenLED1.LEDG1 * 3 + 1];
      numArray2324[index2315] = (byte) num6789;
      byte[] numArray2325 = second;
      int num6790 = num6788;
      int num6791 = num6790 + 1;
      int index2316 = num6790;
      int num6792 = (int) numArray2220[this.ucScreenLED1.LEDG1 * 3 + 2];
      numArray2325[index2316] = (byte) num6792;
      byte[] numArray2326 = second;
      int num6793 = num6791;
      int num6794 = num6793 + 1;
      int index2317 = num6793;
      int num6795 = (int) numArray2220[this.ucScreenLED1.LEDB1 * 3];
      numArray2326[index2317] = (byte) num6795;
      byte[] numArray2327 = second;
      int num6796 = num6794;
      int num6797 = num6796 + 1;
      int index2318 = num6796;
      int num6798 = (int) numArray2220[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray2327[index2318] = (byte) num6798;
      byte[] numArray2328 = second;
      int num6799 = num6797;
      int num6800 = num6799 + 1;
      int index2319 = num6799;
      int num6801 = (int) numArray2220[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray2328[index2319] = (byte) num6801;
      byte[] numArray2329 = second;
      int num6802 = num6800;
      int num6803 = num6802 + 1;
      int index2320 = num6802;
      int num6804 = (int) numArray2220[this.ucScreenLED1.LEDA1 * 3];
      numArray2329[index2320] = (byte) num6804;
      byte[] numArray2330 = second;
      int num6805 = num6803;
      int num6806 = num6805 + 1;
      int index2321 = num6805;
      int num6807 = (int) numArray2220[this.ucScreenLED1.LEDA1 * 3 + 1];
      numArray2330[index2321] = (byte) num6807;
      byte[] numArray2331 = second;
      int num6808 = num6806;
      int num6809 = num6808 + 1;
      int index2322 = num6808;
      int num6810 = (int) numArray2220[this.ucScreenLED1.LEDA1 * 3 + 2];
      numArray2331[index2322] = (byte) num6810;
      byte[] numArray2332 = second;
      int num6811 = num6809;
      int num6812 = num6811 + 1;
      int index2323 = num6811;
      int num6813 = (int) numArray2220[this.ucScreenLED1.LEDF1 * 3];
      numArray2332[index2323] = (byte) num6813;
      byte[] numArray2333 = second;
      int num6814 = num6812;
      int num6815 = num6814 + 1;
      int index2324 = num6814;
      int num6816 = (int) numArray2220[this.ucScreenLED1.LEDF1 * 3 + 1];
      numArray2333[index2324] = (byte) num6816;
      byte[] numArray2334 = second;
      int num6817 = num6815;
      int num6818 = num6817 + 1;
      int index2325 = num6817;
      int num6819 = (int) numArray2220[this.ucScreenLED1.LEDF1 * 3 + 2];
      numArray2334[index2325] = (byte) num6819;
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 11)
    {
      byte[] numArray2335 = new byte[411];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) numArray2335.Length,
        (byte) (numArray2335.Length >> 8),
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 93; ++index)
      {
        if (this.myOnOff == (byte) 0)
        {
          numArray2335[index * 3] = (byte) 0;
          numArray2335[index * 3 + 1] = (byte) 0;
          numArray2335[index * 3 + 2] = (byte) 0;
        }
        else if (this.ucScreenLED1.isOn[index])
        {
          numArray2335[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2 + (double) num1);
          numArray2335[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2 + (double) num1);
          numArray2335[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2 + (double) num1);
        }
        else
        {
          numArray2335[index * 3] = (byte) 0;
          numArray2335[index * 3 + 1] = (byte) 0;
          numArray2335[index * 3 + 2] = (byte) 0;
        }
      }
      int num6820 = 0;
      byte[] second = new byte[numArray2335.Length];
      byte[] numArray2336 = second;
      int num6821 = num6820;
      int num6822 = num6821 + 1;
      int index2326 = num6821;
      int num6823 = (int) numArray2335[this.ucScreenLED1.BFB * 3];
      numArray2336[index2326] = (byte) num6823;
      byte[] numArray2337 = second;
      int num6824 = num6822;
      int num6825 = num6824 + 1;
      int index2327 = num6824;
      int num6826 = (int) numArray2335[this.ucScreenLED1.BFB * 3 + 1];
      numArray2337[index2327] = (byte) num6826;
      byte[] numArray2338 = second;
      int num6827 = num6825;
      int num6828 = num6827 + 1;
      int index2328 = num6827;
      int num6829 = (int) numArray2335[this.ucScreenLED1.BFB * 3 + 2];
      numArray2338[index2328] = (byte) num6829;
      byte[] numArray2339 = second;
      int num6830 = num6828;
      int num6831 = num6830 + 1;
      int index2329 = num6830;
      int num6832 = (int) numArray2335[this.ucScreenLED1.LEDC12 * 3];
      numArray2339[index2329] = (byte) num6832;
      byte[] numArray2340 = second;
      int num6833 = num6831;
      int num6834 = num6833 + 1;
      int index2330 = num6833;
      int num6835 = (int) numArray2335[this.ucScreenLED1.LEDC12 * 3 + 1];
      numArray2340[index2330] = (byte) num6835;
      byte[] numArray2341 = second;
      int num6836 = num6834;
      int num6837 = num6836 + 1;
      int index2331 = num6836;
      int num6838 = (int) numArray2335[this.ucScreenLED1.LEDC12 * 3 + 2];
      numArray2341[index2331] = (byte) num6838;
      byte[] numArray2342 = second;
      int num6839 = num6837;
      int num6840 = num6839 + 1;
      int index2332 = num6839;
      int num6841 = (int) numArray2335[this.ucScreenLED1.LEDD12 * 3];
      numArray2342[index2332] = (byte) num6841;
      byte[] numArray2343 = second;
      int num6842 = num6840;
      int num6843 = num6842 + 1;
      int index2333 = num6842;
      int num6844 = (int) numArray2335[this.ucScreenLED1.LEDD12 * 3 + 1];
      numArray2343[index2333] = (byte) num6844;
      byte[] numArray2344 = second;
      int num6845 = num6843;
      int num6846 = num6845 + 1;
      int index2334 = num6845;
      int num6847 = (int) numArray2335[this.ucScreenLED1.LEDD12 * 3 + 2];
      numArray2344[index2334] = (byte) num6847;
      byte[] numArray2345 = second;
      int num6848 = num6846;
      int num6849 = num6848 + 1;
      int index2335 = num6848;
      int num6850 = (int) numArray2335[this.ucScreenLED1.LEDE12 * 3];
      numArray2345[index2335] = (byte) num6850;
      byte[] numArray2346 = second;
      int num6851 = num6849;
      int num6852 = num6851 + 1;
      int index2336 = num6851;
      int num6853 = (int) numArray2335[this.ucScreenLED1.LEDE12 * 3 + 1];
      numArray2346[index2336] = (byte) num6853;
      byte[] numArray2347 = second;
      int num6854 = num6852;
      int num6855 = num6854 + 1;
      int index2337 = num6854;
      int num6856 = (int) numArray2335[this.ucScreenLED1.LEDE12 * 3 + 2];
      numArray2347[index2337] = (byte) num6856;
      byte[] numArray2348 = second;
      int num6857 = num6855;
      int num6858 = num6857 + 1;
      int index2338 = num6857;
      int num6859 = (int) numArray2335[this.ucScreenLED1.LEDG12 * 3];
      numArray2348[index2338] = (byte) num6859;
      byte[] numArray2349 = second;
      int num6860 = num6858;
      int num6861 = num6860 + 1;
      int index2339 = num6860;
      int num6862 = (int) numArray2335[this.ucScreenLED1.LEDG12 * 3 + 1];
      numArray2349[index2339] = (byte) num6862;
      byte[] numArray2350 = second;
      int num6863 = num6861;
      int num6864 = num6863 + 1;
      int index2340 = num6863;
      int num6865 = (int) numArray2335[this.ucScreenLED1.LEDG12 * 3 + 2];
      numArray2350[index2340] = (byte) num6865;
      byte[] numArray2351 = second;
      int num6866 = num6864;
      int num6867 = num6866 + 1;
      int index2341 = num6866;
      int num6868 = (int) numArray2335[this.ucScreenLED1.LEDB12 * 3];
      numArray2351[index2341] = (byte) num6868;
      byte[] numArray2352 = second;
      int num6869 = num6867;
      int num6870 = num6869 + 1;
      int index2342 = num6869;
      int num6871 = (int) numArray2335[this.ucScreenLED1.LEDB12 * 3 + 1];
      numArray2352[index2342] = (byte) num6871;
      byte[] numArray2353 = second;
      int num6872 = num6870;
      int num6873 = num6872 + 1;
      int index2343 = num6872;
      int num6874 = (int) numArray2335[this.ucScreenLED1.LEDB12 * 3 + 2];
      numArray2353[index2343] = (byte) num6874;
      byte[] numArray2354 = second;
      int num6875 = num6873;
      int num6876 = num6875 + 1;
      int index2344 = num6875;
      int num6877 = (int) numArray2335[this.ucScreenLED1.LEDA12 * 3];
      numArray2354[index2344] = (byte) num6877;
      byte[] numArray2355 = second;
      int num6878 = num6876;
      int num6879 = num6878 + 1;
      int index2345 = num6878;
      int num6880 = (int) numArray2335[this.ucScreenLED1.LEDA12 * 3 + 1];
      numArray2355[index2345] = (byte) num6880;
      byte[] numArray2356 = second;
      int num6881 = num6879;
      int num6882 = num6881 + 1;
      int index2346 = num6881;
      int num6883 = (int) numArray2335[this.ucScreenLED1.LEDA12 * 3 + 2];
      numArray2356[index2346] = (byte) num6883;
      byte[] numArray2357 = second;
      int num6884 = num6882;
      int num6885 = num6884 + 1;
      int index2347 = num6884;
      int num6886 = (int) numArray2335[this.ucScreenLED1.LEDF12 * 3];
      numArray2357[index2347] = (byte) num6886;
      byte[] numArray2358 = second;
      int num6887 = num6885;
      int num6888 = num6887 + 1;
      int index2348 = num6887;
      int num6889 = (int) numArray2335[this.ucScreenLED1.LEDF12 * 3 + 1];
      numArray2358[index2348] = (byte) num6889;
      byte[] numArray2359 = second;
      int num6890 = num6888;
      int num6891 = num6890 + 1;
      int index2349 = num6890;
      int num6892 = (int) numArray2335[this.ucScreenLED1.LEDF12 * 3 + 2];
      numArray2359[index2349] = (byte) num6892;
      byte[] numArray2360 = second;
      int num6893 = num6891;
      int num6894 = num6893 + 1;
      int index2350 = num6893;
      int num6895 = (int) numArray2335[this.ucScreenLED1.LEDC11 * 3];
      numArray2360[index2350] = (byte) num6895;
      byte[] numArray2361 = second;
      int num6896 = num6894;
      int num6897 = num6896 + 1;
      int index2351 = num6896;
      int num6898 = (int) numArray2335[this.ucScreenLED1.LEDC11 * 3 + 1];
      numArray2361[index2351] = (byte) num6898;
      byte[] numArray2362 = second;
      int num6899 = num6897;
      int num6900 = num6899 + 1;
      int index2352 = num6899;
      int num6901 = (int) numArray2335[this.ucScreenLED1.LEDC11 * 3 + 2];
      numArray2362[index2352] = (byte) num6901;
      byte[] numArray2363 = second;
      int num6902 = num6900;
      int num6903 = num6902 + 1;
      int index2353 = num6902;
      int num6904 = (int) numArray2335[this.ucScreenLED1.LEDD11 * 3];
      numArray2363[index2353] = (byte) num6904;
      byte[] numArray2364 = second;
      int num6905 = num6903;
      int num6906 = num6905 + 1;
      int index2354 = num6905;
      int num6907 = (int) numArray2335[this.ucScreenLED1.LEDD11 * 3 + 1];
      numArray2364[index2354] = (byte) num6907;
      byte[] numArray2365 = second;
      int num6908 = num6906;
      int num6909 = num6908 + 1;
      int index2355 = num6908;
      int num6910 = (int) numArray2335[this.ucScreenLED1.LEDD11 * 3 + 2];
      numArray2365[index2355] = (byte) num6910;
      byte[] numArray2366 = second;
      int num6911 = num6909;
      int num6912 = num6911 + 1;
      int index2356 = num6911;
      int num6913 = (int) numArray2335[this.ucScreenLED1.LEDE11 * 3];
      numArray2366[index2356] = (byte) num6913;
      byte[] numArray2367 = second;
      int num6914 = num6912;
      int num6915 = num6914 + 1;
      int index2357 = num6914;
      int num6916 = (int) numArray2335[this.ucScreenLED1.LEDE11 * 3 + 1];
      numArray2367[index2357] = (byte) num6916;
      byte[] numArray2368 = second;
      int num6917 = num6915;
      int num6918 = num6917 + 1;
      int index2358 = num6917;
      int num6919 = (int) numArray2335[this.ucScreenLED1.LEDE11 * 3 + 2];
      numArray2368[index2358] = (byte) num6919;
      byte[] numArray2369 = second;
      int num6920 = num6918;
      int num6921 = num6920 + 1;
      int index2359 = num6920;
      int num6922 = (int) numArray2335[this.ucScreenLED1.LEDG11 * 3];
      numArray2369[index2359] = (byte) num6922;
      byte[] numArray2370 = second;
      int num6923 = num6921;
      int num6924 = num6923 + 1;
      int index2360 = num6923;
      int num6925 = (int) numArray2335[this.ucScreenLED1.LEDG11 * 3 + 1];
      numArray2370[index2360] = (byte) num6925;
      byte[] numArray2371 = second;
      int num6926 = num6924;
      int num6927 = num6926 + 1;
      int index2361 = num6926;
      int num6928 = (int) numArray2335[this.ucScreenLED1.LEDG11 * 3 + 2];
      numArray2371[index2361] = (byte) num6928;
      byte[] numArray2372 = second;
      int num6929 = num6927;
      int num6930 = num6929 + 1;
      int index2362 = num6929;
      int num6931 = (int) numArray2335[this.ucScreenLED1.LEDB11 * 3];
      numArray2372[index2362] = (byte) num6931;
      byte[] numArray2373 = second;
      int num6932 = num6930;
      int num6933 = num6932 + 1;
      int index2363 = num6932;
      int num6934 = (int) numArray2335[this.ucScreenLED1.LEDB11 * 3 + 1];
      numArray2373[index2363] = (byte) num6934;
      byte[] numArray2374 = second;
      int num6935 = num6933;
      int num6936 = num6935 + 1;
      int index2364 = num6935;
      int num6937 = (int) numArray2335[this.ucScreenLED1.LEDB11 * 3 + 2];
      numArray2374[index2364] = (byte) num6937;
      byte[] numArray2375 = second;
      int num6938 = num6936;
      int num6939 = num6938 + 1;
      int index2365 = num6938;
      int num6940 = (int) numArray2335[this.ucScreenLED1.LEDA11 * 3];
      numArray2375[index2365] = (byte) num6940;
      byte[] numArray2376 = second;
      int num6941 = num6939;
      int num6942 = num6941 + 1;
      int index2366 = num6941;
      int num6943 = (int) numArray2335[this.ucScreenLED1.LEDA11 * 3 + 1];
      numArray2376[index2366] = (byte) num6943;
      byte[] numArray2377 = second;
      int num6944 = num6942;
      int num6945 = num6944 + 1;
      int index2367 = num6944;
      int num6946 = (int) numArray2335[this.ucScreenLED1.LEDA11 * 3 + 2];
      numArray2377[index2367] = (byte) num6946;
      byte[] numArray2378 = second;
      int num6947 = num6945;
      int num6948 = num6947 + 1;
      int index2368 = num6947;
      int num6949 = (int) numArray2335[this.ucScreenLED1.LEDF11 * 3];
      numArray2378[index2368] = (byte) num6949;
      byte[] numArray2379 = second;
      int num6950 = num6948;
      int num6951 = num6950 + 1;
      int index2369 = num6950;
      int num6952 = (int) numArray2335[this.ucScreenLED1.LEDF11 * 3 + 1];
      numArray2379[index2369] = (byte) num6952;
      byte[] numArray2380 = second;
      int num6953 = num6951;
      int num6954 = num6953 + 1;
      int index2370 = num6953;
      int num6955 = (int) numArray2335[this.ucScreenLED1.LEDF11 * 3 + 2];
      numArray2380[index2370] = (byte) num6955;
      byte[] numArray2381 = second;
      int num6956 = num6954;
      int num6957 = num6956 + 1;
      int index2371 = num6956;
      int num6958 = (int) numArray2335[this.ucScreenLED1.LEDB13 * 3];
      numArray2381[index2371] = (byte) num6958;
      byte[] numArray2382 = second;
      int num6959 = num6957;
      int num6960 = num6959 + 1;
      int index2372 = num6959;
      int num6961 = (int) numArray2335[this.ucScreenLED1.LEDB13 * 3 + 1];
      numArray2382[index2372] = (byte) num6961;
      byte[] numArray2383 = second;
      int num6962 = num6960;
      int num6963 = num6962 + 1;
      int index2373 = num6962;
      int num6964 = (int) numArray2335[this.ucScreenLED1.LEDB13 * 3 + 2];
      numArray2383[index2373] = (byte) num6964;
      byte[] numArray2384 = second;
      int num6965 = num6963;
      int num6966 = num6965 + 1;
      int index2374 = num6965;
      int num6967 = (int) numArray2335[this.ucScreenLED1.LEDC13 * 3];
      numArray2384[index2374] = (byte) num6967;
      byte[] numArray2385 = second;
      int num6968 = num6966;
      int num6969 = num6968 + 1;
      int index2375 = num6968;
      int num6970 = (int) numArray2335[this.ucScreenLED1.LEDC13 * 3 + 1];
      numArray2385[index2375] = (byte) num6970;
      byte[] numArray2386 = second;
      int num6971 = num6969;
      int num6972 = num6971 + 1;
      int index2376 = num6971;
      int num6973 = (int) numArray2335[this.ucScreenLED1.LEDC13 * 3 + 2];
      numArray2386[index2376] = (byte) num6973;
      byte[] numArray2387 = second;
      int num6974 = num6972;
      int num6975 = num6974 + 1;
      int index2377 = num6974;
      int num6976 = (int) numArray2335[this.ucScreenLED1.MHz * 3];
      numArray2387[index2377] = (byte) num6976;
      byte[] numArray2388 = second;
      int num6977 = num6975;
      int num6978 = num6977 + 1;
      int index2378 = num6977;
      int num6979 = (int) numArray2335[this.ucScreenLED1.MHz * 3 + 1];
      numArray2388[index2378] = (byte) num6979;
      byte[] numArray2389 = second;
      int num6980 = num6978;
      int num6981 = num6980 + 1;
      int index2379 = num6980;
      int num6982 = (int) numArray2335[this.ucScreenLED1.MHz * 3 + 2];
      numArray2389[index2379] = (byte) num6982;
      byte[] numArray2390 = second;
      int num6983 = num6981;
      int num6984 = num6983 + 1;
      int index2380 = num6983;
      int num6985 = (int) numArray2335[this.ucScreenLED1.MHz * 3];
      numArray2390[index2380] = (byte) num6985;
      byte[] numArray2391 = second;
      int num6986 = num6984;
      int num6987 = num6986 + 1;
      int index2381 = num6986;
      int num6988 = (int) numArray2335[this.ucScreenLED1.MHz * 3 + 1];
      numArray2391[index2381] = (byte) num6988;
      byte[] numArray2392 = second;
      int num6989 = num6987;
      int num6990 = num6989 + 1;
      int index2382 = num6989;
      int num6991 = (int) numArray2335[this.ucScreenLED1.MHz * 3 + 2];
      numArray2392[index2382] = (byte) num6991;
      byte[] numArray2393 = second;
      int num6992 = num6990;
      int num6993 = num6992 + 1;
      int index2383 = num6992;
      int num6994 = (int) numArray2335[this.ucScreenLED1.LEDC10 * 3];
      numArray2393[index2383] = (byte) num6994;
      byte[] numArray2394 = second;
      int num6995 = num6993;
      int num6996 = num6995 + 1;
      int index2384 = num6995;
      int num6997 = (int) numArray2335[this.ucScreenLED1.LEDC10 * 3 + 1];
      numArray2394[index2384] = (byte) num6997;
      byte[] numArray2395 = second;
      int num6998 = num6996;
      int num6999 = num6998 + 1;
      int index2385 = num6998;
      int num7000 = (int) numArray2335[this.ucScreenLED1.LEDC10 * 3 + 2];
      numArray2395[index2385] = (byte) num7000;
      byte[] numArray2396 = second;
      int num7001 = num6999;
      int num7002 = num7001 + 1;
      int index2386 = num7001;
      int num7003 = (int) numArray2335[this.ucScreenLED1.LEDD10 * 3];
      numArray2396[index2386] = (byte) num7003;
      byte[] numArray2397 = second;
      int num7004 = num7002;
      int num7005 = num7004 + 1;
      int index2387 = num7004;
      int num7006 = (int) numArray2335[this.ucScreenLED1.LEDD10 * 3 + 1];
      numArray2397[index2387] = (byte) num7006;
      byte[] numArray2398 = second;
      int num7007 = num7005;
      int num7008 = num7007 + 1;
      int index2388 = num7007;
      int num7009 = (int) numArray2335[this.ucScreenLED1.LEDD10 * 3 + 2];
      numArray2398[index2388] = (byte) num7009;
      byte[] numArray2399 = second;
      int num7010 = num7008;
      int num7011 = num7010 + 1;
      int index2389 = num7010;
      int num7012 = (int) numArray2335[this.ucScreenLED1.LEDE10 * 3];
      numArray2399[index2389] = (byte) num7012;
      byte[] numArray2400 = second;
      int num7013 = num7011;
      int num7014 = num7013 + 1;
      int index2390 = num7013;
      int num7015 = (int) numArray2335[this.ucScreenLED1.LEDE10 * 3 + 1];
      numArray2400[index2390] = (byte) num7015;
      byte[] numArray2401 = second;
      int num7016 = num7014;
      int num7017 = num7016 + 1;
      int index2391 = num7016;
      int num7018 = (int) numArray2335[this.ucScreenLED1.LEDE10 * 3 + 2];
      numArray2401[index2391] = (byte) num7018;
      byte[] numArray2402 = second;
      int num7019 = num7017;
      int num7020 = num7019 + 1;
      int index2392 = num7019;
      int num7021 = (int) numArray2335[this.ucScreenLED1.LEDG10 * 3];
      numArray2402[index2392] = (byte) num7021;
      byte[] numArray2403 = second;
      int num7022 = num7020;
      int num7023 = num7022 + 1;
      int index2393 = num7022;
      int num7024 = (int) numArray2335[this.ucScreenLED1.LEDG10 * 3 + 1];
      numArray2403[index2393] = (byte) num7024;
      byte[] numArray2404 = second;
      int num7025 = num7023;
      int num7026 = num7025 + 1;
      int index2394 = num7025;
      int num7027 = (int) numArray2335[this.ucScreenLED1.LEDG10 * 3 + 2];
      numArray2404[index2394] = (byte) num7027;
      byte[] numArray2405 = second;
      int num7028 = num7026;
      int num7029 = num7028 + 1;
      int index2395 = num7028;
      int num7030 = (int) numArray2335[this.ucScreenLED1.LEDB10 * 3];
      numArray2405[index2395] = (byte) num7030;
      byte[] numArray2406 = second;
      int num7031 = num7029;
      int num7032 = num7031 + 1;
      int index2396 = num7031;
      int num7033 = (int) numArray2335[this.ucScreenLED1.LEDB10 * 3 + 1];
      numArray2406[index2396] = (byte) num7033;
      byte[] numArray2407 = second;
      int num7034 = num7032;
      int num7035 = num7034 + 1;
      int index2397 = num7034;
      int num7036 = (int) numArray2335[this.ucScreenLED1.LEDB10 * 3 + 2];
      numArray2407[index2397] = (byte) num7036;
      byte[] numArray2408 = second;
      int num7037 = num7035;
      int num7038 = num7037 + 1;
      int index2398 = num7037;
      int num7039 = (int) numArray2335[this.ucScreenLED1.LEDA10 * 3];
      numArray2408[index2398] = (byte) num7039;
      byte[] numArray2409 = second;
      int num7040 = num7038;
      int num7041 = num7040 + 1;
      int index2399 = num7040;
      int num7042 = (int) numArray2335[this.ucScreenLED1.LEDA10 * 3 + 1];
      numArray2409[index2399] = (byte) num7042;
      byte[] numArray2410 = second;
      int num7043 = num7041;
      int num7044 = num7043 + 1;
      int index2400 = num7043;
      int num7045 = (int) numArray2335[this.ucScreenLED1.LEDA10 * 3 + 2];
      numArray2410[index2400] = (byte) num7045;
      byte[] numArray2411 = second;
      int num7046 = num7044;
      int num7047 = num7046 + 1;
      int index2401 = num7046;
      int num7048 = (int) numArray2335[this.ucScreenLED1.LEDF10 * 3];
      numArray2411[index2401] = (byte) num7048;
      byte[] numArray2412 = second;
      int num7049 = num7047;
      int num7050 = num7049 + 1;
      int index2402 = num7049;
      int num7051 = (int) numArray2335[this.ucScreenLED1.LEDF10 * 3 + 1];
      numArray2412[index2402] = (byte) num7051;
      byte[] numArray2413 = second;
      int num7052 = num7050;
      int num7053 = num7052 + 1;
      int index2403 = num7052;
      int num7054 = (int) numArray2335[this.ucScreenLED1.LEDF10 * 3 + 2];
      numArray2413[index2403] = (byte) num7054;
      byte[] numArray2414 = second;
      int num7055 = num7053;
      int num7056 = num7055 + 1;
      int index2404 = num7055;
      int num7057 = (int) numArray2335[this.ucScreenLED1.LEDC9 * 3];
      numArray2414[index2404] = (byte) num7057;
      byte[] numArray2415 = second;
      int num7058 = num7056;
      int num7059 = num7058 + 1;
      int index2405 = num7058;
      int num7060 = (int) numArray2335[this.ucScreenLED1.LEDC9 * 3 + 1];
      numArray2415[index2405] = (byte) num7060;
      byte[] numArray2416 = second;
      int num7061 = num7059;
      int num7062 = num7061 + 1;
      int index2406 = num7061;
      int num7063 = (int) numArray2335[this.ucScreenLED1.LEDC9 * 3 + 2];
      numArray2416[index2406] = (byte) num7063;
      byte[] numArray2417 = second;
      int num7064 = num7062;
      int num7065 = num7064 + 1;
      int index2407 = num7064;
      int num7066 = (int) numArray2335[this.ucScreenLED1.LEDD9 * 3];
      numArray2417[index2407] = (byte) num7066;
      byte[] numArray2418 = second;
      int num7067 = num7065;
      int num7068 = num7067 + 1;
      int index2408 = num7067;
      int num7069 = (int) numArray2335[this.ucScreenLED1.LEDD9 * 3 + 1];
      numArray2418[index2408] = (byte) num7069;
      byte[] numArray2419 = second;
      int num7070 = num7068;
      int num7071 = num7070 + 1;
      int index2409 = num7070;
      int num7072 = (int) numArray2335[this.ucScreenLED1.LEDD9 * 3 + 2];
      numArray2419[index2409] = (byte) num7072;
      byte[] numArray2420 = second;
      int num7073 = num7071;
      int num7074 = num7073 + 1;
      int index2410 = num7073;
      int num7075 = (int) numArray2335[this.ucScreenLED1.LEDE9 * 3];
      numArray2420[index2410] = (byte) num7075;
      byte[] numArray2421 = second;
      int num7076 = num7074;
      int num7077 = num7076 + 1;
      int index2411 = num7076;
      int num7078 = (int) numArray2335[this.ucScreenLED1.LEDE9 * 3 + 1];
      numArray2421[index2411] = (byte) num7078;
      byte[] numArray2422 = second;
      int num7079 = num7077;
      int num7080 = num7079 + 1;
      int index2412 = num7079;
      int num7081 = (int) numArray2335[this.ucScreenLED1.LEDE9 * 3 + 2];
      numArray2422[index2412] = (byte) num7081;
      byte[] numArray2423 = second;
      int num7082 = num7080;
      int num7083 = num7082 + 1;
      int index2413 = num7082;
      int num7084 = (int) numArray2335[this.ucScreenLED1.LEDG9 * 3];
      numArray2423[index2413] = (byte) num7084;
      byte[] numArray2424 = second;
      int num7085 = num7083;
      int num7086 = num7085 + 1;
      int index2414 = num7085;
      int num7087 = (int) numArray2335[this.ucScreenLED1.LEDG9 * 3 + 1];
      numArray2424[index2414] = (byte) num7087;
      byte[] numArray2425 = second;
      int num7088 = num7086;
      int num7089 = num7088 + 1;
      int index2415 = num7088;
      int num7090 = (int) numArray2335[this.ucScreenLED1.LEDG9 * 3 + 2];
      numArray2425[index2415] = (byte) num7090;
      byte[] numArray2426 = second;
      int num7091 = num7089;
      int num7092 = num7091 + 1;
      int index2416 = num7091;
      int num7093 = (int) numArray2335[this.ucScreenLED1.LEDB9 * 3];
      numArray2426[index2416] = (byte) num7093;
      byte[] numArray2427 = second;
      int num7094 = num7092;
      int num7095 = num7094 + 1;
      int index2417 = num7094;
      int num7096 = (int) numArray2335[this.ucScreenLED1.LEDB9 * 3 + 1];
      numArray2427[index2417] = (byte) num7096;
      byte[] numArray2428 = second;
      int num7097 = num7095;
      int num7098 = num7097 + 1;
      int index2418 = num7097;
      int num7099 = (int) numArray2335[this.ucScreenLED1.LEDB9 * 3 + 2];
      numArray2428[index2418] = (byte) num7099;
      byte[] numArray2429 = second;
      int num7100 = num7098;
      int num7101 = num7100 + 1;
      int index2419 = num7100;
      int num7102 = (int) numArray2335[this.ucScreenLED1.LEDA9 * 3];
      numArray2429[index2419] = (byte) num7102;
      byte[] numArray2430 = second;
      int num7103 = num7101;
      int num7104 = num7103 + 1;
      int index2420 = num7103;
      int num7105 = (int) numArray2335[this.ucScreenLED1.LEDA9 * 3 + 1];
      numArray2430[index2420] = (byte) num7105;
      byte[] numArray2431 = second;
      int num7106 = num7104;
      int num7107 = num7106 + 1;
      int index2421 = num7106;
      int num7108 = (int) numArray2335[this.ucScreenLED1.LEDA9 * 3 + 2];
      numArray2431[index2421] = (byte) num7108;
      byte[] numArray2432 = second;
      int num7109 = num7107;
      int num7110 = num7109 + 1;
      int index2422 = num7109;
      int num7111 = (int) numArray2335[this.ucScreenLED1.LEDF9 * 3];
      numArray2432[index2422] = (byte) num7111;
      byte[] numArray2433 = second;
      int num7112 = num7110;
      int num7113 = num7112 + 1;
      int index2423 = num7112;
      int num7114 = (int) numArray2335[this.ucScreenLED1.LEDF9 * 3 + 1];
      numArray2433[index2423] = (byte) num7114;
      byte[] numArray2434 = second;
      int num7115 = num7113;
      int num7116 = num7115 + 1;
      int index2424 = num7115;
      int num7117 = (int) numArray2335[this.ucScreenLED1.LEDF9 * 3 + 2];
      numArray2434[index2424] = (byte) num7117;
      byte[] numArray2435 = second;
      int num7118 = num7116;
      int num7119 = num7118 + 1;
      int index2425 = num7118;
      int num7120 = (int) numArray2335[this.ucScreenLED1.LEDC8 * 3];
      numArray2435[index2425] = (byte) num7120;
      byte[] numArray2436 = second;
      int num7121 = num7119;
      int num7122 = num7121 + 1;
      int index2426 = num7121;
      int num7123 = (int) numArray2335[this.ucScreenLED1.LEDC8 * 3 + 1];
      numArray2436[index2426] = (byte) num7123;
      byte[] numArray2437 = second;
      int num7124 = num7122;
      int num7125 = num7124 + 1;
      int index2427 = num7124;
      int num7126 = (int) numArray2335[this.ucScreenLED1.LEDC8 * 3 + 2];
      numArray2437[index2427] = (byte) num7126;
      byte[] numArray2438 = second;
      int num7127 = num7125;
      int num7128 = num7127 + 1;
      int index2428 = num7127;
      int num7129 = (int) numArray2335[this.ucScreenLED1.LEDD8 * 3];
      numArray2438[index2428] = (byte) num7129;
      byte[] numArray2439 = second;
      int num7130 = num7128;
      int num7131 = num7130 + 1;
      int index2429 = num7130;
      int num7132 = (int) numArray2335[this.ucScreenLED1.LEDD8 * 3 + 1];
      numArray2439[index2429] = (byte) num7132;
      byte[] numArray2440 = second;
      int num7133 = num7131;
      int num7134 = num7133 + 1;
      int index2430 = num7133;
      int num7135 = (int) numArray2335[this.ucScreenLED1.LEDD8 * 3 + 2];
      numArray2440[index2430] = (byte) num7135;
      byte[] numArray2441 = second;
      int num7136 = num7134;
      int num7137 = num7136 + 1;
      int index2431 = num7136;
      int num7138 = (int) numArray2335[this.ucScreenLED1.LEDE8 * 3];
      numArray2441[index2431] = (byte) num7138;
      byte[] numArray2442 = second;
      int num7139 = num7137;
      int num7140 = num7139 + 1;
      int index2432 = num7139;
      int num7141 = (int) numArray2335[this.ucScreenLED1.LEDE8 * 3 + 1];
      numArray2442[index2432] = (byte) num7141;
      byte[] numArray2443 = second;
      int num7142 = num7140;
      int num7143 = num7142 + 1;
      int index2433 = num7142;
      int num7144 = (int) numArray2335[this.ucScreenLED1.LEDE8 * 3 + 2];
      numArray2443[index2433] = (byte) num7144;
      byte[] numArray2444 = second;
      int num7145 = num7143;
      int num7146 = num7145 + 1;
      int index2434 = num7145;
      int num7147 = (int) numArray2335[this.ucScreenLED1.LEDG8 * 3];
      numArray2444[index2434] = (byte) num7147;
      byte[] numArray2445 = second;
      int num7148 = num7146;
      int num7149 = num7148 + 1;
      int index2435 = num7148;
      int num7150 = (int) numArray2335[this.ucScreenLED1.LEDG8 * 3 + 1];
      numArray2445[index2435] = (byte) num7150;
      byte[] numArray2446 = second;
      int num7151 = num7149;
      int num7152 = num7151 + 1;
      int index2436 = num7151;
      int num7153 = (int) numArray2335[this.ucScreenLED1.LEDG8 * 3 + 2];
      numArray2446[index2436] = (byte) num7153;
      byte[] numArray2447 = second;
      int num7154 = num7152;
      int num7155 = num7154 + 1;
      int index2437 = num7154;
      int num7156 = (int) numArray2335[this.ucScreenLED1.LEDB8 * 3];
      numArray2447[index2437] = (byte) num7156;
      byte[] numArray2448 = second;
      int num7157 = num7155;
      int num7158 = num7157 + 1;
      int index2438 = num7157;
      int num7159 = (int) numArray2335[this.ucScreenLED1.LEDB8 * 3 + 1];
      numArray2448[index2438] = (byte) num7159;
      byte[] numArray2449 = second;
      int num7160 = num7158;
      int num7161 = num7160 + 1;
      int index2439 = num7160;
      int num7162 = (int) numArray2335[this.ucScreenLED1.LEDB8 * 3 + 2];
      numArray2449[index2439] = (byte) num7162;
      byte[] numArray2450 = second;
      int num7163 = num7161;
      int num7164 = num7163 + 1;
      int index2440 = num7163;
      int num7165 = (int) numArray2335[this.ucScreenLED1.LEDA8 * 3];
      numArray2450[index2440] = (byte) num7165;
      byte[] numArray2451 = second;
      int num7166 = num7164;
      int num7167 = num7166 + 1;
      int index2441 = num7166;
      int num7168 = (int) numArray2335[this.ucScreenLED1.LEDA8 * 3 + 1];
      numArray2451[index2441] = (byte) num7168;
      byte[] numArray2452 = second;
      int num7169 = num7167;
      int num7170 = num7169 + 1;
      int index2442 = num7169;
      int num7171 = (int) numArray2335[this.ucScreenLED1.LEDA8 * 3 + 2];
      numArray2452[index2442] = (byte) num7171;
      byte[] numArray2453 = second;
      int num7172 = num7170;
      int num7173 = num7172 + 1;
      int index2443 = num7172;
      int num7174 = (int) numArray2335[this.ucScreenLED1.LEDF8 * 3];
      numArray2453[index2443] = (byte) num7174;
      byte[] numArray2454 = second;
      int num7175 = num7173;
      int num7176 = num7175 + 1;
      int index2444 = num7175;
      int num7177 = (int) numArray2335[this.ucScreenLED1.LEDF8 * 3 + 1];
      numArray2454[index2444] = (byte) num7177;
      byte[] numArray2455 = second;
      int num7178 = num7176;
      int num7179 = num7178 + 1;
      int index2445 = num7178;
      int num7180 = (int) numArray2335[this.ucScreenLED1.LEDF8 * 3 + 2];
      numArray2455[index2445] = (byte) num7180;
      byte[] numArray2456 = second;
      int num7181 = num7179;
      int num7182 = num7181 + 1;
      int index2446 = num7181;
      int num7183 = (int) numArray2335[this.ucScreenLED1.LEDC7 * 3];
      numArray2456[index2446] = (byte) num7183;
      byte[] numArray2457 = second;
      int num7184 = num7182;
      int num7185 = num7184 + 1;
      int index2447 = num7184;
      int num7186 = (int) numArray2335[this.ucScreenLED1.LEDC7 * 3 + 1];
      numArray2457[index2447] = (byte) num7186;
      byte[] numArray2458 = second;
      int num7187 = num7185;
      int num7188 = num7187 + 1;
      int index2448 = num7187;
      int num7189 = (int) numArray2335[this.ucScreenLED1.LEDC7 * 3 + 2];
      numArray2458[index2448] = (byte) num7189;
      byte[] numArray2459 = second;
      int num7190 = num7188;
      int num7191 = num7190 + 1;
      int index2449 = num7190;
      int num7192 = (int) numArray2335[this.ucScreenLED1.LEDD7 * 3];
      numArray2459[index2449] = (byte) num7192;
      byte[] numArray2460 = second;
      int num7193 = num7191;
      int num7194 = num7193 + 1;
      int index2450 = num7193;
      int num7195 = (int) numArray2335[this.ucScreenLED1.LEDD7 * 3 + 1];
      numArray2460[index2450] = (byte) num7195;
      byte[] numArray2461 = second;
      int num7196 = num7194;
      int num7197 = num7196 + 1;
      int index2451 = num7196;
      int num7198 = (int) numArray2335[this.ucScreenLED1.LEDD7 * 3 + 2];
      numArray2461[index2451] = (byte) num7198;
      byte[] numArray2462 = second;
      int num7199 = num7197;
      int num7200 = num7199 + 1;
      int index2452 = num7199;
      int num7201 = (int) numArray2335[this.ucScreenLED1.LEDE7 * 3];
      numArray2462[index2452] = (byte) num7201;
      byte[] numArray2463 = second;
      int num7202 = num7200;
      int num7203 = num7202 + 1;
      int index2453 = num7202;
      int num7204 = (int) numArray2335[this.ucScreenLED1.LEDE7 * 3 + 1];
      numArray2463[index2453] = (byte) num7204;
      byte[] numArray2464 = second;
      int num7205 = num7203;
      int num7206 = num7205 + 1;
      int index2454 = num7205;
      int num7207 = (int) numArray2335[this.ucScreenLED1.LEDE7 * 3 + 2];
      numArray2464[index2454] = (byte) num7207;
      byte[] numArray2465 = second;
      int num7208 = num7206;
      int num7209 = num7208 + 1;
      int index2455 = num7208;
      int num7210 = (int) numArray2335[this.ucScreenLED1.LEDG7 * 3];
      numArray2465[index2455] = (byte) num7210;
      byte[] numArray2466 = second;
      int num7211 = num7209;
      int num7212 = num7211 + 1;
      int index2456 = num7211;
      int num7213 = (int) numArray2335[this.ucScreenLED1.LEDG7 * 3 + 1];
      numArray2466[index2456] = (byte) num7213;
      byte[] numArray2467 = second;
      int num7214 = num7212;
      int num7215 = num7214 + 1;
      int index2457 = num7214;
      int num7216 = (int) numArray2335[this.ucScreenLED1.LEDG7 * 3 + 2];
      numArray2467[index2457] = (byte) num7216;
      byte[] numArray2468 = second;
      int num7217 = num7215;
      int num7218 = num7217 + 1;
      int index2458 = num7217;
      int num7219 = (int) numArray2335[this.ucScreenLED1.LEDB7 * 3];
      numArray2468[index2458] = (byte) num7219;
      byte[] numArray2469 = second;
      int num7220 = num7218;
      int num7221 = num7220 + 1;
      int index2459 = num7220;
      int num7222 = (int) numArray2335[this.ucScreenLED1.LEDB7 * 3 + 1];
      numArray2469[index2459] = (byte) num7222;
      byte[] numArray2470 = second;
      int num7223 = num7221;
      int num7224 = num7223 + 1;
      int index2460 = num7223;
      int num7225 = (int) numArray2335[this.ucScreenLED1.LEDB7 * 3 + 2];
      numArray2470[index2460] = (byte) num7225;
      byte[] numArray2471 = second;
      int num7226 = num7224;
      int num7227 = num7226 + 1;
      int index2461 = num7226;
      int num7228 = (int) numArray2335[this.ucScreenLED1.LEDA7 * 3];
      numArray2471[index2461] = (byte) num7228;
      byte[] numArray2472 = second;
      int num7229 = num7227;
      int num7230 = num7229 + 1;
      int index2462 = num7229;
      int num7231 = (int) numArray2335[this.ucScreenLED1.LEDA7 * 3 + 1];
      numArray2472[index2462] = (byte) num7231;
      byte[] numArray2473 = second;
      int num7232 = num7230;
      int num7233 = num7232 + 1;
      int index2463 = num7232;
      int num7234 = (int) numArray2335[this.ucScreenLED1.LEDA7 * 3 + 2];
      numArray2473[index2463] = (byte) num7234;
      byte[] numArray2474 = second;
      int num7235 = num7233;
      int num7236 = num7235 + 1;
      int index2464 = num7235;
      int num7237 = (int) numArray2335[this.ucScreenLED1.LEDF7 * 3];
      numArray2474[index2464] = (byte) num7237;
      byte[] numArray2475 = second;
      int num7238 = num7236;
      int num7239 = num7238 + 1;
      int index2465 = num7238;
      int num7240 = (int) numArray2335[this.ucScreenLED1.LEDF7 * 3 + 1];
      numArray2475[index2465] = (byte) num7240;
      byte[] numArray2476 = second;
      int num7241 = num7239;
      int num7242 = num7241 + 1;
      int index2466 = num7241;
      int num7243 = (int) numArray2335[this.ucScreenLED1.LEDF7 * 3 + 2];
      numArray2476[index2466] = (byte) num7243;
      float num7244 = (float) ((int) this.myOnOff * (int) this.myBrightness) * 0.01f;
      byte[] numArray2477 = second;
      int num7245 = num7242;
      int num7246 = num7245 + 1;
      int index2467 = num7245;
      int num7247 = (int) (byte) ((double) this.ledValLF15[41, 0] * (double) num7244 * (double) num2);
      numArray2477[index2467] = (byte) num7247;
      byte[] numArray2478 = second;
      int num7248 = num7246;
      int num7249 = num7248 + 1;
      int index2468 = num7248;
      int num7250 = (int) (byte) ((double) this.ledValLF15[41, 1] * (double) num7244 * (double) num2);
      numArray2478[index2468] = (byte) num7250;
      byte[] numArray2479 = second;
      int num7251 = num7249;
      int num7252 = num7251 + 1;
      int index2469 = num7251;
      int num7253 = (int) (byte) ((double) this.ledValLF15[41, 2] * (double) num7244 * (double) num2);
      numArray2479[index2469] = (byte) num7253;
      byte[] numArray2480 = second;
      int num7254 = num7252;
      int num7255 = num7254 + 1;
      int index2470 = num7254;
      int num7256 = (int) (byte) ((double) this.ledValLF15[40, 0] * (double) num7244 * (double) num2);
      numArray2480[index2470] = (byte) num7256;
      byte[] numArray2481 = second;
      int num7257 = num7255;
      int num7258 = num7257 + 1;
      int index2471 = num7257;
      int num7259 = (int) (byte) ((double) this.ledValLF15[40, 1] * (double) num7244 * (double) num2);
      numArray2481[index2471] = (byte) num7259;
      byte[] numArray2482 = second;
      int num7260 = num7258;
      int num7261 = num7260 + 1;
      int index2472 = num7260;
      int num7262 = (int) (byte) ((double) this.ledValLF15[40, 2] * (double) num7244 * (double) num2);
      numArray2482[index2472] = (byte) num7262;
      byte[] numArray2483 = second;
      int num7263 = num7261;
      int num7264 = num7263 + 1;
      int index2473 = num7263;
      int num7265 = (int) (byte) ((double) this.ledValLF15[39, 0] * (double) num7244 * (double) num2);
      numArray2483[index2473] = (byte) num7265;
      byte[] numArray2484 = second;
      int num7266 = num7264;
      int num7267 = num7266 + 1;
      int index2474 = num7266;
      int num7268 = (int) (byte) ((double) this.ledValLF15[39, 1] * (double) num7244 * (double) num2);
      numArray2484[index2474] = (byte) num7268;
      byte[] numArray2485 = second;
      int num7269 = num7267;
      int num7270 = num7269 + 1;
      int index2475 = num7269;
      int num7271 = (int) (byte) ((double) this.ledValLF15[39, 2] * (double) num7244 * (double) num2);
      numArray2485[index2475] = (byte) num7271;
      byte[] numArray2486 = second;
      int num7272 = num7270;
      int num7273 = num7272 + 1;
      int index2476 = num7272;
      int num7274 = (int) (byte) ((double) this.ledValLF15[38, 0] * (double) num7244 * (double) num2);
      numArray2486[index2476] = (byte) num7274;
      byte[] numArray2487 = second;
      int num7275 = num7273;
      int num7276 = num7275 + 1;
      int index2477 = num7275;
      int num7277 = (int) (byte) ((double) this.ledValLF15[38, 1] * (double) num7244 * (double) num2);
      numArray2487[index2477] = (byte) num7277;
      byte[] numArray2488 = second;
      int num7278 = num7276;
      int num7279 = num7278 + 1;
      int index2478 = num7278;
      int num7280 = (int) (byte) ((double) this.ledValLF15[38, 2] * (double) num7244 * (double) num2);
      numArray2488[index2478] = (byte) num7280;
      byte[] numArray2489 = second;
      int num7281 = num7279;
      int num7282 = num7281 + 1;
      int index2479 = num7281;
      int num7283 = (int) (byte) ((double) this.ledValLF15[37, 0] * (double) num7244 * (double) num2);
      numArray2489[index2479] = (byte) num7283;
      byte[] numArray2490 = second;
      int num7284 = num7282;
      int num7285 = num7284 + 1;
      int index2480 = num7284;
      int num7286 = (int) (byte) ((double) this.ledValLF15[37, 1] * (double) num7244 * (double) num2);
      numArray2490[index2480] = (byte) num7286;
      byte[] numArray2491 = second;
      int num7287 = num7285;
      int num7288 = num7287 + 1;
      int index2481 = num7287;
      int num7289 = (int) (byte) ((double) this.ledValLF15[37, 2] * (double) num7244 * (double) num2);
      numArray2491[index2481] = (byte) num7289;
      byte[] numArray2492 = second;
      int num7290 = num7288;
      int num7291 = num7290 + 1;
      int index2482 = num7290;
      int num7292 = (int) (byte) ((double) this.ledValLF15[36, 0] * (double) num7244 * (double) num2);
      numArray2492[index2482] = (byte) num7292;
      byte[] numArray2493 = second;
      int num7293 = num7291;
      int num7294 = num7293 + 1;
      int index2483 = num7293;
      int num7295 = (int) (byte) ((double) this.ledValLF15[36, 1] * (double) num7244 * (double) num2);
      numArray2493[index2483] = (byte) num7295;
      byte[] numArray2494 = second;
      int num7296 = num7294;
      int num7297 = num7296 + 1;
      int index2484 = num7296;
      int num7298 = (int) (byte) ((double) this.ledValLF15[36, 2] * (double) num7244 * (double) num2);
      numArray2494[index2484] = (byte) num7298;
      byte[] numArray2495 = second;
      int num7299 = num7297;
      int num7300 = num7299 + 1;
      int index2485 = num7299;
      int num7301 = (int) (byte) ((double) this.ledValLF15[35, 0] * (double) num7244 * (double) num2);
      numArray2495[index2485] = (byte) num7301;
      byte[] numArray2496 = second;
      int num7302 = num7300;
      int num7303 = num7302 + 1;
      int index2486 = num7302;
      int num7304 = (int) (byte) ((double) this.ledValLF15[35, 1] * (double) num7244 * (double) num2);
      numArray2496[index2486] = (byte) num7304;
      byte[] numArray2497 = second;
      int num7305 = num7303;
      int num7306 = num7305 + 1;
      int index2487 = num7305;
      int num7307 = (int) (byte) ((double) this.ledValLF15[35, 2] * (double) num7244 * (double) num2);
      numArray2497[index2487] = (byte) num7307;
      byte[] numArray2498 = second;
      int num7308 = num7306;
      int num7309 = num7308 + 1;
      int index2488 = num7308;
      int num7310 = (int) (byte) ((double) this.ledValLF15[34, 0] * (double) num7244 * (double) num2);
      numArray2498[index2488] = (byte) num7310;
      byte[] numArray2499 = second;
      int num7311 = num7309;
      int num7312 = num7311 + 1;
      int index2489 = num7311;
      int num7313 = (int) (byte) ((double) this.ledValLF15[34, 1] * (double) num7244 * (double) num2);
      numArray2499[index2489] = (byte) num7313;
      byte[] numArray2500 = second;
      int num7314 = num7312;
      int num7315 = num7314 + 1;
      int index2490 = num7314;
      int num7316 = (int) (byte) ((double) this.ledValLF15[34, 2] * (double) num7244 * (double) num2);
      numArray2500[index2490] = (byte) num7316;
      byte[] numArray2501 = second;
      int num7317 = num7315;
      int num7318 = num7317 + 1;
      int index2491 = num7317;
      int num7319 = (int) (byte) ((double) this.ledValLF15[33, 0] * (double) num7244 * (double) num2);
      numArray2501[index2491] = (byte) num7319;
      byte[] numArray2502 = second;
      int num7320 = num7318;
      int num7321 = num7320 + 1;
      int index2492 = num7320;
      int num7322 = (int) (byte) ((double) this.ledValLF15[33, 1] * (double) num7244 * (double) num2);
      numArray2502[index2492] = (byte) num7322;
      byte[] numArray2503 = second;
      int num7323 = num7321;
      int num7324 = num7323 + 1;
      int index2493 = num7323;
      int num7325 = (int) (byte) ((double) this.ledValLF15[33, 2] * (double) num7244 * (double) num2);
      numArray2503[index2493] = (byte) num7325;
      byte[] numArray2504 = second;
      int num7326 = num7324;
      int num7327 = num7326 + 1;
      int index2494 = num7326;
      int num7328 = (int) (byte) ((double) this.ledValLF15[32 /*0x20*/, 0] * (double) num7244 * (double) num2);
      numArray2504[index2494] = (byte) num7328;
      byte[] numArray2505 = second;
      int num7329 = num7327;
      int num7330 = num7329 + 1;
      int index2495 = num7329;
      int num7331 = (int) (byte) ((double) this.ledValLF15[32 /*0x20*/, 1] * (double) num7244 * (double) num2);
      numArray2505[index2495] = (byte) num7331;
      byte[] numArray2506 = second;
      int num7332 = num7330;
      int num7333 = num7332 + 1;
      int index2496 = num7332;
      int num7334 = (int) (byte) ((double) this.ledValLF15[32 /*0x20*/, 2] * (double) num7244 * (double) num2);
      numArray2506[index2496] = (byte) num7334;
      byte[] numArray2507 = second;
      int num7335 = num7333;
      int num7336 = num7335 + 1;
      int index2497 = num7335;
      int num7337 = (int) (byte) ((double) this.ledValLF15[31 /*0x1F*/, 0] * (double) num7244 * (double) num2);
      numArray2507[index2497] = (byte) num7337;
      byte[] numArray2508 = second;
      int num7338 = num7336;
      int num7339 = num7338 + 1;
      int index2498 = num7338;
      int num7340 = (int) (byte) ((double) this.ledValLF15[31 /*0x1F*/, 1] * (double) num7244 * (double) num2);
      numArray2508[index2498] = (byte) num7340;
      byte[] numArray2509 = second;
      int num7341 = num7339;
      int num7342 = num7341 + 1;
      int index2499 = num7341;
      int num7343 = (int) (byte) ((double) this.ledValLF15[31 /*0x1F*/, 2] * (double) num7244 * (double) num2);
      numArray2509[index2499] = (byte) num7343;
      byte[] numArray2510 = second;
      int num7344 = num7342;
      int num7345 = num7344 + 1;
      int index2500 = num7344;
      int num7346 = (int) (byte) ((double) this.ledValLF15[30, 0] * (double) num7244 * (double) num2);
      numArray2510[index2500] = (byte) num7346;
      byte[] numArray2511 = second;
      int num7347 = num7345;
      int num7348 = num7347 + 1;
      int index2501 = num7347;
      int num7349 = (int) (byte) ((double) this.ledValLF15[30, 1] * (double) num7244 * (double) num2);
      numArray2511[index2501] = (byte) num7349;
      byte[] numArray2512 = second;
      int num7350 = num7348;
      int num7351 = num7350 + 1;
      int index2502 = num7350;
      int num7352 = (int) (byte) ((double) this.ledValLF15[30, 2] * (double) num7244 * (double) num2);
      numArray2512[index2502] = (byte) num7352;
      byte[] numArray2513 = second;
      int num7353 = num7351;
      int num7354 = num7353 + 1;
      int index2503 = num7353;
      int num7355 = (int) numArray2335[this.ucScreenLED1.WATT * 3];
      numArray2513[index2503] = (byte) num7355;
      byte[] numArray2514 = second;
      int num7356 = num7354;
      int num7357 = num7356 + 1;
      int index2504 = num7356;
      int num7358 = (int) numArray2335[this.ucScreenLED1.WATT * 3 + 1];
      numArray2514[index2504] = (byte) num7358;
      byte[] numArray2515 = second;
      int num7359 = num7357;
      int num7360 = num7359 + 1;
      int index2505 = num7359;
      int num7361 = (int) numArray2335[this.ucScreenLED1.WATT * 3 + 2];
      numArray2515[index2505] = (byte) num7361;
      byte[] numArray2516 = second;
      int num7362 = num7360;
      int num7363 = num7362 + 1;
      int index2506 = num7362;
      int num7364 = (int) numArray2335[this.ucScreenLED1.LEDC6 * 3];
      numArray2516[index2506] = (byte) num7364;
      byte[] numArray2517 = second;
      int num7365 = num7363;
      int num7366 = num7365 + 1;
      int index2507 = num7365;
      int num7367 = (int) numArray2335[this.ucScreenLED1.LEDC6 * 3 + 1];
      numArray2517[index2507] = (byte) num7367;
      byte[] numArray2518 = second;
      int num7368 = num7366;
      int num7369 = num7368 + 1;
      int index2508 = num7368;
      int num7370 = (int) numArray2335[this.ucScreenLED1.LEDC6 * 3 + 2];
      numArray2518[index2508] = (byte) num7370;
      byte[] numArray2519 = second;
      int num7371 = num7369;
      int num7372 = num7371 + 1;
      int index2509 = num7371;
      int num7373 = (int) numArray2335[this.ucScreenLED1.LEDD6 * 3];
      numArray2519[index2509] = (byte) num7373;
      byte[] numArray2520 = second;
      int num7374 = num7372;
      int num7375 = num7374 + 1;
      int index2510 = num7374;
      int num7376 = (int) numArray2335[this.ucScreenLED1.LEDD6 * 3 + 1];
      numArray2520[index2510] = (byte) num7376;
      byte[] numArray2521 = second;
      int num7377 = num7375;
      int num7378 = num7377 + 1;
      int index2511 = num7377;
      int num7379 = (int) numArray2335[this.ucScreenLED1.LEDD6 * 3 + 2];
      numArray2521[index2511] = (byte) num7379;
      byte[] numArray2522 = second;
      int num7380 = num7378;
      int num7381 = num7380 + 1;
      int index2512 = num7380;
      int num7382 = (int) numArray2335[this.ucScreenLED1.LEDE6 * 3];
      numArray2522[index2512] = (byte) num7382;
      byte[] numArray2523 = second;
      int num7383 = num7381;
      int num7384 = num7383 + 1;
      int index2513 = num7383;
      int num7385 = (int) numArray2335[this.ucScreenLED1.LEDE6 * 3 + 1];
      numArray2523[index2513] = (byte) num7385;
      byte[] numArray2524 = second;
      int num7386 = num7384;
      int num7387 = num7386 + 1;
      int index2514 = num7386;
      int num7388 = (int) numArray2335[this.ucScreenLED1.LEDE6 * 3 + 2];
      numArray2524[index2514] = (byte) num7388;
      byte[] numArray2525 = second;
      int num7389 = num7387;
      int num7390 = num7389 + 1;
      int index2515 = num7389;
      int num7391 = (int) numArray2335[this.ucScreenLED1.LEDG6 * 3];
      numArray2525[index2515] = (byte) num7391;
      byte[] numArray2526 = second;
      int num7392 = num7390;
      int num7393 = num7392 + 1;
      int index2516 = num7392;
      int num7394 = (int) numArray2335[this.ucScreenLED1.LEDG6 * 3 + 1];
      numArray2526[index2516] = (byte) num7394;
      byte[] numArray2527 = second;
      int num7395 = num7393;
      int num7396 = num7395 + 1;
      int index2517 = num7395;
      int num7397 = (int) numArray2335[this.ucScreenLED1.LEDG6 * 3 + 2];
      numArray2527[index2517] = (byte) num7397;
      byte[] numArray2528 = second;
      int num7398 = num7396;
      int num7399 = num7398 + 1;
      int index2518 = num7398;
      int num7400 = (int) numArray2335[this.ucScreenLED1.LEDB6 * 3];
      numArray2528[index2518] = (byte) num7400;
      byte[] numArray2529 = second;
      int num7401 = num7399;
      int num7402 = num7401 + 1;
      int index2519 = num7401;
      int num7403 = (int) numArray2335[this.ucScreenLED1.LEDB6 * 3 + 1];
      numArray2529[index2519] = (byte) num7403;
      byte[] numArray2530 = second;
      int num7404 = num7402;
      int num7405 = num7404 + 1;
      int index2520 = num7404;
      int num7406 = (int) numArray2335[this.ucScreenLED1.LEDB6 * 3 + 2];
      numArray2530[index2520] = (byte) num7406;
      byte[] numArray2531 = second;
      int num7407 = num7405;
      int num7408 = num7407 + 1;
      int index2521 = num7407;
      int num7409 = (int) numArray2335[this.ucScreenLED1.LEDA6 * 3];
      numArray2531[index2521] = (byte) num7409;
      byte[] numArray2532 = second;
      int num7410 = num7408;
      int num7411 = num7410 + 1;
      int index2522 = num7410;
      int num7412 = (int) numArray2335[this.ucScreenLED1.LEDA6 * 3 + 1];
      numArray2532[index2522] = (byte) num7412;
      byte[] numArray2533 = second;
      int num7413 = num7411;
      int num7414 = num7413 + 1;
      int index2523 = num7413;
      int num7415 = (int) numArray2335[this.ucScreenLED1.LEDA6 * 3 + 2];
      numArray2533[index2523] = (byte) num7415;
      byte[] numArray2534 = second;
      int num7416 = num7414;
      int num7417 = num7416 + 1;
      int index2524 = num7416;
      int num7418 = (int) numArray2335[this.ucScreenLED1.LEDF6 * 3];
      numArray2534[index2524] = (byte) num7418;
      byte[] numArray2535 = second;
      int num7419 = num7417;
      int num7420 = num7419 + 1;
      int index2525 = num7419;
      int num7421 = (int) numArray2335[this.ucScreenLED1.LEDF6 * 3 + 1];
      numArray2535[index2525] = (byte) num7421;
      byte[] numArray2536 = second;
      int num7422 = num7420;
      int num7423 = num7422 + 1;
      int index2526 = num7422;
      int num7424 = (int) numArray2335[this.ucScreenLED1.LEDF6 * 3 + 2];
      numArray2536[index2526] = (byte) num7424;
      byte[] numArray2537 = second;
      int num7425 = num7423;
      int num7426 = num7425 + 1;
      int index2527 = num7425;
      int num7427 = (int) numArray2335[this.ucScreenLED1.LEDC5 * 3];
      numArray2537[index2527] = (byte) num7427;
      byte[] numArray2538 = second;
      int num7428 = num7426;
      int num7429 = num7428 + 1;
      int index2528 = num7428;
      int num7430 = (int) numArray2335[this.ucScreenLED1.LEDC5 * 3 + 1];
      numArray2538[index2528] = (byte) num7430;
      byte[] numArray2539 = second;
      int num7431 = num7429;
      int num7432 = num7431 + 1;
      int index2529 = num7431;
      int num7433 = (int) numArray2335[this.ucScreenLED1.LEDC5 * 3 + 2];
      numArray2539[index2529] = (byte) num7433;
      byte[] numArray2540 = second;
      int num7434 = num7432;
      int num7435 = num7434 + 1;
      int index2530 = num7434;
      int num7436 = (int) numArray2335[this.ucScreenLED1.LEDD5 * 3];
      numArray2540[index2530] = (byte) num7436;
      byte[] numArray2541 = second;
      int num7437 = num7435;
      int num7438 = num7437 + 1;
      int index2531 = num7437;
      int num7439 = (int) numArray2335[this.ucScreenLED1.LEDD5 * 3 + 1];
      numArray2541[index2531] = (byte) num7439;
      byte[] numArray2542 = second;
      int num7440 = num7438;
      int num7441 = num7440 + 1;
      int index2532 = num7440;
      int num7442 = (int) numArray2335[this.ucScreenLED1.LEDD5 * 3 + 2];
      numArray2542[index2532] = (byte) num7442;
      byte[] numArray2543 = second;
      int num7443 = num7441;
      int num7444 = num7443 + 1;
      int index2533 = num7443;
      int num7445 = (int) numArray2335[this.ucScreenLED1.LEDE5 * 3];
      numArray2543[index2533] = (byte) num7445;
      byte[] numArray2544 = second;
      int num7446 = num7444;
      int num7447 = num7446 + 1;
      int index2534 = num7446;
      int num7448 = (int) numArray2335[this.ucScreenLED1.LEDE5 * 3 + 1];
      numArray2544[index2534] = (byte) num7448;
      byte[] numArray2545 = second;
      int num7449 = num7447;
      int num7450 = num7449 + 1;
      int index2535 = num7449;
      int num7451 = (int) numArray2335[this.ucScreenLED1.LEDE5 * 3 + 2];
      numArray2545[index2535] = (byte) num7451;
      byte[] numArray2546 = second;
      int num7452 = num7450;
      int num7453 = num7452 + 1;
      int index2536 = num7452;
      int num7454 = (int) numArray2335[this.ucScreenLED1.LEDG5 * 3];
      numArray2546[index2536] = (byte) num7454;
      byte[] numArray2547 = second;
      int num7455 = num7453;
      int num7456 = num7455 + 1;
      int index2537 = num7455;
      int num7457 = (int) numArray2335[this.ucScreenLED1.LEDG5 * 3 + 1];
      numArray2547[index2537] = (byte) num7457;
      byte[] numArray2548 = second;
      int num7458 = num7456;
      int num7459 = num7458 + 1;
      int index2538 = num7458;
      int num7460 = (int) numArray2335[this.ucScreenLED1.LEDG5 * 3 + 2];
      numArray2548[index2538] = (byte) num7460;
      byte[] numArray2549 = second;
      int num7461 = num7459;
      int num7462 = num7461 + 1;
      int index2539 = num7461;
      int num7463 = (int) numArray2335[this.ucScreenLED1.LEDB5 * 3];
      numArray2549[index2539] = (byte) num7463;
      byte[] numArray2550 = second;
      int num7464 = num7462;
      int num7465 = num7464 + 1;
      int index2540 = num7464;
      int num7466 = (int) numArray2335[this.ucScreenLED1.LEDB5 * 3 + 1];
      numArray2550[index2540] = (byte) num7466;
      byte[] numArray2551 = second;
      int num7467 = num7465;
      int num7468 = num7467 + 1;
      int index2541 = num7467;
      int num7469 = (int) numArray2335[this.ucScreenLED1.LEDB5 * 3 + 2];
      numArray2551[index2541] = (byte) num7469;
      byte[] numArray2552 = second;
      int num7470 = num7468;
      int num7471 = num7470 + 1;
      int index2542 = num7470;
      int num7472 = (int) numArray2335[this.ucScreenLED1.LEDA5 * 3];
      numArray2552[index2542] = (byte) num7472;
      byte[] numArray2553 = second;
      int num7473 = num7471;
      int num7474 = num7473 + 1;
      int index2543 = num7473;
      int num7475 = (int) numArray2335[this.ucScreenLED1.LEDA5 * 3 + 1];
      numArray2553[index2543] = (byte) num7475;
      byte[] numArray2554 = second;
      int num7476 = num7474;
      int num7477 = num7476 + 1;
      int index2544 = num7476;
      int num7478 = (int) numArray2335[this.ucScreenLED1.LEDA5 * 3 + 2];
      numArray2554[index2544] = (byte) num7478;
      byte[] numArray2555 = second;
      int num7479 = num7477;
      int num7480 = num7479 + 1;
      int index2545 = num7479;
      int num7481 = (int) numArray2335[this.ucScreenLED1.LEDF5 * 3];
      numArray2555[index2545] = (byte) num7481;
      byte[] numArray2556 = second;
      int num7482 = num7480;
      int num7483 = num7482 + 1;
      int index2546 = num7482;
      int num7484 = (int) numArray2335[this.ucScreenLED1.LEDF5 * 3 + 1];
      numArray2556[index2546] = (byte) num7484;
      byte[] numArray2557 = second;
      int num7485 = num7483;
      int num7486 = num7485 + 1;
      int index2547 = num7485;
      int num7487 = (int) numArray2335[this.ucScreenLED1.LEDF5 * 3 + 2];
      numArray2557[index2547] = (byte) num7487;
      byte[] numArray2558 = second;
      int num7488 = num7486;
      int num7489 = num7488 + 1;
      int index2548 = num7488;
      int num7490 = (int) numArray2335[this.ucScreenLED1.LEDC4 * 3];
      numArray2558[index2548] = (byte) num7490;
      byte[] numArray2559 = second;
      int num7491 = num7489;
      int num7492 = num7491 + 1;
      int index2549 = num7491;
      int num7493 = (int) numArray2335[this.ucScreenLED1.LEDC4 * 3 + 1];
      numArray2559[index2549] = (byte) num7493;
      byte[] numArray2560 = second;
      int num7494 = num7492;
      int num7495 = num7494 + 1;
      int index2550 = num7494;
      int num7496 = (int) numArray2335[this.ucScreenLED1.LEDC4 * 3 + 2];
      numArray2560[index2550] = (byte) num7496;
      byte[] numArray2561 = second;
      int num7497 = num7495;
      int num7498 = num7497 + 1;
      int index2551 = num7497;
      int num7499 = (int) numArray2335[this.ucScreenLED1.LEDD4 * 3];
      numArray2561[index2551] = (byte) num7499;
      byte[] numArray2562 = second;
      int num7500 = num7498;
      int num7501 = num7500 + 1;
      int index2552 = num7500;
      int num7502 = (int) numArray2335[this.ucScreenLED1.LEDD4 * 3 + 1];
      numArray2562[index2552] = (byte) num7502;
      byte[] numArray2563 = second;
      int num7503 = num7501;
      int num7504 = num7503 + 1;
      int index2553 = num7503;
      int num7505 = (int) numArray2335[this.ucScreenLED1.LEDD4 * 3 + 2];
      numArray2563[index2553] = (byte) num7505;
      byte[] numArray2564 = second;
      int num7506 = num7504;
      int num7507 = num7506 + 1;
      int index2554 = num7506;
      int num7508 = (int) numArray2335[this.ucScreenLED1.LEDE4 * 3];
      numArray2564[index2554] = (byte) num7508;
      byte[] numArray2565 = second;
      int num7509 = num7507;
      int num7510 = num7509 + 1;
      int index2555 = num7509;
      int num7511 = (int) numArray2335[this.ucScreenLED1.LEDE4 * 3 + 1];
      numArray2565[index2555] = (byte) num7511;
      byte[] numArray2566 = second;
      int num7512 = num7510;
      int num7513 = num7512 + 1;
      int index2556 = num7512;
      int num7514 = (int) numArray2335[this.ucScreenLED1.LEDE4 * 3 + 2];
      numArray2566[index2556] = (byte) num7514;
      byte[] numArray2567 = second;
      int num7515 = num7513;
      int num7516 = num7515 + 1;
      int index2557 = num7515;
      int num7517 = (int) numArray2335[this.ucScreenLED1.LEDG4 * 3];
      numArray2567[index2557] = (byte) num7517;
      byte[] numArray2568 = second;
      int num7518 = num7516;
      int num7519 = num7518 + 1;
      int index2558 = num7518;
      int num7520 = (int) numArray2335[this.ucScreenLED1.LEDG4 * 3 + 1];
      numArray2568[index2558] = (byte) num7520;
      byte[] numArray2569 = second;
      int num7521 = num7519;
      int num7522 = num7521 + 1;
      int index2559 = num7521;
      int num7523 = (int) numArray2335[this.ucScreenLED1.LEDG4 * 3 + 2];
      numArray2569[index2559] = (byte) num7523;
      byte[] numArray2570 = second;
      int num7524 = num7522;
      int num7525 = num7524 + 1;
      int index2560 = num7524;
      int num7526 = (int) numArray2335[this.ucScreenLED1.LEDB4 * 3];
      numArray2570[index2560] = (byte) num7526;
      byte[] numArray2571 = second;
      int num7527 = num7525;
      int num7528 = num7527 + 1;
      int index2561 = num7527;
      int num7529 = (int) numArray2335[this.ucScreenLED1.LEDB4 * 3 + 1];
      numArray2571[index2561] = (byte) num7529;
      byte[] numArray2572 = second;
      int num7530 = num7528;
      int num7531 = num7530 + 1;
      int index2562 = num7530;
      int num7532 = (int) numArray2335[this.ucScreenLED1.LEDB4 * 3 + 2];
      numArray2572[index2562] = (byte) num7532;
      byte[] numArray2573 = second;
      int num7533 = num7531;
      int num7534 = num7533 + 1;
      int index2563 = num7533;
      int num7535 = (int) numArray2335[this.ucScreenLED1.LEDA4 * 3];
      numArray2573[index2563] = (byte) num7535;
      byte[] numArray2574 = second;
      int num7536 = num7534;
      int num7537 = num7536 + 1;
      int index2564 = num7536;
      int num7538 = (int) numArray2335[this.ucScreenLED1.LEDA4 * 3 + 1];
      numArray2574[index2564] = (byte) num7538;
      byte[] numArray2575 = second;
      int num7539 = num7537;
      int num7540 = num7539 + 1;
      int index2565 = num7539;
      int num7541 = (int) numArray2335[this.ucScreenLED1.LEDA4 * 3 + 2];
      numArray2575[index2565] = (byte) num7541;
      byte[] numArray2576 = second;
      int num7542 = num7540;
      int num7543 = num7542 + 1;
      int index2566 = num7542;
      int num7544 = (int) numArray2335[this.ucScreenLED1.LEDF4 * 3];
      numArray2576[index2566] = (byte) num7544;
      byte[] numArray2577 = second;
      int num7545 = num7543;
      int num7546 = num7545 + 1;
      int index2567 = num7545;
      int num7547 = (int) numArray2335[this.ucScreenLED1.LEDF4 * 3 + 1];
      numArray2577[index2567] = (byte) num7547;
      byte[] numArray2578 = second;
      int num7548 = num7546;
      int num7549 = num7548 + 1;
      int index2568 = num7548;
      int num7550 = (int) numArray2335[this.ucScreenLED1.LEDF4 * 3 + 2];
      numArray2578[index2568] = (byte) num7550;
      byte[] numArray2579 = second;
      int num7551 = num7549;
      int num7552 = num7551 + 1;
      int index2569 = num7551;
      int num7553 = (int) numArray2335[this.ucScreenLED1.SSD * 3];
      numArray2579[index2569] = (byte) num7553;
      byte[] numArray2580 = second;
      int num7554 = num7552;
      int num7555 = num7554 + 1;
      int index2570 = num7554;
      int num7556 = (int) numArray2335[this.ucScreenLED1.SSD * 3 + 1];
      numArray2580[index2570] = (byte) num7556;
      byte[] numArray2581 = second;
      int num7557 = num7555;
      int num7558 = num7557 + 1;
      int index2571 = num7557;
      int num7559 = (int) numArray2335[this.ucScreenLED1.SSD * 3 + 2];
      numArray2581[index2571] = (byte) num7559;
      byte[] numArray2582 = second;
      int num7560 = num7558;
      int num7561 = num7560 + 1;
      int index2572 = num7560;
      int num7562 = (int) numArray2335[this.ucScreenLED1.HSD * 3];
      numArray2582[index2572] = (byte) num7562;
      byte[] numArray2583 = second;
      int num7563 = num7561;
      int num7564 = num7563 + 1;
      int index2573 = num7563;
      int num7565 = (int) numArray2335[this.ucScreenLED1.HSD * 3 + 1];
      numArray2583[index2573] = (byte) num7565;
      byte[] numArray2584 = second;
      int num7566 = num7564;
      int num7567 = num7566 + 1;
      int index2574 = num7566;
      int num7568 = (int) numArray2335[this.ucScreenLED1.HSD * 3 + 2];
      numArray2584[index2574] = (byte) num7568;
      byte[] numArray2585 = second;
      int num7569 = num7567;
      int num7570 = num7569 + 1;
      int index2575 = num7569;
      int num7571 = (int) numArray2335[this.ucScreenLED1.LEDC3 * 3];
      numArray2585[index2575] = (byte) num7571;
      byte[] numArray2586 = second;
      int num7572 = num7570;
      int num7573 = num7572 + 1;
      int index2576 = num7572;
      int num7574 = (int) numArray2335[this.ucScreenLED1.LEDC3 * 3 + 1];
      numArray2586[index2576] = (byte) num7574;
      byte[] numArray2587 = second;
      int num7575 = num7573;
      int num7576 = num7575 + 1;
      int index2577 = num7575;
      int num7577 = (int) numArray2335[this.ucScreenLED1.LEDC3 * 3 + 2];
      numArray2587[index2577] = (byte) num7577;
      byte[] numArray2588 = second;
      int num7578 = num7576;
      int num7579 = num7578 + 1;
      int index2578 = num7578;
      int num7580 = (int) numArray2335[this.ucScreenLED1.LEDD3 * 3];
      numArray2588[index2578] = (byte) num7580;
      byte[] numArray2589 = second;
      int num7581 = num7579;
      int num7582 = num7581 + 1;
      int index2579 = num7581;
      int num7583 = (int) numArray2335[this.ucScreenLED1.LEDD3 * 3 + 1];
      numArray2589[index2579] = (byte) num7583;
      byte[] numArray2590 = second;
      int num7584 = num7582;
      int num7585 = num7584 + 1;
      int index2580 = num7584;
      int num7586 = (int) numArray2335[this.ucScreenLED1.LEDD3 * 3 + 2];
      numArray2590[index2580] = (byte) num7586;
      byte[] numArray2591 = second;
      int num7587 = num7585;
      int num7588 = num7587 + 1;
      int index2581 = num7587;
      int num7589 = (int) numArray2335[this.ucScreenLED1.LEDE3 * 3];
      numArray2591[index2581] = (byte) num7589;
      byte[] numArray2592 = second;
      int num7590 = num7588;
      int num7591 = num7590 + 1;
      int index2582 = num7590;
      int num7592 = (int) numArray2335[this.ucScreenLED1.LEDE3 * 3 + 1];
      numArray2592[index2582] = (byte) num7592;
      byte[] numArray2593 = second;
      int num7593 = num7591;
      int num7594 = num7593 + 1;
      int index2583 = num7593;
      int num7595 = (int) numArray2335[this.ucScreenLED1.LEDE3 * 3 + 2];
      numArray2593[index2583] = (byte) num7595;
      byte[] numArray2594 = second;
      int num7596 = num7594;
      int num7597 = num7596 + 1;
      int index2584 = num7596;
      int num7598 = (int) numArray2335[this.ucScreenLED1.LEDG3 * 3];
      numArray2594[index2584] = (byte) num7598;
      byte[] numArray2595 = second;
      int num7599 = num7597;
      int num7600 = num7599 + 1;
      int index2585 = num7599;
      int num7601 = (int) numArray2335[this.ucScreenLED1.LEDG3 * 3 + 1];
      numArray2595[index2585] = (byte) num7601;
      byte[] numArray2596 = second;
      int num7602 = num7600;
      int num7603 = num7602 + 1;
      int index2586 = num7602;
      int num7604 = (int) numArray2335[this.ucScreenLED1.LEDG3 * 3 + 2];
      numArray2596[index2586] = (byte) num7604;
      byte[] numArray2597 = second;
      int num7605 = num7603;
      int num7606 = num7605 + 1;
      int index2587 = num7605;
      int num7607 = (int) numArray2335[this.ucScreenLED1.LEDB3 * 3];
      numArray2597[index2587] = (byte) num7607;
      byte[] numArray2598 = second;
      int num7608 = num7606;
      int num7609 = num7608 + 1;
      int index2588 = num7608;
      int num7610 = (int) numArray2335[this.ucScreenLED1.LEDB3 * 3 + 1];
      numArray2598[index2588] = (byte) num7610;
      byte[] numArray2599 = second;
      int num7611 = num7609;
      int num7612 = num7611 + 1;
      int index2589 = num7611;
      int num7613 = (int) numArray2335[this.ucScreenLED1.LEDB3 * 3 + 2];
      numArray2599[index2589] = (byte) num7613;
      byte[] numArray2600 = second;
      int num7614 = num7612;
      int num7615 = num7614 + 1;
      int index2590 = num7614;
      int num7616 = (int) numArray2335[this.ucScreenLED1.LEDA3 * 3];
      numArray2600[index2590] = (byte) num7616;
      byte[] numArray2601 = second;
      int num7617 = num7615;
      int num7618 = num7617 + 1;
      int index2591 = num7617;
      int num7619 = (int) numArray2335[this.ucScreenLED1.LEDA3 * 3 + 1];
      numArray2601[index2591] = (byte) num7619;
      byte[] numArray2602 = second;
      int num7620 = num7618;
      int num7621 = num7620 + 1;
      int index2592 = num7620;
      int num7622 = (int) numArray2335[this.ucScreenLED1.LEDA3 * 3 + 2];
      numArray2602[index2592] = (byte) num7622;
      byte[] numArray2603 = second;
      int num7623 = num7621;
      int num7624 = num7623 + 1;
      int index2593 = num7623;
      int num7625 = (int) numArray2335[this.ucScreenLED1.LEDF3 * 3];
      numArray2603[index2593] = (byte) num7625;
      byte[] numArray2604 = second;
      int num7626 = num7624;
      int num7627 = num7626 + 1;
      int index2594 = num7626;
      int num7628 = (int) numArray2335[this.ucScreenLED1.LEDF3 * 3 + 1];
      numArray2604[index2594] = (byte) num7628;
      byte[] numArray2605 = second;
      int num7629 = num7627;
      int num7630 = num7629 + 1;
      int index2595 = num7629;
      int num7631 = (int) numArray2335[this.ucScreenLED1.LEDF3 * 3 + 2];
      numArray2605[index2595] = (byte) num7631;
      byte[] numArray2606 = second;
      int num7632 = num7630;
      int num7633 = num7632 + 1;
      int index2596 = num7632;
      int num7634 = (int) numArray2335[this.ucScreenLED1.LEDC2 * 3];
      numArray2606[index2596] = (byte) num7634;
      byte[] numArray2607 = second;
      int num7635 = num7633;
      int num7636 = num7635 + 1;
      int index2597 = num7635;
      int num7637 = (int) numArray2335[this.ucScreenLED1.LEDC2 * 3 + 1];
      numArray2607[index2597] = (byte) num7637;
      byte[] numArray2608 = second;
      int num7638 = num7636;
      int num7639 = num7638 + 1;
      int index2598 = num7638;
      int num7640 = (int) numArray2335[this.ucScreenLED1.LEDC2 * 3 + 2];
      numArray2608[index2598] = (byte) num7640;
      byte[] numArray2609 = second;
      int num7641 = num7639;
      int num7642 = num7641 + 1;
      int index2599 = num7641;
      int num7643 = (int) numArray2335[this.ucScreenLED1.LEDD2 * 3];
      numArray2609[index2599] = (byte) num7643;
      byte[] numArray2610 = second;
      int num7644 = num7642;
      int num7645 = num7644 + 1;
      int index2600 = num7644;
      int num7646 = (int) numArray2335[this.ucScreenLED1.LEDD2 * 3 + 1];
      numArray2610[index2600] = (byte) num7646;
      byte[] numArray2611 = second;
      int num7647 = num7645;
      int num7648 = num7647 + 1;
      int index2601 = num7647;
      int num7649 = (int) numArray2335[this.ucScreenLED1.LEDD2 * 3 + 2];
      numArray2611[index2601] = (byte) num7649;
      byte[] numArray2612 = second;
      int num7650 = num7648;
      int num7651 = num7650 + 1;
      int index2602 = num7650;
      int num7652 = (int) numArray2335[this.ucScreenLED1.LEDE2 * 3];
      numArray2612[index2602] = (byte) num7652;
      byte[] numArray2613 = second;
      int num7653 = num7651;
      int num7654 = num7653 + 1;
      int index2603 = num7653;
      int num7655 = (int) numArray2335[this.ucScreenLED1.LEDE2 * 3 + 1];
      numArray2613[index2603] = (byte) num7655;
      byte[] numArray2614 = second;
      int num7656 = num7654;
      int num7657 = num7656 + 1;
      int index2604 = num7656;
      int num7658 = (int) numArray2335[this.ucScreenLED1.LEDE2 * 3 + 2];
      numArray2614[index2604] = (byte) num7658;
      byte[] numArray2615 = second;
      int num7659 = num7657;
      int num7660 = num7659 + 1;
      int index2605 = num7659;
      int num7661 = (int) numArray2335[this.ucScreenLED1.LEDG2 * 3];
      numArray2615[index2605] = (byte) num7661;
      byte[] numArray2616 = second;
      int num7662 = num7660;
      int num7663 = num7662 + 1;
      int index2606 = num7662;
      int num7664 = (int) numArray2335[this.ucScreenLED1.LEDG2 * 3 + 1];
      numArray2616[index2606] = (byte) num7664;
      byte[] numArray2617 = second;
      int num7665 = num7663;
      int num7666 = num7665 + 1;
      int index2607 = num7665;
      int num7667 = (int) numArray2335[this.ucScreenLED1.LEDG2 * 3 + 2];
      numArray2617[index2607] = (byte) num7667;
      byte[] numArray2618 = second;
      int num7668 = num7666;
      int num7669 = num7668 + 1;
      int index2608 = num7668;
      int num7670 = (int) numArray2335[this.ucScreenLED1.LEDB2 * 3];
      numArray2618[index2608] = (byte) num7670;
      byte[] numArray2619 = second;
      int num7671 = num7669;
      int num7672 = num7671 + 1;
      int index2609 = num7671;
      int num7673 = (int) numArray2335[this.ucScreenLED1.LEDB2 * 3 + 1];
      numArray2619[index2609] = (byte) num7673;
      byte[] numArray2620 = second;
      int num7674 = num7672;
      int num7675 = num7674 + 1;
      int index2610 = num7674;
      int num7676 = (int) numArray2335[this.ucScreenLED1.LEDB2 * 3 + 2];
      numArray2620[index2610] = (byte) num7676;
      byte[] numArray2621 = second;
      int num7677 = num7675;
      int num7678 = num7677 + 1;
      int index2611 = num7677;
      int num7679 = (int) numArray2335[this.ucScreenLED1.LEDA2 * 3];
      numArray2621[index2611] = (byte) num7679;
      byte[] numArray2622 = second;
      int num7680 = num7678;
      int num7681 = num7680 + 1;
      int index2612 = num7680;
      int num7682 = (int) numArray2335[this.ucScreenLED1.LEDA2 * 3 + 1];
      numArray2622[index2612] = (byte) num7682;
      byte[] numArray2623 = second;
      int num7683 = num7681;
      int num7684 = num7683 + 1;
      int index2613 = num7683;
      int num7685 = (int) numArray2335[this.ucScreenLED1.LEDA2 * 3 + 2];
      numArray2623[index2613] = (byte) num7685;
      byte[] numArray2624 = second;
      int num7686 = num7684;
      int num7687 = num7686 + 1;
      int index2614 = num7686;
      int num7688 = (int) numArray2335[this.ucScreenLED1.LEDF2 * 3];
      numArray2624[index2614] = (byte) num7688;
      byte[] numArray2625 = second;
      int num7689 = num7687;
      int num7690 = num7689 + 1;
      int index2615 = num7689;
      int num7691 = (int) numArray2335[this.ucScreenLED1.LEDF2 * 3 + 1];
      numArray2625[index2615] = (byte) num7691;
      byte[] numArray2626 = second;
      int num7692 = num7690;
      int num7693 = num7692 + 1;
      int index2616 = num7692;
      int num7694 = (int) numArray2335[this.ucScreenLED1.LEDF2 * 3 + 2];
      numArray2626[index2616] = (byte) num7694;
      byte[] numArray2627 = second;
      int num7695 = num7693;
      int num7696 = num7695 + 1;
      int index2617 = num7695;
      int num7697 = (int) numArray2335[this.ucScreenLED1.LEDC1 * 3];
      numArray2627[index2617] = (byte) num7697;
      byte[] numArray2628 = second;
      int num7698 = num7696;
      int num7699 = num7698 + 1;
      int index2618 = num7698;
      int num7700 = (int) numArray2335[this.ucScreenLED1.LEDC1 * 3 + 1];
      numArray2628[index2618] = (byte) num7700;
      byte[] numArray2629 = second;
      int num7701 = num7699;
      int num7702 = num7701 + 1;
      int index2619 = num7701;
      int num7703 = (int) numArray2335[this.ucScreenLED1.LEDC1 * 3 + 2];
      numArray2629[index2619] = (byte) num7703;
      byte[] numArray2630 = second;
      int num7704 = num7702;
      int num7705 = num7704 + 1;
      int index2620 = num7704;
      int num7706 = (int) numArray2335[this.ucScreenLED1.LEDD1 * 3];
      numArray2630[index2620] = (byte) num7706;
      byte[] numArray2631 = second;
      int num7707 = num7705;
      int num7708 = num7707 + 1;
      int index2621 = num7707;
      int num7709 = (int) numArray2335[this.ucScreenLED1.LEDD1 * 3 + 1];
      numArray2631[index2621] = (byte) num7709;
      byte[] numArray2632 = second;
      int num7710 = num7708;
      int num7711 = num7710 + 1;
      int index2622 = num7710;
      int num7712 = (int) numArray2335[this.ucScreenLED1.LEDD1 * 3 + 2];
      numArray2632[index2622] = (byte) num7712;
      byte[] numArray2633 = second;
      int num7713 = num7711;
      int num7714 = num7713 + 1;
      int index2623 = num7713;
      int num7715 = (int) numArray2335[this.ucScreenLED1.LEDE1 * 3];
      numArray2633[index2623] = (byte) num7715;
      byte[] numArray2634 = second;
      int num7716 = num7714;
      int num7717 = num7716 + 1;
      int index2624 = num7716;
      int num7718 = (int) numArray2335[this.ucScreenLED1.LEDE1 * 3 + 1];
      numArray2634[index2624] = (byte) num7718;
      byte[] numArray2635 = second;
      int num7719 = num7717;
      int num7720 = num7719 + 1;
      int index2625 = num7719;
      int num7721 = (int) numArray2335[this.ucScreenLED1.LEDE1 * 3 + 2];
      numArray2635[index2625] = (byte) num7721;
      byte[] numArray2636 = second;
      int num7722 = num7720;
      int num7723 = num7722 + 1;
      int index2626 = num7722;
      int num7724 = (int) numArray2335[this.ucScreenLED1.LEDG1 * 3];
      numArray2636[index2626] = (byte) num7724;
      byte[] numArray2637 = second;
      int num7725 = num7723;
      int num7726 = num7725 + 1;
      int index2627 = num7725;
      int num7727 = (int) numArray2335[this.ucScreenLED1.LEDG1 * 3 + 1];
      numArray2637[index2627] = (byte) num7727;
      byte[] numArray2638 = second;
      int num7728 = num7726;
      int num7729 = num7728 + 1;
      int index2628 = num7728;
      int num7730 = (int) numArray2335[this.ucScreenLED1.LEDG1 * 3 + 2];
      numArray2638[index2628] = (byte) num7730;
      byte[] numArray2639 = second;
      int num7731 = num7729;
      int num7732 = num7731 + 1;
      int index2629 = num7731;
      int num7733 = (int) numArray2335[this.ucScreenLED1.LEDB1 * 3];
      numArray2639[index2629] = (byte) num7733;
      byte[] numArray2640 = second;
      int num7734 = num7732;
      int num7735 = num7734 + 1;
      int index2630 = num7734;
      int num7736 = (int) numArray2335[this.ucScreenLED1.LEDB1 * 3 + 1];
      numArray2640[index2630] = (byte) num7736;
      byte[] numArray2641 = second;
      int num7737 = num7735;
      int num7738 = num7737 + 1;
      int index2631 = num7737;
      int num7739 = (int) numArray2335[this.ucScreenLED1.LEDB1 * 3 + 2];
      numArray2641[index2631] = (byte) num7739;
      byte[] numArray2642 = second;
      int num7740 = num7738;
      int num7741 = num7740 + 1;
      int index2632 = num7740;
      int num7742 = (int) numArray2335[this.ucScreenLED1.LEDA1 * 3];
      numArray2642[index2632] = (byte) num7742;
      byte[] numArray2643 = second;
      int num7743 = num7741;
      int num7744 = num7743 + 1;
      int index2633 = num7743;
      int num7745 = (int) numArray2335[this.ucScreenLED1.LEDA1 * 3 + 1];
      numArray2643[index2633] = (byte) num7745;
      byte[] numArray2644 = second;
      int num7746 = num7744;
      int num7747 = num7746 + 1;
      int index2634 = num7746;
      int num7748 = (int) numArray2335[this.ucScreenLED1.LEDA1 * 3 + 2];
      numArray2644[index2634] = (byte) num7748;
      byte[] numArray2645 = second;
      int num7749 = num7747;
      int num7750 = num7749 + 1;
      int index2635 = num7749;
      int num7751 = (int) numArray2335[this.ucScreenLED1.LEDF1 * 3];
      numArray2645[index2635] = (byte) num7751;
      byte[] numArray2646 = second;
      int num7752 = num7750;
      int num7753 = num7752 + 1;
      int index2636 = num7752;
      int num7754 = (int) numArray2335[this.ucScreenLED1.LEDF1 * 3 + 1];
      numArray2646[index2636] = (byte) num7754;
      byte[] numArray2647 = second;
      int num7755 = num7753;
      int num7756 = num7755 + 1;
      int index2637 = num7755;
      int num7757 = (int) numArray2335[this.ucScreenLED1.LEDF1 * 3 + 2];
      numArray2647[index2637] = (byte) num7757;
      byte[] numArray2648 = second;
      int num7758 = num7756;
      int num7759 = num7758 + 1;
      int index2638 = num7758;
      int num7760 = (int) numArray2335[this.ucScreenLED1.Gpu1 * 3];
      numArray2648[index2638] = (byte) num7760;
      byte[] numArray2649 = second;
      int num7761 = num7759;
      int num7762 = num7761 + 1;
      int index2639 = num7761;
      int num7763 = (int) numArray2335[this.ucScreenLED1.Gpu1 * 3 + 1];
      numArray2649[index2639] = (byte) num7763;
      byte[] numArray2650 = second;
      int num7764 = num7762;
      int num7765 = num7764 + 1;
      int index2640 = num7764;
      int num7766 = (int) numArray2335[this.ucScreenLED1.Gpu1 * 3 + 2];
      numArray2650[index2640] = (byte) num7766;
      byte[] numArray2651 = second;
      int num7767 = num7765;
      int num7768 = num7767 + 1;
      int index2641 = num7767;
      int num7769 = (int) numArray2335[this.ucScreenLED1.Cpu1 * 3];
      numArray2651[index2641] = (byte) num7769;
      byte[] numArray2652 = second;
      int num7770 = num7768;
      int num7771 = num7770 + 1;
      int index2642 = num7770;
      int num7772 = (int) numArray2335[this.ucScreenLED1.Cpu1 * 3 + 1];
      numArray2652[index2642] = (byte) num7772;
      byte[] numArray2653 = second;
      int num7773 = num7771;
      int num7774 = num7773 + 1;
      int index2643 = num7773;
      int num7775 = (int) numArray2335[this.ucScreenLED1.Cpu1 * 3 + 2];
      numArray2653[index2643] = (byte) num7775;
      byte[] numArray2654 = second;
      int num7776 = num7774;
      int num7777 = num7776 + 1;
      int index2644 = num7776;
      int num7778 = (int) numArray2335[this.ucScreenLED1.Cpu1 * 3];
      numArray2654[index2644] = (byte) num7778;
      byte[] numArray2655 = second;
      int num7779 = num7777;
      int num7780 = num7779 + 1;
      int index2645 = num7779;
      int num7781 = (int) numArray2335[this.ucScreenLED1.Cpu1 * 3 + 1];
      numArray2655[index2645] = (byte) num7781;
      byte[] numArray2656 = second;
      int num7782 = num7780;
      int num7783 = num7782 + 1;
      int index2646 = num7782;
      int num7784 = (int) numArray2335[this.ucScreenLED1.Cpu1 * 3 + 2];
      numArray2656[index2646] = (byte) num7784;
      byte[] numArray2657 = second;
      int num7785 = num7783;
      int num7786 = num7785 + 1;
      int index2647 = num7785;
      int num7787 = (int) numArray2335[this.ucScreenLED1.Gpu1 * 3];
      numArray2657[index2647] = (byte) num7787;
      byte[] numArray2658 = second;
      int num7788 = num7786;
      int num7789 = num7788 + 1;
      int index2648 = num7788;
      int num7790 = (int) numArray2335[this.ucScreenLED1.Gpu1 * 3 + 1];
      numArray2658[index2648] = (byte) num7790;
      byte[] numArray2659 = second;
      int num7791 = num7789;
      int num7792 = num7791 + 1;
      int index2649 = num7791;
      int num7793 = (int) numArray2335[this.ucScreenLED1.Gpu1 * 3 + 2];
      numArray2659[index2649] = (byte) num7793;
      byte[] numArray2660 = second;
      int num7794 = num7792;
      int num7795 = num7794 + 1;
      int index2650 = num7794;
      int num7796 = (int) (byte) ((double) this.ledValLF15[8, 0] * (double) num7244 * (double) num2);
      numArray2660[index2650] = (byte) num7796;
      byte[] numArray2661 = second;
      int num7797 = num7795;
      int num7798 = num7797 + 1;
      int index2651 = num7797;
      int num7799 = (int) (byte) ((double) this.ledValLF15[8, 1] * (double) num7244 * (double) num2);
      numArray2661[index2651] = (byte) num7799;
      byte[] numArray2662 = second;
      int num7800 = num7798;
      int num7801 = num7800 + 1;
      int index2652 = num7800;
      int num7802 = (int) (byte) ((double) this.ledValLF15[8, 2] * (double) num7244 * (double) num2);
      numArray2662[index2652] = (byte) num7802;
      byte[] numArray2663 = second;
      int num7803 = num7801;
      int num7804 = num7803 + 1;
      int index2653 = num7803;
      int num7805 = (int) (byte) ((double) this.ledValLF15[8, 0] * (double) num7244 * (double) num2);
      numArray2663[index2653] = (byte) num7805;
      byte[] numArray2664 = second;
      int num7806 = num7804;
      int num7807 = num7806 + 1;
      int index2654 = num7806;
      int num7808 = (int) (byte) ((double) this.ledValLF15[8, 1] * (double) num7244 * (double) num2);
      numArray2664[index2654] = (byte) num7808;
      byte[] numArray2665 = second;
      int num7809 = num7807;
      int num7810 = num7809 + 1;
      int index2655 = num7809;
      int num7811 = (int) (byte) ((double) this.ledValLF15[8, 2] * (double) num7244 * (double) num2);
      numArray2665[index2655] = (byte) num7811;
      byte[] numArray2666 = second;
      int num7812 = num7810;
      int num7813 = num7812 + 1;
      int index2656 = num7812;
      int num7814 = (int) (byte) ((double) this.ledValLF15[9, 0] * (double) num7244 * (double) num2);
      numArray2666[index2656] = (byte) num7814;
      byte[] numArray2667 = second;
      int num7815 = num7813;
      int num7816 = num7815 + 1;
      int index2657 = num7815;
      int num7817 = (int) (byte) ((double) this.ledValLF15[9, 1] * (double) num7244 * (double) num2);
      numArray2667[index2657] = (byte) num7817;
      byte[] numArray2668 = second;
      int num7818 = num7816;
      int num7819 = num7818 + 1;
      int index2658 = num7818;
      int num7820 = (int) (byte) ((double) this.ledValLF15[9, 2] * (double) num7244 * (double) num2);
      numArray2668[index2658] = (byte) num7820;
      byte[] numArray2669 = second;
      int num7821 = num7819;
      int num7822 = num7821 + 1;
      int index2659 = num7821;
      int num7823 = (int) (byte) ((double) this.ledValLF15[9, 0] * (double) num7244 * (double) num2);
      numArray2669[index2659] = (byte) num7823;
      byte[] numArray2670 = second;
      int num7824 = num7822;
      int num7825 = num7824 + 1;
      int index2660 = num7824;
      int num7826 = (int) (byte) ((double) this.ledValLF15[9, 1] * (double) num7244 * (double) num2);
      numArray2670[index2660] = (byte) num7826;
      byte[] numArray2671 = second;
      int num7827 = num7825;
      int num7828 = num7827 + 1;
      int index2661 = num7827;
      int num7829 = (int) (byte) ((double) this.ledValLF15[9, 2] * (double) num7244 * (double) num2);
      numArray2671[index2661] = (byte) num7829;
      byte[] numArray2672 = second;
      int num7830 = num7828;
      int num7831 = num7830 + 1;
      int index2662 = num7830;
      int num7832 = (int) (byte) ((double) this.ledValLF15[9, 0] * (double) num7244 * (double) num2);
      numArray2672[index2662] = (byte) num7832;
      byte[] numArray2673 = second;
      int num7833 = num7831;
      int num7834 = num7833 + 1;
      int index2663 = num7833;
      int num7835 = (int) (byte) ((double) this.ledValLF15[9, 1] * (double) num7244 * (double) num2);
      numArray2673[index2663] = (byte) num7835;
      byte[] numArray2674 = second;
      int num7836 = num7834;
      int num7837 = num7836 + 1;
      int index2664 = num7836;
      int num7838 = (int) (byte) ((double) this.ledValLF15[9, 2] * (double) num7244 * (double) num2);
      numArray2674[index2664] = (byte) num7838;
      byte[] numArray2675 = second;
      int num7839 = num7837;
      int num7840 = num7839 + 1;
      int index2665 = num7839;
      int num7841 = (int) (byte) ((double) this.ledValLF15[8, 0] * (double) num7244 * (double) num2);
      numArray2675[index2665] = (byte) num7841;
      byte[] numArray2676 = second;
      int num7842 = num7840;
      int num7843 = num7842 + 1;
      int index2666 = num7842;
      int num7844 = (int) (byte) ((double) this.ledValLF15[8, 1] * (double) num7244 * (double) num2);
      numArray2676[index2666] = (byte) num7844;
      byte[] numArray2677 = second;
      int num7845 = num7843;
      int num7846 = num7845 + 1;
      int index2667 = num7845;
      int num7847 = (int) (byte) ((double) this.ledValLF15[8, 2] * (double) num7244 * (double) num2);
      numArray2677[index2667] = (byte) num7847;
      byte[] numArray2678 = second;
      int num7848 = num7846;
      int num7849 = num7848 + 1;
      int index2668 = num7848;
      int num7850 = (int) (byte) ((double) this.ledValLF15[7, 0] * (double) num7244 * (double) num2);
      numArray2678[index2668] = (byte) num7850;
      byte[] numArray2679 = second;
      int num7851 = num7849;
      int num7852 = num7851 + 1;
      int index2669 = num7851;
      int num7853 = (int) (byte) ((double) this.ledValLF15[7, 1] * (double) num7244 * (double) num2);
      numArray2679[index2669] = (byte) num7853;
      byte[] numArray2680 = second;
      int num7854 = num7852;
      int num7855 = num7854 + 1;
      int index2670 = num7854;
      int num7856 = (int) (byte) ((double) this.ledValLF15[7, 2] * (double) num7244 * (double) num2);
      numArray2680[index2670] = (byte) num7856;
      byte[] numArray2681 = second;
      int num7857 = num7855;
      int num7858 = num7857 + 1;
      int index2671 = num7857;
      int num7859 = (int) (byte) ((double) this.ledValLF15[6, 0] * (double) num7244 * (double) num2);
      numArray2681[index2671] = (byte) num7859;
      byte[] numArray2682 = second;
      int num7860 = num7858;
      int num7861 = num7860 + 1;
      int index2672 = num7860;
      int num7862 = (int) (byte) ((double) this.ledValLF15[6, 1] * (double) num7244 * (double) num2);
      numArray2682[index2672] = (byte) num7862;
      byte[] numArray2683 = second;
      int num7863 = num7861;
      int num7864 = num7863 + 1;
      int index2673 = num7863;
      int num7865 = (int) (byte) ((double) this.ledValLF15[6, 2] * (double) num7244 * (double) num2);
      numArray2683[index2673] = (byte) num7865;
      byte[] numArray2684 = second;
      int num7866 = num7864;
      int num7867 = num7866 + 1;
      int index2674 = num7866;
      int num7868 = (int) (byte) ((double) this.ledValLF15[5, 0] * (double) num7244 * (double) num2);
      numArray2684[index2674] = (byte) num7868;
      byte[] numArray2685 = second;
      int num7869 = num7867;
      int num7870 = num7869 + 1;
      int index2675 = num7869;
      int num7871 = (int) (byte) ((double) this.ledValLF15[5, 1] * (double) num7244 * (double) num2);
      numArray2685[index2675] = (byte) num7871;
      byte[] numArray2686 = second;
      int num7872 = num7870;
      int num7873 = num7872 + 1;
      int index2676 = num7872;
      int num7874 = (int) (byte) ((double) this.ledValLF15[5, 2] * (double) num7244 * (double) num2);
      numArray2686[index2676] = (byte) num7874;
      byte[] numArray2687 = second;
      int num7875 = num7873;
      int num7876 = num7875 + 1;
      int index2677 = num7875;
      int num7877 = (int) (byte) ((double) this.ledValLF15[4, 0] * (double) num7244 * (double) num2);
      numArray2687[index2677] = (byte) num7877;
      byte[] numArray2688 = second;
      int num7878 = num7876;
      int num7879 = num7878 + 1;
      int index2678 = num7878;
      int num7880 = (int) (byte) ((double) this.ledValLF15[4, 1] * (double) num7244 * (double) num2);
      numArray2688[index2678] = (byte) num7880;
      byte[] numArray2689 = second;
      int num7881 = num7879;
      int num7882 = num7881 + 1;
      int index2679 = num7881;
      int num7883 = (int) (byte) ((double) this.ledValLF15[4, 2] * (double) num7244 * (double) num2);
      numArray2689[index2679] = (byte) num7883;
      byte[] numArray2690 = second;
      int num7884 = num7882;
      int num7885 = num7884 + 1;
      int index2680 = num7884;
      int num7886 = (int) (byte) ((double) this.ledValLF15[2, 0] * (double) num7244 * (double) num2);
      numArray2690[index2680] = (byte) num7886;
      byte[] numArray2691 = second;
      int num7887 = num7885;
      int num7888 = num7887 + 1;
      int index2681 = num7887;
      int num7889 = (int) (byte) ((double) this.ledValLF15[2, 1] * (double) num7244 * (double) num2);
      numArray2691[index2681] = (byte) num7889;
      byte[] numArray2692 = second;
      int num7890 = num7888;
      int num7891 = num7890 + 1;
      int index2682 = num7890;
      int num7892 = (int) (byte) ((double) this.ledValLF15[2, 2] * (double) num7244 * (double) num2);
      numArray2692[index2682] = (byte) num7892;
      byte[] numArray2693 = second;
      int num7893 = num7891;
      int num7894 = num7893 + 1;
      int index2683 = num7893;
      int num7895 = (int) (byte) ((double) this.ledValLF15[1, 0] * (double) num7244 * (double) num2);
      numArray2693[index2683] = (byte) num7895;
      byte[] numArray2694 = second;
      int num7896 = num7894;
      int num7897 = num7896 + 1;
      int index2684 = num7896;
      int num7898 = (int) (byte) ((double) this.ledValLF15[1, 1] * (double) num7244 * (double) num2);
      numArray2694[index2684] = (byte) num7898;
      byte[] numArray2695 = second;
      int num7899 = num7897;
      int num7900 = num7899 + 1;
      int index2685 = num7899;
      int num7901 = (int) (byte) ((double) this.ledValLF15[1, 2] * (double) num7244 * (double) num2);
      numArray2695[index2685] = (byte) num7901;
      byte[] numArray2696 = second;
      int num7902 = num7900;
      int num7903 = num7902 + 1;
      int index2686 = num7902;
      int num7904 = (int) (byte) ((double) this.ledValLF15[0, 0] * (double) num7244 * (double) num2);
      numArray2696[index2686] = (byte) num7904;
      byte[] numArray2697 = second;
      int num7905 = num7903;
      int num7906 = num7905 + 1;
      int index2687 = num7905;
      int num7907 = (int) (byte) ((double) this.ledValLF15[0, 1] * (double) num7244 * (double) num2);
      numArray2697[index2687] = (byte) num7907;
      byte[] numArray2698 = second;
      int num7908 = num7906;
      int num7909 = num7908 + 1;
      int index2688 = num7908;
      int num7910 = (int) (byte) ((double) this.ledValLF15[0, 2] * (double) num7244 * (double) num2);
      numArray2698[index2688] = (byte) num7910;
      byte[] numArray2699 = second;
      int num7911 = num7909;
      int num7912 = num7911 + 1;
      int index2689 = num7911;
      int num7913 = (int) (byte) ((double) this.ledValLF15[3, 0] * (double) num7244 * (double) num2);
      numArray2699[index2689] = (byte) num7913;
      byte[] numArray2700 = second;
      int num7914 = num7912;
      int num7915 = num7914 + 1;
      int index2690 = num7914;
      int num7916 = (int) (byte) ((double) this.ledValLF15[3, 1] * (double) num7244 * (double) num2);
      numArray2700[index2690] = (byte) num7916;
      byte[] numArray2701 = second;
      int num7917 = num7915;
      int num7918 = num7917 + 1;
      int index2691 = num7917;
      int num7919 = (int) (byte) ((double) this.ledValLF15[3, 2] * (double) num7244 * (double) num2);
      numArray2701[index2691] = (byte) num7919;
      byte[] numArray2702 = second;
      int num7920 = num7918;
      int num7921 = num7920 + 1;
      int index2692 = num7920;
      int num7922 = (int) (byte) ((double) this.ledValLF15[5, 0] * (double) num7244 * (double) num2);
      numArray2702[index2692] = (byte) num7922;
      byte[] numArray2703 = second;
      int num7923 = num7921;
      int num7924 = num7923 + 1;
      int index2693 = num7923;
      int num7925 = (int) (byte) ((double) this.ledValLF15[5, 1] * (double) num7244 * (double) num2);
      numArray2703[index2693] = (byte) num7925;
      byte[] numArray2704 = second;
      int num7926 = num7924;
      int num7927 = num7926 + 1;
      int index2694 = num7926;
      int num7928 = (int) (byte) ((double) this.ledValLF15[5, 2] * (double) num7244 * (double) num2);
      numArray2704[index2694] = (byte) num7928;
      byte[] numArray2705 = second;
      int num7929 = num7927;
      int num7930 = num7929 + 1;
      int index2695 = num7929;
      int num7931 = (int) (byte) ((double) this.ledValLF15[6, 0] * (double) num7244 * (double) num2);
      numArray2705[index2695] = (byte) num7931;
      byte[] numArray2706 = second;
      int num7932 = num7930;
      int num7933 = num7932 + 1;
      int index2696 = num7932;
      int num7934 = (int) (byte) ((double) this.ledValLF15[6, 1] * (double) num7244 * (double) num2);
      numArray2706[index2696] = (byte) num7934;
      byte[] numArray2707 = second;
      int num7935 = num7933;
      int num7936 = num7935 + 1;
      int index2697 = num7935;
      int num7937 = (int) (byte) ((double) this.ledValLF15[6, 2] * (double) num7244 * (double) num2);
      numArray2707[index2697] = (byte) num7937;
      byte[] numArray2708 = second;
      int num7938 = num7936;
      int num7939 = num7938 + 1;
      int index2698 = num7938;
      int num7940 = (int) (byte) ((double) this.ledValLF15[7, 0] * (double) num7244 * (double) num2);
      numArray2708[index2698] = (byte) num7940;
      byte[] numArray2709 = second;
      int num7941 = num7939;
      int num7942 = num7941 + 1;
      int index2699 = num7941;
      int num7943 = (int) (byte) ((double) this.ledValLF15[7, 1] * (double) num7244 * (double) num2);
      numArray2709[index2699] = (byte) num7943;
      byte[] numArray2710 = second;
      int num7944 = num7942;
      int num7945 = num7944 + 1;
      int index2700 = num7944;
      int num7946 = (int) (byte) ((double) this.ledValLF15[7, 2] * (double) num7244 * (double) num2);
      numArray2710[index2700] = (byte) num7946;
      byte[] numArray2711 = second;
      int num7947 = num7945;
      int num7948 = num7947 + 1;
      int index2701 = num7947;
      int num7949 = (int) (byte) ((double) this.ledValLF15[8, 0] * (double) num7244 * (double) num2);
      numArray2711[index2701] = (byte) num7949;
      byte[] numArray2712 = second;
      int num7950 = num7948;
      int num7951 = num7950 + 1;
      int index2702 = num7950;
      int num7952 = (int) (byte) ((double) this.ledValLF15[8, 1] * (double) num7244 * (double) num2);
      numArray2712[index2702] = (byte) num7952;
      byte[] numArray2713 = second;
      int num7953 = num7951;
      int num7954 = num7953 + 1;
      int index2703 = num7953;
      int num7955 = (int) (byte) ((double) this.ledValLF15[8, 2] * (double) num7244 * (double) num2);
      numArray2713[index2703] = (byte) num7955;
      byte[] numArray2714 = second;
      int num7956 = num7954;
      int num7957 = num7956 + 1;
      int index2704 = num7956;
      int num7958 = (int) (byte) ((double) this.ledValLF15[9, 0] * (double) num7244 * (double) num2);
      numArray2714[index2704] = (byte) num7958;
      byte[] numArray2715 = second;
      int num7959 = num7957;
      int num7960 = num7959 + 1;
      int index2705 = num7959;
      int num7961 = (int) (byte) ((double) this.ledValLF15[9, 1] * (double) num7244 * (double) num2);
      numArray2715[index2705] = (byte) num7961;
      byte[] numArray2716 = second;
      int num7962 = num7960;
      int num7963 = num7962 + 1;
      int index2706 = num7962;
      int num7964 = (int) (byte) ((double) this.ledValLF15[9, 2] * (double) num7244 * (double) num2);
      numArray2716[index2706] = (byte) num7964;
      byte[] numArray2717 = second;
      int num7965 = num7963;
      int num7966 = num7965 + 1;
      int index2707 = num7965;
      int num7967 = (int) (byte) ((double) this.ledValLF15[63 /*0x3F*/, 0] * (double) num7244 * (double) num2);
      numArray2717[index2707] = (byte) num7967;
      byte[] numArray2718 = second;
      int num7968 = num7966;
      int num7969 = num7968 + 1;
      int index2708 = num7968;
      int num7970 = (int) (byte) ((double) this.ledValLF15[63 /*0x3F*/, 1] * (double) num7244 * (double) num2);
      numArray2718[index2708] = (byte) num7970;
      byte[] numArray2719 = second;
      int num7971 = num7969;
      int num7972 = num7971 + 1;
      int index2709 = num7971;
      int num7973 = (int) (byte) ((double) this.ledValLF15[63 /*0x3F*/, 2] * (double) num7244 * (double) num2);
      numArray2719[index2709] = (byte) num7973;
      byte[] numArray2720 = second;
      int num7974 = num7972;
      int num7975 = num7974 + 1;
      int index2710 = num7974;
      int num7976 = (int) (byte) ((double) this.ledValLF15[64 /*0x40*/, 0] * (double) num7244 * (double) num2);
      numArray2720[index2710] = (byte) num7976;
      byte[] numArray2721 = second;
      int num7977 = num7975;
      int num7978 = num7977 + 1;
      int index2711 = num7977;
      int num7979 = (int) (byte) ((double) this.ledValLF15[64 /*0x40*/, 1] * (double) num7244 * (double) num2);
      numArray2721[index2711] = (byte) num7979;
      byte[] numArray2722 = second;
      int num7980 = num7978;
      int num7981 = num7980 + 1;
      int index2712 = num7980;
      int num7982 = (int) (byte) ((double) this.ledValLF15[64 /*0x40*/, 2] * (double) num7244 * (double) num2);
      numArray2722[index2712] = (byte) num7982;
      byte[] numArray2723 = second;
      int num7983 = num7981;
      int num7984 = num7983 + 1;
      int index2713 = num7983;
      int num7985 = (int) (byte) ((double) this.ledValLF15[65, 0] * (double) num7244 * (double) num2);
      numArray2723[index2713] = (byte) num7985;
      byte[] numArray2724 = second;
      int num7986 = num7984;
      int num7987 = num7986 + 1;
      int index2714 = num7986;
      int num7988 = (int) (byte) ((double) this.ledValLF15[65, 1] * (double) num7244 * (double) num2);
      numArray2724[index2714] = (byte) num7988;
      byte[] numArray2725 = second;
      int num7989 = num7987;
      int num7990 = num7989 + 1;
      int index2715 = num7989;
      int num7991 = (int) (byte) ((double) this.ledValLF15[65, 2] * (double) num7244 * (double) num2);
      numArray2725[index2715] = (byte) num7991;
      byte[] numArray2726 = second;
      int num7992 = num7990;
      int num7993 = num7992 + 1;
      int index2716 = num7992;
      int num7994 = (int) (byte) ((double) this.ledValLF15[66, 0] * (double) num7244 * (double) num2);
      numArray2726[index2716] = (byte) num7994;
      byte[] numArray2727 = second;
      int num7995 = num7993;
      int num7996 = num7995 + 1;
      int index2717 = num7995;
      int num7997 = (int) (byte) ((double) this.ledValLF15[66, 1] * (double) num7244 * (double) num2);
      numArray2727[index2717] = (byte) num7997;
      byte[] numArray2728 = second;
      int num7998 = num7996;
      int num7999 = num7998 + 1;
      int index2718 = num7998;
      int num8000 = (int) (byte) ((double) this.ledValLF15[66, 2] * (double) num7244 * (double) num2);
      numArray2728[index2718] = (byte) num8000;
      byte[] numArray2729 = second;
      int num8001 = num7999;
      int num8002 = num8001 + 1;
      int index2719 = num8001;
      int num8003 = (int) (byte) ((double) this.ledValLF15[67, 0] * (double) num7244 * (double) num2);
      numArray2729[index2719] = (byte) num8003;
      byte[] numArray2730 = second;
      int num8004 = num8002;
      int num8005 = num8004 + 1;
      int index2720 = num8004;
      int num8006 = (int) (byte) ((double) this.ledValLF15[67, 1] * (double) num7244 * (double) num2);
      numArray2730[index2720] = (byte) num8006;
      byte[] numArray2731 = second;
      int num8007 = num8005;
      int num8008 = num8007 + 1;
      int index2721 = num8007;
      int num8009 = (int) (byte) ((double) this.ledValLF15[67, 2] * (double) num7244 * (double) num2);
      numArray2731[index2721] = (byte) num8009;
      byte[] numArray2732 = second;
      int num8010 = num8008;
      int num8011 = num8010 + 1;
      int index2722 = num8010;
      int num8012 = (int) (byte) ((double) this.ledValLF15[68, 0] * (double) num7244 * (double) num2);
      numArray2732[index2722] = (byte) num8012;
      byte[] numArray2733 = second;
      int num8013 = num8011;
      int num8014 = num8013 + 1;
      int index2723 = num8013;
      int num8015 = (int) (byte) ((double) this.ledValLF15[68, 1] * (double) num7244 * (double) num2);
      numArray2733[index2723] = (byte) num8015;
      byte[] numArray2734 = second;
      int num8016 = num8014;
      int num8017 = num8016 + 1;
      int index2724 = num8016;
      int num8018 = (int) (byte) ((double) this.ledValLF15[68, 2] * (double) num7244 * (double) num2);
      numArray2734[index2724] = (byte) num8018;
      byte[] numArray2735 = second;
      int num8019 = num8017;
      int num8020 = num8019 + 1;
      int index2725 = num8019;
      int num8021 = (int) (byte) ((double) this.ledValLF15[69, 0] * (double) num7244 * (double) num2);
      numArray2735[index2725] = (byte) num8021;
      byte[] numArray2736 = second;
      int num8022 = num8020;
      int num8023 = num8022 + 1;
      int index2726 = num8022;
      int num8024 = (int) (byte) ((double) this.ledValLF15[69, 1] * (double) num7244 * (double) num2);
      numArray2736[index2726] = (byte) num8024;
      byte[] numArray2737 = second;
      int num8025 = num8023;
      int num8026 = num8025 + 1;
      int index2727 = num8025;
      int num8027 = (int) (byte) ((double) this.ledValLF15[69, 2] * (double) num7244 * (double) num2);
      numArray2737[index2727] = (byte) num8027;
      byte[] numArray2738 = second;
      int num8028 = num8026;
      int num8029 = num8028 + 1;
      int index2728 = num8028;
      int num8030 = (int) (byte) ((double) this.ledValLF15[70, 0] * (double) num7244 * (double) num2);
      numArray2738[index2728] = (byte) num8030;
      byte[] numArray2739 = second;
      int num8031 = num8029;
      int num8032 = num8031 + 1;
      int index2729 = num8031;
      int num8033 = (int) (byte) ((double) this.ledValLF15[70, 1] * (double) num7244 * (double) num2);
      numArray2739[index2729] = (byte) num8033;
      byte[] numArray2740 = second;
      int num8034 = num8032;
      int num8035 = num8034 + 1;
      int index2730 = num8034;
      int num8036 = (int) (byte) ((double) this.ledValLF15[70, 2] * (double) num7244 * (double) num2);
      numArray2740[index2730] = (byte) num8036;
      byte[] numArray2741 = second;
      int num8037 = num8035;
      int num8038 = num8037 + 1;
      int index2731 = num8037;
      int num8039 = (int) (byte) ((double) this.ledValLF15[71, 0] * (double) num7244 * (double) num2);
      numArray2741[index2731] = (byte) num8039;
      byte[] numArray2742 = second;
      int num8040 = num8038;
      int num8041 = num8040 + 1;
      int index2732 = num8040;
      int num8042 = (int) (byte) ((double) this.ledValLF15[71, 1] * (double) num7244 * (double) num2);
      numArray2742[index2732] = (byte) num8042;
      byte[] numArray2743 = second;
      int num8043 = num8041;
      int num8044 = num8043 + 1;
      int index2733 = num8043;
      int num8045 = (int) (byte) ((double) this.ledValLF15[71, 2] * (double) num7244 * (double) num2);
      numArray2743[index2733] = (byte) num8045;
      byte[] numArray2744 = second;
      int num8046 = num8044;
      int num8047 = num8046 + 1;
      int index2734 = num8046;
      int num8048 = (int) (byte) ((double) this.ledValLF15[71, 0] * (double) num7244 * (double) num2);
      numArray2744[index2734] = (byte) num8048;
      byte[] numArray2745 = second;
      int num8049 = num8047;
      int num8050 = num8049 + 1;
      int index2735 = num8049;
      int num8051 = (int) (byte) ((double) this.ledValLF15[71, 1] * (double) num7244 * (double) num2);
      numArray2745[index2735] = (byte) num8051;
      byte[] numArray2746 = second;
      int num8052 = num8050;
      int num8053 = num8052 + 1;
      int index2736 = num8052;
      int num8054 = (int) (byte) ((double) this.ledValLF15[71, 2] * (double) num7244 * (double) num2);
      numArray2746[index2736] = (byte) num8054;
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else if (this.nowLedStyle == (byte) 12)
    {
      byte[] second = new byte[186];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) second.Length,
        (byte) (second.Length >> 8),
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 62; ++index)
      {
        if (this.myOnOff == (byte) 0)
        {
          second[index * 3] = (byte) 0;
          second[index * 3 + 1] = (byte) 0;
          second[index * 3 + 2] = (byte) 0;
        }
        else
        {
          second[index * 3] = (byte) ((double) ((int) this.ledValLF13[index, 0] * (int) this.myBrightness) * 0.0099999997764825821 * (double) num2 + (double) num1);
          second[index * 3 + 1] = (byte) ((double) ((int) this.ledValLF13[index, 1] * (int) this.myBrightness) * 0.0099999997764825821 * (double) num2 + (double) num1);
          second[index * 3 + 2] = (byte) ((double) ((int) this.ledValLF13[index, 2] * (int) this.myBrightness) * 0.0099999997764825821 * (double) num2 + (double) num1);
        }
      }
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm == null)
        return;
      delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
    else
    {
      byte[] second = new byte[90];
      byte[] first = new byte[20]
      {
        (byte) 218,
        (byte) 219,
        (byte) 220,
        (byte) 221,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) second.Length,
        (byte) 0,
        (byte) 0,
        (byte) 0
      };
      for (int index = 0; index < 30; ++index)
      {
        if (this.myOnOff == (byte) 0)
        {
          second[index * 3] = (byte) 0;
          second[index * 3 + 1] = (byte) 0;
          second[index * 3 + 2] = (byte) 0;
        }
        else if (this.ucScreenLED1.isOn[index])
        {
          second[index * 3] = (byte) ((double) this.ucScreenLED1.ledColor[index, 0] * (double) num2 + (double) num1);
          second[index * 3 + 1] = (byte) ((double) this.ucScreenLED1.ledColor[index, 1] * (double) num2 + (double) num1);
          second[index * 3 + 2] = (byte) ((double) this.ucScreenLED1.ledColor[index, 2] * (double) num2 + (double) num1);
        }
        else
        {
          second[index * 3] = (byte) 0;
          second[index * 3 + 1] = (byte) 0;
          second[index * 3 + 2] = (byte) 0;
        }
      }
      byte[] array = ((IEnumerable<byte>) first).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
      FormLED.delegateFormLED delegateForm = this.delegateForm;
      if (delegateForm != null)
        delegateForm(16 /*0x10*/, (object) this.myDeviceCount, (object) array, (object) array.Length);
    }
  }

  private void DSCL_Timer()
  {
    for (int index = 0; index < 10; ++index)
    {
      this.ledVal[index, 0] = (byte) this.rgbR1;
      this.ledVal[index, 1] = (byte) this.rgbG1;
      this.ledVal[index, 2] = (byte) this.rgbB1;
    }
  }

  private void DSCL_Timer4()
  {
    for (int index = 0; index < 14; ++index)
    {
      this.ledVal4[index, 0] = (byte) this.rgbR1;
      this.ledVal4[index, 1] = (byte) this.rgbG1;
      this.ledVal4[index, 2] = (byte) this.rgbB1;
    }
  }

  private void DSCL_Timer5()
  {
    for (int index = 0; index < 23; ++index)
    {
      this.ledVal5[index, 0] = (byte) this.rgbR1;
      this.ledVal5[index, 1] = (byte) this.rgbG1;
      this.ledVal5[index, 2] = (byte) this.rgbB1;
    }
  }

  private void DSCL_Timer6()
  {
    for (int index = 0; index < 72; ++index)
    {
      this.ledVal6[index, 0] = (byte) this.rgbR1;
      this.ledVal6[index, 1] = (byte) this.rgbG1;
      this.ledVal6[index, 2] = (byte) this.rgbB1;
    }
  }

  private void DSCL_Timer8()
  {
    for (int index = 0; index < 13; ++index)
    {
      this.ledVal8[index, 0] = (byte) this.rgbR1;
      this.ledVal8[index, 1] = (byte) this.rgbG1;
      this.ledVal8[index, 2] = (byte) this.rgbB1;
    }
  }

  private void DSCL_Timer9()
  {
    for (int index = 0; index < 31 /*0x1F*/; ++index)
    {
      this.ledVal9[index, 0] = (byte) this.rgbR1;
      this.ledVal9[index, 1] = (byte) this.rgbG1;
      this.ledVal9[index, 2] = (byte) this.rgbB1;
    }
  }

  private void DSCL_Timer10()
  {
    for (int index = 0; index < 17; ++index)
    {
      this.ledVal10[index, 0] = (byte) this.rgbR1;
      this.ledVal10[index, 1] = (byte) this.rgbG1;
      this.ledVal10[index, 2] = (byte) this.rgbB1;
    }
  }

  private void DSCL_TimerLF15()
  {
    for (int index = 0; index < 72; ++index)
    {
      this.ledValLF15[index, 0] = (byte) this.rgbR1;
      this.ledValLF15[index, 1] = (byte) this.rgbG1;
      this.ledValLF15[index, 2] = (byte) this.rgbB1;
    }
  }

  private void DSCL_TimerLF13()
  {
    for (int index = 0; index < 62; ++index)
    {
      this.ledValLF13[index, 0] = (byte) this.rgbR1;
      this.ledValLF13[index, 1] = (byte) this.rgbG1;
      this.ledValLF13[index, 2] = (byte) this.rgbB1;
    }
  }

  private void DSHX_Timer()
  {
    ++this.rgbTimer;
    byte num1;
    byte num2;
    byte num3;
    if (this.rgbTimer < 33)
    {
      num1 = (byte) (this.rgbR1 * this.rgbTimer / 33);
      num2 = (byte) (this.rgbG1 * this.rgbTimer / 33);
      num3 = (byte) (this.rgbB1 * this.rgbTimer / 33);
    }
    else if (this.rgbTimer < 66)
    {
      num1 = (byte) (this.rgbR1 * (66 - this.rgbTimer) / 33);
      num2 = (byte) (this.rgbG1 * (66 - this.rgbTimer) / 33);
      num3 = (byte) (this.rgbB1 * (66 - this.rgbTimer) / 33);
    }
    else
    {
      this.rgbTimer = 0;
      int num4;
      num3 = (byte) (num4 = 0);
      num2 = (byte) num4;
      num1 = (byte) num4;
    }
    for (int index = 0; index < 10; ++index)
    {
      this.ledVal[index, 0] = (byte) ((double) num1 * 0.8 + (double) this.rgbR1 * 0.2);
      this.ledVal[index, 1] = (byte) ((double) num2 * 0.8 + (double) this.rgbG1 * 0.2);
      this.ledVal[index, 2] = (byte) ((double) num3 * 0.8 + (double) this.rgbB1 * 0.2);
    }
  }

  private void DSHX_Timer4()
  {
    ++this.rgbTimer;
    byte num1;
    byte num2;
    byte num3;
    if (this.rgbTimer < 33)
    {
      num1 = (byte) (this.rgbR1 * this.rgbTimer / 33);
      num2 = (byte) (this.rgbG1 * this.rgbTimer / 33);
      num3 = (byte) (this.rgbB1 * this.rgbTimer / 33);
    }
    else if (this.rgbTimer < 66)
    {
      num1 = (byte) (this.rgbR1 * (66 - this.rgbTimer) / 33);
      num2 = (byte) (this.rgbG1 * (66 - this.rgbTimer) / 33);
      num3 = (byte) (this.rgbB1 * (66 - this.rgbTimer) / 33);
    }
    else
    {
      this.rgbTimer = 0;
      int num4;
      num3 = (byte) (num4 = 0);
      num2 = (byte) num4;
      num1 = (byte) num4;
    }
    for (int index = 0; index < 14; ++index)
    {
      this.ledVal4[index, 0] = (byte) ((double) num1 * 0.8 + (double) this.rgbR1 * 0.2);
      this.ledVal4[index, 1] = (byte) ((double) num2 * 0.8 + (double) this.rgbG1 * 0.2);
      this.ledVal4[index, 2] = (byte) ((double) num3 * 0.8 + (double) this.rgbB1 * 0.2);
    }
  }

  private void DSHX_Timer5()
  {
    ++this.rgbTimer;
    byte num1;
    byte num2;
    byte num3;
    if (this.rgbTimer < 33)
    {
      num1 = (byte) (this.rgbR1 * this.rgbTimer / 33);
      num2 = (byte) (this.rgbG1 * this.rgbTimer / 33);
      num3 = (byte) (this.rgbB1 * this.rgbTimer / 33);
    }
    else if (this.rgbTimer < 66)
    {
      num1 = (byte) (this.rgbR1 * (66 - this.rgbTimer) / 33);
      num2 = (byte) (this.rgbG1 * (66 - this.rgbTimer) / 33);
      num3 = (byte) (this.rgbB1 * (66 - this.rgbTimer) / 33);
    }
    else
    {
      this.rgbTimer = 0;
      int num4;
      num3 = (byte) (num4 = 0);
      num2 = (byte) num4;
      num1 = (byte) num4;
    }
    for (int index = 0; index < 23; ++index)
    {
      this.ledVal5[index, 0] = (byte) ((double) num1 * 0.8 + (double) this.rgbR1 * 0.2);
      this.ledVal5[index, 1] = (byte) ((double) num2 * 0.8 + (double) this.rgbG1 * 0.2);
      this.ledVal5[index, 2] = (byte) ((double) num3 * 0.8 + (double) this.rgbB1 * 0.2);
    }
  }

  private void DSHX_Timer6()
  {
    ++this.rgbTimer;
    byte num1;
    byte num2;
    byte num3;
    if (this.rgbTimer < 33)
    {
      num1 = (byte) (this.rgbR1 * this.rgbTimer / 33);
      num2 = (byte) (this.rgbG1 * this.rgbTimer / 33);
      num3 = (byte) (this.rgbB1 * this.rgbTimer / 33);
    }
    else if (this.rgbTimer < 66)
    {
      num1 = (byte) (this.rgbR1 * (66 - this.rgbTimer) / 33);
      num2 = (byte) (this.rgbG1 * (66 - this.rgbTimer) / 33);
      num3 = (byte) (this.rgbB1 * (66 - this.rgbTimer) / 33);
    }
    else
    {
      this.rgbTimer = 0;
      int num4;
      num3 = (byte) (num4 = 0);
      num2 = (byte) num4;
      num1 = (byte) num4;
    }
    for (int index = 0; index < 72; ++index)
    {
      this.ledVal6[index, 0] = (byte) ((double) num1 * 0.8 + (double) this.rgbR1 * 0.2);
      this.ledVal6[index, 1] = (byte) ((double) num2 * 0.8 + (double) this.rgbG1 * 0.2);
      this.ledVal6[index, 2] = (byte) ((double) num3 * 0.8 + (double) this.rgbB1 * 0.2);
    }
  }

  private void DSHX_Timer8()
  {
    ++this.rgbTimer;
    byte num1;
    byte num2;
    byte num3;
    if (this.rgbTimer < 33)
    {
      num1 = (byte) (this.rgbR1 * this.rgbTimer / 33);
      num2 = (byte) (this.rgbG1 * this.rgbTimer / 33);
      num3 = (byte) (this.rgbB1 * this.rgbTimer / 33);
    }
    else if (this.rgbTimer < 66)
    {
      num1 = (byte) (this.rgbR1 * (66 - this.rgbTimer) / 33);
      num2 = (byte) (this.rgbG1 * (66 - this.rgbTimer) / 33);
      num3 = (byte) (this.rgbB1 * (66 - this.rgbTimer) / 33);
    }
    else
    {
      this.rgbTimer = 0;
      int num4;
      num3 = (byte) (num4 = 0);
      num2 = (byte) num4;
      num1 = (byte) num4;
    }
    for (int index = 0; index < 13; ++index)
    {
      this.ledVal8[index, 0] = (byte) ((double) num1 * 0.8 + (double) this.rgbR1 * 0.2);
      this.ledVal8[index, 1] = (byte) ((double) num2 * 0.8 + (double) this.rgbG1 * 0.2);
      this.ledVal8[index, 2] = (byte) ((double) num3 * 0.8 + (double) this.rgbB1 * 0.2);
    }
  }

  private void DSHX_Timer9()
  {
    ++this.rgbTimer;
    byte num1;
    byte num2;
    byte num3;
    if (this.rgbTimer < 33)
    {
      num1 = (byte) (this.rgbR1 * this.rgbTimer / 33);
      num2 = (byte) (this.rgbG1 * this.rgbTimer / 33);
      num3 = (byte) (this.rgbB1 * this.rgbTimer / 33);
    }
    else if (this.rgbTimer < 66)
    {
      num1 = (byte) (this.rgbR1 * (66 - this.rgbTimer) / 33);
      num2 = (byte) (this.rgbG1 * (66 - this.rgbTimer) / 33);
      num3 = (byte) (this.rgbB1 * (66 - this.rgbTimer) / 33);
    }
    else
    {
      this.rgbTimer = 0;
      int num4;
      num3 = (byte) (num4 = 0);
      num2 = (byte) num4;
      num1 = (byte) num4;
    }
    for (int index = 0; index < 31 /*0x1F*/; ++index)
    {
      this.ledVal9[index, 0] = (byte) ((double) num1 * 0.8 + (double) this.rgbR1 * 0.2);
      this.ledVal9[index, 1] = (byte) ((double) num2 * 0.8 + (double) this.rgbG1 * 0.2);
      this.ledVal9[index, 2] = (byte) ((double) num3 * 0.8 + (double) this.rgbB1 * 0.2);
    }
  }

  private void DSHX_Timer10()
  {
    ++this.rgbTimer;
    byte num1;
    byte num2;
    byte num3;
    if (this.rgbTimer < 33)
    {
      num1 = (byte) (this.rgbR1 * this.rgbTimer / 33);
      num2 = (byte) (this.rgbG1 * this.rgbTimer / 33);
      num3 = (byte) (this.rgbB1 * this.rgbTimer / 33);
    }
    else if (this.rgbTimer < 66)
    {
      num1 = (byte) (this.rgbR1 * (66 - this.rgbTimer) / 33);
      num2 = (byte) (this.rgbG1 * (66 - this.rgbTimer) / 33);
      num3 = (byte) (this.rgbB1 * (66 - this.rgbTimer) / 33);
    }
    else
    {
      this.rgbTimer = 0;
      int num4;
      num3 = (byte) (num4 = 0);
      num2 = (byte) num4;
      num1 = (byte) num4;
    }
    for (int index = 0; index < 17; ++index)
    {
      this.ledVal10[index, 0] = (byte) ((double) num1 * 0.8 + (double) this.rgbR1 * 0.2);
      this.ledVal10[index, 1] = (byte) ((double) num2 * 0.8 + (double) this.rgbG1 * 0.2);
      this.ledVal10[index, 2] = (byte) ((double) num3 * 0.8 + (double) this.rgbB1 * 0.2);
    }
  }

  private void DSHX_TimerLF15()
  {
    ++this.rgbTimer;
    byte num1;
    byte num2;
    byte num3;
    if (this.rgbTimer < 33)
    {
      num1 = (byte) (this.rgbR1 * this.rgbTimer / 33);
      num2 = (byte) (this.rgbG1 * this.rgbTimer / 33);
      num3 = (byte) (this.rgbB1 * this.rgbTimer / 33);
    }
    else if (this.rgbTimer < 66)
    {
      num1 = (byte) (this.rgbR1 * (66 - this.rgbTimer) / 33);
      num2 = (byte) (this.rgbG1 * (66 - this.rgbTimer) / 33);
      num3 = (byte) (this.rgbB1 * (66 - this.rgbTimer) / 33);
    }
    else
    {
      this.rgbTimer = 0;
      int num4;
      num3 = (byte) (num4 = 0);
      num2 = (byte) num4;
      num1 = (byte) num4;
    }
    for (int index = 0; index < 72; ++index)
    {
      this.ledValLF15[index, 0] = (byte) ((double) num1 * 0.8 + (double) this.rgbR1 * 0.2);
      this.ledValLF15[index, 1] = (byte) ((double) num2 * 0.8 + (double) this.rgbG1 * 0.2);
      this.ledValLF15[index, 2] = (byte) ((double) num3 * 0.8 + (double) this.rgbB1 * 0.2);
    }
  }

  private void DSHX_TimerLF13()
  {
    ++this.rgbTimer;
    byte num1;
    byte num2;
    byte num3;
    if (this.rgbTimer < 33)
    {
      num1 = (byte) (this.rgbR1 * this.rgbTimer / 33);
      num2 = (byte) (this.rgbG1 * this.rgbTimer / 33);
      num3 = (byte) (this.rgbB1 * this.rgbTimer / 33);
    }
    else if (this.rgbTimer < 66)
    {
      num1 = (byte) (this.rgbR1 * (66 - this.rgbTimer) / 33);
      num2 = (byte) (this.rgbG1 * (66 - this.rgbTimer) / 33);
      num3 = (byte) (this.rgbB1 * (66 - this.rgbTimer) / 33);
    }
    else
    {
      this.rgbTimer = 0;
      int num4;
      num3 = (byte) (num4 = 0);
      num2 = (byte) num4;
      num1 = (byte) num4;
    }
    for (int index = 0; index < 62; ++index)
    {
      this.ledValLF13[index, 0] = (byte) ((double) num1 * 0.8 + (double) this.rgbR1 * 0.2);
      this.ledValLF13[index, 1] = (byte) ((double) num2 * 0.8 + (double) this.rgbG1 * 0.2);
      this.ledValLF13[index, 2] = (byte) ((double) num3 * 0.8 + (double) this.rgbB1 * 0.2);
    }
  }

  private void DSHX_Timer_New()
  {
    ++this.rgbTimer1;
    if (this.rgbTimer1 < 33)
      this.ledHuxi = (byte) (51.0 + (double) ((int) byte.MaxValue * this.rgbTimer1 / 33) * 0.8);
    else if (this.rgbTimer1 < 66)
    {
      this.ledHuxi = (byte) (51.0 + (double) ((int) byte.MaxValue * (66 - this.rgbTimer1) / 33) * 0.8);
    }
    else
    {
      this.rgbTimer1 = 0;
      this.ledHuxi = (byte) 51;
    }
  }

  private void QCJB_Timer()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    for (int index = 0; index < 10; ++index)
    {
      this.ledVal[index, 0] = num1;
      this.ledVal[index, 1] = num2;
      this.ledVal[index, 2] = num3;
    }
  }

  private void QCJB_Timer4()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    for (int index = 0; index < 14; ++index)
    {
      this.ledVal4[index, 0] = num1;
      this.ledVal4[index, 1] = num2;
      this.ledVal4[index, 2] = num3;
    }
  }

  private void QCJB_Timer5()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    for (int index = 0; index < 23; ++index)
    {
      this.ledVal5[index, 0] = num1;
      this.ledVal5[index, 1] = num2;
      this.ledVal5[index, 2] = num3;
    }
  }

  private void QCJB_Timer6()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    for (int index = 0; index < 72; ++index)
    {
      this.ledVal6[index, 0] = num1;
      this.ledVal6[index, 1] = num2;
      this.ledVal6[index, 2] = num3;
    }
  }

  private void QCJB_Timer8()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    for (int index = 0; index < 13; ++index)
    {
      this.ledVal8[index, 0] = num1;
      this.ledVal8[index, 1] = num2;
      this.ledVal8[index, 2] = num3;
    }
  }

  private void QCJB_Timer9()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    for (int index = 0; index < 31 /*0x1F*/; ++index)
    {
      this.ledVal9[index, 0] = num1;
      this.ledVal9[index, 1] = num2;
      this.ledVal9[index, 2] = num3;
    }
  }

  private void QCJB_Timer10()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    for (int index = 0; index < 17; ++index)
    {
      this.ledVal10[index, 0] = num1;
      this.ledVal10[index, 1] = num2;
      this.ledVal10[index, 2] = num3;
    }
  }

  private void QCJB_TimerLF15()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    for (int index = 0; index < 72; ++index)
    {
      this.ledValLF15[index, 0] = num1;
      this.ledValLF15[index, 1] = num2;
      this.ledValLF15[index, 2] = num3;
    }
  }

  private void QCJB_TimerLF13()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    for (int index = 0; index < 62; ++index)
    {
      this.ledValLF13[index, 0] = num1;
      this.ledValLF13[index, 1] = num2;
      this.ledValLF13[index, 2] = num3;
    }
  }

  private void QCJB_Timer_New()
  {
    byte num1 = 0;
    byte num2 = 0;
    byte num3 = 0;
    if (this.nowJianbian == 0)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 1;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 1)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = byte.MaxValue;
        num2 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 2;
        num1 = byte.MaxValue;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 2)
    {
      if (this.nowJianbianTimer < 28)
      {
        num1 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num2 = byte.MaxValue;
        num3 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 3;
        num1 = (byte) 0;
        num2 = byte.MaxValue;
        num3 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 3)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = byte.MaxValue;
        num3 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 4;
        num3 = byte.MaxValue;
        num2 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 4)
    {
      if (this.nowJianbianTimer < 28)
      {
        num2 = (byte) ((28 - this.nowJianbianTimer) * (int) byte.MaxValue / 28);
        num3 = byte.MaxValue;
        num1 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 5;
        num2 = (byte) 0;
        num3 = byte.MaxValue;
        num1 = (byte) 0;
      }
    }
    else if (this.nowJianbian == 5)
    {
      if (this.nowJianbianTimer < 28)
      {
        num3 = byte.MaxValue;
        num1 = (byte) (this.nowJianbianTimer * (int) byte.MaxValue / 28);
        num2 = (byte) 0;
        ++this.nowJianbianTimer;
      }
      else
      {
        this.nowJianbianTimer = 0;
        this.nowJianbian = 0;
        num3 = byte.MaxValue;
        num1 = byte.MaxValue;
        num2 = (byte) 0;
      }
    }
    this.ledQicai[0] = num1;
    this.ledQicai[1] = num2;
    this.ledQicai[2] = num3;
  }

  private void CHMS_Timer()
  {
    if (this.rgbTimer >= 768 /*0x0300*/)
      this.rgbTimer = 0;
    for (int index = 0; index < 10; ++index)
    {
      this.ledVal[10 - index - 1, 0] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 10 / 6) % 768 /*0x0300*/, 0];
      this.ledVal[10 - index - 1, 1] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 10 / 6) % 768 /*0x0300*/, 1];
      this.ledVal[10 - index - 1, 2] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 10 / 6) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer += 4;
  }

  private void CHMS_Timer4()
  {
    if (this.rgbTimer >= 768 /*0x0300*/)
      this.rgbTimer = 0;
    for (int index = 0; index < 14; ++index)
    {
      this.ledVal4[14 - index - 1, 0] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 14 / 6) % 768 /*0x0300*/, 0];
      this.ledVal4[14 - index - 1, 1] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 14 / 6) % 768 /*0x0300*/, 1];
      this.ledVal4[14 - index - 1, 2] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 14 / 6) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer += 4;
  }

  private void CHMS_Timer5()
  {
    if (this.rgbTimer >= 768 /*0x0300*/)
      this.rgbTimer = 0;
    for (int index = 0; index < 23; ++index)
    {
      this.ledVal5[23 - index - 1, 0] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 23 / 6) % 768 /*0x0300*/, 0];
      this.ledVal5[23 - index - 1, 1] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 23 / 6) % 768 /*0x0300*/, 1];
      this.ledVal5[23 - index - 1, 2] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 23 / 6) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer += 4;
  }

  private void CHMS_Timer6()
  {
    if (this.rgbTimer >= 768 /*0x0300*/)
      this.rgbTimer = 0;
    for (int index = 0; index < 72; ++index)
    {
      this.ledVal6[72 - index - 1, 0] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 72) % 768 /*0x0300*/, 0];
      this.ledVal6[72 - index - 1, 1] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 72) % 768 /*0x0300*/, 1];
      this.ledVal6[72 - index - 1, 2] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 72) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer += 4;
  }

  private void CHMS_Timer8()
  {
    if (this.rgbTimer >= 768 /*0x0300*/)
      this.rgbTimer = 0;
    for (int index = 0; index < 13; ++index)
    {
      this.ledVal8[13 - index - 1, 0] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 13 / 2) % 768 /*0x0300*/, 0];
      this.ledVal8[13 - index - 1, 1] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 13 / 2) % 768 /*0x0300*/, 1];
      this.ledVal8[13 - index - 1, 2] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 13 / 2) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer += 4;
  }

  private void CHMS_Timer9()
  {
    if (this.rgbTimer >= 768 /*0x0300*/)
      this.rgbTimer = 0;
    for (int index = 0; index < 31 /*0x1F*/; ++index)
    {
      this.ledVal9[31 /*0x1F*/ - index - 1, 0] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 31 /*0x1F*/) % 768 /*0x0300*/, 0];
      this.ledVal9[31 /*0x1F*/ - index - 1, 1] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 31 /*0x1F*/) % 768 /*0x0300*/, 1];
      this.ledVal9[31 /*0x1F*/ - index - 1, 2] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 31 /*0x1F*/) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer += 4;
  }

  private void CHMS_Timer10()
  {
    if (this.rgbTimer >= 768 /*0x0300*/)
      this.rgbTimer = 0;
    for (int index = 0; index < 17; ++index)
    {
      this.ledVal10[17 - index - 1, 0] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 17 / 6) % 768 /*0x0300*/, 0];
      this.ledVal10[17 - index - 1, 1] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 17 / 6) % 768 /*0x0300*/, 1];
      this.ledVal10[17 - index - 1, 2] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 17 / 6) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer += 4;
  }

  private void CHMS_TimerLF15()
  {
    if (this.rgbTimer >= 768 /*0x0300*/)
      this.rgbTimer = 0;
    for (int index = 0; index < 72; ++index)
    {
      this.ledValLF15[72 - index - 1, 0] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 72) % 768 /*0x0300*/, 0];
      this.ledValLF15[72 - index - 1, 1] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 72) % 768 /*0x0300*/, 1];
      this.ledValLF15[72 - index - 1, 2] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 72) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer += 4;
  }

  private void CHMS_TimerLF13()
  {
    if (this.rgbTimer >= 768 /*0x0300*/)
      this.rgbTimer = 0;
    for (int index = 0; index < 62; ++index)
    {
      this.ledValLF13[62 - index - 1, 0] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 62) % 768 /*0x0300*/, 0];
      this.ledValLF13[62 - index - 1, 1] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 62) % 768 /*0x0300*/, 1];
      this.ledValLF13[62 - index - 1, 2] = this.RGBTable[(this.rgbTimer + index * 768 /*0x0300*/ / 62) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer += 4;
  }

  private void CHMS_Timer_New()
  {
    if (this.rgbTimer2 >= 768 /*0x0300*/)
      this.rgbTimer2 = 0;
    for (int index = 0; index < 18; ++index)
    {
      this.ledValCaihong[18 - index - 1, 0] = this.RGBTable[(this.rgbTimer2 + index * 768 /*0x0300*/ / 18 / 6) % 768 /*0x0300*/, 0];
      this.ledValCaihong[18 - index - 1, 1] = this.RGBTable[(this.rgbTimer2 + index * 768 /*0x0300*/ / 18 / 6) % 768 /*0x0300*/, 1];
      this.ledValCaihong[18 - index - 1, 2] = this.RGBTable[(this.rgbTimer2 + index * 768 /*0x0300*/ / 18 / 6) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer2 += 4;
  }

  private void CHMS_Timer_New_7()
  {
    if (this.rgbTimer2 >= 768 /*0x0300*/)
      this.rgbTimer2 = 0;
    for (int index = 0; index < 12; ++index)
    {
      this.ledValCaihong7[12 - index - 1, 0] = this.RGBTable[(this.rgbTimer2 + index * 768 /*0x0300*/ / 12 / 6) % 768 /*0x0300*/, 0];
      this.ledValCaihong7[12 - index - 1, 1] = this.RGBTable[(this.rgbTimer2 + index * 768 /*0x0300*/ / 12 / 6) % 768 /*0x0300*/, 1];
      this.ledValCaihong7[12 - index - 1, 2] = this.RGBTable[(this.rgbTimer2 + index * 768 /*0x0300*/ / 12 / 6) % 768 /*0x0300*/, 2];
    }
    this.rgbTimer2 += 4;
  }

  private void WDLD_Timer()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage1.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage1.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 10; ++index)
    {
      this.ledVal[index, 0] = num1;
      this.ledVal[index, 1] = num2;
      this.ledVal[index, 2] = num3;
    }
  }

  private void WDLD_Timer4()
  {
    int num1 = this.nowLedStyleSub != (byte) 0 ? (int) ((ArrayList) Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo[this.hardDiskCount - 1])[1] : (int) Form1.formSystemInfo.ucSystemInfo1.MemTemperature;
    byte num2;
    byte num3;
    byte num4;
    if (num1 < 30)
    {
      num2 = (byte) 0;
      num3 = byte.MaxValue;
      num4 = byte.MaxValue;
    }
    else if (num1 < 50)
    {
      num2 = (byte) 0;
      num3 = byte.MaxValue;
      num4 = (byte) 0;
    }
    else if (num1 < 70)
    {
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
      num4 = (byte) 0;
    }
    else if (num1 < 90)
    {
      num2 = byte.MaxValue;
      num3 = (byte) 110;
      num4 = (byte) 0;
    }
    else
    {
      num2 = byte.MaxValue;
      num3 = (byte) 0;
      num4 = (byte) 0;
    }
    for (int index = 0; index < 14; ++index)
    {
      this.ledVal4[index, 0] = num2;
      this.ledVal4[index, 1] = num3;
      this.ledVal4[index, 2] = num4;
    }
  }

  private void WDLD_Timer5()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage1.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage1.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 23; ++index)
    {
      this.ledVal5[index, 0] = num1;
      this.ledVal5[index, 1] = num2;
      this.ledVal5[index, 2] = num3;
    }
  }

  private void WDLD_Timer6()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage1.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage1.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 72; ++index)
    {
      this.ledVal6[index, 0] = num1;
      this.ledVal6[index, 1] = num2;
      this.ledVal6[index, 2] = num3;
    }
  }

  private void WDLD_Timer8()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage1.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage1.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 13; ++index)
    {
      this.ledVal8[index, 0] = num1;
      this.ledVal8[index, 1] = num2;
      this.ledVal8[index, 2] = num3;
    }
  }

  private void WDLD_Timer9()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage1.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage1.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 31 /*0x1F*/; ++index)
    {
      this.ledVal9[index, 0] = num1;
      this.ledVal9[index, 1] = num2;
      this.ledVal9[index, 2] = num3;
    }
  }

  private void WDLD_Timer10()
  {
    int num1 = this.nowLedStyleSub != (byte) 0 ? (int) ((ArrayList) Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo[this.hardDiskCount - 1])[1] : (int) Form1.formSystemInfo.ucSystemInfo1.MemTemperature;
    byte num2;
    byte num3;
    byte num4;
    if (num1 < 30)
    {
      num2 = (byte) 0;
      num3 = byte.MaxValue;
      num4 = byte.MaxValue;
    }
    else if (num1 < 50)
    {
      num2 = (byte) 0;
      num3 = byte.MaxValue;
      num4 = (byte) 0;
    }
    else if (num1 < 70)
    {
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
      num4 = (byte) 0;
    }
    else if (num1 < 90)
    {
      num2 = byte.MaxValue;
      num3 = (byte) 110;
      num4 = (byte) 0;
    }
    else
    {
      num2 = byte.MaxValue;
      num3 = (byte) 0;
      num4 = (byte) 0;
    }
    for (int index = 0; index < 17; ++index)
    {
      this.ledVal10[index, 0] = num2;
      this.ledVal10[index, 1] = num3;
      this.ledVal10[index, 2] = num4;
    }
  }

  private void WDLD_TimerLF15()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage1.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage1.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 72; ++index)
    {
      this.ledValLF15[index, 0] = num1;
      this.ledValLF15[index, 1] = num2;
      this.ledValLF15[index, 2] = num3;
    }
  }

  private void WDLD_TimerLF13()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage1.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage1.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 62; ++index)
    {
      this.ledValLF13[index, 0] = num1;
      this.ledValLF13[index, 1] = num2;
      this.ledValLF13[index, 2] = num3;
    }
  }

  private void WDLD_Timer_New()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage1.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage1.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage1.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    this.ledWendu[0] = num1;
    this.ledWendu[1] = num2;
    this.ledWendu[2] = num3;
  }

  private void FZLD_Timer()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage3.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage3.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 10; ++index)
    {
      this.ledVal[index, 0] = num1;
      this.ledVal[index, 1] = num2;
      this.ledVal[index, 2] = num3;
    }
  }

  private void FZLD_Timer4()
  {
    int num1 = this.nowLedStyleSub != (byte) 0 ? (int) ((ArrayList) Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo[this.hardDiskCount - 1])[2] : (int) Form1.formSystemInfo.ucSystemInfo1.MemLoad;
    byte num2;
    byte num3;
    byte num4;
    if (num1 < 30)
    {
      num2 = (byte) 0;
      num3 = byte.MaxValue;
      num4 = byte.MaxValue;
    }
    else if (num1 < 50)
    {
      num2 = (byte) 0;
      num3 = byte.MaxValue;
      num4 = (byte) 0;
    }
    else if (num1 < 70)
    {
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
      num4 = (byte) 0;
    }
    else if (num1 < 90)
    {
      num2 = byte.MaxValue;
      num3 = (byte) 110;
      num4 = (byte) 0;
    }
    else
    {
      num2 = byte.MaxValue;
      num3 = (byte) 0;
      num4 = (byte) 0;
    }
    for (int index = 0; index < 14; ++index)
    {
      this.ledVal4[index, 0] = num2;
      this.ledVal4[index, 1] = num3;
      this.ledVal4[index, 2] = num4;
    }
  }

  private void FZLD_Timer5()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage3.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage3.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 23; ++index)
    {
      this.ledVal5[index, 0] = num1;
      this.ledVal5[index, 1] = num2;
      this.ledVal5[index, 2] = num3;
    }
  }

  private void FZLD_Timer6()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage3.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage3.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 72; ++index)
    {
      this.ledVal6[index, 0] = num1;
      this.ledVal6[index, 1] = num2;
      this.ledVal6[index, 2] = num3;
    }
  }

  private void FZLD_Timer8()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage3.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage3.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 13; ++index)
    {
      this.ledVal8[index, 0] = num1;
      this.ledVal8[index, 1] = num2;
      this.ledVal8[index, 2] = num3;
    }
  }

  private void FZLD_Timer9()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage3.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage3.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 31 /*0x1F*/; ++index)
    {
      this.ledVal9[index, 0] = num1;
      this.ledVal9[index, 1] = num2;
      this.ledVal9[index, 2] = num3;
    }
  }

  private void FZLD_Timer10()
  {
    int num1 = this.nowLedStyleSub != (byte) 0 ? (int) ((ArrayList) Form1.formSystemInfo.ucSystemInfo1.HardDiskInfo[this.hardDiskCount - 1])[2] : (int) Form1.formSystemInfo.ucSystemInfo1.MemLoad;
    byte num2;
    byte num3;
    byte num4;
    if (num1 < 30)
    {
      num2 = (byte) 0;
      num3 = byte.MaxValue;
      num4 = byte.MaxValue;
    }
    else if (num1 < 50)
    {
      num2 = (byte) 0;
      num3 = byte.MaxValue;
      num4 = (byte) 0;
    }
    else if (num1 < 70)
    {
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
      num4 = (byte) 0;
    }
    else if (num1 < 90)
    {
      num2 = byte.MaxValue;
      num3 = (byte) 110;
      num4 = (byte) 0;
    }
    else
    {
      num2 = byte.MaxValue;
      num3 = (byte) 0;
      num4 = (byte) 0;
    }
    for (int index = 0; index < 17; ++index)
    {
      this.ledVal10[index, 0] = num2;
      this.ledVal10[index, 1] = num3;
      this.ledVal10[index, 2] = num4;
    }
  }

  private void FZLD_TimerLF15()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage3.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage3.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 72; ++index)
    {
      this.ledValLF15[index, 0] = num1;
      this.ledValLF15[index, 1] = num2;
      this.ledValLF15[index, 2] = num3;
    }
  }

  private void FZLD_TimerLF13()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage3.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage3.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    for (int index = 0; index < 62; ++index)
    {
      this.ledValLF13[index, 0] = num1;
      this.ledValLF13[index, 1] = num2;
      this.ledValLF13[index, 2] = num3;
    }
  }

  private void FZLD_Timer_New()
  {
    byte num1;
    byte num2;
    byte num3;
    if (this.ucInfoImage3.myVal < 30)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = byte.MaxValue;
    }
    else if (this.ucInfoImage3.myVal < 50)
    {
      num1 = (byte) 0;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 70)
    {
      num1 = byte.MaxValue;
      num2 = byte.MaxValue;
      num3 = (byte) 0;
    }
    else if (this.ucInfoImage3.myVal < 90)
    {
      num1 = byte.MaxValue;
      num2 = (byte) 110;
      num3 = (byte) 0;
    }
    else
    {
      num1 = byte.MaxValue;
      num2 = (byte) 0;
      num3 = (byte) 0;
    }
    this.ledFuzai[0] = num1;
    this.ledFuzai[1] = num2;
    this.ledFuzai[2] = num3;
  }

  private void LedValToScreenLed()
  {
    // ISSUE: The method is too long to display (85448 instructions)
  }

  private void FormLED_MouseDown(object sender, MouseEventArgs e)
  {
    FormLED.delegateFormLED delegateForm = this.delegateForm;
    if (delegateForm == null)
      return;
    delegateForm(241, data: (object) e);
  }

  private void FormLED_MouseMove(object sender, MouseEventArgs e)
  {
    FormLED.delegateFormLED delegateForm = this.delegateForm;
    if (delegateForm == null)
      return;
    delegateForm(242, data: (object) e);
  }

  private void FormLED_MouseUp(object sender, MouseEventArgs e)
  {
    FormLED.delegateFormLED delegateForm = this.delegateForm;
    if (delegateForm == null)
      return;
    delegateForm(243, data: (object) e);
  }

  private void buttonPower_Click(object sender, EventArgs e)
  {
    FormLED.delegateFormLED delegateForm = this.delegateForm;
    if (delegateForm == null)
      return;
    delegateForm((int) byte.MaxValue);
  }

  private void textBoxTimer_KeyPress(object sender, KeyPressEventArgs e)
  {
    if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
      return;
    e.Handled = true;
  }

  private void textBoxTimer_TextChanged(object sender, EventArgs e)
  {
    if (!this.isSaveTimer || this.textBoxTimer.Text.Length <= 0)
      return;
    this.SetMyNameFile();
  }

  private void textBoxR_TextChanged(object sender, EventArgs e)
  {
    if (!this.isSaveTimer || this.textBoxR.Text.Length <= 0)
      return;
    if (Convert.ToInt32(this.textBoxR.Text) > (int) byte.MaxValue)
    {
      this.textBoxR.Text = "255";
    }
    else
    {
      this.ucScrollRDelegate(Convert.ToInt32(this.textBoxR.Text));
      this.ucScrollAR.SetUCScrollA(this.rgbR1);
    }
  }

  private void textBoxG_TextChanged(object sender, EventArgs e)
  {
    if (!this.isSaveTimer || this.textBoxG.Text.Length <= 0)
      return;
    if (Convert.ToInt32(this.textBoxG.Text) > (int) byte.MaxValue)
    {
      this.textBoxG.Text = "255";
    }
    else
    {
      this.ucScrollGDelegate(Convert.ToInt32(this.textBoxG.Text));
      this.ucScrollAG.SetUCScrollA(this.rgbG1);
    }
  }

  private void textBoxB_TextChanged(object sender, EventArgs e)
  {
    if (!this.isSaveTimer || this.textBoxB.Text.Length <= 0)
      return;
    if (Convert.ToInt32(this.textBoxB.Text) > (int) byte.MaxValue)
    {
      this.textBoxB.Text = "255";
    }
    else
    {
      this.ucScrollBDelegate(Convert.ToInt32(this.textBoxB.Text));
      this.ucScrollAB.SetUCScrollA(this.rgbB1);
    }
  }

  private void ButtonH24orH12(bool bl)
  {
    this.isTimer24 = bl;
    if (bl)
    {
      this.buttonH24.BackgroundImage = (Image) Resources.P点选框A;
      this.buttonH12.BackgroundImage = (Image) Resources.P点选框;
    }
    else
    {
      this.buttonH24.BackgroundImage = (Image) Resources.P点选框;
      this.buttonH12.BackgroundImage = (Image) Resources.P点选框A;
    }
  }

  private void buttonH24_Click(object sender, EventArgs e)
  {
    this.ButtonH24orH12(true);
    this.SetMyNameFile();
  }

  private void buttonH12_Click(object sender, EventArgs e)
  {
    this.ButtonH24orH12(false);
    this.SetMyNameFile();
  }

  private void ButtonWeek(bool bl)
  {
    this.isWeekSun = bl;
    if (bl)
    {
      this.buttonWeek7.BackgroundImage = (Image) Resources.P点选框A;
      this.buttonWeek1.BackgroundImage = (Image) Resources.P点选框;
    }
    else
    {
      this.buttonWeek7.BackgroundImage = (Image) Resources.P点选框;
      this.buttonWeek1.BackgroundImage = (Image) Resources.P点选框A;
    }
  }

  private void buttonWeek1_Click(object sender, EventArgs e)
  {
    this.ButtonWeek(false);
    this.SetMyNameFile();
  }

  private void buttonWeek7_Click(object sender, EventArgs e)
  {
    this.ButtonWeek(true);
    this.SetMyNameFile();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormLED));
    this.buttonC = new Button();
    this.buttonF = new Button();
    this.buttonDSHX = new Button();
    this.buttonDSCL = new Button();
    this.buttonQCJB = new Button();
    this.buttonCHMS = new Button();
    this.buttonWDLD = new Button();
    this.buttonFZLD = new Button();
    this.labelB = new Label();
    this.labelG = new Label();
    this.labelR = new Label();
    this.buttonC8 = new Button();
    this.buttonC7 = new Button();
    this.buttonC6 = new Button();
    this.buttonC5 = new Button();
    this.buttonC4 = new Button();
    this.buttonC3 = new Button();
    this.buttonC2 = new Button();
    this.buttonC1 = new Button();
    this.buttonLB = new Button();
    this.button4 = new Button();
    this.button1 = new Button();
    this.button2 = new Button();
    this.button3 = new Button();
    this.buttonPower = new Button();
    this.textBoxTimer = new TextBox();
    this.checkBox1 = new CheckBox();
    this.button5 = new Button();
    this.button6 = new Button();
    this.textBoxR = new TextBox();
    this.textBoxG = new TextBox();
    this.textBoxB = new TextBox();
    this.buttonN1 = new Button();
    this.buttonN2 = new Button();
    this.buttonN3 = new Button();
    this.buttonN4 = new Button();
    this.buttonH24 = new Button();
    this.buttonH12 = new Button();
    this.buttonWeek7 = new Button();
    this.buttonWeek1 = new Button();
    this.ucScrollAB = new UCScrollA();
    this.ucScrollAG = new UCScrollA();
    this.ucScrollAR = new UCScrollA();
    this.ucInfoImage6 = new UCInfoImage();
    this.ucInfoImage5 = new UCInfoImage();
    this.ucInfoImage4 = new UCInfoImage();
    this.ucInfoImage3 = new UCInfoImage();
    this.ucInfoImage2 = new UCInfoImage();
    this.ucInfoImage1 = new UCInfoImage();
    this.ucScrollA = new UCScrollA();
    this.ucColorA1 = new UCColorA();
    this.ucScreenLED1 = new UCScreenLED();
    this.ucledHarddiskInfo1 = new UCLEDHarddiskInfo();
    this.ucledMemoryInfo1 = new UCLEDMemoryInfo();
    this.SuspendLayout();
    this.buttonC.BackColor = Color.Transparent;
    this.buttonC.BackgroundImage = (Image) Resources.P点选框A;
    this.buttonC.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC.FlatAppearance.BorderSize = 0;
    this.buttonC.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC.FlatStyle = FlatStyle.Flat;
    this.buttonC.Location = new Point(699, 144 /*0x90*/);
    this.buttonC.Margin = new Padding(0);
    this.buttonC.Name = "buttonC";
    this.buttonC.Size = new Size(14, 14);
    this.buttonC.TabIndex = 667;
    this.buttonC.UseVisualStyleBackColor = false;
    this.buttonC.Visible = false;
    this.buttonC.Click += new EventHandler(this.buttonC_Click);
    this.buttonF.BackColor = Color.Transparent;
    this.buttonF.BackgroundImage = (Image) Resources.P点选框;
    this.buttonF.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonF.FlatAppearance.BorderSize = 0;
    this.buttonF.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonF.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonF.FlatStyle = FlatStyle.Flat;
    this.buttonF.Location = new Point(759, 144 /*0x90*/);
    this.buttonF.Margin = new Padding(0);
    this.buttonF.Name = "buttonF";
    this.buttonF.Size = new Size(14, 14);
    this.buttonF.TabIndex = 668;
    this.buttonF.UseVisualStyleBackColor = false;
    this.buttonF.Visible = false;
    this.buttonF.Click += new EventHandler(this.buttonF_Click);
    this.buttonDSHX.BackColor = Color.Transparent;
    this.buttonDSHX.BackgroundImage = (Image) Resources.D2灯光2;
    this.buttonDSHX.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDSHX.FlatAppearance.BorderSize = 0;
    this.buttonDSHX.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDSHX.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDSHX.FlatStyle = FlatStyle.Flat;
    this.buttonDSHX.Location = new Point(693, 227);
    this.buttonDSHX.Margin = new Padding(0);
    this.buttonDSHX.Name = "buttonDSHX";
    this.buttonDSHX.Size = new Size(93, 62);
    this.buttonDSHX.TabIndex = 670;
    this.buttonDSHX.UseVisualStyleBackColor = false;
    this.buttonDSHX.Click += new EventHandler(this.buttonDSHX_Click);
    this.buttonDSCL.BackColor = Color.Transparent;
    this.buttonDSCL.BackgroundImage = (Image) Resources.D2灯光1;
    this.buttonDSCL.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonDSCL.FlatAppearance.BorderSize = 0;
    this.buttonDSCL.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonDSCL.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonDSCL.FlatStyle = FlatStyle.Flat;
    this.buttonDSCL.Location = new Point(590, 227);
    this.buttonDSCL.Margin = new Padding(0);
    this.buttonDSCL.Name = "buttonDSCL";
    this.buttonDSCL.Size = new Size(93, 62);
    this.buttonDSCL.TabIndex = 669;
    this.buttonDSCL.UseVisualStyleBackColor = false;
    this.buttonDSCL.Click += new EventHandler(this.buttonDSCL_Click);
    this.buttonQCJB.BackColor = Color.Transparent;
    this.buttonQCJB.BackgroundImage = (Image) Resources.D2灯光3;
    this.buttonQCJB.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonQCJB.FlatAppearance.BorderSize = 0;
    this.buttonQCJB.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonQCJB.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonQCJB.FlatStyle = FlatStyle.Flat;
    this.buttonQCJB.Location = new Point(796, 227);
    this.buttonQCJB.Margin = new Padding(0);
    this.buttonQCJB.Name = "buttonQCJB";
    this.buttonQCJB.Size = new Size(93, 62);
    this.buttonQCJB.TabIndex = 671;
    this.buttonQCJB.UseVisualStyleBackColor = false;
    this.buttonQCJB.Click += new EventHandler(this.buttonQCJB_Click);
    this.buttonCHMS.BackColor = Color.Transparent;
    this.buttonCHMS.BackgroundImage = (Image) Resources.D2灯光4a;
    this.buttonCHMS.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonCHMS.FlatAppearance.BorderSize = 0;
    this.buttonCHMS.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonCHMS.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonCHMS.FlatStyle = FlatStyle.Flat;
    this.buttonCHMS.Location = new Point(899, 227);
    this.buttonCHMS.Margin = new Padding(0);
    this.buttonCHMS.Name = "buttonCHMS";
    this.buttonCHMS.Size = new Size(93, 62);
    this.buttonCHMS.TabIndex = 672;
    this.buttonCHMS.UseVisualStyleBackColor = false;
    this.buttonCHMS.Click += new EventHandler(this.buttonCHMS_Click);
    this.buttonWDLD.BackColor = Color.Transparent;
    this.buttonWDLD.BackgroundImage = (Image) Resources.D2灯光5;
    this.buttonWDLD.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWDLD.FlatAppearance.BorderSize = 0;
    this.buttonWDLD.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWDLD.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWDLD.FlatStyle = FlatStyle.Flat;
    this.buttonWDLD.Location = new Point(1002, 227);
    this.buttonWDLD.Margin = new Padding(0);
    this.buttonWDLD.Name = "buttonWDLD";
    this.buttonWDLD.Size = new Size(93, 62);
    this.buttonWDLD.TabIndex = 673;
    this.buttonWDLD.UseVisualStyleBackColor = false;
    this.buttonWDLD.Click += new EventHandler(this.buttonWDLD_Click);
    this.buttonFZLD.BackColor = Color.Transparent;
    this.buttonFZLD.BackgroundImage = (Image) Resources.D2灯光6;
    this.buttonFZLD.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonFZLD.FlatAppearance.BorderSize = 0;
    this.buttonFZLD.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonFZLD.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonFZLD.FlatStyle = FlatStyle.Flat;
    this.buttonFZLD.Location = new Point(1105, 227);
    this.buttonFZLD.Margin = new Padding(0);
    this.buttonFZLD.Name = "buttonFZLD";
    this.buttonFZLD.Size = new Size(93, 62);
    this.buttonFZLD.TabIndex = 674;
    this.buttonFZLD.UseVisualStyleBackColor = false;
    this.buttonFZLD.Click += new EventHandler(this.buttonFZLD_Click);
    this.labelB.BackColor = Color.Transparent;
    this.labelB.FlatStyle = FlatStyle.Flat;
    this.labelB.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelB.ForeColor = Color.White;
    this.labelB.Location = new Point(1150, 134);
    this.labelB.Margin = new Padding(0);
    this.labelB.Name = "labelB";
    this.labelB.Size = new Size(47, 24);
    this.labelB.TabIndex = 681;
    this.labelB.Text = "0";
    this.labelB.TextAlign = ContentAlignment.MiddleCenter;
    this.labelB.Visible = false;
    this.labelG.BackColor = Color.Transparent;
    this.labelG.FlatStyle = FlatStyle.Flat;
    this.labelG.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelG.ForeColor = Color.White;
    this.labelG.Location = new Point(1081, 134);
    this.labelG.Margin = new Padding(0);
    this.labelG.Name = "labelG";
    this.labelG.Size = new Size(47, 24);
    this.labelG.TabIndex = 680;
    this.labelG.Text = "0";
    this.labelG.TextAlign = ContentAlignment.MiddleCenter;
    this.labelG.Visible = false;
    this.labelR.BackColor = Color.Transparent;
    this.labelR.FlatStyle = FlatStyle.Flat;
    this.labelR.Font = new Font("微软雅黑", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.labelR.ForeColor = Color.White;
    this.labelR.Location = new Point(1012, 134);
    this.labelR.Margin = new Padding(0);
    this.labelR.Name = "labelR";
    this.labelR.Size = new Size(47, 24);
    this.labelR.TabIndex = 679;
    this.labelR.Text = "255";
    this.labelR.TextAlign = ContentAlignment.MiddleCenter;
    this.labelR.Visible = false;
    this.buttonC8.BackColor = Color.Transparent;
    this.buttonC8.BackgroundImage = (Image) Resources.D3白;
    this.buttonC8.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC8.FlatAppearance.BorderSize = 0;
    this.buttonC8.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC8.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC8.FlatStyle = FlatStyle.Flat;
    this.buttonC8.Location = new Point(1142, 444);
    this.buttonC8.Margin = new Padding(0);
    this.buttonC8.Name = "buttonC8";
    this.buttonC8.Size = new Size(24, 24);
    this.buttonC8.TabIndex = 689;
    this.buttonC8.UseVisualStyleBackColor = false;
    this.buttonC8.Click += new EventHandler(this.buttonC8_Click);
    this.buttonC7.BackColor = Color.Transparent;
    this.buttonC7.BackgroundImage = (Image) Resources.D3紫;
    this.buttonC7.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC7.FlatAppearance.BorderSize = 0;
    this.buttonC7.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC7.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC7.FlatStyle = FlatStyle.Flat;
    this.buttonC7.Location = new Point(1108, 444);
    this.buttonC7.Margin = new Padding(0);
    this.buttonC7.Name = "buttonC7";
    this.buttonC7.Size = new Size(24, 24);
    this.buttonC7.TabIndex = 688;
    this.buttonC7.UseVisualStyleBackColor = false;
    this.buttonC7.Click += new EventHandler(this.buttonC7_Click);
    this.buttonC6.BackColor = Color.Transparent;
    this.buttonC6.BackgroundImage = (Image) Resources.D3蓝;
    this.buttonC6.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC6.FlatAppearance.BorderSize = 0;
    this.buttonC6.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC6.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC6.FlatStyle = FlatStyle.Flat;
    this.buttonC6.Location = new Point(1073, 444);
    this.buttonC6.Margin = new Padding(0);
    this.buttonC6.Name = "buttonC6";
    this.buttonC6.Size = new Size(24, 24);
    this.buttonC6.TabIndex = 687;
    this.buttonC6.UseVisualStyleBackColor = false;
    this.buttonC6.Click += new EventHandler(this.buttonC6_Click);
    this.buttonC5.BackColor = Color.Transparent;
    this.buttonC5.BackgroundImage = (Image) Resources.D3湖;
    this.buttonC5.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC5.FlatAppearance.BorderSize = 0;
    this.buttonC5.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC5.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC5.FlatStyle = FlatStyle.Flat;
    this.buttonC5.Location = new Point(1039, 444);
    this.buttonC5.Margin = new Padding(0);
    this.buttonC5.Name = "buttonC5";
    this.buttonC5.Size = new Size(24, 24);
    this.buttonC5.TabIndex = 686;
    this.buttonC5.UseVisualStyleBackColor = false;
    this.buttonC5.Click += new EventHandler(this.buttonC5_Click);
    this.buttonC4.BackColor = Color.Transparent;
    this.buttonC4.BackgroundImage = (Image) Resources.D3绿;
    this.buttonC4.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC4.FlatAppearance.BorderSize = 0;
    this.buttonC4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC4.FlatStyle = FlatStyle.Flat;
    this.buttonC4.Location = new Point(1004, 444);
    this.buttonC4.Margin = new Padding(0);
    this.buttonC4.Name = "buttonC4";
    this.buttonC4.Size = new Size(24, 24);
    this.buttonC4.TabIndex = 685;
    this.buttonC4.UseVisualStyleBackColor = false;
    this.buttonC4.Click += new EventHandler(this.buttonC4_Click);
    this.buttonC3.BackColor = Color.Transparent;
    this.buttonC3.BackgroundImage = (Image) Resources.D3黄;
    this.buttonC3.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC3.FlatAppearance.BorderSize = 0;
    this.buttonC3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC3.FlatStyle = FlatStyle.Flat;
    this.buttonC3.Location = new Point(970, 444);
    this.buttonC3.Margin = new Padding(0);
    this.buttonC3.Name = "buttonC3";
    this.buttonC3.Size = new Size(24, 24);
    this.buttonC3.TabIndex = 684;
    this.buttonC3.UseVisualStyleBackColor = false;
    this.buttonC3.Click += new EventHandler(this.buttonC3_Click);
    this.buttonC2.BackColor = Color.Transparent;
    this.buttonC2.BackgroundImage = (Image) Resources.D3橙;
    this.buttonC2.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC2.FlatAppearance.BorderSize = 0;
    this.buttonC2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC2.FlatStyle = FlatStyle.Flat;
    this.buttonC2.Location = new Point(935, 444);
    this.buttonC2.Margin = new Padding(0);
    this.buttonC2.Name = "buttonC2";
    this.buttonC2.Size = new Size(24, 24);
    this.buttonC2.TabIndex = 683;
    this.buttonC2.UseVisualStyleBackColor = false;
    this.buttonC2.Click += new EventHandler(this.buttonC2_Click);
    this.buttonC1.BackColor = Color.Transparent;
    this.buttonC1.BackgroundImage = (Image) Resources.D3红;
    this.buttonC1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC1.FlatAppearance.BorderSize = 0;
    this.buttonC1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC1.FlatStyle = FlatStyle.Flat;
    this.buttonC1.Location = new Point(901, 444);
    this.buttonC1.Margin = new Padding(0);
    this.buttonC1.Name = "buttonC1";
    this.buttonC1.Size = new Size(24, 24);
    this.buttonC1.TabIndex = 682;
    this.buttonC1.UseVisualStyleBackColor = false;
    this.buttonC1.Click += new EventHandler(this.buttonC1_Click);
    this.buttonLB.BackColor = Color.Transparent;
    this.buttonLB.BackgroundImage = (Image) Resources.P点选框;
    this.buttonLB.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonLB.FlatAppearance.BorderSize = 0;
    this.buttonLB.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonLB.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonLB.FlatStyle = FlatStyle.Flat;
    this.buttonLB.Location = new Point(739, 680);
    this.buttonLB.Margin = new Padding(0);
    this.buttonLB.Name = "buttonLB";
    this.buttonLB.Size = new Size(14, 14);
    this.buttonLB.TabIndex = 691;
    this.buttonLB.UseVisualStyleBackColor = false;
    this.buttonLB.Click += new EventHandler(this.buttonLB_Click);
    this.button4.BackColor = Color.Transparent;
    this.button4.BackgroundImage = (Image) Resources.D4模式4;
    this.button4.BackgroundImageLayout = ImageLayout.Stretch;
    this.button4.FlatAppearance.BorderSize = 0;
    this.button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button4.FlatStyle = FlatStyle.Flat;
    this.button4.Location = new Point(1058, 707);
    this.button4.Margin = new Padding(0);
    this.button4.Name = "button4";
    this.button4.Size = new Size(140, 50);
    this.button4.TabIndex = 692;
    this.button4.UseVisualStyleBackColor = false;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.button1.BackColor = Color.Transparent;
    this.button1.BackgroundImage = (Image) Resources.D4模式1a;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(590, 707);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(140, 50);
    this.button1.TabIndex = 693;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button2.BackColor = Color.Transparent;
    this.button2.BackgroundImage = (Image) Resources.D4模式2;
    this.button2.BackgroundImageLayout = ImageLayout.Stretch;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Location = new Point(748, 707);
    this.button2.Margin = new Padding(0);
    this.button2.Name = "button2";
    this.button2.Size = new Size(140, 50);
    this.button2.TabIndex = 694;
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button3.BackColor = Color.Transparent;
    this.button3.BackgroundImage = (Image) Resources.D4模式3;
    this.button3.BackgroundImageLayout = ImageLayout.Stretch;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Location = new Point(902, 707);
    this.button3.Margin = new Padding(0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(140, 50);
    this.button3.TabIndex = 695;
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.buttonPower.BackColor = Color.Transparent;
    this.buttonPower.BackgroundImage = (Image) Resources.Alogout默认;
    this.buttonPower.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonPower.FlatAppearance.BorderSize = 0;
    this.buttonPower.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonPower.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonPower.FlatStyle = FlatStyle.Flat;
    this.buttonPower.Location = new Point(1212, 24);
    this.buttonPower.Margin = new Padding(0);
    this.buttonPower.Name = "buttonPower";
    this.buttonPower.Size = new Size(40, 40);
    this.buttonPower.TabIndex = 702;
    this.buttonPower.UseVisualStyleBackColor = false;
    this.buttonPower.Click += new EventHandler(this.buttonPower_Click);
    this.textBoxTimer.BackColor = Color.FromArgb(67, 67, 67);
    this.textBoxTimer.BorderStyle = BorderStyle.None;
    this.textBoxTimer.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxTimer.ForeColor = Color.White;
    this.textBoxTimer.ImeMode = ImeMode.NoControl;
    this.textBoxTimer.Location = new Point(843, 678);
    this.textBoxTimer.MaxLength = 2;
    this.textBoxTimer.Name = "textBoxTimer";
    this.textBoxTimer.Size = new Size(36, 16 /*0x10*/);
    this.textBoxTimer.TabIndex = 703;
    this.textBoxTimer.Text = "2";
    this.textBoxTimer.TextAlign = HorizontalAlignment.Center;
    this.textBoxTimer.TextChanged += new EventHandler(this.textBoxTimer_TextChanged);
    this.textBoxTimer.KeyPress += new KeyPressEventHandler(this.textBoxTimer_KeyPress);
    this.checkBox1.AutoSize = true;
    this.checkBox1.BackColor = Color.Transparent;
    this.checkBox1.ForeColor = Color.White;
    this.checkBox1.Location = new Point(36, 78);
    this.checkBox1.Name = "checkBox1";
    this.checkBox1.Size = new Size(72, 16 /*0x10*/);
    this.checkBox1.TabIndex = 704;
    this.checkBox1.Text = "测试模式";
    this.checkBox1.UseVisualStyleBackColor = false;
    this.checkBox1.Visible = false;
    this.button5.BackColor = Color.Transparent;
    this.button5.BackgroundImage = (Image) Resources.D4模式5a;
    this.button5.BackgroundImageLayout = ImageLayout.Stretch;
    this.button5.FlatAppearance.BorderSize = 0;
    this.button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button5.FlatStyle = FlatStyle.Flat;
    this.button5.Location = new Point(590, 748);
    this.button5.Margin = new Padding(0);
    this.button5.Name = "button5";
    this.button5.Size = new Size(140, 50);
    this.button5.TabIndex = 705;
    this.button5.UseVisualStyleBackColor = false;
    this.button5.Visible = false;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.button6.BackColor = Color.Transparent;
    this.button6.BackgroundImage = (Image) Resources.D4模式6;
    this.button6.BackgroundImageLayout = ImageLayout.Stretch;
    this.button6.FlatAppearance.BorderSize = 0;
    this.button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button6.FlatStyle = FlatStyle.Flat;
    this.button6.Location = new Point(748, 748);
    this.button6.Margin = new Padding(0);
    this.button6.Name = "button6";
    this.button6.Size = new Size(140, 50);
    this.button6.TabIndex = 706;
    this.button6.UseVisualStyleBackColor = false;
    this.button6.Visible = false;
    this.button6.Click += new EventHandler(this.button6_Click);
    this.textBoxR.BackColor = Color.FromArgb(67, 67, 67);
    this.textBoxR.BorderStyle = BorderStyle.None;
    this.textBoxR.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxR.ForeColor = Color.White;
    this.textBoxR.ImeMode = ImeMode.NoControl;
    this.textBoxR.Location = new Point(926, 333);
    this.textBoxR.MaxLength = 3;
    this.textBoxR.Name = "textBoxR";
    this.textBoxR.Size = new Size(47, 19);
    this.textBoxR.TabIndex = 707;
    this.textBoxR.Text = "255";
    this.textBoxR.TextAlign = HorizontalAlignment.Center;
    this.textBoxR.TextChanged += new EventHandler(this.textBoxR_TextChanged);
    this.textBoxR.KeyPress += new KeyPressEventHandler(this.textBoxTimer_KeyPress);
    this.textBoxG.BackColor = Color.FromArgb(67, 67, 67);
    this.textBoxG.BorderStyle = BorderStyle.None;
    this.textBoxG.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxG.ForeColor = Color.White;
    this.textBoxG.ImeMode = ImeMode.NoControl;
    this.textBoxG.Location = new Point(926, 363);
    this.textBoxG.MaxLength = 3;
    this.textBoxG.Name = "textBoxG";
    this.textBoxG.Size = new Size(47, 19);
    this.textBoxG.TabIndex = 708;
    this.textBoxG.Text = "0";
    this.textBoxG.TextAlign = HorizontalAlignment.Center;
    this.textBoxG.TextChanged += new EventHandler(this.textBoxG_TextChanged);
    this.textBoxG.KeyPress += new KeyPressEventHandler(this.textBoxTimer_KeyPress);
    this.textBoxB.BackColor = Color.FromArgb(67, 67, 67);
    this.textBoxB.BorderStyle = BorderStyle.None;
    this.textBoxB.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxB.ForeColor = Color.White;
    this.textBoxB.ImeMode = ImeMode.NoControl;
    this.textBoxB.Location = new Point(926, 393);
    this.textBoxB.MaxLength = 3;
    this.textBoxB.Name = "textBoxB";
    this.textBoxB.Size = new Size(47, 19);
    this.textBoxB.TabIndex = 709;
    this.textBoxB.Text = "0";
    this.textBoxB.TextAlign = HorizontalAlignment.Center;
    this.textBoxB.TextChanged += new EventHandler(this.textBoxB_TextChanged);
    this.textBoxB.KeyPress += new KeyPressEventHandler(this.textBoxTimer_KeyPress);
    this.buttonN1.BackColor = Color.Transparent;
    this.buttonN1.BackgroundImage = (Image) Resources.D4按钮1a;
    this.buttonN1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonN1.FlatAppearance.BorderSize = 0;
    this.buttonN1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonN1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonN1.FlatStyle = FlatStyle.Flat;
    this.buttonN1.Location = new Point(590, 626);
    this.buttonN1.Margin = new Padding(0);
    this.buttonN1.Name = "buttonN1";
    this.buttonN1.Size = new Size(140, 50);
    this.buttonN1.TabIndex = 710;
    this.buttonN1.UseVisualStyleBackColor = false;
    this.buttonN1.Visible = false;
    this.buttonN1.Click += new EventHandler(this.buttonN1_Click);
    this.buttonN2.BackColor = Color.Transparent;
    this.buttonN2.BackgroundImage = (Image) Resources.D4按钮2;
    this.buttonN2.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonN2.FlatAppearance.BorderSize = 0;
    this.buttonN2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonN2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonN2.FlatStyle = FlatStyle.Flat;
    this.buttonN2.Location = new Point(748, 626);
    this.buttonN2.Margin = new Padding(0);
    this.buttonN2.Name = "buttonN2";
    this.buttonN2.Size = new Size(140, 50);
    this.buttonN2.TabIndex = 711;
    this.buttonN2.UseVisualStyleBackColor = false;
    this.buttonN2.Visible = false;
    this.buttonN2.Click += new EventHandler(this.buttonN2_Click);
    this.buttonN3.BackColor = Color.Transparent;
    this.buttonN3.BackgroundImage = (Image) Resources.D4按钮3;
    this.buttonN3.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonN3.FlatAppearance.BorderSize = 0;
    this.buttonN3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonN3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonN3.FlatStyle = FlatStyle.Flat;
    this.buttonN3.Location = new Point(902, 626);
    this.buttonN3.Margin = new Padding(0);
    this.buttonN3.Name = "buttonN3";
    this.buttonN3.Size = new Size(140, 50);
    this.buttonN3.TabIndex = 712;
    this.buttonN3.UseVisualStyleBackColor = false;
    this.buttonN3.Visible = false;
    this.buttonN3.Click += new EventHandler(this.buttonN3_Click);
    this.buttonN4.BackColor = Color.Transparent;
    this.buttonN4.BackgroundImage = (Image) Resources.D4按钮4;
    this.buttonN4.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonN4.FlatAppearance.BorderSize = 0;
    this.buttonN4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonN4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonN4.FlatStyle = FlatStyle.Flat;
    this.buttonN4.Location = new Point(1058, 626);
    this.buttonN4.Margin = new Padding(0);
    this.buttonN4.Name = "buttonN4";
    this.buttonN4.Size = new Size(140, 50);
    this.buttonN4.TabIndex = 713;
    this.buttonN4.UseVisualStyleBackColor = false;
    this.buttonN4.Visible = false;
    this.buttonN4.Click += new EventHandler(this.buttonN4_Click);
    this.buttonH24.BackColor = Color.Transparent;
    this.buttonH24.BackgroundImage = (Image) Resources.P点选框A;
    this.buttonH24.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonH24.FlatAppearance.BorderSize = 0;
    this.buttonH24.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonH24.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonH24.FlatStyle = FlatStyle.Flat;
    this.buttonH24.Location = new Point(592, 711);
    this.buttonH24.Margin = new Padding(0);
    this.buttonH24.Name = "buttonH24";
    this.buttonH24.Size = new Size(14, 14);
    this.buttonH24.TabIndex = 716;
    this.buttonH24.UseVisualStyleBackColor = false;
    this.buttonH24.Visible = false;
    this.buttonH24.Click += new EventHandler(this.buttonH24_Click);
    this.buttonH12.BackColor = Color.Transparent;
    this.buttonH12.BackgroundImage = (Image) Resources.P点选框;
    this.buttonH12.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonH12.FlatAppearance.BorderSize = 0;
    this.buttonH12.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonH12.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonH12.FlatStyle = FlatStyle.Flat;
    this.buttonH12.Location = new Point(592, 729);
    this.buttonH12.Margin = new Padding(0);
    this.buttonH12.Name = "buttonH12";
    this.buttonH12.Size = new Size(14, 14);
    this.buttonH12.TabIndex = 717;
    this.buttonH12.UseVisualStyleBackColor = false;
    this.buttonH12.Visible = false;
    this.buttonH12.Click += new EventHandler(this.buttonH12_Click);
    this.buttonWeek7.BackColor = Color.Transparent;
    this.buttonWeek7.BackgroundImage = (Image) Resources.P点选框A;
    this.buttonWeek7.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWeek7.FlatAppearance.BorderSize = 0;
    this.buttonWeek7.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWeek7.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWeek7.FlatStyle = FlatStyle.Flat;
    this.buttonWeek7.Location = new Point(741, 729);
    this.buttonWeek7.Margin = new Padding(0);
    this.buttonWeek7.Name = "buttonWeek7";
    this.buttonWeek7.Size = new Size(14, 14);
    this.buttonWeek7.TabIndex = 719;
    this.buttonWeek7.UseVisualStyleBackColor = false;
    this.buttonWeek7.Visible = false;
    this.buttonWeek7.Click += new EventHandler(this.buttonWeek7_Click);
    this.buttonWeek1.BackColor = Color.Transparent;
    this.buttonWeek1.BackgroundImage = (Image) Resources.P点选框;
    this.buttonWeek1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonWeek1.FlatAppearance.BorderSize = 0;
    this.buttonWeek1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonWeek1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonWeek1.FlatStyle = FlatStyle.Flat;
    this.buttonWeek1.Location = new Point(741, 711);
    this.buttonWeek1.Margin = new Padding(0);
    this.buttonWeek1.Name = "buttonWeek1";
    this.buttonWeek1.Size = new Size(14, 14);
    this.buttonWeek1.TabIndex = 718;
    this.buttonWeek1.UseVisualStyleBackColor = false;
    this.buttonWeek1.Visible = false;
    this.buttonWeek1.Click += new EventHandler(this.buttonWeek1_Click);
    this.ucScrollAB.BackColor = Color.Transparent;
    this.ucScrollAB.BackgroundImageLayout = ImageLayout.None;
    this.ucScrollAB.Location = new Point(976, 393);
    this.ucScrollAB.Margin = new Padding(0);
    this.ucScrollAB.Name = "ucScrollAB";
    this.ucScrollAB.Size = new Size(190, 20);
    this.ucScrollAB.TabIndex = 678;
    this.ucScrollAG.BackColor = Color.Transparent;
    this.ucScrollAG.BackgroundImageLayout = ImageLayout.None;
    this.ucScrollAG.Location = new Point(976, 363);
    this.ucScrollAG.Margin = new Padding(0);
    this.ucScrollAG.Name = "ucScrollAG";
    this.ucScrollAG.Size = new Size(190, 20);
    this.ucScrollAG.TabIndex = 677;
    this.ucScrollAR.BackColor = Color.Transparent;
    this.ucScrollAR.BackgroundImageLayout = ImageLayout.None;
    this.ucScrollAR.Location = new Point(976, 333);
    this.ucScrollAR.Margin = new Padding(0);
    this.ucScrollAR.Name = "ucScrollAR";
    this.ucScrollAR.Size = new Size(190, 20);
    this.ucScrollAR.TabIndex = 676;
    this.ucInfoImage6.BackColor = Color.Transparent;
    this.ucInfoImage6.BackgroundImage = (Image) Resources.P0M6;
    this.ucInfoImage6.Location = new Point(276, 755);
    this.ucInfoImage6.Margin = new Padding(0);
    this.ucInfoImage6.Name = "ucInfoImage6";
    this.ucInfoImage6.Size = new Size(240 /*0xF0*/, 30);
    this.ucInfoImage6.TabIndex = 701;
    this.ucInfoImage6.Visible = false;
    this.ucInfoImage5.BackColor = Color.Transparent;
    this.ucInfoImage5.BackgroundImage = (Image) Resources.P0M5;
    this.ucInfoImage5.Location = new Point(276, 707);
    this.ucInfoImage5.Margin = new Padding(0);
    this.ucInfoImage5.Name = "ucInfoImage5";
    this.ucInfoImage5.Size = new Size(240 /*0xF0*/, 30);
    this.ucInfoImage5.TabIndex = 700;
    this.ucInfoImage5.Visible = false;
    this.ucInfoImage4.BackColor = Color.Transparent;
    this.ucInfoImage4.BackgroundImage = (Image) Resources.P0M4;
    this.ucInfoImage4.Location = new Point(276, 659);
    this.ucInfoImage4.Margin = new Padding(0);
    this.ucInfoImage4.Name = "ucInfoImage4";
    this.ucInfoImage4.Size = new Size(240 /*0xF0*/, 30);
    this.ucInfoImage4.TabIndex = 699;
    this.ucInfoImage4.Visible = false;
    this.ucInfoImage3.BackColor = Color.Transparent;
    this.ucInfoImage3.BackgroundImage = (Image) Resources.P0M3;
    this.ucInfoImage3.Location = new Point(16 /*0x10*/, 755);
    this.ucInfoImage3.Margin = new Padding(0);
    this.ucInfoImage3.Name = "ucInfoImage3";
    this.ucInfoImage3.Size = new Size(240 /*0xF0*/, 30);
    this.ucInfoImage3.TabIndex = 698;
    this.ucInfoImage3.Visible = false;
    this.ucInfoImage2.BackColor = Color.Transparent;
    this.ucInfoImage2.BackgroundImage = (Image) Resources.P0M2;
    this.ucInfoImage2.Location = new Point(16 /*0x10*/, 707);
    this.ucInfoImage2.Margin = new Padding(0);
    this.ucInfoImage2.Name = "ucInfoImage2";
    this.ucInfoImage2.Size = new Size(240 /*0xF0*/, 30);
    this.ucInfoImage2.TabIndex = 697;
    this.ucInfoImage2.Visible = false;
    this.ucInfoImage1.BackColor = Color.Transparent;
    this.ucInfoImage1.BackgroundImage = (Image) Resources.P0M1;
    this.ucInfoImage1.Location = new Point(16 /*0x10*/, 659);
    this.ucInfoImage1.Margin = new Padding(0);
    this.ucInfoImage1.Name = "ucInfoImage1";
    this.ucInfoImage1.Size = new Size(240 /*0xF0*/, 30);
    this.ucInfoImage1.TabIndex = 696;
    this.ucInfoImage1.Visible = false;
    this.ucScrollA.BackColor = Color.Transparent;
    this.ucScrollA.BackgroundImageLayout = ImageLayout.None;
    this.ucScrollA.Location = new Point(976, 537);
    this.ucScrollA.Margin = new Padding(0);
    this.ucScrollA.Name = "ucScrollA";
    this.ucScrollA.Size = new Size(190, 20);
    this.ucScrollA.TabIndex = 690;
    this.ucColorA1.BackColor = Color.Transparent;
    this.ucColorA1.BackgroundImage = (Image) Resources.D3旋钮;
    this.ucColorA1.BackgroundImageLayout = ImageLayout.Center;
    this.ucColorA1.Location = new Point(617, 335);
    this.ucColorA1.Margin = new Padding(0);
    this.ucColorA1.Name = "ucColorA1";
    this.ucColorA1.Size = new Size(216, 216);
    this.ucColorA1.TabIndex = 675;
    this.ucScreenLED1.BackColor = Color.Transparent;
    this.ucScreenLED1.BackgroundImage = (Image) Resources.DFROZEN_HORIZON_PRO;
    this.ucScreenLED1.BackgroundImageLayout = ImageLayout.None;
    this.ucScreenLED1.Location = new Point(36, 128 /*0x80*/);
    this.ucScreenLED1.Margin = new Padding(0);
    this.ucScreenLED1.Name = "ucScreenLED1";
    this.ucScreenLED1.Size = new Size(460, 460);
    this.ucScreenLED1.TabIndex = 0;
    this.ucledHarddiskInfo1.BackColor = Color.Transparent;
    this.ucledHarddiskInfo1.Location = new Point(13, 656);
    this.ucledHarddiskInfo1.Margin = new Padding(0);
    this.ucledHarddiskInfo1.Name = "ucledHarddiskInfo1";
    this.ucledHarddiskInfo1.Size = new Size(506, 132);
    this.ucledHarddiskInfo1.TabIndex = 715;
    this.ucledHarddiskInfo1.Visible = false;
    this.ucledMemoryInfo1.BackColor = Color.Transparent;
    this.ucledMemoryInfo1.Location = new Point(13, 656);
    this.ucledMemoryInfo1.Margin = new Padding(0);
    this.ucledMemoryInfo1.Name = "ucledMemoryInfo1";
    this.ucledMemoryInfo1.Size = new Size(506, 132);
    this.ucledMemoryInfo1.TabIndex = 714;
    this.ucledMemoryInfo1.Visible = false;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.White;
    this.BackgroundImage = (Image) Resources.D0LF15;
    this.BackgroundImageLayout = ImageLayout.None;
    this.ClientSize = new Size(1274, 800);
    this.Controls.Add((Control) this.buttonWeek7);
    this.Controls.Add((Control) this.buttonWeek1);
    this.Controls.Add((Control) this.buttonH12);
    this.Controls.Add((Control) this.buttonH24);
    this.Controls.Add((Control) this.buttonN4);
    this.Controls.Add((Control) this.buttonN3);
    this.Controls.Add((Control) this.buttonN2);
    this.Controls.Add((Control) this.buttonN1);
    this.Controls.Add((Control) this.textBoxB);
    this.Controls.Add((Control) this.textBoxG);
    this.Controls.Add((Control) this.textBoxR);
    this.Controls.Add((Control) this.button6);
    this.Controls.Add((Control) this.button5);
    this.Controls.Add((Control) this.checkBox1);
    this.Controls.Add((Control) this.textBoxTimer);
    this.Controls.Add((Control) this.buttonPower);
    this.Controls.Add((Control) this.ucScrollAB);
    this.Controls.Add((Control) this.ucScrollAG);
    this.Controls.Add((Control) this.ucScrollAR);
    this.Controls.Add((Control) this.ucInfoImage6);
    this.Controls.Add((Control) this.ucInfoImage5);
    this.Controls.Add((Control) this.ucInfoImage4);
    this.Controls.Add((Control) this.ucInfoImage3);
    this.Controls.Add((Control) this.ucInfoImage2);
    this.Controls.Add((Control) this.ucInfoImage1);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.button4);
    this.Controls.Add((Control) this.buttonLB);
    this.Controls.Add((Control) this.ucScrollA);
    this.Controls.Add((Control) this.buttonC8);
    this.Controls.Add((Control) this.buttonC7);
    this.Controls.Add((Control) this.buttonC6);
    this.Controls.Add((Control) this.buttonC5);
    this.Controls.Add((Control) this.buttonC4);
    this.Controls.Add((Control) this.buttonC3);
    this.Controls.Add((Control) this.buttonC2);
    this.Controls.Add((Control) this.buttonC1);
    this.Controls.Add((Control) this.labelB);
    this.Controls.Add((Control) this.labelG);
    this.Controls.Add((Control) this.labelR);
    this.Controls.Add((Control) this.ucColorA1);
    this.Controls.Add((Control) this.buttonFZLD);
    this.Controls.Add((Control) this.buttonWDLD);
    this.Controls.Add((Control) this.buttonCHMS);
    this.Controls.Add((Control) this.buttonQCJB);
    this.Controls.Add((Control) this.buttonDSHX);
    this.Controls.Add((Control) this.buttonDSCL);
    this.Controls.Add((Control) this.buttonF);
    this.Controls.Add((Control) this.buttonC);
    this.Controls.Add((Control) this.ucScreenLED1);
    this.Controls.Add((Control) this.ucledHarddiskInfo1);
    this.Controls.Add((Control) this.ucledMemoryInfo1);
    this.DoubleBuffered = true;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Location = new Point(180, 0);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormLED);
    this.Text = nameof (FormLED);
    this.MouseDown += new MouseEventHandler(this.FormLED_MouseDown);
    this.MouseMove += new MouseEventHandler(this.FormLED_MouseMove);
    this.MouseUp += new MouseEventHandler(this.FormLED_MouseUp);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void delegateFormLED(int cmd, object info = null, object data = null, object data1 = null);
}

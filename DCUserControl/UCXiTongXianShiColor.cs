// Decompiled with JetBrains decompiler
// Type: TRCC.DCUserControl.UCXiTongXianShiColor
// Assembly: TRCC, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: CB0A5FF9-0AB9-4D2F-A637-515F7C378183
// Assembly location: C:\Program Files (x86)\TRCCCAPEN\TRCC.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TRCC.Properties;

#nullable disable
namespace TRCC.DCUserControl;

public class UCXiTongXianShiColor : UserControl
{
  public UCXiTongXianShiColor.delegateUCXiTongXianShiColor ucdelegateColor;
  private bool isTextXYEnabled = true;
  private bool isTextEnabled = true;
  private Font myFont = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
  public bool isGetRGB = false;
  private string myColorName;
  private bool myColorChange = false;
  private IContainer components = (IContainer) null;
  public TextBox textBoxX;
  public TextBox textBoxY;
  public Label label1;
  public Label label2;
  public TextBox textBoxB;
  public TextBox textBoxG;
  public TextBox textBoxR;
  private Button buttonC1;
  private Button buttonC2;
  private Button buttonC3;
  private Button buttonC4;
  private Button buttonC5;
  private Button buttonC6;
  private Button buttonC7;
  private Button buttonC8;
  private Button buttonC9;
  private Button buttonC10;
  private Button buttonC11;
  private Button button1;
  private Button button2;
  private Button button3;
  private Button button4;
  private Button button5;
  private Button button6;
  private Button button7;
  private Button button8;
  private Button button9;
  private Button button10;
  private Button button11;
  private Button buttonText;
  private UCColorB ucColorB1;
  private UCColorC ucColorC1;
  public Button buttonGetColor;

  private void ClearButtonBouns()
  {
    this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button7.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button8.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button9.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button10.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.button11.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC7.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC8.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC9.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC10.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonC11.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonGetColor.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
    this.buttonText.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
  }

  public UCXiTongXianShiColor()
  {
    this.InitializeComponent();
    this.ClearButtonBouns();
    this.ucColorB1.delegateUCColor = new UCColorB.delegateUCColorB(this.UCColorBDelegate);
    this.ucColorC1.delegateUCColor = new UCColorC.delegateUCColorC(this.UCColorCDelegate);
  }

  public void ChangedTextBoxXY(int x, int y)
  {
    this.isTextXYEnabled = false;
    this.textBoxX.Text = x.ToString();
    this.textBoxY.Text = y.ToString();
    this.isTextXYEnabled = true;
  }

  public void UCXiTongXianShiColorSet(ArrayList array)
  {
    this.myColorChange = false;
    this.ChangedTextBoxXY((int) array[0], (int) array[1]);
    this.ChangedTextBoxAndUCColorC((Color) array[2]);
    this.myFont = (Font) array[3];
    this.label1.Text = this.myFont.Name;
    this.label2.Text = Math.Round((double) this.myFont.Size, 0).ToString();
  }

  public void UCXiTongXianShiBackupColor()
  {
    this.button1.FlatAppearance.MouseOverBackColor = this.button1.BackColor;
    this.button1.FlatAppearance.MouseDownBackColor = this.button1.BackColor;
    this.button2.FlatAppearance.MouseOverBackColor = this.button2.BackColor;
    this.button2.FlatAppearance.MouseDownBackColor = this.button2.BackColor;
    this.button3.FlatAppearance.MouseOverBackColor = this.button3.BackColor;
    this.button3.FlatAppearance.MouseDownBackColor = this.button3.BackColor;
    this.button4.FlatAppearance.MouseOverBackColor = this.button4.BackColor;
    this.button4.FlatAppearance.MouseDownBackColor = this.button4.BackColor;
    this.button5.FlatAppearance.MouseOverBackColor = this.button5.BackColor;
    this.button5.FlatAppearance.MouseDownBackColor = this.button5.BackColor;
    this.button6.FlatAppearance.MouseOverBackColor = this.button6.BackColor;
    this.button6.FlatAppearance.MouseDownBackColor = this.button6.BackColor;
    this.button7.FlatAppearance.MouseOverBackColor = this.button7.BackColor;
    this.button7.FlatAppearance.MouseDownBackColor = this.button7.BackColor;
    this.button8.FlatAppearance.MouseOverBackColor = this.button8.BackColor;
    this.button8.FlatAppearance.MouseDownBackColor = this.button8.BackColor;
    this.button9.FlatAppearance.MouseOverBackColor = this.button9.BackColor;
    this.button9.FlatAppearance.MouseDownBackColor = this.button9.BackColor;
    this.button10.FlatAppearance.MouseOverBackColor = this.button10.BackColor;
    this.button10.FlatAppearance.MouseDownBackColor = this.button10.BackColor;
    this.button11.FlatAppearance.MouseOverBackColor = this.button11.BackColor;
    this.button11.FlatAppearance.MouseDownBackColor = this.button11.BackColor;
  }

  public void UCXiTongXianShiBackupColorInit(string name)
  {
    this.myColorName = name;
    FileStream input = new FileStream(this.myColorName, FileMode.OpenOrCreate);
    BinaryReader binaryReader = new BinaryReader((Stream) input);
    try
    {
      if (binaryReader.ReadByte() == (byte) 220)
      {
        this.button1.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button2.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button3.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button4.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button5.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button6.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button7.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button8.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button9.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button10.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        this.button11.BackColor = Color.FromArgb(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
      }
    }
    catch
    {
    }
    binaryReader.Close();
    binaryReader.Dispose();
    input.Close();
    input.Dispose();
    this.UCXiTongXianShiBackupColor();
  }

  public void UCXiTongXianShiBackupColorSave()
  {
    if (!this.myColorChange)
      return;
    this.button11.BackColor = this.button10.BackColor;
    this.button10.BackColor = this.button9.BackColor;
    this.button9.BackColor = this.button8.BackColor;
    this.button8.BackColor = this.button7.BackColor;
    this.button7.BackColor = this.button6.BackColor;
    this.button6.BackColor = this.button5.BackColor;
    this.button5.BackColor = this.button4.BackColor;
    this.button4.BackColor = this.button3.BackColor;
    this.button3.BackColor = this.button2.BackColor;
    this.button2.BackColor = this.button1.BackColor;
    this.button1.BackColor = Color.FromArgb(Convert.ToInt32(this.textBoxR.Text), Convert.ToInt32(this.textBoxG.Text), Convert.ToInt32(this.textBoxB.Text));
    FileStream output = new FileStream(this.myColorName, FileMode.OpenOrCreate);
    BinaryWriter binaryWriter1 = new BinaryWriter((Stream) output);
    binaryWriter1.Write((byte) 220);
    BinaryWriter binaryWriter2 = binaryWriter1;
    Color backColor = this.button1.BackColor;
    int r1 = (int) backColor.R;
    binaryWriter2.Write(r1);
    BinaryWriter binaryWriter3 = binaryWriter1;
    backColor = this.button1.BackColor;
    int g1 = (int) backColor.G;
    binaryWriter3.Write(g1);
    BinaryWriter binaryWriter4 = binaryWriter1;
    backColor = this.button1.BackColor;
    int b1 = (int) backColor.B;
    binaryWriter4.Write(b1);
    BinaryWriter binaryWriter5 = binaryWriter1;
    backColor = this.button2.BackColor;
    int r2 = (int) backColor.R;
    binaryWriter5.Write(r2);
    BinaryWriter binaryWriter6 = binaryWriter1;
    backColor = this.button2.BackColor;
    int g2 = (int) backColor.G;
    binaryWriter6.Write(g2);
    BinaryWriter binaryWriter7 = binaryWriter1;
    backColor = this.button2.BackColor;
    int b2 = (int) backColor.B;
    binaryWriter7.Write(b2);
    BinaryWriter binaryWriter8 = binaryWriter1;
    backColor = this.button3.BackColor;
    int r3 = (int) backColor.R;
    binaryWriter8.Write(r3);
    BinaryWriter binaryWriter9 = binaryWriter1;
    backColor = this.button3.BackColor;
    int g3 = (int) backColor.G;
    binaryWriter9.Write(g3);
    BinaryWriter binaryWriter10 = binaryWriter1;
    backColor = this.button3.BackColor;
    int b3 = (int) backColor.B;
    binaryWriter10.Write(b3);
    BinaryWriter binaryWriter11 = binaryWriter1;
    backColor = this.button4.BackColor;
    int r4 = (int) backColor.R;
    binaryWriter11.Write(r4);
    BinaryWriter binaryWriter12 = binaryWriter1;
    backColor = this.button4.BackColor;
    int g4 = (int) backColor.G;
    binaryWriter12.Write(g4);
    BinaryWriter binaryWriter13 = binaryWriter1;
    backColor = this.button4.BackColor;
    int b4 = (int) backColor.B;
    binaryWriter13.Write(b4);
    BinaryWriter binaryWriter14 = binaryWriter1;
    backColor = this.button5.BackColor;
    int r5 = (int) backColor.R;
    binaryWriter14.Write(r5);
    BinaryWriter binaryWriter15 = binaryWriter1;
    backColor = this.button5.BackColor;
    int g5 = (int) backColor.G;
    binaryWriter15.Write(g5);
    BinaryWriter binaryWriter16 = binaryWriter1;
    backColor = this.button5.BackColor;
    int b5 = (int) backColor.B;
    binaryWriter16.Write(b5);
    BinaryWriter binaryWriter17 = binaryWriter1;
    backColor = this.button6.BackColor;
    int r6 = (int) backColor.R;
    binaryWriter17.Write(r6);
    BinaryWriter binaryWriter18 = binaryWriter1;
    backColor = this.button6.BackColor;
    int g6 = (int) backColor.G;
    binaryWriter18.Write(g6);
    BinaryWriter binaryWriter19 = binaryWriter1;
    backColor = this.button6.BackColor;
    int b6 = (int) backColor.B;
    binaryWriter19.Write(b6);
    BinaryWriter binaryWriter20 = binaryWriter1;
    backColor = this.button7.BackColor;
    int r7 = (int) backColor.R;
    binaryWriter20.Write(r7);
    BinaryWriter binaryWriter21 = binaryWriter1;
    backColor = this.button7.BackColor;
    int g7 = (int) backColor.G;
    binaryWriter21.Write(g7);
    BinaryWriter binaryWriter22 = binaryWriter1;
    backColor = this.button7.BackColor;
    int b7 = (int) backColor.B;
    binaryWriter22.Write(b7);
    BinaryWriter binaryWriter23 = binaryWriter1;
    backColor = this.button8.BackColor;
    int r8 = (int) backColor.R;
    binaryWriter23.Write(r8);
    BinaryWriter binaryWriter24 = binaryWriter1;
    backColor = this.button8.BackColor;
    int g8 = (int) backColor.G;
    binaryWriter24.Write(g8);
    BinaryWriter binaryWriter25 = binaryWriter1;
    backColor = this.button8.BackColor;
    int b8 = (int) backColor.B;
    binaryWriter25.Write(b8);
    BinaryWriter binaryWriter26 = binaryWriter1;
    backColor = this.button9.BackColor;
    int r9 = (int) backColor.R;
    binaryWriter26.Write(r9);
    BinaryWriter binaryWriter27 = binaryWriter1;
    backColor = this.button9.BackColor;
    int g9 = (int) backColor.G;
    binaryWriter27.Write(g9);
    BinaryWriter binaryWriter28 = binaryWriter1;
    backColor = this.button9.BackColor;
    int b9 = (int) backColor.B;
    binaryWriter28.Write(b9);
    BinaryWriter binaryWriter29 = binaryWriter1;
    backColor = this.button10.BackColor;
    int r10 = (int) backColor.R;
    binaryWriter29.Write(r10);
    BinaryWriter binaryWriter30 = binaryWriter1;
    backColor = this.button10.BackColor;
    int g10 = (int) backColor.G;
    binaryWriter30.Write(g10);
    BinaryWriter binaryWriter31 = binaryWriter1;
    backColor = this.button10.BackColor;
    int b10 = (int) backColor.B;
    binaryWriter31.Write(b10);
    BinaryWriter binaryWriter32 = binaryWriter1;
    backColor = this.button11.BackColor;
    int r11 = (int) backColor.R;
    binaryWriter32.Write(r11);
    BinaryWriter binaryWriter33 = binaryWriter1;
    backColor = this.button11.BackColor;
    int g11 = (int) backColor.G;
    binaryWriter33.Write(g11);
    BinaryWriter binaryWriter34 = binaryWriter1;
    backColor = this.button11.BackColor;
    int b11 = (int) backColor.B;
    binaryWriter34.Write(b11);
    binaryWriter1.Flush();
    binaryWriter1.Close();
    binaryWriter1.Dispose();
    output.Close();
    output.Dispose();
    this.UCXiTongXianShiBackupColor();
  }

  public void UCXiTongXianShiBackupFont(ArrayList array)
  {
    Font font1 = this.button1.Font;
    this.button1.Font = (Font) array[0];
    if (font1 != null && font1 != SystemFonts.DefaultFont)
      font1.Dispose();
    Font font2 = this.button2.Font;
    this.button2.Font = (Font) array[1];
    if (font2 != null && font2 != SystemFonts.DefaultFont)
      font2.Dispose();
    Font font3 = this.button3.Font;
    this.button3.Font = (Font) array[2];
    if (font3 != null && font3 != SystemFonts.DefaultFont)
      font3.Dispose();
    Font font4 = this.button4.Font;
    this.button4.Font = (Font) array[3];
    if (font4 != null && font4 != SystemFonts.DefaultFont)
      font4.Dispose();
    Font font5 = this.button5.Font;
    this.button5.Font = (Font) array[4];
    if (font5 != null && font5 != SystemFonts.DefaultFont)
      font5.Dispose();
    Font font6 = this.button6.Font;
    this.button6.Font = (Font) array[5];
    if (font6 != null && font6 != SystemFonts.DefaultFont)
      font6.Dispose();
    Font font7 = this.button7.Font;
    this.button7.Font = (Font) array[6];
    if (font7 != null && font7 != SystemFonts.DefaultFont)
      font7.Dispose();
    Font font8 = this.button8.Font;
    this.button8.Font = (Font) array[7];
    if (font8 != null && font8 != SystemFonts.DefaultFont)
      font8.Dispose();
    Font font9 = this.button9.Font;
    this.button9.Font = (Font) array[8];
    if (font9 != null && font9 != SystemFonts.DefaultFont)
      font9.Dispose();
    Font font10 = this.button10.Font;
    this.button10.Font = (Font) array[9];
    if (font10 != null && font10 != SystemFonts.DefaultFont)
      font10.Dispose();
    Font font11 = this.button11.Font;
    this.button11.Font = (Font) array[10];
    if (font11 == null || font11 == SystemFonts.DefaultFont)
      return;
    font11.Dispose();
  }

  private void UCColorBDelegate(int cmd, int R, int G, int B)
  {
    if (cmd != 1)
      return;
    this.ChangedTextBoxAndUCColorC(R, G, B);
    this.myColorChange = true;
  }

  private void UCColorCDelegate(int cmd, int R, int G, int B)
  {
    if (cmd != 1)
      return;
    this.ChangedTextBoxOnly(R, G, B);
    this.myColorChange = true;
  }

  private void ChangedTextBoxOnly(int R, int G, int B)
  {
    this.isTextEnabled = false;
    this.textBoxR.Text = R.ToString();
    this.textBoxG.Text = G.ToString();
    this.textBoxB.Text = B.ToString();
    this.isTextEnabled = true;
    UCXiTongXianShiColor.delegateUCXiTongXianShiColor ucdelegateColor = this.ucdelegateColor;
    if (ucdelegateColor == null)
      return;
    ucdelegateColor(2, R, G, B);
  }

  private void ChangedTextBoxAndUCColorC(int R, int G, int B)
  {
    this.isTextEnabled = false;
    this.textBoxR.Text = R.ToString();
    this.textBoxG.Text = G.ToString();
    this.textBoxB.Text = B.ToString();
    this.isTextEnabled = true;
    this.ucColorC1.SetUCColorC(R, G, B);
    UCXiTongXianShiColor.delegateUCXiTongXianShiColor ucdelegateColor = this.ucdelegateColor;
    if (ucdelegateColor == null)
      return;
    ucdelegateColor(2, R, G, B);
  }

  private void ChangedTextBoxAndUCColorC(Color color)
  {
    this.isTextEnabled = false;
    this.textBoxR.Text = color.R.ToString();
    this.textBoxG.Text = color.G.ToString();
    this.textBoxB.Text = color.B.ToString();
    this.isTextEnabled = true;
    this.ucColorC1.SetUCColorC((int) color.R, (int) color.G, (int) color.B);
    UCXiTongXianShiColor.delegateUCXiTongXianShiColor ucdelegateColor = this.ucdelegateColor;
    if (ucdelegateColor == null)
      return;
    ucdelegateColor(2, (int) color.R, (int) color.G, (int) color.B);
  }

  public void ChangedTextBoxAndUCColorCWB(Color color) => this.ChangedTextBoxAndUCColorC(color);

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams = base.CreateParams;
      createParams.ExStyle |= 33554432 /*0x02000000*/;
      return createParams;
    }
  }

  private void ColorKeyPress(object sender, KeyPressEventArgs e)
  {
    if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
      return;
    e.Handled = true;
  }

  private void ColorTextChanged(object sender, EventArgs e)
  {
    if (!this.isTextEnabled)
      return;
    TextBox textBox = (TextBox) sender;
    if (textBox.Text.Length != 0 && Convert.ToInt32(textBox.Text) > (int) byte.MaxValue)
    {
      textBox.Text = "255";
    }
    else
    {
      int int32_1 = this.textBoxR.Text.Length != 0 ? Convert.ToInt32(this.textBoxR.Text) : 0;
      int int32_2 = this.textBoxG.Text.Length != 0 ? Convert.ToInt32(this.textBoxG.Text) : 0;
      int int32_3 = this.textBoxB.Text.Length != 0 ? Convert.ToInt32(this.textBoxB.Text) : 0;
      this.ucColorC1.SetUCColorC(int32_1, int32_2, int32_3);
      UCXiTongXianShiColor.delegateUCXiTongXianShiColor ucdelegateColor = this.ucdelegateColor;
      if (ucdelegateColor != null)
        ucdelegateColor(2, int32_1, int32_2, int32_3);
      this.myColorChange = true;
    }
  }

  private void textBoxXY_TextChanged(object sender, EventArgs e)
  {
    if (!this.isTextXYEnabled)
      return;
    int int32_1 = this.textBoxX.Text.Length != 0 ? Convert.ToInt32(this.textBoxX.Text) : 0;
    int int32_2 = this.textBoxY.Text.Length != 0 ? Convert.ToInt32(this.textBoxY.Text) : 0;
    UCXiTongXianShiColor.delegateUCXiTongXianShiColor ucdelegateColor = this.ucdelegateColor;
    if (ucdelegateColor == null)
      return;
    ucdelegateColor(3, int32_1, int32_2);
  }

  private void buttonC_Click(object sender, EventArgs e)
  {
    this.ChangedTextBoxAndUCColorC(((Control) sender).BackColor);
  }

  private void button_Click(object sender, EventArgs e)
  {
    this.ChangedTextBoxAndUCColorC(((Control) sender).BackColor);
  }

  private void buttonText_Click(object sender, EventArgs e)
  {
    FontDialog fontDialog = new FontDialog();
    fontDialog.Font = this.myFont;
    if (fontDialog.ShowDialog() == DialogResult.OK)
    {
      this.myFont.Dispose();
      this.myFont = fontDialog.Font;
      this.label1.Text = this.myFont.Name;
      this.label2.Text = Math.Round((double) this.myFont.Size, 0).ToString();
      UCXiTongXianShiColor.delegateUCXiTongXianShiColor ucdelegateColor = this.ucdelegateColor;
      if (ucdelegateColor != null)
        ucdelegateColor(4, font: this.myFont);
    }
    fontDialog.Dispose();
  }

  private void buttonGetColor_Click(object sender, EventArgs e)
  {
    if (this.isGetRGB)
      return;
    this.isGetRGB = true;
    this.myColorChange = true;
    this.buttonGetColor.Image = (Image) Resources.P取色;
    UCXiTongXianShiColor.delegateUCXiTongXianShiColor ucdelegateColor = this.ucdelegateColor;
    if (ucdelegateColor != null)
      ucdelegateColor(1);
  }

  public void TimerGetRGB()
  {
    if (!this.isGetRGB)
      return;
    Point position = Cursor.Position;
    Console.WriteLine($"X: {position.X.ToString()}Y: {position.Y.ToString()}");
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.textBoxX = new TextBox();
    this.textBoxY = new TextBox();
    this.label1 = new Label();
    this.label2 = new Label();
    this.textBoxB = new TextBox();
    this.textBoxG = new TextBox();
    this.textBoxR = new TextBox();
    this.buttonC1 = new Button();
    this.buttonC2 = new Button();
    this.buttonC3 = new Button();
    this.buttonC4 = new Button();
    this.buttonC5 = new Button();
    this.buttonC6 = new Button();
    this.buttonC7 = new Button();
    this.buttonC8 = new Button();
    this.buttonC9 = new Button();
    this.buttonC10 = new Button();
    this.buttonC11 = new Button();
    this.button1 = new Button();
    this.button2 = new Button();
    this.button3 = new Button();
    this.button4 = new Button();
    this.button5 = new Button();
    this.button6 = new Button();
    this.button7 = new Button();
    this.button8 = new Button();
    this.button9 = new Button();
    this.button10 = new Button();
    this.button11 = new Button();
    this.buttonGetColor = new Button();
    this.buttonText = new Button();
    this.ucColorB1 = new UCColorB();
    this.ucColorC1 = new UCColorC();
    this.SuspendLayout();
    this.textBoxX.BackColor = Color.FromArgb(67, 67, 67);
    this.textBoxX.BorderStyle = BorderStyle.None;
    this.textBoxX.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxX.ForeColor = Color.White;
    this.textBoxX.ImeMode = ImeMode.NoControl;
    this.textBoxX.Location = new Point(32 /*0x20*/, 32 /*0x20*/);
    this.textBoxX.MaxLength = 4;
    this.textBoxX.Name = "textBoxX";
    this.textBoxX.Size = new Size(53, 19);
    this.textBoxX.TabIndex = 672;
    this.textBoxX.Text = "0";
    this.textBoxX.TextAlign = HorizontalAlignment.Right;
    this.textBoxX.TextChanged += new EventHandler(this.textBoxXY_TextChanged);
    this.textBoxX.KeyPress += new KeyPressEventHandler(this.ColorKeyPress);
    this.textBoxY.BackColor = Color.FromArgb(67, 67, 67);
    this.textBoxY.BorderStyle = BorderStyle.None;
    this.textBoxY.Font = new Font("微软雅黑", 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxY.ForeColor = Color.White;
    this.textBoxY.ImeMode = ImeMode.NoControl;
    this.textBoxY.Location = new Point(121, 32 /*0x20*/);
    this.textBoxY.MaxLength = 4;
    this.textBoxY.Name = "textBoxY";
    this.textBoxY.Size = new Size(53, 19);
    this.textBoxY.TabIndex = 673;
    this.textBoxY.Text = "0";
    this.textBoxY.TextAlign = HorizontalAlignment.Right;
    this.textBoxY.TextChanged += new EventHandler(this.textBoxXY_TextChanged);
    this.textBoxY.KeyPress += new KeyPressEventHandler(this.ColorKeyPress);
    this.label1.BackColor = Color.Transparent;
    this.label1.FlatStyle = FlatStyle.Flat;
    this.label1.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label1.ForeColor = Color.White;
    this.label1.Location = new Point(39, 90);
    this.label1.Margin = new Padding(0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(108, 18);
    this.label1.TabIndex = 688;
    this.label1.Text = "微软雅黑";
    this.label1.TextAlign = ContentAlignment.MiddleCenter;
    this.label2.BackColor = Color.Transparent;
    this.label2.FlatStyle = FlatStyle.Flat;
    this.label2.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.label2.ForeColor = Color.White;
    this.label2.Location = new Point(151, 90);
    this.label2.Margin = new Padding(0);
    this.label2.Name = "label2";
    this.label2.Size = new Size(31 /*0x1F*/, 18);
    this.label2.TabIndex = 689;
    this.label2.Text = "9";
    this.label2.TextAlign = ContentAlignment.MiddleCenter;
    this.textBoxB.BackColor = Color.Black;
    this.textBoxB.BorderStyle = BorderStyle.None;
    this.textBoxB.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxB.ForeColor = Color.White;
    this.textBoxB.ImeMode = ImeMode.NoControl;
    this.textBoxB.Location = new Point(181, 304);
    this.textBoxB.MaxLength = 3;
    this.textBoxB.Name = "textBoxB";
    this.textBoxB.Size = new Size(36, 16 /*0x10*/);
    this.textBoxB.TabIndex = 712;
    this.textBoxB.Text = "0";
    this.textBoxB.TextAlign = HorizontalAlignment.Center;
    this.textBoxB.TextChanged += new EventHandler(this.ColorTextChanged);
    this.textBoxB.KeyPress += new KeyPressEventHandler(this.ColorKeyPress);
    this.textBoxG.BackColor = Color.Black;
    this.textBoxG.BorderStyle = BorderStyle.None;
    this.textBoxG.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxG.ForeColor = Color.White;
    this.textBoxG.ImeMode = ImeMode.NoControl;
    this.textBoxG.Location = new Point(132, 304);
    this.textBoxG.MaxLength = 3;
    this.textBoxG.Name = "textBoxG";
    this.textBoxG.Size = new Size(36, 16 /*0x10*/);
    this.textBoxG.TabIndex = 711;
    this.textBoxG.Text = "0";
    this.textBoxG.TextAlign = HorizontalAlignment.Center;
    this.textBoxG.TextChanged += new EventHandler(this.ColorTextChanged);
    this.textBoxG.KeyPress += new KeyPressEventHandler(this.ColorKeyPress);
    this.textBoxR.BackColor = Color.Black;
    this.textBoxR.BorderStyle = BorderStyle.None;
    this.textBoxR.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.textBoxR.ForeColor = Color.White;
    this.textBoxR.ImeMode = ImeMode.NoControl;
    this.textBoxR.Location = new Point(83, 304);
    this.textBoxR.MaxLength = 3;
    this.textBoxR.Name = "textBoxR";
    this.textBoxR.Size = new Size(36, 16 /*0x10*/);
    this.textBoxR.TabIndex = 710;
    this.textBoxR.Text = "255";
    this.textBoxR.TextAlign = HorizontalAlignment.Center;
    this.textBoxR.TextChanged += new EventHandler(this.ColorTextChanged);
    this.textBoxR.KeyPress += new KeyPressEventHandler(this.ColorKeyPress);
    this.buttonC1.BackColor = Color.FromArgb(224 /*0xE0*/, 32 /*0x20*/, 32 /*0x20*/);
    this.buttonC1.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC1.FlatAppearance.BorderSize = 0;
    this.buttonC1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC1.FlatStyle = FlatStyle.Flat;
    this.buttonC1.Location = new Point(13, 354);
    this.buttonC1.Margin = new Padding(0);
    this.buttonC1.Name = "buttonC1";
    this.buttonC1.Size = new Size(14, 14);
    this.buttonC1.TabIndex = 713;
    this.buttonC1.UseVisualStyleBackColor = false;
    this.buttonC1.Click += new EventHandler(this.buttonC_Click);
    this.buttonC2.BackColor = Color.FromArgb(250, 100, 1);
    this.buttonC2.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC2.FlatAppearance.BorderSize = 0;
    this.buttonC2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC2.FlatStyle = FlatStyle.Flat;
    this.buttonC2.Location = new Point(32 /*0x20*/, 354);
    this.buttonC2.Margin = new Padding(0);
    this.buttonC2.Name = "buttonC2";
    this.buttonC2.Size = new Size(14, 14);
    this.buttonC2.TabIndex = 714;
    this.buttonC2.UseVisualStyleBackColor = false;
    this.buttonC2.Click += new EventHandler(this.buttonC_Click);
    this.buttonC3.BackColor = Color.FromArgb(247, 181, 1);
    this.buttonC3.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC3.FlatAppearance.BorderSize = 0;
    this.buttonC3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC3.FlatStyle = FlatStyle.Flat;
    this.buttonC3.Location = new Point(51, 354);
    this.buttonC3.Margin = new Padding(0);
    this.buttonC3.Name = "buttonC3";
    this.buttonC3.Size = new Size(14, 14);
    this.buttonC3.TabIndex = 715;
    this.buttonC3.UseVisualStyleBackColor = false;
    this.buttonC3.Click += new EventHandler(this.buttonC_Click);
    this.buttonC4.BackColor = Color.FromArgb(109, 212, 1);
    this.buttonC4.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC4.FlatAppearance.BorderSize = 0;
    this.buttonC4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC4.FlatStyle = FlatStyle.Flat;
    this.buttonC4.Location = new Point(70, 354);
    this.buttonC4.Margin = new Padding(0);
    this.buttonC4.Name = "buttonC4";
    this.buttonC4.Size = new Size(14, 14);
    this.buttonC4.TabIndex = 716;
    this.buttonC4.UseVisualStyleBackColor = false;
    this.buttonC4.Click += new EventHandler(this.buttonC_Click);
    this.buttonC5.BackColor = Color.FromArgb(68, 215, 182);
    this.buttonC5.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC5.FlatAppearance.BorderSize = 0;
    this.buttonC5.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC5.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC5.FlatStyle = FlatStyle.Flat;
    this.buttonC5.Location = new Point(89, 354);
    this.buttonC5.Margin = new Padding(0);
    this.buttonC5.Name = "buttonC5";
    this.buttonC5.Size = new Size(14, 14);
    this.buttonC5.TabIndex = 717;
    this.buttonC5.UseVisualStyleBackColor = false;
    this.buttonC5.Click += new EventHandler(this.buttonC_Click);
    this.buttonC6.BackColor = Color.FromArgb(50, 197, (int) byte.MaxValue);
    this.buttonC6.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC6.FlatAppearance.BorderSize = 0;
    this.buttonC6.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC6.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC6.FlatStyle = FlatStyle.Flat;
    this.buttonC6.Location = new Point(108, 354);
    this.buttonC6.Margin = new Padding(0);
    this.buttonC6.Name = "buttonC6";
    this.buttonC6.Size = new Size(14, 14);
    this.buttonC6.TabIndex = 718;
    this.buttonC6.UseVisualStyleBackColor = false;
    this.buttonC6.Click += new EventHandler(this.buttonC_Click);
    this.buttonC7.BackColor = Color.FromArgb(1, 145, (int) byte.MaxValue);
    this.buttonC7.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC7.FlatAppearance.BorderSize = 0;
    this.buttonC7.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC7.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC7.FlatStyle = FlatStyle.Flat;
    this.buttonC7.Location = new Point((int) sbyte.MaxValue, 354);
    this.buttonC7.Margin = new Padding(0);
    this.buttonC7.Name = "buttonC7";
    this.buttonC7.Size = new Size(14, 14);
    this.buttonC7.TabIndex = 719;
    this.buttonC7.UseVisualStyleBackColor = false;
    this.buttonC7.Click += new EventHandler(this.buttonC_Click);
    this.buttonC8.BackColor = Color.FromArgb(98, 54, (int) byte.MaxValue);
    this.buttonC8.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC8.FlatAppearance.BorderSize = 0;
    this.buttonC8.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC8.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC8.FlatStyle = FlatStyle.Flat;
    this.buttonC8.Location = new Point(146, 354);
    this.buttonC8.Margin = new Padding(0);
    this.buttonC8.Name = "buttonC8";
    this.buttonC8.Size = new Size(14, 14);
    this.buttonC8.TabIndex = 720;
    this.buttonC8.UseVisualStyleBackColor = false;
    this.buttonC8.Click += new EventHandler(this.buttonC_Click);
    this.buttonC9.BackColor = Color.FromArgb(182, 32 /*0x20*/, 224 /*0xE0*/);
    this.buttonC9.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC9.FlatAppearance.BorderSize = 0;
    this.buttonC9.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC9.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC9.FlatStyle = FlatStyle.Flat;
    this.buttonC9.Location = new Point(165, 354);
    this.buttonC9.Margin = new Padding(0);
    this.buttonC9.Name = "buttonC9";
    this.buttonC9.Size = new Size(14, 14);
    this.buttonC9.TabIndex = 721;
    this.buttonC9.UseVisualStyleBackColor = false;
    this.buttonC9.Click += new EventHandler(this.buttonC_Click);
    this.buttonC10.BackColor = Color.White;
    this.buttonC10.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC10.FlatAppearance.BorderSize = 0;
    this.buttonC10.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC10.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC10.FlatStyle = FlatStyle.Flat;
    this.buttonC10.Location = new Point(184, 354);
    this.buttonC10.Margin = new Padding(0);
    this.buttonC10.Name = "buttonC10";
    this.buttonC10.Size = new Size(14, 14);
    this.buttonC10.TabIndex = 722;
    this.buttonC10.UseVisualStyleBackColor = false;
    this.buttonC10.Click += new EventHandler(this.buttonC_Click);
    this.buttonC11.BackColor = Color.Black;
    this.buttonC11.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonC11.FlatAppearance.BorderSize = 0;
    this.buttonC11.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonC11.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonC11.FlatStyle = FlatStyle.Flat;
    this.buttonC11.Location = new Point(203, 354);
    this.buttonC11.Margin = new Padding(0);
    this.buttonC11.Name = "buttonC11";
    this.buttonC11.Size = new Size(14, 14);
    this.buttonC11.TabIndex = 723;
    this.buttonC11.UseVisualStyleBackColor = false;
    this.buttonC11.Click += new EventHandler(this.buttonC_Click);
    this.button1.BackColor = Color.Silver;
    this.button1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Location = new Point(13, 333);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(14, 14);
    this.button1.TabIndex = 724;
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button_Click);
    this.button2.BackColor = Color.Silver;
    this.button2.BackgroundImageLayout = ImageLayout.Stretch;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Location = new Point(32 /*0x20*/, 333);
    this.button2.Margin = new Padding(0);
    this.button2.Name = "button2";
    this.button2.Size = new Size(14, 14);
    this.button2.TabIndex = 725;
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Click += new EventHandler(this.button_Click);
    this.button3.BackColor = Color.Silver;
    this.button3.BackgroundImageLayout = ImageLayout.Stretch;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Location = new Point(51, 333);
    this.button3.Margin = new Padding(0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(14, 14);
    this.button3.TabIndex = 726;
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Click += new EventHandler(this.button_Click);
    this.button4.BackColor = Color.Silver;
    this.button4.BackgroundImageLayout = ImageLayout.Stretch;
    this.button4.FlatAppearance.BorderSize = 0;
    this.button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button4.FlatStyle = FlatStyle.Flat;
    this.button4.Location = new Point(70, 333);
    this.button4.Margin = new Padding(0);
    this.button4.Name = "button4";
    this.button4.Size = new Size(14, 14);
    this.button4.TabIndex = 727;
    this.button4.UseVisualStyleBackColor = false;
    this.button4.Click += new EventHandler(this.button_Click);
    this.button5.BackColor = Color.Silver;
    this.button5.BackgroundImageLayout = ImageLayout.Stretch;
    this.button5.FlatAppearance.BorderSize = 0;
    this.button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button5.FlatStyle = FlatStyle.Flat;
    this.button5.Location = new Point(89, 333);
    this.button5.Margin = new Padding(0);
    this.button5.Name = "button5";
    this.button5.Size = new Size(14, 14);
    this.button5.TabIndex = 728;
    this.button5.UseVisualStyleBackColor = false;
    this.button5.Click += new EventHandler(this.button_Click);
    this.button6.BackColor = Color.Silver;
    this.button6.BackgroundImageLayout = ImageLayout.Stretch;
    this.button6.FlatAppearance.BorderSize = 0;
    this.button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button6.FlatStyle = FlatStyle.Flat;
    this.button6.Location = new Point(108, 333);
    this.button6.Margin = new Padding(0);
    this.button6.Name = "button6";
    this.button6.Size = new Size(14, 14);
    this.button6.TabIndex = 729;
    this.button6.UseVisualStyleBackColor = false;
    this.button6.Click += new EventHandler(this.button_Click);
    this.button7.BackColor = Color.Silver;
    this.button7.BackgroundImageLayout = ImageLayout.Stretch;
    this.button7.FlatAppearance.BorderSize = 0;
    this.button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button7.FlatStyle = FlatStyle.Flat;
    this.button7.Location = new Point((int) sbyte.MaxValue, 333);
    this.button7.Margin = new Padding(0);
    this.button7.Name = "button7";
    this.button7.Size = new Size(14, 14);
    this.button7.TabIndex = 730;
    this.button7.UseVisualStyleBackColor = false;
    this.button7.Click += new EventHandler(this.button_Click);
    this.button8.BackColor = Color.Silver;
    this.button8.BackgroundImageLayout = ImageLayout.Stretch;
    this.button8.FlatAppearance.BorderSize = 0;
    this.button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button8.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button8.FlatStyle = FlatStyle.Flat;
    this.button8.Location = new Point(146, 333);
    this.button8.Margin = new Padding(0);
    this.button8.Name = "button8";
    this.button8.Size = new Size(14, 14);
    this.button8.TabIndex = 731;
    this.button8.UseVisualStyleBackColor = false;
    this.button8.Click += new EventHandler(this.button_Click);
    this.button9.BackColor = Color.Silver;
    this.button9.BackgroundImageLayout = ImageLayout.Stretch;
    this.button9.FlatAppearance.BorderSize = 0;
    this.button9.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button9.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button9.FlatStyle = FlatStyle.Flat;
    this.button9.Location = new Point(165, 333);
    this.button9.Margin = new Padding(0);
    this.button9.Name = "button9";
    this.button9.Size = new Size(14, 14);
    this.button9.TabIndex = 732;
    this.button9.UseVisualStyleBackColor = false;
    this.button9.Click += new EventHandler(this.button_Click);
    this.button10.BackColor = Color.Silver;
    this.button10.BackgroundImageLayout = ImageLayout.Stretch;
    this.button10.FlatAppearance.BorderSize = 0;
    this.button10.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button10.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button10.FlatStyle = FlatStyle.Flat;
    this.button10.Location = new Point(184, 333);
    this.button10.Margin = new Padding(0);
    this.button10.Name = "button10";
    this.button10.Size = new Size(14, 14);
    this.button10.TabIndex = 733;
    this.button10.UseVisualStyleBackColor = false;
    this.button10.Click += new EventHandler(this.button_Click);
    this.button11.BackColor = Color.Silver;
    this.button11.BackgroundImageLayout = ImageLayout.Stretch;
    this.button11.FlatAppearance.BorderSize = 0;
    this.button11.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.button11.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.button11.FlatStyle = FlatStyle.Flat;
    this.button11.Location = new Point(203, 333);
    this.button11.Margin = new Padding(0);
    this.button11.Name = "button11";
    this.button11.Size = new Size(14, 14);
    this.button11.TabIndex = 734;
    this.button11.UseVisualStyleBackColor = false;
    this.button11.Click += new EventHandler(this.button_Click);
    this.buttonGetColor.BackColor = Color.Transparent;
    this.buttonGetColor.BackgroundImage = (Image) Resources.P吸管;
    this.buttonGetColor.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonGetColor.FlatAppearance.BorderSize = 0;
    this.buttonGetColor.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonGetColor.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonGetColor.FlatStyle = FlatStyle.Flat;
    this.buttonGetColor.Location = new Point(12, 276);
    this.buttonGetColor.Margin = new Padding(0);
    this.buttonGetColor.Name = "buttonGetColor";
    this.buttonGetColor.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.buttonGetColor.TabIndex = 735;
    this.buttonGetColor.UseVisualStyleBackColor = false;
    this.buttonGetColor.Click += new EventHandler(this.buttonGetColor_Click);
    this.buttonText.BackColor = Color.Transparent;
    this.buttonText.BackgroundImage = (Image) Resources.P文字字体;
    this.buttonText.BackgroundImageLayout = ImageLayout.Stretch;
    this.buttonText.FlatAppearance.BorderSize = 0;
    this.buttonText.FlatAppearance.MouseDownBackColor = Color.Transparent;
    this.buttonText.FlatAppearance.MouseOverBackColor = Color.Transparent;
    this.buttonText.FlatStyle = FlatStyle.Flat;
    this.buttonText.Location = new Point(12, 87);
    this.buttonText.Margin = new Padding(0);
    this.buttonText.Name = "buttonText";
    this.buttonText.Size = new Size(170, 24);
    this.buttonText.TabIndex = 736;
    this.buttonText.UseVisualStyleBackColor = false;
    this.buttonText.Click += new EventHandler(this.buttonText_Click);
    this.ucColorB1.BackColor = Color.Transparent;
    this.ucColorB1.Location = new Point(65, 273);
    this.ucColorB1.Margin = new Padding(0);
    this.ucColorB1.Name = "ucColorB1";
    this.ucColorB1.Size = new Size(158, 19);
    this.ucColorB1.TabIndex = 737;
    this.ucColorC1.BackColor = Color.Transparent;
    this.ucColorC1.Location = new Point(8, 139);
    this.ucColorC1.Margin = new Padding(0);
    this.ucColorC1.Name = "ucColorC1";
    this.ucColorC1.Size = new Size(214, 136);
    this.ucColorC1.TabIndex = 738;
    this.AutoScaleMode = AutoScaleMode.Inherit;
    this.BackColor = Color.Transparent;
    this.BackgroundImage = (Image) Resources.P01参数面板;
    this.BackgroundImageLayout = ImageLayout.None;
    this.Controls.Add((Control) this.ucColorB1);
    this.Controls.Add((Control) this.buttonGetColor);
    this.Controls.Add((Control) this.button11);
    this.Controls.Add((Control) this.button10);
    this.Controls.Add((Control) this.button9);
    this.Controls.Add((Control) this.button8);
    this.Controls.Add((Control) this.button7);
    this.Controls.Add((Control) this.button6);
    this.Controls.Add((Control) this.button5);
    this.Controls.Add((Control) this.button4);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.buttonC11);
    this.Controls.Add((Control) this.buttonC10);
    this.Controls.Add((Control) this.buttonC9);
    this.Controls.Add((Control) this.buttonC8);
    this.Controls.Add((Control) this.buttonC7);
    this.Controls.Add((Control) this.buttonC6);
    this.Controls.Add((Control) this.buttonC5);
    this.Controls.Add((Control) this.buttonC4);
    this.Controls.Add((Control) this.buttonC3);
    this.Controls.Add((Control) this.buttonC2);
    this.Controls.Add((Control) this.buttonC1);
    this.Controls.Add((Control) this.textBoxB);
    this.Controls.Add((Control) this.textBoxG);
    this.Controls.Add((Control) this.textBoxR);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.textBoxY);
    this.Controls.Add((Control) this.textBoxX);
    this.Controls.Add((Control) this.buttonText);
    this.Controls.Add((Control) this.ucColorC1);
    this.DoubleBuffered = true;
    this.Margin = new Padding(0);
    this.Name = nameof (UCXiTongXianShiColor);
    this.Size = new Size(230, 374);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void delegateUCXiTongXianShiColor(int mode, int R = 0, int G = 0, int B = 0, Font font = null);
}

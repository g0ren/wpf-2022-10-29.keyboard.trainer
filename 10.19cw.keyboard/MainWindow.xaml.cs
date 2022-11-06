using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _10._19cw.keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShiftDown()
        {
            butBacktick.Content = "~";
            but1.Content = "!";
            but2.Content = "@";
            but3.Content = "#";
            but4.Content = "$";
            but5.Content = "%";
            but6.Content = "^";
            but7.Content = "&";
            but8.Content = "*";
            but9.Content = "(";
            but0.Content = ")";
            butDash.Content = "_";
            butEq.Content = "+";

            butQ.Content = "Q";
            butW.Content = "W";
            butE.Content = "E";
            butR.Content = "R";
            butT.Content="T";
            butY.Content = "Y";
            butU.Content = "U";
            butI.Content = "I";
            butO.Content = "O";
            butP.Content = "P";
            butLSq.Content = "{";
            butRSq.Content = "}";
            butBSlash.Content = "|";

            butA.Content = "A";
            butS.Content = "S";
            butD.Content = "D";
            butF.Content = "F";
            butG.Content = "G";
            butH.Content="H";
            butJ.Content = "J";
            butK.Content = "K";
            butL.Content = "L";
            butSemicol.Content = ":";
            butApo.Content = "\"";

            butZ.Content = "Z";
            butX.Content = "X";
            butC.Content = "C";
            butV.Content = "V";
            butB.Content = "B";
            butN.Content = "N";
            butM.Content = "M";
            butComma.Content = "<";
            butDot.Content = ">";
            butSlash.Content = "?";
        }

        private void ShiftUp()
        {
            butBacktick.Content = "`";
            but1.Content = "1";
            but2.Content = "2";
            but3.Content = "3";
            but4.Content = "4";
            but5.Content = "5";
            but6.Content = "6";
            but7.Content = "7";
            but8.Content = "8";
            but9.Content = "9";
            but0.Content = "0";
            butDash.Content = "-";
            butEq.Content = "=";

            butQ.Content = "q";
            butW.Content = "w";
            butE.Content = "e";
            butR.Content = "r";
            butT.Content = "t";
            butY.Content = "y";
            butU.Content = "u";
            butI.Content = "i";
            butO.Content = "o";
            butP.Content = "p";
            butLSq.Content = "[";
            butRSq.Content = "]";
            butBSlash.Content = "\\";

            butA.Content = "a";
            butS.Content = "s";
            butD.Content = "d";
            butF.Content = "f";
            butG.Content = "g";
            butH.Content = "h";
            butJ.Content = "j";
            butK.Content = "k";
            butL.Content = "l";
            butSemicol.Content = ";";
            butApo.Content = "\'";

            butZ.Content = "z";
            butX.Content = "x";
            butC.Content = "c";
            butV.Content = "v";
            butB.Content = "b";
            butN.Content = "n";
            butM.Content = "m";
            butComma.Content = ",";
            butDot.Content = ".";
            butSlash.Content = "/";
        }


        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                // Line 1
                case Key.Oem3:
                    butBacktick.Background = Brushes.Magenta;
                    break;
                case Key.D1:
                    but1.Background = Brushes.Magenta;
                    break;
                case Key.D2:
                    but2.Background = Brushes.Magenta;
                    break;
                case Key.D3:
                    but3.Background = Brushes.Yellow;
                    break;
                case Key.D4:
                    but4.Background = Brushes.Green;
                    break;
                case Key.D5:
                    but5.Background = Brushes.DodgerBlue;
                    break;
                case Key.D6:
                    but6.Background = Brushes.DodgerBlue;
                    break;
                case Key.D7:
                    but7.Background = Brushes.DarkViolet;
                    break;
                case Key.D8:
                    but8.Background = Brushes.DarkViolet;
                    break;
                case Key.D9:
                    but9.Background = Brushes.Magenta;
                    break;
                case Key.D0:
                    but0.Background = Brushes.Yellow;
                    break;
                case Key.OemMinus:
                    butDash.Background = Brushes.Green;
                    break;
                case Key.OemPlus:
                    butEq.Background = Brushes.Green;
                    break;
                case Key.Back:
                    butBksp.Background = Brushes.DarkGray;
                    break;
                // Line 2
                case Key.Tab:
                    butTab.Background = Brushes.DarkGray;
                    break;
                case Key.Q:
                    butQ.Background = Brushes.Magenta;
                    break;
                case Key.W:
                    butW.Background = Brushes.Yellow;
                    break;
                case Key.E:
                    butE.Background = Brushes.Green;
                    break;
                case Key.R:
                    butR.Background = Brushes.DodgerBlue;
                    break;
                case Key.T:
                    butT.Background = Brushes.DodgerBlue;
                    break;
                case Key.Y:
                    butY.Background = Brushes.DarkViolet;
                    break;
                case Key.U:
                    butU.Background = Brushes.DarkViolet;
                    break;
                case Key.I:
                    butI.Background = Brushes.Magenta;
                    break;
                case Key.O:
                    butO.Background = Brushes.Yellow;
                    break;
                case Key.P:
                    butP.Background = Brushes.Green;
                    break;
                // []\
                case Key.OemOpenBrackets:
                    butLSq.Background = Brushes.Green;
                    break;
                case Key.Oem6:
                    butRSq.Background = Brushes.Green;
                    break;
                case Key.Oem5:
                    butBSlash.Background = Brushes.Green;
                    break;
                // Line 3
                case Key.F18:
                    butCapsLock.Background = Brushes.DarkGray;
                    break;
                case Key.A:
                    butA.Background = Brushes.Magenta;
                    break;
                case Key.S:
                    butS.Background = Brushes.Yellow;
                    break;
                case Key.D:
                    butD.Background = Brushes.Green;
                    break;
                case Key.F:
                    butF.Background = Brushes.DodgerBlue;
                    break;
                case Key.G:
                    butG.Background = Brushes.DodgerBlue;
                    break;
                case Key.H:
                    butH.Background = Brushes.DarkViolet;
                    break;
                case Key.J:
                    butJ.Background = Brushes.DarkViolet;
                    break;
                case Key.K:
                    butK.Background = Brushes.Magenta;
                    break;
                case Key.L:
                    butL.Background = Brushes.Yellow;
                    break;
                case Key.Oem1:
                    butSemicol.Background=Brushes.Green;
                    break;
                case Key.OemQuotes:
                    butApo.Background=Brushes.Green;
                    break;
                case Key.Return:
                butEnter.Background=Brushes.Red;
                    break;
                //Line 4
                case Key.LeftShift:
                    butLShift.Background = Brushes.DarkGray;
                    ShiftDown();
                    break;
                case Key.Z:
                    butZ.Background=Brushes.Magenta;
                    break;
                case Key.X:
                    butX.Background = Brushes.Yellow;
                    break;
                case Key.C:
                    butC.Background = Brushes.Green;
                    break;
                case Key.V:
                    butV.Background = Brushes.DodgerBlue;
                    break;
                case Key.B:
                    butB.Background = Brushes.DodgerBlue;
                    break;
                case Key.N:
                    butN.Background = Brushes.DarkViolet;
                    break;
                case Key.M:
                    butM.Background = Brushes.DarkViolet;
                    break;
                case Key.OemComma:
                    butComma.Background=Brushes.Yellow;
                    break;
                case Key.OemPeriod:
                    butDot.Background=Brushes.Green;
                    break;
                case Key.OemQuestion:
                    butSlash.Background=Brushes.Green;
                    break;
                case Key.RightShift:
                    butRShift.Background = Brushes.DarkGray;
                    ShiftDown();
                    break;
                //Line 5
                case Key.LeftCtrl:
                    butLCtrl.Background = Brushes.DarkGray;
                    break;
                case Key.System:
                case Key.LeftAlt:
                    butLAlt.Background = Brushes.DarkGray;
                    break;
                case Key.RightAlt:
                    butRAlt.Background = Brushes.DarkGray;
                    break;
                case Key.Space:
                    butSpace.Background = Brushes.DarkOrange;
                    break;
                case Key.RightCtrl:
                    butRCtrl.Background = Brushes.DarkGray;
                    break;
                default:
                    MessageBox.Show(Enum.GetName(typeof(Key), e.Key));
                    break;
            }
        }

        private void KeyUpHandler(object sender, KeyEventArgs e)
        {
               switch (e.Key)
            {
                // Line 1
                case Key.Oem3:
                    butBacktick.Background = Brushes.HotPink;
                    break;
                case Key.D1:
                    but1.Background = Brushes.HotPink;
                    break;
                case Key.D2:
                    but2.Background = Brushes.HotPink;
                    break;
                case Key.D3:
                    but3.Background = Brushes.LemonChiffon;
                    break;
                case Key.D4:
                    but4.Background = Brushes.Lime;
                    break;
                case Key.D5:
                    but5.Background = Brushes.SkyBlue;
                    break;
                case Key.D6:
                    but6.Background = Brushes.SkyBlue;
                    break;
                case Key.D7:
                    but7.Background = Brushes.MediumOrchid;
                    break;
                case Key.D8:
                    but8.Background = Brushes.MediumOrchid;
                    break;
                case Key.D9:
                    but9.Background = Brushes.HotPink;
                    break;
                case Key.D0:
                    but0.Background = Brushes.LemonChiffon;
                    break;
                case Key.OemMinus:
                    butDash.Background = Brushes.Lime;
                    break;
                case Key.OemPlus:
                    butEq.Background = Brushes.Lime;
                    break;
                case Key.Back:
                    butBksp.Background = SystemColors.ControlLightBrush;
                    break;
                // Line 2
                case Key.Tab:
                    butTab.Background = SystemColors.ControlLightBrush;
                    break;
                case Key.Q:
                    butQ.Background = Brushes.HotPink;
                    break;
                case Key.W:
                    butW.Background = Brushes.LemonChiffon;
                    break;
                case Key.E:
                    butE.Background = Brushes.Lime;
                    break;
                case Key.R:
                    butR.Background = Brushes.SkyBlue;
                    break;
                case Key.T:
                    butT.Background = Brushes.SkyBlue;
                    break;
                case Key.Y:
                    butY.Background = Brushes.MediumOrchid;
                    break;
                case Key.U:
                    butU.Background = Brushes.MediumOrchid;
                    break;
                case Key.I:
                    butI.Background = Brushes.HotPink;
                    break;
                case Key.O:
                    butO.Background = Brushes.LemonChiffon;
                    break;
                case Key.P:
                    butP.Background = Brushes.Lime;
                    break;
                // []\
                case Key.OemOpenBrackets:
                    butLSq.Background = Brushes.Lime;
                    break;
                case Key.Oem6:
                    butRSq.Background = Brushes.Lime;
                    break;
                case Key.Oem5:
                    butBSlash.Background = Brushes.Lime;
                    break;
                // Line 3
                case Key.F18:
                    butCapsLock.Background = SystemColors.ControlLightBrush;
                    break;
                case Key.A:
                    butA.Background = Brushes.HotPink;
                    break;
                case Key.S:
                    butS.Background = Brushes.LemonChiffon;
                    break;
                case Key.D:
                    butD.Background = Brushes.Lime;
                    break;
                case Key.F:
                    butF.Background = Brushes.SkyBlue;
                    break;
                case Key.G:
                    butG.Background = Brushes.SkyBlue;
                    break;
                case Key.H:
                    butH.Background = Brushes.MediumOrchid;
                    break;
                case Key.J:
                    butJ.Background = Brushes.MediumOrchid;
                    break;
                case Key.K:
                    butK.Background = Brushes.HotPink;
                    break;
                case Key.L:
                    butL.Background = Brushes.LemonChiffon;
                    break;
                case Key.Oem1:
                    butSemicol.Background = Brushes.Lime;
                    break;
                case Key.OemQuotes:
                    butApo.Background = Brushes.Lime;
                    break;
                case Key.Return:
                    butEnter.Background = SystemColors.ControlLightBrush;
                    break;
                //Line 4
                case Key.LeftShift:
                    butLShift.Background = SystemColors.ControlLightBrush;
                    ShiftUp();
                    break;
                case Key.Z:
                    butZ.Background = Brushes.HotPink;
                    break;
                case Key.X:
                    butX.Background = Brushes.LemonChiffon;
                    break;
                case Key.C:
                    butC.Background = Brushes.Lime;
                    break;
                case Key.V:
                    butV.Background = Brushes.SkyBlue;
                    break;
                case Key.B:
                    butB.Background = Brushes.SkyBlue;
                    break;
                case Key.N:
                    butN.Background = Brushes.MediumOrchid;
                    break;
                case Key.M:
                    butM.Background = Brushes.MediumOrchid;
                    break;
                case Key.OemComma:
                    butComma.Background = Brushes.LemonChiffon;
                    break;
                case Key.OemPeriod:
                    butDot.Background = Brushes.Lime;
                    break;
                case Key.OemQuestion:
                    butSlash.Background = Brushes.Lime;
                    break;
                case Key.RightShift:
                    butRShift.Background = SystemColors.ControlLightBrush;
                    ShiftUp();
                    break;
                //Line 5
                case Key.LeftCtrl:
                    butLCtrl.Background = SystemColors.ControlLightBrush;
                    break;
                case Key.System:
                case Key.LeftAlt:
                    butLAlt.Background = SystemColors.ControlLightBrush;
                    break;
                case Key.RightAlt:
                    butRAlt.Background = SystemColors.ControlLightBrush;
                    break;
                case Key.Space:
                    butSpace.Background = Brushes.Orange;
                    break;
                case Key.RightCtrl:
                    butRCtrl.Background = SystemColors.ControlLightBrush;
                    break;
                default:
                    MessageBox.Show(Enum.GetName(typeof(Key), e.Key));
                    break;
            }
        }

        private static uint totalTyped = 0;
        private static uint fails = 0;
        private static uint difficulty = 1;
        private static bool caseSens = false;
        private static double speed = 0.0;
        private static System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

        private static string RandomString()
        {
            Random random = new Random();
            int length = (int)difficulty * 10;
            StringBuilder sb = new StringBuilder();
            sb.Append("abcdefghijklmnopqrstuvwxyz ");
            if (caseSens)
            {
                sb.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ ");
            }
            if(difficulty>1)
            {
                sb.Append("0123456789 ");
            }
            if (difficulty > 3)
            {
                sb.Append("!@#$%^&*()-_=+|? ");
            }
            if (difficulty >= 5) 
            {
                sb.Append(",.;:\'\"\\/[]{} ");
            }
            string chars = sb.ToString();
                                 
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void GameStart()
        {
            startButton.IsEnabled = false;
            stopButton.IsEnabled = true;
            textToType.Text = RandomString();
            typingBox.Document.Blocks.Clear();
            typingBox.IsEnabled = true;
            fails = 0;
            failTextBlock.Text = $"Fails: {fails}";
            totalTyped = 0;
            speedTextBlock.Text = "Speed: N/A";
            watch.Reset();
            watch.Start();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            GameStart();
        }

        private void GameOver()
        {
            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;
            typingBox.IsEnabled = false;
            watch.Stop();
            speed= (double)totalTyped/(watch.ElapsedMilliseconds / 1000);
            speedTextBlock.Text = $"Speed: {speed:0.##} char/sec";
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            GameOver();
        }

        private static bool CharsInequal(char a, char b)
        {
            if (!caseSens &&
                char.IsLetter(a) &&
                char.IsLetter(b))
            {
                return char.ToUpperInvariant(a) != char.ToUpperInvariant(b);
            }
            else
            { 
                return a != b;
            }
        }


        private void typingBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string typedText = String.Empty;
            typedText += new TextRange(typingBox.Document.ContentStart, 
                typingBox.Document.ContentEnd).Text.Replace("\n","").Replace("\r","");
            
            if (typedText.Length > totalTyped)
            {
                totalTyped = (uint)typedText.Length;
                if (CharsInequal(typedText[typedText.Length - 1] , 
                    textToType.Text[typedText.Length - 1]))
                {
                    fails++;
                    //failTextBlock.Text += $", {fails}";
                    failTextBlock.Text = $"Fails: {fails}";
                    TextRange last = new TextRange(
                    typingBox.CaretPosition.GetPositionAtOffset(-1),
                    typingBox.CaretPosition);
                    last.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red);
                }
                else
                {
                    TextRange last = new TextRange(
                    typingBox.CaretPosition.GetPositionAtOffset(-1),
                    typingBox.CaretPosition);
                    last.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);
                }
            }
            if (typedText.Length >= textToType.Text.Length)
            {
                GameOver();
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            difficulty = Convert.ToUInt32(difficultySlider.Value);
        }

        private void caseSenCheck_Checked(object sender, RoutedEventArgs e)
        {
            caseSens = true;
        }
        private void caseSenCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            caseSens = false;
        }
    }
}

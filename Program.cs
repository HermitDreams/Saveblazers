// See https://aka.ms/new-console-template for more information
// FF1 Spellbinder, for use with Final Fantasy Randomizer. IRC Script and C# port by Linkshot, 2018-2022
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Saveblazers
{
    internal class Program
    {
        #region Initialization
        public static string perkname = "PERK";
        public static int perknumber;
        public static byte perkbyte1;
        public static byte perkbyte2;
        public static byte perkbyte3;
        public static byte perkbyte4;
        public static byte perkbyte5;
        public static byte perkbyte6;
        #endregion Initialization
        static void Main()
        {
            var perkseed = new Random();
            perknumber = perkseed.Next(0, 24);
            switch (perknumber)
            {
                case 0: perkname = "Adventurer"; break;
                case 1: perkname = "Archer"; break;
                case 2: perkname = "Twofold"; break;
                case 3: perkname = "Sorcerer"; break;
                case 4: perkname = "Sticky Pete"; break;
                case 5: perkname = "Juggernaut"; break;
                case 6: perkname = "Elementalist"; break;
                case 7: perkname = "Cleric"; break;
                case 8: perkname = "Dashy Joe"; break;
                case 9: perkname = "Springy"; break;
                case 10: perkname = "Slasher"; break;
                case 11: perkname = "Trader"; break;
                case 12: perkname = "Traditionalist"; break;
                case 13: perkname = "Explosive"; break;
                case 14: perkname = "Heavy Hitter"; break;
                case 15: perkname = "Vampire"; break;
                case 16: perkname = "Reaper"; break;
                case 17: perkname = "Protection"; break;
                case 18: perkname = "Dual Wield"; break;
                case 19: perkname = "Vortex"; break;
                case 20: perkname = "Swordsman"; break;
                case 21: perkname = "Brimstone"; break;
                case 22: perkname = "Nimrod"; break;
                case 23: perkname = "Runemaster"; break;
                default: perkname = "PERK"; break;
            }
            colors.echo(8, $"Selected {perkname} ({perknumber})");
            switch (perknumber)
            {
                case  0: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC0; perkbyte4 = 0xC0; perkbyte5 = 0xC0; perkbyte6 = 0xC0; break;
                case  1: perkbyte1 = 0xC0; perkbyte2 = 0xC1; perkbyte3 = 0x18; perkbyte4 = 0xC0; perkbyte5 = 0xCD; perkbyte6 = 0x18; break;
                case  2: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC0; perkbyte4 = 0xC0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case  3: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC0; perkbyte4 = 0xE0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case  4: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC4; perkbyte4 = 0xC0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case  5: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC4; perkbyte4 = 0xD0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case  6: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC4; perkbyte4 = 0xE0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case  7: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC5; perkbyte4 = 0x0C; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case  8: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC8; perkbyte4 = 0xC0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case  9: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC8; perkbyte4 = 0xC8; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 10: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC8; perkbyte4 = 0xD0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 11: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC8; perkbyte4 = 0xD8; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 12: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC8; perkbyte4 = 0xE0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 13: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC9; perkbyte4 = 0x04; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 14: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC9; perkbyte4 = 0x0C; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 15: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xC9; perkbyte4 = 0x14; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 16: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xCC; perkbyte4 = 0xC0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 17: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xCC; perkbyte4 = 0xC4; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 18: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xCC; perkbyte4 = 0xC8; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 19: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xCC; perkbyte4 = 0xCC; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 20: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xCC; perkbyte4 = 0xD0; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 21: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xCC; perkbyte4 = 0xD4; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 22: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xCC; perkbyte4 = 0xD8; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
                case 23: perkbyte1 = 0xC0; perkbyte2 = 0xC0; perkbyte3 = 0xCC; perkbyte4 = 0xDC; perkbyte5 = 0xD0; perkbyte6 = 0xC0; break;
            }
            colors.echo(9, $"Converted {perknumber} to {perkbyte1}{perkbyte2} {perkbyte3}{perkbyte4} {perkbyte5}{perkbyte6}");
            using (TextWriter quill = File.CreateText($@"{Path.GetDirectoryName(Environment.ProcessPath)}\tempsave2.sav"))
            {
                string savefile = File.ReadAllText($@"cleansave2.txt");
                
                    byte[] decodedsave = Convert.FromBase64String(savefile.Substring(1, (savefile.Length - 3)));
                    Buffer.SetByte(decodedsave, 0x1927, perkbyte1);
                    Buffer.SetByte(decodedsave, 0x1928, perkbyte2);
                    Buffer.SetByte(decodedsave, 0x1929, perkbyte3);
                    Buffer.SetByte(decodedsave, 0x192A, perkbyte4);
                    Buffer.SetByte(decodedsave, 0x192B, perkbyte5);
                    Buffer.SetByte(decodedsave, 0x192C, perkbyte6);
                    string patchedsave = Convert.ToBase64String(decodedsave);
                    quill.Write("0");
                    quill.Write($"{patchedsave}");
                    quill.Write("=0");
            }
            colors.echo(4, "Check tempsave2");
        }
    }
}
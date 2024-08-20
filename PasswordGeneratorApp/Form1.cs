using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    public partial class Form1 : MaterialForm
    {
        bool firstClick = true;

        Random rand = new();
        string result = String.Empty;
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        const string numbers = "0123456789";
        const string specialSymbols = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
        string vocabulary = letters;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, 
                Primary.Blue900, Primary.Blue400, Accent.Red200, TextShade.WHITE);

            trackBar1.Minimum = 8;
            trackBar1.Maximum = 128;
            textBox1.Text = GenerateStaticPassword();
        }

        private void StealFocus() => label1.Focus();

        private string GenerateStaticPassword()
        {
            result = String.Empty;

            if (checkBox1.Checked)
                vocabulary += numbers;
            if (checkBox2.Checked)
                vocabulary += specialSymbols;

            for (int i = 0; i < trackBar1.Value; i++)
                result += vocabulary[rand.Next(vocabulary.Length)];
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vocabulary = letters;

            if (checkBox1.Checked)
                vocabulary += numbers;
            if (checkBox2.Checked)
                vocabulary += specialSymbols;

            for (int i = 0; i < trackBar1.Value; i++)
                result += vocabulary[rand.Next(vocabulary.Length)];
            textBox1.Text = GenerateStaticPassword();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            vocabulary = letters;

            if (checkBox1.Checked)
                vocabulary += numbers;
            if (checkBox2.Checked)
                vocabulary += specialSymbols;

            label2.Text = "Password Length: " + trackBar1.Value;
            textBox1.Text = GenerateStaticPassword();

            StealFocus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = GetAltResult();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (firstClick)
                textBox2.Text = String.Empty;
            firstClick = false;
        }

        static string GetAltString(IDependencies iDependencies, char nextRandSymbol)
        {
            Random rand = new();
            for (int j = 0; j < iDependencies.GetDependencies().Length; j++)
            {
                if (nextRandSymbol.ToString() == iDependencies.GetDependencies()[j][0])
                {
                    if (iDependencies.GetDependencies()[j].Length == 1)
                        return iDependencies.GetDependencies()[j][0];
                    return iDependencies.GetDependencies()
                        [j][rand.Next(1, iDependencies.GetDependencies()[j].Length)];
                }
            }

            return String.Empty;
        }

        private string GetAltResult()
        {
            string passWord = textBox2.Text;
            passWord = String.Concat(passWord.Where(c => !Char.IsWhiteSpace(c)));
            string result2 = String.Empty;

            BigLittersDependencies bld = new();
            SmallLittersDependencies sld = new();
            NumbersDependencies nd = new();

            foreach (char symbol in passWord)
            {
                if (char.IsLower(symbol))
                    result2 += GetAltString(sld, symbol);
                else if (char.IsUpper(symbol))
                    result2 += GetAltString(bld, symbol);
                else if (char.IsDigit(symbol))
                    result2 += GetAltString(nd, symbol);
                else
                    result2 += symbol;
            }

            return result2;
        }
    }
}
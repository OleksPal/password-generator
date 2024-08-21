using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    public partial class MainForm : MaterialForm
    {
        Random rand = new();
        string result = String.Empty;
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        const string numbers = "0123456789";
        const string specialSymbols = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
        string vocabulary = letters;

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue400, Accent.Amber400, TextShade.WHITE);

            nonMemorableTextBox.Text = GenerateStaticPassword();
        }

        private void StealFocus() => nonMemorablePageTitle.Focus();

        private string GenerateStaticPassword()
        {
            result = String.Empty;

            if (allowNumbersCheckBox.Checked)
                vocabulary += numbers;
            if (allowSpecialSymbolsCheckBox.Checked)
                vocabulary += specialSymbols;

            for (int i = 0; i < passwordSizeTrackBar.Value; i++)
                result += vocabulary[rand.Next(vocabulary.Length)];
            return result;
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            vocabulary = letters;

            if (allowNumbersCheckBox.Checked)
                vocabulary += numbers;
            if (allowSpecialSymbolsCheckBox.Checked)
                vocabulary += specialSymbols;

            for (int i = 0; i < passwordSizeTrackBar.Value; i++)
                result += vocabulary[rand.Next(vocabulary.Length)];
            nonMemorableTextBox.Text = GenerateStaticPassword();
        }

        private void PasswordSizeTrackBarScroll(object sender, EventArgs e)
        {
            vocabulary = letters;

            if (allowNumbersCheckBox.Checked)
                vocabulary += numbers;
            if (allowSpecialSymbolsCheckBox.Checked)
                vocabulary += specialSymbols;

            passwordLengthLabel.Text = "Password Length: " + passwordSizeTrackBar.Value;
            nonMemorableTextBox.Text = GenerateStaticPassword();

            StealFocus();
        }

        private void PasswordSizeTrackBarEnter(object sender, EventArgs e) => StealFocus();
            
        private void CopyNonMemorableButtonClick(object sender, EventArgs e)
        {
            Clipboard.SetText(nonMemorableTextBox.Text);
        }

        private void GenerateMemorablePasswordButtonClick(object sender, EventArgs e)
        {
            memorablePasswordTextBox.Text = GetAltResult();
        }

        private void CopyMemorablePasswordButtonClick(object sender, EventArgs e)
        {
            Clipboard.SetText(memorablePasswordTextBox.Text);
        }

        static string GetAltString(Replacement replacement, char nextRandSymbol)
        {
            Random rand = new();
            for (int j = 0; j < replacement.Replacements.Length; j++)
            {
                if (nextRandSymbol.ToString() == replacement.Replacements[j][0])
                {
                    if (replacement.Replacements[j].Length == 1)
                        return replacement.Replacements[j][0];
                    return replacement.Replacements
                        [j][rand.Next(0, replacement.Replacements[j].Length)];
                }
            }

            return String.Empty;
        }

        private string GetAltResult()
        {
            string passWord = userKeywordsTextBox.Text;
            passWord = String.Concat(passWord.Where(c => !Char.IsWhiteSpace(c)));
            string result2 = String.Empty;

            BigLittersReplacements bld = new();
            SmallLittersReplacements sld = new();
            NumbersReplacements nd = new();

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
using MaterialSkin;
using MaterialSkin.Controls;
using PasswordGeneratorApp.Const;
using PasswordGeneratorApp.Generator;
using System;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    public partial class MainForm : MaterialForm
    {
        private readonly PasswordGenerator passwordGenerator;

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue400, Accent.Amber400, TextShade.WHITE);

            passwordGenerator = new PasswordGenerator();

            nonMemorableTextBox.Text = passwordGenerator.GenerateNonMemorablePassword(8);
        }

        private void StealFocus() => nonMemorablePageTitle.Focus();

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            if (allowNumbersCheckBox.Checked)
                passwordGenerator.Vocabulary += Constants.Numbers;
            if (allowSpecialSymbolsCheckBox.Checked)
                passwordGenerator.Vocabulary += Constants.SpecialSymbols;

            nonMemorableTextBox.Text = passwordGenerator.GenerateNonMemorablePassword(passwordSizeTrackBar.Value);
        }

        private void PasswordSizeTrackBarScroll(object sender, EventArgs e)
        {
            passwordLengthLabel.Text = "Password Length: " + passwordSizeTrackBar.Value;
            nonMemorableTextBox.Text = passwordGenerator.GenerateNonMemorablePassword(passwordSizeTrackBar.Value);

            StealFocus();
        }

        private void PasswordSizeTrackBarEnter(object sender, EventArgs e) => StealFocus();
            
        private void CopyNonMemorableButtonClick(object sender, EventArgs e)
        {
            Clipboard.SetText(nonMemorableTextBox.Text);
        }

        private void GenerateMemorablePasswordButtonClick(object sender, EventArgs e)
        {
            memorablePasswordTextBox.Text = passwordGenerator.GetMemorablePassword(userKeywordsTextBox.Text);
        }

        private void CopyMemorablePasswordButtonClick(object sender, EventArgs e)
        {
            Clipboard.SetText(memorablePasswordTextBox.Text);
        }
    }
}
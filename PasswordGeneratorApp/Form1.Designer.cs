using MaterialSkin;
using MaterialSkin.Controls;

namespace PasswordGeneratorApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            memorableTabPage = new System.Windows.Forms.TabPage();
            securePasswordLabel = new MaterialLabel();
            userKeywordsTextBox = new MaterialTextBox();
            memorablePasswordTextBox = new MaterialTextBox();
            copyMemorablePasswordButton = new MaterialButton();
            generateMemorablePasswordButton = new MaterialButton();
            yourKeywordsLabel = new MaterialLabel();
            nonMemorableTabPage = new System.Windows.Forms.TabPage();
            nonMemorablePageTitle = new MaterialLabel();
            copyNonMemorableButton = new MaterialButton();
            passwordLengthLabel = new MaterialLabel();
            passwordSizeTrackBar = new System.Windows.Forms.TrackBar();
            refreshButton = new MaterialButton();
            allowSpecialSymbolsCheckBox = new MaterialCheckbox();
            allowNumbersCheckBox = new MaterialCheckbox();
            nonMemorableTextBox = new MaterialTextBox();
            tabControl = new MaterialTabControl();
            tabSelector = new MaterialTabSelector();
            memorableTabPage.SuspendLayout();
            nonMemorableTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordSizeTrackBar).BeginInit();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // memorableTabPage
            // 
            memorableTabPage.BackColor = System.Drawing.Color.White;
            memorableTabPage.Controls.Add(securePasswordLabel);
            memorableTabPage.Controls.Add(userKeywordsTextBox);
            memorableTabPage.Controls.Add(memorablePasswordTextBox);
            memorableTabPage.Controls.Add(copyMemorablePasswordButton);
            memorableTabPage.Controls.Add(generateMemorablePasswordButton);
            memorableTabPage.Controls.Add(yourKeywordsLabel);
            memorableTabPage.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            memorableTabPage.Location = new System.Drawing.Point(4, 37);
            memorableTabPage.Name = "memorableTabPage";
            memorableTabPage.Padding = new System.Windows.Forms.Padding(3);
            memorableTabPage.Size = new System.Drawing.Size(683, 226);
            memorableTabPage.TabIndex = 1;
            memorableTabPage.Text = "Memorable";
            // 
            // securePasswordLabel
            // 
            securePasswordLabel.AutoSize = true;
            securePasswordLabel.Depth = 0;
            securePasswordLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            securePasswordLabel.FontType = MaterialSkinManager.fontType.H5;
            securePasswordLabel.ForeColor = System.Drawing.Color.Red;
            securePasswordLabel.Location = new System.Drawing.Point(10, 106);
            securePasswordLabel.MouseState = MouseState.HOVER;
            securePasswordLabel.Name = "securePasswordLabel";
            securePasswordLabel.Size = new System.Drawing.Size(242, 29);
            securePasswordLabel.TabIndex = 0;
            securePasswordLabel.Text = "Your Secure Password";
            // 
            // userKeywordsTextBox
            // 
            userKeywordsTextBox.AnimateReadOnly = false;
            userKeywordsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            userKeywordsTextBox.Depth = 0;
            userKeywordsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            userKeywordsTextBox.LeadingIcon = null;
            userKeywordsTextBox.Location = new System.Drawing.Point(10, 35);
            userKeywordsTextBox.MaxLength = 50;
            userKeywordsTextBox.MouseState = MouseState.OUT;
            userKeywordsTextBox.Multiline = false;
            userKeywordsTextBox.Name = "userKeywordsTextBox";
            userKeywordsTextBox.Size = new System.Drawing.Size(668, 50);
            userKeywordsTextBox.TabIndex = 1;
            userKeywordsTextBox.Text = "Keyword";
            userKeywordsTextBox.TrailingIcon = null;
            // 
            // memorablePasswordTextBox
            // 
            memorablePasswordTextBox.AnimateReadOnly = false;
            memorablePasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            memorablePasswordTextBox.Depth = 0;
            memorablePasswordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            memorablePasswordTextBox.LeadingIcon = null;
            memorablePasswordTextBox.Location = new System.Drawing.Point(10, 147);
            memorablePasswordTextBox.MaxLength = 50;
            memorablePasswordTextBox.MouseState = MouseState.OUT;
            memorablePasswordTextBox.Multiline = false;
            memorablePasswordTextBox.Name = "memorablePasswordTextBox";
            memorablePasswordTextBox.ReadOnly = true;
            memorablePasswordTextBox.Size = new System.Drawing.Size(668, 50);
            memorablePasswordTextBox.TabIndex = 2;
            memorablePasswordTextBox.Text = "";
            memorablePasswordTextBox.TrailingIcon = null;
            // 
            // copyMemorablePasswordButton
            // 
            copyMemorablePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            copyMemorablePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            copyMemorablePasswordButton.Density = MaterialButton.MaterialButtonDensity.Default;
            copyMemorablePasswordButton.Depth = 0;
            copyMemorablePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            copyMemorablePasswordButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            copyMemorablePasswordButton.HighEmphasis = true;
            copyMemorablePasswordButton.Icon = null;
            copyMemorablePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            copyMemorablePasswordButton.Location = new System.Drawing.Point(400, 206);
            copyMemorablePasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            copyMemorablePasswordButton.MaximumSize = new System.Drawing.Size(100, 50);
            copyMemorablePasswordButton.MinimumSize = new System.Drawing.Size(100, 50);
            copyMemorablePasswordButton.MouseState = MouseState.HOVER;
            copyMemorablePasswordButton.Name = "copyMemorablePasswordButton";
            copyMemorablePasswordButton.NoAccentTextColor = System.Drawing.Color.Empty;
            copyMemorablePasswordButton.Size = new System.Drawing.Size(100, 50);
            copyMemorablePasswordButton.TabIndex = 3;
            copyMemorablePasswordButton.Text = "Copy";
            copyMemorablePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            copyMemorablePasswordButton.Type = MaterialButton.MaterialButtonType.Contained;
            copyMemorablePasswordButton.UseAccentColor = false;
            copyMemorablePasswordButton.UseVisualStyleBackColor = true;
            copyMemorablePasswordButton.Click += CopyMemorablePasswordButtonClick;
            // 
            // generateMemorablePasswordButton
            // 
            generateMemorablePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            generateMemorablePasswordButton.BackColor = System.Drawing.Color.Transparent;
            generateMemorablePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            generateMemorablePasswordButton.Density = MaterialButton.MaterialButtonDensity.Default;
            generateMemorablePasswordButton.Depth = 0;
            generateMemorablePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            generateMemorablePasswordButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            generateMemorablePasswordButton.HighEmphasis = true;
            generateMemorablePasswordButton.Icon = null;
            generateMemorablePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            generateMemorablePasswordButton.Location = new System.Drawing.Point(195, 206);
            generateMemorablePasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            generateMemorablePasswordButton.MaximumSize = new System.Drawing.Size(100, 50);
            generateMemorablePasswordButton.MinimumSize = new System.Drawing.Size(100, 50);
            generateMemorablePasswordButton.MouseState = MouseState.HOVER;
            generateMemorablePasswordButton.Name = "generateMemorablePasswordButton";
            generateMemorablePasswordButton.NoAccentTextColor = System.Drawing.Color.Empty;
            generateMemorablePasswordButton.Size = new System.Drawing.Size(100, 50);
            generateMemorablePasswordButton.TabIndex = 4;
            generateMemorablePasswordButton.Text = "Generate";
            generateMemorablePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            generateMemorablePasswordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            generateMemorablePasswordButton.Type = MaterialButton.MaterialButtonType.Contained;
            generateMemorablePasswordButton.UseAccentColor = false;
            generateMemorablePasswordButton.UseVisualStyleBackColor = false;
            generateMemorablePasswordButton.Click += GenerateMemorablePasswordButtonClick;
            // 
            // yourKeywordsLabel
            // 
            yourKeywordsLabel.AutoSize = true;
            yourKeywordsLabel.Depth = 0;
            yourKeywordsLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            yourKeywordsLabel.FontType = MaterialSkinManager.fontType.H5;
            yourKeywordsLabel.ForeColor = System.Drawing.Color.Red;
            yourKeywordsLabel.Location = new System.Drawing.Point(10, 3);
            yourKeywordsLabel.MouseState = MouseState.HOVER;
            yourKeywordsLabel.Name = "yourKeywordsLabel";
            yourKeywordsLabel.Size = new System.Drawing.Size(161, 29);
            yourKeywordsLabel.TabIndex = 5;
            yourKeywordsLabel.Text = "Your Keywords";
            // 
            // nonMemorableTabPage
            // 
            nonMemorableTabPage.BackColor = System.Drawing.Color.White;
            nonMemorableTabPage.Controls.Add(nonMemorablePageTitle);
            nonMemorableTabPage.Controls.Add(copyNonMemorableButton);
            nonMemorableTabPage.Controls.Add(passwordLengthLabel);
            nonMemorableTabPage.Controls.Add(passwordSizeTrackBar);
            nonMemorableTabPage.Controls.Add(refreshButton);
            nonMemorableTabPage.Controls.Add(allowSpecialSymbolsCheckBox);
            nonMemorableTabPage.Controls.Add(allowNumbersCheckBox);
            nonMemorableTabPage.Controls.Add(nonMemorableTextBox);
            nonMemorableTabPage.Location = new System.Drawing.Point(4, 37);
            nonMemorableTabPage.Name = "nonMemorableTabPage";
            nonMemorableTabPage.Padding = new System.Windows.Forms.Padding(3);
            nonMemorableTabPage.Size = new System.Drawing.Size(683, 226);
            nonMemorableTabPage.TabIndex = 0;
            nonMemorableTabPage.Text = "Non-Memorable";
            // 
            // nonMemorablePageTitle
            // 
            nonMemorablePageTitle.AutoSize = true;
            nonMemorablePageTitle.BackColor = System.Drawing.Color.IndianRed;
            nonMemorablePageTitle.Depth = 0;
            nonMemorablePageTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            nonMemorablePageTitle.FontType = MaterialSkinManager.fontType.H5;
            nonMemorablePageTitle.ForeColor = System.Drawing.Color.Black;
            nonMemorablePageTitle.Location = new System.Drawing.Point(10, 3);
            nonMemorablePageTitle.MouseState = MouseState.HOVER;
            nonMemorablePageTitle.Name = "nonMemorablePageTitle";
            nonMemorablePageTitle.Size = new System.Drawing.Size(242, 29);
            nonMemorablePageTitle.TabIndex = 0;
            nonMemorablePageTitle.Text = "Your Secure Password";
            // 
            // copyNonMemorableButton
            // 
            copyNonMemorableButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            copyNonMemorableButton.BackColor = System.Drawing.Color.White;
            copyNonMemorableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            copyNonMemorableButton.Density = MaterialButton.MaterialButtonDensity.Default;
            copyNonMemorableButton.Depth = 0;
            copyNonMemorableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            copyNonMemorableButton.HighEmphasis = true;
            copyNonMemorableButton.Icon = null;
            copyNonMemorableButton.Location = new System.Drawing.Point(596, 35);
            copyNonMemorableButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            copyNonMemorableButton.MaximumSize = new System.Drawing.Size(80, 50);
            copyNonMemorableButton.MinimumSize = new System.Drawing.Size(80, 50);
            copyNonMemorableButton.MouseState = MouseState.HOVER;
            copyNonMemorableButton.Name = "copyNonMemorableButton";
            copyNonMemorableButton.NoAccentTextColor = System.Drawing.Color.Empty;
            copyNonMemorableButton.Size = new System.Drawing.Size(80, 50);
            copyNonMemorableButton.TabIndex = 1;
            copyNonMemorableButton.Text = "Copy";
            copyNonMemorableButton.Type = MaterialButton.MaterialButtonType.Contained;
            copyNonMemorableButton.UseAccentColor = false;
            copyNonMemorableButton.UseVisualStyleBackColor = false;
            copyNonMemorableButton.Click += CopyNonMemorableButtonClick;
            // 
            // passwordLengthLabel
            // 
            passwordLengthLabel.AutoSize = true;
            passwordLengthLabel.Depth = 0;
            passwordLengthLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            passwordLengthLabel.FontType = MaterialSkinManager.fontType.H6;
            passwordLengthLabel.ForeColor = System.Drawing.Color.Red;
            passwordLengthLabel.Location = new System.Drawing.Point(10, 130);
            passwordLengthLabel.MouseState = MouseState.HOVER;
            passwordLengthLabel.Name = "passwordLengthLabel";
            passwordLengthLabel.Size = new System.Drawing.Size(182, 24);
            passwordLengthLabel.TabIndex = 2;
            passwordLengthLabel.Text = "Password Length:  8";
            // 
            // passwordSizeTrackBar
            // 
            passwordSizeTrackBar.BackColor = System.Drawing.SystemColors.Window;
            passwordSizeTrackBar.Location = new System.Drawing.Point(10, 89);
            passwordSizeTrackBar.Maximum = 128;
            passwordSizeTrackBar.MaximumSize = new System.Drawing.Size(1000, 50);
            passwordSizeTrackBar.Minimum = 8;
            passwordSizeTrackBar.MinimumSize = new System.Drawing.Size(100, 50);
            passwordSizeTrackBar.Name = "passwordSizeTrackBar";
            passwordSizeTrackBar.Size = new System.Drawing.Size(665, 50);
            passwordSizeTrackBar.TabIndex = 3;
            passwordSizeTrackBar.TabStop = false;
            passwordSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            passwordSizeTrackBar.Value = 8;
            passwordSizeTrackBar.Scroll += PasswordSizeTrackBarScroll;
            passwordSizeTrackBar.Enter += PasswordSizeTrackBarEnter;
            // 
            // refreshButton
            // 
            refreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            refreshButton.BackColor = System.Drawing.Color.White;
            refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            refreshButton.Density = MaterialButton.MaterialButtonDensity.Default;
            refreshButton.Depth = 0;
            refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            refreshButton.HighEmphasis = true;
            refreshButton.Icon = null;
            refreshButton.Location = new System.Drawing.Point(511, 35);
            refreshButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            refreshButton.MaximumSize = new System.Drawing.Size(80, 50);
            refreshButton.MinimumSize = new System.Drawing.Size(80, 50);
            refreshButton.MouseState = MouseState.HOVER;
            refreshButton.Name = "refreshButton";
            refreshButton.NoAccentTextColor = System.Drawing.Color.Empty;
            refreshButton.Size = new System.Drawing.Size(80, 50);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Refresh";
            refreshButton.Type = MaterialButton.MaterialButtonType.Contained;
            refreshButton.UseAccentColor = false;
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += RefreshButtonClick;
            // 
            // allowSpecialSymbolsCheckBox
            // 
            allowSpecialSymbolsCheckBox.AutoSize = true;
            allowSpecialSymbolsCheckBox.Depth = 0;
            allowSpecialSymbolsCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            allowSpecialSymbolsCheckBox.Location = new System.Drawing.Point(3, 205);
            allowSpecialSymbolsCheckBox.Margin = new System.Windows.Forms.Padding(0);
            allowSpecialSymbolsCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            allowSpecialSymbolsCheckBox.MouseState = MouseState.HOVER;
            allowSpecialSymbolsCheckBox.Name = "allowSpecialSymbolsCheckBox";
            allowSpecialSymbolsCheckBox.ReadOnly = false;
            allowSpecialSymbolsCheckBox.Ripple = true;
            allowSpecialSymbolsCheckBox.Size = new System.Drawing.Size(192, 37);
            allowSpecialSymbolsCheckBox.TabIndex = 5;
            allowSpecialSymbolsCheckBox.Text = "Allow special symbols";
            allowSpecialSymbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowNumbersCheckBox
            // 
            allowNumbersCheckBox.AutoSize = true;
            allowNumbersCheckBox.Depth = 0;
            allowNumbersCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            allowNumbersCheckBox.Location = new System.Drawing.Point(3, 168);
            allowNumbersCheckBox.Margin = new System.Windows.Forms.Padding(0);
            allowNumbersCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            allowNumbersCheckBox.MouseState = MouseState.HOVER;
            allowNumbersCheckBox.Name = "allowNumbersCheckBox";
            allowNumbersCheckBox.ReadOnly = false;
            allowNumbersCheckBox.Ripple = true;
            allowNumbersCheckBox.Size = new System.Drawing.Size(140, 37);
            allowNumbersCheckBox.TabIndex = 6;
            allowNumbersCheckBox.Text = "Allow numbers";
            allowNumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // nonMemorableTextBox
            // 
            nonMemorableTextBox.AnimateReadOnly = false;
            nonMemorableTextBox.BackColor = System.Drawing.SystemColors.Control;
            nonMemorableTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            nonMemorableTextBox.Depth = 0;
            nonMemorableTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            nonMemorableTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            nonMemorableTextBox.LeadingIcon = null;
            nonMemorableTextBox.Location = new System.Drawing.Point(10, 35);
            nonMemorableTextBox.MaximumSize = new System.Drawing.Size(1000, 50);
            nonMemorableTextBox.MaxLength = 50;
            nonMemorableTextBox.MinimumSize = new System.Drawing.Size(100, 50);
            nonMemorableTextBox.MouseState = MouseState.OUT;
            nonMemorableTextBox.Multiline = false;
            nonMemorableTextBox.Name = "nonMemorableTextBox";
            nonMemorableTextBox.ReadOnly = true;
            nonMemorableTextBox.Size = new System.Drawing.Size(495, 50);
            nonMemorableTextBox.TabIndex = 7;
            nonMemorableTextBox.Text = "";
            nonMemorableTextBox.TrailingIcon = null;
            nonMemorableTextBox.WordWrap = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(nonMemorableTabPage);
            tabControl.Controls.Add(memorableTabPage);
            tabControl.Depth = 0;
            tabControl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl.Location = new System.Drawing.Point(6, 107);
            tabControl.MouseState = MouseState.HOVER;
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(691, 267);
            tabControl.TabIndex = 0;
            // 
            // tabSelector
            // 
            tabSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabSelector.BaseTabControl = tabControl;
            tabSelector.CharacterCasing = MaterialTabSelector.CustomCharacterCasing.Proper;
            tabSelector.Depth = 0;
            tabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tabSelector.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tabSelector.Location = new System.Drawing.Point(0, 64);
            tabSelector.Margin = new System.Windows.Forms.Padding(0);
            tabSelector.MouseState = MouseState.HOVER;
            tabSelector.Name = "tabSelector";
            tabSelector.Size = new System.Drawing.Size(700, 37);
            tabSelector.TabIndex = 0;
            tabSelector.Text = "materialTabSelector1";
            // 
            // MainForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.AliceBlue;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(700, 380);
            Controls.Add(tabControl);
            Controls.Add(tabSelector);
            Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(700, 380);
            MinimumSize = new System.Drawing.Size(700, 380);
            Name = "MainForm";
            Padding = new System.Windows.Forms.Padding(0, 64, 0, 3);
            Sizable = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PasswordGenerator";
            memorableTabPage.ResumeLayout(false);
            memorableTabPage.PerformLayout();
            nonMemorableTabPage.ResumeLayout(false);
            nonMemorableTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordSizeTrackBar).EndInit();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage memorableTabPage;
        private MaterialButton copyMemorablePasswordButton;
        private MaterialButton generateMemorablePasswordButton;
        private MaterialTextBox memorablePasswordTextBox;
        private System.Windows.Forms.TabPage nonMemorableTabPage;
        private MaterialButton copyNonMemorableButton; 
        private System.Windows.Forms.TrackBar passwordSizeTrackBar; 
        private MaterialLabel nonMemorablePageTitle;
        private MaterialButton refreshButton;
        private MaterialCheckbox allowSpecialSymbolsCheckBox;
        private MaterialCheckbox allowNumbersCheckBox;
        private MaterialTextBox nonMemorableTextBox;
        private MaterialTabControl tabControl;
        private MaterialLabel yourKeywordsLabel;
        private MaterialLabel passwordLengthLabel;
        private MaterialTabSelector tabSelector;
        private MaterialTextBox userKeywordsTextBox;
        private MaterialLabel securePasswordLabel;
    }
}


using MaterialSkin;
using MaterialSkin.Controls;

namespace PasswordGeneratorApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPage2 = new System.Windows.Forms.TabPage();
            materialLabel1 = new MaterialLabel();
            textBox2 = new MaterialTextBox();
            textBox3 = new MaterialTextBox();
            button4 = new MaterialButton();
            button3 = new MaterialButton();
            label3 = new MaterialLabel();
            tabPage1 = new System.Windows.Forms.TabPage();
            label1 = new MaterialLabel();
            button2 = new MaterialButton();
            label2 = new MaterialLabel();
            trackBar1 = new System.Windows.Forms.TrackBar();
            button1 = new MaterialButton();
            checkBox2 = new MaterialCheckbox();
            checkBox1 = new MaterialCheckbox();
            textBox1 = new MaterialTextBox();
            tabControl1 = new MaterialTabControl();
            materialTabSelector1 = new MaterialTabSelector();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.White;
            tabPage2.Controls.Add(materialLabel1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label3);
            tabPage2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabPage2.Location = new System.Drawing.Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(683, 226);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Memorable";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkinManager.fontType.H5;
            materialLabel1.ForeColor = System.Drawing.Color.Red;
            materialLabel1.Location = new System.Drawing.Point(10, 106);
            materialLabel1.MouseState = MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(242, 29);
            materialLabel1.TabIndex = 20;
            materialLabel1.Text = "Your Secure Password";
            // 
            // textBox2
            // 
            textBox2.AnimateReadOnly = false;
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Depth = 0;
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.LeadingIcon = null;
            textBox2.Location = new System.Drawing.Point(10, 35);
            textBox2.MaxLength = 50;
            textBox2.MouseState = MouseState.OUT;
            textBox2.Multiline = false;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(668, 50);
            textBox2.TabIndex = 19;
            textBox2.Text = "Keyword";
            textBox2.TrailingIcon = null;
            // 
            // textBox3
            // 
            textBox3.AnimateReadOnly = false;
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox3.Depth = 0;
            textBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            textBox3.LeadingIcon = null;
            textBox3.Location = new System.Drawing.Point(10, 147);
            textBox3.MaxLength = 50;
            textBox3.MouseState = MouseState.OUT;
            textBox3.Multiline = false;
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(668, 50);
            textBox3.TabIndex = 18;
            textBox3.Text = "";
            textBox3.TrailingIcon = null;
            // 
            // button4
            // 
            button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button4.Density = MaterialButton.MaterialButtonDensity.Default;
            button4.Depth = 0;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.HighEmphasis = true;
            button4.Icon = null;
            button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.Location = new System.Drawing.Point(400, 206);
            button4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            button4.MaximumSize = new System.Drawing.Size(100, 50);
            button4.MinimumSize = new System.Drawing.Size(100, 50);
            button4.MouseState = MouseState.HOVER;
            button4.Name = "button4";
            button4.NoAccentTextColor = System.Drawing.Color.Empty;
            button4.Size = new System.Drawing.Size(100, 50);
            button4.TabIndex = 17;
            button4.Text = "Copy";
            button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.Type = MaterialButton.MaterialButtonType.Contained;
            button4.UseAccentColor = false;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button3.BackColor = System.Drawing.Color.Transparent;
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button3.Density = MaterialButton.MaterialButtonDensity.Default;
            button3.Depth = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.HighEmphasis = true;
            button3.Icon = null;
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.Location = new System.Drawing.Point(195, 206);
            button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            button3.MaximumSize = new System.Drawing.Size(100, 50);
            button3.MinimumSize = new System.Drawing.Size(100, 50);
            button3.MouseState = MouseState.HOVER;
            button3.Name = "button3";
            button3.NoAccentTextColor = System.Drawing.Color.Empty;
            button3.Size = new System.Drawing.Size(100, 50);
            button3.TabIndex = 16;
            button3.Text = "Generate";
            button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button3.Type = MaterialButton.MaterialButtonType.Contained;
            button3.UseAccentColor = false;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Depth = 0;
            label3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            label3.FontType = MaterialSkinManager.fontType.H5;
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(10, 3);
            label3.MouseState = MouseState.HOVER;
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(161, 29);
            label3.TabIndex = 13;
            label3.Text = "Your Keywords";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.White;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(trackBar1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new System.Drawing.Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(683, 226);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Non-Memorable";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.IndianRed;
            label1.Depth = 0;
            label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            label1.FontType = MaterialSkinManager.fontType.H5;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(10, 3);
            label1.MouseState = MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(242, 29);
            label1.TabIndex = 12;
            label1.Text = "Your Secure Password";
            // 
            // button2
            // 
            button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button2.BackColor = System.Drawing.Color.White;
            button2.BackgroundImage = Properties.Resources.Copy;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.Density = MaterialButton.MaterialButtonDensity.Default;
            button2.Depth = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.HighEmphasis = true;
            button2.Icon = null;
            button2.Location = new System.Drawing.Point(596, 35);
            button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            button2.MaximumSize = new System.Drawing.Size(80, 50);
            button2.MinimumSize = new System.Drawing.Size(80, 50);
            button2.MouseState = MouseState.HOVER;
            button2.Name = "button2";
            button2.NoAccentTextColor = System.Drawing.Color.Empty;
            button2.Size = new System.Drawing.Size(80, 50);
            button2.TabIndex = 16;
            button2.Text = "Copy";
            button2.Type = MaterialButton.MaterialButtonType.Contained;
            button2.UseAccentColor = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Depth = 0;
            label2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            label2.FontType = MaterialSkinManager.fontType.H6;
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(10, 130);
            label2.MouseState = MouseState.HOVER;
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(182, 24);
            label2.TabIndex = 15;
            label2.Text = "Password Length:  8";
            // 
            // trackBar1
            // 
            trackBar1.BackColor = System.Drawing.SystemColors.Window;
            trackBar1.Location = new System.Drawing.Point(10, 89);
            trackBar1.MaximumSize = new System.Drawing.Size(1000, 50);
            trackBar1.MinimumSize = new System.Drawing.Size(100, 50);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(665, 50);
            trackBar1.TabIndex = 0;
            trackBar1.TabStop = false;
            trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button1
            // 
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImage = Properties.Resources.Button_Refresh_icon;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Density = MaterialButton.MaterialButtonDensity.Default;
            button1.Depth = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.HighEmphasis = true;
            button1.Icon = null;
            button1.Image = Properties.Resources.Button_Refresh_icon;
            button1.Location = new System.Drawing.Point(511, 35);
            button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            button1.MaximumSize = new System.Drawing.Size(80, 50);
            button1.MinimumSize = new System.Drawing.Size(80, 50);
            button1.MouseState = MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = System.Drawing.Color.Empty;
            button1.Size = new System.Drawing.Size(80, 50);
            button1.TabIndex = 11;
            button1.Text = "Refresh";
            button1.Type = MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Depth = 0;
            checkBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox2.Location = new System.Drawing.Point(3, 205);
            checkBox2.Margin = new System.Windows.Forms.Padding(0);
            checkBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBox2.MouseState = MouseState.HOVER;
            checkBox2.Name = "checkBox2";
            checkBox2.ReadOnly = false;
            checkBox2.Ripple = true;
            checkBox2.Size = new System.Drawing.Size(192, 37);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Allow special symbols";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Depth = 0;
            checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(3, 168);
            checkBox1.Margin = new System.Windows.Forms.Padding(0);
            checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBox1.MouseState = MouseState.HOVER;
            checkBox1.Name = "checkBox1";
            checkBox1.ReadOnly = false;
            checkBox1.Ripple = true;
            checkBox1.Size = new System.Drawing.Size(140, 37);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Allow numbers";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.AnimateReadOnly = false;
            textBox1.BackColor = System.Drawing.SystemColors.Control;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Depth = 0;
            textBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            textBox1.LeadingIcon = null;
            textBox1.Location = new System.Drawing.Point(10, 35);
            textBox1.MaximumSize = new System.Drawing.Size(1000, 50);
            textBox1.MaxLength = 50;
            textBox1.MinimumSize = new System.Drawing.Size(100, 50);
            textBox1.MouseState = MouseState.OUT;
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(495, 50);
            textBox1.TabIndex = 8;
            textBox1.Text = "";
            textBox1.TrailingIcon = null;
            textBox1.WordWrap = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Depth = 0;
            tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl1.Location = new System.Drawing.Point(6, 107);
            tabControl1.MouseState = MouseState.HOVER;
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(691, 267);
            tabControl1.TabIndex = 1;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            materialTabSelector1.BaseTabControl = tabControl1;
            materialTabSelector1.CharacterCasing = MaterialTabSelector.CustomCharacterCasing.Proper;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTabSelector1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            materialTabSelector1.MouseState = MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new System.Drawing.Size(700, 37);
            materialTabSelector1.TabIndex = 1;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.AliceBlue;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(700, 380);
            Controls.Add(tabControl1);
            Controls.Add(materialTabSelector1);
            Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(700, 380);
            MinimumSize = new System.Drawing.Size(700, 380);
            Name = "Form1";
            Padding = new System.Windows.Forms.Padding(0, 64, 0, 3);
            Sizable = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PasswordGenerator";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private MaterialButton button4;
        private MaterialButton button3;
        private MaterialTextBox textBox3;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialButton button2; 
        private System.Windows.Forms.TrackBar trackBar1; 
        private MaterialLabel label1;
        private MaterialButton button1;
        private MaterialCheckbox checkBox2;
        private MaterialCheckbox checkBox1;
        private MaterialTextBox textBox1;
        private MaterialTabControl tabControl1;
        private MaterialLabel label3;
        private MaterialLabel label2;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTextBox textBox2;
        private MaterialLabel materialLabel1;
    }
}


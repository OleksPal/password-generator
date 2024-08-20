
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
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            tabPage1 = new System.Windows.Forms.TabPage();
            button2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            trackBar1 = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            textBox1 = new System.Windows.Forms.TextBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(680, 244);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Memorable";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Copy;
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.Location = new System.Drawing.Point(374, 194);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(104, 34);
            button4.TabIndex = 17;
            button4.Text = "   Copy";
            button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button3.BackColor = System.Drawing.Color.Transparent;
            button3.BackgroundImage = Properties.Resources.Button_Refresh_icon;
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.Location = new System.Drawing.Point(166, 194);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(104, 34);
            button3.TabIndex = 16;
            button3.Text = "Refresh";
            button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox3.Location = new System.Drawing.Point(6, 126);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(665, 34);
            textBox3.TabIndex = 15;
            textBox3.Text = " ";
            textBox3.WordWrap = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(6, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(665, 34);
            textBox2.TabIndex = 14;
            textBox2.Text = "Enter your code phrase...";
            textBox2.WordWrap = false;
            textBox2.MouseClick += textBox2_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(0, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(360, 46);
            label3.TabIndex = 13;
            label3.Text = "Your Secure Password";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(trackBar1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(680, 244);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Non-Memorable";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.BackgroundImage = Properties.Resources.Copy;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(637, 53);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(34, 34);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(9, 152);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(238, 33);
            label2.TabIndex = 15;
            label2.Text = "Password Length:  8";
            // 
            // trackBar1
            // 
            trackBar1.BackColor = System.Drawing.SystemColors.Window;
            trackBar1.Location = new System.Drawing.Point(-4, 93);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(678, 56);
            trackBar1.TabIndex = 14;
            trackBar1.Value = 8;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(3, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(360, 46);
            label1.TabIndex = 12;
            label1.Text = "Your Secure Password";
            // 
            // button1
            // 
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImage = Properties.Resources.Button_Refresh_icon;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(597, 53);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(34, 34);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox2.Location = new System.Drawing.Point(9, 220);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(231, 32);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Allow special symbols";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(9, 188);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(167, 32);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Allow numbers";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(3, 53);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(588, 34);
            textBox1.TabIndex = 8;
            textBox1.WordWrap = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(6, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(688, 277);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(700, 360);
            Controls.Add(tabControl1);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}


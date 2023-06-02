namespace ConvertToHex
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
            pictureBox1 = new PictureBox();
            Submitbtn = new Button();
            radioButton32x64 = new RadioButton();
            radioButton64x32 = new RadioButton();
            radioButton32x128 = new RadioButton();
            textBox1 = new TextBox();
            Copybtn = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            radioButton64x64 = new RadioButton();
            quitbtn = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Submitbtn
            // 
            Submitbtn.Cursor = Cursors.Hand;
            Submitbtn.Location = new Point(120, 272);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(144, 23);
            Submitbtn.TabIndex = 1;
            Submitbtn.Text = "Chuyển đổi";
            Submitbtn.UseVisualStyleBackColor = true;
            Submitbtn.Click += button1_Click;
            // 
            // radioButton32x64
            // 
            radioButton32x64.AutoSize = true;
            radioButton32x64.Cursor = Cursors.Hand;
            radioButton32x64.Location = new Point(12, 235);
            radioButton32x64.Name = "radioButton32x64";
            radioButton32x64.Size = new Size(55, 19);
            radioButton32x64.TabIndex = 2;
            radioButton32x64.TabStop = true;
            radioButton32x64.Text = "32x64";
            radioButton32x64.UseVisualStyleBackColor = true;
            radioButton32x64.CheckedChanged += radioButton32x64_CheckedChanged;
            // 
            // radioButton64x32
            // 
            radioButton64x32.AutoSize = true;
            radioButton64x32.Cursor = Cursors.Hand;
            radioButton64x32.Location = new Point(12, 260);
            radioButton64x32.Name = "radioButton64x32";
            radioButton64x32.Size = new Size(55, 19);
            radioButton64x32.TabIndex = 3;
            radioButton64x32.TabStop = true;
            radioButton64x32.Text = "64x32";
            radioButton64x32.UseVisualStyleBackColor = true;
            radioButton64x32.CheckedChanged += radioButton64x32_CheckedChanged;
            // 
            // radioButton32x128
            // 
            radioButton32x128.AutoSize = true;
            radioButton32x128.Cursor = Cursors.Hand;
            radioButton32x128.Location = new Point(12, 310);
            radioButton32x128.Name = "radioButton32x128";
            radioButton32x128.Size = new Size(61, 19);
            radioButton32x128.TabIndex = 4;
            radioButton32x128.TabStop = true;
            radioButton32x128.Text = "32x128";
            radioButton32x128.UseVisualStyleBackColor = true;
            radioButton32x128.CheckedChanged += radioButton32x128_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(346, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(442, 283);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Copybtn
            // 
            Copybtn.Cursor = Cursors.Hand;
            Copybtn.Location = new Point(660, 310);
            Copybtn.Name = "Copybtn";
            Copybtn.Size = new Size(117, 23);
            Copybtn.TabIndex = 6;
            Copybtn.Text = "Copy";
            Copybtn.UseVisualStyleBackColor = true;
            Copybtn.Click += Copybtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.No;
            label1.Location = new Point(12, 206);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 7;
            label1.Text = "Chọn kích thước";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(120, 168);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 8;
            button1.Text = "Select...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(539, 311);
            button2.Name = "button2";
            button2.Size = new Size(115, 22);
            button2.TabIndex = 11;
            button2.Text = "Clear Box";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // radioButton64x64
            // 
            radioButton64x64.AutoSize = true;
            radioButton64x64.Cursor = Cursors.Hand;
            radioButton64x64.Location = new Point(12, 285);
            radioButton64x64.Name = "radioButton64x64";
            radioButton64x64.Size = new Size(55, 19);
            radioButton64x64.TabIndex = 12;
            radioButton64x64.TabStop = true;
            radioButton64x64.Text = "64x64";
            radioButton64x64.UseVisualStyleBackColor = true;
            radioButton64x64.CheckedChanged += radioButton64x64_CheckedChanged;
            // 
            // quitbtn
            // 
            quitbtn.Cursor = Cursors.Hand;
            quitbtn.Location = new Point(660, 354);
            quitbtn.Name = "quitbtn";
            quitbtn.Size = new Size(117, 23);
            quitbtn.TabIndex = 13;
            quitbtn.Text = "Quit";
            quitbtn.UseVisualStyleBackColor = true;
            quitbtn.Click += quitbtn_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(539, 354);
            button3.Name = "button3";
            button3.Size = new Size(117, 23);
            button3.TabIndex = 14;
            button3.Text = "Restart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 389);
            Controls.Add(button3);
            Controls.Add(quitbtn);
            Controls.Add(radioButton64x64);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Copybtn);
            Controls.Add(textBox1);
            Controls.Add(radioButton32x128);
            Controls.Add(radioButton64x32);
            Controls.Add(radioButton32x64);
            Controls.Add(Submitbtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "ConvertToHex";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Submitbtn;
        private RadioButton radioButton32x64;
        private RadioButton radioButton64x32;
        private RadioButton radioButton32x128;
        private TextBox textBox1;
        private Button Copybtn;
        private Label label1;
        private Button button1;
        private Button button2;
        private RadioButton radioButton64x64;
        private Button quitbtn;
        private Button button3;
    }
}
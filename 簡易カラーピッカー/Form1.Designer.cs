namespace 簡易カラーピッカー
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picOut = new System.Windows.Forms.PictureBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rrggbb = new System.Windows.Forms.TextBox();
            this.rgb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dB = new System.Windows.Forms.TextBox();
            this.dG = new System.Windows.Forms.TextBox();
            this.xB = new System.Windows.Forms.TextBox();
            this.xG = new System.Windows.Forms.TextBox();
            this.xR = new System.Windows.Forms.TextBox();
            this.dR = new System.Windows.Forms.TextBox();
            this.groupMacro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).BeginInit();
            this.groupOutput.SuspendLayout();
            this.groupMacro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(6, 18);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(128, 128);
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            this.pic1.Paint += new System.Windows.Forms.PaintEventHandler(this.pic1_Paint);
            this.pic1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseClick);
            this.pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseDown);
            this.pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseMove);
            this.pic1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseUp);
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2.Location = new System.Drawing.Point(140, 18);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(32, 128);
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            this.pic2.Paint += new System.Windows.Forms.PaintEventHandler(this.pic2_Paint);
            this.pic2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic2_MouseClick);
            this.pic2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic2_MouseDown);
            this.pic2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic2_MouseMove);
            this.pic2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic2_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic1);
            this.groupBox1.Controls.Add(this.pic2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "カラーピッカー";
            // 
            // picOut
            // 
            this.picOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOut.Location = new System.Drawing.Point(6, 18);
            this.picOut.Name = "picOut";
            this.picOut.Size = new System.Drawing.Size(64, 64);
            this.picOut.TabIndex = 3;
            this.picOut.TabStop = false;
            this.picOut.Paint += new System.Windows.Forms.PaintEventHandler(this.picOut_Paint);
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.label7);
            this.groupOutput.Controls.Add(this.label6);
            this.groupOutput.Controls.Add(this.rrggbb);
            this.groupOutput.Controls.Add(this.rgb);
            this.groupOutput.Controls.Add(this.label3);
            this.groupOutput.Controls.Add(this.label2);
            this.groupOutput.Controls.Add(this.label5);
            this.groupOutput.Controls.Add(this.label4);
            this.groupOutput.Controls.Add(this.label1);
            this.groupOutput.Controls.Add(this.dB);
            this.groupOutput.Controls.Add(this.dG);
            this.groupOutput.Controls.Add(this.xB);
            this.groupOutput.Controls.Add(this.xG);
            this.groupOutput.Controls.Add(this.xR);
            this.groupOutput.Controls.Add(this.dR);
            this.groupOutput.Controls.Add(this.picOut);
            this.groupOutput.Location = new System.Drawing.Point(198, 12);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(187, 163);
            this.groupOutput.TabIndex = 5;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "出力";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "0xRRGGBB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "0xRGB";
            // 
            // rrggbb
            // 
            this.rrggbb.Location = new System.Drawing.Point(87, 108);
            this.rrggbb.Name = "rrggbb";
            this.rrggbb.ReadOnly = true;
            this.rrggbb.Size = new System.Drawing.Size(81, 19);
            this.rrggbb.TabIndex = 6;
            // 
            // rgb
            // 
            this.rgb.Location = new System.Drawing.Point(87, 133);
            this.rgb.Name = "rgb";
            this.rgb.ReadOnly = true;
            this.rgb.Size = new System.Drawing.Size(50, 19);
            this.rgb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "16進数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "10進数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // dB
            // 
            this.dB.Location = new System.Drawing.Point(95, 83);
            this.dB.Name = "dB";
            this.dB.ReadOnly = true;
            this.dB.Size = new System.Drawing.Size(39, 19);
            this.dB.TabIndex = 4;
            // 
            // dG
            // 
            this.dG.Location = new System.Drawing.Point(95, 58);
            this.dG.Name = "dG";
            this.dG.ReadOnly = true;
            this.dG.Size = new System.Drawing.Size(39, 19);
            this.dG.TabIndex = 4;
            // 
            // xB
            // 
            this.xB.Location = new System.Drawing.Point(140, 83);
            this.xB.Name = "xB";
            this.xB.ReadOnly = true;
            this.xB.Size = new System.Drawing.Size(39, 19);
            this.xB.TabIndex = 4;
            // 
            // xG
            // 
            this.xG.Location = new System.Drawing.Point(140, 58);
            this.xG.Name = "xG";
            this.xG.ReadOnly = true;
            this.xG.Size = new System.Drawing.Size(39, 19);
            this.xG.TabIndex = 4;
            // 
            // xR
            // 
            this.xR.Location = new System.Drawing.Point(140, 33);
            this.xR.Name = "xR";
            this.xR.ReadOnly = true;
            this.xR.Size = new System.Drawing.Size(39, 19);
            this.xR.TabIndex = 4;
            // 
            // dR
            // 
            this.dR.Location = new System.Drawing.Point(95, 33);
            this.dR.Name = "dR";
            this.dR.ReadOnly = true;
            this.dR.Size = new System.Drawing.Size(39, 19);
            this.dR.TabIndex = 4;
            // 
            // groupMacro
            // 
            this.groupMacro.Controls.Add(this.button1);
            this.groupMacro.Controls.Add(this.textBox2);
            this.groupMacro.Controls.Add(this.textBox1);
            this.groupMacro.Controls.Add(this.label11);
            this.groupMacro.Controls.Add(this.label10);
            this.groupMacro.Location = new System.Drawing.Point(12, 181);
            this.groupMacro.Name = "groupMacro";
            this.groupMacro.Size = new System.Drawing.Size(228, 66);
            this.groupMacro.TabIndex = 8;
            this.groupMacro.TabStop = false;
            this.groupMacro.Text = "マクロ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "？";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(138, 19);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "\\r,\\g,\\b";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "出力";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "入力";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(395, 255);
            this.Controls.Add(this.groupMacro);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "簡易カラーピッカー　Ver1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).EndInit();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.groupMacro.ResumeLayout(false);
            this.groupMacro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picOut;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dB;
        private System.Windows.Forms.TextBox dG;
        private System.Windows.Forms.TextBox xR;
        private System.Windows.Forms.TextBox xB;
        private System.Windows.Forms.TextBox xG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rgb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rrggbb;
        private System.Windows.Forms.GroupBox groupMacro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}


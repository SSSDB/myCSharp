namespace HomeWork7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1Pen = new System.Windows.Forms.ComboBox();
            this.textLength = new System.Windows.Forms.TextBox();
            this.textPer1 = new System.Windows.Forms.TextBox();
            this.textPer2 = new System.Windows.Forms.TextBox();
            this.textTh1 = new System.Windows.Forms.TextBox();
            this.textTh2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_depth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 426);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "主干长度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "左分支角度";
            // 
            // comboBox1Pen
            // 
            this.comboBox1Pen.FormattingEnabled = true;
            this.comboBox1Pen.Items.AddRange(new object[] {
            "红色",
            "蓝色",
            "黑色",
            "紫色",
            "绿色"});
            this.comboBox1Pen.Location = new System.Drawing.Point(667, 266);
            this.comboBox1Pen.Name = "comboBox1Pen";
            this.comboBox1Pen.Size = new System.Drawing.Size(121, 23);
            this.comboBox1Pen.TabIndex = 9;
            this.comboBox1Pen.SelectedIndexChanged += new System.EventHandler(this.comboBox1Pen_SelectedIndexChanged);
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(688, 58);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(100, 25);
            this.textLength.TabIndex = 11;
            this.textLength.TextChanged += new System.EventHandler(this.textLength_TextChanged);
            // 
            // textPer1
            // 
            this.textPer1.Location = new System.Drawing.Point(688, 101);
            this.textPer1.Name = "textPer1";
            this.textPer1.Size = new System.Drawing.Size(100, 25);
            this.textPer1.TabIndex = 12;
            this.textPer1.TextChanged += new System.EventHandler(this.textPer1_TextChanged);
            // 
            // textPer2
            // 
            this.textPer2.Location = new System.Drawing.Point(688, 139);
            this.textPer2.Name = "textPer2";
            this.textPer2.Size = new System.Drawing.Size(100, 25);
            this.textPer2.TabIndex = 13;
            this.textPer2.TextChanged += new System.EventHandler(this.textPer2_TextChanged);
            // 
            // textTh1
            // 
            this.textTh1.Location = new System.Drawing.Point(688, 179);
            this.textTh1.Name = "textTh1";
            this.textTh1.Size = new System.Drawing.Size(100, 25);
            this.textTh1.TabIndex = 14;
            this.textTh1.TextChanged += new System.EventHandler(this.textTh1_TextChanged);
            // 
            // textTh2
            // 
            this.textTh2.Location = new System.Drawing.Point(688, 222);
            this.textTh2.Name = "textTh2";
            this.textTh2.Size = new System.Drawing.Size(100, 25);
            this.textTh2.TabIndex = 15;
            this.textTh2.TextChanged += new System.EventHandler(this.textTh2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "左分支长度比";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "颜色";
            // 
            // text_depth
            // 
            this.text_depth.Location = new System.Drawing.Point(688, 19);
            this.text_depth.Name = "text_depth";
            this.text_depth.Size = new System.Drawing.Size(100, 25);
            this.text_depth.TabIndex = 19;
            this.text_depth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_depth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTh2);
            this.Controls.Add(this.textTh1);
            this.Controls.Add(this.textPer2);
            this.Controls.Add(this.textPer1);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.comboBox1Pen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1Pen;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.TextBox textPer1;
        private System.Windows.Forms.TextBox textPer2;
        private System.Windows.Forms.TextBox textTh1;
        private System.Windows.Forms.TextBox textTh2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_depth;
    }
}


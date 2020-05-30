namespace Calculator
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
            this.btn_calculator = new System.Windows.Forms.Button();
            this.textBox_num1 = new System.Windows.Forms.TextBox();
            this.textBox_num2 = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_num1 = new System.Windows.Forms.Label();
            this.label_num2 = new System.Windows.Forms.Label();
            this.label_operator = new System.Windows.Forms.Label();
            this.comboBox_operator = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_calculator
            // 
            this.btn_calculator.Location = new System.Drawing.Point(571, 60);
            this.btn_calculator.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calculator.Name = "btn_calculator";
            this.btn_calculator.Size = new System.Drawing.Size(106, 50);
            this.btn_calculator.TabIndex = 0;
            this.btn_calculator.Text = "计算";
            this.btn_calculator.UseVisualStyleBackColor = true;
            this.btn_calculator.Click += new System.EventHandler(this.btn_calculator_Click);
            // 
            // textBox_num1
            // 
            this.textBox_num1.Location = new System.Drawing.Point(255, 56);
            this.textBox_num1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_num1.Name = "textBox_num1";
            this.textBox_num1.Size = new System.Drawing.Size(148, 28);
            this.textBox_num1.TabIndex = 1;
            this.textBox_num1.TextChanged += new System.EventHandler(this.textBox_num1_TextChanged);
            // 
            // textBox_num2
            // 
            this.textBox_num2.Location = new System.Drawing.Point(255, 163);
            this.textBox_num2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_num2.Name = "textBox_num2";
            this.textBox_num2.Size = new System.Drawing.Size(148, 28);
            this.textBox_num2.TabIndex = 2;
            this.textBox_num2.TextChanged += new System.EventHandler(this.textBox_num2_TextChanged);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(538, 135);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(174, 28);
            this.textBox_result.TabIndex = 6;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_result_TextChanged);
            // 
            // label_num1
            // 
            this.label_num1.AutoSize = true;
            this.label_num1.Location = new System.Drawing.Point(130, 60);
            this.label_num1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_num1.Name = "label_num1";
            this.label_num1.Size = new System.Drawing.Size(116, 18);
            this.label_num1.TabIndex = 3;
            this.label_num1.Text = "第一个操作数";
            // 
            // label_num2
            // 
            this.label_num2.AutoSize = true;
            this.label_num2.Location = new System.Drawing.Point(130, 167);
            this.label_num2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_num2.Name = "label_num2";
            this.label_num2.Size = new System.Drawing.Size(116, 18);
            this.label_num2.TabIndex = 4;
            this.label_num2.Text = "第二个操作数";
            // 
            // label_operator
            // 
            this.label_operator.AutoSize = true;
            this.label_operator.Location = new System.Drawing.Point(170, 117);
            this.label_operator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_operator.Name = "label_operator";
            this.label_operator.Size = new System.Drawing.Size(62, 18);
            this.label_operator.TabIndex = 7;
            this.label_operator.Text = "操作符";
            // 
            // comboBox_operator
            // 
            this.comboBox_operator.FormattingEnabled = true;
            this.comboBox_operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox_operator.Location = new System.Drawing.Point(255, 112);
            this.comboBox_operator.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_operator.Name = "comboBox_operator";
            this.comboBox_operator.Size = new System.Drawing.Size(148, 26);
            this.comboBox_operator.TabIndex = 8;
            this.comboBox_operator.SelectedIndexChanged += new System.EventHandler(this.comboBox_operator_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 249);
            this.Controls.Add(this.comboBox_operator);
            this.Controls.Add(this.label_operator);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label_num2);
            this.Controls.Add(this.label_num1);
            this.Controls.Add(this.textBox_num2);
            this.Controls.Add(this.textBox_num1);
            this.Controls.Add(this.btn_calculator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculator;
        private System.Windows.Forms.TextBox textBox_num1;
        private System.Windows.Forms.TextBox textBox_num2;
        private System.Windows.Forms.Label label_num1;
        private System.Windows.Forms.Label label_num2;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_operator;
        private System.Windows.Forms.ComboBox comboBox_operator;
    }
}


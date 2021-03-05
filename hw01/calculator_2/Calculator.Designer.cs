
namespace calculator_2
{
    partial class Calculator
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
            this.result = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.opt2 = new System.Windows.Forms.TextBox();
            this.opt = new System.Windows.Forms.ComboBox();
            this.opt1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.Location = new System.Drawing.Point(309, 57);
            this.result.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 5;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equal.Location = new System.Drawing.Point(283, 55);
            this.equal.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(19, 19);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            // 
            // opt2
            // 
            this.opt2.Location = new System.Drawing.Point(205, 55);
            this.opt2.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(65, 21);
            this.opt2.TabIndex = 1;
            this.opt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // opt
            // 
            this.opt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.opt.FormattingEnabled = true;
            this.opt.Items.AddRange(new object[] {
            "+",
            "-",
            "×",
            "÷"});
            this.opt.Location = new System.Drawing.Point(151, 55);
            this.opt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(34, 20);
            this.opt.TabIndex = 2;
            this.opt.SelectedIndexChanged += new System.EventHandler(this.op_SelectedIndexChanged);
            // 
            // opt1
            // 
            this.opt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opt1.Location = new System.Drawing.Point(67, 55);
            this.opt1.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(65, 21);
            this.opt1.TabIndex = 0;
            this.opt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opt1_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(309, 81);
            this.button1.MaximumSize = new System.Drawing.Size(80, 40);
            this.button1.MinimumSize = new System.Drawing.Size(35, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.39376F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.60624F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.opt1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.opt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.opt2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.equal, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.result, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.68165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.31835F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 157);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 157);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(385, 195);
            this.Name = "Calculator";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.TextBox opt2;
        private System.Windows.Forms.ComboBox opt;
        private System.Windows.Forms.TextBox opt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}


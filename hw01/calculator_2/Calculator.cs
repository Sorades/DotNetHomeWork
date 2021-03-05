using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_2
{
    public partial class Calculator : Form
    {
        private string op = null;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '.')//允许退格和小数
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                    e.Handled = true;//当输入键不为0-9的数字键则不处理该事件
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.opt1.Text != "" && this.opt2.Text != "")
            {
                double num1 = double.Parse(this.opt1.Text);//将文本框中的数字转为double类型变量储存
                double num2 = double.Parse(this.opt2.Text);
                string result = null;
                switch (this.op)//进行运算
                {
                    case "+":
                        result = (num1 + num2).ToString();
                        break;
                    case "-":
                        result = (num1 - num2).ToString();
                        break;
                    case "×":
                        result = (num1 * num2).ToString();
                        break;
                    case "÷":
                        result = (num1 / num2).ToString();
                        break;
                }
                if (this.op != null)
                {
                    if (result.Length > 9)//保证结果长度在9之内
                        this.result.Text = result.Substring(0, 8);
                    else this.result.Text = result;
                }
            }
        }

        private void op_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.op = this.opt.SelectedItem.ToString();//当被选项目改变时，将被选中的项目名存入op
        }

        private void opt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '.')//允许退格和小数
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                    e.Handled = true;//当输入键不为0-9的数字键则不处理该事件
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        float firstNumber, secondNumber;
        int operators;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Number(string _number)//0~9數字函式
        {
            if (textBoxTotal.Text == "0")
                textBoxTotal.Text = "";
            textBoxTotal.Text = textBoxTotal.Text + _number;
        }


        //0~9按鍵start
        private void button1_Click(object sender, EventArgs e)
        {
            Add_Number("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Number("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Number("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Number("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_Number("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Number("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Add_Number("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add_Number("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Add_Number("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Add_Number("0");
        }
        //0~9按鍵end



        private void buttonPoint_Click(object sender, EventArgs e)// :.
        {
            // 確認輸入文字框中完全沒有小數點
            if (textBoxTotal.Text.IndexOf(".") == -1)
                textBoxTotal.Text = textBoxTotal.Text + ".";
        }

        private void Select_Operator(int _operator)//四則運算函式
        {
            firstNumber = Convert.ToSingle(textBoxTotal.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            textBoxTotal.Text = "0"; //重新將輸入文字框重新設定為0
            operators = _operator;
        }
        private void buttonAdd_Click(object sender, EventArgs e)//加法
        {
            Select_Operator(0);
        }
        private void buttonSubtraction_Click(object sender, EventArgs e)//減法
        {
            Select_Operator(1);
        }
        private void buttonMultiplication_Click(object sender, EventArgs e)//乘法
        {
            Select_Operator(2);
        }

        private void buttonDivision_Click(object sender, EventArgs e)//除法
        {
            Select_Operator(3);
        }

        private void buttonClear_Click(object sender, EventArgs e)//清除
        {
            textBoxTotal.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void buttonPercentage_Click(object sender, EventArgs e)//百分比
        {
            i++;
            //string a= string.Format("{0:P2}", textBoxTotal.Text); // 格式化為百分比形式

            if (operators == 0)
            {
                float a = Convert.ToSingle(textBoxTotal.Text);// 換成浮點數
                float b = firstNumber * a * 0.01f;
                secondNumber = b;
            }
            else if (operators == 1)
            {
                float a = Convert.ToSingle(textBoxTotal.Text);// 換成浮點數
                float b = firstNumber * a * 0.01f;
                secondNumber = b;
            }
            else if(operators == 2)
            {
                float a = Convert.ToSingle(textBoxTotal.Text);// 換成浮點數
                float b = a * 0.01f;
                secondNumber = b;
            }
            else if(operators == 3)
            {
                float a = Convert.ToSingle(textBoxTotal.Text);// 換成浮點數
                float b = a * 0.01f;
                secondNumber = b;
            }

            // textBoxTotal.Text = string.Format("{0:0.##########}", secondNumber);

            //secondNumber = Convert.ToSingle(a);
        }


        private void buttonBack_Click(object sender, EventArgs e)//倒退
        {
            int length = textBoxTotal.Text.Length;
            if (length > 0)
            {
                textBoxTotal.Text = textBoxTotal.Text.Substring(0, length - 1);
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數
            if (i == 0)
            {
                secondNumber = Convert.ToSingle(textBoxTotal.Text);//將輸入文字框轉換成浮點數，存入第二個數字的全域變數 
            }
            
               

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            textBoxTotal.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
            i = 0;
        }


    }
}

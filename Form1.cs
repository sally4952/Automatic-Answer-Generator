using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自动答案生成器
{
    public partial class Form1 : Form
    {
        public static uint 题数;
        public static uint 选项数;
        public static string 答案;
        public static Random randow = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        [STAThread]
        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                题数 = uint.Parse(textBox1.Text);
                if (题数 == 0) throw new Exception("题数不能等于0");
                if (题数 * 3 > 100000) throw new Exception("题数不能大于100000");
            }
            catch
            {
                MessageBox.Show("题目数量无效，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            try
            {
                选项数 = uint.Parse(textBox2.Text);
                if (选项数 == 0) throw new Exception("选项数不能等于0");
                if (选项数 > 26) throw new Exception("选项数不能大于26");
            }
            catch
            {
                MessageBox.Show("选项数量无效，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            if (!checkBox2.Checked)
            {
                for (int i = 0; i < 题数; i++)
                {
                    int temp = randow.Next(1, (int)(选项数 + 1));
                    if (temp == 1) 答案 += "A";
                    else if (temp == 2) 答案 += "B";
                    else if (temp == 3) 答案 += "C";
                    else if (temp == 4) 答案 += "D";
                    else if (temp == 5) 答案 += "E";
                    else if (temp == 6) 答案 += "F";
                    else if (temp == 7) 答案 += "G";
                    else if (temp == 8) 答案 += "H";
                    else if (temp == 9) 答案 += "I";
                    else if (temp == 10) 答案 += "J";
                    else if (temp == 11) 答案 += "K";
                    else if (temp == 12) 答案 += "L";
                    else if (temp == 13) 答案 += "M";
                    else if (temp == 14) 答案 += "N";
                    else if (temp == 15) 答案 += "O";
                    else if (temp == 16) 答案 += "P";
                    else if (temp == 17) 答案 += "Q";
                    else if (temp == 18) 答案 += "R";
                    else if (temp == 19) 答案 += "S";
                    else if (temp == 20) 答案 += "T";
                    else if (temp == 21) 答案 += "U";
                    else if (temp == 22) 答案 += "V";
                    else if (temp == 23) 答案 += "W";
                    else if (temp == 24) 答案 += "X";
                    else if (temp == 25) 答案 += "Y";
                    else if (temp == 26) 答案 += "Z";
                    else throw new Exception("我代码是不是被改了？！");

                    答案 += "  ";
                }
                textBox3.Text = 答案;
                答案 = "";
            }
            else
            {
                Task[] tasks = new Task[11];
                for (int i = 0;i < tasks.Length - 1;i++)
                {
                    tasks[i] = Task.Run(() =>
                    {
                        for (int j = 0; j < (题数 / 10); j ++)
                        {
                            int temp = randow.Next(1, (int)(选项数 + 1));
                            if (temp == 1) 答案 += "A  ";
                            else if (temp == 2) 答案 += "B  ";
                            else if (temp == 3) 答案 += "C  ";
                            else if (temp == 4) 答案 += "D  ";
                            else if (temp == 5) 答案 += "E  ";
                            else if (temp == 6) 答案 += "F  ";
                            else if (temp == 7) 答案 += "G  ";
                            else if (temp == 8) 答案 += "H  ";
                            else if (temp == 9) 答案 += "I  ";
                            else if (temp == 10) 答案 += "J  ";
                            else if (temp == 11) 答案 += "K  ";
                            else if (temp == 12) 答案 += "L  ";
                            else if (temp == 13) 答案 += "M  ";
                            else if (temp == 14) 答案 += "N  ";
                            else if (temp == 15) 答案 += "O  ";
                            else if (temp == 16) 答案 += "P  ";
                            else if (temp == 17) 答案 += "Q  ";
                            else if (temp == 18) 答案 += "R  ";
                            else if (temp == 19) 答案 += "S  ";
                            else if (temp == 20) 答案 += "T  ";
                            else if (temp == 21) 答案 += "U  ";
                            else if (temp == 22) 答案 += "V  ";
                            else if (temp == 23) 答案 += "W  ";
                            else if (temp == 24) 答案 += "X  ";
                            else if (temp == 25) 答案 += "Y  ";
                            else if (temp == 26) 答案 += "Z  ";
                            else throw new Exception("我代码是不是被改了？！");
                        }
                    });
                }
                tasks[10] = Task.Run(() =>
                {
                    for (int j = 0; j < (题数 % 10); j++)
                    {
                        int temp = randow.Next(1, (int)(选项数 + 1));
                        if (temp == 1) 答案 += "A  ";
                        else if (temp == 2) 答案 += "B  ";
                        else if (temp == 3) 答案 += "C  ";
                        else if (temp == 4) 答案 += "D  ";
                        else if (temp == 5) 答案 += "E  ";
                        else if (temp == 6) 答案 += "F  ";
                        else if (temp == 7) 答案 += "G  ";
                        else if (temp == 8) 答案 += "H  ";
                        else if (temp == 9) 答案 += "I  ";
                        else if (temp == 10) 答案 += "J  ";
                        else if (temp == 11) 答案 += "K  ";
                        else if (temp == 12) 答案 += "L  ";
                        else if (temp == 13) 答案 += "M  ";
                        else if (temp == 14) 答案 += "N  ";
                        else if (temp == 15) 答案 += "O  ";
                        else if (temp == 16) 答案 += "P  ";
                        else if (temp == 17) 答案 += "Q  ";
                        else if (temp == 18) 答案 += "R  ";
                        else if (temp == 19) 答案 += "S  ";
                        else if (temp == 20) 答案 += "T  ";
                        else if (temp == 21) 答案 += "U  ";
                        else if (temp == 22) 答案 += "V  ";
                        else if (temp == 23) 答案 += "W  ";
                        else if (temp == 24) 答案 += "X  ";
                        else if (temp == 25) 答案 += "Y  ";
                        else if (temp == 26) 答案 += "Z  ";
                        else throw new Exception("我代码是不是被改了？！");
                    }
                });
                await Task.WhenAll(tasks);
                textBox3.Text = 答案;
                答案 = "";
            }
        }
        
        [STAThread]
        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Clipboard.SetDataObject(textBox3.Text);
            else Clipboard.SetDataObject(textBox3.Text.Replace(" ", ""));
            MessageBox.Show("复制成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && (MessageBox.Show("此功能暂时不稳定，确定开启吗？", "提示", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question) == DialogResult.OK)) checkBox2.Checked = true;
            else checkBox2.Checked = false;
        }
    }
}
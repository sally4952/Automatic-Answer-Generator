using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using 自动答案生成器.Properties;

namespace 自动答案生成器
{
    public partial class Form1 : Form
    {
        public static uint 题数;
        public static uint 选项数;
        public static string 答案;
        public static Random randow;
        public static ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
            InitializeControlsLanguage();
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
                switch (Settings.Default.Language)
                {
                    case "zh":
                        MessageBox.Show("题目数量无效，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "en-US":
                        MessageBox.Show("The number of questions is invalid, please re-enter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "fr":
                        MessageBox.Show("Le nombre de sujets n'est pas valide, veuillez le saisir à nouveau!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "es":
                        MessageBox.Show("¡El número de preguntas no es válido, ¡ por favor, vuelva a ingresar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "ar":
                        MessageBox.Show("عدد من الأسئلة غير صحيحة ، الرجاء إدخال مرة أخرى !", "خطأ .", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "ja":
                        MessageBox.Show("タイトル数が無効なので、再入力してください！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "ru":
                        MessageBox.Show("Неверное количество тем, пожалуйста, введите снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    default:
                        throw new Exception();
                }
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
                switch (Settings.Default.Language)
                {
                    case "zh":
                        MessageBox.Show("选项数量无效，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "en-US":
                        MessageBox.Show("The number of options is invalid, please re-enter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "fr":
                        MessageBox.Show("Le nombre d'options n'est pas valide, veuillez le saisir à nouveau!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "es":
                        MessageBox.Show("¡El número de opciones no es válido, ¡ vuelva a ingresar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "ar":
                        MessageBox.Show("عدد من الخيارات غير صالحة ، الرجاء إدخال مرة أخرى !", "خطأ .", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "ja":
                        MessageBox.Show("無効なオプション数を再入力してください！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case "ru":
                        MessageBox.Show("Неверное количество опций, введите снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    default:
                        throw new Exception();
                }
                textBox2.Focus();
                return;
            }
            randow = new Random();
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
                randow = null;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh");
                    Settings.Default.Language = "zh";
                    break; 
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    Settings.Default.Language = "en-US";
                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                    Settings.Default.Language = "fr";
                    break;
                case 3:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    Settings.Default.Language = "es";
                    break;
                case 4:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
                    Settings.Default.Language = "ar";
                    break;
                case 5:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ja");
                    Settings.Default.Language = "ja";
                    break;
                case 6:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
                    Settings.Default.Language = "ru";
                    break;
                default:
                    throw new Exception();
            }
            resources.ApplyResources(this, "$this");
            foreach (Control control in this.Controls)
            {
                resources.ApplyResources(control, control.Name);
                this.Refresh();
            }
            Settings.Default.Save();
        }
        private void InitializeControlsLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Language);
            resources.ApplyResources(this, "$this");
            foreach (Control control in this.Controls)
            {
                resources.ApplyResources(control, control.Name);
                this.Refresh();
            }
            switch (Settings.Default.Language)
            {
                case "zh":
                    comboBox1.SelectedIndex = 0; break;
                case "en-US":
                    comboBox1.SelectedIndex = 1; break;
                case "fr":
                    comboBox1.SelectedIndex = 2; break;
                case "es":
                    comboBox1.SelectedIndex = 3; break;
                case "ar":
                    comboBox1.SelectedIndex = 4; break;
                case "ja":
                    comboBox1.SelectedIndex = 5; break;
                case "ru":
                    comboBox1.SelectedIndex = 6; break;
                default:
                    throw new Exception();
            }
        }
    }
}
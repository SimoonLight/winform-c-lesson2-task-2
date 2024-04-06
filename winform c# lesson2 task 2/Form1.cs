namespace winform_c__lesson2_task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sifir_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "0";
            }
        }

        private void bir_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox1.Text = "1";
            }
        }

        private void iki_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox1.Text = "2";
            }
        }

        private void uc_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox1.Text = "3";
            }
        }

        private void dord_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox1.Text = "4";
            }
        }

        private void bes_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox1.Text = "5";
            }
        }

        private void alti_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox1.Text = "6";
            }
        }

        private void yetdi_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "7";
            }
            else
            {
                textBox1.Text = "7";
            }
        }

        private void sekkkiz_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox1.Text = "8";
            }
        }

        private void doqqquz_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox1.Text = "9";
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //substring
            if (textBox1.Text.Length != 0)
            {
                string s = textBox1.Text;
                s = s.Substring(0, s.Length - 1);
                textBox1.Text = s;

            }
        }

        private void musbet_menfi_btn_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            if (s[0] != '-')
            {
                s = '-' + s;
            }
            else if (s[0] == '-')
            {
                s = s.Substring(1);
            }
            textBox1.Text = s;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toplama_btn_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s[s.Length - 1] != '+' && s[s.Length - 1] != '-' && s[s.Length - 1] != 'x' && s[s.Length - 1] != '/' && s[s.Length - 1] != '√' && s[s.Length - 1] != '.')
            {
                textBox1.Text += '+';
            }
        }

        private void cixma_btn_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s[s.Length - 1] != '+' && s[s.Length - 1] != '-' && s[s.Length - 1] != 'x' && s[s.Length - 1] != '/' && s[s.Length - 1] != '√' && s[s.Length - 1] != '.')
            {
                textBox1.Text += '-';
            }
        }

        private void vurma_btn_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s[s.Length - 1] != '+' && s[s.Length - 1] != '-' && s[s.Length - 1] != 'x' && s[s.Length - 1] != '/' && s[s.Length - 1] != '√' && s[s.Length - 1] != '.')
            {
                textBox1.Text += 'x';
            }
        }

        private void bolme_btn_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s[s.Length - 1] != '+' && s[s.Length - 1] != '-' && s[s.Length - 1] != 'x' && s[s.Length - 1] != '/' && s[s.Length - 1] != '√' && s[s.Length - 1] != '.')
            {
                textBox1.Text += '/';
            }
        }

        private void mouse_click_textbox1(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
        }

        private void birBolX_btn_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(textBox1.Text, out number);
            number = 1 / number;
            textBox1.Text = number.ToString();
        }

        private void kvadrat_btn_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(textBox1.Text, out number);
            number *= number;
            textBox1.Text = number.ToString();
        }

        private void kokalti_btn_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(textBox1.Text, out number);
            number = Math.Sqrt(number);
            textBox1.Text = number.ToString();
        }

        private void faktorial_btn_Click(object sender, EventArgs e)
        {
            double number;
            double sum = 1;
            double.TryParse(textBox1.Text, out number);
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            number = sum;
            textBox1.Text = number.ToString();
        }

        private void beraberdi_btn_Click(object sender, EventArgs e)
        {
            string main_string = textBox1.Text;
            double first_side = 0;
            double second_side = 0;
            double main_double = 0;
            bool menfi = false;
            int index = 0;
            char ch = '\n';
            bool sifira_bolme_xetasi = false;
            if (main_string[0] == '-')
            {
                menfi = true;
                index = 1;
            }
            for (int i = 0; i < main_string.Length; i++)
            {

                bool check_first_dot = false;
                int ustF = 10;
                for (; index < main_string.Length; index++)
                {
                    if (main_string[index] != '+' && main_string[index] != '-' && main_string[index] != '/' && main_string[index] != 'x')
                    {
                        if (main_string[index] == '.')
                        {
                            check_first_dot = true;
                            continue;
                        }
                        if (check_first_dot == false)
                        {
                            double num = (int)main_string[index];
                            num = (int)main_string[index];
                            num -= 48;
                            first_side = (first_side * 10) + num;
                        }
                        else
                        {
                            double num = (int)main_string[index];
                            num -= 48;
                            num /= ustF;
                            ustF *= 10;
                            first_side += num;
                        }
                    }
                    else
                    {
                        ch = main_string[index];
                        index++;
                        break;
                    }
                }

                bool check_second_dot = false;
                int ustS = 10;
                for (; index < main_string.Length; index++)
                {

                    if (main_string[index] != '+' && main_string[index] != '-' && main_string[index] != '/' && main_string[index] != 'x')
                    {
                        if (main_string[index] == '.')
                        {
                            check_second_dot = true;
                            continue;
                        }
                        if (check_second_dot == false)
                        {
                            double num = (int)main_string[index];
                            num = (int)main_string[index];
                            num -= 48;
                            second_side = (second_side * 10) + num;
                        }
                        else
                        {
                            double num = (int)main_string[index];
                            num = (int)main_string[index];
                            num -= 48;
                            num /= ustS;
                            ustS *= 10;
                            second_side += num;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (ch == '+')
                {
                    if (menfi == true)
                    {
                        main_double = -first_side + second_side;
                    }
                    else
                    {
                        main_double = first_side + second_side;
                    }
                }
                else if (ch == '-')
                {
                    if (menfi == true)
                    {
                        main_double = -first_side - second_side;
                    }
                    else
                    {
                        main_double = first_side - second_side;
                    }
                }
                else if (ch == 'x')
                {
                    if (menfi == true)
                    {
                        main_double = -first_side * second_side;
                    }
                    else
                    {
                        main_double = first_side * second_side;
                    }
                }
                else if (ch == '/')
                {
                    if (second_side != 0)
                    {

                        if (menfi == true)
                        {
                            main_double = -first_side / second_side;
                        }
                        else
                        {
                            main_double = first_side / second_side;
                        }
                    }
                    else
                    {
                        sifira_bolme_xetasi = true;
                    }
                }
            }
            if (sifira_bolme_xetasi == true) textBox1.Text = " Sifira bolme Olmaz!!!";
            else textBox1.Text = main_double.ToString();
        }

        private void noqte_btn_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s[s.Length - 1] != '+' && s[s.Length - 1] != '-' && s[s.Length - 1] != 'x' && s[s.Length - 1] != '/' && s[s.Length - 1] != '√' && s[s.Length - 1] != '.')
            {
                s += '.';
            }
            textBox1.Text = s;
        }

        private void fayiz_btn_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            bool check = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > 47 && s[i] < 58){}
                else
                {
                    check = false;
                }
            }
            if (check == true)
            {
                double number = double.Parse(s);
                number /= 100;
                textBox1.Text = number.ToString();
            }
        }
    }
}

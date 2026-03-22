namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int inputNumber = int.Parse(number.Text);
                if (inputNumber > 999 || inputNumber < 100) {
                    MessageBox.Show("Введите только трёхзначное число" , "Ошибка",
                                MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show($"Наибольшая цифра: {Logic.FindMaxDigit(inputNumber)}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целое число.", "Ошибка",
                                MessageBoxButtons.OK );
                return;
            }
            
        }
    }
    public static class Logic
    {

        public static int FindMaxDigit(int number)
        {
            int a = number / 100;
            number %= 100;
            int b = number / 10;
            number %= 10;
            int c = number;
            int max;

            if (a >= b && a >= c)
            {
                max = a;
            }
            else if (b >= a && b >= c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            return max;

        }

    }
}

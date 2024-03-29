namespace ButtonGuess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numbers = new int[9];
        int count = 0;
        int temp = 0;
        #region Form 1 Load process
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {

                int number = rnd.Next(-4, 5);
                numbers[i] = number;

                while (Array.Exists(numbers, element => element == number))
                {
                    number = rnd.Next(-4, 5);

                }
                numbers[i] = number;


            }


            button1.Tag = numbers[0];
            button2.Tag = numbers[1];
            button3.Tag = numbers[2];
            button4.Tag = numbers[3];
            button5.Tag = numbers[4];
            button6.Tag = numbers[5];
            button7.Tag = numbers[6];
            button8.Tag = numbers[7];
            button9.Tag = numbers[8];
            button1.Click += Click;
            button2.Click += Click;
            button3.Click += Click;
            button4.Click += Click;
            button5.Click += Click;
            button6.Click += Click;
            button7.Click += Click;
            button8.Click += Click;
            button9.Click += Click;

        }
        #endregion
        private void EnabledButton()
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;
                    btn.Enabled = false;
                }
            }


        }

        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = btn.Tag.ToString();
            btn.Enabled = false;
            if (count == 0)
            {
                if (btn.Text == "0")
                {
                    EnabledButton();
                    MessageBox.Show("You Win");

                }
                else
                {
                    temp = int.Parse(btn.Text);
                    count++;
                }

            }
            else if (count == 1)
            {
                temp += int.Parse(btn.Text);
                if (temp == 0)
                {
                    EnabledButton();
                    MessageBox.Show("You Win");

                }
                else
                {
                    EnabledButton();
                    MessageBox.Show("You Lose");

                }
            }

        }
    }
}
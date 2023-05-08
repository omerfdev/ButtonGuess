namespace ButtonGuess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[9];
        int sayac = 0;
        int temp = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {

                int sayi = rnd.Next(-4, 5);
                sayilar[i] = sayi;

                while (Array.Exists(sayilar, element => element == sayi))
                {
                    sayi = rnd.Next(-4, 5);

                }
                sayilar[i] = sayi;


            }


            button1.Tag = sayilar[0];
            button2.Tag = sayilar[1];
            button3.Tag = sayilar[2];
            button4.Tag = sayilar[3];
            button5.Tag = sayilar[4];
            button6.Tag = sayilar[5];
            button7.Tag = sayilar[6];
            button8.Tag = sayilar[7];
            button9.Tag = sayilar[8];
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
            if (sayac == 0)
            {
                if (btn.Text == "0")
                {
                    EnabledButton();
                    MessageBox.Show("You Win");

                }
                else
                {
                    temp = int.Parse(btn.Text);
                    sayac++;
                }

            }
            else if (sayac == 1)
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
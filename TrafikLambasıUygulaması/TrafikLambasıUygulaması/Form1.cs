namespace TrafikLambasıUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayac = Convert.ToInt32(label1.Text);
            sayac++;
            label1.Text = sayac.ToString();
           
            if (sayac == 30)
            {
                button2.BackColor = Color.Yellow;
                button1.BackColor = Color.White;

            }
            if (sayac == 40)
            {
                button2.BackColor = Color.White;
                button3.BackColor = Color.Green;
            }
            if (sayac == 70)
            {
                sayac = 0;
                label1.Text=sayac.ToString();
                button1.BackColor = Color.Red;
                button3.BackColor = Color.White;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }
    }
}
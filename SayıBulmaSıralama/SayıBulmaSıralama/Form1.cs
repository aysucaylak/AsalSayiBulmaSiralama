namespace SayıBulmaSıralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            decimal sayi = Convert.ToDecimal (textBox1.Text);
            listBox1.Items.Clear();
            for (int kimlik =2; kimlik<= sayi; kimlik++)
            {
                int kontrol = 0;
                for (int j = 2;j < kimlik;j++)
                {
                    if (kimlik % j == 0)
                    {
                        kontrol++;
                        break;
                    }

                }
                if (kontrol == 0)
                {
                    listBox1.Items.Add(kimlik);
                    sayac++;
                }
            }
           textBox2.Text = "Listede " + sayac + " tane asal sayı vardır" ;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
 
         

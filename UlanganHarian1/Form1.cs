namespace UlanganHarian1
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

        private void gb_soal1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rb_jakarta.Checked)
            {
                gb_soal1.Text = "Jawaban Anda Benar!";
            }
            else if (rb_surabaya.Checked || rb_purwokerto.Checked)
            {
                gb_soal1.Text = "Jawaban Anda Salah!";
            }
            else
            {
                gb_soal1.Text = "Pilih Dulu Jawabnnya!";
            }
        }

        private void btn_check2_Click(object sender, EventArgs e)
        {
            if (rb_8.Checked)
            {
                gb_soal2.Text = "Jawaban Anda Benar!";
            }
            else if (rb_4.Checked || rb_12.Checked)
            {
                gb_soal2.Text = "Jawaban Anda Salah!";
            }
            else
            {
                gb_soal2.Text = "Pilih Dulu Jawabannya!";
            }
        }
    }
}

namespace _64_Galaxy_Song
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            g.Clear(Color.Black);
            SolidBrush sb = new SolidBrush(Color.White);
            Random random = new Random();
            for (int i = 0; i < 2000; i++)
            {
                g.FillEllipse(sb, random.Next(this.Width), random.Next(this.Height), 4, 4);
            }
        }
    }
}
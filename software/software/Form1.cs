namespace software
{
    public partial class Form1 : Form
    {
        int result ,num1,num2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "sum";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           num1=Convert.ToInt32(textBox1.Text);
            num2=Convert.ToInt32(textBox2.Text);
            result = num1+num2;
            label1.Text = result.ToString();
        }
    }
}
//merhaba
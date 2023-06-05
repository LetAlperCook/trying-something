namespace software
{
    public partial class Form1 : Form
    {
        int result, num1, num2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Calculate";
            comboBox1.Text = "Ýþlem Türü";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                switch (comboBox1.SelectedItem)
                {
                    case "topla":
                        result = num1 + num2;
                        break;


                    case "böl":
                        result = num1 / num2;
                        break;


                    case "çýkar":
                        result = num1 - num2;
                        break;


                    case "çarp":
                        result = num1 * num2;
                        break;
                }
                textBox3.Text = result.ToString();
            }
            catch (Exception ex) { MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }

        }




    }
}
//merhaba
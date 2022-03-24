namespace WinFormCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vin = Int32.Parse( textBox1.Text);
            string colour = textBox2.Text;
            int odo = Int32.Parse( textBox3.Text);

            Car newCar = new Car(vin, colour, odo);
            Globals.cars.Add(newCar);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Car theCar in Globals.cars)
            {
                richTextBox1.AppendText(theCar.reportMe());
                richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
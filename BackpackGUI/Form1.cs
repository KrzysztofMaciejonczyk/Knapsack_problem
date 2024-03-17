using LAB1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BackpackGUI
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemsBox.Text.Length > 0 && SeedBox.Text.Length > 0 && CapacityBox.Text.Length > 0)
            {
                int number = 10;
                try
                {
                    number = int.Parse(ItemsBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Number of items textbox must be an integer.\nSetting default number to 10.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int seed = 0;
                try
                {
                    seed = int.Parse(SeedBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seed textbox must be an integer.\nSetting default seed to 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int capacity = 10;
                try
                {
                    capacity = int.Parse(CapacityBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Capacity textbox must be an integer.\nSetting default capacity to 10.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Backpack backpack = new Backpack(number, seed);
                string instance = backpack.ToString();
                InstanceBox.Text = instance;
                Result result = backpack.Solve(capacity);
                string results = result.ToString();
                ResultsBox.Text = results;
            }
            else
            {
                MessageBox.Show("Neither of the textboxes can be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

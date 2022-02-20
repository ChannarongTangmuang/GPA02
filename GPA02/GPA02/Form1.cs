namespace GPA
{
    public partial class Form1 : Form
    {
        GPACAlculater GPACAlculater = new GPACAlculater();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;
            
            double dInput = Convert.ToDouble(input);
            oG

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";
            textBoxName_input.Text = "";
            textBoxMaxName.Text = "";
            textBoxMinName.Text = "";
            textBoxALLData.Text = "";
        }
    }
}

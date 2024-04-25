namespace RemoteIDTest
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = studentContext.Students.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kivétel)
            {

                MessageBox.Show(kivétel.Message);
            }
        }
    }
}
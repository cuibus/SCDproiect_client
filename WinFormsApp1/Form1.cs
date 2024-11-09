namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        PackageService packageService;
        List<Package> packageList;
        public Form1()
        {
            InitializeComponent();
            packageService = new PackageService();
            packageService.createConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var couriersList = packageService.GetBusyCouriers();

            comboBox1.DataSource= couriersList;
            comboBox1.DisplayMember= "name";
        }
    }
}
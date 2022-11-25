namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        EmployeeService employeeService;
        List<Employee> employeeList;
        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            employeeService.createConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employeeList = employeeService.GetEmployees();

            comboBox1.DataSource= employeeList;
            comboBox1.DisplayMember= "name";
        }
    }
}
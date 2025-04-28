namespace Assignment_4._1._1
{
    public partial class Form1 : Form
    {
        Dictionary<string, Person> addressBook = new Dictionary<string, Person>();
        BindingSource bs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person person1 = new Person("John", "Smith", "(123)456-7890", "(123)456 - 7890", "101 Main St");
            Person person2 = new Person("Jamie", "Smort", "(123)222-7890", "(123)111 - 7890", "101 Main St");
            Person person3 = new Person("Damion", "Darkbool", "(111)111-1111", "(222)222-2222", "1 Main St");
            addressBook.Add(person1.ToString(), person1);
            addressBook.Add(person2.ToString(), person2);
            addressBook.Add(person3.ToString(), person3);
            bs = new BindingSource();
            bs.DataSource = addressBook.Values;
            dataGridView1.DataSource = bs;
            ResizeColumns();
        }

        private void ResizeColumns()
        {
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoResizeColumns();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nameSearch = txtSearch.Text;
            if (addressBook.ContainsKey(nameSearch))
            {
                lblError.Text = "";
                var personInfoForm = new PersonInfoForm(addressBook[nameSearch]);
                personInfoForm.Show();
            }
            else
            {
                lblError.Text = $"Error: {txtSearch.Text} does not exist in the address book.";
            }
            txtSearch.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string mobile = txtMobile.Text;
            string work = txtWork.Text;
            string address = txtAddress.Text;
            try
            {
                Person person = new Person(fName, lName, mobile, work, address);
                addressBook.Add(person.ToString(), person);
                bs.Add(person);
                ResizeColumns();
            }
            catch (Exception ex) { lblError.Text = ex.Message; }
            ClearAddBoxes();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string name = txtLName.Text + " " + txtFName.Text;
            if (addressBook.ContainsKey(name))
            {
                bs.Remove(addressBook[name]);
                bool b = addressBook.Remove(name);
                lblError.Text = $"{name} has been deleted from the address book.";
            }
            else
            {
                lblError.Text = $"Error: {name} does not exist in the address book";
            }
            ClearAddBoxes();
        }

        private void ClearAddBoxes()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtMobile.Text = "";
            txtWork.Text = "";
            txtAddress.Text = "";
        }
    }
}

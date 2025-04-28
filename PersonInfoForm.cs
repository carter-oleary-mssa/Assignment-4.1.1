using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._1._1
{
    public partial class PersonInfoForm : Form
    {
        public Person Person { get; set; }
        public PersonInfoForm(Person person)
        {
            Person = person;
            InitializeComponent();
            lblInfoFName.Text = $"First Name: {person.FirstName}";
            lblInfoLName.Text = $"Last Name: {person.LastName}";
            lblInfoMobile.Text = $"Mobile #: {person.MobilePhone}";
            lblInfoWork.Text = $"Work #: {person.WorkPhone}";
            lblInfoAddress.Text = $"First Name: {person.Address}";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

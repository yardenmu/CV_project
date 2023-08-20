using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvProject.Forms
{
    public partial class FormPersonal : Form
    {
        PersonalInfo personal;
        public FormPersonal()
        {
            InitializeComponent();
            personal = new PersonalInfo();
        }
        //load the user input to the members of class PersonalInfo
        private void save_btn_Click(object sender, EventArgs e)
        {
            string firstName = firstName_tb.Text;
            string lastName = lastName_tb.Text;
            string address = address_tb.Text;
            string id = id_tb.Text;
            string email = Email_tb.Text;
            string DateofBirth = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            
            if(!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName) && !string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(email))
            {
                personal.firstNAME = firstName;
                personal.LastNAME = lastName;
                personal.ADDRESS = address;
                personal.ID = id;
                personal.EMAIL = email;
                personal.dateofBIRTH = DateofBirth;
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}

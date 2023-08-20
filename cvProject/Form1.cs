using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvProject
{
    public partial class cvProject : Form
    {
        private Form activeForm;
        public cvProject()
        {
            InitializeComponent();
            timer1.Start();
        }
        //create a method to open the forms in the panelDesktop
        private void OpenChildForms(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataTime = DateTime.Now;
            this.time_lbl.Text = dataTime.ToString();
        }

        private void personal_btn_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForms(new Forms.FormPersonal(), sender);
        }

        private void education_btn_Click(object sender, EventArgs e)
        {
            OpenChildForms(new Forms.FormEducation(), sender);
        }

        private void workEx_btn_Click(object sender, EventArgs e)
        {
            OpenChildForms(new Forms.FormWorkExperience(), sender);
        }

        private void skill_btn_Click(object sender, EventArgs e)
        {
            OpenChildForms(new Forms.FormSkills(), sender);
        }
    }


}
  


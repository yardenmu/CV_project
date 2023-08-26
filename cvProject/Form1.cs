using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cvProject.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;


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
            FormPersonal formPersonal = new FormPersonal();
            OpenChildForms(formPersonal, sender);
            formPersonal.setDataTotb();
        }

        private void education_btn_Click(object sender, EventArgs e)
        {
            FormEducation education = new FormEducation();
            OpenChildForms(education, sender);
            education.SetEducationList();
        }

        private void workEx_btn_Click(object sender, EventArgs e)
        {
            FormWorkExperience workExperience = new FormWorkExperience();
            OpenChildForms(workExperience, sender);
            workExperience.SetWorkExpList();
        }

        private void skill_btn_Click(object sender, EventArgs e)
        {
            OpenChildForms(new Forms.FormSkills(), sender);
        }

        private void pdf_pb_Click(object sender, EventArgs e)
        {
            PdfDocument cv = new PdfDocument();
            PdfPage page = cv.AddPage();
            // Set the page size (width and height) in points
            page.Width = XUnit.FromMillimeter(210);   // A4 width
            page.Height = XUnit.FromMillimeter(297);  // A4 height
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //fonts:
            XFont fontHeadline = new XFont("David", 24);
            XFont fontSubtitle = new XFont("David", 16, XFontStyle.Bold);
            XFont font = new XFont("David", 12);
            XFont font1 = new XFont("David", 12, XFontStyle.Bold);

            string Headline = "Resume of " + Program.per.firstNAME + " " + Program.per.LastNAME;                                           
            gfx.DrawString(Headline, fontHeadline, XBrushes.Black,new XRect(10, 30, page.Width, page.Height), XStringFormats.TopCenter);

            // Create a background rectangle for the banner
            XRect backgroundRect = new XRect(0, 75, page.Width, 20); 
            XBrush backgroundBrush = XBrushes.LightBlue;
            gfx.DrawRectangle(backgroundBrush, backgroundRect);

            // create the format position to the text
            XStringFormat format = new XStringFormat();
            format.Alignment = XStringAlignment.Center;
            format.LineAlignment = XLineAlignment.Center;
            
            gfx.DrawString(Headline, fontSubtitle, XBrushes.Black, backgroundRect, format);

            //gfx.DrawString(Headline, fontSubtitle, XBrushes.Black, new XRect(40, 75, page.Width, page.Height), XStringFormats.TopLeft);



            cv.Save("C:\\Users\\yarde\\OneDrive\\Desktop\\MyPdfDocument.pdf");
            MessageBox.Show("upload succssesfully");
        }
    }
}



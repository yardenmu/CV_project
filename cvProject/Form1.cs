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
        //global variable
        double pagePosition = 30;
        
        private void pdf_pb_Click(object sender, EventArgs e)
        {
            PdfDocument cv = new PdfDocument();
            PdfPage page = cv.AddPage();
         
            // Set the page size (width and height) in points
            page.Width = XUnit.FromMillimeter(210);   // A4 width
            page.Height = XUnit.FromMillimeter(297);  // A4 height
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //fonts:
            XFont fontHeadline = new XFont("Century Gothic", 24);
            XFont fontsubHeadline = new XFont("Century Gothic", 16, XFontStyle.Bold);
            XFont text = new XFont("Century Gothic", 12);
            XFont subTitle = new XFont("Century Gothic", 12, XFontStyle.Bold);

            string Headline = "Resume of " + Program.per.firstNAME + " " + Program.per.LastNAME;                                           
            gfx.DrawString(Headline, fontHeadline, XBrushes.Black,new XRect(10, pagePosition, page.Width, page.Height), XStringFormats.TopCenter);
            pagePosition += 45;
            DrawPng(gfx);
            PesonalPdf(subTitle, fontsubHeadline, text, gfx, page);
            EducationPdf(subTitle, fontsubHeadline, text, gfx, page, page.Height);         

            cv.Save("C:\\Users\\yarde\\OneDrive\\Desktop\\MyPdfDocument.pdf");
            MessageBox.Show("upload succssesfully");
        }
        public void headlineSection(XFont fontSubtitle, XGraphics gfx, PdfPage page, string Title)
        {
            // Create a background rectangle for the banner
            XRect backgroundRect = new XRect(0, pagePosition, page.Width, 20);
            XBrush backgroundBrush = XBrushes.LightBlue;
            gfx.DrawRectangle(backgroundBrush, backgroundRect);

            // create the format position to the headline
            XStringFormat format = new XStringFormat();
            format.Alignment = XStringAlignment.Center;
            format.LineAlignment = XLineAlignment.Center;

            //need to print all the title in the section
            gfx.DrawString(Title, fontSubtitle, XBrushes.Black, backgroundRect, format);
            pagePosition += fontSubtitle.Height;
        }
        public void PesonalPdf(XFont fontSubtitle, XFont fontsubHeadline, XFont text, XGraphics gfx, PdfPage page)
        {
            headlineSection(fontsubHeadline, gfx, page, Program.per.TITLE);
            pagePosition += 25;
            double yFirst = 120; //position of the text 
            double xFirst = 30;  //position of the text  
            double tab = 300;// space for the second col

            string[] firstColTitle = new string[] { "Name: ", "ID: ", "Date of Birth: ", "Address: ", "Phone: ", "Email: " };
            string[] strPersonal = new string[] { Program.per.firstNAME + " " + Program.per.LastNAME, Program.per.ID, Program.per.dateofBIRTH, Program.per.ADDRESS, Program.per.PHONE, Program.per.EMAIL };
            
            for (int i = 0; i < firstColTitle.Length ; i++)
            {
                //calculate the width of each title 
                double titleWidth = gfx.MeasureString(firstColTitle[i], fontSubtitle).Width;
                
                if(i < 3)
                {                 
                    gfx.DrawString(firstColTitle[i], fontSubtitle, XBrushes.Black, xFirst, pagePosition); //position of the first title
                    gfx.DrawString(strPersonal[i], text, XBrushes.Black, xFirst + titleWidth , pagePosition); //position of the contant for the first title
                    pagePosition += fontSubtitle.Height + text.Height; //calculate the height according to the font title and the text
                }
                else // same here with addition of the tab space
                {
                    gfx.DrawString(firstColTitle[i], fontSubtitle, XBrushes.Black, xFirst + tab, yFirst);
                    gfx.DrawString(strPersonal[i], text, XBrushes.Black, xFirst + titleWidth + tab, yFirst);
                    yFirst += fontSubtitle.Height + text.Height;
                }                                        
                               
            }            
        }
        public void EducationPdf(XFont fontSubtitle, XFont fontsubHeadline, XFont text, XGraphics gfx, PdfPage page,double pageHeight)
        {
            double x = 30;
            double tab = 30;
            headlineSection(fontsubHeadline, gfx, page, "Education");
            pagePosition += 25;

            if (pageHeight - pagePosition == 0)
            {

            }
            foreach(Education i in Program.DataEducationList)
            {
                gfx.DrawString(i.STARTDATE + '-' + i.ENDDATE, fontSubtitle, XBrushes.Black, x, pagePosition);
                double pos = gfx.MeasureString(i.STARTDATE + '-' + i.ENDDATE, fontSubtitle).Width;
                gfx.DrawString(i.DEGREE + " major " + i.MAJOR + " in " + i.INSTITUTION, fontSubtitle, XBrushes.Black, x + pos + tab, pagePosition);
                pagePosition += fontSubtitle.Height + 5;
                gfx.DrawString(i.DESCRIPTION, text, XBrushes.Black, x + pos + tab, pagePosition);
                pagePosition += text.Height + 8;
            }
        }

        void DrawPng(XGraphics gfx)
        {   
            if(Program.per.IMAGEPATH != " ")
            {
                XImage image = XImage.FromFile(Program.per.IMAGEPATH);
                double imageWidth = 65;
                double imageHeight = 65;
                gfx.DrawImage(image, 30, 5, imageWidth, imageHeight);
            }
         
        }
    }
}



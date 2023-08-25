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
    public partial class FormEducation : Form
    {
        Education education;
        int index;
        cvSections cv = new cvSections();

        public FormEducation()
        {
            InitializeComponent();
      
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string institution, degree, major, description;
            string startDate, EndDate;
            institution = institution_tb.Text;
            degree = degree_tb.Text;
            major = major_tb.Text;
            description = description_tb.Text;
            startDate = startDate_tb.Text;
            EndDate = endDate_tb.Text;

            if (!string.IsNullOrWhiteSpace(institution) && !string.IsNullOrWhiteSpace(degree)
                && !string.IsNullOrWhiteSpace(major) && !string.IsNullOrWhiteSpace(description) &&
                !string.IsNullOrWhiteSpace(startDate) && !string.IsNullOrWhiteSpace(EndDate))
            {
                education = new Education(institution, degree, major, description, startDate, EndDate);

                Education_dv.Rows.Add(Education_dv.Rows.Count, education.INSTITUTION, education.DEGREE, education.MAJOR,education.STARTDATE, education.ENDDATE, education.DESCRIPTION);
                cv.addEducation(education);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
            institution_tb.Clear();
            degree_tb.Clear();
            major_tb.Clear();
            description_tb.Clear();
            startDate_tb.Clear();
            endDate_tb.Clear();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //                                       check if the the current selected row value is empty
            if (Education_dv.Rows.Count > 0 && Education_dv.Rows[Education_dv.CurrentRow.Index].Cells[1].Value != null)
            {
                index = Education_dv.CurrentRow.Index; //current selected index
                Education_dv.Rows.RemoveAt(index);
                cv.RemoveEducation(education);
            }    
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            if(Education_dv.Rows.Count != 1)
            {

                institution_tb.Text = Education_dv.Rows[index].Cells[1].Value.ToString();
                degree_tb.Text = Education_dv.Rows[index].Cells[2].Value.ToString();
                major_tb.Text = Education_dv.Rows[index].Cells[3].Value.ToString();
                startDate_tb.Text = Education_dv.Rows[index].Cells[4].Value.ToString();
                endDate_tb.Text = Education_dv.Rows[index].Cells[5].Value.ToString();
                description_tb.Text = Education_dv.Rows[index].Cells[6].Value.ToString();
                Education_dv.Rows.RemoveAt(index);
                
            }

        }

        private void Education_dv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Education_dv.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
    }
}

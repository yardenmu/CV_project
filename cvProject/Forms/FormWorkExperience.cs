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
    public partial class FormWorkExperience : Form
    {
        WorkExperience workExp;
        int index;
        public FormWorkExperience()
        {
            InitializeComponent();
            workExp = new WorkExperience();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string Company, Position, StartDate, EndDate, Responsibilities, Duration;
            Company = company_tb.Text;
            Position = position_tb.Text;
            StartDate = startDate_time.Value.ToString("dd-MM-yyyy"); 
            EndDate = endDate_time.Value.ToString("dd-MM-yyyy");
            Responsibilities = responsibilities_tb.Text;
            Duration = " ";
           

            if (!string.IsNullOrWhiteSpace(Company) && !string.IsNullOrWhiteSpace(Position)
                && !string.IsNullOrWhiteSpace(Responsibilities))
            {
                workExp.COMPANY = Company;
                workExp.POSITION = Position;
                workExp.STARTDATE = StartDate;
                workExp.ENDDATE = EndDate;
                workExp.RESPONSIBILITIES = Responsibilities;
                workExp.DURATION = Duration;

                WorkExp_dv.Rows.Add(WorkExp_dv.Rows.Count, workExp.COMPANY, workExp.POSITION, workExp.DURATION, workExp.RESPONSIBILITIES);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
            company_tb.Clear();
            position_tb.Clear();
            responsibilities_tb.Clear();
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            if (WorkExp_dv.Rows.Count != 1)
            {
                company_tb.Text = WorkExp_dv.Rows[index].Cells[1].Value.ToString();
                position_tb.Text = WorkExp_dv.Rows[index].Cells[2].Value.ToString();
                responsibilities_tb.Text = WorkExp_dv.Rows[index].Cells[4].Value.ToString();
                WorkExp_dv.Rows.RemoveAt(index);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //                                       check if the the current selected row value is empty
            if (WorkExp_dv.Rows.Count > 0 && WorkExp_dv.Rows[WorkExp_dv.CurrentRow.Index].Cells[1].Value != null)
            {
                index = WorkExp_dv.CurrentRow.Index; //current selected index
                WorkExp_dv.Rows.RemoveAt(index);
            }
        }
        //add numbers to each row
        private void WorkExp_dv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            WorkExp_dv.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
    }
}

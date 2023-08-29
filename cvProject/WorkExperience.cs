using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject
{
    class WorkExperience : cvSections
    {
        protected string Company, Position, Responsibilities, Duration;
        public WorkExperience() : base()
        {
            Company = " ";
            Position = " ";
            Responsibilities = " ";
            Duration = " ";
            SetTitleAndOrder("Work Experience", 3);
        }
        public WorkExperience(string index, string Company, string Position, string startdate, string enddate, string Responsibilities, string Duration) : base(startdate, enddate, index)
        {
            COMPANY = Company;
            POSITION = Position;
            RESPONSIBILITIES = Responsibilities;
            DURATION = Duration;
            SetTitleAndOrder("Work Experience", 3);
        }
        public string COMPANY
        {
            get { return Company; }

            set { this.Company = value; }
        }
        public string POSITION
        {
            get { return Position; }

            set { this.Position = value; }

        }
        public string RESPONSIBILITIES
        {
            get { return Responsibilities; }

            set { this.Responsibilities = value; }     
        }
        public string DURATION
        {
            get { return Duration; }

            set { this.Duration = calculateDurationDate(); }
        }

        public string calculateDurationDate()
        {
            DateTime startDate = DateTime.ParseExact(startdate, "dd-MM-yyyy", null);
            DateTime endDate = DateTime.ParseExact(enddate, "dd-MM-yyyy", null);
            TimeSpan duration = endDate - startDate;
            int years = duration.Days / 365;
            int months = (duration.Days % 365) / 30;          
            base.startdate = startDate.Year.ToString();            
            base.enddate = endDate.Year.ToString();
            if(years == 0)
            {
                return months + " month";
            }
            return years + " years " + months + " month";
        }
        public override void addToList()
        {
            Program.DataWorkExperinceList.Add(this);
        }
        public override void RemoveItemFromList()
        {
            Program.DataWorkExperinceList.Remove(this);
        }
    }
}

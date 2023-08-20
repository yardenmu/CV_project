using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject
{
    class WorkExperience
    {
        protected string Company, Position, StartDate, EndDate, Responsibilities;
        public WorkExperience()
        {
            Company = " ";
            Position = " ";
            StartDate = " ";
            EndDate = " ";
            Responsibilities = " ";
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
        public string STARTDATE
        {
            get { return StartDate; }
          
            set { this.StartDate = value; }
          
        }
        public string ENDDATE
        {
            get { return EndDate; }
           
            set { this.EndDate = value; }
           
        }
        public string RESPONSIBILITIES
        {
            get { return Responsibilities; }

            set 
            { 
                this.Responsibilities = value;
            }
     
        }
    
    }
}

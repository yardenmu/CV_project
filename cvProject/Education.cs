using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject
{
    class Education : cvSections
    {
        protected string institution, degree, major,description;
        protected string startDate, endDate;

        public Education()
        {
            institution = "";
            degree = "";
            major = "";
            startDate = "";
            endDate = "";
        }
        public string INSTITUTION
        {
            get { return institution; }
           
            set { this.institution = value; }
          
        }
        public string DEGREE
        {
            get { return degree; }
          
            set { this.degree = value; }
           
        }
        public string MAJOR
        {
            get { return major; }
         
            set { this.major = value; }
          
        }
        public string DESCRIPTION
        {
            get { return description; }
         
            set { this.description = value; }
          
        }
        public string STARTDATE
        {
            get { return startDate; }
          
            set { this.startDate = value; }
          
        }
        public string ENDDATE
        {
            get { return endDate; }
          
            set { this.endDate = value; }
           
        }
    }
}

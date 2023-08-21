﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject
{
    class WorkExperience : cvSections
    {
        protected string Company, Position, StartDate, EndDate, Responsibilities, Duration;
        public WorkExperience()
        {
            Company = " ";
            Position = " ";
            StartDate = " ";
            EndDate = " ";
            Responsibilities = " ";
            Duration = " ";
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
        public string DURATION
        {
            get { return Duration; }

            set { this.Duration = calculateDurationDate(); }
        }

        public string calculateDurationDate()
        {
            DateTime startDate = DateTime.ParseExact(StartDate, "dd-MM-yyyy", null); 
            DateTime endDate = DateTime.ParseExact(EndDate, "dd-MM-yyyy", null); 
            TimeSpan duration = endDate - startDate; 
            int years = duration.Days / 365; 
            int months = (duration.Days % 365) / 30;
            return years + " years " + months + " month";
        }

    }
}
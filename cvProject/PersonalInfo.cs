using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject
{
    class PersonalInfo
    {
        protected string FirstName, LastName, DateOfBirth, Email, Adrress;
        protected string id;

        public PersonalInfo()
        {
            FirstName = " ";
            LastName = " ";
            DateOfBirth = " ";
            Email = " ";
            Adrress = " ";
            id = " ";
        }
        public string firstNAME
        {
            get
            { return FirstName; }
            
            set { this.FirstName = value; }
        }
        public string LastNAME
        {
            get { return LastName; }
     
            set { this.LastName = value; }
        }
        public string dateofBIRTH
        {
            get { return DateOfBirth; }

            set { this.DateOfBirth = value; }
        }
        public string EMAIL
        {
            get { return Email; }
    
            set { this.Email = value; }
          
        }
        public string ADDRESS
        {
            get { return Adrress; }
      
            set { this.Adrress = value; }
          
        }
        public string ID
        {
            get { return id; }

            set { this.id = value; }
        }
    }
    
}

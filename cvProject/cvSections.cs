using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject
{
    class cvSections : cvComponent
    {
        protected List<Education> Educationslist;
        protected List<WorkExperience> WorkExperienceslist;
        public cvSections()
        {
            Educationslist = new List<Education>();
            WorkExperienceslist = new List<WorkExperience>();
        }

        public List<Education> EDUCATION
        {
            get { return Educationslist; }
            set { Educationslist = value; }
        }
        public List<WorkExperience> WORKEXP
        {
            get { return WorkExperienceslist; }
            set { WorkExperienceslist = value; }
        }
 
    }
    
}

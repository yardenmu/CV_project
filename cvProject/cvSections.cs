using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject
{
    class cvSections : cvComponent
    {

        private List<Education> Educationslist;
        private List<WorkExperience> WorkExperienceslist;
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
        

        public void addEducation(Education edu)
        {
            Educationslist.Add(edu);
        }
        public void RemoveEducation(Education edu)
        {
            Educationslist.Remove(edu);
        }

        public void addWorkExperiences(WorkExperience workExp)
        {
            WorkExperienceslist.Add(workExp);
        }
        public void RemoveWorkExperiences(WorkExperience workExp)
        {
            WorkExperienceslist.Remove(workExp);
        }



    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject
{
    
    class cvSections : cvComponent
    {        
        protected string startdate, enddate, index;
        public cvSections() :base()
        {
            startdate = "";
            enddate = "";
            index = "";
        }
        public cvSections(string startdate, string enddate, string index)
        {
            STARTDATE = startdate;
            ENDDATE = enddate;
            INDEX = index;
        }
        public virtual void addToList() { }

        public virtual void RemoveItemFromList() { }

        protected void SetTitleAndOrder(string title, int order)
        {
            base.Title = title;
            base.DisplayOrder = order;          
        }
       
        //properties
        public string STARTDATE
        {
            get { return startdate; }

            set { this.startdate = value; }

        }
        public string ENDDATE
        {
            get { return enddate; }

            set { this.enddate = value; }

        }
        public string INDEX
        {
            get { return index; }

            set { this.index = value; }

        }
    }

}

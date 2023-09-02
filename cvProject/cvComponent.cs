using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvProject
{
    [Serializable]
    class cvComponent
    {
        protected string Title;
        protected int DisplayOrder;
        public static List<cvComponent> cvList = new List<cvComponent>();
      
        public cvComponent()
        {
            Title = " ";
            DisplayOrder = 1;
        }
        public cvComponent(string title, int index)
        {
            TITLE = title;
            DISPLAYTORDER = index;
            
        }
       
        public string TITLE
        {
            get { return Title; }
            set { this.Title = value; }
        }
        public int DISPLAYTORDER
        {
            get { return DisplayOrder; }
            set { this.DisplayOrder = value; }
        }

        public virtual void addTocvCompList()
        {

        }

    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvProject
{
    class cvComponent
    {
        string Title;
        int DisplayOrder;
        ColorDialog colorDialog = new ColorDialog();

        public cvComponent()
        {
            Title = " ";
            DisplayOrder = 1;
        }
        public cvComponent(string title, int index)
        {
            Title = " ";
            DisplayOrder = 1;
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

    }
   
}

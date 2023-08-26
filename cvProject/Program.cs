using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvProject
{

    static class Program
    {
        public static List<Education> DataEducationList = new List<Education>();
        public static List<WorkExperience> DataWorkExperinceList = new List<WorkExperience>();
        public static PersonalInfo per = new PersonalInfo();
        public static Boolean checkValidInputName(string str)
        {
            if (!string.IsNullOrWhiteSpace(str) && (str.All(char.IsLetter)))
            {
                return true;
            }
            return false; //Major -> letters
            //start date ->numbers description
        }
        public static Boolean checkValidInputNumeric(string str)
        {
            if (!string.IsNullOrWhiteSpace(str) && (str.All(char.IsDigit)))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new cvProject());
        }
    }
}

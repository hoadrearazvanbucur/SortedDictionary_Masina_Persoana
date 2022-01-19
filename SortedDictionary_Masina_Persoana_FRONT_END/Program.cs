using SortedDictionary_Masina_Persoana_FRONT_END.MOCKUPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedDictionary_Masina_Persoana_FRONT_END
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdaugarePersoana());
        }
    }
}

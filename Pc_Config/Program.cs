using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_Config
{
    static class Program
    {
        public static Form1 form1 = null;
        public static Form_PC form_PC = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            form_PC = new Form_PC();
            Application.Run(form1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPCrystalReports.BaseClasses.WinRegister
{
    public class RegisterManagerBO
    {
        public static string GetLoginRegister()
        {
            return (string)WinRegisterOps.ReadRegister("Software\\SapCrystalReportsApp", "Login");
        }

        public static void SetLoginRegister(string registerValue)
        {
            WinRegisterOps.AtualizaRegistro("Software\\SapCrystalReportsApp", "Login", registerValue);
        }
    }
}

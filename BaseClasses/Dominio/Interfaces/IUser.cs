using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPCrystalReports.BaseClasses.DTOs
{
    internal interface IUser
    {
         int Id { get; set; } 
         string Login { get; set; }
         string Name { get; set; }
         string Password { get; set; }
    }
}

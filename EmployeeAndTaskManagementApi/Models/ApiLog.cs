using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAndTaskManagementApi.Models
{
    public class ApiLog
    {
        public int Id { get; set; }
        public string LogMessage { get; set; }
        public DateTime TimeStamp { get; set; }
        public string LogLevel { get; set; }  // Info, Error, Debug
    }
}
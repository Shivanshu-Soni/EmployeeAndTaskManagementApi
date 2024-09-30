using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAndTaskManagementApi.Models
{
    public class User
    {
        public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }  // Admin, Manager, Employee
    public int? ManagerId { get; set; }
    public User Manager { get; set; }
    public ICollection<Task> Tasks { get; set; }
    }
}
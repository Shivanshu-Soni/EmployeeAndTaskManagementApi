using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAndTaskManagementApi.Models
{
    public class Task
    {
         public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public string Status { get; set; }  // To Do, In Progress, Completed
    public string Priority { get; set; }  // Low, Medium, High
    public int AssignedEmployeeId { get; set; }
    public User AssignedEmployee { get; set; }
    public bool IsDeleted { get; set; }  // For soft delete
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAndTaskManagementApi.Models.DataContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAndTaskManagementApi.Repository
{
    public class TaskRepository : Repository<Task>
{
    public TaskRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Task>> GetTasksByEmployeeId(int employeeId)
    {
        return await DbContext.Tasks
            .Where(t => t.AssignedEmployeeId == employeeId && !t.IsDeleted)
            .ToListAsync();
    }
}

}
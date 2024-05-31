using System;
using System.Linq;
using System.Threading.Tasks;
using CashOverFlow.Models.Salaries;
using Microsoft.EntityFrameworkCore;

namespace CashOverFlow.Brokers.Storages;

public partial class StorageBroker
{
    public DbSet< Salary> Salaries { get; set; }
    public async ValueTask<Salary> InsertSalaryAsync(Salary salary) =>
        await InsertAsync(salary);

    public IQueryable<Salary> SelectSalaries() =>
        SelectAll<Salary>();

    public async ValueTask<Salary> SelectSalaryByIdAsync(Guid salaryId) =>
        await SelectAsync<Salary>(salaryId);
}

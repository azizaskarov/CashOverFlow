using System;
using System.Linq;
using System.Threading.Tasks;
using CashOverFlow.Models.Salaries;

namespace CashOverFlow.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask<Salary> InsertSalaryAsync(Salary salary);
    IQueryable<Salary> SelectSalaries();
    ValueTask<Salary> SelectSalaryByIdAsync(Guid salaryId);
}

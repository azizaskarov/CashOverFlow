using System;
using System.Linq;
using System.Threading.Tasks;
using CashOverFlow.Models.Companies;

namespace CashOverFlow.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask<Company> InsertCompanyAsync(Company company);
    IQueryable<Company> SelectAllCompanies();
    ValueTask<Company> SelectCompanyByIdAsync(Guid companyId);
    ValueTask<Company> DeleteCompanyAsync(Company company);
    ValueTask<Company> UpdateCompanyAsync(Company company);
}

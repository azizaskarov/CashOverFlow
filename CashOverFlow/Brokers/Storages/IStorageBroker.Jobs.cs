using CashOverFlow.Models.Jobs;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace CashOverFlow.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask<Job> InsertJobAsync(Job job);
    IQueryable<Job> SelectAllJobs();
    ValueTask<Job> SelectJobByIdAsync(Guid jobId);
    ValueTask<Job> UpdateJobAsync(Job job);
    ValueTask<Job> DeleteJobAsync(Job job);
} 

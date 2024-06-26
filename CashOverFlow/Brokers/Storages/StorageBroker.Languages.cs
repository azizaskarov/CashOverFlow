﻿using System;
using System.Linq;
using System.Threading.Tasks;
using CashOverFlow.Models.Languages;
using Microsoft.EntityFrameworkCore;

namespace CashOverFlow.Brokers.Storages;

public partial class StorageBroker
{
    public DbSet<Language> Languages { get; set; }
    public async ValueTask<Language> InsertLanguageAsync(Language language) =>
        await InsertAsync(language);

    public IQueryable<Language> SelectAllLanguages() =>
        SelectAll<Language>();

    public async ValueTask<Language> SelectLanguageByIdAsync(Guid languageId) =>
        await SelectAsync<Language>(languageId);

    public async ValueTask<Language> DeleteLanguageAsync(Language language) =>
        await DeleteAsync(language);

    public async ValueTask<Language> UpdateLanguageAsync(Language language) =>
      await UpdateAsync(language);

}

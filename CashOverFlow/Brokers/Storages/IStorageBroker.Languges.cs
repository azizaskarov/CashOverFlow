using System;
using System.Linq;
using System.Threading.Tasks;
using CashOverFlow.Models.Languages;

namespace CashOverFlow.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask<Language> InsertLanguageAsync(Language language);
    IQueryable<Language> SelectAllLanguages();
    ValueTask<Language> SelectLanguageByIdAsync(Guid languageId);
    ValueTask<Language> DeleteLanguageAsync(Language language);
    ValueTask<Language> UpdateLanguageAsync(Language language);
}

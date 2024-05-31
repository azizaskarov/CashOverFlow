using System;
using System.Text.Json.Serialization;
using CashOverFlow.Models.Companies;

namespace CashOverFlow.Models.Reviews;

public class Review
{
    public Guid Id { get; set; }
    public int Starts { get; set; }
    public string Thoughts { get; set; }

    public Guid CompanyId { get; set; }
    [JsonIgnore]
    public Company Company { get; set; }
}

﻿using System;

namespace CashOverFlow.Models.Salaries;

public class Salary
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public int Experience { get; set; }
    public DateTimeOffset CreatedDate { get; set; }

    public Guid LocationId { get; set; }
    public Guid LanguageId { get; set; }
    public Guid JobId { get; set; }
}

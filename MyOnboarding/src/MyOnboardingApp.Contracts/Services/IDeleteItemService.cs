﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using MyOnboardingApp.Contracts.Models;
using MyOnboardingApp.Contracts.Validation;

namespace MyOnboardingApp.Contracts.Services
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDeleteItemService
    {
        Task<IResolvedItem<TodoListItem>> DeleteItemAsync(Guid id);
    }
}
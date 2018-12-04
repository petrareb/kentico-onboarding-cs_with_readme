﻿using System;
using System.Collections.Generic;
using System.Linq;
using MyOnboardingApp.Contracts.Errors;
using MyOnboardingApp.Contracts.Models;
using MyOnboardingApp.Contracts.Validation;

namespace MyOnboardingApp.Services.Validation
{
    internal class TextCheckingValidator : IInvariantValidator<TodoListItem>
    {
        private readonly IEnumerable<IValidationCriterion<TodoListItem>> _criteria = new List<IValidationCriterion<TodoListItem>>
        {
            new TrimmedTextNonEmptyCriterion()
        };


        public IItemWithErrors<TodoListItem> Validate(TodoListItem item)
        {
            var errors = _criteria
                .SelectMany(criterion => criterion.Validate(item))
                .ToList()
                .AsReadOnly();
            //return ItemWithErrors.Create(item, errors);
            throw new NotImplementedException();
        }
    }


    public class TrimmedTextNonEmptyCriterion : IValidationCriterion<TodoListItem>
    {
        public IEnumerable<string> Validate(TodoListItem item)
        {
            if (string.IsNullOrWhiteSpace(item.Text))
            {
                yield return "Text of the item must not be empty or whitespace.";
            }
        }

        IEnumerable<Error> IValidationCriterion<TodoListItem>.Validate(TodoListItem entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
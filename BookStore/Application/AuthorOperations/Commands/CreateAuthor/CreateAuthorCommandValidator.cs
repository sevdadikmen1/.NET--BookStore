﻿using FluentValidation;
using System;

namespace BookStore.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(command=>command.Model.Name).NotEmpty().MinimumLength(2);
            RuleFor(command => command.Model.Lastname).NotEmpty().MinimumLength(2);
            RuleFor(command => command.Model.DateOfBirth).NotEmpty().LessThan(DateTime.Now.Date); ;
        }
    }
}

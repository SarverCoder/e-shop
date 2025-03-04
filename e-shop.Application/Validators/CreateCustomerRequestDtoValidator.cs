using e_shop.Application.Dtos;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace e_shop.Application.Validators
{
    public class CreateCustomerRequestDtoValidator : AbstractValidator<CreateCustomerRequestDto>
    {
        public CreateCustomerRequestDtoValidator()
        {
            var phoneNumberRegexValidator = new Regex("^\\+?[1-9][0-9]{7,14}$");

            RuleFor(r => r.Firstname)
                .NotEmpty()
                .WithMessage("Firstname field is required")
                .Length(0, 100)
                .WithMessage("Firstname must be between 0 and 100");

            RuleFor(r => r.Lastname)
                .NotEmpty();

            RuleFor(r => r.PhoneNumber)
                .Must(phoneNumber => phoneNumberRegexValidator.IsMatch(phoneNumber))
                .WithMessage("Invalid phone number");

            RuleFor(r => r.Email)
                .NotEmpty()
                .EmailAddress();
        }
    }
}

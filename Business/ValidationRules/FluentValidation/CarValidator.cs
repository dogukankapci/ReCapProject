using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThan(250).When(c => c.BrandId == 3);
            RuleFor(c => c.ModelYear).Must(StartWith).WithMessage("Araçlar 2000 model üzeri olmalıdır!");
        }

        private bool StartWith(string arg)
        {
            return arg.StartsWith("20");
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStore.Products
{
    public class ProductValidator : AbstractValidator<ProductRequestDto>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Product name is required.")
                .MaximumLength(100).WithMessage("Product name cannot exceed 100 characters.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Product description is required.")
                .MaximumLength(500).WithMessage("Product description cannot exceed 500 characters.");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Product price must be greater than zero.");

            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("Category ID must be a positive integer.");
        }
    }
}

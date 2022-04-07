using FluentValidation;

namespace ProjetoMat.Class
{
    public class GeometricProgressionValidator : AbstractValidator<GeometricProgressionModel>
    {
        public GeometricProgressionValidator() 
        {
            RuleFor(x => x.primeiroTermo).NotNull();
            
            RuleFor(x => x.Razao).NotNull();
            
            RuleFor(x => x.numerosN).NotNull();
        }
        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<GeometricProgressionModel>.CreateWithOptions((GeometricProgressionModel)model, x => x.IncludeProperties(propertyName)));
            Console.WriteLine(result);
            
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}

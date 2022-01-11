using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Validators
{
  

    public class ValidationErorResult
    {
        public string IsValid { get; set; }
        public string ValidationMessage { get; set; }
    }
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<ValidationErorResult> Errors { get;private set; }
        public void AddError(ValidationErorResult error)
        {
            IsValid = false;

            Errors.Add(error);

        }
    }
  

        public interface IValidator<TDto> where TDto :class
    {
        ValidationResult ValidationResult { get; set; }


        void Validate(TDto dto);

    }
}

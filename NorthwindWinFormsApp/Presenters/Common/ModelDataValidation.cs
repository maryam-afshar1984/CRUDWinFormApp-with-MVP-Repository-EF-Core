using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NorthwindWinFormsApp.Presenters.Common
{
    public class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> results = new List<ValidationResult>();   
            ValidationContext context = new ValidationContext(model);
            bool IsValid = Validator.TryValidateObject(model, context,results,true);
            if (IsValid==false)
            {
                foreach (var item in results)
                {
                    errorMessage += "- " + item.ErrorMessage + "\n";
                    throw new Exception(errorMessage);
                }
            }
        }
    }
}

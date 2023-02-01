using System;
using System.ComponentModel.DataAnnotations;

namespace slnBurdiakTrinidad.Validations
{
    public class CheckCategoriaAttribute : ValidationAttribute
    {

        public CheckCategoriaAttribute() {
            ErrorMessage = "No corresponde a una categoría válida";
        }

        public override bool IsValid(object value)
        {
            string categoria = Convert.ToString(value).ToLower();
            if(categoria == "desayuno")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}

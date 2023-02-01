using System;
using System.ComponentModel.DataAnnotations;

namespace slnBurdiakTrinidad.Validations
{
    public class CheckEdadAttribute : ValidationAttribute
    {
        public CheckEdadAttribute () {
            ErrorMessage = "Debe ser mayor o igual a 18";
        }
        public override bool IsValid(object value)
        {
            int edad = Convert.ToInt32(value);

            if(edad < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

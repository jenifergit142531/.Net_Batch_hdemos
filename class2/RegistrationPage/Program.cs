using System.ComponentModel.DataAnnotations;
using System.Windows.Markup;

public class RegistrationApp
{
    [Required(ErrorMessage ="This is a required field")]
    [DataType(DataType.Text)]
    [StringLength(15,MinimumLength =5,ErrorMessage ="firstname should be have min 5 characters and max 15 characters")]
    public string FirstName { get; set; }

    [Required(ErrorMessage ="{0} is required")]
    [DataType(DataType.Text)]
    public string LastName { get; set; }

    [Range(18,35,ErrorMessage ="Age must be between 18 and 35 only")]
    public int Age { get; set; }


    [DataType(DataType.PhoneNumber)]
    [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$",ErrorMessage ="Phone number is invalid")]
    [IsEmpty(ErrorMessage ="Phone number should not be empty or null")]
    public string PhoneNumber { get; set; }

    [DataType(DataType.EmailAddress)]
    [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage ="Enter a valid email Id")]
    public string Email { get; set; }



}

//custom validation attribute _ user defined annotations

[AttributeUsage(AttributeTargets.Property)]
public class IsEmptyAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        var inputvalue = value as string;
        return !string.IsNullOrEmpty(inputvalue);
    }
}





class Program
{
    public static void Main(string[] args)
    {
        RegistrationApp register = new RegistrationApp();

        //set the property values
        register.FirstName = "aaa";
        register.LastName = "";
        register.Age = 10;
        // register.PhoneNumber = "";

        int phone = int.Parse(register.PhoneNumber);

       
        register.Email = "jeni@gmail.com";


        //validate the data

        ValidationContext context = new ValidationContext(register);
        List<ValidationResult> result = new List<ValidationResult>();
        bool valid = Validator.TryValidateObject(register, context, result, true);
        if(!valid)
        {
            foreach(ValidationResult res in result)
            {
                Console.WriteLine("{0}", res.ErrorMessage);
            }
        }

    }
}

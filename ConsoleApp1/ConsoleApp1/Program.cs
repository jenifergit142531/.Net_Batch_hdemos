using System.ComponentModel.DataAnnotations;

public class Author
{
    [Required(ErrorMessage = "{0} is required")]
    [StringLength(50, MinimumLength = 3,
    ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "{0} is required")]
    [StringLength(50, MinimumLength = 3,
    ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
    [DataType(DataType.Text)]
    public string LastName { get; set; }
    [DataType(DataType.PhoneNumber)]
    [Phone]
    public string PhoneNumber { get; set; }
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Author author = new Author();
        author.FirstName = "Joydip";
        author.LastName = ""; //No value entered
        author.PhoneNumber = "1234567890";
        author.Email = "joydipkanjilal@yahoo.com";
        ValidationContext context = new ValidationContext
        (author, null, null);
        List<ValidationResult> validationResults = new
        List<ValidationResult>();
        bool valid = Validator.TryValidateObject
        (author, context, validationResults, true);
        if (!valid)
        {
            foreach (ValidationResult validationResult in
            validationResults)
            {
                Console.WriteLine("{0}",
                validationResult.ErrorMessage);
            }
        }
        Console.ReadKey();
    }
}


namespace bukyBookWeb.Models
{

    [Index(nameof(Name), IsUnique = true)]
    public class Category
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="name feild is required .")]
        [StringLength(maximumLength:100,MinimumLength =10)]
    
        public string? Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}

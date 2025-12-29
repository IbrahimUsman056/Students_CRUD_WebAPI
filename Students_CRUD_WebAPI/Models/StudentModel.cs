namespace Students_CRUD_WebAPI.Models
{
    using System.ComponentModel.DataAnnotations;

    public class StudentModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Address { get; set; }
    }
    //practice

    //[key]
    //[required]
    // public int ID {get; set;}
    // [required]
    // public string name{get;set;}
    // [required]
    // public string address


}

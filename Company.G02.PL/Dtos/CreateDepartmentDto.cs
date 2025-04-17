using System.ComponentModel.DataAnnotations;

namespace Company.G02.PL.Dtos
{
    public class CreateDepartmentDto
    {
        [Required(ErrorMessage ="Code is Reuired !")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is Reuired !")]
        public string Name { get; set; }
       [Required(ErrorMessage = "CreateAt is Reuired !")]
        public DateTime CreateAt { get; set; }
    }
}


namespace Company.G02.DAL.FOLDER_Models.ModelEmployees
{
    public class Employee : BaseEntity
    { 
       
        public string name { get; set; }
        public int age { get; set; }
        public string? Email { get; set; }
        public string Address { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime HiringDate { get; set; }       
       // public Gender Gender { get; set; }
        public DateTime CreateAt { get; set; }
    }
}

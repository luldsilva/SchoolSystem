namespace SchoolSystem.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public required string Cpf { get; set; }
        public required string Address { get; set; }
        public required string MobilePhone { get; set; }
        public int SchoolId { get; set; }
    }
}

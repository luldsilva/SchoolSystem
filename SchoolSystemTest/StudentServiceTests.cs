using SchoolSystem.Application.Services;
using SchoolSystem.Domain.Entities;
using SchoolSystem.Infrastructure.Repositories;

namespace SchoolSystemTest
{
    public class StudentServiceTests
    {
        [Fact]
        public void CreateStudent_ShouldAddStudentToRepository()
        {
            // Arrange
            var studentRepository = new InMemoryStudentRepository();
            var studentService = new StudentService(studentRepository);

            var student = new Student
            {
                Name = "John Doe",
                BirthDate = new DateTime(2000, 1, 1),
                Cpf = "12345678900",
                Address = "Test Street",
                MobilePhone = "11999999999",
                SchoolId = 1
            };

            // Act
            studentService.Create(student);
            var students = studentService.GetAll();

            // Assert
            Assert.Single(students);
            Assert.Equal("John Doe", students.First().Name);
        }
    }
}

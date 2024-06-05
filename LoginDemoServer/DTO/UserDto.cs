using LoginDemoServer.Models;
namespace LoginDemoServer.DTO
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Name { get; set; }
        public List<DTO.GradeDTO> ?Grades { get; private set; }

        public Models.User ToModelsUser()
        {
            return new Models.User() { Email = Email, Password = Password, PhoneNumber = PhoneNumber, BirthDate = BirthDate, Name = Name };
        }

        public UserDTO() { }
        public UserDTO(Models.User modelUser)
        {
            this.PhoneNumber = modelUser.PhoneNumber;
            this.Name = modelUser.Name;
            this.Email = modelUser.Email;
            this.Password = modelUser.Password;
            this.BirthDate = modelUser.BirthDate;
            this.Grades = GradeDTO.ConvertGradeListToDTO(modelUser.Grades);
        }
    }
}

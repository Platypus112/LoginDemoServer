using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace LoginDemoServer.DTO
{
    public class GradeDTO
    {
        public int TestId { get; set; }

        public string? Email { get; set; }

        public DateTime Date { get; set; }

        public string Name { get; set; } = null!;

        public int Grade1 { get; set; }

        public Models.Grade ToModelsGrade()
        {
            return new Models.Grade { TestId = TestId, Email = Email, Date = Date, Name = Name, Grade1 = Grade1 };
        }
        public GradeDTO() { }
        public GradeDTO(Models.Grade grade)
        {
            this.TestId = grade.TestId;
            this.Name = grade.Name;
            this.Email = grade.Email;
            this.Date= grade.Date;
            this.Grade1= grade.Grade1;
        }
        public static List<GradeDTO> ConvertGradeListToDTO(ICollection<Models.Grade> grades)
        {
            List<GradeDTO> list = new List<GradeDTO>();
            foreach (var grade in grades)
            {
                list.Add(new GradeDTO()
                {
                    TestId=grade.TestId,
                    Email=grade.Email,
                    Date=grade.Date,
                    Name=grade.Name,
                    Grade1=grade.Grade1,
                });
            }
            return list;
        }
    }
}

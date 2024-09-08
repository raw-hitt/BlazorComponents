using BlazorComponents.Components.Classes;
using BlazorComponents.Models;

namespace BlazorComponents.Services
{
    public class StudentsService
    {
        public List<Students> GetStudents()
        {
            return new List<Students>
            {
                new Students { Id = 1, Name = "John Carter", Email = "john.carter@example.com", Grade = 10, Major = "Mathematics" },
                new Students { Id = 2, Name = "Emma Davis", Email = "emma.davis@example.com", Grade = 12, Major = "Biology" },
                new Students { Id = 3, Name = "Sophia Patel", Email = "sophia.patel@example.com", Grade = 11, Major = "Physics" },
                new Students { Id = 4, Name = "Liam Thompson", Email = "liam.thompson@example.com", Grade = 9, Major = "Chemistry" },
                new Students { Id = 5, Name = "Olivia Brown", Email = "olivia.brown@example.com", Grade = 12, Major = "Computer Science" },
                new Students { Id = 6, Name = "Ethan Martinez", Email = "ethan.martinez@example.com", Grade = 10, Major = "History" },
                new Students { Id = 7, Name = "Mia Garcia", Email = "mia.garcia@example.com", Grade = 11, Major = "English" },
                new Students { Id = 8, Name = "Noah Lee", Email = "noah.lee@example.com", Grade = 12, Major = "Economics" },
                new Students { Id = 9, Name = "Isabella Kim", Email = "isabella.kim@example.com", Grade = 9, Major = "Art" },
                new Students { Id = 10, Name = "James Wilson", Email = "james.wilson@example.com", Grade = 11, Major = "Political Science" }
            };

        }

        public List<ColumnsList> GetStudentsHeaders()
        {
            var Columns = new List<ColumnsList>
            {
                new ColumnsList{Title="Id",Order=1},
                new ColumnsList{Title="Name",Order=2},
                new ColumnsList{Title="Email",Order=3},
                new ColumnsList{Title="Grade",Order=4},
                new ColumnsList{Title="Major",Order=5},
            };

            return Columns.OrderBy(x => x.Order).ToList();
        }
    }
}

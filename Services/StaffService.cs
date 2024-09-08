using BlazorComponents.Components.Classes;
using BlazorComponents.Models;

namespace BlazorComponents.Services
{
    public class StaffService
    {
        public List<Staff> GetStaff()
        {
            return new List<Staff>
            {
                new Staff { Id = 1, First = "Michael Johnson", Email = "michael.johnson@example.com", PhoneNumber = "123-456-7890", Position = "Teacher", Salary = 50000m, Department = "Math Department" },
                new Staff { Id = 2, First = "Sarah Williams", Email = "sarah.williams@example.com", PhoneNumber = "234-567-8901", Position = "Administrator", Salary = 60000m, Department = "Administration" },
                new Staff { Id = 3, First = "David Smith", Email = "david.smith@example.com", PhoneNumber = "345-678-9012", Position = "IT Support", Salary = 45000m, Department = "IT Department" },
                new Staff { Id = 4, First = "Emily Brown", Email = "emily.brown@example.com", PhoneNumber = "456-789-0123", Position = "Counselor", Salary = 55000m, Department = "Student Support" },
                new Staff { Id = 5, First = "Christopher Lee", Email = "christopher.lee@example.com", PhoneNumber = "567-890-1234", Position = "Science Teacher", Salary = 52000m, Department = "Science Department" },
                new Staff { Id = 6, First = "Jessica Garcia", Email = "jessica.garcia@example.com", PhoneNumber = "678-901-2345", Position = "Principal", Salary = 75000m, Department = "Administration" },
                new Staff { Id = 7, First = "Daniel Martinez", Email = "daniel.martinez@example.com", PhoneNumber = "789-012-3456", Position = "History Teacher", Salary = 51000m, Department = "History Department" },
                new Staff { Id = 8, First = "Sophia Hernandez", Email = "sophia.hernandez@example.com", PhoneNumber = "890-123-4567", Position = "Librarian", Salary = 47000m, Department = "Library" },
                new Staff { Id = 9, First = "Matthew Davis", Email = "matthew.davis@example.com", PhoneNumber = "901-234-5678", Position = "Sports Coach", Salary = 48000m, Department = "Physical Education" },
                new Staff { Id = 10, First = "Ava Wilson", Email = "ava.wilson@example.com", PhoneNumber = "012-345-6789", Position = "Art Teacher", Salary = 49000m, Department = "Art Department" }
            };

        }

        public List<ColumnsList> GetStaffHeaders()
        {
            var Columns = new List<ColumnsList>
            {
                new ColumnsList{Title="Id",Order=1},
                new ColumnsList{Title="Full Name",Order=2},
                new ColumnsList{Title="Email Address",Order=3},
                new ColumnsList{Title="Phone Number",Order=4},
                new ColumnsList{Title="Position",Order=5},
                new ColumnsList{Title="Salary",Order=6},
                new ColumnsList{Title="Department",Order=7},
            };

            return Columns.OrderBy(x => x.Order).ToList();
        }
    }
}

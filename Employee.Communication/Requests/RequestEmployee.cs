using Employee.Communication.Enums;

namespace Employee.Communication.Requests
{
    public class RequestEmployee
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public EmployeeType Type { get; set; }
        public int Id { get; set; }
    }
}

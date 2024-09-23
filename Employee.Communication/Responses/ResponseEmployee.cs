using Employee.Communication.Enums;

namespace Employee.Communication.Responses
{
    public class ResponseEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public EmployeeType Type { get; set; }
    }
}

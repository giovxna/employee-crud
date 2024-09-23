using Employee.Communication.Enums;

namespace Employee.Communication.Responses
{
    public class ResponseShortEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public EmployeeType Type { get; set; }
    }
}

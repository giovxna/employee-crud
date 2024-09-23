using Employee.Communication.Responses;

namespace Employee.Application.UseCases.Employee.GetById
{
    public class GetEmployeeByIdUseCase
    {
        public ResponseEmployee Execute(int id)
        {
            return new ResponseEmployee
            {
                Id = id,
                Name = "Giovana",
                Email = "giovana@email.com",
                Password = "123",
                Type = Communication.Enums.EmployeeType.Dev
            };
        }
    }
}

using Employee.Communication.Responses;

namespace Employee.Application.UseCases.Employee.GetAll
{
    public class GetAllEmployeeUseCase
    {
        public ResponseAllEmployee Execute()
        {
            return new ResponseAllEmployee
            {
                //Employees = new List<ResponseShortEmployee>
                //{
                //    new ResponseShortEmployee
                //    {
                //        Id = 1,
                //        Name = "Name",
                //        Type = Communication.Enums.EmployeeType.Dev
                //    }
                //}
            };
        } 
    }
}

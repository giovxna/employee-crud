using Employee.Communication.Requests;
using Employee.Communication.Responses;

namespace Employee.Application.UseCases.Employee.Register;

public class RegisterEmployeeUseCase
{
    public ResponseRegisteredEmployee Execute(RequestEmployee request)
    {

        return new ResponseRegisteredEmployee
        {
            Id = request.Id,
            Name = request.Name,
        };
    }
}

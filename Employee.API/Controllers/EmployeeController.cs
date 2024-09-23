using Employee.Application.UseCases.Employee.Delete;
using Employee.Application.UseCases.Employee.GetAll;
using Employee.Application.UseCases.Employee.GetById;
using Employee.Application.UseCases.Employee.Register;
using Employee.Application.UseCases.Employee.Update;
using Employee.Communication.Requests;
using Employee.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredEmployee), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestEmployee request)
        {
            var response = new RegisterEmployeeUseCase().Execute(request);
            return Created(string.Empty, response);
        }


        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestEmployee request)
        {
            var UseCase = new UpdateEmployeeUseCase();
            UseCase.Execute(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseAllEmployee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var UseCase = new GetAllEmployeeUseCase();
            var response = UseCase.Execute();

            if (response.Employees.Any())
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseEmployee), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var UseCase = new GetEmployeeByIdUseCase();
            var response = UseCase.Execute(id);

            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var UseCase = new DeleteEmployeeByIdUseCase();
            UseCase.Execute(id);

            return NoContent();
        }

    }
}
   


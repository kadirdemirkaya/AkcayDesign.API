using AkcayDesign.API.ResponseMessages;
using BusinessLogicLayer.DTOs.SignIn;
using BusinessLogicLayer.Repositories.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkcayDesign.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterRepository registerRepository;

        public RegisterController(IRegisterRepository registerRepository)
        {
            this.registerRepository = registerRepository;
        }

        [HttpPost]
        [Route("Person-Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            Register register = new() { Message = registerDto.Message, Email = registerDto.Email, Name = registerDto.Name, Surname = registerDto.Surname, IsSuccess = true, CreatedTime = DateTime.Now };

            bool existRegister = await registerRepository.FindRegisterByEmail(registerDto.Email);
            if (!existRegister)
            {
                bool result = await registerRepository.AddAsync(register);
                await registerRepository.SaveChangesAsync();
                if (result)
                    return Ok(new Messages() { message = "Register Process Succussfully", isSuccess = true, Time = DateTime.Now });
                return BadRequest(new Messages() { message = "Register Process Unsuccesfully", isSuccess = false, Time = DateTime.Now });
            }
            return BadRequest(new Messages() { message = "Register Already Exist !", isSuccess = false, Time = DateTime.Now });
        }
    }
}

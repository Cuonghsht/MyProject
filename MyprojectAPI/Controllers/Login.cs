using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyprojectData;
using MyprojectData.Data;

namespace MyprojectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Login : ControllerBase
    {
        private readonly DataContext _dataContext;
        public Login(DataContext data)
        {
            _dataContext = data;
        }
        [HttpGet]
        public IActionResult Loginn(string username, string password)
        {
            var account = _dataContext.Accountss.FirstOrDefault(a => a.AccountName == username);

            if (account == null)
            {
                
                return BadRequest("Lỗi: Tên đăng nhập không tồn tại.");
            }

            
            if (account.AccountPass == password)
            {
                
                return Ok("Đăng nhập thành công!");
            }
            else
            {
                
                return BadRequest("Lỗi: Mật khẩu không chính xác.");
            }
        }

    }
}

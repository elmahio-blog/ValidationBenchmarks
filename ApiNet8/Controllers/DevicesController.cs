using ApiNet8.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiNet8.Controllers;

[ApiController]
[Route("devices")]
public class DevicesController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(CreateDeviceRequest request)
    {
        return Ok(new { Message = "Device accepted (.NET 8)" });
    }
}
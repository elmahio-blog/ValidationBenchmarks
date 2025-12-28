using ApiNet10.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiNet10.Controllers;

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
using Application.Dto;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Web.Host.Controllers;


[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
	public readonly IOrdersService _ordersService;

	public OrderController(IOrdersService ordersService)
	{
		_ordersService = ordersService;
	}

	[HttpPost("createOrder")]
	public IActionResult CreateOrder([FromBody] CreateOrlerDto model)
	{
		_ordersService.CreateOrder(model);
		return Ok();
	}
}
   

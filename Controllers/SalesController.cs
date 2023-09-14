using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data; // Replace with your actual DbContext namespace
using Backend.Models; // Replace with your actual model namespace
using Microsoft.AspNetCore.Cors;


[Route("api/sales")]
[ApiController]
[EnableCors("AllowReactApp")]
public class SalesApiController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SalesApiController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetSales()
    {
        var sales = await _context.Sales.ToListAsync();
        return Ok(sales);
    }
}

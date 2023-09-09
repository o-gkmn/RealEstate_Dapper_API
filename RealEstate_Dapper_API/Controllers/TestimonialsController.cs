using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Repositories.TestimonialRepositories;

namespace RealEstate_Dapper_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialsController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        [HttpGet("testimonials")]
        public async Task<IActionResult> Testimonials()
        {
            var value = await _testimonialRepository.GetAllTestimonialAsync();
            return Ok(value);
        }
    }
}

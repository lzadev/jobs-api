namespace Jobs.Controllers
{
    using Jobs.BussinessLogic.DTOs;
    using Jobs.BussinessLogic.Services.Abstract;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class JobTypesController : ControllerBase
    {
        private readonly IJobTypeService _jobTypeService;

        public JobTypesController(IJobTypeService jobTypeService)
        {
            _jobTypeService = jobTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJobType()
        {
            try
            {
                var result = await _jobTypeService.GetAllJobTypes();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateJobType(CreateJobTypeDto item)
        {
            try
            {
                var result = await _jobTypeService.CreateJobtType(item);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

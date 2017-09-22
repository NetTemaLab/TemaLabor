using Microsoft.AspNetCore.Mvc;
using DanubiusInfo.B4USApi.Services.Interfaces;
using DanubiusInfo.B4USApi.DTO;

namespace DanubiusInfo.B4USApi.Api.Controllers
{
    [Route("api/locations")]
    public class ExampleController : Controller
    {
        private IServiceAndLocationService serviceAndLocationService;
        public ExampleController(IServiceAndLocationService serviceAndLocationService)
        {
            this.serviceAndLocationService = serviceAndLocationService;
        }

        [HttpGet]
        [Route("{location_id:int}/services")]
        public IActionResult Get(int location_id)
        {
            var result = this.serviceAndLocationService.GetServicesAndLocations();
            return Ok(result);
        }

        [HttpPost]
        [Route("addserviceandlocation")]
        public IActionResult AddServiceAndLocation(AddServiceAndLocationDTO request)
        {
            if(request == null || request.Location == null || request.Service == null)
            {
                return BadRequest();
            }

            var result = this.serviceAndLocationService.AddServiceAndLocation(request.Location, request.Service);

            if (!result)
            {
                return StatusCode(500);
            }

            return Ok();
        }
    }
}

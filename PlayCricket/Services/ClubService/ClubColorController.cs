using Microsoft.AspNetCore.Mvc;
using PlayCricket.ViewModel;
using Swashbuckle.AspNetCore.Annotations;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.ClubService
{
    [Route("api/clubs")]
    [SwaggerTag("Club Colors")]
    [ApiController]
    public class ClubColorController : ControllerBase
    {
        // GET: api/<ClubColorController>
        [HttpGet("colors")]
        [SwaggerOperation(
            Summary = "Get All Clubs and Colors",
            Description = "Get All clubs and Colors schema.",
            OperationId = "GetClubsColors")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success")]       
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Insernal Server Error")]
        public List<ClubColor> Get()
        {
            return new List<ClubColor>();
        }

        // GET api/<ClubColorController>/5
        [HttpGet("{clubid}/colors")]
        [SwaggerOperation(
            Summary = "Get Club Colors using ClubId",
            Description = "Get All Club Colors using ClubId",
            OperationId = "GetClubColorsbyId")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success")]        
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Insernal Server Error")]
        public ClubColor Get([SwaggerParameter(Description = "Unique identifier of the club.")] int clubid)
        {
            return new ClubColor();
        }

        // POST api/<ClubColorController>
        [HttpPost("colors")]
        [SwaggerOperation(
            Summary = "Insert Clubs Colors",
            Description = "insert Club Colors",
            OperationId = "InsertClubsColors")]
        [SwaggerResponse(StatusCodes.Status201Created, "Created")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Insernal Server Error")]
        public void Post([FromBody] ClubColor value)
        {
        }

        // PUT api/<ClubColorController>/5
        [HttpPut("{clubid}/colors")]
        [SwaggerOperation(
            Summary = "Update Clubs Colors",
            Description = "update Club Colors",
            OperationId = "UpdateClubsColors")]
        [SwaggerResponse(StatusCodes.Status201Created, "Updated")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Server Error")]
        public void Put([SwaggerParameter(Description = "Unique identifier of the club.")] int clubid, [FromBody] ClubColor value)
        {
        }

        // DELETE api/<ClubColorController>/5
        [HttpDelete("{clubid}/colors")]
        [SwaggerOperation(
            Summary = "Delete Club Colors",
            Description = "Delete Club Colors",
            OperationId = "DeleteClubColors")]
        [SwaggerResponse(StatusCodes.Status201Created, "Deleted")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Insernal Server Error")]
        public void Delete([SwaggerParameter(Description = "Unique identifier of the club.")] int clubid)
        {
        }
    }
}

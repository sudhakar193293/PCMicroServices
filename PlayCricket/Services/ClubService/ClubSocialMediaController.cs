using Microsoft.AspNetCore.Mvc;
using PlayCricket.ViewModel;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.ClubService
{
    [Route("api/clubs")]
    [SwaggerTag("Club SocialMedia")]
    [ApiController]
    public class ClubSocialMediaController : ControllerBase
    {
        // GET: api/<ClubSocialMediaController>
        [HttpGet("socialmedia")]
        [SwaggerOperation(
            Summary = "Get All Clubs and SocialMedia Platforms",
            Description = "Get All Clubs and SocialMedia Platforms",
            OperationId = "GetClubsSocialMediaPlatforms")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Insernal Server Error")]
        public List<ClubSocialMedia> Get()
        {
            return new List<ClubSocialMedia>();
        }

        // GET api/<ClubSocialMediaController>/5
        [HttpGet("{clubid}/socialmedia")]
        [SwaggerOperation(
            Summary = "Get Club SocialMedia Platforms using ClubId",
            Description = "Get Club SocialMedia Platforms using ClubId",
            OperationId = "GetClubSocialMediaPlatformbyId")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Insernal Server Error")]
        public ClubSocialMedia Get([SwaggerParameter(Description = "Unique identifier of the club.")] int clubid)
        {
            return new ClubSocialMedia();
        }

        // POST api/<ClubSocialMediaController>
        [HttpPost("socialmedia")]
        [SwaggerOperation(
            Summary = "Insert Clubs SocialMedia Platforms",
            Description = "Insert Clubs SocialMedia Platforms",
            OperationId = "InsertClubSocialMediaPlatforms")]
        [SwaggerResponse(StatusCodes.Status201Created, "Created")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Insernal Server Error")]
        public void Post([FromBody] List<ClubSocialMedia> value)
        {
        }

        // PUT api/<ClubSocialMediaController>/5
        [HttpPut("{clubid}/socialmedia")]
        [SwaggerOperation(
            Summary = "Update Clubs SocialMedia Platform",
            Description = "Update Clubs SocialMedia Platform",
            OperationId = "UpdateClubSocialMediaePlatform")]
        [SwaggerResponse(StatusCodes.Status201Created, "Updated")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Server Error")]
        public void Put([SwaggerParameter(Description = "Unique identifier of the club.")] int clubid, [FromBody] List<ClubSocialMedia> value)
        {
        }
        [HttpPut("{clubid}/socialmedia/{socialmediaid}")]
        [SwaggerOperation(
            Summary = "Update Clubs SocialMedia Platform by using their Id's",
            Description = "Update Clubs SocialMedia Platform",
            OperationId = "UpdateClubSocialMediaePlatform")]
        [SwaggerResponse(StatusCodes.Status201Created, "Updated")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Server Error")]
        public void PutSocialMedia([SwaggerParameter(Description = "Unique identifier of the club.")] int clubid, [SwaggerParameter(Description = "Unique identifier of the SocialMedia Platform.")] int socialmediaid, ClubSocialMedia value)
        {
        }

        // DELETE api/<ClubSocialMediaController>/5
        [HttpDelete("{clubid}/socialmedia")]
        [SwaggerOperation(
            Summary = "Delete Club SocialMedia Platform",
            Description = "Delete Club SocialMedia Platform",
            OperationId = "DeleteClubSocialMediaPlatform")]
        [SwaggerResponse(StatusCodes.Status201Created, "Deleted")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request")]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Insernal Server Error")]
        public void Delete([SwaggerParameter(Description = "Unique identifier of the club.")] int clubid)
        {
        }
    }
}

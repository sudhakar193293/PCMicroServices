using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.TextToJson
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextToJsonController : ControllerBase
    {
        //// GET: api/<TextToJsonController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<TextToJsonController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<TextToJsonController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            //string jsonText = "{\"event_category_ids\":[\"1\",\"2\",\"3\",\"4\",\"5\",\"6\",\"7\",\"8\",\"9\",\"597\"],\"strapline\":\"We are a friendly, sociable and inclusive cricket club.If you have any queries or would like to join, then please get in touch with us today\\r\\n\\r\\nTEST \\r\\nTEST\\r\\nTEST\",\"match_team_ids\":[\"67067\",\"88037\",\"137434\",\"174606\",\"175121\",\"99743\",\"172549\",\"192194\",\"175120\",\"165118\",\"165117\",\"175518\",\"188833\",\"175631\",\"188834\",\"193875\",\"201996\",\"204193\",\"206155\",\"206185\",\"211783\",\"212940\",\"217001\",\"220343\",\"230358\",\"230462\",\"230463\",\"230464\",\"253008\",\"253009\",\"255654\",\"256470\",\"256965\"],\"hall_of_frame_batting\":[\"top_run_scorer\",\"highest_individual_score\",\"highest_strike_rate\"],\"hall_of_frame_bowling\":[\"top_wicket_taker\",\"best_bowling_figures\",\"most_5_wicket_haul\"],\"hall_of_frame_period\":\"current_season\",\"hall_of_frame_team_ids\":[\"67067\",\"88037\",\"137434\",\"174606\",\"175121\",\"99743\",\"172549\",\"192194\",\"175120\",\"165118\",\"165117\",\"175518\",\"188833\",\"175631\",\"188834\",\"193875\",\"201996\",\"204193\",\"206155\",\"206185\",\"211783\",\"212940\",\"217001\",\"220343\",\"230358\",\"230462\",\"230463\",\"230464\",\"253008\",\"253009\",\"255654\",\"256470\",\"256965\"],\"facebook\":\"\",\"twitter\":\"englandcricket\",\"overview\":\"We're a friendly cricket club that's been bringing players together for competitive matches and social cricket since [year]. Whether you're an experienced player looking for regular weekend fixtures or a complete beginner wanting to learn the game, we've got something for everyone.\\nOur club runs multiple teams across different skill levels, from serious league cricket to relaxed midweek games. We pride ourselves on our welcoming atmosphere, quality facilities, and active social calendar. New members are always welcome – no trials, no pressure, just good cricket and great people.\\nCome down for nets on [day] evenings or get in touch to find out more about joining us this season.\",\"event_calendar_period\":\"next_3_month\",\"overview_title\":\"Welcome to our club\",\"instagram\":\"\",\"youtube\":\"\",\"docs_filter\":\"club\",\"league_table_team_ids\":[\"174606\"]}";

            var obj = JsonSerializer.Deserialize<Dictionary<string, object>>(value);
            return Ok(obj);
        }

        //// PUT api/<TextToJsonController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TextToJsonController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

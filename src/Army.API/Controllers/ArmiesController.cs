using System.Collections.Generic;
using Army.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Army.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ArmiesController : ControllerBase
  {
    // GET api/armies
    [HttpGet]
    public ActionResult<IEnumerable<Unit>> Get()
    {
      var inputJson = System.IO.File.ReadAllText("death-guard.json");
      JObject rss = JObject.Parse(inputJson);
      Catalogue codex = rss.SelectToken("catalogue", false).ToObject<Catalogue>();
      return codex.ArmyUnits.Units;
    }
  }
}

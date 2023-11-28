
namespace CsharpIntro.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DogsController : ControllerBase
{

    private readonly DogsService _dogsService;

    public DogsController(DogsService dogsService)
    {
        _dogsService = dogsService;
    }

    [HttpGet]
    public ActionResult<List<Dog>> GetDogs()
    {
        try
        {
            List<Dog> dogs = _dogsService.GetDogs();
            return Ok(dogs);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
}

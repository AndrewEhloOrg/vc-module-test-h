using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Permissions = AndrewEhloOrg.TestH.Core.ModuleConstants.Security.Permissions;

namespace AndrewEhloOrg.TestH.Web.Controllers.Api;

[Authorize]
[Route("api/test-h")]
public class TestHController : Controller
{
    // GET: api/test-h
    /// <summary>
    /// Get message
    /// </summary>
    /// <remarks>Return "Hello world!" message</remarks>
    [HttpGet]
    [Route("")]
    [Authorize(Permissions.Read)]
    public ActionResult<string> Get()
    {
        return Ok(new { result = "Hello world!" });
    }
}

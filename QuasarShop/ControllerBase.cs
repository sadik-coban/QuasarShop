using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace QuasarShop;

public abstract class ControllerBase : Controller
{
    public Guid UserId => Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)!.Value);
}

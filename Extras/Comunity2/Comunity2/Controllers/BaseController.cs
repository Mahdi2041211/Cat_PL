using jobs.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Comunity2.Controllers
{
    public class BaseController : Controller
    {
        public readonly SessionManger _sessionManger;
      

        public BaseController(SessionManger sessionManger)
        {
            _sessionManger = sessionManger;

        }

    }
}

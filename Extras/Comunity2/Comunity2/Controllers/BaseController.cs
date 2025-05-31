using Comunity2.Data;
using Comunity2.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Comunity2.Controllers
{
    public class BaseController : Controller
    {
        public readonly SessionManger _sessionManger;

        public readonly ApplicationDbContext _applicationDbContext;

        public BaseController(SessionManger sessionManger,ApplicationDbContext applicationDbContext)
        {
            _sessionManger = sessionManger;
            _applicationDbContext = applicationDbContext;

        }

    }
}

<<<<<<< HEAD
﻿using Comunity2.Data;
using jobs.Models;
=======
﻿using jobs.Models;
>>>>>>> 13c9b9920fd44185efb98d925c7aedc94a1ffdee
using Microsoft.AspNetCore.Mvc;
using System;

namespace Comunity2.Controllers
{
    public class BaseController : Controller
    {
        public readonly SessionManger _sessionManger;
<<<<<<< HEAD
        public readonly ApplicationDbContext _applicationDbContext;

        public BaseController(SessionManger sessionManger,ApplicationDbContext applicationDbContext)
        {
            _sessionManger = sessionManger;
            _applicationDbContext = applicationDbContext;
=======
      

        public BaseController(SessionManger sessionManger)
        {
            _sessionManger = sessionManger;
>>>>>>> 13c9b9920fd44185efb98d925c7aedc94a1ffdee

        }

    }
}

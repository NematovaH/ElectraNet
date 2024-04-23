﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElectraNet.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController : ControllerBase { }
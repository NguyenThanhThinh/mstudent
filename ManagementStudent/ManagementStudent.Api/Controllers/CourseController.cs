﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ManagementStudent.Api.Controllers
{
	[Route("api/course")]
	public class CourseController : BaseController
	{
		[HttpGet("{id}")]
		public IActionResult GetById(int Id)
		{
			return Ok(Id);
		}
	}
}
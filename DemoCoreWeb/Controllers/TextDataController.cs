﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
namespace DemoWebApi.Controllers
{
	/// <summary>
	/// For testing posting and getting string data. String returned is text/plain by default
	/// </summary>
	[Route("api/[controller]")]
	public class TextDataController : ControllerBase
	{
		[HttpGet]
		[Route("AthletheSearch")]
		public string AthletheSearch([FromQuery] int? take = 10, [FromQuery] int skip = 0, [FromQuery] string order = null, [FromQuery] string sort = null, [FromQuery] string search = null)
		{
			return (take.HasValue ? take.Value.ToString() : String.Empty) + skip.ToString() + (String.IsNullOrEmpty(order) ? "" : order) + (String.IsNullOrEmpty(sort) ? "" : sort) + (String.IsNullOrEmpty(search) ? "" : search);
		}

		/// <summary>
		/// Return empty body with status 204 No Content.
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		[Route("NullString")]
		[return: System.Diagnostics.CodeAnalysis.MaybeNull]
		public string GetNullString()
		{
			return null;
		}

		/// <summary>
		/// MaybeNull
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		[Route("NullableString")]
		[return: System.Diagnostics.CodeAnalysis.MaybeNull]
		public string GetNullableString()
		{
			if (DateTime.Now > new DateTime(2008, 12, 3))
			{
				return "ABCD";
			}
			else
			{
				return null;
			}
		}

		[HttpGet]
		[Route("String")]
		public string GetABCDE()
		{
			return "ABCDE";
		}

		/// <summary>
		/// Return empty body with status 200.
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		[Route("EmptyString")]
		public string GetEmptyString()
		{
			return String.Empty;
		}
	}
}

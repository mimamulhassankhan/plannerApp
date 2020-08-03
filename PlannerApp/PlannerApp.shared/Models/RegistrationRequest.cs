using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlannerApp.shared.Models
{
	public class RegistrationRequest
	{
		[EmailAddress]
		[Required]
		[StringLength(50)]
		public string EmailAddress { get; set; }

		[Required]
		[StringLength(25)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(25)]
		public string LastName { get; set; }

		[Required]
		[StringLength(50)]
		public string Password { get; set; }

		[Required]
		[StringLength(50)]
		public string ConfirmPassword { get; set; }
	}
}

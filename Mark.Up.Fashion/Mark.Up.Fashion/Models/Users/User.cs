using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Up.Fashion.Models.Users
{
	public class User
	{
		[Key]
		public long Id { get; set; }
		public string Username { get; set;}
		public string Email { get; set;}
		public string Password { get; set;}
		public string Dob { get; set;}
		public string Address { get; set;}
	}
}

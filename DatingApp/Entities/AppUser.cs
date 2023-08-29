﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.Entities
{
	public class AppUser
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
    }
}


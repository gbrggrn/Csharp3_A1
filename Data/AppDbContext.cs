﻿using Microsoft.EntityFrameworkCore;

namespace Csharp3_A1.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

	}
}

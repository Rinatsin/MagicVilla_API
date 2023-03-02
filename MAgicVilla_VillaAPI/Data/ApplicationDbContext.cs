using MAgicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MAgicVilla_VillaAPI.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
		{
		}

		public DbSet<Villa> Villas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var villas = new Villa[10]
			{
				new Villa()
				{
					Id = 1,
					Name = "Great Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 5,
					Rate = 200,
					Sqft = 550,
					Amenity = "",
					CreatedDate = DateTime.Now
				},
				new Villa()
				{
					Id = 2,
					Name = "Best Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 5,
					Rate = 200,
					Sqft = 750,
					Amenity = "",
					CreatedDate = DateTime.Now
				},
				new Villa()
				{
					Id = 3,
					Name = "Shark Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 5,
					Rate = 200,
					Sqft = 650,
					Amenity = "",
					CreatedDate = DateTime.Now
				},
				new Villa()
				{
					Id = 4,
					Name = "Best of The best Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 5,
					Rate = 200,
					Sqft = 850,
					Amenity = "",
					CreatedDate = DateTime.Now
				},
				new Villa()
				{
					Id = 5,
					Name = "Small small Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 5,
					Rate = 200,
					Sqft = 130,
					Amenity = "",
					CreatedDate = DateTime.Now
				},
				new Villa()
				{
					Id = 6,
					Name = "Vintage Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 5,
					Rate = 200,
					Sqft = 450,
					Amenity = "",
					CreatedDate = DateTime.Now
				},
				new Villa()
				{
					Id = 7,
					Name = "Cool Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 5,
					Rate = 200,
					Sqft = 250,
					Amenity = "",
					CreatedDate = DateTime.Now
				},
				new Villa()
				{
					Id = 8,
					Name = "Very small Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 5,
					Rate = 200,
					Sqft = 150,
					Amenity = "",
					CreatedDate = DateTime.Now
				},
				new Villa()
				{
					Id = 9,
					Name = "Big Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 5,
					Rate = 200,
					Sqft = 520,
					Amenity = "",
					CreatedDate = DateTime.Now
				},
				new Villa()
				{
					Id = 10,
					Name = "Very big Villa",
					Details =
						"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
					ImageUrl =
						"https://img.freepik.com/free-photo/house-isolated-field_1303-23773.jpg?w=1380&t=st=1677591271~exp=1677591871~hmac=180ca56a4f333bf1655b7ddd68ef19d3577034bfccb003020cd4a6744ca5e7cc",
					Occupancy = 7,
					Rate = 200,
					Sqft = 510,
					Amenity = "",
					CreatedDate = DateTime.Now
				}
			};
			modelBuilder.Entity<Villa>().HasData(villas);
		}
	}
}

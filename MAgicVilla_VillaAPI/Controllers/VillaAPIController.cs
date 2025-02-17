﻿using MAgicVilla_VillaAPI.Data;
using MAgicVilla_VillaAPI.Models;
using MAgicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAgicVilla_VillaAPI.Controllers
{
	[Route("api/VillaAPI")]
	[ApiController]
	public class VillaAPIController : ControllerBase
	{
		private readonly ApplicationDbContext _db;
		private readonly ILogger<VillaAPIController> _logger;

		public VillaAPIController(ILogger<VillaAPIController> logger, ApplicationDbContext db)
		{
			_logger = logger;
			_db = db;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<IEnumerable<VillaDTO>> GetVillas()
		{
			_logger.LogInformation("GettingAllVillas");
			return Ok(_db.Villas.ToList());
		}

		[HttpGet("{id:int}", Name ="GetVilla")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<VillaDTO> GetVilla(int id)
		{
			if (id == 0) 
			{
				_logger.LogError($"Get Villa Error with Id: {id}");
				return BadRequest(); 
			}
			var villa = _db.Villas.FirstOrDefault(u => u.Id == id);
			if (villa == null) 
			{ 
				return NotFound(); 
			}
			return Ok(villa);
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<VillaDTO> CreateVilla(VillaDTO villaDTO)
		{
			if (_db.Villas.
				    FirstOrDefault(item => item.Name.ToLower() == villaDTO.Name.ToLower()) != null)
			{
				ModelState.AddModelError("CustomError", $"Villa with name {villaDTO.Name} already exist!");
				return BadRequest(ModelState);
			}

			if (villaDTO == null)
			{
				return BadRequest(villaDTO);
			}
			if(villaDTO.Id > 0)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

			Villa model = new()
			{
				Amenity = villaDTO.Amenity,
				Details = villaDTO.Details,
				Id = villaDTO.Id,
				ImageUrl = villaDTO.ImageUrl,
				Name = villaDTO.Name,
				Occupancy = villaDTO.Occupancy,
				Rate = villaDTO.Rate,
				Sqft = villaDTO.Sqft
			};

			_db.Villas.Add(model);
			_db.SaveChanges();

			return CreatedAtRoute("GetVilla", new {id = villaDTO.Id}, villaDTO);
		}

		[HttpDelete("{id:int}", Name = "DeleteVilla")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public IActionResult DeleteVilla(int id)
		{
			if (id == 0)
			{
				return BadRequest();
			}
			var villa = _db.Villas.FirstOrDefault(u => u.Id == id);
			if (villa == null)
			{
				return NotFound();
			}
			_db.Villas.Remove(villa);
			_db.SaveChanges();

			return NoContent();
		}

		[HttpPut("{id:int}", Name = "UpdateVilla")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public IActionResult UpdateVilla(int id, [FromBody]VillaDTO villaDTO)
		{
			if (villaDTO == null || id != villaDTO.Id)
			{
				return BadRequest();
			}
			Villa model = new()
			{
				Amenity = villaDTO.Amenity,
				Details = villaDTO.Details,
				Id = villaDTO.Id,
				ImageUrl = villaDTO.ImageUrl,
				Name = villaDTO.Name,
				Occupancy = villaDTO.Occupancy,
				Rate = villaDTO.Rate,
				Sqft = villaDTO.Sqft
			};

			_db.Villas.Update(model);
			_db.SaveChanges();

			return NoContent();
		}

		[HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDTO)
		{
			if (patchDTO == null || id == 0)
			{
				return BadRequest();
			}
			var villa = _db.Villas.AsNoTracking().FirstOrDefault(u => u.Id == id);

			VillaDTO villaDTO = new()
			{
				Amenity = villa.Amenity,
				Details = villa.Details,
				Id = villa.Id,
				ImageUrl = villa.ImageUrl,
				Name = villa.Name,
				Occupancy = villa.Occupancy,
				Rate = villa.Rate,
				Sqft = villa.Sqft
			};

			if (villa == null)
			{
				return BadRequest();
			}

			patchDTO.ApplyTo(villaDTO, ModelState);

			Villa model = new()
			{
				Amenity = villaDTO.Amenity,
				Details = villaDTO.Details,
				Id = villaDTO.Id,
				ImageUrl = villaDTO.ImageUrl,
				Name = villaDTO.Name,
				Occupancy = villaDTO.Occupancy,
				Rate = villaDTO.Rate,
				Sqft = villaDTO.Sqft
			};

			_db.Villas.Update(model);
			_db.SaveChanges();

			if (!ModelState.IsValid)
			{
				BadRequest(ModelState);
			}

			return NoContent();
		}
	}
}

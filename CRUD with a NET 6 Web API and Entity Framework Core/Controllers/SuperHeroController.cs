using CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Data;
using CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null)
            {
                return BadRequest("No heroes found");
            }
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero hero)
        {
            var foundHero = await _context.SuperHeroes.FindAsync(hero.Id);
            if (foundHero == null)
            {
                return BadRequest($"No hero found with id: {hero.Id}");
            }

            foundHero.Name = hero.Name;
            foundHero.FirstName = hero.FirstName;
            foundHero.LastName = hero.LastName;
            foundHero.Place = hero.Place;
            foundHero.Weapon = hero.Weapon;

            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var foundHero = await _context.SuperHeroes.FindAsync(id);
            if (foundHero == null)
            {
                return BadRequest($"No hero found with id: {id}");
            }

            _context.SuperHeroes.Remove(foundHero);
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }
    }
}

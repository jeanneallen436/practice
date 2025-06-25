using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCAspnet.Models;
using MVCAspnet.Repos;

namespace MVCAspnet.Controllers
{
    [Route("[controller]")]
    public class CharacterController : Controller
    {
        private readonly ILogger<CharacterController> _logger;

        private readonly CharactersRepository _characterRepository;

        public CharacterController(ILogger<CharacterController> logger, CharactersRepository charactersRepository)
        {
            _logger = logger;
            _characterRepository = charactersRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpPost]
        public async Task<ActionResult> AddCharacter()
        {
            Character newCharacter = new();
            Character addedCharacter = await _characterRepository.AddCharacterAsync(newCharacter);
            return Ok();
        }
    }
}
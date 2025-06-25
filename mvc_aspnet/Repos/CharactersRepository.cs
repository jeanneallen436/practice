using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCAspnet.Models;

namespace MVCAspnet.Repos
{
    public class CharactersRepository
    {
        private readonly AppDbContext _context;
        public CharactersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Character> AddCharacterAsync(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();
            return await Task.FromResult(character);
        }
    }
}
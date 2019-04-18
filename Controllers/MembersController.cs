using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using troca_de_figurinhas.Models;

namespace troca_de_figurinhas.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MembersController : ControllerBase
    {

        private readonly ContextoFigurinhas _context;

        public MembersController(ContextoFigurinhas context)
        {
            _context = context;
        }

        // GET: api/Members
        [HttpGet]
        [ActionName("getMembersList")]
        public IEnumerable<MembersViewModel> GetMembers()
        {
            var listMembers = _context.Members.ToList();
            return getMembersViewModel(listMembers);
        }
    }
}
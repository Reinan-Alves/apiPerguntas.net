using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizAngular.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http.Cors;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizAngular.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class PerguntasController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        public PerguntasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<PerguntasController>
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Pergunta>>> GetPerguntas() 
        {
            return await _context.Perguntas.ToListAsync();
        
        }

        // POST api/<PerguntasController>
        [HttpPost]
        public async Task<ActionResult<Pergunta>> PostPergunta(Pergunta pergunta)
        {
            _context.Perguntas.Add(pergunta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPergunta", new { id = pergunta.id },pergunta);
       }
        
    }
}

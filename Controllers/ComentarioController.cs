using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend.Modelo;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComentarioController : ControllerBase
    {
        private Contexto db;
        public ComentarioController (Contexto _db)
        {
            db = _db;
        }
        [HttpGet]
        public List<Comentario> Get()
        {
           
            return db.COMENTARIOS.ToList();
        }
         [HttpGet("{id}")]
        public List<Comentario> Get(long id)
        {
           
            return db.COMENTARIOS.Where(a=>a.produtoId==id).ToList();
        }

        [HttpPost]
        public void Post([FromBody] Comentario dados)
        {
            db.COMENTARIOS.Add(dados);
            db.SaveChanges();
        }
    }

}
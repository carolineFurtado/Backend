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
    public class ProdutoController : ControllerBase
    {
        private Contexto db;
        public ProdutoController (Contexto _db)
        {
            db = _db;
        }
        [HttpGet]
        public List<Produto> Get()
        {
           
            return db.PRODUTO.ToList();
        }
         [HttpGet("{id}")]
        public Produto Get(long id)
        {
           
            return db.PRODUTO.Where(a=>a.id==id).FirstOrDefault();
        }

        [HttpPost]
        public void Post([FromBody] Produto dados)
        {
            db.PRODUTO.Add(dados);
            db.SaveChanges();
        }
    }

}
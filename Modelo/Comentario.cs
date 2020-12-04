using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.Modelo
{
    public class Comentario{
        public long id {get; set;}
       
        public long produtoId {get; set;}

        public Produto produto {get; set;}

        public string comentario {get; set;}
        
    }

}
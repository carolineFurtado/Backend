using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.Modelo
{
    public class Produto{
        public long id {get; set;}
        public string nome{get; set;}
        public decimal preco{get; set;}
        public decimal  peso{get; set;}

        public string urlImagem{get; set;}
        
    }

}
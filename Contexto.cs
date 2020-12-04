using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Backend.Modelo;


    namespace Backend
    {
        public class Contexto : DbContext
        {
            public Contexto (DbContextOptions<Contexto> options) : base(options)

                {
                    
                }
            public DbSet<Produto> PRODUTO {get; set;}

            public DbSet<Comentario> COMENTARIOS {get; set;}
        }


    }
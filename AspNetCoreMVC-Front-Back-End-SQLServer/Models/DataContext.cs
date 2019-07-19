using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVC_Front_Back_End_SQLServer.Models;
using Microsoft.EntityFrameworkCore;


namespace AspNetCoreMVC_Front_Back_End_SQLServer.Models
{
    public class DataContext : DbContext
    {
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Aluno>();
           
        }*/
       
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.OpenConnection();
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Escola> Escola { get; set; }
        
    }
}
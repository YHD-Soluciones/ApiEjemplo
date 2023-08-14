//-----------------------------------------------------------------------
// <copyright file="ApplicationDbContext.cs" company="YHD Soluciones">
// 
//	Author:			JotaAP 
//  Copyright 		(c) 2023. YHD Soluciones. All rights reserved.
//	Date: 			10/08/2023 21:33:10
//			
// </copyright>
//-----------------------------------------------------------------------
using System;
using Microsoft.EntityFrameworkCore;

namespace ApiEjemplo.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
    }
}

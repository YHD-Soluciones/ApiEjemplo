//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="YHD Soluciones">
// 
//	Author:			JotaAP 
//  Copyright 		(c) 2023. YHD Soluciones. All rights reserved.
//	Date: 			10/08/2023 21:33:09
//			
// </copyright>
//-----------------------------------------------------------------------
using System;
using ApiEjemplo.Datos;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
    .AddDbContext<ApplicationDbContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
WebApplication app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//-----------------------------------------------------------------------
// <copyright file="Persona.cs" company="YHD Soluciones">
// 
//	Author:			JotaAP 
//  Copyright 		(c) 2023. YHD Soluciones. All rights reserved.
//	Date: 			10/08/2023 21:33:10
//			
// </copyright>
//-----------------------------------------------------------------------
namespace ApiEjemplo.Datos
{
    public class Persona
    {
        public string CI { get; set; }

        public Guid Id { get; set; } = Guid.NewGuid();

        public string Nombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }
    }
}

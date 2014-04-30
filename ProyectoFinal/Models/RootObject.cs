﻿using System.Collections.Generic;

namespace ProyectoFinal.Models
{
    public class RootObject
    {
        public int id { get; set; }
        public virtual ModeloDatos modeloDatos { get; set; }
        public virtual ModeloExamen modeloExamen { get; set; }
        public virtual ModeloMotivos modeloMotivos { get; set; }
        public virtual IEnumerable<ModeloTrauma> modeloTrauma { get; set; }
        public virtual ModeloCoordenadasUno modeloCoordenadasUno { get; set; }
        public virtual ModeloCoordenadasDos modeloCoordenadasDos { get; set; }
        public virtual ModeloCoordenadasTres modeloCoordenadasTres { get; set; }
    }
}
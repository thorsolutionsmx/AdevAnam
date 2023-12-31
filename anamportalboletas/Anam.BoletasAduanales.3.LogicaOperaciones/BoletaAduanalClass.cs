﻿using Anam.BoletasAduanales._2.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Anam.BoletasAduanales._3.LogicaOperaciones
{
    public class BoletaAduanalClass
    {
        // DONE: Implementar la logica de la operacion CalcularIvaBoleta
        public decimal CalcularIvaBoleta(decimal _Iva, decimal _MontoBoleta)
        {
            if (_MontoBoleta <= 1)
            {
                throw new ArgumentException("El monto de la boleta no puede ser menor o igual a 1 peso");
            }
            if (_MontoBoleta > 10000)
            {
                _Iva += 0.02m;
            }
            //            System.Threading.Thread.Sleep(4000);
            decimal _res = _Iva * _MontoBoleta;
            return _res;
        }

        public List<CatalogoIva> GetCatalogoIva()
        { 
            List<CatalogoIva> _milista = new List<CatalogoIva>();





            CatalogoIva _Iva = new CatalogoIva() { 
                 Id = 1, Descripcion="para personas morales" , EsExento=false, IvaPorcentaje=0.16m, Nombre="Iva Morales"
             };
            _milista.Add(_Iva);

            _Iva = new CatalogoIva()
            {
                Id = 2,
                Descripcion = "para personas Fisicas",
                EsExento = false,
                IvaPorcentaje = 0.08m,
                Nombre = "Iva Fisicas"
            };
            _milista.Add(_Iva);

            _Iva = new CatalogoIva()
            {
                Id = 3,
                Descripcion = "para personas Asociaciones",
                EsExento = true,
                IvaPorcentaje = 0m,
                Nombre = "Iva Asociaciones"
            };
            _milista.Add(_Iva);

            return _milista;        
        }


    }
}

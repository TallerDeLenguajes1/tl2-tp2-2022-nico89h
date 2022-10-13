using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tl2_tp2_2022_nico89h
{
    internal class Casado:Empleado
    {
        private int CantidadHijos;

        public Casado(int cantidadHijos,int dni, string direccion, string nombre, string apellido, DateTime fechaIngreso, float sueldo, Cargo cargo) : base(dni, direccion, nombre, apellido, fechaIngreso, sueldo, cargo)
        {
            this.CantidadHijos1 = cantidadHijos;
        }

        public Casado():base()
        {
            this.CantidadHijos1 = 0;
        }

        //inicio de getter y setter


        public int CantidadHijos1 { get => CantidadHijos; set => CantidadHijos = value; }
        
        public int cantidadHijos()
        {
            return this.CantidadHijos1;
        }
    }
}

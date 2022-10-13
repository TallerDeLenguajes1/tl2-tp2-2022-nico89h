using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tl2_tp2_2022_nico89h
{
    internal class Divorciado:Empleado
    {
        private DateTime fechaDivorcio;

        public Divorciado(DateTime FechaDivorcio,int dni, string direccion, string nombre, string apellido, DateTime fechaIngreso, float sueldo, Cargo cargo) : base(dni, direccion, nombre, apellido, fechaIngreso, sueldo, cargo)
        {
            this.FechaDivorcio = FechaDivorcio;
        }

        public Divorciado() : base()
        {
            this.FechaDivorcio =DateTime.Now;
        }



        //inicio de getter y setter
        public DateTime FechaDivorcio { get => fechaDivorcio; set => fechaDivorcio = value; }
        
        public DateTime FechaDivorcioDos()
        {
            return this.FechaDivorcio;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace tl2_tp2_2022_nico89h
{
    /*
     Datos personales, Dirección, fecha de ingreso la empresa, datos profesionales.
     */
    enum Cargo
    {
        Ingeniero,
        Adminstrador,
        Programador
    }
    internal class Empleado
    {

        public static Logger logger=LogManager.GetCurrentClassLogger(); //con esta clase agarrare los errores
        
        //iincio de la clase empleado
        private int Dni;
        private string direccion=String.Empty, nombre = String.Empty, apellido = String.Empty;
        private DateTime fechaIngreso;
        private float sueldo;
        private Cargo cargo;
        private float sueldoTotal;
        private float adicional;
        private static float descuento=15;
        //inicio de constructor por defecto
        public Empleado()
        {
            this.Dni1 = 0;
            this.Direccion = "";
            this.Nombre = "";
            this.Apellido = "";
            this.FechaIngreso = DateTime.Now;
            this.sueldo = 0;
            this.cargo = Cargo.Adminstrador;
            logger.Warn("Advertencia, los datos cargados no tienen valor, es decir estan vacios");

        }

        //inicio de constructor sobreacrgado
        public Empleado(int dni, string direccion, string nombre, string apellido, DateTime fechaIngreso, float sueldo, Cargo cargo)
        {
            try
            {
                this.Dni1 = dni;
                this.Direccion = direccion;
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.FechaIngreso = fechaIngreso;
                this.sueldo = sueldo;
                this.cargo = cargo;
                logger.Trace("Los datos fueron cargados correctamente");
            }
            catch (Exception)
            {

                logger.Error("No se pudieron cargar los datos, revise nuevamente los mismos");
            }
            
        }
        //inicio de getter y setter
        public int Dni1 { get => Dni; set => Dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public float SueldoTotal { get => sueldoTotal; set => sueldoTotal = value; }
        public float Adicional { get => adicional; set => adicional = value; }
        public Cargo Cargo { get => cargo; set => cargo = value; }
        public float Sueldo{get=>sueldo; set =>sueldo=value;}
        //public float Descuento { get => descuento; }
        //inicio de metodos
        /*
         * a) La clase empleado deberá calcular la antigüedad en la empresa, la edad del
         empleado y el salario. Este se calcula de acuerdo a la fórmula: Salario = Sueldo
         Básico + Adicional – Descuento
         Descuento = 15 % del Sueldo Básico.
         Adicional = 1 % del sueldo básico por cada año de antigüedad.
         1 año__________________________ 1%
         2 años_________________________ 2%
         15 años_________________________ 1 5%
         > 20 años________________________ 25% (a partir de 20 años se fija en 25%)
         */
        //calcula la antiguedad de el empleado
        public void antiguedad()
        {
            int year= DateTime.Now.Year-this.FechaIngreso.Year;
            float sueldoDescuento= (this.Sueldo*this.adicional)/ 100;
            this.Adicional = year >= 20 ? 25 : year;
            this.sueldoTotal = (this.Sueldo - sueldoDescuento)+(this.Sueldo*this.Adicional)/100;
            Console.WriteLine("El sueldo es: "+ this.SueldoTotal);
        }

        public void mostrarDatos()
        {
            try
            {
                Console.WriteLine("Los datos son: ");
                Console.WriteLine("Dni: " + this.Dni1);
                Console.WriteLine("Apellido " + this.Apellido);
                Console.WriteLine("Nombre: " + this.Nombre);
                this.antiguedad();
                Console.WriteLine("Antiguedad " + (DateTime.Now.Year - this.FechaIngreso.Year));
                Console.WriteLine("Fecha de ingreso " + this.FechaIngreso);
            }
            catch (Exception ex)
            {
                
                logger.Warn("La excepcion arrojada es: "+ ex.Message);
                //throw;
            }
            
        }

    }
}

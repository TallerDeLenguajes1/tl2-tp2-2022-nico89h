using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace tl2_tp2_2022_nico89h
{
    internal class Alumno
    {
        private Logger logger= LogManager.GetCurrentClassLogger();
        public int Id { get; set; }
        public string Nombre { get; set; }=String.Empty;
        public string Apellido { get; set; } = String.Empty;
        public int Dni { get; set; }
        public int Curso { get; set; }

        //inicio de constructores
        
        
        //inicio de constructor por defecto
        
        
        public Alumno()
        {
            //añadir un log para avisar que pueden ser null los strings
            this.Dni = 0;
            this.Curso = 0;
            this.Apellido = "";
            this.Nombre = "";
            this.Id = 0;
            this.logger.Warn("Los atributos en la clase alumno estan vacios por defecto");
        }
        
        
        //inicio de constructor por sobrecarga
        
        public Alumno(int id, string nombre, string apellido, int dni, int curso)
        {
            try
            {
                //añadir un log para avisar que pueden ser null los strings
                Id = id;
                Nombre = nombre;
                Apellido = apellido;
                Dni = dni;
                Curso = curso;
            }
            catch (TypeLoadException)
            {
                logger.Error("Los parametros enviados no tienen el mismo tipo");
            }
            
            
        }




        //inicio de metodos

        public int getId()
        {
            try
            {

                return this.Id;
            }
            catch (Exception ex)
            {
                return 0;
                logger.Error("No se pudo retornar el dato solicitado"+ ex.Message);
            }
        }

        



    }
}

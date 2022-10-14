using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tl2_tp2_2022_nico89h
{
    static internal class HelperArchivos //en esta clase se guardaran los archivos
    {

        static private List<Alumno> listadoAlumnos=new List<Alumno>();
        static private Logger logger = LogManager.GetCurrentClassLogger();
        static private string atletismo = "Atletismo.csv", voley = "Voley.csv", futbol = "Futbol.csv";
        //inicio de metodos

        //en este metodo se agregara un alumno al listado
        static public void agregarAlumno(Alumno agregado)
        {
            //añadir try catch
            HelperArchivos.listadoAlumnos.Add(agregado);//agrego un alumno a la clase
        }

        static public void eliminarAlumno(int id)
        {
            //elimina un alumno con ese id
            //selecciono el alumno que coincida con esos datos

            //añadir try catch
            try
            {
                var alumno = from aux in listadoAlumnos where aux.Id == id select aux;

                HelperArchivos.listadoAlumnos.Remove((Alumno)alumno); //elimino el alumno de la lista

                Console.WriteLine("Se elimino el alumno");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine("No se pudo eliminar el alumno"+ ex.Message);

            }
            
        }
        static public void crearArchivos()
        {
            try
            {
                HelperArchivos.crearArchivoFutbol();
                HelperArchivos.crearArchivoAtletismo();
                HelperArchivos.crearArchivoVoley();
            }
            catch (Exception ex)
            {
                logger.Warn("Alguno de los archivos no se pudo crear "+ex.Message);
            }
        } 
    
        static private void crearArchivoAtletismo()
        {
            if (!File.Exists(atletismo))
            {
                try
                {
                    File.Create(atletismo);
                }
                catch (Exception ex)
                {
                    logger.Error("No se pudo crear el archivo atletismo, arroja la excepcion: "+ ex.Message);
                }
            }
            else
            {
                logger.Info("El archivo atletismo ya existe");
            }
        }


        static private void crearArchivoFutbol()
        {
            if (!File.Exists(futbol))
            {
                try
                {
                    File.Create(futbol);
                }
                catch (Exception ex)
                {
                    logger.Error("No se pudo crear el archivo futbol, arroja la excepcion: " + ex.Message);
                }
            }
            else
            {
                logger.Info("El archivo futbol ya existe");
            }
        }

        static private void crearArchivoVoley()
        {
            if (!File.Exists(voley))
            {
                try
                {
                    File.Create(voley);
                }
                catch (Exception ex)
                {
                    logger.Error("No se pudo crear el archivo voley, arroja la excepcion: " + ex.Message);
                }
            }
            else
            {
                logger.Info("El archivo voley ya existe");
            }
        }

        static public void escribirArchivos()
        {
            try
            {
                HelperArchivos.escribirVoley();
                HelperArchivos.escribirFutbol();
                HelperArchivos.escribirAtletismo();
            }
            catch (Exception ex)
            {
                logger.Fatal("No se pudo escribir uno de los archivos" + ex.Message);
                throw;
            }
        }
        
        static private void escribirVoley()
        {
            try
            {
                FileStream archivo=new FileStream(voley, FileMode.Open);
                StreamWriter escribir = new StreamWriter(archivo);
                //int id, string nombre, string apellido, int dni, int curso
                foreach (Alumno item in HelperArchivos.listadoAlumnos)
                {
                    if (item.Curso==0)
                    {
                        escribir.WriteLine("{0},{1},{2},{3},{4}", item.Id, item.Nombre, item.Apellido, item.Dni, item.Curso);
                    }
                }
                
                escribir.Close();
                archivo.Close();
            }
            catch (Exception ex)
            {
                logger.Error("No se pudo escribir el archivo de voley.csv"+ ex.Message);
                
            }
        }
        static public void escribirAtletismo()
        {
            try
            {
                FileStream archivo = new FileStream(atletismo, FileMode.Open);
                StreamWriter escribir = new StreamWriter(archivo);
                //int id, string nombre, string apellido, int dni, int curso
                foreach (Alumno item in HelperArchivos.listadoAlumnos)
                {
                    if (item.Curso == 1)
                    {
                        escribir.WriteLine("{0},{1},{2},{3},{4}", item.Id, item.Nombre, item.Apellido, item.Dni, item.Curso);
                    }
                }

                escribir.Close();
                archivo.Close();
            }
            catch (Exception ex)
            {
                logger.Error("No se pudo escribir el archivo de atletismo.csv" + ex.Message);

            }
        }
        static private void escribirFutbol()
        {
            try
            {
                FileStream archivo = new FileStream(futbol, FileMode.Open);
                StreamWriter escribir = new StreamWriter(archivo);
                //int id, string nombre, string apellido, int dni, int curso
                foreach (Alumno item in HelperArchivos.listadoAlumnos)
                {
                    if (item.Curso == 2)
                    {
                        escribir.WriteLine("{0},{1},{2},{3},{4}", item.Id, item.Nombre, item.Apellido, item.Dni, item.Curso);
                    }
                }

                escribir.Close();
                archivo.Close();
            }
            catch (Exception ex)
            {
                logger.Error("No se pudo escribir el archivo de futbol.csv" + ex.Message);

            }
        }


    }
}

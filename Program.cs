using NLog; //uso la libreria de NLog
using tl2_tp2_2022_nico89h;
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Logger control = LogManager.GetCurrentClassLogger();
//control.Info("Jose");


//inicio de la interfaz para cargar los datos del usuario
//Console.WriteLine("Inicio de interfaz para cargar datos del usuario");
//Console.WriteLine("Id del alumno: ");
//int id = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Dni del alumno: ");
//int DNI=Int32.Parse(Console.ReadLine());

//Console.WriteLine("Nombre del alumno: ");
//string nombre=Console.ReadLine();

//Console.WriteLine("Apellido del alumno: ");

//string apellido=Console.ReadLine();

//Console.WriteLine("Ingrese el curso al cual el alumno se va a inscribir :");
//int curso = Int32.Parse(Console.ReadLine());

Alumno alumnoIngreso= new Alumno(2, "agustina", "arroyo", 44523, 1);

Alumno copia = new Alumno(1, "nico", "leal", 1214412, 1);

Alumno copiaDos = new Alumno(3, "jose", "rodriguez", 42534132, 1);


HelperArchivos.crearArchivos();
//HelperArchivos.escribirArchivos();
HelperArchivos.escribirAtletismo();
/*
 3) Contexto
Un Instituto de Educación Física dicta 3 cursos distintos: “Atletismo”, “Voley” y “Futbol”. Cada
profesor, de cada curso, quiere tener un listado en un archivo .csv de los alumnos inscriptos en
su curso.
Tarea
Deberá desarrollar un sistema que lleve el listado de todos los alumnos inscriptos por curso, esta
información quedará registrada en un archivo csv.
De esta forma cada curso contará con 1 archivo independiente, los nombres de los archivos de
salida serán:
Atletismo.csv
Voley.csv
Futbol.csv
Crear una clase estática HelperDeArchivos , en la cual se van a cargar 2 métodos, uno para
escribir contenido en el archivo y otro para limpiar el contenido actual del archivo.
De los alumnos son importantes los siguientes datos:
Apellido, Nombre, Dni, Id, Curso.
class Alumno
{
private int Id { get; set; }
private string Nombre { get; set; }
private string Apellido { get; set; }
private int Dni { get; set; }
public int Curso { get; set; }
}
i) Cree una interfaz para ingresar los datos del alumno y el deporte al cual se inscribirán.
ii) Incorpore todos los ciclos try-catch y logs necesarios para contemplar todos los posibles
errores que podrían suceder al ejecutar el sistema.
iii) Incorpore también todos los logs que considere que podrían ser informativos para el
desarrollador. Construya el archivos de configuración de NLog acorde a las siguientes reglas:
● Los mensajes de información se escriban en un archivo infoLog.log
● Los mensajes de tipo debug se muestren por consola.
● Todos los demás tipos de logs se escriben en el archivo appLog.log.
 */
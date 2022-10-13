using NLog; //uso la libreria de NLog
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Logger control = LogManager.GetCurrentClassLogger();
control.Info("Jose");
/*
 3) Implementar la solución del siguiente programa usando Try Catch para capturar los posibles
errores.
Escribir la declaración de una clase que almacene información de un empleado: Datos
personales, Dirección, fecha de ingreso la empresa, datos profesionales.
a) La clase empleado deberá calcular la antigüedad en la empresa, la edad del
empleado y el salario. Este se calcula de acuerdo a la fórmula: Salario = Sueldo
Básico + Adicional – Descuento
Descuento = 15 % del Sueldo Básico.
Adicional = 1 % del sueldo básico por cada año de antigüedad.
1 año__________________________ 1%
Página 1
Taller de Lenguajes II – 2022
Programador Universitario / Licenciatura en informática / Ingeniería en Informática
Trabajo Práctico N° 1
2 años_________________________ 2%
15 años_________________________ 1 5%
> 20 años________________________ 25% (a partir de 20 años se fija en 25%)
b) Modifica luego la clase de tal manera que puedas suministrar la información:
i) Si es casado, la cantidad de hijos.
ii) Si es divorciado, la fecha de su divorcio.
iii) Si tiene título universitario, el título y la universidad que impartió el título.
c) Permite el ingreso de N trabajadores
d) Muestra en una lista los datos: Apellido y Nombre, Edad, Antigüedad y Salario de los
trabajadores ingresados
 */
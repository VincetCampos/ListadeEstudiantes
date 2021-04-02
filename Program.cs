using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Estudiante[] ListadoEstudiantes = new Estudiante [5];
            Cursos [] Calificaciones = new Cursos[5];

            while(cont < 5){
                Console.WriteLine("Ingrese el nombre del estudiante");
                string Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad del estudiante");
                int Edad = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el carnet del estudiante");
                string Carnet = Console.ReadLine();

                Console.WriteLine("El estudiante esta sovente?");
                bool Solvencia = Boolean.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del curso");
                string NombreCurso = Console.ReadLine();

                Console.WriteLine("Ingrese la calificacion del primer parcial");
                int PrimerParcial = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la calificacion del segundo parcial");
                int SegundoParcial = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la calificacion del examen final");
                int ExamenFinal = Int16.Parse(Console.ReadLine());

                Estudiante estudiante = new Estudiante(Nombre, Edad, Carnet, Solvencia);
                ListadoEstudiantes[cont] = estudiante;

                Cursos cursos = new Cursos(NombreCurso, PrimerParcial, SegundoParcial, ExamenFinal);
                Calificaciones[cont] = cursos;

                cont++;
            }

            Console.WriteLine("----------LISTADO----------");
            for(int i = 0; i < 5; i++){
                Estudiante estudiante = ListadoEstudiantes[i];
                Console.WriteLine("Nombre del estudiante " + estudiante.Nombre + " Edad " + estudiante.Edad + " Carnet " + estudiante.Carnet + " Solvencia " + estudiante.Solvencia);

                Cursos cursos = Calificaciones[i];
                Console.WriteLine("La calificacion del alumno " + estudiante.Nombre + " en el curso de: " + cursos.NombreCurso + " en el primer parcial es: " + cursos.PrimerParcial + " en el segundo parcial es: " + cursos.SegundoParcial + " y en el examen final es: " + cursos.ExamenFinal);

                 Console.WriteLine("");
            }
        }
    }
}

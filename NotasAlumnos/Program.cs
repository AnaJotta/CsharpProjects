/* Esta aplicación de consola de C# está diseñada para:
- Usar **matrices (arrays)** para almacenar los nombres de los alumnos y las puntuaciones de las tareas.
- Usar una instrucción **`foreach`** para iterar a través de los nombres de los alumnos como un bucle de programa externo.
- Usar una instrucción **`if`** dentro del bucle externo para identificar el nombre del alumno actual y acceder a las puntuaciones de sus tareas.
- Usar una instrucción **`foreach`** dentro del bucle externo para iterar a través de la matriz de puntuaciones de tareas y sumar los valores.
- Usar un algoritmo dentro del bucle externo para **calcular la puntuación promedio de los exámenes** de cada alumno.
- Usar una estructura **`if-elseif-else`** dentro del bucle externo para evaluar la puntuación promedio del examen y **asignar automáticamente una calificación con letra**.
- Integrar las puntuaciones de **créditos extra** al calcular la puntuación final y la calificación con letra del alumno, de la siguiente manera:
    - detecta las tareas de crédito extra basándose en el número de elementos en la matriz de puntuaciones del alumno.
    - divide los valores de las tareas de crédito extra por **10** antes de sumarlas a la suma de las puntuaciones de los exámenes.
- usar el siguiente formato de informe para reportar las calificaciones de los alumnos: 

Estudiante       Puntuación Examen   Calificación General   Crédito Extra

Sophia             92.2                 95.88   A         92 (3.68 pts)

*/
int tareasExamen = 5;

string[] nombreEstudiante = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaNotas = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewNotas = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaNotas = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganNotas = new int[] { 90, 95, 87, 88, 96, 96 };

int[] notaEstudiante = new int[10];

string calificacionConLetra = "";

// imprimir (o mostrar) el encabezado de la tabla de puntuaciones y calificaciones
Console.Clear();
Console.WriteLine("Estudiante\tNotas Examen\tCalificación General\tCredito Extra\n");

/*
El bucle foreach externo se usa para:
- iterar a través de los nombres de los alumnos 
- asignar las calificaciones de un alumno a la matriz studentScores
- calcular las sumas de exámenes y créditos extra (bucle foreach interno)
- calcular la calificación numérica y la calificación con letra
- escribir la información del informe de calificaciones
*/
foreach (string nombre in nombreEstudiante)
{
    string estudianteActual = nombre;

    if (estudianteActual == "Sophia")
        notaEstudiante = sophiaNotas;

    else if (estudianteActual == "Andrew")
        notaEstudiante = andrewNotas;

    else if (estudianteActual == "Emma")
        notaEstudiante = emmaNotas;

    else if (estudianteActual == "Logan")
        notaEstudiante= loganNotas;

    int calificacionAsignada = 0;
    int calificacionesCreditoExtra = 0;

    int sumNotasExamen = 0;
    int sumPuntuacionExtraCreditos = 0;

    decimal notaEstudianteActual = 0;
    decimal puntuacionExamenEstuActual = 0;
    decimal puntuacionCreditoExtraEstuActual = 0;


/* El bucle foreach interno: 
- suma las puntuaciones de exámenes y créditos extra
- cuenta las tareas de créditos extra
*/

    foreach (int nota in notaEstudiante)
    {
        calificacionAsignada += 1;

        if (calificacionAsignada <= tareasExamen)
        {
            sumNotasExamen = sumNotasExamen + nota;
        }

        else
        {
            calificacionesCreditoExtra += 1;
            sumPuntuacionExtraCreditos += nota;
        }
    }

    puntuacionExamenEstuActual = (decimal)(sumNotasExamen) / tareasExamen;
    puntuacionCreditoExtraEstuActual = (decimal)(sumPuntuacionExtraCreditos) / calificacionesCreditoExtra;

    notaEstudianteActual = (decimal)((decimal)sumNotasExamen + ((decimal)sumPuntuacionExtraCreditos / 10)) / tareasExamen;

    if (notaEstudianteActual >= 97)
        calificacionConLetra = "A+";

    else if (notaEstudianteActual >= 93)
        calificacionConLetra = "A";

    else if (notaEstudianteActual >= 90)
        calificacionConLetra = "A-";

    else if (notaEstudianteActual >= 87)
        calificacionConLetra = "B+";

    else if (notaEstudianteActual >= 83)
        calificacionConLetra = "B";

    else if (notaEstudianteActual >= 80)
        calificacionConLetra = "B-";

    else if (notaEstudianteActual >= 77)
        calificacionConLetra = "C+";

    else if (notaEstudianteActual >= 73)
        calificacionConLetra = "C";

    else if (notaEstudianteActual >= 70)
        calificacionConLetra = "C-";

    else if (notaEstudianteActual >= 67)
        calificacionConLetra = "D+";

    else if (notaEstudianteActual >= 63)
        calificacionConLetra = "D";

    else if (notaEstudianteActual >= 60)
        calificacionConLetra = "D-";

    else
        calificacionConLetra = "F";


    Console.WriteLine($"{estudianteActual}\t\t{puntuacionExamenEstuActual}\t\t{notaEstudianteActual}\t{calificacionConLetra}\t\t{puntuacionCreditoExtraEstuActual} ({(((decimal)sumPuntuacionExtraCreditos / 10) / tareasExamen)} pts)");
}

Console.WriteLine("\n\rPresiona Enter para continuar");
Console.ReadLine();
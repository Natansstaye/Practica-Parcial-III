using System.Security.Cryptography.X509Certificates;
using XD.Modelo;

internal class Program
{
    private static void Main(string[] args)
    {
        string Materia;
        string Numero_Grupo;
        string Condición = "";
        Dictionary<string, Dictionary<string, List<Alumno>>> Matricula;
        Matricula = new Dictionary<string, Dictionary<string, List<Alumno>>>();
        do
        {
            Dictionary<string, List<Alumno>> Diccionario_Grupos;
            Diccionario_Grupos = new Dictionary<string, List<Alumno>>();
            Console.Write("Ingrese el nombre de la materia :");
            Materia = Console.ReadLine();
            do
            {
                List<Alumno> Lista_Alumnos = new List<Alumno>();
                Console.WriteLine($"Ingrese el numero de grupo para materia {Materia}");
                Numero_Grupo = Console.ReadLine();
                do
                {
                    Alumno Alumno_Item = new Alumno();
                    Alumno_Item.Guardar_Datos();
                    Lista_Alumnos.Add(Alumno_Item);
                } while (Validar_Condición("Alumno"));

                Diccionario_Grupos.Add(Numero_Grupo, Lista_Alumnos);

            } while (Validar_Condición("Grupo"));

            Matricula.Add(Materia, Diccionario_Grupos);
        } while (Validar_Condición("Materia"));

        foreach (var Item_Matricula in Matricula)
        {
            Console.WriteLine($"Materia -> {Item_Matricula.Key}");
            foreach (var Item_Grupos in Item_Matricula.Value)
            {
                Console.WriteLine($"Grupo -> {Item_Grupos.Key}");
                foreach (var Item_Alumnos in Item_Grupos.Value)
                {
                    Item_Alumnos.Mostrar_Datos();
                }
            }
        }
    }

    public static bool Validar_Condición(string Mensaje)
    {
        string Condición = "";
        Console.WriteLine($"Si desea ingresar otro {Mensaje}, presione s para si\ncualquier letra para no");
        Condición = Console.ReadLine();
        if (Condición.Equals("s", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
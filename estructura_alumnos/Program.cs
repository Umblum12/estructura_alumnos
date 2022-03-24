Alumno alu = new Alumno();
alu.Nombre = "Abelardo Cruz Leos";
alu.Matricula = 641913;
alu.Grupo = "B";
alu.Carrera = "TSU";
Console.WriteLine("El estudiante es: {0} y su matricula es: {1} ", alu.Nombre, alu.Matricula);
Console.ReadKey(true);
struct Alumno
{
    public string Nombre;
    public int Matricula;
    public string Grupo;
    public string Carrera;
}
// Perro.cs  –  Clase hija (hereda de Animal)

class Perro : Animal          // <-- los dos puntos significan "hereda de"
{
    // Atributo propio de Perro
    public string Raza;

    // Constructor  (llama al constructor del padre con "base")
    public Perro(string nombre, int edad, string raza)
        : base(nombre, edad)  // <-- pasa datos al constructor de Animal
    {
        Raza = raza;
    }

    // Sobreescribe el método del padre
    public new void HacerSonido()
    {
        Console.WriteLine(Nombre + " dice: ¡Guau!");
    }

    // Método propio de Perro
    public void Buscar()
    {
        Console.WriteLine(Nombre + " está buscando algo...");
    }
}

// ─────────────────────────────────────────
//  Program  –  Punto de entrada, aquí pruebas todo
// ─────────────────────────────────────────
class Program
{
    static void Main()
    {
        // Crear un Animal
        //Animal miAnimal = new Animal("León", 5);
        //miAnimal.MostrarInfo();       // Nombre: León, Edad: 5
        //miAnimal.HacerSonido();       // León hace un sonido.

        Console.WriteLine();          // línea en blanco

        // Crear un Perro
        Perro miPerro = new Perro("Rex", 3, "Labrador");
        miPerro.MostrarInfo();        // hereda MostrarInfo de Animal
        miPerro.HacerSonido();        // Rex dice: ¡Guau!
        miPerro.Buscar();             // Rex está buscando algo...

        Console.WriteLine("Raza: " + miPerro.Raza);
    }
}

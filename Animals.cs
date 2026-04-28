// Animal.cs  –  Clase base (clase padre)

class Animal
{
    // Atributos (propiedades)
    public string Nombre;
    public int Edad;

    // Constructor
    public Animal(string nombre, int edad)
    {
        Nombre = nombre;
        Edad   = edad;
    }

    // Método
    public void HacerSonido()
    {
        Console.WriteLine(Nombre + " hace un sonido.");
    }

    // Método para mostrar info
    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + Nombre + ", Edad: " + Edad);
    }
}

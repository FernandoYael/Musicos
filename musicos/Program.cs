class Musico
{
    public string Nombre {get; set;}
    public Musico(string nombre)
    {
        Nombre=nombre;
    }
    public void Saludar()
    {
        Console.WriteLine("Hola");
    }
    public virtual void Tocar()
    {
        Console.WriteLine($"{Nombre} esta tocando su Instrumento");
    }
}

class Baterista
{
    //Bateria
}

class Bajista
{
    //Bajista
}

//class Guitarrista
//{
    //Guitarra
//}

//class Vocalista
//{
    //Microfono
//}



internal class Program
{
    private static void Main(string[] args)
    {
        Musico L = new Musico("L");
        L.Saludar();
        L.Tocar();
    }
}
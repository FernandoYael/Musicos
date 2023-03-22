class Musico
{
    public string Nombre {get; set;}
    public Musico(string nombre)
    {
        Nombre=nombre;
    }
    public void Saludar()
    {
        Console.WriteLine($"Hola soy {Nombre}");
    }
    public virtual void Tocar()
    {
        Console.WriteLine($"{Nombre} esta tocando su Instrumento");
    }
}

class Baterista:Musico
{
    public string Bajo{get;set;}
    public Baterista(string n, string b):base(n)
    {
        this.Bajo=b;
    }
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} toca su {Bajo}");
    }
}

class Bajista:Musico
{
    public string Bajo{get;set;}
    public Bajista(string n, string b):base(n)
    {
        this.Bajo=b;
    }
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} toca su {Bajo}");
    }
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

        Bajista A = new Bajista("A", "Musicaman");
        A.Saludar();
        A.Tocar();

        Baterista B = new Baterista("B", "Tama");
        B.Saludar();
        B.Tocar();
    }
}
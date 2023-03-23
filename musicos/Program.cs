abstract class Musico
{
    public string Nombre {get; set;}
    public Musico(string nombre)
    {
        Nombre=nombre;
    }
    public virtual void Saludar()
    {
        Console.WriteLine($"Hola soy {Nombre}");
    }
    public abstract void Tocar();
}

class Baterista:Musico
{
    public string Bateria{get;set;}
    public Baterista(string n, string bt):base(n)
    {
        this.Bateria=bt;
    }
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} toca su {Bateria}");
    }
    public override void Saludar()
    {
        Console.WriteLine($"Hola soy {Nombre} y soy baterista");
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

class Guitarrista:Musico
{
    public string Guitarra{get;set;}
    public Guitarrista(string n, string g):base(n)
    {
        this.Guitarra=g;
    }
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} toca su {Guitarra}");
    }
}

class Vocalista: Musico
{
    public string Microfono{get;set;}
    public Vocalista(string n, string m):base(n)
    {
        this.Microfono=m;
    }
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} canta en su {Microfono}");
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        List<Musico> grupo = new List<Musico>();
        grupo.Add(new Vocalista("A","Mix"));
        grupo.Add(new Guitarrista("B","Mix"));
        grupo.Add(new Bajista("π","Mix"));        
        grupo.Add(new Baterista("2π","Mix"));
        foreach (var m in grupo) m.Saludar();
        foreach (var m in grupo) m.Tocar();

        //Musico L = new Musico("L");
        //L.Saludar();
        //L.Tocar();

        //Bajista A = new Bajista("A", "Musicaman");
        //A.Saludar();
        //A.Tocar();

        //Baterista B = new Baterista("B", "Tama");
        //B.Saludar();
        //B.Tocar();
    }
}
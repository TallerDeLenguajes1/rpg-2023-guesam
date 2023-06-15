namespace clases;

public class personaje {
    private string? tipo;
    private string? nombre;
    private string? apellido;
    private DateTime fechaNacimiento;
    private int edad;
    private int velocidad; // 1 al 10
    private int destreza; // 1 al 5
    private int fuerza; // 1 al 10
    private int nivel; // 1 al 10
    private int armadura; // 1 al 10
    private int salud; //100

    public string? Tipo { get => tipo; set => tipo = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apodo { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Armadura { get => armadura; set => armadura = value; }
    public int Salud { get => salud; set => salud = value; }
    public int Nivel { get => nivel; set => nivel = value; }
}


public class FabricaDePersonajes{
    private string[] tipo = {"Humano", "Brujo", "Ogro", "Troll"};
    private string[] nombre = {"Eva", "Adan", "Cain", "Abel", "Moises", "Lilith"};
    private string[] apodo = {"Humano1", "Brujo2", "Ogro3", "Troll4"};

    public personaje crear(){
        personaje crearPersonaje = new personaje();
        crearPersonaje.Tipo = tipo[numero(0,4)];
        crearPersonaje.Nombre = nombre[numero(0, 6)];
        crearPersonaje.Apodo = apodo[numero(0,4)];
        crearPersonaje.FechaNacimiento = new DateTime(numero(1723, 2024)/numero(0, 31)/numero(0, 12));
        crearPersonaje.Edad = 2023 - crearPersonaje.FechaNacimiento.Year;
        crearPersonaje.Velocidad = numero(1, 11);
        crearPersonaje.Destreza = numero(1, 6);
        crearPersonaje.Fuerza = numero(1, 11);
        crearPersonaje.Nivel = numero(1, 11);
        crearPersonaje.Armadura = numero(1, 11);
        crearPersonaje.Salud = 100;
        return crearPersonaje;
    }

    private int numero(int min, int max){
        Random random = new Random();
        int num;
        num = random.Next(min, max);
        return num;
    }
}

public class archivosJson{
    public void guardarPersonaje(List<personaje> lista, string nombre){
        
    }
}
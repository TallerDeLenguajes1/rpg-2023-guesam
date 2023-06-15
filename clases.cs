namespace clases;

public class personaje {
    private string? tipo;
    private string? nombre;
    private string? apellido;
    private int edad;
    private int destreza;
    private int fuerza;
    private int velocidad;
    private int armadura;

    public string? Tipo { get => tipo; set => tipo = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public int Edad { get => edad; set => edad = value; }
}
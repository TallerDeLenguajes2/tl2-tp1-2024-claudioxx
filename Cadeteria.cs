class Cadeteria
{
    string nombre;
    long telefono;
    public List<Cadete> cadetes;

    public Cadeteria(string nombre, long telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.cadetes = new List<Cadete>();
    }

    public void mostrarCadeteria(){
        Console.Write("Nombre: "+nombre+"\nTelefono: "+telefono);
    }
}
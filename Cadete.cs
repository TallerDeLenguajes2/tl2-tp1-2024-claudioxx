class Cadete
{
    public int id;
    public string nombre;
    string direccion;
    long telefono;

    public Cadete(int id, string nombre, string direccion, long telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }

    public void mostrarCadete(){
        Console.Write("Nro cadete: "+id+"\nNombre del cadete: "+nombre+"\n");
    }
}
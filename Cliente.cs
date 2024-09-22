class Cliente
{
    string nombre;
    string direccion;
    long telefono;
    string datosReferenciaDireccion;

    public Cliente(string nombre, string direccion, long telefono, string datosReferenciaDireccion)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.datosReferenciaDireccion = datosReferenciaDireccion;
    }

    public void mostrarCliente(){
        Console.Write("DATOS DEL CLIENTE:\n\nNombre: " +this.nombre+ "\nDireccion: "+this.direccion+"\nTelefono: "+this.telefono+"\nDatos de direccion: "+this.datosReferenciaDireccion+"\n\n");
    }
}
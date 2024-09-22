class Cadete
{
    public int id;
    public string nombre;
    string direccion;
    long telefono;
    public List<Pedido> pedidos = new List<Pedido>();

    public Cadete(int id, string nombre, string direccion, long telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }

    public int jornalACobrar(){
        int jornal = this.pedidos.Where(unPedido => unPedido.estadoPedido == Estado.Entregado).Count() * 500;
        return jornal;
    }

    public void mostrarCadete(){
        Console.Write("Nro cadete: "+id+"\nNombre del cadete: "+nombre+"\n");
        Console.Write("Pedidos del cadete: ");
        if(this.pedidos.Count == 0)
            Console.Write("No tiene pedidos.\n\n");
        else
            foreach (Pedido unPedido in pedidos)
            {
                unPedido.mostrarPedido();
            }
    }
}
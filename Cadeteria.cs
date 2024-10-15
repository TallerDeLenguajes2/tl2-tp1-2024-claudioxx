class Cadeteria
{
    string nombre;
    long telefono;
    public List<Cadete> cadetes;
    public List<Pedido> pedidos;

    public Cadeteria(string nombre, long telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.cadetes = new List<Cadete>();
        this.pedidos = new List<Pedido>();
    }

    public void mostrarCadeteria(){
        Console.Write("Nombre: "+nombre+"\nTelefono: "+telefono);
    }

    public int jornalACobrar(int idCadete){
        int jornal = 0;
        Cadete unCadete = this.cadetes.First(unCadete => unCadete.id == idCadete);
        foreach (Pedido unPedido in pedidos)
        {
            if (unPedido.cadete.id == idCadete){
                if (unPedido.estadoPedido == Estado.Entregado)
                    jornal += 500;
            }
        }
        return jornal;
    }

    public void asignarCadeteAPedido(int idCadete, int idPedido){
        Pedido unPedido = this.pedidos.Find(unPedido => unPedido.id == idPedido);
        Cadete unCadete = this.cadetes.Find(unCadete => unCadete.id == idCadete);
        if(unPedido == null || unCadete == null)
            Console.WriteLine("Pedido o Cadete mal seleccionado.");
        else
            unPedido.cadete = unCadete;
    }

    public void mostrarPedidos(){
        foreach (Pedido unPedido in this.pedidos)
                {
                    unPedido.mostrarPedido();
                };
    }

    public void mostrarCadetes(){
        foreach (Cadete unCadete in this.cadetes)
                {
                    unCadete.mostrarCadete();
                };
    }

    public int cantidadPedidos(int idCadete){
        return (pedidos.Where(unPedido => unPedido.cadete.id == idCadete).Count());
    }
}
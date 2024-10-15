enum Estado
{
    Entregado = 1,
    Pendiente = -1
}
class Pedido
{   
    static public int nroAi = 0;
    public int id;
    string observacion;
    private Cliente cliente;
    public Cadete cadete = null;
    public Estado estadoPedido;

    public Pedido(string obs, string nombreCliente, string direccionCliente, long telefonoCliente, string datosReferenciaDireccionCliente)
    {
        id = ++nroAi;
        observacion = obs;
        estadoPedido = Estado.Pendiente;
        cliente = new Cliente(nombreCliente,direccionCliente,telefonoCliente,datosReferenciaDireccionCliente);
    }

    public void mostrarPedido(){
        this.cliente.mostrarCliente();
        Console.Write("DATOS DEL PEDIDO:\n\nNro de Pedido: "+id+"\nobservacion: " +observacion+ "\nEstado: " +estadoPedido+"\n\n");
    }

    public void cambiarEstadoPedido(){
        if (estadoPedido == Estado.Pendiente)
            estadoPedido = Estado.Entregado;
        else
            estadoPedido = Estado.Pendiente;
    }
}
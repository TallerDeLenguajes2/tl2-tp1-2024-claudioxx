static class Helper
{

    public static Cadeteria cargarDatos(){
        List<Cadete> cadetes = new List<Cadete>();
        StreamReader archivo = new StreamReader ("Cadetes.csv");
        string linea;
        string[] datos;
        while((linea = archivo.ReadLine()) != null){
            datos = linea.Split(";");
            Cadete nuevoCadete = new Cadete(Int32.Parse(datos[0]),datos[1],datos[2],Int64.Parse(datos[3]));
            cadetes.Add(nuevoCadete);
        };
        archivo = new StreamReader ("Cadeterias.csv");
        linea = archivo.ReadLine();
            datos = linea.Split(";");
            Cadeteria nuevaCadeteria = new Cadeteria(datos[0],Int64.Parse(datos[1]));
            nuevaCadeteria.cadetes = cadetes;
        return nuevaCadeteria;
    }
    public static List<Pedido> pedidos = new List<Pedido>();
    public static void altaPedido(){
        Console.WriteLine("Ingresar datos del cliente\n");
        Console.WriteLine("Nombre: ");
        string nombreCliente = Console.ReadLine();
        Console.WriteLine("Direccion: ");
        string direcCliente = Console.ReadLine();
        Console.WriteLine("Telefono: ");
        long telefonoCliente = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Datos de direccion: ");
        string datosDirecCliente = Console.ReadLine();

        Console.WriteLine("\nIngresar datos del Pedido\n");
        Console.WriteLine("observacion del pedido: ");
        string obsPedido = Console.ReadLine();
        
        Pedido unPedido = new Pedido(obsPedido,nombreCliente,direcCliente,telefonoCliente,datosDirecCliente);
        pedidos.Add(unPedido);
    }

    static public void mostrarPedidos(){
        foreach (Pedido unPedido in Helper.pedidos)
                {
                    unPedido.mostrarPedido();
                };
    }

    static public void mostrarCadetes(Cadeteria unaCadeteria){
        foreach (Cadete unCadete in unaCadeteria.cadetes)
                {
                    unCadete.mostrarCadete();
                };
    }

    static public void asignarPedidoACadete(Cadeteria unaCadeteria){
        mostrarPedidos();
        Console.Write("SELECCIONE EL PEDIDO A ASIGNAR: ");
        int numPedido = Convert.ToInt32(Console.ReadLine());
        mostrarCadetes(unaCadeteria);
        Console.Write("SELECCIONE EL CADETE: ");
        int numCadete = Convert.ToInt32(Console.ReadLine());
        Cadete cadeteAsignar = unaCadeteria.cadetes.Find(unCadete => unCadete.id == numCadete);
        Pedido pedidoAsignar = pedidos.Find(unPedido => unPedido.nro == numPedido);
        if (cadeteAsignar != null && pedidoAsignar != null)
            cadeteAsignar.pedidos.Add(pedidoAsignar);
    }

    static public void reasignarPedidoACadete(Cadeteria unaCadeteria){
        mostrarPedidos();
        Console.Write("SELECCIONE EL PEDIDO A ASIGNAR: ");
        int numPedido = Convert.ToInt32(Console.ReadLine());
        Pedido pedidoAsignar = pedidos.Find(unPedido => unPedido.nro == numPedido);
        if (pedidoAsignar != null)
            foreach (Cadete unCadete in unaCadeteria.cadetes)
            {
                if(unCadete.pedidos.Contains(pedidoAsignar)){
                    Console.Write("El pedido pertenece a: "+unCadete.nombre+"\n\n");
                    unCadete.pedidos.Remove(pedidoAsignar);
                }
                    
            }
        mostrarCadetes(unaCadeteria);
        Console.Write("SELECCIONE EL CADETE: ");
        int numCadete = Convert.ToInt32(Console.ReadLine());
        Cadete cadeteAsignar = unaCadeteria.cadetes.Find(unCadete => unCadete.id == numCadete);
        
        if (cadeteAsignar != null)
            cadeteAsignar.pedidos.Add(pedidoAsignar);
    }

    static public void cambiarEstado(){
        mostrarPedidos();
        Console.Write("SELECCIONE EL PEDIDO: ");
        int numPedido = Convert.ToInt32(Console.ReadLine());
        Pedido pedidoAsignar = pedidos.Find(unPedido => unPedido.nro == numPedido);
        if (pedidoAsignar != null)
            pedidoAsignar.cambiarEstadoPedido();
    }


    static public void finalizarDia(Cadeteria unaCadeteria){
        foreach (Cadete unCadete in unaCadeteria.cadetes)
        {
            Console.Write("Cadete: "+unCadete.nombre+"\nJornal ganado: " +unCadete.jornalACobrar()+"\nCantidad total de pedidos: "+unCadete.pedidos.Count()+"\n");
        }
        
    }

}
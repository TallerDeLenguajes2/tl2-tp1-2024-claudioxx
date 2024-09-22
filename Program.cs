// See https://aka.ms/new-console-template for more information


using System.ComponentModel;


Cadeteria unaCadeteria = Helper.cargarDatos();
menu();


void menu(){
    bool ejecutando = true;
        Console.WriteLine("CADETERIA\n");
    while(ejecutando){
        Console.WriteLine("1: Dar de alta un pedido");
        Console.WriteLine("2: Asignar pedido a cadete");
        Console.WriteLine("3: Cambiar estado de pedido");
        Console.WriteLine("4: Reasignar pedido a otro cadete");
        Console.WriteLine("5: Mostrar Cadetes");
        Console.WriteLine("6: Mostrar pedidos");
        Console.WriteLine("7: Finalizar dia");
        Console.WriteLine("8: Salir");
        Console.Write("\nSeleccione una opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion){
        case 1: Helper.altaPedido();                
                break;
        case 2: Helper.asignarPedidoACadete(unaCadeteria);
                break;
        case 3: Helper.cambiarEstado();
                break;
        case 4: Helper.reasignarPedidoACadete(unaCadeteria);
                break;
        case 5: Helper.mostrarCadetes(unaCadeteria);
                break;
        case 6: Helper.mostrarPedidos();
                break;
        case 7: Helper.finalizarDia(unaCadeteria);
                break;        
        case 8: ejecutando = false;
                break;
        default: Console.WriteLine("Opcion incorrecta;\n");
                break;
    }
    }
}
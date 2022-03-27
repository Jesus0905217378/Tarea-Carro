using Tarea_Carro.Clases;


Carro JesusCarrito = new Carro("Nissan", 2022, "Azul");



Console.WriteLine($"La Marca del Carro es {JesusCarrito.Marca}");
Console.WriteLine($"El Modelo del Carro es {JesusCarrito.Modelo}");
Console.WriteLine($"El Color del Carro es {JesusCarrito.Color}");


Console.WriteLine(JesusCarrito.GetVelocidadActual());
JesusCarrito.EncenderMotor();

for (int i = 0; i < 8; i++)
{
    JesusCarrito.acelerar();
}

JesusCarrito.acelerar(3);
JesusCarrito.acelerar(6);
JesusCarrito.acelerar(1);

/* //////////////////////////  Desacelerar  ///////////////////////*/

for (int i = 0; i < 5; i++)
{
    JesusCarrito.desacelerar();
}

/*  ////////////////////////////  Frenar   /////////////////////////*/
for (int i = 0; i < 6; i++)
{
    JesusCarrito.frenar();
}

/*  ////////////////////////////  Apagar motor   /////////////////////////*/
JesusCarrito.ApagarMotor();

/*  ////////////////////////////  Bocinar   /////////////////////////*/
JesusCarrito.bocinar();


string usuario = "admin";

Console.WriteLine("Informe qual seu cargo: ");
usuario = Console.ReadLine();

if (usuario == "admin" || usuario == "supervisor")
{
    Console.WriteLine("Acesso concedido");
}
else
{
    Console.WriteLine(":(");
}

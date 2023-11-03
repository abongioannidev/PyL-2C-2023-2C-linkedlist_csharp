namespace linkedlist_csharp;
class Program
{
    static void Main(string[] args)
    {
        Linkedlinst<string> lista = new Linkedlinst<string>();

        lista.AddElement("Hola Mundo");
        lista.AddElement("Buenos dias");


        Console.WriteLine($"Obtengo el primer elemento  => {lista.GetElementByIndex(0)}");
        Console.WriteLine($"Obtengo el segundo elemento  => {lista.GetElementByIndex(1)}");
        Console.WriteLine($"Cantidad de elementos en la lista {lista.CountElements}");
        Console.WriteLine($"Indice de Buenas Dias {lista.IndexOf(x => x == "Buenos dias")}");

    }
}

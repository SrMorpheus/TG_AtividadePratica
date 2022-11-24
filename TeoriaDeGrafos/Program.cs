using TeoriaDeGrafos.GrafoPasta.Core;
using TeoriaDeGrafos.GrafoPasta.Search;


/*
    Grafo grafo = new Grafo();


    List<string> rotas  = new List<string> {"RJ", "SP", "BH", "PT", "OS", "SV", "CR","PA"};

    foreach (var item in rotas)
    {

        grafo.AdicionarVertices(item);

    }


    Console.WriteLine("O grafo G possui os seguintes Vértices:");

    foreach (var grafos in grafo.GetVertices())
    {


        Console.WriteLine("- Vértice " +  grafos.GetRotulo());

    }

Console.WriteLine("A ordem do Grafo G é " + grafo.OrdemGrafo());



    Grafo grafo2 = new Grafo();

    List<string> rotasTestes = new List<string> { "1", "2", "3", "4", "5", "u", "v"};

    foreach(var item in rotasTestes)
    {

        grafo2.AdicionarVertices(item);

    }

    grafo2.ConectarVertice("u", "1");
    grafo2.ConectarVertice("1", "4");
    grafo2.ConectarVertice("4", "3");
    grafo2.ConectarVertice("4", "5");
    grafo2.ConectarVertice("3", "2");
    grafo2.ConectarVertice("3", "5");
    grafo2.ConectarVertice("5", "v");

//teste



/*
    Console.WriteLine("Grau do Vértice A: " + grafo2.GetVertice("A").GetGrau());
    Console.WriteLine("Grau do Vértice D: " + grafo2.GetVertice("D").GetGrau());
    Console.WriteLine("Grau do Vértice C: " + grafo2.GetVertice("C").GetGrau());

    Console.WriteLine();

    Console.WriteLine("O vértice A possui as seguintes Adjacências:");

    var adjcacentes = grafo2.GetAdjacencias("A");
    
    foreach(var vertice in adjcacentes)
    {

        Console.WriteLine(vertice.GetRotulo() + " ");

    }

Console.WriteLine();

Console.WriteLine("O vértice C possui as seguintes Adjacências:");


var adjcacentes2 = grafo2.GetAdjacencias("C");

foreach (var vertice in adjcacentes2)
{

    Console.WriteLine(vertice.GetRotulo() + " ");

}



    GrafoClass grafo2 = new GrafoClass();

    List<string> rotasTestes = new List<string> { "1", "2", "3", "4", "5", "u", "v" };

    foreach (var item in rotasTestes)
    {

        grafo2.AdicionarVertices(item);

    }

    grafo2.ConectarVertice("u", "1");
    grafo2.ConectarVertice("1", "4");
    grafo2.ConectarVertice("4", "3");
    grafo2.ConectarVertice("4", "5");
    grafo2.ConectarVertice("3", "2");
    grafo2.ConectarVertice("3", "5");
    grafo2.ConectarVertice("5", "v");


    Vertice vertice1 = new Vertice("1");
    Vertice vertice2 = new Vertice("2");
    Vertice vertice3 = new Vertice("3");
    Vertice vertice4 = new Vertice("4");
    Vertice vertice5 = new Vertice("5");
    Vertice verticeU = new Vertice("u");
    Vertice verticeV = new Vertice("v");


    List<Vertice> sequencia1 = new List<Vertice> { verticeU, vertice1, vertice4, vertice5, verticeV };

    List<Vertice> sequencia2 = new List<Vertice> { verticeU, vertice1, vertice4, vertice3, vertice5, vertice4, vertice3, vertice5, verticeV };

    List<Vertice> sequencia3 = new List<Vertice> { vertice1, vertice3, vertice5, vertice4, verticeU, verticeV, vertice1, vertice3 };


    Console.WriteLine( grafo2.GRAPHcheckPath(sequencia1));
    Console.WriteLine(grafo2.GRAPHcheckPath(sequencia2));
    Console.WriteLine(grafo2.GRAPHcheckPath(sequencia3));





*/

GrafoClass grafo1 = new GrafoClass(12);


grafo1.AdicionarVertices("A");
grafo1.AdicionarVertices("B");
grafo1.AdicionarVertices("C");
grafo1.AdicionarVertices("D");
grafo1.AdicionarVertices("E");
grafo1.AdicionarVertices("F");
grafo1.AdicionarVertices("G");
grafo1.AdicionarVertices("H");
grafo1.AdicionarVertices("I");
grafo1.AdicionarVertices("J");
grafo1.AdicionarVertices("K");

grafo1.ConectarVertice("A", "B");
grafo1.ConectarVertice("A", "C");
grafo1.ConectarVertice("B", "D");
grafo1.ConectarVertice("B", "E");
grafo1.ConectarVertice("D", "H");
grafo1.ConectarVertice("D", "I");
grafo1.ConectarVertice("C", "F");
grafo1.ConectarVertice("C", "G");
grafo1.ConectarVertice("F", "J");
grafo1.ConectarVertice("F", "K");


Console.WriteLine("Exemplo 1:");
List<String> caminho = BuscaEmProfundidade.GetInstance().Buscar(grafo1);

Console.WriteLine("Caminho feito por uma busca em profundidade: ");
foreach (String passo in caminho)
{
    Console.WriteLine(passo + " ");
}

Console.WriteLine("\n");

caminho = BuscaEmLargura.GetInstance().Buscar(grafo1);
Console.WriteLine("Caminho feito por uma busca em largura: ");
foreach (String passo in caminho)
{
    Console.WriteLine(passo + " ");
}

Console.WriteLine();

Console.WriteLine("\nExemplo 2");
GrafoClass grafo2 = new GrafoClass();

grafo2.AdicionarVertices("A");
grafo2.AdicionarVertices("B");
grafo2.AdicionarVertices("C");
grafo2.AdicionarVertices("D");
grafo2.AdicionarVertices("E");
grafo2.AdicionarVertices("F");
grafo2.AdicionarVertices("G");
grafo2.AdicionarVertices("H");
grafo2.AdicionarVertices("I");

grafo2.ConectarVertice("A", "B");
grafo2.ConectarVertice("A", "C");
grafo2.ConectarVertice("A", "D");
grafo2.ConectarVertice("B", "F");
grafo2.ConectarVertice("B", "I");
grafo2.ConectarVertice("D", "E");
grafo2.ConectarVertice("D", "I");
grafo2.ConectarVertice("D", "G");
grafo2.ConectarVertice("I", "A");
grafo2.ConectarVertice("I", "D");
grafo2.ConectarVertice("I", "C");
grafo2.ConectarVertice("I", "H");
grafo2.ConectarVertice("E", "A");

caminho = BuscaEmProfundidade.GetInstance().Buscar(grafo2);

Console.WriteLine("Caminho feito por uma busca em profundidade: ");
foreach (String passo in caminho)
{
    Console.WriteLine(passo + " ");
}

caminho = BuscaEmLargura.GetInstance().Buscar(grafo2);
Console.WriteLine();
Console.WriteLine("Caminho feito por uma busca em largura: ");
foreach (String passo in caminho)
{
    Console.WriteLine(passo + " ");
}

Console.WriteLine("\n\nExemplo 3");
GrafoClass grafo3 = new GrafoClass();

grafo3.AdicionarVertices("A");
grafo3.AdicionarVertices("B");
grafo3.AdicionarVertices("C");
grafo3.AdicionarVertices("D");
grafo3.AdicionarVertices("E");

grafo3.ConectarVertice("A", "B");
grafo3.ConectarVertice("B", "E");
grafo3.ConectarVertice("B", "C");
grafo3.ConectarVertice("B", "D");
grafo3.ConectarVertice("D", "E");

caminho = BuscaEmProfundidade.GetInstance().Buscar(grafo3);

Console.WriteLine("Caminho feito por uma busca em profundidade: ");
foreach (String passo in caminho)
{
    Console.WriteLine(passo + " ");
}

caminho = BuscaEmLargura.GetInstance().Buscar(grafo3);
Console.WriteLine();
Console.WriteLine("Caminho feito por uma busca em largura: ");
foreach (String passo in caminho)
{
    Console.WriteLine(passo + " ");
}
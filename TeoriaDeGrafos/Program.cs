using TeoriaDeGrafos.Grafo.Core;


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
*/


    Grafo grafo2 = new Grafo();

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






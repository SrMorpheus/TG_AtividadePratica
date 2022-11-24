using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TeoriaDeGrafos.GrafoPasta.Core;

namespace TeoriaDeGrafos.GrafoPasta.Search
{
     public class BuscaEmProfundidade
     {

        private static BuscaEmProfundidade _instance;

        private BuscaEmProfundidade() { }


        public static BuscaEmProfundidade GetInstance()
        {
            if(_instance == null)
            {

                return new BuscaEmProfundidade();


            }

            return _instance;

        }



        public List<string> Buscar (GrafoClass grafo, string origem , string destino)
        {
            Stack<string> roloDeBarbante = new Stack<string>();
            HashSet<string> verticesVisitados = new HashSet<string>();
            Caminho caminho = new Caminho();

            roloDeBarbante.Push(origem);


            while(roloDeBarbante.Count!=0)
            {


                string v = roloDeBarbante.Pop();

                if(v.Equals(destino))
                {
                    break;

                }

                foreach( var u in grafo.GetAdjacencias(v))
                {

                    string rotulo = u.GetRotulo();


                    if(!verticesVisitados.Contains(rotulo))
                    {
                        verticesVisitados.Add(rotulo);
                        caminho.Ligar(rotulo, v);
                        roloDeBarbante.Push(rotulo);



                    }

                }


            }


            return caminho.Gerar(origem, destino);


        }


        public List<string> Buscar (GrafoClass grafo)
        {

            Stack<string> roloDeBarbante = new Stack<string>();
            List<string> marcados = new List<string>();
            List<string> resultados = new List<string>();


            roloDeBarbante.Push(grafo.GetVertices()[0].GetRotulo());
            marcados.Add(grafo.GetVertices()[0].GetRotulo());



            while(roloDeBarbante.Count > 0)
            {

                string verticeAtual = roloDeBarbante.Pop();
                resultados.Add(verticeAtual);

                foreach(var u in grafo.GetAdjacencias(verticeAtual))
                {

                    if (!marcados.Contains(u.GetRotulo()))
                    {

                        marcados.Add(u.GetRotulo());
                        roloDeBarbante.Push(u.GetRotulo());


                    }


                }


            }


            return resultados;

        }
        




    }
}

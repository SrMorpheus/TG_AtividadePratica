using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TeoriaDeGrafos.GrafoPasta.Core;

namespace TeoriaDeGrafos.GrafoPasta.Search
{
    public class BuscaEmLargura
    {

        private static BuscaEmLargura _instance;


        public static BuscaEmLargura GetInstance()
        {
            if(_instance == null)
            {

                return new BuscaEmLargura();


            }

            return _instance;

        }

        public List<string> buscar (GrafoClass grafo, string origem , string destino)
        {

            LinkedList<string> roloDeBarbante = new LinkedList<string>();
            
            HashSet<string>  verticesVisitados = new HashSet<string>();

            Caminho caminho = new Caminho();

            roloDeBarbante.AddFirst(origem);

            while (roloDeBarbante.Count !=0)

            {

                string v = roloDeBarbante.First();

                roloDeBarbante.RemoveFirst();


                if(v.Equals(destino))
                {

                    break;

                }

                foreach (var u in grafo.GetAdjacencias(v))
                {

                    string rotulo = u.GetRotulo();

                    if(!verticesVisitados.Contains(rotulo))
                    {
                        verticesVisitados.Add(rotulo);
                        caminho.Ligar(rotulo, v);
                        roloDeBarbante.AddFirst(rotulo);

                    }

                }


            }

            return caminho.Gerar(origem, destino);



        }


        public List<string> Buscar (GrafoClass grafo)
        {
            LinkedList<string> roloDeBArbante = new LinkedList<string> ();

            List<string> marcados = new List<string>();

            marcados.Add(grafo.GetVertices()[0].GetRotulo());
            roloDeBArbante.AddFirst(grafo.GetVertices()[0].GetRotulo());

            while(roloDeBArbante.Count > 0)
            {

               string verticeAtual = roloDeBArbante.First();
               roloDeBArbante.RemoveFirst();



                foreach( var u in grafo.GetAdjacencias(verticeAtual))
                {

                    if (!marcados.Contains(u.GetRotulo()))
                    {
                        marcados.Add(u.GetRotulo());
                        roloDeBArbante.AddFirst(u.GetRotulo());


                    }
                


                }

            }

            return marcados;
        }

        



    }
}

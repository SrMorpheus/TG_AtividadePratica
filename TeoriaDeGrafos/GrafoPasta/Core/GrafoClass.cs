using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaDeGrafos.GrafoPasta.Core
{
    public class GrafoClass
    {

        private List<Vertice> _vertices = new List<Vertice>();

        private MatrizAdjacencia _matrizAdjacencia;

        private int _qtdMaximaVertices ;

        private bool _IsQtdMaximaDefinida;

        private int _qtdAtualVertices = 0;

        private Dictionary<string, int> rotuloEmIndices  = new Dictionary<string, int>();

        

        public GrafoClass()
        {

            _qtdMaximaVertices = 10;

        }


        public GrafoClass (int qtdVertices )
        {

            if(qtdVertices <= 0)
            {
                throw new ArgumentException("A quantidade máxima de vértices deve ser maior ouu igaul a 1");

            }

            _qtdMaximaVertices = qtdVertices;
             _IsQtdMaximaDefinida = true;


        }



        public void AdicionarVertices(string  rotulo)
        {

            if (_qtdAtualVertices <= _qtdMaximaVertices - 1)
            {


                Vertice novoVertice = new Vertice(rotulo);

                _vertices.Add(novoVertice);
                rotuloEmIndices.Add(rotulo, _qtdAtualVertices);

                _qtdAtualVertices++;

            }
            else
            
            {

                throw new ArgumentException("A quantidade máxima de vértices permitida " + _qtdMaximaVertices +  " foi excedida.");


            }

        }


        public Vertice GetVertice(string rotulo)
        {

            ExisteVerticeOrThrow(rotulo);

            int indice;

            var boolReposta = rotuloEmIndices.TryGetValue(rotulo, out indice);

            if(boolReposta)
            {

                return _vertices[indice];

            }

            return null;

        }

        public void ConectarVertice( string rotuloVerticeInicial , string rotuloVerticeFinal)
        {

            int indiceVerticeInicial;
            int inidiceVerticeFinal;

            if (!ExisteVertice(rotuloVerticeInicial) || !ExisteVertice(rotuloVerticeFinal))
            {

                throw new Exception("Para adicionar uma aresta ambos vértices devem existir.");


            }

            CriarMatrizAdjacencia();

            rotuloEmIndices.TryGetValue(rotuloVerticeFinal, out inidiceVerticeFinal);
            rotuloEmIndices.TryGetValue(rotuloVerticeInicial, out indiceVerticeInicial);

            _matrizAdjacencia.AdicionarAresta(indiceVerticeInicial, inidiceVerticeFinal);
            

        }

        public List<Vertice> GetAdjacencias (string vertice)
        {
            int indiceVertice;

            ExisteVerticeOrThrow(vertice);

            rotuloEmIndices.TryGetValue(vertice, out indiceVertice);

            return _matrizAdjacencia.GetAdjacencias(indiceVertice);



        }



        

        public List<Vertice> GetVertices()
        {


            return _vertices;

        }

        public int OrdemGrafo()
        {


            return _vertices.Count();

        }


        private bool ExisteVerticeOrThrow(string vertice)
        {

            if(!ExisteVertice(vertice))
            {

                throw new ArgumentException("O vértice não eciste.");

            }

            return true;


        }

        private bool ExisteVertice(string rotuloVertice)
        {

            int indice;

           var boolReposta =  rotuloEmIndices.TryGetValue(rotuloVertice, out indice);


            if(boolReposta)
            {

                return _vertices[indice] != null ? true : false;

            }

            return false;

        }

        private void CriarMatrizAdjacencia()
        {

            if(_matrizAdjacencia == null)
            {

                _matrizAdjacencia = new MatrizAdjacencia(new List<Vertice>(_vertices));

            }



        }



        public bool GRAPHcheckPath(List<Vertice> vertices)
        {
            for (int x = 0; x < vertices.Count - 1; x++)
            {
                var Adjacencias = GetAdjacencias(vertices[x].GetRotulo());

                int count = Adjacencias.Count(V => V.GetRotulo() == vertices[x+1].GetRotulo());

                if (count == 0) return false ;

            }   

            return true;


        }



    }
}

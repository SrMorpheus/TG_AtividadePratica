using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaDeGrafos.Grafo.Core
{
    public class MatrizAdjacencia
    {


        private int[,] _matriz;

        private List<Vertice> _vertices;

        private int _qtdVertices;


        public MatrizAdjacencia(List<Vertice> vertices)
        {


            _vertices = vertices;

            _qtdVertices = vertices.Count;

            _matriz = new int[_qtdVertices, _qtdVertices];

            InicializarMatriz();


        }

        private void InicializarMatriz()
        {

            for (int x = 0; x < _qtdVertices; x++)
            {

                for (int y = 0; y < _qtdVertices; y ++)
                {

                    _matriz[x, y] = 0;

                }


            }


        }


        public void AdicionarAresta( int inidiceVerticeInicial , int indiceVerticeFinal)
        {


            var verticeInicial = _vertices[inidiceVerticeInicial];

            var verticeFinal = _vertices[indiceVerticeFinal];

            if(inidiceVerticeInicial == indiceVerticeFinal)
            {

                _matriz[inidiceVerticeInicial, inidiceVerticeInicial] = 1;

                verticeInicial.AddGrau();

            }else
            {

                _matriz[inidiceVerticeInicial, indiceVerticeFinal] = 1;

                verticeInicial.AddGrau();

                _matriz[indiceVerticeFinal, inidiceVerticeInicial] = 1;

                verticeFinal.AddGrau();



            }

        }

        public List<Vertice> GetAdjacencias(int indiceVertice)
        {
            int linha = indiceVertice;

            var adjacencias = new List<Vertice>();


            for(int i = 0; i < _vertices.Count;  i ++)
            {

                if (_matriz[linha,i] == 1 )
                {
                   var vertice = _vertices[i];

                    adjacencias.Add(vertice);


                }

            }


            return adjacencias;

        }



    }
}

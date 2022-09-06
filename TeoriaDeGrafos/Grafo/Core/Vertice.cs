using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaDeGrafos.Grafo.Core
{
    public class Vertice
    {

        public string _rotulo { private set; get; }

        private int _grau;


        public Vertice(string rotulo)
        {

            if (String.IsNullOrWhiteSpace(rotulo))
            {

                throw new Exception("Não é permitida a inclusão de vértices com rótulo em branco.");

            
            }
            else
            {

                _rotulo = rotulo;

            } 





        }

        public string GetRotulo ()
        {
            return _rotulo;
        }


        public void AddGrau()
        {

            _grau++;

        }

        public int GetGrau()
        {

            return _grau;

        }


    }
}

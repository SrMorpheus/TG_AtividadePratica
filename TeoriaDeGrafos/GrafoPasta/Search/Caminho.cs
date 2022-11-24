using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaDeGrafos.GrafoPasta.Search
{
    public class Caminho
    {


        private IDictionary<string, string> _caminho;


        public Caminho()
        {

            _caminho = new Dictionary<string,string>();


        }


        public void Ligar (string anterior , string proximo)
        {


            _caminho[anterior] = proximo;



        }

        public List<string> Gerar (string origem , string destino)
        {

            List<string> resultado = new List<string>();
            string no = destino;

            while(no != origem && _caminho.ContainsKey(no))
            {

                resultado.Add(no);
                no = _caminho[no];

            }

            resultado.Add(no);

            resultado.Reverse();

            return resultado;



        }



    }
}

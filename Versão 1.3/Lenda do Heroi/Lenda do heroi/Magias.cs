using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenda_do_heroi
{
    public class Magias
    {
        public string nome;
        public float dano;
        public string classe;
        public Magias(string nome,float dano,string classe)
        {
            this.nome = nome;
            this.dano = dano;
            this.classe = classe;
        }
    }
}

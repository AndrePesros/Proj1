using System;
using System.Collections.Generic;
using System.Text;

namespace Proj1
{
    class Instituicao
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public Departamento[] Departamentos { get; } = new Departamento[10];
        private int quantsdp = 0;
        public void Registrardp(Departamento d)
        {
            if (quantsdp < 10)
                Departamentos[quantsdp++] = d;
        }

        public int Obeterquatdps()
        {
            return quantsdp;
        }
        public Departamento Dpindice(int indice)
        {
            return Departamentos[indice];
        }

    }
}

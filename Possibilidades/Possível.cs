using System;
using System.Text;

namespace Possibilidades
{
    public class Possível
    {
        private char[] dicionario;
        private ulong qtdCaracteres;
        private ulong possibilidades;
        private ulong index = 0;
        private StringBuilder sb = new StringBuilder();

        public bool hasNext = true;

        public Possível(string dicionario, ulong qtdCaracteres)
        {
            this.dicionario = dicionario.ToCharArray();
            this.qtdCaracteres = qtdCaracteres;
            getPossibilidades();
        }

        private void getPossibilidades()
        {
            ulong temp = (ulong)dicionario.Length;
            possibilidades = temp;
            for (ulong i = 1; i < qtdCaracteres; i++)
            {
                possibilidades = possibilidades * temp;
            }
        }

        public string getNext()
        {
            sb.Clear();
            for (ulong ii = 0; ii < qtdCaracteres; ii++)
            {
                sb.Append(dicionario[(int)((index / Math.Pow(dicionario.Length, ii)) % dicionario.Length)]);
            }
            index++;
            if (!(index < possibilidades))
            {
                hasNext = false;
            }

            return sb.ToString();
        }
    }
}

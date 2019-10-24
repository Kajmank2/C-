using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_rpg
{
    public class Druzyna
    {
        private string _nazwa;
        private List<IPostac> _lista;

        public Druzyna(string nazwa)
        {
            _nazwa = nazwa;
            _lista = new List<IPostac>();
        }

        public void Dodaj(IPostac postac)
        {
            _lista.Add(postac);
        }

        public double SumaAtaku()
        {
            double moc = 0;
            foreach (var postac in _lista)
            {
                moc += postac.MocAtaku();
            }
            return moc;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Druzyna: " + _nazwa);
            sb.AppendLine("Suma ataku: " + this.SumaAtaku());
            for (int i = 0; i < _lista.Count; i++)
            {
                sb.AppendLine(_lista[i].ToString());
            }
            return sb.ToString();
        }
    }
}

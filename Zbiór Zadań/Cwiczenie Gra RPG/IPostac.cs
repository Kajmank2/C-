using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_rpg
{
    public interface IPostac
    {
        string Imie { get;   }
        double PunktyZycia { get;  }
        double MocAtaku();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStomatologServices.Interfejsi
{
    public interface IUslugaService
    {
        IEnumerable<eStomatologModel.Usluga> Get();
        eStomatologModel.Usluga GetById(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStomatologServices.Interfejsi
{
    public interface ITerminService
    {
        IEnumerable<eStomatologModel.Termin> Get();
        eStomatologModel.Termin GetById(int id);
    }
}

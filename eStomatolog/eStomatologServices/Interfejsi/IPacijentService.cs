using eStomatologServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStomatologServices.Interfejsi
{
    public interface IPacijentService
    {
        IEnumerable<eStomatologModel.Pacijent> Get();
        eStomatologModel.Pacijent GetById(int id);
    }
}

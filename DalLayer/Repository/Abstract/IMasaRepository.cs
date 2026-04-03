using Models;
using System.Collections.Generic;

namespace DalLayer.Repositories.Abstract
{
    public interface IMasaRepository : ICRUD<Masa>
    {
        List<Masa> BosMasalariGetir();
        Masa MasaNoIleGetir(string masaNo);
        List<Masa> KonumaGoreGetir(string konum);
    }
}

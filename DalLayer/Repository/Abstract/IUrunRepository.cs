using Models;
using System.Collections.Generic;

namespace DalLayer.Repositories.Abstract
{
    public interface IUrunRepository : ICRUD<Urun>
    {
        List<Urun> KategoriyeGoreGetir(string kategori);
        List<Urun> MevcutUrunler();
        List<Urun> FiyataGoreSirala();
    }
}
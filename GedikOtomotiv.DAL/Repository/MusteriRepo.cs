using GedikOtomotiv.Entity.DBContext;
using GedikOtomotiv.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GedikOtomotiv.DAL.Repository
{
    public class MusteriRepo
    {
        public static List<Musteri> GetAll()
        {
            using (GedikOtoDBContext db = new GedikOtoDBContext())
            {
                return db.Musteri.ToList();
            }
        }
    }
}

using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class SupportingMaterialsDAO
    {
        ManageDbContext db = null;
        public SupportingMaterialsDAO()
        {
            db = new ManageDbContext();
        }
        public int Insert(SupportingMaterial entity)
        {
            db.SupportingMaterials.Add(entity);
            db.SaveChanges();
            return entity.SupportingMaterialID;
        }
    }
}

using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class OrganisantionDAO
    {
        ManageDbContext db = null;

        public OrganisantionDAO()
        {
            db = new ManageDbContext();
        }

        public int Insert(Organisantion entity)
        {
            db.Organisantions.Add(entity);
            db.SaveChanges();
            return entity.OrgID;
        }

        public Org_Add_View ViewOrganisantion(int id)
        {
            return db.Org_Add_View.Find(id);
        }

        public Organisantion GetById(int id)
        {
            return db.Organisantions.Find(id);
        }

        public Organisantion Edit(Organisantion entity)
        {
            try
            {
                var organisantion = db.Organisantions.Find(entity.OrgID);

                organisantion.OrgName = entity.OrgName;
                organisantion.ContactID = entity.ContactID;
                organisantion.IsActive = entity.IsActive;
                db.SaveChanges();
                return organisantion;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var organisantion = db.Organisantions.Find(id);
                db.Organisantions.Remove(organisantion);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        public Organisantion getOrgName(string orgName)
        {
            return db.Organisantions.SingleOrDefault(n => n.OrgName == orgName);
        }

    }
}

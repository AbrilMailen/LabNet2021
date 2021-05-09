using LAB.Data;
using LAB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.Logic
{
    public class TerritoriesLogic : BaseLogic, IABMLogic<Territories>
    {
        public void Add(Territories newT)
        {
            context.Territories.Add(newT);
            context.SaveChanges();
        }

        public void Delete(string id)
        {

            var territorieAEliminar = context.Territories.Find(id); ;
            context.Territories.Remove(territorieAEliminar);
            context.SaveChanges();
        }

        public bool Exists(string idStr = "", int idInt = 0)
        {
            var territorio = context.Territories.Find(idStr);
            if (territorio != null)
                return true;
            else return false;
        }

        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public Territories GetOne(string id)
        {
            var territorie = context.Territories.Find(id);
            return territorie;
        }

        public void Update(Territories upT)
        {
            var territorieUpdate = context.Territories.Find(upT.TerritoryID);
            territorieUpdate.TerritoryDescription = upT.TerritoryDescription;
            territorieUpdate.RegionID = upT.RegionID;

            context.SaveChanges();
        }
    }
}

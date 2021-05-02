using LAB.EF.Data;
using LAB.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.EF.Logic
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

using IsaacGonzález._2024.EN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacGonzález._2024.DAL
{
    public class CategoDal
    {
        public static async Task<Catego> GetById(int id)
        {
            var pcat = new Catego();
            using (var dbContext = new ComunDB())
            {
                pcat = await dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == id);
            }
            return pcat;
        }

        public static async Task<int> Create(Catego catego)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                dbContext.Add(catego);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Update(Catego catego)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                var pcat = await dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == catego.Id);
                pcat.Nombre = catego.Nombre;
                dbContext.Update(catego);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<List<Catego>> GetAll()
        {
            var pcat = new List<Catego>();
            using (var dbContext = new ComunDB())
            {
                pcat = await dbContext.Categorias.ToListAsync();
            }
            return pcat;
        }

        public static async Task<int> Delete(Catego catego)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                var pcat = await dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == catego.Id);
                dbContext.Remove(catego);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
    }
}

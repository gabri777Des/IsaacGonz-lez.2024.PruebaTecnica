using IsaacGonzález._2024.EN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacGonzález._2024.DAL
{
    public class ProducDAL
    {
        public static async Task<Produc> GetById(int id)
        {
            var pcat = new Produc();
            using (var dbContext = new ComunDB())
            {
                pcat = await dbContext.Productos.FirstOrDefaultAsync(c => c.Id == id);
            }
            return pcat;
        }

        public static async Task<int> Create(Produc Produc)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                dbContext.Add(Produc);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Update(Produc Produc)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                var pcat = await dbContext.Productos.FirstOrDefaultAsync(c => c.Id == Produc.Id);
                pcat.Nombre = Produc.Nombre;
                pcat.Precio = Produc.Precio;
                pcat.IdCatego = Produc.IdCatego;
                dbContext.Update(Produc);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<List<Produc>> GetAll()
        {
            var pcat = new List<Produc>();
            using (var dbContext = new ComunDB())
            {
                pcat = await dbContext.Productos.ToListAsync();
            }
            return pcat;
        }

        public static async Task<int> Delete(Produc Produc)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                var pcat = await dbContext.Productos.FirstOrDefaultAsync(c => c.Id == Produc.Id);
                dbContext.Remove(Produc);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
    }
}

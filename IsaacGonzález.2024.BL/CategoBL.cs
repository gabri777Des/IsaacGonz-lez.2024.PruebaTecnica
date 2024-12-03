using IsaacGonzález._2024.DAL;
using IsaacGonzález._2024.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacGonzález._2024.BL
{
    public class CategoBL
    {
        public static async Task<Catego> GetById(int id)
        {
            return await CategoDal.GetById(id);
        }
        public static async Task<List<Catego>> GetAll()
        {
            return await CategoDal.GetAll();
        }
        public static async Task<int> Create(Catego catego)
        {
            return await CategoDal.Create(catego);
        }
        public static async Task<int> Update(Catego catego)
        {
            return await CategoDal.Update(catego);
        }
        public static async Task<int> Delete(Catego catego)
        {
            return await CategoDal.Delete(catego);
        }
    }
}
using IsaacGonzález._2024.DAL;
using IsaacGonzález._2024.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacGonzález._2024.BL
{
    public class ProducBL
    {
        public static async Task<Produc> GetById(int id)
        {
            return await ProducDAL.GetById(id);
        }
        public static async Task<List<Produc>> GetAll()
        {
            return await ProducDAL.GetAll();
        }
        public static async Task<int> Create(Produc Produc)
        {
            return await ProducDAL.Create(Produc);
        }
        public static async Task<int> Update(Produc Produc)
        {
            return await ProducDAL.Update(Produc);
        }
        public static async Task<int> Delete(Produc Produc)
        {
            return await ProducDAL.Delete(Produc);
        }
    }
}

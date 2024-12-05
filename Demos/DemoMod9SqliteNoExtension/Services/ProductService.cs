using DemoMod9SqliteNoExtension.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace DemoMod9SqliteNoExtension.Services
{
    //This class provides with method for interacting with the Sqlite database

    public class ProductService
    {
        public SQLiteAsyncConnection con;
        string _dbPath;

        public ProductService(string dbPath) 
        {
            _dbPath = dbPath;
        }

        private async Task InitAsync()
        {
            if (con != null)
            {
                return;
            }
            con = new SQLiteAsyncConnection(_dbPath);
            await con.CreateTableAsync<ProductInfo>();
        }
        public async Task<bool> AddUpdateProductAsync(ProductInfo productInfo)
        {
            //return false;
            if (productInfo.ProdId > 0)
            {
                await con.UpdateAsync(productInfo); // Update
            }
            else
            {
                await con.InsertAsync(productInfo);// Insert
            }

            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteProductAsync(int prodId)
        {
            //return false;
            await con.DeleteAsync<ProductInfo>(prodId);
            return await Task.FromResult(true);
        }
        //retrive a record based on ProductId
        //select  * from emp where 
        public async Task<ProductInfo> GetProductAsync(int prodId)
        {
            //throw new NotImplementedException();
            return await con.Table<ProductInfo>().Where(p=>p.ProdId == prodId).FirstOrDefaultAsync();
        }

        //retrive all the record 
        public async Task<IEnumerable<ProductInfo>> GetProductAsync()
        {
            //throw new NotImplementedException();
            await InitAsync();
            return await Task.FromResult(await con.Table<ProductInfo>().ToListAsync());
        }


    }
}

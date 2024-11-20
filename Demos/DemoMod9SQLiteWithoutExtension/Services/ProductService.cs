using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMod9SQLiteWithoutExtension.Data;
using SQLite;

namespace DemoMod9SQLiteWithoutExtension.Services
{
	// this class provides us with a method for interacting with the SQLite database
	public class ProductService
	{
		public SQLiteAsyncConnection conn;
		string _dbPath;
        public ProductService()
        {
			_dbPath = _dbPath;
        }

		private async Task InitAsync()
		{
			if (conn != null)
			{
				return;
			}
			conn = new SQLiteAsyncConnection(_dbPath);
			await conn.CreateTableAsync<ProductInfo>();
		}
        public async Task<bool> AddUpdateProductAsync(ProductInfo productInfo)
		{
			if (productInfo.ProdId > 0)
			{	
				await conn.UpdateAsync(productInfo); // Update
			}
			else
			{
				await conn.InsertAsync(productInfo); // Insert
			}
			return await Task.FromResult(true);
		}
		public async Task<bool> DeleteProductAsync(int prodId)
		{
			await conn.DeleteAsync<ProductInfo>(prodId);
			return await Task.FromResult(true);
		}

		// retrieve a record based on ProductId
		public async Task<ProductInfo> GetProductAsync(int prodId)
		{
			return await conn.Table<ProductInfo>().Where(p => p.ProdId == prodId).FirstOrDefaultAsync();
		}

		// returns all the records
		public async Task<IEnumerable<ProductInfo>> GetProductAsync()
		{
			await InitAsync();
			return await Task.FromResult(await conn.Table<ProductInfo>().ToListAsync());
		}	
	}
}

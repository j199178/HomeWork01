using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeWork01.Models
{
    public class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
    {
        public 客戶資料 searchById(int p_id)
        {
            return this.All().FirstOrDefault(m => m.Id == p_id);
        }
    }

    public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}
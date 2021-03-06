using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeWork01.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
    {
        public 客戶銀行資訊 searchById(int p_id)
        {
            return this.All().FirstOrDefault(m => m.Id == p_id);
        }

        public override IQueryable<客戶銀行資訊> All()
        {
            return base.All();
            //.Where(m => m.IsDelete != "1");
        }

    }

	public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}
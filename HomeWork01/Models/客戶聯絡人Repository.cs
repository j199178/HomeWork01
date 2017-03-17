using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace HomeWork01.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
        public 客戶聯絡人 searchById(int p_id)
        {
            return this.All().FirstOrDefault(m => m.Id == p_id);
        }

        public override IQueryable<客戶聯絡人> All()
        {
            return base.All();
            //.Where(m => m.IsDelete != "1");
        }

        internal IEnumerable searchForDdl()
        {
            return base.All().Distinct();
        }
    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}
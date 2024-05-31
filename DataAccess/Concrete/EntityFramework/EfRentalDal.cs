using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DBCarProjectContext>, IRentalDal
    {
        public List<RentalAllDetails> GetRentAllDetailsDto()
        {
            using (DBCarProjectContext context = new DBCarProjectContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             join u in context.Users on r.CustomerId equals u.Id
                             select new RentalAllDetails 
                             { Id = r.Id, BrandName = b.BrandName, FullName = u.FirstName + " " + u.LastName, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();
            }
        }
    }
}

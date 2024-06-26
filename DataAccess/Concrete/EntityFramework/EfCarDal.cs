﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DBCarProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (DBCarProjectContext context = new DBCarProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.Id equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto 
                             { 
                             Id = c.Id,BrandName = b.BrandName,ColorName = co.ColorName,DailyPrice=c.DailyPrice,Description=c.Description,ModelYear=c.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}

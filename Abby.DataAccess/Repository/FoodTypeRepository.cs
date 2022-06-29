﻿
using Abby.Models;
using AbbyWeb.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repository.IRepository
{
    public class FoodTypeRepository : Repository<FoodType>, IFoodTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public FoodTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(FoodType obj)
        {
            var ObjFromDb = _db.FoodType.FirstOrDefault(u => u.Id == obj.Id); //this will retrive the category obj from the database
            ObjFromDb.Name = obj.Name;
        }
    }
}

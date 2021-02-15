using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BranId { get; set; }
        public int ColorId { get; set; }
        public decimal DailyPrice { get; set; }//günlük fiyat
        public string Description { get; set; }//açıklama

    }
}

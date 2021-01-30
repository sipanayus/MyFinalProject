using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın
    class Category:IEntity
    {
        public int CstegoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

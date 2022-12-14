using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IColorsDal
    {
        List<Colors> GetAllColors();
        public void Add(Colors color);
        public void Update(Colors color);
        public void Delete(Colors color);
    }
}

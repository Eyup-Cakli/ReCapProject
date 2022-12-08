using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorsDal : IColorsDal
    {
        List<Colors> _colors;
        public InMemoryColorsDal()
        {
            _colors = new List<Colors>
            {
                new Colors{ColorId=1,ColorName="Siyah"},
                new Colors{ColorId=2,ColorName="Beyaz"},
                new Colors{ColorId=3,ColorName="Gri"},
                new Colors{ColorId=4,ColorName="Mavi"}
            };
        }
        public void Add(Colors color)
        {
            _colors.Add(color);
        }

        public void Delete(Colors color)
        {
            Colors colorToDelete=_colors.SingleOrDefault(p=>p.ColorId==color.ColorId);
            _colors.Remove(colorToDelete);
        }

        public List<Colors> GetAllColors()
        {
            return _colors;
        }

        public void Update(Colors color)
        {
            Colors colorToUpdate = _colors.SingleOrDefault(p => p.ColorId == color.ColorId);
            colorToUpdate.ColorId = color.ColorId;
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}

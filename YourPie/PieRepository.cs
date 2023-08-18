using Microsoft.EntityFrameworkCore;
using YourPie.Models;

namespace YourPie
{
    public class PieRepository:IPieRepository
    {
        private readonly YourPieDbContext _yourPieDbcontext;
        public PieRepository(YourPieDbContext yourPieDbcontext)
        {
            _yourPieDbcontext = yourPieDbcontext;
        }
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _yourPieDbcontext.pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _yourPieDbcontext.pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _yourPieDbcontext.pies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}

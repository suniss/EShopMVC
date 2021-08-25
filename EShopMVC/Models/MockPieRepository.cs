using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopMVC.Models
{
    public class MockPieRepository : IPieRepository
        
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name="Strawberry Pie", Price= 15.96M, ShortDescription="Test Description"},
                new Pie {PieId = 2, Name="Strawberry Pie", Price= 15.96M, ShortDescription="Test Description"},
                new Pie {PieId = 3, Name="Strawberry Pie", Price= 15.96M, ShortDescription="Test Description"},
                new Pie {PieId = 4, Name="Strawberry Pie", Price= 15.96M, ShortDescription="Test Description"}
            };
public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using YourPie.Models;
using YourPie.ViewModels;

namespace YourPie.Controllers
{
    public class PieController : Controller
    {
      private readonly IPieRepository _pieRepository;
      private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            //ViewBag.CurrentCategory="cheese cakes ";
            //return View(_pieRepository.AllPies);  
            PieListViewModel piesListViewModel = new PieListViewModel(_pieRepository.AllPies,"Cheese Cake is Yours");
            return View(piesListViewModel);
        }
    }
    
    
}

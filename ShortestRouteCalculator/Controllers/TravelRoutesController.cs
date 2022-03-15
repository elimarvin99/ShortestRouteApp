using Microsoft.AspNetCore.Mvc;
using ShortestRouteCalculator.Services;

namespace ShortestRouteCalculator.Controllers
{
    public class TravelRoutesController : Controller
    {
        private RouteEngineService _routeEngineService;
        public TravelRoutesController(RouteEngineService routeEngineService)
        {
            _routeEngineService = routeEngineService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRoute()
        {
            var data = _routeEngineService.GetRouteData();
            return View(data);
        }
    }
}

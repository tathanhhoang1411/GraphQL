using GPL.DBModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GPL.Controllers
{
    
    [ApiController]
    public class DataController : ControllerBase
    {
        ProductDataContext _context = new ProductDataContext();


       

        [Route("GetProducts")]
        [HttpGet]
        public List<TblProduct> GetProducts()
        {
            return _context.TblProducts.ToList();
        }
    }
}

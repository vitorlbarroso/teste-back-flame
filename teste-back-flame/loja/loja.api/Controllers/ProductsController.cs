using loja.api.ViewModel;
using loja.domain.Entities;
using loja.domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace loja.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
    
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            
           return _productService.GetAll();
           
        }

     
        [HttpGet("{id:int}")]
        public Products Get(int id)
        {
            return _productService.GetByID(id);
        }

      
        [HttpGet, Route("status")]
        public IEnumerable<Products> Get( bool? parameterstatus = null)
        {
            
            return _productService.GetAll(parameterstatus);
        }
        
     
        [HttpPost]
        public IResult Post([FromBody] Productpost productview)
        {
            Products product=new Products();
            product.name = productview.name;
            product.description = productview.description;
            product.price = productview.price;
            DateTime t = DateTime.Now;
            product.timestamps=BitConverter.GetBytes(t.Ticks);
           
            var retorno = _productService.Save(product);

            return retorno ? Results.Ok() : Results.Problem("Erro ao inserir Produto");
        }

       
        [HttpPut("{id}")]
        public IResult Put(int id, [FromBody] Productput productview)
        {
            var product = _productService.GetByID(id);
            if (product != null && product.id == productview.id)
            {

                product.name = productview.name;
                product.description = productview.description;
                product.price = productview.price;
                product.isBlocked = productview.isBlocked;
                DateTime t = DateTime.Now;
                product.timestamps = BitConverter.GetBytes(t.Ticks);

            }
            else
            {
                return Results.Problem("Problema no id do produto.");
            }
            var retorno = _productService.Update(product);

            return retorno ? Results.Ok() : Results.Problem("Erro ao atualizar Produto");
        }

       
    }
}

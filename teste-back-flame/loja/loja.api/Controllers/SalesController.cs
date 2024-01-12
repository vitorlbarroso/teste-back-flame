using loja.api.ViewModel;
using loja.data.Services;
using loja.domain.Entities;
using loja.domain.Entities.Enums;
using loja.domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace loja.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private ISalesService _salesService;
        private IProductService _productService;
        public SalesController(ISalesService salesService, IProductService productService)
        {
            _salesService = salesService;
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Sales> Get()
        {
            return _salesService.GetAll();
        }


        [HttpGet("{id}")]
        public Sales Get(int id)
        {
            return _salesService.GetByID(id);
        }


        [HttpPost]
        public IResult Post([FromBody] Salespost salesview)
        {
            var product = _productService.GetByID(salesview.ProdutoId);

            if (!product.Price.Equals(salesview.AmountPaid))
                return Results.Problem("Valor incorreto do pagamento.", "", StatusCodes.Status422UnprocessableEntity);

            Sales sales = new Sales
            {
                ProdutoId = salesview.ProdutoId,
                AmountPaid = product.Price,
                BuyerDocument = salesview.BuyerDocument,
                BuyerFullName = salesview.BuyerFullName,
                DeliveryAddressCity = salesview.DeliveryAddressCity,
                DeliveryAddressComplement = salesview.DeliveryAddressComplement,
                DeliveryAddressState = salesview.DeliveryAddressState,
                DeliveryAddressZipCode = salesview.DeliveryAddressZipCode,
                PaymentMethod = (PaymentMethod)salesview.PaymentMethod,
                PaymentStatus = PaymentStatus.Paid,
                Status = Status.WaitingToBeSent,
                PurchaseCode = Guid.NewGuid(),

            };


            var retorno = _salesService.Save(sales);

            return retorno ? Results.Ok() : Results.Problem("Erro ao inserir Produto", "", StatusCodes.Status422UnprocessableEntity);
        }

        [HttpPut]
        public IResult Put([FromBody] Salesput salesview)
        {
            var salesobj = _salesService.GetByID(salesview.Id);

            if (salesobj is null)
                return  Results.Problem("Venda não existe.", "", StatusCodes.Status422UnprocessableEntity);


            salesobj.BuyerDocument = salesview.BuyerDocument;
            salesobj.BuyerFullName = salesview.BuyerFullName;
            salesobj.DeliveryAddressCity = salesview.DeliveryAddressCity;
            salesobj.DeliveryAddressComplement = salesview.DeliveryAddressComplement;
            salesobj.DeliveryAddressState = salesview.DeliveryAddressState;
            salesobj.DeliveryAddressZipCode = salesview.DeliveryAddressZipCode;
            salesobj.PaymentMethod = salesview.PaymentMethod;
            salesobj.PaymentStatus = salesview.PaymentStatus;
            salesobj.Status = salesview.Status;


            var retorno = _salesService.Update(salesobj);

            return retorno ? Results.Ok() : Results.Problem("Erro ao inserir Produto", "", StatusCodes.Status422UnprocessableEntity);
        }

        [HttpPut("{id}/{status}")]
        public IResult PutSalesStatus(int id, Status status)
        {
            var salesobj = _salesService.GetByID(id);

    
            if (salesobj is null)
                return Results.Problem("Venda não existe.", "", StatusCodes.Status422UnprocessableEntity);
                             
            salesobj.Status = status;
            var retorno = _salesService.Update(salesobj);

            return retorno ? Results.Ok() : Results.Problem("Erro ao inserir Produto", "", StatusCodes.Status422UnprocessableEntity);
        }

        [HttpPut]
        [Route("id/{iid}/paymentstatus/{paymentstatus}")]
        public IResult PutSalesPaymentStatus(int iid, PaymentStatus paymentstatus)
        {
            var salesobj = _salesService.GetByID(iid);


            if (salesobj is null)
                return Results.Problem("Venda não existe.", "", StatusCodes.Status422UnprocessableEntity);

            salesobj.PaymentStatus = paymentstatus;
            var retorno = _salesService.Update(salesobj);

            return retorno ? Results.Ok() : Results.Problem("Erro ao inserir Produto", "", StatusCodes.Status422UnprocessableEntity);
        }

    }
}

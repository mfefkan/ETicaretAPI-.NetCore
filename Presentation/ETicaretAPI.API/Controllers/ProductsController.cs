using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{                                           //Controller deneme için düzenlenmektedir. Projenin son hali değildir. Yapılan eklemeler, güncellemelere istinaden denemeler yapılmaktadır.
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }


        //[HttpGet]
        //public async Task Add()
        //{
        //    #region Database Ürün Ekleme Deneme Kodu
        //    //await _productWriteRepository.AddRangeAsync(new()
        //    //{
        //    //    new() { Id = Guid.NewGuid(), Name ="Product1", Price =100,CreatedDate = DateTime.UtcNow,Stock = 12 },
        //    //    new() { Id = Guid.NewGuid(), Name ="Product2", Price =200,CreatedDate = DateTime.UtcNow,Stock = 13 },
        //    //    new() { Id = Guid.NewGuid(), Name ="Product3", Price =300,CreatedDate = DateTime.UtcNow,Stock = 14 }
        //    //});
        //    //await _productWriteRepository.SaveAsync();
        //    #endregion

        //    #region Tracking Optimizasyon Deneme Kodu
        //    //Product p =   await _productReadRepository.GetByIdAsync("6e2bfc68-c690-4dea-be70-63d56ad03b65",false);

        //    //     p.Name = "Mehmet";

        //    //    await _productWriteRepository.SaveAsync();
        //    #endregion


        //    #region SaveChangeAsync Interceptor Deneme Kodu
        //    //await _productWriteRepository.AddAsync(new() { Name = "C Product", Price = 1.500F, Stock = 10, CreatedDate = DateTime.UtcNow });
        //    //await _productWriteRepository.SaveAsync();

        //    //var customerId = Guid.NewGuid();
        //    //await _customerWriteRepository.AddAsync(new() { Id= customerId ,Name = "Muhiddin"});

        //    //await  _orderWriteRepository.AddAsync(new() { Description = "bla bla bla", Address = "Kayseri, Talas" , CustomerId = customerId});
        //    //await  _orderWriteRepository.AddAsync(new() { Description = "bla bla bla2", Address = "Kayseri, Sarıoğlan", CustomerId = customerId });
        //    //await  _orderWriteRepository.SaveAsync();

        //    //  Order o = await  _orderReadRepository.GetByIdAsync("1fffef89-de7b-4c30-8b8b-832fc575aa8f");
        //    //o.Address = "İstanbul";
        //    //_orderWriteRepository.SaveAsync();

        //    #endregion

        //}

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Merhaba");
        }




    }
}

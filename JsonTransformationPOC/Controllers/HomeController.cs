using JsonTransformationPOC.DataAccess.DBContext;
using JsonTransformationPOC.Model;
using JUST;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using db = JsonTransformationPOC.DataAccess.Model;
using System.Linq;

namespace JsonTransformationPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly BCContext _context;
        public HomeController(BCContext context)
        {
            _context = context;
        }

        [Route("transformItemCategory")]
        [HttpPost]
        public async Task<ItemCategory> TransformAsync([FromBody] string itemCategory)
        {
            return await TransformToBCAsync(itemCategory);
        }
        [Route("transformChartOfAccount")]
        [HttpPost]
        public async Task<ChartOfAccount> TransformAsyncChartOfAccount([FromBody] string account)
        {
            return await TransformToBCAsyncChartOfAccount(account);
        }
        [Route("transformPaymentTerm")]
        [HttpPost]
        public async Task<Paymentterm> TransformAsyncPaymentTerm([FromBody] string payment)
        {
            return await TransformToBCAsyncPaymentTerm(payment);
        }
        [Route("transformItems")]
        [HttpPost]
        public async Task<Items> TransformAsyncItems([FromBody] string item)
        {
            return await TransformToBCAsyncItems(item);
        }
        [Route("transformPaymentMethod")]
        [HttpPost]
        public async Task<PaymentMethod> TransformAsyncPaymentMethod([FromBody] string method)
        {
            return await TransformToBCAsyncPaymentMethod(method);
        }
        [Route("transformCustomer")]
        [HttpPost]
        public async Task<Customer> TransformAsyncCustomer([FromBody] string customer)
        {
            return await TransformToBCCustomer(customer);
        }
        [Route("updatemapping")]
        [HttpPost]
        public async Task UpdateAsync([FromBody] ItemCategory itemCategory)
        {

            var itemCategoryData = _context.ItemCategory.Where(x => x.Id == itemCategory.ItemCategoryId).FirstOrDefault();
            itemCategoryData.DestinationId = itemCategory.Id;
            _context.Update(itemCategoryData);
            await _context.SaveChangesAsync();
        }
        private async Task<ItemCategory> TransformToBCAsync(string input)
        {
            string filePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            string transformer = System.IO.File.ReadAllText($@"{filePath}\JsonTransform\ItemCategory.json");
            string transformedString = JsonTransformer.Transform(transformer, input);
            var transformData = JsonConvert.DeserializeObject<ItemCategory>(transformedString);
            //var itemCategory = new db.ItemCategory
            //{
            //    Code = transformData.Code,
            //    Name = transformData.DisplayName,
            //    SourceSystemId = transformData.Id,
            //    DestinationId = null
            //};

            //await _context.AddAsync(itemCategory);
            //await _context.SaveChangesAsync();

            //transformData.ItemCategoryId = itemCategory.Id;
            transformData.Id = null;
            transformData.LastModifiedDateTime = null;
            return transformData;
        }
        private async Task<ChartOfAccount> TransformToBCAsyncChartOfAccount(string input)
        {
            string filePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string transformer = System.IO.File.ReadAllText($@"{filePath}\JsonTransform\ChartOfAccount.json");
            string transformedString = JsonTransformer.Transform(transformer, input);
            var transformData = JsonConvert.DeserializeObject<ChartOfAccount>(transformedString);
            return transformData;
        }
        private async Task<Items> TransformToBCAsyncItems(string input)
        {
            string filePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string transformer = System.IO.File.ReadAllText($@"{filePath}\JsonTransform\Items.json");
            string transformedString = JsonTransformer.Transform(transformer, input);
            var transformData = JsonConvert.DeserializeObject<Items>(transformedString);
            return transformData;
        }
        private async Task<Paymentterm> TransformToBCAsyncPaymentTerm(string input)
        {
            string filePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string transformer = System.IO.File.ReadAllText($@"{filePath}\JsonTransform\PaymentTerm.json");

            string transformedString = JsonTransformer.Transform(transformer, input);
            var transformData = JsonConvert.DeserializeObject<Paymentterm>(transformedString);
            return transformData;
        }
        private async Task<PaymentMethod> TransformToBCAsyncPaymentMethod(string input)
        {
            string filepath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string transformer = System.IO.File.ReadAllText($@"{filepath}\JsonTransform\PaymentMethod.json");
            string transformedString = JsonTransformer.Transform(transformer, input);
            var transformData = JsonConvert.DeserializeObject<PaymentMethod>(transformedString);
            return transformData;
        }
        private async Task<Customer> TransformToBCCustomer(string input)
        {
            string filepath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string transformer = System.IO.File.ReadAllText($@"{filepath}\JsonTransform\Customer.json");
            string transformedString = JsonTransformer.Transform(transformer, input);
            var transformData = JsonConvert.DeserializeObject<Customer>(transformedString);
            return transformData;
        }
    }

}

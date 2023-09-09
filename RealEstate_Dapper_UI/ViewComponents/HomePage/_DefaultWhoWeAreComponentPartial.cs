using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.WhoWeAreDtos;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultWhoWeAreComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var clientForServices = _httpClientFactory.CreateClient();
            var responseMessaage = await client.GetAsync("https://localhost:44382/api/WhoWeAres/who_we_ares");
            var responseMessaageForServices = await clientForServices.GetAsync("https://localhost:44382/api/Services/get_service_list");

            if(responseMessaage.IsSuccessStatusCode && responseMessaageForServices.IsSuccessStatusCode)
            {
                var jsonData = await responseMessaage.Content.ReadAsStringAsync();
                var jsonDataForServices = await responseMessaageForServices.Content.ReadAsStringAsync();

                var value = JsonConvert.DeserializeObject<List<ResultWhoWeAreDto>>(jsonData).FirstOrDefault();
                var valueForServices = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonDataForServices);

                ViewBag.title = value.title;
                ViewBag.subtitle = value.subtitle;
                ViewBag.description1 = value.description1;
                ViewBag.description2 = value.description2;
                return View(valueForServices);
            }
            return View();
        }
    }
}

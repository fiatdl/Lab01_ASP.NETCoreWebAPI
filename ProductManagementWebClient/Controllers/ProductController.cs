﻿using BusinessObjects_;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ProductManagementWebClient.Controllers
{
    public class ProductController : Controller
    {


        private readonly HttpClient client = null; private string ProductApiUrl;

public ProductController()
        {


            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            ProductApiUrl = "http://localhost:53633/api/products";
        }

        public async Task<IActionResult> Index()
        {


            HttpResponseMessage response = await client.GetAsync(ProductApiUrl); string strData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {  PropertyNameCaseInsensitive = true
            };
          

            List<Product> listProducts = JsonSerializer.Deserialize<List<Product>>(strData, options);
            return View(listProducts);
        }
        // GET: ProductController/Details/5

    } }


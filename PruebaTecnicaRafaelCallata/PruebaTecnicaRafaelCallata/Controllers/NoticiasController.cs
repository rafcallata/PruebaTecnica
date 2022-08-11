using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PruebaTecnicaRafaelCallata.Models;
using System.Collections.Generic;

namespace PruebaTecnicaRafaelCallata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiasController : ControllerBase
    {
        HttpClient client;
        [HttpGet]
        public async Task<IActionResult> GetArticulos()
        {
            client = new HttpClient();
            string url = "https://newsapi.org/v2/top-headlines?country=us&category=business&apiKey=cc4c2db17b0f49ed968a739a645ee18c";
            string response = await client.GetStringAsync(url);

            NoticiasResponse newsObject = JsonConvert.DeserializeObject<NoticiasResponse>(response);
            var list = new List<Article>();
            foreach (var article in newsObject.Articles)
            {
                list.Add(article);
            }
            return Ok(await Task.Run(() => list));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetalleArticulo(int id)
        {
            client = new HttpClient();
            string url = "https://newsapi.org/v2/top-headlines?country=us&category=business&apiKey=cc4c2db17b0f49ed968a739a645ee18c";
            string response = await client.GetStringAsync(url);

            NoticiasResponse newsObject = JsonConvert.DeserializeObject<NoticiasResponse>(response);
            Article article = new Article();
            for (int i = 0; i < newsObject.Articles.Count; i++)
            {
                if (i == id)
                {
                    article.Author = newsObject.Articles[i].Author;
                    article.Title = newsObject.Articles[i].Title;
                    article.Description = newsObject.Articles[i].Description;
                    article.Url = newsObject.Articles[i].Url;
                    article.UrlToImage = newsObject.Articles[i].UrlToImage;
                    article.PublishedAt = newsObject.Articles[i].PublishedAt;
                    article.Content = newsObject.Articles[i].Content;
                }
            }
            return Ok(await Task.Run(() => article));
        }
    }
}

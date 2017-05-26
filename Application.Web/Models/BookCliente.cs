using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Application.Web.Models
{
    public class BookCliente
    {
            private string Base_URL = "http://localhost:50652/api/";

            public IEnumerable<Book> pegarTodos()
            {
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(Base_URL);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("book").Result;

                    if (response.IsSuccessStatusCode)
                        return response.Content.ReadAsAsync<IEnumerable<Book>>().Result;
                    return null;
                }
                catch
                {
                    return null;
                }
            }
            public Book encontrar(int id)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(Base_URL);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("book/" + id).Result;

                    if (response.IsSuccessStatusCode)
                        return response.Content.ReadAsAsync<Book>().Result;
                    return null;
                }
                catch
                {
                    return null;
                }
            }
            public bool Criar(Book book)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(Base_URL);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.PostAsJsonAsync("book", book).Result;
                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }
            public bool Editar(Book book)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(Base_URL);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.PutAsJsonAsync("book/" + book.BookId, book).Result;
                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }
            public bool Delete(int id)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(Base_URL);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.DeleteAsync("book/" + id).Result;
                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }
    }
}

using System.Text;

class Program
{
    static async Task Main(string[] args)
    {
        await SendFirstRequest();
        await SendSecondRequest();
        await SendThirdRequest();
    }

    static async Task SendFirstRequest()
    {
        var url = "https://a.wb.ru/e/ec?t=Точилка для ножей FROLHOME 17334044 купить за 6,27 р. в интернет-магазине Wildberries&u=https://www.wildberries.ru/catalog/17334044/detail.aspx?targetUrl=SP&cid=4&s=3440x1440x24&w=2386x1353&user_id=10256868181711484967&vbn=325&timestamp=2024-03-28T21:34:08.047Z&timezone_offset=180&timezone=Europe/Minsk&client_id=w7TDssOkw7PCu8K2wrLCscK3wrLCs8K1wrM=";

        using (var httpClient = new HttpClient())
        {
            var content = new StringContent("", Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Content = content
            };

            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:122.0) Gecko/20100101 Firefox/122.0");
            request.Headers.Add("Accept", "*/*");
            request.Headers.Add("Accept-Language", "en-GB,en;q=0.5");
            request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            request.Headers.Add("Referer", "https://www.wildberries.ru/catalog/17334044/detail.aspx?targetUrl=SP");
            request.Headers.Add("authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6Ikp9.eyJpYXQiOjE3MTE2NTc4MjUsInZlcnNpb24iOjIsInVzZXIiOiI3MzA2MzI0MiIsInNoYXJkX2tleSI6IjExIiwiY2xpZW50X2lkIjoid2IiLCJzZXNzaW9uX2lkIjoiOThkOWVjNzFkOGI2NDdiMjg5OTdmYzQ5ZDc2MzRjODIiLCJ1c2VyX3JlZ2lzdHJhdGlvbl9kdCI6MTY0NTc3MzgzOSwidmFsaWRhdGlvbl9rZXkiOiI0NDA0MDI0MGIxYmE4YWFkZTZhNGQ2NGI0Y2NjMmNlMjljZDZiMTE3NDBjODljNzdhN2I1MDRiMWRhMmQzODQ1IiwicGhvbmUiOiI1Vjk0ZHVvL0RzUHBSb2MvMm5FUWpBPT0ifQ.pHz54fXl-1gJC3rDjDYkHx3-cfFY1C31J1jheq42eY7SYHloOhPj66dq77dgSPxd2nesIGhDnRPkAzcEkVD3CofYdOJF6vki9MrxqmWtwXlvhmQHS_AlV9lKKJSc8af2q1bhLR2Jwax3283FNYQMh18yyZ5AAcHtRciojrkHoTKvNZukyZLREVD2bDdhZV9BdvgEIw_CO9tQD-NC0kmO_TSrPmoxhGLEX7EvAXb0CAd5OPeiNCaeHOU-qkEk6EbLxKl6tnBEDjDtA41rNJ2aUHkNgSVjCwv_fo_M1MXoTEcbGK827Ju1BpLIM1Fcczaz610mv3SdYhdZ2kkky-Zq0g");
            request.Headers.Add("Origin", "https://www.wildberries.ru");
            request.Headers.Add("Connection", "keep-alive");
            request.Headers.Add("Sec-Fetch-Dest", "empty");
            request.Headers.Add("Sec-Fetch-Mode", "cors");
            request.Headers.Add("Sec-Fetch-Site", "same-site");
            request.Headers.Add("TE", "trailers");

            using (var response = await httpClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Первый запрос успешно выполнен.");
                }
                else
                {
                    Console.WriteLine($"Ошибка при выполнении первого запроса. Код ошибки: {response.StatusCode}");
                }
            }
        }
    }

    static async Task SendSecondRequest()
    {

        string url = "https://cart-storage-api.wildberries.ru/api/basket/sync?ts=1711661976258&device_id=site_16bc8c4dd53c4ed6a6ee4f01ba682072";
        string requestBody = "[{\"chrt_id\":48191701,\"quantity\":1,\"cod_1s\":17334044,\"client_ts\":1711662740,\"op_type\":1,\"target_url\":\"EX|1|SNT|IT|popular|17334044||||false\"}]"; // Замените на фактическое тело запроса


        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:122.0) Gecko/20100101 Firefox/122.0");
            client.DefaultRequestHeaders.Add("Accept", "*/*");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-GB,en;q=0.5");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            client.DefaultRequestHeaders.Add("Referer", "https://www.wildberries.ru/catalog/17334044/detail.aspx?targetUrl=SP");
            client.DefaultRequestHeaders.Add("authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6Ikp9.eyJpYXQiOjE3MTE2NTc4MjUsInZlcnNpb24iOjIsInVzZXIiOiI3MzA2MzI0MiIsInNoYXJkX2tleSI6IjExIiwiY2xpZW50X2lkIjoid2IiLCJzZXNzaW9uX2lkIjoiOThkOWVjNzFkOGI2NDdiMjg5OTdmYzQ5ZDc2MzRjODIiLCJ1c2VyX3JlZ2lzdHJhdGlvbl9kdCI6MTY0NTc3MzgzOSwidmFsaWRhdGlvbl9rZXkiOiI0NDA0MDI0MGIxYmE4YWFkZTZhNGQ2NGI0Y2NjMmNlMjljZDZiMTE3NDBjODljNzdhN2I1MDRiMWRhMmQzODQ1IiwicGhvbmUiOiI1Vjk0ZHVvL0RzUHBSb2MvMm5FUWpBPT0ifQ.pHz54fXl-1gJC3rDjDYkHx3-cfFY1C31J1jheq42eY7SYHloOhPj66dq77dgSPxd2nesIGhDnRPkAzcEkVD3CofYdOJF6vki9MrxqmWtwXlvhmQHS_AlV9lKKJSc8af2q1bhLR2Jwax3283FNYQMh18yyZ5AAcHtRciojrkHoTKvNZukyZLREVD2bDdhZV9BdvgEIw_CO9tQD-NC0kmO_TSrPmoxhGLEX7EvAXb0CAd5OPeiNCaeHOU-qkEk6EbLxKl6tnBEDjDtA41rNJ2aUHkNgSVjCwv_fo_M1MXoTEcbGK827Ju1BpLIM1Fcczaz610mv3SdYhdZ2kkky-Zq0g");

            StringContent content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            string responseContent = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseContent);
        }
    }

    static async Task SendThirdRequest()
    {
        var url = "https://www.wildberries.ru/webapi/logging/wbbasket/metrics?status=0";

        using (var httpClient = new HttpClient())
        {
            var content = new StringContent("", Encoding.UTF8);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Content = content
            };

            request.Headers.Add("Host", "www.wildberries.ru");
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:122.0) Gecko/20100101 Firefox/122.0");
            request.Headers.Add("Accept", "*/*");
            request.Headers.Add("Accept-Language", "en-GB,en;q=0.5");
            request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            request.Headers.Add("Referer", "https://www.wildberries.ru/catalog/17334044/detail.aspx?targetUrl=SP");
            request.Headers.Add("authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6Ikp9.eyJpYXQiOjE3MTE2NTc4MjUsInZlcnNpb24iOjIsInVzZXIiOiI3MzA2MzI0MiIsInNoYXJkX2tleSI6IjExIiwiY2xpZW50X2lkIjoid2IiLCJzZXNzaW9uX2lkIjoiOThkOWVjNzFkOGI2NDdiMjg5OTdmYzQ5ZDc2MzRjODIiLCJ1c2VyX3JlZ2lzdHJhdGlvbl9kdCI6MTY0NTc3MzgzOSwidmFsaWRhdGlvbl9rZXkiOiI0NDA0MDI0MGIxYmE4YWFkZTZhNGQ2NGI0Y2NjMmNlMjljZDZiMTE3NDBjODljNzdhN2I1MDRiMWRhMmQzODQ1IiwicGhvbmUiOiI1Vjk0ZHVvL0RzUHBSb2MvMm5FUWpBPT0ifQ.pHz54fXl-1gJC3rDjDYkHx3-cfFY1C31J1jheq42eY7SYHloOhPj66dq77dgSPxd2nesIGhDnRPkAzcEkVD3CofYdOJF6vki9MrxqmWtwXlvhmQHS_AlV9lKKJSc8af2q1bhLR2Jwax3283FNYQMh18yyZ5AAcHtRciojrkHoTKvNZukyZLREVD2bDdhZV9BdvgEIw_CO9tQD-NC0kmO_TSrPmoxhGLEX7EvAXb0CAd5OPeiNCaeHOU-qkEk6EbLxKl6tnBEDjDtA41rNJ2aUHkNgSVjCwv_fo_M1MXoTEcbGK827Ju1BpLIM1Fcczaz610mv3SdYhdZ2kkky-Zq0g");
            request.Headers.Add("x-requested-with", "XMLHttpRequest");
            request.Headers.Add("x-spa-version", "10.0.1.1");
            request.Headers.Add("Origin", "https://www.wildberries.ru");
            request.Headers.Add("Connection", "keep-alive");
            request.Headers.Add("Cookie", "__currency=BYN; BasketUID=42104775efbf43d79ac3de4a8bbeff83; ___wbu=0ce6daae-7124-4ce1-a740-207e0b550b7a.1704133226; __wba_s=1; _wbauid=10256868181711484967; wbx-validation-key=eab1117b-baec-4b3c-8548-a136c4d748aa; ___wbs=ad967a67-5719-4f64-8cde-56a9ec3802ec.1711661299");
            request.Headers.Add("Sec-Fetch-Dest", "empty");
            request.Headers.Add("Sec-Fetch-Mode", "cors");
            request.Headers.Add("Sec-Fetch-Site", "same-origin");
            request.Headers.Add("TE", "trailers");

            using (var response = await httpClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Третий запрос успешно выполнен.");
                }
                else
                {
                    Console.WriteLine($"Ошибка при выполнении третьего запроса. Код ошибки: {response.StatusCode}");
                }
            }
        }
    }
}

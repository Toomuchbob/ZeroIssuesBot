﻿using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

public class DiscordBotAuthorizer
{
    private readonly string _grantType = ConfigurationManager.AppSettings["grantType"];
    private readonly string _clientId = ConfigurationManager.AppSettings["clientId"];
    private readonly string _clientSecret = ConfigurationManager.AppSettings["clientSecret"];
    private readonly string _scope = ConfigurationManager.AppSettings["scope"];
    private readonly string _permissions = ConfigurationManager.AppSettings["permissions"];
    private readonly string _apiEndpoint = ConfigurationManager.ConnectionStrings["apiEndpoint"].ToString();

    private static HttpClient Client = new HttpClient();

    private List<KeyValuePair<string, string>> GetRequestContent()
    {
        var list = new List<KeyValuePair<string, string>>();
        DiscordBotAuthorizer bot = new DiscordBotAuthorizer();
        for (int i = 0; i < ConfigurationManager.AppSettings.Count; i++)
        {
            list.Add(new KeyValuePair<string, string>(ConfigurationManager.AppSettings.GetKey(i), ConfigurationManager.AppSettings.GetValues(i).First()));
        }
        return list;
    }

    public async Task<string> GetTokenResponse()
    {
        var requestUri = _apiEndpoint;

        var request = new HttpRequestMessage(HttpMethod.Post, requestUri);
        request.Content = new FormUrlEncodedContent(GetRequestContent());

        var response = await Client.SendAsync(request);

        return await response.Content.ReadAsStringAsync();
    }
}

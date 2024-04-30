using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OAuthServiceConnect.Models;
using System.Net;

namespace OAuthServiceConnect.Controllers
{
    [ApiController]
    public class OAuthController : ControllerBase
    {
        private readonly OauthConfig _oauthConfig;
        private readonly ILogger<OAuthController> _logger;

        public OAuthController(
            ILogger<OAuthController> logger,
            IOptions<OauthConfig> oauthConfig)
        {
            _logger = logger;
            _oauthConfig = oauthConfig.Value;
        }

        [HttpGet]
        [Route("api/facebook")]
        public IActionResult Facebook(string? code = null)
        {            
            if (string.IsNullOrEmpty(code))
            {
                _logger.LogInformation($"Request access using Facebook");
                _logger.LogInformation($"Facebook will redirect the request for a login screen");

                return Redirect($"https://graph.facebook.com/oauth/authorize?client_id={_oauthConfig.ClientId}&redirect_uri={_oauthConfig.RedirectUri}");
            }

            _logger.LogInformation($"Facebook has returned a code");
            _logger.LogInformation($"Request access token using code returned from Facebook - Code = {code}");

            var json = string.Empty;
            var request = (HttpWebRequest)WebRequest.Create($"https://graph.facebook.com/{_oauthConfig.Version}/oauth/access_token?client_id={_oauthConfig.ClientId}&redirect_uri={_oauthConfig.RedirectUri}&client_secret={_oauthConfig.AppSecret}&code={code}");
            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var receiveStream = response.GetResponseStream();
                var readStream = new StreamReader(receiveStream);
                json = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
            }

            _logger.LogInformation($"Request user data after successful login");

            var oauthToken = JsonConvert.DeserializeObject<OauthToken>(json);
            return Redirect($"https://graph.facebook.com/me?fields=name,gender,birthday,picture.width(320).height(320)&access_token={oauthToken.access_token}");
        }
    }
}
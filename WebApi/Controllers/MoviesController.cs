using Bussiness.BussinessLayer;
using Entities.Utilities;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApi.Util;

namespace WebApi.Controllers
{
    [MycrosHot]
    [System.Web.Http.RoutePrefix("Movies")]
    public class MoviesController : ApiController
    {
        MoviesBL moviesBl = new MoviesBL();

        [System.Web.Http.Route("GetLastMovies")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetLastMovies()
        {
            try
            {
                ConfigRequest configRequest = new ConfigRequest()
                {
                    ApiKey = ConfigurationManager.AppSettings["Api_Key"],
                    urlBase = ConfigurationManager.AppSettings["Url_Base"]
                };
                var response = this.Request.CreateResponse(HttpStatusCode.OK, moviesBl.GetLastMovies(configRequest));
                return response;
            }
            catch (Exception eException)
            {
                throw new HttpResponseException(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new StringContent(eException.Message)
                });
            }
        }

        [System.Web.Http.Route("GetPopularMovies")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetPopularMovies()
        {
            try
            {
                ConfigRequest configRequest = new ConfigRequest()
                {
                    ApiKey = ConfigurationManager.AppSettings["Api_Key"],
                    urlBase = ConfigurationManager.AppSettings["Url_Base"]
                };
                var response = this.Request.CreateResponse(HttpStatusCode.OK, moviesBl.GetPopularMovies(configRequest));
                return response;
            }
            catch (Exception eException)
            {
                throw new HttpResponseException(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new StringContent(eException.Message)
                });
            }
        }
        [System.Web.Http.Route("GetTopRatedMovies")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetTopRatedMovies()
        {
            try
            {
                ConfigRequest configRequest = new ConfigRequest()
                {
                    ApiKey = ConfigurationManager.AppSettings["Api_Key"],
                    urlBase = ConfigurationManager.AppSettings["Url_Base"]
                };
                var response = this.Request.CreateResponse(HttpStatusCode.OK, moviesBl.GetTopRatedMovies(configRequest));
                return response;
            }
            catch (Exception eException)
            {
                throw new HttpResponseException(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new StringContent(eException.Message)
                });
            }
        }
    }
}
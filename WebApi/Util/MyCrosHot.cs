using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace WebApi.Util
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class MycrosHot : Attribute, ICorsPolicyProvider
    {
        private CorsPolicy _policy;
        public MycrosHot()
        {
            // Create a CORS policy.
            _policy = new CorsPolicy
            {
                AllowAnyMethod = true,
                AllowAnyHeader = true
            };
            // Agregar origenes
            _policy.Origins.Add("http://localhost:4200");
        }
        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_policy);
        }
    }
}
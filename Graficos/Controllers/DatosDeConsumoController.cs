using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Graficos.Controllers
{
    public class DatosDeConsumoController : ApiController
    {
        TaxiDB db = new TaxiDB();
        public List<RankingDeVentasDeTaxis_Result>  Get()
        {
            return db.RankingDeVentasDeTaxis().ToList();
        }

    }
}

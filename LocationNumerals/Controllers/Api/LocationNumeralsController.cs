using Models;
using LogicLayer;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace LocationNumerals.Controllers.Api
{
    /// <summary>
    /// This controller handle all the HTTP resquest (POST) to send information to every method according to the needs
    /// </summary>
    [RoutePrefix("api")]
    public class LocationNumeralsController : ApiController
    {
        private DataManagerClass _dm;
        public LocationNumeralsController()
        {
            _dm = new DataManagerClass();
        }

        /// <summary>
        /// This method receives an Integer and returns a string the result of the conversion to Literal number
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <description>poipoipoip</description>
        /// <response code="200">Process OK</response>
        /// <response code="400">Invalid parameters sent</response>
        /// <response code="500">Excpetion unhandled</response> 
        /// <returns>Retorna información del usuario autenticado</returns>
        [HttpPost]
        [Route("IntToLocationNum")]
        [ResponseType(typeof(DataOut))]
        public HttpResponseMessage IntToLocationNum(IntToLocationNum input)
        {
            if (ModelState.IsValid)
            {
                var tt = _dm.IntToLocationNumeral(input.input);
                var resp = Request.CreateResponse(HttpStatusCode.OK, tt);

                return resp;
            }
            else
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest,new DataOut() { result = Models.Common.Result.error , message = "Invalid parameters sent" });
            }
        }

        /// <summary>
        /// This method receives an Integer and returns a string the result of the conversion to Literal number
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <description>poipoipoip</description>
        /// <response code="200">Process OK</response>
        /// <response code="400">Invalid parameters sent</response>
        /// <response code="500">Excpetion unhandled</response> 
        /// <returns>Retorna información del usuario autenticado</returns>
        [HttpPost]
        [Route("LocationNumeralToInt")]
        [ResponseType(typeof(DataOut))]
        public HttpResponseMessage LocationNumeralToInt(LocationNumIn input)
        {
            if (ModelState.IsValid)
            {
                var tt = _dm.LocationNumeralToInt(input.input.ToLower());
                var resp = Request.CreateResponse(HttpStatusCode.OK, tt);

                return resp;
            }
            else
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, new DataOut() { result = Models.Common.Result.error, message = "Invalid parameters sent" });
            }
        }

        /// <summary>
        /// This method receives an Integer and returns a string the result of the conversion to Literal number
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <description>poipoipoip</description>
        /// <response code="200">Process OK</response>
        /// <response code="400">Invalid parameters sent</response>
        /// <response code="500">Excpetion unhandled</response> 
        /// <returns>Retorna información del usuario autenticado</returns>
        [HttpPost]
        [Route("LocationNumeralToAbreviated")]
        [ResponseType(typeof(DataOut))]
        public HttpResponseMessage LocationNumeralToAbreviated(LocationNumIn input)
        {
            if (ModelState.IsValid)
            {
                var tt = _dm.LocationNumeralToAbreviated(input.input.ToLower());
                var resp = Request.CreateResponse(HttpStatusCode.OK, tt);

                return resp;
            }
            else
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, new DataOut() { result = Models.Common.Result.error, message = "Invalid parameters sent" });
            }
        }
    }
}

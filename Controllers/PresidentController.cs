using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class PresidentController : ApiController
    {

        IList<President> _presidents = new List<President>();


        public ResponseModel Get()
        {
            getPresidentData();
            Configuration.Formatters.Clear();
            Configuration.Formatters.Add(new JsonMediaTypeFormatter());
            ResponseModel responseModel = new ResponseModel();
            responseModel.PresidentData = _presidents;
            return responseModel;
        }

        [Route("Api/president/ascending")]
        public ResponseModel GetPresidentAsc()
        {
            getPresidentData();
            ResponseModel responseModel = new ResponseModel();
            responseModel.PresidentData = _presidents.OrderBy(_presidents => _presidents.PresidentName);
            Configuration.Formatters.Clear();
            Configuration.Formatters.Add(new JsonMediaTypeFormatter());
            return responseModel;
        }

        [Route("Api/president/descending")]
        public ResponseModel GetPresidentDesc()
        {
            getPresidentData();
            ResponseModel responseModel = new ResponseModel();
            responseModel.PresidentData = _presidents.OrderByDescending(_presidents => _presidents.PresidentName);
            Configuration.Formatters.Clear();
            Configuration.Formatters.Add(new JsonMediaTypeFormatter());
            return responseModel;
        }


        private void getPresidentData()
        {
            JObject parsedJson = JObject.Parse(Constants.PRESIDENT_JSON);
            JToken jPresident = parsedJson[Constants.PRESIDENT_DATA_JSON_KEY];
            foreach (var individual in jPresident)
            {
                var president = new President();
                president.PresidentName = (string)individual[Constants.PPRESIDENT_NAME_KEY];
                president.BirthDay = (string)individual[Constants.PRESIDENT_BIRTH_DAY_KEY];
                president.BirthPlace = (string)individual[Constants.PPRESIDENT_BIRTH_PLACE_KEY];
                president.DeathDay = (string)individual[Constants.PPRESIDENT_DEATH_DAY_KEY];
                president.DeathPlace = (string)individual[Constants.PPRESIDENT_DEATH_PLACE_KEY];
                _presidents.Add(president);
            }
        }

    }
}
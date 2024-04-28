using Data.ApiModels;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Swashbuckle.AspNetCore.Annotations;

namespace Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route(Constants.RouteNames.Base + "/data-set")]
    public class DataSetController : ControllerBase
    {
        private readonly ILogger<DataSetController> Logger;

        public DataSetController(ILogger<DataSetController> logger)
        {
            Logger = logger;
        }

        [HttpGet]
        [Route(Constants.RouteNames.TableEntry)]
        [SwaggerOperation("Get TableRecords", "Get records for table views")]
        [SwaggerResponse(StatusCodes.Status200OK, ResponseText.Ok)]
        [SwaggerResponse(StatusCodes.Status400BadRequest, ResponseText.BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, ResponseText.Error)]
        public ActionResult<IList<DataSetModel>> GetTableRecords()
        {
            Logger.LogInformation("{func} called", nameof(GetTableRecords));

            return Ok();
        }

        [HttpGet]
        [Route(Constants.RouteNames.IdParam)]
        [SwaggerOperation("Get Record by Id", "Get record for standard usage by Id")]
        [SwaggerResponse(StatusCodes.Status200OK, ResponseText.Ok)]
        [SwaggerResponse(StatusCodes.Status400BadRequest, ResponseText.BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound, ResponseText.NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, ResponseText.Error)]
        public ActionResult<DataSetModel> GetRecordById(long id)
        {
            Logger.LogInformation("{func} called, with id = {id}", nameof(GetRecordById), id);

            return Ok();
        }

        [HttpPost]
        [SwaggerOperation("Add Codebook Record")]
        [SwaggerResponse(StatusCodes.Status201Created, ResponseText.Created)]
        [SwaggerResponse(StatusCodes.Status400BadRequest, ResponseText.BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, ResponseText.Error)]
        public ActionResult<long> AddRecord(DataSetUploadModel model)
        {
            Logger.LogInformation("{func} called, with model = {model}", nameof(AddRecord), model);

            return Created();
        }
    }
}

using System;
using System.Threading.Tasks;
using JkTyre.Business;
using JkTyre.Enums;
using JkTyre.Models;
using Microsoft.AspNetCore.Mvc;

namespace JkTyre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly MasterManager _masterManager;

        public MasterController(MasterManager masterManager)
        {
            _masterManager = masterManager;
        }

        [HttpGet]
        [Route("GetIncentiveMaster")]
        public async Task<IActionResult> GetIncentiveMaster()
        {
            try
            {
                var incentives = await _masterManager.GetIncentiveMasterAsync();
                return Ok(new
                {
                    IsSuccess = true,
                    Message = ReturnMessage.DataFetchSuccessfully,
                    Data = incentives,
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("AddEditIncentiveMaster")]
        public async Task<IActionResult> AddEditIncentiveMaster(IncentiveMasterModel mdm)
        {
            try
            {
                await _masterManager.AddEditIncentiveMaster(mdm);
                return Ok(new
                {
                    IsSuccess = true,
                    Message = "New record saved successfully."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPost]
        [Route("DeleteIncentiveMaster")]
        public async Task<IActionResult> DeleteIncentiveMaster(Int64 id)
        {
            try
            {
                await _masterManager.DeleteIncentiveMaster(id);
                return Ok(new
                {
                    IsSuccess = true,
                    Message = "Record delete successfully"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

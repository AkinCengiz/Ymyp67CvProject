using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ymyp67CvProject.Business.Abstract;
using Ymyp67CvProject.Entity.Dtos.Experience;

namespace Ymyp67CvProject.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ExperiencesController : ControllerBase
{
    private readonly IExperienceService _experiencesService;

    public ExperiencesController(IExperienceService experiencesService)
    {
        _experiencesService = experiencesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _experiencesService.GetAllAsync();
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _experiencesService.GetByIdAsync(id);
        if (!result.Success)
        {
            return NotFound(result.Message);
        }
        return Ok(result.Data);
    }

    [HttpGet("[action]/{company}")]
    public async Task<IActionResult> GetExperiencesByCompany(string company)
    {
        var result = await _experiencesService.GetExperiencesByCompanyAsync(company);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }


    [HttpPost]
    public async Task<IActionResult> Create(ExperienceCreateRequestDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Geçersiz veri");
        }

        var result = await _experiencesService.AddAsync(dto);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);

    }

    [HttpPut]
    public async Task<IActionResult> Update(ExperienceUpdateRequestDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Geçersiz veri");
        }

        var result = await _experiencesService.UpdateAsync(dto);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }

        return Ok(result.Message);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _experiencesService.RemoveAsync(id);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }

        return Ok(result.Message);
    }
}

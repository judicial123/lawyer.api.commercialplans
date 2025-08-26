using lawyer.api.commercialplans.application.DTO;
using lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Create;
using lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Delete;
using lawyer.api.commercialplans.application.UseCases.LegalTechPlan.GetAll;
using lawyer.api.commercialplans.application.UseCases.LegalTechPlan.GetById;
using lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lawyer.api.commercialplans.webapi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class LegalTechPlanController : ControllerBase
{
    private readonly IMediator _mediator;

    public LegalTechPlanController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<LegalTechPlanDto>>> Get()
    {
        var entities = await _mediator.Send(new GetAllLegalTechPlanQuery());
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LegalTechPlanDto>> Get(Guid id)
    {
        var entity = await _mediator.Send(new GetByIdLegalTechPlanQuery(id));
        return Ok(entity);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post([FromBody] CreateLegalTechPlanCommand command)
    {
        var id = await _mediator.Send(command);
        var url = Url.Action(nameof(Get), new { id });
        return Created(url, id);
    }

    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Put([FromBody] UpdateLegalTechPlanCommand command)
    {
        if (command.Id == Guid.Empty)
            return BadRequest("The provided ID is not valid.");

        var updatedId = await _mediator.Send(command);
        return Ok(updatedId);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<ActionResult> Delete(Guid id)
    {
        var command = new DeleteLegalTechPlanCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}

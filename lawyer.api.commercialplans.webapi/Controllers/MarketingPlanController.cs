using lawyer.api.commercialplans.application.DTO;
using lawyer.api.commercialplans.application.UseCases.MarketingPlan.Create;
using lawyer.api.commercialplans.application.UseCases.MarketingPlan.Delete;
using lawyer.api.commercialplans.application.UseCases.MarketingPlan.GetAll;
using lawyer.api.commercialplans.application.UseCases.MarketingPlan.GetById;
using lawyer.api.commercialplans.application.UseCases.MarketingPlan.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lawyer.api.commercialplans.webapi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class MarketingPlanController : ControllerBase
{
    private readonly IMediator _mediator;

    public MarketingPlanController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<MarketingPlanDto>>> Get()
    {
        var entities = await _mediator.Send(new GetAllMarketingPlanQuery());
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MarketingPlanDto>> Get(Guid id)
    {
        var entity = await _mediator.Send(new GetByIdMarketingPlanQuery(id));
        return Ok(entity);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post([FromBody] CreateMarketingPlanCommand command)
    {
        var id = await _mediator.Send(command);
        var url = Url.Action(nameof(Get), new { id });
        return Created(url, id);
    }

    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Put([FromBody] UpdateMarketingPlanCommand command)
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
        var command = new DeleteMarketingPlanCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}

using Core.Entities;

namespace Ymyp67CvProject.Entity.Dtos.Experience;

public sealed record ExperienceCreateRequestDto(
    Guid Id,
    string Title,
    string Company,
    string Description,
    DateTime StartDate,
    DateTime? EndDate
) : ICreateDto;
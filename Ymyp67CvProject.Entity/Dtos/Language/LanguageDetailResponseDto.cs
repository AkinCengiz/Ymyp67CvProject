using Core.Entities;

namespace Ymyp67CvProject.Entity.Dtos.Language;

public sealed record LanguageDetailResponseDto(
    Guid Id,
    string Name,
    byte Level,
    bool IsActive,
    bool IsDeleted
) : IDetailDto;
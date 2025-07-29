using Core.Entities;

namespace Ymyp67CvProject.Entity.Dtos.Education;

public sealed record EducationDetailResponseDto(
    Guid Id,
    string School,
    string Section,
    string Department,
    decimal GPA,
    string Grade,
    DateTime StartDate,
    DateTime? EndDate,
    bool IsActive,
    bool IsDeleted
) : IDetailDto;
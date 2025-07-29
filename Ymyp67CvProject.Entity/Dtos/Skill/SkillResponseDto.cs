using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvProject.Entity.Dtos.Skill;

public sealed record SkillResponseDto(
    Guid Id,
    string Title,
    string Icon,
    bool IsProgramLanguageAndTool
    ) : IResponseDto;
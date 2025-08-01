﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvProject.Entity.Dtos.Experience;

public sealed record ExperienceResponseDto(
    Guid Id,
    string Title,
    string Company,
    string Description,
    DateTime StartDate,
    DateTime? EndDate
    ) : IResponseDto;
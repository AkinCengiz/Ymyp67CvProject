﻿using Core.Entities;

namespace Ymyp67CvProject.Entity.Dtos.PersonalInfo;

public sealed record PersonalInfoCreateRequestDto(
    string FirstName,
    string LastName,
    string ImageUrl,
    bool MaritalStatus,
    string Gender,
    string DrivingLicence,
    DateTime BirthDate,
    string BirthPlace,
    string Nationality
) : ICreateDto;
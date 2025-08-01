﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Ymyp67CvProject.Entity.Concrete;
using Ymyp67CvProject.Entity.Dtos.PersonalInfo;

namespace Ymyp67CvProject.Business.Abstract;
public interface IPersonalInfoService : IGenericService<PersonalInfo,PersonalInfoResponseDto,PersonalInfoCreateRequestDto,PersonalInfoUpdateRequestDto,PersonalInfoDetailResponseDto>
{
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Ymyp67CvProject.Entity.Concrete;
using Ymyp67CvProject.Entity.Dtos.About;

namespace Ymyp67CvProject.Business.Abstract;
public interface IAboutService : IGenericService<About,AboutResponseDto,AboutCreateRequestDto,AboutUpdateRequestDto,AboutDetailResponseDto>
{
}

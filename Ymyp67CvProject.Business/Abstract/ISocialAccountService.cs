using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvProject.Entity.Concrete;
using Ymyp67CvProject.Entity.Dtos.SocialAccount;

namespace Ymyp67CvProject.Business.Abstract;
public interface ISocialAccountService : IGenericService<SocialAccount,SocialAccountResponseDto,SocialAccountCreateRequestDto,SocialAccountUpdateRequestDto,SocialAccountDetailResponseDto>
{
    Task<IDataResult<SocialAccountResponseDto>> GetSocialAccountByNameAsync();
    Task<IDataResult<IEnumerable<SocialAccountResponseDto>>> GetSocialAccountsByUserNameAsync();
}

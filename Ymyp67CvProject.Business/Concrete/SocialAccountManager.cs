using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.UnitOfWorks;
using Core.Utilities.Results;
using Ymyp67CvProject.Business.Abstract;
using Ymyp67CvProject.DataAccess.Abstract;
using Ymyp67CvProject.Entity.Dtos.SocialAccount;

namespace Ymyp67CvProject.Business.Concrete;
public class SocialAccountManager : ISocialAccountService
{
    private readonly ISocialAccountRepository _socialAccountRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public SocialAccountManager(ISocialAccountRepository socialAccountRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _socialAccountRepository = socialAccountRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public Task<IDataResult<SocialAccountResponseDto>> AddAsync(SocialAccountCreateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> UpdateAsync(SocialAccountUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<SocialAccountResponseDto>> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<IEnumerable<SocialAccountResponseDto>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<SocialAccountResponseDto>> GetSocialAccountByNameAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<IEnumerable<SocialAccountResponseDto>>> GetSocialAccountsByUserNameAsync()
    {
        throw new NotImplementedException();
    }
}

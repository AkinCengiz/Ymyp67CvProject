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
using Ymyp67CvProject.Entity.Concrete;
using Ymyp67CvProject.Entity.Dtos.About;

namespace Ymyp67CvProject.Business.Concrete;
public class AboutManager : IAboutService
{
    private readonly IAboutRepository _aboutRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public AboutManager(IAboutRepository aboutRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _aboutRepository = aboutRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<IDataResult<AboutResponseDto>> AddAsync(AboutCreateRequestDto dto)
    {
        try
        {
            var about = _mapper.Map<About>(dto);
            await _aboutRepository.AddAsync(about);

            await _unitOfWork.CommitAsync();
            throw new NotImplementedException();//UnitOfWork anlatılacak.

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Task<IResult> UpdateAsync(AboutUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<AboutResponseDto>> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<IEnumerable<AboutResponseDto>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}

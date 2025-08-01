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
using Ymyp67CvProject.Entity.Dtos.Skill;

namespace Ymyp67CvProject.Business.Concrete;
public class SkillManager : ISkillService
{
    private readonly ISkillRepository _skillRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public SkillManager(ISkillRepository skillRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _skillRepository = skillRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public Task<IDataResult<SkillResponseDto>> AddAsync(SkillCreateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> UpdateAsync(SkillUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<SkillResponseDto>> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<IEnumerable<SkillResponseDto>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsProgramLanguagesAsync(bool program)
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsToolsAsync(bool tools)
    {
        throw new NotImplementedException();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvProject.Entity.Concrete;

namespace Ymyp67CvProject.Business.Abstract;
public interface IExperienceService : IGenericService<Experience>
{
    Task<IDataResult<IEnumerable<Experience>>> GetExperiencesByCompanyAsync(string company);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Ymyp67CvProject.DataAccess.Abstract;
using Ymyp67CvProject.DataAccess.Contexts;
using Ymyp67CvProject.Entity.Concrete;

namespace Ymyp67CvProject.DataAccess.Concrete.EntityFramework;
public class EfInterestRepository : EfGenericRepository<Interest,Ymyp67CvProjectDbContext>,IInterestRepository
{
    public EfInterestRepository(Ymyp67CvProjectDbContext context) : base(context)
    {
    }
}

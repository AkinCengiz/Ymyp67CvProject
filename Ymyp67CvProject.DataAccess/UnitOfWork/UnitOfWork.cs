using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.UnitOfWorks;
using Ymyp67CvProject.DataAccess.Contexts;

namespace Ymyp67CvProject.DataAccess.UnitOfWork;
public class UnitOfWork(Ymyp67CvProjectDbContext context) : IUnitOfWork
{
    //PRIMARY CONSTRUCTOR OLUŞTURULDUĞU İÇİN ALLTAKİ KOD SATIRLARI YORUM SATIRI OLDU
    //private readonly Ymyp67CvProjectDbContext _context;

    //public UnitOfWork(Ymyp67CvProjectDbContext context)
    //{
    //    _context = context;
    //}
    private readonly Ymyp67CvProjectDbContext _context = context;


    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Commit()
    {
        _context.SaveChanges();
    }
}

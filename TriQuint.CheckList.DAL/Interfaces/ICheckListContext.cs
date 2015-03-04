
using System.Data.Entity;
using TriQuint.BaseDAL.Interfaces;
using TriQuint.CheckList.Entities;

namespace TriQuint.CheckList.DAL.Interfaces
{
    public interface ICheckListContext :IContext
    {
        DbSet<CheckListTemplate> CheckListTemplates { get; set; }
    }
}

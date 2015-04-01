
using System.Data.Entity;
using TriQuint.BaseInterfaces;
using TriQuint.CheckList.Entities;

namespace TriQuint.CheckList.DAL.Interfaces
{
    public interface ICheckListContext :IContext
    {
        IDbSet<CheckListTemplate> CheckListTemplates { get; set; }
        IDbSet<CheckListItemTemplate> CheckListItemTemplates { get; set; }
        IDbSet<TemplateSection> TemplateSections { get; set; } 
    }
}

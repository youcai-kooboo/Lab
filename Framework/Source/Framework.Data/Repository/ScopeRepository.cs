//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Framework.Data.Model;
using Framework.Data.Infrastructure;

namespace Framework.Data.Repository
{
    public partial interface IScopeRepository : IRepository<Scope>
    {
    }
    
    public partial class ScopeRepository : RepositoryBase<Scope>, IScopeRepository
    {
        public ScopeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
     
}
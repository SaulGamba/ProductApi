using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApi.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}

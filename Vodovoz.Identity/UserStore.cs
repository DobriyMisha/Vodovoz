﻿using Microsoft.AspNet.Identity;
using NHibernate;
using QS.DomainModel.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vodovoz.Identity
{
    public class UserStore : IUserStore<IdentityUser, int>
    {
        public UserStore(IUnitOfWork unitOfWork) //: base(unitOfWork.Session)
        {
            UoW = unitOfWork;
        }

        public UserStore(ISession context)// : base(context)
        {
        }

        public IUnitOfWork UoW { get; private set; }

        public Task CreateAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> FindByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityUser> FindByNameAsync(string userName)
        {
            return await UoW.Session.QueryOver<IdentityUser>().Where(x => x.UserName == userName).SingleOrDefaultAsync();
        }

        public Task UpdateAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }
    }
}
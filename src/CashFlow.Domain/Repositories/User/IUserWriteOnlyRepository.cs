﻿namespace CashFlow.Domain.Repositories.User
{
    public interface IUserWriteOnlyRepository
    {
        public Task Add(Entities.User user);

        public Task Delete(Entities.User user);
    }
}

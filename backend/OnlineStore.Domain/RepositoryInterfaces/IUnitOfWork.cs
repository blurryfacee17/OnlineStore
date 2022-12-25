﻿namespace OnlineStore.Domain.RepositoryInterfaces;

public interface IUnitOfWork
{
    IAccountRepository AccountRepository { get; }
    ICartRepository CartRepository { get; }
    IProductRepository ProductRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
﻿using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShare.Responses;
using LocalShared.DTOs;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones
{
    public class GenericUnitOfWork<T> : IGenericUnitOfWork<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericUnitOfWork(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<ActionResponse<IEnumerable<T>>> GetAsync(PaginationDTO pagination) => await _repository.GetAsync(pagination);
        public virtual async Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination) => await _repository.GetTotalPagesAsync(pagination);
        public virtual async Task<ActionResponse<T>> AddAsync(T model) => await _repository.AddAsync(model);
        public virtual async Task<ActionResponse<T>> DeleteAsync(Guid id) => await _repository.DeleteAsync(id);
        public virtual async Task<ActionResponse<IEnumerable<T>>> GetAsync() => await _repository.GetAsync();
        public virtual async Task<ActionResponse<T>> GetAsync(Guid id) => await _repository.GetAsync(id);
        public virtual async Task<ActionResponse<T>> UpdateAsync(T model) => await _repository.UpdateAsync(model);
    }
}

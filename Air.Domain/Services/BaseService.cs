using Air.Domain.Entities;
using Air.Domain.Interfaces.Repositories;
using Air.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Domain.Services
{
    public class BaseService<TEntidade> : IBaseService<TEntidade> where TEntidade : BaseEntity
    {
        protected readonly IBaseRepository<TEntidade> repository;

        public BaseService(IBaseRepository<TEntidade> repository)
        {
            this.repository = repository;
        }

        public void Alterar(TEntidade entidade)
        {
            repository.Alterar(entidade);
        }

        public void Excluir(int id)
        {
            repository.Excluir(id);
        }

        public void Excluir(TEntidade entidade)
        {
            repository.Excluir(entidade);
        }

        public int Incluir(TEntidade entidade)
        {
            return repository.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(int id)
        {
            return repository.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return repository.SelecionarTodos();
        }
    }
}

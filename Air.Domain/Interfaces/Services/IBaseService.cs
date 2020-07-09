using Air.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        int Incluir(TEntity entidade);
        void Excluir(int id);
        void Excluir(TEntity entidade);
        void Alterar(TEntity entidade);
        TEntity SelecionarPorId(int id);
        IEnumerable<TEntity> SelecionarTodos();
    }
}

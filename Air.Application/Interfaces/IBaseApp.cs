using Air.Application.DTO;
using Air.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Application.Interfaces
{
    public interface IBaseApp<TEntity, TEntityDTO>
        where TEntity : BaseEntity
        where TEntityDTO : BaseDTO
    {
        int Incluir(TEntityDTO entidade);
        void Excluir(int id);
        void Excluir(TEntityDTO entidade);
        void Alterar(TEntityDTO entidade);
        TEntityDTO SelecionarPorId(int id);
        IEnumerable<TEntityDTO> SelecionarTodos();
    }
}

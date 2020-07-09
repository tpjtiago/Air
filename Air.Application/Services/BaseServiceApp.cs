using Air.Application.DTO;
using Air.Application.Interfaces;
using Air.Domain.Entities;
using Air.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Application.Services
{
    public class BaseServiceApp<TEntity, TEntityDTO> : IBaseApp<TEntity, TEntityDTO>
           where TEntity : BaseEntity
           where TEntityDTO : BaseDTO
    {
        protected readonly IBaseService<TEntity> service;
        protected readonly IMapper iMapper;

        public BaseServiceApp(IMapper iMapper, IBaseService<TEntity> service)
            : base()
        {
            this.iMapper = iMapper;
            this.service = service;
        }

        public void Alterar(TEntityDTO entidade)
        {
            service.Alterar(iMapper.Map<TEntity>(entidade));
        }

        public void Excluir(int id)
        {
            service.Excluir(id);
        }

        public void Excluir(TEntityDTO entidade)
        {
            service.Excluir(iMapper.Map<TEntity>(entidade));
        }

        public int Incluir(TEntityDTO entidade)
        {
            return service.Incluir(iMapper.Map<TEntity>(entidade));
        }

        public TEntityDTO SelecionarPorId(int id)
        {
            return iMapper.Map<TEntityDTO>(service.SelecionarPorId(id));
        }

        public IEnumerable<TEntityDTO> SelecionarTodos()
        {
            return iMapper.Map<IEnumerable<TEntityDTO>>(service.SelecionarTodos());
        }
    }
}

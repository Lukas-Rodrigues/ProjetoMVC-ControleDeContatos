using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        public ContatoModel Adicionar(ContatoModel contato);
        public List<ContatoModel> BuscarTodos();
         ContatoModel Atualizar(ContatoModel contato);
         bool Apagar(int id);
    }
}
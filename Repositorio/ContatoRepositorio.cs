using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            //gravar no bd
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public bool Apagar(int id)
        {
              ContatoModel contatoDb = ListarPorId(id);
            if (contatoDb == null)
            {
                throw new Exception("Houve um erro na deleção de dados");
            }
            _bancoContext.Contatos.Remove(contatoDb);
            _bancoContext.SaveChanges();
            return true;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDb = ListarPorId(contato.Id);
            if (contatoDb == null)
            {
                throw new Exception("Houve um erro na atualização de dados");
            }
            else
            {
                contatoDb.Nome = contato.Nome;
                contatoDb.Email = contato.Email;
                contatoDb.Celular = contato.Celular;
                _bancoContext.Update(contatoDb);
                _bancoContext.SaveChanges();
                return contatoDb;
            }
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }
    }
}
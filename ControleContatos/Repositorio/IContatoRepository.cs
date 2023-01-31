using ControleContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleContatos.Repositorio
{
    public interface IContatoRepository
    {
        ContatoModel ListarPorID(int id);
        List<ContatoModel> ListaContatos(); 
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
        



    }
}

using ControleContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleContatos.Repositorio
{
    public interface IContatoRepository
    {
        List<ContatoModel> ListaContatos(); 
        ContatoModel Adicionar(ContatoModel contato);



    }
}

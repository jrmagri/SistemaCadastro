using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleContatos.Helper
{
    public interface IEmail
    {
        bool Enviar(string email, string assuntoEmail, string mensagem);
    }
}

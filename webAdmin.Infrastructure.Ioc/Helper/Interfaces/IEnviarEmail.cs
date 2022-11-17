using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAdmin.Infrastructure.Helper.Interfaces
{
    public interface IEnviarEmail
    {
        public bool Enviar(string email, string assunto, string mensagem);
    }
}

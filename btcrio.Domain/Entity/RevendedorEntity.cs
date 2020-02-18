using System;
using System.Collections.Generic;
using System.Text;

namespace btc.Domain.Entiity
{
    public class RevendedorEntity : BaseEntity
    {
        /// <summary>
        /// Nome completo do revendedor
        /// </summary>
        public string NomeCompleto { get; set; }
        /// <summary>
        /// Numero do CPF do revendedor
        /// </summary>
        public string CPF { get; set; }
        /// <summary>
        /// Endereço de e-mail e login do revendedor
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// senha do revendedor
        /// </summary>
        public string Senha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace btcrio.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage ="Email é campo obrigatório para login")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatória")]
        public string Senha { get; set; }
    }
}

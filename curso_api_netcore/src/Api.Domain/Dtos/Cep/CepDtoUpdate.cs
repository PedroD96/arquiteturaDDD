using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Cep
{
    public class CepDtoUpdate
    {
        [Required(ErrorMessage = "Id é campo obrigatorio")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Cep é campo obrigatorio")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Logradouro é campo obrigatorio")]
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        [Required(ErrorMessage = "Municipio é campo obrigatorio")]
        public Guid MunicipioId { get; set; }
    }
}

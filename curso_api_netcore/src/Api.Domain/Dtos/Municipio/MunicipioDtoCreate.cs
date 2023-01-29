using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Uf;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoCreate
    {
        [Required(ErrorMessage = "Nome de Municipio é campo obrigatorio")]
        [StringLength(60, ErrorMessage = "Nome de Municipio deve ter no maximo {0} caracteres.")]
        public string Nome { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Codigo do IBGE Invalidado")]
        public int CodIBGE { get; set; }

        [Required(ErrorMessage = "Codigo de UF é campo obrigatorio")]
        public Guid UfId { get; set; }
    }
}

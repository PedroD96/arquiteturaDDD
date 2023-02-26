using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Application.Controllers;
using Api.Domain.Dtos.Cep;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Interfaces.Services.Cep;
using Api.Domain.Interfaces.Services.Municipio;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Api.Application.Test.Cep.QuandoRequisitarUpdate
{
    public class Retorno_Created
    {
        private CepsController _controller;

        [Fact(DisplayName = "É possível Realizar o Updated")]
        public async Task E_Possivel_Invocar_a_Controller_Update()
        {
            var serviceMock = new Mock<ICepService>();
            serviceMock.Setup(m => m.Put(It.IsAny<CepDtoUpdate>())).ReturnsAsync(
                new CepDtoUpdateResult
                {
                    Id = Guid.NewGuid(),
                    Logradouro = "Teste de Rua",
                    UpdateAt = DateTime.UtcNow
                }
            );

            _controller = new CepsController(serviceMock.Object);

            var CepDtoUpdate = new CepDtoUpdate
            {
                Cep = "São Paulo",
                Logradouro = "Teste de Rua",
                Numero = "1"
            };

            var result = await _controller.Put(CepDtoUpdate);
            Assert.True(result is OkObjectResult);
        }
    }
}

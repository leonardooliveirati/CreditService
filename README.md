# Microserviço de Liberação de Crédito

Este é um microsserviço responsável por processar solicitações de crédito, aplicar regras de negócios relacionadas à liberação de crédito e retornar o resultado do processamento.

## Estrutura do Projeto

O projeto é estruturado da seguinte forma:

- **CreditService.API:** Este projeto contém os controladores da API para receber solicitações de crédito e outros endpoints relacionados.
- **CreditService.Infrastructure:** Este projeto contém implementações de infraestrutura, como repositórios de dados e serviços de acesso a dados.
- **CreditService.Domain:**  responsável pela implementação de classes/modelos, as quais serão mapeadas para o banco de dados, além de obter as declarações de interfaces, constantes, DTOs (Data Transfer Object) e enums..
- **CreditService.Service:** seria o “coração” do projeto, pois é nela que é feita todas as regras de negócio e todas as validações, antes de persistir os dados no banco de dados.
- **CreditService.Test:** Test-Driven Development (TDD) usando componente xunit

## Configuração e Execução

Para configurar e executar o projeto, siga estas etapas:

1. Certifique-se de ter o ambiente de desenvolvimento configurado corretamente, incluindo o SDK do .NET Core.
2. Clone este repositório em sua máquina local.
3. Abra o projeto em sua IDE favorita.
4. Atualize as configurações de conexão com banco de dados, se necessário, no arquivo `appsettings.json`.
5. Navegue até o diretório `CreditService.API` e execute o comando `dotnet run` para iniciar o serviço.
6. O serviço estará disponível em `https://localhost:7147`.

## Documentação da API

A documentação da API está disponível em `https://localhost:7147/swagger/index.html`, onde você pode encontrar informações sobre os endpoints disponíveis e como usá-los.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Autores

- [Leonardo Oliveira](https://github.com/leonardooliveirati/T)

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

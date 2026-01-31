## Sobre o projeto

Esta **API** foi desenvolvida utilizando **.NET 8 (LTS)** e adota os princípios do **Domain-Driven Design (DDD)** para fornecer uma solução organizada e escalável no gerenciamento de **Alunos** e **Escolas**. O principal objetivo da aplicação é permitir o cadastro, consulta, atualização e exclusão dessas entidades, mantendo uma clara separação de responsabilidades entre as camadas do sistema.

A arquitetura da **API** segue o padrão **REST**, utilizando métodos **HTTP** convencionais para garantir uma comunicação simples e eficiente entre cliente e servidor. A aplicação também conta com **documentação Swagger**, oferecendo uma interface interativa que facilita a visualização, o entendimento e o teste dos endpoints disponíveis.

Para controle de acesso, foi implementado um mecanismo de **autenticação baseada em JWT (JSON Web Token)**. A partir de um endpoint de login, é gerado um token que permite o acesso aos endpoints protegidos da aplicação, garantindo maior segurança e controle sobre as operações disponíveis.

Os dados são armazenados **em memória**, por meio de repositórios específicos, permitindo uma implementação simples e desacoplada, ao mesmo tempo em que prepara a aplicação para uma futura substituição por um banco de dados persistente, sem impacto nas camadas de domínio e aplicação.

---

### Features

- **Domain-Driven Design (DDD):** Estrutura modular com separação clara entre Domain, Application, Infrastructure e API.
- **Autenticação JWT:** Geração e validação de tokens para proteção dos endpoints.
- **CRUD de Alunos e Escolas:** Operações completas de criação, leitura, atualização e exclusão.
- **Armazenamento em memória:** Implementação de repositórios InMemory seguindo contratos do domínio.
- **RESTful API com Documentação Swagger:** Endpoints documentados e prontos para consumo e testes.
- **Testes unitários:** Cobertura da camada de aplicação utilizando mocks para garantir isolamento e confiabilidade.

---

### Construído com

![.NET Badge](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge)
![Windows](https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-007ACC?logo=visualstudiocode&logoColor=fff&style=for-the-badge)
![Swagger Badge](https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge)
![JWT Badge](https://img.shields.io/badge/JWT-000000?logo=jsonwebtokens&logoColor=fff&style=for-the-badge)

---

## Getting Started

Para obter uma cópia local funcionando, siga estes passos simples.

### Requisitos

- Visual Studio 2022+ ou Visual Studio Code
- Windows 10+ ou Linux/MacOS
- [.NET SDK 8.0](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)

---

### Instalação

1. Clone o repositório:

```sh
git clone https://github.com/seu-usuario/SchoolSystem.git

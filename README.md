## Projeto FullStack .NET
Este projeto foi desenvolvido ao longo da série de aulas da jornada FullStack da plataforma Balta.io.

### Estrutura do Projeto
O projeto é dividido em três componentes principais:

1. API
   - Descrição: Contém toda a lógica de back-end da aplicação, implementada utilizando Minimal APIs do .NET. 
   - Funcionalidades: Gerencia todas as requisições do front-end, realiza operações CRUD e lida com autenticação e autorização.

2. Core
   - Descrição: Abriga a lógica central da aplicação.
   - Funcionalidades: Contém as entidades e interfaces necessárias para a comunicação entre a API e a camada de dados.

3. Web
   - Descrição: Desenvolvida utilizando Blazor, esta parte do projeto representa a interface do usuário (front-end) da aplicação. 
   - Funcionalidades: Inclui todos os componentes da interface do usuário, gerenciamento de estado e interações com a API.
   
### Tecnologias Utilizadas
   - .NET 8: Framework para desenvolvimento de aplicações web.
   - Minimal APIs: Abordagem simplificada para criar APIs RESTful.
   - Blazor: Framework para construção de interfaces de usuário interativas em C#.
   - MudBlazor: Biblioteca de componentes para facilitar a criação das interfaces.
   - EF Core: Para acesso e manipulação de dados.
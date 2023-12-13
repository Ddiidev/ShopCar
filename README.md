
# ShopCar


## Funcionalidades

- CRUD complete de veículos
- Fazer login na api
- Configuração do banco de dados, através de arquivo 'conf.json';


## Demonstração



## Especificações

- Foi utilizado o NewtonSoft.Json para parsear o json vindo da api, pois ele tem uma melhor praticidade em comparação com o padrão da microsoft(System.Text);

- Para gerenciamento do banco, utilizei o Dapper, pois consigo criar as consultas manualmente e só iria precisar de uma biblioteca para fazer o mapeamento, e fica menos sobrecarregado de um EntityFramework, Dapper é leve e rápido.

- Desenvolvi as interfaces em camadas, dessa forma consigo dividir as responsabilidades de uma melhor forma ao invés de adicionar toda a regra no formulário principal, ou criar vários formulários.

- Nesse projeto foi utilizado .NET 6, apenas por praticidade pra quem irá testar, mas fiz alguns testes com .NET 8 e funcionou perfeitamente também.

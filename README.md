
# ShopCar


## Funcionalidades

- CRUD complete de veículos
- Fazer login na api
- Configuração do banco de dados, através de arquivo 'conf.json';


## Demonstração

### Tela de Login
![login](https://github.com/ldedev/ShopCar/assets/7676415/eaaa1efc-36f7-4043-94f5-f71f3adccbd5)

### Listagem de veículos

![lista-veiculos](https://github.com/ldedev/ShopCar/assets/7676415/b936cc3d-6716-4435-a6ec-0868b5dbb517)

### Busca de veículos

![lista-veiculo-busca](https://github.com/ldedev/ShopCar/assets/7676415/8500959c-b915-4390-9984-5cc3948a0d87)

### Editar veículos

![editar-veiculo](https://github.com/ldedev/ShopCar/assets/7676415/8e645dd6-0084-4f12-a5f5-27c26e7f4111)

### Deletando um Veículo

![delete-veiculo](https://github.com/ldedev/ShopCar/assets/7676415/8e1137b0-6af4-431c-aca2-ef5294396737)


## Especificações

- Desenvolvi as interfaces em camadas, dessa forma consigo dividir as responsabilidades de uma melhor forma ao invés de adicionar toda a regra no formulário principal, ou criar vários formulários.

- Implementei a api em uma biblioteca separada, para demonstrar que dessa forma, poderia criar uma outra biblioteca apontando pra outro endpoint e a aplicação host não sentiria efeitos colaterais além disso fica fácil de criar testes e manter rastreabilidade.

- Implementei um teste de unidade para api, ele é básico pois não conheço todos os caminhos possíveis da api.

- Foi utilizado o NewtonSoft.Json para parsear o json vindo da api, pois ele tem uma melhor praticidade em comparação com o padrão da microsoft(System.Text);

- Para gerenciamento do banco, utilizei o Dapper, pois consigo criar as consultas manualmente e só iria precisar de uma biblioteca para fazer o mapeamento, e fica menos sobrecarregado de um EntityFramework, Dapper é leve e rápido.

- Nesse projeto foi utilizado .NET 6, apenas por praticidade pra quem irá testar, mas fiz alguns testes com .NET 8 e funcionou perfeitamente também.

Padrão CQRS (Command Query Responsibility Segregation)
O padrão CQRS (Command Query Responsibility Segregation) é um padrão arquitetural que propõe a separação das operações de leitura (queries) das operações de escrita (commands) em um sistema. Ele divide a responsabilidade de operações de leitura e operações de escrita, permitindo que sejam otimizadas separadamente.

Comandos (Commands)
Comandos representam as operações de escrita no sistema. Eles são responsáveis por alterar o estado do sistema. Ao enviar um comando, o sistema executa a ação correspondente, que pode incluir a criação, atualização ou exclusão de dados.

Consultas (Queries)
Consultas representam as operações de leitura no sistema. Elas são responsáveis por recuperar dados do sistema sem modificar seu estado. Ao enviar uma consulta, o sistema retorna os dados solicitados sem realizar alterações.

Padrão Mediator
O padrão Mediator é um padrão comportamental que permite o acoplamento fraco entre objetos, encapsulando como esses objetos interagem e eliminando a necessidade desses objetos se comunicarem diretamente entre si. Ele ajuda a reduzir a complexidade geral do sistema ao promover a comunicação entre componentes por meio de um objeto intermediário, conhecido como mediador.

Biblioteca MediatR
O MediatR é uma biblioteca para o padrão Mediator e é comumente usada em conjunto com o padrão CQRS. Ele facilita a implementação da comunicação entre comandos, manipuladores de comandos, consultas e manipuladores de consultas em um sistema. Ao utilizar o MediatR, é possível implementar o desacoplamento entre componentes, tornando o sistema mais modular e fácil de manter.

Esses padrões e bibliotecas são frequentemente utilizados em sistemas complexos para melhorar a organização e a manutenibilidade do código, além de promover a escalabilidade e a eficiência no desenvolvimento de software.
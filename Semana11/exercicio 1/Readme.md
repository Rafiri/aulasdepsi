# Comparação entre SGDB Relacional e SGBD Não-Relacional 
## Modelo de dados:

#### Relacional: 
Utiliza um modelo de dados tabular com linhas e colunas interconectadas por chaves primárias e estrangeiras.
#### Não-relacional:
Suporta uma variedade de modelos de dados, como documentos, chave-valor, colunas e grafos, oferecendo maior flexibilidade na modelagem dos dados.
## Estrutura de armazenamento:

#### Relacional:
Armazena dados em tabelas relacionadas.
#### Não-relacional: 
Pode armazenar dados de diferentes maneiras, dependendo do modelo de dados escolhido, como documentos, pares chave-valor, colunas ou grafos.
## Escalabilidade:

#### Relacional:
Escala verticalmente, adicionando mais recursos (CPU, memória, etc.) a um único servidor.
#### Não-relacional:
Escala horizontalmente, distribuindo os dados em vários nós ou servidores, permitindo lidar com grandes volumes de dados e carga de trabalho.
## Esquema:

#### Relacional: 
Possui um esquema rígido definido com antecedência, onde a estrutura das tabelas e as relações entre elas são especificadas.
#### Não-relacional:
Geralmente possui um esquema flexível, onde os esquemas podem ser adicionados, modificados ou removidos conforme necessário, sem interromper a operação do sistema.
## Consistência:

#### Relacional:
Prioriza a consistência imediata, garantindo que todas as transações mantenham a integridade dos dados.
#### Não-relacional:
Muitos SGBDs não-relacionais priorizam a consistência eventual, o que significa que pode haver um atraso entre a gravação e a leitura dos dados consistentes em todas as réplicas.
## Consultas:

#### Relacional:
Utiliza a linguagem SQL para consultar os dados, com consultas estruturadas e declarativas.
#### Não-relacional:
Oferece diferentes mecanismos de consulta, dependendo do modelo de dados escolhido, como consultas baseadas em documentos, chaves, padrões de grafos, etc.
## Disponibilidade e Tolerância a Falhas:

#### Relacional:
Geralmente requer configurações complexas para garantir alta disponibilidade e tolerância a falhas.
#### Não-relacional:
Muitos SGBDs não-relacionais são projetados para fornecer alta disponibilidade e tolerância a falhas, utilizando técnicas como replicação de dados, particionamento e detecção de falhas automáticas.

# SGBD Orientado a Objetos:
## Modelo de Dados: 
Utiliza um modelo de dados baseado em objetos, onde os dados são representados como objetos que contêm atributos e métodos.
## Estrutura de Dados: 
Os dados são armazenados como objetos diretamente no banco de dados, mantendo as relações de herança e agregação entre eles.
#### SGBD Relacional:
#### Modelo de Dados:
Utiliza um modelo de dados tabular com linhas e colunas interconectadas por chaves primárias e estrangeiras.
#### Estrutura de Dados:
Os dados são armazenados em tabelas relacionadas, seguindo um esquema rígido definido com antecedência.
## Linguagem de Consulta (Query) Usada:

#### SGBD Orientado a Objetos:
Utiliza uma linguagem de consulta orientada a objetos, como OQL (Object Query Language) ou Java Persistence Query Language (JPQL), que permitem consultar e manipular objetos diretamente.
#### SGBD Relacional:
Utiliza a linguagem SQL (Structured Query Language) para consultar e manipular os dados, com consultas estruturadas e declarativas.
Escalabilidade e Desempenho:

#### SGBD Orientado a Objetos:
Pode ser escalável horizontalmente, mas a escalabilidade pode ser limitada devido à complexidade de mapeamento entre objetos e bancos de dados relacionais subjacentes.
O desempenho pode ser afetado se o mapeamento entre objetos e tabelas não for otimizado.
#### SGBD Relacional:
Geralmente escalável verticalmente, adicionando mais recursos (CPU, memória, etc.) a um único servidor.
O desempenho pode ser otimizado com o uso adequado de índices, consultas eficientes e ajuste fino do esquema.
## Casos de Aplicações no Mundo Real:

#### SGBD Orientado a Objetos:

#### Medicina: Sistemas de gerenciamento de registros médicos eletrônicos, onde os dados do paciente são representados como objetos com atributos como nome, idade, histórico médico, etc.
#### Finanças: Sistemas de gestão de investimentos, onde os ativos financeiros e suas relações são modelados como objetos.
#### E-commerce: Plataformas de comércio eletrônico que lidam com catálogos de produtos, carrinhos de compras e pedidos como objetos.
#### Redes Sociais: Aplicações que gerenciam perfis de usuário, conexões entre usuários e conteúdo compartilhado como objetos.
#### SGBD Relacional:

#### Medicina:
Sistemas de gestão de hospitais que mantêm registros de pacientes, médicos e tratamentos em tabelas relacionais.
#### Finanças:
Bancos e instituições financeiras que gerenciam contas de clientes, transações e históricos de transações em bancos de dados relacionais.
#### E-commerce:
Plataformas de comércio eletrônico que mantêm informações de produtos, pedidos e clientes em tabelas relacionais.
#### Redes Sociais:
Aplicações que armazenam perfis de usuário, conexões de amizade e postagens em tabelas relacionais.

# SGBD em Memória:
#### Modelo de Dados:
O modelo de dados pode variar, mas geralmente é otimizado para armazenar e manipular dados na memória RAM de forma eficiente.
#### Estrutura de Dados: 
Os dados são armazenados diretamente na memória principal, geralmente em estruturas de dados como arrays, hash maps ou árvores, para acesso rápido.
#### SGBD Relacional:
#### Modelo de Dados:
Utiliza um modelo de dados tabular com linhas e colunas interconectadas por chaves primárias e estrangeiras.
#### Estrutura de Dados:
Os dados são armazenados em tabelas relacionadas, geralmente em disco, embora em alguns casos possam ser mantidos em cache na memória.
## Linguagem de Consulta (Query) Usada:

#### SGBD em Memória:
Pode usar uma linguagem de consulta SQL para acesso a dados, semelhante aos SGBDs relacionais tradicionais.
#### SGBD Relacional:
Utiliza a linguagem SQL para consultar e manipular os dados, com consultas estruturadas e declarativas.
#### Escalabilidade e Desempenho:

#### SGBD em Memória:
Geralmente oferece desempenho superior devido ao acesso direto aos dados na memória principal, sem a necessidade de E/S de disco.
A escalabilidade pode ser limitada pela quantidade de memória disponível em um único servidor, embora a distribuição de carga possa ser alcançada com o uso de clusters ou caches distribuídos.
#### SGBD Relacional:
Geralmente tem desempenho mais lento em comparação com SGBDs em memória, devido à necessidade de acessar dados em disco.
A escalabilidade é geralmente alcançada escalando horizontalmente com replicação de dados e particionamento.
#### Casos de Aplicações no Mundo Real:

#### SGBD em Memória:
Análise de dados em tempo real: Aplicações que exigem processamento rápido de grandes volumes de dados, como análise de streaming e detecção de fraudes financeiras.
Sistemas de gerenciamento de sessões: Aplicações da web que precisam armazenar temporariamente dados da sessão do usuário para fornecer uma experiência personalizada.
#### SGBD Relacional:
Sistemas de gerenciamento de banco de dados tradicionais: Aplicações que exigem persistência de dados, integridade transacional e conformidade com padrões de negócios.
Aplicações de back-office: Sistemas empresariais que mantêm registros de clientes, transações financeiras e estoque.
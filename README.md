# design-patterns-sample-solid
Design Patters Exemplos conceitos SOLID


## Single Reponsability Principle (Princípio de Responsabilidade Única)

 - Uma classe deve ter apenas uma única razão para mudar
 - Separação de preocupações - diferentes classes lidam com diferentes aspectos independentes do sistema, lidam com diferentes tarefas e resolvem diferentes problemas.

## Open-Closed Principle (Princípio aberto e fechado)

 - As classes devem ser abertas para extensão, mas fechadas para modificações

## Liskov Substition Principle (Princípio de Substituição de Liskov)

 - Substituir um tipo de base por um subtipo, porque o design orientado a objetos exige que você possa classificar um descendente para sua base e armazenamento em uma variável fora da base e ainda deve funcionar corretamente. 

## Interface Segragation Principle (Princípio de Segregação de Interfaces)

 - Não se deve colocar muita responsabilidade em uma interface, pois isso forçará os implementadores dessa interface, implementar coisas que não serão necessárias
 - YAGNI = You Ain't Going to Need It
 - Basicamente, não colocar código que você realmente não precisa fazer nada, e é isso que uma interface que é muito grande obriga as pessoas a implementar.

## Dependency Inversion Principle (Princípio de Inversão de Dependência)

 - Os módulos de alto nível não devem depender de módulos de baixo nível
 - Deve usar abstrações sempre que possível
 -  Não expor os detalhes da implementação (não diretamente)
 - Capacidade de alterar as partes internas do sistema sem alterar a interface de exposição. 

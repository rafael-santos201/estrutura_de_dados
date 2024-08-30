# Estrutura de Dados: Pilha

## Visão Geral

Uma **Pilha** é uma estrutura de dados que segue o princípio LIFO (*Last In, First Out*), que significa "Último a Entrar, Primeiro a Sair". Isso quer dizer que o último elemento adicionado à pilha será o primeiro a ser removido. Imagine uma pilha de pratos: quando você coloca um prato em cima de uma pilha, ele será o primeiro a ser retirado se você começar a remover os pratos a partir do topo.

## Funcionamento

### Operação `push()`
- **Descrição**: A operação `push()` é responsável por adicionar um novo elemento no topo da pilha. Se imaginarmos a pilha como uma lista de itens, `push()` coloca o novo elemento no final dessa lista.

### Operação `pop()`
- **Descrição**: A operação `pop()` remove o elemento que está no topo da pilha. Como a pilha segue a lógica LIFO, o elemento removido será sempre o que foi adicionado mais recentemente. Se a pilha estiver vazia, a operação `pop()` geralmente retorna um erro ou um valor especial indicando que não há elementos para remover.

### Operação `mostrar()`
- **Descrição**: A operação `mostrar()` permite visualizar o elemento que está no topo da pilha sem removê-lo. Isso é útil quando você precisa saber qual é o próximo elemento que será removido, mas ainda não quer efetuar a remoção.

### Operação `isEmpty()`
- **Descrição**: A operação `isEmpty()` verifica se a pilha está vazia. Isso é importante para evitar erros ao tentar remover elementos de uma pilha que não possui nenhum item.

## Como uma Pilha Funciona na Prática

Imagine que você está trabalhando com uma pilha de documentos. Você começa com uma pilha vazia:

1. Você adiciona o documento A. Agora, o documento A está no topo.
2. Você adiciona o documento B. B está no topo, e A está logo abaixo.
3. Você adiciona o documento C. C está no topo, seguido por B e depois A.

Se agora você quiser remover um documento da pilha, o documento C será removido primeiro, pois ele foi o último a entrar (LIFO). Se você remover outro documento, o documento B será removido. Finalmente, ao remover mais um documento, o documento A será retirado.

Se você tentar remover um documento de uma pilha vazia, poderá encontrar uma situação onde a operação falha, uma vez que não há nada para remover. Por isso, é importante verificar se a pilha está vazia antes de tentar realizar a operação de remoção.

## Aplicações Comuns

As pilhas são amplamente utilizadas em várias áreas da computação:

1. **Recursão**: Em muitas linguagens de programação, as chamadas recursivas utilizam uma pilha para rastrear as funções chamadas e seus contextos. Cada chamada de função é empilhada até que a função termine, momento em que é desempilhada.

2. **Análise de Expressões**: Em compiladores e interpretadores, as pilhas são usadas para avaliar expressões aritméticas e para converter expressões de uma notação para outra (por exemplo, de infix para postfix).

3. **Navegação na Web**: A funcionalidade de "voltar" nos navegadores é geralmente implementada com uma pilha, onde cada URL visitada é empilhada. Quando você clica no botão de voltar, a URL atual é removida da pilha, e a URL anterior é carregada.

## Vantagens e Desvantagens

### Vantagens:
- **Simplicidade**: As pilhas são simples de entender e implementar.
- **Eficiência**: As operações de adicionar e remover são rápidas, pois acontecem apenas no topo da pilha.

### Desvantagens:
- **Acesso Restrito**: Você só pode acessar o elemento no topo da pilha diretamente. Para acessar outros elementos, você precisa removê-los um a um até chegar ao que deseja.
- **Não Ideal para Todos os Problemas**: Para situações onde é necessário acessar ou modificar elementos que não estão no topo, outras estruturas de dados como listas ou filas podem ser mais adequadas.

## Conclusão

A **Pilha** é uma estrutura de dados essencial que tem várias aplicações práticas na ciência da computação. Sua simplicidade e eficiência a tornam uma escolha ideal para cenários onde o acesso aos elementos é necessário de maneira LIFO.

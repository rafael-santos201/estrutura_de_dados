//  NESSE CODIGO EU IREI COLOCAR A CLASSE PILHA JUNTO COM A CLASSE MAIN
//  APENAS POR SER UM EXEMPLO DE UMA IMPLEMENTAÇÃO DE PILHA
//  QUANDO O CORRETO SERIA A PILHA ESTAR EM UMA CLASSE SEPARADA DA MAIN    
using System;
using System.Runtime;

public class Pilha
{
    private int[] elementos;
    private int top;
    private int total;

    public Pilha(int total)
    {
        this.total = total;
        elementos = new int[total];
        top = -1;
    }

    //criando metodos push(enviar para a pilha) e pop(retirar elemento no topo da pilha)

    //metodo push
    public void push(int numero)
    {
        //verificando se a pilha ainda tem espaço;
        if(top == total-1){Console.WriteLine("\n\n#####Pilha Cheia#####"); return;}
        elementos[++top] = numero;
    }
        
    //metodo pop
    public int pop()
    {
        if(top == -1){Console.WriteLine("\n\n#####pilha vazia#####"); return -1;}
        return elementos[top--];
    }

    //criando metodos isEmpty(verificar se o vetor está vazio) e isFull(verificar se o vetor está cheio)

    //verifica se o vetor está cheio
    public bool isFull()
    {
        return top == total - 1;
    }
    //verifica se o vetor está vazio
    public bool isEmpty()
    {
        return (top == -1);
    }

    //metodo para mostrar o elemento que está no topo da pilha 
    public int show()
    {
        return elementos[top];
    }
}



//  CLASSE PRINCIPAL    
class Principal
{
    public static void Main(string[] args)
    {
        //recebedo o tamanho da pilha e criando ela 
        Console.Write("\n\nDigite o tamanhoda pilha: ");
        int tamanho_da_pilha = int.Parse(Console.ReadLine());
        Pilha pilha1 = new Pilha(tamanho_da_pilha);

        int escolha = 0;
        while(escolha == 0)
        {
            Console.WriteLine("\n\n[1]Adicionar um item a pilha\n[2]Retirar item do topo\n[3]Ver item do topo");
            int opcao = int.Parse(Console.ReadLine());

                if(opcao == 1)
                {
                    Console.WriteLine("\n\nQual valor a ser adicionado: ");
                    int valor_adicionado = int.Parse(Console.ReadLine());
                    
                    pilha1.push(valor_adicionado);
                }else if(opcao == 2)
                {
                    int topo = pilha1.show();
                    pilha1.pop();
                    Console.WriteLine($"elemento {topo} removido");
                }
                
                else if(opcao == 3)
                {
                    Console.WriteLine($"\n\nElemento no topo: {pilha1.show()}");
                }
        }

    }
}

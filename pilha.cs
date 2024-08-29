//  NESSE CODIGO EU IREI COLOCAR A CLASSE PILHA JUNTO COM A CLASSE MAIN
//  APENAS POR SER UM EXEMPLO DE UMA IMPLEMENTAÇÃO DE PILHA
//  QUANDO O CORRETO SERIA A PILHA ESTAR EM UMA CLASSE SEPARADA DA MAIN    
using System;
using System.Runtime;

public class pilha
{
    private int[] elementos;
    private int top;
    private int total;

    public pilha(int total)
    {
        this.total = total;
        elementos = new int[total];
        top = -1;
    }

    //criando metodos push(enviar para a pilha) e pop(retirar elemento no topo da pilha)

    //metodo push
    public void push(int numero)
    {
        elementos[++top] = numero;
    }
        
    //metodo pop
    public int pop()
    {
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


class principal
{
    public static void Main(string[] args)
    {
        pilha teste1 = new pilha(10);

        teste1.push(25);
        teste1.push(24);
        teste1.push(23);
        teste1.push(22);
        teste1.push(21);
        teste1.push(20);
        teste1.push(19);
        Console.WriteLine($"O Elemnto que está no topo é: {teste1.show()}");
        teste1.pop();

        Console.WriteLine($"O Elemnto que está no topo é: {teste1.show()}");
        Console.WriteLine($"A pilha está cheia: {teste1.isFull()}");
        Console.WriteLine($"A pilha está vazia: {teste1.isEmpty()}");
    }
}

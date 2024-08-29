
using System;
using System.Runtime;

public class pilha
{
    private int[] elementos;
    private int top;
    private int total;

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
}



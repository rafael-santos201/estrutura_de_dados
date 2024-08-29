
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

}



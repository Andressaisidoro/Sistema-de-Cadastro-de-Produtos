using System;

using System.Collections.Generic;

class Program

    static List<Produto> produtos = new List<Produto>();
    static int proximoId = 1;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Sistema de Cadastro de Produtos");
            Console.WriteLine("1. Adicionar Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Buscar Produto por ID");
            Console.WriteLine("4. Sair");
            Console.Write("Selecione uma opção:");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1";
                AdicionarProduto:();
                break;
                case "2";
                ListarProdutos:();
                break;
                case "3";
                BuscarProduto:();
                break;
                case "4";
                return;
                default:
                Console.WriteLine("Esta opção não existe.");
                break;

            }
            Console.WriteLine();
        }
    }
    static void AdicionarProduto()
    {
        Console.Write("Digite o nome do produto");
        string nome = Console.ReadLine();
        Console.Write("Digite o preço do produto");
        decimal preco = decimal.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade do produto:");
        int quantidade = int.Parse(Console.ReadLine());

        produto novoProduto = new Produto
        {
            Id = proximoId++,
            Nome = nome,
            Preco = preco,
            Quantidade = quantidade,
        };
        produtos.Add(novoProduto);

        Console.WriteLine("Produto adicionado com sucesso!");

    }
    static void ListarProdutos()
    {
        Console.WriteLine("Lista de Produtos:");
        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.Quantidade}");

        }
    }
    static void BuscarProduto()
    {
        Console.Write("Digite o ID do produto:");
        int id = int.Parse(Console.ReadLine());
       Produto produto = produtos.Find(p => p.Id == id);

        if (produto != null)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.Quantidade}");
        }
        else
        {
            Console.WriteLine("Este produto não existe.");

        }
    }
    static void AtualizarProduto()
    {
        Console.Write("Digite o ID do produto para ser atualizado:");
        int id = int.Parse(Console.ReadLine());
        Produto produto = produtos.Find(p => p.Id == id);

       if (produto != null)
        {
            Console.Write("Digite o novo nome do Produto");
            string nome = Console.ReadLine();
            if (!string.IsNullOrEmpty(nome))
            {
                produto.Nome = nome;
            }
            Console.Write("Digite o novo preço do produto");
            string precoInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(precoInput))
            {
                produto.Preco = decimal.Parse(precoInput);

            }
            Console.Write("Digite a nova quantidade de produto");
            string quantidadeInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(quantidadeInput))
            {
                produto.Quantidade = int.Parse(quantidadeInput);
            }
            Console.WriteLine("O produto foi atualizado!")

        }
        else
        {
            Console.WriteLine("Produto não encontrado.");

        }
    }
    static void DeletarProduto()
    
        Console.Write("Digite o ID do produto que deseja deletar:");
        int id = int.Parse(Console.ReadLine);
        Produto produto = produtos.Find( p => p.Id == id);

       if (produto != null)
        {
        {
            produtos.Remove(produto);
            Console.WriteLine("Produto deletado com sucesso!");
        }
        else
         Console.WriteLine("Produto não encontrado.");
        {
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2Aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
            int op;
            int[,] poltronas = new int[12, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 },
                   { 17, 18, 19, 20 }, { 21, 22, 23, 24 }, { 25, 26, 27, 28 }, { 29, 30, 31, 32 }, { 33, 34, 35, 36 },
                   { 37, 38, 39, 40 }, { 41, 42, 43, 44 }, { 45, 46, 47, 48 } };

            int[,] poltronas2 = new int[12, 4];

        inicio:
            //CASE MENU
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Bem-vindo ao sistema DELLAI!");
            Console.WriteLine("Clique qualquer coisa para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("1 - Inserir Poltrona:"); //feito
            Console.WriteLine("2 - Alterar Poltrona:");
            Console.WriteLine("3 - Listar Poltrona:");//feito
            Console.WriteLine("4 - Buscar Poltrona:");//feito
            Console.WriteLine("5 - Liberar Poltrona:");//feito
            Console.WriteLine("6 - Sair:");//feito
            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (op)
            {
                case 1: //inserir poltronas
                    Console.WriteLine("LIBERAR POLTRONA");
                    Console.Write("Informe a poltrona que deseja ocupar: ");
                    int n_ocupar = Convert.ToInt32(Console.ReadLine()); //ler a número da poltrona que vai liberar

                    for (int i = 0; i < 12; i++) //começa a loop pra ver todas as poltronas da primeira coluna
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (n_ocupar == poltronas[i, j]) //se o número da poltrona for igual ao buscado pelo loop, ele irá perguntar
                            {
                                Console.WriteLine("deseja liberar a poltrona " + n_ocupar + " ?");
                                Console.Write("Digite 1 para sim 0 para não");
                                int op_ocupar = Convert.ToInt32(Console.ReadLine());

                                if (op_ocupar == 1) //selecionado para liberar a poltrona 
                                {
                                    for (int l = 0; l < 12; l++) //troquei as variaveis inteiras para o loop, depois vê se está certo
                                    {
                                        for (int p = 0; p < 4; p++)
                                        {
                                            if (n_ocupar == poltronas[i, j]) //se a poltrona que deseja liberar for igual ao número encontrado pelo loop da matriz...
                                                                             //A poltrona assumirá valor 0 (valor de vazio) na matriz "poltronas2"
                                            {
                                                poltronas2[i, j] = 1;
                                                Console.WriteLine("a poltrona " + n_ocupar + " foi Ocupada.");



                                            }
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    goto inicio;

                case 2://alterar poltronas
                    for (int i = 0; i < 46; i++)
                    {
                        for (int j = 0; j < 46; j++)
                        {
                            poltronas = poltronas2;
                            Console.WriteLine("Digite o número da poltrona que deseja trocar: ");
                            poltronas2[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    goto inicio;

                case 3://listar poltronas
                    for (int i = 0; i < 12; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine("Listagem de poltronas do ônibus");
                            Console.WriteLine("A poltrona " + poltronas[i, j] + "está com situação " + poltronas2[i, j]);
                            //Situação e listagem da poltrona
                        }
                    }
                    goto inicio;

                case 4://buscar poltronas
                    Console.WriteLine("BUSCAR POLTRONA");
                    Console.WriteLine("Informe a poltrona:");

                    int buscar_poltrona = Convert.ToInt32(Console.ReadLine()); //lê o número da poltrona digitada
                    for (int i = 0; i < 12; i++) //começa a loop pra ver todas as poltronas da primeira coluna
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (buscar_poltrona == poltronas[i, j]) //se o número da poltrona for igual ao buscado pelo loop, ele irá informar
                            {
                                Console.WriteLine("a poltrona " + buscar_poltrona + " está com a situação " + poltronas2[i, j]);
                            }
                        }
                    }
                    goto inicio;

                case 5://liberar poltrona
                    Console.WriteLine("LIBERAR POLTRONA");
                    Console.Write("Informe a poltrona que deseja liberar: ");
                    int n_liberar = Convert.ToInt32(Console.ReadLine()); //ler a número da poltrona que vai liberar

                    for (int i = 0; i < 12; i++) //começa a loop pra ver todas as poltronas da primeira coluna
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (n_liberar == poltronas[i, j]) //se o número da poltrona for igual ao buscado pelo loop, ele irá peruntar
                            {
                                Console.WriteLine("deseja liberar a poltrona " + n_liberar + " ?");
                                Console.Write("Digite 1 para sim 0 para não");
                                int op_liberar = Convert.ToInt32(Console.ReadLine());

                                if (op_liberar == 1) //selecionado para liberar a poltrona 
                                {
                                    for (int l = 0; l < 12; l++) //troquei as variaveis inteiras para o loop, depois vê se está certo
                                    {
                                        for (int p = 0; p < 4; p++)
                                        {
                                            if (n_liberar == poltronas[i, j]) //se a poltrona que deseja liberar for igual ao número encontrado pelo loop da matriz...
                                                                              //A poltrona assumirá valor 0 (valor de vazio) na matriz "poltronas2"
                                            {
                                                poltronas2[i, j] = 0;
                                                Console.WriteLine("a poltrona " + n_liberar + " foi liberada para uso.");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    goto inicio;

                case 6:
                    Console.WriteLine("Você saiu do Sistema DELLAI");

                    break;
            }

            Console.ReadKey();
        }//fim
    }
}
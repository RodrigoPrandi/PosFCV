using PosDesignPatternsFCV.FactoryMethod;
using PosDesignPatternsFCV.FactoryMethod.Desafio;
using PosDesignPatternsFCV.FactoryMethod.Exemplo_2;
using PosDesignPatternsFCV.FactoryMethod.Exemplo1;
using PosDesignPatternsFCV.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV
{
    public class Program
    {
        // Professor: 
        // Email: prof_jose@fcv.edu.br
        static void Main(string[] args)
        {
            TestarSingleton();
            Console.WriteLine();
            TestarFactoryMethod1();
            Console.WriteLine();
            TestarFactoryMethod2();
            Console.WriteLine();
            TestarFactoryMethodDesafio();

            Console.ReadLine();
        }

        private static void TestarSingleton()
        {
            Console.WriteLine("### Singleton");

            Conexao conexao1 = Conexao.GetInstance();
            Conexao conexao2 = Conexao.GetInstance();

            if (conexao1 == conexao2)
                Console.WriteLine("Conexoes Iguais");
            else
                Console.WriteLine("Conexoes Diferentes");
        }

        private static void TestarFactoryMethod1()
        {
            Console.WriteLine("### FactoryMethod 1");

            IMoto moto;
            moto = FabricaMotos.Fabricar(MotoEnum.CG150);
            Console.WriteLine(moto.ExibirModelo());

            moto = FabricaMotos.Fabricar(MotoEnum.YBR);
            Console.WriteLine(moto.ExibirModelo());

            moto = FabricaMotos.Fabricar(MotoEnum.Ninja250);
            Console.WriteLine(moto.ExibirModelo());

            moto = FabricaMotos.Fabricar(MotoEnum.F800);
            Console.WriteLine(moto.ExibirModelo());
        }

        private static void TestarFactoryMethod2()
        {
            Console.WriteLine("### FactoryMethod 2");

            List<Fabrica> listaFabrica = new List<Fabrica>();
            listaFabrica.Add(new FabricaCG());
            listaFabrica.Add(new FabricaF800());
            listaFabrica.Add(new FabricarNinja());
            listaFabrica.Add(new FabricarYBR());

            foreach (var fabrica in listaFabrica)
            {
                IMoto moto = fabrica.FabricarMoto();
                moto.ExibirModelo();
                Console.WriteLine(moto.ExibirModelo());
            }
        }

        private static void TestarFactoryMethodDesafio()
        {
            Console.WriteLine("### FactoryMethod Desafio");

            Cozinheiro cozinheiro = new Pizzaiolo();
            Console.WriteLine(cozinheiro.CriarComida().Sabor());

            cozinheiro = new Churrasqueiro();
            Console.WriteLine(cozinheiro.CriarComida().Sabor());
        }
    }
}

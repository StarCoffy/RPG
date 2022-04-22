using System;
namespace Lenda_do_heroi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atributos BrokenSwordStatus = new Atributos(0, 10, 0, 0, 20);
            Atributos ArcoComumStatus = new Atributos(0, 20, 0, 0, 5);
            Atributos CapaceteDCavaleiroatributos = new Atributos(10, 0, 10, 0, -5);

            Consumivel poçãodecuraP = new Consumivel("Poção de cura P", "cura",50);
            Consumivel poçãodemanaP = new Consumivel("Poção de Mana P", "mana", 50);

            Armas BrokenSword = new Armas("Broken Sword", BrokenSwordStatus,"Guerreiro");
            Armas Arco = new Armas("Arco comum",ArcoComumStatus,"Arqueiro");
            armadura capaceteDcavaleiro = new armadura("Capacete de Cavaleiro(metal)","cabeca","Guerreiro", CapaceteDCavaleiroatributos);

            Magias boladefogo = new Magias("Bola de fogo", 200,"Mago");
            Console.WriteLine("Welcome challenger!\nChoose your class!:\n1-Warrior\n2-Archer\n");
            int escolha = (Int32.Parse(Console.ReadLine()));
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Qual seu nome Guerreira?\n");
                    string nome = Console.ReadLine();
                    
                    Guerreiro Warrior = new Guerreiro(nome, 18);

                    Monstro goblin = criarGoblin(Warrior.getLv());
                    Monstro Smoug = criarDragao("Smoug", Warrior.getLv());


                    Warrior.colocar(poçãodecuraP);
                    Warrior.colocar(poçãodecuraP);
                    Warrior.colocar(BrokenSword);
                    Warrior.equiparArma(BrokenSword);
                   
                    goblin.recebeDano(Warrior);
                    Warrior.recebeDano(goblin);
                    Warrior.MostraStatus();
                    Warrior.consumir(poçãodecuraP);
                    Warrior.consumir(poçãodecuraP);
                    goblin.MostraStatus();
                    Warrior.MostraStatus();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Qual seu nome Arqueira?\n");
                    string ArcherName = Console.ReadLine();

                    Arqueiro Archer = new Arqueiro(ArcherName, 18,100);
                    Archer.MostraStatus();
                    Console.ReadLine();

                    Goblin goblin2 = new Goblin(1);

                

                    goblin2.recebeDano(Archer);
                    goblin2.MostraStatus();
                    Archer.MostraStatus();

                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Qual seu nome Mago?\n");
                    string MageName = Console.ReadLine();

                    Mago Mage = new Mago(MageName, 18);
                    Mage.MostraStatus();
                    Console.ReadLine();

                    Goblin goblin3 = new Goblin(1);

                  

                    goblin3.recebeDano(Mage,boladefogo);
                    Mage.recebeDano(goblin3);
                    Mage.recebeDano(goblin3);
                    goblin3.MostraStatus();

                    Mage.MostraStatus();
                    Console.ReadLine();
                    break;

            }

        }
        public static Goblin criarGoblin(int lv)
        {
            Goblin goblin = new Goblin(lv);
            return goblin;
        }
        public static Dragao criarDragao(string nome,int lv)
        {
            Dragao dragao = new Dragao(nome,lv);
            return dragao;
        }
    }
}

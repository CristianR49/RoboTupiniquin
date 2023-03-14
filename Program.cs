namespace RoboTupiniquin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string face;
            int x = 0;
            int y = 0;

            string posIni;
            string movs;

            bool loop1 = true;
            string Output1 = "0";

            Console.Write("Digite o limite de X: ");
            int limiteX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o limite de Y: ");
            int limiteY = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a posição inicial e a direção do primeiro robo:");
            Console.Write("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Direção: ");
            face = Console.ReadLine();

            Console.WriteLine("Digite o comando de movimentos com E, D ou M: ");
            movs = Console.ReadLine();

            Console.WriteLine("Digite a posição inicial e a direção do segundo robo:");
            Console.Write("X: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Direção: ");
            string face2 = Console.ReadLine();

            Console.WriteLine("Digite o comando de movimentos com E, D ou M: ");
            string movs2 = Console.ReadLine();
            //Console.ReadLine()

            for (int i = 0; i < movs.Length; i++)
            {
                if (movs[i] == 'D')
                {
                   
                    switch(face)
                    {
                        case "N":
                            face = "L";
                            break;
                        case "L":
                            face ="S";
                            break;
                        case "S":
                            face = "O"; 
                            break;
                        case "O":
                            face = "N";
                            break;
                    }
                }
                if (movs[i] == 'E')
                {
                    switch (face)
                    {
                        case "N":
                            face = "O";
                            break;
                        case "O":
                            face = "S";
                            break;
                        case "S":
                            face = "L";
                            break;
                        case "L":
                            face = "N";
                            break;
                    }
                }
                if (face == "N" && movs[i] == 'M' && limiteY > y)
                {
                    y++;
                }
                else if (face == "L" && movs[i] == 'M' && limiteX > x)
                {
                    x++;
                }
                else if (face == "S" && movs[i] == 'M' && 0 < y)
                {
                    y--;
                }
                else if (face == "O" && movs[i] == 'M' && 0 < x)
                {
                    x--;
                }

                if (i == movs.Length - 1 && loop1 == true)
                {
                    Output1 = x + " " + y + " " + face;
                    x = x2;
                    y = y2;
                    face = face2;
                    movs = movs2;
                    loop1 = false;
                    i = -1;
                }
            }
            string Output2 = x + " " + y + " " + face;
            Console.WriteLine(Output1 + "\n\n" + Output2);


        }
    }
}
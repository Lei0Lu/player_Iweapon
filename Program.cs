using _11._10._2022;



void Action( Player work, Player have)
{
    Random rnd = new Random();
    for (bool i = false; i == false;)
    {
        Console.WriteLine($"{work.Name}\n 0 - ударить, 1- попытаться выхватить {have.Weapon}");
        int action = Convert.ToInt32(Console.ReadLine());
        if (action == 0)
        {
            Console.WriteLine("первый атакует второго");
            work.AttackPlayer(have);
            i = true;
        }
        else if (action == 1 || have.Weapon!= have.Weapon.Fist)
        {


            int value = rnd.Next(0, 10);
            if (value <= 4 )
            {
                work.Weapon = new Pistol();
                have.Weapon = null;
                Console.WriteLine($"{work} отобрал {have.Weapon} у противника");
            }
            else
            {
                Console.WriteLine($"{work} попытался отобрать {have.Weapon} у противника, но без результатно");
            }

            i = true;
        }
        else
        {
            Console.WriteLine($"Такого действия нет, попробуйте еще раз");
            i = false;
        }
    }
}


Player player1 = new Player()
{
    Name = "Nikita",
    Health = 100,
    Weapon = new Pistol()
};
Player player2 = new Player()
{
    Name = "Stroyak",
    Health = 85,
    Weapon = new Pistol()
};



for (; player1.Health > 0 && player2.Health > 0;)
{
    if (player1.Health > 0) Action(player1, player2);
    player1.Life();
    if (player2.Health > 0) Action(player2, player1);
    player1.Life();
}


//player1.AttackPlayer(player2);
//player2.AttackPlayer(player1);

//Console.WriteLine("Первый игрок резко выхватывает у второго оружие");
//player1.Weapon = new Pistol();
//player2.Weapon = null;



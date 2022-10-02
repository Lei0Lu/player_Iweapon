using _11._10._2022;






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
    Weapon = new Knife()
};


// Резня в мейне на смерть
while ( player1.Health > 0 && player2.Health > 0)
{
    if (player1.Health > 0) player1.Action(player2);
    player1.Life();
    if (player2.Health > 0) player2.Action(player1);
    player1.Life();
}





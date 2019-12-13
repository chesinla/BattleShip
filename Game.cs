using System;
using System.Collections.Generic;



public class Game
{

static void Setup()
{
	Console.WriteLine("Please place your ships");



}




    static void Main()
    {

		Game.Welcome();

		





		GameLoop();
		DisplayWinner();
		Restart();
        /*  const int GRID_SIZE = 10;
		List<Ship> defaultShipList = new List<Ship>();
		defaultShipList.Add(new Ship("Battleship", 'B', 3));
		List<Player> players = new List<Player>();
        
        Gameboard testG = new Gameboard();

        //set up players
		Player player1 = new Player(0, "Player1", GRID_SIZE);
		Player player2 = new Player(1, "player2", GRID_SIZE);
		
		players.Add(player1);
		players.Add(player2);
		
		//add ships and collect location of ships
		foreach(Player p in players){
			foreach(Ship s in defaultShipList){
				p.shipList.Add(s);
				//maybe get from the console the location of the ship and add it to the player's board
			}
		}
*/ }
}
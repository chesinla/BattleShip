using System;
using System.Collections.Generic;


/**

		const int GRID_SIZE = 10;
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
	*/ 
 
public class Game
{
	readonly static int BOARD_SIZE;

	static Game(){
		BOARD_SIZE = 10;
	}

	static void Setup()
	{
		Console.WriteLine("Please place your ships");
	}

	static void Main()
	{
		Console.WriteLine("game board is this big: {0}", Game.BOARD_SIZE);
		Game.Welcome(); 
		//Initilzation of Objects
		Game.CreatePlayers();
		Game.CreateGrids();
		Game.CreateShips();

		//Setup - player specific
		Game.PlaceShips();
		
		//Start game
		Game.GameLoop();
		Game.DisplayWinner();
		Game.Restart();
	}

  private static void PlaceShips()
  {
    //throw new NotImplementedException();
  }

  private static void CreateShips()
  {
    //throw new NotImplementedException();
  }


  private static void CreateGrids()
  {
    // new NotImplementedException();
  }

  /**
    Create 2 players
    validate there exists two plaers
    assign each player a neme of P1 p2
   */
  private static Player CreatePlayers()
  {
    //throw new NotImplementedException();
		return null;
  }

  /**
		Displays welcome text
	 */
  private static void Welcome()
  {
    View.Welcome();
  }
 


  private static void GameLoop()
  {
    //
  }

  private static void DisplayWinner()
  {
    //
  }

 	private static void Restart()
  {
    //
  }


}
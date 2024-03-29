﻿using System;
using System.Collections.Generic;


public class Game
{
	readonly static int BOARD_SIZE;
	readonly static int NUMBER_OF_PLAYERS;

	private static List<Player> Players;

	static Game()
	{
		BOARD_SIZE = 10;
		NUMBER_OF_PLAYERS = 2;
	}

	static void Main()
	{
		Console.WriteLine("game board is this big: {0}", Game.BOARD_SIZE);
		Game.Welcome(); 
		//Initilzation of Objects

		Game.CreatePlayers();
		Game.playersStartGame();
		

		//Once Correct PlayerCount is validated, the players Grids and Ships will be created and validated
		Game.CreateGrids();

		Game.CreateShips();

		//Setup - player specific
		Game.PlaceShips();
		
		//Start game
		Game.GameLoop();
		Game.DisplayWinner();
		Game.Restart();
	}

private static void Welcome()
  {
    View.Welcome();
  }

	private static List<Player> CreatePlayers()
  {
		List<Player> players = new List<Player>();
		for(int i = 0; i < NUMBER_OF_PLAYERS; i++){
			Player player1 = new Player(1, "player1", 10, 1);
			Players.Add(player1);
		}
		return Players;

	}


 private static void playersStartGame()
 {	
	 while(arePlayersReady())
	 {
		 CreateGrids();
	 }
 }
  private static void CreateGrids()
  {
	
    // Create 2 Grids foreach player created,
		//naming convention will show as offensive and defensive grid
		//Grids will both need to be the same size
		//for each defensive grid created create one set of ships as defined in createShips()
  }

	 private static void CreateShips()
  {
	
		
		//create ships in sets,
		// 1 set contains 3 ships, [Carrier, Submarine, Destroyer]
		// forEach player created, assign player 1 set of ships in their playerShipSet
		// check conditional that forEach player, playerShipSet contains 1 set of Ships, 
		// shipSet can be altered in Ship class considering size of Grid and logical amount of empty spaces
		//player will always only have 1 set of ships, Grid_size and number of Ships&length of ships can change within Ships.cs class
		

    //throw new NotImplementedException();
  }


 private static void PlaceShips()
  {
		//this function will interact with View, as the user will use console to place their ships
		// will be able to view grid in console and input a concurrent array of numbers on the grid to place ships
		//first ship placed will be Carrier, user will input an array of integers that must be in order whether vertically or horizontally, (x or y) 

    //throw new NotImplementedException();
  }



  private static void GameLoop()
  {
    //
  }

  private static void DisplayWinner()
  {
    //once a winner is determined in GameLoop(), which will be determined by a looping through the amount of sunken ships, if number of ships == number of sunken ships the other player is = winningPlayer(logic will need work)

		Console.WriteLine("Congratulations {0} is the winner");
  }

 	private static void Restart()
	 {

	 }


}

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
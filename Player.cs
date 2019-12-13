using System;
using System.Collections.Generic;


class Player
{

    public string playerName {get; set;}
    public int playerNumber {get;set;}
    public List<Ship> shipList {get;set;}
    public Gameboard gameBoard {get;set;}
	//gitpublic int numberOfPlayers {get; set;}

public Player(int playerNumber, string playerName, int gridSize,)
	{
		this.playerNumber = playerNumber;
		this.playerName = playerName;
		this.gameBoard = new Gameboard();
		this.gameBoard.grid = new char[gridSize,gridSize];
		this.shipList = new List<Ship>();
		
	}


}

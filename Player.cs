using System;
using System.Collections.Generic;


class Player
{

    public string playerName {get; set;}
    public int playerNumber {get;set;}
    public List<Ship> shipList {get;set;}
    public Gameboard gameBoard {get;set;}
	public int playerCount {get; set;}

public Player(int playerNumber, string playerName, int gridSize, int playerCount)
	{
		this.playerNumber = playerNumber;
		this.playerName = playerName;
		this.gameBoard = new Gameboard();
		this.gameBoard.Grid = new char[gridSize,gridSize];
		this.shipList = new List<Ship>();
		this.playerCount = playerCount;
		
	}


}

using System;

class Ship
{
	public string shipName {get; set;} 
	public char identifyingCharacter {get;set;}
	public int shipLength {get; set;}
	public Ship(){
		this.shipName = "Hello Battleship";
		this.shipLength = 5;
	
	}  // this a function to call instantiate ship, Constructor, why did curly enclosed with nothing inside?
	public Ship(string shipName, char identifyingCharacter, int shipLength){
		this.shipName = shipName;
		this.identifyingCharacter = identifyingCharacter;
		this.shipLength = shipLength;
	}
}

class ShipFactory{
	static Ship Clone(Ship source){
		return new Ship(source.shipName, source.identifyingCharacter, source.shipLength);	// is source 
	}
}
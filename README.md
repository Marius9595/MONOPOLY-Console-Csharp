# MONOPOLY Console C#

This is a classic game where there are among 2-8 players that try to avoid the bankruptcy. The Winner is the only one guy that is not bankrupt

## **SUMMARY**

- [GAME REQUIREMENTS](#game-requirements)
  - [Components of game](#components-of-game)
  - [Rules of the game (official)](#rules-of-the-game-official)
  - [Explanations of components (rules)](#explanations-of-components-rules)
    - [Bank](#bank)
    - [Chance or Community Chest](#chance-or-community-chest)
    - [Jail](#jail)
    - [Properties](#properties)
    - [Mortgaging](#mortgaging)
    - [Bankruptcy](#bankruptcy)
  


# GAME REQUIREMENTS
--------------
## Components of game

* A board
* Two dice
* Houses and Hotels
* 16 Chance Chest and 16 Community Chest 
* 28 property deeds
* Money (1500 m.u for each player in the beggining)
* 32 houses and 12 hotels

### Board

(https://github.com/Marius9595/board.JPG)

------
## Rules of the game (official)

* To start the game it is necessary to choose what is the order of player to play. In this way, there is a first round where each player rolls the two dice, the sum of two values gives the starting order (in decreasing order).

* The sum of values as result to roll dice, it gives the number of steps of a player. In the next round, the player start in a new position in relation of the start of the game, so that`s the new origin to count future steps and so on

* It is possible that two player can be in the same place. There is no problem

* To be in a place can cause diferents situations such as the posibility to buy , to have to pay to bank or other player and to suffer a penalty o to gain surprises

* A result 12 (die1=6 + die2=6  and die1=di2) gives to the player another roll of the dice. But if it occurs 3 times. The player has to go to jail (Hacks? xD)

* A player who lands on or passes the Go space collects $200 from the bank.

* No reward or penalty is given for landing on Free Parking.Properties can only be developed once a player owns all the properties in that color group. They then must be developed equally. A house must be built on each property of that color before a second can be built. Each property within a group must be within one house level of all the others within that group.



----------


## Explanations of components (rules)

 ### Bank

The Bank has to do the following:
* To pay wage and bonus
* To charge taxes, fines ,loans
* To manage the title deeds  ( to selling and actions)

 ### Chance or Community Chest

If a player lands on a Chance or Community Chest space, a message it wil be given to playa to the player follows its instructions. This may include:

   * collecting or paying money to the bank or another player
   * moving to a different space on the board. 
   * Two types of cards that involve jail, "Go to Jail" and "Get Out of Jail Free", are explained below.

 ### Jail

A player is sent to jail for doing any of the following:

  * Landing directly on the "Go to Jail" space
  * Throwing three consecutive doubles in one turn
  * Drawing a "Go to Jail" card from Chance or Community Chest
  
 When a player is sent to jail, they move directly to the Jail space and their turn ends ("Do not pass Go. Do no collect $200."). If an ordinary dice roll (not one of the above events) ends with the player's token on the Jail corner, they are "Just Visiting" and can move ahead on their next turn without incurring any penalty whatsoever.
  
 If a player is in jail, they do not take a normal turn and must:

  * either pay a fine of $50 to be released,
  * use a Chance or Community Chest Get Out of Jail Free card,
  * or attempt to roll doubles on the dice.
  
If a player fails to roll doubles, they lose their turn. Failing to roll doubles for three consecutive turns requires the player to either pay the $50 fine or use a Get Out of Jail Free card, after which they move ahead according to the total rolled.


Players in jail may not buy properties directly from the bank since they are unable to move. This does not impede any other transaction, meaning they can engage in, for example, mortgaging properties, selling/trading properties to other players, buying/selling houses and hotels, collecting rent, and bidding on property auctions. A player who rolls doubles to leave jail does not roll again; however, if the player pays the fine or uses a card to get out and then rolls doubles, they do take another turn.

 ### Properties
 
Just An **unowned property** can be bought and it is necessary that a player is there to have got that option. However, if the player choose not to buy it, automatically that property is auctioned off by the bank to the highest bidder, including the player who declined to buy.

if the **property is already owned and unmortgaged** each player (except owner) will have to pay the rent (this is variable, depends on is part of a set or its level of development).

The **properties belong to a color group**. If a player has got all color group and there is no mortgaged properties, the player can develop them during their turn ~~or in between other player's turns.~~ This means build houses and hotels from the bank. the development must be done uniformly across the group.

houses....

### Mortgaging

Properties can be mortgaged, but all developments on a monopoly must be sold before any property of that color can be mortgaged or traded.

Houses and hotels can be sold back to the bank for half their purchase price.

The player receives half the purchase price from the bank for each mortgaged property.

The bank charges a 10% of interest to clear the mortgage

Players cannot collect rent on mortgaged properties and may not give improved property away to others

trading mortgaged properties is allowed. The player receiving the mortgaged property must immediately pay the bank the mortgage price plus 10% or pay just the 10% amount and keep the property mortgaged; if the player chooses the latter, they must pay the 10% again when they pay off the mortgage.

 ### Bankruptcy
 
A player who cannot pay what they owe is bankrupt and eliminated from the game.
 
Si el jugador en quiebra debe al banco, debe entregar todos sus activos al banco, que entonces subasta sus propiedades (si las tiene), excepto los edificios.
 
If the debt is owed to another player instead, all assets are given to that opponent, except buildings which must be returned to the bank.

The new owner must either pay off any mortgages held by the bank on such properties received or pay a fee of 10% of the mortgaged value to the bank if they choose to leave the properties mortgaged.

If a player runs out of money but still has assets that can be converted to cash, they can do so by selling buildings, mortgaging properties, or trading with other players. To avoid bankruptcy the player must be able to raise enough cash to pay the full amount owed.
 
A player cannot choose to go bankrupt; if there is any way to pay what they owe, even by returning all their buildings at a loss, mortgaging all their real estate and giving up all their cash, even knowing they are likely going bankrupt the next time, they must do so.


## Strategy

the best way to get the most out of every property is through houses and hotels. In order to do so, the player must have all the corresponding properties of the color set. Three houses allows the player to make all the money they spent on the houses back and earn even more as players land on those properties

### Trading

players trade to speed up the process and secure a win. Building at least 3 houses on each property allows the player to break even once at least one player lands on this property



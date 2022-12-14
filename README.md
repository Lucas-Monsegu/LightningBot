# LightningBot

This project contains the source code of the lightningBot viewer


The goal is to be the last to survive. To do that you can code a bot that will interact with our api and play the right moves.


After the game is played using our API. You can visualize how the game using this viewer hosted on our website (which is not anymore).


# Screenshot

![lightningbot-screen](resources/lightningbot.png)

# Trailer

Here is a [trailer](https://www.youtube.com/watch?v=rjhCD6h5H-k) of the project


# Story of the project

This is a 3 man project that was made during our studies, on our free time.
After the launch we had many users and an active discord server. People were playing games, coding bots and sharing them.
One company saw it as an opportunity to make a coding event and they invited the 3 of us to Lille to participate in it. It was fun and we had a free train tickets and pizzas and the person that contacted us, also hosted us for the night !


## Beginner's tutorial

Chose a language and read the code (see level 0) to have a basic understanding of it. If it looks like Chinese to you try to just identify where the direction of the bot is chosen and start from here. If there is no code sample of the language you chose you will have to do it from scratch.
If you need help feel free to ask questions to our community in the discord:
https://discordapp.com/invite/wxzd7Us


### Level 0
Level 0 correspond to the code samples provided at https://lightningbot.cf/doc. It goes in a straight line. To complete this level you just have to run it. Don't forget that for a game to start there must be at least 2 bots playing. If nobody else is playing try to launch 2 of your bots. Take the time to read the documentation it will help you for completing the levels.
### Level 1
Chose a random direction each turn. Go to the documentation and find what are the values for each direction. Then generate a random number in the range of the values that you previously found (it should be [0,3]). Replace the direction variable in your script by this value and there you go, Level 1 finished ! You can see that your bot will not survive for long and will probably kill himself (invalid move). Because it went in the opposite direction it was previously facing.
### Level 2
Do the same thing than level 1 but just try to not let your bot kill himself. Store the value of the direction of the previous turn in a variable and exclude it from the range of the random. Your bot can still die on his on tail but at least there will not be invalid moves.
### Level 3
In this level you should use Object Oriented Programming. It will be very simples classes but if you have no idea what they are try to read about it on the internet. In this level we will
update a map of the game to keep track of all the information. During the info phase you have the dimension of the map (it's a square) and the starting position of all the bots including yours. A solution is to make a class "Bot" and a class "Map":

- The Bot has: a position, a name.
- The Map has: A 2D array of integers that will represent the map.

Don't hesitate to add your own attributes.
After the info phase instantiate all a Bot object for each bot in the game, and a single map (You can also do a static map). Define a method in the bot class to update their position and a method in the Map class to update the map. For example you can say that 0 is a free position and 1 is when a bot already went at this position. Each turn call your methods to update the map and the bots. See the documentation on how to get the bot positions if it is not already in the code sample. Now that your map is updated take a random direction but chose an other if it leads your bot death's. Your bot will now survive for much longer and that is when the game really start.
You can now think of your own way to guide your bot instead of using the random.
If you have no ideas, here are a couple algorithms you could use:
- Dijkstra/A*
- Vorono??
- Machine learning



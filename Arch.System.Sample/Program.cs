﻿// See https://aka.ms/new-console-template for more information

using Arch.EventBus.SourceGenerator;
using Microsoft.Xna.Framework;
using Game = Arch.System.Sample.Game;


// Info : 
// This sample demonstrates a example usage of arch. 
// Especially a few different iteration techniques for entity iterations. 
// Its not a full demonstration of all features. 
// Hit "delete" to remove velocity from all entities

// Disclaimer : 
// You can spawn in to 1 million entities, then the performance starts dropping.
// The bottleneck is not the ECS framework, its actually the rendering ( Monogame Spritebatch ).

Console.WriteLine("Sample App starts...");
using var game = new Game();
game.Run();

Environment.Exit(0);
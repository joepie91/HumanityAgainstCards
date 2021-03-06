﻿using System;
using Californium;
using SFML.Graphics;
using SFML.Window;

namespace ManateesAgainstCards
{
	class Program
	{
		public const string DefaultFont = "arial.ttf";
		public const string Version = "1.97";
		public static bool HandleNetworking;

		public static void Main(string[] args)
		{
			HandleNetworking = true;

			Console.WriteLine("Manatees Against Humanity; Version {0}", Version);
			
			// Set window resolution
			GameOptions.Caption = "Manatees Against Cards";
			GameOptions.Icon = "Icon.png";
			GameOptions.Width = 1280; // 1280
			GameOptions.Height = 720; // 720
			GameOptions.Resizable = false;

			// Prepare network loop
			Timer.EveryFrame(() =>
			{
				if (HandleNetworking)
				{
					Network.Client.UpdateNetwork();
					Network.Server.UpdateNetwork();
				}

				return false;
			});

			Console.WriteLine("Initializing engine...");
			Game.Initialize();

			Console.WriteLine("Running...");
			Game.SetState(new States.MainMenu());
			Game.Run();
		}
	}
}

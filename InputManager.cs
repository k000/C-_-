﻿using System;
namespace soukoban_ex
{
    public class InputManager
    {
        public InputManager(){}
      
        public int getInputKey(int stageWidth){
            
			string key = Console.ReadLine();
			int direction = 0;
			//入力したキーに応じてプレイヤーの移動先を決定します。
			switch (key)
			{
				case "a":
					direction = -1;
					break;
				case "d":
					direction = 1;
					break;
				case "w":
					direction = stageWidth * (-1);
					break;
				case "s":
					direction = stageWidth;
					break;
				default:
					Console.Write("ゲームを終了します");
					Environment.Exit(0);
                    return 0;
			}
            return direction;
        }
    }
}

﻿using System;

namespace soukoban_ex
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("遊び方。\n a=左移動:d=右移動:w=上移動:s=下移動");
            Console.WriteLine("P=プレイヤー");
            Console.WriteLine("N=荷物");
            Console.WriteLine("G=ゴール");
            Console.WriteLine("■=壁");
            Console.WriteLine("F=ゴールに乗った荷物");
            Console.WriteLine("O=ゴールに乗ったプレイヤー");

            Stage stage = new NomalStage();
            var filePath = @"/Users/name/Projects/sokoban/sokoban/StageData.txt";
            stage.startGame(filePath);
        }
    }
}

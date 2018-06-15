using System;
using System.Collections.Generic;
using System.Linq;


namespace soukoban_ex
{
    public class ObjectManager
    {
       private List<GameObject> objectList = new List<GameObject>();

        public void addObject(GameObject gameobject){
            this.objectList.Add(gameobject);
        }

        public GameObject getPlayerObject(){
            var player = this.objectList.Find(s => s.objectType == GameObject.ObjectType.PLAYER);
            return player;
        }

        public GameObject getGameObjectWithPosition(int position){
            var gameObject = this.objectList.Find(s => s.position == position);
            return gameObject;
        }

        public GameObject getNextObject(int direction){
            var playerpos = getPlayerPosition();
            return getGameObjectWithPosition(playerpos + direction);
        }

        public GameObject getMoreNectObject(int direction){
			var playerpos = getPlayerPosition();
            return getGameObjectWithPosition(playerpos + direction + direction);
        }

        public int getPlayerPosition(){
            var player = getPlayerObject();
            return player.position;
        }

        public void printObject(int width){
			var printlist = objectList.OrderBy(x => x.position);
			int counter = 0;
			foreach (var obj in printlist)
			{
				counter++;
				Console.Write(obj.type);
				if ((counter) % width == 0)
					Console.Write(Environment.NewLine);
			}
		}

        public bool hasGoal(){
            var finish = objectList.Select(s => s).Any(s => s.objectType == GameObject.ObjectType.GOAL);
            return finish;
        }

    }
}

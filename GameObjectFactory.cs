﻿namespace soukoban_ex
{
    public class GameObjectFactory : Factory
    {
        public GameObjectFactory(){}
        private int positionCounter = 0;

        protected override GameObject createGameObject(char type){

            positionCounter++;
            GameObject gameobject = null;
			
            switch(type){
                case 'P':
                    gameobject = new SoukobanObject();
                    gameobject.init(positionCounter,type,GameObject.ObjectType.PLAYER);
                    break;
                case '■':
                    gameobject = new SoukobanObject();
                    gameobject.init(positionCounter, type,GameObject.ObjectType.WALL);
                    break;
				case 'N':
                    gameobject = new SoukobanObject();
                    gameobject.init(positionCounter, type,GameObject.ObjectType.NIMOTU);
					break;
				case 'G':
					gameobject = new SoukobanObject();
                    gameobject.init(positionCounter, type, GameObject.ObjectType.GOAL);
					break;
                 default:
                    gameobject = new SoukobanObject();
                    gameobject.init(positionCounter,type,GameObject.ObjectType.FLOOR);
                    break;
            }
            return gameobject;
        }

    }
}

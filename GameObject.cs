﻿namespace soukoban_ex
{
    public abstract class GameObject
    {

    
        public enum ObjectType{
            PLAYER,
            NIMOTU,
            GOAL,
            WALL,
            FLOOR,
            NIMOTUONGOAL,
        }

        public int position{
            get;protected set;
        }

        public char type{
            get;protected set;
        }

        public ObjectType objectType{
            get;protected set;
        }

        public void init(int pos, char typech,ObjectType objtype)
		{
			position = pos;
			type = typech;
            objectType = objtype;
		}

        public virtual void changeType(char type , ObjectType objecttype){}

    }
}

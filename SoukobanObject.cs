﻿namespace soukoban_ex
{
    public class SoukobanObject : GameObject
    {
        public override void changeType(char type, GameObject.ObjectType objecttype)
        {
            this.type = type;
            this.objectType = objecttype;
        }
	}
}

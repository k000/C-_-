namespace soukoban_ex
{
    public class ActionManager
    {
        private ObjectManager objectManager = null;

        public ActionManager(ObjectManager objectManager){
            this.objectManager = objectManager;
        }

        public void hitGoal(int direction){
            
            var player = objectManager.getPlayerObject();
            var goal = objectManager.getNextObject(direction);

            player.changeType(CharManager.getFloorChar(),GameObject.ObjectType.FLOOR);
            goal.changeType(CharManager.getPlayerOnGoalChar(), GameObject.ObjectType.PLAYER);

        }

        public void hitNimotu(int direction){
            /*  まずは必要なオブジェクトを取得します　*/
            var player = objectManager.getPlayerObject();
            var nextObj = objectManager.getNextObject(direction);
            var morenextObject = objectManager.getMoreNectObject(direction);

            //荷物の移動先が荷物だったら動かせないので処理はしません
            if (morenextObject.objectType == GameObject.ObjectType.NIMOTU)
                return;
            //荷物の移動先が荷物の乗ったゴールだったら動かせないので処理はしません
            if (morenextObject.objectType == GameObject.ObjectType.NIMOTUONGOAL)
				return;
            /*
             * 荷物の移動先がゴールだったら
             *・ゴールに荷物を乗せて
             *・もともと荷物の場所にプレイヤーが移動して
             *・プレイヤーのいた場所を床にします。
             */
			if (morenextObject.objectType == GameObject.ObjectType.GOAL)
			{
                morenextObject.changeType(CharManager.getNimotuOnGoalChar(), GameObject.ObjectType.NIMOTUONGOAL);
                nextObj.changeType(CharManager.getPlayerChar(), GameObject.ObjectType.PLAYER);
                player.changeType(CharManager.getFloorChar(), GameObject.ObjectType.FLOOR);
				return;
			}
            //最終的に荷物の移動先が壁でなければ
            if (morenextObject.objectType != GameObject.ObjectType.WALL)
			{
                /*
                 *・荷物の移動先に荷物を移動して 
                 *・荷物の場所にプレイヤーが移動して
                 *・プレイヤーの場所が床になります
                 */
                morenextObject.changeType(CharManager.getNimotuChar(), GameObject.ObjectType.NIMOTU);
                nextObj.changeType(CharManager.getPlayerChar(),GameObject.ObjectType.PLAYER);
                player.changeType(CharManager.getFloorChar(),GameObject.ObjectType.FLOOR);
			}
        }

    }
}

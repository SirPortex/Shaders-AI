//using system;
//using system.collections;
//using system.collections.generic;
//using unityengine;


//[createassetmenu(filename = "timepassedaction (a)", menuname = "scriptableobjects/actions/timepassedaction")]
//public class timepassedaction : action
//{
//    public float maxtime;

//    private float currenttime = 0;
//    public override bool check(gameobject owner)
//    {
//        currenttime += time.deltatime;

//        if (currenttime >= maxtime)
//        {
//            currenttime = 0;
//            return true;
//        }
//        return false;
//    }

//    public override void drawgizmo(gameobject owner)
//    {

//    }
//}

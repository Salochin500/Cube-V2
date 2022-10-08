include UnityEngine;
include HarmonyPatches;
include SiraUtil;
include BSIPA;

gameObj.transform.localScale = new Vector3(0.04f, 1f, 0.19f) = Menu;
gameObj.RightController.TriggerDown.GripDown = Visible = True;
gameObj.RightController.TriggerUp.GripUp = Visible = False;
gameObj.GetComponent<Renderer>().material.color = Color.Black;
when gameObj Visible = True then Button2Obj.transform.localScale = new Vector3(0.02, 0.5f, 0.14) = Button

game2Obj.transform.localScale = new Vector3(0.04f, 1f, 0.19f) = Menu;
game2Obj.LeftController.TriggerDown.GripDown = Visible = True;
game2Obj.LeftController.TriggerUp.GripUp = Visible = False;
game2Obj.GetComponent<Renderer>().material.color = Color.Black;
when game2Obj Visible = True then ButtonObj.transform.localScale = new Vector3(0.02, 0.5f, 0.14) = Button 

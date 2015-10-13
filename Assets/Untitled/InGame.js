#pragma strict

var buildPanelOpen:boolean=false;
//var buildPanelTweener:TweenPosition;
//var buildPanelArrowTweener:TweenRotation;

var placementPlanesRoot:Transform;
var hoverMat:Material;
var placementLayerMask:LayerMask;
private var originalMat:Material;
private var lastHitObj:GameObject;

//build section
var onColor:Color;
var offColor:Color;
var allStructures:GameObject[];
//var buildBtnGraphics:UISlicedSprite[];
private var structureIndex:int=0;


function Start () 
{
   structureIndex=0;
   //UpdateGUI;
}

/*function UpdateGUI()
{
  for(var theBtnGraphic:UISlicedSprite in buildBtnGraphics)
  {
   theBtnGraphic.color=offColor;
  }
  
   buildBtnGraphics[structureIndex].color=offColor;
}*/

function Update () 
{
if(buildPanelOpen)
  {
   var ray=Camera.main.ScreenPointToRay(Input.mousePosition);
   var hit:RaycastHit;
   if(Physics.Raycast(ray,hit,1000,placementLayerMask))
    {
     if(lastHitObj)
        {
          lastHitObj.GetComponent.<Renderer>().material=originalMat;
        }
        
     lastHitObj=hit.collider.gameObject;
     originalMat=lastHitObj.GetComponent.<Renderer>().material;
     lastHitObj.GetComponent.<Renderer>().material=hoverMat;
     
    }
   else 
   {
     if(lastHitObj)
        {
          lastHitObj.GetComponent.<Renderer>().material=originalMat;
          lastHitObj=null;
        }      
   }
   
   if(Input.GetMouseButtonDown(0)&& lastHitObj)
   {
     if(lastHitObj.tag =="PlacementPlane_Open")
      {
       var newStructure:GameObject=Instantiate(allStructures[structureIndex],lastHitObj.transform.position,Quaternion.identity);
       newStructure.transform.localEulerAngles.y=(Random.Range(0,360));
       lastHitObj.tag="PlacementPlane_Taken";
      }
   }
  }

}

function SetBuildChoice(btnObj:GameObject)
{
  var btnName:String=btnObj.name;
  if(btnName == "btn_Shop")
  {
    structureIndex=0;
  }
  else if (btnName == "btn_Env")
  {
    structureIndex=1;
  }
    else if (btnName == "btn_Facil")
  {
    structureIndex=2;
  }
  
  
}



function ToggleBuildPanel()
{
 if(buildPanelOpen)
 {
 
 for(var thePlane:Transform in placementPlanesRoot)
 {
   thePlane.gameObject.GetComponent.<Renderer>().enabled=false;
 }
 
//buildPnaelTweener.Play(false);
//buildPanelArrowTweener.Play(false);
buildPanelOpen=false; 
}

else 
{
  for(var thePlane:Transform in placementPlanesRoot)
 {
   thePlane.gameObject.GetComponent.<Renderer>().enabled=true;
 }
 
//buildPnaelTweener.Play(true);
//buildPanelArrowTweener.Play(true);
buildPanelOpen=true; 
}
}



































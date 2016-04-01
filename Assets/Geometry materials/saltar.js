var velocidad=5.0;
var velocidadSalto=40.0;
var tierra=true;
function Update () 
{
var x:Vector3=Input.GetAxis("Horizontal")*transform.right*Time.deltaTime*velocidad;
var z:Vector3=Input.GetAxis("Vertical")*transform.forward*Time.deltaTime*velocidad;
transform.Translate(x+z);
transform.rotation=Quaternion.LookRotation(Vector3.forward,Vector3.up);
if(Input.GetButtonDown("Fire1"))
{
Saltar();
}
}


function Saltar()
{

if(tierra==true){
GetComponent.<Rigidbody>().AddForce(Vector3.up *velocidadSalto);
tierra=false;
}
} 

function OnCollisionEnter(hit:Collision)
{
tierra=true;

}
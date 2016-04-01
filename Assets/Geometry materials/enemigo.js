function OnTriggerEnter(Otro : Collider)
{
	if(Otro.tag == "enemigo")
	{
		MiPosicion.Usar.Cargar();
	}
}
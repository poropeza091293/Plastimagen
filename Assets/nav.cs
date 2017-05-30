using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nav : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Irmenu()
	{
		SceneManager.LoadScene ("menu");
	}

	public void IrInicio()
	{
		SceneManager.LoadScene ("prueba");
	}


	public void extrusion()
	{
		SceneManager.LoadScene ("extrusion");
	}

	public void extrusion_d()
	{
		SceneManager.LoadScene ("ex_d");
	}

	public void inyeccion()
	{
		SceneManager.LoadScene ("inyeccion");
	}

	public void inyeccion_d()
	{
		SceneManager.LoadScene ("iny_d");
	}

	public void soplado()
	{
		SceneManager.LoadScene ("soplado");
	}

	public void soplado_d()
	{
		SceneManager.LoadScene ("sop_d");
	}

	public void calandreo()
	{
		SceneManager.LoadScene ("calandreo");
	}

	public void calandreo_d()
	{
		SceneManager.LoadScene ("cal_d");
	}

	public void inmersion()
	{
		SceneManager.LoadScene ("inmersion");
	}

	public void inmersion_d()
	{
		SceneManager.LoadScene ("inm_d");
	}

	public void rotomoldeo()
	{
		SceneManager.LoadScene ("rotomoldeo");
	}

	public void rotomoldeo_d()
	{
		SceneManager.LoadScene ("rot_d");
	}

	public void compresion()
	{
		SceneManager.LoadScene ("compresion");
	}

	public void compresion_d()
	{
		SceneManager.LoadScene ("com_d");
	}

	public void final()
	{
		SceneManager.LoadScene ("final");
	}


	public void AbrirRegistro()
	{
		Application.ExternalEval("window.open(\"http://acob.guru/Pangea/regstart.aspx?cuip=4-5222226&md=1&lan=SP&acuni=222222\",\"_blank\")");
	}

}

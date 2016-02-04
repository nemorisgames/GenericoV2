using UnityEngine;
using System.Collections;

public class DiapositivaPreguntas : MonoBehaviour {
    ArrayList preguntas; //arreglo de tipo Pregunta
    public GameObject preguntaPrefab;
	// Use this for initialization
	void Start () {
        inicializar();
    }

    public void inicializar()
    {
        preguntas = new ArrayList();
        for (int i = 0; i < 6; i++)
        {
            GameObject g = NGUITools.AddChild(transform.FindChild("PanelCentral").gameObject, preguntaPrefab);
            g.transform.localPosition = new Vector3(g.transform.localPosition.x, g.transform.localPosition.y - i * 350f, g.transform.localPosition.z);
            Pregunta d = g.GetComponent<Pregunta>();
            d.inicializar(0, (i + 1) + ".- Esta es una pregunta?", new int[4] { 0, 1, 2, 3 }, new string[4] { "respuesta 1", "respuesta 2", "respuesta 3", "respuesta 4" }, 1);
            preguntas.Add(d);
        }
    }

    public void entregarEvaluacion()
    {
        //por implementar...
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

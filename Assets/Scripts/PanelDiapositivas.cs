using UnityEngine;
using System.Collections;

public class PanelDiapositivas : MonoBehaviour {
    ArrayList diapositivas;
    int diapositivaActual = 0;
    public Diapositiva diapositivaTitulo;
    public DiapositivaPreguntas diapositivaPreguntas;
    // Use this for initialization
    void Start () {
        traerInformacion();
    }

    void traerInformacion()
    {
        diapositivas = new ArrayList();
        diapositivaTitulo.titulo.text = "Módulo N";
        diapositivaTitulo.subTitulo.text = "Módulo de información";
        diapositivas.Add(diapositivaTitulo.gameObject);
        //suponemos 3 diapositivas
        for (int i = 0; i < 3; i++)
        {
            //recibimos el tipo de la diapositiva. En este caso, todas del mismo tipo
            Diapositiva.TipoDispositiva tipo = Diapositiva.TipoDispositiva.TextoDerecha;
            switch (tipo)
            {
                case Diapositiva.TipoDispositiva.TextoDerecha:
                    GameObject g = NGUITools.AddChild(gameObject, (GameObject)Resources.Load("Diapositiva_Tipo1"));
                    Diapositiva d = g.GetComponent<Diapositiva>();
                    d.panelDiapositivas = this;

                    //SEGMENTO DE CODIGO A CONFIGURAR SEGUN LA INFORMACION
                    d.titulo.text = "Módulo N";
                    d.subTitulo.text = "Módulo de información";
                    d.imagenPrincipal.mainTexture = (Texture)Resources.Load("Diapositivas/Modulo1/diapositiva1");
                    //la forma en que se maneja la informacion en cada panel de informacion depende de su diseño. en este caso, solo hay uno
                    InformacionBullet a = new InformacionBullet();
                    InformacionBullet b = new InformacionBullet();
                    InformacionBullet c = new InformacionBullet();

                    a.sprite = "check-rojo";
                    b.sprite = "check-rojo";
                    c.sprite = "check-rojo";

                    a.texto = "texto de prueba 1\nwdqwd\ndwqdqwd\nljjl\nlkjlklkjl\nlkjlkjlj\nsad";
                    b.texto = "texto de prueba 2\nwdqwd\ndwqdqwd\nljjl\nlkjlklkjl\nlkjlkjlj\nsad";
                    c.texto = "texto de prueba 3\n\n";

                    d.panelInformacionBullets[0].inicializar("Descripcion de la diapositiva " + i, new InformacionBullet[3] { a, b, c });
                    //FIN SEGMENTO

                    g.SetActive(false);
                    diapositivas.Add(g);

                    break;
            }
        }

        diapositivas.Add(diapositivaPreguntas.gameObject);
    }

    public void cambiarDiapositiva(bool adelante)
    {
        diapositivaActual = Mathf.Clamp(diapositivaActual + (adelante ? 1 : -1), 0, diapositivas.Count);
        for(int i = 0; i < diapositivas.Count; i++)
        {
            ((GameObject)diapositivas[i]).SetActive(i == diapositivaActual);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

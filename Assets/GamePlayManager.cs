using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour {

    public class StoryNode{
        //history: El texto que describe la localización.
        public string history;
        //answers[]: La lista de textos con las respuestas posibles.
        public string[] answers;
        //nextNode[]: La lista de nodos destino, en el mismo orden que en la lista de 
        //respuestas. O sea, si se elige la respuesta en el índice 1 de «answers», 
        //el jugador se desplazará al nodo indicado por nextNode[1].
        public StoryNode[] nextNode;
        public bool isFinal = false;
        //isFinal: Indica que este nodo corresponde a un final, donde acaba la aventura.
        public delegate void NodeVisisted();
        //NodeVisited() y nodeVisited: Permite asignar una referencia a un método 
        //delegado que se ejecutará siempre que se visite esa localización. Esta 
        //estrategia permite ejecutar código que manipule el mapa al llegar a ciertas 
        //localizaciones.
        public NodeVisisted nodeVisisted;
    }

    private StoryNode current;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace RPG
{
    public class DialogueManager : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI npcText_UI;
        [SerializeField]
        private TextMeshProUGUI[] answers_UI;

        private InteractionComponent unit;
        private int currentNode;
        private Dialogue _dialogue;
        private Node[] _nodes;
        private Answer[] _answers;

        private TextAsset xml;

        public void InitializeDialogue(TextAsset XmlOfNpc, int numberOfNode, InteractionComponent Unit)
        {
            unit = Unit;
            xml = XmlOfNpc;
            currentNode = numberOfNode;
            _dialogue = Dialogue.Load(xml);
            _nodes = _dialogue.nodes;
            SetNode(currentNode);
        }

        public void SetNode (int num)
        {
            currentNode = num;
            npcText_UI.text = _nodes[currentNode].npcText;
            _answers = _nodes[currentNode].answers;

            for (int i = 0; i < _answers.Length; i++ )
            {
                answers_UI[i].text = _answers[i].text;
                answers_UI[i].enabled = true;
            }
            for (int j = _answers.Length; j<answers_UI.Length; j++)
            {
                answers_UI[j].enabled = false;
            }
        }
        public void ButtonFirst_UI()
        {
            var answer = _answers[0];
            if(answer.end == "true")
            {
                unit.BackNode(answer.nextNode);
            }
            else
            {
                SetNode(answer.nextNode);
            }
        }
        public void ButtonSecond_UI()
        {
            var answer = _answers[1];
            if (answer.end == "true")
            {
                unit.BackNode(answer.nextNode);
            }
            else
            {
                SetNode(answer.nextNode);
            }
        }
        public void ButtonThird_UI()
        {
            var answer = _answers[2];
            if (answer.end == "true")
            {
                unit.BackNode(answer.nextNode);
            }
            else
            {
                SetNode(answer.nextNode);
            }
        }
        public void ButtonFourth_UI()
        {
            var answer = _answers[3];
            if (answer.end == "true")
            {
                unit.BackNode(answer.nextNode);
            }
            else
            {
                SetNode(answer.nextNode);
            }
        }
        public void ButtonFifth_UI()
        {
            var answer = _answers[4];
            if (answer.end == "true")
            {
                unit.BackNode(answer.nextNode);
            }
            else
            {
                SetNode(answer.nextNode);
            }
        }

    }
}
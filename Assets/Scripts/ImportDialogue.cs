using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

namespace RPG
{
    [XmlRoot("Dialogue")]
    public class Dialogue 
    {
        [XmlElement("Text")]
        public string text;
        [XmlElement("Node")]
        public Node[] nodes;

        public static Dialogue Load (TextAsset _xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Dialogue));
            StringReader reader = new StringReader(_xml.text);
            Dialogue dial = serializer.Deserialize(reader) as Dialogue;
            return dial;
        }
    }
    [System.Serializable]
    public class Node
    {
        [XmlElement("NPCtext")]
        public string npcText;
        [XmlArray("Answers")]
        [XmlArrayItem("Answer")]
        public Answer[] answers;
    }
    public class Answer
    {
        [XmlAttribute("tonode")]
        public int nextNode;
        [XmlElement("Text")]
        public string text;
        [XmlElement("DialEnd")]
        public string end;
    }
}
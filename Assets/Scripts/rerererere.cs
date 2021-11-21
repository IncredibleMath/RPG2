using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{
    [CreateAssetMenu(fileName ="na",menuName ="nana")]
    public class rerererere : ScriptableObject
    {
        public List<Vector2> vectors;
        public List<string> names;

        [ContextMenu("herak")]
        void utut()
        {
            vectors = new List<Vector2>();
            names = new List<string>();
            var pool = GameObject.FindGameObjectWithTag("HUI").transform;
            foreach (var a in pool.GetComponentsInChildren<Transform>())
            {
                if (a == pool)
                {
                    continue;
                }
                names.Add(a.name);
                vectors.Add(a.position);
            }
        }


    }
}
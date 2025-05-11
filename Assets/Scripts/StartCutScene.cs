using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


    public class StartCutScene : MonoBehaviour
    {
        [SerializeField] private PlayableDirector playableDirector;
       
        private void Start()
        {
            GameObject plDir = GameObject.Find("timeline2");
            playableDirector = plDir.GetComponent<PlayableDirector>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<CapsuleCollider>(out CapsuleCollider capsuleCollider))
            {
                playableDirector.Play();
            }
        }
    }

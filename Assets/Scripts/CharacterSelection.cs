using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacters=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextCharacter(){
        characters[selectedCharacters].SetActive(false);
        selectedCharacters=(selectedCharacters + 1 ) % characters.Length;
        characters[selectedCharacters].SetActive(true);
    }
    public void PreviusCharacter(){
        characters[selectedCharacters].SetActive(false);
        selectedCharacters--;
        if(selectedCharacters<0 ){
            selectedCharacters+=characters.Length;
        }
        characters[selectedCharacters].SetActive(true);
    }
}

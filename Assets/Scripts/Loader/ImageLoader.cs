namespace Loader
{
    using UnityEngine;

    public static class ImageLoader
    {
        private const string CharactersPath = "Images/Characters";
        private const string EndingsPath = "Images/Endings";
        
        public static Sprite LoadCharacterImage(string character, string variant)
        {
            return Resources.Load<Sprite>(string.Join('/', CharactersPath, character, variant));
        }
        
        public static Sprite LoadEndingImage(string variant)
        {
            return Resources.Load<Sprite>(string.Join('/', EndingsPath, variant));
        }
    }
}

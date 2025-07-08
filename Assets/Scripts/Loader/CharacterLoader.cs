namespace Loader
{
    using UnityEngine;

    public static class CharacterLoader
    {
        private const string CharactersPath = "Characters";
        
        public static Sprite Load(string character, string variant)
        {
            return Resources.Load<Sprite>(string.Join('/', CharactersPath, character, variant));
        }
    }
}

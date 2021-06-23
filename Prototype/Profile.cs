using System;

namespace Prototype
{
    public class Profile
    {
        public readonly string EyesColor;

        public readonly string HairColor;

        public Profile(string eyesColor, string hairColor)
        {
            EyesColor = eyesColor;
            HairColor = hairColor;
        }
    }
}
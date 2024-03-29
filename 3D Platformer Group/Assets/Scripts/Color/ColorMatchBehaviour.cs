using Scripts.Data;
using UnityEngine;

namespace Scripts
{
    public class ColorMatchBehaviour : MatchBehaviour
    {
        public ColorIDDataList colorIDDataListObj;

        public void Awake()
        {
            if (colorIDDataListObj != null) idObj = colorIDDataListObj.currentColor;
        }

        public void ChangeColor(SpriteRenderer renderer)
        {
            var newColor = idObj as ColorID;
            renderer.color = newColor.value;
        }
        public void ChangeMaterial(MeshRenderer renderer)
        {
            var newColor = idObj as ColorID;
            renderer.material = newColor.material;
        }
    }
}

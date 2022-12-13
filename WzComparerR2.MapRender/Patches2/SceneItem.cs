namespace WzComparerR2.MapRender.Patches2
{
    public class SceneItem
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public string Tag { get; set; }

        public override string ToString()
        {
            return $"{Name} {GetType().Name}";
        }
    }
}
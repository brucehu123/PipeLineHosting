namespace PipelineHosting
{
    public interface IFeatureCollection
    {
        TFeature Get<TFeature>();

        void Set<TFeature>(TFeature instance);
    }
}

﻿using System;
using System.Collections.Concurrent;

namespace PipelineHosting
{
    public class FeatureCollection : IFeatureCollection
    {
        private ConcurrentDictionary<Type, object> features = new ConcurrentDictionary<Type, object>();
        public TFeature Get<TFeature>()
        {
            object feature;
            return features.TryGetValue(typeof(TFeature), out feature) ? (TFeature)feature : default(TFeature);
        }

        public void Set<TFeature>(TFeature instance)
        {
            features[typeof(TFeature)] = instance;
        }
    }
}

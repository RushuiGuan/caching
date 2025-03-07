﻿using Polly.Caching;
using Polly.Caching.Memory;

namespace Albatross.Caching.MemCache {
	public class ObjectCacheProviderAdapter : ICacheProviderAdapter {
		private readonly MemoryCacheProvider provider;

		public ObjectCacheProviderAdapter(MemoryCacheProvider provider) {
			this.provider = provider;
		}

		public IAsyncCacheProvider<T> Create<T>()
			=> provider.AsyncFor<T>();

		public ISyncCacheProvider<T> CreateSync<T>()
			=> provider.For<T>();
	}
}
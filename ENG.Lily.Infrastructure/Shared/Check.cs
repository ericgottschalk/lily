using System;

namespace ENG.Lily.Infrastructure.Shared
{
    public static class Check
    {
        public static T NotNull<T>(T instance) where T : class
        {
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            return instance;
        }

        public static T NotNull<T>(T? instance) where T : struct
        {
            if (!instance.HasValue)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            return instance.Value;
        }
    }
}

﻿namespace TrackerDog.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Diagnostics.Contracts;
    using System.Reflection;

    [ContractClassFor(typeof(ITrackableType))]
    public abstract class ITrackableTypeContract : ITrackableType
    {
        public IImmutableSet<PropertyInfo> IncludedProperties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IImmutableDictionary<IList<PropertyInfo>, PropertyInfo> ObjectPaths
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Type Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        [ContractInvariantMethod]
        private void Invariants()
        {
            Contract.Invariant(IncludedProperties != null, "Included properties cannot be null");
            Contract.Invariant(Type != null, "Type cannot be null");
            Contract.Invariant(ObjectPaths != null, "Object paths must not be null");
        }
    }
}
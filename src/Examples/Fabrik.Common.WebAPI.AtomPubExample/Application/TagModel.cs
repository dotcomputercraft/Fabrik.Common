﻿using Fabrik.Common.WebAPI.AtomPub;

namespace Fabrik.Common.WebAPI.AtomPubExample
{
    public class TagModel : IPublicationCategory
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Scheme { get; set; }

        string IPublicationCategory.Name
        {
            get { return Name; }
        }

        string IPublicationCategory.Label
        {
            get { return Name; }
        }
    }
}
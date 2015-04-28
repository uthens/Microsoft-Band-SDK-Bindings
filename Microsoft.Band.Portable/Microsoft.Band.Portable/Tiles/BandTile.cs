﻿using System;
using System.Collections.Generic;

using Microsoft.Band.Portable.Personalization;
using Microsoft.Band.Portable.Tiles.Pages;

namespace Microsoft.Band.Portable.Tiles
{
    using BandTheme = Microsoft.Band.Portable.Personalization.BandTheme;

    public class BandTile
    {
        public BandTile(Guid tileId)
        {
            Id = tileId;

            PageLayouts = new List<PageLayout>();
            PageImages = new List<BandImage>();
        }

        public BandTile(Guid tileId, string name, BandImage icon)
            : this(tileId)
        {
            Name = name;
            Icon = icon;
        }

        public Guid Id { get; private set; }

        public string Name { get; set; }

        public BandImage Icon { get; set; }

        public BandImage SmallIcon { get; set; }

		public BandTheme Theme { get; set; }
        
        public List<PageLayout> PageLayouts { get; private set; }

        public List<BandImage> PageImages { get; private set; }

		public bool IsBadgingEnabled 
		{
			get { return SmallIcon != null; }
		}

		public bool IsCustomThemeEnabled 
		{ 
			get { return Theme != BandTheme.Empty; }
		}
    }
}

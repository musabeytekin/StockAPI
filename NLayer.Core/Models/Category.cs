﻿using System;
namespace NLayer.Core
{
	public class Category:BaseEntity
	{
		public string? Name { get; set; }

        //Navigation Property
        public ICollection<ProductFeature>? Products { get; set; }
	}
}
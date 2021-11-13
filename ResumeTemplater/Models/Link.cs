﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeTemplater.Models
{
	// Additional Challenge
	public class Link
	{
		public string URLPath { get; set; }
		public LinkType Type { get; set; }
		//constructor
		public Link(LinkType linkType, string urlPath)
		{
			Type = linkType;
			URLPath = urlPath;
		}
	}

	public enum LinkType
	{
		GitHub,
		LinkedIn
	}
}

﻿using System;

namespace Ghasedak.Kavenegar.Json
{
 public class JsonString : JsonObject
 {
	public String Text { get; set; }

	public JsonString(String text)
	{
	 Text = text;
	}

	public JsonObject UpCast()
	{
	 JsonObject objectJ = this;
	 return objectJ;
	}


 }
}

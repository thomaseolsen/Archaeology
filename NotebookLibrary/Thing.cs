﻿using System;
using static Newtonsoft.Json.JsonConvert;

namespace NotebookLibrary
{
    public class Thing
    {
        public int Get(int left, int right) =>
            DeserializeObject<int>($"{left + right}");
    }
}

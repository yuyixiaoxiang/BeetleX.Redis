﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeetleX.Redis.Commands
{
    public class HSTRLEN : Command
    {
        public HSTRLEN(string key, string field)
        {
            Key = key;
            Field = field;
        }

        public string Key { get; set; }

        public string Field { get; set; }

        public override bool Read => true;

        public override string Name => "HSTRLEN";

        public override void OnExecute()
        {
            base.OnExecute();
            AddText(Key);
            AddText(Field);
        }
    }
}

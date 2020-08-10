﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Libs
{
    class KarolPendrive : Pendrive, IMemorable
    {
        public KarolPendrive(string data)
        {
            RecordData(data);
        }

        public void ErseData(string data)
        {
            throw new NotImplementedException();
        }

        public override void SetColor(string ColorName)
        {
            _color = ColorName;
        }
        public override string GetColor()
        {
            return _color;
        }
    }
}

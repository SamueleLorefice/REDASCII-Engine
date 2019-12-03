using System;
using System.Collections.Generic;
using System.Text;

namespace REDASCII_Engine {
    public interface ISystem {
        public void Run();
        public void Update();
        public void Stop();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardSmasher {
    interface ISmasher {
        bool IsSmashing();
        void StartSmashing();
        void StopSmashing();
        void Smash();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardSmasher.Smasher {
    interface ISmasher {
        bool IsSmashing();
        void StartSmashing();
        void StopSmashing();
    }
}

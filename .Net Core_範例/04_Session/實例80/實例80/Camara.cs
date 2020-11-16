using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例80
{
    public class Camara
    {
        private Guid _deviceID;

        private Camara()
        {
            _deviceID = Guid.NewGuid();
        }
        public Guid DeviceID => _deviceID;
        private static Camara _currentInstance = new Camara();
        public static Camara CurrentInstance => _currentInstance;
    }
}
